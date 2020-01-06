using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models.Calculator;
using Persona4GoldenHelper.Service;
using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Tests
{
    public class FusionServiceTests
    {
        ApplicationDbContext Context;

        IFusion FusionService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "PersonaDatabase").Options;

            Context = new ApplicationDbContext(options);

            FusionService = new FusionService(Context, new NullLogger<FusionService>());
        }

        [Test]
        public void GetAllArcanas()
        {
            // arrange
            Context.ArcanaRanks.Add(new ArcanaRank()
            {
                ArcanaName = "Fool"
            });

            Context.ArcanaRanks.Add(new ArcanaRank()
            {
                ArcanaName = "Magician"
            });

            Context.SaveChanges();

            // act
            var arcanas = FusionService.GetAllArcanas();

            // assert
            Assert.AreEqual(2, arcanas.Count);
        }

        [Test]
        public void GetAllArcana2FusionResults()
        {
            // arrange
            Context.ArcanaFusionResults.Add(new ArcanaFusionResult()
            {
                FusionType = FusionType.Arcana2,
                SourceArcanas = new List<FusionArcana>()
                {
                    new FusionArcana()
                    {
                        ArcanaName = "sdf"
                    },
                    new FusionArcana()
                    {
                        ArcanaName = "sdgf"
                    }
                },
                ResultArcana = "gfd"
            });

            Context.ArcanaFusionResults.Add(new ArcanaFusionResult()
            {
                FusionType = FusionType.Arcana2,
                SourceArcanas = new List<FusionArcana>()
                {
                    new FusionArcana()
                    {
                        ArcanaName = "sdf"
                    },
                    new FusionArcana()
                    {
                        ArcanaName = "sdgf"
                    }
                },
                ResultArcana = "gfd"
            });

            Context.SaveChanges();

            // act
            var arcanaResults = FusionService.GetAllArcana2FusionResults();
                          
            // assert
            Assert.AreEqual(2, arcanaResults.Count);
        }

        [Test]
        public void GetAllArcana3FusionResults()
        {
            // arrange
            Context.ArcanaFusionResults.Add(new ArcanaFusionResult()
            {
                FusionType = FusionType.Arcana3,
                SourceArcanas = new List<FusionArcana>()
                {
                    new FusionArcana()
                    {
                        ArcanaName = "sdf"
                    },
                    new FusionArcana()
                    {
                        ArcanaName = "sdgf"
                    }
                },
                ResultArcana = "gfd"
            });

            Context.ArcanaFusionResults.Add(new ArcanaFusionResult()
            {
                FusionType = FusionType.Arcana3,
                SourceArcanas = new List<FusionArcana>()
                {
                    new FusionArcana()
                    {
                        ArcanaName = "sdf"
                    },
                    new FusionArcana()
                    {
                        ArcanaName = "sdgf"
                    }
                },
                ResultArcana = "gfd"
            });

            Context.SaveChanges();

            // act
            var arcanaResults = FusionService.GetAllArcana3FusionResults();

            // assert
            Assert.AreEqual(2, arcanaResults.Count);
        }

        [Test]
        public void GetAllSpecialFusionResults()
        {
            // arrange
            Context.SpecialFusionResults.Add(new SpecialFusionResult()
            {
                SourcePersonas = new List<FusionPersona>()
                {
                    new FusionPersona()
                    {
                        PersonaName = "sdf"
                    },
                    new FusionPersona()
                    {
                        PersonaName = "adfg"
                    }
                },
                ResultPersona = "erg"
            });

            Context.SpecialFusionResults.Add(new SpecialFusionResult()
            {
                SourcePersonas = new List<FusionPersona>()
                {
                    new FusionPersona()
                    {
                        PersonaName = "sdf"
                    },
                    new FusionPersona()
                    {
                        PersonaName = "adfg"
                    }
                },
                ResultPersona = "erg"
            });

            Context.SaveChanges();

            // act
            var specialResults = FusionService.GetAllSpecialFusionResults();

            // assert
            Assert.AreEqual(2, specialResults.Count);
        }
    }
}
