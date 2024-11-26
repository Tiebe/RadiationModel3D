using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium169";
        public override double halfLife { get; } = 2766355.2d;
        public override double atomicWeight { get; } = 168.93518d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium169() }, { 0.0035930000000000003d, new GammaParticle(8410.17, 0.14742) }, { 0.001965371d, new GammaParticle(20752.0, 0.05975) }, { 0.0025151d, new GammaParticle(42760.0, 0.029) }, { 0.00010779000000000001d, new GammaParticle(45940.0, 0.02699) }, { 0.0053895d, new GammaParticle(50610.0, 0.0245) }, { 0.0053895d, new GammaParticle(50860.0, 0.02438) }, { 0.00017964999999999998d, new GammaParticle(51510.0, 0.02407) }, { 0.021558d, new GammaParticle(63010.0, 0.01968) }, { 0.4361902d, new GammaParticle(63120.44, 0.01964) }, { 0.000104197d, new GammaParticle(65860.0, 0.01883) }, { 3.5929999999999997e-05d, new GammaParticle(72028.0, 0.01721) }, { 2.8744e-05d, new GammaParticle(85090.0, 0.01457) }, { 0.02579774d, new GammaParticle(93614.47, 0.01324) }, { 2.1558e-05d, new GammaParticle(95700.0, 0.01296) }, { 2.1558e-05d, new GammaParticle(95850.0, 0.01294) }, { 1.7964999999999998e-05d, new GammaParticle(98010.0, 0.01265) }, { 7.185999999999999e-05d, new GammaParticle(101405.0, 0.01223) }, { 2.58696e-05d, new GammaParticle(105190.0, 0.01179) }, { 0.17386527000000002d, new GammaParticle(109779.24, 0.01129) }, { 0.00010779000000000001d, new GammaParticle(113620.0, 0.01091) }, { 8.6232e-05d, new GammaParticle(113980.0, 0.01088) }, { 0.000398823d, new GammaParticle(117376.0, 0.01056) }, { 0.018741088d, new GammaParticle(118189.4, 0.01049) }, { 0.0053895d, new GammaParticle(129940.0, 0.00954) }, { 0.11382624d, new GammaParticle(130522.93, 0.0095) }, { 9.880750000000001e-05d, new GammaParticle(156724.0, 0.00791) }, { 2.8744e-05d, new GammaParticle(173880.0, 0.00713) }, { 0.22280193d, new GammaParticle(177213.07, 0.007) }, { 7.5453e-05d, new GammaParticle(193150.0, 0.00642) }, { 0.3593d, new GammaParticle(197956.75, 0.00626) }, { 0.00032336999999999996d, new GammaParticle(199770.0, 0.00621) }, { 3.37742e-05d, new GammaParticle(205990.0, 0.00602) }, { 2.91033e-05d, new GammaParticle(213935.0, 0.0058) }, { 2.5151e-06d, new GammaParticle(226300.0, 0.00548) }, { 3.9523e-06d, new GammaParticle(228710.0, 0.00542) }, { 0.001138981d, new GammaParticle(240331.0, 0.00516) }, { 0.016793682d, new GammaParticle(261077.12, 0.00475) }, { 4.3116e-05d, new GammaParticle(291188.0, 0.00426) }, { 9.701100000000001e-06d, new GammaParticle(294540.0, 0.00421) }, { 4.6709e-05d, new GammaParticle(301730.0, 0.00411) }, { 0.0017965000000000001d, new GammaParticle(306830.0, 0.00404) }, { 0.0050302d, new GammaParticle(307520.0, 0.00403) }, { 0.10046028d, new GammaParticle(307735.86, 0.00403) }, { 1.742605e-05d, new GammaParticle(333963.0, 0.00371) }, { 9.44959e-05d, new GammaParticle(336618.0, 0.00368) }, { 1.408456e-06d, new GammaParticle(356740.0, 0.00348) }, { 8.80285e-06d, new GammaParticle(370854.0, 0.00334) }, { 4.06009e-06d, new GammaParticle(379284.0, 0.00327) }, { 3.348676e-06d, new GammaParticle(386671.0, 0.00321) }, { 1.76057e-07d, new GammaParticle(452620.0, 0.00274) }, { 3.5930000000000005e-08d, new GammaParticle(464700.0, 0.00267) }, { 1.9042899999999999e-06d, new GammaParticle(465650.0, 0.00266) }, { 1.94022e-07d, new GammaParticle(466700.0, 0.00266) }, { 1.943813e-06d, new GammaParticle(474970.0, 0.00261) }, { 1.47313e-05d, new GammaParticle(494357.0, 0.00251) }, { 8.83878e-08d, new GammaParticle(500350.0, 0.00248) }, { 1.47313e-08d, new GammaParticle(507800.0, 0.00244) }, { 4.1714730000000004e-05d, new GammaParticle(515101.0, 0.00241) }, { 1.1964689999999999e-06d, new GammaParticle(528569.0, 0.00235) }, { 1.47313e-08d, new GammaParticle(546160.0, 0.00227) }, { 1.189283e-06d, new GammaParticle(562410.0, 0.0022) }, { 1.11383e-06d, new GammaParticle(570890.0, 0.00217) }, { 1.925848e-05d, new GammaParticle(579851.0, 0.00214) }, { 1.1389810000000001e-05d, new GammaParticle(600603.0, 0.00206) }, { 4.92241e-05d, new GammaParticle(624881.0, 0.00198) }, { 6.89856e-08d, new GammaParticle(633320.0, 0.00196) }, { 7.653089999999999e-07d, new GammaParticle(642873.0, 0.00193) }, { 1.933034e-06d, new GammaParticle(663599.0, 0.00187) }, { 8.69506e-08d, new GammaParticle(693460.0, 0.00179) }, { 3.4133500000000003e-07d, new GammaParticle(710354.0, 0.00175) }, { 1.83243e-08d, new GammaParticle(739420.0, 0.00168) }, { 8.2639e-09d, new GammaParticle(760240.0, 0.00163) }, { 2.0875329999999998e-06d, new GammaParticle(773386.0, 0.0016) }, { 3.01812e-08d, new GammaParticle(781640.0, 0.00159) }, { 0.475d, new GammaParticle(8215.0, 0.15092) }, { 0.523d, new GammaParticle(49773.0, 0.02491) }, { 0.9229999999999999d, new GammaParticle(50742.0, 0.02443) }, { 0.302d, new GammaParticle(57612.0, 0.02152) }, { 0.38d, new GammaParticle(58257.0, 0.02128) }, { 0.0784d, new GammaParticle(59034.0, 0.021) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    