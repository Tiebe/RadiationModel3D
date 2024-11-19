using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver96n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver96n";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 95.93339d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2460000.0, 0.0005)), new Silver96() } },

        };
    }
}
    
    