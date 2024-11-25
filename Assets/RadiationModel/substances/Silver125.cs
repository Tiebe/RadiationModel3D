using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver125 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver125";
        public override double halfLife { get; } = 0.159d;
        public override double atomicWeight { get; } = 124.93073d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium125() }, { 1.0d, new BetaParticle(-1, 4414050.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    