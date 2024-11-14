using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium108";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 107.92938d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new List<RadioactiveSubstance> { new BetaParticle(1, 6663000.0), new Antimony108() } },
            { 0.49d, new List<RadioactiveSubstance> { new AlphaParticle(4440047.4), new Tin104() } },

        };
    }
}
    
    