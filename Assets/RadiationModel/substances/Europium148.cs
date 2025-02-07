using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium148";
        public override double halfLife { get; } = 4708800.0d;
        public override double atomicWeight { get; } = 147.91809d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium148()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00025884d, new GammaParticle(66720.0, 0.01858)), new(0.00019412999999999999d, new GammaParticle(92600.0, 0.01339)), new(0.0010137899999999999d, new GammaParticle(98530.0, 0.01258)), new(0.00150271d, new GammaParticle(116010.0, 0.01069)), new(0.00011504000000000001d, new GammaParticle(151600.0, 0.00818)), new(0.00010066d, new GammaParticle(157800.0, 0.00786)), new(0.00010066d, new GammaParticle(157800.0, 0.00786)), new(0.0002876d, new GammaParticle(161000.0, 0.0077)), new(0.0006758599999999999d, new GammaParticle(166150.0, 0.00746)), new(0.0015099000000000002d, new GammaParticle(182830.0, 0.00678)), new(0.00178312d, new GammaParticle(189721.0, 0.00654)), new(0.00030198d, new GammaParticle(216160.0, 0.00574)), new(0.00019412999999999999d, new GammaParticle(216160.0, 0.00574)), new(7.908999999999999e-05d, new GammaParticle(218300.0, 0.00568)), new(0.00023008000000000002d, new GammaParticle(222710.0, 0.00557)), new(0.014379999999999999d, new GammaParticle(241653.0, 0.00513)), new(0.0032355d, new GammaParticle(243830.0, 0.00508)), new(0.00133734d, new GammaParticle(252600.0, 0.00491)), new(0.00022289d, new GammaParticle(255350.0, 0.00486)), new(0.00084123d, new GammaParticle(279300.0, 0.00444)), new(0.00346558d, new GammaParticle(288141.0, 0.0043)), new(0.00010784999999999999d, new GammaParticle(291300.0, 0.00426)), new(0.00054644d, new GammaParticle(296210.0, 0.00419)), new(0.00054644d, new GammaParticle(300650.0, 0.00412)), new(0.00074776d, new GammaParticle(308450.0, 0.00402)), new(0.0015099000000000002d, new GammaParticle(310140.0, 0.004)), new(0.0010066d, new GammaParticle(310140.0, 0.004)), new(0.0179031d, new GammaParticle(311570.0, 0.00398)), new(0.0015530399999999999d, new GammaParticle(319270.0, 0.00388)), new(0.00019412999999999999d, new GammaParticle(322000.0, 0.00385)), new(0.00010066d, new GammaParticle(332910.0, 0.00372)), new(0.00012223d, new GammaParticle(356470.0, 0.00348)), new(0.00025884d, new GammaParticle(362500.0, 0.00342)), new(0.0015818d, new GammaParticle(377560.0, 0.00328)), new(0.0001438d, new GammaParticle(385900.0, 0.00321)), new(0.102817d, new GammaParticle(414028.0, 0.00299)), new(0.10066000000000001d, new GammaParticle(414057.0, 0.00299)), new(0.00038107d, new GammaParticle(423500.0, 0.00293)), new(0.00038107d, new GammaParticle(423500.0, 0.00293)), new(0.0010066d, new GammaParticle(432745.0, 0.00287)), new(0.028400500000000002d, new GammaParticle(432745.0, 0.00287)), new(0.0019125400000000001d, new GammaParticle(437180.0, 0.00284)), new(0.00011504000000000001d, new GammaParticle(441230.0, 0.00281)), new(0.00040264d, new GammaParticle(446520.0, 0.00278)), new(0.0005033d, new GammaParticle(449000.0, 0.00276)), new(0.00027322d, new GammaParticle(455300.0, 0.00272)), new(0.00018694d, new GammaParticle(460800.0, 0.00269)), new(0.00018694d, new GammaParticle(460800.0, 0.00269)), new(0.0042061500000000005d, new GammaParticle(468500.0, 0.00265)), new(5.033e-05d, new GammaParticle(474200.0, 0.00261)), new(0.00021569999999999998d, new GammaParticle(478400.0, 0.00259)), new(0.0009418899999999999d, new GammaParticle(480890.0, 0.00258)), new(0.00015817999999999998d, new GammaParticle(485900.0, 0.00255)), new(0.00015817999999999998d, new GammaParticle(485900.0, 0.00255)), new(0.00015817999999999998d, new GammaParticle(485900.0, 0.00255)), new(0.00019412999999999999d, new GammaParticle(489200.0, 0.00253)), new(0.0005752d, new GammaParticle(493510.0, 0.00251)), new(0.00255964d, new GammaParticle(495250.0, 0.0025)), new(0.00047454d, new GammaParticle(495250.0, 0.0025)), new(0.0097065d, new GammaParticle(501312.0, 0.00247)), new(0.0013804800000000001d, new GammaParticle(504570.0, 0.00246)), new(0.00423491d, new GammaParticle(516793.0, 0.0024)), new(0.00019412999999999999d, new GammaParticle(532000.0, 0.00233)), new(0.0010066d, new GammaParticle(534380.0, 0.00232)), new(0.00010066d, new GammaParticle(539100.0, 0.0023)), new(0.98503d, new GammaParticle(550284.0, 0.00225)), new(0.12942d, new GammaParticle(553231.0, 0.00224)), new(0.05033000000000001d, new GammaParticle(553260.0, 0.00224)), new(0.09562699999999999d, new GammaParticle(571962.0, 0.00217)), new(0.00019412999999999999d, new GammaParticle(574000.0, 0.00216)), new(0.00046016000000000004d, new GammaParticle(575970.0, 0.00215)), new(0.00019412999999999999d, new GammaParticle(583400.0, 0.00213)), new(0.00117197d, new GammaParticle(587520.0, 0.00211)), new(0.00117197d, new GammaParticle(587520.0, 0.00211)), new(0.00117197d, new GammaParticle(587520.0, 0.00211)), new(0.00193411d, new GammaParticle(594890.0, 0.00208)), new(0.0034368199999999997d, new GammaParticle(599810.0, 0.00207)), new(0.00295509d, new GammaParticle(602620.0, 0.00206)), new(0.00031635999999999996d, new GammaParticle(602620.0, 0.00206)), new(0.20491499999999999d, new GammaParticle(611293.0, 0.00203)), new(0.0089875d, new GammaParticle(620040.0, 0.002)), new(0.0020132d, new GammaParticle(620040.0, 0.002)), new(0.7190000000000001d, new GammaParticle(629987.0, 0.00197)), new(0.0002876d, new GammaParticle(636860.0, 0.00195)), new(0.000156742d, new GammaParticle(643900.0, 0.00193)), new(0.00010066d, new GammaParticle(646900.0, 0.00192)), new(0.00019412999999999999d, new GammaParticle(651500.0, 0.0019)), new(0.0161775d, new GammaParticle(654220.0, 0.0019)), new(0.00140924d, new GammaParticle(656930.0, 0.00189)), new(0.00099941d, new GammaParticle(662790.0, 0.00187)), new(0.0010785d, new GammaParticle(667170.0, 0.00186)), new(0.0006471000000000001d, new GammaParticle(667170.0, 0.00186)), new(0.0127982d, new GammaParticle(683153.0, 0.00181)), new(0.00121511d, new GammaParticle(690740.0, 0.00179)), new(0.00019412999999999999d, new GammaParticle(701900.0, 0.00177)), new(0.00019412999999999999d, new GammaParticle(704400.0, 0.00176)), new(0.00017256000000000001d, new GammaParticle(705910.0, 0.00176)), new(0.0171841d, new GammaParticle(714769.0, 0.00173)), new(0.0027322d, new GammaParticle(719640.0, 0.00172)), new(0.12654400000000002d, new GammaParticle(725673.0, 0.00171)), new(0.00056082d, new GammaParticle(732990.0, 0.00169)), new(0.0012223d, new GammaParticle(735000.0, 0.00169)), new(0.00031635999999999996d, new GammaParticle(735000.0, 0.00169)), new(0.00020851000000000002d, new GammaParticle(736900.0, 0.00168)), new(0.00024446d, new GammaParticle(742160.0, 0.00167)), new(0.00053206d, new GammaParticle(745870.0, 0.00166)), new(0.00304137d, new GammaParticle(756581.0, 0.00164)), new(0.00422772d, new GammaParticle(770307.0, 0.00161)), new(0.00010066d, new GammaParticle(774200.0, 0.0016)), new(0.0011504d, new GammaParticle(780110.0, 0.00159)), new(0.00026603d, new GammaParticle(787980.0, 0.00157)), new(0.00040982999999999997d, new GammaParticle(790200.0, 0.00157)), new(0.00117916d, new GammaParticle(792590.0, 0.00156)), new(0.00418458d, new GammaParticle(799230.0, 0.00155)), new(0.00068305d, new GammaParticle(810120.0, 0.00153)), new(0.00010066d, new GammaParticle(817500.0, 0.00152)), new(0.00010066d, new GammaParticle(817500.0, 0.00152)), new(0.00025884d, new GammaParticle(826300.0, 0.0015)), new(0.00034512000000000003d, new GammaParticle(828610.0, 0.0015)), new(0.00024446d, new GammaParticle(832820.0, 0.00149)), new(0.00010066d, new GammaParticle(832900.0, 0.00149)), new(0.00015099d, new GammaParticle(851400.0, 0.00146)), new(0.00031635999999999996d, new GammaParticle(856900.0, 0.00145)), new(0.00035231d, new GammaParticle(859900.0, 0.00144)), new(0.0548597d, new GammaParticle(869891.0, 0.00143)), new(0.006471d, new GammaParticle(895847.0, 0.00138)), new(0.0037028499999999997d, new GammaParticle(903831.0, 0.00137)), new(0.00207791d, new GammaParticle(906870.0, 0.00137)), new(0.0259559d, new GammaParticle(915331.0, 0.00135)), new(0.00314922d, new GammaParticle(924750.0, 0.00134)), new(0.012223d, new GammaParticle(929850.0, 0.00133)), new(0.013661000000000001d, new GammaParticle(930807.0, 0.00133)), new(0.00053206d, new GammaParticle(935200.0, 0.00133)), new(0.00116478d, new GammaParticle(938100.0, 0.00132)), new(0.00240146d, new GammaParticle(949590.0, 0.00131)), new(0.00010066d, new GammaParticle(961400.0, 0.00129)), new(0.0270344d, new GammaParticle(967306.0, 0.00128)), new(0.00081247d, new GammaParticle(976500.0, 0.00127)), new(0.00214262d, new GammaParticle(979843.0, 0.00127)), new(0.00463755d, new GammaParticle(989606.0, 0.00125)), new(0.0053206d, new GammaParticle(1013808.0, 0.00122)), new(0.077652d, new GammaParticle(1033986.0, 0.0012)), new(0.0010785d, new GammaParticle(1036000.0, 0.0012)), new(0.0005033d, new GammaParticle(1047570.0, 0.00118)), new(0.0019413d, new GammaParticle(1047570.0, 0.00118)), new(0.00010066d, new GammaParticle(1058700.0, 0.00117)), new(0.00389698d, new GammaParticle(1066750.0, 0.00116)), new(0.0009059399999999999d, new GammaParticle(1068250.0, 0.00116)), new(0.00219295d, new GammaParticle(1069820.0, 0.00116)), new(0.0018909699999999998d, new GammaParticle(1082096.0, 0.00115)), new(0.00204915d, new GammaParticle(1089154.0, 0.00114)), new(0.00124387d, new GammaParticle(1097180.0, 0.00113)), new(0.0036740899999999996d, new GammaParticle(1104321.0, 0.00112)), new(0.0013013900000000001d, new GammaParticle(1107670.0, 0.00112)), new(0.0013661d, new GammaParticle(1113920.0, 0.00111)), new(0.00020851000000000002d, new GammaParticle(1121700.0, 0.00111)), new(0.00084123d, new GammaParticle(1127690.0, 0.0011)), new(0.00046735d, new GammaParticle(1133120.0, 0.00109)), new(0.00019412999999999999d, new GammaParticle(1138400.0, 0.00109)), new(0.0196287d, new GammaParticle(1146805.0, 0.00108)), new(0.00019412999999999999d, new GammaParticle(1151300.0, 0.00108)), new(0.00080528d, new GammaParticle(1165540.0, 0.00106)), new(0.0166089d, new GammaParticle(1183208.0, 0.00105)), new(0.00127982d, new GammaParticle(1194185.0, 0.00104)), new(0.00010066d, new GammaParticle(1201300.0, 0.00103)), new(0.00629844d, new GammaParticle(1207473.0, 0.00103)), new(0.0005033d, new GammaParticle(1219010.0, 0.00102)), new(0.00137329d, new GammaParticle(1221370.0, 0.00102)), new(0.00010066d, new GammaParticle(1229600.0, 0.00101)), new(0.0040839199999999996d, new GammaParticle(1236374.0, 0.001)), new(0.00145238d, new GammaParticle(1266760.0, 0.00098)), new(0.00013661d, new GammaParticle(1269300.0, 0.00098)), new(0.00013661d, new GammaParticle(1269300.0, 0.00098)), new(0.00475259d, new GammaParticle(1309778.0, 0.00095)), new(0.013157700000000001d, new GammaParticle(1328504.0, 0.00093)), new(0.016896500000000002d, new GammaParticle(1343870.0, 0.00092)), new(0.0189097d, new GammaParticle(1344740.0, 0.00092)), new(0.0062553d, new GammaParticle(1353550.0, 0.00092)), new(0.00596051d, new GammaParticle(1362640.0, 0.00091)), new(0.00019412999999999999d, new GammaParticle(1370970.0, 0.0009)), new(0.00010066d, new GammaParticle(1377400.0, 0.0009)), new(9.7784e-05d, new GammaParticle(1390440.0, 0.00089)), new(0.00140924d, new GammaParticle(1409160.0, 0.00088)), new(5.033e-05d, new GammaParticle(1419600.0, 0.00087)), new(0.00013373400000000002d, new GammaParticle(1422210.0, 0.00087)), new(0.0036884699999999997d, new GammaParticle(1454110.0, 0.00085)), new(0.0116478d, new GammaParticle(1460630.0, 0.00085)), new(0.00015817999999999998d, new GammaParticle(1465200.0, 0.00085)), new(0.00098503d, new GammaParticle(1492810.0, 0.00083)), new(0.00186221d, new GammaParticle(1503200.0, 0.00082)), new(0.00041702000000000004d, new GammaParticle(1511490.0, 0.00082)), new(8.628000000000001e-05d, new GammaParticle(1513900.0, 0.00082)), new(0.00153147d, new GammaParticle(1521850.0, 0.00081)), new(0.00032355000000000003d, new GammaParticle(1533100.0, 0.00081)), new(0.0009131300000000001d, new GammaParticle(1535840.0, 0.00081)), new(0.00079809d, new GammaParticle(1540270.0, 0.0008)), new(0.0074056999999999994d, new GammaParticle(1543289.0, 0.0008)), new(0.00088437d, new GammaParticle(1547140.0, 0.0008)), new(0.008412300000000001d, new GammaParticle(1560786.0, 0.00079)), new(0.00031635999999999996d, new GammaParticle(1565290.0, 0.00079)), new(0.000114321d, new GammaParticle(1572900.0, 0.00079)), new(0.0464474d, new GammaParticle(1621510.0, 0.00076)), new(0.0015889900000000002d, new GammaParticle(1635310.0, 0.00076)), new(0.0371004d, new GammaParticle(1650436.0, 0.00075)), new(0.00117197d, new GammaParticle(1654020.0, 0.00075)), new(0.00070462d, new GammaParticle(1664200.0, 0.00075)), new(0.00424929d, new GammaParticle(1677850.0, 0.00074)), new(0.00029479d, new GammaParticle(1680900.0, 0.00074)), new(0.00015314700000000002d, new GammaParticle(1699540.0, 0.00073)), new(0.000343682d, new GammaParticle(1748580.0, 0.00071)), new(0.00065429d, new GammaParticle(1776870.0, 0.0007)), new(5.6081999999999996e-05d, new GammaParticle(1788910.0, 0.00069)), new(0.00016968400000000002d, new GammaParticle(1840060.0, 0.00067)), new(2.1570000000000002e-05d, new GammaParticle(1843500.0, 0.00067)), new(2.0850999999999997e-05d, new GammaParticle(1917500.0, 0.00065)), new(0.0006902400000000001d, new GammaParticle(1939170.0, 0.00064)), new(0.00053206d, new GammaParticle(1973810.0, 0.00063)), new(0.00013661d, new GammaParticle(2122750.0, 0.00058)), new(5.5363e-05d, new GammaParticle(2163900.0, 0.00057)), new(0.00230799d, new GammaParticle(2173280.0, 0.00057)), new(0.00188d, new GammaParticle(511000.0, 0.00243)), new(0.13888477262072332d, new GammaParticle(6354.0, 0.19513)), new(0.2263457501097035d, new GammaParticle(39522.0, 0.03137)), new(0.4096755658094181d, new GammaParticle(40117.0, 0.03091)), new(0.12806375144857987d, new GammaParticle(45523.0, 0.02724)), new(0.16110419932231348d, new GammaParticle(45998.0, 0.02695)), new(0.03304044787373361d, new GammaParticle(46575.0, 0.02662)) } },
            { 9.4e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium144()), new(1.0d, new AlphaParticle(3716102.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 300.0d, 0.00000000000176967d },
            { 600.0d, 0.00000000000538233d },
            { 900.0d, 0.0000000000137241d },
            { 1200.0d, 0.0000000000259133d },
            { 1700.0d, 0.0000000000548771d },
            { 2200.0d, 0.000000000096525d },
            { 2700.0d, 0.00000000015123d },
            { 3200.0d, 0.00000000022119d },
            { 3700.0d, 0.000000000306257d },
            { 4200.0d, 0.000000000413214d },
            { 4700.0d, 0.000000000548248d },
            { 5200.0d, 0.000000000707744d },
            { 5700.0d, 0.000000000892445d },
            { 6200.0d, 0.00000000110814d },
            { 6700.0d, 0.00000000136226d },
            { 7200.0d, 0.00000000164968d },
            { 7700.0d, 0.00000000197239d },
            { 8200.0d, 0.00000000233466d },
            { 8700.0d, 0.00000000274415d },
            { 9200.0d, 0.00000000319573d },
            { 9700.0d, 0.0000000036907d },
            { 10000.0d, 0.00000000400856d },
            { 11000.0d, 0.00000000521246d },
            { 12000.0d, 0.00000000661737d },
            { 13000.0d, 0.00000000825168d },
            { 14000.0d, 0.0000000101111d },
            { 15000.0d, 0.0000000122186d },
            { 16000.0d, 0.0000000145697d },
            { 17000.0d, 0.0000000171822d },
            { 18000.0d, 0.0000000200518d },
            { 19000.0d, 0.0000000231912d },
            { 20000.0d, 0.0000000265964d },
            { 21000.0d, 0.0000000302756d },
            { 22000.0d, 0.000000034225d },
            { 23000.0d, 0.000000038449d },
            { 24000.0d, 0.000000042944d },
            { 25000.0d, 0.0000000477112d },
            { 26000.0d, 0.000000052747d },
            { 27000.0d, 0.00000005805d },
            { 28000.0d, 0.0000000636168d },
            { 29000.0d, 0.0000000694434d },
            { 30000.0d, 0.0000000755271d },
            { 31000.0d, 0.0000000818618d },
            { 32000.0d, 0.0000000884449d },
            { 33000.0d, 0.0000000952691d },
            { 34000.0d, 0.000000102332d },
            { 35000.0d, 0.000000109624d },
            { 36000.0d, 0.000000117144d },
            { 37000.0d, 0.000000124882d },
            { 38000.0d, 0.000000132836d },
            { 39000.0d, 0.000000140996d },
            { 40000.0d, 0.000000149359d },
            { 41000.0d, 0.000000157916d },
            { 42000.0d, 0.000000166664d },
            { 43000.0d, 0.000000175592d },
            { 44000.0d, 0.0000001847d },
            { 45000.0d, 0.000000193974d },
            { 46000.0d, 0.000000203415d },
            { 47000.0d, 0.000000213011d },
            { 48000.0d, 0.000000222762d },
            { 49000.0d, 0.000000232654d },
            { 50000.0d, 0.000000242688d },
            { 51000.0d, 0.000000252852d },
            { 52000.0d, 0.000000263147d },
            { 53000.0d, 0.000000273559d },
            { 54000.0d, 0.00000028409d },
            { 55000.0d, 0.000000294728d },
            { 56000.0d, 0.000000305473d },
            { 57000.0d, 0.000000316312d },
            { 58000.0d, 0.000000327249d },
            { 59000.0d, 0.000000338271d },
            { 60000.0d, 0.000000349378d },
            { 61000.0d, 0.000000360561d },
            { 62000.0d, 0.000000371819d },
            { 63000.0d, 0.000000383142d },
            { 64000.0d, 0.000000394532d },
            { 65000.0d, 0.000000405979d },
            { 66000.0d, 0.000000417481d },
            { 67000.0d, 0.000000429032d },
            { 68000.0d, 0.000000440632d },
            { 69000.0d, 0.00000045227d },
            { 70000.0d, 0.000000463949d },
            { 71000.0d, 0.000000475661d },
            { 72000.0d, 0.000000487404d },
            { 73000.0d, 0.000000499173d },
            { 74000.0d, 0.000000510966d },
            { 75000.0d, 0.000000522777d },
            { 76000.0d, 0.000000534608d },
            { 77000.0d, 0.00000054645d },
            { 78000.0d, 0.000000558304d },
            { 79000.0d, 0.000000570164d },
            { 80000.0d, 0.000000582032d },
            { 81000.0d, 0.000000593899d },
            { 82000.0d, 0.000000605768d },
            { 83000.0d, 0.000000617631d },
            { 84000.0d, 0.000000629492d },
            { 85000.0d, 0.000000641343d },
            { 86000.0d, 0.000000653185d },
            { 87000.0d, 0.000000665015d },
            { 88000.0d, 0.000000676832d },
            { 89000.0d, 0.000000688631d },
            { 90000.0d, 0.000000700415d },
            { 91000.0d, 0.000000712178d },
            { 92000.0d, 0.000000723921d },
            { 93000.0d, 0.000000735641d },
            { 94000.0d, 0.000000747339d },
            { 95000.0d, 0.000000759009d },
            { 96000.0d, 0.000000770655d },
            { 97000.0d, 0.000000782271d },
            { 98000.0d, 0.000000793861d },
            { 99000.0d, 0.000000805419d },
            { 100000.0d, 0.000000816947d },
            { 102000.0d, 0.000000839909d },
            { 104000.0d, 0.000000862737d },
            { 106000.0d, 0.000000885427d },
            { 108000.0d, 0.000000907978d },
            { 110000.0d, 0.000000930375d },
            { 112000.0d, 0.000000952558d },
            { 114000.0d, 0.000000974509d },
            { 116000.0d, 0.000000996222d },
            { 118000.0d, 0.00000101769d },
            { 120000.0d, 0.0000010389d },
            { 122000.0d, 0.00000105984d },
            { 124000.0d, 0.0000010805d },
            { 126000.0d, 0.00000110086d },
            { 128000.0d, 0.00000112092d },
            { 130000.0d, 0.00000114067d },
            { 132000.0d, 0.00000116012d },
            { 134000.0d, 0.00000117925d },
            { 136000.0d, 0.00000119807d },
            { 138000.0d, 0.00000121657d },
            { 140000.0d, 0.00000123474d },
            { 142000.0d, 0.00000125259d },
            { 144000.0d, 0.00000127011d },
            { 146000.0d, 0.00000128731d },
            { 148000.0d, 0.00000130417d },
            { 150000.0d, 0.00000132071d },
            { 152000.0d, 0.00000133693d },
            { 154000.0d, 0.00000135281d },
            { 156000.0d, 0.00000136837d },
            { 158000.0d, 0.00000138361d },
            { 160000.0d, 0.00000139852d },
            { 162000.0d, 0.0000014131d },
            { 164000.0d, 0.00000142737d },
            { 166000.0d, 0.00000144132d },
            { 168000.0d, 0.00000145495d },
            { 170000.0d, 0.00000146827d },
            { 172000.0d, 0.00000148128d },
            { 174000.0d, 0.00000149399d },
            { 176000.0d, 0.00000150639d },
            { 178000.0d, 0.0000015185d },
            { 180000.0d, 0.00000153032d },
            { 182000.0d, 0.00000154184d },
            { 184000.0d, 0.00000155308d },
            { 186000.0d, 0.00000156404d },
            { 188000.0d, 0.00000157473d },
            { 190000.0d, 0.00000158515d },
            { 192000.0d, 0.0000015953d },
            { 194000.0d, 0.00000160519d },
            { 196000.0d, 0.00000161485d },
            { 198000.0d, 0.00000162424d },
            { 200000.0d, 0.00000163341d },
            { 202000.0d, 0.00000164233d },
            { 204000.0d, 0.00000165103d },
            { 206000.0d, 0.00000165952d },
            { 208000.0d, 0.00000166779d },
            { 210000.0d, 0.00000167585d },
            { 212000.0d, 0.00000168373d },
            { 214000.0d, 0.0000016914d },
            { 216000.0d, 0.00000169888d },
            { 218000.0d, 0.0000017062d },
            { 220000.0d, 0.00000171335d },
            { 222000.0d, 0.00000172034d },
            { 224000.0d, 0.00000172718d },
            { 226000.0d, 0.00000173387d },
            { 228000.0d, 0.00000174043d },
            { 230000.0d, 0.00000174685d },
            { 232000.0d, 0.00000175316d },
            { 234000.0d, 0.00000175936d },
            { 236000.0d, 0.00000176546d },
            { 238000.0d, 0.00000177146d },
            { 240000.0d, 0.00000177738d },
            { 242000.0d, 0.00000178323d },
            { 244000.0d, 0.00000178901d },
            { 246000.0d, 0.00000179473d },
            { 248000.0d, 0.00000180041d },
            { 250000.0d, 0.00000180605d },
            { 252000.0d, 0.00000181166d },
            { 254000.0d, 0.00000181726d },
            { 256000.0d, 0.00000182284d },
            { 258000.0d, 0.00000182842d },
            { 260000.0d, 0.00000183401d },
            { 262000.0d, 0.00000183963d },
            { 264000.0d, 0.00000184527d },
            { 266000.0d, 0.00000185095d },
            { 268000.0d, 0.00000185669d },
            { 270000.0d, 0.00000186249d },
            { 272000.0d, 0.00000186835d },
            { 274000.0d, 0.0000018743d },
            { 276000.0d, 0.00000188034d },
            { 278000.0d, 0.00000188648d },
            { 280000.0d, 0.00000189274d },
            { 282000.0d, 0.00000189912d },
            { 284000.0d, 0.00000190546d },
            { 286000.0d, 0.00000191161d },
            { 288000.0d, 0.00000191756d },
            { 290000.0d, 0.00000192332d },
            { 292000.0d, 0.00000192889d },
            { 294000.0d, 0.00000193426d },
            { 296000.0d, 0.00000193944d },
            { 298000.0d, 0.00000194442d },
            { 300000.0d, 0.00000194922d },
            { 302000.0d, 0.00000195382d },
            { 304000.0d, 0.00000195822d },
            { 306000.0d, 0.00000196244d },
            { 308000.0d, 0.00000196647d },
            { 310000.0d, 0.0000019703d },
            { 312000.0d, 0.00000197395d },
            { 314000.0d, 0.00000197741d },
            { 316000.0d, 0.00000198068d },
            { 318000.0d, 0.00000198376d },
            { 320000.0d, 0.00000198666d },
            { 322000.0d, 0.00000198936d },
            { 324000.0d, 0.00000199189d },
            { 326000.0d, 0.00000199422d },
            { 328000.0d, 0.00000199637d },
            { 330000.0d, 0.00000199834d },
            { 332000.0d, 0.00000200013d },
            { 334000.0d, 0.00000200173d },
            { 336000.0d, 0.00000200315d },
            { 338000.0d, 0.00000200439d },
            { 340000.0d, 0.00000200545d },
            { 342000.0d, 0.00000200633d },
            { 344000.0d, 0.00000200703d },
            { 346000.0d, 0.00000200756d },
            { 348000.0d, 0.0000020079d },
            { 350000.0d, 0.00000200807d },
            { 352000.0d, 0.00000200807d },
            { 354000.0d, 0.00000200789d },
            { 356000.0d, 0.00000200753d },
            { 358000.0d, 0.00000200701d },
            { 360000.0d, 0.00000200631d },
            { 362000.0d, 0.00000200544d },
            { 364000.0d, 0.0000020044d },
            { 366000.0d, 0.00000200319d },
            { 368000.0d, 0.00000200181d },
            { 370000.0d, 0.00000200027d },
            { 372000.0d, 0.00000199856d },
            { 374000.0d, 0.00000199668d },
            { 376000.0d, 0.00000199464d },
            { 378000.0d, 0.00000199243d },
            { 380000.0d, 0.00000199006d },
            { 382000.0d, 0.00000198753d },
            { 384000.0d, 0.00000198484d },
            { 386000.0d, 0.00000198199d },
            { 388000.0d, 0.00000197899d },
            { 390000.0d, 0.00000197582d },
            { 392000.0d, 0.0000019725d },
            { 394000.0d, 0.00000196902d },
            { 396000.0d, 0.00000196538d },
            { 398000.0d, 0.0000019616d },
            { 400000.0d, 0.00000195766d },
            { 402000.0d, 0.00000195357d },
            { 404000.0d, 0.00000194933d },
            { 406000.0d, 0.00000194494d },
            { 408000.0d, 0.0000019404d },
            { 410000.0d, 0.00000193571d },
            { 412000.0d, 0.00000193088d },
            { 414000.0d, 0.00000192591d },
            { 416000.0d, 0.00000192079d },
            { 418000.0d, 0.00000191553d },
            { 420000.0d, 0.00000191012d },
            { 422000.0d, 0.00000190458d },
            { 424000.0d, 0.0000018989d },
            { 426000.0d, 0.00000189308d },
            { 428000.0d, 0.00000188712d },
            { 430000.0d, 0.00000188103d },
            { 432000.0d, 0.00000187481d },
            { 434000.0d, 0.00000186845d },
            { 436000.0d, 0.00000186196d },
            { 438000.0d, 0.00000185534d },
            { 440000.0d, 0.00000184859d },
            { 442000.0d, 0.00000184171d },
            { 444000.0d, 0.00000183471d },
            { 446000.0d, 0.00000182758d },
            { 448000.0d, 0.00000182032d },
            { 450000.0d, 0.00000181295d },
            { 452000.0d, 0.00000180545d },
            { 454000.0d, 0.00000179783d },
            { 456000.0d, 0.00000179009d },
            { 458000.0d, 0.00000178223d },
            { 460000.0d, 0.00000177426d },
            { 462000.0d, 0.00000176617d },
            { 464000.0d, 0.00000175797d },
            { 466000.0d, 0.00000174965d },
            { 468000.0d, 0.00000174122d },
            { 470000.0d, 0.00000173269d },
            { 472000.0d, 0.00000172404d },
            { 474000.0d, 0.00000171529d },
            { 476000.0d, 0.00000170643d },
            { 478000.0d, 0.00000169747d },
            { 480000.0d, 0.0000016884d },
            { 482000.0d, 0.00000167924d },
            { 484000.0d, 0.00000166997d },
            { 486000.0d, 0.0000016606d },
            { 488000.0d, 0.00000165114d },
            { 490000.0d, 0.00000164158d },
            { 492000.0d, 0.00000163192d },
            { 494000.0d, 0.00000162217d },
            { 496000.0d, 0.00000161233d },
            { 498000.0d, 0.0000016024d },
            { 500000.0d, 0.00000159238d },
            { 502000.0d, 0.00000158227d },
            { 504000.0d, 0.00000157207d },
            { 506000.0d, 0.00000156179d },
            { 508000.0d, 0.00000155143d },
            { 510000.0d, 0.00000154099d },
            { 512000.0d, 0.00000153046d },
            { 514000.0d, 0.00000151986d },
            { 516000.0d, 0.00000150918d },
            { 518000.0d, 0.00000149842d },
            { 520000.0d, 0.00000148759d },
            { 522000.0d, 0.00000147669d },
            { 524000.0d, 0.00000146571d },
            { 526000.0d, 0.00000145466d },
            { 528000.0d, 0.00000144355d },
            { 530000.0d, 0.00000143237d },
            { 532000.0d, 0.00000142112d },
            { 534000.0d, 0.00000140981d },
            { 536000.0d, 0.00000139844d },
            { 538000.0d, 0.00000138701d },
            { 540000.0d, 0.00000137552d },
            { 542000.0d, 0.00000136397d },
            { 544000.0d, 0.00000135236d },
            { 546000.0d, 0.0000013407d },
            { 548000.0d, 0.00000132899d },
            { 550000.0d, 0.00000131723d },
            { 552000.0d, 0.00000130541d },
            { 554000.0d, 0.00000129355d },
            { 556000.0d, 0.00000128165d },
            { 558000.0d, 0.00000126969d },
            { 560000.0d, 0.0000012577d },
            { 562000.0d, 0.00000124566d },
            { 564000.0d, 0.00000123359d },
            { 566000.0d, 0.00000122147d },
            { 568000.0d, 0.00000120932d },
            { 570000.0d, 0.00000119713d },
            { 572000.0d, 0.00000118491d },
            { 574000.0d, 0.00000117266d },
            { 576000.0d, 0.00000116038d },
            { 578000.0d, 0.00000114807d },
            { 580000.0d, 0.00000113573d },
            { 582000.0d, 0.00000112337d },
            { 584000.0d, 0.00000111099d },
            { 586000.0d, 0.00000109858d },
            { 588000.0d, 0.00000108615d },
            { 590000.0d, 0.00000107371d },
            { 592000.0d, 0.00000106125d },
            { 594000.0d, 0.00000104877d },
            { 596000.0d, 0.00000103628d },
            { 598000.0d, 0.00000102378d },
            { 600000.0d, 0.00000101127d },
            { 602000.0d, 0.000000998755d },
            { 604000.0d, 0.000000986232d },
            { 606000.0d, 0.000000973704d },
            { 608000.0d, 0.000000961173d },
            { 610000.0d, 0.000000948642d },
            { 612000.0d, 0.000000936112d },
            { 614000.0d, 0.000000923584d },
            { 616000.0d, 0.000000911061d },
            { 618000.0d, 0.000000898544d },
            { 620000.0d, 0.000000886035d },
            { 622000.0d, 0.000000873536d },
            { 624000.0d, 0.000000861048d },
            { 626000.0d, 0.000000848574d },
            { 628000.0d, 0.000000836116d },
            { 630000.0d, 0.000000823674d },
            { 632000.0d, 0.000000811251d },
            { 634000.0d, 0.000000798849d },
            { 636000.0d, 0.00000078647d },
            { 638000.0d, 0.000000774115d },
            { 640000.0d, 0.000000761786d },
            { 642000.0d, 0.000000749486d },
            { 644000.0d, 0.000000737215d },
            { 646000.0d, 0.000000724976d },
            { 648000.0d, 0.000000712771d },
            { 650000.0d, 0.000000700601d },
            { 652000.0d, 0.000000688469d },
            { 654000.0d, 0.000000676376d },
            { 656000.0d, 0.000000664324d },
            { 658000.0d, 0.000000652315d },
            { 660000.0d, 0.000000640351d },
            { 662000.0d, 0.000000628435d },
            { 664000.0d, 0.000000616566d },
            { 666000.0d, 0.000000604749d },
            { 668000.0d, 0.000000592984d },
            { 670000.0d, 0.000000581274d },
            { 672000.0d, 0.00000056962d },
            { 674000.0d, 0.000000558025d },
            { 676000.0d, 0.00000054649d },
            { 678000.0d, 0.000000535017d },
            { 680000.0d, 0.000000523608d },
            { 682000.0d, 0.000000512266d },
            { 684000.0d, 0.000000500992d },
            { 686000.0d, 0.000000489787d },
            { 688000.0d, 0.000000478655d },
            { 690000.0d, 0.000000467597d },
            { 692000.0d, 0.000000456615d },
            { 694000.0d, 0.000000445711d },
            { 696000.0d, 0.000000434888d },
            { 698000.0d, 0.000000424146d },
            { 700000.0d, 0.000000413488d },
            { 702000.0d, 0.000000402916d },
            { 704000.0d, 0.000000392432d },
            { 706000.0d, 0.000000382038d },
            { 708000.0d, 0.000000371736d },
            { 710000.0d, 0.000000361528d },
            { 712000.0d, 0.000000351417d },
            { 714000.0d, 0.000000341403d },
            { 716000.0d, 0.00000033149d },
            { 718000.0d, 0.000000321679d },
            { 720000.0d, 0.000000311972d },
            { 722000.0d, 0.000000302372d },
            { 724000.0d, 0.00000029288d },
            { 726000.0d, 0.000000283499d },
            { 728000.0d, 0.00000027423d },
            { 730000.0d, 0.000000265075d },
            { 732000.0d, 0.000000256038d },
            { 734000.0d, 0.000000247119d },
            { 736000.0d, 0.000000238321d },
            { 738000.0d, 0.000000229646d },
            { 740000.0d, 0.000000221096d },
            { 742000.0d, 0.000000212674d },
            { 744000.0d, 0.00000020438d },
            { 746000.0d, 0.000000196218d },
            { 748000.0d, 0.00000018819d },
            { 750000.0d, 0.000000180297d },
            { 752000.0d, 0.000000172542d },
            { 754000.0d, 0.000000164927d },
            { 756000.0d, 0.000000157454d },
            { 758000.0d, 0.000000150125d },
            { 760000.0d, 0.000000142943d },
            { 762000.0d, 0.000000135909d },
            { 764000.0d, 0.000000129025d },
            { 766000.0d, 0.000000122295d },
            { 768000.0d, 0.000000115719d },
            { 770000.0d, 0.000000109301d },
            { 772000.0d, 0.000000103041d },
            { 774000.0d, 0.0000000969437d },
            { 776000.0d, 0.0000000910096d },
            { 778000.0d, 0.0000000852415d },
            { 780000.0d, 0.0000000796413d },
            { 782000.0d, 0.0000000742114d },
            { 784000.0d, 0.0000000689539d },
            { 786000.0d, 0.0000000638711d },
            { 788000.0d, 0.000000058965d },
            { 790000.0d, 0.0000000542381d },
            { 792000.0d, 0.0000000496923d },
            { 794000.0d, 0.00000004533d },
            { 796000.0d, 0.0000000411534d },
            { 798000.0d, 0.0000000371647d },
            { 800000.0d, 0.0000000333661d },
            { 802000.0d, 0.0000000297598d },
            { 804000.0d, 0.0000000263481d },
            { 806000.0d, 0.0000000231331d },
            { 808000.0d, 0.0000000201172d },
            { 810000.0d, 0.0000000173026d },
            { 812000.0d, 0.0000000146914d },
            { 814000.0d, 0.0000000122858d },
            { 816000.0d, 0.0000000100882d },
            { 818000.0d, 0.00000000810078d },
            { 820000.0d, 0.00000000632568d },
            { 822000.0d, 0.00000000476513d },
            { 824000.0d, 0.00000000342133d },
            { 826000.0d, 0.00000000229647d },
            { 828000.0d, 0.00000000139269d },
            { 830000.0d, 0.0000000007121d },
            { 832000.0d, 0.000000000256749d },
            { 834000.0d, 0.0000000000285102d },
            { 835000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    