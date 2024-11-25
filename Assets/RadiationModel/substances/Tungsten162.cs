using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten162 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten162";
        public override double halfLife { get; } = 1.19d;
        public override double atomicWeight { get; } = 161.9635d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5479999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium162() }, { 1.0d, new BetaParticle(1, 7584500.0) } } },
            { 0.452d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium158() }, { 1.0d, new AlphaParticle(6700002.09) } } },

        };
    }
}
    