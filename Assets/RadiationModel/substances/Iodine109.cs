using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine109 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine109";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 108.93809d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9998600000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium108() }, { 1.0d, new ProtonParticle() } } },
            { 0.00014000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony105() }, { 1.0d, new AlphaParticle(4939002.09) } } },

        };
    }
}
    