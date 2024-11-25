using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum34 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum34";
        public override double halfLife { get; } = 0.0563d;
        public override double atomicWeight { get; } = 33.99678d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon34() }, { 1.0d, new BetaParticle(-1, 8497050.0) }, { 0.2652d, new GammaParticle(124200.0, 0.00998) }, { 0.03927d, new GammaParticle(590900.0, 0.0021) }, { 0.5304d, new GammaParticle(929000.0, 0.00133) }, { 0.01989d, new GammaParticle(1052800.0, 0.00118) }, { 0.032639999999999995d, new GammaParticle(1193340.0, 0.00104) }, { 0.01224d, new GammaParticle(1715400.0, 0.00072) }, { 0.02448d, new GammaParticle(2696400.0, 0.00046) }, { 0.51d, new GammaParticle(3326200.0, 0.00037) }, { 0.12240000000000001d, new GammaParticle(4257000.0, 0.00029) }, { 6.607256246448e-06d, new GammaParticle(118.0, 10.50714) }, { 0.00019874035039012613d, new GammaParticle(1740.0, 0.71255) }, { 0.00010010551449150653d, new GammaParticle(1740.0, 0.71255) }, { 8.666530081567348e-06d, new GammaParticle(1836.0, 0.6753) }, { 8.666530081567348e-06d, new GammaParticle(1836.0, 0.6753) } } },
            { 0.26d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon34() }, { 1.0d, new BetaParticle(-1, 8497050.0) }, { 0.2652d, new GammaParticle(124200.0, 0.00998) }, { 0.03927d, new GammaParticle(590900.0, 0.0021) }, { 0.5304d, new GammaParticle(929000.0, 0.00133) }, { 0.01989d, new GammaParticle(1052800.0, 0.00118) }, { 0.032639999999999995d, new GammaParticle(1193340.0, 0.00104) }, { 0.01224d, new GammaParticle(1715400.0, 0.00072) }, { 0.02448d, new GammaParticle(2696400.0, 0.00046) }, { 0.51d, new GammaParticle(3326200.0, 0.00037) }, { 0.12240000000000001d, new GammaParticle(4257000.0, 0.00029) }, { 6.607256246448e-06d, new GammaParticle(118.0, 10.50714) }, { 0.00019874035039012613d, new GammaParticle(1740.0, 0.71255) }, { 0.00010010551449150653d, new GammaParticle(1740.0, 0.71255) }, { 8.666530081567348e-06d, new GammaParticle(1836.0, 0.6753) }, { 8.666530081567348e-06d, new GammaParticle(1836.0, 0.6753) } } },

        };
    }
}
    