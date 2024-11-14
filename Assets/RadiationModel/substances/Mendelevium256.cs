using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium256";
        public override double halfLife { get; } = 4662.0d;
        public override double atomicWeight { get; } = 256.09389d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9079999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 1975000.0), new Fermium256() } },
            { 0.092d, new List<RadioactiveSubstance> { new AlphaParticle(8765047.4), new Einsteinium252() } },
            { 0.03d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    