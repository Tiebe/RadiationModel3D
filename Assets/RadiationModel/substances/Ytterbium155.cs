using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium155";
        public override double halfLife { get; } = 1.793d;
        public override double atomicWeight { get; } = 154.94578d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new AlphaParticle(6358047.4), new Erbium151() } },
            { 0.11d, new List<RadioactiveSubstance> { new BetaParticle(1, 6123000.0), new Thulium155() } },

        };
    }
}
    
    