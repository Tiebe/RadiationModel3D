using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium201";
        public override double halfLife { get; } = 930.0d;
        public override double atomicWeight { get; } = 200.98226d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9887d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead201()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0216d, new GammaParticle(188600.0, 0.00657)), new(0.0011899999999999999d, new GammaParticle(195900.0, 0.00633)), new(0.198d, new GammaParticle(240100.0, 0.00516)), new(0.0054d, new GammaParticle(296100.0, 0.00419)), new(0.038599999999999995d, new GammaParticle(428200.0, 0.0029)), new(0.012d, new GammaParticle(506800.0, 0.00245)), new(0.006d, new GammaParticle(516700.0, 0.0024)), new(0.031d, new GammaParticle(530100.0, 0.00234)), new(0.0131d, new GammaParticle(537500.0, 0.00231)), new(0.0106d, new GammaParticle(543400.0, 0.00228)), new(0.0225d, new GammaParticle(551900.0, 0.00225)), new(0.0043d, new GammaParticle(566600.0, 0.00219)), new(0.0161d, new GammaParticle(583600.0, 0.00212)), new(0.0441d, new GammaParticle(593300.0, 0.00209)), new(0.0074d, new GammaParticle(624700.0, 0.00198)), new(0.0053d, new GammaParticle(636500.0, 0.00195)), new(0.0043d, new GammaParticle(650900.0, 0.0019)), new(0.0109d, new GammaParticle(731700.0, 0.00169)), new(0.0137d, new GammaParticle(771800.0, 0.00161)), new(0.0115d, new GammaParticle(779400.0, 0.00159)), new(0.042800000000000005d, new GammaParticle(791400.0, 0.00157)), new(0.005d, new GammaParticle(809900.0, 0.00153)), new(0.353d, new GammaParticle(846300.0, 0.00147)), new(0.0146d, new GammaParticle(874600.0, 0.00142)), new(0.0167d, new GammaParticle(889200.0, 0.00139)), new(0.28d, new GammaParticle(890100.0, 0.00139)), new(0.153d, new GammaParticle(904200.0, 0.00137)), new(0.0044d, new GammaParticle(918700.0, 0.00135)), new(0.0053d, new GammaParticle(926500.0, 0.00134)), new(0.0048d, new GammaParticle(944200.0, 0.00131)), new(0.009399999999999999d, new GammaParticle(967400.0, 0.00128)), new(0.0167d, new GammaParticle(971400.0, 0.00128)), new(0.0137d, new GammaParticle(979700.0, 0.00127)), new(0.0067d, new GammaParticle(1023000.0, 0.00121)), new(0.0060999999999999995d, new GammaParticle(1031200.0, 0.0012)), new(0.0066d, new GammaParticle(1039700.0, 0.00119)), new(0.0088d, new GammaParticle(1054700.0, 0.00118)), new(0.005699999999999999d, new GammaParticle(1160600.0, 0.00107)), new(0.0325d, new GammaParticle(1175300.0, 0.00105)), new(0.0033d, new GammaParticle(1181300.0, 0.00105)), new(0.057999999999999996d, new GammaParticle(1186700.0, 0.00104)), new(0.0034999999999999996d, new GammaParticle(1196300.0, 0.00104)), new(0.0334d, new GammaParticle(1207100.0, 0.00103)), new(0.0097d, new GammaParticle(1219300.0, 0.00102)), new(0.012199999999999999d, new GammaParticle(1300500.0, 0.00095)), new(0.0106d, new GammaParticle(1306900.0, 0.00095)), new(0.0059d, new GammaParticle(1318000.0, 0.00094)), new(0.0055000000000000005d, new GammaParticle(1346200.0, 0.00092)), new(0.0088d, new GammaParticle(1348400.0, 0.00092)), new(0.012199999999999999d, new GammaParticle(1369300.0, 0.00091)), new(0.0194d, new GammaParticle(1398000.0, 0.00089)), new(0.009399999999999999d, new GammaParticle(1442200.0, 0.00086)), new(0.0134d, new GammaParticle(1470900.0, 0.00084)), new(0.0097d, new GammaParticle(1506600.0, 0.00082)), new(0.0158d, new GammaParticle(1518200.0, 0.00082)), new(0.006999999999999999d, new GammaParticle(1521500.0, 0.00081)), new(0.0040999999999999995d, new GammaParticle(1531700.0, 0.00081)), new(0.0060999999999999995d, new GammaParticle(1588500.0, 0.00078)), new(0.01d, new GammaParticle(1593900.0, 0.00078)), new(0.011899999999999999d, new GammaParticle(1609000.0, 0.00077)), new(0.008199999999999999d, new GammaParticle(1627700.0, 0.00076)), new(0.005699999999999999d, new GammaParticle(1638100.0, 0.00076)), new(0.0137d, new GammaParticle(1676300.0, 0.00074)), new(0.0085d, new GammaParticle(1689300.0, 0.00073)), new(0.0158d, new GammaParticle(1702100.0, 0.00073)), new(0.006999999999999999d, new GammaParticle(1746800.0, 0.00071)), new(0.0040999999999999995d, new GammaParticle(1815800.0, 0.00068)), new(0.0029d, new GammaParticle(1819800.0, 0.00068)), new(0.0097d, new GammaParticle(1833100.0, 0.00068)), new(0.0060999999999999995d, new GammaParticle(1841600.0, 0.00067)), new(0.0088d, new GammaParticle(1848000.0, 0.00067)), new(0.006500000000000001d, new GammaParticle(1927500.0, 0.00064)), new(0.0029d, new GammaParticle(1930200.0, 0.00064)), new(0.0088d, new GammaParticle(1944200.0, 0.00064)), new(0.0055000000000000005d, new GammaParticle(2028900.0, 0.00061)), new(0.0016d, new GammaParticle(2055700.0, 0.0006)), new(0.0034999999999999996d, new GammaParticle(2059400.0, 0.0006)), new(0.0076d, new GammaParticle(2065300.0, 0.0006)), new(0.0015d, new GammaParticle(2073200.0, 0.0006)), new(0.0016d, new GammaParticle(2128000.0, 0.00058)), new(0.0091d, new GammaParticle(2191500.0, 0.00057)), new(0.0046d, new GammaParticle(2321700.0, 0.00053)), new(0.256332d, new GammaParticle(511000.0, 0.00243)), new(0.34355817620890905d, new GammaParticle(12904.0, 0.09608)), new(0.24270893844343178d, new GammaParticle(74815.0, 0.01657)), new(0.4060715048409433d, new GammaParticle(77108.0, 0.01608)), new(0.13909534771793644d, new GammaParticle(87388.0, 0.01419)), new(0.18165852411962502d, new GammaParticle(88458.0, 0.01402)), new(0.04256317640168855d, new GammaParticle(89784.0, 0.01381)) } },
            { 0.0113d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead197()), new(1.0d, new AlphaParticle(6821002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 3000.0d, 0.0000000000471025d },
            { 6000.0d, 0.00000000136496d },
            { 9000.0d, 0.00000000627599d },
            { 12000.0d, 0.0000000142865d },
            { 15000.0d, 0.000000026723d },
            { 18000.0d, 0.0000000440645d },
            { 21000.0d, 0.0000000694478d },
            { 24000.0d, 0.000000102212d },
            { 27000.0d, 0.000000143612d },
            { 30000.0d, 0.000000194615d },
            { 33000.0d, 0.00000025573d },
            { 36000.0d, 0.00000032689d },
            { 39000.0d, 0.0000004092d },
            { 42000.0d, 0.000000502369d },
            { 45000.0d, 0.000000606699d },
            { 48000.0d, 0.000000722324d },
            { 51000.0d, 0.000000849182d },
            { 54000.0d, 0.000000987259d },
            { 57000.0d, 0.00000113638d },
            { 60000.0d, 0.00000129651d },
            { 63000.0d, 0.00000146743d },
            { 66000.0d, 0.00000164882d },
            { 69000.0d, 0.00000184056d },
            { 72000.0d, 0.00000204259d },
            { 75000.0d, 0.00000225406d },
            { 78000.0d, 0.00000247529d },
            { 81000.0d, 0.00000270584d },
            { 84000.0d, 0.00000294513d },
            { 87000.0d, 0.0000031931d },
            { 90000.0d, 0.0000034497d },
            { 93000.0d, 0.00000371394d },
            { 96000.0d, 0.00000398619d },
            { 99000.0d, 0.0000042659d },
            { 102000.0d, 0.00000455265d },
            { 112000.0d, 0.00000555677d },
            { 122000.0d, 0.00000662704d },
            { 132000.0d, 0.00000775406d },
            { 142000.0d, 0.00000892903d },
            { 152000.0d, 0.0000101442d },
            { 162000.0d, 0.0000113924d },
            { 172000.0d, 0.0000126671d },
            { 182000.0d, 0.0000139629d },
            { 192000.0d, 0.0000152747d },
            { 202000.0d, 0.0000165979d },
            { 212000.0d, 0.0000179286d },
            { 222000.0d, 0.0000192631d },
            { 232000.0d, 0.0000205983d },
            { 242000.0d, 0.0000219313d },
            { 252000.0d, 0.0000232597d },
            { 262000.0d, 0.000024581d },
            { 272000.0d, 0.0000258935d },
            { 282000.0d, 0.0000271952d },
            { 292000.0d, 0.0000284847d },
            { 302000.0d, 0.0000297603d },
            { 312000.0d, 0.000031021d },
            { 322000.0d, 0.0000322656d },
            { 332000.0d, 0.000033493d },
            { 342000.0d, 0.0000347024d },
            { 352000.0d, 0.000035893d },
            { 362000.0d, 0.0000370641d },
            { 372000.0d, 0.000038215d },
            { 382000.0d, 0.0000393452d },
            { 392000.0d, 0.0000404542d },
            { 402000.0d, 0.0000415416d },
            { 412000.0d, 0.0000426071d },
            { 422000.0d, 0.0000436502d },
            { 432000.0d, 0.0000446707d },
            { 442000.0d, 0.0000456685d },
            { 452000.0d, 0.0000466431d },
            { 462000.0d, 0.0000475946d },
            { 472000.0d, 0.0000485227d },
            { 482000.0d, 0.0000494274d },
            { 492000.0d, 0.0000503086d },
            { 502000.0d, 0.0000511662d },
            { 512000.0d, 0.0000520001d },
            { 522000.0d, 0.0000528104d },
            { 532000.0d, 0.0000535971d },
            { 542000.0d, 0.0000543601d },
            { 552000.0d, 0.0000550996d },
            { 562000.0d, 0.0000558155d },
            { 572000.0d, 0.000056508d },
            { 582000.0d, 0.000057177d },
            { 592000.0d, 0.0000578227d },
            { 602000.0d, 0.0000584453d },
            { 612000.0d, 0.0000590447d },
            { 622000.0d, 0.0000596212d },
            { 632000.0d, 0.0000601749d },
            { 642000.0d, 0.0000607058d },
            { 652000.0d, 0.0000612142d },
            { 662000.0d, 0.0000617003d },
            { 672000.0d, 0.0000621642d },
            { 682000.0d, 0.0000626059d },
            { 692000.0d, 0.0000630259d },
            { 702000.0d, 0.0000634242d },
            { 712000.0d, 0.000063801d },
            { 722000.0d, 0.0000641566d },
            { 732000.0d, 0.000064491d },
            { 742000.0d, 0.0000648046d },
            { 752000.0d, 0.0000650975d },
            { 762000.0d, 0.0000653701d },
            { 772000.0d, 0.0000656225d },
            { 782000.0d, 0.0000658549d },
            { 792000.0d, 0.0000660675d },
            { 802000.0d, 0.0000662607d },
            { 812000.0d, 0.0000664347d },
            { 822000.0d, 0.0000665897d },
            { 832000.0d, 0.000066726d },
            { 842000.0d, 0.0000668439d },
            { 852000.0d, 0.0000669435d },
            { 862000.0d, 0.0000670251d },
            { 872000.0d, 0.0000670892d },
            { 882000.0d, 0.0000671358d },
            { 892000.0d, 0.0000671655d },
            { 902000.0d, 0.0000671782d },
            { 912000.0d, 0.0000671744d },
            { 922000.0d, 0.0000671544d },
            { 932000.0d, 0.0000671184d },
            { 942000.0d, 0.0000670667d },
            { 952000.0d, 0.0000669998d },
            { 962000.0d, 0.0000669177d },
            { 972000.0d, 0.0000668209d },
            { 982000.0d, 0.0000667097d },
            { 992000.0d, 0.0000665841d },
            { 1002000.0d, 0.000066444d },
            { 1012000.0d, 0.0000662897d },
            { 1022000.0d, 0.0000661215d },
            { 1032000.0d, 0.0000659398d },
            { 1042000.0d, 0.0000657449d },
            { 1052000.0d, 0.0000655369d },
            { 1062000.0d, 0.0000653163d },
            { 1072000.0d, 0.0000650834d },
            { 1082000.0d, 0.0000648383d },
            { 1092000.0d, 0.0000645816d },
            { 1102000.0d, 0.0000643135d },
            { 1112000.0d, 0.0000640343d },
            { 1122000.0d, 0.0000637444d },
            { 1132000.0d, 0.0000634439d },
            { 1142000.0d, 0.0000631334d },
            { 1152000.0d, 0.0000628131d },
            { 1162000.0d, 0.0000624834d },
            { 1172000.0d, 0.0000621446d },
            { 1182000.0d, 0.000061797d },
            { 1192000.0d, 0.000061441d },
            { 1202000.0d, 0.000061077d },
            { 1212000.0d, 0.0000607051d },
            { 1222000.0d, 0.0000603259d },
            { 1232000.0d, 0.0000599397d },
            { 1242000.0d, 0.0000595469d },
            { 1252000.0d, 0.0000591477d },
            { 1262000.0d, 0.0000587425d },
            { 1272000.0d, 0.0000583318d },
            { 1282000.0d, 0.0000579159d },
            { 1292000.0d, 0.000057495d },
            { 1302000.0d, 0.000057069d },
            { 1312000.0d, 0.0000566374d },
            { 1322000.0d, 0.0000562003d },
            { 1332000.0d, 0.0000557581d },
            { 1342000.0d, 0.0000553112d },
            { 1352000.0d, 0.0000548599d },
            { 1362000.0d, 0.0000544045d },
            { 1372000.0d, 0.0000539453d },
            { 1382000.0d, 0.0000534828d },
            { 1392000.0d, 0.0000530172d },
            { 1402000.0d, 0.0000525488d },
            { 1412000.0d, 0.0000520777d },
            { 1422000.0d, 0.0000516035d },
            { 1432000.0d, 0.0000511269d },
            { 1442000.0d, 0.0000506474d },
            { 1452000.0d, 0.000050165d },
            { 1462000.0d, 0.0000496797d },
            { 1472000.0d, 0.0000491911d },
            { 1482000.0d, 0.0000486992d },
            { 1492000.0d, 0.0000482041d },
            { 1502000.0d, 0.0000477061d },
            { 1512000.0d, 0.0000472053d },
            { 1522000.0d, 0.0000467018d },
            { 1532000.0d, 0.0000461958d },
            { 1542000.0d, 0.0000456876d },
            { 1552000.0d, 0.0000451775d },
            { 1562000.0d, 0.0000446658d },
            { 1572000.0d, 0.0000441527d },
            { 1582000.0d, 0.0000436385d },
            { 1592000.0d, 0.0000431235d },
            { 1602000.0d, 0.0000426079d },
            { 1612000.0d, 0.0000420921d },
            { 1622000.0d, 0.0000415764d },
            { 1632000.0d, 0.0000410609d },
            { 1642000.0d, 0.0000405461d },
            { 1652000.0d, 0.0000400321d },
            { 1662000.0d, 0.0000395194d },
            { 1672000.0d, 0.000039008d },
            { 1682000.0d, 0.0000384985d },
            { 1692000.0d, 0.000037991d },
            { 1702000.0d, 0.0000374859d },
            { 1712000.0d, 0.0000369834d },
            { 1722000.0d, 0.0000364839d },
            { 1732000.0d, 0.0000359875d },
            { 1742000.0d, 0.0000354949d },
            { 1752000.0d, 0.000035006d },
            { 1762000.0d, 0.0000345213d },
            { 1772000.0d, 0.0000340412d },
            { 1782000.0d, 0.0000335657d },
            { 1792000.0d, 0.0000330954d },
            { 1802000.0d, 0.0000326306d },
            { 1812000.0d, 0.0000321713d },
            { 1822000.0d, 0.0000317181d },
            { 1832000.0d, 0.0000312687d },
            { 1842000.0d, 0.0000308213d },
            { 1852000.0d, 0.0000303752d },
            { 1862000.0d, 0.0000299305d },
            { 1872000.0d, 0.0000294875d },
            { 1882000.0d, 0.0000290464d },
            { 1892000.0d, 0.0000286074d },
            { 1902000.0d, 0.0000281706d },
            { 1912000.0d, 0.0000277364d },
            { 1922000.0d, 0.0000273049d },
            { 1932000.0d, 0.0000268763d },
            { 1942000.0d, 0.0000264508d },
            { 1952000.0d, 0.0000260283d },
            { 1962000.0d, 0.0000256085d },
            { 1972000.0d, 0.0000251912d },
            { 1982000.0d, 0.0000247768d },
            { 1992000.0d, 0.0000243651d },
            { 2002000.0d, 0.0000239565d },
            { 2012000.0d, 0.0000235511d },
            { 2022000.0d, 0.0000231492d },
            { 2032000.0d, 0.0000227509d },
            { 2042000.0d, 0.0000223555d },
            { 2052000.0d, 0.0000219627d },
            { 2062000.0d, 0.0000215726d },
            { 2072000.0d, 0.0000211852d },
            { 2082000.0d, 0.0000207998d },
            { 2092000.0d, 0.0000204164d },
            { 2102000.0d, 0.0000200349d },
            { 2112000.0d, 0.0000196556d },
            { 2122000.0d, 0.0000192777d },
            { 2132000.0d, 0.0000189013d },
            { 2142000.0d, 0.0000185266d },
            { 2152000.0d, 0.0000181535d },
            { 2162000.0d, 0.0000177824d },
            { 2172000.0d, 0.0000174133d },
            { 2182000.0d, 0.0000170465d },
            { 2192000.0d, 0.0000166819d },
            { 2202000.0d, 0.0000163199d },
            { 2212000.0d, 0.0000159605d },
            { 2222000.0d, 0.000015604d },
            { 2232000.0d, 0.0000152503d },
            { 2242000.0d, 0.0000148999d },
            { 2252000.0d, 0.0000145526d },
            { 2262000.0d, 0.0000142088d },
            { 2272000.0d, 0.0000138686d },
            { 2282000.0d, 0.0000135314d },
            { 2292000.0d, 0.0000131971d },
            { 2302000.0d, 0.0000128657d },
            { 2312000.0d, 0.0000125375d },
            { 2322000.0d, 0.0000122127d },
            { 2332000.0d, 0.0000118912d },
            { 2342000.0d, 0.0000115734d },
            { 2352000.0d, 0.0000112594d },
            { 2362000.0d, 0.0000109493d },
            { 2372000.0d, 0.0000106433d },
            { 2382000.0d, 0.0000103416d },
            { 2392000.0d, 0.0000100442d },
            { 2402000.0d, 0.0000097515d },
            { 2412000.0d, 0.00000946275d },
            { 2422000.0d, 0.00000917725d },
            { 2432000.0d, 0.00000889477d },
            { 2442000.0d, 0.0000086154d },
            { 2452000.0d, 0.00000833904d },
            { 2462000.0d, 0.00000806537d },
            { 2472000.0d, 0.00000779449d },
            { 2482000.0d, 0.00000752653d },
            { 2492000.0d, 0.00000726159d },
            { 2502000.0d, 0.00000699981d },
            { 2512000.0d, 0.00000674133d },
            { 2522000.0d, 0.00000648626d },
            { 2532000.0d, 0.00000623472d },
            { 2542000.0d, 0.00000598685d },
            { 2552000.0d, 0.00000574279d },
            { 2562000.0d, 0.00000550266d },
            { 2572000.0d, 0.00000526661d },
            { 2582000.0d, 0.00000503475d },
            { 2592000.0d, 0.00000480724d },
            { 2602000.0d, 0.00000458423d },
            { 2612000.0d, 0.00000436584d },
            { 2622000.0d, 0.00000415223d },
            { 2632000.0d, 0.00000394353d },
            { 2642000.0d, 0.00000373989d },
            { 2652000.0d, 0.00000354146d },
            { 2662000.0d, 0.0000033484d },
            { 2672000.0d, 0.00000316085d },
            { 2682000.0d, 0.00000297896d },
            { 2692000.0d, 0.0000028029d },
            { 2702000.0d, 0.00000263274d },
            { 2712000.0d, 0.00000246781d },
            { 2722000.0d, 0.00000230792d },
            { 2732000.0d, 0.0000021532d },
            { 2742000.0d, 0.00000200378d },
            { 2752000.0d, 0.00000185976d },
            { 2762000.0d, 0.00000172126d },
            { 2772000.0d, 0.00000158842d },
            { 2782000.0d, 0.00000146135d },
            { 2792000.0d, 0.00000134018d },
            { 2802000.0d, 0.00000122498d },
            { 2812000.0d, 0.00000111478d },
            { 2822000.0d, 0.00000100918d },
            { 2832000.0d, 0.000000908266d },
            { 2842000.0d, 0.000000812154d },
            { 2852000.0d, 0.000000720948d },
            { 2862000.0d, 0.000000634755d },
            { 2872000.0d, 0.000000553685d },
            { 2882000.0d, 0.000000477843d },
            { 2892000.0d, 0.000000407339d },
            { 2902000.0d, 0.000000342282d },
            { 2912000.0d, 0.000000282784d },
            { 2922000.0d, 0.000000228954d },
            { 2932000.0d, 0.000000180904d },
            { 2942000.0d, 0.000000138746d },
            { 2952000.0d, 0.000000102592d },
            { 2962000.0d, 0.000000072554d },
            { 2972000.0d, 0.0000000487385d },
            { 2982000.0d, 0.0000000312457d },
            { 2992000.0d, 0.0000000194459d },
            { 3002000.0d, 0.0000000120539d },
            { 3012000.0d, 0.00000000656066d },
            { 3022000.0d, 0.00000000271511d },
            { 3032000.0d, 0.000000000535523d },
            { 3040000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    