using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium255";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 255.10692d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(233903216973.56) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    