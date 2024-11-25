using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium86";
        public override double halfLife { get; } = 0.226d;
        public override double atomicWeight { get; } = 85.94697d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic86() }, { 1.0d, new BetaParticle(-1, 4781000.0) } } },
            { 0.45d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic86() }, { 1.0d, new BetaParticle(-1, 4781000.0) } } },

        };
    }
}
    