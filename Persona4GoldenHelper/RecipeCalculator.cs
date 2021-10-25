using Persona4GoldenHelper.Models;
using System.Net.Http.Json;

namespace Persona4GoldenHelper
{
    /// <summary>Handles calculating recipes for personas.</summary>
    public static class RecipeCalculator
    {
        /*********
        ** Fields
        *********/
        /// <summary>The arcana fusion results to use when calculating either a two persona fusion or the intermediate parent in a three persona fusion, ordered by result arcana.</summary>
        private static Dictionary<string, List<ArcanaFusionResult>> Arcana2FusionResultsByResultArcana;

        /// <summary>The arcana fusion results to use when calculating a three persona fusion, ordered by result arcana.</summary>
        private static Dictionary<string, List<ArcanaFusionResult>> Arcana3FusionResultsByResultArcana;

        /// <summary>The persona fusion results of personas with special recipes.</summary>
        private static List<SpecialFusionResult> SpecialFusionResults;

        /// <summary>All the personas.</summary>
        private static List<Persona> Personas;

        /// <summary>All the personas, ordered by arcana.</summary>
        private static Dictionary<string, List<Persona>> PersonasByArcana = new();

        /// <summary>The order of the arcanas.</summary>
        /// <remarks>This is used for determining the rank of an arcana, required for some cases in three persona fusions.</remarks>
        private static List<string> ArcanaOrder;


        /*********
        ** Public Methods
        *********/
        /// <summary>Calculates the recipes of a persona.</summary>
        /// <param name="httpClient">The http client to use to retrieve data form the server.</param>
        /// <param name="targetPersona">The persona whose recipes should get calculated.</param>
        /// <returns>The calculates recipes for <paramref name="targetPersona"/>.</returns>
        public static async Task<List<Recipe>> CalculateRecipes(HttpClient httpClient, Persona targetPersona)
        {
            // load required data
            if (ArcanaOrder == null)
                ArcanaOrder = await httpClient.GetFromJsonAsync<List<string>>("data/arcana-order.json");

            if (Arcana2FusionResultsByResultArcana == null || Arcana3FusionResultsByResultArcana == null)
            {
                var arcanaFusionResults = await httpClient.GetFromJsonAsync<List<ArcanaFusionResult>>("data/arcana-fusion-results.json");

                var arcana2FusionResults = arcanaFusionResults.Where(fusionResult => fusionResult.FusionType == FusionType.Arcana2).ToList();
                var arcana3FusionResults = arcanaFusionResults.Where(fusionResult => fusionResult.FusionType == FusionType.Arcana3).ToList();

                Arcana2FusionResultsByResultArcana = new();
                Arcana3FusionResultsByResultArcana = new();
                foreach (var arcana in ArcanaOrder)
                {
                    Arcana2FusionResultsByResultArcana[arcana] = arcana2FusionResults.Where(fusionResult => fusionResult.ResultArcana == arcana).ToList();
                    Arcana3FusionResultsByResultArcana[arcana] = arcana3FusionResults.Where(fusionResult => fusionResult.ResultArcana == arcana).ToList();
                }
            }
            if (SpecialFusionResults == null)
                SpecialFusionResults = await httpClient.GetFromJsonAsync<List<SpecialFusionResult>>("data/special-fusion-results.json");
            if (Personas == null)
                Personas = await httpClient.GetFromJsonAsync<List<Persona>>("data/personas.json");

            foreach (var arcana in ArcanaOrder)
                PersonasByArcana[arcana] = GetPersonasByArcana(arcana);

            // ensure persona isn't a special persona (meaning it only has a single predefined recipe)
            if (targetPersona.IsSpecial)
                return new() { CalculateSpecialRecipe(targetPersona) };

            // calculate recipes
            var recipes = new List<Recipe>();
            recipes.AddRange(Calculate2ParentPersonaRecipes(targetPersona));
            recipes.AddRange(Calculate3ParentPersonaRecipes(targetPersona));
            return recipes.OrderBy(recipe => recipe.Cost).Distinct().ToList();

            // Retrieves all the personas in a specified arcana.
            List<Persona> GetPersonasByArcana(string arcana) =>
                Personas.Where(persona => persona.Arcana == arcana).ToList();
        }


        /*********
        ** Private Methods
        *********/
        /// <summary>Calculates the special recipe to create a specified persona.</summary>
        /// <param name="targetPersona">The persona to calculate the special recipe of.</param>
        /// <returns>The calculated recipe.</returns>
        private static Recipe CalculateSpecialRecipe(Persona targetPersona) =>
            new(SpecialFusionResults.FirstOrDefault(fusionResult => fusionResult.ResultPersona == targetPersona.Name)?.SourcePersonas
                .Select(personaName => Personas.First(persona => persona.Name == personaName))
                .ToList());

