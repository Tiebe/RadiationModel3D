using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine132 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine132";
        public override double halfLife { get; } = 8262.0d;
        public override double atomicWeight { get; } = 131.90799d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon132()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0007896d, new GammaParticle(136700.0, 0.00907)), new(0.0007896d, new GammaParticle(136700.0, 0.00907)), new(0.0023688d, new GammaParticle(147400.0, 0.00841)), new(0.0013817999999999999d, new GammaParticle(183600.0, 0.00675)), new(0.0008883000000000001d, new GammaParticle(194300.0, 0.00638)), new(0.0002961d, new GammaParticle(234300.0, 0.00529)), new(0.0004935d, new GammaParticle(241200.0, 0.00514)), new(0.00017766d, new GammaParticle(250800.0, 0.00494)), new(0.00017766d, new GammaParticle(250800.0, 0.00494)), new(0.0023688d, new GammaParticle(255100.0, 0.00486)), new(0.0001974d, new GammaParticle(255100.0, 0.00486)), new(0.012830999999999999d, new GammaParticle(262900.0, 0.00472)), new(0.0003948d, new GammaParticle(278400.0, 0.00445)), new(0.0003948d, new GammaParticle(278400.0, 0.00445)), new(0.0071064000000000006d, new GammaParticle(284900.0, 0.00435)), new(0.00015792d, new GammaParticle(296500.0, 0.00418)), new(4.935e-05d, new GammaParticle(302000.0, 0.00411)), new(0.000987d, new GammaParticle(306700.0, 0.00404)), new(0.000987d, new GammaParticle(306700.0, 0.00404)), new(0.0008883000000000001d, new GammaParticle(310100.0, 0.004)), new(0.0008883000000000001d, new GammaParticle(310100.0, 0.004)), new(0.0012831000000000001d, new GammaParticle(316700.0, 0.00391)), new(0.0008883000000000001d, new GammaParticle(343700.0, 0.00361)), new(0.0004935d, new GammaParticle(355200.0, 0.00349)), new(0.0004935d, new GammaParticle(355200.0, 0.00349)), new(0.004935d, new GammaParticle(363340.0, 0.00341)), new(9.87e-05d, new GammaParticle(376600.0, 0.00329)), new(0.0029609999999999997d, new GammaParticle(387900.0, 0.0032)), new(0.0029609999999999997d, new GammaParticle(387900.0, 0.0032)), new(0.0029609999999999997d, new GammaParticle(387900.0, 0.0032)), new(0.00022700999999999998d, new GammaParticle(402600.0, 0.00308)), new(0.0047376d, new GammaParticle(416800.0, 0.00297)), new(0.0047376d, new GammaParticle(431800.0, 0.00287)), new(0.000987d, new GammaParticle(445000.0, 0.00279)), new(0.0060207d, new GammaParticle(446200.0, 0.00278)), new(0.0016779d, new GammaParticle(473600.0, 0.00262)), new(0.0016779d, new GammaParticle(478200.0, 0.00259)), new(0.0041454000000000005d, new GammaParticle(488000.0, 0.00254)), new(0.0041454000000000005d, new GammaParticle(488000.0, 0.00254)), new(0.04935d, new GammaParticle(505790.0, 0.00245)), new(0.159894d, new GammaParticle(522650.0, 0.00237)), new(0.0051324000000000005d, new GammaParticle(535400.0, 0.00232)), new(0.0010857d, new GammaParticle(539700.0, 0.0023)), new(0.0010857d, new GammaParticle(539700.0, 0.0023)), new(0.0113505d, new GammaParticle(547200.0, 0.00227)), new(0.0008883000000000001d, new GammaParticle(559700.0, 0.00222)), new(0.0005922d, new GammaParticle(572500.0, 0.00217)), new(0.0005922d, new GammaParticle(572500.0, 0.00217)), new(0.0006908999999999999d, new GammaParticle(591100.0, 0.0021)), new(0.0006908999999999999d, new GammaParticle(591100.0, 0.0021)), new(0.0012831000000000001d, new GammaParticle(600000.0, 0.00207)), new(0.0012831000000000001d, new GammaParticle(600000.0, 0.00207)), new(0.0003948d, new GammaParticle(609800.0, 0.00203)), new(0.003948d, new GammaParticle(620900.0, 0.002)), new(0.015792d, new GammaParticle(621200.0, 0.002)), new(0.133245d, new GammaParticle(630190.0, 0.00197)), new(0.00034544999999999997d, new GammaParticle(642400.0, 0.00193)), new(0.025661999999999997d, new GammaParticle(650500.0, 0.00191)), new(0.001974d, new GammaParticle(659000.0, 0.00188)), new(0.987d, new GammaParticle(667714.0, 0.00186)), new(0.04638899999999999d, new GammaParticle(669800.0, 0.00185)), new(0.034545d, new GammaParticle(671400.0, 0.00185)), new(0.0003948d, new GammaParticle(684400.0, 0.00181)), new(0.0003948d, new GammaParticle(687800.0, 0.0018)), new(0.0001974d, new GammaParticle(706400.0, 0.00176)), new(0.021714d, new GammaParticle(727000.0, 0.00171)), new(0.031584d, new GammaParticle(727200.0, 0.0017)), new(0.015792d, new GammaParticle(728400.0, 0.0017)), new(0.0001974d, new GammaParticle(771700.0, 0.00161)), new(0.7560420000000001d, new GammaParticle(772600.0, 0.0016)), new(0.011843999999999999d, new GammaParticle(780000.0, 0.00159)), new(0.0038493d, new GammaParticle(784400.0, 0.00158)), new(0.000987d, new GammaParticle(791200.0, 0.00157)), new(0.025661999999999997d, new GammaParticle(809500.0, 0.00153)), new(0.055271999999999995d, new GammaParticle(812000.0, 0.00153)), new(0.00024675d, new GammaParticle(831300.0, 0.00149)), new(0.00016779d, new GammaParticle(847900.0, 0.00146)), new(0.0056259000000000005d, new GammaParticle(863000.0, 0.00144)), new(0.00035532d, new GammaParticle(866000.0, 0.00143)), new(0.00035532d, new GammaParticle(866000.0, 0.00143)), new(0.010363500000000001d, new GammaParticle(876600.0, 0.00141)), new(0.00024675d, new GammaParticle(886100.0, 0.0014)), new(0.00034544999999999997d, new GammaParticle(888700.0, 0.0014)), new(0.00034544999999999997d, new GammaParticle(888700.0, 0.0014)), new(0.00012831d, new GammaParticle(904400.0, 0.00137)), new(0.009277800000000001d, new GammaParticle(910100.0, 0.00136)), new(0.0041454000000000005d, new GammaParticle(927400.0, 0.00134)), new(0.00044415000000000004d, new GammaParticle(947200.0, 0.00131)), new(0.175686d, new GammaParticle(954550.0, 0.0013)), new(0.00034544999999999997d, new GammaParticle(965800.0, 0.00128)), new(0.005921999999999999d, new GammaParticle(984200.0, 0.00126)), new(0.0002961d, new GammaParticle(995800.0, 0.00125)), new(0.00025662d, new GammaParticle(1002500.0, 0.00124)), new(0.00025662d, new GammaParticle(1002500.0, 0.00124)), new(0.00015792d, new GammaParticle(1005400.0, 0.00123)), new(0.00046389d, new GammaParticle(1009000.0, 0.00123)), new(0.0051324000000000005d, new GammaParticle(1035000.0, 0.0012)), new(0.00046389d, new GammaParticle(1049600.0, 0.00118)), new(0.00034544999999999997d, new GammaParticle(1081800.0, 0.00115)), new(0.00034544999999999997d, new GammaParticle(1081800.0, 0.00115)), new(0.0007896d, new GammaParticle(1086200.0, 0.00114)), new(0.00044415000000000004d, new GammaParticle(1096900.0, 0.00113)), new(0.0006514200000000001d, new GammaParticle(1112400.0, 0.00111)), new(0.0004935d, new GammaParticle(1126500.0, 0.0011)), new(0.0004935d, new GammaParticle(1126500.0, 0.0011)), new(0.0301035d, new GammaParticle(1136000.0, 0.00109)), new(0.0135219d, new GammaParticle(1143300.0, 0.00108)), new(0.0026649d, new GammaParticle(1147800.0, 0.00108)), new(0.010857d, new GammaParticle(1172900.0, 0.00106)), new(0.00016779d, new GammaParticle(1206700.0, 0.00103)), new(0.00011844d, new GammaParticle(1212300.0, 0.00102)), new(0.00011844d, new GammaParticle(1242600.0, 0.001)), new(0.0005922d, new GammaParticle(1254100.0, 0.00099)), new(0.00026649d, new GammaParticle(1263600.0, 0.00098)), new(0.0016779d, new GammaParticle(1272800.0, 0.00097)), new(0.011251800000000001d, new GammaParticle(1290800.0, 0.00096)), new(0.018753d, new GammaParticle(1295100.0, 0.00096)), new(0.008883d, new GammaParticle(1297910.0, 0.00096)), new(0.0005922d, new GammaParticle(1314000.0, 0.00094)), new(0.0011844d, new GammaParticle(1317918.0, 0.00094)), new(5.922e-05d, new GammaParticle(1360000.0, 0.00091)), new(0.024675d, new GammaParticle(1372070.0, 0.0009)), new(0.00014805d, new GammaParticle(1390700.0, 0.00089)), new(0.070077d, new GammaParticle(1398570.0, 0.00089)), new(0.00043428d, new GammaParticle(1410600.0, 0.00088)), new(0.0140154d, new GammaParticle(1442560.0, 0.00086)), new(7.896e-05d, new GammaParticle(1450000.0, 0.00086)), new(0.0004935d, new GammaParticle(1456500.0, 0.00085)), new(0.0013028400000000002d, new GammaParticle(1476700.0, 0.00084)), new(0.0007896d, new GammaParticle(1519600.0, 0.00082)), new(5.922e-05d, new GammaParticle(1531900.0, 0.00081)), new(0.00015792d, new GammaParticle(1542300.0, 0.0008)), new(8.883e-05d, new GammaParticle(1559000.0, 0.0008)), new(0.00047376d, new GammaParticle(1592900.0, 0.00078)), new(9.87e-05d, new GammaParticle(1617900.0, 0.00077)), new(6.909e-05d, new GammaParticle(1618900.0, 0.00077)), new(0.00011844d, new GammaParticle(1636500.0, 0.00076)), new(0.00011844d, new GammaParticle(1636500.0, 0.00076)), new(7.896e-05d, new GammaParticle(1639100.0, 0.00076)), new(0.00012831d, new GammaParticle(1644000.0, 0.00075)), new(0.00015792d, new GammaParticle(1661400.0, 0.00075)), new(0.00021714d, new GammaParticle(1671300.0, 0.00074)), new(5.922e-05d, new GammaParticle(1679300.0, 0.00074)), new(0.00055272d, new GammaParticle(1715400.0, 0.00072)), new(0.00054285d, new GammaParticle(1720600.0, 0.00072)), new(0.00067116d, new GammaParticle(1727200.0, 0.00072)), new(0.00024675d, new GammaParticle(1752300.0, 0.00071)), new(0.0029609999999999997d, new GammaParticle(1757400.0, 0.00071)), new(0.0005922d, new GammaParticle(1760400.0, 0.0007)), new(0.00024675d, new GammaParticle(1768500.0, 0.0007)), new(0.0007896d, new GammaParticle(1778500.0, 0.0007)), new(0.00010857d, new GammaParticle(1786500.0, 0.00069)), new(0.00010857d, new GammaParticle(1786500.0, 0.00069)), new(0.00015792d, new GammaParticle(1814000.0, 0.00068)), new(0.00027636d, new GammaParticle(1830100.0, 0.00068)), new(0.00013818d, new GammaParticle(1879200.0, 0.00066)), new(0.0002961d, new GammaParticle(1913700.0, 0.00065)), new(0.0123375d, new GammaParticle(1921080.0, 0.00065)), new(1.974e-05d, new GammaParticle(1925700.0, 0.00064)), new(4.935e-05d, new GammaParticle(1939500.0, 0.00064)), new(0.00011844d, new GammaParticle(1985625.0, 0.00062)), new(0.0113505d, new GammaParticle(2002200.0, 0.00062)), new(0.0025662000000000003d, new GammaParticle(2086820.0, 0.00059)), new(0.0020727000000000002d, new GammaParticle(2172680.0, 0.00057)), new(6.909e-05d, new GammaParticle(2187000.0, 0.00057)), new(2.961e-05d, new GammaParticle(2204200.0, 0.00056)), new(0.0011844d, new GammaParticle(2223170.0, 0.00056)), new(0.00033558d, new GammaParticle(2249100.0, 0.00055)), new(3.5532e-05d, new GammaParticle(2290600.0, 0.00054)), new(0.00014805d, new GammaParticle(2304400.0, 0.00054)), new(0.0018753d, new GammaParticle(2390480.0, 0.00052)), new(9.3765e-05d, new GammaParticle(2408600.0, 0.00051)), new(1.3818e-05d, new GammaParticle(2417100.0, 0.00051)), new(5.6259e-05d, new GammaParticle(2444000.0, 0.00051)), new(2.0726999999999997e-05d, new GammaParticle(2454800.0, 0.00051)), new(7.896e-06d, new GammaParticle(2487800.0, 0.0005)), new(0.0003948d, new GammaParticle(2525140.0, 0.00049)), new(1.5792e-05d, new GammaParticle(2546500.0, 0.00049)), new(4.935e-05d, new GammaParticle(2569800.0, 0.00048)), new(1.1843999999999999e-05d, new GammaParticle(2593800.0, 0.00048)), new(1.4805e-05d, new GammaParticle(2603200.0, 0.00048)), new(9.87e-06d, new GammaParticle(2607200.0, 0.00048)), new(3.5532e-05d, new GammaParticle(2614500.0, 0.00047)), new(9.87e-06d, new GammaParticle(2653800.0, 0.00047)), new(9.87e-06d, new GammaParticle(2690800.0, 0.00046)), new(3.4545e-05d, new GammaParticle(2717500.0, 0.00046)), new(8.883e-06d, new GammaParticle(2757800.0, 0.00045)), new(3.948e-06d, new GammaParticle(2766100.0, 0.00045)), new(0.0011899999999999999d, new GammaParticle(4540.0, 0.27309)), new(0.003d, new GammaParticle(29458.0, 0.04209)), new(0.00555d, new GammaParticle(29778.0, 0.04164)), new(0.00161d, new GammaParticle(33726.0, 0.03676)), new(0.00199d, new GammaParticle(34030.0, 0.03643)), new(0.00037999999999999997d, new GammaParticle(34414.0, 0.03603)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00119968d },
            { 600.0d, 0.001197d },
            { 1200.0d, 0.00119543d },
            { 1800.0d, 0.00119496d },
            { 2400.0d, 0.00119549d },
            { 3000.0d, 0.00119683d },
            { 3600.0d, 0.00119796d },
            { 4200.0d, 0.00119912d },
            { 4800.0d, 0.00120024d },
            { 5400.0d, 0.00120134d },
            { 6000.0d, 0.00120241d },
            { 6600.0d, 0.00120338d },
            { 7200.0d, 0.00120429d },
            { 7800.0d, 0.00120514d },
            { 8400.0d, 0.00120595d },
            { 9000.0d, 0.00120672d },
            { 9600.0d, 0.00120749d },
            { 10000.0d, 0.00120799d },
            { 11000.0d, 0.00120922d },
            { 12000.0d, 0.00121038d },
            { 13000.0d, 0.00121154d },
            { 14000.0d, 0.00121266d },
            { 15000.0d, 0.00121375d },
            { 16000.0d, 0.00121483d },
            { 17000.0d, 0.00121589d },
            { 18000.0d, 0.00121693d },
            { 19000.0d, 0.00121795d },
            { 20000.0d, 0.00121895d },
            { 21000.0d, 0.00121994d },
            { 22000.0d, 0.00122091d },
            { 23000.0d, 0.00122188d },
            { 24000.0d, 0.00122282d },
            { 25000.0d, 0.00122376d },
            { 26000.0d, 0.00122469d },
            { 27000.0d, 0.0012256d },
            { 28000.0d, 0.00122651d },
            { 29000.0d, 0.0012274d },
            { 30000.0d, 0.00122829d },
            { 31000.0d, 0.00122917d },
            { 32000.0d, 0.00123004d },
            { 33000.0d, 0.0012309d },
            { 34000.0d, 0.00123176d },
            { 35000.0d, 0.00123261d },
            { 36000.0d, 0.00123345d },
            { 37000.0d, 0.00123429d },
            { 38000.0d, 0.00123512d },
            { 39000.0d, 0.00123594d },
            { 40000.0d, 0.00123676d },
            { 41000.0d, 0.00123757d },
            { 42000.0d, 0.00123837d },
            { 43000.0d, 0.00123917d },
            { 44000.0d, 0.00123997d },
            { 45000.0d, 0.00124076d },
            { 46000.0d, 0.00124154d },
            { 47000.0d, 0.00124232d },
            { 48000.0d, 0.0012431d },
            { 49000.0d, 0.00124387d },
            { 50000.0d, 0.00124463d },
            { 51000.0d, 0.00124539d },
            { 52000.0d, 0.00124614d },
            { 53000.0d, 0.00124689d },
            { 54000.0d, 0.00124764d },
            { 55000.0d, 0.00124837d },
            { 56000.0d, 0.00124911d },
            { 57000.0d, 0.00124984d },
            { 58000.0d, 0.00125056d },
            { 59000.0d, 0.00125128d },
            { 60000.0d, 0.00125199d },
            { 61000.0d, 0.0012527d },
            { 62000.0d, 0.0012534d },
            { 63000.0d, 0.0012541d },
            { 64000.0d, 0.00125479d },
            { 65000.0d, 0.00125548d },
            { 66000.0d, 0.00125616d },
            { 67000.0d, 0.00125683d },
            { 68000.0d, 0.00125751d },
            { 69000.0d, 0.00125817d },
            { 70000.0d, 0.00125883d },
            { 71000.0d, 0.00125948d },
            { 72000.0d, 0.00126013d },
            { 73000.0d, 0.00126077d },
            { 74000.0d, 0.00126141d },
            { 75000.0d, 0.00126204d },
            { 76000.0d, 0.00126266d },
            { 77000.0d, 0.00126328d },
            { 78000.0d, 0.0012639d },
            { 79000.0d, 0.0012645d },
            { 80000.0d, 0.0012651d },
            { 81000.0d, 0.0012657d },
            { 82000.0d, 0.00126629d },
            { 83000.0d, 0.00126687d },
            { 84000.0d, 0.00126744d },
            { 85000.0d, 0.00126801d },
            { 86000.0d, 0.00126858d },
            { 87000.0d, 0.00126913d },
            { 88000.0d, 0.00126968d },
            { 89000.0d, 0.00127023d },
            { 90000.0d, 0.00127077d },
            { 91000.0d, 0.0012713d },
            { 92000.0d, 0.00127182d },
            { 93000.0d, 0.00127234d },
            { 94000.0d, 0.00127285d },
            { 95000.0d, 0.00127335d },
            { 96000.0d, 0.00127385d },
            { 97000.0d, 0.00127434d },
            { 98000.0d, 0.00127483d },
            { 99000.0d, 0.00127531d },
            { 100000.0d, 0.00127578d },
            { 107000.0d, 0.00127888d },
            { 114000.0d, 0.00128163d },
            { 121000.0d, 0.00128403d },
            { 128000.0d, 0.00128608d },
            { 135000.0d, 0.00128775d },
            { 142000.0d, 0.00128907d },
            { 149000.0d, 0.00129002d },
            { 156000.0d, 0.0012906d },
            { 163000.0d, 0.00129082d },
            { 170000.0d, 0.00129068d },
            { 177000.0d, 0.00129018d },
            { 184000.0d, 0.00128933d },
            { 191000.0d, 0.00128813d },
            { 198000.0d, 0.00128659d },
            { 205000.0d, 0.00128471d },
            { 212000.0d, 0.0012825d },
            { 219000.0d, 0.00127998d },
            { 226000.0d, 0.00127714d },
            { 233000.0d, 0.00127399d },
            { 240000.0d, 0.00127051d },
            { 247000.0d, 0.00126671d },
            { 254000.0d, 0.00126259d },
            { 261000.0d, 0.00125817d },
            { 268000.0d, 0.00125344d },
            { 275000.0d, 0.00124843d },
            { 282000.0d, 0.00124314d },
            { 289000.0d, 0.00123758d },
            { 296000.0d, 0.00123177d },
            { 303000.0d, 0.00122571d },
            { 310000.0d, 0.00121941d },
            { 317000.0d, 0.0012129d },
            { 324000.0d, 0.00120618d },
            { 331000.0d, 0.00119924d },
            { 338000.0d, 0.00119208d },
            { 345000.0d, 0.00118473d },
            { 352000.0d, 0.00117718d },
            { 359000.0d, 0.00116943d },
            { 366000.0d, 0.00116146d },
            { 373000.0d, 0.00115325d },
            { 380000.0d, 0.00114482d },
            { 387000.0d, 0.00113615d },
            { 394000.0d, 0.00112727d },
            { 401000.0d, 0.00111817d },
            { 408000.0d, 0.00110887d },
            { 415000.0d, 0.00109937d },
            { 422000.0d, 0.00108968d },
            { 429000.0d, 0.00107982d },
            { 436000.0d, 0.00106979d },
            { 443000.0d, 0.00105958d },
            { 450000.0d, 0.00104923d },
            { 457000.0d, 0.00103873d },
            { 464000.0d, 0.0010281d },
            { 471000.0d, 0.00101734d },
            { 478000.0d, 0.00100647d },
            { 485000.0d, 0.000995483d },
            { 492000.0d, 0.000984402d },
            { 499000.0d, 0.000973235d },
            { 506000.0d, 0.000961996d },
            { 513000.0d, 0.000950668d },
            { 520000.0d, 0.000939252d },
            { 527000.0d, 0.000927752d },
            { 534000.0d, 0.000916158d },
            { 541000.0d, 0.000904477d },
            { 548000.0d, 0.000892718d },
            { 555000.0d, 0.000880897d },
            { 562000.0d, 0.000869021d },
            { 569000.0d, 0.000857105d },
            { 576000.0d, 0.000845158d },
            { 583000.0d, 0.000833196d },
            { 590000.0d, 0.000821229d },
            { 597000.0d, 0.000809269d },
            { 604000.0d, 0.00079733d },
            { 611000.0d, 0.000785426d },
            { 618000.0d, 0.000773567d },
            { 625000.0d, 0.000761769d },
            { 632000.0d, 0.000750044d },
            { 639000.0d, 0.000738407d },
            { 646000.0d, 0.00072687d },
            { 653000.0d, 0.000715449d },
            { 660000.0d, 0.000704157d },
            { 667000.0d, 0.000693009d },
            { 674000.0d, 0.000682015d },
            { 681000.0d, 0.000671187d },
            { 688000.0d, 0.000660541d },
            { 695000.0d, 0.000650086d },
            { 702000.0d, 0.000639821d },
            { 709000.0d, 0.000629757d },
            { 716000.0d, 0.00061991d },
            { 723000.0d, 0.000610296d },
            { 730000.0d, 0.000600928d },
            { 737000.0d, 0.000591818d },
            { 744000.0d, 0.000582972d },
            { 751000.0d, 0.00057419d },
            { 758000.0d, 0.000565408d },
            { 765000.0d, 0.00055663d },
            { 772000.0d, 0.000547869d },
            { 779000.0d, 0.000539124d },
            { 786000.0d, 0.000530408d },
            { 793000.0d, 0.000521722d },
            { 800000.0d, 0.000513077d },
            { 807000.0d, 0.000504476d },
            { 814000.0d, 0.00049593d },
            { 821000.0d, 0.000487443d },
            { 828000.0d, 0.000479023d },
            { 835000.0d, 0.000470675d },
            { 842000.0d, 0.000462402d },
            { 849000.0d, 0.000454212d },
            { 856000.0d, 0.000446111d },
            { 863000.0d, 0.000438108d },
            { 870000.0d, 0.000430209d },
            { 877000.0d, 0.000422423d },
            { 884000.0d, 0.000414756d },
            { 891000.0d, 0.000407215d },
            { 898000.0d, 0.000399809d },
            { 905000.0d, 0.000392544d },
            { 912000.0d, 0.000385429d },
            { 919000.0d, 0.000378445d },
            { 926000.0d, 0.000371582d },
            { 933000.0d, 0.000364848d },
            { 940000.0d, 0.000358249d },
            { 947000.0d, 0.000351792d },
            { 954000.0d, 0.000345484d },
            { 961000.0d, 0.000339332d },
            { 968000.0d, 0.000333343d },
            { 975000.0d, 0.000327479d },
            { 982000.0d, 0.000321702d },
            { 989000.0d, 0.000316018d },
            { 996000.0d, 0.000310426d },
            { 1003000.0d, 0.000304898d },
            { 1010000.0d, 0.000299418d },
            { 1017000.0d, 0.000293986d },
            { 1024000.0d, 0.000288609d },
            { 1031000.0d, 0.000283288d },
            { 1038000.0d, 0.000278028d },
            { 1045000.0d, 0.000272833d },
            { 1052000.0d, 0.000267706d },
            { 1059000.0d, 0.000262652d },
            { 1066000.0d, 0.000257674d },
            { 1073000.0d, 0.000252775d },
            { 1080000.0d, 0.000247961d },
            { 1087000.0d, 0.000243234d },
            { 1094000.0d, 0.000238599d },
            { 1101000.0d, 0.00023406d },
            { 1108000.0d, 0.000229621d },
            { 1115000.0d, 0.000225286d },
            { 1122000.0d, 0.000221059d },
            { 1129000.0d, 0.000216944d },
            { 1136000.0d, 0.000212944d },
            { 1143000.0d, 0.000209065d },
            { 1150000.0d, 0.000205311d },
            { 1157000.0d, 0.000201685d },
            { 1164000.0d, 0.000198181d },
            { 1171000.0d, 0.000194796d },
            { 1178000.0d, 0.000191535d },
            { 1185000.0d, 0.000188399d },
            { 1192000.0d, 0.000185349d },
            { 1199000.0d, 0.00018231d },
            { 1206000.0d, 0.000179281d },
            { 1213000.0d, 0.000176265d },
            { 1220000.0d, 0.000173263d },
            { 1227000.0d, 0.000170275d },
            { 1234000.0d, 0.000167303d },
            { 1241000.0d, 0.000164345d },
            { 1248000.0d, 0.000161403d },
            { 1255000.0d, 0.000158475d },
            { 1262000.0d, 0.000155565d },
            { 1269000.0d, 0.000152673d },
            { 1276000.0d, 0.000149801d },
            { 1283000.0d, 0.000146951d },
            { 1290000.0d, 0.000144123d },
            { 1297000.0d, 0.000141318d },
            { 1304000.0d, 0.00013854d },
            { 1311000.0d, 0.000135787d },
            { 1318000.0d, 0.000133063d },
            { 1325000.0d, 0.000130368d },
            { 1332000.0d, 0.000127703d },
            { 1339000.0d, 0.000125071d },
            { 1346000.0d, 0.000122472d },
            { 1353000.0d, 0.000119908d },
            { 1360000.0d, 0.00011738d },
            { 1367000.0d, 0.00011489d },
            { 1374000.0d, 0.000112439d },
            { 1381000.0d, 0.000110028d },
            { 1388000.0d, 0.00010766d },
            { 1395000.0d, 0.000105335d },
            { 1402000.0d, 0.000103055d },
            { 1409000.0d, 0.000100821d },
            { 1416000.0d, 0.0000986337d },
            { 1423000.0d, 0.0000964929d },
            { 1430000.0d, 0.0000943986d },
            { 1437000.0d, 0.0000923527d },
            { 1444000.0d, 0.0000903565d },
            { 1451000.0d, 0.0000884113d },
            { 1458000.0d, 0.0000865186d },
            { 1465000.0d, 0.0000846797d },
            { 1472000.0d, 0.0000828957d },
            { 1479000.0d, 0.0000811464d },
            { 1486000.0d, 0.0000794204d },
            { 1493000.0d, 0.0000777186d },
            { 1500000.0d, 0.0000760417d },
            { 1507000.0d, 0.0000743907d },
            { 1514000.0d, 0.0000727664d },
            { 1521000.0d, 0.0000711695d },
            { 1528000.0d, 0.0000696012d },
            { 1535000.0d, 0.000068062d },
            { 1542000.0d, 0.0000665529d },
            { 1549000.0d, 0.0000650746d },
            { 1556000.0d, 0.0000636278d },
            { 1563000.0d, 0.0000622133d },
            { 1570000.0d, 0.0000608321d },
            { 1577000.0d, 0.0000594849d },
            { 1584000.0d, 0.0000581728d },
            { 1591000.0d, 0.0000568964d },
            { 1598000.0d, 0.0000556568d },
            { 1605000.0d, 0.0000544548d },
            { 1612000.0d, 0.000053291d },
            { 1619000.0d, 0.0000521662d },
            { 1626000.0d, 0.0000510582d },
            { 1633000.0d, 0.0000499543d },
            { 1640000.0d, 0.0000488548d },
            { 1647000.0d, 0.00004776d },
            { 1654000.0d, 0.0000466701d },
            { 1661000.0d, 0.0000455854d },
            { 1668000.0d, 0.0000445064d },
            { 1675000.0d, 0.0000434331d },
            { 1682000.0d, 0.000042366d },
            { 1689000.0d, 0.0000413054d },
            { 1696000.0d, 0.0000402515d },
            { 1703000.0d, 0.0000392047d },
            { 1710000.0d, 0.0000381653d },
            { 1717000.0d, 0.0000371336d },
            { 1724000.0d, 0.0000361098d },
            { 1731000.0d, 0.0000350944d },
            { 1738000.0d, 0.0000340876d },
            { 1745000.0d, 0.0000330898d },
            { 1752000.0d, 0.0000321012d },
            { 1759000.0d, 0.0000311221d },
            { 1766000.0d, 0.000030153d },
            { 1773000.0d, 0.0000291941d },
            { 1780000.0d, 0.0000282456d },
            { 1787000.0d, 0.0000273071d },
            { 1794000.0d, 0.0000263786d },
            { 1801000.0d, 0.0000254603d },
            { 1808000.0d, 0.0000245527d },
            { 1815000.0d, 0.0000236561d },
            { 1822000.0d, 0.0000227707d },
            { 1829000.0d, 0.000021897d },
            { 1836000.0d, 0.0000210351d },
            { 1843000.0d, 0.0000201854d },
            { 1850000.0d, 0.0000193484d },
            { 1857000.0d, 0.0000185242d },
            { 1864000.0d, 0.0000177132d },
            { 1871000.0d, 0.0000169157d },
            { 1878000.0d, 0.0000161321d },
            { 1885000.0d, 0.0000153626d },
            { 1892000.0d, 0.0000146077d },
            { 1899000.0d, 0.0000138677d },
            { 1906000.0d, 0.0000131429d },
            { 1913000.0d, 0.0000124334d },
            { 1920000.0d, 0.00001174d },
            { 1927000.0d, 0.0000110627d },
            { 1934000.0d, 0.0000104019d },
            { 1941000.0d, 0.00000975812d },
            { 1948000.0d, 0.00000913147d },
            { 1955000.0d, 0.00000852241d },
            { 1962000.0d, 0.00000793124d },
            { 1969000.0d, 0.00000735834d },
            { 1976000.0d, 0.00000680406d },
            { 1983000.0d, 0.00000626872d },
            { 1990000.0d, 0.00000575269d },
            { 1997000.0d, 0.00000525632d },
            { 2004000.0d, 0.00000477997d },
            { 2011000.0d, 0.00000432397d },
            { 2018000.0d, 0.0000038887d },
            { 2025000.0d, 0.00000347449d },
            { 2032000.0d, 0.00000308172d },
            { 2039000.0d, 0.00000271074d },
            { 2046000.0d, 0.0000023619d },
            { 2053000.0d, 0.00000203556d },
            { 2060000.0d, 0.00000173208d },
            { 2067000.0d, 0.00000145182d },
            { 2074000.0d, 0.00000119515d },
            { 2081000.0d, 0.0000009624d },
            { 2088000.0d, 0.000000753947d },
            { 2095000.0d, 0.000000570144d },
            { 2102000.0d, 0.000000411345d },
            { 2109000.0d, 0.000000277898d },
            { 2116000.0d, 0.000000170149d },
            { 2123000.0d, 0.0000000884366d },
            { 2130000.0d, 0.0000000330816d },
            { 2137000.0d, 0.00000000436781d },
            { 2141000.0d, 0d },

        }; 
    }
}
    