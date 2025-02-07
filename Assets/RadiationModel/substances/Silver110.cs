using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver110 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver110";
        public override double halfLife { get; } = 24.56d;
        public override double atomicWeight { get; } = 109.90611d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium110()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1e-06d, new GammaParticle(255400.0, 0.00485)), new(7.6e-05d, new GammaParticle(295300.0, 0.0042)), new(8.5e-07d, new GammaParticle(295420.0, 0.0042)), new(4.5000000000000003e-07d, new GammaParticle(310400.0, 0.00399)), new(1.7e-05d, new GammaParticle(548400.0, 0.00226)), new(3.5e-06d, new GammaParticle(603030.0, 0.00206)), new(0.045d, new GammaParticle(657500.0, 0.00189)), new(0.00038199999999999996d, new GammaParticle(815500.0, 0.00152)), new(8.999999999999999e-05d, new GammaParticle(818200.0, 0.00152)), new(9e-06d, new GammaParticle(1074000.0, 0.00115)), new(0.000153d, new GammaParticle(1125800.0, 0.0011)), new(2.7000000000000002e-05d, new GammaParticle(1186300.0, 0.00105)), new(2.2000000000000003e-05d, new GammaParticle(1421400.0, 0.00087)), new(4.9e-05d, new GammaParticle(1475800.0, 0.00084)), new(2.2000000000000003e-05d, new GammaParticle(1629900.0, 0.00076)), new(7.2e-05d, new GammaParticle(1674300.0, 0.00074)), new(5.1000000000000006e-05d, new GammaParticle(1783600.0, 0.0007)), new(3.6e-05d, new GammaParticle(2004400.0, 0.00062)), new(8.5764412042152e-06d, new GammaParticle(3388.0, 0.36595)), new(3.0250416483924483e-05d, new GammaParticle(22983.0, 0.05395)), new(5.689376807207914e-05d, new GammaParticle(23173.0, 0.0535)), new(1.5858472164125536e-05d, new GammaParticle(26184.0, 0.04735)), new(1.874471409799638e-05d, new GammaParticle(26381.0, 0.047)), new(2.8862419338708472e-06d, new GammaParticle(26641.0, 0.04654)) } },
            { 0.003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium110()), new(0.0002d, new GammaParticle(373800.0, 0.00332)), new(0.00016d, new GammaParticle(3053.0, 0.40611)), new(0.00063d, new GammaParticle(21020.0, 0.05898)), new(0.0011799999999999998d, new GammaParticle(21177.0, 0.05855)), new(0.00032d, new GammaParticle(23904.0, 0.05187)), new(0.00037999999999999997d, new GammaParticle(24070.0, 0.05151)), new(5.4999999999999995e-05d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000171681d },
            { 700.0d, 0.000171999d },
            { 1400.0d, 0.000172328d },
            { 2100.0d, 0.000172666d },
            { 2800.0d, 0.000173006d },
            { 3500.0d, 0.000173345d },
            { 4200.0d, 0.000173683d },
            { 4900.0d, 0.00017402d },
            { 5600.0d, 0.000174357d },
            { 6300.0d, 0.000174693d },
            { 7000.0d, 0.000175029d },
            { 7700.0d, 0.000175364d },
            { 8400.0d, 0.000175699d },
            { 9100.0d, 0.000176033d },
            { 9800.0d, 0.000176367d },
            { 10000.0d, 0.000176462d },
            { 11000.0d, 0.000176938d },
            { 12000.0d, 0.000177413d },
            { 13000.0d, 0.000177887d },
            { 14000.0d, 0.00017836d },
            { 15000.0d, 0.000178833d },
            { 16000.0d, 0.000179305d },
            { 17000.0d, 0.000179775d },
            { 18000.0d, 0.000180245d },
            { 19000.0d, 0.000180714d },
            { 20000.0d, 0.000181183d },
            { 21000.0d, 0.00018165d },
            { 22000.0d, 0.000182118d },
            { 23000.0d, 0.000182584d },
            { 24000.0d, 0.00018305d },
            { 25000.0d, 0.000183516d },
            { 26000.0d, 0.00018398d },
            { 27000.0d, 0.000184444d },
            { 28000.0d, 0.000184914d },
            { 29000.0d, 0.000185384d },
            { 30000.0d, 0.000185855d },
            { 31000.0d, 0.000186327d },
            { 32000.0d, 0.0001868d },
            { 33000.0d, 0.000187273d },
            { 34000.0d, 0.000187747d },
            { 35000.0d, 0.000188221d },
            { 36000.0d, 0.000188696d },
            { 37000.0d, 0.000189175d },
            { 38000.0d, 0.000189654d },
            { 39000.0d, 0.000190135d },
            { 40000.0d, 0.000190617d },
            { 41000.0d, 0.0001911d },
            { 42000.0d, 0.000191584d },
            { 43000.0d, 0.000192069d },
            { 44000.0d, 0.000192556d },
            { 45000.0d, 0.000193043d },
            { 46000.0d, 0.000193532d },
            { 47000.0d, 0.000194022d },
            { 48000.0d, 0.000194514d },
            { 49000.0d, 0.000195006d },
            { 50000.0d, 0.0001955d },
            { 51000.0d, 0.000195995d },
            { 52000.0d, 0.000196491d },
            { 53000.0d, 0.000196988d },
            { 54000.0d, 0.000197487d },
            { 55000.0d, 0.000197986d },
            { 56000.0d, 0.000198486d },
            { 57000.0d, 0.000198988d },
            { 58000.0d, 0.00019949d },
            { 59000.0d, 0.000199994d },
            { 60000.0d, 0.000200499d },
            { 61000.0d, 0.000201005d },
            { 62000.0d, 0.000201511d },
            { 63000.0d, 0.000202019d },
            { 64000.0d, 0.000202528d },
            { 65000.0d, 0.000203037d },
            { 66000.0d, 0.000203547d },
            { 67000.0d, 0.000204058d },
            { 68000.0d, 0.00020457d },
            { 69000.0d, 0.000205083d },
            { 70000.0d, 0.000205597d },
            { 71000.0d, 0.000206111d },
            { 72000.0d, 0.000206627d },
            { 73000.0d, 0.000207143d },
            { 74000.0d, 0.00020766d },
            { 75000.0d, 0.000208177d },
            { 76000.0d, 0.000208696d },
            { 77000.0d, 0.000209215d },
            { 78000.0d, 0.000209734d },
            { 79000.0d, 0.000210255d },
            { 80000.0d, 0.000210777d },
            { 81000.0d, 0.000211299d },
            { 82000.0d, 0.000211821d },
            { 83000.0d, 0.000212344d },
            { 84000.0d, 0.000212868d },
            { 85000.0d, 0.000213392d },
            { 86000.0d, 0.000213917d },
            { 87000.0d, 0.000214443d },
            { 88000.0d, 0.000214969d },
            { 89000.0d, 0.000215496d },
            { 90000.0d, 0.000216024d },
            { 91000.0d, 0.000216552d },
            { 92000.0d, 0.00021708d },
            { 93000.0d, 0.000217609d },
            { 94000.0d, 0.000218138d },
            { 95000.0d, 0.000218668d },
            { 96000.0d, 0.000219199d },
            { 97000.0d, 0.00021973d },
            { 98000.0d, 0.000220261d },
            { 99000.0d, 0.000220793d },
            { 100000.0d, 0.000221325d },
            { 109000.0d, 0.000226135d },
            { 118000.0d, 0.000230973d },
            { 127000.0d, 0.000235836d },
            { 136000.0d, 0.000240718d },
            { 145000.0d, 0.000245613d },
            { 154000.0d, 0.00025052d },
            { 163000.0d, 0.000255435d },
            { 172000.0d, 0.000260355d },
            { 181000.0d, 0.000265279d },
            { 190000.0d, 0.000270202d },
            { 199000.0d, 0.000275124d },
            { 208000.0d, 0.000280043d },
            { 217000.0d, 0.000284957d },
            { 226000.0d, 0.000289863d },
            { 235000.0d, 0.000294762d },
            { 244000.0d, 0.000299646d },
            { 253000.0d, 0.000304515d },
            { 262000.0d, 0.000309368d },
            { 271000.0d, 0.000314203d },
            { 280000.0d, 0.000319017d },
            { 289000.0d, 0.000323811d },
            { 298000.0d, 0.000328583d },
            { 307000.0d, 0.000333331d },
            { 316000.0d, 0.000338054d },
            { 325000.0d, 0.000342751d },
            { 334000.0d, 0.000347421d },
            { 343000.0d, 0.000352063d },
            { 352000.0d, 0.000356677d },
            { 361000.0d, 0.000361259d },
            { 370000.0d, 0.000365811d },
            { 379000.0d, 0.00037033d },
            { 388000.0d, 0.000374816d },
            { 397000.0d, 0.000379268d },
            { 406000.0d, 0.000383685d },
            { 415000.0d, 0.000388066d },
            { 424000.0d, 0.000392411d },
            { 433000.0d, 0.000396717d },
            { 442000.0d, 0.000400985d },
            { 451000.0d, 0.000405214d },
            { 460000.0d, 0.000409403d },
            { 469000.0d, 0.00041355d },
            { 478000.0d, 0.000417656d },
            { 487000.0d, 0.000421721d },
            { 496000.0d, 0.000425741d },
            { 505000.0d, 0.000429718d },
            { 514000.0d, 0.00043365d },
            { 523000.0d, 0.000437537d },
            { 532000.0d, 0.000441377d },
            { 541000.0d, 0.000445172d },
            { 550000.0d, 0.00044892d },
            { 559000.0d, 0.000452619d },
            { 568000.0d, 0.00045627d },
            { 577000.0d, 0.000459872d },
            { 586000.0d, 0.000463422d },
            { 595000.0d, 0.000466923d },
            { 604000.0d, 0.000470372d },
            { 613000.0d, 0.000473768d },
            { 622000.0d, 0.000477113d },
            { 631000.0d, 0.000480404d },
            { 640000.0d, 0.000483641d },
            { 649000.0d, 0.000486824d },
            { 658000.0d, 0.000489953d },
            { 667000.0d, 0.000493027d },
            { 676000.0d, 0.000496044d },
            { 685000.0d, 0.000499006d },
            { 694000.0d, 0.000501911d },
            { 703000.0d, 0.000504758d },
            { 712000.0d, 0.000507549d },
            { 721000.0d, 0.000510282d },
            { 730000.0d, 0.000512957d },
            { 739000.0d, 0.000515573d },
            { 748000.0d, 0.00051813d },
            { 757000.0d, 0.000520628d },
            { 766000.0d, 0.000523067d },
            { 775000.0d, 0.000525445d },
            { 784000.0d, 0.000527763d },
            { 793000.0d, 0.000530021d },
            { 802000.0d, 0.000532218d },
            { 811000.0d, 0.000534354d },
            { 820000.0d, 0.000536428d },
            { 829000.0d, 0.00053844d },
            { 838000.0d, 0.00054039d },
            { 847000.0d, 0.000542278d },
            { 856000.0d, 0.000544103d },
            { 865000.0d, 0.000545865d },
            { 874000.0d, 0.000547564d },
            { 883000.0d, 0.0005492d },
            { 892000.0d, 0.000550771d },
            { 901000.0d, 0.00055228d },
            { 910000.0d, 0.000553724d },
            { 919000.0d, 0.000555104d },
            { 928000.0d, 0.000556422d },
            { 937000.0d, 0.000557673d },
            { 946000.0d, 0.000558861d },
            { 955000.0d, 0.000559984d },
            { 964000.0d, 0.000561043d },
            { 973000.0d, 0.000562037d },
            { 982000.0d, 0.000562966d },
            { 991000.0d, 0.000563831d },
            { 1000000.0d, 0.00056463d },
            { 1009000.0d, 0.000565365d },
            { 1018000.0d, 0.000566036d },
            { 1027000.0d, 0.00056664d },
            { 1036000.0d, 0.00056718d },
            { 1045000.0d, 0.000567655d },
            { 1054000.0d, 0.000568066d },
            { 1063000.0d, 0.000568411d },
            { 1072000.0d, 0.000568692d },
            { 1081000.0d, 0.000568908d },
            { 1090000.0d, 0.000569059d },
            { 1099000.0d, 0.000569146d },
            { 1108000.0d, 0.000569167d },
            { 1117000.0d, 0.000569126d },
            { 1126000.0d, 0.000569019d },
            { 1135000.0d, 0.000568847d },
            { 1144000.0d, 0.000568612d },
            { 1153000.0d, 0.000568312d },
            { 1162000.0d, 0.000567949d },
            { 1171000.0d, 0.000567521d },
            { 1180000.0d, 0.00056703d },
            { 1189000.0d, 0.000566476d },
            { 1198000.0d, 0.000565858d },
            { 1207000.0d, 0.000565178d },
            { 1216000.0d, 0.000564434d },
            { 1225000.0d, 0.000563627d },
            { 1234000.0d, 0.000562759d },
            { 1243000.0d, 0.000561828d },
            { 1252000.0d, 0.000560835d },
            { 1261000.0d, 0.00055978d },
            { 1270000.0d, 0.000558664d },
            { 1279000.0d, 0.000557487d },
            { 1288000.0d, 0.00055625d },
            { 1297000.0d, 0.000554951d },
            { 1306000.0d, 0.000553592d },
            { 1315000.0d, 0.000552174d },
            { 1324000.0d, 0.000550696d },
            { 1333000.0d, 0.000549159d },
            { 1342000.0d, 0.000547562d },
            { 1351000.0d, 0.000545908d },
            { 1360000.0d, 0.000544195d },
            { 1369000.0d, 0.000542424d },
            { 1378000.0d, 0.000540596d },
            { 1387000.0d, 0.000538711d },
            { 1396000.0d, 0.000536769d },
            { 1405000.0d, 0.000534772d },
            { 1414000.0d, 0.000532719d },
            { 1423000.0d, 0.00053061d },
            { 1432000.0d, 0.000528446d },
            { 1441000.0d, 0.000526227d },
            { 1450000.0d, 0.000523955d },
            { 1459000.0d, 0.000521628d },
            { 1468000.0d, 0.000519249d },
            { 1477000.0d, 0.000516816d },
            { 1486000.0d, 0.000514332d },
            { 1495000.0d, 0.000511795d },
            { 1504000.0d, 0.000509206d },
            { 1513000.0d, 0.000506568d },
            { 1522000.0d, 0.000503879d },
            { 1531000.0d, 0.00050114d },
            { 1540000.0d, 0.000498353d },
            { 1549000.0d, 0.000495517d },
            { 1558000.0d, 0.000492633d },
            { 1567000.0d, 0.000489701d },
            { 1576000.0d, 0.000486723d },
            { 1585000.0d, 0.000483699d },
            { 1594000.0d, 0.000480628d },
            { 1603000.0d, 0.000477514d },
            { 1612000.0d, 0.000474355d },
            { 1621000.0d, 0.000471152d },
            { 1630000.0d, 0.000467906d },
            { 1639000.0d, 0.000464617d },
            { 1648000.0d, 0.000461288d },
            { 1657000.0d, 0.000457917d },
            { 1666000.0d, 0.000454506d },
            { 1675000.0d, 0.000451055d },
            { 1684000.0d, 0.000447565d },
            { 1693000.0d, 0.000444038d },
            { 1702000.0d, 0.000440473d },
            { 1711000.0d, 0.000436871d },
            { 1720000.0d, 0.000433232d },
            { 1729000.0d, 0.00042956d },
            { 1738000.0d, 0.000425852d },
            { 1747000.0d, 0.000422111d },
            { 1756000.0d, 0.000418336d },
            { 1765000.0d, 0.00041453d },
            { 1774000.0d, 0.000410692d },
            { 1783000.0d, 0.000406824d },
            { 1792000.0d, 0.000402927d },
            { 1801000.0d, 0.000399d },
            { 1810000.0d, 0.000395045d },
            { 1819000.0d, 0.000391063d },
            { 1828000.0d, 0.000387054d },
            { 1837000.0d, 0.000383021d },
            { 1846000.0d, 0.000378962d },
            { 1855000.0d, 0.00037488d },
            { 1864000.0d, 0.000370775d },
            { 1873000.0d, 0.000366648d },
            { 1882000.0d, 0.0003625d },
            { 1891000.0d, 0.000358332d },
            { 1900000.0d, 0.000354145d },
            { 1909000.0d, 0.000349938d },
            { 1918000.0d, 0.000345715d },
            { 1927000.0d, 0.000341475d },
            { 1936000.0d, 0.000337221d },
            { 1945000.0d, 0.000332951d },
            { 1954000.0d, 0.000328669d },
            { 1963000.0d, 0.000324373d },
            { 1972000.0d, 0.000320066d },
            { 1981000.0d, 0.000315748d },
            { 1990000.0d, 0.000311421d },
            { 1999000.0d, 0.000307085d },
            { 2008000.0d, 0.000302741d },
            { 2017000.0d, 0.000298392d },
            { 2026000.0d, 0.000294037d },
            { 2035000.0d, 0.000289677d },
            { 2044000.0d, 0.000285314d },
            { 2053000.0d, 0.000280949d },
            { 2062000.0d, 0.000276583d },
            { 2071000.0d, 0.000272216d },
            { 2080000.0d, 0.00026785d },
            { 2089000.0d, 0.000263487d },
            { 2098000.0d, 0.000259127d },
            { 2107000.0d, 0.000254771d },
            { 2116000.0d, 0.00025042d },
            { 2125000.0d, 0.000246076d },
            { 2134000.0d, 0.000241739d },
            { 2143000.0d, 0.000237411d },
            { 2152000.0d, 0.000233094d },
            { 2161000.0d, 0.000228788d },
            { 2170000.0d, 0.000224493d },
            { 2179000.0d, 0.000220212d },
            { 2188000.0d, 0.000215945d },
            { 2197000.0d, 0.000211696d },
            { 2206000.0d, 0.000207462d },
            { 2215000.0d, 0.000203247d },
            { 2224000.0d, 0.000199051d },
            { 2233000.0d, 0.000194875d },
            { 2242000.0d, 0.000190719d },
            { 2251000.0d, 0.000186576d },
            { 2260000.0d, 0.000182448d },
            { 2269000.0d, 0.000178335d },
            { 2278000.0d, 0.000174239d },
            { 2287000.0d, 0.000170159d },
            { 2296000.0d, 0.000166099d },
            { 2305000.0d, 0.000162057d },
            { 2314000.0d, 0.000158037d },
            { 2323000.0d, 0.000154039d },
            { 2332000.0d, 0.000150065d },
            { 2341000.0d, 0.000146113d },
            { 2350000.0d, 0.000142188d },
            { 2359000.0d, 0.000138289d },
            { 2368000.0d, 0.000134417d },
            { 2377000.0d, 0.000130576d },
            { 2386000.0d, 0.000126763d },
            { 2395000.0d, 0.000122981d },
            { 2404000.0d, 0.000119232d },
            { 2413000.0d, 0.000115517d },
            { 2422000.0d, 0.000111836d },
            { 2431000.0d, 0.000108191d },
            { 2440000.0d, 0.000104583d },
            { 2449000.0d, 0.000101014d },
            { 2458000.0d, 0.0000974844d },
            { 2467000.0d, 0.0000939955d },
            { 2476000.0d, 0.0000905486d },
            { 2485000.0d, 0.000087145d },
            { 2494000.0d, 0.0000837859d },
            { 2503000.0d, 0.0000804726d },
            { 2512000.0d, 0.0000772064d },
            { 2521000.0d, 0.0000739884d },
            { 2530000.0d, 0.00007082d },
            { 2539000.0d, 0.0000677024d },
            { 2548000.0d, 0.000064637d },
            { 2557000.0d, 0.000061625d },
            { 2566000.0d, 0.0000586678d },
            { 2575000.0d, 0.0000557666d },
            { 2584000.0d, 0.0000529226d },
            { 2593000.0d, 0.0000501374d },
            { 2602000.0d, 0.0000474121d },
            { 2611000.0d, 0.0000447481d },
            { 2620000.0d, 0.0000421467d },
            { 2629000.0d, 0.0000396093d },
            { 2638000.0d, 0.0000371372d },
            { 2647000.0d, 0.0000347317d },
            { 2656000.0d, 0.0000323942d },
            { 2665000.0d, 0.0000301261d },
            { 2674000.0d, 0.0000279286d },
            { 2683000.0d, 0.0000258033d },
            { 2692000.0d, 0.0000237514d },
            { 2701000.0d, 0.0000217743d },
            { 2710000.0d, 0.0000198734d },
            { 2719000.0d, 0.0000180502d },
            { 2728000.0d, 0.0000163059d },
            { 2737000.0d, 0.000014642d },
            { 2746000.0d, 0.0000130598d },
            { 2755000.0d, 0.0000115608d },
            { 2764000.0d, 0.0000101464d },
            { 2773000.0d, 0.00000881792d },
            { 2782000.0d, 0.00000757683d },
            { 2791000.0d, 0.00000642452d },
            { 2800000.0d, 0.00000536239d },
            { 2809000.0d, 0.00000439184d },
            { 2818000.0d, 0.00000351428d },
            { 2827000.0d, 0.0000027311d },
            { 2836000.0d, 0.00000204369d },
            { 2845000.0d, 0.00000145342d },
            { 2854000.0d, 0.00000096166d },
            { 2863000.0d, 0.000000569736d },
            { 2872000.0d, 0.000000278938d },
            { 2881000.0d, 0.0000000904698d },
            { 2890000.0d, 0.00000000533463d },
            { 2892900.0d, 0d },

        }; 
    }
}
    