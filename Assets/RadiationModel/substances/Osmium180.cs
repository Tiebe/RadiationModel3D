using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium180";
        public override double halfLife { get; } = 1290.0d;
        public override double atomicWeight { get; } = 179.95238d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten180() }, { 1.0d, new BetaParticle(1, 2640099.99999) }, { 0.17d, new GammaParticle(20100.0, 0.06168) }, { 0.00126d, new GammaParticle(511000.0, 0.00243) }, { 0.34d, new GammaParticle(10063.0, 0.12321) }, { 0.11d, new GammaParticle(59718.0, 0.02076) }, { 0.19d, new GammaParticle(61141.0, 0.02028) }, { 0.06d, new GammaParticle(69395.0, 0.01787) }, { 0.08d, new GammaParticle(70206.0, 0.01766) }, { 0.018000000000000002d, new GammaParticle(71195.0, 0.01741) } } },

        };
    }
}
    