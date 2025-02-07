using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium43";
        public override double halfLife { get; } = 80280.0d;
        public override double atomicWeight { get; } = 42.96073d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Calcium43()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0480004d, new GammaParticle(220632.0, 0.00562)), new(0.868d, new GammaParticle(372760.0, 0.00333)), new(0.118482d, new GammaParticle(396861.0, 0.00312)), new(0.0036456d, new GammaParticle(404214.0, 0.00307)), new(0.1125796d, new GammaParticle(593390.0, 0.00209)), new(0.7916160000000001d, new GammaParticle(617490.0, 0.00201)), new(0.0014755999999999999d, new GammaParticle(801070.0, 0.00155)), new(0.0028643999999999996d, new GammaParticle(990245.0, 0.00125)), new(0.0196168d, new GammaParticle(1021698.0, 0.00121)), new(0.0013106799999999998d, new GammaParticle(1394448.0, 0.00089)), new(2.488844306505102e-06d, new GammaParticle(358.0, 3.46325)), new(3.316026156160955e-05d, new GammaParticle(3688.0, 0.33618)), new(6.552116491130122e-05d, new GammaParticle(3692.0, 0.33582)), new(1.2789112870889236e-05d, new GammaParticle(4013.0, 0.30896)), new(1.2789112870889236e-05d, new GammaParticle(4013.0, 0.30896)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00128818d },
            { 1000.0d, 0.00128908d },
            { 2000.0d, 0.00129026d },
            { 3000.0d, 0.00129171d },
            { 4000.0d, 0.00129318d },
            { 5000.0d, 0.00129465d },
            { 6000.0d, 0.00129616d },
            { 7000.0d, 0.00129819d },
            { 8000.0d, 0.00130058d },
            { 9000.0d, 0.00130336d },
            { 10000.0d, 0.00130651d },
            { 11000.0d, 0.00130996d },
            { 12000.0d, 0.00131372d },
            { 13000.0d, 0.00131767d },
            { 14000.0d, 0.00132186d },
            { 15000.0d, 0.0013262d },
            { 16000.0d, 0.00133071d },
            { 17000.0d, 0.00133532d },
            { 18000.0d, 0.00134006d },
            { 19000.0d, 0.00134487d },
            { 20000.0d, 0.00134977d },
            { 21000.0d, 0.00135471d },
            { 22000.0d, 0.00135971d },
            { 23000.0d, 0.00136475d },
            { 24000.0d, 0.00136983d },
            { 25000.0d, 0.00137492d },
            { 26000.0d, 0.00138004d },
            { 27000.0d, 0.00138516d },
            { 28000.0d, 0.00139029d },
            { 29000.0d, 0.00139542d },
            { 30000.0d, 0.00140054d },
            { 31000.0d, 0.00140566d },
            { 32000.0d, 0.00141078d },
            { 33000.0d, 0.00141588d },
            { 34000.0d, 0.00142097d },
            { 35000.0d, 0.00142604d },
            { 36000.0d, 0.0014311d },
            { 37000.0d, 0.00143613d },
            { 38000.0d, 0.00144114d },
            { 39000.0d, 0.00144613d },
            { 40000.0d, 0.0014511d },
            { 41000.0d, 0.00145603d },
            { 42000.0d, 0.00146095d },
            { 43000.0d, 0.00146583d },
            { 44000.0d, 0.00147069d },
            { 45000.0d, 0.00147552d },
            { 46000.0d, 0.00148033d },
            { 47000.0d, 0.0014851d },
            { 48000.0d, 0.00148985d },
            { 49000.0d, 0.00149456d },
            { 50000.0d, 0.00149924d },
            { 51000.0d, 0.00150389d },
            { 52000.0d, 0.00150851d },
            { 53000.0d, 0.0015131d },
            { 54000.0d, 0.00151766d },
            { 55000.0d, 0.00152218d },
            { 56000.0d, 0.00152668d },
            { 57000.0d, 0.00153114d },
            { 58000.0d, 0.00153558d },
            { 59000.0d, 0.00153997d },
            { 60000.0d, 0.00154434d },
            { 61000.0d, 0.00154867d },
            { 62000.0d, 0.00155297d },
            { 63000.0d, 0.00155724d },
            { 64000.0d, 0.00156147d },
            { 65000.0d, 0.00156567d },
            { 66000.0d, 0.00156984d },
            { 67000.0d, 0.00157398d },
            { 68000.0d, 0.00157808d },
            { 69000.0d, 0.00158215d },
            { 70000.0d, 0.00158619d },
            { 71000.0d, 0.0015902d },
            { 72000.0d, 0.00159417d },
            { 73000.0d, 0.00159811d },
            { 74000.0d, 0.00160202d },
            { 75000.0d, 0.0016059d },
            { 76000.0d, 0.00160974d },
            { 77000.0d, 0.00161356d },
            { 78000.0d, 0.00161735d },
            { 79000.0d, 0.0016211d },
            { 80000.0d, 0.00162481d },
            { 81000.0d, 0.0016285d },
            { 82000.0d, 0.00163215d },
            { 83000.0d, 0.00163577d },
            { 84000.0d, 0.00163936d },
            { 85000.0d, 0.00164292d },
            { 86000.0d, 0.00164645d },
            { 87000.0d, 0.00164994d },
            { 88000.0d, 0.0016534d },
            { 89000.0d, 0.00165684d },
            { 90000.0d, 0.00166025d },
            { 91000.0d, 0.00166362d },
            { 92000.0d, 0.00166695d },
            { 93000.0d, 0.00167026d },
            { 94000.0d, 0.00167354d },
            { 95000.0d, 0.00167679d },
            { 96000.0d, 0.00168001d },
            { 97000.0d, 0.00168319d },
            { 98000.0d, 0.00168635d },
            { 99000.0d, 0.00168947d },
            { 100000.0d, 0.00169257d },
            { 106000.0d, 0.00171051d },
            { 112000.0d, 0.00172738d },
            { 118000.0d, 0.00174318d },
            { 124000.0d, 0.00175796d },
            { 130000.0d, 0.0017717d },
            { 136000.0d, 0.00178443d },
            { 142000.0d, 0.00179616d },
            { 148000.0d, 0.00180691d },
            { 154000.0d, 0.00181669d },
            { 160000.0d, 0.00182551d },
            { 166000.0d, 0.00183339d },
            { 172000.0d, 0.00184033d },
            { 178000.0d, 0.00184635d },
            { 184000.0d, 0.00185145d },
            { 190000.0d, 0.00185566d },
            { 196000.0d, 0.00185899d },
            { 202000.0d, 0.00186143d },
            { 208000.0d, 0.00186301d },
            { 214000.0d, 0.00186374d },
            { 220000.0d, 0.00186363d },
            { 226000.0d, 0.00186268d },
            { 232000.0d, 0.00186091d },
            { 238000.0d, 0.00185834d },
            { 244000.0d, 0.00185498d },
            { 250000.0d, 0.00185084d },
            { 256000.0d, 0.00184592d },
            { 262000.0d, 0.00184024d },
            { 268000.0d, 0.00183383d },
            { 274000.0d, 0.00182668d },
            { 280000.0d, 0.00181882d },
            { 286000.0d, 0.00181024d },
            { 292000.0d, 0.00180098d },
            { 298000.0d, 0.00179104d },
            { 304000.0d, 0.00178044d },
            { 310000.0d, 0.00176919d },
            { 316000.0d, 0.00175732d },
            { 322000.0d, 0.00174482d },
            { 328000.0d, 0.00173172d },
            { 334000.0d, 0.00171804d },
            { 340000.0d, 0.00170377d },
            { 346000.0d, 0.00168897d },
            { 352000.0d, 0.00167363d },
            { 358000.0d, 0.00165776d },
            { 364000.0d, 0.0016414d },
            { 370000.0d, 0.00162456d },
            { 376000.0d, 0.00160725d },
            { 382000.0d, 0.00158949d },
            { 388000.0d, 0.0015713d },
            { 394000.0d, 0.0015527d },
            { 400000.0d, 0.00153372d },
            { 406000.0d, 0.00151437d },
            { 412000.0d, 0.00149466d },
            { 418000.0d, 0.00147462d },
            { 424000.0d, 0.00145429d },
            { 430000.0d, 0.00143367d },
            { 436000.0d, 0.00141277d },
            { 442000.0d, 0.00139162d },
            { 448000.0d, 0.00137008d },
            { 454000.0d, 0.00134815d },
            { 460000.0d, 0.00132584d },
            { 466000.0d, 0.00130318d },
            { 472000.0d, 0.00128017d },
            { 478000.0d, 0.00125684d },
            { 484000.0d, 0.0012332d },
            { 490000.0d, 0.00120927d },
            { 496000.0d, 0.00118506d },
            { 502000.0d, 0.00116059d },
            { 508000.0d, 0.00113589d },
            { 514000.0d, 0.00111096d },
            { 520000.0d, 0.00108583d },
            { 526000.0d, 0.00106051d },
            { 532000.0d, 0.00103503d },
            { 538000.0d, 0.0010094d },
            { 544000.0d, 0.000983647d },
            { 550000.0d, 0.000957782d },
            { 556000.0d, 0.00093183d },
            { 562000.0d, 0.000905811d },
            { 568000.0d, 0.000879745d },
            { 574000.0d, 0.000853654d },
            { 580000.0d, 0.000827557d },
            { 586000.0d, 0.000801477d },
            { 592000.0d, 0.000775436d },
            { 598000.0d, 0.000749456d },
            { 604000.0d, 0.000723559d },
            { 610000.0d, 0.000697767d },
            { 616000.0d, 0.000672104d },
            { 622000.0d, 0.000646592d },
            { 628000.0d, 0.000621255d },
            { 634000.0d, 0.000596117d },
            { 640000.0d, 0.000571201d },
            { 646000.0d, 0.000546534d },
            { 652000.0d, 0.000522137d },
            { 658000.0d, 0.000498037d },
            { 664000.0d, 0.000474259d },
            { 670000.0d, 0.000450829d },
            { 676000.0d, 0.00042777d },
            { 682000.0d, 0.000405112d },
            { 688000.0d, 0.000382878d },
            { 694000.0d, 0.000361095d },
            { 700000.0d, 0.000339791d },
            { 706000.0d, 0.000318994d },
            { 712000.0d, 0.000298728d },
            { 718000.0d, 0.000279024d },
            { 724000.0d, 0.000259909d },
            { 730000.0d, 0.00024141d },
            { 736000.0d, 0.000223557d },
            { 742000.0d, 0.000206378d },
            { 748000.0d, 0.000189901d },
            { 754000.0d, 0.000174157d },
            { 760000.0d, 0.000159175d },
            { 766000.0d, 0.000144985d },
            { 772000.0d, 0.000131616d },
            { 778000.0d, 0.000119099d },
            { 784000.0d, 0.000107465d },
            { 790000.0d, 0.0000967446d },
            { 796000.0d, 0.000086968d },
            { 802000.0d, 0.0000781669d },
            { 808000.0d, 0.0000703727d },
            { 814000.0d, 0.0000636169d },
            { 820000.0d, 0.0000579313d },
            { 826000.0d, 0.0000533473d },
            { 832000.0d, 0.0000498968d },
            { 838000.0d, 0.000047611d },
            { 844000.0d, 0.0000465053d },
            { 850000.0d, 0.0000458336d },
            { 856000.0d, 0.0000451591d },
            { 862000.0d, 0.000044482d },
            { 868000.0d, 0.0000438025d },
            { 874000.0d, 0.0000431209d },
            { 880000.0d, 0.0000424376d },
            { 886000.0d, 0.0000417528d },
            { 892000.0d, 0.0000410667d },
            { 898000.0d, 0.0000403796d },
            { 904000.0d, 0.0000396919d },
            { 910000.0d, 0.0000390038d },
            { 916000.0d, 0.0000383158d },
            { 922000.0d, 0.0000376279d },
            { 928000.0d, 0.0000369405d },
            { 934000.0d, 0.000036254d },
            { 940000.0d, 0.0000355686d },
            { 946000.0d, 0.0000348847d },
            { 952000.0d, 0.0000342026d },
            { 958000.0d, 0.0000335225d },
            { 964000.0d, 0.0000328449d },
            { 970000.0d, 0.00003217d },
            { 976000.0d, 0.0000314982d },
            { 982000.0d, 0.0000308298d },
            { 988000.0d, 0.0000301651d },
            { 994000.0d, 0.0000295044d },
            { 1000000.0d, 0.0000288481d },
            { 1006000.0d, 0.0000281967d },
            { 1012000.0d, 0.0000275503d },
            { 1018000.0d, 0.0000269092d },
            { 1024000.0d, 0.000026274d },
            { 1030000.0d, 0.000025645d },
            { 1036000.0d, 0.0000250224d },
            { 1042000.0d, 0.0000244067d },
            { 1048000.0d, 0.0000237983d },
            { 1054000.0d, 0.0000231975d },
            { 1060000.0d, 0.0000226045d },
            { 1066000.0d, 0.0000220199d },
            { 1072000.0d, 0.000021444d },
            { 1078000.0d, 0.0000208773d },
            { 1084000.0d, 0.00002032d },
            { 1090000.0d, 0.0000197725d },
            { 1096000.0d, 0.0000192353d },
            { 1102000.0d, 0.0000187087d },
            { 1108000.0d, 0.0000181931d },
            { 1114000.0d, 0.0000176891d },
            { 1120000.0d, 0.0000171968d },
            { 1126000.0d, 0.0000167168d },
            { 1132000.0d, 0.0000162493d },
            { 1138000.0d, 0.000015795d },
            { 1144000.0d, 0.0000153541d },
            { 1150000.0d, 0.0000149272d },
            { 1156000.0d, 0.0000145145d },
            { 1162000.0d, 0.0000141165d },
            { 1168000.0d, 0.0000137337d },
            { 1174000.0d, 0.0000133665d },
            { 1180000.0d, 0.0000130153d },
            { 1186000.0d, 0.0000126805d },
            { 1192000.0d, 0.0000123626d },
            { 1198000.0d, 0.000012062d },
            { 1204000.0d, 0.0000117791d },
            { 1210000.0d, 0.0000115145d },
            { 1216000.0d, 0.0000112684d },
            { 1222000.0d, 0.0000110415d },
            { 1228000.0d, 0.000010834d },
            { 1234000.0d, 0.0000106465d },
            { 1240000.0d, 0.0000104792d },
            { 1246000.0d, 0.0000103223d },
            { 1252000.0d, 0.0000101656d },
            { 1258000.0d, 0.0000100092d },
            { 1264000.0d, 0.00000985307d },
            { 1270000.0d, 0.00000969727d },
            { 1276000.0d, 0.00000954188d },
            { 1282000.0d, 0.00000938694d },
            { 1288000.0d, 0.0000092325d },
            { 1294000.0d, 0.00000907862d },
            { 1300000.0d, 0.00000892535d },
            { 1306000.0d, 0.00000877276d },
            { 1312000.0d, 0.00000862088d },
            { 1318000.0d, 0.0000084698d },
            { 1324000.0d, 0.00000831955d },
            { 1330000.0d, 0.00000817021d },
            { 1336000.0d, 0.00000802183d },
            { 1342000.0d, 0.00000787448d },
            { 1348000.0d, 0.00000772823d },
            { 1354000.0d, 0.00000758312d },
            { 1360000.0d, 0.00000743923d },
            { 1366000.0d, 0.00000729664d },
            { 1372000.0d, 0.0000071554d },
            { 1378000.0d, 0.00000701558d },
            { 1384000.0d, 0.00000687726d },
            { 1390000.0d, 0.00000674051d },
            { 1396000.0d, 0.0000066054d },
            { 1402000.0d, 0.000006472d },
            { 1408000.0d, 0.00000634039d },
            { 1414000.0d, 0.00000621065d },
            { 1420000.0d, 0.00000608286d },
            { 1426000.0d, 0.00000595709d },
            { 1432000.0d, 0.00000583342d },
            { 1438000.0d, 0.00000571194d },
            { 1444000.0d, 0.00000559272d },
            { 1450000.0d, 0.00000547585d },
            { 1456000.0d, 0.00000536141d },
            { 1462000.0d, 0.00000524938d },
            { 1468000.0d, 0.00000513781d },
            { 1474000.0d, 0.00000502586d },
            { 1480000.0d, 0.00000491356d },
            { 1486000.0d, 0.00000480097d },
            { 1492000.0d, 0.0000046881d },
            { 1498000.0d, 0.00000457503d },
            { 1504000.0d, 0.00000446177d },
            { 1510000.0d, 0.0000043484d },
            { 1516000.0d, 0.00000423494d },
            { 1522000.0d, 0.00000412145d },
            { 1528000.0d, 0.00000400798d },
            { 1534000.0d, 0.00000389459d },
            { 1540000.0d, 0.00000378133d },
            { 1546000.0d, 0.00000366824d },
            { 1552000.0d, 0.00000355539d },
            { 1558000.0d, 0.00000344283d },
            { 1564000.0d, 0.00000333064d },
            { 1570000.0d, 0.00000321887d },
            { 1576000.0d, 0.00000310757d },
            { 1582000.0d, 0.00000299683d },
            { 1588000.0d, 0.0000028867d },
            { 1594000.0d, 0.00000277725d },
            { 1600000.0d, 0.00000266856d },
            { 1606000.0d, 0.0000025607d },
            { 1612000.0d, 0.00000245374d },
            { 1618000.0d, 0.00000234777d },
            { 1624000.0d, 0.00000224284d },
            { 1630000.0d, 0.00000213905d },
            { 1636000.0d, 0.00000203649d },
            { 1642000.0d, 0.00000193523d },
            { 1648000.0d, 0.00000183535d },
            { 1654000.0d, 0.00000173696d },
            { 1660000.0d, 0.00000164014d },
            { 1666000.0d, 0.00000154497d },
            { 1672000.0d, 0.00000145156d },
            { 1678000.0d, 0.00000136001d },
            { 1684000.0d, 0.0000012704d },
            { 1690000.0d, 0.00000118285d },
            { 1696000.0d, 0.00000109745d },
            { 1702000.0d, 0.00000101431d },
            { 1708000.0d, 0.000000933546d },
            { 1714000.0d, 0.000000855256d },
            { 1720000.0d, 0.000000779557d },
            { 1726000.0d, 0.000000706565d },
            { 1732000.0d, 0.000000636395d },
            { 1738000.0d, 0.000000569167d },
            { 1744000.0d, 0.000000505003d },
            { 1750000.0d, 0.000000444026d },
            { 1756000.0d, 0.000000386364d },
            { 1762000.0d, 0.000000332145d },
            { 1768000.0d, 0.000000281501d },
            { 1774000.0d, 0.000000234564d },
            { 1780000.0d, 0.00000019147d },
            { 1786000.0d, 0.000000152359d },
            { 1792000.0d, 0.00000011737d },
            { 1798000.0d, 0.0000000866464d },
            { 1804000.0d, 0.0000000603323d },
            { 1810000.0d, 0.0000000385741d },
            { 1816000.0d, 0.0000000215193d },
            { 1822000.0d, 0.00000000931569d },
            { 1828000.0d, 0.00000000210908d },
            { 1833400.0d, 0d },

        }; 
    }
}
    