using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium104m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium104m";
        public override double halfLife { get; } = 260.4d;
        public override double atomicWeight { get; } = 103.90678d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9987d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium104() }, { 5.8e-06d, new GammaParticle(31842.0, 0.03894) }, { 0.48277000000000003d, new GammaParticle(51422.5, 0.02411) }, { 0.0208d, new GammaParticle(77533.0, 0.01599) }, { 0.029900000000000003d, new GammaParticle(97113.7, 0.01277) }, { 0.06505680038754d, new GammaParticle(2892.0, 0.42871) }, { 0.19140175002223497d, new GammaParticle(20073.0, 0.06177) }, { 0.36236605456689697d, new GammaParticle(20215.0, 0.06133) }, { 0.09840539374860045d, new GammaParticle(22806.0, 0.05436) }, { 0.11474068911086813d, new GammaParticle(22957.0, 0.05401) }, { 0.016335295362267674d, new GammaParticle(23170.0, 0.05351) } } },
            { 0.0013d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium104() }, { 1.0d, new BetaParticle(-1, 1282400.0) }, { 1.43e-06d, new GammaParticle(332600.0, 0.00373) }, { 9.000000000000001e-07d, new GammaParticle(443500.0, 0.0028) }, { 3.8e-06d, new GammaParticle(451500.0, 0.00275) }, { 1.04e-06d, new GammaParticle(460500.0, 0.00269) }, { 7e-07d, new GammaParticle(479400.0, 0.00259) }, { 1.43e-06d, new GammaParticle(488500.0, 0.00254) }, { 1.17e-06d, new GammaParticle(497800.0, 0.00249) }, { 0.0013d, new GammaParticle(555810.0, 0.00223) }, { 4.0000000000000003e-07d, new GammaParticle(618000.0, 0.00201) }, { 8.000000000000001e-07d, new GammaParticle(623200.0, 0.00199) }, { 8.599999999999999e-06d, new GammaParticle(740690.0, 0.00167) }, { 9.4e-06d, new GammaParticle(758780.0, 0.00163) }, { 6.5e-05d, new GammaParticle(767780.0, 0.00161) }, { 3.8e-06d, new GammaParticle(777200.0, 0.0016) }, { 8.599999999999999e-06d, new GammaParticle(785880.0, 0.00158) }, { 6.499999999999999e-07d, new GammaParticle(839900.0, 0.00148) }, { 7.2000000000000005e-06d, new GammaParticle(858000.0, 0.00145) }, { 1.8000000000000001e-06d, new GammaParticle(923620.0, 0.00134) }, { 6.8e-06d, new GammaParticle(941720.0, 0.00132) }, { 4.2e-05d, new GammaParticle(1237050.0, 0.001) }, { 6.5e-06d, new GammaParticle(1238000.0, 0.001) }, { 3.8999999999999997e-07d, new GammaParticle(1264850.0, 0.00098) }, { 6.5e-06d, new GammaParticle(1341670.0, 0.00092) }, { 7.9e-06d, new GammaParticle(1526600.0, 0.00081) }, { 3.9e-06d, new GammaParticle(1625760.0, 0.00076) }, { 7e-08d, new GammaParticle(1708000.0, 0.00073) }, { 6.499999999999999e-07d, new GammaParticle(1793200.0, 0.00069) } } },

        };
    }
}
    