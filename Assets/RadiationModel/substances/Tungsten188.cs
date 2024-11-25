using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten188 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten188";
        public override double halfLife { get; } = 6028992.0d;
        public override double atomicWeight { get; } = 187.95849d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium188() }, { 1.0d, new BetaParticle(-1, 174450.0) }, { 0.0011200000000000001d, new GammaParticle(63583.0, 0.0195) }, { 2.5e-05d, new GammaParticle(85320.0, 0.01453) }, { 1.3e-05d, new GammaParticle(105853.0, 0.01171) }, { 6.7e-05d, new GammaParticle(141758.8, 0.00875) }, { 9.900000000000001e-05d, new GammaParticle(207847.7, 0.00597) }, { 0.0023499999999999997d, new GammaParticle(227073.1, 0.00546) }, { 0.00416d, new GammaParticle(290682.8, 0.00427) }, { 0.00147d, new GammaParticle(10063.0, 0.12321) }, { 0.00057d, new GammaParticle(59718.0, 0.02076) }, { 0.00098d, new GammaParticle(61141.0, 0.02028) }, { 0.00032599999999999996d, new GammaParticle(69395.0, 0.01787) }, { 0.00042d, new GammaParticle(70206.0, 0.01766) }, { 8.999999999999999e-05d, new GammaParticle(71195.0, 0.01741) } } },

        };
    }
}
    