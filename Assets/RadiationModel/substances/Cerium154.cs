
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium154";
        public override double halfLife { get; } = 0.722d;
        public override double atomicWeight { get; } = 153.94394d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium154() } },

        };
    }
}
    
    