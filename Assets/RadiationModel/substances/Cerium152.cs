
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium152";
        public override double halfLife { get; } = 1.42d;
        public override double atomicWeight { get; } = 151.93668d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium152() } },

        };
    }
}
    
    