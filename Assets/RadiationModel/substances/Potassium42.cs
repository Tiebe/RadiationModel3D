using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium42";
        public override double halfLife { get; } = 44478.0d;
        public override double atomicWeight { get; } = 41.9624d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Calcium42()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00336288d, new GammaParticle(312600.0, 0.00397)), new(3.2544e-05d, new GammaParticle(692000.0, 0.00179)), new(0.00051528d, new GammaParticle(899700.0, 0.00138)), new(0.000200688d, new GammaParticle(1021200.0, 0.00121)), new(2.3503999999999997e-05d, new GammaParticle(1228000.0, 0.00101)), new(0.1808d, new GammaParticle(1524600.0, 0.00081)), new(0.000412224d, new GammaParticle(1920800.0, 0.00065)), new(0.00019888d, new GammaParticle(2424300.0, 0.00051)), new(3.934556484768e-08d, new GammaParticle(358.0, 3.46325)), new(5.24104168470317e-07d, new GammaParticle(3688.0, 0.33618)), new(1.0355743301132525e-06d, new GammaParticle(3692.0, 0.33582)), new(2.021343334164306e-07d, new GammaParticle(4013.0, 0.30896)), new(2.021343334164306e-07d, new GammaParticle(4013.0, 0.30896)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000155679d },
            { 200.0d, 0.000154741d },
            { 400.0d, 0.00015413d },
            { 600.0d, 0.000153847d },
            { 800.0d, 0.000153709d },
            { 1000.0d, 0.000153636d },
            { 1500.0d, 0.000153568d },
            { 2000.0d, 0.00015355d },
            { 2500.0d, 0.000153544d },
            { 3000.0d, 0.000153541d },
            { 3500.0d, 0.000153541d },
            { 4000.0d, 0.000153544d },
            { 4500.0d, 0.000153551d },
            { 5000.0d, 0.000153563d },
            { 5500.0d, 0.00015358d },
            { 6000.0d, 0.000153602d },
            { 6500.0d, 0.00015363d },
            { 7000.0d, 0.000153663d },
            { 7500.0d, 0.000153701d },
            { 8000.0d, 0.000153745d },
            { 8500.0d, 0.000153794d },
            { 9000.0d, 0.000153849d },
            { 9500.0d, 0.000153908d },
            { 10000.0d, 0.000153972d },
            { 11000.0d, 0.000154115d },
            { 12000.0d, 0.000154277d },
            { 13000.0d, 0.000154456d },
            { 14000.0d, 0.000154652d },
            { 15000.0d, 0.000154865d },
            { 16000.0d, 0.000155094d },
            { 17000.0d, 0.000155339d },
            { 18000.0d, 0.000155599d },
            { 19000.0d, 0.000155856d },
            { 20000.0d, 0.000156124d },
            { 21000.0d, 0.000156402d },
            { 22000.0d, 0.000156689d },
            { 23000.0d, 0.000156986d },
            { 24000.0d, 0.000157293d },
            { 25000.0d, 0.000157602d },
            { 26000.0d, 0.000157918d },
            { 27000.0d, 0.000158242d },
            { 28000.0d, 0.000158574d },
            { 29000.0d, 0.000158913d },
            { 30000.0d, 0.00015926d },
            { 31000.0d, 0.000159612d },
            { 32000.0d, 0.00015997d },
            { 33000.0d, 0.000160335d },
            { 34000.0d, 0.000160692d },
            { 35000.0d, 0.000161053d },
            { 36000.0d, 0.000161419d },
            { 37000.0d, 0.000161788d },
            { 38000.0d, 0.000162162d },
            { 39000.0d, 0.00016254d },
            { 40000.0d, 0.000162923d },
            { 41000.0d, 0.000163311d },
            { 42000.0d, 0.000163705d },
            { 43000.0d, 0.000164103d },
            { 44000.0d, 0.000164506d },
            { 45000.0d, 0.000164909d },
            { 46000.0d, 0.000165318d },
            { 47000.0d, 0.000165732d },
            { 48000.0d, 0.000166151d },
            { 49000.0d, 0.000166574d },
            { 50000.0d, 0.000167003d },
            { 51000.0d, 0.000167438d },
            { 52000.0d, 0.000167878d },
            { 53000.0d, 0.000168324d },
            { 54000.0d, 0.000168776d },
            { 55000.0d, 0.000169233d },
            { 56000.0d, 0.000169696d },
            { 57000.0d, 0.000170165d },
            { 58000.0d, 0.00017064d },
            { 59000.0d, 0.000171122d },
            { 60000.0d, 0.000171611d },
            { 61000.0d, 0.000172106d },
            { 62000.0d, 0.000172608d },
            { 63000.0d, 0.000173118d },
            { 64000.0d, 0.000173635d },
            { 65000.0d, 0.000174159d },
            { 66000.0d, 0.000174691d },
            { 67000.0d, 0.000175231d },
            { 68000.0d, 0.000175779d },
            { 69000.0d, 0.000176335d },
            { 70000.0d, 0.000176899d },
            { 71000.0d, 0.000177472d },
            { 72000.0d, 0.000178053d },
            { 73000.0d, 0.000178644d },
            { 74000.0d, 0.000179243d },
            { 75000.0d, 0.000179852d },
            { 76000.0d, 0.00018047d },
            { 77000.0d, 0.000181097d },
            { 78000.0d, 0.000181734d },
            { 79000.0d, 0.000182382d },
            { 80000.0d, 0.000183039d },
            { 81000.0d, 0.000183698d },
            { 82000.0d, 0.000184356d },
            { 83000.0d, 0.000185013d },
            { 84000.0d, 0.000185668d },
            { 85000.0d, 0.000186323d },
            { 86000.0d, 0.000186976d },
            { 87000.0d, 0.000187627d },
            { 88000.0d, 0.000188278d },
            { 89000.0d, 0.000188927d },
            { 90000.0d, 0.000189575d },
            { 91000.0d, 0.000190222d },
            { 92000.0d, 0.000190868d },
            { 93000.0d, 0.000191512d },
            { 94000.0d, 0.000192155d },
            { 95000.0d, 0.000192797d },
            { 96000.0d, 0.000193438d },
            { 97000.0d, 0.000194078d },
            { 98000.0d, 0.000194716d },
            { 99000.0d, 0.000195353d },
            { 100000.0d, 0.000195989d },
            { 110000.0d, 0.000202286d },
            { 120000.0d, 0.000208471d },
            { 130000.0d, 0.00021455d },
            { 140000.0d, 0.000220527d },
            { 150000.0d, 0.000226406d },
            { 160000.0d, 0.00023219d },
            { 170000.0d, 0.000237882d },
            { 180000.0d, 0.000243485d },
            { 190000.0d, 0.000249d },
            { 200000.0d, 0.00025443d },
            { 210000.0d, 0.000259776d },
            { 220000.0d, 0.000265039d },
            { 230000.0d, 0.000270221d },
            { 240000.0d, 0.000275321d },
            { 250000.0d, 0.000280341d },
            { 260000.0d, 0.000285282d },
            { 270000.0d, 0.000290144d },
            { 280000.0d, 0.000294927d },
            { 290000.0d, 0.000299633d },
            { 300000.0d, 0.000304261d },
            { 310000.0d, 0.000308812d },
            { 320000.0d, 0.000313286d },
            { 330000.0d, 0.000317683d },
            { 340000.0d, 0.000322003d },
            { 350000.0d, 0.000326247d },
            { 360000.0d, 0.000330414d },
            { 370000.0d, 0.000334507d },
            { 380000.0d, 0.000338522d },
            { 390000.0d, 0.000342462d },
            { 400000.0d, 0.000346326d },
            { 410000.0d, 0.000350113d },
            { 420000.0d, 0.000353826d },
            { 430000.0d, 0.000357463d },
            { 440000.0d, 0.000361026d },
            { 450000.0d, 0.000364512d },
            { 460000.0d, 0.000367924d },
            { 470000.0d, 0.000371261d },
            { 480000.0d, 0.000374524d },
            { 490000.0d, 0.000377712d },
            { 500000.0d, 0.000380826d },
            { 510000.0d, 0.000383865d },
            { 520000.0d, 0.000386831d },
            { 530000.0d, 0.000389722d },
            { 540000.0d, 0.000392541d },
            { 550000.0d, 0.000395286d },
            { 560000.0d, 0.000397958d },
            { 570000.0d, 0.000400557d },
            { 580000.0d, 0.000403084d },
            { 590000.0d, 0.00040554d },
            { 600000.0d, 0.000407922d },
            { 610000.0d, 0.000410233d },
            { 620000.0d, 0.000412475d },
            { 630000.0d, 0.000414643d },
            { 640000.0d, 0.000416742d },
            { 650000.0d, 0.000418772d },
            { 660000.0d, 0.000420731d },
            { 670000.0d, 0.000422621d },
            { 680000.0d, 0.000424441d },
            { 690000.0d, 0.000426194d },
            { 700000.0d, 0.000427878d },
            { 710000.0d, 0.000429495d },
            { 720000.0d, 0.000431045d },
            { 730000.0d, 0.000432529d },
            { 740000.0d, 0.000433945d },
            { 750000.0d, 0.000435296d },
            { 760000.0d, 0.000436582d },
            { 770000.0d, 0.000437804d },
            { 780000.0d, 0.000438961d },
            { 790000.0d, 0.000440055d },
            { 800000.0d, 0.000441085d },
            { 810000.0d, 0.000442053d },
            { 820000.0d, 0.000442959d },
            { 830000.0d, 0.000443804d },
            { 840000.0d, 0.000444588d },
            { 850000.0d, 0.000445312d },
            { 860000.0d, 0.000445977d },
            { 870000.0d, 0.000446582d },
            { 880000.0d, 0.000447129d },
            { 890000.0d, 0.000447619d },
            { 900000.0d, 0.000448051d },
            { 910000.0d, 0.000448427d },
            { 920000.0d, 0.000448747d },
            { 930000.0d, 0.000449013d },
            { 940000.0d, 0.000449224d },
            { 950000.0d, 0.00044938d },
            { 960000.0d, 0.000449485d },
            { 970000.0d, 0.000449537d },
            { 980000.0d, 0.000449537d },
            { 990000.0d, 0.000449485d },
            { 1000000.0d, 0.000449385d },
            { 1011000.0d, 0.000449216d },
            { 1022000.0d, 0.00044899d },
            { 1033000.0d, 0.000448705d },
            { 1044000.0d, 0.000448363d },
            { 1055000.0d, 0.000447965d },
            { 1066000.0d, 0.000447513d },
            { 1077000.0d, 0.000447006d },
            { 1088000.0d, 0.000446446d },
            { 1099000.0d, 0.000445834d },
            { 1110000.0d, 0.000445172d },
            { 1121000.0d, 0.000444458d },
            { 1132000.0d, 0.000443694d },
            { 1143000.0d, 0.000442882d },
            { 1154000.0d, 0.000442021d },
            { 1165000.0d, 0.000441113d },
            { 1176000.0d, 0.00044016d },
            { 1187000.0d, 0.000439162d },
            { 1198000.0d, 0.00043812d },
            { 1209000.0d, 0.000437035d },
            { 1220000.0d, 0.000435909d },
            { 1231000.0d, 0.000434741d },
            { 1242000.0d, 0.000433535d },
            { 1253000.0d, 0.00043229d },
            { 1264000.0d, 0.000431008d },
            { 1275000.0d, 0.000429688d },
            { 1286000.0d, 0.000428335d },
            { 1297000.0d, 0.000426947d },
            { 1308000.0d, 0.000425526d },
            { 1319000.0d, 0.000424073d },
            { 1330000.0d, 0.00042259d },
            { 1341000.0d, 0.000421077d },
            { 1352000.0d, 0.000419536d },
            { 1363000.0d, 0.000417967d },
            { 1374000.0d, 0.000416372d },
            { 1385000.0d, 0.000414753d },
            { 1396000.0d, 0.00041311d },
            { 1407000.0d, 0.000411444d },
            { 1418000.0d, 0.000409757d },
            { 1429000.0d, 0.00040805d },
            { 1440000.0d, 0.000406323d },
            { 1451000.0d, 0.00040458d },
            { 1462000.0d, 0.000402819d },
            { 1473000.0d, 0.000401043d },
            { 1484000.0d, 0.000399253d },
            { 1495000.0d, 0.000397451d },
            { 1506000.0d, 0.000395637d },
            { 1517000.0d, 0.000393813d },
            { 1528000.0d, 0.00039198d },
            { 1539000.0d, 0.00039014d },
            { 1550000.0d, 0.000388293d },
            { 1561000.0d, 0.000386441d },
            { 1572000.0d, 0.000384586d },
            { 1583000.0d, 0.000382728d },
            { 1594000.0d, 0.00038087d },
            { 1605000.0d, 0.000379012d },
            { 1616000.0d, 0.000377157d },
            { 1627000.0d, 0.000375304d },
            { 1638000.0d, 0.000373456d },
            { 1649000.0d, 0.000371614d },
            { 1660000.0d, 0.00036978d },
            { 1671000.0d, 0.000367955d },
            { 1682000.0d, 0.00036614d },
            { 1693000.0d, 0.000364337d },
            { 1704000.0d, 0.000362543d },
            { 1715000.0d, 0.000360759d },
            { 1726000.0d, 0.000358986d },
            { 1737000.0d, 0.000357225d },
            { 1748000.0d, 0.000355478d },
            { 1759000.0d, 0.000353744d },
            { 1770000.0d, 0.000352027d },
            { 1781000.0d, 0.000350328d },
            { 1792000.0d, 0.000348646d },
            { 1803000.0d, 0.000346985d },
            { 1814000.0d, 0.000345345d },
            { 1825000.0d, 0.000343727d },
            { 1836000.0d, 0.000342132d },
            { 1847000.0d, 0.000340563d },
            { 1858000.0d, 0.000339021d },
            { 1869000.0d, 0.000337506d },
            { 1880000.0d, 0.00033602d },
            { 1891000.0d, 0.000334565d },
            { 1902000.0d, 0.000333142d },
            { 1913000.0d, 0.000331752d },
            { 1924000.0d, 0.000330397d },
            { 1935000.0d, 0.000329078d },
            { 1946000.0d, 0.000327797d },
            { 1957000.0d, 0.000326555d },
            { 1968000.0d, 0.000325354d },
            { 1979000.0d, 0.000324195d },
            { 1990000.0d, 0.00032308d },
            { 2001000.0d, 0.00032201d },
            { 2012000.0d, 0.000320947d },
            { 2023000.0d, 0.000319858d },
            { 2034000.0d, 0.000318743d },
            { 2045000.0d, 0.000317601d },
            { 2056000.0d, 0.000316433d },
            { 2067000.0d, 0.000315236d },
            { 2078000.0d, 0.000314013d },
            { 2089000.0d, 0.000312762d },
            { 2100000.0d, 0.000311484d },
            { 2111000.0d, 0.000310177d },
            { 2122000.0d, 0.000308843d },
            { 2133000.0d, 0.000307479d },
            { 2144000.0d, 0.000306088d },
            { 2155000.0d, 0.000304667d },
            { 2166000.0d, 0.000303217d },
            { 2177000.0d, 0.000301738d },
            { 2188000.0d, 0.00030023d },
            { 2199000.0d, 0.00029869d },
            { 2210000.0d, 0.000297122d },
            { 2221000.0d, 0.000295524d },
            { 2232000.0d, 0.000293896d },
            { 2243000.0d, 0.000292236d },
            { 2254000.0d, 0.000290546d },
            { 2265000.0d, 0.000288826d },
            { 2276000.0d, 0.000287075d },
            { 2287000.0d, 0.000285292d },
            { 2298000.0d, 0.000283478d },
            { 2309000.0d, 0.000281632d },
            { 2320000.0d, 0.000279756d },
            { 2331000.0d, 0.000277848d },
            { 2342000.0d, 0.000275908d },
            { 2353000.0d, 0.000273936d },
            { 2364000.0d, 0.000271932d },
            { 2375000.0d, 0.000269897d },
            { 2386000.0d, 0.000267829d },
            { 2397000.0d, 0.000265729d },
            { 2408000.0d, 0.000263596d },
            { 2419000.0d, 0.000261433d },
            { 2430000.0d, 0.000259237d },
            { 2441000.0d, 0.000257008d },
            { 2452000.0d, 0.000254748d },
            { 2463000.0d, 0.000252456d },
            { 2474000.0d, 0.000250132d },
            { 2485000.0d, 0.000247776d },
            { 2496000.0d, 0.000245388d },
            { 2507000.0d, 0.000242968d },
            { 2518000.0d, 0.000240517d },
            { 2529000.0d, 0.000238035d },
            { 2540000.0d, 0.000235521d },
            { 2551000.0d, 0.000232977d },
            { 2562000.0d, 0.000230401d },
            { 2573000.0d, 0.000227794d },
            { 2584000.0d, 0.000225158d },
            { 2595000.0d, 0.000222492d },
            { 2606000.0d, 0.000219796d },
            { 2617000.0d, 0.00021707d },
            { 2628000.0d, 0.000214316d },
            { 2639000.0d, 0.000211532d },
            { 2650000.0d, 0.000208721d },
            { 2661000.0d, 0.000205882d },
            { 2672000.0d, 0.000203016d },
            { 2683000.0d, 0.000200122d },
            { 2694000.0d, 0.000197203d },
            { 2705000.0d, 0.000194257d },
            { 2716000.0d, 0.000191286d },
            { 2727000.0d, 0.000188291d },
            { 2738000.0d, 0.000185272d },
            { 2749000.0d, 0.000182229d },
            { 2760000.0d, 0.000179164d },
            { 2771000.0d, 0.000176077d },
            { 2782000.0d, 0.000172969d },
            { 2793000.0d, 0.00016984d },
            { 2804000.0d, 0.000166693d },
            { 2815000.0d, 0.000163527d },
            { 2826000.0d, 0.000160343d },
            { 2837000.0d, 0.000157144d },
            { 2848000.0d, 0.000153927d },
            { 2859000.0d, 0.000150697d },
            { 2870000.0d, 0.000147454d },
            { 2881000.0d, 0.000144198d },
            { 2892000.0d, 0.000140931d },
            { 2903000.0d, 0.000137653d },
            { 2914000.0d, 0.000134367d },
            { 2925000.0d, 0.000131074d },
            { 2936000.0d, 0.000127774d },
            { 2947000.0d, 0.000124471d },
            { 2958000.0d, 0.000121164d },
            { 2969000.0d, 0.000117855d },
            { 2980000.0d, 0.000114545d },
            { 2991000.0d, 0.000111238d },
            { 3002000.0d, 0.000107933d },
            { 3013000.0d, 0.000104633d },
            { 3024000.0d, 0.000101339d },
            { 3035000.0d, 0.0000980543d },
            { 3046000.0d, 0.0000947793d },
            { 3057000.0d, 0.0000915162d },
            { 3068000.0d, 0.0000882672d },
            { 3079000.0d, 0.0000850342d },
            { 3090000.0d, 0.0000818192d },
            { 3101000.0d, 0.0000786244d },
            { 3112000.0d, 0.0000754521d },
            { 3123000.0d, 0.0000723044d },
            { 3134000.0d, 0.0000691837d },
            { 3145000.0d, 0.0000660923d },
            { 3156000.0d, 0.0000630328d },
            { 3167000.0d, 0.0000600075d },
            { 3178000.0d, 0.0000570191d },
            { 3189000.0d, 0.0000540702d },
            { 3200000.0d, 0.0000511635d },
            { 3211000.0d, 0.0000483018d },
            { 3222000.0d, 0.0000454879d },
            { 3233000.0d, 0.0000427248d },
            { 3244000.0d, 0.0000400153d },
            { 3255000.0d, 0.0000373627d },
            { 3266000.0d, 0.0000347699d },
            { 3277000.0d, 0.0000322402d },
            { 3288000.0d, 0.0000297769d },
            { 3299000.0d, 0.0000273833d },
            { 3310000.0d, 0.0000250628d },
            { 3321000.0d, 0.000022819d },
            { 3332000.0d, 0.0000206555d },
            { 3343000.0d, 0.0000185758d },
            { 3354000.0d, 0.0000165837d },
            { 3365000.0d, 0.0000146831d },
            { 3376000.0d, 0.0000128779d },
            { 3387000.0d, 0.000011172d },
            { 3398000.0d, 0.00000956965d },
            { 3409000.0d, 0.00000807487d },
            { 3420000.0d, 0.00000669196d },
            { 3431000.0d, 0.00000542525d },
            { 3442000.0d, 0.00000427918d },
            { 3453000.0d, 0.00000325827d },
            { 3464000.0d, 0.00000236712d },
            { 3475000.0d, 0.00000161045d },
            { 3486000.0d, 0.000000993059d },
            { 3497000.0d, 0.000000519833d },
            { 3508000.0d, 0.000000195764d },
            { 3519000.0d, 0.0000000259392d },
            { 3525220.0d, 0d },

        }; 
    }
}
    