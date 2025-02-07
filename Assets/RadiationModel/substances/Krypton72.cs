using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton72 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton72";
        public override double halfLife { get; } = 17.1d;
        public override double atomicWeight { get; } = 71.94209d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium72()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0017427d, new GammaParticle(30500.0, 0.04065)), new(0.001727d, new GammaParticle(38800.0, 0.03195)), new(0.008321d, new GammaParticle(87200.0, 0.01422)), new(0.000785d, new GammaParticle(88500.0, 0.01401)), new(0.000471d, new GammaParticle(91500.0, 0.01355)), new(0.024021d, new GammaParticle(101300.0, 0.01224)), new(0.004867d, new GammaParticle(105300.0, 0.01177)), new(0.0008007d, new GammaParticle(117800.0, 0.01052)), new(0.035168d, new GammaParticle(124400.0, 0.00997)), new(0.0010833d, new GammaParticle(130500.0, 0.0095)), new(0.0003454d, new GammaParticle(132500.0, 0.00936)), new(0.0002198d, new GammaParticle(146200.0, 0.00848)), new(0.005338000000000001d, new GammaParticle(147200.0, 0.00842)), new(0.000942d, new GammaParticle(147200.0, 0.00842)), new(0.001099d, new GammaParticle(160800.0, 0.00771)), new(0.0942d, new GammaParticle(162700.0, 0.00762)), new(0.001099d, new GammaParticle(166100.0, 0.00746)), new(0.0013502d, new GammaParticle(177200.0, 0.007)), new(0.025276999999999997d, new GammaParticle(178500.0, 0.00695)), new(0.0027632d, new GammaParticle(183300.0, 0.00676)), new(0.0002826d, new GammaParticle(185500.0, 0.00668)), new(0.0036109999999999996d, new GammaParticle(196200.0, 0.00632)), new(0.001727d, new GammaParticle(196200.0, 0.00632)), new(0.0010205d, new GammaParticle(204400.0, 0.00607)), new(0.006594d, new GammaParticle(208900.0, 0.00594)), new(0.0005966d, new GammaParticle(218800.0, 0.00567)), new(0.0036895d, new GammaParticle(230100.0, 0.00539)), new(0.0050868d, new GammaParticle(235500.0, 0.00526)), new(0.024021d, new GammaParticle(252400.0, 0.00491)), new(0.0019311d, new GammaParticle(254900.0, 0.00486)), new(0.0047571d, new GammaParticle(265700.0, 0.00467)), new(0.0008635d, new GammaParticle(267000.0, 0.00464)), new(0.001884d, new GammaParticle(274200.0, 0.00452)), new(0.007441799999999999d, new GammaParticle(283400.0, 0.00437)), new(0.00048669999999999996d, new GammaParticle(290700.0, 0.00427)), new(0.0018054999999999998d, new GammaParticle(307000.0, 0.00404)), new(0.154802d, new GammaParticle(309900.0, 0.004)), new(0.0056677d, new GammaParticle(313800.0, 0.00395)), new(0.011932d, new GammaParticle(328400.0, 0.00378)), new(0.0008792d, new GammaParticle(356300.0, 0.00348)), new(0.0002041d, new GammaParticle(379300.0, 0.00327)), new(0.008164d, new GammaParticle(379300.0, 0.00327)), new(0.0061072999999999995d, new GammaParticle(380800.0, 0.00326)), new(0.0006908d, new GammaParticle(385400.0, 0.00322)), new(0.0058875d, new GammaParticle(392700.0, 0.00316)), new(0.0056677d, new GammaParticle(398400.0, 0.00311)), new(0.0036895d, new GammaParticle(412100.0, 0.00301)), new(0.06437d, new GammaParticle(414500.0, 0.00299)), new(0.13188d, new GammaParticle(415100.0, 0.00299)), new(0.0007536d, new GammaParticle(427100.0, 0.0029)), new(0.0016014d, new GammaParticle(451400.0, 0.00275)), new(0.0072691d, new GammaParticle(452300.0, 0.00274)), new(0.0012874d, new GammaParticle(482500.0, 0.00257)), new(0.0043175d, new GammaParticle(484700.0, 0.00256)), new(0.004427400000000001d, new GammaParticle(485900.0, 0.00255)), new(0.0003768d, new GammaParticle(489200.0, 0.00253)), new(0.002983d, new GammaParticle(504000.0, 0.00246)), new(0.0031557d, new GammaParticle(519500.0, 0.00239)), new(0.000785d, new GammaParticle(541100.0, 0.00229)), new(0.0016955999999999998d, new GammaParticle(545300.0, 0.00227)), new(0.0008321000000000001d, new GammaParticle(546700.0, 0.00227)), new(0.0047257d, new GammaParticle(559700.0, 0.00222)), new(0.011460999999999999d, new GammaParticle(575800.0, 0.00215)), new(0.062643d, new GammaParticle(576900.0, 0.00215)), new(0.001256d, new GammaParticle(583300.0, 0.00213)), new(0.0039250000000000005d, new GammaParticle(590600.0, 0.0021)), new(0.000628d, new GammaParticle(592500.0, 0.00209)), new(0.0005966d, new GammaParticle(610400.0, 0.00203)), new(0.002355d, new GammaParticle(617900.0, 0.00201)), new(0.0013345000000000002d, new GammaParticle(629800.0, 0.00197)), new(0.003297d, new GammaParticle(631300.0, 0.00196)), new(0.0044588d, new GammaParticle(633500.0, 0.00196)), new(0.00628d, new GammaParticle(635200.0, 0.00195)), new(0.0016171d, new GammaParticle(648800.0, 0.00191)), new(0.0012403d, new GammaParticle(671700.0, 0.00185)), new(0.00314d, new GammaParticle(682500.0, 0.00182)), new(0.0023079d, new GammaParticle(699500.0, 0.00177)), new(0.0020253d, new GammaParticle(708000.0, 0.00175)), new(0.0007222000000000001d, new GammaParticle(722300.0, 0.00172)), new(0.0017584d, new GammaParticle(739200.0, 0.00168)), new(0.011460999999999999d, new GammaParticle(755500.0, 0.00164)), new(0.000785d, new GammaParticle(774500.0, 0.0016)), new(0.0037052d, new GammaParticle(777500.0, 0.00159)), new(0.0013973d, new GammaParticle(795700.0, 0.00156)), new(0.0011618000000000002d, new GammaParticle(801700.0, 0.00155)), new(0.0025748d, new GammaParticle(810100.0, 0.00153)), new(0.0023864d, new GammaParticle(815100.0, 0.00152)), new(0.00314d, new GammaParticle(840300.0, 0.00148)), new(0.0010362000000000001d, new GammaParticle(844500.0, 0.00147)), new(0.0015856999999999998d, new GammaParticle(844500.0, 0.00147)), new(0.0008792d, new GammaParticle(865300.0, 0.00143)), new(0.0014601d, new GammaParticle(869900.0, 0.00143)), new(0.007379d, new GammaParticle(901900.0, 0.00137)), new(0.0018212d, new GammaParticle(908000.0, 0.00137)), new(0.0061544d, new GammaParticle(939200.0, 0.00132)), new(0.0014601d, new GammaParticle(954600.0, 0.0013)), new(0.0068766d, new GammaParticle(976600.0, 0.00127)), new(0.0003925d, new GammaParticle(991200.0, 0.00125)), new(0.0010833d, new GammaParticle(994300.0, 0.00125)), new(0.0014130000000000002d, new GammaParticle(1027700.0, 0.00121)), new(0.002041d, new GammaParticle(1029000.0, 0.0012)), new(0.0030301d, new GammaParticle(1039500.0, 0.00119)), new(0.0056677d, new GammaParticle(1049900.0, 0.00118)), new(0.0030301d, new GammaParticle(1058000.0, 0.00117)), new(0.0009891d, new GammaParticle(1076000.0, 0.00115)), new(0.0012874d, new GammaParticle(1160100.0, 0.00107)), new(0.0002041d, new GammaParticle(1167100.0, 0.00106)), new(0.0007536d, new GammaParticle(1222400.0, 0.00101)), new(0.0024021d, new GammaParticle(1373300.0, 0.0009)), new(0.0016642000000000002d, new GammaParticle(1386000.0, 0.00089)), new(0.0023393d, new GammaParticle(1392600.0, 0.00089)), new(0.0002198d, new GammaParticle(1441900.0, 0.00086)), new(0.0016014d, new GammaParticle(1457000.0, 0.00085)), new(0.0013659d, new GammaParticle(1481300.0, 0.00084)), new(0.0002983d, new GammaParticle(1541000.0, 0.0008)), new(0.0014444000000000002d, new GammaParticle(1605100.0, 0.00077)), new(0.0033755d, new GammaParticle(1609200.0, 0.00077)), new(0.000942d, new GammaParticle(1636900.0, 0.00076)), new(0.0039564d, new GammaParticle(1648000.0, 0.00075)), new(0.0003768d, new GammaParticle(1672700.0, 0.00074)), new(0.0013973d, new GammaParticle(1675000.0, 0.00074)), new(0.0024649d, new GammaParticle(1711200.0, 0.00072)), new(0.0005024d, new GammaParticle(1771900.0, 0.0007)), new(0.0003925d, new GammaParticle(1799600.0, 0.00069)), new(0.0002198d, new GammaParticle(1835800.0, 0.00068)), new(2.00768d, new GammaParticle(511000.0, 0.00243)), new(0.0021d, new GammaParticle(1535.0, 0.80771)), new(0.013999999999999999d, new GammaParticle(11879.0, 0.10437)), new(0.027999999999999997d, new GammaParticle(11925.0, 0.10397)), new(0.006500000000000001d, new GammaParticle(13345.0, 0.09291)), new(0.006999999999999999d, new GammaParticle(13377.0, 0.09268)), new(0.0005099999999999999d, new GammaParticle(13469.0, 0.09205)) } },
            { 1e-08d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium71()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 2000.0d, 0.000000000153499d },
            { 4000.0d, 0.0000000420392d },
            { 6000.0d, 0.000000144025d },
            { 8000.0d, 0.000000300156d },
            { 10000.0d, 0.000000510468d },
            { 12000.0d, 0.000000774953d },
            { 14000.0d, 0.00000109358d },
            { 16000.0d, 0.00000146613d },
            { 18000.0d, 0.00000189242d },
            { 20000.0d, 0.00000237141d },
            { 22000.0d, 0.00000290071d },
            { 24000.0d, 0.00000347144d },
            { 26000.0d, 0.00000407271d },
            { 28000.0d, 0.00000469759d },
            { 30000.0d, 0.00000535644d },
            { 32000.0d, 0.00000604925d },
            { 34000.0d, 0.00000677236d },
            { 36000.0d, 0.00000752286d },
            { 38000.0d, 0.00000828592d },
            { 40000.0d, 0.0000090676d },
            { 42000.0d, 0.00000986289d },
            { 44000.0d, 0.0000106777d },
            { 46000.0d, 0.0000115064d },
            { 48000.0d, 0.0000123528d },
            { 50000.0d, 0.0000132071d },
            { 52000.0d, 0.000014075d },
            { 54000.0d, 0.0000149488d },
            { 56000.0d, 0.0000158326d },
            { 58000.0d, 0.0000167249d },
            { 60000.0d, 0.0000176277d },
            { 62000.0d, 0.000018535d },
            { 64000.0d, 0.0000194506d },
            { 66000.0d, 0.0000203718d },
            { 68000.0d, 0.0000212962d },
            { 70000.0d, 0.0000222269d },
            { 72000.0d, 0.0000231631d },
            { 74000.0d, 0.000024102d },
            { 76000.0d, 0.0000250459d },
            { 78000.0d, 0.0000259941d },
            { 80000.0d, 0.0000269436d },
            { 82000.0d, 0.0000278964d },
            { 84000.0d, 0.0000288529d },
            { 86000.0d, 0.0000298108d },
            { 88000.0d, 0.0000307717d },
            { 90000.0d, 0.0000317347d },
            { 92000.0d, 0.0000326993d },
            { 94000.0d, 0.0000336654d },
            { 96000.0d, 0.0000346336d },
            { 98000.0d, 0.0000356027d },
            { 100000.0d, 0.0000365732d },
            { 110000.0d, 0.0000414414d },
            { 120000.0d, 0.0000463258d },
            { 130000.0d, 0.0000512175d },
            { 140000.0d, 0.0000561101d },
            { 150000.0d, 0.0000609997d },
            { 160000.0d, 0.0000658828d },
            { 170000.0d, 0.0000707569d },
            { 180000.0d, 0.0000756202d },
            { 190000.0d, 0.0000804714d },
            { 200000.0d, 0.0000853095d },
            { 210000.0d, 0.0000901337d },
            { 220000.0d, 0.0000949434d },
            { 230000.0d, 0.0000997382d },
            { 240000.0d, 0.000104517d },
            { 250000.0d, 0.000109281d },
            { 260000.0d, 0.000114028d },
            { 270000.0d, 0.000118758d },
            { 280000.0d, 0.000123472d },
            { 290000.0d, 0.000128168d },
            { 300000.0d, 0.000132847d },
            { 310000.0d, 0.000137508d },
            { 320000.0d, 0.00014215d },
            { 330000.0d, 0.000146774d },
            { 340000.0d, 0.000151379d },
            { 350000.0d, 0.000155964d },
            { 360000.0d, 0.00016053d },
            { 370000.0d, 0.000165076d },
            { 380000.0d, 0.000169601d },
            { 390000.0d, 0.000174105d },
            { 400000.0d, 0.000178588d },
            { 410000.0d, 0.00018305d },
            { 420000.0d, 0.000187489d },
            { 430000.0d, 0.000191906d },
            { 440000.0d, 0.0001963d },
            { 450000.0d, 0.000200671d },
            { 460000.0d, 0.000205018d },
            { 470000.0d, 0.000209341d },
            { 480000.0d, 0.000213639d },
            { 490000.0d, 0.000217913d },
            { 500000.0d, 0.000222161d },
            { 510000.0d, 0.000226383d },
            { 520000.0d, 0.000230579d },
            { 530000.0d, 0.000234749d },
            { 540000.0d, 0.000238891d },
            { 550000.0d, 0.000243007d },
            { 560000.0d, 0.000247094d },
            { 570000.0d, 0.000251153d },
            { 580000.0d, 0.000255184d },
            { 590000.0d, 0.000259186d },
            { 600000.0d, 0.000263158d },
            { 610000.0d, 0.000267101d },
            { 620000.0d, 0.000271013d },
            { 630000.0d, 0.000274896d },
            { 640000.0d, 0.000278747d },
            { 650000.0d, 0.000282567d },
            { 660000.0d, 0.000286356d },
            { 670000.0d, 0.000290113d },
            { 680000.0d, 0.000293838d },
            { 690000.0d, 0.00029753d },
            { 700000.0d, 0.000301189d },
            { 710000.0d, 0.000304816d },
            { 720000.0d, 0.000308408d },
            { 730000.0d, 0.000311968d },
            { 740000.0d, 0.000315493d },
            { 750000.0d, 0.000318983d },
            { 760000.0d, 0.00032244d },
            { 770000.0d, 0.000325861d },
            { 780000.0d, 0.000329248d },
            { 790000.0d, 0.000332599d },
            { 800000.0d, 0.000335914d },
            { 810000.0d, 0.000339193d },
            { 820000.0d, 0.000342433d },
            { 830000.0d, 0.000345634d },
            { 840000.0d, 0.000348796d },
            { 850000.0d, 0.000351919d },
            { 860000.0d, 0.000355002d },
            { 870000.0d, 0.000358044d },
            { 880000.0d, 0.000361046d },
            { 890000.0d, 0.000364007d },
            { 900000.0d, 0.000366927d },
            { 910000.0d, 0.000369806d },
            { 920000.0d, 0.000372643d },
            { 930000.0d, 0.000375438d },
            { 940000.0d, 0.000378191d },
            { 950000.0d, 0.000380901d },
            { 960000.0d, 0.000383569d },
            { 970000.0d, 0.000386193d },
            { 980000.0d, 0.000388774d },
            { 990000.0d, 0.000391312d },
            { 1000000.0d, 0.000393806d },
            { 1013000.0d, 0.000396982d },
            { 1026000.0d, 0.000400084d },
            { 1039000.0d, 0.000403111d },
            { 1052000.0d, 0.000406062d },
            { 1065000.0d, 0.000408937d },
            { 1078000.0d, 0.000411736d },
            { 1091000.0d, 0.000414458d },
            { 1104000.0d, 0.000417102d },
            { 1117000.0d, 0.00041967d },
            { 1130000.0d, 0.000422159d },
            { 1143000.0d, 0.000424571d },
            { 1156000.0d, 0.000426905d },
            { 1169000.0d, 0.00042916d },
            { 1182000.0d, 0.000431336d },
            { 1195000.0d, 0.000433433d },
            { 1208000.0d, 0.000435451d },
            { 1221000.0d, 0.00043739d },
            { 1234000.0d, 0.00043925d },
            { 1247000.0d, 0.000441029d },
            { 1260000.0d, 0.00044273d },
            { 1273000.0d, 0.000444351d },
            { 1286000.0d, 0.000445891d },
            { 1299000.0d, 0.000447353d },
            { 1312000.0d, 0.000448734d },
            { 1325000.0d, 0.000450036d },
            { 1338000.0d, 0.000451258d },
            { 1351000.0d, 0.0004524d },
            { 1364000.0d, 0.000453462d },
            { 1377000.0d, 0.000454446d },
            { 1390000.0d, 0.00045535d },
            { 1403000.0d, 0.000456174d },
            { 1416000.0d, 0.000456919d },
            { 1429000.0d, 0.000457586d },
            { 1442000.0d, 0.000458173d },
            { 1455000.0d, 0.000458682d },
            { 1468000.0d, 0.000459113d },
            { 1481000.0d, 0.000459466d },
            { 1494000.0d, 0.000459742d },
            { 1507000.0d, 0.00045994d },
            { 1520000.0d, 0.00046006d },
            { 1533000.0d, 0.000460105d },
            { 1546000.0d, 0.000460073d },
            { 1559000.0d, 0.000459964d },
            { 1572000.0d, 0.00045978d },
            { 1585000.0d, 0.000459521d },
            { 1598000.0d, 0.000459188d },
            { 1611000.0d, 0.000458781d },
            { 1624000.0d, 0.000458299d },
            { 1637000.0d, 0.000457744d },
            { 1650000.0d, 0.000457117d },
            { 1663000.0d, 0.000456417d },
            { 1676000.0d, 0.000455646d },
            { 1689000.0d, 0.000454804d },
            { 1702000.0d, 0.000453891d },
            { 1715000.0d, 0.00045291d },
            { 1728000.0d, 0.000451859d },
            { 1741000.0d, 0.00045074d },
            { 1754000.0d, 0.000449553d },
            { 1767000.0d, 0.000448299d },
            { 1780000.0d, 0.000446979d },
            { 1793000.0d, 0.000445594d },
            { 1806000.0d, 0.000444144d },
            { 1819000.0d, 0.000442629d },
            { 1832000.0d, 0.000441053d },
            { 1845000.0d, 0.000439414d },
            { 1858000.0d, 0.000437714d },
            { 1871000.0d, 0.000435953d },
            { 1884000.0d, 0.000434133d },
            { 1897000.0d, 0.000432255d },
            { 1910000.0d, 0.000430318d },
            { 1923000.0d, 0.000428325d },
            { 1936000.0d, 0.000426277d },
            { 1949000.0d, 0.000424173d },
            { 1962000.0d, 0.000422017d },
            { 1975000.0d, 0.000419807d },
            { 1988000.0d, 0.000417546d },
            { 2001000.0d, 0.000415235d },
            { 2014000.0d, 0.000412875d },
            { 2027000.0d, 0.000410467d },
            { 2040000.0d, 0.000408011d },
            { 2053000.0d, 0.000405509d },
            { 2066000.0d, 0.000402962d },
            { 2079000.0d, 0.000400374d },
            { 2092000.0d, 0.000397741d },
            { 2105000.0d, 0.000395069d },
            { 2118000.0d, 0.000392357d },
            { 2131000.0d, 0.000389606d },
            { 2144000.0d, 0.000386817d },
            { 2157000.0d, 0.000383993d },
            { 2170000.0d, 0.000381134d },
            { 2183000.0d, 0.000378242d },
            { 2196000.0d, 0.000375317d },
            { 2209000.0d, 0.000372361d },
            { 2222000.0d, 0.000369375d },
            { 2235000.0d, 0.000366361d },
            { 2248000.0d, 0.00036332d },
            { 2261000.0d, 0.000360254d },
            { 2274000.0d, 0.000357164d },
            { 2287000.0d, 0.000354048d },
            { 2300000.0d, 0.000350908d },
            { 2313000.0d, 0.000347744d },
            { 2326000.0d, 0.000344557d },
            { 2339000.0d, 0.000341347d },
            { 2352000.0d, 0.000338105d },
            { 2365000.0d, 0.00033483d },
            { 2378000.0d, 0.000331522d },
            { 2391000.0d, 0.000328184d },
            { 2404000.0d, 0.000324815d },
            { 2417000.0d, 0.000321416d },
            { 2430000.0d, 0.000317989d },
            { 2443000.0d, 0.000314534d },
            { 2456000.0d, 0.000311051d },
            { 2469000.0d, 0.000307544d },
            { 2482000.0d, 0.000304011d },
            { 2495000.0d, 0.000300456d },
            { 2508000.0d, 0.000296878d },
            { 2521000.0d, 0.000293276d },
            { 2534000.0d, 0.000289654d },
            { 2547000.0d, 0.000286011d },
            { 2560000.0d, 0.000282349d },
            { 2573000.0d, 0.00027867d },
            { 2586000.0d, 0.000274973d },
            { 2599000.0d, 0.000271261d },
            { 2612000.0d, 0.000267535d },
            { 2625000.0d, 0.000263796d },
            { 2638000.0d, 0.000260045d },
            { 2651000.0d, 0.000256285d },
            { 2664000.0d, 0.000252515d },
            { 2677000.0d, 0.000248738d },
            { 2690000.0d, 0.000244954d },
            { 2703000.0d, 0.000241166d },
            { 2716000.0d, 0.000237374d },
            { 2729000.0d, 0.00023358d },
            { 2742000.0d, 0.000229779d },
            { 2755000.0d, 0.000225971d },
            { 2768000.0d, 0.00022216d },
            { 2781000.0d, 0.000218346d },
            { 2794000.0d, 0.00021453d },
            { 2807000.0d, 0.000210714d },
            { 2820000.0d, 0.000206897d },
            { 2833000.0d, 0.000203082d },
            { 2846000.0d, 0.00019927d },
            { 2859000.0d, 0.000195463d },
            { 2872000.0d, 0.000191662d },
            { 2885000.0d, 0.000187867d },
            { 2898000.0d, 0.000184082d },
            { 2911000.0d, 0.000180307d },
            { 2924000.0d, 0.000176543d },
            { 2937000.0d, 0.000172792d },
            { 2950000.0d, 0.000169055d },
            { 2963000.0d, 0.000165333d },
            { 2976000.0d, 0.000161627d },
            { 2989000.0d, 0.000157939d },
            { 3002000.0d, 0.00015427d },
            { 3015000.0d, 0.000150622d },
            { 3028000.0d, 0.000146996d },
            { 3041000.0d, 0.000143394d },
            { 3054000.0d, 0.000139817d },
            { 3067000.0d, 0.000136267d },
            { 3080000.0d, 0.000132746d },
            { 3093000.0d, 0.000129252d },
            { 3106000.0d, 0.000125786d },
            { 3119000.0d, 0.000122349d },
            { 3132000.0d, 0.000118943d },
            { 3145000.0d, 0.000115569d },
            { 3158000.0d, 0.000112229d },
            { 3171000.0d, 0.000108925d },
            { 3184000.0d, 0.000105655d },
            { 3197000.0d, 0.000102423d },
            { 3210000.0d, 0.0000992279d },
            { 3223000.0d, 0.000096071d },
            { 3236000.0d, 0.0000929534d },
            { 3249000.0d, 0.0000898768d },
            { 3262000.0d, 0.0000868426d },
            { 3275000.0d, 0.0000838523d },
            { 3288000.0d, 0.0000809078d },
            { 3301000.0d, 0.0000780104d },
            { 3314000.0d, 0.0000751618d },
            { 3327000.0d, 0.0000723636d },
            { 3340000.0d, 0.0000696171d },
            { 3353000.0d, 0.0000669239d },
            { 3366000.0d, 0.000064284d },
            { 3379000.0d, 0.000061698d },
            { 3392000.0d, 0.0000591673d },
            { 3405000.0d, 0.0000566927d },
            { 3418000.0d, 0.0000542751d },
            { 3431000.0d, 0.0000519158d },
            { 3444000.0d, 0.0000496155d },
            { 3457000.0d, 0.0000473759d },
            { 3470000.0d, 0.0000451984d },
            { 3483000.0d, 0.0000430847d },
            { 3496000.0d, 0.0000410365d },
            { 3509000.0d, 0.0000390554d },
            { 3522000.0d, 0.0000371429d },
            { 3535000.0d, 0.000035299d },
            { 3548000.0d, 0.0000335082d },
            { 3561000.0d, 0.0000317676d },
            { 3574000.0d, 0.0000300783d },
            { 3587000.0d, 0.0000284414d },
            { 3600000.0d, 0.0000268583d },
            { 3613000.0d, 0.00002533d },
            { 3626000.0d, 0.0000238575d },
            { 3639000.0d, 0.0000224423d },
            { 3652000.0d, 0.0000210855d },
            { 3665000.0d, 0.0000197886d },
            { 3678000.0d, 0.0000185528d },
            { 3691000.0d, 0.0000173792d },
            { 3704000.0d, 0.0000162599d },
            { 3717000.0d, 0.0000151832d },
            { 3730000.0d, 0.00001415d },
            { 3743000.0d, 0.000013161d },
            { 3756000.0d, 0.0000122171d },
            { 3769000.0d, 0.0000113192d },
            { 3782000.0d, 0.0000104683d },
            { 3795000.0d, 0.00000966478d },
            { 3808000.0d, 0.00000890145d },
            { 3821000.0d, 0.00000816565d },
            { 3834000.0d, 0.00000745782d },
            { 3847000.0d, 0.00000677866d },
            { 3860000.0d, 0.00000612885d },
            { 3873000.0d, 0.00000550912d },
            { 3886000.0d, 0.00000492016d },
            { 3899000.0d, 0.00000436249d },
            { 3912000.0d, 0.00000383645d },
            { 3925000.0d, 0.00000334276d },
            { 3938000.0d, 0.00000288216d },
            { 3951000.0d, 0.00000245531d },
            { 3964000.0d, 0.00000206262d },
            { 3977000.0d, 0.00000170477d },
            { 3990000.0d, 0.00000138221d },
            { 4003000.0d, 0.00000109476d },
            { 4016000.0d, 0.000000841765d },
            { 4029000.0d, 0.000000621017d },
            { 4042000.0d, 0.000000432938d },
            { 4055000.0d, 0.000000278047d },
            { 4068000.0d, 0.000000156851d },
            { 4081000.0d, 0.0000000698358d },
            { 4094000.0d, 0.0000000174465d },
            { 4107000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    