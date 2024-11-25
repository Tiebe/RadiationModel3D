using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium99";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 98.91667d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium99() }, { 1.0d, new BetaParticle(-1, 2359000.0) }, { 0.0021449999999999998d, new GammaParticle(28400.0, 0.04366) }, { 0.00066d, new GammaParticle(46100.0, 0.02689) }, { 0.02145d, new GammaParticle(55900.0, 0.02218) }, { 0.00010999999999999999d, new GammaParticle(74300.0, 0.01669) }, { 0.03025d, new GammaParticle(81800.0, 0.01516) }, { 0.0008799999999999999d, new GammaParticle(84400.0, 0.01469) }, { 0.000385d, new GammaParticle(86700.0, 0.0143) }, { 0.000495d, new GammaParticle(88800.0, 0.01396) }, { 0.00033d, new GammaParticle(113400.0, 0.01093) }, { 0.0017050000000000001d, new GammaParticle(114200.0, 0.01086) }, { 5.4999999999999995e-05d, new GammaParticle(165600.0, 0.00749) }, { 0.000495d, new GammaParticle(175200.0, 0.00708) }, { 0.053899999999999997d, new GammaParticle(178984.0, 0.00693) }, { 0.00033d, new GammaParticle(198000.0, 0.00626) }, { 0.00043999999999999996d, new GammaParticle(220900.0, 0.00561) }, { 0.00021999999999999998d, new GammaParticle(250400.0, 0.00495) }, { 0.00043999999999999996d, new GammaParticle(347500.0, 0.00357) }, { 0.00033d, new GammaParticle(363000.0, 0.00342) }, { 0.00055d, new GammaParticle(379200.0, 0.00327) }, { 0.00033d, new GammaParticle(384800.0, 0.00322) }, { 0.000605d, new GammaParticle(386500.0, 0.00321) }, { 0.07975d, new GammaParticle(387420.0, 0.0032) }, { 0.04675d, new GammaParticle(415093.0, 0.00299) }, { 0.00209d, new GammaParticle(429300.0, 0.00289) }, { 0.00033d, new GammaParticle(444500.0, 0.00279) }, { 0.10945d, new GammaParticle(461800.0, 0.00268) }, { 0.552d, new GammaParticle(469137.0, 0.00264) }, { 0.00066d, new GammaParticle(471100.0, 0.00263) }, { 0.0055000000000000005d, new GammaParticle(490200.0, 0.00253) }, { 0.00033d, new GammaParticle(499900.0, 0.00248) }, { 0.00825d, new GammaParticle(536700.0, 0.00231) }, { 0.0069299999999999995d, new GammaParticle(543600.0, 0.00228) }, { 0.4829d, new GammaParticle(546130.0, 0.00227) }, { 0.001045d, new GammaParticle(561400.0, 0.00221) }, { 0.0088d, new GammaParticle(575400.0, 0.00215) }, { 0.0055000000000000005d, new GammaParticle(581000.0, 0.00213) }, { 0.27225d, new GammaParticle(593994.0, 0.00209) }, { 0.00033d, new GammaParticle(600400.0, 0.00207) }, { 0.02035d, new GammaParticle(627900.0, 0.00197) }, { 0.02255d, new GammaParticle(650000.0, 0.00191) }, { 0.00066d, new GammaParticle(816700.0, 0.00152) }, { 0.0033550000000000003d, new GammaParticle(960000.0, 0.00129) }, { 0.00099d, new GammaParticle(1043400.0, 0.00119) }, { 0.00132d, new GammaParticle(1321000.0, 0.00094) }, { 0.00339314821924597d, new GammaParticle(2299.0, 0.5393) }, { 0.017639504160111574d, new GammaParticle(16521.0, 0.07505) }, { 0.03368889258997626d, new GammaParticle(16615.0, 0.07462) }, { 0.008716900769819267d, new GammaParticle(18694.0, 0.06632) }, { 0.010024435885292155d, new GammaParticle(18795.0, 0.06597) }, { 0.00130753511547289d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    