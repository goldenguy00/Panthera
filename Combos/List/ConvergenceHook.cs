﻿using Panthera.GUI;
using Panthera.Utils;

namespace Panthera.Combos.List
{
    public class ConvergenceHook : PantheraCombo
    {

        public ConvergenceHook()
        {
            ComboSkill comboSkill1 = new ComboSkill(Panthera.PantheraCharacter.CharacterSkills.GetSkillByID(PantheraConfig.Rip_SkillID), KeysBinder.KeysEnum.Skill1);
            ComboSkill comboSkill2 = new ComboSkill(Panthera.PantheraCharacter.CharacterSkills.GetSkillByID(PantheraConfig.ConvergenceHook_SkillID), KeysBinder.KeysEnum.Skill2, 0, KeysBinder.KeysEnum.Backward);
            comboSkillsList.Add(comboSkill1);
            comboSkillsList.Add(comboSkill2);
            comboID = PantheraConfig.ConvergenceHook_CombosID;
            name = PantheraTokens.Get("combo_ConvergenceHookName");
        }

    }
}
