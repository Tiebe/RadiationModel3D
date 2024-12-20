using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium115";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 114.9119d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin115()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00768d, new GammaParticle(228220.0, 0.00543)), new(0.00992d, new GammaParticle(281960.0, 0.0044)), new(0.03168d, new GammaParticle(374480.0, 0.00331)), new(0.0022400000000000002d, new GammaParticle(386300.0, 0.00321)), new(0.01088d, new GammaParticle(428220.0, 0.0029)), new(0.027839999999999997d, new GammaParticle(568390.0, 0.00218)), new(0.001664d, new GammaParticle(576800.0, 0.00215)), new(0.044160000000000005d, new GammaParticle(603270.0, 0.00206)), new(0.00928d, new GammaParticle(634060.0, 0.00196)), new(0.06816d, new GammaParticle(657010.0, 0.00189)), new(0.30079999999999996d, new GammaParticle(723570.0, 0.00171)), new(0.0022400000000000002d, new GammaParticle(804000.0, 0.00154)), new(0.00416d, new GammaParticle(921300.0, 0.00135)), new(0.01824d, new GammaParticle(942870.0, 0.00131)), new(0.011200000000000002d, new GammaParticle(996610.0, 0.00124)), new(0.01664d, new GammaParticle(1012300.0, 0.00122)), new(0.00736d, new GammaParticle(1022800.0, 0.00121)), new(0.0032d, new GammaParticle(1051400.0, 0.00118)), new(0.0060799999999999995d, new GammaParticle(1061600.0, 0.00117)), new(0.0024d, new GammaParticle(1071700.0, 0.00116)), new(0.008d, new GammaParticle(1088400.0, 0.00114)), new(0.1632d, new GammaParticle(1098620.0, 0.00113)), new(0.0060799999999999995d, new GammaParticle(1213600.0, 0.00102)), new(0.00768d, new GammaParticle(1224500.0, 0.00101)), new(0.05888d, new GammaParticle(1290500.0, 0.00096)), new(0.024319999999999998d, new GammaParticle(1300300.0, 0.00095)), new(0.00128d, new GammaParticle(1315500.0, 0.00094)), new(0.22719999999999999d, new GammaParticle(1326840.0, 0.00093)), new(0.0016d, new GammaParticle(1369100.0, 0.00091)), new(0.2304d, new GammaParticle(1380580.0, 0.0009)), new(0.00384d, new GammaParticle(1437300.0, 0.00086)), new(0.00256d, new GammaParticle(1446700.0, 0.00086)), new(0.00208d, new GammaParticle(1589500.0, 0.00078)), new(0.02624d, new GammaParticle(1599900.0, 0.00077)), new(0.0011200000000000001d, new GammaParticle(1617100.0, 0.00077)), new(0.00928d, new GammaParticle(1665400.0, 0.00074)), new(0.0044800000000000005d, new GammaParticle(1685500.0, 0.00074)), new(0.0016d, new GammaParticle(1743500.0, 0.00071)), new(0.00512d, new GammaParticle(1837300.0, 0.00067)), new(0.00416d, new GammaParticle(1953800.0, 0.00063)), new(0.00128d, new GammaParticle(2019500.0, 0.00061)), new(0.001248d, new GammaParticle(2118600.0, 0.00059)), new(0.00512d, new GammaParticle(2130800.0, 0.00058)), new(0.0023680000000000003d, new GammaParticle(2389100.0, 0.00052)), new(0.001216d, new GammaParticle(2459300.0, 0.0005)), new(0.0007679999999999999d, new GammaParticle(2467500.0, 0.0005)), new(0.0032d, new GammaParticle(2481600.0, 0.0005)), new(0.001088d, new GammaParticle(2503200.0, 0.0005)), new(0.0015359999999999998d, new GammaParticle(2511200.0, 0.00049)), new(0.008d, new GammaParticle(2688200.0, 0.00046)), new(0.001248d, new GammaParticle(2717800.0, 0.00046)), new(0.001248d, new GammaParticle(2746200.0, 0.00045)), new(0.00048d, new GammaParticle(3411600.0, 0.00036)), new(0.000544d, new GammaParticle(3447900.0, 0.00036)), new(0.000448d, new GammaParticle(3529400.0, 0.00035)), new(0.000608d, new GammaParticle(3559600.0, 0.00035)), new(1.334d, new GammaParticle(511000.0, 0.00243)), new(0.0252040307557568d, new GammaParticle(3941.0, 0.3146)), new(0.07421398212050978d, new GammaParticle(26111.0, 0.04748)), new(0.13856232658795703d, new GammaParticle(26359.0, 0.04704)), new(0.03941738411533817d, new GammaParticle(29821.0, 0.04158)), new(0.04757678262721318d, new GammaParticle(30069.0, 0.04123)), new(0.008159398511875d, new GammaParticle(30387.0, 0.0408)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 4000.0d, 0.0000000055752d },
            { 8000.0d, 0.000000124771d },
            { 12000.0d, 0.000000389666d },
            { 16000.0d, 0.00000080983d },
            { 20000.0d, 0.0000014377d },
            { 24000.0d, 0.00000227045d },
            { 28000.0d, 0.00000330423d },
            { 32000.0d, 0.00000453404d },
            { 36000.0d, 0.00000594013d },
            { 40000.0d, 0.00000752033d },
            { 44000.0d, 0.00000924476d },
            { 48000.0d, 0.000011117d },
            { 52000.0d, 0.0000131113d },
            { 56000.0d, 0.0000152255d },
            { 60000.0d, 0.0000174399d },
            { 64000.0d, 0.0000197521d },
            { 68000.0d, 0.0000221447d },
            { 72000.0d, 0.0000246189d },
            { 76000.0d, 0.000027157d },
            { 80000.0d, 0.0000297619d },
            { 84000.0d, 0.0000324171d },
            { 88000.0d, 0.0000351259d },
            { 92000.0d, 0.000037877d },
            { 96000.0d, 0.0000406695d },
            { 100000.0d, 0.0000434963d },
            { 110000.0d, 0.0000506949d },
            { 120000.0d, 0.0000580402d },
            { 130000.0d, 0.0000654891d },
            { 140000.0d, 0.0000730094d },
            { 150000.0d, 0.0000805744d },
            { 160000.0d, 0.0000881618d },
            { 170000.0d, 0.0000957534d },
            { 180000.0d, 0.000103334d },
            { 190000.0d, 0.000110893d },
            { 200000.0d, 0.000118418d },
            { 210000.0d, 0.0001259d },
            { 220000.0d, 0.000133333d },
            { 230000.0d, 0.00014071d },
            { 240000.0d, 0.000148026d },
            { 250000.0d, 0.000155274d },
            { 260000.0d, 0.000162453d },
            { 270000.0d, 0.000169556d },
            { 280000.0d, 0.000176583d },
            { 290000.0d, 0.000183528d },
            { 300000.0d, 0.000190391d },
            { 310000.0d, 0.000197168d },
            { 320000.0d, 0.000203857d },
            { 330000.0d, 0.000210457d },
            { 340000.0d, 0.000216965d },
            { 350000.0d, 0.000223381d },
            { 360000.0d, 0.000229703d },
            { 370000.0d, 0.000235928d },
            { 380000.0d, 0.000242057d },
            { 390000.0d, 0.000248088d },
            { 400000.0d, 0.00025402d },
            { 410000.0d, 0.000259851d },
            { 420000.0d, 0.000265582d },
            { 430000.0d, 0.000271211d },
            { 440000.0d, 0.000276738d },
            { 450000.0d, 0.000282161d },
            { 460000.0d, 0.00028748d },
            { 470000.0d, 0.000292695d },
            { 480000.0d, 0.000297805d },
            { 490000.0d, 0.000302809d },
            { 500000.0d, 0.000307707d },
            { 510000.0d, 0.000312498d },
            { 520000.0d, 0.000317183d },
            { 530000.0d, 0.00032176d },
            { 540000.0d, 0.00032623d },
            { 550000.0d, 0.000330592d },
            { 560000.0d, 0.000334846d },
            { 570000.0d, 0.000338992d },
            { 580000.0d, 0.000343029d },
            { 590000.0d, 0.000346958d },
            { 600000.0d, 0.000350778d },
            { 610000.0d, 0.00035449d },
            { 620000.0d, 0.000358093d },
            { 630000.0d, 0.000361587d },
            { 640000.0d, 0.000364973d },
            { 650000.0d, 0.00036825d },
            { 660000.0d, 0.000371419d },
            { 670000.0d, 0.000374479d },
            { 680000.0d, 0.000377432d },
            { 690000.0d, 0.000380278d },
            { 700000.0d, 0.000383015d },
            { 710000.0d, 0.000385644d },
            { 720000.0d, 0.000388167d },
            { 730000.0d, 0.000390584d },
            { 740000.0d, 0.000392893d },
            { 750000.0d, 0.000395097d },
            { 760000.0d, 0.000397195d },
            { 770000.0d, 0.00039919d },
            { 780000.0d, 0.000401079d },
            { 790000.0d, 0.000402864d },
            { 800000.0d, 0.000404546d },
            { 810000.0d, 0.000406125d },
            { 820000.0d, 0.000407602d },
            { 830000.0d, 0.000408978d },
            { 840000.0d, 0.000410253d },
            { 850000.0d, 0.000411428d },
            { 860000.0d, 0.000412503d },
            { 870000.0d, 0.00041348d },
            { 880000.0d, 0.00041436d },
            { 890000.0d, 0.000415142d },
            { 900000.0d, 0.000415829d },
            { 910000.0d, 0.00041642d },
            { 920000.0d, 0.000416917d },
            { 930000.0d, 0.000417322d },
            { 940000.0d, 0.000417634d },
            { 950000.0d, 0.000417856d },
            { 960000.0d, 0.000417987d },
            { 970000.0d, 0.000418029d },
            { 980000.0d, 0.000417983d },
            { 990000.0d, 0.000417851d },
            { 1000000.0d, 0.000417633d },
            { 1013000.0d, 0.000417225d },
            { 1026000.0d, 0.000416677d },
            { 1039000.0d, 0.000415992d },
            { 1052000.0d, 0.000415173d },
            { 1065000.0d, 0.000414223d },
            { 1078000.0d, 0.000413146d },
            { 1091000.0d, 0.000411945d },
            { 1104000.0d, 0.000410623d },
            { 1117000.0d, 0.000409182d },
            { 1130000.0d, 0.000407627d },
            { 1143000.0d, 0.000405961d },
            { 1156000.0d, 0.000404187d },
            { 1169000.0d, 0.000402311d },
            { 1182000.0d, 0.000400334d },
            { 1195000.0d, 0.000398262d },
            { 1208000.0d, 0.000396098d },
            { 1221000.0d, 0.000393845d },
            { 1234000.0d, 0.000391509d },
            { 1247000.0d, 0.000389089d },
            { 1260000.0d, 0.000386586d },
            { 1273000.0d, 0.000384005d },
            { 1286000.0d, 0.000381351d },
            { 1299000.0d, 0.000378628d },
            { 1312000.0d, 0.000375838d },
            { 1325000.0d, 0.000372989d },
            { 1338000.0d, 0.000370083d },
            { 1351000.0d, 0.000367126d },
            { 1364000.0d, 0.000364121d },
            { 1377000.0d, 0.000361074d },
            { 1390000.0d, 0.000357989d },
            { 1403000.0d, 0.000354871d },
            { 1416000.0d, 0.000351726d },
            { 1429000.0d, 0.000348558d },
            { 1442000.0d, 0.000345373d },
            { 1455000.0d, 0.000342174d },
            { 1468000.0d, 0.00033897d },
            { 1481000.0d, 0.000335762d },
            { 1494000.0d, 0.000332557d },
            { 1507000.0d, 0.000329362d },
            { 1520000.0d, 0.000326181d },
            { 1533000.0d, 0.000323016d },
            { 1546000.0d, 0.000319832d },
            { 1559000.0d, 0.00031662d },
            { 1572000.0d, 0.000313383d },
            { 1585000.0d, 0.000310125d },
            { 1598000.0d, 0.000306846d },
            { 1611000.0d, 0.000303515d },
            { 1624000.0d, 0.000300116d },
            { 1637000.0d, 0.000296651d },
            { 1650000.0d, 0.000293122d },
            { 1663000.0d, 0.000289532d },
            { 1676000.0d, 0.000285881d },
            { 1689000.0d, 0.000282173d },
            { 1702000.0d, 0.000278408d },
            { 1715000.0d, 0.00027459d },
            { 1728000.0d, 0.00027072d },
            { 1741000.0d, 0.000266801d },
            { 1754000.0d, 0.000262834d },
            { 1767000.0d, 0.000258821d },
            { 1780000.0d, 0.000254766d },
            { 1793000.0d, 0.00025067d },
            { 1806000.0d, 0.000246536d },
            { 1819000.0d, 0.000242365d },
            { 1832000.0d, 0.000238161d },
            { 1845000.0d, 0.000233925d },
            { 1858000.0d, 0.00022966d },
            { 1871000.0d, 0.00022537d },
            { 1884000.0d, 0.000221055d },
            { 1897000.0d, 0.000216718d },
            { 1910000.0d, 0.000212363d },
            { 1923000.0d, 0.000207992d },
            { 1936000.0d, 0.000203608d },
            { 1949000.0d, 0.000199212d },
            { 1962000.0d, 0.000194808d },
            { 1975000.0d, 0.000190399d },
            { 1988000.0d, 0.000185988d },
            { 2001000.0d, 0.000181576d },
            { 2014000.0d, 0.000177168d },
            { 2027000.0d, 0.000172765d },
            { 2040000.0d, 0.000168372d },
            { 2053000.0d, 0.00016399d },
            { 2066000.0d, 0.000159623d },
            { 2079000.0d, 0.000155274d },
            { 2092000.0d, 0.000150946d },
            { 2105000.0d, 0.000146641d },
            { 2118000.0d, 0.000142364d },
            { 2131000.0d, 0.000138117d },
            { 2144000.0d, 0.000133904d },
            { 2157000.0d, 0.000129727d },
            { 2170000.0d, 0.000125589d },
            { 2183000.0d, 0.000121495d },
            { 2196000.0d, 0.000117448d },
            { 2209000.0d, 0.00011345d },
            { 2222000.0d, 0.000109506d },
            { 2235000.0d, 0.000105618d },
            { 2248000.0d, 0.000101791d },
            { 2261000.0d, 0.0000980265d },
            { 2274000.0d, 0.0000943294d },
            { 2287000.0d, 0.0000907032d },
            { 2300000.0d, 0.0000871511d },
            { 2313000.0d, 0.0000836767d },
            { 2326000.0d, 0.000080284d },
            { 2339000.0d, 0.0000769764d },
            { 2352000.0d, 0.0000737577d },
            { 2365000.0d, 0.0000706315d },
            { 2378000.0d, 0.0000676016d },
            { 2391000.0d, 0.0000646719d },
            { 2404000.0d, 0.0000618463d },
            { 2417000.0d, 0.0000591284d },
            { 2430000.0d, 0.0000565222d },
            { 2443000.0d, 0.0000540316d },
            { 2456000.0d, 0.0000516605d },
            { 2469000.0d, 0.000049413d },
            { 2482000.0d, 0.0000472927d },
            { 2495000.0d, 0.0000453038d },
            { 2508000.0d, 0.0000434502d },
            { 2521000.0d, 0.0000417358d },
            { 2534000.0d, 0.0000401643d },
            { 2547000.0d, 0.0000387182d },
            { 2560000.0d, 0.0000373522d },
            { 2573000.0d, 0.0000360668d },
            { 2586000.0d, 0.0000348642d },
            { 2599000.0d, 0.0000337337d },
            { 2612000.0d, 0.0000326276d },
            { 2625000.0d, 0.0000315415d },
            { 2638000.0d, 0.0000304739d },
            { 2651000.0d, 0.0000294256d },
            { 2664000.0d, 0.0000283971d },
            { 2677000.0d, 0.0000273893d },
            { 2690000.0d, 0.000026403d },
            { 2703000.0d, 0.0000254391d },
            { 2716000.0d, 0.0000244983d },
            { 2729000.0d, 0.0000235815d },
            { 2742000.0d, 0.0000226896d },
            { 2755000.0d, 0.0000218234d },
            { 2768000.0d, 0.0000209837d },
            { 2781000.0d, 0.0000201714d },
            { 2794000.0d, 0.0000193872d },
            { 2807000.0d, 0.0000186321d },
            { 2820000.0d, 0.0000179068d },
            { 2833000.0d, 0.0000172016d },
            { 2846000.0d, 0.0000165095d },
            { 2859000.0d, 0.0000158309d },
            { 2872000.0d, 0.0000151664d },
            { 2885000.0d, 0.0000145164d },
            { 2898000.0d, 0.0000138815d },
            { 2911000.0d, 0.0000132621d },
            { 2924000.0d, 0.0000126589d },
            { 2937000.0d, 0.0000120722d },
            { 2950000.0d, 0.0000115026d },
            { 2963000.0d, 0.0000109506d },
            { 2976000.0d, 0.0000104168d },
            { 2989000.0d, 0.00000990163d },
            { 3002000.0d, 0.00000940567d },
            { 3015000.0d, 0.00000892944d },
            { 3028000.0d, 0.00000847346d },
            { 3041000.0d, 0.00000803826d },
            { 3054000.0d, 0.00000762441d },
            { 3067000.0d, 0.00000723241d },
            { 3080000.0d, 0.00000686281d },
            { 3093000.0d, 0.00000651617d },
            { 3106000.0d, 0.00000619301d },
            { 3119000.0d, 0.00000589388d },
            { 3132000.0d, 0.00000561931d },
            { 3145000.0d, 0.00000536984d },
            { 3158000.0d, 0.00000514599d },
            { 3171000.0d, 0.00000494828d },
            { 3184000.0d, 0.00000477718d },
            { 3197000.0d, 0.00000463235d },
            { 3210000.0d, 0.00000449616d },
            { 3223000.0d, 0.00000436091d },
            { 3236000.0d, 0.00000422664d },
            { 3249000.0d, 0.00000409342d },
            { 3262000.0d, 0.0000039613d },
            { 3275000.0d, 0.00000383034d },
            { 3288000.0d, 0.00000370056d },
            { 3301000.0d, 0.00000357205d },
            { 3314000.0d, 0.00000344485d },
            { 3327000.0d, 0.000003319d },
            { 3340000.0d, 0.00000319458d },
            { 3353000.0d, 0.00000307163d },
            { 3366000.0d, 0.0000029502d },
            { 3379000.0d, 0.00000283034d },
            { 3392000.0d, 0.00000271213d },
            { 3405000.0d, 0.00000259561d },
            { 3418000.0d, 0.00000248084d },
            { 3431000.0d, 0.00000236786d },
            { 3444000.0d, 0.00000225676d },
            { 3457000.0d, 0.00000214757d },
            { 3470000.0d, 0.00000204036d },
            { 3483000.0d, 0.00000193517d },
            { 3496000.0d, 0.00000183208d },
            { 3509000.0d, 0.00000173114d },
            { 3522000.0d, 0.00000163241d },
            { 3535000.0d, 0.00000153595d },
            { 3548000.0d, 0.0000014418d },
            { 3561000.0d, 0.00000135006d },
            { 3574000.0d, 0.00000126076d },
            { 3587000.0d, 0.00000117396d },
            { 3600000.0d, 0.00000108974d },
            { 3613000.0d, 0.00000100814d },
            { 3626000.0d, 0.000000929234d },
            { 3639000.0d, 0.00000085308d },
            { 3652000.0d, 0.000000779738d },
            { 3665000.0d, 0.000000709272d },
            { 3678000.0d, 0.000000641743d },
            { 3691000.0d, 0.000000577216d },
            { 3704000.0d, 0.000000515751d },
            { 3717000.0d, 0.000000457412d },
            { 3730000.0d, 0.000000402262d },
            { 3743000.0d, 0.000000350365d },
            { 3756000.0d, 0.000000301783d },
            { 3769000.0d, 0.000000256581d },
            { 3782000.0d, 0.000000214821d },
            { 3795000.0d, 0.000000176569d },
            { 3808000.0d, 0.000000141886d },
            { 3821000.0d, 0.000000110836d },
            { 3834000.0d, 0.0000000834846d },
            { 3847000.0d, 0.0000000598919d },
            { 3860000.0d, 0.0000000401205d },
            { 3873000.0d, 0.0000000242317d },
            { 3886000.0d, 0.0000000122846d },
            { 3899000.0d, 0.00000000433495d },
            { 3912000.0d, 0.000000000430709d },
            { 3918000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    