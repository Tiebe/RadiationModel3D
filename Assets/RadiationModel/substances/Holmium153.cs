using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium153";
        public override double halfLife { get; } = 120.6d;
        public override double atomicWeight { get; } = 152.93021d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99949d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium153()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0483d, new GammaParticle(66200.0, 0.01873)), new(0.0087d, new GammaParticle(75300.0, 0.01647)), new(0.0161d, new GammaParticle(84800.0, 0.01462)), new(0.0007000000000000001d, new GammaParticle(95200.0, 0.01302)), new(0.02d, new GammaParticle(108700.0, 0.01141)), new(0.0027d, new GammaParticle(117300.0, 0.01057)), new(0.0013d, new GammaParticle(125100.0, 0.00991)), new(0.0067d, new GammaParticle(141800.0, 0.00874)), new(0.006999999999999999d, new GammaParticle(161500.0, 0.00768)), new(0.0028799999999999997d, new GammaParticle(186900.0, 0.00663)), new(0.004d, new GammaParticle(192800.0, 0.00643)), new(0.0013d, new GammaParticle(203800.0, 0.00608)), new(0.006999999999999999d, new GammaParticle(230000.0, 0.00539)), new(0.0034000000000000002d, new GammaParticle(253800.0, 0.00489)), new(0.0034000000000000002d, new GammaParticle(253800.0, 0.00489)), new(0.006999999999999999d, new GammaParticle(270600.0, 0.00458)), new(0.67d, new GammaParticle(295800.0, 0.00419)), new(0.00248d, new GammaParticle(341000.0, 0.00364)), new(0.02d, new GammaParticle(365900.0, 0.00339)), new(0.0034000000000000002d, new GammaParticle(392500.0, 0.00316)), new(0.0027d, new GammaParticle(404100.0, 0.00307)), new(0.0027d, new GammaParticle(404100.0, 0.00307)), new(0.004699999999999999d, new GammaParticle(420400.0, 0.00295)), new(0.0007000000000000001d, new GammaParticle(431000.0, 0.00288)), new(0.0013d, new GammaParticle(445700.0, 0.00278)), new(0.002d, new GammaParticle(449700.0, 0.00276)), new(0.006999999999999999d, new GammaParticle(456800.0, 0.00271)), new(0.009399999999999999d, new GammaParticle(468200.0, 0.00265)), new(0.002d, new GammaParticle(529600.0, 0.00234)), new(0.009399999999999999d, new GammaParticle(541400.0, 0.00229)), new(0.0027d, new GammaParticle(552000.0, 0.00225)), new(0.004d, new GammaParticle(565500.0, 0.00219)), new(0.010700000000000001d, new GammaParticle(577000.0, 0.00215)), new(0.008d, new GammaParticle(579700.0, 0.00214)), new(0.0034000000000000002d, new GammaParticle(617500.0, 0.00201)), new(0.054000000000000006d, new GammaParticle(637000.0, 0.00195)), new(0.002d, new GammaParticle(685200.0, 0.00181)), new(0.037000000000000005d, new GammaParticle(688500.0, 0.0018)), new(0.002d, new GammaParticle(693000.0, 0.00179)), new(0.002d, new GammaParticle(712000.0, 0.00174)), new(0.0013d, new GammaParticle(721000.0, 0.00172)), new(0.0121d, new GammaParticle(726800.0, 0.00171)), new(0.0034000000000000002d, new GammaParticle(742800.0, 0.00167)), new(0.0027d, new GammaParticle(745200.0, 0.00166)), new(0.0027d, new GammaParticle(745200.0, 0.00166)), new(0.004d, new GammaParticle(772200.0, 0.00161)), new(0.0034000000000000002d, new GammaParticle(775400.0, 0.0016)), new(0.0067d, new GammaParticle(784800.0, 0.00158)), new(0.008d, new GammaParticle(806000.0, 0.00154)), new(0.002d, new GammaParticle(812100.0, 0.00153)), new(0.004d, new GammaParticle(815500.0, 0.00152)), new(0.0054d, new GammaParticle(836100.0, 0.00148)), new(0.004d, new GammaParticle(843800.0, 0.00147)), new(0.0074d, new GammaParticle(847500.0, 0.00146)), new(0.0074d, new GammaParticle(862900.0, 0.00144)), new(0.004d, new GammaParticle(864000.0, 0.00144)), new(0.0027d, new GammaParticle(868600.0, 0.00143)), new(0.0034000000000000002d, new GammaParticle(885100.0, 0.0014)), new(0.002d, new GammaParticle(893900.0, 0.00139)), new(0.002d, new GammaParticle(893900.0, 0.00139)), new(0.009399999999999999d, new GammaParticle(910400.0, 0.00136)), new(0.0121d, new GammaParticle(924000.0, 0.00134)), new(0.0027d, new GammaParticle(1004100.0, 0.00123)), new(0.009399999999999999d, new GammaParticle(1015400.0, 0.00122)), new(0.0255d, new GammaParticle(1085800.0, 0.00114)), new(0.0054d, new GammaParticle(1091800.0, 0.00114)), new(0.0087d, new GammaParticle(1151200.0, 0.00108)), new(0.010700000000000001d, new GammaParticle(1167600.0, 0.00106)), new(0.0054d, new GammaParticle(1183100.0, 0.00105)), new(0.0027d, new GammaParticle(1189900.0, 0.00104)), new(0.0034000000000000002d, new GammaParticle(1202400.0, 0.00103)), new(0.006d, new GammaParticle(1208400.0, 0.00103)), new(0.034d, new GammaParticle(1276500.0, 0.00097)), new(0.0007000000000000001d, new GammaParticle(1284800.0, 0.00097)), new(0.0027d, new GammaParticle(1300800.0, 0.00095)), new(0.0067d, new GammaParticle(1347800.0, 0.00092)), new(0.0127d, new GammaParticle(1381000.0, 0.0009)), new(0.0013d, new GammaParticle(1389000.0, 0.00089)), new(0.8248000000000001d, new GammaParticle(511000.0, 0.00243)), new(0.115267371229584d, new GammaParticle(7384.0, 0.16791)), new(0.15457757874706515d, new GammaParticle(45207.0, 0.02743)), new(0.27622869683178186d, new GammaParticle(45998.0, 0.02695)), new(0.08869138721043882d, new GammaParticle(52220.0, 0.02374)), new(0.1117511478851529d, new GammaParticle(52791.0, 0.02349)), new(0.023059760674714092d, new GammaParticle(53478.0, 0.02318)) } },
            { 0.0005099999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium149()), new(1.0d, new AlphaParticle(5074002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 5000.0d, 0.00000000110261d },
            { 10000.0d, 0.0000000458528d },
            { 15000.0d, 0.000000143138d },
            { 20000.0d, 0.000000310066d },
            { 25000.0d, 0.000000575412d },
            { 30000.0d, 0.000000940701d },
            { 35000.0d, 0.00000141371d },
            { 40000.0d, 0.00000199272d },
            { 45000.0d, 0.00000267722d },
            { 50000.0d, 0.00000346021d },
            { 55000.0d, 0.00000434057d },
            { 60000.0d, 0.00000530863d },
            { 65000.0d, 0.00000636235d },
            { 70000.0d, 0.00000749307d },
            { 75000.0d, 0.00000869663d },
            { 80000.0d, 0.0000099675d },
            { 85000.0d, 0.0000112989d },
            { 90000.0d, 0.0000126888d },
            { 95000.0d, 0.000014128d },
            { 100000.0d, 0.000015617d },
            { 109000.0d, 0.0000184029d },
            { 118000.0d, 0.0000213087d },
            { 127000.0d, 0.0000243156d },
            { 136000.0d, 0.0000274075d },
            { 145000.0d, 0.0000305702d },
            { 154000.0d, 0.0000337914d },
            { 163000.0d, 0.0000370604d },
            { 172000.0d, 0.0000403677d },
            { 181000.0d, 0.0000437055d },
            { 190000.0d, 0.0000470662d },
            { 199000.0d, 0.0000504437d },
            { 208000.0d, 0.0000538325d },
            { 217000.0d, 0.0000572276d },
            { 226000.0d, 0.0000606246d },
            { 235000.0d, 0.0000640197d },
            { 244000.0d, 0.0000674095d },
            { 253000.0d, 0.0000707908d },
            { 262000.0d, 0.000074161d },
            { 271000.0d, 0.0000775176d },
            { 280000.0d, 0.0000808583d },
            { 289000.0d, 0.0000841811d },
            { 298000.0d, 0.0000874842d },
            { 307000.0d, 0.000090766d },
            { 316000.0d, 0.0000940249d },
            { 325000.0d, 0.0000972596d },
            { 334000.0d, 0.000100469d },
            { 343000.0d, 0.000103652d },
            { 352000.0d, 0.000106807d },
            { 361000.0d, 0.000109933d },
            { 370000.0d, 0.00011303d },
            { 379000.0d, 0.000116097d },
            { 388000.0d, 0.000119132d },
            { 397000.0d, 0.000122136d },
            { 406000.0d, 0.000125108d },
            { 415000.0d, 0.000128047d },
            { 424000.0d, 0.000130951d },
            { 433000.0d, 0.000133822d },
            { 442000.0d, 0.000136658d },
            { 451000.0d, 0.00013946d },
            { 460000.0d, 0.000142225d },
            { 469000.0d, 0.000144956d },
            { 478000.0d, 0.00014765d },
            { 487000.0d, 0.000150308d },
            { 496000.0d, 0.000152928d },
            { 505000.0d, 0.000155512d },
            { 514000.0d, 0.000158057d },
            { 523000.0d, 0.000160565d },
            { 532000.0d, 0.000163036d },
            { 541000.0d, 0.000165467d },
            { 550000.0d, 0.000167861d },
            { 559000.0d, 0.000170216d },
            { 568000.0d, 0.000172533d },
            { 577000.0d, 0.00017481d },
            { 586000.0d, 0.000177048d },
            { 595000.0d, 0.000179246d },
            { 604000.0d, 0.000181406d },
            { 613000.0d, 0.000183526d },
            { 622000.0d, 0.000185606d },
            { 631000.0d, 0.000187646d },
            { 640000.0d, 0.000189646d },
            { 649000.0d, 0.000191607d },
            { 658000.0d, 0.000193527d },
            { 667000.0d, 0.000195407d },
            { 676000.0d, 0.000197247d },
            { 685000.0d, 0.000199047d },
            { 694000.0d, 0.000200806d },
            { 703000.0d, 0.000202524d },
            { 712000.0d, 0.000204202d },
            { 721000.0d, 0.00020584d },
            { 730000.0d, 0.000207437d },
            { 739000.0d, 0.000208995d },
            { 748000.0d, 0.000210511d },
            { 757000.0d, 0.000211987d },
            { 766000.0d, 0.000213422d },
            { 775000.0d, 0.000214817d },
            { 784000.0d, 0.000216171d },
            { 793000.0d, 0.000217485d },
            { 802000.0d, 0.000218759d },
            { 811000.0d, 0.000219992d },
            { 820000.0d, 0.000221185d },
            { 829000.0d, 0.000222337d },
            { 838000.0d, 0.00022345d },
            { 847000.0d, 0.000224522d },
            { 856000.0d, 0.000225554d },
            { 865000.0d, 0.000226547d },
            { 874000.0d, 0.000227499d },
            { 883000.0d, 0.000228411d },
            { 892000.0d, 0.000229284d },
            { 901000.0d, 0.000230118d },
            { 910000.0d, 0.000230911d },
            { 919000.0d, 0.000231665d },
            { 928000.0d, 0.00023238d },
            { 937000.0d, 0.000233056d },
            { 946000.0d, 0.000233694d },
            { 955000.0d, 0.000234291d },
            { 964000.0d, 0.000234851d },
            { 973000.0d, 0.000235372d },
            { 982000.0d, 0.000235854d },
            { 991000.0d, 0.000236298d },
            { 1000000.0d, 0.000236704d },
            { 1009000.0d, 0.000237073d },
            { 1018000.0d, 0.000237403d },
            { 1027000.0d, 0.000237696d },
            { 1036000.0d, 0.000237951d },
            { 1045000.0d, 0.000238169d },
            { 1054000.0d, 0.000238351d },
            { 1063000.0d, 0.000238495d },
            { 1072000.0d, 0.000238603d },
            { 1081000.0d, 0.000238674d },
            { 1090000.0d, 0.00023871d },
            { 1099000.0d, 0.00023871d },
            { 1108000.0d, 0.000238675d },
            { 1117000.0d, 0.000238603d },
            { 1126000.0d, 0.000238497d },
            { 1135000.0d, 0.000238354d },
            { 1144000.0d, 0.000238179d },
            { 1153000.0d, 0.000237968d },
            { 1162000.0d, 0.000237724d },
            { 1171000.0d, 0.000237446d },
            { 1180000.0d, 0.000237134d },
            { 1189000.0d, 0.000236788d },
            { 1198000.0d, 0.00023641d },
            { 1207000.0d, 0.000236d },
            { 1216000.0d, 0.000235557d },
            { 1225000.0d, 0.000235081d },
            { 1234000.0d, 0.000234574d },
            { 1243000.0d, 0.000234035d },
            { 1252000.0d, 0.000233466d },
            { 1261000.0d, 0.000232865d },
            { 1270000.0d, 0.000232234d },
            { 1279000.0d, 0.000231573d },
            { 1288000.0d, 0.000230883d },
            { 1297000.0d, 0.000230162d },
            { 1306000.0d, 0.000229413d },
            { 1315000.0d, 0.000228635d },
            { 1324000.0d, 0.000227829d },
            { 1333000.0d, 0.000226995d },
            { 1342000.0d, 0.000226133d },
            { 1351000.0d, 0.000225244d },
            { 1360000.0d, 0.000224328d },
            { 1369000.0d, 0.000223386d },
            { 1378000.0d, 0.000222419d },
            { 1387000.0d, 0.000221425d },
            { 1396000.0d, 0.000220407d },
            { 1405000.0d, 0.000219362d },
            { 1414000.0d, 0.000218296d },
            { 1423000.0d, 0.000217204d },
            { 1432000.0d, 0.000216088d },
            { 1441000.0d, 0.000214951d },
            { 1450000.0d, 0.00021379d },
            { 1459000.0d, 0.000212608d },
            { 1468000.0d, 0.000211405d },
            { 1477000.0d, 0.000210179d },
            { 1486000.0d, 0.000208934d },
            { 1495000.0d, 0.000207668d },
            { 1504000.0d, 0.000206382d },
            { 1513000.0d, 0.000205078d },
            { 1522000.0d, 0.000203755d },
            { 1531000.0d, 0.000202414d },
            { 1540000.0d, 0.000201053d },
            { 1549000.0d, 0.000199675d },
            { 1558000.0d, 0.000198277d },
            { 1567000.0d, 0.000196862d },
            { 1576000.0d, 0.00019543d },
            { 1585000.0d, 0.000193982d },
            { 1594000.0d, 0.000192516d },
            { 1603000.0d, 0.000191035d },
            { 1612000.0d, 0.000189539d },
            { 1621000.0d, 0.000188027d },
            { 1630000.0d, 0.000186499d },
            { 1639000.0d, 0.000184956d },
            { 1648000.0d, 0.000183398d },
            { 1657000.0d, 0.000181826d },
            { 1666000.0d, 0.00018024d },
            { 1675000.0d, 0.000178641d },
            { 1684000.0d, 0.00017703d },
            { 1693000.0d, 0.000175406d },
            { 1702000.0d, 0.000173772d },
            { 1711000.0d, 0.000172126d },
            { 1720000.0d, 0.00017047d },
            { 1729000.0d, 0.000168805d },
            { 1738000.0d, 0.00016713d },
            { 1747000.0d, 0.000165445d },
            { 1756000.0d, 0.000163751d },
            { 1765000.0d, 0.000162048d },
            { 1774000.0d, 0.000160336d },
            { 1783000.0d, 0.000158617d },
            { 1792000.0d, 0.000156891d },
            { 1801000.0d, 0.000155158d },
            { 1810000.0d, 0.000153417d },
            { 1819000.0d, 0.000151671d },
            { 1828000.0d, 0.000149919d },
            { 1837000.0d, 0.000148161d },
            { 1846000.0d, 0.000146394d },
            { 1855000.0d, 0.000144618d },
            { 1864000.0d, 0.000142834d },
            { 1873000.0d, 0.000141041d },
            { 1882000.0d, 0.000139241d },
            { 1891000.0d, 0.000137433d },
            { 1900000.0d, 0.000135619d },
            { 1909000.0d, 0.000133799d },
            { 1918000.0d, 0.000131972d },
            { 1927000.0d, 0.00013014d },
            { 1936000.0d, 0.000128303d },
            { 1945000.0d, 0.000126461d },
            { 1954000.0d, 0.000124616d },
            { 1963000.0d, 0.000122766d },
            { 1972000.0d, 0.000120913d },
            { 1981000.0d, 0.000119058d },
            { 1990000.0d, 0.0001172d },
            { 1999000.0d, 0.00011534d },
            { 2008000.0d, 0.000113479d },
            { 2017000.0d, 0.000111618d },
            { 2026000.0d, 0.000109756d },
            { 2035000.0d, 0.000107894d },
            { 2044000.0d, 0.000106032d },
            { 2053000.0d, 0.00010417d },
            { 2062000.0d, 0.00010231d },
            { 2071000.0d, 0.000100451d },
            { 2080000.0d, 0.0000985935d },
            { 2089000.0d, 0.0000967383d },
            { 2098000.0d, 0.0000948858d },
            { 2107000.0d, 0.0000930364d },
            { 2116000.0d, 0.0000911906d },
            { 2125000.0d, 0.0000893492d },
            { 2134000.0d, 0.0000875125d },
            { 2143000.0d, 0.0000856811d },
            { 2152000.0d, 0.0000838555d },
            { 2161000.0d, 0.0000820364d },
            { 2170000.0d, 0.0000802243d },
            { 2179000.0d, 0.0000784197d },
            { 2188000.0d, 0.0000766232d },
            { 2197000.0d, 0.0000748355d },
            { 2206000.0d, 0.0000730571d },
            { 2215000.0d, 0.0000712885d },
            { 2224000.0d, 0.0000695303d },
            { 2233000.0d, 0.0000677833d },
            { 2242000.0d, 0.0000660479d },
            { 2251000.0d, 0.0000643248d },
            { 2260000.0d, 0.0000626144d },
            { 2269000.0d, 0.0000609177d },
            { 2278000.0d, 0.0000592347d },
            { 2287000.0d, 0.0000575652d },
            { 2296000.0d, 0.0000559089d },
            { 2305000.0d, 0.0000542663d },
            { 2314000.0d, 0.000052638d },
            { 2323000.0d, 0.0000510246d },
            { 2332000.0d, 0.0000494267d },
            { 2341000.0d, 0.000047845d },
            { 2350000.0d, 0.0000462801d },
            { 2359000.0d, 0.0000447325d },
            { 2368000.0d, 0.0000432031d },
            { 2377000.0d, 0.0000416923d },
            { 2386000.0d, 0.0000402009d },
            { 2395000.0d, 0.0000387293d },
            { 2404000.0d, 0.0000372782d },
            { 2413000.0d, 0.0000358475d },
            { 2422000.0d, 0.0000344381d },
            { 2431000.0d, 0.0000330496d },
            { 2440000.0d, 0.0000316822d },
            { 2449000.0d, 0.0000303364d },
            { 2458000.0d, 0.000029013d },
            { 2467000.0d, 0.0000277124d },
            { 2476000.0d, 0.000026435d },
            { 2485000.0d, 0.0000251802d },
            { 2494000.0d, 0.0000239483d },
            { 2503000.0d, 0.0000227399d },
            { 2512000.0d, 0.0000215555d },
            { 2521000.0d, 0.0000203958d },
            { 2530000.0d, 0.0000192613d },
            { 2539000.0d, 0.0000181527d },
            { 2548000.0d, 0.0000170705d },
            { 2557000.0d, 0.0000160154d },
            { 2566000.0d, 0.0000149879d },
            { 2575000.0d, 0.0000139888d },
            { 2584000.0d, 0.0000130185d },
            { 2593000.0d, 0.0000120777d },
            { 2602000.0d, 0.0000111671d },
            { 2611000.0d, 0.0000102873d },
            { 2620000.0d, 0.00000943889d },
            { 2629000.0d, 0.00000862253d },
            { 2638000.0d, 0.00000783884d },
            { 2647000.0d, 0.00000708847d },
            { 2656000.0d, 0.00000637206d },
            { 2665000.0d, 0.00000569027d },
            { 2674000.0d, 0.00000504373d },
            { 2683000.0d, 0.00000443311d },
            { 2692000.0d, 0.00000385906d },
            { 2701000.0d, 0.00000332222d },
            { 2710000.0d, 0.00000282327d },
            { 2719000.0d, 0.00000236287d },
            { 2728000.0d, 0.00000194169d },
            { 2737000.0d, 0.00000156036d },
            { 2746000.0d, 0.00000121954d },
            { 2755000.0d, 0.000000919478d },
            { 2764000.0d, 0.000000660682d },
            { 2773000.0d, 0.000000443785d },
            { 2782000.0d, 0.000000269404d },
            { 2791000.0d, 0.000000138141d },
            { 2800000.0d, 0.0000000505689d },
            { 2809000.0d, 0.00000000718534d },
            { 2818000.0d, 0.0000000014316d },
            { 2827000.0d, 0.00000000047597d },
            { 2836000.0d, 0.0000000000302077d },
            { 2839000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    