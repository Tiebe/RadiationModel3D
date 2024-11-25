using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon23 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon23";
        public override double halfLife { get; } = 37.25d;
        public override double atomicWeight { get; } = 22.99447d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium23() }, { 1.0d, new BetaParticle(-1, 2187901.75) }, { 0.32899999999999996d, new GammaParticle(440500.0, 0.00281) }, { 0.01d, new GammaParticle(1636600.0, 0.00076) }, { 0.00101d, new GammaParticle(2076700.0, 0.0006) }, { 0.000269d, new GammaParticle(2541300.0, 0.00049) }, { 0.000378d, new GammaParticle(2981700.0, 0.00042) }, { 1.1938791981138901e-07d, new GammaParticle(1041.0, 1.19101) }, { 2.373989258528316e-07d, new GammaParticle(1041.0, 1.19101) } } },

        };
    }
}
    