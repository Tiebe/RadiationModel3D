using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium134";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 133.93411d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium134() }, { 1.0d, new BetaParticle(1, 7133000.0) }, { 0.006d, new GammaParticle(50800.0, 0.02441) }, { 0.0144d, new GammaParticle(104700.0, 0.01184) }, { 0.0054d, new GammaParticle(107000.0, 0.01159) }, { 0.06d, new GammaParticle(110200.0, 0.01125) }, { 0.036000000000000004d, new GammaParticle(112300.0, 0.01104) }, { 0.018000000000000002d, new GammaParticle(116800.0, 0.01062) }, { 0.6d, new GammaParticle(118900.0, 0.01043) }, { 0.0138d, new GammaParticle(129500.0, 0.00957) }, { 0.0192d, new GammaParticle(141300.0, 0.00877) }, { 0.09d, new GammaParticle(161200.0, 0.00769) }, { 0.06d, new GammaParticle(185800.0, 0.00667) }, { 0.192d, new GammaParticle(218900.0, 0.00566) }, { 0.0108d, new GammaParticle(224000.0, 0.00554) }, { 0.078d, new GammaParticle(229100.0, 0.00541) }, { 0.0384d, new GammaParticle(257400.0, 0.00482) }, { 0.078d, new GammaParticle(280000.0, 0.00443) }, { 0.09d, new GammaParticle(300000.0, 0.00413) }, { 0.102d, new GammaParticle(380100.0, 0.00326) }, { 0.0528d, new GammaParticle(419000.0, 0.00296) }, { 0.036000000000000004d, new GammaParticle(768500.0, 0.00161) }, { 2.204d, new GammaParticle(511000.0, 0.00243) }, { 0.10986886500800001d, new GammaParticle(6109.0, 0.20295) }, { 0.1939832000943419d, new GammaParticle(38171.0, 0.03248) }, { 0.3521844591400543d, new GammaParticle(38724.0, 0.03202) }, { 0.10919008175465696d, new GammaParticle(43934.0, 0.02822) }, { 0.13725193276560377d, new GammaParticle(44387.0, 0.02793) }, { 0.028061851010946836d, new GammaParticle(44938.0, 0.02759) } } },

        };
    }
}
    