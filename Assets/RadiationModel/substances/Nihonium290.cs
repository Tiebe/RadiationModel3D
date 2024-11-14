using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium290";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 290.19143d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10405047.4), new Roentgenium286() } },
            { 0.5d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    