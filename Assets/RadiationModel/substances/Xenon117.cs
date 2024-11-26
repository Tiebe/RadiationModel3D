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

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium117()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.37d, new GammaParticle(28500.0, 0.0435)), new(0.076d, new GammaParticle(32300.0, 0.03839)), new(0.0025d, new GammaParticle(43700.0, 0.02837)), new(0.031d, new GammaParticle(58800.0, 0.02109)), new(0.013999999999999999d, new GammaParticle(94400.0, 0.01313)), new(0.0017000000000000001d, new GammaParticle(101600.0, 0.0122)), new(0.0044d, new GammaParticle(104600.0, 0.01185)), new(0.054000000000000006d, new GammaParticle(116700.0, 0.01062)), new(0.013000000000000001d, new GammaParticle(155200.0, 0.00799)), new(0.032d, new GammaParticle(160600.0, 0.00772)), new(0.004d, new GammaParticle(199100.0, 0.00623)), new(0.005699999999999999d, new GammaParticle(203400.0, 0.0061)), new(0.1d, new GammaParticle(221300.0, 0.0056)), new(0.0125d, new GammaParticle(256900.0, 0.00483)), new(0.053d, new GammaParticle(294700.0, 0.00421)), new(0.0024d, new GammaParticle(300200.0, 0.00413)), new(0.0165d, new GammaParticle(315800.0, 0.00393)), new(0.0078000000000000005d, new GammaParticle(353600.0, 0.00351)), new(0.001d, new GammaParticle(389700.0, 0.00318)), new(0.023d, new GammaParticle(439200.0, 0.00282)), new(0.006999999999999999d, new GammaParticle(450700.0, 0.00275)), new(0.0015d, new GammaParticle(460000.0, 0.0027)), new(0.062d, new GammaParticle(519100.0, 0.00239)), new(0.004d, new GammaParticle(543800.0, 0.00228)), new(0.003d, new GammaParticle(565100.0, 0.00219)), new(0.031d, new GammaParticle(639000.0, 0.00194)), new(0.027999999999999997d, new GammaParticle(661300.0, 0.00187)), new(0.013999999999999999d, new GammaParticle(695100.0, 0.00178)), new(0.0025d, new GammaParticle(733800.0, 0.00169)), new(0.01d, new GammaParticle(757300.0, 0.00164)), new(0.008d, new GammaParticle(776400.0, 0.0016)), new(0.006500000000000001d, new GammaParticle(875600.0, 0.00142)), new(0.0055000000000000005d, new GammaParticle(970100.0, 0.00128)), new(0.0045000000000000005d, new GammaParticle(1012500.0, 0.00122)), new(0.0055000000000000005d, new GammaParticle(1048500.0, 0.00118)), new(0.0073d, new GammaParticle(1084300.0, 0.00114)), new(0.004d, new GammaParticle(1213000.0, 0.00102)), new(0.006d, new GammaParticle(1247500.0, 0.00099)), new(0.0015d, new GammaParticle(1317000.0, 0.00094)), new(0.0033d, new GammaParticle(1432800.0, 0.00087)), new(0.0075d, new GammaParticle(1481800.0, 0.00084)), new(0.02d, new GammaParticle(1523600.0, 0.00081)), new(0.0044d, new GammaParticle(1561200.0, 0.00079)), new(0.022699828472d, new GammaParticle(4335.0, 0.28601)), new(0.054510773441282474d, new GammaParticle(28318.0, 0.04378)), new(0.10124586448975201d, new GammaParticle(28613.0, 0.04333)), new(0.0291694323564156d, new GammaParticle(32395.0, 0.03827)), new(0.03576172406896552d, new GammaParticle(32680.0, 0.03794)), new(0.0065922917125499254d, new GammaParticle(33040.0, 0.03753)) } },
            { 2.8999999999999997e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium116()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    