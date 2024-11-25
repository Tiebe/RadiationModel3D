using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium152";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 151.96412d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium152() }, { 1.0d, new BetaParticle(1, 9150000.0) }, { 0.7395d, new GammaParticle(312600.0, 0.00397) }, { 0.7565000000000001d, new GammaParticle(358700.0, 0.00346) }, { 0.85d, new GammaParticle(1531400.0, 0.00081) }, { 1.62d, new GammaParticle(511000.0, 0.00243) }, { 0.01914291620871d, new GammaParticle(8502.0, 0.14583) }, { 0.020754720516388825d, new GammaParticle(51354.0, 0.02414) }, { 0.036585088165677467d, new GammaParticle(52389.0, 0.02367) }, { 0.012009074919059243d, new GammaParticle(59481.0, 0.02084) }, { 0.015143443472933706d, new GammaParticle(60151.0, 0.02061) }, { 0.0031343685538744626d, new GammaParticle(60961.0, 0.02034) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium151() }, { 1.0d, new BetaParticle(1, 474423051.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    