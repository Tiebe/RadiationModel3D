using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead208m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead208m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 207.98191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((4895199.99999, 0.00025)), new Lead208() } },

        };
    }
}
    
    