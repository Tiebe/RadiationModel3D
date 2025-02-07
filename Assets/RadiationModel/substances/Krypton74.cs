using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton74 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton74";
        public override double halfLife { get; } = 690.0d;
        public override double atomicWeight { get; } = 73.93308d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium74()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0434d, new GammaParticle(9850.0, 0.12587)), new(0.00155d, new GammaParticle(26400.0, 0.04696)), new(0.09609999999999999d, new GammaParticle(62840.0, 0.01973)), new(0.014570000000000001d, new GammaParticle(67290.0, 0.01843)), new(0.00496d, new GammaParticle(72380.0, 0.01713)), new(0.0027900000000000004d, new GammaParticle(79960.0, 0.01551)), new(0.00124d, new GammaParticle(83600.0, 0.01483)), new(0.31d, new GammaParticle(89700.0, 0.01382)), new(0.009300000000000001d, new GammaParticle(89700.0, 0.01382)), new(0.03286d, new GammaParticle(93810.0, 0.01322)), new(0.0837d, new GammaParticle(123360.0, 0.01005)), new(0.0217d, new GammaParticle(129600.0, 0.00957)), new(0.00651d, new GammaParticle(132600.0, 0.00935)), new(0.0806d, new GammaParticle(140270.0, 0.00884)), new(0.02139d, new GammaParticle(149720.0, 0.00828)), new(0.0037199999999999998d, new GammaParticle(166840.0, 0.00743)), new(0.0034100000000000003d, new GammaParticle(179300.0, 0.00691)), new(0.17980000000000002d, new GammaParticle(202980.0, 0.00611)), new(0.0009299999999999999d, new GammaParticle(210000.0, 0.0059)), new(0.00961d, new GammaParticle(212750.0, 0.00583)), new(0.0806d, new GammaParticle(216900.0, 0.00572)), new(0.0027900000000000004d, new GammaParticle(225100.0, 0.00551)), new(0.0046500000000000005d, new GammaParticle(229700.0, 0.0054)), new(0.0434d, new GammaParticle(233880.0, 0.0053)), new(0.00434d, new GammaParticle(239400.0, 0.00518)), new(0.0992d, new GammaParticle(296670.0, 0.00418)), new(0.00868d, new GammaParticle(300400.0, 0.00413)), new(0.09300000000000001d, new GammaParticle(306510.0, 0.00405)), new(0.00775d, new GammaParticle(310900.0, 0.00399)), new(0.0031d, new GammaParticle(369700.0, 0.00335)), new(0.0031d, new GammaParticle(373600.0, 0.00332)), new(0.008060000000000001d, new GammaParticle(396000.0, 0.00313)), new(0.00496d, new GammaParticle(444800.0, 0.00279)), new(0.00248d, new GammaParticle(488900.0, 0.00254)), new(0.005889999999999999d, new GammaParticle(519800.0, 0.00239)), new(0.000775d, new GammaParticle(524400.0, 0.00236)), new(0.0018599999999999999d, new GammaParticle(530500.0, 0.00234)), new(0.0034100000000000003d, new GammaParticle(535300.0, 0.00232)), new(0.0034100000000000003d, new GammaParticle(536000.0, 0.00231)), new(0.00248d, new GammaParticle(606500.0, 0.00204)), new(0.01054d, new GammaParticle(609200.0, 0.00204)), new(0.0018599999999999999d, new GammaParticle(611500.0, 0.00203)), new(0.00248d, new GammaParticle(618900.0, 0.002)), new(0.00248d, new GammaParticle(628800.0, 0.00197)), new(0.0027900000000000004d, new GammaParticle(691500.0, 0.00179)), new(0.014570000000000001d, new GammaParticle(701300.0, 0.00177)), new(0.0018599999999999999d, new GammaParticle(738800.0, 0.00168)), new(0.005889999999999999d, new GammaParticle(757300.0, 0.00164)), new(0.0018599999999999999d, new GammaParticle(765900.0, 0.00162)), new(0.00217d, new GammaParticle(797600.0, 0.00155)), new(0.00155d, new GammaParticle(831900.0, 0.00149)), new(0.00124d, new GammaParticle(862000.0, 0.00144)), new(0.00155d, new GammaParticle(879500.0, 0.00141)), new(0.00217d, new GammaParticle(900000.0, 0.00138)), new(0.00248d, new GammaParticle(969000.0, 0.00128)), new(0.00155d, new GammaParticle(978100.0, 0.00127)), new(0.00217d, new GammaParticle(1013800.0, 0.00122)), new(0.00217d, new GammaParticle(1060900.0, 0.00117)), new(1.7326d, new GammaParticle(511000.0, 0.00243)), new(0.021d, new GammaParticle(1535.0, 0.80771)), new(0.09d, new GammaParticle(11879.0, 0.10437)), new(0.18d, new GammaParticle(11925.0, 0.10397)), new(0.042d, new GammaParticle(13345.0, 0.09291)), new(0.045d, new GammaParticle(13377.0, 0.09268)), new(0.0032d, new GammaParticle(13469.0, 0.09205)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 3000.0d, 0.000000100216d },
            { 6000.0d, 0.000000799659d },
            { 9000.0d, 0.00000210764d },
            { 12000.0d, 0.00000409205d },
            { 15000.0d, 0.0000067883d },
            { 18000.0d, 0.0000100979d },
            { 21000.0d, 0.0000139698d },
            { 24000.0d, 0.0000183258d },
            { 27000.0d, 0.000023088d },
            { 30000.0d, 0.0000282303d },
            { 33000.0d, 0.0000336505d },
            { 36000.0d, 0.0000393565d },
            { 39000.0d, 0.000045271d },
            { 42000.0d, 0.000051385d },
            { 45000.0d, 0.0000576606d },
            { 48000.0d, 0.0000640688d },
            { 51000.0d, 0.0000705957d },
            { 54000.0d, 0.0000772206d },
            { 57000.0d, 0.0000839251d },
            { 60000.0d, 0.0000907023d },
            { 63000.0d, 0.000097528d },
            { 66000.0d, 0.000104404d },
            { 69000.0d, 0.000111313d },
            { 72000.0d, 0.000118252d },
            { 75000.0d, 0.000125211d },
            { 78000.0d, 0.000132183d },
            { 81000.0d, 0.000139165d },
            { 84000.0d, 0.000146151d },
            { 87000.0d, 0.000153136d },
            { 90000.0d, 0.000160118d },
            { 93000.0d, 0.000167091d },
            { 96000.0d, 0.000174055d },
            { 99000.0d, 0.000181005d },
            { 102000.0d, 0.000187939d },
            { 108000.0d, 0.000201753d },
            { 114000.0d, 0.000215482d },
            { 120000.0d, 0.000229113d },
            { 126000.0d, 0.000242638d },
            { 132000.0d, 0.000256049d },
            { 138000.0d, 0.00026934d },
            { 144000.0d, 0.000282505d },
            { 150000.0d, 0.000295541d },
            { 156000.0d, 0.000308442d },
            { 162000.0d, 0.000321209d },
            { 168000.0d, 0.000333838d },
            { 174000.0d, 0.000346327d },
            { 180000.0d, 0.000358673d },
            { 186000.0d, 0.000370877d },
            { 192000.0d, 0.000382936d },
            { 198000.0d, 0.00039485d },
            { 204000.0d, 0.000406617d },
            { 210000.0d, 0.000418238d },
            { 216000.0d, 0.000429712d },
            { 222000.0d, 0.000441038d },
            { 228000.0d, 0.000452214d },
            { 234000.0d, 0.000463242d },
            { 240000.0d, 0.000474121d },
            { 246000.0d, 0.000484852d },
            { 252000.0d, 0.000495431d },
            { 258000.0d, 0.000505859d },
            { 264000.0d, 0.000516138d },
            { 270000.0d, 0.000526266d },
            { 276000.0d, 0.000536243d },
            { 282000.0d, 0.000546069d },
            { 288000.0d, 0.000555744d },
            { 294000.0d, 0.000565266d },
            { 300000.0d, 0.000574637d },
            { 306000.0d, 0.000583856d },
            { 312000.0d, 0.000592923d },
            { 318000.0d, 0.000601839d },
            { 324000.0d, 0.000610602d },
            { 330000.0d, 0.000619212d },
            { 336000.0d, 0.000627669d },
            { 342000.0d, 0.000635973d },
            { 348000.0d, 0.000644126d },
            { 354000.0d, 0.000652124d },
            { 360000.0d, 0.00065997d },
            { 366000.0d, 0.000667662d },
            { 372000.0d, 0.000675201d },
            { 378000.0d, 0.000682587d },
            { 384000.0d, 0.000689819d },
            { 390000.0d, 0.000696899d },
            { 396000.0d, 0.000703824d },
            { 402000.0d, 0.000710595d },
            { 408000.0d, 0.000717213d },
            { 414000.0d, 0.000723678d },
            { 420000.0d, 0.00072999d },
            { 426000.0d, 0.000736147d },
            { 432000.0d, 0.000742151d },
            { 438000.0d, 0.000748001d },
            { 444000.0d, 0.000753698d },
            { 450000.0d, 0.000759243d },
            { 456000.0d, 0.000764632d },
            { 462000.0d, 0.000769871d },
            { 468000.0d, 0.000774955d },
            { 474000.0d, 0.000779887d },
            { 480000.0d, 0.000784665d },
            { 486000.0d, 0.000789292d },
            { 492000.0d, 0.000793766d },
            { 498000.0d, 0.000798087d },
            { 504000.0d, 0.000802257d },
            { 510000.0d, 0.000806275d },
            { 516000.0d, 0.000810141d },
            { 522000.0d, 0.000813856d },
            { 528000.0d, 0.00081742d },
            { 534000.0d, 0.000820834d },
            { 540000.0d, 0.000824098d },
            { 546000.0d, 0.000827211d },
            { 552000.0d, 0.000830174d },
            { 558000.0d, 0.000832989d },
            { 564000.0d, 0.000835653d },
            { 570000.0d, 0.000838171d },
            { 576000.0d, 0.00084054d },
            { 582000.0d, 0.00084276d },
            { 588000.0d, 0.000844835d },
            { 594000.0d, 0.000846762d },
            { 600000.0d, 0.000848544d },
            { 606000.0d, 0.000850179d },
            { 612000.0d, 0.000851669d },
            { 618000.0d, 0.000853016d },
            { 624000.0d, 0.000854218d },
            { 630000.0d, 0.000855277d },
            { 636000.0d, 0.000856193d },
            { 642000.0d, 0.000856966d },
            { 648000.0d, 0.000857599d },
            { 654000.0d, 0.000858091d },
            { 660000.0d, 0.000858442d },
            { 666000.0d, 0.000858655d },
            { 672000.0d, 0.000858728d },
            { 678000.0d, 0.000858664d },
            { 684000.0d, 0.000858464d },
            { 690000.0d, 0.000858125d },
            { 696000.0d, 0.000857652d },
            { 702000.0d, 0.000857046d },
            { 708000.0d, 0.000856305d },
            { 714000.0d, 0.000855431d },
            { 720000.0d, 0.000854425d },
            { 726000.0d, 0.000853289d },
            { 732000.0d, 0.000852022d },
            { 738000.0d, 0.000850626d },
            { 744000.0d, 0.000849102d },
            { 750000.0d, 0.000847451d },
            { 756000.0d, 0.000845674d },
            { 762000.0d, 0.000843773d },
            { 768000.0d, 0.000841746d },
            { 774000.0d, 0.000839597d },
            { 780000.0d, 0.000837327d },
            { 786000.0d, 0.000834936d },
            { 792000.0d, 0.000832426d },
            { 798000.0d, 0.000829797d },
            { 804000.0d, 0.000827052d },
            { 810000.0d, 0.00082419d },
            { 816000.0d, 0.000821214d },
            { 822000.0d, 0.000818125d },
            { 828000.0d, 0.000814923d },
            { 834000.0d, 0.000811611d },
            { 840000.0d, 0.00080819d },
            { 846000.0d, 0.000804661d },
            { 852000.0d, 0.000801024d },
            { 858000.0d, 0.000797283d },
            { 864000.0d, 0.000793439d },
            { 870000.0d, 0.000789491d },
            { 876000.0d, 0.000785442d },
            { 882000.0d, 0.000781294d },
            { 888000.0d, 0.000777048d },
            { 894000.0d, 0.000772706d },
            { 900000.0d, 0.000768268d },
            { 906000.0d, 0.000763738d },
            { 912000.0d, 0.000759113d },
            { 918000.0d, 0.000754401d },
            { 924000.0d, 0.0007496d },
            { 930000.0d, 0.000744712d },
            { 936000.0d, 0.000739738d },
            { 942000.0d, 0.000734681d },
            { 948000.0d, 0.000729542d },
            { 954000.0d, 0.000724322d },
            { 960000.0d, 0.000719025d },
            { 966000.0d, 0.000713651d },
            { 972000.0d, 0.000708202d },
            { 978000.0d, 0.00070268d },
            { 984000.0d, 0.000697084d },
            { 990000.0d, 0.000691414d },
            { 996000.0d, 0.000685668d },
            { 1002000.0d, 0.000679849d },
            { 1008000.0d, 0.000673959d },
            { 1014000.0d, 0.000667998d },
            { 1020000.0d, 0.00066197d },
            { 1026000.0d, 0.000655875d },
            { 1032000.0d, 0.000649717d },
            { 1038000.0d, 0.000643494d },
            { 1044000.0d, 0.000637212d },
            { 1050000.0d, 0.00063087d },
            { 1056000.0d, 0.000624472d },
            { 1062000.0d, 0.000618019d },
            { 1068000.0d, 0.000611512d },
            { 1074000.0d, 0.000604954d },
            { 1080000.0d, 0.000598348d },
            { 1086000.0d, 0.000591693d },
            { 1092000.0d, 0.000584994d },
            { 1098000.0d, 0.000578252d },
            { 1104000.0d, 0.000571467d },
            { 1110000.0d, 0.000564646d },
            { 1116000.0d, 0.000557784d },
            { 1122000.0d, 0.00055089d },
            { 1128000.0d, 0.000543962d },
            { 1134000.0d, 0.000537001d },
            { 1140000.0d, 0.000530011d },
            { 1146000.0d, 0.000522991d },
            { 1152000.0d, 0.000515947d },
            { 1158000.0d, 0.000508878d },
            { 1164000.0d, 0.000501788d },
            { 1170000.0d, 0.00049468d },
            { 1176000.0d, 0.000487554d },
            { 1182000.0d, 0.000480413d },
            { 1188000.0d, 0.000473259d },
            { 1194000.0d, 0.000466095d },
            { 1200000.0d, 0.000458925d },
            { 1206000.0d, 0.000451748d },
            { 1212000.0d, 0.00044457d },
            { 1218000.0d, 0.000437389d },
            { 1224000.0d, 0.000430211d },
            { 1230000.0d, 0.000423036d },
            { 1236000.0d, 0.000415869d },
            { 1242000.0d, 0.00040871d },
            { 1248000.0d, 0.000401563d },
            { 1254000.0d, 0.00039443d },
            { 1260000.0d, 0.000387304d },
            { 1266000.0d, 0.000380184d },
            { 1272000.0d, 0.000373075d },
            { 1278000.0d, 0.000365975d },
            { 1284000.0d, 0.000358891d },
            { 1290000.0d, 0.000351822d },
            { 1296000.0d, 0.000344773d },
            { 1302000.0d, 0.000337746d },
            { 1308000.0d, 0.00033074d },
            { 1314000.0d, 0.000323762d },
            { 1320000.0d, 0.000316811d },
            { 1326000.0d, 0.000309891d },
            { 1332000.0d, 0.000303005d },
            { 1338000.0d, 0.000296155d },
            { 1344000.0d, 0.000289343d },
            { 1350000.0d, 0.000282565d },
            { 1356000.0d, 0.00027582d },
            { 1362000.0d, 0.000269109d },
            { 1368000.0d, 0.000262435d },
            { 1374000.0d, 0.0002558d },
            { 1380000.0d, 0.000249207d },
            { 1386000.0d, 0.000242657d },
            { 1392000.0d, 0.000236155d },
            { 1398000.0d, 0.000229701d },
            { 1404000.0d, 0.000223299d },
            { 1410000.0d, 0.00021695d },
            { 1416000.0d, 0.000210658d },
            { 1422000.0d, 0.000204424d },
            { 1428000.0d, 0.000198249d },
            { 1434000.0d, 0.000192136d },
            { 1440000.0d, 0.000186086d },
            { 1446000.0d, 0.000180102d },
            { 1452000.0d, 0.000174188d },
            { 1458000.0d, 0.000168344d },
            { 1464000.0d, 0.000162575d },
            { 1470000.0d, 0.000156883d },
            { 1476000.0d, 0.000151269d },
            { 1482000.0d, 0.000145738d },
            { 1488000.0d, 0.000140292d },
            { 1494000.0d, 0.000134932d },
            { 1500000.0d, 0.000129663d },
            { 1506000.0d, 0.000124486d },
            { 1512000.0d, 0.000119405d },
            { 1518000.0d, 0.000114422d },
            { 1524000.0d, 0.00010954d },
            { 1530000.0d, 0.000104761d },
            { 1536000.0d, 0.000100089d },
            { 1542000.0d, 0.0000955258d },
            { 1548000.0d, 0.000091075d },
            { 1554000.0d, 0.0000867389d },
            { 1560000.0d, 0.0000825205d },
            { 1566000.0d, 0.0000784227d },
            { 1572000.0d, 0.0000744472d },
            { 1578000.0d, 0.0000705968d },
            { 1584000.0d, 0.0000668745d },
            { 1590000.0d, 0.000063283d },
            { 1596000.0d, 0.0000598254d },
            { 1602000.0d, 0.0000565045d },
            { 1608000.0d, 0.0000533232d },
            { 1614000.0d, 0.0000502844d },
            { 1620000.0d, 0.000047391d },
            { 1626000.0d, 0.000044646d },
            { 1632000.0d, 0.0000420525d },
            { 1638000.0d, 0.000039613d },
            { 1644000.0d, 0.0000373303d },
            { 1650000.0d, 0.0000351869d },
            { 1656000.0d, 0.00003312d },
            { 1662000.0d, 0.0000311261d },
            { 1668000.0d, 0.000029207d },
            { 1674000.0d, 0.0000273639d },
            { 1680000.0d, 0.0000255988d },
            { 1686000.0d, 0.000023913d },
            { 1692000.0d, 0.0000223082d },
            { 1698000.0d, 0.0000207859d },
            { 1704000.0d, 0.0000193478d },
            { 1710000.0d, 0.0000179954d },
            { 1716000.0d, 0.0000167301d },
            { 1722000.0d, 0.0000155504d },
            { 1728000.0d, 0.0000144571d },
            { 1734000.0d, 0.0000134514d },
            { 1740000.0d, 0.0000125348d },
            { 1746000.0d, 0.0000116777d },
            { 1752000.0d, 0.0000108505d },
            { 1758000.0d, 0.0000100539d },
            { 1764000.0d, 0.00000928829d },
            { 1770000.0d, 0.00000855449d },
            { 1776000.0d, 0.00000785293d },
            { 1782000.0d, 0.00000718185d },
            { 1788000.0d, 0.00000654114d },
            { 1794000.0d, 0.00000593142d },
            { 1800000.0d, 0.0000053533d },
            { 1806000.0d, 0.00000480742d },
            { 1812000.0d, 0.00000429437d },
            { 1818000.0d, 0.0000038148d },
            { 1824000.0d, 0.000003369d },
            { 1830000.0d, 0.00000295656d },
            { 1836000.0d, 0.00000257802d },
            { 1842000.0d, 0.00000223398d },
            { 1848000.0d, 0.00000192506d },
            { 1854000.0d, 0.00000165186d },
            { 1860000.0d, 0.00000141493d },
            { 1866000.0d, 0.00000121225d },
            { 1872000.0d, 0.00000102911d },
            { 1878000.0d, 0.000000863354d },
            { 1884000.0d, 0.00000071428d },
            { 1890000.0d, 0.000000578905d },
            { 1896000.0d, 0.000000457194d },
            { 1902000.0d, 0.000000349358d },
            { 1908000.0d, 0.000000255606d },
            { 1914000.0d, 0.000000176147d },
            { 1920000.0d, 0.000000111186d },
            { 1926000.0d, 0.000000060927d },
            { 1932000.0d, 0.0000000255647d },
            { 1938000.0d, 0.00000000528145d },
            { 1943000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    