        /// <summary>Calculates all the recipes that have two parent personas for a specified persona.</summary>
        /// <param name="targetPersona">The persona to calculate the recipes of.</param>
        /// <returns>The calculated recipes.</returns>
        private static List<Recipe> Calculate2ParentPersonaRecipes(Persona targetPersona)
        {
            var recipes = new List<Recipe>();

            // get all arcana fusions that result in the target persona arcana
            var arcanaFusions = Arcana2FusionResultsByResultArcana[targetPersona.Arcana];

            // get all possible persona from both arcanas and try to fuse them all, then check if the output persona if the target persona
            foreach (var arcanaFusion in arcanaFusions)
            {
                // try every possible combination of personas from the two arcanas of the fusion
                var firstPersonas = PersonasByArcana[arcanaFusion.SourceArcanas[0]];
                var secondPersonas = PersonasByArcana[arcanaFusion.SourceArcanas[1]];

                for (var i = 0; i < firstPersonas.Count; i++)
                {
                    var firstPersona = firstPersonas[i];

                    for (var j = 0; j < secondPersonas.Count; j++)
                    {
                        var secondPersona = secondPersonas[j];

                        // if the parent arcanas are the same, ensure the personas are different and don't check each match twice (i.e. Izanagi + Yomotsu-Shikome & Yomotsu-Shikome + Izanagi)
                        if (arcanaFusion.SourceArcanas[0] == arcanaFusion.SourceArcanas[1] && j <= i)
                            continue;

                        // calculate the result from the fusion
                        var resultPersona = Fuse2Personas(targetPersona.Arcana, firstPersona, secondPersona);
                        if (resultPersona == null)
                            continue;

                        if (resultPersona.Name != targetPersona.Name)
                            continue;

                        recipes.Add(new(new[] { firstPersona, secondPersona }));
                    }
                }
            }

            return recipes;
        }

        /// <summary>Calculates all the recipes that have three parent personas for a specified persona.</summary>
        /// <param name="targetPersona">The persona to calculate the recipes of.</param>
        /// <returns>The calculated recipes.</returns>
        private static List<Recipe> Calculate3ParentPersonaRecipes(Persona targetPersona)
        {
            var recipes = new List<Recipe>();

            // get all arcana fusions that result in the target persona arcana
            var arcanaFusions = Arcana3FusionResultsByResultArcana[targetPersona.Arcana];

            // for each arcana fusion, consider either arcana to be from the 'intermediate parent'
            foreach (var arcanaFusion in arcanaFusions)
            {
                recipes.AddRange(CalculateRecipesForIntemediateArcana(targetPersona, arcanaFusion.SourceArcanas[0], arcanaFusion.SourceArcanas[1]));
                recipes.AddRange(CalculateRecipesForIntemediateArcana(targetPersona, arcanaFusion.SourceArcanas[1], arcanaFusion.SourceArcanas[0]));
            }

            return recipes;
        }

        /// <summary>Calculates all the recipes between two arcanas, one being the intermediate from a three persona fusion.</summary>
        /// <param name="targetPersona">The persona to calculate the recipes of.</param>
        /// <param name="intermediateArcana">The intermediate arcana to use when calculating the recipes.</param>
        /// <param name="otherArcana">The non intermediate arcana to use when calculating the recipes.</param>
        /// <returns>The calculated recipes.</returns>
        private static List<Recipe> CalculateRecipesForIntemediateArcana(Persona targetPersona, string intermediateArcana, string otherArcana)
        {
            var recipes = new List<Recipe>();

            // get all arcana fusions that result in the intermediate arcana
            var intermediateArcanaFusions = Arcana2FusionResultsByResultArcana[intermediateArcana];

            // get all the third personas of the calculation
            // these are the third personas because the intermediate arcana is calculated from the two lower level personas
            var thirdPersonas = PersonasByArcana[otherArcana];

            // get all possible persona from all three arcanas (the two fused to make the intermediate arcana and the 'otherArcana' parameter) and try to fuse them all, then check if the output persona if the target persona
            foreach (var intermediateArcanaFusion in intermediateArcanaFusions)
            {
                var firstPersonas = PersonasByArcana[intermediateArcanaFusion.SourceArcanas[0]];
                var secondPersonas = PersonasByArcana[intermediateArcanaFusion.SourceArcanas[1]];

                foreach (var firstPersona in firstPersonas)
                    foreach (var secondPersona in secondPersonas)
                        foreach (var thirdPersona in thirdPersonas)
                        {
                            if (!Is3PersonaFusionValid(firstPersona, secondPersona, thirdPersona))
                                continue;

                            // calculate the result from the fusion
                            var resultPersona = Fuse3Personas(targetPersona.Arcana, firstPersona, secondPersona, thirdPersona);
                            if (resultPersona == null)
                                continue;

                            if (resultPersona.Name != targetPersona.Name)
                                continue;

                            recipes.Add(new(new[] { firstPersona, secondPersona, thirdPersona }));
                        }
            }

            return recipes;
        }

