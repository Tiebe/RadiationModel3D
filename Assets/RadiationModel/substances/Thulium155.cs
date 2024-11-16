using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium155";
        public override double halfLife { get; } = 21.6d;
        public override double atomicWeight { get; } = 154.93921d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9917d, new List<RadioactiveSubstance> { new BetaParticle(1, 5583000.0), new Erbium155() } },
            { 0.0083d, new List<RadioactiveSubstance> { new AlphaParticle(5594002.09), new Holmium151() } },

        };
    }
}
    
    