using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese46 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese46";
        public override double halfLife { get; } = 0.0362d;
        public override double atomicWeight { get; } = 45.98667d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium46() }, { 1.0d, new BetaParticle(1, 12327950.0) }, { 0.016d, new GammaParticle(796100.0, 0.00156) }, { 0.25d, new GammaParticle(892500.0, 0.00139) }, { 0.26d, new GammaParticle(1094700.0, 0.00113) }, { 0.015d, new GammaParticle(1118000.0, 0.00111) }, { 0.54d, new GammaParticle(511000.0, 0.00243) }, { 1.566621e-06d, new GammaParticle(597.0, 2.07679) }, { 1.8560680400353492e-05d, new GammaParticle(5406.0, 0.22935) }, { 3.645782832518855e-05d, new GammaParticle(5415.0, 0.22896) }, { 7.4054912744579585e-06d, new GammaParticle(5966.0, 0.20782) }, { 7.4054912744579585e-06d, new GammaParticle(5966.0, 0.20782) } } },
            { 0.57d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium45() }, { 1.0d, new ProtonParticle() }, { 0.113d, new GammaParticle(329400.0, 0.00376) }, { 0.067d, new GammaParticle(410200.0, 0.00302) }, { 0.017d, new GammaParticle(475200.0, 0.00261) }, { 0.024d, new GammaParticle(739700.0, 0.00168) }, { 0.016d, new GammaParticle(796100.0, 0.00156) }, { 0.022000000000000002d, new GammaParticle(885700.0, 0.0014) }, { 0.015d, new GammaParticle(1118000.0, 0.00111) }, { 0.035d, new GammaParticle(1272600.0, 0.00097) }, { 0.049d, new GammaParticle(1322100.0, 0.00094) } } },

        };
    }
}
    