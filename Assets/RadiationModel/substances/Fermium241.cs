using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium241";
        public override double halfLife { get; } = 0.00073d;
        public override double atomicWeight { get; } = 241.07431d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.14d, new List<RadioactiveSubstance> { new AlphaParticle(9877002.09), new Californium237() } },
            { 0.12d, new List<RadioactiveSubstance> { new BetaParticle(1, 5330000.0), new Einsteinium241() } },

        };
    }
}
    
    