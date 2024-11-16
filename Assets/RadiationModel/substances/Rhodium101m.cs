using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium101m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium101m";
        public override double halfLife { get; } = 375235.2d;
        public override double atomicWeight { get; } = 100.90633d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9279999999999999d, new List<RadioactiveSubstance> { new Ruthenium101() } },
            { 0.07200000000000001d, new List<RadioactiveSubstance> { new GammaParticle(0.0079), new Rhodium101() } },

        };
    }
}
    
    