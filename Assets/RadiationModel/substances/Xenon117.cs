using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon117 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon117";
        public override double halfLife { get; } = 61.0d;
        public override double atomicWeight { get; } = 116.92036d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium117() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.37d, new GammaParticle(28500.0, 0.0435) }, { 0.076d, new GammaParticle(32300.0, 0.03839) }, { 0.0025d, new GammaParticle(43700.0, 0.02837) }, { 0.031d, new GammaParticle(58800.0, 0.02109) }, { 0.013999999999999999d, new GammaParticle(94400.0, 0.01313) }, { 0.0017000000000000001d, new GammaParticle(101600.0, 0.0122) }, { 0.0044d, new GammaParticle(104600.0, 0.01185) }, { 0.054000000000000006d, new GammaParticle(116700.0, 0.01062) }, { 0.013000000000000001d, new GammaParticle(155200.0, 0.00799) }, { 0.032d, new GammaParticle(160600.0, 0.00772) }, { 0.004d, new GammaParticle(199100.0, 0.00623) }, { 0.005699999999999999d, new GammaParticle(203400.0, 0.0061) }, { 0.1d, new GammaParticle(221300.0, 0.0056) }, { 0.0125d, new GammaParticle(256900.0, 0.00483) }, { 0.053d, new GammaParticle(294700.0, 0.00421) }, { 0.0024d, new GammaParticle(300200.0, 0.00413) }, { 0.0165d, new GammaParticle(315800.0, 0.00393) }, { 0.0078000000000000005d, new GammaParticle(353600.0, 0.00351) }, { 0.001d, new GammaParticle(389700.0, 0.00318) }, { 0.023d, new GammaParticle(439200.0, 0.00282) }, { 0.006999999999999999d, new GammaParticle(450700.0, 0.00275) }, { 0.0015d, new GammaParticle(460000.0, 0.0027) }, { 0.062d, new GammaParticle(519100.0, 0.00239) }, { 0.004d, new GammaParticle(543800.0, 0.00228) }, { 0.003d, new GammaParticle(565100.0, 0.00219) }, { 0.031d, new GammaParticle(639000.0, 0.00194) }, { 0.027999999999999997d, new GammaParticle(661300.0, 0.00187) }, { 0.013999999999999999d, new GammaParticle(695100.0, 0.00178) }, { 0.0025d, new GammaParticle(733800.0, 0.00169) }, { 0.01d, new GammaParticle(757300.0, 0.00164) }, { 0.008d, new GammaParticle(776400.0, 0.0016) }, { 0.006500000000000001d, new GammaParticle(875600.0, 0.00142) }, { 0.0055000000000000005d, new GammaParticle(970100.0, 0.00128) }, { 0.0045000000000000005d, new GammaParticle(1012500.0, 0.00122) }, { 0.0055000000000000005d, new GammaParticle(1048500.0, 0.00118) }, { 0.0073d, new GammaParticle(1084300.0, 0.00114) }, { 0.004d, new GammaParticle(1213000.0, 0.00102) }, { 0.006d, new GammaParticle(1247500.0, 0.00099) }, { 0.0015d, new GammaParticle(1317000.0, 0.00094) }, { 0.0033d, new GammaParticle(1432800.0, 0.00087) }, { 0.0075d, new GammaParticle(1481800.0, 0.00084) }, { 0.02d, new GammaParticle(1523600.0, 0.00081) }, { 0.0044d, new GammaParticle(1561200.0, 0.00079) }, { 0.022699828472d, new GammaParticle(4335.0, 0.28601) }, { 0.054510773441282474d, new GammaParticle(28318.0, 0.04378) }, { 0.10124586448975201d, new GammaParticle(28613.0, 0.04333) }, { 0.0291694323564156d, new GammaParticle(32395.0, 0.03827) }, { 0.03576172406896552d, new GammaParticle(32680.0, 0.03794) }, { 0.0065922917125499254d, new GammaParticle(33040.0, 0.03753) } } },
            { 2.8999999999999997e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium116() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    