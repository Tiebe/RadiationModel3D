using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum132m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum132m";
        public override double halfLife { get; } = 1458.0d;
        public override double atomicWeight { get; } = 131.91033d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.76d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum132()), new(0.0004d, new GammaParticle(52800.0, 0.02348)), new(0.49d, new GammaParticle(135800.0, 0.00913)), new(0.00296d, new GammaParticle(188500.0, 0.00658)), new(0.0934027847532d, new GammaParticle(5185.0, 0.23912)), new(0.11083397835140828d, new GammaParticle(33034.0, 0.03753)), new(0.20358923282771543d, new GammaParticle(33442.0, 0.03707)), new(0.060626215339885305d, new GammaParticle(37908.0, 0.03271)), new(0.07596464782087628d, new GammaParticle(38273.0, 0.03239)), new(0.015338432480990984d, new GammaParticle(38725.0, 0.03202)) } },
            { 0.24d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium132()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00015d, new GammaParticle(73100.0, 0.01696)), new(4.3e-05d, new GammaParticle(82600.0, 0.01501)), new(0.000281d, new GammaParticle(92700.0, 0.01337)), new(1.3e-05d, new GammaParticle(102300.0, 0.01212)), new(0.0006900000000000001d, new GammaParticle(131700.0, 0.00941)), new(0.00156d, new GammaParticle(175200.0, 0.00708)), new(0.0026d, new GammaParticle(187600.0, 0.00661)), new(0.0019d, new GammaParticle(192800.0, 0.00643)), new(6.5e-05d, new GammaParticle(218200.0, 0.00568)), new(0.039d, new GammaParticle(238300.0, 0.0052)), new(0.00086d, new GammaParticle(265900.0, 0.00466)), new(0.071d, new GammaParticle(285400.0, 0.00434)), new(0.022000000000000002d, new GammaParticle(297600.0, 0.00417)), new(0.00045d, new GammaParticle(317100.0, 0.00391)), new(0.0063d, new GammaParticle(330500.0, 0.00375)), new(3.2e-05d, new GammaParticle(360660.0, 0.00344)), new(0.0005d, new GammaParticle(368200.0, 0.00337)), new(2.8e-05d, new GammaParticle(380400.0, 0.00326)), new(0.0022d, new GammaParticle(383400.0, 0.00323)), new(2.8e-06d, new GammaParticle(386000.0, 0.00321)), new(0.048d, new GammaParticle(390510.0, 0.00317)), new(0.21600000000000003d, new GammaParticle(464550.0, 0.00267)), new(0.035d, new GammaParticle(479470.0, 0.00259)), new(0.069d, new GammaParticle(515780.0, 0.0024)), new(0.00041d, new GammaParticle(535500.0, 0.00232)), new(0.043d, new GammaParticle(567140.0, 0.00219)), new(0.006d, new GammaParticle(583100.0, 0.00213)), new(0.015d, new GammaParticle(601750.0, 0.00206)), new(0.00033d, new GammaParticle(628560.0, 0.00197)), new(0.00097d, new GammaParticle(654030.0, 0.0019)), new(0.11199999999999999d, new GammaParticle(663070.0, 0.00187)), new(0.039d, new GammaParticle(697680.0, 0.00178)), new(8.6e-05d, new GammaParticle(801500.0, 0.00155)), new(8.999999999999999e-05d, new GammaParticle(804200.0, 0.00154)), new(0.00151d, new GammaParticle(816600.0, 0.00152)), new(0.065d, new GammaParticle(899320.0, 0.00138)), new(0.00016d, new GammaParticle(912500.0, 0.00136)), new(0.0005600000000000001d, new GammaParticle(918680.0, 0.00135)), new(0.027999999999999997d, new GammaParticle(991950.0, 0.00125)), new(0.00013d, new GammaParticle(1014590.0, 0.00122)), new(0.024d, new GammaParticle(1031700.0, 0.0012)), new(0.055999999999999994d, new GammaParticle(1046560.0, 0.00118)), new(2.8e-05d, new GammaParticle(1087900.0, 0.00114)), new(0.00099d, new GammaParticle(1195820.0, 0.00104)), new(0.0083d, new GammaParticle(1221230.0, 0.00102)), new(0.013000000000000001d, new GammaParticle(1264770.0, 0.00098)), new(4e-05d, new GammaParticle(1479700.0, 0.00084)), new(0.00043d, new GammaParticle(1562300.0, 0.00079)), new(7.1e-05d, new GammaParticle(1581900.0, 0.00078)), new(0.00039d, new GammaParticle(1655000.0, 0.00075)), new(0.146d, new GammaParticle(511000.0, 0.00243)), new(0.01725899115952d, new GammaParticle(4966.0, 0.24967)), new(0.03911164388257036d, new GammaParticle(31816.0, 0.03897)), new(0.07205534982050545d, new GammaParticle(32193.0, 0.03851)), new(0.021194537856968204d, new GammaParticle(36482.0, 0.03399)), new(0.026535561396924194d, new GammaParticle(36827.0, 0.03367)), new(0.005341023539955988d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 4000.0d, 0.00000000263746d },
            { 8000.0d, 0.0000000218624d },
            { 12000.0d, 0.000000063369d },
            { 16000.0d, 0.000000138387d },
            { 20000.0d, 0.000000251209d },
            { 24000.0d, 0.000000404724d },
            { 28000.0d, 0.000000598996d },
            { 32000.0d, 0.000000833385d },
            { 36000.0d, 0.00000110637d },
            { 40000.0d, 0.00000141551d },
            { 44000.0d, 0.00000175842d },
            { 48000.0d, 0.00000213282d },
            { 52000.0d, 0.0000025359d },
            { 56000.0d, 0.0000029655d },
            { 60000.0d, 0.00000341914d },
            { 64000.0d, 0.00000389417d },
            { 68000.0d, 0.00000438907d },
            { 72000.0d, 0.00000490177d },
            { 76000.0d, 0.00000543027d },
            { 80000.0d, 0.00000597311d },
            { 84000.0d, 0.00000652853d },
            { 88000.0d, 0.00000709519d },
            { 92000.0d, 0.00000767193d },
            { 96000.0d, 0.00000825748d },
            { 100000.0d, 0.00000885064d },
            { 106000.0d, 0.00000975256d },
            { 112000.0d, 0.0000106664d },
            { 118000.0d, 0.0000115895d },
            { 124000.0d, 0.0000125195d },
            { 130000.0d, 0.0000134542d },
            { 136000.0d, 0.0000143916d },
            { 142000.0d, 0.0000153303d },
            { 148000.0d, 0.0000162686d },
            { 154000.0d, 0.0000172054d },
            { 160000.0d, 0.0000181394d },
            { 166000.0d, 0.0000190696d },
            { 172000.0d, 0.000019995d },
            { 178000.0d, 0.0000209149d },
            { 184000.0d, 0.0000218284d },
            { 190000.0d, 0.000022735d },
            { 196000.0d, 0.000023634d },
            { 202000.0d, 0.0000245249d },
            { 208000.0d, 0.0000254071d },
            { 214000.0d, 0.0000262804d },
            { 220000.0d, 0.0000271442d },
            { 226000.0d, 0.0000279982d },
            { 232000.0d, 0.0000288421d },
            { 238000.0d, 0.0000296756d },
            { 244000.0d, 0.0000304985d },
            { 250000.0d, 0.0000313105d },
            { 256000.0d, 0.0000321115d },
            { 262000.0d, 0.000032901d },
            { 268000.0d, 0.0000336792d },
            { 274000.0d, 0.0000344457d },
            { 280000.0d, 0.0000352005d },
            { 286000.0d, 0.0000359434d },
            { 292000.0d, 0.0000366743d },
            { 298000.0d, 0.0000373931d },
            { 304000.0d, 0.0000380997d },
            { 310000.0d, 0.0000387941d },
            { 316000.0d, 0.000039476d },
            { 322000.0d, 0.0000401456d },
            { 328000.0d, 0.0000408028d },
            { 334000.0d, 0.0000414474d },
            { 340000.0d, 0.0000420795d },
            { 346000.0d, 0.0000426989d },
            { 352000.0d, 0.0000433059d },
            { 358000.0d, 0.0000439001d },
            { 364000.0d, 0.0000444817d },
            { 370000.0d, 0.0000450506d },
            { 376000.0d, 0.0000456069d },
            { 382000.0d, 0.0000461504d },
            { 388000.0d, 0.0000466814d },
            { 394000.0d, 0.0000471994d },
            { 400000.0d, 0.000047705d },
            { 406000.0d, 0.0000481978d },
            { 412000.0d, 0.0000486781d },
            { 418000.0d, 0.0000491455d },
            { 424000.0d, 0.0000496005d },
            { 430000.0d, 0.0000500427d },
            { 436000.0d, 0.0000504724d },
            { 442000.0d, 0.0000508896d },
            { 448000.0d, 0.0000512942d },
            { 454000.0d, 0.0000516863d },
            { 460000.0d, 0.0000520659d },
            { 466000.0d, 0.0000524329d },
            { 472000.0d, 0.0000527877d },
            { 478000.0d, 0.0000531301d },
            { 484000.0d, 0.0000534602d },
            { 490000.0d, 0.0000537778d },
            { 496000.0d, 0.0000540832d },
            { 502000.0d, 0.0000543765d },
            { 508000.0d, 0.0000546576d },
            { 514000.0d, 0.0000549266d },
            { 520000.0d, 0.0000551835d },
            { 526000.0d, 0.0000554284d },
            { 532000.0d, 0.0000556612d },
            { 538000.0d, 0.0000558821d },
            { 544000.0d, 0.0000560911d },
            { 550000.0d, 0.0000562885d },
            { 556000.0d, 0.0000564739d },
            { 562000.0d, 0.0000566478d },
            { 568000.0d, 0.0000568099d },
            { 574000.0d, 0.0000569605d },
            { 580000.0d, 0.0000570995d },
            { 586000.0d, 0.000057227d },
            { 592000.0d, 0.0000573432d },
            { 598000.0d, 0.0000574482d },
            { 604000.0d, 0.0000575417d },
            { 610000.0d, 0.000057624d },
            { 616000.0d, 0.0000576953d },
            { 622000.0d, 0.0000577555d },
            { 628000.0d, 0.0000578047d },
            { 634000.0d, 0.000057843d },
            { 640000.0d, 0.0000578704d },
            { 646000.0d, 0.0000578869d },
            { 652000.0d, 0.0000578929d },
            { 658000.0d, 0.0000578882d },
            { 664000.0d, 0.0000578729d },
            { 670000.0d, 0.0000578472d },
            { 676000.0d, 0.000057811d },
            { 682000.0d, 0.0000577646d },
            { 688000.0d, 0.0000577078d },
            { 694000.0d, 0.0000576411d },
            { 700000.0d, 0.0000575641d },
            { 706000.0d, 0.0000574772d },
            { 712000.0d, 0.0000573804d },
            { 718000.0d, 0.0000572738d },
            { 724000.0d, 0.0000571574d },
            { 730000.0d, 0.0000570314d },
            { 736000.0d, 0.0000568958d },
            { 742000.0d, 0.0000567507d },
            { 748000.0d, 0.0000565964d },
            { 754000.0d, 0.0000564327d },
            { 760000.0d, 0.0000562597d },
            { 766000.0d, 0.0000560778d },
            { 772000.0d, 0.0000558868d },
            { 778000.0d, 0.000055687d },
            { 784000.0d, 0.0000554782d },
            { 790000.0d, 0.0000552609d },
            { 796000.0d, 0.0000550349d },
            { 802000.0d, 0.0000548003d },
            { 808000.0d, 0.0000545575d },
            { 814000.0d, 0.0000543062d },
            { 820000.0d, 0.0000540466d },
            { 826000.0d, 0.0000537791d },
            { 832000.0d, 0.0000535035d },
            { 838000.0d, 0.0000532201d },
            { 844000.0d, 0.0000529289d },
            { 850000.0d, 0.0000526298d },
            { 856000.0d, 0.0000523233d },
            { 862000.0d, 0.0000520094d },
            { 868000.0d, 0.0000516881d },
            { 874000.0d, 0.0000513597d },
            { 880000.0d, 0.000051024d },
            { 886000.0d, 0.0000506812d },
            { 892000.0d, 0.0000503318d },
            { 898000.0d, 0.0000499754d },
            { 904000.0d, 0.0000496124d },
            { 910000.0d, 0.0000492428d },
            { 916000.0d, 0.0000488669d },
            { 922000.0d, 0.0000484847d },
            { 928000.0d, 0.0000480962d },
            { 934000.0d, 0.0000477017d },
            { 940000.0d, 0.0000473014d },
            { 946000.0d, 0.000046895d },
            { 952000.0d, 0.0000464832d },
            { 958000.0d, 0.0000460657d },
            { 964000.0d, 0.0000456428d },
            { 970000.0d, 0.0000452147d },
            { 976000.0d, 0.0000447813d },
            { 982000.0d, 0.000044343d },
            { 988000.0d, 0.0000438997d },
            { 994000.0d, 0.0000434517d },
            { 1000000.0d, 0.000042999d },
            { 1006000.0d, 0.0000425419d },
            { 1012000.0d, 0.0000420804d },
            { 1018000.0d, 0.0000416147d },
            { 1024000.0d, 0.0000411449d },
            { 1030000.0d, 0.0000406713d },
            { 1036000.0d, 0.0000401937d },
            { 1042000.0d, 0.0000397126d },
            { 1048000.0d, 0.000039228d },
            { 1054000.0d, 0.00003874d },
            { 1060000.0d, 0.0000382488d },
            { 1066000.0d, 0.0000377545d },
            { 1072000.0d, 0.0000372573d },
            { 1078000.0d, 0.0000367574d },
            { 1084000.0d, 0.0000362549d },
            { 1090000.0d, 0.0000357499d },
            { 1096000.0d, 0.0000352426d },
            { 1102000.0d, 0.0000347332d },
            { 1108000.0d, 0.0000342219d },
            { 1114000.0d, 0.0000337086d },
            { 1120000.0d, 0.0000331938d },
            { 1126000.0d, 0.0000326774d },
            { 1132000.0d, 0.0000321598d },
            { 1138000.0d, 0.000031641d },
            { 1144000.0d, 0.0000311211d },
            { 1150000.0d, 0.0000306004d },
            { 1156000.0d, 0.0000300791d },
            { 1162000.0d, 0.0000295572d },
            { 1168000.0d, 0.0000290351d },
            { 1174000.0d, 0.0000285128d },
            { 1180000.0d, 0.0000279905d },
            { 1186000.0d, 0.0000274684d },
            { 1192000.0d, 0.0000269467d },
            { 1198000.0d, 0.0000264256d },
            { 1204000.0d, 0.0000259052d },
            { 1210000.0d, 0.0000253857d },
            { 1216000.0d, 0.0000248673d },
            { 1222000.0d, 0.0000243503d },
            { 1228000.0d, 0.0000238347d },
            { 1234000.0d, 0.0000233207d },
            { 1240000.0d, 0.0000228086d },
            { 1246000.0d, 0.0000222986d },
            { 1252000.0d, 0.0000217908d },
            { 1258000.0d, 0.0000212855d },
            { 1264000.0d, 0.0000207828d },
            { 1270000.0d, 0.0000202829d },
            { 1276000.0d, 0.000019786d },
            { 1282000.0d, 0.0000192924d },
            { 1288000.0d, 0.0000188022d },
            { 1294000.0d, 0.0000183156d },
            { 1300000.0d, 0.0000178329d },
            { 1306000.0d, 0.0000173543d },
            { 1312000.0d, 0.0000168799d },
            { 1318000.0d, 0.0000164099d },
            { 1324000.0d, 0.0000159447d },
            { 1330000.0d, 0.0000154844d },
            { 1336000.0d, 0.0000150291d },
            { 1342000.0d, 0.0000145793d },
            { 1348000.0d, 0.0000141349d },
            { 1354000.0d, 0.0000136964d },
            { 1360000.0d, 0.0000132638d },
            { 1366000.0d, 0.0000128375d },
            { 1372000.0d, 0.0000124176d },
            { 1378000.0d, 0.0000120044d },
            { 1384000.0d, 0.0000115981d },
            { 1390000.0d, 0.000011199d },
            { 1396000.0d, 0.0000108072d },
            { 1402000.0d, 0.0000104231d },
            { 1408000.0d, 0.0000100468d },
            { 1414000.0d, 0.00000967862d },
            { 1420000.0d, 0.00000931874d },
            { 1426000.0d, 0.00000896747d },
            { 1432000.0d, 0.00000862501d },
            { 1438000.0d, 0.00000829162d },
            { 1444000.0d, 0.00000796754d },
            { 1450000.0d, 0.00000765303d },
            { 1456000.0d, 0.00000734835d },
            { 1462000.0d, 0.00000705374d },
            { 1468000.0d, 0.00000676946d },
            { 1474000.0d, 0.00000649577d },
            { 1480000.0d, 0.00000623291d },
            { 1486000.0d, 0.00000598116d },
            { 1492000.0d, 0.00000574076d },
            { 1498000.0d, 0.00000551197d },
            { 1504000.0d, 0.00000529353d },
            { 1510000.0d, 0.00000508296d },
            { 1516000.0d, 0.00000488039d },
            { 1522000.0d, 0.00000468601d },
            { 1528000.0d, 0.00000450001d },
            { 1534000.0d, 0.00000432259d },
            { 1540000.0d, 0.00000415393d },
            { 1546000.0d, 0.0000039938d },
            { 1552000.0d, 0.00000383709d },
            { 1558000.0d, 0.00000368226d },
            { 1564000.0d, 0.00000352941d },
            { 1570000.0d, 0.00000337862d },
            { 1576000.0d, 0.00000322999d },
            { 1582000.0d, 0.0000030836d },
            { 1588000.0d, 0.00000293955d },
            { 1594000.0d, 0.00000279794d },
            { 1600000.0d, 0.00000265884d },
            { 1606000.0d, 0.00000252237d },
            { 1612000.0d, 0.00000238863d },
            { 1618000.0d, 0.0000022577d },
            { 1624000.0d, 0.0000021297d },
            { 1630000.0d, 0.00000200472d },
            { 1636000.0d, 0.00000188288d },
            { 1642000.0d, 0.00000176427d },
            { 1648000.0d, 0.00000164901d },
            { 1654000.0d, 0.00000153721d },
            { 1660000.0d, 0.00000142898d },
            { 1666000.0d, 0.00000132444d },
            { 1672000.0d, 0.0000012237d },
            { 1678000.0d, 0.00000112687d },
            { 1684000.0d, 0.00000103407d },
            { 1690000.0d, 0.000000945435d },
            { 1696000.0d, 0.000000861077d },
            { 1702000.0d, 0.000000781121d },
            { 1708000.0d, 0.000000705693d },
            { 1714000.0d, 0.000000634921d },
            { 1720000.0d, 0.000000568931d },
            { 1726000.0d, 0.000000507854d },
            { 1732000.0d, 0.000000451818d },
            { 1738000.0d, 0.000000400904d },
            { 1744000.0d, 0.000000353398d },
            { 1750000.0d, 0.000000308412d },
            { 1756000.0d, 0.000000266045d },
            { 1762000.0d, 0.000000226395d },
            { 1768000.0d, 0.000000189564d },
            { 1774000.0d, 0.000000155659d },
            { 1780000.0d, 0.000000124783d },
            { 1786000.0d, 0.0000000970445d },
            { 1792000.0d, 0.0000000725531d },
            { 1798000.0d, 0.0000000514189d },
            { 1804000.0d, 0.0000000337546d },
            { 1810000.0d, 0.0000000196736d },
            { 1816000.0d, 0.00000000928984d },
            { 1822000.0d, 0.00000000271643d },
            { 1828000.0d, 0.000000000057687d },
            { 1829000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    