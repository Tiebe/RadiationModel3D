using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron49 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron49";
        public override double halfLife { get; } = 0.0647d;
        public override double atomicWeight { get; } = 48.97343d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium49() }, { 1.0d, new BetaParticle(1, 10290700.0) }, { 0.51d, new GammaParticle(261500.0, 0.00474) }, { 0.10300000000000001d, new GammaParticle(481900.0, 0.00257) }, { 0.237d, new GammaParticle(797100.0, 0.00156) }, { 0.078d, new GammaParticle(1278700.0, 0.00097) }, { 0.742d, new GammaParticle(511000.0, 0.00243) }, { 5.95408314e-07d, new GammaParticle(660.0, 1.87855) }, { 7.638513309297467e-06d, new GammaParticle(5888.0, 0.21057) }, { 1.4980414413213314e-05d, new GammaParticle(5899.0, 0.21018) }, { 3.0739122774892156e-06d, new GammaParticle(6512.0, 0.19039) }, { 3.0739122774892156e-06d, new GammaParticle(6512.0, 0.19039) } } },
            { 0.5670000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium48() }, { 1.0d, new BetaParticle(1, 474782051.736) }, { 1.0d, new ProtonParticle() }, { 0.52d, new GammaParticle(752200.0, 0.00165) }, { 0.031d, new GammaParticle(1105200.0, 0.00112) }, { 1.1260865394e-06d, new GammaParticle(597.0, 2.07679) }, { 1.3432252697937114e-05d, new GammaParticle(5406.0, 0.22935) }, { 2.638431093682403e-05d, new GammaParticle(5415.0, 0.22896) }, { 5.359309465238851e-06d, new GammaParticle(5966.0, 0.20782) }, { 5.359309465238851e-06d, new GammaParticle(5966.0, 0.20782) } } },

        };
    }
}
    