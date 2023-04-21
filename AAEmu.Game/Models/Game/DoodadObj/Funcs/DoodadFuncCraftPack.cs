﻿using AAEmu.Game.Models.Game.DoodadObj.Templates;
using AAEmu.Game.Models.Game.Units;

namespace AAEmu.Game.Models.Game.DoodadObj.Funcs
{
    public class DoodadFuncCraftPack : DoodadFuncTemplate
    {
        // doodad_funcs
        public uint CraftPackId { get; set; }
        
        public override void Use(BaseUnit caster, Doodad owner, uint skillId, int nextPhase = 0)
        {
            _log.Trace("DoodadFuncCraftPack");

        }
    }
}
