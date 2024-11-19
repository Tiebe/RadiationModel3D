using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium148m";
        public override double halfLife { get; } = 120.6d;
        public override double atomicWeight { get; } = 147.92221d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4950100.0), new Neodymium148() } },
            { 0.36d, new List<RadioactiveSubstance> { new GammaParticle(0.0161, 77000.0), new Praseodymium148() } },

        };
    }
}
    
    