using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium160";
        public override double halfLife { get; } = 36.1d;
        public override double atomicWeight { get; } = 159.94603d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium160() }, { 1.0d, new BetaParticle(1, 5015000.0) } } },
            { 1e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium156() }, { 1.0d, new AlphaParticle(5161002.09) } } },

        };
    }
}
    