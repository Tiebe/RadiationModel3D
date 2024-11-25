using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium147";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 146.94996d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium147() }, { 1.0d, new BetaParticle(1, 8793000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium146() }, { 1.0d, new BetaParticle(1, 473719551.73601) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    