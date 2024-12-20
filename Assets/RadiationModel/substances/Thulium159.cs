using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium159";
        public override double halfLife { get; } = 547.8d;
        public override double atomicWeight { get; } = 158.93498d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium159()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.02528d, new GammaParticle(38320.0, 0.03235)), new(0.01456d, new GammaParticle(59290.0, 0.02091)), new(0.0004d, new GammaParticle(74880.0, 0.01656)), new(0.000832d, new GammaParticle(76130.0, 0.01629)), new(0.000832d, new GammaParticle(76130.0, 0.01629)), new(0.02128d, new GammaParticle(84980.0, 0.01459)), new(0.001168d, new GammaParticle(87090.0, 0.01424)), new(0.0028799999999999997d, new GammaParticle(88930.0, 0.01394)), new(9.599999999999999e-05d, new GammaParticle(91600.0, 0.01354)), new(0.00016d, new GammaParticle(94000.0, 0.01319)), new(0.00032d, new GammaParticle(105800.0, 0.01172)), new(0.00032d, new GammaParticle(112430.0, 0.01103)), new(0.0036d, new GammaParticle(114030.0, 0.01087)), new(0.0028799999999999997d, new GammaParticle(119820.0, 0.01035)), new(0.00832d, new GammaParticle(119820.0, 0.01035)), new(0.0004d, new GammaParticle(124400.0, 0.00997)), new(0.002d, new GammaParticle(127120.0, 0.00975)), new(0.012159999999999999d, new GammaParticle(127980.0, 0.00969)), new(0.0017280000000000002d, new GammaParticle(136800.0, 0.00906)), new(0.000528d, new GammaParticle(142230.0, 0.00872)), new(0.00624d, new GammaParticle(144240.0, 0.0086)), new(0.009439999999999999d, new GammaParticle(161090.0, 0.0077)), new(0.004719999999999999d, new GammaParticle(163040.0, 0.0076)), new(0.0008d, new GammaParticle(170750.0, 0.00726)), new(0.000336d, new GammaParticle(179570.0, 0.0069)), new(0.000224d, new GammaParticle(183000.0, 0.00678)), new(0.000528d, new GammaParticle(191210.0, 0.00648)), new(0.007039999999999999d, new GammaParticle(196620.0, 0.00631)), new(0.0044d, new GammaParticle(199060.0, 0.00623)), new(0.00096d, new GammaParticle(206800.0, 0.006)), new(0.0044800000000000005d, new GammaParticle(212230.0, 0.00584)), new(0.000544d, new GammaParticle(214130.0, 0.00579)), new(0.016d, new GammaParticle(220300.0, 0.00563)), new(0.0005920000000000001d, new GammaParticle(229060.0, 0.00541)), new(0.00344d, new GammaParticle(243270.0, 0.0051)), new(0.0005600000000000001d, new GammaParticle(246700.0, 0.00503)), new(0.0011200000000000001d, new GammaParticle(247700.0, 0.00501)), new(0.0036d, new GammaParticle(247870.0, 0.005)), new(0.0016d, new GammaParticle(252700.0, 0.00491)), new(0.00016d, new GammaParticle(262900.0, 0.00472)), new(0.000688d, new GammaParticle(267620.0, 0.00463)), new(0.01936d, new GammaParticle(271420.0, 0.00457)), new(0.00216d, new GammaParticle(284840.0, 0.00435)), new(0.01664d, new GammaParticle(289110.0, 0.00429)), new(0.00064d, new GammaParticle(296700.0, 0.00418)), new(0.00136d, new GammaParticle(307500.0, 0.00403)), new(0.00192d, new GammaParticle(313500.0, 0.00395)), new(0.0012959999999999998d, new GammaParticle(334750.0, 0.0037)), new(0.00024d, new GammaParticle(344650.0, 0.0036)), new(0.01264d, new GammaParticle(348400.0, 0.00356)), new(0.001248d, new GammaParticle(358940.0, 0.00345)), new(0.0005600000000000001d, new GammaParticle(361750.0, 0.00343)), new(0.001792d, new GammaParticle(367750.0, 0.00337)), new(0.0012d, new GammaParticle(372640.0, 0.00333)), new(0.00832d, new GammaParticle(374810.0, 0.00331)), new(0.00096d, new GammaParticle(395700.0, 0.00313)), new(0.00048d, new GammaParticle(401490.0, 0.00309)), new(0.00784d, new GammaParticle(408590.0, 0.00303)), new(0.001984d, new GammaParticle(415820.0, 0.00298)), new(0.001904d, new GammaParticle(422530.0, 0.00293)), new(0.000208d, new GammaParticle(429100.0, 0.00289)), new(0.0016d, new GammaParticle(434250.0, 0.00286)), new(0.002112d, new GammaParticle(434400.0, 0.00285)), new(0.00024d, new GammaParticle(439300.0, 0.00282)), new(0.001552d, new GammaParticle(445700.0, 0.00278)), new(0.003152d, new GammaParticle(450420.0, 0.00275)), new(0.001792d, new GammaParticle(453890.0, 0.00273)), new(0.0035199999999999997d, new GammaParticle(461840.0, 0.00268)), new(0.001056d, new GammaParticle(468280.0, 0.00265)), new(0.0014399999999999999d, new GammaParticle(473000.0, 0.00262)), new(0.002144d, new GammaParticle(482750.0, 0.00257)), new(0.001104d, new GammaParticle(485120.0, 0.00256)), new(0.00064d, new GammaParticle(496880.0, 0.0025)), new(0.002784d, new GammaParticle(501100.0, 0.00247)), new(0.00272d, new GammaParticle(518300.0, 0.00239)), new(0.0008d, new GammaParticle(525600.0, 0.00236)), new(0.0011200000000000001d, new GammaParticle(532200.0, 0.00233)), new(0.0014399999999999999d, new GammaParticle(534600.0, 0.00232)), new(0.00368d, new GammaParticle(541650.0, 0.00229)), new(0.00096d, new GammaParticle(549300.0, 0.00226)), new(0.00208d, new GammaParticle(558300.0, 0.00222)), new(0.00048d, new GammaParticle(559300.0, 0.00222)), new(0.0011200000000000001d, new GammaParticle(567000.0, 0.00219)), new(0.0004d, new GammaParticle(572500.0, 0.00217)), new(0.00064d, new GammaParticle(583500.0, 0.00212)), new(0.0004d, new GammaParticle(601200.0, 0.00206)), new(0.00096d, new GammaParticle(605300.0, 0.00205)), new(0.000528d, new GammaParticle(617100.0, 0.00201)), new(0.00096d, new GammaParticle(619300.0, 0.002)), new(0.00104d, new GammaParticle(634200.0, 0.00195)), new(0.00024d, new GammaParticle(642900.0, 0.00193)), new(0.00096d, new GammaParticle(690500.0, 0.0018)), new(0.00048d, new GammaParticle(693600.0, 0.00179)), new(0.00032d, new GammaParticle(703800.0, 0.00176)), new(0.0004d, new GammaParticle(713200.0, 0.00174)), new(0.0008d, new GammaParticle(729600.0, 0.0017)), new(0.00064d, new GammaParticle(733300.0, 0.00169)), new(0.00048d, new GammaParticle(737200.0, 0.00168)), new(0.00048d, new GammaParticle(740000.0, 0.00168)), new(0.00064d, new GammaParticle(755700.0, 0.00164)), new(0.00032d, new GammaParticle(757900.0, 0.00164)), new(0.0014399999999999999d, new GammaParticle(762100.0, 0.00163)), new(0.0008d, new GammaParticle(770600.0, 0.00161)), new(0.00064d, new GammaParticle(778700.0, 0.00159)), new(0.00064d, new GammaParticle(783700.0, 0.00158)), new(0.00024d, new GammaParticle(787100.0, 0.00158)), new(0.00064d, new GammaParticle(792300.0, 0.00156)), new(0.0004d, new GammaParticle(822400.0, 0.00151)), new(0.00096d, new GammaParticle(829300.0, 0.0015)), new(0.00064d, new GammaParticle(843200.0, 0.00147)), new(0.0011200000000000001d, new GammaParticle(857600.0, 0.00145)), new(0.00048d, new GammaParticle(888300.0, 0.0014)), new(0.0011200000000000001d, new GammaParticle(902300.0, 0.00137)), new(0.00064d, new GammaParticle(906100.0, 0.00137)), new(0.0011200000000000001d, new GammaParticle(921800.0, 0.00135)), new(0.00048d, new GammaParticle(933100.0, 0.00133)), new(0.0017599999999999998d, new GammaParticle(956200.0, 0.0013)), new(0.0008d, new GammaParticle(990800.0, 0.00125)), new(0.00048d, new GammaParticle(1059800.0, 0.00117)), new(0.00032d, new GammaParticle(1131900.0, 0.0011)), new(0.00192d, new GammaParticle(1135600.0, 0.00109)), new(0.00048d, new GammaParticle(1146100.0, 0.00108)), new(0.00024d, new GammaParticle(1168300.0, 0.00106)), new(0.00048d, new GammaParticle(1174500.0, 0.00106)), new(0.00048d, new GammaParticle(1190800.0, 0.00104)), new(0.00096d, new GammaParticle(1208200.0, 0.00103)), new(0.00096d, new GammaParticle(1211000.0, 0.00102)), new(0.0014399999999999999d, new GammaParticle(1247900.0, 0.00099)), new(0.0014399999999999999d, new GammaParticle(1261500.0, 0.00098)), new(0.0024d, new GammaParticle(1270100.0, 0.00098)), new(0.00208d, new GammaParticle(1297200.0, 0.00096)), new(0.00208d, new GammaParticle(1355500.0, 0.00091)), new(0.001168d, new GammaParticle(1392700.0, 0.00089)), new(0.001136d, new GammaParticle(1400940.0, 0.00089)), new(0.000288d, new GammaParticle(1402700.0, 0.00088)), new(0.00208d, new GammaParticle(1427100.0, 0.00087)), new(0.0004d, new GammaParticle(1437740.0, 0.00086)), new(0.00043200000000000004d, new GammaParticle(1441820.0, 0.00086)), new(0.00016d, new GammaParticle(1455600.0, 0.00085)), new(0.001008d, new GammaParticle(1459470.0, 0.00085)), new(0.0009760000000000001d, new GammaParticle(1466450.0, 0.00085)), new(0.00035999999999999997d, new GammaParticle(1469820.0, 0.00084)), new(0.000544d, new GammaParticle(1476150.0, 0.00084)), new(0.00019040000000000002d, new GammaParticle(1483940.0, 0.00084)), new(0.0004496d, new GammaParticle(1496460.0, 0.00083)), new(0.0006016d, new GammaParticle(1500140.0, 0.00083)), new(0.00040480000000000003d, new GammaParticle(1507380.0, 0.00082)), new(0.00038399999999999996d, new GammaParticle(1513260.0, 0.00082)), new(0.00025760000000000003d, new GammaParticle(1528810.0, 0.00081)), new(0.00208d, new GammaParticle(1553200.0, 0.0008)), new(0.000688d, new GammaParticle(1582590.0, 0.00078)), new(0.000256d, new GammaParticle(1591170.0, 0.00078)), new(0.0005920000000000001d, new GammaParticle(1595150.0, 0.00078)), new(0.0006704d, new GammaParticle(1598920.0, 0.00078)), new(0.0011840000000000002d, new GammaParticle(1602660.0, 0.00077)), new(0.000368d, new GammaParticle(1610220.0, 0.00077)), new(0.00039359999999999997d, new GammaParticle(1645820.0, 0.00075)), new(0.0001104d, new GammaParticle(1652700.0, 0.00075)), new(0.0001696d, new GammaParticle(1659300.0, 0.00075)), new(0.0002384d, new GammaParticle(1666880.0, 0.00074)), new(0.000256d, new GammaParticle(1686000.0, 0.00074)), new(0.000896d, new GammaParticle(1715410.0, 0.00072)), new(0.000304d, new GammaParticle(1722330.0, 0.00072)), new(0.000224d, new GammaParticle(1734100.0, 0.00071)), new(0.00021600000000000002d, new GammaParticle(1741360.0, 0.00071)), new(0.000448d, new GammaParticle(1749420.0, 0.00071)), new(0.000448d, new GammaParticle(1752750.0, 0.00071)), new(0.000608d, new GammaParticle(1761960.0, 0.0007)), new(0.000416d, new GammaParticle(1774940.0, 0.0007)), new(0.0005312d, new GammaParticle(1806630.0, 0.00069)), new(0.0003792d, new GammaParticle(1810940.0, 0.00068)), new(0.00016480000000000002d, new GammaParticle(1814670.0, 0.00068)), new(0.00016d, new GammaParticle(1828800.0, 0.00068)), new(0.0030399999999999997d, new GammaParticle(1838800.0, 0.00067)), new(0.0001408d, new GammaParticle(1856990.0, 0.00067)), new(0.000256d, new GammaParticle(1861830.0, 0.00067)), new(0.0004d, new GammaParticle(1864440.0, 0.00066)), new(0.00272d, new GammaParticle(1891000.0, 0.00066)), new(0.0003136d, new GammaParticle(1916530.0, 0.00065)), new(0.0003504d, new GammaParticle(1919340.0, 0.00065)), new(0.00104d, new GammaParticle(1924400.0, 0.00064)), new(0.0004656d, new GammaParticle(1927150.0, 0.00064)), new(0.0002144d, new GammaParticle(1935900.0, 0.00064)), new(0.0005920000000000001d, new GammaParticle(1938990.0, 0.00064)), new(0.0001072d, new GammaParticle(1943100.0, 0.00064)), new(0.0003648d, new GammaParticle(1951770.0, 0.00064)), new(0.00027519999999999997d, new GammaParticle(1956640.0, 0.00063)), new(0.001968d, new GammaParticle(1961400.0, 0.00063)), new(0.0001424d, new GammaParticle(1974400.0, 0.00063)), new(0.0003792d, new GammaParticle(1978340.0, 0.00063)), new(0.00043200000000000004d, new GammaParticle(1984110.0, 0.00062)), new(0.000256d, new GammaParticle(1990230.0, 0.00062)), new(0.000128d, new GammaParticle(1997500.0, 0.00062)), new(0.00272d, new GammaParticle(2002600.0, 0.00062)), new(0.0004d, new GammaParticle(2024870.0, 0.00061)), new(0.0004927999999999999d, new GammaParticle(2031790.0, 0.00061)), new(0.00016d, new GammaParticle(2086030.0, 0.00059)), new(0.0011200000000000001d, new GammaParticle(2090600.0, 0.00059)), new(0.00016639999999999998d, new GammaParticle(2095130.0, 0.00059)), new(6.720000000000001e-05d, new GammaParticle(2110800.0, 0.00059)), new(0.000416d, new GammaParticle(2116350.0, 0.00059)), new(0.000304d, new GammaParticle(2131510.0, 0.00058)), new(0.0002288d, new GammaParticle(2157600.0, 0.00057)), new(0.0003744d, new GammaParticle(2169260.0, 0.00057)), new(0.0002288d, new GammaParticle(2173320.0, 0.00057)), new(0.00128d, new GammaParticle(2177230.0, 0.00057)), new(0.0003008d, new GammaParticle(2189290.0, 0.00057)), new(0.0001504d, new GammaParticle(2195700.0, 0.00056)), new(0.0001504d, new GammaParticle(2202200.0, 0.00056)), new(0.0014080000000000002d, new GammaParticle(2208710.0, 0.00056)), new(0.001024d, new GammaParticle(2223280.0, 0.00056)), new(0.000224d, new GammaParticle(2227900.0, 0.00056)), new(0.0001792d, new GammaParticle(2235790.0, 0.00055)), new(0.00028639999999999997d, new GammaParticle(2241260.0, 0.00055)), new(0.0003088d, new GammaParticle(2246900.0, 0.00055)), new(0.0003712d, new GammaParticle(2251130.0, 0.00055)), new(0.00022239999999999998d, new GammaParticle(2255860.0, 0.00055)), new(0.00018079999999999998d, new GammaParticle(2259980.0, 0.00055)), new(0.0002992d, new GammaParticle(2265320.0, 0.00055)), new(0.00025760000000000003d, new GammaParticle(2273090.0, 0.00055)), new(0.0001712d, new GammaParticle(2279110.0, 0.00054)), new(0.0003424d, new GammaParticle(2284280.0, 0.00054)), new(0.0002992d, new GammaParticle(2298630.0, 0.00054)), new(0.0002208d, new GammaParticle(2303270.0, 0.00054)), new(0.0002288d, new GammaParticle(2309530.0, 0.00054)), new(0.0004016d, new GammaParticle(2324290.0, 0.00053)), new(0.0005936d, new GammaParticle(2332090.0, 0.00053)), new(0.0003744d, new GammaParticle(2337210.0, 0.00053)), new(0.0001984d, new GammaParticle(2343200.0, 0.00053)), new(0.0001472d, new GammaParticle(2368440.0, 0.00052)), new(9.12e-05d, new GammaParticle(2377000.0, 0.00052)), new(0.0002192d, new GammaParticle(2381120.0, 0.00052)), new(0.0001584d, new GammaParticle(2408380.0, 0.00051)), new(0.00024639999999999997d, new GammaParticle(2411380.0, 0.00051)), new(0.0009071999999999999d, new GammaParticle(2422330.0, 0.00051)), new(0.00013440000000000001d, new GammaParticle(2430740.0, 0.00051)), new(0.000144d, new GammaParticle(2434200.0, 0.00051)), new(0.00017600000000000002d, new GammaParticle(2436300.0, 0.00051)), new(0.0006d, new GammaParticle(2439970.0, 0.00051)), new(0.0001696d, new GammaParticle(2466820.0, 0.0005)), new(0.0001264d, new GammaParticle(2470720.0, 0.0005)), new(0.0001488d, new GammaParticle(2508010.0, 0.00049)), new(6.720000000000001e-05d, new GammaParticle(2515400.0, 0.00049)), new(7.68e-05d, new GammaParticle(2521500.0, 0.00049)), new(0.00012d, new GammaParticle(2540370.0, 0.00049)), new(0.0001552d, new GammaParticle(2549620.0, 0.00049)), new(8.48e-05d, new GammaParticle(2600600.0, 0.00048)), new(0.0001264d, new GammaParticle(2615210.0, 0.00047)), new(8.319999999999999e-05d, new GammaParticle(2624320.0, 0.00047)), new(0.0001424d, new GammaParticle(2644700.0, 0.00047)), new(0.0001088d, new GammaParticle(2651800.0, 0.00047)), new(0.0001712d, new GammaParticle(2659730.0, 0.00047)), new(0.0001264d, new GammaParticle(2721330.0, 0.00046)), new(6.720000000000001e-05d, new GammaParticle(2731000.0, 0.00045)), new(6.08e-05d, new GammaParticle(2734200.0, 0.00045)), new(0.0014399999999999999d, new GammaParticle(2775000.0, 0.00045)), new(7.2e-05d, new GammaParticle(2864300.0, 0.00043)), new(0.2811d, new GammaParticle(511000.0, 0.00243)), new(0.107d, new GammaParticle(7933.0, 0.15629)), new(0.12300000000000001d, new GammaParticle(48222.0, 0.02571)), new(0.218d, new GammaParticle(49128.0, 0.02524)), new(0.0709d, new GammaParticle(55779.0, 0.02223)), new(0.08900000000000001d, new GammaParticle(56399.0, 0.02198)), new(0.0184d, new GammaParticle(57145.0, 0.0217)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 5000.0d, 0.000000000234944d },
            { 10000.0d, 0.000000014263d },
            { 15000.0d, 0.0000000439742d },
            { 20000.0d, 0.000000096408d },
            { 25000.0d, 0.00000017943d },
            { 30000.0d, 0.000000295314d },
            { 35000.0d, 0.00000044604d },
            { 40000.0d, 0.00000063195d },
            { 45000.0d, 0.000000852802d },
            { 50000.0d, 0.00000110712d },
            { 55000.0d, 0.00000139421d },
            { 60000.0d, 0.00000171149d },
            { 65000.0d, 0.00000205824d },
            { 70000.0d, 0.00000243172d },
            { 75000.0d, 0.00000283069d },
            { 80000.0d, 0.00000325342d },
            { 85000.0d, 0.0000036975d },
            { 90000.0d, 0.00000416244d },
            { 95000.0d, 0.00000464535d },
            { 100000.0d, 0.00000514599d },
            { 109000.0d, 0.00000608592d },
            { 118000.0d, 0.00000707005d },
            { 127000.0d, 0.00000809198d },
            { 136000.0d, 0.0000091461d },
            { 145000.0d, 0.0000102275d },
            { 154000.0d, 0.0000113318d },
            { 163000.0d, 0.0000124552d },
            { 172000.0d, 0.0000135946d },
            { 181000.0d, 0.0000147468d },
            { 190000.0d, 0.0000159094d },
            { 199000.0d, 0.00001708d },
            { 208000.0d, 0.0000182567d },
            { 217000.0d, 0.0000194376d },
            { 226000.0d, 0.0000206211d },
            { 235000.0d, 0.0000218058d },
            { 244000.0d, 0.0000229904d },
            { 253000.0d, 0.0000241738d },
            { 262000.0d, 0.0000253549d },
            { 271000.0d, 0.0000265329d },
            { 280000.0d, 0.0000277069d },
            { 289000.0d, 0.000028876d },
            { 298000.0d, 0.0000300397d },
            { 307000.0d, 0.0000311973d },
            { 316000.0d, 0.0000323481d },
            { 325000.0d, 0.0000334918d },
            { 334000.0d, 0.0000346277d },
            { 343000.0d, 0.0000357556d },
            { 352000.0d, 0.0000368749d },
            { 361000.0d, 0.0000379852d },
            { 370000.0d, 0.0000390863d },
            { 379000.0d, 0.0000401778d },
            { 388000.0d, 0.0000412593d },
            { 397000.0d, 0.0000423308d },
            { 406000.0d, 0.0000433918d },
            { 415000.0d, 0.0000444421d },
            { 424000.0d, 0.0000454816d },
            { 433000.0d, 0.0000465099d },
            { 442000.0d, 0.0000475269d },
            { 451000.0d, 0.0000485324d },
            { 460000.0d, 0.0000495263d },
            { 469000.0d, 0.0000505084d },
            { 478000.0d, 0.0000514785d },
            { 487000.0d, 0.0000524365d },
            { 496000.0d, 0.0000533822d },
            { 505000.0d, 0.0000543155d },
            { 514000.0d, 0.0000552364d },
            { 523000.0d, 0.0000561446d },
            { 532000.0d, 0.0000570401d },
            { 541000.0d, 0.0000579229d },
            { 550000.0d, 0.0000587926d },
            { 559000.0d, 0.0000596494d },
            { 568000.0d, 0.0000604931d },
            { 577000.0d, 0.0000613236d },
            { 586000.0d, 0.0000621409d },
            { 595000.0d, 0.0000629449d },
            { 604000.0d, 0.0000637354d },
            { 613000.0d, 0.0000645126d },
            { 622000.0d, 0.0000652762d },
            { 631000.0d, 0.0000660263d },
            { 640000.0d, 0.0000667628d },
            { 649000.0d, 0.0000674856d },
            { 658000.0d, 0.0000681948d },
            { 667000.0d, 0.0000688901d },
            { 676000.0d, 0.0000695718d },
            { 685000.0d, 0.0000702395d },
            { 694000.0d, 0.0000708934d },
            { 703000.0d, 0.0000715335d },
            { 712000.0d, 0.0000721596d },
            { 721000.0d, 0.000072772d },
            { 730000.0d, 0.0000733702d },
            { 739000.0d, 0.0000739544d },
            { 748000.0d, 0.0000745248d },
            { 757000.0d, 0.0000750811d },
            { 766000.0d, 0.0000756233d },
            { 775000.0d, 0.0000761517d },
            { 784000.0d, 0.0000766659d },
            { 793000.0d, 0.0000771661d },
            { 802000.0d, 0.0000776522d },
            { 811000.0d, 0.0000781244d },
            { 820000.0d, 0.0000785825d },
            { 829000.0d, 0.0000790266d },
            { 838000.0d, 0.0000794566d },
            { 847000.0d, 0.0000798726d },
            { 856000.0d, 0.0000802748d },
            { 865000.0d, 0.0000806627d },
            { 874000.0d, 0.0000810368d },
            { 883000.0d, 0.000081397d },
            { 892000.0d, 0.0000817431d },
            { 901000.0d, 0.0000820752d },
            { 910000.0d, 0.0000823936d },
            { 919000.0d, 0.0000826981d },
            { 928000.0d, 0.0000829888d },
            { 937000.0d, 0.0000832654d },
            { 946000.0d, 0.0000835286d },
            { 955000.0d, 0.0000837776d },
            { 964000.0d, 0.0000840132d },
            { 973000.0d, 0.0000842351d },
            { 982000.0d, 0.0000844432d },
            { 991000.0d, 0.0000846379d },
            { 1000000.0d, 0.0000848189d },
            { 1009000.0d, 0.0000849864d },
            { 1018000.0d, 0.0000851404d },
            { 1027000.0d, 0.0000852809d },
            { 1036000.0d, 0.0000854081d },
            { 1045000.0d, 0.000085522d },
            { 1054000.0d, 0.0000856226d },
            { 1063000.0d, 0.0000857099d },
            { 1072000.0d, 0.0000857842d },
            { 1081000.0d, 0.0000858453d },
            { 1090000.0d, 0.0000858932d },
            { 1099000.0d, 0.0000859283d },
            { 1108000.0d, 0.0000859505d },
            { 1117000.0d, 0.0000859597d },
            { 1126000.0d, 0.0000859561d },
            { 1135000.0d, 0.0000859399d },
            { 1144000.0d, 0.000085911d },
            { 1153000.0d, 0.0000858695d },
            { 1162000.0d, 0.0000858155d },
            { 1171000.0d, 0.0000857491d },
            { 1180000.0d, 0.0000856703d },
            { 1189000.0d, 0.0000855792d },
            { 1198000.0d, 0.000085476d },
            { 1207000.0d, 0.0000853606d },
            { 1216000.0d, 0.0000852331d },
            { 1225000.0d, 0.0000850938d },
            { 1234000.0d, 0.0000849425d },
            { 1243000.0d, 0.0000847797d },
            { 1252000.0d, 0.000084605d },
            { 1261000.0d, 0.0000844187d },
            { 1270000.0d, 0.0000842211d },
            { 1279000.0d, 0.000084012d },
            { 1288000.0d, 0.0000837915d },
            { 1297000.0d, 0.0000835599d },
            { 1306000.0d, 0.0000833172d },
            { 1315000.0d, 0.0000830635d },
            { 1324000.0d, 0.0000827989d },
            { 1333000.0d, 0.0000825236d },
            { 1342000.0d, 0.0000822375d },
            { 1351000.0d, 0.0000819409d },
            { 1360000.0d, 0.0000816339d },
            { 1369000.0d, 0.0000813165d },
            { 1378000.0d, 0.0000809888d },
            { 1387000.0d, 0.0000806511d },
            { 1396000.0d, 0.0000803033d },
            { 1405000.0d, 0.0000799457d },
            { 1414000.0d, 0.0000795783d },
            { 1423000.0d, 0.0000792014d },
            { 1432000.0d, 0.0000788149d },
            { 1441000.0d, 0.0000784188d },
            { 1450000.0d, 0.0000780138d },
            { 1459000.0d, 0.0000775995d },
            { 1468000.0d, 0.0000771762d },
            { 1477000.0d, 0.0000767441d },
            { 1486000.0d, 0.0000763032d },
            { 1495000.0d, 0.0000758536d },
            { 1504000.0d, 0.0000753957d },
            { 1513000.0d, 0.0000749296d },
            { 1522000.0d, 0.0000744551d },
            { 1531000.0d, 0.0000739727d },
            { 1540000.0d, 0.0000734823d },
            { 1549000.0d, 0.0000729842d },
            { 1558000.0d, 0.0000724785d },
            { 1567000.0d, 0.0000719653d },
            { 1576000.0d, 0.0000714449d },
            { 1585000.0d, 0.0000709172d },
            { 1594000.0d, 0.0000703826d },
            { 1603000.0d, 0.0000698411d },
            { 1612000.0d, 0.000069293d },
            { 1621000.0d, 0.0000687384d },
            { 1630000.0d, 0.0000681772d },
            { 1639000.0d, 0.00006761d },
            { 1648000.0d, 0.0000670366d },
            { 1657000.0d, 0.0000664575d },
            { 1666000.0d, 0.0000658724d },
            { 1675000.0d, 0.0000652817d },
            { 1684000.0d, 0.0000646852d },
            { 1693000.0d, 0.0000640832d },
            { 1702000.0d, 0.0000634761d },
            { 1711000.0d, 0.0000628637d },
            { 1720000.0d, 0.0000622463d },
            { 1729000.0d, 0.0000616243d },
            { 1738000.0d, 0.0000609974d },
            { 1747000.0d, 0.0000603662d },
            { 1756000.0d, 0.0000597308d },
            { 1765000.0d, 0.0000590913d },
            { 1774000.0d, 0.0000584478d },
            { 1783000.0d, 0.0000578006d },
            { 1792000.0d, 0.0000571498d },
            { 1801000.0d, 0.0000564953d },
            { 1810000.0d, 0.0000558375d },
            { 1819000.0d, 0.0000551765d },
            { 1828000.0d, 0.0000545124d },
            { 1837000.0d, 0.0000538453d },
            { 1846000.0d, 0.0000531756d },
            { 1855000.0d, 0.0000525035d },
            { 1864000.0d, 0.000051829d },
            { 1873000.0d, 0.0000511525d },
            { 1882000.0d, 0.0000504739d },
            { 1891000.0d, 0.0000497937d },
            { 1900000.0d, 0.000049112d },
            { 1909000.0d, 0.0000484289d },
            { 1918000.0d, 0.0000477447d },
            { 1927000.0d, 0.0000470595d },
            { 1936000.0d, 0.0000463734d },
            { 1945000.0d, 0.0000456865d },
            { 1954000.0d, 0.0000449989d },
            { 1963000.0d, 0.0000443109d },
            { 1972000.0d, 0.0000436228d },
            { 1981000.0d, 0.0000429346d },
            { 1990000.0d, 0.0000422465d },
            { 1999000.0d, 0.0000415587d },
            { 2008000.0d, 0.0000408714d },
            { 2017000.0d, 0.0000401846d },
            { 2026000.0d, 0.0000394981d },
            { 2035000.0d, 0.0000388119d },
            { 2044000.0d, 0.0000381264d },
            { 2053000.0d, 0.0000374417d },
            { 2062000.0d, 0.000036758d },
            { 2071000.0d, 0.0000360755d },
            { 2080000.0d, 0.0000353944d },
            { 2089000.0d, 0.0000347149d },
            { 2098000.0d, 0.0000340369d },
            { 2107000.0d, 0.0000333607d },
            { 2116000.0d, 0.0000326865d },
            { 2125000.0d, 0.0000320145d },
            { 2134000.0d, 0.0000313448d },
            { 2143000.0d, 0.0000306776d },
            { 2152000.0d, 0.0000300133d },
            { 2161000.0d, 0.0000293519d },
            { 2170000.0d, 0.0000286938d },
            { 2179000.0d, 0.0000280391d },
            { 2188000.0d, 0.000027388d },
            { 2197000.0d, 0.0000267406d },
            { 2206000.0d, 0.0000260971d },
            { 2215000.0d, 0.0000254578d },
            { 2224000.0d, 0.0000248229d },
            { 2233000.0d, 0.0000241926d },
            { 2242000.0d, 0.000023567d },
            { 2251000.0d, 0.0000229465d },
            { 2260000.0d, 0.0000223312d },
            { 2269000.0d, 0.0000217213d },
            { 2278000.0d, 0.0000211167d },
            { 2287000.0d, 0.0000205179d },
            { 2296000.0d, 0.000019925d },
            { 2305000.0d, 0.0000193382d },
            { 2314000.0d, 0.0000187578d },
            { 2323000.0d, 0.000018184d },
            { 2332000.0d, 0.000017617d },
            { 2341000.0d, 0.000017057d },
            { 2350000.0d, 0.0000165043d },
            { 2359000.0d, 0.0000159591d },
            { 2368000.0d, 0.0000154214d },
            { 2377000.0d, 0.000014891d },
            { 2386000.0d, 0.0000143684d },
            { 2395000.0d, 0.0000138536d },
            { 2404000.0d, 0.000013347d },
            { 2413000.0d, 0.0000128487d },
            { 2422000.0d, 0.0000123586d },
            { 2431000.0d, 0.0000118771d },
            { 2440000.0d, 0.0000114042d },
            { 2449000.0d, 0.0000109403d },
            { 2458000.0d, 0.0000104855d },
            { 2467000.0d, 0.0000100401d },
            { 2476000.0d, 0.00000960433d },
            { 2485000.0d, 0.00000917841d },
            { 2494000.0d, 0.00000876258d },
            { 2503000.0d, 0.00000835707d },
            { 2512000.0d, 0.00000796194d },
            { 2521000.0d, 0.00000757658d },
            { 2530000.0d, 0.00000720111d },
            { 2539000.0d, 0.00000683567d },
            { 2548000.0d, 0.00000648051d },
            { 2557000.0d, 0.0000061358d },
            { 2566000.0d, 0.0000058018d },
            { 2575000.0d, 0.00000547873d },
            { 2584000.0d, 0.0000051668d },
            { 2593000.0d, 0.00000486625d },
            { 2602000.0d, 0.00000457731d },
            { 2611000.0d, 0.00000430017d },
            { 2620000.0d, 0.00000403509d },
            { 2629000.0d, 0.0000037822d },
            { 2638000.0d, 0.00000354001d },
            { 2647000.0d, 0.00000330793d },
            { 2656000.0d, 0.00000308615d },
            { 2665000.0d, 0.00000287489d },
            { 2674000.0d, 0.00000267403d },
            { 2683000.0d, 0.00000248219d },
            { 2692000.0d, 0.0000022989d },
            { 2701000.0d, 0.00000212435d },
            { 2710000.0d, 0.00000195834d },
            { 2719000.0d, 0.00000179992d },
            { 2728000.0d, 0.00000164886d },
            { 2737000.0d, 0.00000150516d },
            { 2746000.0d, 0.00000136895d },
            { 2755000.0d, 0.00000124035d },
            { 2764000.0d, 0.00000111901d },
            { 2773000.0d, 0.00000100457d },
            { 2782000.0d, 0.000000897154d },
            { 2791000.0d, 0.000000796873d },
            { 2800000.0d, 0.000000703841d },
            { 2809000.0d, 0.000000618168d },
            { 2818000.0d, 0.000000539966d },
            { 2827000.0d, 0.000000469339d },
            { 2836000.0d, 0.000000405893d },
            { 2845000.0d, 0.00000034738d },
            { 2854000.0d, 0.000000293565d },
            { 2863000.0d, 0.00000024452d },
            { 2872000.0d, 0.000000200319d },
            { 2881000.0d, 0.00000016103d },
            { 2890000.0d, 0.000000126724d },
            { 2899000.0d, 0.0000000974688d },
            { 2908000.0d, 0.0000000733308d },
            { 2917000.0d, 0.0000000543481d },
            { 2926000.0d, 0.0000000389244d },
            { 2935000.0d, 0.0000000260211d },
            { 2944000.0d, 0.0000000156719d },
            { 2953000.0d, 0.0000000079091d },
            { 2962000.0d, 0.00000000276329d },
            { 2971000.0d, 0.000000000260289d },
            { 2975000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    