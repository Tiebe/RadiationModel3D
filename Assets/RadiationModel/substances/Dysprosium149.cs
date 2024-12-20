using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium149";
        public override double halfLife { get; } = 252.0d;
        public override double atomicWeight { get; } = 148.92733d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium149()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0007000000000000001d, new GammaParticle(31700.0, 0.03911)), new(0.153d, new GammaParticle(100700.0, 0.01231)), new(0.083d, new GammaParticle(106200.0, 0.01167)), new(0.00052d, new GammaParticle(131200.0, 0.00945)), new(0.00148d, new GammaParticle(135700.0, 0.00914)), new(0.00127d, new GammaParticle(137900.0, 0.00899)), new(0.00178d, new GammaParticle(148400.0, 0.00835)), new(0.00183d, new GammaParticle(188500.0, 0.00658)), new(0.00035000000000000005d, new GammaParticle(197200.0, 0.00629)), new(0.00046d, new GammaParticle(219900.0, 0.00564)), new(0.002d, new GammaParticle(223300.0, 0.00555)), new(0.0012d, new GammaParticle(223600.0, 0.00554)), new(0.0012d, new GammaParticle(245100.0, 0.00506)), new(0.0678d, new GammaParticle(253600.0, 0.00489)), new(0.0008699999999999999d, new GammaParticle(267700.0, 0.00463)), new(0.00079d, new GammaParticle(293400.0, 0.00423)), new(0.0022d, new GammaParticle(297700.0, 0.00416)), new(0.0011d, new GammaParticle(337100.0, 0.00368)), new(0.0015d, new GammaParticle(346300.0, 0.00358)), new(0.00252d, new GammaParticle(348900.0, 0.00355)), new(0.001d, new GammaParticle(353900.0, 0.0035)), new(0.0015d, new GammaParticle(358600.0, 0.00346)), new(0.0009d, new GammaParticle(359300.0, 0.00345)), new(0.006500000000000001d, new GammaParticle(359600.0, 0.00345)), new(0.0007000000000000001d, new GammaParticle(361200.0, 0.00343)), new(0.0064d, new GammaParticle(367800.0, 0.00337)), new(0.00047d, new GammaParticle(372600.0, 0.00333)), new(0.0008100000000000001d, new GammaParticle(376600.0, 0.00329)), new(0.00313d, new GammaParticle(380800.0, 0.00326)), new(0.00117d, new GammaParticle(399400.0, 0.0031)), new(0.0013900000000000002d, new GammaParticle(409400.0, 0.00303)), new(0.00365d, new GammaParticle(415500.0, 0.00298)), new(0.0009299999999999999d, new GammaParticle(421000.0, 0.00294)), new(0.00046d, new GammaParticle(422000.0, 0.00294)), new(0.00159d, new GammaParticle(457000.0, 0.00271)), new(0.0024d, new GammaParticle(477800.0, 0.00259)), new(0.00035000000000000005d, new GammaParticle(479500.0, 0.00259)), new(0.0006d, new GammaParticle(491600.0, 0.00252)), new(0.010700000000000001d, new GammaParticle(494600.0, 0.00251)), new(0.0005d, new GammaParticle(495000.0, 0.0025)), new(0.00058d, new GammaParticle(499900.0, 0.00248)), new(0.00208d, new GammaParticle(501100.0, 0.00247)), new(0.0005600000000000001d, new GammaParticle(501800.0, 0.00247)), new(0.0013900000000000002d, new GammaParticle(505500.0, 0.00245)), new(0.0017000000000000001d, new GammaParticle(508500.0, 0.00244)), new(0.006999999999999999d, new GammaParticle(509900.0, 0.00243)), new(0.001d, new GammaParticle(511100.0, 0.00243)), new(0.0009d, new GammaParticle(517100.0, 0.0024)), new(0.0009d, new GammaParticle(517400.0, 0.0024)), new(0.0024d, new GammaParticle(521600.0, 0.00238)), new(0.0006900000000000001d, new GammaParticle(526600.0, 0.00235)), new(0.01d, new GammaParticle(534700.0, 0.00232)), new(0.0008500000000000001d, new GammaParticle(537800.0, 0.00231)), new(0.00068d, new GammaParticle(544600.0, 0.00228)), new(0.00468d, new GammaParticle(548100.0, 0.00226)), new(0.0007000000000000001d, new GammaParticle(553600.0, 0.00224)), new(0.0007000000000000001d, new GammaParticle(553900.0, 0.00224)), new(0.0028000000000000004d, new GammaParticle(556700.0, 0.00223)), new(0.0021d, new GammaParticle(556800.0, 0.00223)), new(0.0028899999999999998d, new GammaParticle(561400.0, 0.00221)), new(0.00091d, new GammaParticle(565300.0, 0.00219)), new(0.0028399999999999996d, new GammaParticle(568900.0, 0.00218)), new(0.00255d, new GammaParticle(576400.0, 0.00215)), new(0.0016200000000000001d, new GammaParticle(577800.0, 0.00215)), new(0.0006d, new GammaParticle(588600.0, 0.00211)), new(0.0011d, new GammaParticle(600200.0, 0.00207)), new(0.0017000000000000001d, new GammaParticle(601200.0, 0.00206)), new(0.0015d, new GammaParticle(601200.0, 0.00206)), new(0.0009d, new GammaParticle(633200.0, 0.00196)), new(0.0031d, new GammaParticle(635600.0, 0.00195)), new(0.0037d, new GammaParticle(636300.0, 0.00195)), new(0.0294d, new GammaParticle(637300.0, 0.00195)), new(0.0073d, new GammaParticle(640800.0, 0.00193)), new(0.00035000000000000005d, new GammaParticle(648000.0, 0.00191)), new(0.0016d, new GammaParticle(648700.0, 0.00191)), new(0.091d, new GammaParticle(653600.0, 0.0019)), new(0.008100000000000001d, new GammaParticle(654100.0, 0.0019)), new(0.00089d, new GammaParticle(657800.0, 0.00188)), new(0.0053100000000000005d, new GammaParticle(662800.0, 0.00187)), new(0.0016d, new GammaParticle(683300.0, 0.00181)), new(0.0013d, new GammaParticle(683700.0, 0.00181)), new(0.00822d, new GammaParticle(692700.0, 0.00179)), new(0.00035000000000000005d, new GammaParticle(693000.0, 0.00179)), new(0.0005d, new GammaParticle(697000.0, 0.00178)), new(0.00127d, new GammaParticle(699300.0, 0.00177)), new(0.0007099999999999999d, new GammaParticle(706400.0, 0.00176)), new(0.00086d, new GammaParticle(708000.0, 0.00175)), new(0.0025700000000000002d, new GammaParticle(721500.0, 0.00172)), new(0.00331d, new GammaParticle(728600.0, 0.0017)), new(0.00197d, new GammaParticle(731600.0, 0.00169)), new(0.024d, new GammaParticle(736400.0, 0.00168)), new(0.0048d, new GammaParticle(736800.0, 0.00168)), new(0.024d, new GammaParticle(741700.0, 0.00167)), new(0.0026d, new GammaParticle(745000.0, 0.00166)), new(0.0028000000000000004d, new GammaParticle(753200.0, 0.00165)), new(0.0055000000000000005d, new GammaParticle(754800.0, 0.00164)), new(0.0048d, new GammaParticle(763600.0, 0.00162)), new(0.0064d, new GammaParticle(769000.0, 0.00161)), new(0.001d, new GammaParticle(769300.0, 0.00161)), new(0.0016d, new GammaParticle(771800.0, 0.00161)), new(0.027000000000000003d, new GammaParticle(775100.0, 0.0016)), new(0.00035000000000000005d, new GammaParticle(784000.0, 0.00158)), new(0.0014000000000000002d, new GammaParticle(788300.0, 0.00157)), new(0.1158d, new GammaParticle(789400.0, 0.00157)), new(0.0021d, new GammaParticle(794500.0, 0.00156)), new(0.0054d, new GammaParticle(805000.0, 0.00154)), new(0.00248d, new GammaParticle(812200.0, 0.00153)), new(0.0015d, new GammaParticle(819300.0, 0.00151)), new(0.0008d, new GammaParticle(819600.0, 0.00151)), new(0.001d, new GammaParticle(823600.0, 0.00151)), new(0.0002d, new GammaParticle(825400.0, 0.0015)), new(0.00135d, new GammaParticle(827600.0, 0.0015)), new(0.0484d, new GammaParticle(836700.0, 0.00148)), new(0.003d, new GammaParticle(837100.0, 0.00148)), new(0.0009d, new GammaParticle(842300.0, 0.00147)), new(0.0015d, new GammaParticle(852200.0, 0.00145)), new(0.0008d, new GammaParticle(857000.0, 0.00145)), new(0.0008d, new GammaParticle(859600.0, 0.00144)), new(0.0104d, new GammaParticle(859700.0, 0.00144)), new(0.0075d, new GammaParticle(860100.0, 0.00144)), new(0.0005d, new GammaParticle(863500.0, 0.00144)), new(0.0313d, new GammaParticle(869700.0, 0.00143)), new(0.0017000000000000001d, new GammaParticle(870000.0, 0.00143)), new(0.0208d, new GammaParticle(871200.0, 0.00142)), new(0.0034999999999999996d, new GammaParticle(872400.0, 0.00142)), new(0.0021d, new GammaParticle(876200.0, 0.00142)), new(0.00035000000000000005d, new GammaParticle(877100.0, 0.00141)), new(0.0034999999999999996d, new GammaParticle(881400.0, 0.00141)), new(0.00313d, new GammaParticle(901000.0, 0.00138)), new(0.002d, new GammaParticle(906700.0, 0.00137)), new(0.0008d, new GammaParticle(910300.0, 0.00136)), new(0.0086d, new GammaParticle(912800.0, 0.00136)), new(0.0053d, new GammaParticle(913200.0, 0.00136)), new(0.001d, new GammaParticle(921000.0, 0.00135)), new(0.00406d, new GammaParticle(924000.0, 0.00134)), new(0.0008699999999999999d, new GammaParticle(937800.0, 0.00132)), new(0.00233d, new GammaParticle(945400.0, 0.00131)), new(0.0097d, new GammaParticle(952900.0, 0.0013)), new(0.0012d, new GammaParticle(960000.0, 0.00129)), new(0.0006d, new GammaParticle(969400.0, 0.00128)), new(0.0022d, new GammaParticle(972200.0, 0.00128)), new(0.0039000000000000003d, new GammaParticle(973400.0, 0.00127)), new(0.0008d, new GammaParticle(974500.0, 0.00127)), new(0.0012d, new GammaParticle(982200.0, 0.00126)), new(0.0008d, new GammaParticle(986000.0, 0.00126)), new(0.006500000000000001d, new GammaParticle(986800.0, 0.00126)), new(0.013000000000000001d, new GammaParticle(987800.0, 0.00126)), new(0.0116d, new GammaParticle(997500.0, 0.00124)), new(0.0019d, new GammaParticle(998600.0, 0.00124)), new(0.00023d, new GammaParticle(1000800.0, 0.00124)), new(0.00035000000000000005d, new GammaParticle(1001200.0, 0.00124)), new(0.0022d, new GammaParticle(1008300.0, 0.00123)), new(0.023d, new GammaParticle(1010600.0, 0.00123)), new(0.0011d, new GammaParticle(1016500.0, 0.00122)), new(0.0008d, new GammaParticle(1027100.0, 0.00121)), new(0.0007000000000000001d, new GammaParticle(1032600.0, 0.0012)), new(0.00023d, new GammaParticle(1033200.0, 0.0012)), new(0.0009299999999999999d, new GammaParticle(1034900.0, 0.0012)), new(0.0089d, new GammaParticle(1039100.0, 0.00119)), new(0.0163d, new GammaParticle(1039800.0, 0.00119)), new(0.00035000000000000005d, new GammaParticle(1042100.0, 0.00119)), new(0.0034999999999999996d, new GammaParticle(1043700.0, 0.00119)), new(0.0006d, new GammaParticle(1044300.0, 0.00119)), new(0.00086d, new GammaParticle(1046200.0, 0.00119)), new(0.0013d, new GammaParticle(1049200.0, 0.00118)), new(0.00023d, new GammaParticle(1056000.0, 0.00117)), new(0.0189d, new GammaParticle(1057900.0, 0.00117)), new(0.00975d, new GammaParticle(1080600.0, 0.00115)), new(0.0072d, new GammaParticle(1083400.0, 0.00114)), new(0.0002d, new GammaParticle(1084000.0, 0.00114)), new(0.0042d, new GammaParticle(1087300.0, 0.00114)), new(0.0005d, new GammaParticle(1092300.0, 0.00114)), new(0.00317d, new GammaParticle(1095000.0, 0.00113)), new(0.0032d, new GammaParticle(1097800.0, 0.00113)), new(0.0017000000000000001d, new GammaParticle(1103200.0, 0.00112)), new(0.0016200000000000001d, new GammaParticle(1109200.0, 0.00112)), new(0.00045d, new GammaParticle(1110400.0, 0.00112)), new(0.00819d, new GammaParticle(1121900.0, 0.00111)), new(0.0008500000000000001d, new GammaParticle(1128000.0, 0.0011)), new(0.016d, new GammaParticle(1135200.0, 0.00109)), new(0.0016200000000000001d, new GammaParticle(1142200.0, 0.00109)), new(0.0014000000000000002d, new GammaParticle(1148200.0, 0.00108)), new(0.00113d, new GammaParticle(1150000.0, 0.00108)), new(0.0037d, new GammaParticle(1152300.0, 0.00108)), new(0.0039000000000000003d, new GammaParticle(1153300.0, 0.00108)), new(0.00075d, new GammaParticle(1162600.0, 0.00107)), new(0.005699999999999999d, new GammaParticle(1169500.0, 0.00106)), new(0.0073d, new GammaParticle(1170100.0, 0.00106)), new(0.0014000000000000002d, new GammaParticle(1173900.0, 0.00106)), new(0.0087d, new GammaParticle(1174900.0, 0.00106)), new(0.00382d, new GammaParticle(1187500.0, 0.00104)), new(0.00243d, new GammaParticle(1188900.0, 0.00104)), new(0.0015d, new GammaParticle(1189600.0, 0.00104)), new(0.00234d, new GammaParticle(1193700.0, 0.00104)), new(0.0068000000000000005d, new GammaParticle(1195600.0, 0.00104)), new(0.0006d, new GammaParticle(1201300.0, 0.00103)), new(0.0006d, new GammaParticle(1201800.0, 0.00103)), new(0.00134d, new GammaParticle(1204500.0, 0.00103)), new(0.005520000000000001d, new GammaParticle(1221200.0, 0.00102)), new(0.004719999999999999d, new GammaParticle(1228200.0, 0.00101)), new(0.0008500000000000001d, new GammaParticle(1231500.0, 0.00101)), new(0.0022d, new GammaParticle(1236900.0, 0.001)), new(0.0032d, new GammaParticle(1237100.0, 0.001)), new(0.0005d, new GammaParticle(1239000.0, 0.001)), new(0.0013d, new GammaParticle(1240100.0, 0.001)), new(0.003d, new GammaParticle(1246800.0, 0.00099)), new(0.00035000000000000005d, new GammaParticle(1248900.0, 0.00099)), new(0.0049d, new GammaParticle(1254300.0, 0.00099)), new(0.0085d, new GammaParticle(1263800.0, 0.00098)), new(0.02d, new GammaParticle(1274900.0, 0.00097)), new(0.0013d, new GammaParticle(1278500.0, 0.00097)), new(0.0006d, new GammaParticle(1284700.0, 0.00097)), new(0.0012d, new GammaParticle(1288500.0, 0.00096)), new(0.0012d, new GammaParticle(1288500.0, 0.00096)), new(0.00046d, new GammaParticle(1297200.0, 0.00096)), new(0.0075d, new GammaParticle(1301600.0, 0.00095)), new(0.0073d, new GammaParticle(1316100.0, 0.00094)), new(0.0009299999999999999d, new GammaParticle(1320400.0, 0.00094)), new(0.010700000000000001d, new GammaParticle(1323700.0, 0.00094)), new(0.0007000000000000001d, new GammaParticle(1325000.0, 0.00094)), new(0.0005d, new GammaParticle(1332900.0, 0.00093)), new(0.0006900000000000001d, new GammaParticle(1343600.0, 0.00092)), new(0.0006900000000000001d, new GammaParticle(1346300.0, 0.00092)), new(0.00647d, new GammaParticle(1376000.0, 0.0009)), new(0.0014000000000000002d, new GammaParticle(1381300.0, 0.0009)), new(0.0039000000000000003d, new GammaParticle(1384700.0, 0.0009)), new(0.0019d, new GammaParticle(1384700.0, 0.0009)), new(0.0008d, new GammaParticle(1387900.0, 0.00089)), new(0.02d, new GammaParticle(1390300.0, 0.00089)), new(0.0005d, new GammaParticle(1391900.0, 0.00089)), new(0.00267d, new GammaParticle(1416400.0, 0.00088)), new(0.0189d, new GammaParticle(1422600.0, 0.00087)), new(0.0006d, new GammaParticle(1425100.0, 0.00087)), new(0.00023d, new GammaParticle(1427900.0, 0.00087)), new(0.00017d, new GammaParticle(1428000.0, 0.00087)), new(0.0034000000000000002d, new GammaParticle(1438000.0, 0.00086)), new(0.0014000000000000002d, new GammaParticle(1467600.0, 0.00084)), new(0.0013d, new GammaParticle(1468700.0, 0.00084)), new(0.0034000000000000002d, new GammaParticle(1471700.0, 0.00084)), new(0.00023d, new GammaParticle(1472700.0, 0.00084)), new(0.00058d, new GammaParticle(1492700.0, 0.00083)), new(0.039d, new GammaParticle(1521400.0, 0.00081)), new(0.00043999999999999996d, new GammaParticle(1527300.0, 0.00081)), new(0.00031d, new GammaParticle(1528600.0, 0.00081)), new(0.0005099999999999999d, new GammaParticle(1531000.0, 0.00081)), new(0.00148d, new GammaParticle(1565800.0, 0.00079)), new(0.0028000000000000004d, new GammaParticle(1569800.0, 0.00079)), new(0.0005d, new GammaParticle(1597000.0, 0.00078)), new(0.0005099999999999999d, new GammaParticle(1604800.0, 0.00077)), new(0.0016d, new GammaParticle(1613800.0, 0.00077)), new(0.00017d, new GammaParticle(1627500.0, 0.00076)), new(0.0207d, new GammaParticle(1627600.0, 0.00076)), new(0.00233d, new GammaParticle(1645100.0, 0.00075)), new(0.0087d, new GammaParticle(1661700.0, 0.00075)), new(0.0063d, new GammaParticle(1670000.0, 0.00074)), new(0.00058d, new GammaParticle(1697400.0, 0.00073)), new(0.0007000000000000001d, new GammaParticle(1699600.0, 0.00073)), new(0.0006d, new GammaParticle(1700700.0, 0.00073)), new(0.0008799999999999999d, new GammaParticle(1740900.0, 0.00071)), new(0.1166d, new GammaParticle(1776200.0, 0.0007)), new(0.0007000000000000001d, new GammaParticle(1779800.0, 0.0007)), new(0.00032d, new GammaParticle(1789000.0, 0.00069)), new(0.07690000000000001d, new GammaParticle(1805800.0, 0.00069)), new(0.0005d, new GammaParticle(1816400.0, 0.00068)), new(0.002d, new GammaParticle(1819300.0, 0.00068)), new(0.0019d, new GammaParticle(1847300.0, 0.00067)), new(0.008d, new GammaParticle(1858400.0, 0.00067)), new(0.0068000000000000005d, new GammaParticle(1867300.0, 0.00066)), new(0.00043d, new GammaParticle(1891800.0, 0.00066)), new(0.00037999999999999997d, new GammaParticle(1892400.0, 0.00066)), new(0.00131d, new GammaParticle(1910200.0, 0.00065)), new(0.016399999999999998d, new GammaParticle(1917400.0, 0.00065)), new(0.00046d, new GammaParticle(1979500.0, 0.00063)), new(0.0005d, new GammaParticle(2026200.0, 0.00061)), new(0.0258d, new GammaParticle(2029600.0, 0.00061)), new(0.00252d, new GammaParticle(2038500.0, 0.00061)), new(0.00012d, new GammaParticle(2087300.0, 0.00059)), new(0.00029d, new GammaParticle(2105400.0, 0.00059)), new(0.00029d, new GammaParticle(2113000.0, 0.00059)), new(0.0017000000000000001d, new GammaParticle(2125300.0, 0.00058)), new(0.0002d, new GammaParticle(2128100.0, 0.00058)), new(0.0013d, new GammaParticle(2224300.0, 0.00056)), new(0.00034d, new GammaParticle(2279600.0, 0.00054)), new(0.00058d, new GammaParticle(2309300.0, 0.00054)), new(0.00043d, new GammaParticle(2316400.0, 0.00054)), new(0.0003d, new GammaParticle(2340500.0, 0.00053)), new(0.00035999999999999997d, new GammaParticle(2416700.0, 0.00051)), new(0.00027d, new GammaParticle(2446500.0, 0.00051)), new(0.00014000000000000001d, new GammaParticle(2480600.0, 0.0005)), new(0.00012d, new GammaParticle(2530500.0, 0.00049)), new(0.00012d, new GammaParticle(2537600.0, 0.00049)), new(0.00015d, new GammaParticle(2625600.0, 0.00047)), new(0.13736238d, new GammaParticle(511000.0, 0.00243)), new(0.228d, new GammaParticle(7118.0, 0.17418)), new(0.327d, new GammaParticle(43743.0, 0.02834)), new(0.5870000000000001d, new GammaParticle(44481.0, 0.02787)), new(0.187d, new GammaParticle(50494.0, 0.02455)), new(0.23600000000000002d, new GammaParticle(51040.0, 0.02429)), new(0.048499999999999995d, new GammaParticle(51699.0, 0.02398)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 300.0d, 0.000000000000103351d },
            { 600.0d, 0.00000000000771663d },
            { 900.0d, 0.0000000000408234d },
            { 1200.0d, 0.0000000000934293d },
            { 1700.0d, 0.000000000306652d },
            { 2200.0d, 0.000000000653764d },
            { 2700.0d, 0.00000000115092d },
            { 3200.0d, 0.00000000182452d },
            { 3700.0d, 0.00000000274633d },
            { 4200.0d, 0.00000000399843d },
            { 4700.0d, 0.00000000554814d },
            { 5200.0d, 0.00000000741344d },
            { 5700.0d, 0.0000000095554d },
            { 6200.0d, 0.0000000120578d },
            { 6700.0d, 0.0000000150332d },
            { 7200.0d, 0.000000018361d },
            { 7700.0d, 0.0000000220413d },
            { 8200.0d, 0.0000000261393d },
            { 8700.0d, 0.0000000307288d },
            { 9200.0d, 0.000000035789d },
            { 9700.0d, 0.0000000413821d },
            { 10000.0d, 0.0000000449577d },
            { 11000.0d, 0.0000000584723d },
            { 12000.0d, 0.0000000740312d },
            { 13000.0d, 0.0000000929727d },
            { 14000.0d, 0.000000114507d },
            { 15000.0d, 0.000000138854d },
            { 16000.0d, 0.000000166323d },
            { 17000.0d, 0.000000197178d },
            { 18000.0d, 0.000000231128d },
            { 19000.0d, 0.000000268951d },
            { 20000.0d, 0.000000310179d },
            { 21000.0d, 0.000000355076d },
            { 22000.0d, 0.000000403664d },
            { 23000.0d, 0.000000455925d },
            { 24000.0d, 0.000000511834d },
            { 25000.0d, 0.000000571933d },
            { 26000.0d, 0.000000635918d },
            { 27000.0d, 0.000000703782d },
            { 28000.0d, 0.000000775557d },
            { 29000.0d, 0.000000851264d },
            { 30000.0d, 0.000000930878d },
            { 31000.0d, 0.0000010145d },
            { 32000.0d, 0.00000110207d },
            { 33000.0d, 0.00000119357d },
            { 34000.0d, 0.00000128898d },
            { 35000.0d, 0.00000138827d },
            { 36000.0d, 0.00000149145d },
            { 37000.0d, 0.00000159841d },
            { 38000.0d, 0.0000017092d },
            { 39000.0d, 0.00000182377d },
            { 40000.0d, 0.00000194209d },
            { 41000.0d, 0.00000206404d },
            { 42000.0d, 0.00000218971d },
            { 43000.0d, 0.00000231885d },
            { 44000.0d, 0.00000245161d },
            { 45000.0d, 0.00000258787d },
            { 46000.0d, 0.00000272757d },
            { 47000.0d, 0.00000287071d },
            { 48000.0d, 0.0000030173d },
            { 49000.0d, 0.00000316697d },
            { 50000.0d, 0.00000331993d },
            { 51000.0d, 0.00000347609d },
            { 52000.0d, 0.00000363539d },
            { 53000.0d, 0.00000379777d },
            { 54000.0d, 0.00000396329d },
            { 55000.0d, 0.00000413162d },
            { 56000.0d, 0.0000043029d },
            { 57000.0d, 0.00000447698d },
            { 58000.0d, 0.00000465385d },
            { 59000.0d, 0.00000483351d },
            { 60000.0d, 0.00000501597d },
            { 61000.0d, 0.00000520083d },
            { 62000.0d, 0.00000538833d },
            { 63000.0d, 0.00000557839d },
            { 64000.0d, 0.00000577093d },
            { 65000.0d, 0.00000596584d },
            { 66000.0d, 0.00000616317d },
            { 67000.0d, 0.00000636263d },
            { 68000.0d, 0.0000065644d },
            { 69000.0d, 0.00000676838d },
            { 70000.0d, 0.00000697451d },
            { 71000.0d, 0.00000718275d },
            { 72000.0d, 0.00000739314d },
            { 73000.0d, 0.00000760527d },
            { 74000.0d, 0.0000078194d },
            { 75000.0d, 0.00000803545d },
            { 76000.0d, 0.00000825333d },
            { 77000.0d, 0.00000847302d },
            { 78000.0d, 0.00000869454d },
            { 79000.0d, 0.00000891762d },
            { 80000.0d, 0.00000914241d },
            { 81000.0d, 0.00000936873d },
            { 82000.0d, 0.00000959663d },
            { 83000.0d, 0.00000982608d },
            { 84000.0d, 0.0000100571d },
            { 85000.0d, 0.0000102894d },
            { 86000.0d, 0.0000105231d },
            { 87000.0d, 0.0000107581d },
            { 88000.0d, 0.0000109945d },
            { 89000.0d, 0.0000112321d },
            { 90000.0d, 0.0000114711d },
            { 91000.0d, 0.000011711d },
            { 92000.0d, 0.0000119522d },
            { 93000.0d, 0.0000121944d },
            { 94000.0d, 0.0000124378d },
            { 95000.0d, 0.0000126822d },
            { 96000.0d, 0.0000129277d },
            { 97000.0d, 0.0000131739d },
            { 98000.0d, 0.0000134211d },
            { 99000.0d, 0.0000136693d },
            { 100000.0d, 0.0000139183d },
            { 108000.0d, 0.0000159372d },
            { 116000.0d, 0.0000179929d },
            { 124000.0d, 0.0000200718d },
            { 132000.0d, 0.0000221618d },
            { 140000.0d, 0.0000242523d },
            { 148000.0d, 0.0000263344d },
            { 156000.0d, 0.0000284004d },
            { 164000.0d, 0.0000304432d },
            { 172000.0d, 0.0000324571d },
            { 180000.0d, 0.000034437d },
            { 188000.0d, 0.0000363784d },
            { 196000.0d, 0.0000382777d },
            { 204000.0d, 0.0000401315d },
            { 212000.0d, 0.0000419371d },
            { 220000.0d, 0.000043692d },
            { 228000.0d, 0.0000453942d },
            { 236000.0d, 0.000047042d },
            { 244000.0d, 0.000048634d },
            { 252000.0d, 0.0000501691d },
            { 260000.0d, 0.0000516461d },
            { 268000.0d, 0.0000530645d },
            { 276000.0d, 0.0000544235d },
            { 284000.0d, 0.0000557228d },
            { 292000.0d, 0.0000569622d },
            { 300000.0d, 0.0000581414d },
            { 308000.0d, 0.0000592604d },
            { 316000.0d, 0.0000603194d },
            { 324000.0d, 0.0000613185d },
            { 332000.0d, 0.0000622581d },
            { 340000.0d, 0.0000631384d },
            { 348000.0d, 0.0000639599d },
            { 356000.0d, 0.0000647232d },
            { 364000.0d, 0.0000654288d },
            { 372000.0d, 0.0000660774d },
            { 380000.0d, 0.0000666698d },
            { 388000.0d, 0.0000672066d },
            { 396000.0d, 0.0000676887d },
            { 404000.0d, 0.000068117d },
            { 412000.0d, 0.0000684924d },
            { 420000.0d, 0.0000688158d },
            { 428000.0d, 0.0000690884d },
            { 436000.0d, 0.0000693109d },
            { 444000.0d, 0.0000694846d },
            { 452000.0d, 0.0000696105d },
            { 460000.0d, 0.0000696899d },
            { 468000.0d, 0.0000697238d },
            { 476000.0d, 0.0000697136d },
            { 484000.0d, 0.0000696605d },
            { 492000.0d, 0.0000695657d },
            { 500000.0d, 0.0000694308d },
            { 508000.0d, 0.0000692568d },
            { 516000.0d, 0.0000690452d },
            { 524000.0d, 0.0000687973d },
            { 532000.0d, 0.0000685146d },
            { 540000.0d, 0.0000681983d },
            { 548000.0d, 0.0000678501d },
            { 556000.0d, 0.0000674715d },
            { 564000.0d, 0.0000670639d },
            { 572000.0d, 0.0000666289d },
            { 580000.0d, 0.0000661681d },
            { 588000.0d, 0.0000656832d },
            { 596000.0d, 0.0000651758d },
            { 604000.0d, 0.0000646474d },
            { 612000.0d, 0.0000640998d },
            { 620000.0d, 0.0000635344d },
            { 628000.0d, 0.000062952d },
            { 636000.0d, 0.0000623546d },
            { 644000.0d, 0.0000617435d },
            { 652000.0d, 0.0000611208d },
            { 660000.0d, 0.0000604879d },
            { 668000.0d, 0.0000598469d },
            { 676000.0d, 0.0000591993d },
            { 684000.0d, 0.0000585469d },
            { 692000.0d, 0.0000578918d },
            { 700000.0d, 0.0000572357d },
            { 708000.0d, 0.0000565797d },
            { 716000.0d, 0.0000559216d },
            { 724000.0d, 0.0000552595d },
            { 732000.0d, 0.000054595d },
            { 740000.0d, 0.0000539295d },
            { 748000.0d, 0.0000532647d },
            { 756000.0d, 0.0000526016d },
            { 764000.0d, 0.0000519415d },
            { 772000.0d, 0.0000512854d },
            { 780000.0d, 0.000050635d },
            { 788000.0d, 0.0000499919d },
            { 796000.0d, 0.0000493577d },
            { 804000.0d, 0.000048734d },
            { 812000.0d, 0.0000481223d },
            { 820000.0d, 0.0000475245d },
            { 828000.0d, 0.0000469407d },
            { 836000.0d, 0.0000463711d },
            { 844000.0d, 0.0000458171d },
            { 852000.0d, 0.0000452805d },
            { 860000.0d, 0.0000447623d },
            { 868000.0d, 0.0000442644d },
            { 876000.0d, 0.0000437884d },
            { 884000.0d, 0.0000433359d },
            { 892000.0d, 0.0000429082d },
            { 900000.0d, 0.0000425007d },
            { 908000.0d, 0.0000421025d },
            { 916000.0d, 0.0000417126d },
            { 924000.0d, 0.000041332d },
            { 932000.0d, 0.0000409613d },
            { 940000.0d, 0.0000405939d },
            { 948000.0d, 0.000040226d },
            { 956000.0d, 0.000039858d },
            { 964000.0d, 0.0000394904d },
            { 972000.0d, 0.0000391237d },
            { 980000.0d, 0.0000387585d },
            { 988000.0d, 0.0000383952d },
            { 996000.0d, 0.0000380344d },
            { 1004000.0d, 0.0000376758d },
            { 1012000.0d, 0.0000373196d },
            { 1020000.0d, 0.000036966d },
            { 1028000.0d, 0.0000366155d },
            { 1036000.0d, 0.0000362687d },
            { 1044000.0d, 0.0000359256d },
            { 1052000.0d, 0.0000355829d },
            { 1060000.0d, 0.0000352369d },
            { 1068000.0d, 0.0000348879d },
            { 1076000.0d, 0.0000345361d },
            { 1084000.0d, 0.0000341812d },
            { 1092000.0d, 0.0000338226d },
            { 1100000.0d, 0.0000334605d },
            { 1108000.0d, 0.0000330954d },
            { 1116000.0d, 0.0000327273d },
            { 1124000.0d, 0.0000323565d },
            { 1132000.0d, 0.0000319832d },
            { 1140000.0d, 0.0000316078d },
            { 1148000.0d, 0.0000312302d },
            { 1156000.0d, 0.000030851d },
            { 1164000.0d, 0.0000304703d },
            { 1172000.0d, 0.0000300883d },
            { 1180000.0d, 0.0000297053d },
            { 1188000.0d, 0.0000293215d },
            { 1196000.0d, 0.0000289372d },
            { 1204000.0d, 0.0000285526d },
            { 1212000.0d, 0.0000281681d },
            { 1220000.0d, 0.0000277838d },
            { 1228000.0d, 0.0000274d },
            { 1236000.0d, 0.000027017d },
            { 1244000.0d, 0.000026635d },
            { 1252000.0d, 0.0000262545d },
            { 1260000.0d, 0.0000258754d },
            { 1268000.0d, 0.0000254981d },
            { 1276000.0d, 0.0000251222d },
            { 1284000.0d, 0.0000247479d },
            { 1292000.0d, 0.0000243754d },
            { 1300000.0d, 0.0000240051d },
            { 1308000.0d, 0.0000236369d },
            { 1316000.0d, 0.0000232713d },
            { 1324000.0d, 0.0000229083d },
            { 1332000.0d, 0.000022548d },
            { 1340000.0d, 0.0000221908d },
            { 1348000.0d, 0.0000218369d },
            { 1356000.0d, 0.0000214853d },
            { 1364000.0d, 0.0000211349d },
            { 1372000.0d, 0.0000207858d },
            { 1380000.0d, 0.0000204382d },
            { 1388000.0d, 0.0000200924d },
            { 1396000.0d, 0.0000197481d },
            { 1404000.0d, 0.0000194045d },
            { 1412000.0d, 0.0000190618d },
            { 1420000.0d, 0.00001872d },
            { 1428000.0d, 0.0000183794d },
            { 1436000.0d, 0.0000180401d },
            { 1444000.0d, 0.0000177023d },
            { 1452000.0d, 0.0000173661d },
            { 1460000.0d, 0.0000170318d },
            { 1468000.0d, 0.0000166995d },
            { 1476000.0d, 0.0000163694d },
            { 1484000.0d, 0.0000160416d },
            { 1492000.0d, 0.0000157164d },
            { 1500000.0d, 0.0000153939d },
            { 1508000.0d, 0.0000150742d },
            { 1516000.0d, 0.0000147575d },
            { 1524000.0d, 0.0000144437d },
            { 1532000.0d, 0.0000141329d },
            { 1540000.0d, 0.0000138249d },
            { 1548000.0d, 0.00001352d },
            { 1556000.0d, 0.0000132183d },
            { 1564000.0d, 0.0000129201d },
            { 1572000.0d, 0.0000126253d },
            { 1580000.0d, 0.0000123337d },
            { 1588000.0d, 0.0000120453d },
            { 1596000.0d, 0.0000117598d },
            { 1604000.0d, 0.0000114771d },
            { 1612000.0d, 0.0000111973d },
            { 1620000.0d, 0.0000109206d },
            { 1628000.0d, 0.0000106471d },
            { 1636000.0d, 0.0000103769d },
            { 1644000.0d, 0.0000101102d },
            { 1652000.0d, 0.00000984719d },
            { 1660000.0d, 0.00000958787d },
            { 1668000.0d, 0.00000933231d },
            { 1676000.0d, 0.00000908068d },
            { 1684000.0d, 0.00000883313d },
            { 1692000.0d, 0.00000858963d },
            { 1700000.0d, 0.00000835011d },
            { 1708000.0d, 0.00000811475d },
            { 1716000.0d, 0.0000078837d },
            { 1724000.0d, 0.0000076571d },
            { 1732000.0d, 0.00000743508d },
            { 1740000.0d, 0.00000721772d },
            { 1748000.0d, 0.00000700521d },
            { 1756000.0d, 0.00000679771d },
            { 1764000.0d, 0.00000659534d },
            { 1772000.0d, 0.00000639829d },
            { 1780000.0d, 0.00000620668d },
            { 1788000.0d, 0.0000060207d },
            { 1796000.0d, 0.0000058404d },
            { 1804000.0d, 0.00000566559d },
            { 1812000.0d, 0.00000549605d },
            { 1820000.0d, 0.00000533174d },
            { 1828000.0d, 0.00000517276d },
            { 1836000.0d, 0.00000501919d },
            { 1844000.0d, 0.00000487119d },
            { 1852000.0d, 0.00000472889d },
            { 1860000.0d, 0.00000459243d },
            { 1868000.0d, 0.00000446196d },
            { 1876000.0d, 0.00000433762d },
            { 1884000.0d, 0.00000421956d },
            { 1892000.0d, 0.00000410793d },
            { 1900000.0d, 0.00000400286d },
            { 1908000.0d, 0.00000390437d },
            { 1916000.0d, 0.00000381228d },
            { 1924000.0d, 0.0000037267d },
            { 1932000.0d, 0.00000364771d },
            { 1940000.0d, 0.00000357512d },
            { 1948000.0d, 0.00000350882d },
            { 1956000.0d, 0.00000344605d },
            { 1964000.0d, 0.00000338409d },
            { 1972000.0d, 0.00000332297d },
            { 1980000.0d, 0.00000326271d },
            { 1988000.0d, 0.00000320334d },
            { 1996000.0d, 0.00000314489d },
            { 2004000.0d, 0.00000308739d },
            { 2012000.0d, 0.00000303086d },
            { 2020000.0d, 0.00000297535d },
            { 2028000.0d, 0.0000029208d },
            { 2036000.0d, 0.00000286713d },
            { 2044000.0d, 0.00000281398d },
            { 2052000.0d, 0.00000276136d },
            { 2060000.0d, 0.00000270926d },
            { 2068000.0d, 0.00000265771d },
            { 2076000.0d, 0.00000260675d },
            { 2084000.0d, 0.00000255638d },
            { 2092000.0d, 0.00000250634d },
            { 2100000.0d, 0.00000245635d },
            { 2108000.0d, 0.00000240643d },
            { 2116000.0d, 0.00000235661d },
            { 2124000.0d, 0.00000230688d },
            { 2132000.0d, 0.00000225727d },
            { 2140000.0d, 0.0000022078d },
            { 2148000.0d, 0.00000215847d },
            { 2156000.0d, 0.0000021093d },
            { 2164000.0d, 0.00000206033d },
            { 2172000.0d, 0.00000201156d },
            { 2180000.0d, 0.000001963d },
            { 2188000.0d, 0.00000191468d },
            { 2196000.0d, 0.00000186662d },
            { 2204000.0d, 0.00000181883d },
            { 2212000.0d, 0.00000177135d },
            { 2220000.0d, 0.00000172418d },
            { 2228000.0d, 0.00000167735d },
            { 2236000.0d, 0.00000163088d },
            { 2244000.0d, 0.00000158479d },
            { 2252000.0d, 0.0000015391d },
            { 2260000.0d, 0.00000149385d },
            { 2268000.0d, 0.00000144904d },
            { 2276000.0d, 0.00000140471d },
            { 2284000.0d, 0.00000136088d },
            { 2292000.0d, 0.00000131757d },
            { 2300000.0d, 0.00000127481d },
            { 2308000.0d, 0.00000123262d },
            { 2316000.0d, 0.000001191d },
            { 2324000.0d, 0.0000011497d },
            { 2332000.0d, 0.00000110864d },
            { 2340000.0d, 0.00000106785d },
            { 2348000.0d, 0.00000102737d },
            { 2356000.0d, 0.000000987202d },
            { 2364000.0d, 0.000000947387d },
            { 2372000.0d, 0.00000090794d },
            { 2380000.0d, 0.00000086889d },
            { 2388000.0d, 0.000000830264d },
            { 2396000.0d, 0.000000792086d },
            { 2404000.0d, 0.000000754388d },
            { 2412000.0d, 0.000000717194d },
            { 2420000.0d, 0.000000680535d },
            { 2428000.0d, 0.00000064444d },
            { 2436000.0d, 0.00000060894d },
            { 2444000.0d, 0.000000574065d },
            { 2452000.0d, 0.000000539847d },
            { 2460000.0d, 0.000000506319d },
            { 2468000.0d, 0.000000473514d },
            { 2476000.0d, 0.000000441464d },
            { 2484000.0d, 0.000000410206d },
            { 2492000.0d, 0.000000379775d },
            { 2500000.0d, 0.000000350204d },
            { 2508000.0d, 0.000000321533d },
            { 2516000.0d, 0.000000293799d },
            { 2524000.0d, 0.000000267039d },
            { 2532000.0d, 0.000000241293d },
            { 2540000.0d, 0.000000216601d },
            { 2548000.0d, 0.000000193003d },
            { 2556000.0d, 0.00000017054d },
            { 2564000.0d, 0.000000149255d },
            { 2572000.0d, 0.00000012919d },
            { 2580000.0d, 0.00000011039d },
            { 2588000.0d, 0.0000000928984d },
            { 2596000.0d, 0.0000000767606d },
            { 2604000.0d, 0.0000000620229d },
            { 2612000.0d, 0.0000000487316d },
            { 2620000.0d, 0.0000000369342d },
            { 2628000.0d, 0.0000000266785d },
            { 2636000.0d, 0.0000000180132d },
            { 2644000.0d, 0.0000000109871d },
            { 2652000.0d, 0.00000000564921d },
            { 2660000.0d, 0.00000000204804d },
            { 2668000.0d, 0.000000000229822d },
            { 2672000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    