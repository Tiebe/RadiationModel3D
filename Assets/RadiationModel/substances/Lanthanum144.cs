using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum144 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum144";
        public override double halfLife { get; } = 40.8d;
        public override double atomicWeight { get; } = 143.91965d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium144()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0147108d, new GammaParticle(303600.0, 0.00408)), new(0.004715d, new GammaParticle(340200.0, 0.00364)), new(0.0027347d, new GammaParticle(357300.0, 0.00347)), new(0.0146165d, new GammaParticle(367300.0, 0.00338)), new(0.943d, new GammaParticle(397440.0, 0.00312)), new(0.0363055d, new GammaParticle(431400.0, 0.00287)), new(0.0075439999999999995d, new GammaParticle(449500.0, 0.00276)), new(0.01886d, new GammaParticle(453400.0, 0.00273)), new(0.0051865d, new GammaParticle(467700.0, 0.00265)), new(0.39228799999999997d, new GammaParticle(541200.0, 0.00229)), new(0.0796835d, new GammaParticle(585020.0, 0.00212)), new(0.00943d, new GammaParticle(587000.0, 0.00211)), new(0.0050922d, new GammaParticle(597200.0, 0.00208)), new(0.002829d, new GammaParticle(621800.0, 0.00199)), new(0.0148994d, new GammaParticle(643000.0, 0.00193)), new(0.0110331d, new GammaParticle(662500.0, 0.00187)), new(0.0417749d, new GammaParticle(705400.0, 0.00176)), new(0.0709136d, new GammaParticle(735200.0, 0.00169)), new(0.0073554d, new GammaParticle(746900.0, 0.00166)), new(0.0152766d, new GammaParticle(751700.0, 0.00165)), new(0.0037719999999999997d, new GammaParticle(763400.0, 0.00162)), new(0.0049979d, new GammaParticle(798500.0, 0.00155)), new(0.0049036d, new GammaParticle(813200.0, 0.00152)), new(0.0087699d, new GammaParticle(833600.0, 0.00149)), new(0.222548d, new GammaParticle(844800.0, 0.00147)), new(0.010467299999999999d, new GammaParticle(853200.0, 0.00145)), new(0.0013201999999999999d, new GammaParticle(857800.0, 0.00145)), new(0.0055637d, new GammaParticle(860800.0, 0.00144)), new(0.0050922d, new GammaParticle(871900.0, 0.00142)), new(0.0126362d, new GammaParticle(890400.0, 0.00139)), new(0.0059409d, new GammaParticle(907300.0, 0.00137)), new(0.01886d, new GammaParticle(950900.0, 0.0013)), new(0.029233d, new GammaParticle(952200.0, 0.0013)), new(0.0035834d, new GammaParticle(957900.0, 0.00129)), new(0.0330993d, new GammaParticle(968800.0, 0.00128)), new(0.0051865d, new GammaParticle(974200.0, 0.00127)), new(0.0189543d, new GammaParticle(978500.0, 0.00127)), new(0.0016031d, new GammaParticle(1006200.0, 0.00123)), new(0.0043378d, new GammaParticle(1010800.0, 0.00123)), new(0.0026403999999999998d, new GammaParticle(1017800.0, 0.00122)), new(0.0018859999999999999d, new GammaParticle(1044500.0, 0.00119)), new(0.0201802d, new GammaParticle(1052700.0, 0.00118)), new(0.0035834d, new GammaParticle(1062900.0, 0.00117)), new(0.0099015d, new GammaParticle(1070200.0, 0.00116)), new(0.0054694d, new GammaParticle(1082700.0, 0.00115)), new(0.0075439999999999995d, new GammaParticle(1084300.0, 0.00114)), new(0.0100901d, new GammaParticle(1092100.0, 0.00114)), new(0.0125419d, new GammaParticle(1102100.0, 0.00112)), new(0.0043378d, new GammaParticle(1153000.0, 0.00108)), new(0.0046207d, new GammaParticle(1170200.0, 0.00106)), new(0.0049036d, new GammaParticle(1176200.0, 0.00105)), new(0.004715d, new GammaParticle(1190400.0, 0.00104)), new(0.0049036d, new GammaParticle(1212000.0, 0.00102)), new(0.0049036d, new GammaParticle(1214500.0, 0.00102)), new(0.0039606d, new GammaParticle(1217800.0, 0.00102)), new(0.0059409d, new GammaParticle(1237800.0, 0.001)), new(0.0037719999999999997d, new GammaParticle(1247400.0, 0.00099)), new(0.0161253d, new GammaParticle(1276300.0, 0.00097)), new(0.0033005d, new GammaParticle(1282100.0, 0.00097)), new(0.03772d, new GammaParticle(1294200.0, 0.00096)), new(0.027347d, new GammaParticle(1294400.0, 0.00096)), new(0.0018859999999999999d, new GammaParticle(1307400.0, 0.00095)), new(0.004715d, new GammaParticle(1308400.0, 0.00095)), new(0.0149937d, new GammaParticle(1347800.0, 0.00092)), new(0.002829d, new GammaParticle(1357800.0, 0.00091)), new(0.0043378d, new GammaParticle(1367600.0, 0.00091)), new(0.0074497d, new GammaParticle(1380100.0, 0.0009)), new(0.0064124d, new GammaParticle(1387500.0, 0.00089)), new(0.0071668d, new GammaParticle(1401100.0, 0.00088)), new(0.0054694d, new GammaParticle(1413900.0, 0.00088)), new(0.011316d, new GammaParticle(1421800.0, 0.00087)), new(0.0417749d, new GammaParticle(1431400.0, 0.00087)), new(0.0013201999999999999d, new GammaParticle(1437800.0, 0.00086)), new(0.0038662999999999996d, new GammaParticle(1450200.0, 0.00085)), new(0.006035199999999999d, new GammaParticle(1467100.0, 0.00085)), new(0.014145000000000001d, new GammaParticle(1489600.0, 0.00083)), new(0.0069782d, new GammaParticle(1499300.0, 0.00083)), new(0.0038662999999999996d, new GammaParticle(1505700.0, 0.00082)), new(0.0347967d, new GammaParticle(1523500.0, 0.00081)), new(0.0069782d, new GammaParticle(1623800.0, 0.00076)), new(0.010373d, new GammaParticle(1631800.0, 0.00076)), new(0.0075439999999999995d, new GammaParticle(1639800.0, 0.00076)), new(0.002829d, new GammaParticle(1641900.0, 0.00076)), new(0.006601d, new GammaParticle(1661400.0, 0.00075)), new(0.013862099999999999d, new GammaParticle(1673700.0, 0.00074)), new(0.006883899999999999d, new GammaParticle(1683100.0, 0.00074)), new(0.0098072d, new GammaParticle(1714600.0, 0.00072)), new(0.0087699d, new GammaParticle(1715600.0, 0.00072)), new(0.0041492000000000005d, new GammaParticle(1754700.0, 0.00071)), new(0.010561599999999999d, new GammaParticle(1755500.0, 0.00071)), new(0.0034891d, new GammaParticle(1756800.0, 0.00071)), new(0.0059409d, new GammaParticle(1765700.0, 0.0007)), new(0.0066952999999999995d, new GammaParticle(1804400.0, 0.00069)), new(0.0038662999999999996d, new GammaParticle(1818000.0, 0.00068)), new(0.0012259d, new GammaParticle(1819100.0, 0.00068)), new(0.0026403999999999998d, new GammaParticle(1842900.0, 0.00067)), new(0.002829d, new GammaParticle(1863800.0, 0.00067)), new(0.002829d, new GammaParticle(1864200.0, 0.00067)), new(0.0020746000000000002d, new GammaParticle(1930900.0, 0.00064)), new(0.0139564d, new GammaParticle(1942200.0, 0.00064)), new(0.0031119000000000003d, new GammaParticle(1942700.0, 0.00064)), new(0.0050922d, new GammaParticle(1955100.0, 0.00063)), new(0.0092414d, new GammaParticle(1955200.0, 0.00063)), new(0.0033948d, new GammaParticle(1965000.0, 0.00063)), new(0.0036777d, new GammaParticle(1966800.0, 0.00063)), new(0.028290000000000003d, new GammaParticle(1996400.0, 0.00062)), new(0.011693199999999999d, new GammaParticle(2007800.0, 0.00062)), new(0.0034891d, new GammaParticle(2028700.0, 0.00061)), new(0.0043378d, new GammaParticle(2036500.0, 0.00061)), new(0.0076383d, new GammaParticle(2050000.0, 0.0006)), new(0.0052807999999999996d, new GammaParticle(2051400.0, 0.0006)), new(0.0021689d, new GammaParticle(2112000.0, 0.00059)), new(0.0005658d, new GammaParticle(2131000.0, 0.00058)), new(0.002829d, new GammaParticle(2137400.0, 0.00058)), new(0.0018859999999999999d, new GammaParticle(2150800.0, 0.00058)), new(0.002829d, new GammaParticle(2152800.0, 0.00058)), new(0.0025461d, new GammaParticle(2154000.0, 0.00058)), new(0.0033948d, new GammaParticle(2166500.0, 0.00057)), new(0.0011316d, new GammaParticle(2182100.0, 0.00057)), new(0.0016974d, new GammaParticle(2184200.0, 0.00057)), new(0.0065067d, new GammaParticle(2258700.0, 0.00055)), new(0.0033005d, new GammaParticle(2300000.0, 0.00054)), new(0.0034891d, new GammaParticle(2323700.0, 0.00053)), new(0.005658d, new GammaParticle(2324400.0, 0.00053)), new(0.0027347d, new GammaParticle(2339500.0, 0.00053)), new(0.0022632d, new GammaParticle(2340000.0, 0.00053)), new(0.0025461d, new GammaParticle(2352400.0, 0.00053)), new(0.004715d, new GammaParticle(2352900.0, 0.00053)), new(0.0020746000000000002d, new GammaParticle(2353600.0, 0.00053)), new(0.0013201999999999999d, new GammaParticle(2372000.0, 0.00052)), new(0.0023575d, new GammaParticle(2386800.0, 0.00052)), new(0.0023575d, new GammaParticle(2390300.0, 0.00052)), new(0.0014145d, new GammaParticle(2464200.0, 0.0005)), new(0.0036777d, new GammaParticle(2540000.0, 0.00049)), new(0.0011316d, new GammaParticle(2547600.0, 0.00049)), new(0.0196144d, new GammaParticle(2662700.0, 0.00047)), new(0.0012259d, new GammaParticle(2731400.0, 0.00045)), new(0.0012259d, new GammaParticle(2749900.0, 0.00045)), new(0.010373d, new GammaParticle(2865200.0, 0.00043)), new(0.0031119000000000003d, new GammaParticle(2881900.0, 0.00043)), new(0.0030175999999999996d, new GammaParticle(2896200.0, 0.00043)), new(0.0020746000000000002d, new GammaParticle(2998900.0, 0.00041)), new(0.0018859999999999999d, new GammaParticle(3007400.0, 0.00041)), new(0.0024518d, new GammaParticle(3027400.0, 0.00041)), new(0.0012259d, new GammaParticle(3060000.0, 0.00041)), new(0.0011316d, new GammaParticle(3628900.0, 0.00034)), new(0.0009429999999999999d, new GammaParticle(3632400.0, 0.00034)), new(0.00269539754052545d, new GammaParticle(5410.0, 0.22918)), new(0.005349664305311805d, new GammaParticle(34279.0, 0.03617)), new(0.009797919973098545d, new GammaParticle(34720.0, 0.03571)), new(0.0029510006692309797d, new GammaParticle(39366.0, 0.0315)), new(0.0037005548392156484d, new GammaParticle(39753.0, 0.03119)), new(0.0007495541699846689d, new GammaParticle(40229.0, 0.03082)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000200679d },
            { 5000.0d, 0.000203459d },
            { 10000.0d, 0.000206153d },
            { 15000.0d, 0.000208761d },
            { 20000.0d, 0.000211291d },
            { 25000.0d, 0.000213781d },
            { 30000.0d, 0.000216251d },
            { 35000.0d, 0.000218711d },
            { 40000.0d, 0.000221167d },
            { 45000.0d, 0.000223625d },
            { 50000.0d, 0.000226087d },
            { 55000.0d, 0.000228556d },
            { 60000.0d, 0.000231033d },
            { 65000.0d, 0.000233517d },
            { 70000.0d, 0.000236009d },
            { 75000.0d, 0.000238509d },
            { 80000.0d, 0.000241015d },
            { 85000.0d, 0.000243528d },
            { 90000.0d, 0.000246045d },
            { 95000.0d, 0.000248568d },
            { 100000.0d, 0.000251094d },
            { 110000.0d, 0.000256155d },
            { 120000.0d, 0.000261222d },
            { 130000.0d, 0.00026629d },
            { 140000.0d, 0.000271355d },
            { 150000.0d, 0.00027641d },
            { 160000.0d, 0.000281453d },
            { 170000.0d, 0.000286479d },
            { 180000.0d, 0.000291485d },
            { 190000.0d, 0.000296468d },
            { 200000.0d, 0.000301425d },
            { 210000.0d, 0.000306353d },
            { 220000.0d, 0.00031125d },
            { 230000.0d, 0.000316114d },
            { 240000.0d, 0.000320941d },
            { 250000.0d, 0.000325731d },
            { 260000.0d, 0.000330481d },
            { 270000.0d, 0.00033519d },
            { 280000.0d, 0.000339855d },
            { 290000.0d, 0.000344476d },
            { 300000.0d, 0.000349051d },
            { 310000.0d, 0.000353578d },
            { 320000.0d, 0.000358055d },
            { 330000.0d, 0.000362483d },
            { 340000.0d, 0.000366859d },
            { 350000.0d, 0.000371182d },
            { 360000.0d, 0.000375451d },
            { 370000.0d, 0.000379665d },
            { 380000.0d, 0.000383823d },
            { 390000.0d, 0.000387924d },
            { 400000.0d, 0.000391967d },
            { 410000.0d, 0.000395951d },
            { 420000.0d, 0.000399876d },
            { 430000.0d, 0.000403739d },
            { 440000.0d, 0.000407541d },
            { 450000.0d, 0.000411281d },
            { 460000.0d, 0.000414958d },
            { 470000.0d, 0.000418572d },
            { 480000.0d, 0.00042212d },
            { 490000.0d, 0.000425604d },
            { 500000.0d, 0.000429022d },
            { 510000.0d, 0.000432374d },
            { 520000.0d, 0.000435659d },
            { 530000.0d, 0.000438877d },
            { 540000.0d, 0.000442027d },
            { 550000.0d, 0.000445109d },
            { 560000.0d, 0.000448121d },
            { 570000.0d, 0.000451065d },
            { 580000.0d, 0.000453938d },
            { 590000.0d, 0.000456742d },
            { 600000.0d, 0.000459475d },
            { 610000.0d, 0.000462137d },
            { 620000.0d, 0.000464727d },
            { 630000.0d, 0.000467247d },
            { 640000.0d, 0.000469694d },
            { 650000.0d, 0.00047207d },
            { 660000.0d, 0.000474372d },
            { 670000.0d, 0.000476603d },
            { 680000.0d, 0.00047876d },
            { 690000.0d, 0.000480845d },
            { 700000.0d, 0.000482856d },
            { 710000.0d, 0.000484793d },
            { 720000.0d, 0.000486657d },
            { 730000.0d, 0.000488448d },
            { 740000.0d, 0.000490165d },
            { 750000.0d, 0.000491807d },
            { 760000.0d, 0.000493376d },
            { 770000.0d, 0.000494871d },
            { 780000.0d, 0.000496291d },
            { 790000.0d, 0.000497638d },
            { 800000.0d, 0.00049891d },
            { 810000.0d, 0.000500108d },
            { 820000.0d, 0.000501233d },
            { 830000.0d, 0.000502282d },
            { 840000.0d, 0.000503259d },
            { 850000.0d, 0.00050416d },
            { 860000.0d, 0.000504989d },
            { 870000.0d, 0.000505743d },
            { 880000.0d, 0.000506424d },
            { 890000.0d, 0.000507031d },
            { 900000.0d, 0.000507565d },
            { 910000.0d, 0.000508025d },
            { 920000.0d, 0.000508413d },
            { 930000.0d, 0.000508727d },
            { 940000.0d, 0.000508969d },
            { 950000.0d, 0.000509139d },
            { 960000.0d, 0.000509236d },
            { 970000.0d, 0.000509261d },
            { 980000.0d, 0.000509215d },
            { 990000.0d, 0.000509098d },
            { 1000000.0d, 0.000508909d },
            { 1017000.0d, 0.000508426d },
            { 1034000.0d, 0.000507739d },
            { 1051000.0d, 0.000506852d },
            { 1068000.0d, 0.000505765d },
            { 1085000.0d, 0.000504482d },
            { 1102000.0d, 0.000503003d },
            { 1119000.0d, 0.000501331d },
            { 1136000.0d, 0.000499469d },
            { 1153000.0d, 0.000497419d },
            { 1170000.0d, 0.000495184d },
            { 1187000.0d, 0.000492767d },
            { 1204000.0d, 0.00049017d },
            { 1221000.0d, 0.000487397d },
            { 1238000.0d, 0.000484451d },
            { 1255000.0d, 0.000481335d },
            { 1272000.0d, 0.000478053d },
            { 1289000.0d, 0.000474609d },
            { 1306000.0d, 0.000471006d },
            { 1323000.0d, 0.000467248d },
            { 1340000.0d, 0.00046334d },
            { 1357000.0d, 0.000459285d },
            { 1374000.0d, 0.000455088d },
            { 1391000.0d, 0.000450754d },
            { 1408000.0d, 0.000446288d },
            { 1425000.0d, 0.000441693d },
            { 1442000.0d, 0.000436976d },
            { 1459000.0d, 0.000432142d },
            { 1476000.0d, 0.000427196d },
            { 1493000.0d, 0.000422143d },
            { 1510000.0d, 0.00041699d },
            { 1527000.0d, 0.000411743d },
            { 1544000.0d, 0.000406407d },
            { 1561000.0d, 0.000400989d },
            { 1578000.0d, 0.000395495d },
            { 1595000.0d, 0.00038993d },
            { 1612000.0d, 0.000384301d },
            { 1629000.0d, 0.000378616d },
            { 1646000.0d, 0.00037288d },
            { 1663000.0d, 0.000367102d },
            { 1680000.0d, 0.000361289d },
            { 1697000.0d, 0.000355449d },
            { 1714000.0d, 0.000349591d },
            { 1731000.0d, 0.000343722d },
            { 1748000.0d, 0.000337852d },
            { 1765000.0d, 0.000331985d },
            { 1782000.0d, 0.000326125d },
            { 1799000.0d, 0.000320282d },
            { 1816000.0d, 0.000314464d },
            { 1833000.0d, 0.00030868d },
            { 1850000.0d, 0.000302932d },
            { 1867000.0d, 0.000297227d },
            { 1884000.0d, 0.000291574d },
            { 1901000.0d, 0.000285983d },
            { 1918000.0d, 0.000280459d },
            { 1935000.0d, 0.000274983d },
            { 1952000.0d, 0.000269552d },
            { 1969000.0d, 0.000264169d },
            { 1986000.0d, 0.000258835d },
            { 2003000.0d, 0.000253547d },
            { 2020000.0d, 0.000248313d },
            { 2037000.0d, 0.00024314d },
            { 2054000.0d, 0.000238035d },
            { 2071000.0d, 0.000233006d },
            { 2088000.0d, 0.000228061d },
            { 2105000.0d, 0.000223206d },
            { 2122000.0d, 0.00021845d },
            { 2139000.0d, 0.000213799d },
            { 2156000.0d, 0.000209252d },
            { 2173000.0d, 0.000204812d },
            { 2190000.0d, 0.000200486d },
            { 2207000.0d, 0.000196282d },
            { 2224000.0d, 0.000192206d },
            { 2241000.0d, 0.000188267d },
            { 2258000.0d, 0.000184472d },
            { 2275000.0d, 0.000180817d },
            { 2292000.0d, 0.0001773d },
            { 2309000.0d, 0.000173912d },
            { 2326000.0d, 0.000170622d },
            { 2343000.0d, 0.000167429d },
            { 2360000.0d, 0.000164294d },
            { 2377000.0d, 0.000161201d },
            { 2394000.0d, 0.000158149d },
            { 2411000.0d, 0.000155139d },
            { 2428000.0d, 0.000152177d },
            { 2445000.0d, 0.000149267d },
            { 2462000.0d, 0.000146414d },
            { 2479000.0d, 0.000143622d },
            { 2496000.0d, 0.000140883d },
            { 2513000.0d, 0.000138184d },
            { 2530000.0d, 0.000135527d },
            { 2547000.0d, 0.000132912d },
            { 2564000.0d, 0.000130332d },
            { 2581000.0d, 0.00012779d },
            { 2598000.0d, 0.000125286d },
            { 2615000.0d, 0.000122824d },
            { 2632000.0d, 0.000120406d },
            { 2649000.0d, 0.000118034d },
            { 2666000.0d, 0.000115707d },
            { 2683000.0d, 0.000113416d },
            { 2700000.0d, 0.000111162d },
            { 2717000.0d, 0.000108947d },
            { 2734000.0d, 0.000106773d },
            { 2751000.0d, 0.000104643d },
            { 2768000.0d, 0.000102558d },
            { 2785000.0d, 0.000100519d },
            { 2802000.0d, 0.0000985296d },
            { 2819000.0d, 0.0000965895d },
            { 2836000.0d, 0.0000947014d },
            { 2853000.0d, 0.0000928674d },
            { 2870000.0d, 0.0000910874d },
            { 2887000.0d, 0.0000893626d },
            { 2904000.0d, 0.0000876942d },
            { 2921000.0d, 0.0000860652d },
            { 2938000.0d, 0.000084469d },
            { 2955000.0d, 0.0000829072d },
            { 2972000.0d, 0.0000813813d },
            { 2989000.0d, 0.000079893d },
            { 3006000.0d, 0.000078443d },
            { 3023000.0d, 0.0000770201d },
            { 3040000.0d, 0.0000756083d },
            { 3057000.0d, 0.0000742081d },
            { 3074000.0d, 0.0000728204d },
            { 3091000.0d, 0.0000714462d },
            { 3108000.0d, 0.0000700851d },
            { 3125000.0d, 0.0000687369d },
            { 3142000.0d, 0.0000674025d },
            { 3159000.0d, 0.0000660823d },
            { 3176000.0d, 0.0000647766d },
            { 3193000.0d, 0.0000634865d },
            { 3210000.0d, 0.000062211d },
            { 3227000.0d, 0.0000609463d },
            { 3244000.0d, 0.0000596928d },
            { 3261000.0d, 0.0000584512d },
            { 3278000.0d, 0.0000572223d },
            { 3295000.0d, 0.0000560071d },
            { 3312000.0d, 0.0000548061d },
            { 3329000.0d, 0.0000536197d },
            { 3346000.0d, 0.0000524448d },
            { 3363000.0d, 0.0000512815d },
            { 3380000.0d, 0.0000501308d },
            { 3397000.0d, 0.0000489932d },
            { 3414000.0d, 0.0000478697d },
            { 3431000.0d, 0.0000467604d },
            { 3448000.0d, 0.000045665d },
            { 3465000.0d, 0.0000445841d },
            { 3482000.0d, 0.0000435182d },
            { 3499000.0d, 0.0000424683d },
            { 3516000.0d, 0.0000414339d },
            { 3533000.0d, 0.0000404135d },
            { 3550000.0d, 0.0000394069d },
            { 3567000.0d, 0.0000384132d },
            { 3584000.0d, 0.0000374314d },
            { 3601000.0d, 0.0000364619d },
            { 3618000.0d, 0.0000355056d },
            { 3635000.0d, 0.000034563d },
            { 3652000.0d, 0.0000336349d },
            { 3669000.0d, 0.0000327219d },
            { 3686000.0d, 0.0000318247d },
            { 3703000.0d, 0.0000309431d },
            { 3720000.0d, 0.000030077d },
            { 3737000.0d, 0.0000292246d },
            { 3754000.0d, 0.0000283855d },
            { 3771000.0d, 0.0000275603d },
            { 3788000.0d, 0.0000267495d },
            { 3805000.0d, 0.0000259539d },
            { 3822000.0d, 0.0000251739d },
            { 3839000.0d, 0.0000244102d },
            { 3856000.0d, 0.0000236634d },
            { 3873000.0d, 0.0000229327d },
            { 3890000.0d, 0.0000222154d },
            { 3907000.0d, 0.0000215108d },
            { 3924000.0d, 0.0000208194d },
            { 3941000.0d, 0.0000201418d },
            { 3958000.0d, 0.0000194785d },
            { 3975000.0d, 0.0000188302d },
            { 3992000.0d, 0.0000181973d },
            { 4009000.0d, 0.0000175805d },
            { 4026000.0d, 0.0000169799d },
            { 4043000.0d, 0.0000163912d },
            { 4060000.0d, 0.000015813d },
            { 4077000.0d, 0.0000152444d },
            { 4094000.0d, 0.0000146855d },
            { 4111000.0d, 0.0000141367d },
            { 4128000.0d, 0.0000135984d },
            { 4145000.0d, 0.0000130707d },
            { 4162000.0d, 0.000012554d },
            { 4179000.0d, 0.0000120486d },
            { 4196000.0d, 0.0000115549d },
            { 4213000.0d, 0.0000110731d },
            { 4230000.0d, 0.0000106035d },
            { 4247000.0d, 0.0000101465d },
            { 4264000.0d, 0.00000970232d },
            { 4281000.0d, 0.00000927134d },
            { 4298000.0d, 0.00000885385d },
            { 4315000.0d, 0.0000084486d },
            { 4332000.0d, 0.00000805352d },
            { 4349000.0d, 0.00000766886d },
            { 4366000.0d, 0.00000729487d },
            { 4383000.0d, 0.00000693181d },
            { 4400000.0d, 0.00000657994d },
            { 4417000.0d, 0.0000062395d },
            { 4434000.0d, 0.00000591077d },
            { 4451000.0d, 0.00000559399d },
            { 4468000.0d, 0.00000528943d },
            { 4485000.0d, 0.00000499734d },
            { 4502000.0d, 0.00000471799d },
            { 4519000.0d, 0.00000445163d },
            { 4536000.0d, 0.0000041985d },
            { 4553000.0d, 0.00000395887d },
            { 4570000.0d, 0.00000373296d },
            { 4587000.0d, 0.00000352102d },
            { 4604000.0d, 0.00000332295d },
            { 4621000.0d, 0.00000313216d },
            { 4638000.0d, 0.0000029459d },
            { 4655000.0d, 0.00000276427d },
            { 4672000.0d, 0.00000258739d },
            { 4689000.0d, 0.00000241536d },
            { 4706000.0d, 0.00000224829d },
            { 4723000.0d, 0.00000208628d },
            { 4740000.0d, 0.00000192945d },
            { 4757000.0d, 0.00000177789d },
            { 4774000.0d, 0.00000163173d },
            { 4791000.0d, 0.00000149107d },
            { 4808000.0d, 0.00000135601d },
            { 4825000.0d, 0.00000122668d },
            { 4842000.0d, 0.00000110317d },
            { 4859000.0d, 0.000000985594d },
            { 4876000.0d, 0.000000874068d },
            { 4893000.0d, 0.000000768701d },
            { 4910000.0d, 0.0000006696d },
            { 4927000.0d, 0.000000576876d },
            { 4944000.0d, 0.000000490639d },
            { 4961000.0d, 0.000000410999d },
            { 4978000.0d, 0.000000338065d },
            { 4995000.0d, 0.000000271947d },
            { 5012000.0d, 0.000000212754d },
            { 5029000.0d, 0.000000160592d },
            { 5046000.0d, 0.000000115569d },
            { 5063000.0d, 0.0000000777887d },
            { 5080000.0d, 0.0000000473542d },
            { 5097000.0d, 0.0000000243637d },
            { 5114000.0d, 0.000000008908d },
            { 5131000.0d, 0.00000000106223d },
            { 5140000.0d, 0d },

        }; 
    }
}
    