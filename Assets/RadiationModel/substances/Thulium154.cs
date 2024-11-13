
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium154";
        public override double halfLife { get; } = 8.1d;
        public override double atomicWeight { get; } = 153.94157d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.54d, new List<RadioactiveSubstance> { new AlphaParticle(), new Holmium150() } },

            { 0.46d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium154() } },

        };
    }
}
    
    