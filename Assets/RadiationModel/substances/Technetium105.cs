using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium105";
        public override double halfLife { get; } = 458.4d;
        public override double atomicWeight { get; } = 104.91166d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium105()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0021160000000000003d, new GammaParticle(20550.0, 0.06033)), new(0.00010580000000000001d, new GammaParticle(51200.0, 0.02422)), new(0.00118496d, new GammaParticle(55740.0, 0.02224)), new(0.0029624d, new GammaParticle(75300.0, 0.01647)), new(0.00059248d, new GammaParticle(80640.0, 0.01538)), new(0.005713200000000001d, new GammaParticle(82546.0, 0.01502)), new(0.00021160000000000002d, new GammaParticle(87400.0, 0.01419)), new(0.019044000000000002d, new GammaParticle(107945.0, 0.01149)), new(0.00118496d, new GammaParticle(113360.0, 0.01094)), new(0.00019043999999999997d, new GammaParticle(121450.0, 0.01021)), new(0.0006347999999999999d, new GammaParticle(131700.0, 0.00941)), new(0.005713200000000001d, new GammaParticle(138446.0, 0.00896)), new(0.02116d, new GammaParticle(143260.0, 0.00865)), new(0.0035548800000000003d, new GammaParticle(157820.0, 0.00786)), new(0.013753999999999999d, new GammaParticle(159528.0, 0.00777)), new(0.00078292d, new GammaParticle(162300.0, 0.00764)), new(0.00040204d, new GammaParticle(164800.0, 0.00752)), new(0.00080408d, new GammaParticle(169200.0, 0.00733)), new(0.00040204d, new GammaParticle(193300.0, 0.00641)), new(0.0017774400000000001d, new GammaParticle(208900.0, 0.00594)), new(0.0017774400000000001d, new GammaParticle(213600.0, 0.0058)), new(0.00395692d, new GammaParticle(225600.0, 0.0055)), new(0.00040204d, new GammaParticle(229400.0, 0.0054)), new(0.00080408d, new GammaParticle(246200.0, 0.00504)), new(0.0078292d, new GammaParticle(252000.0, 0.00492)), new(0.0046552d, new GammaParticle(272600.0, 0.00455)), new(0.0013754d, new GammaParticle(280200.0, 0.00442)), new(0.00040204d, new GammaParticle(282700.0, 0.00439)), new(0.001587d, new GammaParticle(301000.0, 0.00412)), new(0.0013754d, new GammaParticle(307000.0, 0.00404)), new(0.00099452d, new GammaParticle(314700.0, 0.00394)), new(0.0150236d, new GammaParticle(321500.0, 0.00386)), new(0.0021160000000000003d, new GammaParticle(322300.0, 0.00385)), new(0.00099452d, new GammaParticle(333900.0, 0.00371)), new(0.0033856000000000003d, new GammaParticle(358300.0, 0.00346)), new(0.00078292d, new GammaParticle(358400.0, 0.00346)), new(0.00038087999999999994d, new GammaParticle(397600.0, 0.00312)), new(0.00038087999999999994d, new GammaParticle(407400.0, 0.00304)), new(0.00059248d, new GammaParticle(418700.0, 0.00296)), new(0.00236992d, new GammaParticle(441900.0, 0.00281)), new(0.00217948d, new GammaParticle(445900.0, 0.00278)), new(0.0059248d, new GammaParticle(462800.0, 0.00268)), new(0.0020102d, new GammaParticle(466300.0, 0.00266)), new(0.00059248d, new GammaParticle(469900.0, 0.00264)), new(0.00042320000000000004d, new GammaParticle(471700.0, 0.00263)), new(0.0020102d, new GammaParticle(480100.0, 0.00258)), new(0.00059248d, new GammaParticle(484000.0, 0.00256)), new(0.003174d, new GammaParticle(490600.0, 0.00253)), new(0.00021160000000000002d, new GammaParticle(535800.0, 0.00231)), new(0.00042320000000000004d, new GammaParticle(538500.0, 0.0023)), new(0.00038087999999999994d, new GammaParticle(540700.0, 0.00229)), new(0.0017774400000000001d, new GammaParticle(565100.0, 0.00219)), new(0.003174d, new GammaParticle(577900.0, 0.00215)), new(0.00031739999999999996d, new GammaParticle(631000.0, 0.00196)), new(0.0035548800000000003d, new GammaParticle(640200.0, 0.00194)), new(0.00099452d, new GammaParticle(644000.0, 0.00193)), new(0.001587d, new GammaParticle(646300.0, 0.00192)), new(0.00099452d, new GammaParticle(648700.0, 0.00191)), new(0.00021160000000000002d, new GammaParticle(657000.0, 0.00189)), new(0.00057132d, new GammaParticle(664600.0, 0.00187)), new(0.0007617599999999999d, new GammaParticle(713800.0, 0.00174)), new(0.0007617599999999999d, new GammaParticle(716600.0, 0.00173)), new(0.00021160000000000002d, new GammaParticle(722800.0, 0.00172)), new(0.00217948d, new GammaParticle(739300.0, 0.00168)), new(0.001587d, new GammaParticle(757000.0, 0.00164)), new(0.001587d, new GammaParticle(824300.0, 0.0015)), new(0.00021160000000000002d, new GammaParticle(883500.0, 0.0014)), new(0.0021160000000000003d, new GammaParticle(896000.0, 0.00138)), new(0.0009521999999999999d, new GammaParticle(1003800.0, 0.00124)), new(0.00236992d, new GammaParticle(1008400.0, 0.00123)), new(0.00078292d, new GammaParticle(1047900.0, 0.00118)), new(0.00118496d, new GammaParticle(1058500.0, 0.00117)), new(0.001587d, new GammaParticle(1201600.0, 0.00103)), new(0.00435896d, new GammaParticle(1366300.0, 0.00091)), new(0.0009521999999999999d, new GammaParticle(1370800.0, 0.0009)), new(0.003174d, new GammaParticle(1510600.0, 0.00082)), new(0.0027508d, new GammaParticle(1560100.0, 0.00079)), new(0.00021160000000000002d, new GammaParticle(1570500.0, 0.00079)), new(0.00021160000000000002d, new GammaParticle(1673300.0, 0.00074)), new(0.00021160000000000002d, new GammaParticle(1683900.0, 0.00074)), new(0.00021160000000000002d, new GammaParticle(1882700.0, 0.00066)), new(0.0020102d, new GammaParticle(2053900.0, 0.0006)), new(0.0020102d, new GammaParticle(2082000.0, 0.0006)), new(0.0029624d, new GammaParticle(2155400.0, 0.00058)), new(0.00042320000000000004d, new GammaParticle(2167200.0, 0.00057)), new(0.00059248d, new GammaParticle(2174000.0, 0.00057)), new(0.0021d, new GammaParticle(2737.0, 0.45299)), new(0.006999999999999999d, new GammaParticle(19150.0, 0.06474)), new(0.013000000000000001d, new GammaParticle(19279.0, 0.06431)), new(0.0034000000000000002d, new GammaParticle(21736.0, 0.05704)), new(0.004d, new GammaParticle(21875.0, 0.05668)), new(0.0005600000000000001d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000763981d },
            { 100.0d, 0.000764267d },
            { 200.0d, 0.000764385d },
            { 300.0d, 0.000764422d },
            { 400.0d, 0.000764514d },
            { 500.0d, 0.00076464d },
            { 600.0d, 0.000764791d },
            { 700.0d, 0.000764952d },
            { 800.0d, 0.000765124d },
            { 900.0d, 0.000765299d },
            { 1000.0d, 0.000765475d },
            { 1500.0d, 0.000766333d },
            { 2000.0d, 0.000767119d },
            { 2500.0d, 0.000767821d },
            { 3000.0d, 0.000768444d },
            { 3500.0d, 0.000769014d },
            { 4000.0d, 0.000769528d },
            { 4500.0d, 0.000770003d },
            { 5000.0d, 0.000770434d },
            { 5500.0d, 0.00077083d },
            { 6000.0d, 0.000771187d },
            { 6500.0d, 0.000771571d },
            { 7000.0d, 0.000771944d },
            { 7500.0d, 0.000772307d },
            { 8000.0d, 0.000772659d },
            { 8500.0d, 0.00077301d },
            { 9000.0d, 0.000773354d },
            { 9500.0d, 0.00077371d },
            { 10000.0d, 0.000774064d },
            { 11000.0d, 0.000774773d },
            { 12000.0d, 0.00077548d },
            { 13000.0d, 0.000776206d },
            { 14000.0d, 0.00077694d },
            { 15000.0d, 0.000777682d },
            { 16000.0d, 0.00077844d },
            { 17000.0d, 0.000779215d },
            { 18000.0d, 0.000780004d },
            { 19000.0d, 0.000780815d },
            { 20000.0d, 0.000781644d },
            { 21000.0d, 0.000782497d },
            { 22000.0d, 0.000783372d },
            { 23000.0d, 0.00078427d },
            { 24000.0d, 0.00078519d },
            { 25000.0d, 0.000786127d },
            { 26000.0d, 0.000787066d },
            { 27000.0d, 0.000788008d },
            { 28000.0d, 0.000788954d },
            { 29000.0d, 0.000789903d },
            { 30000.0d, 0.000790856d },
            { 31000.0d, 0.000791814d },
            { 32000.0d, 0.000792775d },
            { 33000.0d, 0.000793741d },
            { 34000.0d, 0.000794711d },
            { 35000.0d, 0.000795686d },
            { 36000.0d, 0.000796664d },
            { 37000.0d, 0.000797648d },
            { 38000.0d, 0.000798635d },
            { 39000.0d, 0.000799627d },
            { 40000.0d, 0.000800623d },
            { 41000.0d, 0.000801623d },
            { 42000.0d, 0.000802626d },
            { 43000.0d, 0.000803633d },
            { 44000.0d, 0.000804644d },
            { 45000.0d, 0.000805659d },
            { 46000.0d, 0.000806677d },
            { 47000.0d, 0.000807698d },
            { 48000.0d, 0.000808723d },
            { 49000.0d, 0.00080975d },
            { 50000.0d, 0.000810779d },
            { 51000.0d, 0.000811812d },
            { 52000.0d, 0.000812848d },
            { 53000.0d, 0.000813885d },
            { 54000.0d, 0.000814926d },
            { 55000.0d, 0.000815968d },
            { 56000.0d, 0.000817013d },
            { 57000.0d, 0.00081806d },
            { 58000.0d, 0.000819108d },
            { 59000.0d, 0.000820159d },
            { 60000.0d, 0.000821211d },
            { 61000.0d, 0.000822264d },
            { 62000.0d, 0.00082332d },
            { 63000.0d, 0.000824376d },
            { 64000.0d, 0.000825434d },
            { 65000.0d, 0.000826493d },
            { 66000.0d, 0.000827551d },
            { 67000.0d, 0.000828608d },
            { 68000.0d, 0.000829664d },
            { 69000.0d, 0.00083072d },
            { 70000.0d, 0.000831774d },
            { 71000.0d, 0.000832828d },
            { 72000.0d, 0.000833881d },
            { 73000.0d, 0.000834933d },
            { 74000.0d, 0.000835983d },
            { 75000.0d, 0.000837033d },
            { 76000.0d, 0.000838081d },
            { 77000.0d, 0.000839127d },
            { 78000.0d, 0.000840172d },
            { 79000.0d, 0.000841215d },
            { 80000.0d, 0.000842257d },
            { 81000.0d, 0.000843297d },
            { 82000.0d, 0.000844335d },
            { 83000.0d, 0.000845371d },
            { 84000.0d, 0.000846405d },
            { 85000.0d, 0.000847437d },
            { 86000.0d, 0.000848467d },
            { 87000.0d, 0.000849495d },
            { 88000.0d, 0.000850521d },
            { 89000.0d, 0.000851545d },
            { 90000.0d, 0.000852566d },
            { 91000.0d, 0.000853585d },
            { 92000.0d, 0.000854602d },
            { 93000.0d, 0.000855616d },
            { 94000.0d, 0.000856627d },
            { 95000.0d, 0.000857636d },
            { 96000.0d, 0.000858643d },
            { 97000.0d, 0.000859647d },
            { 98000.0d, 0.000860648d },
            { 99000.0d, 0.000861647d },
            { 100000.0d, 0.000862643d },
            { 110000.0d, 0.000872436d },
            { 120000.0d, 0.000881873d },
            { 130000.0d, 0.000890927d },
            { 140000.0d, 0.000899581d },
            { 150000.0d, 0.000907816d },
            { 160000.0d, 0.000915602d },
            { 170000.0d, 0.00092293d },
            { 180000.0d, 0.000929799d },
            { 190000.0d, 0.000936204d },
            { 200000.0d, 0.000942127d },
            { 210000.0d, 0.00094757d },
            { 220000.0d, 0.000952534d },
            { 230000.0d, 0.000957024d },
            { 240000.0d, 0.000961026d },
            { 250000.0d, 0.000964545d },
            { 260000.0d, 0.000967589d },
            { 270000.0d, 0.000970162d },
            { 280000.0d, 0.000972257d },
            { 290000.0d, 0.000973878d },
            { 300000.0d, 0.000975037d },
            { 310000.0d, 0.000975739d },
            { 320000.0d, 0.000975978d },
            { 330000.0d, 0.000975763d },
            { 340000.0d, 0.000975103d },
            { 350000.0d, 0.00097401d },
            { 360000.0d, 0.000972491d },
            { 370000.0d, 0.000970557d },
            { 380000.0d, 0.000968222d },
            { 390000.0d, 0.000965496d },
            { 400000.0d, 0.000962373d },
            { 410000.0d, 0.000958868d },
            { 420000.0d, 0.000954995d },
            { 430000.0d, 0.000950762d },
            { 440000.0d, 0.00094617d },
            { 450000.0d, 0.000941231d },
            { 460000.0d, 0.000935961d },
            { 470000.0d, 0.000930371d },
            { 480000.0d, 0.000924463d },
            { 490000.0d, 0.00091825d },
            { 500000.0d, 0.000911749d },
            { 510000.0d, 0.000904975d },
            { 520000.0d, 0.000897928d },
            { 530000.0d, 0.000890626d },
            { 540000.0d, 0.000883087d },
            { 550000.0d, 0.000875323d },
            { 560000.0d, 0.000867341d },
            { 570000.0d, 0.000859156d },
            { 580000.0d, 0.000850787d },
            { 590000.0d, 0.000842248d },
            { 600000.0d, 0.000833544d },
            { 610000.0d, 0.000824691d },
            { 620000.0d, 0.000815709d },
            { 630000.0d, 0.000806617d },
            { 640000.0d, 0.000797436d },
            { 650000.0d, 0.000788185d },
            { 660000.0d, 0.000778888d },
            { 670000.0d, 0.000769559d },
            { 680000.0d, 0.000760203d },
            { 690000.0d, 0.000750837d },
            { 700000.0d, 0.000741484d },
            { 710000.0d, 0.000732154d },
            { 720000.0d, 0.000722819d },
            { 730000.0d, 0.000713494d },
            { 740000.0d, 0.0007042d },
            { 750000.0d, 0.000694943d },
            { 760000.0d, 0.000685682d },
            { 770000.0d, 0.000676431d },
            { 780000.0d, 0.000667206d },
            { 790000.0d, 0.000658013d },
            { 800000.0d, 0.000648812d },
            { 810000.0d, 0.000639614d },
            { 820000.0d, 0.000630434d },
            { 830000.0d, 0.000621277d },
            { 840000.0d, 0.000612115d },
            { 850000.0d, 0.000602957d },
            { 860000.0d, 0.000593817d },
            { 870000.0d, 0.000584703d },
            { 880000.0d, 0.000575595d },
            { 890000.0d, 0.000566504d },
            { 900000.0d, 0.000557442d },
            { 910000.0d, 0.000548419d },
            { 920000.0d, 0.000539419d },
            { 930000.0d, 0.000530456d },
            { 940000.0d, 0.00052154d },
            { 950000.0d, 0.00051268d },
            { 960000.0d, 0.000503865d },
            { 970000.0d, 0.000495106d },
            { 980000.0d, 0.000486414d },
            { 990000.0d, 0.000477796d },
            { 1000000.0d, 0.000469242d },
            { 1012000.0d, 0.000459073d },
            { 1024000.0d, 0.000449029d },
            { 1036000.0d, 0.000439108d },
            { 1048000.0d, 0.000429303d },
            { 1060000.0d, 0.000419636d },
            { 1072000.0d, 0.000410113d },
            { 1084000.0d, 0.000400718d },
            { 1096000.0d, 0.000391467d },
            { 1108000.0d, 0.000382374d },
            { 1120000.0d, 0.000373423d },
            { 1132000.0d, 0.000364619d },
            { 1144000.0d, 0.000355979d },
            { 1156000.0d, 0.000347499d },
            { 1168000.0d, 0.000339168d },
            { 1180000.0d, 0.000331005d },
            { 1192000.0d, 0.000323016d },
            { 1204000.0d, 0.000315182d },
            { 1216000.0d, 0.000307517d },
            { 1228000.0d, 0.000300033d },
            { 1240000.0d, 0.000292712d },
            { 1252000.0d, 0.000285539d },
            { 1264000.0d, 0.000278496d },
            { 1276000.0d, 0.000271598d },
            { 1288000.0d, 0.000264856d },
            { 1300000.0d, 0.000258284d },
            { 1312000.0d, 0.000251883d },
            { 1324000.0d, 0.000245627d },
            { 1336000.0d, 0.000239493d },
            { 1348000.0d, 0.000233485d },
            { 1360000.0d, 0.000227616d },
            { 1372000.0d, 0.000221895d },
            { 1384000.0d, 0.000216333d },
            { 1396000.0d, 0.00021092d },
            { 1408000.0d, 0.000205649d },
            { 1420000.0d, 0.000200527d },
            { 1432000.0d, 0.000195556d },
            { 1444000.0d, 0.000190716d },
            { 1456000.0d, 0.000186013d },
            { 1468000.0d, 0.000181453d },
            { 1480000.0d, 0.000177016d },
            { 1492000.0d, 0.000172697d },
            { 1504000.0d, 0.00016848d },
            { 1516000.0d, 0.000164361d },
            { 1528000.0d, 0.000160346d },
            { 1540000.0d, 0.000156441d },
            { 1552000.0d, 0.000152649d },
            { 1564000.0d, 0.000148959d },
            { 1576000.0d, 0.000145374d },
            { 1588000.0d, 0.000141901d },
            { 1600000.0d, 0.000138535d },
            { 1612000.0d, 0.000135279d },
            { 1624000.0d, 0.000132139d },
            { 1636000.0d, 0.000129117d },
            { 1648000.0d, 0.000126213d },
            { 1660000.0d, 0.000123433d },
            { 1672000.0d, 0.000120781d },
            { 1684000.0d, 0.000118259d },
            { 1696000.0d, 0.000115871d },
            { 1708000.0d, 0.000113622d },
            { 1720000.0d, 0.000111511d },
            { 1732000.0d, 0.000109541d },
            { 1744000.0d, 0.000107719d },
            { 1756000.0d, 0.000106039d },
            { 1768000.0d, 0.000104498d },
            { 1780000.0d, 0.000103099d },
            { 1792000.0d, 0.000101838d },
            { 1804000.0d, 0.000100687d },
            { 1816000.0d, 0.0000996105d },
            { 1828000.0d, 0.0000985612d },
            { 1840000.0d, 0.0000975329d },
            { 1852000.0d, 0.0000965265d },
            { 1864000.0d, 0.0000955435d },
            { 1876000.0d, 0.0000945736d },
            { 1888000.0d, 0.0000936067d },
            { 1900000.0d, 0.0000926436d },
            { 1912000.0d, 0.0000916832d },
            { 1924000.0d, 0.000090721d },
            { 1936000.0d, 0.0000897569d },
            { 1948000.0d, 0.0000887916d },
            { 1960000.0d, 0.0000878236d },
            { 1972000.0d, 0.0000868526d },
            { 1984000.0d, 0.0000858795d },
            { 1996000.0d, 0.0000849037d },
            { 2008000.0d, 0.0000839252d },
            { 2020000.0d, 0.0000829445d },
            { 2032000.0d, 0.0000819619d },
            { 2044000.0d, 0.0000809773d },
            { 2056000.0d, 0.000079991d },
            { 2068000.0d, 0.0000790035d },
            { 2080000.0d, 0.0000780148d },
            { 2092000.0d, 0.0000770252d },
            { 2104000.0d, 0.0000760351d },
            { 2116000.0d, 0.0000750446d },
            { 2128000.0d, 0.0000740539d },
            { 2140000.0d, 0.0000730635d },
            { 2152000.0d, 0.0000720733d },
            { 2164000.0d, 0.0000710834d },
            { 2176000.0d, 0.0000700943d },
            { 2188000.0d, 0.0000691061d },
            { 2200000.0d, 0.0000681184d },
            { 2212000.0d, 0.0000671314d },
            { 2224000.0d, 0.0000661456d },
            { 2236000.0d, 0.0000651603d },
            { 2248000.0d, 0.0000641752d },
            { 2260000.0d, 0.0000631905d },
            { 2272000.0d, 0.0000622061d },
            { 2284000.0d, 0.0000612197d },
            { 2296000.0d, 0.0000602316d },
            { 2308000.0d, 0.0000592423d },
            { 2320000.0d, 0.0000582519d },
            { 2332000.0d, 0.0000572609d },
            { 2344000.0d, 0.0000562698d },
            { 2356000.0d, 0.0000552787d },
            { 2368000.0d, 0.0000542882d },
            { 2380000.0d, 0.0000532985d },
            { 2392000.0d, 0.0000523101d },
            { 2404000.0d, 0.0000513233d },
            { 2416000.0d, 0.0000503386d },
            { 2428000.0d, 0.0000493562d },
            { 2440000.0d, 0.0000483768d },
            { 2452000.0d, 0.0000474004d },
            { 2464000.0d, 0.0000464278d },
            { 2476000.0d, 0.0000454591d },
            { 2488000.0d, 0.000044495d },
            { 2500000.0d, 0.0000435357d },
            { 2512000.0d, 0.0000425815d },
            { 2524000.0d, 0.000041633d },
            { 2536000.0d, 0.0000406907d },
            { 2548000.0d, 0.0000397548d },
            { 2560000.0d, 0.0000388259d },
            { 2572000.0d, 0.0000379044d },
            { 2584000.0d, 0.0000369907d },
            { 2596000.0d, 0.0000360852d },
            { 2608000.0d, 0.0000351884d },
            { 2620000.0d, 0.0000343007d },
            { 2632000.0d, 0.0000334226d },
            { 2644000.0d, 0.0000325545d },
            { 2656000.0d, 0.0000316969d },
            { 2668000.0d, 0.0000308502d },
            { 2680000.0d, 0.0000300149d },
            { 2692000.0d, 0.0000291915d },
            { 2704000.0d, 0.0000283804d },
            { 2716000.0d, 0.0000275819d },
            { 2728000.0d, 0.0000267968d },
            { 2740000.0d, 0.0000260255d },
            { 2752000.0d, 0.0000252682d },
            { 2764000.0d, 0.0000245256d },
            { 2776000.0d, 0.0000237982d },
            { 2788000.0d, 0.0000230864d },
            { 2800000.0d, 0.0000223906d },
            { 2812000.0d, 0.0000217115d },
            { 2824000.0d, 0.0000210493d },
            { 2836000.0d, 0.0000204048d },
            { 2848000.0d, 0.0000197782d },
            { 2860000.0d, 0.0000191701d },
            { 2872000.0d, 0.0000185763d },
            { 2884000.0d, 0.0000179929d },
            { 2896000.0d, 0.0000174191d },
            { 2908000.0d, 0.0000168529d },
            { 2920000.0d, 0.0000162943d },
            { 2932000.0d, 0.0000157437d },
            { 2944000.0d, 0.0000152014d },
            { 2956000.0d, 0.0000146677d },
            { 2968000.0d, 0.0000141427d },
            { 2980000.0d, 0.0000136268d },
            { 2992000.0d, 0.00001312d },
            { 3004000.0d, 0.000012621d },
            { 3016000.0d, 0.0000121303d },
            { 3028000.0d, 0.0000116479d },
            { 3040000.0d, 0.0000111742d },
            { 3052000.0d, 0.0000107094d },
            { 3064000.0d, 0.0000102538d },
            { 3076000.0d, 0.0000098076d },
            { 3088000.0d, 0.00000937108d },
            { 3100000.0d, 0.00000894453d },
            { 3112000.0d, 0.00000852817d },
            { 3124000.0d, 0.0000081223d },
            { 3136000.0d, 0.00000772715d },
            { 3148000.0d, 0.00000734296d },
            { 3160000.0d, 0.00000696929d },
            { 3172000.0d, 0.00000660621d },
            { 3184000.0d, 0.00000625397d },
            { 3196000.0d, 0.00000591281d },
            { 3208000.0d, 0.000005583d },
            { 3220000.0d, 0.00000526479d },
            { 3232000.0d, 0.00000495843d },
            { 3244000.0d, 0.00000466418d },
            { 3256000.0d, 0.0000043823d },
            { 3268000.0d, 0.00000411302d },
            { 3280000.0d, 0.00000385663d },
            { 3292000.0d, 0.00000361333d },
            { 3304000.0d, 0.00000338336d },
            { 3316000.0d, 0.00000316334d },
            { 3328000.0d, 0.00000294988d },
            { 3340000.0d, 0.00000274313d },
            { 3352000.0d, 0.00000254324d },
            { 3364000.0d, 0.00000235035d },
            { 3376000.0d, 0.00000216455d },
            { 3388000.0d, 0.00000198547d },
            { 3400000.0d, 0.00000181313d },
            { 3412000.0d, 0.00000164771d },
            { 3424000.0d, 0.00000148929d },
            { 3436000.0d, 0.00000133806d },
            { 3448000.0d, 0.00000119414d },
            { 3460000.0d, 0.00000105767d },
            { 3472000.0d, 0.000000928793d },
            { 3484000.0d, 0.000000807649d },
            { 3496000.0d, 0.000000694381d },
            { 3508000.0d, 0.000000589129d },
            { 3520000.0d, 0.000000492036d },
            { 3532000.0d, 0.000000403242d },
            { 3544000.0d, 0.000000322891d },
            { 3556000.0d, 0.000000251121d },
            { 3568000.0d, 0.000000188074d },
            { 3580000.0d, 0.000000133888d },
            { 3592000.0d, 0.0000000887005d },
            { 3604000.0d, 0.0000000526464d },
            { 3616000.0d, 0.0000000258551d },
            { 3628000.0d, 0.00000000844797d },
            { 3640000.0d, 0.00000000052372d },
            { 3644000.0d, 0d },

        }; 
    }
}
    