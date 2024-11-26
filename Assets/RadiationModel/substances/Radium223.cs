using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium223";
        public override double halfLife { get; } = 987552.0d;
        public override double atomicWeight { get; } = 223.0185d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon219() }, { 1.0d, new AlphaParticle(7000902.09) }, { 2.33e-07d, new GammaParticle(4413.0, 0.28095) }, { 0.00016856d, new GammaParticle(9987.0, 0.12415) }, { 0.00019866000000000003d, new GammaParticle(14400.0, 0.0861) }, { 1.0836e-06d, new GammaParticle(31980.0, 0.03877) }, { 7.224e-05d, new GammaParticle(69500.0, 0.01784) }, { 3.6722e-05d, new GammaParticle(70900.0, 0.01749) }, { 9.03e-06d, new GammaParticle(102200.0, 0.01213) }, { 6.02e-05d, new GammaParticle(103200.0, 0.01201) }, { 0.000119196d, new GammaParticle(104230.0, 0.0119) }, { 0.000229362d, new GammaParticle(106780.0, 0.01161) }, { 6.02e-05d, new GammaParticle(108500.0, 0.01143) }, { 0.000522536d, new GammaParticle(110856.0, 0.01118) }, { 0.00010234d, new GammaParticle(114700.0, 0.01081) }, { 0.01304534d, new GammaParticle(122319.0, 0.01014) }, { 5.418e-05d, new GammaParticle(131600.0, 0.00942) }, { 2.6488e-05d, new GammaParticle(138300.0, 0.00896) }, { 0.0347354d, new GammaParticle(144235.0, 0.0086) }, { 6.02e-05d, new GammaParticle(147200.0, 0.00842) }, { 0.0602d, new GammaParticle(154208.0, 0.00804) }, { 0.007380520000000001d, new GammaParticle(158635.0, 0.00782) }, { 4.1538e-05d, new GammaParticle(165800.0, 0.00748) }, { 0.00015778420000000002d, new GammaParticle(175600.0, 0.00706) }, { 0.00042742d, new GammaParticle(177300.0, 0.00699) }, { 0.0016091459999999999d, new GammaParticle(179540.0, 0.00691) }, { 2.9497999999999998e-05d, new GammaParticle(199300.0, 0.00622) }, { 0.00029919399999999997d, new GammaParticle(221320.0, 0.0056) }, { 9.632e-05d, new GammaParticle(246200.0, 0.00504) }, { 0.00037444400000000004d, new GammaParticle(249300.0, 0.00497) }, { 0.000636314d, new GammaParticle(251600.0, 0.00493) }, { 0.000500262d, new GammaParticle(255200.0, 0.00486) }, { 5.418e-05d, new GammaParticle(255700.0, 0.00485) }, { 6.622e-05d, new GammaParticle(260400.0, 0.00476) }, { 0.133042d, new GammaParticle(269463.0, 0.0046) }, { 7.224e-06d, new GammaParticle(270300.0, 0.00459) }, { 1.204e-05d, new GammaParticle(286000.0, 0.00434) }, { 0.00148694d, new GammaParticle(288180.0, 0.0043) }, { 0.036421d, new GammaParticle(323871.0, 0.00383) }, { 0.00202272d, new GammaParticle(328380.0, 0.00378) }, { 0.0007555099999999999d, new GammaParticle(334010.0, 0.00371) }, { 0.0260064d, new GammaParticle(338282.0, 0.00367) }, { 0.0017458d, new GammaParticle(342870.0, 0.00362) }, { 4.3946e-05d, new GammaParticle(355500.0, 0.00349) }, { 2.9497999999999998e-05d, new GammaParticle(355700.0, 0.00349) }, { 0.000264278d, new GammaParticle(362052.0, 0.00342) }, { 0.000186018d, new GammaParticle(362900.0, 0.00342) }, { 0.000134246d, new GammaParticle(368560.0, 0.00336) }, { 0.00434644d, new GammaParticle(371676.0, 0.00334) }, { 0.0008307599999999999d, new GammaParticle(372900.0, 0.00332) }, { 5.5384e-05d, new GammaParticle(376100.0, 0.0033) }, { 1.8662e-05d, new GammaParticle(382800.0, 0.00324) }, { 5.1772e-05d, new GammaParticle(387700.0, 0.0032) }, { 5.2374e-05d, new GammaParticle(390100.0, 0.00318) }, { 0.00023417799999999998d, new GammaParticle(430600.0, 0.00288) }, { 0.000312438d, new GammaParticle(432120.0, 0.00287) }, { 0.01218448d, new GammaParticle(445033.0, 0.00279) }, { 6.5618e-05d, new GammaParticle(487500.0, 0.00254) }, { 1.7458e-05d, new GammaParticle(490800.0, 0.00253) }, { 1.3846e-05d, new GammaParticle(500000.0, 0.00248) }, { 4.214e-06d, new GammaParticle(510000.0, 0.00243) }, { 1.7458e-05d, new GammaParticle(523200.0, 0.00237) }, { 0.000660394d, new GammaParticle(527611.0, 0.00235) }, { 1.806e-05d, new GammaParticle(532900.0, 0.00233) }, { 2.9497999999999998e-05d, new GammaParticle(537600.0, 0.00231) }, { 1.6856e-05d, new GammaParticle(542000.0, 0.00229) }, { 2.0468e-05d, new GammaParticle(545800.0, 0.00227) }, { 2.0468e-05d, new GammaParticle(574100.0, 0.00216) }, { 1.4448e-05d, new GammaParticle(579600.0, 0.00214) }, { 1.4448e-05d, new GammaParticle(584300.0, 0.00212) }, { 1.4448e-05d, new GammaParticle(594000.0, 0.00209) }, { 0.0008620640000000001d, new GammaParticle(598721.0, 0.00207) }, { 0.000305214d, new GammaParticle(609310.0, 0.00203) }, { 4.816e-05d, new GammaParticle(619100.0, 0.002) }, { 7.6454e-05d, new GammaParticle(623500.0, 0.00199) }, { 4.214e-05d, new GammaParticle(631700.0, 0.00196) }, { 1.7458e-05d, new GammaParticle(641700.0, 0.00193) }, { 4.214e-05d, new GammaParticle(646100.0, 0.00192) }, { 7.224e-06d, new GammaParticle(696900.0, 0.00178) }, { 3.3712e-05d, new GammaParticle(711300.0, 0.00174) }, { 1.4448e-05d, new GammaParticle(718400.0, 0.00173) }, { 2.5284e-05d, new GammaParticle(728400.0, 0.0017) }, { 6.02e-06d, new GammaParticle(732800.0, 0.00169) }, { 2.9498e-06d, new GammaParticle(737200.0, 0.00168) }, { 0.23d, new GammaParticle(14088.0, 0.08801) }, { 0.1542d, new GammaParticle(81070.0, 0.01529) }, { 0.254d, new GammaParticle(83789.0, 0.0148) }, { 0.0882d, new GammaParticle(94878.0, 0.01307) }, { 0.1164d, new GammaParticle(96054.0, 0.01291) }, { 0.0282d, new GammaParticle(97530.0, 0.01271) } } },
            { 8.9e-10d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 7.7e-10d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    