using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver107m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver107m";
        public override double halfLife { get; } = 44.3d;
        public override double atomicWeight { get; } = 106.90519d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01332, 93100.0), new Silver107() } },

        };
    }
}
    
    