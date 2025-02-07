using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper69 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper69";
        public override double halfLife { get; } = 171.0d;
        public override double atomicWeight { get; } = 68.92943d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc69()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00025739999999999997d, new GammaParticle(167200.0, 0.00742)), new(0.000468d, new GammaParticle(173400.0, 0.00715)), new(0.0025740000000000003d, new GammaParticle(173400.0, 0.00715)), new(0.00035099999999999997d, new GammaParticle(178200.0, 0.00696)), new(0.000936d, new GammaParticle(346300.0, 0.00358)), new(0.001638d, new GammaParticle(417400.0, 0.00297)), new(0.0014039999999999999d, new GammaParticle(421800.0, 0.00294)), new(0.000936d, new GammaParticle(434000.0, 0.00286)), new(0.001872d, new GammaParticle(476300.0, 0.0026)), new(0.059669999999999994d, new GammaParticle(531200.0, 0.00233)), new(0.026208d, new GammaParticle(594900.0, 0.00208)), new(0.00117d, new GammaParticle(647400.0, 0.00192)), new(0.020825999999999997d, new GammaParticle(649400.0, 0.00191)), new(0.000936d, new GammaParticle(820700.0, 0.00151)), new(0.13104d, new GammaParticle(834400.0, 0.00149)), new(0.0014039999999999999d, new GammaParticle(851800.0, 0.00146)), new(0.006552d, new GammaParticle(898200.0, 0.00138)), new(0.011466d, new GammaParticle(993400.0, 0.00125)), new(0.23399999999999999d, new GammaParticle(1007500.0, 0.00123)), new(0.022932d, new GammaParticle(1180700.0, 0.00105)), new(0.00117d, new GammaParticle(1205000.0, 0.00103)), new(0.0042120000000000005d, new GammaParticle(1251800.0, 0.00099)), new(0.00234d, new GammaParticle(1296600.0, 0.00096)), new(0.000468d, new GammaParticle(1361900.0, 0.00091)), new(0.034164d, new GammaParticle(1429800.0, 0.00087)), new(0.0002808d, new GammaParticle(1458300.0, 0.00085)), new(0.0028079999999999997d, new GammaParticle(1501600.0, 0.00083)), new(0.000936d, new GammaParticle(1594200.0, 0.00078)), new(0.0004212d, new GammaParticle(1633200.0, 0.00076)), new(0.0025740000000000003d, new GammaParticle(1828600.0, 0.00068)), new(0.0001872d, new GammaParticle(1894000.0, 0.00065)), new(0.0003978d, new GammaParticle(2033000.0, 0.00061)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000330333d },
            { 2000.0d, 0.000331697d },
            { 4000.0d, 0.000333094d },
            { 6000.0d, 0.000334523d },
            { 8000.0d, 0.000335978d },
            { 10000.0d, 0.000337465d },
            { 12000.0d, 0.000338987d },
            { 14000.0d, 0.000340564d },
            { 16000.0d, 0.000342203d },
            { 18000.0d, 0.000343917d },
            { 20000.0d, 0.000345702d },
            { 22000.0d, 0.000347549d },
            { 24000.0d, 0.000349459d },
            { 26000.0d, 0.000351414d },
            { 28000.0d, 0.000353417d },
            { 30000.0d, 0.000355466d },
            { 32000.0d, 0.00035755d },
            { 34000.0d, 0.00035966d },
            { 36000.0d, 0.0003618d },
            { 38000.0d, 0.000363963d },
            { 40000.0d, 0.000366151d },
            { 42000.0d, 0.000368351d },
            { 44000.0d, 0.000370567d },
            { 46000.0d, 0.000372797d },
            { 48000.0d, 0.00037504d },
            { 50000.0d, 0.000377289d },
            { 52000.0d, 0.000379546d },
            { 54000.0d, 0.000381811d },
            { 56000.0d, 0.000384081d },
            { 58000.0d, 0.000386354d },
            { 60000.0d, 0.00038863d },
            { 62000.0d, 0.000390909d },
            { 64000.0d, 0.00039319d },
            { 66000.0d, 0.00039547d },
            { 68000.0d, 0.00039775d },
            { 70000.0d, 0.000400029d },
            { 72000.0d, 0.000402308d },
            { 74000.0d, 0.000404584d },
            { 76000.0d, 0.000406859d },
            { 78000.0d, 0.00040913d },
            { 80000.0d, 0.000411398d },
            { 82000.0d, 0.000413663d },
            { 84000.0d, 0.000415925d },
            { 86000.0d, 0.000418182d },
            { 88000.0d, 0.000420436d },
            { 90000.0d, 0.000422684d },
            { 92000.0d, 0.000424927d },
            { 94000.0d, 0.000427166d },
            { 96000.0d, 0.000429399d },
            { 98000.0d, 0.000431627d },
            { 100000.0d, 0.000433849d },
            { 108000.0d, 0.000442681d },
            { 116000.0d, 0.000451411d },
            { 124000.0d, 0.000460033d },
            { 132000.0d, 0.000468542d },
            { 140000.0d, 0.000476935d },
            { 148000.0d, 0.000485205d },
            { 156000.0d, 0.000493352d },
            { 164000.0d, 0.000501373d },
            { 172000.0d, 0.000509263d },
            { 180000.0d, 0.000517024d },
            { 188000.0d, 0.000524649d },
            { 196000.0d, 0.000532141d },
            { 204000.0d, 0.000539497d },
            { 212000.0d, 0.000546714d },
            { 220000.0d, 0.000553792d },
            { 228000.0d, 0.000560731d },
            { 236000.0d, 0.000567528d },
            { 244000.0d, 0.000574182d },
            { 252000.0d, 0.000580693d },
            { 260000.0d, 0.00058706d },
            { 268000.0d, 0.000593282d },
            { 276000.0d, 0.000599359d },
            { 284000.0d, 0.000605287d },
            { 292000.0d, 0.00061107d },
            { 300000.0d, 0.000616705d },
            { 308000.0d, 0.000622193d },
            { 316000.0d, 0.000627531d },
            { 324000.0d, 0.00063272d },
            { 332000.0d, 0.00063776d },
            { 340000.0d, 0.000642652d },
            { 348000.0d, 0.000647394d },
            { 356000.0d, 0.000651985d },
            { 364000.0d, 0.000656428d },
            { 372000.0d, 0.000660721d },
            { 380000.0d, 0.000664865d },
            { 388000.0d, 0.00066886d },
            { 396000.0d, 0.000672706d },
            { 404000.0d, 0.000676402d },
            { 412000.0d, 0.000679951d },
            { 420000.0d, 0.000683352d },
            { 428000.0d, 0.000686606d },
            { 436000.0d, 0.000689713d },
            { 444000.0d, 0.000692676d },
            { 452000.0d, 0.000695492d },
            { 460000.0d, 0.000698164d },
            { 468000.0d, 0.000700692d },
            { 476000.0d, 0.000703079d },
            { 484000.0d, 0.000705323d },
            { 492000.0d, 0.000707427d },
            { 500000.0d, 0.000709392d },
            { 508000.0d, 0.000711219d },
            { 516000.0d, 0.000712909d },
            { 524000.0d, 0.000714465d },
            { 532000.0d, 0.000715886d },
            { 540000.0d, 0.000717174d },
            { 548000.0d, 0.000718332d },
            { 556000.0d, 0.00071936d },
            { 564000.0d, 0.000720261d },
            { 572000.0d, 0.000721038d },
            { 580000.0d, 0.000721689d },
            { 588000.0d, 0.000722219d },
            { 596000.0d, 0.00072263d },
            { 604000.0d, 0.000722922d },
            { 612000.0d, 0.000723098d },
            { 620000.0d, 0.000723162d },
            { 628000.0d, 0.000723114d },
            { 636000.0d, 0.000722957d },
            { 644000.0d, 0.000722694d },
            { 652000.0d, 0.000722325d },
            { 660000.0d, 0.000721838d },
            { 668000.0d, 0.000721232d },
            { 676000.0d, 0.000720507d },
            { 684000.0d, 0.000719666d },
            { 692000.0d, 0.000718711d },
            { 700000.0d, 0.000717644d },
            { 708000.0d, 0.000716467d },
            { 716000.0d, 0.000715183d },
            { 724000.0d, 0.000713792d },
            { 732000.0d, 0.000712299d },
            { 740000.0d, 0.000710705d },
            { 748000.0d, 0.000709011d },
            { 756000.0d, 0.000707222d },
            { 764000.0d, 0.00070534d },
            { 772000.0d, 0.000703365d },
            { 780000.0d, 0.000701303d },
            { 788000.0d, 0.000699155d },
            { 796000.0d, 0.000696923d },
            { 804000.0d, 0.000694609d },
            { 812000.0d, 0.000692215d },
            { 820000.0d, 0.000689745d },
            { 828000.0d, 0.000687201d },
            { 836000.0d, 0.000684587d },
            { 844000.0d, 0.000681905d },
            { 852000.0d, 0.000679158d },
            { 860000.0d, 0.000676336d },
            { 868000.0d, 0.000673416d },
            { 876000.0d, 0.000670398d },
            { 884000.0d, 0.000667285d },
            { 892000.0d, 0.000664079d },
            { 900000.0d, 0.000660781d },
            { 908000.0d, 0.000657395d },
            { 916000.0d, 0.000653921d },
            { 924000.0d, 0.000650363d },
            { 932000.0d, 0.000646721d },
            { 940000.0d, 0.000642998d },
            { 948000.0d, 0.000639197d },
            { 956000.0d, 0.000635319d },
            { 964000.0d, 0.000631368d },
            { 972000.0d, 0.000627345d },
            { 980000.0d, 0.000623252d },
            { 988000.0d, 0.000619094d },
            { 996000.0d, 0.000614871d },
            { 1004000.0d, 0.000610586d },
            { 1012000.0d, 0.000606242d },
            { 1020000.0d, 0.000601842d },
            { 1028000.0d, 0.000597387d },
            { 1036000.0d, 0.000592881d },
            { 1044000.0d, 0.000588327d },
            { 1052000.0d, 0.000583728d },
            { 1060000.0d, 0.000579084d },
            { 1068000.0d, 0.0005744d },
            { 1076000.0d, 0.000569679d },
            { 1084000.0d, 0.000564922d },
            { 1092000.0d, 0.000560134d },
            { 1100000.0d, 0.000555317d },
            { 1108000.0d, 0.000550474d },
            { 1116000.0d, 0.000545609d },
            { 1124000.0d, 0.000540724d },
            { 1132000.0d, 0.000535822d },
            { 1140000.0d, 0.000530907d },
            { 1148000.0d, 0.000525983d },
            { 1156000.0d, 0.000521052d },
            { 1164000.0d, 0.000516117d },
            { 1172000.0d, 0.000511182d },
            { 1180000.0d, 0.000506251d },
            { 1188000.0d, 0.000501327d },
            { 1196000.0d, 0.000496413d },
            { 1204000.0d, 0.000491513d },
            { 1212000.0d, 0.00048663d },
            { 1220000.0d, 0.000481768d },
            { 1228000.0d, 0.000476931d },
            { 1236000.0d, 0.000472121d },
            { 1244000.0d, 0.000467343d },
            { 1252000.0d, 0.000462601d },
            { 1260000.0d, 0.000457866d },
            { 1268000.0d, 0.000453116d },
            { 1276000.0d, 0.000448351d },
            { 1284000.0d, 0.000443574d },
            { 1292000.0d, 0.000438787d },
            { 1300000.0d, 0.000433993d },
            { 1308000.0d, 0.000429195d },
            { 1316000.0d, 0.000424393d },
            { 1324000.0d, 0.000419593d },
            { 1332000.0d, 0.000414794d },
            { 1340000.0d, 0.000410001d },
            { 1348000.0d, 0.000405216d },
            { 1356000.0d, 0.00040044d },
            { 1364000.0d, 0.000395678d },
            { 1372000.0d, 0.000390932d },
            { 1380000.0d, 0.000386203d },
            { 1388000.0d, 0.000381495d },
            { 1396000.0d, 0.000376812d },
            { 1404000.0d, 0.000372154d },
            { 1412000.0d, 0.000367526d },
            { 1420000.0d, 0.000362929d },
            { 1428000.0d, 0.000358367d },
            { 1436000.0d, 0.000353841d },
            { 1444000.0d, 0.000349353d },
            { 1452000.0d, 0.000344905d },
            { 1460000.0d, 0.000340499d },
            { 1468000.0d, 0.000336139d },
            { 1476000.0d, 0.000331827d },
            { 1484000.0d, 0.000327567d },
            { 1492000.0d, 0.000323361d },
            { 1500000.0d, 0.000319212d },
            { 1508000.0d, 0.000315114d },
            { 1516000.0d, 0.000311056d },
            { 1524000.0d, 0.000307041d },
            { 1532000.0d, 0.000303072d },
            { 1540000.0d, 0.00029915d },
            { 1548000.0d, 0.00029528d },
            { 1556000.0d, 0.000291463d },
            { 1564000.0d, 0.000287702d },
            { 1572000.0d, 0.000283998d },
            { 1580000.0d, 0.000280356d },
            { 1588000.0d, 0.000276778d },
            { 1596000.0d, 0.000273267d },
            { 1604000.0d, 0.000269824d },
            { 1612000.0d, 0.000266454d },
            { 1620000.0d, 0.000263159d },
            { 1628000.0d, 0.00025994d },
            { 1636000.0d, 0.000256802d },
            { 1644000.0d, 0.000253747d },
            { 1652000.0d, 0.000250777d },
            { 1660000.0d, 0.000247896d },
            { 1668000.0d, 0.000245106d },
            { 1676000.0d, 0.000242405d },
            { 1684000.0d, 0.000239728d },
            { 1692000.0d, 0.000237052d },
            { 1700000.0d, 0.000234379d },
            { 1708000.0d, 0.000231708d },
            { 1716000.0d, 0.00022904d },
            { 1724000.0d, 0.000226377d },
            { 1732000.0d, 0.00022372d },
            { 1740000.0d, 0.000221069d },
            { 1748000.0d, 0.000218425d },
            { 1756000.0d, 0.000215789d },
            { 1764000.0d, 0.000213164d },
            { 1772000.0d, 0.000210548d },
            { 1780000.0d, 0.000207944d },
            { 1788000.0d, 0.000205352d },
            { 1796000.0d, 0.000202773d },
            { 1804000.0d, 0.000200209d },
            { 1812000.0d, 0.00019766d },
            { 1820000.0d, 0.000195127d },
            { 1828000.0d, 0.000192612d },
            { 1836000.0d, 0.000190115d },
            { 1844000.0d, 0.000187637d },
            { 1852000.0d, 0.000185173d },
            { 1860000.0d, 0.000182705d },
            { 1868000.0d, 0.000180231d },
            { 1876000.0d, 0.000177752d },
            { 1884000.0d, 0.000175268d },
            { 1892000.0d, 0.00017278d },
            { 1900000.0d, 0.000170288d },
            { 1908000.0d, 0.000167794d },
            { 1916000.0d, 0.000165297d },
            { 1924000.0d, 0.000162799d },
            { 1932000.0d, 0.000160298d },
            { 1940000.0d, 0.000157797d },
            { 1948000.0d, 0.000155295d },
            { 1956000.0d, 0.000152795d },
            { 1964000.0d, 0.000150295d },
            { 1972000.0d, 0.000147797d },
            { 1980000.0d, 0.000145301d },
            { 1988000.0d, 0.000142807d },
            { 1996000.0d, 0.000140318d },
            { 2004000.0d, 0.000137831d },
            { 2012000.0d, 0.00013535d },
            { 2020000.0d, 0.000132875d },
            { 2028000.0d, 0.000130405d },
            { 2036000.0d, 0.000127941d },
            { 2044000.0d, 0.000125485d },
            { 2052000.0d, 0.000123036d },
            { 2060000.0d, 0.000120596d },
            { 2068000.0d, 0.000118165d },
            { 2076000.0d, 0.000115744d },
            { 2084000.0d, 0.000113333d },
            { 2092000.0d, 0.000110933d },
            { 2100000.0d, 0.000108545d },
            { 2108000.0d, 0.00010617d },
            { 2116000.0d, 0.000103807d },
            { 2124000.0d, 0.000101458d },
            { 2132000.0d, 0.0000991233d },
            { 2140000.0d, 0.0000968045d },
            { 2148000.0d, 0.0000945009d },
            { 2156000.0d, 0.0000922125d },
            { 2164000.0d, 0.0000899361d },
            { 2172000.0d, 0.0000876722d },
            { 2180000.0d, 0.0000854216d },
            { 2188000.0d, 0.0000831846d },
            { 2196000.0d, 0.000080962d },
            { 2204000.0d, 0.0000787545d },
            { 2212000.0d, 0.0000765627d },
            { 2220000.0d, 0.0000743871d },
            { 2228000.0d, 0.0000722285d },
            { 2236000.0d, 0.0000700876d },
            { 2244000.0d, 0.0000679648d },
            { 2252000.0d, 0.0000658611d },
            { 2260000.0d, 0.0000637768d },
            { 2268000.0d, 0.0000617128d },
            { 2276000.0d, 0.0000596698d },
            { 2284000.0d, 0.0000576482d },
            { 2292000.0d, 0.0000556491d },
            { 2300000.0d, 0.0000536728d },
            { 2308000.0d, 0.0000517201d },
            { 2316000.0d, 0.0000497918d },
            { 2324000.0d, 0.0000478884d },
            { 2332000.0d, 0.0000460108d },
            { 2340000.0d, 0.0000441596d },
            { 2348000.0d, 0.0000423354d },
            { 2356000.0d, 0.0000405391d },
            { 2364000.0d, 0.0000387713d },
            { 2372000.0d, 0.0000370328d },
            { 2380000.0d, 0.0000353241d },
            { 2388000.0d, 0.0000336462d },
            { 2396000.0d, 0.0000319996d },
            { 2404000.0d, 0.0000303852d },
            { 2412000.0d, 0.0000288036d },
            { 2420000.0d, 0.0000272556d },
            { 2428000.0d, 0.000025742d },
            { 2436000.0d, 0.0000242634d },
            { 2444000.0d, 0.0000228207d },
            { 2452000.0d, 0.0000214145d },
            { 2460000.0d, 0.0000200456d },
            { 2468000.0d, 0.0000187148d },
            { 2476000.0d, 0.0000174229d },
            { 2484000.0d, 0.0000161705d },
            { 2492000.0d, 0.0000149585d },
            { 2500000.0d, 0.0000137876d },
            { 2508000.0d, 0.0000126586d },
            { 2516000.0d, 0.0000115723d },
            { 2524000.0d, 0.0000105294d },
            { 2532000.0d, 0.00000953081d },
            { 2540000.0d, 0.00000857715d },
            { 2548000.0d, 0.00000766931d },
            { 2556000.0d, 0.00000680803d },
            { 2564000.0d, 0.00000599412d },
            { 2572000.0d, 0.00000522836d },
            { 2580000.0d, 0.00000451154d },
            { 2588000.0d, 0.00000384445d },
            { 2596000.0d, 0.00000322788d },
            { 2604000.0d, 0.00000266263d },
            { 2612000.0d, 0.00000214948d },
            { 2620000.0d, 0.00000168922d },
            { 2628000.0d, 0.00000128265d },
            { 2636000.0d, 0.000000930538d },
            { 2644000.0d, 0.000000633659d },
            { 2652000.0d, 0.000000392776d },
            { 2660000.0d, 0.00000020863d },
            { 2668000.0d, 0.0000000819272d },
            { 2676000.0d, 0.0000000132935d },
            { 2681400.0d, 0d },

        }; 
    }
}
    