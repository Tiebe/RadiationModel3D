using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium117";
        public override double halfLife { get; } = 8.4d;
        public override double atomicWeight { get; } = 116.92862d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine117() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.099d, new GammaParticle(29700.0, 0.04175) }, { 0.0225d, new GammaParticle(33700.0, 0.03679) }, { 0.00885d, new GammaParticle(83800.0, 0.0148) }, { 0.0009d, new GammaParticle(107800.0, 0.0115) }, { 0.00315d, new GammaParticle(121900.0, 0.01017) }, { 0.0018d, new GammaParticle(143000.0, 0.00867) }, { 0.0006d, new GammaParticle(150300.0, 0.00825) }, { 0.0495d, new GammaParticle(159900.0, 0.00775) }, { 0.0036d, new GammaParticle(171500.0, 0.00723) }, { 0.0225d, new GammaParticle(188200.0, 0.00659) }, { 0.15d, new GammaParticle(204800.0, 0.00605) }, { 0.0675d, new GammaParticle(205600.0, 0.00603) }, { 0.0033d, new GammaParticle(217000.0, 0.00571) }, { 0.048d, new GammaParticle(221600.0, 0.00559) }, { 0.0036d, new GammaParticle(233900.0, 0.0053) }, { 0.003d, new GammaParticle(235900.0, 0.00526) }, { 0.029249999999999998d, new GammaParticle(242700.0, 0.00511) }, { 0.00135d, new GammaParticle(249400.0, 0.00497) }, { 0.039900000000000005d, new GammaParticle(263100.0, 0.00471) }, { 0.0045000000000000005d, new GammaParticle(268800.0, 0.00461) }, { 0.04275d, new GammaParticle(271100.0, 0.00457) }, { 0.003d, new GammaParticle(277100.0, 0.00447) }, { 0.0024d, new GammaParticle(280000.0, 0.00443) }, { 0.0066d, new GammaParticle(314400.0, 0.00394) }, { 0.00315d, new GammaParticle(331400.0, 0.00374) }, { 0.01125d, new GammaParticle(336900.0, 0.00368) }, { 0.0028499999999999997d, new GammaParticle(364700.0, 0.0034) }, { 0.00255d, new GammaParticle(374100.0, 0.00331) }, { 0.00255d, new GammaParticle(387200.0, 0.0032) }, { 0.0045000000000000005d, new GammaParticle(393200.0, 0.00315) }, { 0.021d, new GammaParticle(393200.0, 0.00315) }, { 0.00105d, new GammaParticle(430400.0, 0.00288) }, { 0.0046500000000000005d, new GammaParticle(431800.0, 0.00287) }, { 0.0285d, new GammaParticle(438800.0, 0.00283) }, { 0.0033d, new GammaParticle(450000.0, 0.00276) }, { 0.00165d, new GammaParticle(465100.0, 0.00267) }, { 0.006d, new GammaParticle(473800.0, 0.00262) }, { 0.003d, new GammaParticle(522500.0, 0.00237) }, { 0.0009d, new GammaParticle(529000.0, 0.00234) }, { 0.00135d, new GammaParticle(532300.0, 0.00233) }, { 0.0048d, new GammaParticle(540100.0, 0.0023) }, { 0.006d, new GammaParticle(543000.0, 0.00228) }, { 0.0015d, new GammaParticle(546800.0, 0.00227) }, { 0.00075d, new GammaParticle(555000.0, 0.00223) }, { 0.008100000000000001d, new GammaParticle(610900.0, 0.00203) }, { 0.0075d, new GammaParticle(615100.0, 0.00202) }, { 0.0045000000000000005d, new GammaParticle(620300.0, 0.002) }, { 0.0019500000000000001d, new GammaParticle(626500.0, 0.00198) }, { 0.005699999999999999d, new GammaParticle(647500.0, 0.00191) }, { 0.006750000000000001d, new GammaParticle(716000.0, 0.00173) }, { 0.00645d, new GammaParticle(773600.0, 0.0016) }, { 0.0051d, new GammaParticle(781300.0, 0.00159) }, { 0.0045000000000000005d, new GammaParticle(846500.0, 0.00146) }, { 0.006750000000000001d, new GammaParticle(869000.0, 0.00143) }, { 0.0028499999999999997d, new GammaParticle(928700.0, 0.00134) }, { 0.0022500000000000003d, new GammaParticle(987400.0, 0.00126) }, { 0.0015d, new GammaParticle(1051500.0, 0.00118) }, { 0.00105d, new GammaParticle(1069100.0, 0.00116) }, { 0.0075d, new GammaParticle(1084600.0, 0.00114) }, { 0.0022500000000000003d, new GammaParticle(1143200.0, 0.00108) }, { 0.0018d, new GammaParticle(1201800.0, 0.00103) }, { 0.00255d, new GammaParticle(1266000.0, 0.00098) }, { 0.0022500000000000003d, new GammaParticle(1541700.0, 0.0008) }, { 0.0297606721992d, new GammaParticle(4540.0, 0.27309) }, { 0.012274674844605806d, new GammaParticle(29458.0, 0.04209) }, { 0.022739301305309018d, new GammaParticle(29778.0, 0.04164) }, { 0.006592032564793835d, new GammaParticle(33726.0, 0.03676) }, { 0.00814775225008518d, new GammaParticle(34030.0, 0.03643) }, { 0.0015557196852913453d, new GammaParticle(34414.0, 0.03603) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    