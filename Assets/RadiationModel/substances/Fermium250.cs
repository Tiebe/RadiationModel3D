using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium250";
        public override double halfLife { get; } = 1800.0d;
        public override double atomicWeight { get; } = 250.07952d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium246() }, { 1.0d, new AlphaParticle(8578802.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium250() } } },
            { 6.9e-05d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    