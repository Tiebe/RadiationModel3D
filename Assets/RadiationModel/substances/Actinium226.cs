using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium226";
        public override double halfLife { get; } = 105732.0d;
        public override double atomicWeight { get; } = 226.0261d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1111000.0), new Thorium226() } },
            { 0.17d, new List<RadioactiveSubstance> { new Radium226() } },
            { 6e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6528002.09), new Francium222() } },

        };
    }
}
    
    