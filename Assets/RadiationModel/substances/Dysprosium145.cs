
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium145";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 144.93747d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium145() } },

        };
    }
}
    
    