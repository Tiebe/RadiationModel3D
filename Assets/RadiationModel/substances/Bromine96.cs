using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine96 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine96";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 95.95898d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton96() }, { 1.0d, new BetaParticle(-1, 7436000.0) } } },
            { 0.276d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton96() }, { 1.0d, new BetaParticle(-1, 7436000.0) } } },

        };
    }
}
    