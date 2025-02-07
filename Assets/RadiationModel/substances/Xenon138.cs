using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon138 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon138";
        public override double halfLife { get; } = 848.4d;
        public override double atomicWeight { get; } = 137.91415d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium138()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0020119d, new GammaParticle(4850.0, 0.25564)), new(0.0068882d, new GammaParticle(10850.0, 0.11427)), new(0.0005115d, new GammaParticle(68300.0, 0.01815)), new(0.0007502d, new GammaParticle(137200.0, 0.00904)), new(0.06444899999999999d, new GammaParticle(153858.0, 0.00806)), new(0.037850999999999996d, new GammaParticle(242560.0, 0.00511)), new(0.341d, new GammaParticle(258411.0, 0.0048)), new(0.0046376d, new GammaParticle(282510.0, 0.00439)), new(0.00025234d, new GammaParticle(325300.0, 0.00381)), new(0.00016709000000000003d, new GammaParticle(329400.0, 0.00376)), new(0.0011594d, new GammaParticle(335280.0, 0.0037)), new(0.0054218999999999995d, new GammaParticle(371440.0, 0.00334)), new(0.0682d, new GammaParticle(396513.0, 0.00313)), new(0.023529d, new GammaParticle(401360.0, 0.00309)), new(0.000682d, new GammaParticle(412800.0, 0.003)), new(0.21994499999999997d, new GammaParticle(434562.0, 0.00285)), new(0.0039215d, new GammaParticle(500220.0, 0.00248)), new(0.002728d, new GammaParticle(530070.0, 0.00234)), new(0.00016027d, new GammaParticle(534000.0, 0.00232)), new(0.0012617000000000001d, new GammaParticle(537760.0, 0.00231)), new(0.0002387d, new GammaParticle(540800.0, 0.00229)), new(0.0012617000000000001d, new GammaParticle(555950.0, 0.00223)), new(0.0033077000000000002d, new GammaParticle(568530.0, 0.00218)), new(0.0008183999999999999d, new GammaParticle(579680.0, 0.00214)), new(0.00020459999999999999d, new GammaParticle(586000.0, 0.00212)), new(0.0013299d, new GammaParticle(588840.0, 0.00211)), new(0.0002387d, new GammaParticle(619700.0, 0.002)), new(0.0001705d, new GammaParticle(647200.0, 0.00192)), new(0.0015686d, new GammaParticle(654080.0, 0.0019)), new(0.0007843d, new GammaParticle(675370.0, 0.00184)), new(0.0005797d, new GammaParticle(680240.0, 0.00182)), new(0.000341d, new GammaParticle(691500.0, 0.00179)), new(0.0009548d, new GammaParticle(693530.0, 0.00179)), new(0.0002387d, new GammaParticle(697600.0, 0.00178)), new(0.0006138d, new GammaParticle(703580.0, 0.00176)), new(0.000341d, new GammaParticle(733900.0, 0.00169)), new(0.00027279999999999996d, new GammaParticle(755000.0, 0.00164)), new(0.0007160999999999999d, new GammaParticle(774210.0, 0.0016)), new(0.0004774d, new GammaParticle(778100.0, 0.00159)), new(0.0002387d, new GammaParticle(792900.0, 0.00156)), new(0.0001705d, new GammaParticle(799600.0, 0.00155)), new(0.0007843d, new GammaParticle(816060.0, 0.00152)), new(0.0004774d, new GammaParticle(848700.0, 0.00146)), new(0.0007502d, new GammaParticle(851300.0, 0.00146)), new(0.0032053999999999997d, new GammaParticle(865820.0, 0.00143)), new(0.0067177d, new GammaParticle(869350.0, 0.00143)), new(0.0014321999999999998d, new GammaParticle(896870.0, 0.00138)), new(0.0004774d, new GammaParticle(902300.0, 0.00137)), new(0.0035464d, new GammaParticle(912510.0, 0.00136)), new(0.009957200000000001d, new GammaParticle(917130.0, 0.00135)), new(0.0014663d, new GammaParticle(936360.0, 0.00132)), new(0.0024893000000000003d, new GammaParticle(941250.0, 0.00132)), new(0.000682d, new GammaParticle(946630.0, 0.00131)), new(0.0003069d, new GammaParticle(953100.0, 0.0013)), new(0.000682d, new GammaParticle(996800.0, 0.00124)), new(0.0009548d, new GammaParticle(1076380.0, 0.00115)), new(0.004433d, new GammaParticle(1093870.0, 0.00113)), new(0.0023188d, new GammaParticle(1098770.0, 0.00113)), new(0.0011594d, new GammaParticle(1102240.0, 0.00112)), new(0.0159588d, new GammaParticle(1114290.0, 0.00111)), new(0.0055583d, new GammaParticle(1141640.0, 0.00109)), new(0.0014321999999999998d, new GammaParticle(1145440.0, 0.00108)), new(0.000341d, new GammaParticle(1153600.0, 0.00107)), new(0.0010571d, new GammaParticle(1160960.0, 0.00107)), new(0.0008866d, new GammaParticle(1189540.0, 0.00104)), new(0.0009548d, new GammaParticle(1194940.0, 0.00104)), new(0.0003751d, new GammaParticle(1204500.0, 0.00103)), new(0.00040919999999999997d, new GammaParticle(1218700.0, 0.00102)), new(0.000682d, new GammaParticle(1228300.0, 0.00101)), new(0.0009207d, new GammaParticle(1311070.0, 0.00095)), new(0.0005455999999999999d, new GammaParticle(1356600.0, 0.00091)), new(0.0003751d, new GammaParticle(1361900.0, 0.00091)), new(0.0007502d, new GammaParticle(1381400.0, 0.0009)), new(0.0008183999999999999d, new GammaParticle(1385500.0, 0.00089)), new(0.0007502d, new GammaParticle(1473200.0, 0.00084)), new(0.0008183999999999999d, new GammaParticle(1548900.0, 0.0008)), new(0.0028643999999999996d, new GammaParticle(1571840.0, 0.00079)), new(0.0005455999999999999d, new GammaParticle(1578100.0, 0.00079)), new(0.0025575d, new GammaParticle(1614570.0, 0.00077)), new(0.0007160999999999999d, new GammaParticle(1646500.0, 0.00075)), new(0.18107099999999998d, new GammaParticle(1768260.0, 0.0007)), new(0.00040919999999999997d, new GammaParticle(1783400.0, 0.0007)), new(0.0003751d, new GammaParticle(1799400.0, 0.00069)), new(0.0019436999999999998d, new GammaParticle(1812540.0, 0.00068)), new(0.0154132d, new GammaParticle(1850860.0, 0.00067)), new(0.0007502d, new GammaParticle(1887300.0, 0.00066)), new(0.0061039d, new GammaParticle(1925360.0, 0.00064)), new(0.057969999999999994d, new GammaParticle(2004750.0, 0.00062)), new(0.13264900000000002d, new GammaParticle(2015820.0, 0.00062)), new(0.000341d, new GammaParticle(2041200.0, 0.00061)), new(0.0156178d, new GammaParticle(2079170.0, 0.0006)), new(0.0247566d, new GammaParticle(2252260.0, 0.00055)), new(0.00040919999999999997d, new GammaParticle(2266800.0, 0.00055)), new(0.0067177d, new GammaParticle(2321900.0, 0.00053)), new(0.0006138d, new GammaParticle(2326900.0, 0.00053)), new(0.0033759d, new GammaParticle(2475260.0, 0.0005)), new(0.0005797d, new GammaParticle(2492610.0, 0.0005)), new(0.0018755d, new GammaParticle(2497560.0, 0.0005)), new(0.056291195109864d, new GammaParticle(4749.0, 0.26107)), new(0.011162932646795692d, new GammaParticle(30625.0, 0.04048)), new(0.02062245085312339d, new GammaParticle(30973.0, 0.04003)), new(0.006024914332219388d, new GammaParticle(35089.0, 0.03533)), new(0.007494993429280919d, new GammaParticle(35414.0, 0.03501)), new(0.001470079097061531d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00117988d },
            { 1000.0d, 0.0011753d },
            { 2000.0d, 0.00117348d },
            { 3000.0d, 0.00117441d },
            { 4000.0d, 0.00117581d },
            { 5000.0d, 0.00117744d },
            { 6000.0d, 0.00117928d },
            { 7000.0d, 0.00118076d },
            { 8000.0d, 0.00118208d },
            { 9000.0d, 0.00118334d },
            { 10000.0d, 0.00118453d },
            { 11000.0d, 0.00118568d },
            { 12000.0d, 0.00118678d },
            { 13000.0d, 0.00118787d },
            { 14000.0d, 0.00118892d },
            { 15000.0d, 0.00118995d },
            { 16000.0d, 0.00119095d },
            { 17000.0d, 0.00119194d },
            { 18000.0d, 0.0011929d },
            { 19000.0d, 0.00119385d },
            { 20000.0d, 0.00119478d },
            { 21000.0d, 0.00119569d },
            { 22000.0d, 0.00119658d },
            { 23000.0d, 0.00119746d },
            { 24000.0d, 0.00119833d },
            { 25000.0d, 0.00119918d },
            { 26000.0d, 0.00120003d },
            { 27000.0d, 0.00120086d },
            { 28000.0d, 0.00120168d },
            { 29000.0d, 0.00120249d },
            { 30000.0d, 0.00120328d },
            { 31000.0d, 0.00120407d },
            { 32000.0d, 0.00120485d },
            { 33000.0d, 0.00120562d },
            { 34000.0d, 0.00120639d },
            { 35000.0d, 0.00120714d },
            { 36000.0d, 0.00120789d },
            { 37000.0d, 0.00120862d },
            { 38000.0d, 0.00120935d },
            { 39000.0d, 0.00121007d },
            { 40000.0d, 0.00121079d },
            { 41000.0d, 0.0012115d },
            { 42000.0d, 0.0012122d },
            { 43000.0d, 0.00121289d },
            { 44000.0d, 0.00121358d },
            { 45000.0d, 0.00121426d },
            { 46000.0d, 0.00121494d },
            { 47000.0d, 0.0012156d },
            { 48000.0d, 0.00121626d },
            { 49000.0d, 0.00121692d },
            { 50000.0d, 0.00121757d },
            { 51000.0d, 0.00121821d },
            { 52000.0d, 0.00121885d },
            { 53000.0d, 0.00121947d },
            { 54000.0d, 0.0012201d },
            { 55000.0d, 0.00122072d },
            { 56000.0d, 0.00122133d },
            { 57000.0d, 0.00122193d },
            { 58000.0d, 0.00122253d },
            { 59000.0d, 0.00122312d },
            { 60000.0d, 0.0012237d },
            { 61000.0d, 0.00122428d },
            { 62000.0d, 0.00122485d },
            { 63000.0d, 0.00122542d },
            { 64000.0d, 0.00122598d },
            { 65000.0d, 0.00122653d },
            { 66000.0d, 0.00122708d },
            { 67000.0d, 0.00122761d },
            { 68000.0d, 0.00122815d },
            { 69000.0d, 0.00122867d },
            { 70000.0d, 0.00122919d },
            { 71000.0d, 0.0012297d },
            { 72000.0d, 0.00123021d },
            { 73000.0d, 0.00123071d },
            { 74000.0d, 0.0012312d },
            { 75000.0d, 0.00123168d },
            { 76000.0d, 0.00123216d },
            { 77000.0d, 0.00123263d },
            { 78000.0d, 0.00123309d },
            { 79000.0d, 0.00123355d },
            { 80000.0d, 0.001234d },
            { 81000.0d, 0.00123444d },
            { 82000.0d, 0.00123487d },
            { 83000.0d, 0.0012353d },
            { 84000.0d, 0.00123572d },
            { 85000.0d, 0.00123613d },
            { 86000.0d, 0.00123653d },
            { 87000.0d, 0.00123693d },
            { 88000.0d, 0.00123732d },
            { 89000.0d, 0.0012377d },
            { 90000.0d, 0.00123807d },
            { 91000.0d, 0.00123844d },
            { 92000.0d, 0.0012388d },
            { 93000.0d, 0.00123915d },
            { 94000.0d, 0.00123949d },
            { 95000.0d, 0.00123982d },
            { 96000.0d, 0.00124015d },
            { 97000.0d, 0.00124047d },
            { 98000.0d, 0.00124078d },
            { 99000.0d, 0.00124108d },
            { 100000.0d, 0.00124138d },
            { 109000.0d, 0.00124366d },
            { 118000.0d, 0.00124527d },
            { 127000.0d, 0.00124618d },
            { 136000.0d, 0.00124639d },
            { 145000.0d, 0.00124588d },
            { 154000.0d, 0.00124464d },
            { 163000.0d, 0.00124268d },
            { 172000.0d, 0.00124d },
            { 181000.0d, 0.00123659d },
            { 190000.0d, 0.00123246d },
            { 199000.0d, 0.00122762d },
            { 208000.0d, 0.00122208d },
            { 217000.0d, 0.00121585d },
            { 226000.0d, 0.00120894d },
            { 235000.0d, 0.00120136d },
            { 244000.0d, 0.00119313d },
            { 253000.0d, 0.00118426d },
            { 262000.0d, 0.00117479d },
            { 271000.0d, 0.00116471d },
            { 280000.0d, 0.00115406d },
            { 289000.0d, 0.00114285d },
            { 298000.0d, 0.00113111d },
            { 307000.0d, 0.00111887d },
            { 316000.0d, 0.00110614d },
            { 325000.0d, 0.00109296d },
            { 334000.0d, 0.00107934d },
            { 343000.0d, 0.00106533d },
            { 352000.0d, 0.00105094d },
            { 361000.0d, 0.00103621d },
            { 370000.0d, 0.00102118d },
            { 379000.0d, 0.00100586d },
            { 388000.0d, 0.000990302d },
            { 397000.0d, 0.00097453d },
            { 406000.0d, 0.000958582d },
            { 415000.0d, 0.000942478d },
            { 424000.0d, 0.00092623d },
            { 433000.0d, 0.000909842d },
            { 442000.0d, 0.000893313d },
            { 451000.0d, 0.000876676d },
            { 460000.0d, 0.000859965d },
            { 469000.0d, 0.000843216d },
            { 478000.0d, 0.000826465d },
            { 487000.0d, 0.000809749d },
            { 496000.0d, 0.000793104d },
            { 505000.0d, 0.000776569d },
            { 514000.0d, 0.000760184d },
            { 523000.0d, 0.000743987d },
            { 532000.0d, 0.000728018d },
            { 541000.0d, 0.00071232d },
            { 550000.0d, 0.000696934d },
            { 559000.0d, 0.0006819d },
            { 568000.0d, 0.000667265d },
            { 577000.0d, 0.000653071d },
            { 586000.0d, 0.000639255d },
            { 595000.0d, 0.000625753d },
            { 604000.0d, 0.000612598d },
            { 613000.0d, 0.00059983d },
            { 622000.0d, 0.000587486d },
            { 631000.0d, 0.000575602d },
            { 640000.0d, 0.000564217d },
            { 649000.0d, 0.00055337d },
            { 658000.0d, 0.00054299d },
            { 667000.0d, 0.000532762d },
            { 676000.0d, 0.000522678d },
            { 685000.0d, 0.000512758d },
            { 694000.0d, 0.000503023d },
            { 703000.0d, 0.000493496d },
            { 712000.0d, 0.000484197d },
            { 721000.0d, 0.000475148d },
            { 730000.0d, 0.000466369d },
            { 739000.0d, 0.000457884d },
            { 748000.0d, 0.000449717d },
            { 757000.0d, 0.000441888d },
            { 766000.0d, 0.000434422d },
            { 775000.0d, 0.000427343d },
            { 784000.0d, 0.000420672d },
            { 793000.0d, 0.000414435d },
            { 802000.0d, 0.000408656d },
            { 811000.0d, 0.000403359d },
            { 820000.0d, 0.00039857d },
            { 829000.0d, 0.000394312d },
            { 838000.0d, 0.000390612d },
            { 847000.0d, 0.000387494d },
            { 856000.0d, 0.000384984d },
            { 865000.0d, 0.000383109d },
            { 874000.0d, 0.000381892d },
            { 883000.0d, 0.000381361d },
            { 892000.0d, 0.000381462d },
            { 901000.0d, 0.000381636d },
            { 910000.0d, 0.000381762d },
            { 919000.0d, 0.00038184d },
            { 928000.0d, 0.00038187d },
            { 937000.0d, 0.000381852d },
            { 946000.0d, 0.000381787d },
            { 955000.0d, 0.000381675d },
            { 964000.0d, 0.000381516d },
            { 973000.0d, 0.000381311d },
            { 982000.0d, 0.000381058d },
            { 991000.0d, 0.00038076d },
            { 1000000.0d, 0.000380416d },
            { 1009000.0d, 0.000380026d },
            { 1018000.0d, 0.00037959d },
            { 1027000.0d, 0.000379109d },
            { 1036000.0d, 0.000378584d },
            { 1045000.0d, 0.000378014d },
            { 1054000.0d, 0.0003774d },
            { 1063000.0d, 0.000376742d },
            { 1072000.0d, 0.00037604d },
            { 1081000.0d, 0.000375296d },
            { 1090000.0d, 0.000374508d },
            { 1099000.0d, 0.000373677d },
            { 1108000.0d, 0.000372805d },
            { 1117000.0d, 0.00037189d },
            { 1126000.0d, 0.000370933d },
            { 1135000.0d, 0.000369933d },
            { 1144000.0d, 0.000368889d },
            { 1153000.0d, 0.000367801d },
            { 1162000.0d, 0.00036667d },
            { 1171000.0d, 0.000365497d },
            { 1180000.0d, 0.000364279d },
            { 1189000.0d, 0.000363021d },
            { 1198000.0d, 0.00036172d },
            { 1207000.0d, 0.000360378d },
            { 1216000.0d, 0.000358995d },
            { 1225000.0d, 0.00035757d },
            { 1234000.0d, 0.000356105d },
            { 1243000.0d, 0.0003546d },
            { 1252000.0d, 0.000353055d },
            { 1261000.0d, 0.000351472d },
            { 1270000.0d, 0.000349849d },
            { 1279000.0d, 0.000348188d },
            { 1288000.0d, 0.000346488d },
            { 1297000.0d, 0.000344752d },
            { 1306000.0d, 0.000342978d },
            { 1315000.0d, 0.000341167d },
            { 1324000.0d, 0.00033932d },
            { 1333000.0d, 0.000337436d },
            { 1342000.0d, 0.000335518d },
            { 1351000.0d, 0.000333565d },
            { 1360000.0d, 0.000331577d },
            { 1369000.0d, 0.000329555d },
            { 1378000.0d, 0.000327499d },
            { 1387000.0d, 0.000325412d },
            { 1396000.0d, 0.00032329d },
            { 1405000.0d, 0.000321137d },
            { 1414000.0d, 0.000318952d },
            { 1423000.0d, 0.000316736d },
            { 1432000.0d, 0.000314488d },
            { 1441000.0d, 0.000312211d },
            { 1450000.0d, 0.000309905d },
            { 1459000.0d, 0.000307568d },
            { 1468000.0d, 0.000305204d },
            { 1477000.0d, 0.000302811d },
            { 1486000.0d, 0.000300391d },
            { 1495000.0d, 0.000297944d },
            { 1504000.0d, 0.000295471d },
            { 1513000.0d, 0.000292972d },
            { 1522000.0d, 0.000290448d },
            { 1531000.0d, 0.000287899d },
            { 1540000.0d, 0.000285327d },
            { 1549000.0d, 0.000282731d },
            { 1558000.0d, 0.000280111d },
            { 1567000.0d, 0.000277469d },
            { 1576000.0d, 0.000274804d },
            { 1585000.0d, 0.000272117d },
            { 1594000.0d, 0.000269409d },
            { 1603000.0d, 0.000266681d },
            { 1612000.0d, 0.000263933d },
            { 1621000.0d, 0.000261165d },
            { 1630000.0d, 0.000258379d },
            { 1639000.0d, 0.000255575d },
            { 1648000.0d, 0.000252754d },
            { 1657000.0d, 0.000249916d },
            { 1666000.0d, 0.000247062d },
            { 1675000.0d, 0.000244193d },
            { 1684000.0d, 0.000241309d },
            { 1693000.0d, 0.000238412d },
            { 1702000.0d, 0.000235501d },
            { 1711000.0d, 0.000232578d },
            { 1720000.0d, 0.000229642d },
            { 1729000.0d, 0.000226695d },
            { 1738000.0d, 0.000223736d },
            { 1747000.0d, 0.000220768d },
            { 1756000.0d, 0.000217789d },
            { 1765000.0d, 0.000214801d },
            { 1774000.0d, 0.000211805d },
            { 1783000.0d, 0.000208802d },
            { 1792000.0d, 0.000205792d },
            { 1801000.0d, 0.000202775d },
            { 1810000.0d, 0.000199754d },
            { 1819000.0d, 0.000196727d },
            { 1828000.0d, 0.000193697d },
            { 1837000.0d, 0.000190664d },
            { 1846000.0d, 0.000187628d },
            { 1855000.0d, 0.00018459d },
            { 1864000.0d, 0.000181552d },
            { 1873000.0d, 0.000178514d },
            { 1882000.0d, 0.000175476d },
            { 1891000.0d, 0.00017244d },
            { 1900000.0d, 0.000169407d },
            { 1909000.0d, 0.000166377d },
            { 1918000.0d, 0.000163351d },
            { 1927000.0d, 0.00016033d },
            { 1936000.0d, 0.000157315d },
            { 1945000.0d, 0.000154307d },
            { 1954000.0d, 0.000151306d },
            { 1963000.0d, 0.000148314d },
            { 1972000.0d, 0.000145331d },
            { 1981000.0d, 0.000142357d },
            { 1990000.0d, 0.000139393d },
            { 1999000.0d, 0.00013644d },
            { 2008000.0d, 0.0001335d },
            { 2017000.0d, 0.000130573d },
            { 2026000.0d, 0.000127659d },
            { 2035000.0d, 0.00012476d },
            { 2044000.0d, 0.000121877d },
            { 2053000.0d, 0.00011901d },
            { 2062000.0d, 0.000116161d },
            { 2071000.0d, 0.000113331d },
            { 2080000.0d, 0.00011052d },
            { 2089000.0d, 0.00010773d },
            { 2098000.0d, 0.000104961d },
            { 2107000.0d, 0.000102214d },
            { 2116000.0d, 0.0000994913d },
            { 2125000.0d, 0.0000967927d },
            { 2134000.0d, 0.0000941195d },
            { 2143000.0d, 0.0000914728d },
            { 2152000.0d, 0.0000888533d },
            { 2161000.0d, 0.0000862625d },
            { 2170000.0d, 0.0000837014d },
            { 2179000.0d, 0.0000811706d },
            { 2188000.0d, 0.0000786714d },
            { 2197000.0d, 0.0000762049d },
            { 2206000.0d, 0.0000737721d },
            { 2215000.0d, 0.0000713743d },
            { 2224000.0d, 0.0000690122d },
            { 2233000.0d, 0.0000666871d },
            { 2242000.0d, 0.0000644d },
            { 2251000.0d, 0.0000621518d },
            { 2260000.0d, 0.0000599439d },
            { 2269000.0d, 0.0000577772d },
            { 2278000.0d, 0.0000556528d },
            { 2287000.0d, 0.0000535721d },
            { 2296000.0d, 0.0000515359d },
            { 2305000.0d, 0.0000495457d },
            { 2314000.0d, 0.0000476023d },
            { 2323000.0d, 0.0000457072d },
            { 2332000.0d, 0.0000438613d },
            { 2341000.0d, 0.0000420658d },
            { 2350000.0d, 0.0000403221d },
            { 2359000.0d, 0.0000386312d },
            { 2368000.0d, 0.0000369942d },
            { 2377000.0d, 0.0000354125d },
            { 2386000.0d, 0.0000338872d },
            { 2395000.0d, 0.0000324194d },
            { 2404000.0d, 0.0000310103d },
            { 2413000.0d, 0.0000296613d },
            { 2422000.0d, 0.0000283734d },
            { 2431000.0d, 0.0000271482d },
            { 2440000.0d, 0.0000259864d },
            { 2449000.0d, 0.0000248896d },
            { 2458000.0d, 0.0000238587d },
            { 2467000.0d, 0.0000228942d },
            { 2476000.0d, 0.000021973d },
            { 2485000.0d, 0.0000210857d },
            { 2494000.0d, 0.0000202329d },
            { 2503000.0d, 0.0000194151d },
            { 2512000.0d, 0.0000186214d },
            { 2521000.0d, 0.0000178406d },
            { 2530000.0d, 0.0000170731d },
            { 2539000.0d, 0.0000163195d },
            { 2548000.0d, 0.00001558d },
            { 2557000.0d, 0.0000148552d },
            { 2566000.0d, 0.0000141454d },
            { 2575000.0d, 0.0000134512d },
            { 2584000.0d, 0.000012773d },
            { 2593000.0d, 0.0000121112d },
            { 2602000.0d, 0.0000114662d },
            { 2611000.0d, 0.0000108386d },
            { 2620000.0d, 0.0000102288d },
            { 2629000.0d, 0.00000963721d },
            { 2638000.0d, 0.00000906442d },
            { 2647000.0d, 0.00000851087d },
            { 2656000.0d, 0.00000797704d },
            { 2665000.0d, 0.00000746045d },
            { 2674000.0d, 0.00000695709d },
            { 2683000.0d, 0.00000646737d },
            { 2692000.0d, 0.0000059917d },
            { 2701000.0d, 0.00000553049d },
            { 2710000.0d, 0.00000508421d },
            { 2719000.0d, 0.00000465329d },
            { 2728000.0d, 0.00000423817d },
            { 2737000.0d, 0.00000383933d },
            { 2746000.0d, 0.00000345722d },
            { 2755000.0d, 0.00000309232d },
            { 2764000.0d, 0.00000274509d },
            { 2773000.0d, 0.00000241604d },
            { 2782000.0d, 0.00000210564d },
            { 2791000.0d, 0.0000018144d },
            { 2800000.0d, 0.00000154281d },
            { 2809000.0d, 0.0000012914d },
            { 2818000.0d, 0.00000106067d },
            { 2827000.0d, 0.000000851148d },
            { 2836000.0d, 0.000000663361d },
            { 2845000.0d, 0.00000049784d },
            { 2854000.0d, 0.00000035512d },
            { 2863000.0d, 0.00000023574d },
            { 2872000.0d, 0.000000140237d },
            { 2881000.0d, 0.0000000691439d },
            { 2890000.0d, 0.0000000229795d },
            { 2899000.0d, 0.00000000221077d },
            { 2904000.0d, 0d },

        }; 
    }
}
    