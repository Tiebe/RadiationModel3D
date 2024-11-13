
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium158";
        public override double halfLife { get; } = 0.099d;
        public override double atomicWeight { get; } = 157.96077d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium158() } },

        };
    }
}
    
    