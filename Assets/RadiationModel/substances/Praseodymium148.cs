using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium148";
        public override double halfLife { get; } = 137.4d;
        public override double atomicWeight { get; } = 147.92213d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium148()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.008086d, new GammaParticle(247400.0, 0.00501)), new(0.622d, new GammaParticle(301702.0, 0.00411)), new(0.0018659999999999998d, new GammaParticle(418700.0, 0.00296)), new(0.029234d, new GammaParticle(450800.0, 0.00275)), new(0.009951999999999999d, new GammaParticle(492400.0, 0.00252)), new(0.0024879999999999998d, new GammaParticle(496800.0, 0.0025)), new(0.00311d, new GammaParticle(512200.0, 0.00242)), new(0.0024879999999999998d, new GammaParticle(522200.0, 0.00237)), new(0.00311d, new GammaParticle(562400.0, 0.0022)), new(0.024258000000000002d, new GammaParticle(615100.0, 0.00202)), new(0.0049759999999999995d, new GammaParticle(622700.0, 0.00199)), new(0.011196d, new GammaParticle(636500.0, 0.00195)), new(0.017416d, new GammaParticle(660000.0, 0.00188)), new(0.057846d, new GammaParticle(697500.0, 0.00178)), new(0.037942000000000004d, new GammaParticle(721300.0, 0.00172)), new(0.0024879999999999998d, new GammaParticle(759300.0, 0.00163)), new(0.0037319999999999996d, new GammaParticle(800000.0, 0.00155)), new(0.016794d, new GammaParticle(825300.0, 0.0015)), new(0.041052d, new GammaParticle(869200.0, 0.00143)), new(0.0049759999999999995d, new GammaParticle(894400.0, 0.00139)), new(0.013062d, new GammaParticle(903100.0, 0.00137)), new(0.0024879999999999998d, new GammaParticle(918400.0, 0.00135)), new(0.0018659999999999998d, new GammaParticle(933700.0, 0.00133)), new(0.017416d, new GammaParticle(947100.0, 0.00131)), new(0.004354d, new GammaParticle(999000.0, 0.00124)), new(0.056602d, new GammaParticle(1023200.0, 0.00121)), new(0.0037319999999999996d, new GammaParticle(1050500.0, 0.00118)), new(0.004354d, new GammaParticle(1065500.0, 0.00116)), new(0.0049759999999999995d, new GammaParticle(1156500.0, 0.00107)), new(0.013062d, new GammaParticle(1157400.0, 0.00107)), new(0.010573999999999998d, new GammaParticle(1171200.0, 0.00106)), new(0.00311d, new GammaParticle(1182700.0, 0.00105)), new(0.016172d, new GammaParticle(1209900.0, 0.00102)), new(0.054736d, new GammaParticle(1248600.0, 0.00099)), new(0.008086d, new GammaParticle(1260700.0, 0.00098)), new(0.0049759999999999995d, new GammaParticle(1271200.0, 0.00098)), new(0.004354d, new GammaParticle(1343700.0, 0.00092)), new(0.066554d, new GammaParticle(1358230.0, 0.00091)), new(0.021147999999999997d, new GammaParticle(1382100.0, 0.0009)), new(0.0012439999999999999d, new GammaParticle(1409800.0, 0.00088)), new(0.004354d, new GammaParticle(1418600.0, 0.00087)), new(0.008708d, new GammaParticle(1521800.0, 0.00081)), new(0.0037319999999999996d, new GammaParticle(1658500.0, 0.00075)), new(0.004354d, new GammaParticle(1682800.0, 0.00074)), new(0.014927999999999999d, new GammaParticle(1771700.0, 0.0007)), new(0.0024879999999999998d, new GammaParticle(1880900.0, 0.00066)), new(0.010573999999999998d, new GammaParticle(1907100.0, 0.00065)), new(0.00622d, new GammaParticle(1931900.0, 0.00064)), new(0.0008086d, new GammaParticle(2106700.0, 0.00059)), new(0.022392d, new GammaParticle(2129600.0, 0.00058)), new(0.0037319999999999996d, new GammaParticle(2141800.0, 0.00058)), new(0.0037319999999999996d, new GammaParticle(2222500.0, 0.00056)), new(0.014927999999999999d, new GammaParticle(2629000.0, 0.00047)), new(0.007463999999999999d, new GammaParticle(2735300.0, 0.00045)), new(0.00622d, new GammaParticle(2982600.0, 0.00042)), new(0.00394983623586384d, new GammaParticle(5870.0, 0.21122)), new(0.006869828276761199d, new GammaParticle(36848.0, 0.03365)), new(0.01251106952606301d, new GammaParticle(37362.0, 0.03318)), new(0.003842259134816064d, new GammaParticle(42380.0, 0.02926)), new(0.0048297197324637916d, new GammaParticle(42810.0, 0.02896)), new(0.0009874605976477283d, new GammaParticle(43335.0, 0.02861)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000131109d },
            { 5000.0d, 0.000132958d },
            { 10000.0d, 0.000134767d },
            { 15000.0d, 0.000136537d },
            { 20000.0d, 0.000138272d },
            { 25000.0d, 0.000139985d },
            { 30000.0d, 0.000141685d },
            { 35000.0d, 0.000143379d },
            { 40000.0d, 0.000145068d },
            { 45000.0d, 0.000146757d },
            { 50000.0d, 0.00014845d },
            { 55000.0d, 0.000150148d },
            { 60000.0d, 0.000151851d },
            { 65000.0d, 0.00015356d },
            { 70000.0d, 0.000155275d },
            { 75000.0d, 0.000156995d },
            { 80000.0d, 0.000158722d },
            { 85000.0d, 0.000160453d },
            { 90000.0d, 0.00016219d },
            { 95000.0d, 0.000163931d },
            { 100000.0d, 0.000165677d },
            { 110000.0d, 0.000169179d },
            { 120000.0d, 0.000172694d },
            { 130000.0d, 0.000176218d },
            { 140000.0d, 0.000179748d },
            { 150000.0d, 0.000183282d },
            { 160000.0d, 0.000186818d },
            { 170000.0d, 0.000190352d },
            { 180000.0d, 0.000193883d },
            { 190000.0d, 0.000197409d },
            { 200000.0d, 0.000200928d },
            { 210000.0d, 0.000204438d },
            { 220000.0d, 0.000207939d },
            { 230000.0d, 0.000211427d },
            { 240000.0d, 0.000214903d },
            { 250000.0d, 0.000218365d },
            { 260000.0d, 0.000221811d },
            { 270000.0d, 0.00022524d },
            { 280000.0d, 0.000228652d },
            { 290000.0d, 0.000232044d },
            { 300000.0d, 0.000235417d },
            { 310000.0d, 0.000238769d },
            { 320000.0d, 0.0002421d },
            { 330000.0d, 0.000245408d },
            { 340000.0d, 0.000248692d },
            { 350000.0d, 0.000251953d },
            { 360000.0d, 0.000255188d },
            { 370000.0d, 0.000258398d },
            { 380000.0d, 0.000261581d },
            { 390000.0d, 0.000264737d },
            { 400000.0d, 0.000267865d },
            { 410000.0d, 0.000270965d },
            { 420000.0d, 0.000274035d },
            { 430000.0d, 0.000277077d },
            { 440000.0d, 0.000280087d },
            { 450000.0d, 0.000283067d },
            { 460000.0d, 0.000286016d },
            { 470000.0d, 0.000288932d },
            { 480000.0d, 0.000291817d },
            { 490000.0d, 0.000294668d },
            { 500000.0d, 0.000297487d },
            { 510000.0d, 0.000300271d },
            { 520000.0d, 0.000303021d },
            { 530000.0d, 0.000305736d },
            { 540000.0d, 0.000308417d },
            { 550000.0d, 0.000311062d },
            { 560000.0d, 0.000313671d },
            { 570000.0d, 0.000316244d },
            { 580000.0d, 0.00031878d },
            { 590000.0d, 0.00032128d },
            { 600000.0d, 0.000323742d },
            { 610000.0d, 0.000326167d },
            { 620000.0d, 0.000328554d },
            { 630000.0d, 0.000330902d },
            { 640000.0d, 0.000333213d },
            { 650000.0d, 0.000335485d },
            { 660000.0d, 0.000337718d },
            { 670000.0d, 0.000339912d },
            { 680000.0d, 0.000342067d },
            { 690000.0d, 0.000344182d },
            { 700000.0d, 0.000346258d },
            { 710000.0d, 0.000348293d },
            { 720000.0d, 0.000350289d },
            { 730000.0d, 0.000352244d },
            { 740000.0d, 0.000354159d },
            { 750000.0d, 0.000356033d },
            { 760000.0d, 0.000357867d },
            { 770000.0d, 0.00035966d },
            { 780000.0d, 0.000361413d },
            { 790000.0d, 0.000363124d },
            { 800000.0d, 0.000364794d },
            { 810000.0d, 0.000366423d },
            { 820000.0d, 0.000368011d },
            { 830000.0d, 0.000369557d },
            { 840000.0d, 0.000371063d },
            { 850000.0d, 0.000372526d },
            { 860000.0d, 0.000373949d },
            { 870000.0d, 0.00037533d },
            { 880000.0d, 0.00037667d },
            { 890000.0d, 0.000377969d },
            { 900000.0d, 0.000379226d },
            { 910000.0d, 0.000380442d },
            { 920000.0d, 0.000381616d },
            { 930000.0d, 0.00038275d },
            { 940000.0d, 0.000383842d },
            { 950000.0d, 0.000384893d },
            { 960000.0d, 0.000385903d },
            { 970000.0d, 0.000386871d },
            { 980000.0d, 0.0003878d },
            { 990000.0d, 0.000388687d },
            { 1000000.0d, 0.000389534d },
            { 1016000.0d, 0.000390804d },
            { 1032000.0d, 0.000391971d },
            { 1048000.0d, 0.000393035d },
            { 1064000.0d, 0.000393997d },
            { 1080000.0d, 0.000394858d },
            { 1096000.0d, 0.000395618d },
            { 1112000.0d, 0.000396278d },
            { 1128000.0d, 0.00039684d },
            { 1144000.0d, 0.000397304d },
            { 1160000.0d, 0.00039767d },
            { 1176000.0d, 0.000397941d },
            { 1192000.0d, 0.000398117d },
            { 1208000.0d, 0.000398199d },
            { 1224000.0d, 0.000398188d },
            { 1240000.0d, 0.000398087d },
            { 1256000.0d, 0.000397896d },
            { 1272000.0d, 0.000397616d },
            { 1288000.0d, 0.000397249d },
            { 1304000.0d, 0.000396796d },
            { 1320000.0d, 0.000396259d },
            { 1336000.0d, 0.00039564d },
            { 1352000.0d, 0.00039494d },
            { 1368000.0d, 0.00039416d },
            { 1384000.0d, 0.000393303d },
            { 1400000.0d, 0.00039237d },
            { 1416000.0d, 0.000391364d },
            { 1432000.0d, 0.000390285d },
            { 1448000.0d, 0.000389136d },
            { 1464000.0d, 0.000387919d },
            { 1480000.0d, 0.000386636d },
            { 1496000.0d, 0.000385289d },
            { 1512000.0d, 0.00038388d },
            { 1528000.0d, 0.000382411d },
            { 1544000.0d, 0.000380884d },
            { 1560000.0d, 0.000379303d },
            { 1576000.0d, 0.000377668d },
            { 1592000.0d, 0.000375982d },
            { 1608000.0d, 0.000374249d },
            { 1624000.0d, 0.000372469d },
            { 1640000.0d, 0.000370646d },
            { 1656000.0d, 0.000368782d },
            { 1672000.0d, 0.000366879d },
            { 1688000.0d, 0.000364941d },
            { 1704000.0d, 0.00036297d },
            { 1720000.0d, 0.000360969d },
            { 1736000.0d, 0.00035894d },
            { 1752000.0d, 0.000356886d },
            { 1768000.0d, 0.000354809d },
            { 1784000.0d, 0.000352712d },
            { 1800000.0d, 0.000350597d },
            { 1816000.0d, 0.000348468d },
            { 1832000.0d, 0.000346327d },
            { 1848000.0d, 0.000344173d },
            { 1864000.0d, 0.000342002d },
            { 1880000.0d, 0.000339815d },
            { 1896000.0d, 0.000337616d },
            { 1912000.0d, 0.000335406d },
            { 1928000.0d, 0.000333189d },
            { 1944000.0d, 0.000330968d },
            { 1960000.0d, 0.000328717d },
            { 1976000.0d, 0.000326428d },
            { 1992000.0d, 0.000324101d },
            { 2008000.0d, 0.000321738d },
            { 2024000.0d, 0.000319342d },
            { 2040000.0d, 0.000316912d },
            { 2056000.0d, 0.000314452d },
            { 2072000.0d, 0.000311962d },
            { 2088000.0d, 0.000309446d },
            { 2104000.0d, 0.000306903d },
            { 2120000.0d, 0.000304336d },
            { 2136000.0d, 0.000301747d },
            { 2152000.0d, 0.000299137d },
            { 2168000.0d, 0.000296509d },
            { 2184000.0d, 0.000293864d },
            { 2200000.0d, 0.000291203d },
            { 2216000.0d, 0.00028853d },
            { 2232000.0d, 0.000285845d },
            { 2248000.0d, 0.000283151d },
            { 2264000.0d, 0.000280449d },
            { 2280000.0d, 0.000277742d },
            { 2296000.0d, 0.000275032d },
            { 2312000.0d, 0.00027232d },
            { 2328000.0d, 0.000269608d },
            { 2344000.0d, 0.000266896d },
            { 2360000.0d, 0.000264184d },
            { 2376000.0d, 0.000261472d },
            { 2392000.0d, 0.000258764d },
            { 2408000.0d, 0.000256061d },
            { 2424000.0d, 0.000253364d },
            { 2440000.0d, 0.000250677d },
            { 2456000.0d, 0.000247993d },
            { 2472000.0d, 0.000245301d },
            { 2488000.0d, 0.000242597d },
            { 2504000.0d, 0.000239881d },
            { 2520000.0d, 0.000237154d },
            { 2536000.0d, 0.000234417d },
            { 2552000.0d, 0.000231672d },
            { 2568000.0d, 0.00022892d },
            { 2584000.0d, 0.000226163d },
            { 2600000.0d, 0.000223402d },
            { 2616000.0d, 0.000220638d },
            { 2632000.0d, 0.000217874d },
            { 2648000.0d, 0.00021511d },
            { 2664000.0d, 0.000212349d },
            { 2680000.0d, 0.000209591d },
            { 2696000.0d, 0.000206838d },
            { 2712000.0d, 0.00020409d },
            { 2728000.0d, 0.000201349d },
            { 2744000.0d, 0.000198616d },
            { 2760000.0d, 0.000195893d },
            { 2776000.0d, 0.000193182d },
            { 2792000.0d, 0.000190484d },
            { 2808000.0d, 0.000187797d },
            { 2824000.0d, 0.000185107d },
            { 2840000.0d, 0.000182416d },
            { 2856000.0d, 0.000179724d },
            { 2872000.0d, 0.000177032d },
            { 2888000.0d, 0.000174343d },
            { 2904000.0d, 0.000171657d },
            { 2920000.0d, 0.000168977d },
            { 2936000.0d, 0.000166304d },
            { 2952000.0d, 0.00016364d },
            { 2968000.0d, 0.000160986d },
            { 2984000.0d, 0.000158344d },
            { 3000000.0d, 0.000155717d },
            { 3016000.0d, 0.000153106d },
            { 3032000.0d, 0.000150512d },
            { 3048000.0d, 0.000147939d },
            { 3064000.0d, 0.000145387d },
            { 3080000.0d, 0.00014286d },
            { 3096000.0d, 0.00014036d },
            { 3112000.0d, 0.000137888d },
            { 3128000.0d, 0.000135446d },
            { 3144000.0d, 0.000133039d },
            { 3160000.0d, 0.000130666d },
            { 3176000.0d, 0.000128332d },
            { 3192000.0d, 0.000126039d },
            { 3208000.0d, 0.000123777d },
            { 3224000.0d, 0.000121537d },
            { 3240000.0d, 0.000119304d },
            { 3256000.0d, 0.000117077d },
            { 3272000.0d, 0.000114857d },
            { 3288000.0d, 0.000112645d },
            { 3304000.0d, 0.000110443d },
            { 3320000.0d, 0.000108251d },
            { 3336000.0d, 0.000106069d },
            { 3352000.0d, 0.0001039d },
            { 3368000.0d, 0.000101744d },
            { 3384000.0d, 0.0000995986d },
            { 3400000.0d, 0.0000974647d },
            { 3416000.0d, 0.0000953435d },
            { 3432000.0d, 0.0000932359d },
            { 3448000.0d, 0.0000911431d },
            { 3464000.0d, 0.000089066d },
            { 3480000.0d, 0.0000870056d },
            { 3496000.0d, 0.0000849632d },
            { 3512000.0d, 0.0000829397d },
            { 3528000.0d, 0.0000809361d },
            { 3544000.0d, 0.0000789538d },
            { 3560000.0d, 0.0000769938d },
            { 3576000.0d, 0.0000750571d },
            { 3592000.0d, 0.000073145d },
            { 3608000.0d, 0.0000712587d },
            { 3624000.0d, 0.0000693992d },
            { 3640000.0d, 0.0000675634d },
            { 3656000.0d, 0.0000657496d },
            { 3672000.0d, 0.0000639584d },
            { 3688000.0d, 0.0000621912d },
            { 3704000.0d, 0.0000604491d },
            { 3720000.0d, 0.0000587303d },
            { 3736000.0d, 0.0000570345d },
            { 3752000.0d, 0.000055363d },
            { 3768000.0d, 0.0000537169d },
            { 3784000.0d, 0.0000520972d },
            { 3800000.0d, 0.0000505052d },
            { 3816000.0d, 0.0000489418d },
            { 3832000.0d, 0.0000474084d },
            { 3848000.0d, 0.0000459061d },
            { 3864000.0d, 0.0000444332d },
            { 3880000.0d, 0.0000429862d },
            { 3896000.0d, 0.000041558d },
            { 3912000.0d, 0.0000401477d },
            { 3928000.0d, 0.0000387559d },
            { 3944000.0d, 0.0000373834d },
            { 3960000.0d, 0.0000360309d },
            { 3976000.0d, 0.000034697d },
            { 3992000.0d, 0.000033382d },
            { 4008000.0d, 0.0000320867d },
            { 4024000.0d, 0.0000308116d },
            { 4040000.0d, 0.0000295577d },
            { 4056000.0d, 0.0000283256d },
            { 4072000.0d, 0.0000271161d },
            { 4088000.0d, 0.00002593d },
            { 4104000.0d, 0.0000247681d },
            { 4120000.0d, 0.0000236311d },
            { 4136000.0d, 0.0000225178d },
            { 4152000.0d, 0.0000214269d },
            { 4168000.0d, 0.0000203586d },
            { 4184000.0d, 0.0000193138d },
            { 4200000.0d, 0.0000182931d },
            { 4216000.0d, 0.0000172969d },
            { 4232000.0d, 0.0000163259d },
            { 4248000.0d, 0.0000153807d },
            { 4264000.0d, 0.0000144619d },
            { 4280000.0d, 0.0000135699d },
            { 4296000.0d, 0.0000127056d },
            { 4312000.0d, 0.0000118694d },
            { 4328000.0d, 0.000011062d },
            { 4344000.0d, 0.0000102839d },
            { 4360000.0d, 0.00000953576d },
            { 4376000.0d, 0.00000881821d },
            { 4392000.0d, 0.0000081318d },
            { 4408000.0d, 0.00000747719d },
            { 4424000.0d, 0.00000685493d },
            { 4440000.0d, 0.00000626566d },
            { 4456000.0d, 0.00000570999d },
            { 4472000.0d, 0.00000518849d },
            { 4488000.0d, 0.00000470177d },
            { 4504000.0d, 0.00000425042d },
            { 4520000.0d, 0.00000383503d },
            { 4536000.0d, 0.00000345615d },
            { 4552000.0d, 0.00000311434d },
            { 4568000.0d, 0.00000281005d },
            { 4584000.0d, 0.00000253389d },
            { 4600000.0d, 0.00000227084d },
            { 4616000.0d, 0.00000202092d },
            { 4632000.0d, 0.00000178438d },
            { 4648000.0d, 0.00000156146d },
            { 4664000.0d, 0.00000135239d },
            { 4680000.0d, 0.00000115739d },
            { 4696000.0d, 0.000000976724d },
            { 4712000.0d, 0.000000810607d },
            { 4728000.0d, 0.000000659275d },
            { 4744000.0d, 0.000000522962d },
            { 4760000.0d, 0.000000401902d },
            { 4776000.0d, 0.000000296321d },
            { 4792000.0d, 0.000000206445d },
            { 4808000.0d, 0.000000132497d },
            { 4824000.0d, 0.000000074692d },
            { 4840000.0d, 0.000000033231d },
            { 4856000.0d, 0.00000000829489d },
            { 4872000.0d, 0d },

        }; 
    }
}
    