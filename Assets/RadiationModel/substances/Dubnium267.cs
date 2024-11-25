using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium267";
        public override double halfLife { get; } = 4740.0d;
        public override double atomicWeight { get; } = 267.12239d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(245095556215.22) } } },

        };
    }
}
    