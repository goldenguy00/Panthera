﻿using Panthera.Base;
using System;

namespace Panthera.Abilities.Passives
{
    public class GodPower : PantheraAbility
    {

        public GodPower()
        {
            base.name = Utils.PantheraTokens.Get("ability_GodPowerName");
            base.abilityID = PantheraConfig.GodPower_AbilityID;
            base.type = AbilityType.special;
            base.icon = PantheraAssets.GodPowerAbility;
            base.maxLevel = 1;
            base.cooldown = 0;
            base.desc1 = String.Format(Utils.PantheraTokens.Get("ability_GodPowerDesc"), PantheraConfig.GodPower_unlockLevel);
            base.desc2 = null;
        }

    }
}
