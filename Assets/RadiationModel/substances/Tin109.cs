using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin109 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin109";
        public override double halfLife { get; } = 1086.0d;
        public override double atomicWeight { get; } = 108.91129d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium109()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.000586d, new GammaParticle(119000.0, 0.01042)), new(0.000879d, new GammaParticle(142800.0, 0.00868)), new(0.000879d, new GammaParticle(158600.0, 0.00782)), new(0.000586d, new GammaParticle(181800.0, 0.00682)), new(0.000586d, new GammaParticle(216900.0, 0.00572)), new(0.001172d, new GammaParticle(220500.0, 0.00562)), new(0.000586d, new GammaParticle(222200.0, 0.00558)), new(0.001172d, new GammaParticle(229200.0, 0.00541)), new(0.001172d, new GammaParticle(250100.0, 0.00496)), new(0.0032229999999999997d, new GammaParticle(261100.0, 0.00475)), new(0.003516d, new GammaParticle(285000.0, 0.00435)), new(0.001465d, new GammaParticle(310300.0, 0.004)), new(0.00586d, new GammaParticle(312000.0, 0.00397)), new(0.094346d, new GammaParticle(331200.0, 0.00374)), new(0.002344d, new GammaParticle(340200.0, 0.00364)), new(0.009962d, new GammaParticle(353900.0, 0.0035)), new(0.002344d, new GammaParticle(362900.0, 0.00342)), new(0.002344d, new GammaParticle(373700.0, 0.00332)), new(0.000879d, new GammaParticle(376100.0, 0.0033)), new(0.00879d, new GammaParticle(383000.0, 0.00324)), new(0.02344d, new GammaParticle(384500.0, 0.00322)), new(0.000879d, new GammaParticle(401800.0, 0.00309)), new(0.0006446000000000001d, new GammaParticle(401970.0, 0.00308)), new(0.001465d, new GammaParticle(407300.0, 0.00304)), new(0.001172d, new GammaParticle(414700.0, 0.00299)), new(0.009376d, new GammaParticle(422600.0, 0.00293)), new(0.016115d, new GammaParticle(437200.0, 0.00284)), new(0.010548d, new GammaParticle(437400.0, 0.00283)), new(0.000879d, new GammaParticle(448700.0, 0.00276)), new(0.001465d, new GammaParticle(452800.0, 0.00274)), new(0.001758d, new GammaParticle(454400.0, 0.00273)), new(0.0013185d, new GammaParticle(459800.0, 0.0027)), new(0.002051d, new GammaParticle(459800.0, 0.0027)), new(0.001465d, new GammaParticle(465800.0, 0.00266)), new(0.001758d, new GammaParticle(473200.0, 0.00262)), new(0.001172d, new GammaParticle(478500.0, 0.00259)), new(0.001172d, new GammaParticle(482700.0, 0.00257)), new(0.0038090000000000003d, new GammaParticle(495800.0, 0.0025)), new(0.0037503999999999997d, new GammaParticle(501000.0, 0.00247)), new(0.002637d, new GammaParticle(501200.0, 0.00247)), new(0.028128d, new GammaParticle(521900.0, 0.00238)), new(0.00586d, new GammaParticle(522000.0, 0.00238)), new(0.002051d, new GammaParticle(539400.0, 0.0023)), new(0.001465d, new GammaParticle(548900.0, 0.00226)), new(0.000879d, new GammaParticle(560300.0, 0.00221)), new(0.000879d, new GammaParticle(594600.0, 0.00209)), new(0.001465d, new GammaParticle(597200.0, 0.00208)), new(0.01758d, new GammaParticle(614100.0, 0.00202)), new(0.021096d, new GammaParticle(623400.0, 0.00199)), new(0.29593d, new GammaParticle(649800.0, 0.00191)), new(0.014064d, new GammaParticle(660100.0, 0.00188)), new(0.007325000000000001d, new GammaParticle(686800.0, 0.00181)), new(0.004102d, new GammaParticle(710700.0, 0.00174)), new(0.005567d, new GammaParticle(722100.0, 0.00172)), new(0.006153d, new GammaParticle(732500.0, 0.00169)), new(0.0032229999999999997d, new GammaParticle(745300.0, 0.00166)), new(0.002344d, new GammaParticle(780100.0, 0.00159)), new(0.002637d, new GammaParticle(785300.0, 0.00158)), new(0.015236000000000001d, new GammaParticle(790900.0, 0.00157)), new(0.002051d, new GammaParticle(804900.0, 0.00154)), new(0.005274d, new GammaParticle(816200.0, 0.00152)), new(0.005274d, new GammaParticle(816200.0, 0.00152)), new(0.008497d, new GammaParticle(828800.0, 0.0015)), new(0.008497d, new GammaParticle(835700.0, 0.00148)), new(0.001465d, new GammaParticle(848600.0, 0.00146)), new(0.005274d, new GammaParticle(857900.0, 0.00145)), new(0.006739d, new GammaParticle(869300.0, 0.00143)), new(0.00586d, new GammaParticle(879200.0, 0.00141)), new(0.006153d, new GammaParticle(888700.0, 0.0014)), new(0.009376d, new GammaParticle(897500.0, 0.00138)), new(0.001758d, new GammaParticle(903400.0, 0.00137)), new(0.004688d, new GammaParticle(967200.0, 0.00128)), new(0.010548d, new GammaParticle(976300.0, 0.00127)), new(0.0038090000000000003d, new GammaParticle(985300.0, 0.00126)), new(0.01172d, new GammaParticle(1026400.0, 0.00121)), new(0.039848d, new GammaParticle(1026400.0, 0.00121)), new(0.043949999999999996d, new GammaParticle(1039000.0, 0.00119)), new(0.006153d, new GammaParticle(1054200.0, 0.00118)), new(0.002344d, new GammaParticle(1072700.0, 0.00116)), new(0.000879d, new GammaParticle(1078500.0, 0.00115)), new(0.00586d, new GammaParticle(1083400.0, 0.00114)), new(0.005274d, new GammaParticle(1092200.0, 0.00114)), new(0.293d, new GammaParticle(1099200.0, 0.00113)), new(0.004688d, new GammaParticle(1107200.0, 0.00112)), new(0.004688d, new GammaParticle(1107700.0, 0.00112)), new(0.030764999999999997d, new GammaParticle(1119200.0, 0.00111)), new(0.013771d, new GammaParticle(1128200.0, 0.0011)), new(0.000879d, new GammaParticle(1130500.0, 0.0011)), new(0.004981d, new GammaParticle(1157800.0, 0.00107)), new(0.004395d, new GammaParticle(1166600.0, 0.00106)), new(0.000879d, new GammaParticle(1170200.0, 0.00106)), new(0.001758d, new GammaParticle(1174600.0, 0.00106)), new(0.002344d, new GammaParticle(1187800.0, 0.00104)), new(0.0038090000000000003d, new GammaParticle(1205600.0, 0.00103)), new(0.009669d, new GammaParticle(1211400.0, 0.00102)), new(0.001465d, new GammaParticle(1220900.0, 0.00102)), new(0.0032229999999999997d, new GammaParticle(1227400.0, 0.00101)), new(0.005567d, new GammaParticle(1231000.0, 0.00101)), new(0.0038090000000000003d, new GammaParticle(1239900.0, 0.001)), new(0.002344d, new GammaParticle(1250100.0, 0.00099)), new(0.004688d, new GammaParticle(1271500.0, 0.00098)), new(0.001465d, new GammaParticle(1290000.0, 0.00096)), new(0.004981d, new GammaParticle(1300700.0, 0.00095)), new(0.0032229999999999997d, new GammaParticle(1307100.0, 0.00095)), new(0.115442d, new GammaParticle(1321300.0, 0.00094)), new(0.00879d, new GammaParticle(1350100.0, 0.00092)), new(0.0038090000000000003d, new GammaParticle(1375200.0, 0.0009)), new(0.002344d, new GammaParticle(1388200.0, 0.00089)), new(0.006739d, new GammaParticle(1408900.0, 0.00088)), new(0.0028714d, new GammaParticle(1428320.0, 0.00087)), new(0.00293d, new GammaParticle(1429700.0, 0.00087)), new(0.007032d, new GammaParticle(1442700.0, 0.00086)), new(0.0064459999999999995d, new GammaParticle(1455300.0, 0.00085)), new(0.02051d, new GammaParticle(1462000.0, 0.00085)), new(0.029300000000000003d, new GammaParticle(1463600.0, 0.00085)), new(0.03516d, new GammaParticle(1464200.0, 0.00085)), new(0.004102d, new GammaParticle(1482300.0, 0.00084)), new(0.039555d, new GammaParticle(1488700.0, 0.00083)), new(0.013185d, new GammaParticle(1492600.0, 0.00083)), new(0.001465d, new GammaParticle(1501700.0, 0.00083)), new(0.001172d, new GammaParticle(1507600.0, 0.00082)), new(0.004981d, new GammaParticle(1524900.0, 0.00081)), new(0.001172d, new GammaParticle(1546600.0, 0.0008)), new(0.002344d, new GammaParticle(1557900.0, 0.0008)), new(0.002344d, new GammaParticle(1565600.0, 0.00079)), new(0.053326000000000005d, new GammaParticle(1574400.0, 0.00079)), new(0.011134d, new GammaParticle(1580700.0, 0.00078)), new(0.0038090000000000003d, new GammaParticle(1603300.0, 0.00077)), new(0.004395d, new GammaParticle(1621700.0, 0.00076)), new(0.004688d, new GammaParticle(1655700.0, 0.00075)), new(0.002051d, new GammaParticle(1674100.0, 0.00074)), new(0.007325000000000001d, new GammaParticle(1686300.0, 0.00074)), new(0.001172d, new GammaParticle(1700700.0, 0.00073)), new(0.000879d, new GammaParticle(1709300.0, 0.00073)), new(0.009669d, new GammaParticle(1713500.0, 0.00072)), new(0.010255d, new GammaParticle(1722200.0, 0.00072)), new(0.00293d, new GammaParticle(1734300.0, 0.00071)), new(0.010841d, new GammaParticle(1759200.0, 0.0007)), new(0.003516d, new GammaParticle(1770800.0, 0.0007)), new(0.002344d, new GammaParticle(1792000.0, 0.00069)), new(0.001758d, new GammaParticle(1819000.0, 0.00068)), new(0.006153d, new GammaParticle(1825100.0, 0.00068)), new(0.006153d, new GammaParticle(1825300.0, 0.00068)), new(0.007032d, new GammaParticle(1843700.0, 0.00067)), new(0.004981d, new GammaParticle(1850100.0, 0.00067)), new(0.0038090000000000003d, new GammaParticle(1858700.0, 0.00067)), new(0.014943d, new GammaParticle(1889800.0, 0.00066)), new(0.056548999999999995d, new GammaParticle(1911100.0, 0.00065)), new(0.004981d, new GammaParticle(1930500.0, 0.00064)), new(0.010548d, new GammaParticle(1943500.0, 0.00064)), new(0.000879d, new GammaParticle(1951300.0, 0.00064)), new(0.0038090000000000003d, new GammaParticle(1956900.0, 0.00063)), new(0.001465d, new GammaParticle(1962200.0, 0.00063)), new(0.000879d, new GammaParticle(2007100.0, 0.00062)), new(0.003516d, new GammaParticle(2030000.0, 0.00061)), new(0.00293d, new GammaParticle(2049000.0, 0.00061)), new(0.017287d, new GammaParticle(2055200.0, 0.0006)), new(0.000879d, new GammaParticle(2074800.0, 0.0006)), new(0.000586d, new GammaParticle(2078800.0, 0.0006)), new(0.000879d, new GammaParticle(2099200.0, 0.00059)), new(0.000293d, new GammaParticle(2106200.0, 0.00059)), new(0.013478d, new GammaParticle(2125900.0, 0.00058)), new(0.007032d, new GammaParticle(2158900.0, 0.00057)), new(0.013771d, new GammaParticle(2195600.0, 0.00056)), new(0.0021389d, new GammaParticle(2218500.0, 0.00056)), new(0.0010548d, new GammaParticle(2235800.0, 0.00055)), new(0.002344d, new GammaParticle(2276500.0, 0.00054)), new(0.001172d, new GammaParticle(2302500.0, 0.00054)), new(0.0013771d, new GammaParticle(2437500.0, 0.00051)), new(0.025491d, new GammaParticle(2541800.0, 0.00049)), new(0.0009962d, new GammaParticle(2564200.0, 0.00048)), new(0.0010841000000000002d, new GammaParticle(2574800.0, 0.00048)), new(0.00586d, new GammaParticle(2591600.0, 0.00048)), new(0.0007618d, new GammaParticle(2602700.0, 0.00048)), new(0.000586d, new GammaParticle(2617000.0, 0.00047)), new(0.016994d, new GammaParticle(2785400.0, 0.00045)), new(0.0038090000000000003d, new GammaParticle(2813200.0, 0.00044)), new(0.000586d, new GammaParticle(2852200.0, 0.00043)), new(0.009962d, new GammaParticle(2858600.0, 0.00043)), new(0.0007911d, new GammaParticle(2871200.0, 0.00043)), new(0.0001465d, new GammaParticle(2919800.0, 0.00042)), new(0.0010841000000000002d, new GammaParticle(2942800.0, 0.00042)), new(0.0012306d, new GammaParticle(3013400.0, 0.00041)), new(0.0004395d, new GammaParticle(3029500.0, 0.00041)), new(0.0012013d, new GammaParticle(3034800.0, 0.00041)), new(0.003516d, new GammaParticle(3050700.0, 0.00041)), new(0.0007618d, new GammaParticle(3065600.0, 0.0004)), new(0.0004102d, new GammaParticle(3139800.0, 0.00039)), new(0.000879d, new GammaParticle(3316700.0, 0.00037)), new(0.0002051d, new GammaParticle(3360900.0, 0.00037)), new(0.0010841000000000002d, new GammaParticle(3395600.0, 0.00037)), new(0.00011719999999999999d, new GammaParticle(3418500.0, 0.00036)), new(0.0001758d, new GammaParticle(3427300.0, 0.00036)), new(0.208114d, new GammaParticle(511000.0, 0.00243)), new(0.0567d, new GammaParticle(3571.0, 0.3472)), new(0.187d, new GammaParticle(24001.0, 0.05166)), new(0.35100000000000003d, new GammaParticle(24209.0, 0.05121)), new(0.099d, new GammaParticle(27367.0, 0.0453)), new(0.11699999999999999d, new GammaParticle(27581.0, 0.04495)), new(0.0187d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.000000525319d },
            { 200.0d, 0.000000908079d },
            { 300.0d, 0.00000135632d },
            { 400.0d, 0.00000187411d },
            { 500.0d, 0.00000246893d },
            { 600.0d, 0.00000314574d },
            { 700.0d, 0.00000390926d },
            { 800.0d, 0.00000476371d },
            { 900.0d, 0.00000571344d },
            { 1000.0d, 0.00000676204d },
            { 1500.0d, 0.0000136121d },
            { 2000.0d, 0.0000234234d },
            { 2500.0d, 0.0000365055d },
            { 3000.0d, 0.0000530686d },
            { 3500.0d, 0.0000732212d },
            { 4000.0d, 0.0000969726d },
            { 4500.0d, 0.000124236d },
            { 5000.0d, 0.000154831d },
            { 5500.0d, 0.0001885d },
            { 6000.0d, 0.000224907d },
            { 6500.0d, 0.000263652d },
            { 7000.0d, 0.00030428d },
            { 7500.0d, 0.000346292d },
            { 8000.0d, 0.000389149d },
            { 8500.0d, 0.000432294d },
            { 9000.0d, 0.000475149d },
            { 9500.0d, 0.000517132d },
            { 10000.0d, 0.000557661d },
            { 11000.0d, 0.000632101d },
            { 12000.0d, 0.000694181d },
            { 13000.0d, 0.000740143d },
            { 14000.0d, 0.000766947d },
            { 15000.0d, 0.000772446d },
            { 16000.0d, 0.000755524d },
            { 17000.0d, 0.0007162d },
            { 18000.0d, 0.000655717d },
            { 19000.0d, 0.000576617d },
            { 20000.0d, 0.000482778d },
            { 21000.0d, 0.000379455d },
            { 22000.0d, 0.000273298d },
            { 23000.0d, 0.000172353d },
            { 24000.0d, 0.0000860732d },
            { 25000.0d, 0.0000252971d },
            { 26000.0d, 0.00000223459d },
            { 27000.0d, 0.00000244028d },
            { 28000.0d, 0.00000265457d },
            { 29000.0d, 0.0000028768d },
            { 30000.0d, 0.00000310733d },
            { 31000.0d, 0.0000033452d },
            { 32000.0d, 0.0000035909d },
            { 33000.0d, 0.00000384388d },
            { 34000.0d, 0.00000410423d },
            { 35000.0d, 0.00000437178d },
            { 36000.0d, 0.00000464565d },
            { 37000.0d, 0.0000049257d },
            { 38000.0d, 0.00000521229d },
            { 39000.0d, 0.00000550519d },
            { 40000.0d, 0.0000058043d },
            { 41000.0d, 0.00000610854d },
            { 42000.0d, 0.00000641854d },
            { 43000.0d, 0.00000673359d },
            { 44000.0d, 0.00000705405d },
            { 45000.0d, 0.00000737943d },
            { 46000.0d, 0.00000770923d },
            { 47000.0d, 0.00000804374d },
            { 48000.0d, 0.00000838296d },
            { 49000.0d, 0.00000872624d },
            { 50000.0d, 0.00000907361d },
            { 51000.0d, 0.00000942458d },
            { 52000.0d, 0.00000977942d },
            { 53000.0d, 0.0000101377d },
            { 54000.0d, 0.0000104997d },
            { 55000.0d, 0.0000108651d },
            { 56000.0d, 0.0000112334d },
            { 57000.0d, 0.0000116045d },
            { 58000.0d, 0.0000119785d },
            { 59000.0d, 0.0000123553d },
            { 60000.0d, 0.000012735d },
            { 61000.0d, 0.0000131167d },
            { 62000.0d, 0.0000135009d },
            { 63000.0d, 0.0000138874d },
            { 64000.0d, 0.000014276d },
            { 65000.0d, 0.0000146666d },
            { 66000.0d, 0.000015059d },
            { 67000.0d, 0.0000154531d },
            { 68000.0d, 0.0000158491d },
            { 69000.0d, 0.0000162466d },
            { 70000.0d, 0.0000166458d },
            { 71000.0d, 0.000017046d },
            { 72000.0d, 0.0000174477d },
            { 73000.0d, 0.0000178505d },
            { 74000.0d, 0.0000182545d },
            { 75000.0d, 0.0000186597d },
            { 76000.0d, 0.0000190657d },
            { 77000.0d, 0.0000194726d },
            { 78000.0d, 0.0000198803d },
            { 79000.0d, 0.0000202887d },
            { 80000.0d, 0.0000206979d },
            { 81000.0d, 0.0000211075d },
            { 82000.0d, 0.0000215177d },
            { 83000.0d, 0.0000219283d },
            { 84000.0d, 0.0000223396d },
            { 85000.0d, 0.000022751d },
            { 86000.0d, 0.0000231626d },
            { 87000.0d, 0.0000235744d },
            { 88000.0d, 0.0000239864d },
            { 89000.0d, 0.0000243986d },
            { 90000.0d, 0.0000248109d },
            { 91000.0d, 0.0000252231d },
            { 92000.0d, 0.0000256352d },
            { 93000.0d, 0.0000260472d },
            { 94000.0d, 0.000026459d },
            { 95000.0d, 0.0000268708d },
            { 96000.0d, 0.0000272823d },
            { 97000.0d, 0.0000276934d },
            { 98000.0d, 0.0000281043d },
            { 99000.0d, 0.0000285148d },
            { 100000.0d, 0.0000289249d },
            { 107000.0d, 0.0000317811d },
            { 114000.0d, 0.0000346045d },
            { 121000.0d, 0.0000373858d },
            { 128000.0d, 0.0000401176d },
            { 135000.0d, 0.0000427941d },
            { 142000.0d, 0.0000454109d },
            { 149000.0d, 0.0000479645d },
            { 156000.0d, 0.0000504527d },
            { 163000.0d, 0.0000528736d },
            { 170000.0d, 0.0000552262d },
            { 177000.0d, 0.0000575101d },
            { 184000.0d, 0.0000597253d },
            { 191000.0d, 0.0000618723d },
            { 198000.0d, 0.0000639517d },
            { 205000.0d, 0.0000659648d },
            { 212000.0d, 0.0000679129d },
            { 219000.0d, 0.0000697977d },
            { 226000.0d, 0.0000716205d },
            { 233000.0d, 0.0000733832d },
            { 240000.0d, 0.0000750876d },
            { 247000.0d, 0.0000767346d },
            { 254000.0d, 0.000078323d },
            { 261000.0d, 0.000079854d },
            { 268000.0d, 0.0000813296d },
            { 275000.0d, 0.0000827518d },
            { 282000.0d, 0.0000841167d },
            { 289000.0d, 0.0000854222d },
            { 296000.0d, 0.0000866691d },
            { 303000.0d, 0.0000878551d },
            { 310000.0d, 0.00008898d },
            { 317000.0d, 0.0000900453d },
            { 324000.0d, 0.0000910517d },
            { 331000.0d, 0.0000920004d },
            { 338000.0d, 0.0000928912d },
            { 345000.0d, 0.0000937253d },
            { 352000.0d, 0.0000945036d },
            { 359000.0d, 0.0000952276d },
            { 366000.0d, 0.0000958981d },
            { 373000.0d, 0.0000965162d },
            { 380000.0d, 0.0000970828d },
            { 387000.0d, 0.0000975992d },
            { 394000.0d, 0.0000980667d },
            { 401000.0d, 0.0000984865d },
            { 408000.0d, 0.0000988599d },
            { 415000.0d, 0.0000991883d },
            { 422000.0d, 0.0000994732d },
            { 429000.0d, 0.0000997156d },
            { 436000.0d, 0.0000999163d },
            { 443000.0d, 0.000100076d },
            { 450000.0d, 0.000100197d },
            { 457000.0d, 0.000100281d },
            { 464000.0d, 0.000100328d },
            { 471000.0d, 0.000100341d },
            { 478000.0d, 0.000100321d },
            { 485000.0d, 0.000100269d },
            { 492000.0d, 0.000100186d },
            { 499000.0d, 0.000100073d },
            { 506000.0d, 0.0000999329d },
            { 513000.0d, 0.0000997662d },
            { 520000.0d, 0.0000995749d },
            { 527000.0d, 0.0000993607d },
            { 534000.0d, 0.000099125d },
            { 541000.0d, 0.000098868d },
            { 548000.0d, 0.0000985912d },
            { 555000.0d, 0.0000982965d },
            { 562000.0d, 0.0000979854d },
            { 569000.0d, 0.0000976586d },
            { 576000.0d, 0.0000973166d },
            { 583000.0d, 0.0000969614d },
            { 590000.0d, 0.0000965943d },
            { 597000.0d, 0.0000962169d },
            { 604000.0d, 0.0000958308d },
            { 611000.0d, 0.0000954365d },
            { 618000.0d, 0.0000950354d },
            { 625000.0d, 0.000094623d },
            { 632000.0d, 0.0000941985d },
            { 639000.0d, 0.0000937633d },
            { 646000.0d, 0.0000933187d },
            { 653000.0d, 0.0000928659d },
            { 660000.0d, 0.0000924064d },
            { 667000.0d, 0.0000919414d },
            { 674000.0d, 0.0000914727d },
            { 681000.0d, 0.0000910012d },
            { 688000.0d, 0.0000905283d },
            { 695000.0d, 0.0000900545d },
            { 702000.0d, 0.0000895764d },
            { 709000.0d, 0.000089082d },
            { 716000.0d, 0.0000885706d },
            { 723000.0d, 0.0000880418d },
            { 730000.0d, 0.0000874961d },
            { 737000.0d, 0.0000869344d },
            { 744000.0d, 0.0000863571d },
            { 751000.0d, 0.0000857649d },
            { 758000.0d, 0.0000851586d },
            { 765000.0d, 0.0000845384d },
            { 772000.0d, 0.0000839055d },
            { 779000.0d, 0.0000832595d },
            { 786000.0d, 0.0000825995d },
            { 793000.0d, 0.0000819245d },
            { 800000.0d, 0.0000812351d },
            { 807000.0d, 0.000080532d },
            { 814000.0d, 0.0000798155d },
            { 821000.0d, 0.0000790863d },
            { 828000.0d, 0.000078345d },
            { 835000.0d, 0.0000775922d },
            { 842000.0d, 0.0000768281d },
            { 849000.0d, 0.0000760539d },
            { 856000.0d, 0.0000752697d },
            { 863000.0d, 0.0000744764d },
            { 870000.0d, 0.0000736746d },
            { 877000.0d, 0.0000728648d },
            { 884000.0d, 0.0000720473d },
            { 891000.0d, 0.0000712223d },
            { 898000.0d, 0.0000703902d },
            { 905000.0d, 0.0000695517d },
            { 912000.0d, 0.0000687074d },
            { 919000.0d, 0.000067858d },
            { 926000.0d, 0.0000670043d },
            { 933000.0d, 0.0000661464d },
            { 940000.0d, 0.0000652856d },
            { 947000.0d, 0.0000644221d },
            { 954000.0d, 0.0000635569d },
            { 961000.0d, 0.0000626905d },
            { 968000.0d, 0.0000618235d },
            { 975000.0d, 0.0000609567d },
            { 982000.0d, 0.0000600909d },
            { 989000.0d, 0.0000592267d },
            { 996000.0d, 0.0000583642d },
            { 1003000.0d, 0.0000575036d },
            { 1010000.0d, 0.0000566446d },
            { 1017000.0d, 0.0000557888d },
            { 1024000.0d, 0.0000549351d },
            { 1031000.0d, 0.0000540828d },
            { 1038000.0d, 0.0000532321d },
            { 1045000.0d, 0.0000523837d },
            { 1052000.0d, 0.0000515385d },
            { 1059000.0d, 0.0000506969d },
            { 1066000.0d, 0.0000498597d },
            { 1073000.0d, 0.0000490273d },
            { 1080000.0d, 0.0000482003d },
            { 1087000.0d, 0.000047378d },
            { 1094000.0d, 0.0000465607d },
            { 1101000.0d, 0.0000457492d },
            { 1108000.0d, 0.000044944d },
            { 1115000.0d, 0.0000441457d },
            { 1122000.0d, 0.0000433518d },
            { 1129000.0d, 0.0000425616d },
            { 1136000.0d, 0.0000417747d },
            { 1143000.0d, 0.0000409917d },
            { 1150000.0d, 0.000040213d },
            { 1157000.0d, 0.0000394391d },
            { 1164000.0d, 0.0000386706d },
            { 1171000.0d, 0.000037908d },
            { 1178000.0d, 0.0000371518d },
            { 1185000.0d, 0.0000364024d },
            { 1192000.0d, 0.0000356605d },
            { 1199000.0d, 0.0000349265d },
            { 1206000.0d, 0.0000342009d },
            { 1213000.0d, 0.0000334844d },
            { 1220000.0d, 0.0000327773d },
            { 1227000.0d, 0.0000320804d },
            { 1234000.0d, 0.0000313941d },
            { 1241000.0d, 0.0000307188d },
            { 1248000.0d, 0.0000300554d },
            { 1255000.0d, 0.0000294042d },
            { 1262000.0d, 0.0000287658d },
            { 1269000.0d, 0.0000281374d },
            { 1276000.0d, 0.0000275178d },
            { 1283000.0d, 0.0000269074d },
            { 1290000.0d, 0.0000263066d },
            { 1297000.0d, 0.000025716d },
            { 1304000.0d, 0.0000251357d },
            { 1311000.0d, 0.0000245666d },
            { 1318000.0d, 0.0000240089d },
            { 1325000.0d, 0.0000234632d },
            { 1332000.0d, 0.0000229299d },
            { 1339000.0d, 0.0000224096d },
            { 1346000.0d, 0.0000219025d },
            { 1353000.0d, 0.0000214092d },
            { 1360000.0d, 0.0000209251d },
            { 1367000.0d, 0.0000204479d },
            { 1374000.0d, 0.0000199779d },
            { 1381000.0d, 0.0000195154d },
            { 1388000.0d, 0.0000190608d },
            { 1395000.0d, 0.0000186143d },
            { 1402000.0d, 0.000018175d },
            { 1409000.0d, 0.0000177424d },
            { 1416000.0d, 0.0000173168d },
            { 1423000.0d, 0.0000168985d },
            { 1430000.0d, 0.0000164878d },
            { 1437000.0d, 0.0000160851d },
            { 1444000.0d, 0.0000156905d },
            { 1451000.0d, 0.0000153045d },
            { 1458000.0d, 0.0000149273d },
            { 1465000.0d, 0.0000145593d },
            { 1472000.0d, 0.0000142008d },
            { 1479000.0d, 0.0000138521d },
            { 1486000.0d, 0.0000135136d },
            { 1493000.0d, 0.0000131855d },
            { 1500000.0d, 0.0000128682d },
            { 1507000.0d, 0.0000125611d },
            { 1514000.0d, 0.0000122638d },
            { 1521000.0d, 0.0000119728d },
            { 1528000.0d, 0.0000116849d },
            { 1535000.0d, 0.0000114001d },
            { 1542000.0d, 0.0000111187d },
            { 1549000.0d, 0.0000108408d },
            { 1556000.0d, 0.0000105667d },
            { 1563000.0d, 0.0000102964d },
            { 1570000.0d, 0.0000100303d },
            { 1577000.0d, 0.00000976839d },
            { 1584000.0d, 0.00000951102d },
            { 1591000.0d, 0.0000092583d },
            { 1598000.0d, 0.00000901049d },
            { 1605000.0d, 0.00000876776d },
            { 1612000.0d, 0.00000853033d },
            { 1619000.0d, 0.00000829843d },
            { 1626000.0d, 0.00000807225d },
            { 1633000.0d, 0.00000785204d },
            { 1640000.0d, 0.000007638d },
            { 1647000.0d, 0.00000743038d },
            { 1654000.0d, 0.00000722941d },
            { 1661000.0d, 0.0000070353d },
            { 1668000.0d, 0.00000684781d },
            { 1675000.0d, 0.00000666575d },
            { 1682000.0d, 0.00000648922d },
            { 1689000.0d, 0.0000063184d },
            { 1696000.0d, 0.00000615345d },
            { 1703000.0d, 0.00000599457d },
            { 1710000.0d, 0.00000584193d },
            { 1717000.0d, 0.00000569571d },
            { 1724000.0d, 0.0000055561d },
            { 1731000.0d, 0.00000542327d },
            { 1738000.0d, 0.00000529713d },
            { 1745000.0d, 0.00000517334d },
            { 1752000.0d, 0.00000505037d },
            { 1759000.0d, 0.00000492833d },
            { 1766000.0d, 0.00000480731d },
            { 1773000.0d, 0.00000468739d },
            { 1780000.0d, 0.00000456868d },
            { 1787000.0d, 0.00000445128d },
            { 1794000.0d, 0.00000433531d },
            { 1801000.0d, 0.00000422087d },
            { 1808000.0d, 0.00000410807d },
            { 1815000.0d, 0.0000039966d },
            { 1822000.0d, 0.00000388582d },
            { 1829000.0d, 0.00000377579d },
            { 1836000.0d, 0.00000366654d },
            { 1843000.0d, 0.00000355817d },
            { 1850000.0d, 0.00000345072d },
            { 1857000.0d, 0.00000334419d },
            { 1864000.0d, 0.00000323807d },
            { 1871000.0d, 0.0000031323d },
            { 1878000.0d, 0.00000302696d },
            { 1885000.0d, 0.00000292208d },
            { 1892000.0d, 0.00000281773d },
            { 1899000.0d, 0.00000271397d },
            { 1906000.0d, 0.00000261088d },
            { 1913000.0d, 0.0000025085d },
            { 1920000.0d, 0.00000240693d },
            { 1927000.0d, 0.00000230621d },
            { 1934000.0d, 0.00000220642d },
            { 1941000.0d, 0.00000210764d },
            { 1948000.0d, 0.00000200994d },
            { 1955000.0d, 0.00000191339d },
            { 1962000.0d, 0.00000181809d },
            { 1969000.0d, 0.0000017241d },
            { 1976000.0d, 0.00000163151d },
            { 1983000.0d, 0.0000015404d },
            { 1990000.0d, 0.00000145087d },
            { 1997000.0d, 0.00000136298d },
            { 2004000.0d, 0.00000127686d },
            { 2011000.0d, 0.00000119257d },
            { 2018000.0d, 0.00000111022d },
            { 2025000.0d, 0.00000102991d },
            { 2032000.0d, 0.000000951725d },
            { 2039000.0d, 0.000000875779d },
            { 2046000.0d, 0.00000080217d },
            { 2053000.0d, 0.000000731006d },
            { 2060000.0d, 0.000000662393d },
            { 2067000.0d, 0.000000596441d },
            { 2074000.0d, 0.000000533264d },
            { 2081000.0d, 0.000000472975d },
            { 2088000.0d, 0.000000415693d },
            { 2095000.0d, 0.000000361536d },
            { 2102000.0d, 0.000000310625d },
            { 2109000.0d, 0.000000263084d },
            { 2116000.0d, 0.00000021904d },
            { 2123000.0d, 0.00000017862d },
            { 2130000.0d, 0.000000141955d },
            { 2137000.0d, 0.000000109178d },
            { 2144000.0d, 0.0000000804232d },
            { 2151000.0d, 0.0000000558272d },
            { 2158000.0d, 0.0000000355278d },
            { 2165000.0d, 0.0000000196641d },
            { 2172000.0d, 0.00000000837518d },
            { 2179000.0d, 0.0000000017975d },
            { 2185000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    