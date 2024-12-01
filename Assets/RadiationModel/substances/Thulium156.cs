using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium156";
        public override double halfLife { get; } = 83.8d;
        public override double atomicWeight { get; } = 155.93899d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99936d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium156()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.003784d, new GammaParticle(290680.0, 0.00427)), new(0.0025800000000000003d, new GammaParticle(312400.0, 0.00397)), new(0.002408d, new GammaParticle(326000.0, 0.0038)), new(0.86d, new GammaParticle(344550.0, 0.0036)), new(0.00172d, new GammaParticle(350000.0, 0.00354)), new(0.000946d, new GammaParticle(406900.0, 0.00305)), new(0.01548d, new GammaParticle(420780.0, 0.00295)), new(0.004386d, new GammaParticle(423400.0, 0.00293)), new(0.0012900000000000001d, new GammaParticle(429900.0, 0.00288)), new(0.0012900000000000001d, new GammaParticle(451500.0, 0.00275)), new(0.17286d, new GammaParticle(452850.0, 0.00274)), new(0.009115999999999999d, new GammaParticle(475630.0, 0.00261)), new(0.0045579999999999996d, new GammaParticle(484850.0, 0.00256)), new(0.00172d, new GammaParticle(507400.0, 0.00244)), new(0.002752d, new GammaParticle(543500.0, 0.00228)), new(0.008944d, new GammaParticle(553980.0, 0.00224)), new(0.00344d, new GammaParticle(557900.0, 0.00222)), new(0.1462d, new GammaParticle(585930.0, 0.00212)), new(0.1462d, new GammaParticle(585930.0, 0.00212)), new(0.01462d, new GammaParticle(608840.0, 0.00204)), new(0.004988d, new GammaParticle(640440.0, 0.00194)), new(0.012642d, new GammaParticle(699900.0, 0.00177)), new(0.005246d, new GammaParticle(749000.0, 0.00166)), new(0.001978d, new GammaParticle(773000.0, 0.0016)), new(0.005848d, new GammaParticle(814300.0, 0.00152)), new(0.0016339999999999998d, new GammaParticle(826000.0, 0.0015)), new(0.0045579999999999996d, new GammaParticle(866020.0, 0.00143)), new(0.02322d, new GammaParticle(876200.0, 0.00142)), new(0.0129d, new GammaParticle(898500.0, 0.00138)), new(0.0129d, new GammaParticle(898500.0, 0.00138)), new(0.05074d, new GammaParticle(930420.0, 0.00133)), new(0.08858d, new GammaParticle(959000.0, 0.00129)), new(0.03096d, new GammaParticle(1006860.0, 0.00123)), new(0.010922000000000001d, new GammaParticle(1017100.0, 0.00122)), new(0.0086d, new GammaParticle(1061300.0, 0.00117)), new(0.00215d, new GammaParticle(1084400.0, 0.00114)), new(0.0016339999999999998d, new GammaParticle(1160500.0, 0.00107)), new(0.0043d, new GammaParticle(1173340.0, 0.00106)), new(0.00903d, new GammaParticle(1202200.0, 0.00103)), new(0.0301d, new GammaParticle(1220830.0, 0.00102)), new(0.01204d, new GammaParticle(1226100.0, 0.00101)), new(0.02666d, new GammaParticle(1286050.0, 0.00096)), new(0.01548d, new GammaParticle(1366000.0, 0.00091)), new(0.0043d, new GammaParticle(1405000.0, 0.00088)), new(0.01204d, new GammaParticle(1516300.0, 0.00082)), new(0.01892d, new GammaParticle(1518000.0, 0.00082)), new(0.0040420000000000005d, new GammaParticle(1529300.0, 0.00081)), new(0.01634d, new GammaParticle(1565100.0, 0.00079)), new(0.01161d, new GammaParticle(1663900.0, 0.00075)), new(0.01376d, new GammaParticle(1670000.0, 0.00074)), new(0.002408d, new GammaParticle(1677200.0, 0.00074)), new(0.00215d, new GammaParticle(1711700.0, 0.00072)), new(0.003096d, new GammaParticle(1722500.0, 0.00072)), new(0.002408d, new GammaParticle(1738700.0, 0.00071)), new(0.0036980000000000003d, new GammaParticle(1760500.0, 0.0007)), new(0.0016339999999999998d, new GammaParticle(1767300.0, 0.0007)), new(0.0016339999999999998d, new GammaParticle(1779400.0, 0.0007)), new(0.00817d, new GammaParticle(1825300.0, 0.00068)), new(0.0086d, new GammaParticle(7933.0, 0.15629)), new(0.01d, new GammaParticle(48222.0, 0.02571)), new(0.0178d, new GammaParticle(49128.0, 0.02524)), new(0.00579d, new GammaParticle(55779.0, 0.02223)), new(0.0073d, new GammaParticle(56399.0, 0.02198)), new(0.0015d, new GammaParticle(57145.0, 0.0217)) } },
            { 0.00064d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium152()), new(1.0d, new AlphaParticle(5368002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    