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

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium151() }, { 1.0d, new AlphaParticle(6824002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium155() }, { 1.0d, new BetaParticle(1, 7040500.0) } } },

        };
    }
}
    