using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium48";
        public override double halfLife { get; } = 9.15150853263168e+26d;
        public override double atomicWeight { get; } = 47.95252d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium48() }, { 1.0d, new BetaParticle(-1, 2134041.0) }, { 1.0d, new BetaParticle(-1, 2134041.0) } } },
            { 0.74d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium48() }, { 1.0d, new BetaParticle(-1, 2134041.0) }, { 1.0d, new BetaParticle(-1, 2134041.0) } } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium48() }, { 1.0d, new BetaParticle(-1, 139566.0) } } },

        };
    }
}
    