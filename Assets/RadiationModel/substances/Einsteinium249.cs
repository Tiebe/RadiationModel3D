using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium249";
        public override double halfLife { get; } = 6132.0d;
        public override double atomicWeight { get; } = 249.07641d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1457300.0), new Californium249() } },
            { 0.005699999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(7961247.4), new Berkelium245() } },

        };
    }
}
    
    