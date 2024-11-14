using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium158";
        public override double halfLife { get; } = 89.4d;
        public override double atomicWeight { get; } = 157.93987d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2693000.0), new Thulium158() } },
            { 2.1e-05d, new List<RadioactiveSubstance> { new AlphaParticle(5190047.4), new Erbium154() } },

        };
    }
}
    
    