using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium148";
        public override double halfLife { get; } = 56.8d;
        public override double atomicWeight { get; } = 147.92442d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium148()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.001368d, new GammaParticle(74500.0, 0.01664)), new(0.021033d, new GammaParticle(90890.0, 0.01364)), new(0.013167d, new GammaParticle(98000.0, 0.01265)), new(0.015903d, new GammaParticle(98166.0, 0.01263)), new(0.126882d, new GammaParticle(98990.0, 0.01252)), new(0.036765d, new GammaParticle(101029.0, 0.01227)), new(0.002565d, new GammaParticle(103200.0, 0.01201)), new(0.053694d, new GammaParticle(105200.0, 0.01179)), new(0.038475d, new GammaParticle(116920.0, 0.0106)), new(0.13509000000000002d, new GammaParticle(121169.0, 0.01023)), new(0.011286000000000001d, new GammaParticle(167800.0, 0.00739)), new(0.0034200000000000003d, new GammaParticle(168520.0, 0.00736)), new(0.016929d, new GammaParticle(184530.0, 0.00672)), new(0.01539d, new GammaParticle(187900.0, 0.0066)), new(0.011798999999999999d, new GammaParticle(188500.0, 0.00658)), new(0.016929d, new GammaParticle(191600.0, 0.00647)), new(0.0034200000000000003d, new GammaParticle(193800.0, 0.0064)), new(0.04104d, new GammaParticle(194690.0, 0.00637)), new(0.06669d, new GammaParticle(195977.0, 0.00633)), new(0.0034200000000000003d, new GammaParticle(231600.0, 0.00535)), new(0.01026d, new GammaParticle(233710.0, 0.00531)), new(0.009576d, new GammaParticle(247520.0, 0.00501)), new(0.174078d, new GammaParticle(269520.0, 0.0046)), new(0.006840000000000001d, new GammaParticle(271500.0, 0.00457)), new(0.055746000000000004d, new GammaParticle(273770.0, 0.00453)), new(0.008208d, new GammaParticle(285500.0, 0.00434)), new(0.01881d, new GammaParticle(287170.0, 0.00432)), new(0.05814d, new GammaParticle(289640.0, 0.00428)), new(0.171d, new GammaParticle(291724.0, 0.00425)), new(0.077463d, new GammaParticle(324850.0, 0.00382)), new(0.01539d, new GammaParticle(332700.0, 0.00373)), new(0.005985000000000001d, new GammaParticle(346300.0, 0.00358)), new(0.018126d, new GammaParticle(352400.0, 0.00352)), new(0.016587d, new GammaParticle(369090.0, 0.00336)), new(0.007011d, new GammaParticle(375000.0, 0.00331)), new(0.013509d, new GammaParticle(390790.0, 0.00317)), new(0.007866d, new GammaParticle(399430.0, 0.0031)), new(0.037278d, new GammaParticle(421780.0, 0.00294)), new(0.013680000000000001d, new GammaParticle(478170.0, 0.00259)), new(0.007011d, new GammaParticle(521200.0, 0.00238)), new(0.06911740277476451d, new GammaParticle(5637.0, 0.21995)), new(0.11978276964544608d, new GammaParticle(35551.0, 0.03488)), new(0.2187413616607854d, new GammaParticle(36027.0, 0.03441)), new(0.0665458662575705d, new GammaParticle(40857.0, 0.03035)), new(0.08358160801950856d, new GammaParticle(41266.0, 0.03005)), new(0.01703574176193805d, new GammaParticle(41766.0, 0.02969)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000480024d },
            { 4000.0d, 0.000485542d },
            { 8000.0d, 0.000490635d },
            { 12000.0d, 0.000495304d },
            { 16000.0d, 0.000499614d },
            { 20000.0d, 0.000503843d },
            { 24000.0d, 0.000508009d },
            { 28000.0d, 0.000512121d },
            { 32000.0d, 0.000516194d },
            { 36000.0d, 0.000520239d },
            { 40000.0d, 0.000524265d },
            { 44000.0d, 0.000528275d },
            { 48000.0d, 0.000532273d },
            { 52000.0d, 0.000536263d },
            { 56000.0d, 0.000540246d },
            { 60000.0d, 0.000544221d },
            { 64000.0d, 0.000548192d },
            { 68000.0d, 0.000552156d },
            { 72000.0d, 0.000556114d },
            { 76000.0d, 0.000560066d },
            { 80000.0d, 0.00056401d },
            { 84000.0d, 0.000567945d },
            { 88000.0d, 0.000571872d },
            { 92000.0d, 0.000575788d },
            { 96000.0d, 0.000579693d },
            { 100000.0d, 0.000583585d },
            { 106000.0d, 0.000589401d },
            { 112000.0d, 0.000595183d },
            { 118000.0d, 0.00060093d },
            { 124000.0d, 0.000606638d },
            { 130000.0d, 0.000612305d },
            { 136000.0d, 0.000617928d },
            { 142000.0d, 0.000623504d },
            { 148000.0d, 0.000629032d },
            { 154000.0d, 0.000634509d },
            { 160000.0d, 0.000639932d },
            { 166000.0d, 0.0006453d },
            { 172000.0d, 0.00065061d },
            { 178000.0d, 0.00065586d },
            { 184000.0d, 0.00066105d },
            { 190000.0d, 0.000666178d },
            { 196000.0d, 0.000671241d },
            { 202000.0d, 0.000676239d },
            { 208000.0d, 0.000681168d },
            { 214000.0d, 0.000686029d },
            { 220000.0d, 0.00069082d },
            { 226000.0d, 0.00069554d },
            { 232000.0d, 0.000700188d },
            { 238000.0d, 0.000704762d },
            { 244000.0d, 0.000709261d },
            { 250000.0d, 0.000713684d },
            { 256000.0d, 0.000718031d },
            { 262000.0d, 0.000722301d },
            { 268000.0d, 0.000726491d },
            { 274000.0d, 0.000730601d },
            { 280000.0d, 0.000734632d },
            { 286000.0d, 0.000738581d },
            { 292000.0d, 0.000742448d },
            { 298000.0d, 0.000746232d },
            { 304000.0d, 0.000749933d },
            { 310000.0d, 0.00075355d },
            { 316000.0d, 0.000757082d },
            { 322000.0d, 0.000760528d },
            { 328000.0d, 0.000763887d },
            { 334000.0d, 0.00076716d },
            { 340000.0d, 0.000770347d },
            { 346000.0d, 0.000773444d },
            { 352000.0d, 0.000776455d },
            { 358000.0d, 0.000779376d },
            { 364000.0d, 0.000782208d },
            { 370000.0d, 0.00078495d },
            { 376000.0d, 0.000787603d },
            { 382000.0d, 0.000790164d },
            { 388000.0d, 0.000792635d },
            { 394000.0d, 0.000795014d },
            { 400000.0d, 0.000797303d },
            { 406000.0d, 0.0007995d },
            { 412000.0d, 0.000801604d },
            { 418000.0d, 0.000803616d },
            { 424000.0d, 0.000805535d },
            { 430000.0d, 0.000807361d },
            { 436000.0d, 0.000809095d },
            { 442000.0d, 0.000810734d },
            { 448000.0d, 0.000812282d },
            { 454000.0d, 0.000813735d },
            { 460000.0d, 0.000815094d },
            { 466000.0d, 0.00081636d },
            { 472000.0d, 0.000817532d },
            { 478000.0d, 0.00081861d },
            { 484000.0d, 0.000819594d },
            { 490000.0d, 0.000820484d },
            { 496000.0d, 0.00082128d },
            { 502000.0d, 0.000821981d },
            { 508000.0d, 0.000822589d },
            { 514000.0d, 0.000823102d },
            { 520000.0d, 0.000823521d },
            { 526000.0d, 0.000823847d },
            { 532000.0d, 0.000824079d },
            { 538000.0d, 0.000824216d },
            { 544000.0d, 0.00082426d },
            { 550000.0d, 0.000824211d },
            { 556000.0d, 0.000824068d },
            { 562000.0d, 0.000823832d },
            { 568000.0d, 0.000823502d },
            { 574000.0d, 0.00082308d },
            { 580000.0d, 0.000822564d },
            { 586000.0d, 0.000821957d },
            { 592000.0d, 0.000821257d },
            { 598000.0d, 0.000820466d },
            { 604000.0d, 0.000819582d },
            { 610000.0d, 0.000818606d },
            { 616000.0d, 0.000817541d },
            { 622000.0d, 0.000816384d },
            { 628000.0d, 0.000815136d },
            { 634000.0d, 0.000813798d },
            { 640000.0d, 0.000812371d },
            { 646000.0d, 0.000810853d },
            { 652000.0d, 0.000809247d },
            { 658000.0d, 0.000807552d },
            { 664000.0d, 0.000805769d },
            { 670000.0d, 0.000803897d },
            { 676000.0d, 0.000801939d },
            { 682000.0d, 0.000799893d },
            { 688000.0d, 0.000797761d },
            { 694000.0d, 0.000795543d },
            { 700000.0d, 0.000793239d },
            { 706000.0d, 0.00079085d },
            { 712000.0d, 0.000788378d },
            { 718000.0d, 0.000785821d },
            { 724000.0d, 0.00078318d },
            { 730000.0d, 0.000780457d },
            { 736000.0d, 0.000777651d },
            { 742000.0d, 0.000774764d },
            { 748000.0d, 0.000771796d },
            { 754000.0d, 0.000768748d },
            { 760000.0d, 0.000765619d },
            { 766000.0d, 0.000762412d },
            { 772000.0d, 0.000759125d },
            { 778000.0d, 0.000755762d },
            { 784000.0d, 0.000752321d },
            { 790000.0d, 0.000748803d },
            { 796000.0d, 0.00074521d },
            { 802000.0d, 0.000741543d },
            { 808000.0d, 0.0007378d },
            { 814000.0d, 0.000733985d },
            { 820000.0d, 0.000730096d },
            { 826000.0d, 0.000726136d },
            { 832000.0d, 0.000722105d },
            { 838000.0d, 0.000718003d },
            { 844000.0d, 0.000713832d },
            { 850000.0d, 0.000709593d },
            { 856000.0d, 0.000705285d },
            { 862000.0d, 0.000700911d },
            { 868000.0d, 0.00069647d },
            { 874000.0d, 0.000691965d },
            { 880000.0d, 0.000687395d },
            { 886000.0d, 0.000682761d },
            { 892000.0d, 0.000678066d },
            { 898000.0d, 0.000673309d },
            { 904000.0d, 0.000668491d },
            { 910000.0d, 0.000663613d },
            { 916000.0d, 0.000658678d },
            { 922000.0d, 0.000653684d },
            { 928000.0d, 0.000648634d },
            { 934000.0d, 0.000643528d },
            { 940000.0d, 0.000638368d },
            { 946000.0d, 0.000633154d },
            { 952000.0d, 0.000627887d },
            { 958000.0d, 0.00062257d },
            { 964000.0d, 0.000617201d },
            { 970000.0d, 0.000611783d },
            { 976000.0d, 0.000606317d },
            { 982000.0d, 0.000600805d },
            { 988000.0d, 0.000595246d },
            { 994000.0d, 0.000589642d },
            { 1000000.0d, 0.000583994d },
            { 1006000.0d, 0.000578305d },
            { 1012000.0d, 0.000572573d },
            { 1018000.0d, 0.000566802d },
            { 1024000.0d, 0.000560992d },
            { 1030000.0d, 0.000555143d },
            { 1036000.0d, 0.000549259d },
            { 1042000.0d, 0.000543338d },
            { 1048000.0d, 0.000537384d },
            { 1054000.0d, 0.000531397d },
            { 1060000.0d, 0.000525378d },
            { 1066000.0d, 0.000519329d },
            { 1072000.0d, 0.000513251d },
            { 1078000.0d, 0.000507145d },
            { 1084000.0d, 0.000501013d },
            { 1090000.0d, 0.000494855d },
            { 1096000.0d, 0.000488674d },
            { 1102000.0d, 0.000482471d },
            { 1108000.0d, 0.000476247d },
            { 1114000.0d, 0.000470003d },
            { 1120000.0d, 0.000463739d },
            { 1126000.0d, 0.00045746d },
            { 1132000.0d, 0.000451165d },
            { 1138000.0d, 0.000444856d },
            { 1144000.0d, 0.000438534d },
            { 1150000.0d, 0.0004322d },
            { 1156000.0d, 0.000425857d },
            { 1162000.0d, 0.000419506d },
            { 1168000.0d, 0.000413147d },
            { 1174000.0d, 0.000406784d },
            { 1180000.0d, 0.000400416d },
            { 1186000.0d, 0.000394045d },
            { 1192000.0d, 0.000387675d },
            { 1198000.0d, 0.000381304d },
            { 1204000.0d, 0.000374935d },
            { 1210000.0d, 0.00036857d },
            { 1216000.0d, 0.000362211d },
            { 1222000.0d, 0.000355858d },
            { 1228000.0d, 0.000349514d },
            { 1234000.0d, 0.00034318d },
            { 1240000.0d, 0.000336857d },
            { 1246000.0d, 0.000330547d },
            { 1252000.0d, 0.000324252d },
            { 1258000.0d, 0.000317973d },
            { 1264000.0d, 0.000311712d },
            { 1270000.0d, 0.000305472d },
            { 1276000.0d, 0.000299252d },
            { 1282000.0d, 0.000293056d },
            { 1288000.0d, 0.000286884d },
            { 1294000.0d, 0.000280738d },
            { 1300000.0d, 0.00027462d },
            { 1306000.0d, 0.000268532d },
            { 1312000.0d, 0.000262477d },
            { 1318000.0d, 0.000256454d },
            { 1324000.0d, 0.000250466d },
            { 1330000.0d, 0.000244514d },
            { 1336000.0d, 0.000238601d },
            { 1342000.0d, 0.000232729d },
            { 1348000.0d, 0.000226898d },
            { 1354000.0d, 0.000221112d },
            { 1360000.0d, 0.000215371d },
            { 1366000.0d, 0.000209676d },
            { 1372000.0d, 0.000204032d },
            { 1378000.0d, 0.000198435d },
            { 1384000.0d, 0.000192885d },
            { 1390000.0d, 0.000187381d },
            { 1396000.0d, 0.000181927d },
            { 1402000.0d, 0.000176526d },
            { 1408000.0d, 0.000171176d },
            { 1414000.0d, 0.000165882d },
            { 1420000.0d, 0.000160644d },
            { 1426000.0d, 0.000155465d },
            { 1432000.0d, 0.000150346d },
            { 1438000.0d, 0.000145289d },
            { 1444000.0d, 0.000140296d },
            { 1450000.0d, 0.000135368d },
            { 1456000.0d, 0.000130509d },
            { 1462000.0d, 0.000125718d },
            { 1468000.0d, 0.000120999d },
            { 1474000.0d, 0.000116352d },
            { 1480000.0d, 0.000111781d },
            { 1486000.0d, 0.000107286d },
            { 1492000.0d, 0.00010287d },
            { 1498000.0d, 0.0000985348d },
            { 1504000.0d, 0.000094282d },
            { 1510000.0d, 0.0000901136d },
            { 1516000.0d, 0.0000860309d },
            { 1522000.0d, 0.0000820347d },
            { 1528000.0d, 0.0000781269d },
            { 1534000.0d, 0.0000743093d },
            { 1540000.0d, 0.000070584d },
            { 1546000.0d, 0.0000669529d },
            { 1552000.0d, 0.0000634178d },
            { 1558000.0d, 0.0000599808d },
            { 1564000.0d, 0.0000566437d },
            { 1570000.0d, 0.0000534085d },
            { 1576000.0d, 0.0000502773d },
            { 1582000.0d, 0.0000472519d },
            { 1588000.0d, 0.0000443344d },
            { 1594000.0d, 0.0000415266d },
            { 1600000.0d, 0.0000388304d },
            { 1606000.0d, 0.0000362482d },
            { 1612000.0d, 0.0000337814d },
            { 1618000.0d, 0.0000314303d },
            { 1624000.0d, 0.0000291718d },
            { 1630000.0d, 0.0000269998d },
            { 1636000.0d, 0.0000249161d },
            { 1642000.0d, 0.000022922d },
            { 1648000.0d, 0.0000210192d },
            { 1654000.0d, 0.0000192091d },
            { 1660000.0d, 0.0000174933d },
            { 1666000.0d, 0.0000158734d },
            { 1672000.0d, 0.0000143501d },
            { 1678000.0d, 0.00001292d },
            { 1684000.0d, 0.0000115839d },
            { 1690000.0d, 0.0000103432d },
            { 1696000.0d, 0.00000919952d },
            { 1702000.0d, 0.00000815414d },
            { 1708000.0d, 0.00000720859d },
            { 1714000.0d, 0.0000063643d },
            { 1720000.0d, 0.00000562269d },
            { 1726000.0d, 0.0000049853d },
            { 1732000.0d, 0.00000445345d },
            { 1738000.0d, 0.00000402845d },
            { 1744000.0d, 0.0000037115d },
            { 1750000.0d, 0.00000348085d },
            { 1756000.0d, 0.00000326401d },
            { 1762000.0d, 0.00000305553d },
            { 1768000.0d, 0.00000285554d },
            { 1774000.0d, 0.00000266418d },
            { 1780000.0d, 0.00000248157d },
            { 1786000.0d, 0.00000230765d },
            { 1792000.0d, 0.00000214006d },
            { 1798000.0d, 0.00000197813d },
            { 1804000.0d, 0.00000182198d },
            { 1810000.0d, 0.00000167168d },
            { 1816000.0d, 0.00000152734d },
            { 1822000.0d, 0.00000138904d },
            { 1828000.0d, 0.00000125689d },
            { 1834000.0d, 0.00000113097d },
            { 1840000.0d, 0.00000101138d },
            { 1846000.0d, 0.000000898216d },
            { 1852000.0d, 0.00000079151d },
            { 1858000.0d, 0.000000691154d },
            { 1864000.0d, 0.000000597203d },
            { 1870000.0d, 0.000000509751d },
            { 1876000.0d, 0.000000428888d },
            { 1882000.0d, 0.000000354706d },
            { 1888000.0d, 0.000000287296d },
            { 1894000.0d, 0.00000022675d },
            { 1900000.0d, 0.000000173158d },
            { 1906000.0d, 0.000000126611d },
            { 1912000.0d, 0.0000000871985d },
            { 1918000.0d, 0.0000000550082d },
            { 1924000.0d, 0.0000000301262d },
            { 1930000.0d, 0.0000000126355d },
            { 1936000.0d, 0.00000000261143d },
            { 1941000.0d, 0d },

        }; 
    }
}
    