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
    /// <summary>Shadow API tests.</summary>
    public class ShadowServiceTests
    {
        /*********
        ** Fields
        *********/
        /// <summary>The database context.</summary>
        private ApplicationDbContext Context;

        /// <summary>Provides shadow apis.</summary>
        private IShadow ShadowService;


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

            ShadowService = new ShadowService(Context, new NullLogger<ShadowService>());
        }

        /// <summary>Test for get all api.</summary>
        [Test]
        public void GetAll()
        {
            // arrange
            Context.Shadows.Add(new Shadow()
            {
                Name = "asdfgafg",
                HP = 1,
                SP = 4,
                Level = 5,
                Yen = "34",
                Type = ShadowType.Normal,
                Exp = 345,
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
                Skills = new List<ShadowSkill>()
                {
                    new ShadowSkill()
                    {
                        Name = "REFLECT physical"
                    },
                    new ShadowSkill()
                    {
                        Name = "ReFlEcT WiNd"
                    }
                }
            });

            Context.Shadows.Add(new Shadow()
            {
                Name = "sadfghsdfg",
                HP = 1,
                SP = 4,
                Level = 5,
                Yen = "34",
                Type = ShadowType.Normal,
                Exp = 345,
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
                Skills = new List<ShadowSkill>()
                {
                    new ShadowSkill()
                    {
                        Name = "REFLECT physical"
                    },
                    new ShadowSkill()
                    {
                        Name = "ReFlEcT WiNd"
                    }
                }
            });

            Context.SaveChanges();

            // act
            var shadows = ShadowService.GetAll();

            // assert
            Assert.AreEqual(2, shadows.Count);
        }

        /// <summary>Test for get by name api.</summary>
        /// <param name="name">The name of the shadow to get.</param>
        [TestCase("WoRlD bAlAnCe")]
        public void GetByName(string name)
        {
            // arrange
            Context.Shadows.Add(new Shadow()
            {
                Name = "World Balance",
                HP = 1,
                SP = 4,
                Level = 5,
                Yen = "34",
                Type = ShadowType.Normal,
                Exp = 345,
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
                Skills = new List<ShadowSkill>()
                {
                    new ShadowSkill()
                    {
                        Name = "REFLECT physical"
                    },
                    new ShadowSkill()
                    {
                        Name = "ReFlEcT WiNd"
                    }
                }
            });

            Context.Shadows.Add(new Shadow()
            {
                Name = "asedgafgd",
                HP = 1,
                SP = 4,
                Level = 5,
                Yen = "34",
                Type = ShadowType.Normal,
                Exp = 345,
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
                Skills = new List<ShadowSkill>()
                {
                    new ShadowSkill()
                    {
                        Name = "REFLECT physical"
                    },
                    new ShadowSkill()
                    {
                        Name = "ReFlEcT WiNd"
                    }
                }
            });

            Context.SaveChanges();

            // act
            var shadows = ShadowService.GetByName(name);

            // assert
            Assert.AreEqual(1, shadows.Count);
        }
    }
}
