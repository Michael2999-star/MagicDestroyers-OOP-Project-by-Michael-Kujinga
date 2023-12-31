﻿using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const string DEFAULT_NAME = "Bob";

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();
               
        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.Strike();
        }

        public override void SpecialAttack()
        {
            this.Execute();
        }

        public override void Defend()
        {
            this.SkinHarden();
        }
    }
}
