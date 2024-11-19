using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium254m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium254m";
        public override double halfLife { get; } = 141480.0d;
        public override double atomicWeight { get; } = 254.08811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1172000.0), new Fermium254() } },
            { 0.03d, new List<RadioactiveSubstance> { new GammaParticle((80300.00001, 0.01544)), new Einsteinium254() } },
            { 0.0032d, new List<RadioactiveSubstance> { new AlphaParticle(7719502.09), new Berkelium250() } },
            { 0.0007599999999999999d, new List<RadioactiveSubstance> { new Californium254() } },
            { 0.00045d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    