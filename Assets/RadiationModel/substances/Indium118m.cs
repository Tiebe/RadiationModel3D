using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium118m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium118m";
        public override double halfLife { get; } = 267.0d;
        public override double atomicWeight { get; } = 117.90646d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin118()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00043200000000000004d, new GammaParticle(186240.0, 0.00666)), new(0.026015999999999997d, new GammaParticle(208520.0, 0.00595)), new(0.0075168000000000006d, new GammaParticle(229650.0, 0.0054)), new(0.00038399999999999996d, new GammaParticle(237600.0, 0.00522)), new(0.0007775999999999999d, new GammaParticle(285220.0, 0.00435)), new(0.0003552d, new GammaParticle(411440.0, 0.00301)), new(0.055296000000000005d, new GammaParticle(445980.0, 0.00278)), new(0.0019872d, new GammaParticle(472210.0, 0.00263)), new(0.0288d, new GammaParticle(474570.0, 0.00261)), new(0.001248d, new GammaParticle(510500.0, 0.00243)), new(0.009504d, new GammaParticle(560210.0, 0.00221)), new(0.0006912d, new GammaParticle(568940.0, 0.00218)), new(0.001968d, new GammaParticle(576180.0, 0.00215)), new(0.0006624d, new GammaParticle(598340.0, 0.00207)), new(0.016992d, new GammaParticle(635400.0, 0.00195)), new(0.013151999999999999d, new GammaParticle(638610.0, 0.00194)), new(0.000576d, new GammaParticle(642560.0, 0.00193)), new(0.001152d, new GammaParticle(675000.0, 0.00184)), new(0.54336d, new GammaParticle(683060.0, 0.00182)), new(0.0007296d, new GammaParticle(718900.0, 0.00172)), new(0.0003552d, new GammaParticle(756400.0, 0.00164)), new(0.037248d, new GammaParticle(813200.0, 0.00152)), new(0.0011232d, new GammaParticle(858840.0, 0.00144)), new(0.0025344d, new GammaParticle(885660.0, 0.0014)), new(0.0008448d, new GammaParticle(908650.0, 0.00136)), new(0.0048576d, new GammaParticle(920570.0, 0.00135)), new(0.0030719999999999996d, new GammaParticle(971440.0, 0.00128)), new(0.00336d, new GammaParticle(971440.0, 0.00128)), new(0.81024d, new GammaParticle(1050650.0, 0.00118)), new(0.0077280000000000005d, new GammaParticle(1094300.0, 0.00113)), new(0.0144d, new GammaParticle(1095000.0, 0.00113)), new(0.01536d, new GammaParticle(1098200.0, 0.00113)), new(0.0006528d, new GammaParticle(1102540.0, 0.00112)), new(0.0006816d, new GammaParticle(1116420.0, 0.00111)), new(0.0009504d, new GammaParticle(1132490.0, 0.00109)), new(0.013728d, new GammaParticle(1173520.0, 0.00106)), new(0.0015648d, new GammaParticle(1180180.0, 0.00105)), new(0.96d, new GammaParticle(1229640.0, 0.00101)), new(0.038304d, new GammaParticle(1259180.0, 0.00098)), new(0.0013248d, new GammaParticle(1264960.0, 0.00098)), new(0.0007008d, new GammaParticle(1271260.0, 0.00098)), new(0.0005376000000000001d, new GammaParticle(1301620.0, 0.00095)), new(0.0017952d, new GammaParticle(1312220.0, 0.00094)), new(0.00023040000000000002d, new GammaParticle(1368300.0, 0.00091)), new(0.0003648d, new GammaParticle(1377090.0, 0.0009)), new(0.0002592d, new GammaParticle(1418000.0, 0.00087)), new(0.00020160000000000002d, new GammaParticle(1424700.0, 0.00087)), new(0.0001824d, new GammaParticle(1430400.0, 0.00087)), new(0.0004512d, new GammaParticle(1447550.0, 0.00086)), new(0.0016991999999999999d, new GammaParticle(1473500.0, 0.00084)), new(0.01584d, new GammaParticle(1504100.0, 0.00082)), new(0.0012767999999999998d, new GammaParticle(1531960.0, 0.00081)), new(0.0026976d, new GammaParticle(1549630.0, 0.0008)), new(0.00039359999999999997d, new GammaParticle(1661930.0, 0.00075)), new(0.034848d, new GammaParticle(2042770.0, 0.00061)), new(0.0001536d, new GammaParticle(2107600.0, 0.00059)), new(0.0011616d, new GammaParticle(2144640.0, 0.00058)), new(0.0031968d, new GammaParticle(2230760.0, 0.00056)), new(0.0035904d, new GammaParticle(2327820.0, 0.00053)), new(0.0006528d, new GammaParticle(2362780.0, 0.00052)), new(0.0014399999999999999d, new GammaParticle(2475060.0, 0.0005)), new(0.0009216000000000001d, new GammaParticle(2586900.0, 0.00048)), new(0.0008255999999999999d, new GammaParticle(2609180.0, 0.00048)), new(0.0003744d, new GammaParticle(2677400.0, 0.00046)), new(0.00026880000000000003d, new GammaParticle(2903900.0, 0.00043)), new(0.0001536d, new GammaParticle(3104500.0, 0.0004)), new(3.84e-05d, new GammaParticle(3669700.0, 0.00034)), new(0.00021424641279744d, new GammaParticle(3753.0, 0.33036)), new(0.0006656705558897362d, new GammaParticle(25044.0, 0.04951)), new(0.0012458741454047094d, new GammaParticle(25271.0, 0.04906)), new(0.0003522863501299538d, new GammaParticle(28579.0, 0.04338)), new(0.0004216867611055547d, new GammaParticle(28810.0, 0.04304)), new(6.940041097560089e-05d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    