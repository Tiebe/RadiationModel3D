using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium107";
        public override double halfLife { get; } = 1302.0d;
        public override double atomicWeight { get; } = 106.90675d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium107() }, { 1.0d, new BetaParticle(-1, 754350.0) }, { 0.0005d, new GammaParticle(80060.0, 0.01549) }, { 8.999999999999999e-05d, new GammaParticle(96600.0, 0.01283) }, { 0.0002d, new GammaParticle(102400.0, 0.01211) }, { 0.0052d, new GammaParticle(115650.0, 0.01072) }, { 0.0007000000000000001d, new GammaParticle(175300.0, 0.00707) }, { 0.0004d, new GammaParticle(198700.0, 0.00624) }, { 0.001d, new GammaParticle(219400.0, 0.00565) }, { 0.0021d, new GammaParticle(232370.0, 0.00534) }, { 0.0028000000000000004d, new GammaParticle(266060.0, 0.00466) }, { 0.017d, new GammaParticle(277580.0, 0.00447) }, { 0.0073d, new GammaParticle(288280.0, 0.0043) }, { 0.66d, new GammaParticle(302770.0, 0.00409) }, { 0.048d, new GammaParticle(312210.0, 0.00397) }, { 0.0226d, new GammaParticle(321840.0, 0.00385) }, { 0.0227d, new GammaParticle(348210.0, 0.00356) }, { 0.0040999999999999995d, new GammaParticle(357840.0, 0.00346) }, { 0.0191d, new GammaParticle(367310.0, 0.00338) }, { 0.006500000000000001d, new GammaParticle(381860.0, 0.00325) }, { 0.08800000000000001d, new GammaParticle(392470.0, 0.00316) }, { 0.00026d, new GammaParticle(431700.0, 0.00287) }, { 0.0051d, new GammaParticle(451880.0, 0.00274) }, { 0.0012d, new GammaParticle(471200.0, 0.00263) }, { 0.0003d, new GammaParticle(511700.0, 0.00242) }, { 0.0002d, new GammaParticle(521200.0, 0.00238) }, { 0.00078d, new GammaParticle(554400.0, 0.00224) }, { 0.0115d, new GammaParticle(567700.0, 0.00218) }, { 0.00032d, new GammaParticle(643900.0, 0.00193) }, { 0.0222d, new GammaParticle(670050.0, 0.00185) }, { 0.00012d, new GammaParticle(696700.0, 0.00178) }, { 0.00075d, new GammaParticle(709500.0, 0.00175) }, { 0.00013d, new GammaParticle(720400.0, 0.00172) }, { 0.00013d, new GammaParticle(753800.0, 0.00164) }, { 0.00089d, new GammaParticle(789900.0, 0.00157) }, { 0.00015d, new GammaParticle(836500.0, 0.00148) }, { 0.00025d, new GammaParticle(845400.0, 0.00147) }, { 0.00037d, new GammaParticle(863400.0, 0.00144) }, { 0.00010999999999999999d, new GammaParticle(1101900.0, 0.00113) }, { 0.00024d, new GammaParticle(1120000.0, 0.00111) }, { 0.00039d, new GammaParticle(1148500.0, 0.00108) }, { 0.000219338704d, new GammaParticle(3053.0, 0.40611) }, { 0.0008074858379051997d, new GammaParticle(21020.0, 0.05898) }, { 0.0015255730925849231d, new GammaParticle(21177.0, 0.05855) }, { 0.00041855476026485196d, new GammaParticle(23904.0, 0.05187) }, { 0.0004897090695098768d, new GammaParticle(24070.0, 0.05151) }, { 7.115430924502484e-05d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    