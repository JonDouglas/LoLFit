﻿using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class SummonerSpellDto
    {
        public List<double> Cooldown { get; set; }
        public string CooldownBurn { get; set; }
        public List<int> Cost { get; set; }
        public string CostBurn { get; set; }
        public string CostType { get; set; }
        public string Description { get; set; }
        public List<List<double>> Effect { get; set; }
        public List<string> EffectBurn { get; set; }
        public int Id { get; set; }
        public ImageDto Image { get; set; }
        public string Key { get; set; }
        public LevelTipDto LevelTip { get; set; }
        public int Maxrank { get; set; }
        public List<string> Modes { get; set; } 
        public string Name { get; set; }
        public List<object> Range { get; set; }
        public string RangeBurn { get; set; }
        public string Resource { get; set; }
        public string SanitizedDescription { get; set; }
        public string SanitizedTooltip { get; set; }
        public int SummonerLevel { get; set; }
        public string Tooltip { get; set; }
        public List<SpellVarsDto> Vars { get; set; }
    }
}
