using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten160 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten160";
        public override double halfLife { get; } = 0.091d;
        public override double atomicWeight { get; } = 159.96851d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium156() }, { 1.0d, new AlphaParticle(7087002.09) } } },
            { 0.13d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium160() }, { 1.0d, new BetaParticle(1, 8304500.0) } } },

        };
    }
}
    