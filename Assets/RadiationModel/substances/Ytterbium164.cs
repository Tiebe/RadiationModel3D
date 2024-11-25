using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium164";
        public override double halfLife { get; } = 4548.0d;
        public override double atomicWeight { get; } = 163.9345d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium164() }, { 0.0009750000000000001d, new GammaParticle(37573.0, 0.033) }, { 0.009250000000000001d, new GammaParticle(40928.0, 0.03029) }, { 0.00045d, new GammaParticle(94050.0, 0.01318) }, { 0.000325d, new GammaParticle(97340.0, 0.01274) }, { 0.00017500000000000003d, new GammaParticle(135000.0, 0.00918) }, { 0.000475d, new GammaParticle(154180.0, 0.00804) }, { 0.001d, new GammaParticle(164450.0, 0.00754) }, { 0.000725d, new GammaParticle(187800.0, 0.0066) }, { 0.0008d, new GammaParticle(190800.0, 0.0065) }, { 0.000325d, new GammaParticle(199100.0, 0.00623) }, { 0.000225d, new GammaParticle(324260.0, 0.00382) }, { 0.000225d, new GammaParticle(327430.0, 0.00379) }, { 0.0003d, new GammaParticle(358000.0, 0.00346) }, { 0.0017000000000000001d, new GammaParticle(362840.0, 0.00342) }, { 0.00035000000000000005d, new GammaParticle(390600.0, 0.00317) }, { 0.0025d, new GammaParticle(390600.0, 0.00317) }, { 0.00075d, new GammaParticle(402100.0, 0.00308) }, { 0.0008749999999999999d, new GammaParticle(415790.0, 0.00298) }, { 0.000325d, new GammaParticle(419500.0, 0.00296) }, { 0.00155d, new GammaParticle(444600.0, 0.00279) }, { 0.0022500000000000003d, new GammaParticle(446700.0, 0.00278) }, { 0.000185d, new GammaParticle(475900.0, 0.00261) }, { 5e-05d, new GammaParticle(491300.0, 0.00252) }, { 0.000125d, new GammaParticle(534000.0, 0.00232) }, { 0.0007000000000000001d, new GammaParticle(543600.0, 0.00228) }, { 0.000675d, new GammaParticle(546900.0, 0.00227) }, { 0.00035000000000000005d, new GammaParticle(549800.0, 0.00226) }, { 0.00025d, new GammaParticle(571500.0, 0.00217) }, { 0.000125d, new GammaParticle(581600.0, 0.00213) }, { 0.000825d, new GammaParticle(589120.0, 0.0021) }, { 7.5e-05d, new GammaParticle(601800.0, 0.00206) }, { 0.001875d, new GammaParticle(638120.0, 0.00194) }, { 0.003075d, new GammaParticle(675410.0, 0.00184) }, { 0.00065d, new GammaParticle(695200.0, 0.00178) }, { 0.00015d, new GammaParticle(732700.0, 0.00169) }, { 0.00042500000000000003d, new GammaParticle(887300.0, 0.0014) }, { 0.0006d, new GammaParticle(928700.0, 0.00134) }, { 0.000325d, new GammaParticle(1019200.0, 0.00122) }, { 0.19d, new GammaParticle(8215.0, 0.15092) }, { 0.222d, new GammaParticle(49773.0, 0.02491) }, { 0.391d, new GammaParticle(50742.0, 0.02443) }, { 0.128d, new GammaParticle(57612.0, 0.02152) }, { 0.161d, new GammaParticle(58257.0, 0.02128) }, { 0.0333d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    