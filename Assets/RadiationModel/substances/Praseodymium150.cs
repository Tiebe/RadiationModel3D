
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium150";
        public override double halfLife { get; } = 6.19d;
        public override double atomicWeight { get; } = 149.92668d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium150() } },

        };
    }
}
    
    