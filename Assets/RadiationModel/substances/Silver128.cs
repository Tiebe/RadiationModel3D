using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver128 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver128";
        public override double halfLife { get; } = 0.058d;
        public override double atomicWeight { get; } = 127.94127d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium128() }, { 1.0d, new BetaParticle(-1, 6264000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    