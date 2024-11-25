using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium152m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium152m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 151.95327d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium152() }, { 0.54d, new GammaParticle(139800.0, 0.00887) }, { 0.86d, new GammaParticle(312300.0, 0.00397) }, { 0.78d, new GammaParticle(347400.0, 0.00357) }, { 0.95d, new GammaParticle(358500.0, 0.00346) }, { 1.0d, new GammaParticle(1531200.0, 0.00081) }, { 0.035902494684d, new GammaParticle(8502.0, 0.14583) }, { 0.038910695429365226d, new GammaParticle(51354.0, 0.02414) }, { 0.06858927450972188d, new GammaParticle(52389.0, 0.02367) }, { 0.022514466344895245d, new GammaParticle(59481.0, 0.02084) }, { 0.028390742060912903d, new GammaParticle(60151.0, 0.02061) }, { 0.0058762757160176595d, new GammaParticle(60961.0, 0.02034) } } },

        };
    }
}
    