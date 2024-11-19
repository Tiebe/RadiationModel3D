using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth210m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth210m";
        public override double halfLife { get; } = 95933134080000.0d;
        public override double atomicWeight { get; } = 209.98441d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6329702.09), new Thallium206() } },

        };
    }
}
    
    