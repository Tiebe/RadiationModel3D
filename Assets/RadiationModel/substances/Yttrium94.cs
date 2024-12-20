using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium94";
        public override double halfLife { get; } = 1122.0d;
        public override double atomicWeight { get; } = 93.91159d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium94()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0005600000000000001d, new GammaParticle(308200.0, 0.00402)), new(0.02016d, new GammaParticle(381600.0, 0.00325)), new(0.04928d, new GammaParticle(550900.0, 0.00225)), new(0.00168d, new GammaParticle(588000.0, 0.00211)), new(0.001904d, new GammaParticle(694700.0, 0.00178)), new(0.013999999999999999d, new GammaParticle(752600.0, 0.00165)), new(0.000784d, new GammaParticle(887500.0, 0.0014)), new(0.56d, new GammaParticle(918740.0, 0.00135)), new(0.000616d, new GammaParticle(1001800.0, 0.00124)), new(0.000616d, new GammaParticle(1066500.0, 0.00116)), new(0.05992d, new GammaParticle(1138900.0, 0.00109)), new(0.0069440000000000005d, new GammaParticle(1161800.0, 0.00107)), new(0.003304d, new GammaParticle(1232600.0, 0.00101)), new(0.001288d, new GammaParticle(1236600.0, 0.001)), new(0.000448d, new GammaParticle(1303800.0, 0.00095)), new(0.00028000000000000003d, new GammaParticle(1384400.0, 0.0009)), new(0.000784d, new GammaParticle(1411900.0, 0.00088)), new(0.00252d, new GammaParticle(1447400.0, 0.00086)), new(0.000336d, new GammaParticle(1587900.0, 0.00078)), new(0.000336d, new GammaParticle(1630000.0, 0.00076)), new(0.02464d, new GammaParticle(1671400.0, 0.00074)), new(0.0038640000000000002d, new GammaParticle(1891600.0, 0.00066)), new(0.000336d, new GammaParticle(1904600.0, 0.00065)), new(0.000392d, new GammaParticle(1927500.0, 0.00064)), new(0.000392d, new GammaParticle(1940600.0, 0.00064)), new(0.000392d, new GammaParticle(1989300.0, 0.00062)), new(0.009519999999999999d, new GammaParticle(2140600.0, 0.00058)), new(0.000336d, new GammaParticle(2255300.0, 0.00055)), new(0.001792d, new GammaParticle(2300500.0, 0.00054)), new(0.000336d, new GammaParticle(2348700.0, 0.00053)), new(0.0014000000000000002d, new GammaParticle(2442100.0, 0.00051)), new(0.0021279999999999997d, new GammaParticle(2492000.0, 0.0005)), new(0.002016d, new GammaParticle(2527300.0, 0.00049)), new(0.000616d, new GammaParticle(2566200.0, 0.00048)), new(0.00028000000000000003d, new GammaParticle(2662400.0, 0.00047)), new(0.000336d, new GammaParticle(2805900.0, 0.00044)), new(0.0036959999999999996d, new GammaParticle(2846300.0, 0.00044)), new(0.001008d, new GammaParticle(2898700.0, 0.00043)), new(0.000448d, new GammaParticle(2908400.0, 0.00043)), new(0.000112d, new GammaParticle(2966600.0, 0.00042)), new(0.000168d, new GammaParticle(2998400.0, 0.00041)), new(0.0001792d, new GammaParticle(3190300.0, 0.00039)), new(0.000616d, new GammaParticle(3264400.0, 0.00038)), new(0.000504d, new GammaParticle(3318700.0, 0.00037)), new(0.000224d, new GammaParticle(3477300.0, 0.00036)), new(0.000112d, new GammaParticle(3541500.0, 0.00035)), new(0.000168d, new GammaParticle(3599800.0, 0.00034)), new(0.000112d, new GammaParticle(3666500.0, 0.00034)), new(8.4e-05d, new GammaParticle(3718800.0, 0.00033)), new(0.000112d, new GammaParticle(3750900.0, 0.00033)), new(0.000112d, new GammaParticle(3795200.0, 0.00033)), new(0.000112d, new GammaParticle(4002100.0, 0.00031)), new(5.6e-05d, new GammaParticle(4052300.0, 0.00031)), new(0.000224d, new GammaParticle(4098400.0, 0.0003)), new(2.67769534816e-05d, new GammaParticle(2161.0, 0.57374)), new(0.0001517427279359146d, new GammaParticle(15691.0, 0.07902)), new(0.0002904167041835686d, new GammaParticle(15775.0, 0.0786)), new(7.400190146641962e-05d, new GammaParticle(17736.0, 0.06991)), new(8.480617908051687e-05d, new GammaParticle(17824.0, 0.06956)), new(1.0804277614097263e-05d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000108546d },
            { 800.0d, 0.000108855d },
            { 1600.0d, 0.00010912d },
            { 2400.0d, 0.000109341d },
            { 3200.0d, 0.000109544d },
            { 4000.0d, 0.000109741d },
            { 4800.0d, 0.000109932d },
            { 5600.0d, 0.00011012d },
            { 6400.0d, 0.000110306d },
            { 7200.0d, 0.000110493d },
            { 8000.0d, 0.00011068d },
            { 8800.0d, 0.000110868d },
            { 9600.0d, 0.000111055d },
            { 10000.0d, 0.000111149d },
            { 11000.0d, 0.000111385d },
            { 12000.0d, 0.00011162d },
            { 13000.0d, 0.000111856d },
            { 14000.0d, 0.000112093d },
            { 15000.0d, 0.00011233d },
            { 16000.0d, 0.000112569d },
            { 17000.0d, 0.000112808d },
            { 18000.0d, 0.000113048d },
            { 19000.0d, 0.00011329d },
            { 20000.0d, 0.000113533d },
            { 21000.0d, 0.000113777d },
            { 22000.0d, 0.000114022d },
            { 23000.0d, 0.000114268d },
            { 24000.0d, 0.000114516d },
            { 25000.0d, 0.000114765d },
            { 26000.0d, 0.000115016d },
            { 27000.0d, 0.000115268d },
            { 28000.0d, 0.000115522d },
            { 29000.0d, 0.000115777d },
            { 30000.0d, 0.000116033d },
            { 31000.0d, 0.000116291d },
            { 32000.0d, 0.000116551d },
            { 33000.0d, 0.000116812d },
            { 34000.0d, 0.000117074d },
            { 35000.0d, 0.000117338d },
            { 36000.0d, 0.000117603d },
            { 37000.0d, 0.00011787d },
            { 38000.0d, 0.000118138d },
            { 39000.0d, 0.000118407d },
            { 40000.0d, 0.000118678d },
            { 41000.0d, 0.00011895d },
            { 42000.0d, 0.000119223d },
            { 43000.0d, 0.000119497d },
            { 44000.0d, 0.000119773d },
            { 45000.0d, 0.00012005d },
            { 46000.0d, 0.000120328d },
            { 47000.0d, 0.000120607d },
            { 48000.0d, 0.000120888d },
            { 49000.0d, 0.000121168d },
            { 50000.0d, 0.00012145d },
            { 51000.0d, 0.000121733d },
            { 52000.0d, 0.000122016d },
            { 53000.0d, 0.0001223d },
            { 54000.0d, 0.000122585d },
            { 55000.0d, 0.000122871d },
            { 56000.0d, 0.000123157d },
            { 57000.0d, 0.000123444d },
            { 58000.0d, 0.000123732d },
            { 59000.0d, 0.000124021d },
            { 60000.0d, 0.000124311d },
            { 61000.0d, 0.000124601d },
            { 62000.0d, 0.000124892d },
            { 63000.0d, 0.000125184d },
            { 64000.0d, 0.000125476d },
            { 65000.0d, 0.000125769d },
            { 66000.0d, 0.000126061d },
            { 67000.0d, 0.000126354d },
            { 68000.0d, 0.000126647d },
            { 69000.0d, 0.000126941d },
            { 70000.0d, 0.000127236d },
            { 71000.0d, 0.00012753d },
            { 72000.0d, 0.000127826d },
            { 73000.0d, 0.000128121d },
            { 74000.0d, 0.000128418d },
            { 75000.0d, 0.000128714d },
            { 76000.0d, 0.000129011d },
            { 77000.0d, 0.000129309d },
            { 78000.0d, 0.000129607d },
            { 79000.0d, 0.000129905d },
            { 80000.0d, 0.000130203d },
            { 81000.0d, 0.000130501d },
            { 82000.0d, 0.0001308d },
            { 83000.0d, 0.000131098d },
            { 84000.0d, 0.000131397d },
            { 85000.0d, 0.000131696d },
            { 86000.0d, 0.000131996d },
            { 87000.0d, 0.000132295d },
            { 88000.0d, 0.000132595d },
            { 89000.0d, 0.000132896d },
            { 90000.0d, 0.000133196d },
            { 91000.0d, 0.000133497d },
            { 92000.0d, 0.000133797d },
            { 93000.0d, 0.000134098d },
            { 94000.0d, 0.000134399d },
            { 95000.0d, 0.0001347d },
            { 96000.0d, 0.000135001d },
            { 97000.0d, 0.000135303d },
            { 98000.0d, 0.000135604d },
            { 99000.0d, 0.000135905d },
            { 100000.0d, 0.000136207d },
            { 110000.0d, 0.000139227d },
            { 120000.0d, 0.000142252d },
            { 130000.0d, 0.000145278d },
            { 140000.0d, 0.000148302d },
            { 150000.0d, 0.000151323d },
            { 160000.0d, 0.00015434d },
            { 170000.0d, 0.000157351d },
            { 180000.0d, 0.000160357d },
            { 190000.0d, 0.000163359d },
            { 200000.0d, 0.000166357d },
            { 210000.0d, 0.000169352d },
            { 220000.0d, 0.000172344d },
            { 230000.0d, 0.000175335d },
            { 240000.0d, 0.000178327d },
            { 250000.0d, 0.00018132d },
            { 260000.0d, 0.000184303d },
            { 270000.0d, 0.00018727d },
            { 280000.0d, 0.000190221d },
            { 290000.0d, 0.000193151d },
            { 300000.0d, 0.000196055d },
            { 310000.0d, 0.000198932d },
            { 320000.0d, 0.000201783d },
            { 330000.0d, 0.000204607d },
            { 340000.0d, 0.000207404d },
            { 350000.0d, 0.000210173d },
            { 360000.0d, 0.000212916d },
            { 370000.0d, 0.000215631d },
            { 380000.0d, 0.000218319d },
            { 390000.0d, 0.000220979d },
            { 400000.0d, 0.000223612d },
            { 410000.0d, 0.000226218d },
            { 420000.0d, 0.000228797d },
            { 430000.0d, 0.00023135d },
            { 440000.0d, 0.000233876d },
            { 450000.0d, 0.000236375d },
            { 460000.0d, 0.000238849d },
            { 470000.0d, 0.000241296d },
            { 480000.0d, 0.000243719d },
            { 490000.0d, 0.000246116d },
            { 500000.0d, 0.000248489d },
            { 510000.0d, 0.000250838d },
            { 520000.0d, 0.000253164d },
            { 530000.0d, 0.000255466d },
            { 540000.0d, 0.000257746d },
            { 550000.0d, 0.000260003d },
            { 560000.0d, 0.00026224d },
            { 570000.0d, 0.000264455d },
            { 580000.0d, 0.000266651d },
            { 590000.0d, 0.000268828d },
            { 600000.0d, 0.000270986d },
            { 610000.0d, 0.000273126d },
            { 620000.0d, 0.000275249d },
            { 630000.0d, 0.000277356d },
            { 640000.0d, 0.000279448d },
            { 650000.0d, 0.000281525d },
            { 660000.0d, 0.000283588d },
            { 670000.0d, 0.000285639d },
            { 680000.0d, 0.000287679d },
            { 690000.0d, 0.000289704d },
            { 700000.0d, 0.000291713d },
            { 710000.0d, 0.000293707d },
            { 720000.0d, 0.000295686d },
            { 730000.0d, 0.000297642d },
            { 740000.0d, 0.000299569d },
            { 750000.0d, 0.000301468d },
            { 760000.0d, 0.000303338d },
            { 770000.0d, 0.00030518d },
            { 780000.0d, 0.000306994d },
            { 790000.0d, 0.00030878d },
            { 800000.0d, 0.000310538d },
            { 810000.0d, 0.000312268d },
            { 820000.0d, 0.000313972d },
            { 830000.0d, 0.000315648d },
            { 840000.0d, 0.000317296d },
            { 850000.0d, 0.000318917d },
            { 860000.0d, 0.00032051d },
            { 870000.0d, 0.000322076d },
            { 880000.0d, 0.000323616d },
            { 890000.0d, 0.00032513d },
            { 900000.0d, 0.000326616d },
            { 910000.0d, 0.000328077d },
            { 920000.0d, 0.000329512d },
            { 930000.0d, 0.000330921d },
            { 940000.0d, 0.000332304d },
            { 950000.0d, 0.000333662d },
            { 960000.0d, 0.000334996d },
            { 970000.0d, 0.000336299d },
            { 980000.0d, 0.000337572d },
            { 990000.0d, 0.000338812d },
            { 1000000.0d, 0.000340023d },
            { 1016000.0d, 0.000341895d },
            { 1032000.0d, 0.00034369d },
            { 1048000.0d, 0.000345407d },
            { 1064000.0d, 0.000347047d },
            { 1080000.0d, 0.000348611d },
            { 1096000.0d, 0.000350098d },
            { 1112000.0d, 0.000351513d },
            { 1128000.0d, 0.000352853d },
            { 1144000.0d, 0.00035412d },
            { 1160000.0d, 0.000355315d },
            { 1176000.0d, 0.000356439d },
            { 1192000.0d, 0.000357494d },
            { 1208000.0d, 0.000358477d },
            { 1224000.0d, 0.00035939d },
            { 1240000.0d, 0.000360235d },
            { 1256000.0d, 0.00036101d },
            { 1272000.0d, 0.00036172d },
            { 1288000.0d, 0.000362363d },
            { 1304000.0d, 0.000362941d },
            { 1320000.0d, 0.000363455d },
            { 1336000.0d, 0.000363907d },
            { 1352000.0d, 0.000364299d },
            { 1368000.0d, 0.000364631d },
            { 1384000.0d, 0.000364904d },
            { 1400000.0d, 0.00036512d },
            { 1416000.0d, 0.000365282d },
            { 1432000.0d, 0.000365389d },
            { 1448000.0d, 0.000365444d },
            { 1464000.0d, 0.00036545d },
            { 1480000.0d, 0.000365405d },
            { 1496000.0d, 0.000365314d },
            { 1512000.0d, 0.000365177d },
            { 1528000.0d, 0.000364994d },
            { 1544000.0d, 0.000364771d },
            { 1560000.0d, 0.000364507d },
            { 1576000.0d, 0.000364197d },
            { 1592000.0d, 0.00036384d },
            { 1608000.0d, 0.000363436d },
            { 1624000.0d, 0.000362987d },
            { 1640000.0d, 0.000362495d },
            { 1656000.0d, 0.000361961d },
            { 1672000.0d, 0.000361387d },
            { 1688000.0d, 0.000360774d },
            { 1704000.0d, 0.000360123d },
            { 1720000.0d, 0.000359425d },
            { 1736000.0d, 0.00035868d },
            { 1752000.0d, 0.000357887d },
            { 1768000.0d, 0.000357048d },
            { 1784000.0d, 0.000356164d },
            { 1800000.0d, 0.000355236d },
            { 1816000.0d, 0.000354265d },
            { 1832000.0d, 0.000353254d },
            { 1848000.0d, 0.000352203d },
            { 1864000.0d, 0.000351113d },
            { 1880000.0d, 0.000349975d },
            { 1896000.0d, 0.00034879d },
            { 1912000.0d, 0.000347557d },
            { 1928000.0d, 0.000346278d },
            { 1944000.0d, 0.000344955d },
            { 1960000.0d, 0.000343587d },
            { 1976000.0d, 0.000342176d },
            { 1992000.0d, 0.000340721d },
            { 2008000.0d, 0.000339224d },
            { 2024000.0d, 0.000337684d },
            { 2040000.0d, 0.0003361d },
            { 2056000.0d, 0.000334475d },
            { 2072000.0d, 0.000332807d },
            { 2088000.0d, 0.000331096d },
            { 2104000.0d, 0.000329343d },
            { 2120000.0d, 0.000327546d },
            { 2136000.0d, 0.000325708d },
            { 2152000.0d, 0.00032383d },
            { 2168000.0d, 0.00032191d },
            { 2184000.0d, 0.000319952d },
            { 2200000.0d, 0.000317955d },
            { 2216000.0d, 0.000315921d },
            { 2232000.0d, 0.000313851d },
            { 2248000.0d, 0.000311744d },
            { 2264000.0d, 0.000309603d },
            { 2280000.0d, 0.000307428d },
            { 2296000.0d, 0.000305221d },
            { 2312000.0d, 0.000302981d },
            { 2328000.0d, 0.000300711d },
            { 2344000.0d, 0.000298412d },
            { 2360000.0d, 0.000296083d },
            { 2376000.0d, 0.000293727d },
            { 2392000.0d, 0.000291343d },
            { 2408000.0d, 0.000288935d },
            { 2424000.0d, 0.000286502d },
            { 2440000.0d, 0.000284046d },
            { 2456000.0d, 0.000281568d },
            { 2472000.0d, 0.000279069d },
            { 2488000.0d, 0.00027655d },
            { 2504000.0d, 0.000274011d },
            { 2520000.0d, 0.000271456d },
            { 2536000.0d, 0.000268884d },
            { 2552000.0d, 0.000266298d },
            { 2568000.0d, 0.000263694d },
            { 2584000.0d, 0.000261077d },
            { 2600000.0d, 0.000258445d },
            { 2616000.0d, 0.000255799d },
            { 2632000.0d, 0.000253143d },
            { 2648000.0d, 0.000250475d },
            { 2664000.0d, 0.000247797d },
            { 2680000.0d, 0.000245111d },
            { 2696000.0d, 0.000242419d },
            { 2712000.0d, 0.00023972d },
            { 2728000.0d, 0.000237017d },
            { 2744000.0d, 0.000234311d },
            { 2760000.0d, 0.000231605d },
            { 2776000.0d, 0.000228896d },
            { 2792000.0d, 0.00022619d },
            { 2808000.0d, 0.000223484d },
            { 2824000.0d, 0.000220781d },
            { 2840000.0d, 0.000218082d },
            { 2856000.0d, 0.000215389d },
            { 2872000.0d, 0.000212697d },
            { 2888000.0d, 0.000209994d },
            { 2904000.0d, 0.000207281d },
            { 2920000.0d, 0.000204559d },
            { 2936000.0d, 0.000201828d },
            { 2952000.0d, 0.000199089d },
            { 2968000.0d, 0.000196344d },
            { 2984000.0d, 0.000193595d },
            { 3000000.0d, 0.000190842d },
            { 3016000.0d, 0.000188087d },
            { 3032000.0d, 0.000185329d },
            { 3048000.0d, 0.000182573d },
            { 3064000.0d, 0.000179818d },
            { 3080000.0d, 0.000177065d },
            { 3096000.0d, 0.000174316d },
            { 3112000.0d, 0.000171573d },
            { 3128000.0d, 0.000168837d },
            { 3144000.0d, 0.000166109d },
            { 3160000.0d, 0.000163391d },
            { 3176000.0d, 0.000160683d },
            { 3192000.0d, 0.000157989d },
            { 3208000.0d, 0.00015531d },
            { 3224000.0d, 0.000152646d },
            { 3240000.0d, 0.00015d },
            { 3256000.0d, 0.000147372d },
            { 3272000.0d, 0.000144757d },
            { 3288000.0d, 0.000142155d },
            { 3304000.0d, 0.000139568d },
            { 3320000.0d, 0.000136998d },
            { 3336000.0d, 0.000134447d },
            { 3352000.0d, 0.000131915d },
            { 3368000.0d, 0.000129406d },
            { 3384000.0d, 0.00012692d },
            { 3400000.0d, 0.000124459d },
            { 3416000.0d, 0.000122025d },
            { 3432000.0d, 0.000119621d },
            { 3448000.0d, 0.000117247d },
            { 3464000.0d, 0.000114897d },
            { 3480000.0d, 0.000112565d },
            { 3496000.0d, 0.000110252d },
            { 3512000.0d, 0.000107958d },
            { 3528000.0d, 0.000105686d },
            { 3544000.0d, 0.000103436d },
            { 3560000.0d, 0.000101211d },
            { 3576000.0d, 0.0000990098d },
            { 3592000.0d, 0.0000968354d },
            { 3608000.0d, 0.000094689d },
            { 3624000.0d, 0.0000925711d },
            { 3640000.0d, 0.0000904786d },
            { 3656000.0d, 0.0000884114d },
            { 3672000.0d, 0.0000863705d },
            { 3688000.0d, 0.0000843572d },
            { 3704000.0d, 0.0000823726d },
            { 3720000.0d, 0.000080418d },
            { 3736000.0d, 0.0000784946d },
            { 3752000.0d, 0.0000766037d },
            { 3768000.0d, 0.0000747465d },
            { 3784000.0d, 0.0000729243d },
            { 3800000.0d, 0.0000711384d },
            { 3816000.0d, 0.0000693901d },
            { 3832000.0d, 0.0000676808d },
            { 3848000.0d, 0.0000660118d },
            { 3864000.0d, 0.0000643845d },
            { 3880000.0d, 0.0000628002d },
            { 3896000.0d, 0.0000612605d },
            { 3912000.0d, 0.0000597664d },
            { 3928000.0d, 0.0000583197d },
            { 3944000.0d, 0.0000569217d },
            { 3960000.0d, 0.0000555737d },
            { 3976000.0d, 0.0000542772d },
            { 3992000.0d, 0.0000530334d },
            { 4008000.0d, 0.0000518338d },
            { 4024000.0d, 0.0000506351d },
            { 4040000.0d, 0.000049432d },
            { 4056000.0d, 0.000048225d },
            { 4072000.0d, 0.0000470148d },
            { 4088000.0d, 0.0000458018d },
            { 4104000.0d, 0.0000445864d },
            { 4120000.0d, 0.0000433694d },
            { 4136000.0d, 0.0000421513d },
            { 4152000.0d, 0.0000409326d },
            { 4168000.0d, 0.000039714d },
            { 4184000.0d, 0.0000384962d },
            { 4200000.0d, 0.0000372799d },
            { 4216000.0d, 0.0000360656d },
            { 4232000.0d, 0.0000348543d },
            { 4248000.0d, 0.0000336464d },
            { 4264000.0d, 0.000032443d },
            { 4280000.0d, 0.0000312447d },
            { 4296000.0d, 0.0000300524d },
            { 4312000.0d, 0.0000288668d },
            { 4328000.0d, 0.0000276889d },
            { 4344000.0d, 0.0000265195d },
            { 4360000.0d, 0.0000253597d },
            { 4376000.0d, 0.0000242102d },
            { 4392000.0d, 0.0000230721d },
            { 4408000.0d, 0.0000219464d },
            { 4424000.0d, 0.0000208341d },
            { 4440000.0d, 0.0000197362d },
            { 4456000.0d, 0.0000186539d },
            { 4472000.0d, 0.0000175883d },
            { 4488000.0d, 0.0000165405d },
            { 4504000.0d, 0.0000155116d },
            { 4520000.0d, 0.0000145029d },
            { 4536000.0d, 0.0000135156d },
            { 4552000.0d, 0.000012551d },
            { 4568000.0d, 0.0000116103d },
            { 4584000.0d, 0.0000106949d },
            { 4600000.0d, 0.00000980623d },
            { 4616000.0d, 0.0000089455d },
            { 4632000.0d, 0.00000811424d },
            { 4648000.0d, 0.00000731389d },
            { 4664000.0d, 0.00000654594d },
            { 4680000.0d, 0.00000581189d },
            { 4696000.0d, 0.00000511331d },
            { 4712000.0d, 0.00000445179d },
            { 4728000.0d, 0.00000382893d },
            { 4744000.0d, 0.00000324639d },
            { 4760000.0d, 0.00000270586d },
            { 4776000.0d, 0.00000220904d },
            { 4792000.0d, 0.00000175769d },
            { 4808000.0d, 0.00000135358d },
            { 4824000.0d, 0.000000998514d },
            { 4840000.0d, 0.000000694315d },
            { 4856000.0d, 0.000000442833d },
            { 4872000.0d, 0.00000024592d },
            { 4888000.0d, 0.00000010542d },
            { 4904000.0d, 0.0000000231174d },
            { 4918000.0d, 0d },

        }; 
    }
}
    