using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium143";
        public override double halfLife { get; } = 155.4d;
        public override double atomicWeight { get; } = 142.9203d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium143()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.019251d, new GammaParticle(107690.0, 0.01151)), new(0.0013109999999999999d, new GammaParticle(203100.0, 0.0061)), new(0.0010488d, new GammaParticle(429600.0, 0.00289)), new(0.00039329999999999996d, new GammaParticle(458400.0, 0.0027)), new(0.000552d, new GammaParticle(551400.0, 0.00225)), new(0.000621d, new GammaParticle(556600.0, 0.00223)), new(0.002415d, new GammaParticle(607600.0, 0.00204)), new(0.0005313d, new GammaParticle(691200.0, 0.00179)), new(0.0005796d, new GammaParticle(733100.0, 0.00169)), new(0.002001d, new GammaParticle(754000.0, 0.00164)), new(0.0006900000000000001d, new GammaParticle(798100.0, 0.00155)), new(0.009245999999999999d, new GammaParticle(805300.0, 0.00154)), new(0.005037000000000001d, new GammaParticle(999600.0, 0.00124)), new(0.069d, new GammaParticle(1107300.0, 0.00112)), new(0.0002553d, new GammaParticle(1163300.0, 0.00107)), new(0.000552d, new GammaParticle(1272200.0, 0.00097)), new(0.00828d, new GammaParticle(1369100.0, 0.00091)), new(0.003243d, new GammaParticle(1429300.0, 0.00087)), new(0.010695d, new GammaParticle(1458400.0, 0.00085)), new(0.030291000000000002d, new GammaParticle(1536800.0, 0.00081)), new(0.005520000000000001d, new GammaParticle(1566100.0, 0.00079)), new(0.00031739999999999996d, new GammaParticle(1578500.0, 0.00079)), new(0.009315d, new GammaParticle(1607300.0, 0.00077)), new(0.000897d, new GammaParticle(1668800.0, 0.00074)), new(0.0002208d, new GammaParticle(1680900.0, 0.00074)), new(0.001587d, new GammaParticle(1715200.0, 0.00072)), new(0.00024150000000000002d, new GammaParticle(1779100.0, 0.0007)), new(0.015318d, new GammaParticle(1804900.0, 0.00069)), new(0.019596d, new GammaParticle(1912700.0, 0.00065)), new(0.000552d, new GammaParticle(1955300.0, 0.00063)), new(0.0021390000000000003d, new GammaParticle(1962600.0, 0.00063)), new(0.0002622d, new GammaParticle(2001600.0, 0.00062)), new(0.004692d, new GammaParticle(2070300.0, 0.0006)), new(0.008694d, new GammaParticle(2102500.0, 0.00059)), new(0.0003312d, new GammaParticle(2131500.0, 0.00058)), new(0.00048300000000000003d, new GammaParticle(2167300.0, 0.00057)), new(0.0037259999999999997d, new GammaParticle(2228000.0, 0.00056)), new(0.001104d, new GammaParticle(2270800.0, 0.00055)), new(0.0002346d, new GammaParticle(2280000.0, 0.00054)), new(0.0003105d, new GammaParticle(2303000.0, 0.00054)), new(0.0002001d, new GammaParticle(2312400.0, 0.00054)), new(0.00031739999999999996d, new GammaParticle(2323600.0, 0.00053)), new(0.00015869999999999998d, new GammaParticle(2410700.0, 0.00051)), new(0.00031739999999999996d, new GammaParticle(2450600.0, 0.00051)), new(0.0007796999999999999d, new GammaParticle(2479900.0, 0.0005)), new(0.0003105d, new GammaParticle(2557900.0, 0.00048)), new(0.0001518d, new GammaParticle(2571100.0, 0.00048)), new(0.0001035d, new GammaParticle(2578200.0, 0.00048)), new(0.0004416d, new GammaParticle(2587400.0, 0.00048)), new(0.000207d, new GammaParticle(2646800.0, 0.00047)), new(0.0003726d, new GammaParticle(2685800.0, 0.00046)), new(0.0001518d, new GammaParticle(2708900.0, 0.00046)), new(9.66e-05d, new GammaParticle(2842100.0, 0.00044)), new(0.0001311d, new GammaParticle(3031200.0, 0.00041)), new(0.0001035d, new GammaParticle(3154000.0, 0.00039)), new(8.970000000000001e-05d, new GammaParticle(3342900.0, 0.00037)), new(4.83e-05d, new GammaParticle(4093000.0, 0.0003)), new(1.50648d, new GammaParticle(511000.0, 0.00243)), new(0.036882292822848d, new GammaParticle(6354.0, 0.19513)), new(0.06134537118916592d, new GammaParticle(39522.0, 0.03137)), new(0.11103234604373922d, new GammaParticle(40117.0, 0.03091)), new(0.03470848630770658d, new GammaParticle(45523.0, 0.02724)), new(0.04366327577509487d, new GammaParticle(45998.0, 0.02695)), new(0.008954789467388296d, new GammaParticle(46575.0, 0.02662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 3000.0d, 0.00000000000666905d },
            { 6000.0d, 0.00000000184802d },
            { 9000.0d, 0.0000000178436d },
            { 12000.0d, 0.0000000665365d },
            { 15000.0d, 0.00000013742d },
            { 18000.0d, 0.000000232449d },
            { 21000.0d, 0.00000035334d },
            { 24000.0d, 0.000000501316d },
            { 27000.0d, 0.000000675704d },
            { 30000.0d, 0.0000008876d },
            { 33000.0d, 0.00000113701d },
            { 36000.0d, 0.0000014193d },
            { 39000.0d, 0.0000017343d },
            { 42000.0d, 0.00000208179d },
            { 45000.0d, 0.00000245854d },
            { 48000.0d, 0.00000286623d },
            { 51000.0d, 0.00000330428d },
            { 54000.0d, 0.00000377238d },
            { 57000.0d, 0.00000426751d },
            { 60000.0d, 0.00000478464d },
            { 63000.0d, 0.00000532754d },
            { 66000.0d, 0.00000589541d },
            { 69000.0d, 0.00000648858d },
            { 72000.0d, 0.00000710058d },
            { 75000.0d, 0.00000773068d },
            { 78000.0d, 0.00000838173d },
            { 81000.0d, 0.00000905316d },
            { 84000.0d, 0.00000974424d },
            { 87000.0d, 0.0000104469d },
            { 90000.0d, 0.0000111665d },
            { 93000.0d, 0.0000119018d },
            { 96000.0d, 0.0000126533d },
            { 99000.0d, 0.0000134188d },
            { 102000.0d, 0.0000141941d },
            { 112000.0d, 0.0000168712d },
            { 122000.0d, 0.00001966d },
            { 132000.0d, 0.0000225488d },
            { 142000.0d, 0.0000255207d },
            { 152000.0d, 0.0000285603d },
            { 162000.0d, 0.000031658d },
            { 172000.0d, 0.0000348052d },
            { 182000.0d, 0.0000379931d },
            { 192000.0d, 0.0000412134d },
            { 202000.0d, 0.0000444623d },
            { 212000.0d, 0.000047734d },
            { 222000.0d, 0.0000510232d },
            { 232000.0d, 0.0000543266d },
            { 242000.0d, 0.0000576409d },
            { 252000.0d, 0.000060963d },
            { 262000.0d, 0.0000642894d },
            { 272000.0d, 0.0000676187d },
            { 282000.0d, 0.0000709485d },
            { 292000.0d, 0.0000742765d },
            { 302000.0d, 0.0000776012d },
            { 312000.0d, 0.0000809213d },
            { 322000.0d, 0.0000842351d },
            { 332000.0d, 0.0000875411d },
            { 342000.0d, 0.0000908384d },
            { 352000.0d, 0.000094126d },
            { 362000.0d, 0.0000974027d },
            { 372000.0d, 0.000100668d },
            { 382000.0d, 0.00010392d },
            { 392000.0d, 0.000107159d },
            { 402000.0d, 0.000110383d },
            { 412000.0d, 0.000113593d },
            { 422000.0d, 0.000116787d },
            { 432000.0d, 0.000119965d },
            { 442000.0d, 0.000123127d },
            { 452000.0d, 0.00012627d },
            { 462000.0d, 0.000129397d },
            { 472000.0d, 0.000132504d },
            { 482000.0d, 0.000135593d },
            { 492000.0d, 0.000138663d },
            { 502000.0d, 0.000141713d },
            { 512000.0d, 0.000144743d },
            { 522000.0d, 0.000147752d },
            { 532000.0d, 0.00015074d },
            { 542000.0d, 0.000153706d },
            { 552000.0d, 0.000156651d },
            { 562000.0d, 0.000159575d },
            { 572000.0d, 0.000162476d },
            { 582000.0d, 0.000165354d },
            { 592000.0d, 0.000168209d },
            { 602000.0d, 0.000171041d },
            { 612000.0d, 0.00017385d },
            { 622000.0d, 0.000176634d },
            { 632000.0d, 0.000179394d },
            { 642000.0d, 0.00018213d },
            { 652000.0d, 0.000184841d },
            { 662000.0d, 0.000187528d },
            { 672000.0d, 0.00019019d },
            { 682000.0d, 0.000192826d },
            { 692000.0d, 0.000195436d },
            { 702000.0d, 0.00019802d },
            { 712000.0d, 0.000200579d },
            { 722000.0d, 0.000203111d },
            { 732000.0d, 0.000205617d },
            { 742000.0d, 0.000208095d },
            { 752000.0d, 0.000210548d },
            { 762000.0d, 0.000212974d },
            { 772000.0d, 0.000215372d },
            { 782000.0d, 0.000217743d },
            { 792000.0d, 0.000220086d },
            { 802000.0d, 0.000222402d },
            { 812000.0d, 0.00022469d },
            { 822000.0d, 0.000226949d },
            { 832000.0d, 0.000229181d },
            { 842000.0d, 0.000231385d },
            { 852000.0d, 0.000233561d },
            { 862000.0d, 0.000235707d },
            { 872000.0d, 0.000237826d },
            { 882000.0d, 0.000239915d },
            { 892000.0d, 0.000241975d },
            { 902000.0d, 0.000244006d },
            { 912000.0d, 0.000246009d },
            { 922000.0d, 0.000247982d },
            { 932000.0d, 0.000249927d },
            { 942000.0d, 0.000251842d },
            { 952000.0d, 0.000253726d },
            { 962000.0d, 0.000255582d },
            { 972000.0d, 0.000257408d },
            { 982000.0d, 0.000259204d },
            { 992000.0d, 0.00026097d },
            { 1002000.0d, 0.000262706d },
            { 1016000.0d, 0.000265087d },
            { 1030000.0d, 0.000267408d },
            { 1044000.0d, 0.000269671d },
            { 1058000.0d, 0.000271875d },
            { 1072000.0d, 0.00027402d },
            { 1086000.0d, 0.000276105d },
            { 1100000.0d, 0.000278132d },
            { 1114000.0d, 0.000280098d },
            { 1128000.0d, 0.000282006d },
            { 1142000.0d, 0.000283853d },
            { 1156000.0d, 0.000285641d },
            { 1170000.0d, 0.00028737d },
            { 1184000.0d, 0.000289041d },
            { 1198000.0d, 0.000290651d },
            { 1212000.0d, 0.000292203d },
            { 1226000.0d, 0.000293695d },
            { 1240000.0d, 0.000295128d },
            { 1254000.0d, 0.000296503d },
            { 1268000.0d, 0.000297819d },
            { 1282000.0d, 0.000299075d },
            { 1296000.0d, 0.000300273d },
            { 1310000.0d, 0.000301414d },
            { 1324000.0d, 0.000302497d },
            { 1338000.0d, 0.000303521d },
            { 1352000.0d, 0.000304488d },
            { 1366000.0d, 0.000305398d },
            { 1380000.0d, 0.000306251d },
            { 1394000.0d, 0.000307046d },
            { 1408000.0d, 0.000307786d },
            { 1422000.0d, 0.000308468d },
            { 1436000.0d, 0.000309096d },
            { 1450000.0d, 0.000309666d },
            { 1464000.0d, 0.000310181d },
            { 1478000.0d, 0.000310642d },
            { 1492000.0d, 0.000311048d },
            { 1506000.0d, 0.000311401d },
            { 1520000.0d, 0.000311699d },
            { 1534000.0d, 0.000311943d },
            { 1548000.0d, 0.000312136d },
            { 1562000.0d, 0.000312276d },
            { 1576000.0d, 0.000312363d },
            { 1590000.0d, 0.000312399d },
            { 1604000.0d, 0.000312384d },
            { 1618000.0d, 0.000312318d },
            { 1632000.0d, 0.000312202d },
            { 1646000.0d, 0.000312037d },
            { 1660000.0d, 0.000311823d },
            { 1674000.0d, 0.000311559d },
            { 1688000.0d, 0.000311249d },
            { 1702000.0d, 0.00031089d },
            { 1716000.0d, 0.000310484d },
            { 1730000.0d, 0.000310032d },
            { 1744000.0d, 0.000309533d },
            { 1758000.0d, 0.00030899d },
            { 1772000.0d, 0.000308401d },
            { 1786000.0d, 0.000307769d },
            { 1800000.0d, 0.000307093d },
            { 1814000.0d, 0.000306375d },
            { 1828000.0d, 0.000305616d },
            { 1842000.0d, 0.000304815d },
            { 1856000.0d, 0.000303973d },
            { 1870000.0d, 0.000303092d },
            { 1884000.0d, 0.000302172d },
            { 1898000.0d, 0.000301214d },
            { 1912000.0d, 0.000300219d },
            { 1926000.0d, 0.000299186d },
            { 1940000.0d, 0.000298119d },
            { 1954000.0d, 0.000297016d },
            { 1968000.0d, 0.000295879d },
            { 1982000.0d, 0.00029471d },
            { 1996000.0d, 0.000293507d },
            { 2010000.0d, 0.000292274d },
            { 2024000.0d, 0.000291008d },
            { 2038000.0d, 0.000289713d },
            { 2052000.0d, 0.000288387d },
            { 2066000.0d, 0.000287033d },
            { 2080000.0d, 0.00028565d },
            { 2094000.0d, 0.000284239d },
            { 2108000.0d, 0.000282801d },
            { 2122000.0d, 0.000281338d },
            { 2136000.0d, 0.000279849d },
            { 2150000.0d, 0.000278337d },
            { 2164000.0d, 0.000276801d },
            { 2178000.0d, 0.000275239d },
            { 2192000.0d, 0.000273655d },
            { 2206000.0d, 0.000272046d },
            { 2220000.0d, 0.000270413d },
            { 2234000.0d, 0.000268759d },
            { 2248000.0d, 0.000267083d },
            { 2262000.0d, 0.000265385d },
            { 2276000.0d, 0.000263668d },
            { 2290000.0d, 0.000261933d },
            { 2304000.0d, 0.000260181d },
            { 2318000.0d, 0.000258411d },
            { 2332000.0d, 0.000256626d },
            { 2346000.0d, 0.000254825d },
            { 2360000.0d, 0.000253001d },
            { 2374000.0d, 0.000251154d },
            { 2388000.0d, 0.000249284d },
            { 2402000.0d, 0.000247393d },
            { 2416000.0d, 0.00024548d },
            { 2430000.0d, 0.000243547d },
            { 2444000.0d, 0.000241594d },
            { 2458000.0d, 0.000239624d },
            { 2472000.0d, 0.000237635d },
            { 2486000.0d, 0.000235629d },
            { 2500000.0d, 0.000233607d },
            { 2514000.0d, 0.000231569d },
            { 2528000.0d, 0.000229517d },
            { 2542000.0d, 0.000227451d },
            { 2556000.0d, 0.000225371d },
            { 2570000.0d, 0.000223276d },
            { 2584000.0d, 0.000221167d },
            { 2598000.0d, 0.000219044d },
            { 2612000.0d, 0.00021691d },
            { 2626000.0d, 0.000214764d },
            { 2640000.0d, 0.000212607d },
            { 2654000.0d, 0.00021044d },
            { 2668000.0d, 0.000208265d },
            { 2682000.0d, 0.000206081d },
            { 2696000.0d, 0.000203889d },
            { 2710000.0d, 0.000201688d },
            { 2724000.0d, 0.000199477d },
            { 2738000.0d, 0.000197252d },
            { 2752000.0d, 0.000195012d },
            { 2766000.0d, 0.000192759d },
            { 2780000.0d, 0.000190494d },
            { 2794000.0d, 0.000188215d },
            { 2808000.0d, 0.000185927d },
            { 2822000.0d, 0.000183627d },
            { 2836000.0d, 0.000181317d },
            { 2850000.0d, 0.000178999d },
            { 2864000.0d, 0.000176673d },
            { 2878000.0d, 0.000174338d },
            { 2892000.0d, 0.000171996d },
            { 2906000.0d, 0.000169648d },
            { 2920000.0d, 0.000167292d },
            { 2934000.0d, 0.000164931d },
            { 2948000.0d, 0.000162565d },
            { 2962000.0d, 0.000160194d },
            { 2976000.0d, 0.00015782d },
            { 2990000.0d, 0.000155443d },
            { 3004000.0d, 0.000153063d },
            { 3018000.0d, 0.000150682d },
            { 3032000.0d, 0.0001483d },
            { 3046000.0d, 0.000145918d },
            { 3060000.0d, 0.000143537d },
            { 3074000.0d, 0.000141158d },
            { 3088000.0d, 0.000138781d },
            { 3102000.0d, 0.000136408d },
            { 3116000.0d, 0.000134039d },
            { 3130000.0d, 0.000131674d },
            { 3144000.0d, 0.000129315d },
            { 3158000.0d, 0.00012696d },
            { 3172000.0d, 0.000124603d },
            { 3186000.0d, 0.000122246d },
            { 3200000.0d, 0.000119888d },
            { 3214000.0d, 0.00011753d },
            { 3228000.0d, 0.000115174d },
            { 3242000.0d, 0.000112819d },
            { 3256000.0d, 0.000110468d },
            { 3270000.0d, 0.000108119d },
            { 3284000.0d, 0.000105775d },
            { 3298000.0d, 0.000103434d },
            { 3312000.0d, 0.0001011d },
            { 3326000.0d, 0.0000987716d },
            { 3340000.0d, 0.0000964505d },
            { 3354000.0d, 0.0000941368d },
            { 3368000.0d, 0.0000918315d },
            { 3382000.0d, 0.0000895354d },
            { 3396000.0d, 0.0000872492d },
            { 3410000.0d, 0.0000849737d },
            { 3424000.0d, 0.0000827097d },
            { 3438000.0d, 0.0000804579d },
            { 3452000.0d, 0.0000782191d },
            { 3466000.0d, 0.000075994d },
            { 3480000.0d, 0.0000737836d },
            { 3494000.0d, 0.0000715886d },
            { 3508000.0d, 0.0000694097d },
            { 3522000.0d, 0.0000672478d },
            { 3536000.0d, 0.0000651038d },
            { 3550000.0d, 0.0000629784d },
            { 3564000.0d, 0.0000608725d },
            { 3578000.0d, 0.0000587868d },
            { 3592000.0d, 0.0000567222d },
            { 3606000.0d, 0.0000546796d },
            { 3620000.0d, 0.0000526599d },
            { 3634000.0d, 0.0000506637d },
            { 3648000.0d, 0.0000486921d },
            { 3662000.0d, 0.0000467458d },
            { 3676000.0d, 0.0000448258d },
            { 3690000.0d, 0.0000429329d },
            { 3704000.0d, 0.0000410679d },
            { 3718000.0d, 0.0000392319d },
            { 3732000.0d, 0.0000374256d },
            { 3746000.0d, 0.0000356499d },
            { 3760000.0d, 0.0000339057d },
            { 3774000.0d, 0.000032194d },
            { 3788000.0d, 0.0000305156d },
            { 3802000.0d, 0.0000288715d },
            { 3816000.0d, 0.0000272625d },
            { 3830000.0d, 0.0000256897d },
            { 3844000.0d, 0.0000241538d },
            { 3858000.0d, 0.0000226558d },
            { 3872000.0d, 0.0000211967d },
            { 3886000.0d, 0.0000197775d },
            { 3900000.0d, 0.000018399d },
            { 3914000.0d, 0.0000170621d },
            { 3928000.0d, 0.000015768d },
            { 3942000.0d, 0.0000145174d },
            { 3956000.0d, 0.0000133114d },
            { 3970000.0d, 0.000012151d },
            { 3984000.0d, 0.0000110369d },
            { 3998000.0d, 0.00000997036d },
            { 4012000.0d, 0.00000895222d },
            { 4026000.0d, 0.0000079835d },
            { 4040000.0d, 0.00000706516d },
            { 4054000.0d, 0.00000619819d },
            { 4068000.0d, 0.00000538356d },
            { 4082000.0d, 0.00000462225d },
            { 4096000.0d, 0.00000391526d },
            { 4110000.0d, 0.00000326357d },
            { 4124000.0d, 0.00000266816d },
            { 4138000.0d, 0.00000213002d },
            { 4152000.0d, 0.00000165013d },
            { 4166000.0d, 0.00000122945d },
            { 4180000.0d, 0.000000868968d },
            { 4194000.0d, 0.00000056963d },
            { 4208000.0d, 0.000000332358d },
            { 4222000.0d, 0.000000158053d },
            { 4236000.0d, 0.0000000475431d },
            { 4250000.0d, 0.00000000145913d },
            { 4253000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    