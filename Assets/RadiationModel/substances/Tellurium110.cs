using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium110";
        public override double halfLife { get; } = 18.6d;
        public override double atomicWeight { get; } = 109.92246d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin110() }, { 1.0d, new BetaParticle(1, 6806000.0) } } },
            { 6.7e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin106() }, { 1.0d, new AlphaParticle(3721002.09) } } },

        };
    }
}
    