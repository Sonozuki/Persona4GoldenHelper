using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Service;
using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Tests
{
    /// <summary>Persona API tests.</summary>
    public class PersonaServiceTests
    {
        /*********
        ** Fields
        *********/
        /// <summary>The database context.</summary>
        private ApplicationDbContext Context;

        /// <summary>Provides persona apis.</summary>
        private IPersona PersonaService;


        /*********
        ** Public Methods
        *********/
        /// <summary>Setup initial test state.</summary>
        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "PersonaDatabase").Options;

            Context = new ApplicationDbContext(options);

            PersonaService = new PersonaService(Context, new NullLogger<PersonaService>());
        }

        /// <summary>Test for get all api.</summary>
        [Test]
        public void GetAll()
        {
            // arrange
            Context.Personas.Add(new Persona()
            {
                Name = "name1",
                Arcana = "arcana",
                Level = 23,
                Ultimate = false,
                NewGame = false,
                Stats = new Stats()
                {
                    Strength = 1,
                    Magic = 2,
                    Endurance = 3,
                    Agility = 4,
                    Luck = 5
                },
                Elements = new Elements()
                {
                    Physical = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<PersonaSkill>()
                {
                    new PersonaSkill()
                    {
                        Name = "absorb physical",
                        LevelRequired = 5
                    },
                    new PersonaSkill()
                    {
                        Name = "AbSoRb WiNd",
                        LevelRequired = 78
                    }
                }
            });

            Context.Personas.Add(new Persona()
            {
                Name = "name2",
                Arcana = "arcana",
                Level = 23,
                Ultimate = false,
                NewGame = false,
                Stats = new Stats()
                {
                    Strength = 1,
                    Magic = 2,
                    Endurance = 3,
                    Agility = 4,
                    Luck = 5
                },
                Elements = new Elements()
                {
                    Physical = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<PersonaSkill>()
                {
                    new PersonaSkill()
                    {
                        Name = "absorb physical",
                        LevelRequired = 5
                    },
                    new PersonaSkill()
                    {
                        Name = "AbSoRb WiNd",
                        LevelRequired = 78
                    }
                }
            });

            Context.SaveChanges();

            // act
            var personas = PersonaService.GetAll();

            // assert
            Assert.AreEqual(2, personas.Count);
        }

        /// <summary>Test for get by name api.</summary>
        /// <param name="name">The name of the shadow to get.</param>
        [TestCase("Helel")]
        public void GetByName(string name)
        {
            // arrange
            Context.Personas.Add(new Persona()
            {
                Name = "HeLeL",
                Arcana = "arcana",
                Level = 23,
                Ultimate = false,
                NewGame = false,
                Stats = new Stats()
                {
                    Strength = 1,
                    Magic = 2,
                    Endurance = 3,
                    Agility = 4,
                    Luck = 5
                },
                Elements = new Elements()
                {
                    Physical = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<PersonaSkill>()
                {
                    new PersonaSkill()
                    {
                        Name = "absorb physical",
                        LevelRequired = 5
                    },
                    new PersonaSkill()
                    {
                        Name = "AbSoRb WiNd",
                        LevelRequired = 78
                    }
                }
            });

            Context.Personas.Add(new Persona()
            {
                Name = "Trumpeter",
                Arcana = "arcana",
                Level = 23,
                Ultimate = false,
                NewGame = false,
                Stats = new Stats()
                {
                    Strength = 1,
                    Magic = 2,
                    Endurance = 3,
                    Agility = 4,
                    Luck = 5
                },
                Elements = new Elements()
                {
                    Physical = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<PersonaSkill>()
                {
                    new PersonaSkill()
                    {
                        Name = "absorb physical",
                        LevelRequired = 5
                    },
                    new PersonaSkill()
                    {
                        Name = "AbSoRb WiNd",
                        LevelRequired = 78
                    }
                }
            });

            Context.SaveChanges();

            // act
            var persona = PersonaService.GetByName(name);

            // assert
            Assert.NotNull(persona);
        }
    }
}
