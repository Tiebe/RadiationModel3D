using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus42 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus42";
        public override double halfLife { get; } = 0.0485d;
        public override double atomicWeight { get; } = 42.00117d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 18727700.0), new Sulfur42() } },

        };
    }
}
    
    