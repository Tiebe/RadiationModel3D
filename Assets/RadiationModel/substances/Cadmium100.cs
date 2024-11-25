using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium100";
        public override double halfLife { get; } = 49.1d;
        public override double atomicWeight { get; } = 99.92035d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium100() }, { 1.0d, new BetaParticle(1, 5509200.0) }, { 0.0021d, new GammaParticle(111400.0, 0.01113) }, { 0.00092d, new GammaParticle(117000.0, 0.0106) }, { 0.037000000000000005d, new GammaParticle(124700.0, 0.00994) }, { 0.067d, new GammaParticle(139710.0, 0.00887) }, { 0.0014000000000000002d, new GammaParticle(148500.0, 0.00835) }, { 0.0005899999999999999d, new GammaParticle(164300.0, 0.00755) }, { 0.005d, new GammaParticle(173200.0, 0.00716) }, { 0.046d, new GammaParticle(178950.0, 0.00693) }, { 0.036000000000000004d, new GammaParticle(220650.0, 0.00562) }, { 0.0025700000000000002d, new GammaParticle(270370.0, 0.00459) }, { 0.021099999999999997d, new GammaParticle(288130.0, 0.0043) }, { 0.0011d, new GammaParticle(302800.0, 0.00409) }, { 0.021099999999999997d, new GammaParticle(347230.0, 0.00357) }, { 0.0022d, new GammaParticle(361400.0, 0.00343) }, { 0.046d, new GammaParticle(368700.0, 0.00336) }, { 0.046d, new GammaParticle(428200.0, 0.0029) }, { 0.0076d, new GammaParticle(441100.0, 0.00281) }, { 0.0009d, new GammaParticle(500000.0, 0.00248) }, { 0.055d, new GammaParticle(507250.0, 0.00244) }, { 0.004d, new GammaParticle(525500.0, 0.00236) }, { 0.002d, new GammaParticle(535000.0, 0.00232) }, { 0.052000000000000005d, new GammaParticle(567900.0, 0.00218) }, { 0.0026d, new GammaParticle(573100.0, 0.00216) }, { 0.063d, new GammaParticle(582500.0, 0.00213) }, { 0.005d, new GammaParticle(629400.0, 0.00197) }, { 0.0068000000000000005d, new GammaParticle(650000.0, 0.00191) }, { 0.0021d, new GammaParticle(680600.0, 0.00182) }, { 0.035d, new GammaParticle(688300.0, 0.0018) }, { 0.00066d, new GammaParticle(707500.0, 0.00175) }, { 0.0172d, new GammaParticle(730770.0, 0.0017) }, { 0.00073d, new GammaParticle(796600.0, 0.00156) }, { 0.047d, new GammaParticle(809830.0, 0.00153) }, { 0.001d, new GammaParticle(852000.0, 0.00146) }, { 0.005600000000000001d, new GammaParticle(870400.0, 0.00142) }, { 0.0022d, new GammaParticle(909200.0, 0.00136) }, { 0.66d, new GammaParticle(936550.0, 0.00132) }, { 0.011200000000000002d, new GammaParticle(940900.0, 0.00132) }, { 0.0009d, new GammaParticle(974300.0, 0.00127) }, { 0.0139d, new GammaParticle(990900.0, 0.00125) }, { 0.009899999999999999d, new GammaParticle(1024100.0, 0.00121) }, { 0.009899999999999999d, new GammaParticle(1057500.0, 0.00117) }, { 0.0009d, new GammaParticle(1074200.0, 0.00115) }, { 0.0165d, new GammaParticle(1140790.0, 0.00109) }, { 0.002d, new GammaParticle(1156800.0, 0.00107) }, { 0.0191d, new GammaParticle(1197120.0, 0.00104) }, { 0.004699999999999999d, new GammaParticle(1309300.0, 0.00095) }, { 0.0019d, new GammaParticle(1338200.0, 0.00093) }, { 0.047d, new GammaParticle(1377520.0, 0.0009) }, { 0.0046d, new GammaParticle(1944700.0, 0.00064) }, { 1.17252d, new GammaParticle(511000.0, 0.00243) }, { 0.0262d, new GammaParticle(3218.0, 0.38528) }, { 0.098d, new GammaParticle(21990.0, 0.05638) }, { 0.184d, new GammaParticle(22163.0, 0.05594) }, { 0.051100000000000007d, new GammaParticle(25030.0, 0.04953) }, { 0.06d, new GammaParticle(25211.0, 0.04918) }, { 0.0089d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    