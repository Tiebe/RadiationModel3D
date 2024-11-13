
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium48";
        public override double halfLife { get; } = 1380110.4d;
        public override double atomicWeight { get; } = 47.95225d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium48() } },

        };
    }
}
    
    