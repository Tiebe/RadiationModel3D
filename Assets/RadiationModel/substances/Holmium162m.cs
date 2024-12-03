using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium162m";
        public override double halfLife { get; } = 4020.0d;
        public override double atomicWeight { get; } = 161.92922d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.63d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium162()), new(1.2e-08d, new GammaParticle(9800.0, 0.12651)), new(0.08d, new GammaParticle(38340.0, 0.03234)), new(0.045d, new GammaParticle(57740.0, 0.02147)), new(0.00083d, new GammaParticle(96060.0, 0.01291)), new(0.23266647263780002d, new GammaParticle(7656.0, 0.16194)), new(0.12702144168263566d, new GammaParticle(46700.0, 0.02655)), new(0.2262180617678284d, new GammaParticle(47547.0, 0.02608)), new(0.0730869353567746d, new GammaParticle(53982.0, 0.02297)), new(0.09208953854953598d, new GammaParticle(54577.0, 0.02272)), new(0.019002603192761397d, new GammaParticle(55293.0, 0.02242)) } },
            { 0.37d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium162()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.045d, new GammaParticle(80670.0, 0.01537)), new(0.0023d, new GammaParticle(89980.0, 0.01378)), new(0.0048d, new GammaParticle(95250.0, 0.01302)), new(0.0025d, new GammaParticle(149070.0, 0.00832)), new(0.0006900000000000001d, new GammaParticle(161160.0, 0.00769)), new(0.24d, new GammaParticle(184990.0, 0.0067)), new(0.00091d, new GammaParticle(188780.0, 0.00657)), new(0.00029d, new GammaParticle(219600.0, 0.00565)), new(0.00052d, new GammaParticle(236040.0, 0.00525)), new(0.00035999999999999997d, new GammaParticle(247120.0, 0.00502)), new(0.00024d, new GammaParticle(251100.0, 0.00494)), new(7.2e-05d, new GammaParticle(260000.0, 0.00477)), new(0.0072d, new GammaParticle(275550.0, 0.0045)), new(0.0012d, new GammaParticle(278490.0, 0.00445)), new(0.102d, new GammaParticle(282860.0, 0.00438)), new(0.003d, new GammaParticle(302910.0, 0.00409)), new(0.0008799999999999999d, new GammaParticle(321760.0, 0.00385)), new(0.00048d, new GammaParticle(329470.0, 0.00376)), new(0.0038d, new GammaParticle(333950.0, 0.00371)), new(0.00062d, new GammaParticle(347470.0, 0.00357)), new(0.0022d, new GammaParticle(392860.0, 0.00316)), new(0.0036d, new GammaParticle(424690.0, 0.00292)), new(0.0009299999999999999d, new GammaParticle(634210.0, 0.00195)), new(0.00055d, new GammaParticle(697280.0, 0.00178)), new(0.0007599999999999999d, new GammaParticle(775810.0, 0.0016)), new(0.0032d, new GammaParticle(795360.0, 0.00156)), new(0.00045d, new GammaParticle(807650.0, 0.00154)), new(0.004d, new GammaParticle(842000.0, 0.00147)), new(0.0032d, new GammaParticle(882320.0, 0.00141)), new(0.00074d, new GammaParticle(888200.0, 0.0014)), new(0.0051d, new GammaParticle(917170.0, 0.00135)), new(0.1d, new GammaParticle(937170.0, 0.00132)), new(0.0021d, new GammaParticle(944450.0, 0.00131)), new(0.0027d, new GammaParticle(980430.0, 0.00126)), new(0.0006d, new GammaParticle(1026930.0, 0.00121)), new(0.00037999999999999997d, new GammaParticle(1058850.0, 0.00117)), new(0.0111d, new GammaParticle(1124900.0, 0.0011)), new(0.0036d, new GammaParticle(1129460.0, 0.0011)), new(0.23600000000000002d, new GammaParticle(1220040.0, 0.00102)), new(0.001d, new GammaParticle(1310050.0, 0.00095)), new(0.0597241254007048d, new GammaParticle(7384.0, 0.16791)), new(0.04044519762725859d, new GammaParticle(45207.0, 0.02743)), new(0.072275192328911d, new GammaParticle(45998.0, 0.02695)), new(0.02320608663065904d, new GammaParticle(52220.0, 0.02374)), new(0.02923966915463039d, new GammaParticle(52791.0, 0.02349)), new(0.006033582523971351d, new GammaParticle(53478.0, 0.02318)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    