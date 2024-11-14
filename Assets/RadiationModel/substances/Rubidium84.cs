using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium84";
        public override double halfLife { get; } = 2835648.0d;
        public override double atomicWeight { get; } = 83.91438d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.961d, new List<RadioactiveSubstance> { new BetaParticle(1, 2680345.0), new Krypton84() } },
            { 0.039d, new List<RadioactiveSubstance> { new BetaParticle(-1, 890600.0), new Strontium84() } },

        };
    }
}
    
    