using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium154m";
        public override double halfLife { get; } = 3.3d;
        public override double atomicWeight { get; } = 153.94165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.58d, new List<RadioactiveSubstance> { new AlphaParticle(6193002.09), new Holmium150() } },
            { 0.42d, new List<RadioactiveSubstance> { new BetaParticle(1, 8255000.0), new Erbium154() } },

        };
    }
}
    
    