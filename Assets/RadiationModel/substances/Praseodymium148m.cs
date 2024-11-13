
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

            { 0.64d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium148() } },

            { 0.36d, new List<RadioactiveSubstance> { new GammaParticle(), new Praseodymium148() } },

        };
    }
}
    
    