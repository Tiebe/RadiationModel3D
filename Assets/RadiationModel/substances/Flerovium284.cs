using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium284";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 284.18119d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(260985725974.25) } } },

        };
    }
}
    