
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium145";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 144.94727d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium145() } },

        };
    }
}
    
    