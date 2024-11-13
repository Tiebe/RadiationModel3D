
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium143";
        public override double halfLife { get; } = 118940.4d;
        public override double atomicWeight { get; } = 142.91239d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium143() } },

        };
    }
}
    
    