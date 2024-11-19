using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead200m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead200m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 199.97416d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2183000.0, 0.00057)), new Lead200() } },

        };
    }
}
    
    