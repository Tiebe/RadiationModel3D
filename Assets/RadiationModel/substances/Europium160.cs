using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium160";
        public override double halfLife { get; } = 42.6d;
        public override double atomicWeight { get; } = 159.93184d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium160()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.121d, new GammaParticle(75400.0, 0.01644)), new(0.0084d, new GammaParticle(98800.0, 0.01255)), new(0.032400000000000005d, new GammaParticle(102700.0, 0.01207)), new(0.0023d, new GammaParticle(123000.0, 0.01008)), new(0.523d, new GammaParticle(173300.0, 0.00715)), new(0.0089d, new GammaParticle(187500.0, 0.00661)), new(0.00319d, new GammaParticle(215000.0, 0.00577)), new(0.0213d, new GammaParticle(225100.0, 0.00551)), new(0.011000000000000001d, new GammaParticle(264500.0, 0.00469)), new(0.09d, new GammaParticle(266400.0, 0.00465)), new(0.00131d, new GammaParticle(286000.0, 0.00434)), new(0.0027700000000000003d, new GammaParticle(286900.0, 0.00432)), new(0.00256d, new GammaParticle(300600.0, 0.00412)), new(0.0335d, new GammaParticle(310000.0, 0.004)), new(0.094d, new GammaParticle(408900.0, 0.00303)), new(0.442d, new GammaParticle(412700.0, 0.003)), new(0.079d, new GammaParticle(417100.0, 0.00297)), new(0.0105d, new GammaParticle(450700.0, 0.00275)), new(0.026699999999999998d, new GammaParticle(491100.0, 0.00252)), new(0.46d, new GammaParticle(515700.0, 0.0024)), new(0.00507d, new GammaParticle(555600.0, 0.00223)), new(0.0387d, new GammaParticle(560800.0, 0.00221)), new(0.0115d, new GammaParticle(605700.0, 0.00205)), new(0.00131d, new GammaParticle(646000.0, 0.00192)), new(0.014499999999999999d, new GammaParticle(658200.0, 0.00188)), new(0.075d, new GammaParticle(737600.0, 0.00168)), new(0.0161d, new GammaParticle(746100.0, 0.00166)), new(0.0216d, new GammaParticle(762700.0, 0.00163)), new(0.022000000000000002d, new GammaParticle(769600.0, 0.00161)), new(0.009899999999999999d, new GammaParticle(780700.0, 0.00159)), new(0.34600000000000003d, new GammaParticle(822000.0, 0.00151)), new(0.0102d, new GammaParticle(825600.0, 0.0015)), new(0.00575d, new GammaParticle(878300.0, 0.00141)), new(0.10800000000000001d, new GammaParticle(924600.0, 0.00134)), new(0.009399999999999999d, new GammaParticle(928000.0, 0.00134)), new(0.0204d, new GammaParticle(968400.0, 0.00128)), new(0.28300000000000003d, new GammaParticle(995300.0, 0.00125)), new(0.018600000000000002d, new GammaParticle(1006500.0, 0.00123)), new(0.071d, new GammaParticle(1012600.0, 0.00122)), new(0.0139d, new GammaParticle(1033400.0, 0.0012)), new(0.0131d, new GammaParticle(1046900.0, 0.00118)), new(0.00444d, new GammaParticle(1052100.0, 0.00118)), new(0.022000000000000002d, new GammaParticle(1076400.0, 0.00115)), new(0.00366d, new GammaParticle(1122400.0, 0.0011)), new(0.0078000000000000005d, new GammaParticle(1144700.0, 0.00108)), new(0.0078000000000000005d, new GammaParticle(1183500.0, 0.00105)), new(0.00131d, new GammaParticle(1194100.0, 0.00104)), new(0.0591d, new GammaParticle(1234600.0, 0.001)), new(0.00617d, new GammaParticle(1264100.0, 0.00098)), new(0.0167d, new GammaParticle(1316400.0, 0.00094)), new(0.016200000000000003d, new GammaParticle(1386500.0, 0.00089)), new(0.00575d, new GammaParticle(1408100.0, 0.00088)), new(0.00293d, new GammaParticle(1483600.0, 0.00084)), new(0.00575d, new GammaParticle(1750200.0, 0.00071)), new(0.16899999999999998d, new GammaParticle(6858.0, 0.18079)), new(0.133d, new GammaParticle(42308.0, 0.02931)), new(0.24d, new GammaParticle(42996.0, 0.02884)), new(0.076d, new GammaParticle(48802.0, 0.02541)), new(0.096d, new GammaParticle(49326.0, 0.02514)), new(0.0199d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000287704d },
            { 6000.0d, 0.000292649d },
            { 12000.0d, 0.000297349d },
            { 18000.0d, 0.000301806d },
            { 24000.0d, 0.00030609d },
            { 30000.0d, 0.00031032d },
            { 36000.0d, 0.000314509d },
            { 42000.0d, 0.000318672d },
            { 48000.0d, 0.00032282d },
            { 54000.0d, 0.000326961d },
            { 60000.0d, 0.000331097d },
            { 66000.0d, 0.000335231d },
            { 72000.0d, 0.000339366d },
            { 78000.0d, 0.0003435d },
            { 84000.0d, 0.000347635d },
            { 90000.0d, 0.000351769d },
            { 96000.0d, 0.000355902d },
            { 102000.0d, 0.000360033d },
            { 112000.0d, 0.000366911d },
            { 122000.0d, 0.000373773d },
            { 132000.0d, 0.000380617d },
            { 142000.0d, 0.000387434d },
            { 152000.0d, 0.000394223d },
            { 162000.0d, 0.000400976d },
            { 172000.0d, 0.000407689d },
            { 182000.0d, 0.000414359d },
            { 192000.0d, 0.00042098d },
            { 202000.0d, 0.00042755d },
            { 212000.0d, 0.000434064d },
            { 222000.0d, 0.000440519d },
            { 232000.0d, 0.000446912d },
            { 242000.0d, 0.000453239d },
            { 252000.0d, 0.000459498d },
            { 262000.0d, 0.000465685d },
            { 272000.0d, 0.000471799d },
            { 282000.0d, 0.000477837d },
            { 292000.0d, 0.000483795d },
            { 302000.0d, 0.000489673d },
            { 312000.0d, 0.000495467d },
            { 322000.0d, 0.000501177d },
            { 332000.0d, 0.000506799d },
            { 342000.0d, 0.000512333d },
            { 352000.0d, 0.000517774d },
            { 362000.0d, 0.000523123d },
            { 372000.0d, 0.000528377d },
            { 382000.0d, 0.000533535d },
            { 392000.0d, 0.000538595d },
            { 402000.0d, 0.000543556d },
            { 412000.0d, 0.000548417d },
            { 422000.0d, 0.000553175d },
            { 432000.0d, 0.00055783d },
            { 442000.0d, 0.000562381d },
            { 452000.0d, 0.000566825d },
            { 462000.0d, 0.000571163d },
            { 472000.0d, 0.000575392d },
            { 482000.0d, 0.000579513d },
            { 492000.0d, 0.000583523d },
            { 502000.0d, 0.000587422d },
            { 512000.0d, 0.00059121d },
            { 522000.0d, 0.000594885d },
            { 532000.0d, 0.000598445d },
            { 542000.0d, 0.000601892d },
            { 552000.0d, 0.000605223d },
            { 562000.0d, 0.000608439d },
            { 572000.0d, 0.000611538d },
            { 582000.0d, 0.000614521d },
            { 592000.0d, 0.000617386d },
            { 602000.0d, 0.000620133d },
            { 612000.0d, 0.000622762d },
            { 622000.0d, 0.000625271d },
            { 632000.0d, 0.000627662d },
            { 642000.0d, 0.000629934d },
            { 652000.0d, 0.000632085d },
            { 662000.0d, 0.000634116d },
            { 672000.0d, 0.000636027d },
            { 682000.0d, 0.000637817d },
            { 692000.0d, 0.000639487d },
            { 702000.0d, 0.000641036d },
            { 712000.0d, 0.000642464d },
            { 722000.0d, 0.000643771d },
            { 732000.0d, 0.000644957d },
            { 742000.0d, 0.000646023d },
            { 752000.0d, 0.000646968d },
            { 762000.0d, 0.000647792d },
            { 772000.0d, 0.000648496d },
            { 782000.0d, 0.000649079d },
            { 792000.0d, 0.000649543d },
            { 802000.0d, 0.000649886d },
            { 812000.0d, 0.000650109d },
            { 822000.0d, 0.000650214d },
            { 832000.0d, 0.0006502d },
            { 842000.0d, 0.000650067d },
            { 852000.0d, 0.000649816d },
            { 862000.0d, 0.000649448d },
            { 872000.0d, 0.000648962d },
            { 882000.0d, 0.000648359d },
            { 892000.0d, 0.000647641d },
            { 902000.0d, 0.000646806d },
            { 912000.0d, 0.000645858d },
            { 922000.0d, 0.000644794d },
            { 932000.0d, 0.000643617d },
            { 942000.0d, 0.000642326d },
            { 952000.0d, 0.000640924d },
            { 962000.0d, 0.000639411d },
            { 972000.0d, 0.000637786d },
            { 982000.0d, 0.000636052d },
            { 992000.0d, 0.000634208d },
            { 1002000.0d, 0.000632257d },
            { 1013000.0d, 0.000629987d },
            { 1024000.0d, 0.000627588d },
            { 1035000.0d, 0.000625062d },
            { 1046000.0d, 0.000622411d },
            { 1057000.0d, 0.000619635d },
            { 1068000.0d, 0.000616735d },
            { 1079000.0d, 0.000613714d },
            { 1090000.0d, 0.000610574d },
            { 1101000.0d, 0.000607314d },
            { 1112000.0d, 0.000603938d },
            { 1123000.0d, 0.000600447d },
            { 1134000.0d, 0.000596841d },
            { 1145000.0d, 0.000593124d },
            { 1156000.0d, 0.000589296d },
            { 1167000.0d, 0.00058536d },
            { 1178000.0d, 0.000581319d },
            { 1189000.0d, 0.000577172d },
            { 1200000.0d, 0.000572922d },
            { 1211000.0d, 0.000568572d },
            { 1222000.0d, 0.000564123d },
            { 1233000.0d, 0.000559577d },
            { 1244000.0d, 0.000554936d },
            { 1255000.0d, 0.000550202d },
            { 1266000.0d, 0.000545379d },
            { 1277000.0d, 0.000540466d },
            { 1288000.0d, 0.000535468d },
            { 1299000.0d, 0.000530386d },
            { 1310000.0d, 0.000525221d },
            { 1321000.0d, 0.000519978d },
            { 1332000.0d, 0.000514658d },
            { 1343000.0d, 0.000509264d },
            { 1354000.0d, 0.000503797d },
            { 1365000.0d, 0.000498261d },
            { 1376000.0d, 0.000492659d },
            { 1387000.0d, 0.000486991d },
            { 1398000.0d, 0.000481261d },
            { 1409000.0d, 0.000475472d },
            { 1420000.0d, 0.000469627d },
            { 1431000.0d, 0.000463727d },
            { 1442000.0d, 0.000457776d },
            { 1453000.0d, 0.000451776d },
            { 1464000.0d, 0.000445731d },
            { 1475000.0d, 0.000439642d },
            { 1486000.0d, 0.000433515d },
            { 1497000.0d, 0.000427349d },
            { 1508000.0d, 0.000421149d },
            { 1519000.0d, 0.000414919d },
            { 1530000.0d, 0.000408659d },
            { 1541000.0d, 0.000402374d },
            { 1552000.0d, 0.000396068d },
            { 1563000.0d, 0.000389742d },
            { 1574000.0d, 0.0003834d },
            { 1585000.0d, 0.000377045d },
            { 1596000.0d, 0.000370681d },
            { 1607000.0d, 0.000364309d },
            { 1618000.0d, 0.000357936d },
            { 1629000.0d, 0.000351561d },
            { 1640000.0d, 0.00034519d },
            { 1651000.0d, 0.000338826d },
            { 1662000.0d, 0.000332472d },
            { 1673000.0d, 0.000326132d },
            { 1684000.0d, 0.000319809d },
            { 1695000.0d, 0.000313506d },
            { 1706000.0d, 0.000307227d },
            { 1717000.0d, 0.000300975d },
            { 1728000.0d, 0.000294754d },
            { 1739000.0d, 0.000288569d },
            { 1750000.0d, 0.00028242d },
            { 1761000.0d, 0.000276314d },
            { 1772000.0d, 0.000270253d },
            { 1783000.0d, 0.000264242d },
            { 1794000.0d, 0.000258283d },
            { 1805000.0d, 0.000252382d },
            { 1816000.0d, 0.00024654d },
            { 1827000.0d, 0.000240763d },
            { 1838000.0d, 0.000235054d },
            { 1849000.0d, 0.000229417d },
            { 1860000.0d, 0.000223855d },
            { 1871000.0d, 0.000218373d },
            { 1882000.0d, 0.000212975d },
            { 1893000.0d, 0.00020766d },
            { 1904000.0d, 0.000202404d },
            { 1915000.0d, 0.000197201d },
            { 1926000.0d, 0.000192056d },
            { 1937000.0d, 0.000186971d },
            { 1948000.0d, 0.000181949d },
            { 1959000.0d, 0.000176994d },
            { 1970000.0d, 0.000172092d },
            { 1981000.0d, 0.000167234d },
            { 1992000.0d, 0.000162423d },
            { 2003000.0d, 0.00015766d },
            { 2014000.0d, 0.000152949d },
            { 2025000.0d, 0.000148292d },
            { 2036000.0d, 0.000143692d },
            { 2047000.0d, 0.000139152d },
            { 2058000.0d, 0.000134673d },
            { 2069000.0d, 0.00013026d },
            { 2080000.0d, 0.000125914d },
            { 2091000.0d, 0.000121639d },
            { 2102000.0d, 0.000117437d },
            { 2113000.0d, 0.000113308d },
            { 2124000.0d, 0.00010925d },
            { 2135000.0d, 0.000105266d },
            { 2146000.0d, 0.000101358d },
            { 2157000.0d, 0.000097529d },
            { 2168000.0d, 0.0000937818d },
            { 2179000.0d, 0.0000901191d },
            { 2190000.0d, 0.0000865437d },
            { 2201000.0d, 0.0000830572d },
            { 2212000.0d, 0.0000796573d },
            { 2223000.0d, 0.0000763458d },
            { 2234000.0d, 0.0000731255d },
            { 2245000.0d, 0.0000699989d },
            { 2256000.0d, 0.0000669686d },
            { 2267000.0d, 0.0000640375d },
            { 2278000.0d, 0.0000612083d },
            { 2289000.0d, 0.0000584836d },
            { 2300000.0d, 0.0000558662d },
            { 2311000.0d, 0.0000533588d },
            { 2322000.0d, 0.0000509641d },
            { 2333000.0d, 0.000048685d },
            { 2344000.0d, 0.000046524d },
            { 2355000.0d, 0.0000444843d },
            { 2366000.0d, 0.0000425682d },
            { 2377000.0d, 0.0000407788d },
            { 2388000.0d, 0.0000391187d },
            { 2399000.0d, 0.0000375907d },
            { 2410000.0d, 0.0000361975d },
            { 2421000.0d, 0.0000349418d },
            { 2432000.0d, 0.0000338262d },
            { 2443000.0d, 0.0000328531d },
            { 2454000.0d, 0.0000320131d },
            { 2465000.0d, 0.0000312032d },
            { 2476000.0d, 0.0000303986d },
            { 2487000.0d, 0.0000295996d },
            { 2498000.0d, 0.0000288065d },
            { 2509000.0d, 0.0000280196d },
            { 2520000.0d, 0.0000272392d },
            { 2531000.0d, 0.0000264655d },
            { 2542000.0d, 0.000025699d },
            { 2553000.0d, 0.0000249399d },
            { 2564000.0d, 0.0000241885d },
            { 2575000.0d, 0.0000234452d },
            { 2586000.0d, 0.0000227103d },
            { 2597000.0d, 0.000021984d },
            { 2608000.0d, 0.0000212667d },
            { 2619000.0d, 0.0000205588d },
            { 2630000.0d, 0.0000198605d },
            { 2641000.0d, 0.0000191722d },
            { 2652000.0d, 0.0000184942d },
            { 2663000.0d, 0.0000178269d },
            { 2674000.0d, 0.0000171705d },
            { 2685000.0d, 0.0000165255d },
            { 2696000.0d, 0.0000158922d },
            { 2707000.0d, 0.0000152709d },
            { 2718000.0d, 0.0000146619d },
            { 2729000.0d, 0.0000140656d },
            { 2740000.0d, 0.0000134824d },
            { 2751000.0d, 0.0000129126d },
            { 2762000.0d, 0.0000123561d },
            { 2773000.0d, 0.0000118127d },
            { 2784000.0d, 0.0000112829d },
            { 2795000.0d, 0.0000107669d },
            { 2806000.0d, 0.0000102652d },
            { 2817000.0d, 0.00000977812d },
            { 2828000.0d, 0.00000930597d },
            { 2839000.0d, 0.00000884912d },
            { 2850000.0d, 0.00000840791d },
            { 2861000.0d, 0.00000798272d },
            { 2872000.0d, 0.00000757344d },
            { 2883000.0d, 0.00000717791d },
            { 2894000.0d, 0.00000679602d },
            { 2905000.0d, 0.00000642796d },
            { 2916000.0d, 0.0000060731d },
            { 2927000.0d, 0.00000573148d },
            { 2938000.0d, 0.00000540338d },
            { 2949000.0d, 0.00000508908d },
            { 2960000.0d, 0.00000478881d },
            { 2971000.0d, 0.00000450205d },
            { 2982000.0d, 0.00000422487d },
            { 2993000.0d, 0.00000395686d },
            { 3004000.0d, 0.00000369822d },
            { 3015000.0d, 0.00000344907d },
            { 3026000.0d, 0.00000320896d },
            { 3037000.0d, 0.00000297789d },
            { 3048000.0d, 0.00000275603d },
            { 3059000.0d, 0.00000254354d },
            { 3070000.0d, 0.0000023404d },
            { 3081000.0d, 0.00000214671d },
            { 3092000.0d, 0.00000196264d },
            { 3103000.0d, 0.00000178838d },
            { 3114000.0d, 0.00000162406d },
            { 3125000.0d, 0.00000146988d },
            { 3136000.0d, 0.00000132596d },
            { 3147000.0d, 0.00000119249d },
            { 3158000.0d, 0.00000106923d },
            { 3169000.0d, 0.00000095378d },
            { 3180000.0d, 0.000000845763d },
            { 3191000.0d, 0.000000745241d },
            { 3202000.0d, 0.000000651583d },
            { 3213000.0d, 0.00000056467d },
            { 3224000.0d, 0.00000048461d },
            { 3235000.0d, 0.000000411504d },
            { 3246000.0d, 0.000000345458d },
            { 3257000.0d, 0.000000286571d },
            { 3268000.0d, 0.000000234942d },
            { 3279000.0d, 0.000000190477d },
            { 3290000.0d, 0.000000151042d },
            { 3301000.0d, 0.000000116031d },
            { 3312000.0d, 0.0000000855089d },
            { 3323000.0d, 0.0000000595379d },
            { 3334000.0d, 0.0000000381793d },
            { 3345000.0d, 0.0000000214929d },
            { 3356000.0d, 0.00000000953567d },
            { 3367000.0d, 0.0000000023594d },
            { 3377900.0d, 0d },

        }; 
    }
}
    