using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium290";
        public override double halfLife { get; } = 80.0d;
        public override double atomicWeight { get; } = 290.19187d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10877002.09), new Copernicium286() } },
            { 0.5d, new List<RadioactiveSubstance> { new BetaParticle(1, 410000.0), new Nihonium290() } },

        };
    }
}
    
    