
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium129m";
        public override double halfLife { get; } = 2.6d;
        public override double atomicWeight { get; } = 128.93309d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium129() } },

        };
    }
}
    
    