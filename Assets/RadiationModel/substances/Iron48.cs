using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron48 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron48";
        public override double halfLife { get; } = 0.0455d;
        public override double atomicWeight { get; } = 47.98067d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium48() }, { 1.0d, new BetaParticle(1, 12405500.0) }, { 0.72d, new GammaParticle(89900.0, 0.01379) }, { 0.63d, new GammaParticle(313300.0, 0.00396) }, { 0.3d, new GammaParticle(2633500.0, 0.00047) }, { 1.724d, new GammaParticle(511000.0, 0.00243) }, { 0.00019694578382200003d, new GammaParticle(660.0, 1.87855) }, { 0.002537980028669659d, new GammaParticle(5888.0, 0.21057) }, { 0.004977407390997566d, new GammaParticle(5899.0, 0.21018) }, { 0.0010213411503327758d, new GammaParticle(6512.0, 0.19039) }, { 0.0010213411503327758d, new GammaParticle(6512.0, 0.19039) } } },
            { 0.153d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium47() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    