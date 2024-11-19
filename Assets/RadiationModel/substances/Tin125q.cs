using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin125q : RadioactiveSubstance
    {
        public override string name { get; } = "Tin125q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 124.91061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00047, 2623500.0), new Tin125() } },

        };
    }
}
    
    