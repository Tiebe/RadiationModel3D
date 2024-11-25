using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium165";
        public override double halfLife { get; } = 0.071d;
        public override double atomicWeight { get; } = 164.97665d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten161() }, { 1.0d, new AlphaParticle(7357002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten165() }, { 1.0d, new BetaParticle(1, 8555500.0) } } },

        };
    }
}
    