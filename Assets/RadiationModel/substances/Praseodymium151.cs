using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium151";
        public override double halfLife { get; } = 18.9d;
        public override double atomicWeight { get; } = 150.92831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4163200.0), new Neodymium151() } },

        };
    }
}
    
    