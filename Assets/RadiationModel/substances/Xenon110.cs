using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon110 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon110";
        public override double halfLife { get; } = 0.093d;
        public override double atomicWeight { get; } = 109.94426d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium106() }, { 1.0d, new AlphaParticle(4897002.09) } } },
            { 0.36d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium110() }, { 1.0d, new BetaParticle(1, 10155000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    