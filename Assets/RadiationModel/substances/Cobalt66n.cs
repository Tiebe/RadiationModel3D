using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt66n : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt66n";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 65.94013d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00193), new Cobalt66() } },

        };
    }
}
    
    