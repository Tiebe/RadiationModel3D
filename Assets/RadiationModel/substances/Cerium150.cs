
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium150";
        public override double halfLife { get; } = 6.05d;
        public override double atomicWeight { get; } = 149.93038d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium150() } },

        };
    }
}
    
    