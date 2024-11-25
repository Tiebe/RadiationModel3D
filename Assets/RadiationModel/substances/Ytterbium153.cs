using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium153";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 152.94937d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium153() }, { 1.0d, new BetaParticle(1, 6653500.0) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium149() }, { 1.0d, new AlphaParticle(5179002.09) } } },
            { 8e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium152() }, { 1.0d, new BetaParticle(1, 472417051.73601) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    