using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine38 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine38";
        public override double halfLife { get; } = 2233.8d;
        public override double atomicWeight { get; } = 37.96801d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon38() }, { 1.0d, new BetaParticle(-1, 2458355.0) }, { 0.0002d, new GammaParticle(1209400.0, 0.00103) }, { 0.32899999999999996d, new GammaParticle(1642680.0, 0.00075) }, { 0.44d, new GammaParticle(2167400.0, 0.00057) }, { 0.0002d, new GammaParticle(2398100.0, 0.00052) }, { 0.000259d, new GammaParticle(3810010.0, 0.00033) }, { 7.000000000000001e-05d, new GammaParticle(3936100.0, 0.00031) }, { 2.4e-08d, new GammaParticle(265.0, 4.67865) }, { 3.35e-07d, new GammaParticle(2956.0, 0.41943) }, { 6.629999999999999e-07d, new GammaParticle(2958.0, 0.41915) }, { 1.08e-07d, new GammaParticle(3190.0, 0.38867) }, { 1.08e-07d, new GammaParticle(3190.0, 0.38867) } } },

        };
    }
}
    