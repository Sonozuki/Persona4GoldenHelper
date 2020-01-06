using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Service;
using System;
using System.Collections.Generic;
using System.Text;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Tests
{
    public class ShadowServiceTests
    {
        ApplicationDbContext Context;

        IShadow ShadowService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "PersonaDatabase").Options;

            Context = new ApplicationDbContext(options);

            ShadowService = new ShadowService(Context, new NullLogger<ShadowService>());
        }

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
