using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium260";
        public override double halfLife { get; } = 2401920.0d;
        public override double atomicWeight { get; } = 260.10365d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },
            { 0.05d, new List<RadioactiveSubstance> { new AlphaParticle(7957002.09), new Einsteinium256() } },
            { 0.05d, new List<RadioactiveSubstance> { new Fermium260() } },
            { 0.035d, new List<RadioactiveSubstance> { new BetaParticle(-1, 940000.0), new Nobelium260() } },

        };
    }
}
    
    