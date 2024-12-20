using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium71 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium71";
        public override double halfLife { get; } = 284.4d;
        public override double atomicWeight { get; } = 70.93221d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium71()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.023d, new GammaParticle(143200.0, 0.00866)), new(0.48d, new GammaParticle(147500.0, 0.00841)), new(0.0176d, new GammaParticle(358800.0, 0.00346)), new(0.0048d, new GammaParticle(362200.0, 0.00342)), new(0.005699999999999999d, new GammaParticle(484200.0, 0.00256)), new(0.0067d, new GammaParticle(681290.0, 0.00182)), new(0.00062d, new GammaParticle(685000.0, 0.00181)), new(0.026099999999999998d, new GammaParticle(722900.0, 0.00172)), new(0.0012d, new GammaParticle(726700.0, 0.00171)), new(0.00105d, new GammaParticle(773760.0, 0.0016)), new(0.00052d, new GammaParticle(777300.0, 0.0016)), new(0.09699999999999999d, new GammaParticle(830330.0, 0.00149)), new(0.0038d, new GammaParticle(834300.0, 0.00149)), new(0.011399999999999999d, new GammaParticle(842990.0, 0.00147)), new(0.0062d, new GammaParticle(847140.0, 0.00146)), new(0.066d, new GammaParticle(870300.0, 0.00142)), new(0.0091d, new GammaParticle(924540.0, 0.00134)), new(0.0089d, new GammaParticle(936910.0, 0.00132)), new(0.00157d, new GammaParticle(957000.0, 0.0013)), new(0.012199999999999999d, new GammaParticle(977850.0, 0.00127)), new(0.001d, new GammaParticle(981600.0, 0.00126)), new(0.00209d, new GammaParticle(990670.0, 0.00125)), new(0.00105d, new GammaParticle(1000200.0, 0.00124)), new(0.00266d, new GammaParticle(1003420.0, 0.00124)), new(0.0008100000000000001d, new GammaParticle(1057100.0, 0.00117)), new(0.098d, new GammaParticle(1095260.0, 0.00113)), new(0.0138d, new GammaParticle(1098820.0, 0.00113)), new(0.00147d, new GammaParticle(1137340.0, 0.00109)), new(0.0015199999999999999d, new GammaParticle(1186460.0, 0.00104)), new(0.07200000000000001d, new GammaParticle(1242590.0, 0.001)), new(0.004699999999999999d, new GammaParticle(1265260.0, 0.00098)), new(0.00114d, new GammaParticle(1269400.0, 0.00098)), new(0.0048d, new GammaParticle(1295680.0, 0.00096)), new(0.0007099999999999999d, new GammaParticle(1300300.0, 0.00095)), new(0.0020399999999999997d, new GammaParticle(1315920.0, 0.00094)), new(0.001d, new GammaParticle(1319700.0, 0.00094)), new(0.0019500000000000001d, new GammaParticle(1323770.0, 0.00094)), new(0.0007599999999999999d, new GammaParticle(1394700.0, 0.00089)), new(0.00052d, new GammaParticle(1402900.0, 0.00088)), new(0.00209d, new GammaParticle(1443270.0, 0.00086)), new(0.00124d, new GammaParticle(1445500.0, 0.00086)), new(0.00052d, new GammaParticle(1456200.0, 0.00085)), new(0.0014299999999999998d, new GammaParticle(1462540.0, 0.00085)), new(0.0032d, new GammaParticle(1468240.0, 0.00084)), new(0.00043d, new GammaParticle(1499560.0, 0.00083)), new(0.00105d, new GammaParticle(1504580.0, 0.00082)), new(0.00057d, new GammaParticle(1528820.0, 0.00081)), new(0.00033d, new GammaParticle(1559300.0, 0.0008)), new(0.0008100000000000001d, new GammaParticle(1581990.0, 0.00078)), new(0.004699999999999999d, new GammaParticle(1604190.0, 0.00077)), new(0.00095d, new GammaParticle(1608700.0, 0.00077)), new(0.00018999999999999998d, new GammaParticle(1637000.0, 0.00076)), new(0.00048d, new GammaParticle(1683310.0, 0.00074)), new(0.00048d, new GammaParticle(1687200.0, 0.00073)), new(0.00048d, new GammaParticle(1701100.0, 0.00073)), new(0.00124d, new GammaParticle(1729680.0, 0.00072)), new(0.0008100000000000001d, new GammaParticle(1752050.0, 0.00071)), new(0.00185d, new GammaParticle(1759930.0, 0.0007)), new(0.00048d, new GammaParticle(1769200.0, 0.0007)), new(0.0077d, new GammaParticle(1834090.0, 0.00068)), new(0.0009d, new GammaParticle(1926400.0, 0.00064)), new(0.00057d, new GammaParticle(1929900.0, 0.00064)), new(0.00252d, new GammaParticle(1981670.0, 0.00063)), new(0.00086d, new GammaParticle(2282050.0, 0.00054)), new(0.00029d, new GammaParticle(2286500.0, 0.00054)), new(0.00124d, new GammaParticle(2359300.0, 0.00053)), new(0.00037999999999999997d, new GammaParticle(2380700.0, 0.00052)), new(0.00062d, new GammaParticle(2411700.0, 0.00051)), new(0.00024d, new GammaParticle(2418150.0, 0.00051)), new(0.00048d, new GammaParticle(2429360.0, 0.00051)), new(0.00067d, new GammaParticle(2507220.0, 0.00049)), new(0.00062d, new GammaParticle(2520150.0, 0.00049)), new(0.00057d, new GammaParticle(2609100.0, 0.00048)), new(0.00029d, new GammaParticle(2854000.0, 0.00043)), new(0.00048d, new GammaParticle(2909570.0, 0.00043)), new(0.00062d, new GammaParticle(2926690.0, 0.00042)), new(0.0001d, new GammaParticle(3002100.0, 0.00041)), new(0.00014000000000000001d, new GammaParticle(3023500.0, 0.00041)), new(0.00014000000000000001d, new GammaParticle(3078400.0, 0.0004)), new(0.00029d, new GammaParticle(3095000.0, 0.0004)), new(0.00048d, new GammaParticle(3171820.0, 0.00039)), new(0.00067d, new GammaParticle(3189650.0, 0.00039)), new(0.00014000000000000001d, new GammaParticle(3246000.0, 0.00038)), new(0.0001d, new GammaParticle(3359000.0, 0.00037)), new(0.00014000000000000001d, new GammaParticle(3457800.0, 0.00036)), new(0.00018999999999999998d, new GammaParticle(3590200.0, 0.00035)), new(1.9169200000000002d, new GammaParticle(511000.0, 0.00243)), new(0.0011650657697801d, new GammaParticle(1320.0, 0.93927)), new(0.009453282068348761d, new GammaParticle(10509.0, 0.11798)), new(0.01834520098651031d, new GammaParticle(10544.0, 0.11759)), new(0.0041946834133657065d, new GammaParticle(11773.0, 0.10531)), new(0.0043532424463909305d, new GammaParticle(11791.0, 0.10515)), new(0.00015855903302522368d, new GammaParticle(11861.0, 0.10453)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 1000.0d, 0.00000000010419d },
            { 2000.0d, 0.00000000306866d },
            { 3000.0d, 0.0000000353032d },
            { 4000.0d, 0.0000000954174d },
            { 5000.0d, 0.000000179803d },
            { 6000.0d, 0.000000288492d },
            { 7000.0d, 0.000000421501d },
            { 8000.0d, 0.000000578837d },
            { 9000.0d, 0.000000760874d },
            { 10000.0d, 0.000000967377d },
            { 11000.0d, 0.00000119859d },
            { 12000.0d, 0.00000145431d },
            { 13000.0d, 0.00000173436d },
            { 14000.0d, 0.0000020388d },
            { 15000.0d, 0.00000236715d },
            { 16000.0d, 0.00000271927d },
            { 17000.0d, 0.0000030903d },
            { 18000.0d, 0.00000348418d },
            { 19000.0d, 0.00000389308d },
            { 20000.0d, 0.0000043232d },
            { 21000.0d, 0.00000477344d },
            { 22000.0d, 0.0000052431d },
            { 23000.0d, 0.0000057275d },
            { 24000.0d, 0.0000062314d },
            { 25000.0d, 0.00000673638d },
            { 26000.0d, 0.00000725685d },
            { 27000.0d, 0.0000077931d },
            { 28000.0d, 0.00000833552d },
            { 29000.0d, 0.0000088904d },
            { 30000.0d, 0.00000945873d },
            { 31000.0d, 0.0000100397d },
            { 32000.0d, 0.0000106339d },
            { 33000.0d, 0.0000112352d },
            { 34000.0d, 0.0000118431d },
            { 35000.0d, 0.000012462d },
            { 36000.0d, 0.0000130908d },
            { 37000.0d, 0.0000137161d },
            { 38000.0d, 0.0000143496d },
            { 39000.0d, 0.0000149911d },
            { 40000.0d, 0.0000156408d },
            { 41000.0d, 0.0000162942d },
            { 42000.0d, 0.0000169547d },
            { 43000.0d, 0.0000176216d },
            { 44000.0d, 0.0000182954d },
            { 45000.0d, 0.0000189731d },
            { 46000.0d, 0.0000196532d },
            { 47000.0d, 0.0000203388d },
            { 48000.0d, 0.0000210299d },
            { 49000.0d, 0.00002172d },
            { 50000.0d, 0.000022414d },
            { 51000.0d, 0.000023112d },
            { 52000.0d, 0.0000238141d },
            { 53000.0d, 0.0000245204d },
            { 54000.0d, 0.0000252308d },
            { 55000.0d, 0.0000259428d },
            { 56000.0d, 0.0000266568d },
            { 57000.0d, 0.0000273721d },
            { 58000.0d, 0.0000280903d },
            { 59000.0d, 0.0000288113d },
            { 60000.0d, 0.0000295352d },
            { 61000.0d, 0.0000302597d },
            { 62000.0d, 0.0000309866d },
            { 63000.0d, 0.000031716d },
            { 64000.0d, 0.0000324462d },
            { 65000.0d, 0.0000331773d },
            { 66000.0d, 0.0000339103d },
            { 67000.0d, 0.0000346441d },
            { 68000.0d, 0.0000353796d },
            { 69000.0d, 0.0000361167d },
            { 70000.0d, 0.0000368555d },
            { 71000.0d, 0.0000375958d },
            { 72000.0d, 0.0000383376d },
            { 73000.0d, 0.0000390781d },
            { 74000.0d, 0.0000398196d },
            { 75000.0d, 0.0000405622d },
            { 76000.0d, 0.0000413057d },
            { 77000.0d, 0.0000420503d },
            { 78000.0d, 0.0000427952d },
            { 79000.0d, 0.000043541d },
            { 80000.0d, 0.0000442877d },
            { 81000.0d, 0.0000450347d },
            { 82000.0d, 0.0000457818d },
            { 83000.0d, 0.0000465296d },
            { 84000.0d, 0.0000472779d },
            { 85000.0d, 0.0000480262d },
            { 86000.0d, 0.0000487749d },
            { 87000.0d, 0.0000495241d },
            { 88000.0d, 0.0000502738d },
            { 89000.0d, 0.0000510232d },
            { 90000.0d, 0.000051773d },
            { 91000.0d, 0.0000525226d },
            { 92000.0d, 0.0000532725d },
            { 93000.0d, 0.0000540225d },
            { 94000.0d, 0.0000547728d },
            { 95000.0d, 0.0000555233d },
            { 96000.0d, 0.0000562741d },
            { 97000.0d, 0.0000570243d },
            { 98000.0d, 0.0000577747d },
            { 99000.0d, 0.0000585251d },
            { 100000.0d, 0.0000592751d },
            { 110000.0d, 0.0000667705d },
            { 120000.0d, 0.0000742435d },
            { 130000.0d, 0.0000816832d },
            { 140000.0d, 0.000089083d },
            { 150000.0d, 0.0000964379d },
            { 160000.0d, 0.000103745d },
            { 170000.0d, 0.000111001d },
            { 180000.0d, 0.000118206d },
            { 190000.0d, 0.000125358d },
            { 200000.0d, 0.000132457d },
            { 210000.0d, 0.000139502d },
            { 220000.0d, 0.000146493d },
            { 230000.0d, 0.00015343d },
            { 240000.0d, 0.000160312d },
            { 250000.0d, 0.00016714d },
            { 260000.0d, 0.000173913d },
            { 270000.0d, 0.000180631d },
            { 280000.0d, 0.000187294d },
            { 290000.0d, 0.000193902d },
            { 300000.0d, 0.000200455d },
            { 310000.0d, 0.000206952d },
            { 320000.0d, 0.000213394d },
            { 330000.0d, 0.00021978d },
            { 340000.0d, 0.000226109d },
            { 350000.0d, 0.000232382d },
            { 360000.0d, 0.000238598d },
            { 370000.0d, 0.000244758d },
            { 380000.0d, 0.00025086d },
            { 390000.0d, 0.000256904d },
            { 400000.0d, 0.000262891d },
            { 410000.0d, 0.000268819d },
            { 420000.0d, 0.00027469d },
            { 430000.0d, 0.000280501d },
            { 440000.0d, 0.000286254d },
            { 450000.0d, 0.000291947d },
            { 460000.0d, 0.000297581d },
            { 470000.0d, 0.000303155d },
            { 480000.0d, 0.000308669d },
            { 490000.0d, 0.000314123d },
            { 500000.0d, 0.000319517d },
            { 510000.0d, 0.00032485d },
            { 520000.0d, 0.000330122d },
            { 530000.0d, 0.000335333d },
            { 540000.0d, 0.000340483d },
            { 550000.0d, 0.000345572d },
            { 560000.0d, 0.000350597d },
            { 570000.0d, 0.000355553d },
            { 580000.0d, 0.00036044d },
            { 590000.0d, 0.000365258d },
            { 600000.0d, 0.000370005d },
            { 610000.0d, 0.000374681d },
            { 620000.0d, 0.000379286d },
            { 630000.0d, 0.000383819d },
            { 640000.0d, 0.00038828d },
            { 650000.0d, 0.000392668d },
            { 660000.0d, 0.000396982d },
            { 670000.0d, 0.000401223d },
            { 680000.0d, 0.000405389d },
            { 690000.0d, 0.000409481d },
            { 700000.0d, 0.000413498d },
            { 710000.0d, 0.00041744d },
            { 720000.0d, 0.000421305d },
            { 730000.0d, 0.000425095d },
            { 740000.0d, 0.000428809d },
            { 750000.0d, 0.000432445d },
            { 760000.0d, 0.000436004d },
            { 770000.0d, 0.000439487d },
            { 780000.0d, 0.000442892d },
            { 790000.0d, 0.000446219d },
            { 800000.0d, 0.000449467d },
            { 810000.0d, 0.000452638d },
            { 820000.0d, 0.00045573d },
            { 830000.0d, 0.000458743d },
            { 840000.0d, 0.000461678d },
            { 850000.0d, 0.000464535d },
            { 860000.0d, 0.000467312d },
            { 870000.0d, 0.00047001d },
            { 880000.0d, 0.000472628d },
            { 890000.0d, 0.000475167d },
            { 900000.0d, 0.000477628d },
            { 910000.0d, 0.000480009d },
            { 920000.0d, 0.000482311d },
            { 930000.0d, 0.000484533d },
            { 940000.0d, 0.000486677d },
            { 950000.0d, 0.000488741d },
            { 960000.0d, 0.000490727d },
            { 970000.0d, 0.000492632d },
            { 980000.0d, 0.00049446d },
            { 990000.0d, 0.000496209d },
            { 1000000.0d, 0.00049788d },
            { 1012000.0d, 0.000499781d },
            { 1024000.0d, 0.000501569d },
            { 1036000.0d, 0.000503245d },
            { 1048000.0d, 0.00050481d },
            { 1060000.0d, 0.000506263d },
            { 1072000.0d, 0.000507607d },
            { 1084000.0d, 0.000508839d },
            { 1096000.0d, 0.000509962d },
            { 1108000.0d, 0.000510977d },
            { 1120000.0d, 0.000511882d },
            { 1132000.0d, 0.000512681d },
            { 1144000.0d, 0.000513372d },
            { 1156000.0d, 0.000513957d },
            { 1168000.0d, 0.000514438d },
            { 1180000.0d, 0.000514814d },
            { 1192000.0d, 0.000515087d },
            { 1204000.0d, 0.000515257d },
            { 1216000.0d, 0.000515326d },
            { 1228000.0d, 0.000515292d },
            { 1240000.0d, 0.000515156d },
            { 1252000.0d, 0.000514919d },
            { 1264000.0d, 0.000514581d },
            { 1276000.0d, 0.000514143d },
            { 1288000.0d, 0.000513607d },
            { 1300000.0d, 0.000512972d },
            { 1312000.0d, 0.000512237d },
            { 1324000.0d, 0.000511401d },
            { 1336000.0d, 0.000510465d },
            { 1348000.0d, 0.000509429d },
            { 1360000.0d, 0.000508297d },
            { 1372000.0d, 0.000507065d },
            { 1384000.0d, 0.000505734d },
            { 1396000.0d, 0.000504307d },
            { 1408000.0d, 0.000502784d },
            { 1420000.0d, 0.000501166d },
            { 1432000.0d, 0.000499455d },
            { 1444000.0d, 0.000497651d },
            { 1456000.0d, 0.000495755d },
            { 1468000.0d, 0.000493772d },
            { 1480000.0d, 0.000491699d },
            { 1492000.0d, 0.00048954d },
            { 1504000.0d, 0.000487294d },
            { 1516000.0d, 0.000484964d },
            { 1528000.0d, 0.000482552d },
            { 1540000.0d, 0.000480058d },
            { 1552000.0d, 0.000477486d },
            { 1564000.0d, 0.000474835d },
            { 1576000.0d, 0.000472108d },
            { 1588000.0d, 0.000469306d },
            { 1600000.0d, 0.00046643d },
            { 1612000.0d, 0.000463484d },
            { 1624000.0d, 0.000460469d },
            { 1636000.0d, 0.000457386d },
            { 1648000.0d, 0.000454236d },
            { 1660000.0d, 0.000451022d },
            { 1672000.0d, 0.000447748d },
            { 1684000.0d, 0.000444413d },
            { 1696000.0d, 0.000441019d },
            { 1708000.0d, 0.000437569d },
            { 1720000.0d, 0.000434065d },
            { 1732000.0d, 0.00043051d },
            { 1744000.0d, 0.000426903d },
            { 1756000.0d, 0.000423243d },
            { 1768000.0d, 0.000419526d },
            { 1780000.0d, 0.000415755d },
            { 1792000.0d, 0.00041193d },
            { 1804000.0d, 0.000408055d },
            { 1816000.0d, 0.00040413d },
            { 1828000.0d, 0.000400159d },
            { 1840000.0d, 0.000396142d },
            { 1852000.0d, 0.000392083d },
            { 1864000.0d, 0.000387983d },
            { 1876000.0d, 0.000383844d },
            { 1888000.0d, 0.000379669d },
            { 1900000.0d, 0.000375459d },
            { 1912000.0d, 0.000371218d },
            { 1924000.0d, 0.000366947d },
            { 1936000.0d, 0.000362648d },
            { 1948000.0d, 0.000358324d },
            { 1960000.0d, 0.000353977d },
            { 1972000.0d, 0.00034961d },
            { 1984000.0d, 0.000345223d },
            { 1996000.0d, 0.000340817d },
            { 2008000.0d, 0.000336393d },
            { 2020000.0d, 0.000331955d },
            { 2032000.0d, 0.000327504d },
            { 2044000.0d, 0.000323044d },
            { 2056000.0d, 0.000318575d },
            { 2068000.0d, 0.000314102d },
            { 2080000.0d, 0.000309627d },
            { 2092000.0d, 0.000305152d },
            { 2104000.0d, 0.00030068d },
            { 2116000.0d, 0.000296213d },
            { 2128000.0d, 0.000291753d },
            { 2140000.0d, 0.000287303d },
            { 2152000.0d, 0.000282863d },
            { 2164000.0d, 0.00027844d },
            { 2176000.0d, 0.000274033d },
            { 2188000.0d, 0.000269647d },
            { 2200000.0d, 0.000265283d },
            { 2212000.0d, 0.000260947d },
            { 2224000.0d, 0.000256638d },
            { 2236000.0d, 0.000252362d },
            { 2248000.0d, 0.000248121d },
            { 2260000.0d, 0.000243917d },
            { 2272000.0d, 0.000239751d },
            { 2284000.0d, 0.000235626d },
            { 2296000.0d, 0.00023154d },
            { 2308000.0d, 0.000227493d },
            { 2320000.0d, 0.000223489d },
            { 2332000.0d, 0.000219526d },
            { 2344000.0d, 0.000215609d },
            { 2356000.0d, 0.000211741d },
            { 2368000.0d, 0.000207923d },
            { 2380000.0d, 0.00020416d },
            { 2392000.0d, 0.000200452d },
            { 2404000.0d, 0.000196806d },
            { 2416000.0d, 0.000193221d },
            { 2428000.0d, 0.000189701d },
            { 2440000.0d, 0.000186251d },
            { 2452000.0d, 0.000182872d },
            { 2464000.0d, 0.000179566d },
            { 2476000.0d, 0.000176338d },
            { 2488000.0d, 0.00017318d },
            { 2500000.0d, 0.00017005d },
            { 2512000.0d, 0.00016694d },
            { 2524000.0d, 0.000163853d },
            { 2536000.0d, 0.00016079d },
            { 2548000.0d, 0.000157753d },
            { 2560000.0d, 0.000154744d },
            { 2572000.0d, 0.000151763d },
            { 2584000.0d, 0.000148815d },
            { 2596000.0d, 0.000145898d },
            { 2608000.0d, 0.000143016d },
            { 2620000.0d, 0.00014017d },
            { 2632000.0d, 0.000137362d },
            { 2644000.0d, 0.000134594d },
            { 2656000.0d, 0.000131866d },
            { 2668000.0d, 0.000129182d },
            { 2680000.0d, 0.000126543d },
            { 2692000.0d, 0.000123951d },
            { 2704000.0d, 0.000121407d },
            { 2716000.0d, 0.000118914d },
            { 2728000.0d, 0.000116473d },
            { 2740000.0d, 0.000114085d },
            { 2752000.0d, 0.000111743d },
            { 2764000.0d, 0.000109427d },
            { 2776000.0d, 0.000107133d },
            { 2788000.0d, 0.000104862d },
            { 2800000.0d, 0.000102615d },
            { 2812000.0d, 0.000100393d },
            { 2824000.0d, 0.0000981957d },
            { 2836000.0d, 0.0000960239d },
            { 2848000.0d, 0.0000938791d },
            { 2860000.0d, 0.0000917603d },
            { 2872000.0d, 0.0000896522d },
            { 2884000.0d, 0.0000875519d },
            { 2896000.0d, 0.00008546d },
            { 2908000.0d, 0.0000833763d },
            { 2920000.0d, 0.0000813009d },
            { 2932000.0d, 0.0000792346d },
            { 2944000.0d, 0.0000771778d },
            { 2956000.0d, 0.0000751314d },
            { 2968000.0d, 0.0000730961d },
            { 2980000.0d, 0.0000710728d },
            { 2992000.0d, 0.0000690621d },
            { 3004000.0d, 0.0000670647d },
            { 3016000.0d, 0.0000650815d },
            { 3028000.0d, 0.0000631131d },
            { 3040000.0d, 0.0000611604d },
            { 3052000.0d, 0.0000592241d },
            { 3064000.0d, 0.000057305d },
            { 3076000.0d, 0.000055404d },
            { 3088000.0d, 0.0000535216d },
            { 3100000.0d, 0.0000516588d },
            { 3112000.0d, 0.0000498164d },
            { 3124000.0d, 0.0000479952d },
            { 3136000.0d, 0.0000461961d },
            { 3148000.0d, 0.0000444196d },
            { 3160000.0d, 0.0000426668d },
            { 3172000.0d, 0.0000409385d },
            { 3184000.0d, 0.0000392355d },
            { 3196000.0d, 0.0000375585d },
            { 3208000.0d, 0.0000359085d },
            { 3220000.0d, 0.0000342863d },
            { 3232000.0d, 0.0000326923d },
            { 3244000.0d, 0.0000311266d },
            { 3256000.0d, 0.0000295903d },
            { 3268000.0d, 0.0000280842d },
            { 3280000.0d, 0.0000266091d },
            { 3292000.0d, 0.0000251659d },
            { 3304000.0d, 0.0000237555d },
            { 3316000.0d, 0.0000223786d },
            { 3328000.0d, 0.0000210363d },
            { 3340000.0d, 0.0000197293d },
            { 3352000.0d, 0.0000184587d },
            { 3364000.0d, 0.0000172251d },
            { 3376000.0d, 0.0000160297d },
            { 3388000.0d, 0.0000148731d },
            { 3400000.0d, 0.0000137565d },
            { 3412000.0d, 0.0000126805d },
            { 3424000.0d, 0.0000116462d },
            { 3436000.0d, 0.0000106545d },
            { 3448000.0d, 0.00000970632d },
            { 3460000.0d, 0.00000880251d },
            { 3472000.0d, 0.00000794404d },
            { 3484000.0d, 0.0000071318d },
            { 3496000.0d, 0.00000636675d },
            { 3508000.0d, 0.00000564981d },
            { 3520000.0d, 0.00000498188d },
            { 3532000.0d, 0.00000436391d },
            { 3544000.0d, 0.0000037968d },
            { 3556000.0d, 0.00000328146d },
            { 3568000.0d, 0.00000281875d },
            { 3580000.0d, 0.00000240907d },
            { 3592000.0d, 0.00000203695d },
            { 3604000.0d, 0.00000169423d },
            { 3616000.0d, 0.00000138144d },
            { 3628000.0d, 0.00000109913d },
            { 3640000.0d, 0.000000847808d },
            { 3652000.0d, 0.000000628025d },
            { 3664000.0d, 0.000000440303d },
            { 3676000.0d, 0.000000285158d },
            { 3688000.0d, 0.000000163104d },
            { 3700000.0d, 0.0000000746278d },
            { 3712000.0d, 0.0000000201828d },
            { 3724000.0d, 0.000000000114991d },
            { 3725000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    