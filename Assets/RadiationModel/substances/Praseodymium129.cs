
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium129";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 128.92509d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium129() } },

        };
    }
}
    
    