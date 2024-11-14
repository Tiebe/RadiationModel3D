using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium282";
        public override double halfLife { get; } = 0.14d;
        public override double atomicWeight { get; } = 282.17577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11805047.4), new Roentgenium278() } },

        };
    }
}
    
    