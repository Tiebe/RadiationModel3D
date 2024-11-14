using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium168";
        public override double halfLife { get; } = 8043840.0d;
        public override double atomicWeight { get; } = 167.93418d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1676830.0), new Erbium168() } },
            { 0.0001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 267470.0), new Ytterbium168() } },

        };
    }
}
    
    