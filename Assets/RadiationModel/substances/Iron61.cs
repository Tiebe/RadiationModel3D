using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iron61 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron61";
        public override double halfLife { get; } = 358.8d;
        public override double atomicWeight { get; } = 60.93675d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cobalt61()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.051239999999999994d, new GammaParticle(120340.0, 0.0103)), new(0.01932d, new GammaParticle(177610.0, 0.00698)), new(0.21420000000000003d, new GammaParticle(297900.0, 0.00416)), new(0.002142d, new GammaParticle(333000.0, 0.00372)), new(0.001554d, new GammaParticle(349700.0, 0.00355)), new(0.0021d, new GammaParticle(440500.0, 0.00281)), new(0.00063d, new GammaParticle(542600.0, 0.00229)), new(0.000546d, new GammaParticle(561400.0, 0.00221)), new(0.000714d, new GammaParticle(603300.0, 0.00206)), new(0.008988000000000001d, new GammaParticle(618400.0, 0.002)), new(0.002142d, new GammaParticle(657300.0, 0.00189)), new(0.0038640000000000002d, new GammaParticle(686000.0, 0.00181)), new(0.001092d, new GammaParticle(696900.0, 0.00178)), new(0.00777d, new GammaParticle(748100.0, 0.00166)), new(0.001554d, new GammaParticle(769400.0, 0.00161)), new(0.0018479999999999998d, new GammaParticle(806300.0, 0.00154)), new(0.003276d, new GammaParticle(925600.0, 0.00134)), new(0.00105d, new GammaParticle(945400.0, 0.00131)), new(0.000714d, new GammaParticle(978000.0, 0.00127)), new(0.00588d, new GammaParticle(984100.0, 0.00126)), new(0.00588d, new GammaParticle(989200.0, 0.00125)), new(0.41159999999999997d, new GammaParticle(1027420.0, 0.00121)), new(0.00672d, new GammaParticle(1097800.0, 0.00113)), new(0.42d, new GammaParticle(1205070.0, 0.00103)), new(0.00588d, new GammaParticle(1275000.0, 0.00097)), new(0.00357d, new GammaParticle(1285700.0, 0.00096)), new(0.0038640000000000002d, new GammaParticle(1381400.0, 0.0009)), new(0.001134d, new GammaParticle(1403900.0, 0.00088)), new(0.002646d, new GammaParticle(1538800.0, 0.00081)), new(0.003528d, new GammaParticle(1618900.0, 0.00077)), new(0.0672d, new GammaParticle(1645950.0, 0.00075)), new(0.007476d, new GammaParticle(1659300.0, 0.00075)), new(0.001344d, new GammaParticle(1837200.0, 0.00067)), new(0.00252d, new GammaParticle(1879400.0, 0.00066)), new(0.001722d, new GammaParticle(1889000.0, 0.00066)), new(0.000714d, new GammaParticle(1899300.0, 0.00065)), new(0.000588d, new GammaParticle(1972700.0, 0.00063)), new(0.00126d, new GammaParticle(1999800.0, 0.00062)), new(0.04242d, new GammaParticle(2011600.0, 0.00062)), new(0.002016d, new GammaParticle(2177100.0, 0.00057)), new(0.00105d, new GammaParticle(2230800.0, 0.00056)), new(0.001176d, new GammaParticle(2484400.0, 0.0005)), new(0.007391999999999999d, new GammaParticle(2754400.0, 0.00045)), new(0.000672d, new GammaParticle(2920000.0, 0.00042)), new(0.000798d, new GammaParticle(3191000.0, 0.00039)), new(0.00042d, new GammaParticle(3204200.0, 0.00039)), new(0.000546d, new GammaParticle(3239100.0, 0.00038)), new(0.00042d, new GammaParticle(3364900.0, 0.00037)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000196515d },
            { 2000.0d, 0.000197335d },
            { 4000.0d, 0.000198203d },
            { 6000.0d, 0.000199119d },
            { 8000.0d, 0.000200078d },
            { 10000.0d, 0.000201086d },
            { 12000.0d, 0.000202151d },
            { 14000.0d, 0.000203279d },
            { 16000.0d, 0.000204466d },
            { 18000.0d, 0.000205713d },
            { 20000.0d, 0.000207016d },
            { 22000.0d, 0.000208372d },
            { 24000.0d, 0.000209779d },
            { 26000.0d, 0.000211221d },
            { 28000.0d, 0.000212695d },
            { 30000.0d, 0.00021419d },
            { 32000.0d, 0.000215713d },
            { 34000.0d, 0.000217257d },
            { 36000.0d, 0.000218823d },
            { 38000.0d, 0.000220396d },
            { 40000.0d, 0.000221985d },
            { 42000.0d, 0.000223581d },
            { 44000.0d, 0.000225188d },
            { 46000.0d, 0.000226803d },
            { 48000.0d, 0.000228424d },
            { 50000.0d, 0.000230049d },
            { 52000.0d, 0.000231679d },
            { 54000.0d, 0.000233314d },
            { 56000.0d, 0.00023495d },
            { 58000.0d, 0.000236587d },
            { 60000.0d, 0.000238227d },
            { 62000.0d, 0.000239868d },
            { 64000.0d, 0.00024151d },
            { 66000.0d, 0.000243151d },
            { 68000.0d, 0.000244792d },
            { 70000.0d, 0.000246433d },
            { 72000.0d, 0.000248073d },
            { 74000.0d, 0.000249712d },
            { 76000.0d, 0.000251349d },
            { 78000.0d, 0.000252986d },
            { 80000.0d, 0.000254621d },
            { 82000.0d, 0.000256253d },
            { 84000.0d, 0.000257884d },
            { 86000.0d, 0.000259512d },
            { 88000.0d, 0.000261139d },
            { 90000.0d, 0.000262763d },
            { 92000.0d, 0.000264384d },
            { 94000.0d, 0.000266003d },
            { 96000.0d, 0.000267619d },
            { 98000.0d, 0.000269233d },
            { 100000.0d, 0.000270843d },
            { 110000.0d, 0.000278852d },
            { 120000.0d, 0.000286782d },
            { 130000.0d, 0.000294628d },
            { 140000.0d, 0.000302387d },
            { 150000.0d, 0.000310057d },
            { 160000.0d, 0.000317635d },
            { 170000.0d, 0.000325119d },
            { 180000.0d, 0.000332509d },
            { 190000.0d, 0.000339802d },
            { 200000.0d, 0.000346998d },
            { 210000.0d, 0.000354094d },
            { 220000.0d, 0.000361092d },
            { 230000.0d, 0.000367988d },
            { 240000.0d, 0.000374783d },
            { 250000.0d, 0.000381475d },
            { 260000.0d, 0.000388063d },
            { 270000.0d, 0.000394547d },
            { 280000.0d, 0.000400925d },
            { 290000.0d, 0.000407198d },
            { 300000.0d, 0.000413363d },
            { 310000.0d, 0.000419421d },
            { 320000.0d, 0.000425372d },
            { 330000.0d, 0.000431215d },
            { 340000.0d, 0.000436949d },
            { 350000.0d, 0.000442573d },
            { 360000.0d, 0.000448087d },
            { 370000.0d, 0.000453493d },
            { 380000.0d, 0.000458788d },
            { 390000.0d, 0.000463974d },
            { 400000.0d, 0.000469049d },
            { 410000.0d, 0.000474015d },
            { 420000.0d, 0.00047887d },
            { 430000.0d, 0.000483616d },
            { 440000.0d, 0.000488254d },
            { 450000.0d, 0.000492782d },
            { 460000.0d, 0.000497202d },
            { 470000.0d, 0.000501515d },
            { 480000.0d, 0.000505719d },
            { 490000.0d, 0.000509818d },
            { 500000.0d, 0.000513811d },
            { 510000.0d, 0.000517699d },
            { 520000.0d, 0.000521483d },
            { 530000.0d, 0.000525165d },
            { 540000.0d, 0.000528745d },
            { 550000.0d, 0.000532224d },
            { 560000.0d, 0.000535605d },
            { 570000.0d, 0.000538888d },
            { 580000.0d, 0.000542074d },
            { 590000.0d, 0.000545166d },
            { 600000.0d, 0.000548165d },
            { 610000.0d, 0.000551073d },
            { 620000.0d, 0.000553889d },
            { 630000.0d, 0.000556615d },
            { 640000.0d, 0.000559253d },
            { 650000.0d, 0.000561802d },
            { 660000.0d, 0.000564265d },
            { 670000.0d, 0.000566646d },
            { 680000.0d, 0.000568944d },
            { 690000.0d, 0.000571165d },
            { 700000.0d, 0.000573308d },
            { 710000.0d, 0.000575376d },
            { 720000.0d, 0.000577374d },
            { 730000.0d, 0.000579302d },
            { 740000.0d, 0.000581162d },
            { 750000.0d, 0.000582957d },
            { 760000.0d, 0.000584686d },
            { 770000.0d, 0.000586356d },
            { 780000.0d, 0.000587957d },
            { 790000.0d, 0.000589474d },
            { 800000.0d, 0.000590907d },
            { 810000.0d, 0.000592253d },
            { 820000.0d, 0.000593517d },
            { 830000.0d, 0.000594699d },
            { 840000.0d, 0.000595801d },
            { 850000.0d, 0.000596824d },
            { 860000.0d, 0.000597772d },
            { 870000.0d, 0.000598644d },
            { 880000.0d, 0.000599444d },
            { 890000.0d, 0.000600171d },
            { 900000.0d, 0.000600827d },
            { 910000.0d, 0.000601414d },
            { 920000.0d, 0.000601933d },
            { 930000.0d, 0.000602389d },
            { 940000.0d, 0.000602781d },
            { 950000.0d, 0.000603114d },
            { 960000.0d, 0.000603387d },
            { 970000.0d, 0.000603605d },
            { 980000.0d, 0.000603769d },
            { 990000.0d, 0.000603854d },
            { 1000000.0d, 0.000603858d },
            { 1013000.0d, 0.000603742d },
            { 1026000.0d, 0.00060349d },
            { 1039000.0d, 0.000603107d },
            { 1052000.0d, 0.000602595d },
            { 1065000.0d, 0.000601958d },
            { 1078000.0d, 0.000601195d },
            { 1091000.0d, 0.000600311d },
            { 1104000.0d, 0.00059931d },
            { 1117000.0d, 0.000598191d },
            { 1130000.0d, 0.000596933d },
            { 1143000.0d, 0.000595529d },
            { 1156000.0d, 0.000593981d },
            { 1169000.0d, 0.000592292d },
            { 1182000.0d, 0.000590463d },
            { 1195000.0d, 0.000588498d },
            { 1208000.0d, 0.000586397d },
            { 1221000.0d, 0.000584165d },
            { 1234000.0d, 0.000581795d },
            { 1247000.0d, 0.000579281d },
            { 1260000.0d, 0.000576623d },
            { 1273000.0d, 0.000573824d },
            { 1286000.0d, 0.000570885d },
            { 1299000.0d, 0.000567809d },
            { 1312000.0d, 0.000564599d },
            { 1325000.0d, 0.000561256d },
            { 1338000.0d, 0.000557783d },
            { 1351000.0d, 0.000554182d },
            { 1364000.0d, 0.000550455d },
            { 1377000.0d, 0.000546606d },
            { 1390000.0d, 0.000542638d },
            { 1403000.0d, 0.000538552d },
            { 1416000.0d, 0.000534351d },
            { 1429000.0d, 0.00053004d },
            { 1442000.0d, 0.00052562d },
            { 1455000.0d, 0.000521094d },
            { 1468000.0d, 0.000516466d },
            { 1481000.0d, 0.000511739d },
            { 1494000.0d, 0.000506916d },
            { 1507000.0d, 0.000501999d },
            { 1520000.0d, 0.000496991d },
            { 1533000.0d, 0.000491896d },
            { 1546000.0d, 0.000486717d },
            { 1559000.0d, 0.000481455d },
            { 1572000.0d, 0.000476114d },
            { 1585000.0d, 0.000470698d },
            { 1598000.0d, 0.00046521d },
            { 1611000.0d, 0.000459652d },
            { 1624000.0d, 0.000454031d },
            { 1637000.0d, 0.000448348d },
            { 1650000.0d, 0.00044261d },
            { 1663000.0d, 0.000436817d },
            { 1676000.0d, 0.000430976d },
            { 1689000.0d, 0.000425079d },
            { 1702000.0d, 0.000419125d },
            { 1715000.0d, 0.000413117d },
            { 1728000.0d, 0.000407058d },
            { 1741000.0d, 0.000400953d },
            { 1754000.0d, 0.000394806d },
            { 1767000.0d, 0.000388618d },
            { 1780000.0d, 0.000382396d },
            { 1793000.0d, 0.000376141d },
            { 1806000.0d, 0.000369859d },
            { 1819000.0d, 0.000363554d },
            { 1832000.0d, 0.000357228d },
            { 1845000.0d, 0.000350888d },
            { 1858000.0d, 0.000344537d },
            { 1871000.0d, 0.00033818d },
            { 1884000.0d, 0.000331821d },
            { 1897000.0d, 0.000325464d },
            { 1910000.0d, 0.000319115d },
            { 1923000.0d, 0.000312776d },
            { 1936000.0d, 0.000306454d },
            { 1949000.0d, 0.000300153d },
            { 1962000.0d, 0.000293877d },
            { 1975000.0d, 0.000287622d },
            { 1988000.0d, 0.000281369d },
            { 2001000.0d, 0.00027512d },
            { 2014000.0d, 0.000268879d },
            { 2027000.0d, 0.000262651d },
            { 2040000.0d, 0.000256435d },
            { 2053000.0d, 0.000250231d },
            { 2066000.0d, 0.000244046d },
            { 2079000.0d, 0.000237882d },
            { 2092000.0d, 0.000231745d },
            { 2105000.0d, 0.000225636d },
            { 2118000.0d, 0.000219559d },
            { 2131000.0d, 0.00021352d },
            { 2144000.0d, 0.000207521d },
            { 2157000.0d, 0.000201567d },
            { 2170000.0d, 0.000195663d },
            { 2183000.0d, 0.000189812d },
            { 2196000.0d, 0.000184019d },
            { 2209000.0d, 0.000178289d },
            { 2222000.0d, 0.000172626d },
            { 2235000.0d, 0.000167034d },
            { 2248000.0d, 0.000161518d },
            { 2261000.0d, 0.000156083d },
            { 2274000.0d, 0.000150732d },
            { 2287000.0d, 0.000145472d },
            { 2300000.0d, 0.000140306d },
            { 2313000.0d, 0.000135238d },
            { 2326000.0d, 0.000130275d },
            { 2339000.0d, 0.000125414d },
            { 2352000.0d, 0.000120635d },
            { 2365000.0d, 0.000115937d },
            { 2378000.0d, 0.000111326d },
            { 2391000.0d, 0.000106805d },
            { 2404000.0d, 0.000102378d },
            { 2417000.0d, 0.0000980485d },
            { 2430000.0d, 0.0000938218d },
            { 2443000.0d, 0.000089702d },
            { 2456000.0d, 0.0000856928d },
            { 2469000.0d, 0.000081799d },
            { 2482000.0d, 0.0000780246d },
            { 2495000.0d, 0.000074374d },
            { 2508000.0d, 0.0000708518d },
            { 2521000.0d, 0.0000674623d },
            { 2534000.0d, 0.00006421d },
            { 2547000.0d, 0.000061099d },
            { 2560000.0d, 0.0000581346d },
            { 2573000.0d, 0.0000553206d },
            { 2586000.0d, 0.0000526617d },
            { 2599000.0d, 0.0000501629d },
            { 2612000.0d, 0.0000478283d },
            { 2625000.0d, 0.0000456625d },
            { 2638000.0d, 0.0000436702d },
            { 2651000.0d, 0.0000418557d },
            { 2664000.0d, 0.0000401852d },
            { 2677000.0d, 0.0000386159d },
            { 2690000.0d, 0.0000371504d },
            { 2703000.0d, 0.0000357915d },
            { 2716000.0d, 0.0000345416d },
            { 2729000.0d, 0.0000334036d },
            { 2742000.0d, 0.0000323804d },
            { 2755000.0d, 0.0000314745d },
            { 2768000.0d, 0.0000306885d },
            { 2781000.0d, 0.0000300004d },
            { 2794000.0d, 0.0000293402d },
            { 2807000.0d, 0.000028704d },
            { 2820000.0d, 0.0000280924d },
            { 2833000.0d, 0.0000275064d },
            { 2846000.0d, 0.0000269465d },
            { 2859000.0d, 0.0000264135d },
            { 2872000.0d, 0.0000259081d },
            { 2885000.0d, 0.0000254312d },
            { 2898000.0d, 0.0000249834d },
            { 2911000.0d, 0.0000245655d },
            { 2924000.0d, 0.0000241782d },
            { 2937000.0d, 0.0000238222d },
            { 2950000.0d, 0.0000234982d },
            { 2963000.0d, 0.0000231873d },
            { 2976000.0d, 0.000022873d },
            { 2989000.0d, 0.0000225554d },
            { 3002000.0d, 0.0000222344d },
            { 3015000.0d, 0.0000219103d },
            { 3028000.0d, 0.0000215829d },
            { 3041000.0d, 0.0000212524d },
            { 3054000.0d, 0.0000209188d },
            { 3067000.0d, 0.0000205822d },
            { 3080000.0d, 0.0000202427d },
            { 3093000.0d, 0.0000199004d },
            { 3106000.0d, 0.0000195554d },
            { 3119000.0d, 0.0000192078d },
            { 3132000.0d, 0.0000188575d },
            { 3145000.0d, 0.0000185047d },
            { 3158000.0d, 0.0000181496d },
            { 3171000.0d, 0.0000177923d },
            { 3184000.0d, 0.0000174327d },
            { 3197000.0d, 0.0000170712d },
            { 3210000.0d, 0.0000167077d },
            { 3223000.0d, 0.0000163426d },
            { 3236000.0d, 0.0000159757d },
            { 3249000.0d, 0.0000156073d },
            { 3262000.0d, 0.0000152376d },
            { 3275000.0d, 0.0000148667d },
            { 3288000.0d, 0.0000144947d },
            { 3301000.0d, 0.0000141218d },
            { 3314000.0d, 0.0000137483d },
            { 3327000.0d, 0.0000133741d },
            { 3340000.0d, 0.0000129995d },
            { 3353000.0d, 0.0000126248d },
            { 3366000.0d, 0.0000122502d },
            { 3379000.0d, 0.0000118757d },
            { 3392000.0d, 0.0000115017d },
            { 3405000.0d, 0.0000111283d },
            { 3418000.0d, 0.0000107557d },
            { 3431000.0d, 0.0000103843d },
            { 3444000.0d, 0.0000100141d },
            { 3457000.0d, 0.00000964555d },
            { 3470000.0d, 0.0000092788d },
            { 3483000.0d, 0.0000089141d },
            { 3496000.0d, 0.00000855174d },
            { 3509000.0d, 0.00000819198d },
            { 3522000.0d, 0.00000783512d },
            { 3535000.0d, 0.00000748144d },
            { 3548000.0d, 0.00000713123d },
            { 3561000.0d, 0.00000678482d },
            { 3574000.0d, 0.00000644249d },
            { 3587000.0d, 0.00000610459d },
            { 3600000.0d, 0.00000577143d },
            { 3613000.0d, 0.00000544337d },
            { 3626000.0d, 0.00000512075d },
            { 3639000.0d, 0.00000480393d },
            { 3652000.0d, 0.00000449327d },
            { 3665000.0d, 0.00000418915d },
            { 3678000.0d, 0.00000389196d },
            { 3691000.0d, 0.00000360209d },
            { 3704000.0d, 0.00000331995d },
            { 3717000.0d, 0.00000304595d },
            { 3730000.0d, 0.00000278051d },
            { 3743000.0d, 0.00000252407d },
            { 3756000.0d, 0.00000227708d },
            { 3769000.0d, 0.00000203998d },
            { 3782000.0d, 0.00000181324d },
            { 3795000.0d, 0.00000159733d },
            { 3808000.0d, 0.00000139274d },
            { 3821000.0d, 0.00000119995d },
            { 3834000.0d, 0.00000101948d },
            { 3847000.0d, 0.000000851833d },
            { 3860000.0d, 0.000000697537d },
            { 3873000.0d, 0.000000557125d },
            { 3886000.0d, 0.000000431138d },
            { 3899000.0d, 0.000000320126d },
            { 3912000.0d, 0.000000224648d },
            { 3925000.0d, 0.000000145268d },
            { 3938000.0d, 0.0000000825564d },
            { 3951000.0d, 0.0000000370808d },
            { 3964000.0d, 0.00000000939808d },
            { 3977000.0d, 0.00000000000114528d },
            { 3977100.0d, 0d },

        }; 
    }
}
    