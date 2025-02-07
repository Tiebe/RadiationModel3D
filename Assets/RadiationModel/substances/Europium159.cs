using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium159";
        public override double halfLife { get; } = 1086.0d;
        public override double atomicWeight { get; } = 158.9291d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium159()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.024700000000000003d, new GammaParticle(17100.0, 0.07251)), new(0.19175d, new GammaParticle(67800.0, 0.01829)), new(0.010725d, new GammaParticle(71400.0, 0.01736)), new(0.091d, new GammaParticle(78600.0, 0.01577)), new(0.012350000000000002d, new GammaParticle(80400.0, 0.01542)), new(0.006175000000000001d, new GammaParticle(90400.0, 0.01372)), new(0.06987499999999999d, new GammaParticle(95700.0, 0.01296)), new(0.006500000000000001d, new GammaParticle(102500.0, 0.0121)), new(0.00715d, new GammaParticle(105500.0, 0.01175)), new(0.0028275d, new GammaParticle(108800.0, 0.0114)), new(0.0039000000000000003d, new GammaParticle(121900.0, 0.01017)), new(0.0325d, new GammaParticle(146400.0, 0.00847)), new(0.01365d, new GammaParticle(159800.0, 0.00776)), new(0.013000000000000001d, new GammaParticle(176900.0, 0.00701)), new(0.01625d, new GammaParticle(227500.0, 0.00545)), new(0.0032500000000000003d, new GammaParticle(498200.0, 0.00249)), new(0.0016250000000000001d, new GammaParticle(521400.0, 0.00238)), new(0.0039000000000000003d, new GammaParticle(551300.0, 0.00225)), new(0.0026d, new GammaParticle(575500.0, 0.00215)), new(0.0039000000000000003d, new GammaParticle(588600.0, 0.00211)), new(0.0032500000000000003d, new GammaParticle(596000.0, 0.00208)), new(0.008775d, new GammaParticle(602200.0, 0.00206)), new(0.012675d, new GammaParticle(613400.0, 0.00202)), new(0.003575d, new GammaParticle(645700.0, 0.00192)), new(0.013325d, new GammaParticle(659500.0, 0.00188)), new(0.03055d, new GammaParticle(664900.0, 0.00186)), new(0.01885d, new GammaParticle(676600.0, 0.00183)), new(0.023075000000000002d, new GammaParticle(681900.0, 0.00182)), new(0.004875d, new GammaParticle(693800.0, 0.00179)), new(0.0016250000000000001d, new GammaParticle(720400.0, 0.00172)), new(0.006500000000000001d, new GammaParticle(726500.0, 0.00171)), new(0.0024375d, new GammaParticle(733100.0, 0.00169)), new(0.0091d, new GammaParticle(744300.0, 0.00167)), new(0.0091d, new GammaParticle(753900.0, 0.00164)), new(0.0032500000000000003d, new GammaParticle(763100.0, 0.00162)), new(0.025675d, new GammaParticle(804700.0, 0.00154)), new(0.0055249999999999995d, new GammaParticle(829700.0, 0.00149)), new(0.0021125d, new GammaParticle(871400.0, 0.00142)), new(0.0032500000000000003d, new GammaParticle(880800.0, 0.00141)), new(0.0016250000000000001d, new GammaParticle(915700.0, 0.00135)), new(0.0029249999999999996d, new GammaParticle(936100.0, 0.00132)), new(0.004875d, new GammaParticle(1015000.0, 0.00122)), new(0.0019500000000000001d, new GammaParticle(1038200.0, 0.00119)), new(0.0052d, new GammaParticle(1043700.0, 0.00119)), new(0.0029249999999999996d, new GammaParticle(1060400.0, 0.00117)), new(0.0026d, new GammaParticle(1078400.0, 0.00115)), new(0.012025d, new GammaParticle(1094800.0, 0.00113)), new(0.0026d, new GammaParticle(1109000.0, 0.00112)), new(0.0052d, new GammaParticle(1128400.0, 0.0011)), new(0.0006175d, new GammaParticle(1159400.0, 0.00107)), new(0.0011375d, new GammaParticle(1181600.0, 0.00105)), new(0.0019500000000000001d, new GammaParticle(1220700.0, 0.00102)), new(0.0032500000000000003d, new GammaParticle(1301500.0, 0.00095)), new(0.0012025d, new GammaParticle(1350800.0, 0.00092)), new(0.0024375d, new GammaParticle(1433700.0, 0.00086)), new(0.0019500000000000001d, new GammaParticle(1451600.0, 0.00085)), new(0.0029249999999999996d, new GammaParticle(1468600.0, 0.00084)), new(0.006500000000000001d, new GammaParticle(1520000.0, 0.00082)), new(0.10911284955999999d, new GammaParticle(6858.0, 0.18079)), new(0.10614739834972356d, new GammaParticle(42308.0, 0.02931)), new(0.190946929932944d, new GammaParticle(42996.0, 0.02884)), new(0.06035978197730205d, new GammaParticle(48802.0, 0.02541)), new(0.0762344046373325d, new GammaParticle(49326.0, 0.02514)), new(0.01587462266003044d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000388157d },
            { 3000.0d, 0.000391507d },
            { 6000.0d, 0.000394716d },
            { 9000.0d, 0.000397784d },
            { 12000.0d, 0.000400704d },
            { 15000.0d, 0.0004035d },
            { 18000.0d, 0.00040622d },
            { 21000.0d, 0.000408866d },
            { 24000.0d, 0.000411496d },
            { 27000.0d, 0.000414102d },
            { 30000.0d, 0.000416688d },
            { 33000.0d, 0.000419258d },
            { 36000.0d, 0.000421813d },
            { 39000.0d, 0.000424357d },
            { 42000.0d, 0.000426889d },
            { 45000.0d, 0.000429415d },
            { 48000.0d, 0.000431931d },
            { 51000.0d, 0.000434442d },
            { 54000.0d, 0.000436947d },
            { 57000.0d, 0.000439447d },
            { 60000.0d, 0.000441942d },
            { 63000.0d, 0.000444432d },
            { 66000.0d, 0.000446919d },
            { 69000.0d, 0.000449402d },
            { 72000.0d, 0.000451882d },
            { 75000.0d, 0.000454358d },
            { 78000.0d, 0.00045683d },
            { 81000.0d, 0.000459299d },
            { 84000.0d, 0.000461763d },
            { 87000.0d, 0.000464224d },
            { 90000.0d, 0.000466681d },
            { 93000.0d, 0.000469133d },
            { 96000.0d, 0.000471581d },
            { 99000.0d, 0.000474025d },
            { 102000.0d, 0.000476464d },
            { 110000.0d, 0.000482944d },
            { 118000.0d, 0.000489386d },
            { 126000.0d, 0.000495784d },
            { 134000.0d, 0.000502138d },
            { 142000.0d, 0.000508442d },
            { 150000.0d, 0.000514692d },
            { 158000.0d, 0.000520887d },
            { 166000.0d, 0.000527022d },
            { 174000.0d, 0.000533095d },
            { 182000.0d, 0.000539103d },
            { 190000.0d, 0.000545043d },
            { 198000.0d, 0.000550912d },
            { 206000.0d, 0.000556709d },
            { 214000.0d, 0.000562431d },
            { 222000.0d, 0.000568076d },
            { 230000.0d, 0.000573642d },
            { 238000.0d, 0.000579126d },
            { 246000.0d, 0.000584528d },
            { 254000.0d, 0.000589844d },
            { 262000.0d, 0.000595075d },
            { 270000.0d, 0.000600219d },
            { 278000.0d, 0.000605273d },
            { 286000.0d, 0.000610237d },
            { 294000.0d, 0.000615108d },
            { 302000.0d, 0.000619887d },
            { 310000.0d, 0.000624571d },
            { 318000.0d, 0.00062916d },
            { 326000.0d, 0.000633652d },
            { 334000.0d, 0.000638048d },
            { 342000.0d, 0.000642344d },
            { 350000.0d, 0.000646542d },
            { 358000.0d, 0.000650638d },
            { 366000.0d, 0.000654635d },
            { 374000.0d, 0.00065853d },
            { 382000.0d, 0.000662323d },
            { 390000.0d, 0.000666013d },
            { 398000.0d, 0.0006696d },
            { 406000.0d, 0.000673081d },
            { 414000.0d, 0.00067646d },
            { 422000.0d, 0.000679733d },
            { 430000.0d, 0.000682899d },
            { 438000.0d, 0.000685962d },
            { 446000.0d, 0.000688917d },
            { 454000.0d, 0.000691766d },
            { 462000.0d, 0.000694509d },
            { 470000.0d, 0.000697144d },
            { 478000.0d, 0.000699672d },
            { 486000.0d, 0.000702094d },
            { 494000.0d, 0.000704408d },
            { 502000.0d, 0.000706615d },
            { 510000.0d, 0.000708715d },
            { 518000.0d, 0.000710706d },
            { 526000.0d, 0.000712589d },
            { 534000.0d, 0.000714366d },
            { 542000.0d, 0.000716036d },
            { 550000.0d, 0.000717599d },
            { 558000.0d, 0.000719054d },
            { 566000.0d, 0.000720402d },
            { 574000.0d, 0.000721644d },
            { 582000.0d, 0.00072278d },
            { 590000.0d, 0.000723808d },
            { 598000.0d, 0.000724732d },
            { 606000.0d, 0.000725551d },
            { 614000.0d, 0.000726264d },
            { 622000.0d, 0.000726873d },
            { 630000.0d, 0.000727377d },
            { 638000.0d, 0.000727778d },
            { 646000.0d, 0.000728075d },
            { 654000.0d, 0.000728269d },
            { 662000.0d, 0.000728362d },
            { 670000.0d, 0.000728352d },
            { 678000.0d, 0.000728243d },
            { 686000.0d, 0.000728031d },
            { 694000.0d, 0.000727721d },
            { 702000.0d, 0.000727312d },
            { 710000.0d, 0.000726804d },
            { 718000.0d, 0.0007262d },
            { 726000.0d, 0.000725497d },
            { 734000.0d, 0.000724699d },
            { 742000.0d, 0.000723806d },
            { 750000.0d, 0.000722819d },
            { 758000.0d, 0.000721738d },
            { 766000.0d, 0.000720564d },
            { 774000.0d, 0.0007193d },
            { 782000.0d, 0.000717944d },
            { 790000.0d, 0.000716497d },
            { 798000.0d, 0.000714963d },
            { 806000.0d, 0.000713341d },
            { 814000.0d, 0.000711634d },
            { 822000.0d, 0.000709839d },
            { 830000.0d, 0.000707961d },
            { 838000.0d, 0.000705999d },
            { 846000.0d, 0.000703956d },
            { 854000.0d, 0.000701831d },
            { 862000.0d, 0.000699627d },
            { 870000.0d, 0.000697344d },
            { 878000.0d, 0.000694984d },
            { 886000.0d, 0.000692547d },
            { 894000.0d, 0.000690036d },
            { 902000.0d, 0.000687452d },
            { 910000.0d, 0.000684796d },
            { 918000.0d, 0.000682069d },
            { 926000.0d, 0.000679273d },
            { 934000.0d, 0.000676409d },
            { 942000.0d, 0.000673479d },
            { 950000.0d, 0.000670483d },
            { 958000.0d, 0.000667424d },
            { 966000.0d, 0.000664303d },
            { 974000.0d, 0.000661122d },
            { 982000.0d, 0.000657882d },
            { 990000.0d, 0.000654584d },
            { 998000.0d, 0.000651229d },
            { 1006000.0d, 0.000647809d },
            { 1014000.0d, 0.000644322d },
            { 1022000.0d, 0.000640771d },
            { 1030000.0d, 0.000637155d },
            { 1038000.0d, 0.000633477d },
            { 1046000.0d, 0.000629737d },
            { 1054000.0d, 0.000625937d },
            { 1062000.0d, 0.000622078d },
            { 1070000.0d, 0.000618163d },
            { 1078000.0d, 0.000614192d },
            { 1086000.0d, 0.000610166d },
            { 1094000.0d, 0.000606087d },
            { 1102000.0d, 0.000601956d },
            { 1110000.0d, 0.000597776d },
            { 1118000.0d, 0.000593546d },
            { 1126000.0d, 0.000589271d },
            { 1134000.0d, 0.00058495d },
            { 1142000.0d, 0.000580585d },
            { 1150000.0d, 0.000576178d },
            { 1158000.0d, 0.000571731d },
            { 1166000.0d, 0.000567243d },
            { 1174000.0d, 0.000562715d },
            { 1182000.0d, 0.000558148d },
            { 1190000.0d, 0.000553542d },
            { 1198000.0d, 0.0005489d },
            { 1206000.0d, 0.000544225d },
            { 1214000.0d, 0.000539514d },
            { 1222000.0d, 0.000534772d },
            { 1230000.0d, 0.00053d },
            { 1238000.0d, 0.000525201d },
            { 1246000.0d, 0.000520374d },
            { 1254000.0d, 0.000515523d },
            { 1262000.0d, 0.000510648d },
            { 1270000.0d, 0.000505752d },
            { 1278000.0d, 0.000500837d },
            { 1286000.0d, 0.000495903d },
            { 1294000.0d, 0.000490954d },
            { 1302000.0d, 0.000485991d },
            { 1310000.0d, 0.000481015d },
            { 1318000.0d, 0.000476028d },
            { 1326000.0d, 0.000471032d },
            { 1334000.0d, 0.00046603d },
            { 1342000.0d, 0.000461022d },
            { 1350000.0d, 0.000456011d },
            { 1358000.0d, 0.000450995d },
            { 1366000.0d, 0.000445964d },
            { 1374000.0d, 0.000440923d },
            { 1382000.0d, 0.000435871d },
            { 1390000.0d, 0.000430808d },
            { 1398000.0d, 0.000425734d },
            { 1406000.0d, 0.000420647d },
            { 1414000.0d, 0.000415551d },
            { 1422000.0d, 0.000410445d },
            { 1430000.0d, 0.000405334d },
            { 1438000.0d, 0.000400216d },
            { 1446000.0d, 0.000395095d },
            { 1454000.0d, 0.000389972d },
            { 1462000.0d, 0.000384848d },
            { 1470000.0d, 0.000379726d },
            { 1478000.0d, 0.000374606d },
            { 1486000.0d, 0.000369492d },
            { 1494000.0d, 0.000364384d },
            { 1502000.0d, 0.000359283d },
            { 1510000.0d, 0.000354192d },
            { 1518000.0d, 0.000349113d },
            { 1526000.0d, 0.000344047d },
            { 1534000.0d, 0.000338997d },
            { 1542000.0d, 0.000333963d },
            { 1550000.0d, 0.000328947d },
            { 1558000.0d, 0.000323953d },
            { 1566000.0d, 0.000318979d },
            { 1574000.0d, 0.000314029d },
            { 1582000.0d, 0.000309098d },
            { 1590000.0d, 0.000304189d },
            { 1598000.0d, 0.000299304d },
            { 1606000.0d, 0.000294445d },
            { 1614000.0d, 0.000289612d },
            { 1622000.0d, 0.000284809d },
            { 1630000.0d, 0.000280037d },
            { 1638000.0d, 0.000275297d },
            { 1646000.0d, 0.000270589d },
            { 1654000.0d, 0.000265904d },
            { 1662000.0d, 0.00026124d },
            { 1670000.0d, 0.000256597d },
            { 1678000.0d, 0.00025198d },
            { 1686000.0d, 0.000247388d },
            { 1694000.0d, 0.000242824d },
            { 1702000.0d, 0.000238289d },
            { 1710000.0d, 0.000233784d },
            { 1718000.0d, 0.000229312d },
            { 1726000.0d, 0.000224874d },
            { 1734000.0d, 0.00022047d },
            { 1742000.0d, 0.000216104d },
            { 1750000.0d, 0.000211777d },
            { 1758000.0d, 0.00020749d },
            { 1766000.0d, 0.000203245d },
            { 1774000.0d, 0.000199043d },
            { 1782000.0d, 0.000194878d },
            { 1790000.0d, 0.000190741d },
            { 1798000.0d, 0.000186624d },
            { 1806000.0d, 0.000182528d },
            { 1814000.0d, 0.00017845d },
            { 1822000.0d, 0.000174389d },
            { 1830000.0d, 0.000170348d },
            { 1838000.0d, 0.000166326d },
            { 1846000.0d, 0.000162325d },
            { 1854000.0d, 0.000158346d },
            { 1862000.0d, 0.00015439d },
            { 1870000.0d, 0.000150459d },
            { 1878000.0d, 0.000146554d },
            { 1886000.0d, 0.000142676d },
            { 1894000.0d, 0.000138825d },
            { 1902000.0d, 0.000135004d },
            { 1910000.0d, 0.000131213d },
            { 1918000.0d, 0.000127454d },
            { 1926000.0d, 0.000123724d },
            { 1934000.0d, 0.000120026d },
            { 1942000.0d, 0.00011636d },
            { 1950000.0d, 0.000112727d },
            { 1958000.0d, 0.000109129d },
            { 1966000.0d, 0.000105567d },
            { 1974000.0d, 0.000102042d },
            { 1982000.0d, 0.0000985549d },
            { 1990000.0d, 0.0000951078d },
            { 1998000.0d, 0.0000917016d },
            { 2006000.0d, 0.0000883375d },
            { 2014000.0d, 0.0000850167d },
            { 2022000.0d, 0.0000817406d },
            { 2030000.0d, 0.0000785105d },
            { 2038000.0d, 0.0000753276d },
            { 2046000.0d, 0.0000721932d },
            { 2054000.0d, 0.0000691088d },
            { 2062000.0d, 0.0000660754d },
            { 2070000.0d, 0.0000630946d },
            { 2078000.0d, 0.0000601675d },
            { 2086000.0d, 0.0000572956d },
            { 2094000.0d, 0.0000544802d },
            { 2102000.0d, 0.0000517227d },
            { 2110000.0d, 0.0000490244d },
            { 2118000.0d, 0.0000463866d },
            { 2126000.0d, 0.0000438107d },
            { 2134000.0d, 0.0000412982d },
            { 2142000.0d, 0.0000388504d },
            { 2150000.0d, 0.0000364687d },
            { 2158000.0d, 0.0000341546d },
            { 2166000.0d, 0.0000319094d },
            { 2174000.0d, 0.0000297346d },
            { 2182000.0d, 0.0000276315d },
            { 2190000.0d, 0.0000256015d },
            { 2198000.0d, 0.0000236462d },
            { 2206000.0d, 0.000021767d },
            { 2214000.0d, 0.0000199653d },
            { 2222000.0d, 0.0000182426d },
            { 2230000.0d, 0.0000166003d },
            { 2238000.0d, 0.0000150399d },
            { 2246000.0d, 0.0000135629d },
            { 2254000.0d, 0.0000121706d },
            { 2262000.0d, 0.0000108647d },
            { 2270000.0d, 0.00000964658d },
            { 2278000.0d, 0.00000851762d },
            { 2286000.0d, 0.00000747926d },
            { 2294000.0d, 0.00000652707d },
            { 2302000.0d, 0.00000564827d },
            { 2310000.0d, 0.00000484122d },
            { 2318000.0d, 0.00000410359d },
            { 2326000.0d, 0.00000343635d },
            { 2334000.0d, 0.0000028405d },
            { 2342000.0d, 0.00000231705d },
            { 2350000.0d, 0.00000186701d },
            { 2358000.0d, 0.00000149131d },
            { 2366000.0d, 0.00000119084d },
            { 2374000.0d, 0.000000956616d },
            { 2382000.0d, 0.00000075302d },
            { 2390000.0d, 0.00000057699d },
            { 2398000.0d, 0.00000042759d },
            { 2406000.0d, 0.00000030038d },
            { 2414000.0d, 0.000000195198d },
            { 2422000.0d, 0.000000112327d },
            { 2430000.0d, 0.0000000520419d },
            { 2438000.0d, 0.0000000145937d },
            { 2446000.0d, 0.000000000177992d },
            { 2447000.0d, 0d },

        }; 
    }
}
    