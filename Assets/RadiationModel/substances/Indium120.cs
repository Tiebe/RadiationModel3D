using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium120";
        public override double halfLife { get; } = 3.08d;
        public override double atomicWeight { get; } = 119.90797d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin120()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.79d, new GammaParticle(89870.0, 0.0138)), new(0.81d, new GammaParticle(197360.0, 0.00628)), new(0.0019d, new GammaParticle(251500.0, 0.00493)), new(0.125d, new GammaParticle(268080.0, 0.00462)), new(0.125d, new GammaParticle(354880.0, 0.00349)), new(0.07d, new GammaParticle(465380.0, 0.00266)), new(0.132d, new GammaParticle(609960.0, 0.00203)), new(0.19699999999999998d, new GammaParticle(696750.0, 0.00178)), new(0.01425d, new GammaParticle(704200.0, 0.00176)), new(0.01d, new GammaParticle(808400.0, 0.00153)), new(0.613d, new GammaParticle(964860.0, 0.00128)), new(0.00133d, new GammaParticle(990000.0, 0.00125)), new(0.99d, new GammaParticle(1023020.0, 0.00121)), new(0.01d, new GammaParticle(1112700.0, 0.00111)), new(0.084d, new GammaParticle(1162780.0, 0.00107)), new(1.0d, new GammaParticle(1171220.0, 0.00106)), new(0.19d, new GammaParticle(1172500.0, 0.00106)), new(0.00912d, new GammaParticle(1185800.0, 0.00105)), new(0.005889999999999999d, new GammaParticle(1207500.0, 0.00103)), new(0.00228d, new GammaParticle(1250800.0, 0.00099)), new(0.01862d, new GammaParticle(2039800.0, 0.00061)), new(0.00418d, new GammaParticle(2098300.0, 0.00059)), new(0.00095d, new GammaParticle(2149200.0, 0.00058)), new(0.011399999999999999d, new GammaParticle(2390200.0, 0.00052)), new(0.021693038639200003d, new GammaParticle(3753.0, 0.33036)), new(0.06655361390398157d, new GammaParticle(25044.0, 0.04951)), new(0.12456225697919064d, new GammaParticle(25271.0, 0.04906)), new(0.03522152140085864d, new GammaParticle(28579.0, 0.04338)), new(0.04216016111682779d, new GammaParticle(28810.0, 0.04304)), new(0.006938639715969153d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000445168d },
            { 5000.0d, 0.000450933d },
            { 10000.0d, 0.000456429d },
            { 15000.0d, 0.000461657d },
            { 20000.0d, 0.000466703d },
            { 25000.0d, 0.000471698d },
            { 30000.0d, 0.000476678d },
            { 35000.0d, 0.000481676d },
            { 40000.0d, 0.000486702d },
            { 45000.0d, 0.000491763d },
            { 50000.0d, 0.00049686d },
            { 55000.0d, 0.000501993d },
            { 60000.0d, 0.000507157d },
            { 65000.0d, 0.000512349d },
            { 70000.0d, 0.000517564d },
            { 75000.0d, 0.000522797d },
            { 80000.0d, 0.000528045d },
            { 85000.0d, 0.000533303d },
            { 90000.0d, 0.000538567d },
            { 95000.0d, 0.000543833d },
            { 100000.0d, 0.000549098d },
            { 109000.0d, 0.000558565d },
            { 118000.0d, 0.000568003d },
            { 127000.0d, 0.000577398d },
            { 136000.0d, 0.000586738d },
            { 145000.0d, 0.000596014d },
            { 154000.0d, 0.000605214d },
            { 163000.0d, 0.000614332d },
            { 172000.0d, 0.000623358d },
            { 181000.0d, 0.000632289d },
            { 190000.0d, 0.000641116d },
            { 199000.0d, 0.000649835d },
            { 208000.0d, 0.000658441d },
            { 217000.0d, 0.00066693d },
            { 226000.0d, 0.000675296d },
            { 235000.0d, 0.000683536d },
            { 244000.0d, 0.000691646d },
            { 253000.0d, 0.000699623d },
            { 262000.0d, 0.000707465d },
            { 271000.0d, 0.000715167d },
            { 280000.0d, 0.000722728d },
            { 289000.0d, 0.000730144d },
            { 298000.0d, 0.000737413d },
            { 307000.0d, 0.000744532d },
            { 316000.0d, 0.000751499d },
            { 325000.0d, 0.000758314d },
            { 334000.0d, 0.000764972d },
            { 343000.0d, 0.000771472d },
            { 352000.0d, 0.000777814d },
            { 361000.0d, 0.000783994d },
            { 370000.0d, 0.000790011d },
            { 379000.0d, 0.000795863d },
            { 388000.0d, 0.00080155d },
            { 397000.0d, 0.00080707d },
            { 406000.0d, 0.000812421d },
            { 415000.0d, 0.000817602d },
            { 424000.0d, 0.000822612d },
            { 433000.0d, 0.00082745d },
            { 442000.0d, 0.000832116d },
            { 451000.0d, 0.000836606d },
            { 460000.0d, 0.000840922d },
            { 469000.0d, 0.000845062d },
            { 478000.0d, 0.000849024d },
            { 487000.0d, 0.00085281d },
            { 496000.0d, 0.000856418d },
            { 505000.0d, 0.000859846d },
            { 514000.0d, 0.000863095d },
            { 523000.0d, 0.000866164d },
            { 532000.0d, 0.000869052d },
            { 541000.0d, 0.00087176d },
            { 550000.0d, 0.000874286d },
            { 559000.0d, 0.000876632d },
            { 568000.0d, 0.000878794d },
            { 577000.0d, 0.000880774d },
            { 586000.0d, 0.000882572d },
            { 595000.0d, 0.000884188d },
            { 604000.0d, 0.000885621d },
            { 613000.0d, 0.000886871d },
            { 622000.0d, 0.000887939d },
            { 631000.0d, 0.000888824d },
            { 640000.0d, 0.000889526d },
            { 649000.0d, 0.000890046d },
            { 658000.0d, 0.000890383d },
            { 667000.0d, 0.000890538d },
            { 676000.0d, 0.000890512d },
            { 685000.0d, 0.000890304d },
            { 694000.0d, 0.000889915d },
            { 703000.0d, 0.000889345d },
            { 712000.0d, 0.000888594d },
            { 721000.0d, 0.000887663d },
            { 730000.0d, 0.000886554d },
            { 739000.0d, 0.000885265d },
            { 748000.0d, 0.000883798d },
            { 757000.0d, 0.000882154d },
            { 766000.0d, 0.000880332d },
            { 775000.0d, 0.000878334d },
            { 784000.0d, 0.000876161d },
            { 793000.0d, 0.000873814d },
            { 802000.0d, 0.000871291d },
            { 811000.0d, 0.000868597d },
            { 820000.0d, 0.000865731d },
            { 829000.0d, 0.000862693d },
            { 838000.0d, 0.000859487d },
            { 847000.0d, 0.000856111d },
            { 856000.0d, 0.000852567d },
            { 865000.0d, 0.000848856d },
            { 874000.0d, 0.000844981d },
            { 883000.0d, 0.000840941d },
            { 892000.0d, 0.000836738d },
            { 901000.0d, 0.000832374d },
            { 910000.0d, 0.00082785d },
            { 919000.0d, 0.000823167d },
            { 928000.0d, 0.000818328d },
            { 937000.0d, 0.000813332d },
            { 946000.0d, 0.000808183d },
            { 955000.0d, 0.000802881d },
            { 964000.0d, 0.000797428d },
            { 973000.0d, 0.000791827d },
            { 982000.0d, 0.000786078d },
            { 991000.0d, 0.000780184d },
            { 1000000.0d, 0.000774146d },
            { 1009000.0d, 0.000767966d },
            { 1018000.0d, 0.000761647d },
            { 1027000.0d, 0.00075519d },
            { 1036000.0d, 0.000748597d },
            { 1045000.0d, 0.000741872d },
            { 1054000.0d, 0.000735015d },
            { 1063000.0d, 0.000728029d },
            { 1072000.0d, 0.000720915d },
            { 1081000.0d, 0.000713678d },
            { 1090000.0d, 0.000706318d },
            { 1099000.0d, 0.000698838d },
            { 1108000.0d, 0.000691242d },
            { 1117000.0d, 0.000683531d },
            { 1126000.0d, 0.000675708d },
            { 1135000.0d, 0.000667776d },
            { 1144000.0d, 0.000659737d },
            { 1153000.0d, 0.000651594d },
            { 1162000.0d, 0.000643351d },
            { 1171000.0d, 0.00063501d },
            { 1180000.0d, 0.000626573d },
            { 1189000.0d, 0.000618044d },
            { 1198000.0d, 0.000609427d },
            { 1207000.0d, 0.000600724d },
            { 1216000.0d, 0.000591939d },
            { 1225000.0d, 0.000583073d },
            { 1234000.0d, 0.000574133d },
            { 1243000.0d, 0.00056512d },
            { 1252000.0d, 0.000556039d },
            { 1261000.0d, 0.000546891d },
            { 1270000.0d, 0.000537682d },
            { 1279000.0d, 0.000528416d },
            { 1288000.0d, 0.000519094d },
            { 1297000.0d, 0.000509722d },
            { 1306000.0d, 0.000500305d },
            { 1315000.0d, 0.000490844d },
            { 1324000.0d, 0.000481345d },
            { 1333000.0d, 0.000471812d },
            { 1342000.0d, 0.000462249d },
            { 1351000.0d, 0.00045266d },
            { 1360000.0d, 0.000443049d },
            { 1369000.0d, 0.000433422d },
            { 1378000.0d, 0.000423783d },
            { 1387000.0d, 0.000414135d },
            { 1396000.0d, 0.000404485d },
            { 1405000.0d, 0.000394836d },
            { 1414000.0d, 0.000385194d },
            { 1423000.0d, 0.000375564d },
            { 1432000.0d, 0.000365949d },
            { 1441000.0d, 0.000356358d },
            { 1450000.0d, 0.000346792d },
            { 1459000.0d, 0.00033726d },
            { 1468000.0d, 0.000327764d },
            { 1477000.0d, 0.000318312d },
            { 1486000.0d, 0.000308908d },
            { 1495000.0d, 0.000299559d },
            { 1504000.0d, 0.000290271d },
            { 1513000.0d, 0.000281048d },
            { 1522000.0d, 0.000271897d },
            { 1531000.0d, 0.000262825d },
            { 1540000.0d, 0.000253836d },
            { 1549000.0d, 0.000244939d },
            { 1558000.0d, 0.000236138d },
            { 1567000.0d, 0.00022744d },
            { 1576000.0d, 0.000218852d },
            { 1585000.0d, 0.000210381d },
            { 1594000.0d, 0.000202034d },
            { 1603000.0d, 0.000193816d },
            { 1612000.0d, 0.000185737d },
            { 1621000.0d, 0.0001778d },
            { 1630000.0d, 0.000170016d },
            { 1639000.0d, 0.000162391d },
            { 1648000.0d, 0.000154933d },
            { 1657000.0d, 0.000147647d },
            { 1666000.0d, 0.000140544d },
            { 1675000.0d, 0.00013363d },
            { 1684000.0d, 0.000126913d },
            { 1693000.0d, 0.000120401d },
            { 1702000.0d, 0.000114102d },
            { 1711000.0d, 0.000108025d },
            { 1720000.0d, 0.000102177d },
            { 1729000.0d, 0.000096563d },
            { 1738000.0d, 0.0000911419d },
            { 1747000.0d, 0.0000859046d },
            { 1756000.0d, 0.0000808565d },
            { 1765000.0d, 0.000076003d },
            { 1774000.0d, 0.0000713497d },
            { 1783000.0d, 0.0000669019d },
            { 1792000.0d, 0.0000626656d },
            { 1801000.0d, 0.000058646d },
            { 1810000.0d, 0.0000548489d },
            { 1819000.0d, 0.0000512799d },
            { 1828000.0d, 0.0000479446d },
            { 1837000.0d, 0.0000448489d },
            { 1846000.0d, 0.0000419984d },
            { 1855000.0d, 0.0000393985d },
            { 1864000.0d, 0.0000370554d },
            { 1873000.0d, 0.0000349745d },
            { 1882000.0d, 0.0000331617d },
            { 1891000.0d, 0.0000316225d },
            { 1900000.0d, 0.0000303626d },
            { 1909000.0d, 0.0000293875d },
            { 1918000.0d, 0.0000287024d },
            { 1927000.0d, 0.0000282945d },
            { 1936000.0d, 0.0000279509d },
            { 1945000.0d, 0.0000276057d },
            { 1954000.0d, 0.0000272592d },
            { 1963000.0d, 0.0000269113d },
            { 1972000.0d, 0.000026562d },
            { 1981000.0d, 0.0000262115d },
            { 1990000.0d, 0.0000258599d },
            { 1999000.0d, 0.0000255072d },
            { 2008000.0d, 0.0000251535d },
            { 2017000.0d, 0.0000247988d },
            { 2026000.0d, 0.0000244433d },
            { 2035000.0d, 0.0000240871d },
            { 2044000.0d, 0.0000237301d },
            { 2053000.0d, 0.0000233724d },
            { 2062000.0d, 0.0000230143d },
            { 2071000.0d, 0.0000226557d },
            { 2080000.0d, 0.0000222967d },
            { 2089000.0d, 0.0000219375d },
            { 2098000.0d, 0.000021578d },
            { 2107000.0d, 0.0000212183d },
            { 2116000.0d, 0.0000208586d },
            { 2125000.0d, 0.0000204989d },
            { 2134000.0d, 0.0000201394d },
            { 2143000.0d, 0.00001978d },
            { 2152000.0d, 0.0000194208d },
            { 2161000.0d, 0.0000190621d },
            { 2170000.0d, 0.0000187038d },
            { 2179000.0d, 0.0000183461d },
            { 2188000.0d, 0.000017989d },
            { 2197000.0d, 0.0000176325d },
            { 2206000.0d, 0.0000172769d },
            { 2215000.0d, 0.0000169222d },
            { 2224000.0d, 0.0000165685d },
            { 2233000.0d, 0.0000162158d },
            { 2242000.0d, 0.0000158642d },
            { 2251000.0d, 0.0000155139d },
            { 2260000.0d, 0.000015165d },
            { 2269000.0d, 0.0000148175d },
            { 2278000.0d, 0.0000144716d },
            { 2287000.0d, 0.0000141272d },
            { 2296000.0d, 0.0000137846d },
            { 2305000.0d, 0.0000134437d },
            { 2314000.0d, 0.0000131049d },
            { 2323000.0d, 0.000012768d },
            { 2332000.0d, 0.0000124331d },
            { 2341000.0d, 0.0000121005d },
            { 2350000.0d, 0.0000117702d },
            { 2359000.0d, 0.0000114423d },
            { 2368000.0d, 0.0000111169d },
            { 2377000.0d, 0.000010794d },
            { 2386000.0d, 0.0000104738d },
            { 2395000.0d, 0.0000101565d },
            { 2404000.0d, 0.00000984199d },
            { 2413000.0d, 0.0000095305d },
            { 2422000.0d, 0.00000922211d },
            { 2431000.0d, 0.00000891691d },
            { 2440000.0d, 0.00000861501d },
            { 2449000.0d, 0.00000831652d },
            { 2458000.0d, 0.00000802153d },
            { 2467000.0d, 0.00000773016d },
            { 2476000.0d, 0.0000074425d },
            { 2485000.0d, 0.00000715866d },
            { 2494000.0d, 0.00000687875d },
            { 2503000.0d, 0.00000660289d },
            { 2512000.0d, 0.00000633117d },
            { 2521000.0d, 0.00000606369d },
            { 2530000.0d, 0.00000580057d },
            { 2539000.0d, 0.00000554189d },
            { 2548000.0d, 0.00000528765d },
            { 2557000.0d, 0.00000503793d },
            { 2566000.0d, 0.00000479285d },
            { 2575000.0d, 0.00000455252d },
            { 2584000.0d, 0.00000431703d },
            { 2593000.0d, 0.00000408651d },
            { 2602000.0d, 0.00000386106d },
            { 2611000.0d, 0.00000364078d },
            { 2620000.0d, 0.00000342579d },
            { 2629000.0d, 0.00000321622d },
            { 2638000.0d, 0.00000301214d },
            { 2647000.0d, 0.0000028137d },
            { 2656000.0d, 0.00000262101d },
            { 2665000.0d, 0.00000243415d },
            { 2674000.0d, 0.00000225327d },
            { 2683000.0d, 0.00000207846d },
            { 2692000.0d, 0.00000190985d },
            { 2701000.0d, 0.00000174753d },
            { 2710000.0d, 0.00000159164d },
            { 2719000.0d, 0.00000144228d },
            { 2728000.0d, 0.00000129958d },
            { 2737000.0d, 0.00000116365d },
            { 2746000.0d, 0.00000103459d },
            { 2755000.0d, 0.000000912533d },
            { 2764000.0d, 0.00000079759d },
            { 2773000.0d, 0.000000689878d },
            { 2782000.0d, 0.000000589513d },
            { 2791000.0d, 0.000000496612d },
            { 2800000.0d, 0.000000411291d },
            { 2809000.0d, 0.000000333666d },
            { 2818000.0d, 0.000000263852d },
            { 2827000.0d, 0.000000201966d },
            { 2836000.0d, 0.000000148122d },
            { 2845000.0d, 0.000000102433d },
            { 2854000.0d, 0.0000000650104d },
            { 2863000.0d, 0.0000000359642d },
            { 2872000.0d, 0.0000000153981d },
            { 2881000.0d, 0.00000000340625d },
            { 2889000.0d, 0d },

        }; 
    }
}
    