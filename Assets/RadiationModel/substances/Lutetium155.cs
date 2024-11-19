using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium155";
        public override double halfLife { get; } = 0.068d;
        public override double atomicWeight { get; } = 154.95433d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(6824002.09), new Thulium151() } },
            { 0.1d, new List<RadioactiveSubstance> { new BetaParticle(1, 7958000.0), new Ytterbium155() } },

        };
    }
}
    
    