using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron52m : RadioactiveSubstance
    {
        public override string name { get; } = "Iron52m";
        public override double halfLife { get; } = 45.9d;
        public override double atomicWeight { get; } = 51.95559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99979d, new List<RadioactiveSubstance> { new BetaParticle(1, 9339960.0), new Manganese52() } },
            { 0.00021d, new List<RadioactiveSubstance> { new GammaParticle(0.00018, 6960670.0), new Iron52() } },

        };
    }
}
    
    