using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc74 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc74";
        public override double halfLife { get; } = 95.6d;
        public override double atomicWeight { get; } = 73.92941d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gallium74()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00795d, new GammaParticle(45746.0, 0.0271)), new(0.32549999999999996d, new GammaParticle(49087.0, 0.02526)), new(0.1059d, new GammaParticle(52110.0, 0.02379)), new(0.18d, new GammaParticle(56559.0, 0.02192)), new(0.0051d, new GammaParticle(84810.0, 0.01462)), new(0.0075d, new GammaParticle(85100.0, 0.01457)), new(0.013349999999999999d, new GammaParticle(88496.0, 0.01401)), new(0.00945d, new GammaParticle(102250.0, 0.01213)), new(0.00795d, new GammaParticle(106762.0, 0.01161)), new(0.0042d, new GammaParticle(108635.0, 0.01141)), new(0.00555d, new GammaParticle(110461.0, 0.01122)), new(0.0195d, new GammaParticle(119149.0, 0.01041)), new(0.0042d, new GammaParticle(125540.0, 0.00988)), new(0.03675d, new GammaParticle(141330.0, 0.00877)), new(0.21d, new GammaParticle(143137.0, 0.00866)), new(0.0039000000000000003d, new GammaParticle(145020.0, 0.00855)), new(0.015600000000000001d, new GammaParticle(149517.0, 0.00829)), new(0.00255d, new GammaParticle(168220.0, 0.00737)), new(0.0012d, new GammaParticle(171130.0, 0.00725)), new(0.15d, new GammaParticle(192212.0, 0.00645)), new(0.023250000000000003d, new GammaParticle(195190.0, 0.00635)), new(0.00345d, new GammaParticle(251890.0, 0.00492)), new(0.02835d, new GammaParticle(346460.0, 0.00358)), new(0.0049499999999999995d, new GammaParticle(395160.0, 0.00314)), new(0.0024d, new GammaParticle(398300.0, 0.00311)), new(0.005849999999999999d, new GammaParticle(438830.0, 0.00283)), new(0.00555d, new GammaParticle(630720.0, 0.00197)), new(0.004050000000000001d, new GammaParticle(642900.0, 0.00193)), new(0.0246d, new GammaParticle(666210.0, 0.00186)), new(0.00375d, new GammaParticle(749200.0, 0.00165)), new(0.03495d, new GammaParticle(752820.0, 0.00165)), new(0.0105d, new GammaParticle(785440.0, 0.00158)), new(0.0087d, new GammaParticle(792010.0, 0.00157)), new(0.0069d, new GammaParticle(834000.0, 0.00149)), new(0.01665d, new GammaParticle(837490.0, 0.00148)), new(0.0048d, new GammaParticle(894100.0, 0.00139)), new(0.0054d, new GammaParticle(977070.0, 0.00127)), new(0.0049499999999999995d, new GammaParticle(983700.0, 0.00126)), new(0.00615d, new GammaParticle(1025810.0, 0.00121)), new(0.00435d, new GammaParticle(1028700.0, 0.00121)), new(0.00139152131712d, new GammaParticle(1127.0, 1.10013)), new(0.012229761420091714d, new GammaParticle(9225.0, 0.1344)), new(0.0237655682473605d, new GammaParticle(9252.0, 0.13401)), new(0.005213240091995812d, new GammaParticle(10306.0, 0.1203)), new(0.005244519532547787d, new GammaParticle(10313.0, 0.12022)), new(3.1279440551974875e-05d, new GammaParticle(10365.0, 0.11962)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    