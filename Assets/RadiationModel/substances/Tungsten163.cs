using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten163 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten163";
        public override double halfLife { get; } = 2.67d;
        public override double atomicWeight { get; } = 162.96252d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium163() }, { 1.0d, new BetaParticle(1, 7179500.0) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium159() }, { 1.0d, new AlphaParticle(6540002.09) } } },

        };
    }
}
    