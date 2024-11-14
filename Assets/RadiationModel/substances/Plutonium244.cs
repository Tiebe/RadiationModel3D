using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium244";
        public override double halfLife { get; } = 2565580197600000.0d;
        public override double atomicWeight { get; } = 244.0642d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9987699999999999d, new List<RadioactiveSubstance> { new AlphaParticle(5685547.4), new Uranium240() } },
            { 0.00123d, new List<RadioactiveSubstance> {  } },
            { 7.3e-11d, new List<RadioactiveSubstance> { new BetaParticle(-2, 1354200.0), new Curium244() } },

        };
    }
}
    
    