using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium142";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 141.96001d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium142() }, { 1.0d, new BetaParticle(1, 9655000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium141() }, { 1.0d, new ProtonParticle() } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium141() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    