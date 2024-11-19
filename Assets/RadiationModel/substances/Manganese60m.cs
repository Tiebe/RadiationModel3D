using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese60m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese60m";
        public override double halfLife { get; } = 1.77d;
        public override double atomicWeight { get; } = 59.94343d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.885d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8717000.0), new Iron60() } },
            { 0.115d, new List<RadioactiveSubstance> { new GammaParticle((271900.0, 0.00456)), new Manganese60() } },

        };
    }
}
    
    