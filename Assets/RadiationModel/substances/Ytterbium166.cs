using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium166";
        public override double halfLife { get; } = 204120.0d;
        public override double atomicWeight { get; } = 165.93388d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium166() }, { 0.1555d, new GammaParticle(82290.0, 0.01507) }, { 0.34354747500000005d, new GammaParticle(8215.0, 0.15092) }, { 0.39365160047457415d, new GammaParticle(49773.0, 0.02491) }, { 0.6950063567700815d, new GammaParticle(50742.0, 0.02443) }, { 0.22723574821852735d, new GammaParticle(57612.0, 0.02152) }, { 0.2863170427553445d, new GammaParticle(58257.0, 0.02128) }, { 0.05908129453681712d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    