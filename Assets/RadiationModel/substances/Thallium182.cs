using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium182";
        public override double halfLife { get; } = 1.9d;
        public override double atomicWeight { get; } = 181.98569d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10250000.0), new Mercury182() } },
            { 0.0049d, new List<RadioactiveSubstance> { new AlphaParticle(7571047.4), new Gold178() } },

        };
    }
}
    
    