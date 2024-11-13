
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium154";
        public override double halfLife { get; } = 705.6d;
        public override double atomicWeight { get; } = 153.93061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.99981d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium154() } },

            { 0.00018999999999999998d, new List<RadioactiveSubstance> { new AlphaParticle(), new Terbium150() } },

        };
    }
}
    
    