using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium163";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 162.94711d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium163() }, { 1.0d, new BetaParticle(1, 5012500.0) } } },
            { 1e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium159() }, { 1.0d, new AlphaParticle(5162002.09) } } },

        };
    }
}
    