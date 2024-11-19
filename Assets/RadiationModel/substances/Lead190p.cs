using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead190p : RadioactiveSubstance
    {
        public override string name { get; } = "Lead190p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 189.98093d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00047, 2658000.0), new Lead190() } },

        };
    }
}
    
    