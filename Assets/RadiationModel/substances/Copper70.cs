using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper70 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper70";
        public override double halfLife { get; } = 44.5d;
        public override double atomicWeight { get; } = 69.93239d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc70()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.013999999999999999d, new GammaParticle(438200.0, 0.00283)), new(0.0103d, new GammaParticle(560820.0, 0.00221)), new(0.0083d, new GammaParticle(584700.0, 0.00212)), new(0.0125d, new GammaParticle(750000.0, 0.00165)), new(0.0049d, new GammaParticle(783100.0, 0.00158)), new(1.0d, new GammaParticle(884880.0, 0.0014)), new(0.02d, new GammaParticle(893100.0, 0.00139)), new(0.997d, new GammaParticle(901700.0, 0.00138)), new(0.0024d, new GammaParticle(906500.0, 0.00137)), new(0.0074d, new GammaParticle(963300.0, 0.00129)), new(0.0072d, new GammaParticle(988000.0, 0.00125)), new(0.0058d, new GammaParticle(1023300.0, 0.00121)), new(0.09300000000000001d, new GammaParticle(1108400.0, 0.00112)), new(0.0216d, new GammaParticle(1226300.0, 0.00101)), new(0.733d, new GammaParticle(1251700.0, 0.00099)), new(0.0165d, new GammaParticle(1270800.0, 0.00098)), new(0.005699999999999999d, new GammaParticle(1315000.0, 0.00094)), new(0.0070999999999999995d, new GammaParticle(1413900.0, 0.00088)), new(0.026000000000000002d, new GammaParticle(1426500.0, 0.00087)), new(0.013500000000000002d, new GammaParticle(1476100.0, 0.00084)), new(0.012d, new GammaParticle(1520100.0, 0.00082)), new(0.013999999999999999d, new GammaParticle(1550600.0, 0.0008)), new(0.009399999999999999d, new GammaParticle(1555200.0, 0.0008)), new(0.0083d, new GammaParticle(1569800.0, 0.00079)), new(0.063d, new GammaParticle(1690300.0, 0.00073)), new(0.0026d, new GammaParticle(1809100.0, 0.00069)), new(0.0104d, new GammaParticle(1815000.0, 0.00068)), new(0.027999999999999997d, new GammaParticle(1954200.0, 0.00063)), new(0.049d, new GammaParticle(2061600.0, 0.0006)), new(0.005699999999999999d, new GammaParticle(2117200.0, 0.00059)), new(0.005d, new GammaParticle(2166200.0, 0.00057)), new(0.0178d, new GammaParticle(2771200.0, 0.00045)), new(0.0239d, new GammaParticle(3062100.0, 0.0004)), new(1.1852251734096e-05d, new GammaParticle(1035.0, 1.19791)), new(0.0001112114501431319d, new GammaParticle(8616.0, 0.1439)), new(0.0002162805331449473d, new GammaParticle(8639.0, 0.14352)), new(4.640561403192083e-05d, new GammaParticle(9610.0, 0.12902)), new(4.640561403192083e-05d, new GammaParticle(9610.0, 0.12902)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000136327d },
            { 5000.0d, 0.000138006d },
            { 10000.0d, 0.000139835d },
            { 15000.0d, 0.000141813d },
            { 20000.0d, 0.000143963d },
            { 25000.0d, 0.000146284d },
            { 30000.0d, 0.000148757d },
            { 35000.0d, 0.000151341d },
            { 40000.0d, 0.000153999d },
            { 45000.0d, 0.000156726d },
            { 50000.0d, 0.000159493d },
            { 55000.0d, 0.0001623d },
            { 60000.0d, 0.00016513d },
            { 65000.0d, 0.000167983d },
            { 70000.0d, 0.000170852d },
            { 75000.0d, 0.000173733d },
            { 80000.0d, 0.000176624d },
            { 85000.0d, 0.000179521d },
            { 90000.0d, 0.000182423d },
            { 95000.0d, 0.000185328d },
            { 100000.0d, 0.000188235d },
            { 110000.0d, 0.00019405d },
            { 120000.0d, 0.000199862d },
            { 130000.0d, 0.000205664d },
            { 140000.0d, 0.000211452d },
            { 150000.0d, 0.000217224d },
            { 160000.0d, 0.000222977d },
            { 170000.0d, 0.000228708d },
            { 180000.0d, 0.000234414d },
            { 190000.0d, 0.000240095d },
            { 200000.0d, 0.000245749d },
            { 210000.0d, 0.000251373d },
            { 220000.0d, 0.000256966d },
            { 230000.0d, 0.000262527d },
            { 240000.0d, 0.000268054d },
            { 250000.0d, 0.000273546d },
            { 260000.0d, 0.000279d },
            { 270000.0d, 0.000284417d },
            { 280000.0d, 0.000289793d },
            { 290000.0d, 0.00029513d },
            { 300000.0d, 0.000300423d },
            { 310000.0d, 0.000305673d },
            { 320000.0d, 0.000310878d },
            { 330000.0d, 0.000316037d },
            { 340000.0d, 0.000321148d },
            { 350000.0d, 0.000326211d },
            { 360000.0d, 0.000331223d },
            { 370000.0d, 0.000336184d },
            { 380000.0d, 0.000341094d },
            { 390000.0d, 0.00034595d },
            { 400000.0d, 0.000350751d },
            { 410000.0d, 0.000355498d },
            { 420000.0d, 0.000360186d },
            { 430000.0d, 0.000364817d },
            { 440000.0d, 0.000369389d },
            { 450000.0d, 0.000373902d },
            { 460000.0d, 0.000378354d },
            { 470000.0d, 0.000382743d },
            { 480000.0d, 0.00038707d },
            { 490000.0d, 0.000391333d },
            { 500000.0d, 0.000395532d },
            { 510000.0d, 0.000399666d },
            { 520000.0d, 0.000403732d },
            { 530000.0d, 0.000407732d },
            { 540000.0d, 0.000411664d },
            { 550000.0d, 0.000415527d },
            { 560000.0d, 0.000419321d },
            { 570000.0d, 0.000423045d },
            { 580000.0d, 0.000426698d },
            { 590000.0d, 0.000430279d },
            { 600000.0d, 0.000433788d },
            { 610000.0d, 0.000437224d },
            { 620000.0d, 0.000440586d },
            { 630000.0d, 0.000443876d },
            { 640000.0d, 0.000447091d },
            { 650000.0d, 0.00045023d },
            { 660000.0d, 0.000453293d },
            { 670000.0d, 0.000456282d },
            { 680000.0d, 0.000459193d },
            { 690000.0d, 0.000462028d },
            { 700000.0d, 0.000464785d },
            { 710000.0d, 0.000467465d },
            { 720000.0d, 0.000470067d },
            { 730000.0d, 0.000472591d },
            { 740000.0d, 0.000475036d },
            { 750000.0d, 0.000477403d },
            { 760000.0d, 0.000479691d },
            { 770000.0d, 0.000481899d },
            { 780000.0d, 0.000484028d },
            { 790000.0d, 0.000486077d },
            { 800000.0d, 0.000488046d },
            { 810000.0d, 0.000489936d },
            { 820000.0d, 0.000491746d },
            { 830000.0d, 0.000493477d },
            { 840000.0d, 0.000495127d },
            { 850000.0d, 0.000496697d },
            { 860000.0d, 0.000498187d },
            { 870000.0d, 0.000499597d },
            { 880000.0d, 0.000500927d },
            { 890000.0d, 0.000502179d },
            { 900000.0d, 0.000503349d },
            { 910000.0d, 0.000504441d },
            { 920000.0d, 0.000505454d },
            { 930000.0d, 0.000506387d },
            { 940000.0d, 0.000507242d },
            { 950000.0d, 0.000508018d },
            { 960000.0d, 0.000508716d },
            { 970000.0d, 0.000509335d },
            { 980000.0d, 0.000509878d },
            { 990000.0d, 0.000510343d },
            { 1000000.0d, 0.000510731d },
            { 1012000.0d, 0.000511095d },
            { 1024000.0d, 0.00051135d },
            { 1036000.0d, 0.000511497d },
            { 1048000.0d, 0.000511536d },
            { 1060000.0d, 0.000511468d },
            { 1072000.0d, 0.000511294d },
            { 1084000.0d, 0.000511014d },
            { 1096000.0d, 0.000510632d },
            { 1108000.0d, 0.000510146d },
            { 1120000.0d, 0.00050956d },
            { 1132000.0d, 0.000508872d },
            { 1144000.0d, 0.000508085d },
            { 1156000.0d, 0.000507201d },
            { 1168000.0d, 0.00050622d },
            { 1180000.0d, 0.000505144d },
            { 1192000.0d, 0.000503975d },
            { 1204000.0d, 0.000502715d },
            { 1216000.0d, 0.000501364d },
            { 1228000.0d, 0.000499923d },
            { 1240000.0d, 0.000498395d },
            { 1252000.0d, 0.000496783d },
            { 1264000.0d, 0.000495087d },
            { 1276000.0d, 0.000493309d },
            { 1288000.0d, 0.000491451d },
            { 1300000.0d, 0.000489515d },
            { 1312000.0d, 0.000487503d },
            { 1324000.0d, 0.000485418d },
            { 1336000.0d, 0.000483261d },
            { 1348000.0d, 0.000481033d },
            { 1360000.0d, 0.000478739d },
            { 1372000.0d, 0.000476379d },
            { 1384000.0d, 0.000473956d },
            { 1396000.0d, 0.000471472d },
            { 1408000.0d, 0.00046893d },
            { 1420000.0d, 0.000466333d },
            { 1432000.0d, 0.000463681d },
            { 1444000.0d, 0.00046098d },
            { 1456000.0d, 0.00045823d },
            { 1468000.0d, 0.000455433d },
            { 1480000.0d, 0.000452594d },
            { 1492000.0d, 0.000449715d },
            { 1504000.0d, 0.000446798d },
            { 1516000.0d, 0.000443847d },
            { 1528000.0d, 0.000440863d },
            { 1540000.0d, 0.000437848d },
            { 1552000.0d, 0.0004348d },
            { 1564000.0d, 0.000431723d },
            { 1576000.0d, 0.000428621d },
            { 1588000.0d, 0.000425495d },
            { 1600000.0d, 0.000422348d },
            { 1612000.0d, 0.000419184d },
            { 1624000.0d, 0.000416006d },
            { 1636000.0d, 0.000412816d },
            { 1648000.0d, 0.000409618d },
            { 1660000.0d, 0.000406415d },
            { 1672000.0d, 0.00040321d },
            { 1684000.0d, 0.000400008d },
            { 1696000.0d, 0.000396809d },
            { 1708000.0d, 0.000393618d },
            { 1720000.0d, 0.000390439d },
            { 1732000.0d, 0.000387274d },
            { 1744000.0d, 0.000384123d },
            { 1756000.0d, 0.000380959d },
            { 1768000.0d, 0.000377775d },
            { 1780000.0d, 0.000374574d },
            { 1792000.0d, 0.000371358d },
            { 1804000.0d, 0.00036813d },
            { 1816000.0d, 0.000364888d },
            { 1828000.0d, 0.000361633d },
            { 1840000.0d, 0.000358368d },
            { 1852000.0d, 0.000355095d },
            { 1864000.0d, 0.000351818d },
            { 1876000.0d, 0.000348539d },
            { 1888000.0d, 0.000345257d },
            { 1900000.0d, 0.000341969d },
            { 1912000.0d, 0.000338678d },
            { 1924000.0d, 0.000335388d },
            { 1936000.0d, 0.000332099d },
            { 1948000.0d, 0.000328814d },
            { 1960000.0d, 0.000325536d },
            { 1972000.0d, 0.000322266d },
            { 1984000.0d, 0.000319009d },
            { 1996000.0d, 0.000315764d },
            { 2008000.0d, 0.000312535d },
            { 2020000.0d, 0.000309315d },
            { 2032000.0d, 0.000306109d },
            { 2044000.0d, 0.000302907d },
            { 2056000.0d, 0.000299706d },
            { 2068000.0d, 0.000296506d },
            { 2080000.0d, 0.000293311d },
            { 2092000.0d, 0.000290116d },
            { 2104000.0d, 0.000286922d },
            { 2116000.0d, 0.000283732d },
            { 2128000.0d, 0.000280544d },
            { 2140000.0d, 0.000277346d },
            { 2152000.0d, 0.000274137d },
            { 2164000.0d, 0.000270917d },
            { 2176000.0d, 0.000267686d },
            { 2188000.0d, 0.000264448d },
            { 2200000.0d, 0.000261203d },
            { 2212000.0d, 0.000257954d },
            { 2224000.0d, 0.0002547d },
            { 2236000.0d, 0.000251444d },
            { 2248000.0d, 0.000248187d },
            { 2260000.0d, 0.000244931d },
            { 2272000.0d, 0.000241678d },
            { 2284000.0d, 0.000238427d },
            { 2296000.0d, 0.000235174d },
            { 2308000.0d, 0.000231917d },
            { 2320000.0d, 0.000228659d },
            { 2332000.0d, 0.000225399d },
            { 2344000.0d, 0.000222132d },
            { 2356000.0d, 0.000218858d },
            { 2368000.0d, 0.000215581d },
            { 2380000.0d, 0.000212299d },
            { 2392000.0d, 0.000209015d },
            { 2404000.0d, 0.000205728d },
            { 2416000.0d, 0.000202443d },
            { 2428000.0d, 0.000199159d },
            { 2440000.0d, 0.000195878d },
            { 2452000.0d, 0.0001926d },
            { 2464000.0d, 0.000189328d },
            { 2476000.0d, 0.000186062d },
            { 2488000.0d, 0.000182805d },
            { 2500000.0d, 0.000179556d },
            { 2512000.0d, 0.000176319d },
            { 2524000.0d, 0.000173093d },
            { 2536000.0d, 0.00016988d },
            { 2548000.0d, 0.000166677d },
            { 2560000.0d, 0.000163485d },
            { 2572000.0d, 0.000160307d },
            { 2584000.0d, 0.000157143d },
            { 2596000.0d, 0.000153994d },
            { 2608000.0d, 0.00015086d },
            { 2620000.0d, 0.000147743d },
            { 2632000.0d, 0.000144642d },
            { 2644000.0d, 0.000141561d },
            { 2656000.0d, 0.000138501d },
            { 2668000.0d, 0.000135462d },
            { 2680000.0d, 0.000132446d },
            { 2692000.0d, 0.000129454d },
            { 2704000.0d, 0.000126486d },
            { 2716000.0d, 0.000123545d },
            { 2728000.0d, 0.00012063d },
            { 2740000.0d, 0.000117744d },
            { 2752000.0d, 0.000114882d },
            { 2764000.0d, 0.000112038d },
            { 2776000.0d, 0.000109215d },
            { 2788000.0d, 0.000106413d },
            { 2800000.0d, 0.000103633d },
            { 2812000.0d, 0.000100874d },
            { 2824000.0d, 0.0000981317d },
            { 2836000.0d, 0.0000954079d },
            { 2848000.0d, 0.0000927035d },
            { 2860000.0d, 0.0000900197d },
            { 2872000.0d, 0.0000873578d },
            { 2884000.0d, 0.0000847187d },
            { 2896000.0d, 0.0000821038d },
            { 2908000.0d, 0.000079514d },
            { 2920000.0d, 0.0000769507d },
            { 2932000.0d, 0.000074415d },
            { 2944000.0d, 0.0000719081d },
            { 2956000.0d, 0.0000694312d },
            { 2968000.0d, 0.0000669856d },
            { 2980000.0d, 0.0000645724d },
            { 2992000.0d, 0.0000621929d },
            { 3004000.0d, 0.0000598469d },
            { 3016000.0d, 0.0000575352d },
            { 3028000.0d, 0.0000552588d },
            { 3040000.0d, 0.0000530191d },
            { 3052000.0d, 0.0000508174d },
            { 3064000.0d, 0.0000486549d },
            { 3076000.0d, 0.0000465329d },
            { 3088000.0d, 0.0000444527d },
            { 3100000.0d, 0.0000424156d },
            { 3112000.0d, 0.0000404228d },
            { 3124000.0d, 0.0000384699d },
            { 3136000.0d, 0.0000365531d },
            { 3148000.0d, 0.0000346737d },
            { 3160000.0d, 0.0000328328d },
            { 3172000.0d, 0.0000310317d },
            { 3184000.0d, 0.0000292714d },
            { 3196000.0d, 0.0000275532d },
            { 3208000.0d, 0.0000258785d },
            { 3220000.0d, 0.0000242483d },
            { 3232000.0d, 0.0000226639d },
            { 3244000.0d, 0.0000211268d },
            { 3256000.0d, 0.0000196367d },
            { 3268000.0d, 0.0000181925d },
            { 3280000.0d, 0.0000167949d },
            { 3292000.0d, 0.0000154452d },
            { 3304000.0d, 0.0000141445d },
            { 3316000.0d, 0.0000128938d },
            { 3328000.0d, 0.0000116942d },
            { 3340000.0d, 0.0000105468d },
            { 3352000.0d, 0.00000945275d },
            { 3364000.0d, 0.0000084132d },
            { 3376000.0d, 0.00000742923d },
            { 3388000.0d, 0.00000650198d },
            { 3400000.0d, 0.0000056326d },
            { 3412000.0d, 0.00000482221d },
            { 3424000.0d, 0.0000040719d },
            { 3436000.0d, 0.00000338284d },
            { 3448000.0d, 0.00000275614d },
            { 3460000.0d, 0.00000219293d },
            { 3472000.0d, 0.00000169434d },
            { 3484000.0d, 0.00000126149d },
            { 3496000.0d, 0.000000895477d },
            { 3508000.0d, 0.000000597404d },
            { 3520000.0d, 0.000000368329d },
            { 3532000.0d, 0.000000209299d },
            { 3544000.0d, 0.000000121156d },
            { 3556000.0d, 0.0000000955643d },
            { 3568000.0d, 0.0000000799741d },
            { 3580000.0d, 0.0000000656987d },
            { 3592000.0d, 0.0000000527612d },
            { 3604000.0d, 0.0000000411846d },
            { 3616000.0d, 0.0000000309921d },
            { 3628000.0d, 0.0000000222063d },
            { 3640000.0d, 0.00000001485d },
            { 3652000.0d, 0.00000000894525d },
            { 3664000.0d, 0.00000000451356d },
            { 3676000.0d, 0.00000000157518d },
            { 3688000.0d, 0.000000000147074d },
            { 3693300.0d, 0d },

        }; 
    }
}
    