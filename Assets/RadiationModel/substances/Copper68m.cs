using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper68m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper68m";
        public override double halfLife { get; } = 225.0d;
        public override double atomicWeight { get; } = 67.93039d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.86d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copper68()), new(0.82d, new GammaParticle(84120.0, 0.01474)), new(0.166d, new GammaParticle(110740.0, 0.0112)), new(0.748d, new GammaParticle(526440.0, 0.00236)), new(0.0037d, new GammaParticle(610300.0, 0.00203)), new(0.107d, new GammaParticle(637140.0, 0.00195)), new(0.00851058228528897d, new GammaParticle(952.0, 1.30236)), new(0.07841189797858586d, new GammaParticle(8028.0, 0.15444)), new(0.15276037011218752d, new GammaParticle(8048.0, 0.15406)), new(0.03215606249142658d, new GammaParticle(8940.0, 0.13868)), new(0.03215606249142658d, new GammaParticle(8940.0, 0.13868)) } },
            { 0.14d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc68()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.054000000000000006d, new GammaParticle(151600.0, 0.00818)), new(0.0058d, new GammaParticle(585600.0, 0.00212)), new(0.0060999999999999995d, new GammaParticle(670700.0, 0.00185)), new(0.009000000000000001d, new GammaParticle(1014500.0, 0.00122)), new(0.09300000000000001d, new GammaParticle(1041000.0, 0.00119)), new(0.14d, new GammaParticle(1077700.0, 0.00115)), new(0.0029d, new GammaParticle(1149400.0, 0.00108)), new(0.008d, new GammaParticle(1222200.0, 0.00101)), new(0.0029d, new GammaParticle(1261800.0, 0.00098)), new(0.006d, new GammaParticle(1292900.0, 0.00096)), new(0.12d, new GammaParticle(1340500.0, 0.00092)), new(0.0033d, new GammaParticle(1385800.0, 0.00089)), new(0.008d, new GammaParticle(1432800.0, 0.00087)), new(0.008d, new GammaParticle(1540700.0, 0.0008)), new(0.0033d, new GammaParticle(1743700.0, 0.00071)), new(0.00032d, new GammaParticle(2339500.0, 0.00053)), new(1.62396821653776e-05d, new GammaParticle(1035.0, 1.19791)), new(0.00015204651590615374d, new GammaParticle(8616.0, 0.1439)), new(0.0002956952856984709d, new GammaParticle(8639.0, 0.14352)), new(6.344501328737532e-05d, new GammaParticle(9610.0, 0.12902)), new(6.344501328737532e-05d, new GammaParticle(9610.0, 0.12902)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000708159d },
            { 3000.0d, 0.0000712671d },
            { 6000.0d, 0.0000717274d },
            { 9000.0d, 0.0000721968d },
            { 12000.0d, 0.0000726787d },
            { 15000.0d, 0.0000731799d },
            { 18000.0d, 0.0000737188d },
            { 21000.0d, 0.0000742902d },
            { 24000.0d, 0.0000748913d },
            { 27000.0d, 0.0000755174d },
            { 30000.0d, 0.0000761644d },
            { 33000.0d, 0.0000768273d },
            { 36000.0d, 0.0000775055d },
            { 39000.0d, 0.0000781937d },
            { 42000.0d, 0.0000788911d },
            { 45000.0d, 0.0000795963d },
            { 48000.0d, 0.0000803058d },
            { 51000.0d, 0.0000810203d },
            { 54000.0d, 0.0000817379d },
            { 57000.0d, 0.0000824576d },
            { 60000.0d, 0.0000831787d },
            { 63000.0d, 0.0000839004d },
            { 66000.0d, 0.0000846224d },
            { 69000.0d, 0.0000853439d },
            { 72000.0d, 0.0000860649d },
            { 75000.0d, 0.0000867845d },
            { 78000.0d, 0.0000875025d },
            { 81000.0d, 0.0000882189d },
            { 84000.0d, 0.0000889332d },
            { 87000.0d, 0.0000896452d },
            { 90000.0d, 0.000090355d },
            { 93000.0d, 0.0000910619d },
            { 96000.0d, 0.000091766d },
            { 99000.0d, 0.0000924672d },
            { 102000.0d, 0.0000931653d },
            { 111000.0d, 0.0000952402d },
            { 120000.0d, 0.0000972839d },
            { 129000.0d, 0.0000992944d },
            { 138000.0d, 0.00010127d },
            { 147000.0d, 0.00010321d },
            { 156000.0d, 0.000105112d },
            { 165000.0d, 0.000106976d },
            { 174000.0d, 0.000108801d },
            { 183000.0d, 0.000110586d },
            { 192000.0d, 0.000112331d },
            { 201000.0d, 0.000114035d },
            { 210000.0d, 0.000115698d },
            { 219000.0d, 0.000117318d },
            { 228000.0d, 0.000118896d },
            { 237000.0d, 0.00012043d },
            { 246000.0d, 0.000121921d },
            { 255000.0d, 0.000123368d },
            { 264000.0d, 0.00012477d },
            { 273000.0d, 0.000126128d },
            { 282000.0d, 0.000127441d },
            { 291000.0d, 0.000128708d },
            { 300000.0d, 0.000129929d },
            { 309000.0d, 0.000131104d },
            { 318000.0d, 0.000132233d },
            { 327000.0d, 0.000133314d },
            { 336000.0d, 0.000134349d },
            { 345000.0d, 0.000135337d },
            { 354000.0d, 0.000136278d },
            { 363000.0d, 0.000137171d },
            { 372000.0d, 0.000138015d },
            { 381000.0d, 0.000138813d },
            { 390000.0d, 0.000139562d },
            { 399000.0d, 0.000140263d },
            { 408000.0d, 0.000140916d },
            { 417000.0d, 0.000141521d },
            { 426000.0d, 0.000142077d },
            { 435000.0d, 0.000142585d },
            { 444000.0d, 0.000143044d },
            { 453000.0d, 0.000143456d },
            { 462000.0d, 0.000143819d },
            { 471000.0d, 0.000144134d },
            { 480000.0d, 0.0001444d },
            { 489000.0d, 0.000144619d },
            { 498000.0d, 0.00014479d },
            { 507000.0d, 0.000144913d },
            { 516000.0d, 0.000144988d },
            { 525000.0d, 0.000145016d },
            { 534000.0d, 0.000144996d },
            { 543000.0d, 0.00014493d },
            { 552000.0d, 0.000144817d },
            { 561000.0d, 0.000144657d },
            { 570000.0d, 0.000144452d },
            { 579000.0d, 0.0001442d },
            { 588000.0d, 0.000143902d },
            { 597000.0d, 0.00014356d },
            { 606000.0d, 0.000143173d },
            { 615000.0d, 0.000142741d },
            { 624000.0d, 0.000142265d },
            { 633000.0d, 0.000141746d },
            { 642000.0d, 0.000141183d },
            { 651000.0d, 0.000140578d },
            { 660000.0d, 0.000139931d },
            { 669000.0d, 0.000139242d },
            { 678000.0d, 0.000138512d },
            { 687000.0d, 0.000137741d },
            { 696000.0d, 0.000136931d },
            { 705000.0d, 0.000136081d },
            { 714000.0d, 0.000135192d },
            { 723000.0d, 0.000134265d },
            { 732000.0d, 0.000133301d },
            { 741000.0d, 0.0001323d },
            { 750000.0d, 0.000131263d },
            { 759000.0d, 0.000130191d },
            { 768000.0d, 0.000129084d },
            { 777000.0d, 0.000127943d },
            { 786000.0d, 0.000126769d },
            { 795000.0d, 0.000125563d },
            { 804000.0d, 0.000124326d },
            { 813000.0d, 0.000123058d },
            { 822000.0d, 0.00012176d },
            { 831000.0d, 0.000120434d },
            { 840000.0d, 0.000119079d },
            { 849000.0d, 0.000117698d },
            { 858000.0d, 0.000116291d },
            { 867000.0d, 0.000114858d },
            { 876000.0d, 0.000113402d },
            { 885000.0d, 0.000111922d },
            { 894000.0d, 0.000110421d },
            { 903000.0d, 0.000108898d },
            { 912000.0d, 0.000107356d },
            { 921000.0d, 0.000105795d },
            { 930000.0d, 0.000104216d },
            { 939000.0d, 0.00010262d },
            { 948000.0d, 0.000101009d },
            { 957000.0d, 0.0000993838d },
            { 966000.0d, 0.0000977455d },
            { 975000.0d, 0.0000960951d },
            { 984000.0d, 0.0000944342d },
            { 993000.0d, 0.0000927637d },
            { 1002000.0d, 0.0000910851d },
            { 1011000.0d, 0.0000893997d },
            { 1020000.0d, 0.0000877086d },
            { 1029000.0d, 0.0000860134d },
            { 1038000.0d, 0.0000843151d },
            { 1047000.0d, 0.0000826154d },
            { 1056000.0d, 0.0000809153d },
            { 1065000.0d, 0.0000792166d },
            { 1074000.0d, 0.0000775204d },
            { 1083000.0d, 0.0000758284d },
            { 1092000.0d, 0.0000741418d },
            { 1101000.0d, 0.0000724622d },
            { 1110000.0d, 0.000070791d },
            { 1119000.0d, 0.0000691299d },
            { 1128000.0d, 0.0000674802d },
            { 1137000.0d, 0.0000658436d },
            { 1146000.0d, 0.0000642216d },
            { 1155000.0d, 0.0000626158d },
            { 1164000.0d, 0.0000610277d },
            { 1173000.0d, 0.0000594591d },
            { 1182000.0d, 0.0000579115d },
            { 1191000.0d, 0.0000563864d },
            { 1200000.0d, 0.0000548751d },
            { 1209000.0d, 0.0000533725d },
            { 1218000.0d, 0.0000518795d },
            { 1227000.0d, 0.0000503976d },
            { 1236000.0d, 0.0000489275d },
            { 1245000.0d, 0.0000474709d },
            { 1254000.0d, 0.0000460288d },
            { 1263000.0d, 0.0000446026d },
            { 1272000.0d, 0.0000431932d },
            { 1281000.0d, 0.0000418022d },
            { 1290000.0d, 0.000040431d },
            { 1299000.0d, 0.0000390806d },
            { 1308000.0d, 0.0000377525d },
            { 1317000.0d, 0.0000364478d },
            { 1326000.0d, 0.000035168d },
            { 1335000.0d, 0.0000339146d },
            { 1344000.0d, 0.0000326889d },
            { 1353000.0d, 0.0000314921d },
            { 1362000.0d, 0.0000303256d },
            { 1371000.0d, 0.0000291909d },
            { 1380000.0d, 0.0000280895d },
            { 1389000.0d, 0.0000270227d },
            { 1398000.0d, 0.000025992d },
            { 1407000.0d, 0.0000249988d },
            { 1416000.0d, 0.0000240446d },
            { 1425000.0d, 0.0000231307d },
            { 1434000.0d, 0.0000222573d },
            { 1443000.0d, 0.0000214198d },
            { 1452000.0d, 0.0000206172d },
            { 1461000.0d, 0.0000198507d },
            { 1470000.0d, 0.0000191215d },
            { 1479000.0d, 0.0000184311d },
            { 1488000.0d, 0.0000177805d },
            { 1497000.0d, 0.0000171712d },
            { 1506000.0d, 0.0000166045d },
            { 1515000.0d, 0.0000160815d },
            { 1524000.0d, 0.0000156038d },
            { 1533000.0d, 0.0000151724d },
            { 1542000.0d, 0.0000147887d },
            { 1551000.0d, 0.0000144538d },
            { 1560000.0d, 0.0000141466d },
            { 1569000.0d, 0.0000138512d },
            { 1578000.0d, 0.0000135679d },
            { 1587000.0d, 0.0000132972d },
            { 1596000.0d, 0.0000130396d },
            { 1605000.0d, 0.0000127952d },
            { 1614000.0d, 0.0000125648d },
            { 1623000.0d, 0.0000123486d },
            { 1632000.0d, 0.0000121469d },
            { 1641000.0d, 0.0000119604d },
            { 1650000.0d, 0.0000117894d },
            { 1659000.0d, 0.0000116342d },
            { 1668000.0d, 0.0000114954d },
            { 1677000.0d, 0.0000113732d },
            { 1686000.0d, 0.0000112683d },
            { 1695000.0d, 0.0000111808d },
            { 1704000.0d, 0.0000111107d },
            { 1713000.0d, 0.0000110451d },
            { 1722000.0d, 0.0000109783d },
            { 1731000.0d, 0.0000109103d },
            { 1740000.0d, 0.0000108411d },
            { 1749000.0d, 0.0000107708d },
            { 1758000.0d, 0.0000106993d },
            { 1767000.0d, 0.0000106266d },
            { 1776000.0d, 0.0000105527d },
            { 1785000.0d, 0.0000104776d },
            { 1794000.0d, 0.0000104013d },
            { 1803000.0d, 0.0000103238d },
            { 1812000.0d, 0.0000102451d },
            { 1821000.0d, 0.0000101652d },
            { 1830000.0d, 0.000010084d },
            { 1839000.0d, 0.0000100017d },
            { 1848000.0d, 0.0000099181d },
            { 1857000.0d, 0.00000983328d },
            { 1866000.0d, 0.00000974726d },
            { 1875000.0d, 0.00000966d },
            { 1884000.0d, 0.00000957152d },
            { 1893000.0d, 0.00000948184d },
            { 1902000.0d, 0.00000939093d },
            { 1911000.0d, 0.00000929881d },
            { 1920000.0d, 0.00000920549d },
            { 1929000.0d, 0.00000911096d },
            { 1938000.0d, 0.00000901523d },
            { 1947000.0d, 0.0000089183d },
            { 1956000.0d, 0.0000088202d },
            { 1965000.0d, 0.00000872091d },
            { 1974000.0d, 0.00000862046d },
            { 1983000.0d, 0.00000851885d },
            { 1992000.0d, 0.00000841609d },
            { 2001000.0d, 0.00000831219d },
            { 2010000.0d, 0.00000820718d },
            { 2019000.0d, 0.00000810105d },
            { 2028000.0d, 0.00000799383d },
            { 2037000.0d, 0.00000788552d },
            { 2046000.0d, 0.00000777615d },
            { 2055000.0d, 0.00000766574d },
            { 2064000.0d, 0.0000075543d },
            { 2073000.0d, 0.00000744185d },
            { 2082000.0d, 0.00000732842d },
            { 2091000.0d, 0.00000721404d },
            { 2100000.0d, 0.00000709871d },
            { 2109000.0d, 0.00000698246d },
            { 2118000.0d, 0.00000686533d },
            { 2127000.0d, 0.00000674735d },
            { 2136000.0d, 0.00000662853d },
            { 2145000.0d, 0.00000650891d },
            { 2154000.0d, 0.00000638853d },
            { 2163000.0d, 0.00000626742d },
            { 2172000.0d, 0.00000614561d },
            { 2181000.0d, 0.00000602315d },
            { 2190000.0d, 0.00000590005d },
            { 2199000.0d, 0.00000577637d },
            { 2208000.0d, 0.00000565216d },
            { 2217000.0d, 0.00000552745d },
            { 2226000.0d, 0.00000540228d },
            { 2235000.0d, 0.0000052767d },
            { 2244000.0d, 0.00000515077d },
            { 2253000.0d, 0.00000502453d },
            { 2262000.0d, 0.00000489803d },
            { 2271000.0d, 0.00000477133d },
            { 2280000.0d, 0.00000464449d },
            { 2289000.0d, 0.00000451755d },
            { 2298000.0d, 0.00000439058d },
            { 2307000.0d, 0.00000426365d },
            { 2316000.0d, 0.00000413681d },
            { 2325000.0d, 0.00000401013d },
            { 2334000.0d, 0.00000388368d },
            { 2343000.0d, 0.00000375753d },
            { 2352000.0d, 0.00000363175d },
            { 2361000.0d, 0.00000350642d },
            { 2370000.0d, 0.0000033816d },
            { 2379000.0d, 0.00000325739d },
            { 2388000.0d, 0.00000313386d },
            { 2397000.0d, 0.00000301109d },
            { 2406000.0d, 0.00000288916d },
            { 2415000.0d, 0.00000276819d },
            { 2424000.0d, 0.00000264823d },
            { 2433000.0d, 0.00000252941d },
            { 2442000.0d, 0.00000241179d },
            { 2451000.0d, 0.00000229549d },
            { 2460000.0d, 0.0000021806d },
            { 2469000.0d, 0.00000206724d },
            { 2478000.0d, 0.0000019555d },
            { 2487000.0d, 0.0000018455d },
            { 2496000.0d, 0.00000173733d },
            { 2505000.0d, 0.00000163113d },
            { 2514000.0d, 0.00000152701d },
            { 2523000.0d, 0.00000142508d },
            { 2532000.0d, 0.00000132547d },
            { 2541000.0d, 0.0000012283d },
            { 2550000.0d, 0.00000113371d },
            { 2559000.0d, 0.00000104181d },
            { 2568000.0d, 0.000000952758d },
            { 2577000.0d, 0.000000866679d },
            { 2586000.0d, 0.000000783715d },
            { 2595000.0d, 0.000000704009d },
            { 2604000.0d, 0.000000627708d },
            { 2613000.0d, 0.000000554961d },
            { 2622000.0d, 0.000000485921d },
            { 2631000.0d, 0.000000420744d },
            { 2640000.0d, 0.000000359588d },
            { 2649000.0d, 0.000000302615d },
            { 2658000.0d, 0.000000249991d },
            { 2667000.0d, 0.000000201881d },
            { 2676000.0d, 0.00000015846d },
            { 2685000.0d, 0.000000119898d },
            { 2694000.0d, 0.0000000863725d },
            { 2703000.0d, 0.0000000580624d },
            { 2712000.0d, 0.0000000351477d },
            { 2721000.0d, 0.0000000178097d },
            { 2730000.0d, 0.00000000622838d },
            { 2739000.0d, 0.000000000573553d },
            { 2742900.0d, 0d },

        }; 
    }
}
    