using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony110 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony110";
        public override double halfLife { get; } = 23.6d;
        public override double atomicWeight { get; } = 109.91685d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium110() }, { 1.0d, new BetaParticle(1, 4510000.0) }, { 1.8319999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.010076d, new GammaParticle(624400.0, 0.00199) }, { 0.043052d, new GammaParticle(636500.0, 0.00195) }, { 0.04122d, new GammaParticle(751500.0, 0.00165) }, { 0.008244d, new GammaParticle(766800.0, 0.00162) }, { 0.004122d, new GammaParticle(796200.0, 0.00156) }, { 0.09434799999999999d, new GammaParticle(827100.0, 0.0015) }, { 0.07786d, new GammaParticle(908900.0, 0.00136) }, { 0.312356d, new GammaParticle(984700.0, 0.00126) }, { 0.012824d, new GammaParticle(996700.0, 0.00124) }, { 0.0229d, new GammaParticle(1025800.0, 0.00121) }, { 0.0076028d, new GammaParticle(1101200.0, 0.00113) }, { 0.9159999999999999d, new GammaParticle(1211700.0, 0.00102) }, { 0.133736d, new GammaParticle(1243300.0, 0.001) }, { 0.005038d, new GammaParticle(1325600.0, 0.00094) }, { 0.015571999999999999d, new GammaParticle(1333600.0, 0.00093) }, { 0.0047632d, new GammaParticle(1339200.0, 0.00093) }, { 0.012824d, new GammaParticle(1351800.0, 0.00092) }, { 0.0021984d, new GammaParticle(1375800.0, 0.0009) }, { 0.0031144d, new GammaParticle(1419600.0, 0.00087) }, { 0.012824d, new GammaParticle(1432600.0, 0.00087) }, { 0.04213599999999999d, new GammaParticle(1482500.0, 0.00084) }, { 0.0229d, new GammaParticle(1609500.0, 0.00077) }, { 0.016488d, new GammaParticle(1621400.0, 0.00076) }, { 0.0025648d, new GammaParticle(1702500.0, 0.00073) }, { 0.070532d, new GammaParticle(1735900.0, 0.00071) }, { 0.040304d, new GammaParticle(1765300.0, 0.0007) }, { 0.0032976d, new GammaParticle(1780200.0, 0.0007) }, { 0.048548d, new GammaParticle(1970900.0, 0.00063) }, { 0.004122d, new GammaParticle(2010100.0, 0.00062) }, { 0.03664d, new GammaParticle(2029100.0, 0.00061) }, { 0.07328d, new GammaParticle(2120800.0, 0.00058) }, { 0.0010992d, new GammaParticle(2172300.0, 0.00057) }, { 0.0229d, new GammaParticle(2234900.0, 0.00055) }, { 0.010992d, new GammaParticle(2328400.0, 0.00053) }, { 0.008244d, new GammaParticle(2382400.0, 0.00052) }, { 0.0071448d, new GammaParticle(2417800.0, 0.00051) }, { 0.0054044d, new GammaParticle(2545400.0, 0.00049) }, { 0.021067999999999996d, new GammaParticle(2673200.0, 0.00046) }, { 0.0035724d, new GammaParticle(2834300.0, 0.00044) }, { 0.0021984d, new GammaParticle(2915100.0, 0.00043) }, { 1.854d, new GammaParticle(511000.0, 0.00243) }, { 0.005064911409592128d, new GammaParticle(3753.0, 0.33036) }, { 0.015803480663741654d, new GammaParticle(25044.0, 0.04951) }, { 0.029577916271273916d, new GammaParticle(25271.0, 0.04906) }, { 0.00836352227557597d, new GammaParticle(28579.0, 0.04338) }, { 0.010011136163864436d, new GammaParticle(28810.0, 0.04304) }, { 0.001647613888288466d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    