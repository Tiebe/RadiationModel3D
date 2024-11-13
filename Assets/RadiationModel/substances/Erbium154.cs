
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium154";
        public override double halfLife { get; } = 223.8d;
        public override double atomicWeight { get; } = 153.93279d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium154() } },

            { 0.004699999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(), new Dysprosium150() } },

        };
    }
}
    
    