        /// <summary>Fuses two personas.</summary>
        /// <param name="destinationArcana">The arcana of the child persona.</param>
        /// <param name="persona1">The first parent persona.</param>
        /// <param name="persona2">The second parent persona.</param>
        /// <returns>The resulting persona from the fusion, if one exists; otherwise, <see langword="null"/>.</returns>
        private static Persona Fuse2Personas(string destinationArcana, Persona persona1, Persona persona2)
        {
            var personas = PersonasByArcana[destinationArcana];

            // find target persona based off of rank
            var averageRank = (persona1.Level + persona2.Level) / 2 + 1; // TODO: this uses base level, not current level
            var index = personas.FindIndex(persona => persona.Level >= averageRank);
            if (index == -1) // if the average rank is higher than the rank of the highest persona, clamp it
                index = personas.Count - 1;

            // down grade persona until result is valid (the result persona isn't a special fusion and isn't a parent)
            while (index >= 0 && (personas[index].IsSpecial || personas[index] == persona1 || personas[index] == persona2))
                index--;

            if (index < 0)
                return null;
            return personas[index];
        }

        /// <summary>Fuses three personas.</summary>
        /// <param name="destinationArcana">The arcana of the child persona.</param>
        /// <param name="persona1">The first parent persona.</param>
        /// <param name="persona2">The second parent persona.</param>
        /// <param name="persona3">The third parent persona.</param>
        /// <returns>The resulting persona from the fusion, if one exists; otherwise, <see langword="null"/>.</returns>
        private static Persona Fuse3Personas(string destinationArcana, Persona persona1, Persona persona2, Persona persona3)
        {
            var personas = PersonasByArcana[destinationArcana];

            // find target persona based off of rank
            var averageRank = (persona1.Level + persona2.Level + persona3.Level) / 3 + 5; // TODO: this uses base level, not current level
            var index = personas.FindIndex(persona => persona.Level >= averageRank);
            if (index == -1) // if the average rank is higher than the rank of the highest persona, clamp it
                index = personas.Count - 1;

            // if fusing three personas from the same arcana, keep upgrading result until the result isn't one of the parents
            if (persona1.Arcana == destinationArcana && persona2.Arcana == destinationArcana && persona3.Arcana == destinationArcana)
                while (index <= personas.Count - 1 && (personas[index] == persona1 || personas[index] == persona2 || personas[index] == persona3))
                    index++;

            // upgrade persona until result is valid (the result persona isn't a special fusion and isn't a parent)
            while (index <= personas.Count - 1 && (personas[index].IsSpecial || personas[index] == persona1 || personas[index] == persona2 || personas[index] == persona3))
                index++;

            if (index > personas.Count - 1)
                return null;
            return personas[index];
        }

        /// <summary>Determines whether a three persona fusion is valid.</summary>
        /// <param name="persona1">The first persona.</param>
        /// <param name="persona2">The second persona.</param>
        /// <param name="persona3">The third persona.</param>
        /// <returns><see langword="true"/>, if the fusion is valid; otherwise, <see langword="false"/>.</returns>
        private static bool Is3PersonaFusionValid(Persona persona1, Persona persona2, Persona persona3)
        {
            if (persona1 == persona2 || persona1 == persona3 || persona2 == persona3)
                return false;

            // ensure the third persona is the highest level
            if (persona1.Level > persona3.Level || persona2.Level > persona3.Level)
                return false;

            // if the third persona has the same level as another persona, ensure it has a lower arcana rank
            if (persona1.Level == persona3.Level)
                return GetArcanaRank(persona1.Arcana) > GetArcanaRank(persona3.Arcana);
            if (persona2.Level == persona3.Level)
                return GetArcanaRank(persona2.Arcana) > GetArcanaRank(persona3.Arcana);

            return true;
        }

        /// <summary>Retrieves the rank of a specified arcana.</summary>
        /// <param name="arcana">The arcana whose rank to retrieve.</param>
        /// <returns>The rank of <paramref name="arcana"/>.</returns>
        private static int GetArcanaRank(string arcana) => ArcanaOrder.IndexOf(arcana);
    }
}
