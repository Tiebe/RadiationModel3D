using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium156";
        public override double halfLife { get; } = 3360.0d;
        public override double atomicWeight { get; } = 155.92964d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium156()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.000312d, new GammaParticle(61700.0, 0.02009)), new(0.00156d, new GammaParticle(80200.0, 0.01546)), new(0.000416d, new GammaParticle(131700.0, 0.00941)), new(0.52d, new GammaParticle(137800.0, 0.009)), new(0.00104d, new GammaParticle(146400.0, 0.00847)), new(0.000364d, new GammaParticle(152800.0, 0.00811)), new(0.00156d, new GammaParticle(167000.0, 0.00742)), new(0.00104d, new GammaParticle(190000.0, 0.00653)), new(0.007592d, new GammaParticle(259590.0, 0.00478)), new(0.6604000000000001d, new GammaParticle(266380.0, 0.00465)), new(0.000832d, new GammaParticle(271000.0, 0.00458)), new(0.0036919999999999995d, new GammaParticle(277960.0, 0.00446)), new(0.00052d, new GammaParticle(304600.0, 0.00407)), new(0.003432d, new GammaParticle(313400.0, 0.00396)), new(0.0014039999999999999d, new GammaParticle(317900.0, 0.0039)), new(0.007332d, new GammaParticle(348960.0, 0.00355)), new(0.002756d, new GammaParticle(356300.0, 0.00348)), new(0.00104d, new GammaParticle(357000.0, 0.00347)), new(0.000572d, new GammaParticle(360700.0, 0.00344)), new(0.14508d, new GammaParticle(366220.0, 0.00339)), new(0.000468d, new GammaParticle(393200.0, 0.00315)), new(0.001092d, new GammaParticle(397900.0, 0.00312)), new(0.005824d, new GammaParticle(424500.0, 0.00292)), new(0.000676d, new GammaParticle(437000.0, 0.00284)), new(0.000416d, new GammaParticle(437600.0, 0.00283)), new(0.001924d, new GammaParticle(445230.0, 0.00278)), new(0.000468d, new GammaParticle(456200.0, 0.00272)), new(0.00104d, new GammaParticle(458900.0, 0.0027)), new(0.0026d, new GammaParticle(486400.0, 0.00255)), new(0.001196d, new GammaParticle(491600.0, 0.00252)), new(0.000572d, new GammaParticle(524000.0, 0.00237)), new(0.004472d, new GammaParticle(537800.0, 0.00231)), new(0.00104d, new GammaParticle(548400.0, 0.00226)), new(0.001456d, new GammaParticle(553700.0, 0.00224)), new(0.000624d, new GammaParticle(562600.0, 0.0022)), new(0.00598d, new GammaParticle(565070.0, 0.00219)), new(0.001248d, new GammaParticle(582600.0, 0.00213)), new(0.00182d, new GammaParticle(585600.0, 0.00212)), new(0.002704d, new GammaParticle(588880.0, 0.00211)), new(0.0002444d, new GammaParticle(594900.0, 0.00208)), new(0.001872d, new GammaParticle(605300.0, 0.00205)), new(0.001092d, new GammaParticle(608200.0, 0.00204)), new(0.01872d, new GammaParticle(617880.0, 0.00201)), new(0.00052d, new GammaParticle(620100.0, 0.002)), new(0.000572d, new GammaParticle(624400.0, 0.00199)), new(0.001248d, new GammaParticle(638200.0, 0.00194)), new(0.001716d, new GammaParticle(654900.0, 0.00189)), new(0.0015079999999999998d, new GammaParticle(663300.0, 0.00187)), new(0.009984d, new GammaParticle(666880.0, 0.00186)), new(0.000936d, new GammaParticle(671200.0, 0.00185)), new(0.00052d, new GammaParticle(680600.0, 0.00182)), new(0.06916d, new GammaParticle(684100.0, 0.00181)), new(0.00078d, new GammaParticle(688900.0, 0.0018)), new(0.05408d, new GammaParticle(690860.0, 0.00179)), new(0.000728d, new GammaParticle(706740.0, 0.00175)), new(0.001248d, new GammaParticle(715100.0, 0.00173)), new(0.000676d, new GammaParticle(722300.0, 0.00172)), new(0.000728d, new GammaParticle(723500.0, 0.00171)), new(0.017159999999999998d, new GammaParticle(752670.0, 0.00165)), new(0.0091d, new GammaParticle(754900.0, 0.00164)), new(0.00312d, new GammaParticle(755000.0, 0.00164)), new(0.046799999999999994d, new GammaParticle(764120.0, 0.00162)), new(0.000832d, new GammaParticle(767800.0, 0.00161)), new(0.00052d, new GammaParticle(786100.0, 0.00158)), new(0.005096000000000001d, new GammaParticle(796030.0, 0.00156)), new(0.001352d, new GammaParticle(818100.0, 0.00152)), new(0.000988d, new GammaParticle(818700.0, 0.00151)), new(0.000416d, new GammaParticle(820900.0, 0.00151)), new(0.00208d, new GammaParticle(828700.0, 0.0015)), new(0.00104d, new GammaParticle(839300.0, 0.00148)), new(0.000572d, new GammaParticle(845300.0, 0.00147)), new(0.000624d, new GammaParticle(848200.0, 0.00146)), new(0.000364d, new GammaParticle(851000.0, 0.00146)), new(0.001768d, new GammaParticle(854600.0, 0.00145)), new(0.001768d, new GammaParticle(858000.0, 0.00145)), new(0.00052d, new GammaParticle(863300.0, 0.00144)), new(0.000936d, new GammaParticle(871600.0, 0.00142)), new(0.003432d, new GammaParticle(880500.0, 0.00141)), new(0.000572d, new GammaParticle(884300.0, 0.0014)), new(0.08528000000000001d, new GammaParticle(884300.0, 0.0014)), new(0.0014039999999999999d, new GammaParticle(890200.0, 0.00139)), new(0.03068d, new GammaParticle(890440.0, 0.00139)), new(0.00052d, new GammaParticle(907000.0, 0.00137)), new(0.000728d, new GammaParticle(907200.0, 0.00137)), new(0.000988d, new GammaParticle(908000.0, 0.00137)), new(0.00078d, new GammaParticle(911500.0, 0.00136)), new(0.000728d, new GammaParticle(914600.0, 0.00136)), new(0.000676d, new GammaParticle(919700.0, 0.00135)), new(0.001352d, new GammaParticle(921200.0, 0.00135)), new(0.03744d, new GammaParticle(931350.0, 0.00133)), new(0.000988d, new GammaParticle(935000.0, 0.00133)), new(0.000884d, new GammaParticle(939200.0, 0.00132)), new(0.00078d, new GammaParticle(944300.0, 0.00131)), new(0.0036919999999999995d, new GammaParticle(949600.0, 0.00131)), new(0.00624d, new GammaParticle(950500.0, 0.0013)), new(0.000988d, new GammaParticle(955400.0, 0.0013)), new(0.001144d, new GammaParticle(958300.0, 0.00129)), new(0.003588d, new GammaParticle(960600.0, 0.00129)), new(0.007852d, new GammaParticle(964360.0, 0.00129)), new(0.00052d, new GammaParticle(965300.0, 0.00128)), new(0.001196d, new GammaParticle(968200.0, 0.00128)), new(0.000312d, new GammaParticle(970400.0, 0.00128)), new(0.001196d, new GammaParticle(980100.0, 0.00127)), new(0.000728d, new GammaParticle(988700.0, 0.00125)), new(0.000728d, new GammaParticle(996100.0, 0.00124)), new(0.002236d, new GammaParticle(1001700.0, 0.00124)), new(0.00052d, new GammaParticle(1011700.0, 0.00123)), new(0.000624d, new GammaParticle(1024600.0, 0.00121)), new(0.04003999999999999d, new GammaParticle(1030700.0, 0.0012)), new(0.000572d, new GammaParticle(1031800.0, 0.0012)), new(0.00338d, new GammaParticle(1033200.0, 0.0012)), new(0.001664d, new GammaParticle(1036400.0, 0.0012)), new(0.001716d, new GammaParticle(1039300.0, 0.00119)), new(0.000572d, new GammaParticle(1040000.0, 0.00119)), new(0.000624d, new GammaParticle(1049600.0, 0.00118)), new(0.000572d, new GammaParticle(1050000.0, 0.00118)), new(0.002184d, new GammaParticle(1076200.0, 0.00115)), new(0.003328d, new GammaParticle(1081200.0, 0.00115)), new(0.0032240000000000003d, new GammaParticle(1087400.0, 0.00114)), new(0.00078d, new GammaParticle(1094800.0, 0.00113)), new(0.00052d, new GammaParticle(1095900.0, 0.00113)), new(0.0015079999999999998d, new GammaParticle(1110700.0, 0.00112)), new(0.002756d, new GammaParticle(1111200.0, 0.00112)), new(0.015600000000000001d, new GammaParticle(1121000.0, 0.00111)), new(0.042640000000000004d, new GammaParticle(1121800.0, 0.00111)), new(0.004628d, new GammaParticle(1128070.0, 0.0011)), new(0.001716d, new GammaParticle(1137400.0, 0.00109)), new(0.001664d, new GammaParticle(1139000.0, 0.00109)), new(0.000624d, new GammaParticle(1148000.0, 0.00108)), new(0.000728d, new GammaParticle(1154400.0, 0.00107)), new(0.006552d, new GammaParticle(1155300.0, 0.00107)), new(0.001664d, new GammaParticle(1156400.0, 0.00107)), new(0.00052d, new GammaParticle(1163100.0, 0.00107)), new(0.00104d, new GammaParticle(1172500.0, 0.00106)), new(0.002184d, new GammaParticle(1174200.0, 0.00106)), new(0.001144d, new GammaParticle(1174500.0, 0.00106)), new(0.0015079999999999998d, new GammaParticle(1177600.0, 0.00105)), new(0.001144d, new GammaParticle(1185600.0, 0.00105)), new(0.002236d, new GammaParticle(1191100.0, 0.00104)), new(0.006604d, new GammaParticle(1205200.0, 0.00103)), new(0.0013d, new GammaParticle(1217200.0, 0.00102)), new(0.0020280000000000003d, new GammaParticle(1218800.0, 0.00102)), new(0.001924d, new GammaParticle(1222800.0, 0.00101)), new(0.02912d, new GammaParticle(1223360.0, 0.00101)), new(0.027559999999999998d, new GammaParticle(1230720.0, 0.00101)), new(0.002236d, new GammaParticle(1235300.0, 0.001)), new(0.00078d, new GammaParticle(1241200.0, 0.001)), new(0.000728d, new GammaParticle(1241300.0, 0.001)), new(0.000988d, new GammaParticle(1259100.0, 0.00098)), new(0.001664d, new GammaParticle(1272800.0, 0.00097)), new(0.002704d, new GammaParticle(1278000.0, 0.00097)), new(0.000936d, new GammaParticle(1285400.0, 0.00096)), new(0.004524d, new GammaParticle(1292300.0, 0.00096)), new(0.000728d, new GammaParticle(1293000.0, 0.00096)), new(0.0014039999999999999d, new GammaParticle(1293400.0, 0.00096)), new(0.001716d, new GammaParticle(1297300.0, 0.00096)), new(0.0039000000000000003d, new GammaParticle(1297500.0, 0.00096)), new(0.013415999999999999d, new GammaParticle(1301500.0, 0.00095)), new(0.001924d, new GammaParticle(1309700.0, 0.00095)), new(0.002704d, new GammaParticle(1314700.0, 0.00094)), new(0.000624d, new GammaParticle(1320300.0, 0.00094)), new(0.000884d, new GammaParticle(1323200.0, 0.00094)), new(0.001248d, new GammaParticle(1332900.0, 0.00093)), new(0.005772d, new GammaParticle(1338310.0, 0.00093)), new(0.000988d, new GammaParticle(1345600.0, 0.00092)), new(0.000988d, new GammaParticle(1348900.0, 0.00092)), new(0.00052d, new GammaParticle(1351300.0, 0.00092)), new(0.002132d, new GammaParticle(1354100.0, 0.00092)), new(0.001092d, new GammaParticle(1355100.0, 0.00091)), new(0.000416d, new GammaParticle(1363400.0, 0.00091)), new(0.000936d, new GammaParticle(1364700.0, 0.00091)), new(0.00338d, new GammaParticle(1380900.0, 0.0009)), new(0.0034839999999999997d, new GammaParticle(1386300.0, 0.00089)), new(0.010764000000000001d, new GammaParticle(1390330.0, 0.00089)), new(0.000468d, new GammaParticle(1393900.0, 0.00089)), new(0.002392d, new GammaParticle(1397400.0, 0.00089)), new(0.000832d, new GammaParticle(1407200.0, 0.00088)), new(0.0078000000000000005d, new GammaParticle(1415900.0, 0.00088)), new(0.004784d, new GammaParticle(1416800.0, 0.00088)), new(0.003536d, new GammaParticle(1423000.0, 0.00087)), new(0.000832d, new GammaParticle(1423300.0, 0.00087)), new(0.00104d, new GammaParticle(1425900.0, 0.00087)), new(0.0052d, new GammaParticle(1432800.0, 0.00087)), new(0.002444d, new GammaParticle(1435700.0, 0.00086)), new(0.001144d, new GammaParticle(1450000.0, 0.00086)), new(0.00078d, new GammaParticle(1450000.0, 0.00086)), new(0.013000000000000001d, new GammaParticle(1453650.0, 0.00085)), new(0.001144d, new GammaParticle(1460500.0, 0.00085)), new(0.00052d, new GammaParticle(1467100.0, 0.00085)), new(0.000988d, new GammaParticle(1469900.0, 0.00084)), new(0.013000000000000001d, new GammaParticle(1471500.0, 0.00084)), new(0.002912d, new GammaParticle(1474200.0, 0.00084)), new(0.001456d, new GammaParticle(1478700.0, 0.00084)), new(0.00156d, new GammaParticle(1482700.0, 0.00084)), new(0.0014039999999999999d, new GammaParticle(1485200.0, 0.00083)), new(0.0028079999999999997d, new GammaParticle(1486400.0, 0.00083)), new(0.00104d, new GammaParticle(1493800.0, 0.00083)), new(0.0015079999999999998d, new GammaParticle(1494500.0, 0.00083)), new(0.0032240000000000003d, new GammaParticle(1499600.0, 0.00083)), new(0.0013d, new GammaParticle(1518700.0, 0.00082)), new(0.001976d, new GammaParticle(1523000.0, 0.00081)), new(0.003328d, new GammaParticle(1526100.0, 0.00081)), new(0.007904d, new GammaParticle(1529400.0, 0.00081)), new(0.0025480000000000004d, new GammaParticle(1536000.0, 0.00081)), new(0.002132d, new GammaParticle(1538000.0, 0.00081)), new(0.00416d, new GammaParticle(1542100.0, 0.0008)), new(0.002652d, new GammaParticle(1542200.0, 0.0008)), new(0.007488d, new GammaParticle(1545800.0, 0.0008)), new(0.001456d, new GammaParticle(1565000.0, 0.00079)), new(0.000676d, new GammaParticle(1572000.0, 0.00079)), new(0.000416d, new GammaParticle(1572500.0, 0.00079)), new(0.000572d, new GammaParticle(1580300.0, 0.00078)), new(0.000728d, new GammaParticle(1583200.0, 0.00078)), new(0.0013d, new GammaParticle(1598700.0, 0.00078)), new(0.000832d, new GammaParticle(1601400.0, 0.00077)), new(0.000728d, new GammaParticle(1609100.0, 0.00077)), new(0.000832d, new GammaParticle(1626800.0, 0.00076)), new(0.000416d, new GammaParticle(1630600.0, 0.00076)), new(0.005719999999999999d, new GammaParticle(1634600.0, 0.00076)), new(0.001248d, new GammaParticle(1643500.0, 0.00075)), new(0.000988d, new GammaParticle(1648100.0, 0.00075)), new(0.007124d, new GammaParticle(1649700.0, 0.00075)), new(0.000728d, new GammaParticle(1654000.0, 0.00075)), new(0.002704d, new GammaParticle(1663300.0, 0.00075)), new(0.001664d, new GammaParticle(1668700.0, 0.00074)), new(0.000988d, new GammaParticle(1681700.0, 0.00074)), new(0.00156d, new GammaParticle(1685400.0, 0.00074)), new(0.000364d, new GammaParticle(1688200.0, 0.00073)), new(0.00104d, new GammaParticle(1706100.0, 0.00073)), new(0.002964d, new GammaParticle(1730100.0, 0.00072)), new(0.000936d, new GammaParticle(1735700.0, 0.00071)), new(0.001872d, new GammaParticle(1741500.0, 0.00071)), new(0.00182d, new GammaParticle(1758300.0, 0.00071)), new(0.0016120000000000002d, new GammaParticle(1760100.0, 0.0007)), new(0.0026d, new GammaParticle(1791900.0, 0.00069)), new(0.002184d, new GammaParticle(1795600.0, 0.00069)), new(0.000676d, new GammaParticle(1796000.0, 0.00069)), new(0.00052d, new GammaParticle(1801400.0, 0.00069)), new(0.000468d, new GammaParticle(1814400.0, 0.00068)), new(0.003276d, new GammaParticle(1824700.0, 0.00068)), new(0.00104d, new GammaParticle(1824700.0, 0.00068)), new(0.001144d, new GammaParticle(1840500.0, 0.00067)), new(0.000156d, new GammaParticle(1841900.0, 0.00067)), new(0.000884d, new GammaParticle(1844500.0, 0.00067)), new(0.0042120000000000005d, new GammaParticle(1860100.0, 0.00067)), new(0.000728d, new GammaParticle(1866800.0, 0.00066)), new(0.000832d, new GammaParticle(1869900.0, 0.00066)), new(0.001092d, new GammaParticle(1872900.0, 0.00066)), new(0.0014039999999999999d, new GammaParticle(1888800.0, 0.00066)), new(0.0020280000000000003d, new GammaParticle(1899800.0, 0.00065)), new(0.002184d, new GammaParticle(1902500.0, 0.00065)), new(0.001664d, new GammaParticle(1908900.0, 0.00065)), new(0.003172d, new GammaParticle(1919800.0, 0.00065)), new(0.0015079999999999998d, new GammaParticle(1921300.0, 0.00065)), new(0.000572d, new GammaParticle(1932000.0, 0.00064)), new(0.001248d, new GammaParticle(1952300.0, 0.00064)), new(0.000988d, new GammaParticle(1962400.0, 0.00063)), new(0.003068d, new GammaParticle(1967900.0, 0.00063)), new(0.000364d, new GammaParticle(1990000.0, 0.00062)), new(0.000364d, new GammaParticle(1994000.0, 0.00062)), new(0.001768d, new GammaParticle(2003700.0, 0.00062)), new(0.00052d, new GammaParticle(2004200.0, 0.00062)), new(0.002184d, new GammaParticle(2014900.0, 0.00062)), new(0.00208d, new GammaParticle(2027000.0, 0.00061)), new(0.011284d, new GammaParticle(2029700.0, 0.00061)), new(0.00884d, new GammaParticle(2035000.0, 0.00061)), new(0.000572d, new GammaParticle(2039900.0, 0.00061)), new(0.001716d, new GammaParticle(2042400.0, 0.00061)), new(0.000988d, new GammaParticle(2048000.0, 0.00061)), new(0.003588d, new GammaParticle(2052800.0, 0.0006)), new(0.001196d, new GammaParticle(2063200.0, 0.0006)), new(0.00156d, new GammaParticle(2075500.0, 0.0006)), new(0.000728d, new GammaParticle(2078600.0, 0.0006)), new(0.0025480000000000004d, new GammaParticle(2085400.0, 0.00059)), new(0.001924d, new GammaParticle(2088200.0, 0.00059)), new(0.0016120000000000002d, new GammaParticle(2089100.0, 0.00059)), new(0.000884d, new GammaParticle(2101600.0, 0.00059)), new(0.00104d, new GammaParticle(2136000.0, 0.00058)), new(0.001196d, new GammaParticle(2168900.0, 0.00057)), new(0.0016120000000000002d, new GammaParticle(2169800.0, 0.00057)), new(0.0016120000000000002d, new GammaParticle(2185600.0, 0.00057)), new(0.000988d, new GammaParticle(2209200.0, 0.00056)), new(0.000884d, new GammaParticle(2216600.0, 0.00056)), new(0.00884d, new GammaParticle(2234200.0, 0.00055)), new(0.004004d, new GammaParticle(2238300.0, 0.00055)), new(0.001664d, new GammaParticle(2249000.0, 0.00055)), new(0.004576d, new GammaParticle(2271000.0, 0.00055)), new(0.001924d, new GammaParticle(2277400.0, 0.00054)), new(0.00078d, new GammaParticle(2286300.0, 0.00054)), new(0.00156d, new GammaParticle(2301600.0, 0.00054)), new(0.0014039999999999999d, new GammaParticle(2307400.0, 0.00054)), new(0.00078d, new GammaParticle(2321200.0, 0.00053)), new(0.001144d, new GammaParticle(2327500.0, 0.00053)), new(0.000676d, new GammaParticle(2339000.0, 0.00053)), new(0.00078d, new GammaParticle(2349300.0, 0.00053)), new(0.00468d, new GammaParticle(2354100.0, 0.00053)), new(0.0015079999999999998d, new GammaParticle(2365100.0, 0.00052)), new(0.001092d, new GammaParticle(2368900.0, 0.00052)), new(0.001768d, new GammaParticle(2373900.0, 0.00052)), new(0.000728d, new GammaParticle(2398100.0, 0.00052)), new(0.001976d, new GammaParticle(2406200.0, 0.00052)), new(0.00832d, new GammaParticle(2414200.0, 0.00051)), new(0.017159999999999998d, new GammaParticle(2419200.0, 0.00051)), new(0.003276d, new GammaParticle(2429500.0, 0.00051)), new(0.001092d, new GammaParticle(2434200.0, 0.00051)), new(0.001248d, new GammaParticle(2451000.0, 0.00051)), new(0.001092d, new GammaParticle(2480300.0, 0.0005)), new(0.000832d, new GammaParticle(2485900.0, 0.0005)), new(0.001092d, new GammaParticle(2490700.0, 0.0005)), new(0.001924d, new GammaParticle(2570800.0, 0.00048)), new(0.001716d, new GammaParticle(2577300.0, 0.00048)), new(0.001768d, new GammaParticle(2580100.0, 0.00048)), new(0.000988d, new GammaParticle(2589400.0, 0.00048)), new(0.000988d, new GammaParticle(2610500.0, 0.00047)), new(0.000884d, new GammaParticle(2724800.0, 0.00046)), new(0.0014039999999999999d, new GammaParticle(2753800.0, 0.00045)), new(0.00026d, new GammaParticle(2820600.0, 0.00044)), new(0.000624d, new GammaParticle(2825300.0, 0.00044)), new(0.001144d, new GammaParticle(2890800.0, 0.00043)), new(0.00052d, new GammaParticle(2893400.0, 0.00043)), new(0.000728d, new GammaParticle(3270600.0, 0.00038)), new(0.083d, new GammaParticle(7384.0, 0.16791)), new(0.081d, new GammaParticle(45207.0, 0.02743)), new(0.145d, new GammaParticle(45998.0, 0.02695)), new(0.047d, new GammaParticle(52220.0, 0.02374)), new(0.059000000000000004d, new GammaParticle(52791.0, 0.02349)), new(0.0121d, new GammaParticle(53478.0, 0.02318)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    