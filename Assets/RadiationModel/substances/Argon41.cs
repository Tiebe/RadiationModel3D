using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon41 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon41";
        public override double halfLife { get; } = 6576.6d;
        public override double atomicWeight { get; } = 40.9645d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium41()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.9915999999999999d, new GammaParticle(1293640.0, 0.00096)), new(0.0005156319999999999d, new GammaParticle(1677000.0, 0.00074)), new(1.9842448637329175e-07d, new GammaParticle(311.0, 3.98663)), new(2.6981522252461593e-06d, new GammaParticle(3311.0, 0.37446)), new(5.337590950041858e-06d, new GammaParticle(3314.0, 0.37412)), new(9.843785389727823e-07d, new GammaParticle(3591.0, 0.34526)), new(9.843785389727823e-07d, new GammaParticle(3591.0, 0.34526)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000645894d },
            { 2000.0d, 0.000647932d },
            { 4000.0d, 0.000650837d },
            { 6000.0d, 0.000654609d },
            { 8000.0d, 0.000659247d },
            { 10000.0d, 0.000664618d },
            { 12000.0d, 0.000670521d },
            { 14000.0d, 0.000676741d },
            { 16000.0d, 0.00068326d },
            { 18000.0d, 0.000689968d },
            { 20000.0d, 0.000696785d },
            { 22000.0d, 0.000703704d },
            { 24000.0d, 0.00071068d },
            { 26000.0d, 0.000717679d },
            { 28000.0d, 0.000724696d },
            { 30000.0d, 0.000731712d },
            { 32000.0d, 0.000738712d },
            { 34000.0d, 0.000745694d },
            { 36000.0d, 0.000752648d },
            { 38000.0d, 0.000759569d },
            { 40000.0d, 0.000766454d },
            { 42000.0d, 0.000773299d },
            { 44000.0d, 0.000780101d },
            { 46000.0d, 0.000786859d },
            { 48000.0d, 0.000793572d },
            { 50000.0d, 0.000800238d },
            { 52000.0d, 0.000806856d },
            { 54000.0d, 0.000813426d },
            { 56000.0d, 0.000819948d },
            { 58000.0d, 0.000826422d },
            { 60000.0d, 0.000832846d },
            { 62000.0d, 0.000839222d },
            { 64000.0d, 0.000845549d },
            { 66000.0d, 0.000851828d },
            { 68000.0d, 0.000858058d },
            { 70000.0d, 0.000864239d },
            { 72000.0d, 0.000870373d },
            { 74000.0d, 0.000876459d },
            { 76000.0d, 0.000882497d },
            { 78000.0d, 0.000888489d },
            { 80000.0d, 0.000894432d },
            { 82000.0d, 0.00090033d },
            { 84000.0d, 0.000906181d },
            { 86000.0d, 0.000911986d },
            { 88000.0d, 0.000917746d },
            { 90000.0d, 0.000923459d },
            { 92000.0d, 0.000929127d },
            { 94000.0d, 0.000934751d },
            { 96000.0d, 0.00094033d },
            { 98000.0d, 0.000945864d },
            { 100000.0d, 0.000951354d },
            { 108000.0d, 0.000972878d },
            { 116000.0d, 0.000993715d },
            { 124000.0d, 0.00101387d },
            { 132000.0d, 0.00103337d },
            { 140000.0d, 0.00105222d },
            { 148000.0d, 0.00107042d },
            { 156000.0d, 0.00108798d },
            { 164000.0d, 0.00110491d },
            { 172000.0d, 0.00112121d },
            { 180000.0d, 0.00113689d },
            { 188000.0d, 0.00115194d },
            { 196000.0d, 0.00116638d },
            { 204000.0d, 0.00118021d },
            { 212000.0d, 0.00119342d },
            { 220000.0d, 0.00120603d },
            { 228000.0d, 0.00121803d },
            { 236000.0d, 0.00122942d },
            { 244000.0d, 0.00124021d },
            { 252000.0d, 0.00125039d },
            { 260000.0d, 0.00125997d },
            { 268000.0d, 0.00126895d },
            { 276000.0d, 0.00127733d },
            { 284000.0d, 0.00128511d },
            { 292000.0d, 0.0012923d },
            { 300000.0d, 0.00129889d },
            { 308000.0d, 0.00130488d },
            { 316000.0d, 0.00131028d },
            { 324000.0d, 0.0013151d },
            { 332000.0d, 0.00131932d },
            { 340000.0d, 0.00132295d },
            { 348000.0d, 0.00132601d },
            { 356000.0d, 0.00132847d },
            { 364000.0d, 0.00133036d },
            { 372000.0d, 0.00133167d },
            { 380000.0d, 0.00133241d },
            { 388000.0d, 0.00133257d },
            { 396000.0d, 0.00133217d },
            { 404000.0d, 0.0013312d },
            { 412000.0d, 0.00132967d },
            { 420000.0d, 0.00132758d },
            { 428000.0d, 0.00132494d },
            { 436000.0d, 0.00132175d },
            { 444000.0d, 0.00131802d },
            { 452000.0d, 0.00131375d },
            { 460000.0d, 0.00130894d },
            { 468000.0d, 0.00130361d },
            { 476000.0d, 0.00129775d },
            { 484000.0d, 0.00129137d },
            { 492000.0d, 0.00128447d },
            { 500000.0d, 0.00127707d },
            { 508000.0d, 0.00126918d },
            { 516000.0d, 0.00126079d },
            { 524000.0d, 0.00125191d },
            { 532000.0d, 0.00124255d },
            { 540000.0d, 0.00123273d },
            { 548000.0d, 0.00122243d },
            { 556000.0d, 0.00121168d },
            { 564000.0d, 0.00120048d },
            { 572000.0d, 0.00118885d },
            { 580000.0d, 0.00117677d },
            { 588000.0d, 0.00116427d },
            { 596000.0d, 0.00115137d },
            { 604000.0d, 0.00113805d },
            { 612000.0d, 0.00112434d },
            { 620000.0d, 0.00111025d },
            { 628000.0d, 0.00109578d },
            { 636000.0d, 0.00108094d },
            { 644000.0d, 0.00106575d },
            { 652000.0d, 0.00105021d },
            { 660000.0d, 0.00103435d },
            { 668000.0d, 0.00101815d },
            { 676000.0d, 0.00100165d },
            { 684000.0d, 0.000984851d },
            { 692000.0d, 0.000967762d },
            { 700000.0d, 0.000950399d },
            { 708000.0d, 0.000932772d },
            { 716000.0d, 0.000914897d },
            { 724000.0d, 0.000896784d },
            { 732000.0d, 0.000878447d },
            { 740000.0d, 0.0008599d },
            { 748000.0d, 0.000841156d },
            { 756000.0d, 0.000822228d },
            { 764000.0d, 0.000803133d },
            { 772000.0d, 0.000783883d },
            { 780000.0d, 0.000764493d },
            { 788000.0d, 0.000744978d },
            { 796000.0d, 0.000725352d },
            { 804000.0d, 0.000705632d },
            { 812000.0d, 0.000685834d },
            { 820000.0d, 0.000665972d },
            { 828000.0d, 0.000646061d },
            { 836000.0d, 0.000626119d },
            { 844000.0d, 0.00060616d },
            { 852000.0d, 0.000586203d },
            { 860000.0d, 0.000566263d },
            { 868000.0d, 0.000546358d },
            { 876000.0d, 0.000526505d },
            { 884000.0d, 0.000506724d },
            { 892000.0d, 0.000487029d },
            { 900000.0d, 0.000467441d },
            { 908000.0d, 0.000447979d },
            { 916000.0d, 0.000428659d },
            { 924000.0d, 0.0004095d },
            { 932000.0d, 0.000390524d },
            { 940000.0d, 0.000371747d },
            { 948000.0d, 0.000353191d },
            { 956000.0d, 0.000334874d },
            { 964000.0d, 0.000316817d },
            { 972000.0d, 0.000299041d },
            { 980000.0d, 0.000281565d },
            { 988000.0d, 0.000264411d },
            { 996000.0d, 0.000247598d },
            { 1004000.0d, 0.000231149d },
            { 1012000.0d, 0.000215086d },
            { 1020000.0d, 0.000199428d },
            { 1028000.0d, 0.000184199d },
            { 1036000.0d, 0.00016942d },
            { 1044000.0d, 0.000155115d },
            { 1052000.0d, 0.000141305d },
            { 1060000.0d, 0.000128013d },
            { 1068000.0d, 0.000115263d },
            { 1076000.0d, 0.000103077d },
            { 1084000.0d, 0.000091479d },
            { 1092000.0d, 0.0000804929d },
            { 1100000.0d, 0.0000701426d },
            { 1108000.0d, 0.0000604521d },
            { 1116000.0d, 0.0000514457d },
            { 1124000.0d, 0.0000431485d },
            { 1132000.0d, 0.000035585d },
            { 1140000.0d, 0.0000287802d },
            { 1148000.0d, 0.0000227596d },
            { 1156000.0d, 0.0000175485d },
            { 1164000.0d, 0.0000131729d },
            { 1172000.0d, 0.00000965868d },
            { 1180000.0d, 0.00000703195d },
            { 1188000.0d, 0.00000531914d },
            { 1196000.0d, 0.00000454708d },
            { 1204000.0d, 0.00000449825d },
            { 1212000.0d, 0.00000449157d },
            { 1220000.0d, 0.00000448459d },
            { 1228000.0d, 0.00000447732d },
            { 1236000.0d, 0.00000446975d },
            { 1244000.0d, 0.00000446188d },
            { 1252000.0d, 0.00000445371d },
            { 1260000.0d, 0.00000444523d },
            { 1268000.0d, 0.00000443645d },
            { 1276000.0d, 0.00000442736d },
            { 1284000.0d, 0.00000441796d },
            { 1292000.0d, 0.00000440824d },
            { 1300000.0d, 0.0000043982d },
            { 1308000.0d, 0.00000438785d },
            { 1316000.0d, 0.00000437718d },
            { 1324000.0d, 0.00000436618d },
            { 1332000.0d, 0.00000435485d },
            { 1340000.0d, 0.00000434319d },
            { 1348000.0d, 0.00000433119d },
            { 1356000.0d, 0.00000431886d },
            { 1364000.0d, 0.00000430619d },
            { 1372000.0d, 0.00000429318d },
            { 1380000.0d, 0.00000427982d },
            { 1388000.0d, 0.00000426611d },
            { 1396000.0d, 0.00000425204d },
            { 1404000.0d, 0.00000423762d },
            { 1412000.0d, 0.00000422285d },
            { 1420000.0d, 0.00000420771d },
            { 1428000.0d, 0.0000041922d },
            { 1436000.0d, 0.00000417634d },
            { 1444000.0d, 0.00000416009d },
            { 1452000.0d, 0.00000414348d },
            { 1460000.0d, 0.00000412648d },
            { 1468000.0d, 0.00000410911d },
            { 1476000.0d, 0.00000409135d },
            { 1484000.0d, 0.00000407321d },
            { 1492000.0d, 0.00000405468d },
            { 1500000.0d, 0.00000403576d },
            { 1508000.0d, 0.00000401644d },
            { 1516000.0d, 0.00000399672d },
            { 1524000.0d, 0.0000039766d },
            { 1532000.0d, 0.00000395609d },
            { 1540000.0d, 0.00000393517d },
            { 1548000.0d, 0.00000391383d },
            { 1556000.0d, 0.00000389209d },
            { 1564000.0d, 0.00000386994d },
            { 1572000.0d, 0.00000384737d },
            { 1580000.0d, 0.00000382439d },
            { 1588000.0d, 0.00000380099d },
            { 1596000.0d, 0.00000377716d },
            { 1604000.0d, 0.00000375292d },
            { 1612000.0d, 0.00000372825d },
            { 1620000.0d, 0.00000370316d },
            { 1628000.0d, 0.00000367764d },
            { 1636000.0d, 0.00000365169d },
            { 1644000.0d, 0.00000362532d },
            { 1652000.0d, 0.0000035985d },
            { 1660000.0d, 0.00000357127d },
            { 1668000.0d, 0.0000035436d },
            { 1676000.0d, 0.00000351551d },
            { 1684000.0d, 0.00000348697d },
            { 1692000.0d, 0.00000345802d },
            { 1700000.0d, 0.00000342862d },
            { 1708000.0d, 0.00000339879d },
            { 1716000.0d, 0.00000336854d },
            { 1724000.0d, 0.00000333787d },
            { 1732000.0d, 0.00000330675d },
            { 1740000.0d, 0.00000327521d },
            { 1748000.0d, 0.00000324325d },
            { 1756000.0d, 0.00000321086d },
            { 1764000.0d, 0.00000317805d },
            { 1772000.0d, 0.00000314482d },
            { 1780000.0d, 0.00000311118d },
            { 1788000.0d, 0.00000307712d },
            { 1796000.0d, 0.00000304265d },
            { 1804000.0d, 0.00000300777d },
            { 1812000.0d, 0.00000297249d },
            { 1820000.0d, 0.00000293681d },
            { 1828000.0d, 0.00000290073d },
            { 1836000.0d, 0.00000286427d },
            { 1844000.0d, 0.00000282743d },
            { 1852000.0d, 0.0000027902d },
            { 1860000.0d, 0.00000275259d },
            { 1868000.0d, 0.00000271462d },
            { 1876000.0d, 0.00000267629d },
            { 1884000.0d, 0.0000026376d },
            { 1892000.0d, 0.00000259857d },
            { 1900000.0d, 0.0000025592d },
            { 1908000.0d, 0.0000025195d },
            { 1916000.0d, 0.00000247947d },
            { 1924000.0d, 0.00000243913d },
            { 1932000.0d, 0.00000239848d },
            { 1940000.0d, 0.00000235755d },
            { 1948000.0d, 0.00000231632d },
            { 1956000.0d, 0.00000227483d },
            { 1964000.0d, 0.00000223307d },
            { 1972000.0d, 0.00000219107d },
            { 1980000.0d, 0.00000214881d },
            { 1988000.0d, 0.00000210634d },
            { 1996000.0d, 0.00000206365d },
            { 2004000.0d, 0.00000202077d },
            { 2012000.0d, 0.00000197771d },
            { 2020000.0d, 0.00000193447d },
            { 2028000.0d, 0.00000189108d },
            { 2036000.0d, 0.00000184755d },
            { 2044000.0d, 0.0000018039d },
            { 2052000.0d, 0.00000176014d },
            { 2060000.0d, 0.0000017163d },
            { 2068000.0d, 0.00000167239d },
            { 2076000.0d, 0.00000162844d },
            { 2084000.0d, 0.00000158444d },
            { 2092000.0d, 0.00000154044d },
            { 2100000.0d, 0.00000149646d },
            { 2108000.0d, 0.0000014525d },
            { 2116000.0d, 0.0000014086d },
            { 2124000.0d, 0.00000136478d },
            { 2132000.0d, 0.00000132107d },
            { 2140000.0d, 0.00000127747d },
            { 2148000.0d, 0.00000123403d },
            { 2156000.0d, 0.00000119076d },
            { 2164000.0d, 0.0000011477d },
            { 2172000.0d, 0.00000110487d },
            { 2180000.0d, 0.00000106229d },
            { 2188000.0d, 0.00000102001d },
            { 2196000.0d, 0.000000978039d },
            { 2204000.0d, 0.000000936416d },
            { 2212000.0d, 0.000000895173d },
            { 2220000.0d, 0.00000085434d },
            { 2228000.0d, 0.00000081395d },
            { 2236000.0d, 0.000000774037d },
            { 2244000.0d, 0.000000734636d },
            { 2252000.0d, 0.000000695783d },
            { 2260000.0d, 0.000000657513d },
            { 2268000.0d, 0.000000619864d },
            { 2276000.0d, 0.000000582873d },
            { 2284000.0d, 0.000000546581d },
            { 2292000.0d, 0.000000511026d },
            { 2300000.0d, 0.000000476252d },
            { 2308000.0d, 0.000000442298d },
            { 2316000.0d, 0.000000409208d },
            { 2324000.0d, 0.000000377026d },
            { 2332000.0d, 0.000000345796d },
            { 2340000.0d, 0.000000315566d },
            { 2348000.0d, 0.000000286381d },
            { 2356000.0d, 0.000000258291d },
            { 2364000.0d, 0.000000231343d },
            { 2372000.0d, 0.000000205588d },
            { 2380000.0d, 0.000000181078d },
            { 2388000.0d, 0.000000157865d },
            { 2396000.0d, 0.000000136002d },
            { 2404000.0d, 0.000000115543d },
            { 2412000.0d, 0.0000000965446d },
            { 2420000.0d, 0.0000000790643d },
            { 2428000.0d, 0.0000000631593d },
            { 2436000.0d, 0.000000048889d },
            { 2444000.0d, 0.0000000363139d },
            { 2452000.0d, 0.0000000254958d },
            { 2460000.0d, 0.0000000164975d },
            { 2468000.0d, 0.00000000938314d },
            { 2476000.0d, 0.00000000421818d },
            { 2484000.0d, 0.00000000106925d },
            { 2492000.0d, 0d },

        }; 
    }
}
    