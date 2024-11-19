using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead190m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead190m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 189.98089d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00047, 2615000.0), new Lead190() } },

        };
    }
}
    
    