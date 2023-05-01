﻿using Panthera.Base;
using Panthera.Components;
using RoR2.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace Panthera.SkillsPassive
{
    internal class WindWalker
    {

        public static void Create()
        {
            // Create the Skill //
            PantheraSkill skill = new PantheraSkill();
            skill.skillID = PantheraConfig.WindWalker_SkillID;
            skill.name = "WIND_WALKER_ABILITY_NAME";
            skill.desc = "WIND_WALKER_ABILITY_DESC";
            skill.icon = Assets.WindWalkerAbility;
            skill.iconPrefab = Assets.PassiveSkillPrefab;
            skill.type = PantheraSkill.SkillType.passive;
            skill.associatedSkill = typeof(WindWalker);

            // Save this Skill //
            PantheraSkill.SkillDefsList.Add(skill.skillID, skill);
        }

    }
}
