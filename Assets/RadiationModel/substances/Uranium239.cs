using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium239";
        public override double halfLife { get; } = 1407.0d;
        public override double atomicWeight { get; } = 239.05429d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium239()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0006916d, new GammaParticle(31131.0, 0.03983)), new(0.0439964d, new GammaParticle(43533.0, 0.02848)), new(9.044e-07d, new GammaParticle(55180.0, 0.02247)), new(0.532d, new GammaParticle(74664.0, 0.01661)), new(0.00057456d, new GammaParticle(86720.0, 0.0143)), new(0.00021812d, new GammaParticle(111000.0, 0.01117)), new(0.0014896d, new GammaParticle(117660.0, 0.01054)), new(2.1812e-05d, new GammaParticle(134710.0, 0.0092)), new(1.8088e-05d, new GammaParticle(141970.0, 0.00873)), new(2.3939999999999998e-05d, new GammaParticle(142930.0, 0.00867)), new(0.00011172d, new GammaParticle(174070.0, 0.00712)), new(0.00033516d, new GammaParticle(186150.0, 0.00666)), new(6.4904e-05d, new GammaParticle(187280.0, 0.00662)), new(2.9792e-05d, new GammaParticle(191970.0, 0.00646)), new(2.3408e-05d, new GammaParticle(196850.0, 0.0063)), new(2.8196e-05d, new GammaParticle(197280.0, 0.00628)), new(5.852e-06d, new GammaParticle(201090.0, 0.00617)), new(0.00032983999999999997d, new GammaParticle(220520.0, 0.00562)), new(3.2984e-05d, new GammaParticle(231700.0, 0.00535)), new(1.064e-05d, new GammaParticle(236280.0, 0.00525)), new(1.0108e-05d, new GammaParticle(240000.0, 0.00517)), new(1.33e-05d, new GammaParticle(255710.0, 0.00485)), new(8.511999999999999e-06d, new GammaParticle(258800.0, 0.00479)), new(3.5644e-05d, new GammaParticle(260860.0, 0.00475)), new(9.576e-06d, new GammaParticle(262890.0, 0.00472)), new(1.064e-05d, new GammaParticle(265440.0, 0.00467)), new(1.6492e-05d, new GammaParticle(296930.0, 0.00418)), new(1.6492e-05d, new GammaParticle(296930.0, 0.00418)), new(1.2768e-05d, new GammaParticle(301640.0, 0.00411)), new(1.8619999999999998e-05d, new GammaParticle(304170.0, 0.00408)), new(5.852e-05d, new GammaParticle(312050.0, 0.00397)), new(1.2768e-05d, new GammaParticle(321710.0, 0.00385)), new(5.054e-05d, new GammaParticle(326210.0, 0.0038)), new(7.98e-06d, new GammaParticle(330140.0, 0.00376)), new(1.33e-05d, new GammaParticle(332060.0, 0.00373)), new(2.0748e-05d, new GammaParticle(343740.0, 0.00361)), new(4.522e-05d, new GammaParticle(345130.0, 0.00359)), new(8.511999999999999e-06d, new GammaParticle(348230.0, 0.00356)), new(8.511999999999999e-06d, new GammaParticle(351330.0, 0.00353)), new(5.1603999999999996e-05d, new GammaParticle(361830.0, 0.00343)), new(9.044e-06d, new GammaParticle(363100.0, 0.00341)), new(0.000285684d, new GammaParticle(373510.0, 0.00332)), new(0.00011704d, new GammaParticle(378060.0, 0.00328)), new(7.448e-06d, new GammaParticle(381270.0, 0.00325)), new(7.448e-06d, new GammaParticle(393010.0, 0.00315)), new(2.3939999999999998e-05d, new GammaParticle(395190.0, 0.00314)), new(1.8088e-05d, new GammaParticle(399130.0, 0.00311)), new(1.064e-05d, new GammaParticle(400550.0, 0.0031)), new(1.0108e-05d, new GammaParticle(404840.0, 0.00306)), new(3.7772000000000004e-05d, new GammaParticle(407700.0, 0.00304)), new(1.33e-05d, new GammaParticle(434440.0, 0.00285)), new(1.2768e-05d, new GammaParticle(445810.0, 0.00278)), new(0.00010480400000000001d, new GammaParticle(448190.0, 0.00277)), new(1.8088e-05d, new GammaParticle(452170.0, 0.00274)), new(9.576e-06d, new GammaParticle(455260.0, 0.00272)), new(2.0216e-05d, new GammaParticle(474500.0, 0.00261)), new(6.384e-06d, new GammaParticle(478130.0, 0.00259)), new(1.1704e-05d, new GammaParticle(479550.0, 0.00259)), new(0.0007182d, new GammaParticle(486870.0, 0.00255)), new(7.98e-06d, new GammaParticle(490330.0, 0.00253)), new(5.7988e-05d, new GammaParticle(492760.0, 0.00252)), new(2.3939999999999998e-05d, new GammaParticle(499100.0, 0.00248)), new(6.916e-06d, new GammaParticle(502120.0, 0.00247)), new(6.0648000000000006e-05d, new GammaParticle(504760.0, 0.00246)), new(1.1704e-05d, new GammaParticle(506800.0, 0.00245)), new(7.448e-06d, new GammaParticle(514100.0, 0.00241)), new(5.2136e-05d, new GammaParticle(518010.0, 0.00239)), new(2.8196e-05d, new GammaParticle(522120.0, 0.00237)), new(1.2768e-05d, new GammaParticle(530500.0, 0.00234)), new(2.66e-05d, new GammaParticle(532860.0, 0.00233)), new(1.4364e-05d, new GammaParticle(535010.0, 0.00232)), new(3.3516e-05d, new GammaParticle(541320.0, 0.00229)), new(4.2028e-05d, new GammaParticle(544480.0, 0.00228)), new(2.2876e-05d, new GammaParticle(547990.0, 0.00226)), new(6.916e-06d, new GammaParticle(558460.0, 0.00222)), new(6.7564e-05d, new GammaParticle(560630.0, 0.00221)), new(4.788e-06d, new GammaParticle(564090.0, 0.0022)), new(4.788e-06d, new GammaParticle(567880.0, 0.00218)), new(0.00015162d, new GammaParticle(575270.0, 0.00216)), new(1.596e-05d, new GammaParticle(577150.0, 0.00215)), new(1.596e-05d, new GammaParticle(577150.0, 0.00215)), new(1.4364e-05d, new GammaParticle(585490.0, 0.00212)), new(0.00022344d, new GammaParticle(587630.0, 0.00211)), new(0.00022344d, new GammaParticle(587630.0, 0.00211)), new(6.3308e-05d, new GammaParticle(588700.0, 0.00211)), new(1.064e-05d, new GammaParticle(591820.0, 0.00209)), new(8.511999999999999e-06d, new GammaParticle(599130.0, 0.00207)), new(5.2136e-05d, new GammaParticle(602680.0, 0.00206)), new(5.586e-05d, new GammaParticle(602790.0, 0.00206)), new(1.1172e-05d, new GammaParticle(604850.0, 0.00205)), new(1.5428e-05d, new GammaParticle(607960.0, 0.00204)), new(7.448e-06d, new GammaParticle(614530.0, 0.00202)), new(8.511999999999999e-06d, new GammaParticle(618030.0, 0.00201)), new(7.182e-05d, new GammaParticle(624110.0, 0.00199)), new(3.0856e-05d, new GammaParticle(629000.0, 0.00197)), new(0.0007820399999999999d, new GammaParticle(631100.0, 0.00196)), new(2.2344e-05d, new GammaParticle(644120.0, 0.00192)), new(3.3516e-05d, new GammaParticle(646260.0, 0.00192)), new(1.064e-05d, new GammaParticle(649790.0, 0.00191)), new(6.384e-06d, new GammaParticle(658500.0, 0.00188)), new(0.0019684d, new GammaParticle(662260.0, 0.00187)), new(6.2244e-05d, new GammaParticle(664170.0, 0.00187)), new(6.384e-06d, new GammaParticle(668760.0, 0.00185)), new(6.916e-06d, new GammaParticle(670880.0, 0.00185)), new(8.5652e-05d, new GammaParticle(691010.0, 0.00179)), new(1.9152e-05d, new GammaParticle(692610.0, 0.00179)), new(4.2028e-05d, new GammaParticle(695180.0, 0.00178)), new(2.2344e-05d, new GammaParticle(700930.0, 0.00177)), new(2.7664e-05d, new GammaParticle(701210.0, 0.00177)), new(2.7131999999999997e-05d, new GammaParticle(703630.0, 0.00176)), new(2.5536e-05d, new GammaParticle(707380.0, 0.00175)), new(1.33e-05d, new GammaParticle(710350.0, 0.00175)), new(4.3092e-05d, new GammaParticle(714220.0, 0.00174)), new(0.000313348d, new GammaParticle(722850.0, 0.00172)), new(2.9792e-05d, new GammaParticle(727520.0, 0.0017)), new(2.9792e-05d, new GammaParticle(727520.0, 0.0017)), new(0.00013299999999999998d, new GammaParticle(730920.0, 0.0017)), new(0.00010906d, new GammaParticle(730950.0, 0.0017)), new(4.9476e-05d, new GammaParticle(746060.0, 0.00166)), new(0.0010320799999999999d, new GammaParticle(748090.0, 0.00166)), new(1.4896e-05d, new GammaParticle(752390.0, 0.00165)), new(2.9792e-05d, new GammaParticle(764040.0, 0.00162)), new(2.3408e-05d, new GammaParticle(768150.0, 0.00161)), new(4.788e-06d, new GammaParticle(769520.0, 0.00161)), new(3.4047999999999997e-05d, new GammaParticle(772940.0, 0.0016)), new(0.00017555999999999998d, new GammaParticle(774770.0, 0.0016)), new(7.448e-06d, new GammaParticle(779570.0, 0.00159)), new(5.6392e-05d, new GammaParticle(788190.0, 0.00157)), new(9.575999999999999e-05d, new GammaParticle(791300.0, 0.00157)), new(8.6716e-05d, new GammaParticle(791330.0, 0.00157)), new(3.2452e-05d, new GammaParticle(793550.0, 0.00156)), new(9.576e-06d, new GammaParticle(795130.0, 0.00156)), new(0.000798d, new GammaParticle(812890.0, 0.00153)), new(0.00149492d, new GammaParticle(819190.0, 0.00151)), new(5.32e-06d, new GammaParticle(829590.0, 0.00149)), new(3.7772000000000004e-05d, new GammaParticle(831860.0, 0.00149)), new(2.3939999999999998e-05d, new GammaParticle(831890.0, 0.00149)), new(4.9476e-05d, new GammaParticle(840300.0, 0.00148)), new(2.8728e-05d, new GammaParticle(841480.0, 0.00147)), new(0.00161196d, new GammaParticle(844050.0, 0.00147)), new(0.00036176d, new GammaParticle(846390.0, 0.00146)), new(2.3408e-05d, new GammaParticle(849440.0, 0.00146)), new(2.3408e-05d, new GammaParticle(849440.0, 0.00146)), new(4.788e-06d, new GammaParticle(862560.0, 0.00144)), new(8.778e-06d, new GammaParticle(867110.0, 0.00143)), new(1.8619999999999998e-05d, new GammaParticle(869570.0, 0.00143)), new(3.8304e-05d, new GammaParticle(874220.0, 0.00142)), new(2.1812e-05d, new GammaParticle(876140.0, 0.00142)), new(9.9484e-05d, new GammaParticle(884450.0, 0.0014)), new(2.7131999999999997e-05d, new GammaParticle(887830.0, 0.0014)), new(0.00024259200000000002d, new GammaParticle(889490.0, 0.00139)), new(9.576e-06d, new GammaParticle(895150.0, 0.00139)), new(2.1812e-05d, new GammaParticle(913680.0, 0.00136)), new(3.0856e-05d, new GammaParticle(917400.0, 0.00135)), new(2.9792e-05d, new GammaParticle(920950.0, 0.00135)), new(7.0224e-06d, new GammaParticle(922830.0, 0.00134)), new(5.9584e-05d, new GammaParticle(928000.0, 0.00134)), new(6.1712e-05d, new GammaParticle(931970.0, 0.00133)), new(0.00030324d, new GammaParticle(933090.0, 0.00133)), new(3.5644e-06d, new GammaParticle(938590.0, 0.00132)), new(2.66e-06d, new GammaParticle(948880.0, 0.00131)), new(8.990800000000001e-05d, new GammaParticle(959480.0, 0.00129)), new(0.00012129600000000001d, new GammaParticle(960990.0, 0.00129)), new(0.0010480399999999999d, new GammaParticle(964300.0, 0.00129)), new(2.3408e-05d, new GammaParticle(965580.0, 0.00128)), new(1.064e-05d, new GammaParticle(970070.0, 0.00128)), new(4.6284000000000004e-06d, new GammaParticle(974910.0, 0.00127)), new(5.160400000000001e-06d, new GammaParticle(988510.0, 0.00125)), new(3.2452e-05d, new GammaParticle(992000.0, 0.00125)), new(5.852e-06d, new GammaParticle(1002400.0, 0.00124)), new(7.448e-06d, new GammaParticle(1005270.0, 0.00123)), new(3.458e-06d, new GammaParticle(1009380.0, 0.00123)), new(1.1704e-05d, new GammaParticle(1018140.0, 0.00122)), new(1.3034e-05d, new GammaParticle(1040190.0, 0.00119)), new(6.916e-06d, new GammaParticle(1065760.0, 0.00116)), new(1.7023999999999998e-05d, new GammaParticle(1078880.0, 0.00115)), new(1.9152e-05d, new GammaParticle(1096920.0, 0.00113)), new(3.5644e-06d, new GammaParticle(1101990.0, 0.00113)), new(7.448e-06d, new GammaParticle(1122800.0, 0.0011)), new(1.064e-05d, new GammaParticle(1161400.0, 0.00107)), new(1.0108e-05d, new GammaParticle(1196900.0, 0.00104)), new(1.7023999999999998e-05d, new GammaParticle(1204900.0, 0.00103)), new(0.145d, new GammaParticle(17136.0, 0.07235)), new(0.00025d, new GammaParticle(97078.0, 0.01277)), new(0.0004d, new GammaParticle(101068.0, 0.01227)), new(0.00015d, new GammaParticle(114160.0, 0.01086)), new(0.0002d, new GammaParticle(115608.0, 0.01072)), new(5e-05d, new GammaParticle(117470.0, 0.01055)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00127104d },
            { 200.0d, 0.0012726d },
            { 400.0d, 0.0012742d },
            { 600.0d, 0.00127582d },
            { 800.0d, 0.00127746d },
            { 1000.0d, 0.00127908d },
            { 1500.0d, 0.0012831d },
            { 2000.0d, 0.001287d },
            { 2500.0d, 0.00129075d },
            { 3000.0d, 0.0012943d },
            { 3500.0d, 0.00129758d },
            { 4000.0d, 0.00130063d },
            { 4500.0d, 0.00130345d },
            { 5000.0d, 0.00130605d },
            { 5500.0d, 0.00130844d },
            { 6000.0d, 0.00131062d },
            { 6500.0d, 0.00131259d },
            { 7000.0d, 0.00131435d },
            { 7500.0d, 0.00131592d },
            { 8000.0d, 0.00131728d },
            { 8500.0d, 0.00131845d },
            { 9000.0d, 0.00131941d },
            { 9500.0d, 0.00132058d },
            { 10000.0d, 0.00132168d },
            { 11000.0d, 0.00132363d },
            { 12000.0d, 0.00132527d },
            { 13000.0d, 0.00132702d },
            { 14000.0d, 0.00132865d },
            { 15000.0d, 0.00133017d },
            { 16000.0d, 0.00133164d },
            { 17000.0d, 0.00133308d },
            { 18000.0d, 0.00133446d },
            { 19000.0d, 0.00133581d },
            { 20000.0d, 0.00133712d },
            { 21000.0d, 0.00133839d },
            { 22000.0d, 0.00133965d },
            { 23000.0d, 0.00134088d },
            { 24000.0d, 0.00134208d },
            { 25000.0d, 0.00134326d },
            { 26000.0d, 0.00134443d },
            { 27000.0d, 0.00134557d },
            { 28000.0d, 0.0013467d },
            { 29000.0d, 0.00134781d },
            { 30000.0d, 0.0013489d },
            { 31000.0d, 0.00134999d },
            { 32000.0d, 0.00135105d },
            { 33000.0d, 0.00135211d },
            { 34000.0d, 0.00135315d },
            { 35000.0d, 0.00135418d },
            { 36000.0d, 0.00135519d },
            { 37000.0d, 0.0013562d },
            { 38000.0d, 0.00135719d },
            { 39000.0d, 0.00135818d },
            { 40000.0d, 0.00135915d },
            { 41000.0d, 0.00136011d },
            { 42000.0d, 0.00136106d },
            { 43000.0d, 0.00136201d },
            { 44000.0d, 0.00136294d },
            { 45000.0d, 0.00136386d },
            { 46000.0d, 0.00136478d },
            { 47000.0d, 0.00136568d },
            { 48000.0d, 0.00136658d },
            { 49000.0d, 0.00136746d },
            { 50000.0d, 0.00136834d },
            { 51000.0d, 0.00136921d },
            { 52000.0d, 0.00137007d },
            { 53000.0d, 0.00137092d },
            { 54000.0d, 0.00137176d },
            { 55000.0d, 0.0013726d },
            { 56000.0d, 0.00137343d },
            { 57000.0d, 0.00137424d },
            { 58000.0d, 0.00137505d },
            { 59000.0d, 0.00137585d },
            { 60000.0d, 0.00137665d },
            { 61000.0d, 0.00137743d },
            { 62000.0d, 0.00137821d },
            { 63000.0d, 0.00137898d },
            { 64000.0d, 0.00137974d },
            { 65000.0d, 0.0013805d },
            { 66000.0d, 0.00138124d },
            { 67000.0d, 0.00138198d },
            { 68000.0d, 0.00138271d },
            { 69000.0d, 0.00138343d },
            { 70000.0d, 0.00138415d },
            { 71000.0d, 0.00138485d },
            { 72000.0d, 0.00138555d },
            { 73000.0d, 0.00138624d },
            { 74000.0d, 0.00138692d },
            { 75000.0d, 0.00138759d },
            { 76000.0d, 0.00138825d },
            { 77000.0d, 0.00138891d },
            { 78000.0d, 0.00138956d },
            { 79000.0d, 0.0013902d },
            { 80000.0d, 0.00139083d },
            { 81000.0d, 0.00139145d },
            { 82000.0d, 0.00139207d },
            { 83000.0d, 0.00139268d },
            { 84000.0d, 0.00139328d },
            { 85000.0d, 0.00139387d },
            { 86000.0d, 0.00139446d },
            { 87000.0d, 0.00139503d },
            { 88000.0d, 0.0013956d },
            { 89000.0d, 0.00139616d },
            { 90000.0d, 0.00139672d },
            { 91000.0d, 0.00139726d },
            { 92000.0d, 0.0013978d },
            { 93000.0d, 0.00139834d },
            { 94000.0d, 0.00139886d },
            { 95000.0d, 0.00139938d },
            { 96000.0d, 0.00139988d },
            { 97000.0d, 0.00140039d },
            { 98000.0d, 0.00140088d },
            { 99000.0d, 0.00140137d },
            { 100000.0d, 0.00140185d },
            { 104000.0d, 0.00140369d },
            { 108000.0d, 0.00140542d },
            { 112000.0d, 0.00140703d },
            { 116000.0d, 0.00140853d },
            { 120000.0d, 0.00140991d },
            { 124000.0d, 0.00141119d },
            { 128000.0d, 0.00141235d },
            { 132000.0d, 0.00141341d },
            { 136000.0d, 0.00141436d },
            { 140000.0d, 0.0014152d },
            { 144000.0d, 0.00141593d },
            { 148000.0d, 0.00141656d },
            { 152000.0d, 0.00141709d },
            { 156000.0d, 0.00141751d },
            { 160000.0d, 0.00141784d },
            { 164000.0d, 0.00141806d },
            { 168000.0d, 0.00141819d },
            { 172000.0d, 0.00141821d },
            { 176000.0d, 0.00141813d },
            { 180000.0d, 0.00141795d },
            { 184000.0d, 0.00141767d },
            { 188000.0d, 0.00141729d },
            { 192000.0d, 0.00141682d },
            { 196000.0d, 0.00141625d },
            { 200000.0d, 0.00141558d },
            { 204000.0d, 0.00141482d },
            { 208000.0d, 0.00141397d },
            { 212000.0d, 0.00141303d },
            { 216000.0d, 0.00141199d },
            { 220000.0d, 0.00141087d },
            { 224000.0d, 0.00140965d },
            { 228000.0d, 0.00140834d },
            { 232000.0d, 0.00140694d },
            { 236000.0d, 0.00140545d },
            { 240000.0d, 0.00140387d },
            { 244000.0d, 0.0014022d },
            { 248000.0d, 0.00140044d },
            { 252000.0d, 0.0013986d },
            { 256000.0d, 0.00139666d },
            { 260000.0d, 0.00139465d },
            { 264000.0d, 0.00139254d },
            { 268000.0d, 0.00139035d },
            { 272000.0d, 0.00138808d },
            { 276000.0d, 0.00138573d },
            { 280000.0d, 0.00138329d },
            { 284000.0d, 0.00138077d },
            { 288000.0d, 0.00137816d },
            { 292000.0d, 0.00137548d },
            { 296000.0d, 0.00137272d },
            { 300000.0d, 0.00136988d },
            { 304000.0d, 0.00136694d },
            { 308000.0d, 0.00136392d },
            { 312000.0d, 0.00136081d },
            { 316000.0d, 0.0013576d },
            { 320000.0d, 0.00135431d },
            { 324000.0d, 0.00135093d },
            { 328000.0d, 0.00134747d },
            { 332000.0d, 0.00134392d },
            { 336000.0d, 0.00134028d },
            { 340000.0d, 0.00133656d },
            { 344000.0d, 0.00133276d },
            { 348000.0d, 0.00132887d },
            { 352000.0d, 0.00132491d },
            { 356000.0d, 0.00132086d },
            { 360000.0d, 0.00131673d },
            { 364000.0d, 0.00131252d },
            { 368000.0d, 0.00130824d },
            { 372000.0d, 0.00130388d },
            { 376000.0d, 0.00129944d },
            { 380000.0d, 0.00129493d },
            { 384000.0d, 0.00129034d },
            { 388000.0d, 0.00128567d },
            { 392000.0d, 0.00128094d },
            { 396000.0d, 0.00127613d },
            { 400000.0d, 0.00127126d },
            { 404000.0d, 0.00126631d },
            { 408000.0d, 0.00126129d },
            { 412000.0d, 0.00125621d },
            { 416000.0d, 0.00125106d },
            { 420000.0d, 0.00124584d },
            { 424000.0d, 0.00124055d },
            { 428000.0d, 0.00123519d },
            { 432000.0d, 0.00122976d },
            { 436000.0d, 0.00122427d },
            { 440000.0d, 0.0012187d },
            { 444000.0d, 0.00121307d },
            { 448000.0d, 0.00120737d },
            { 452000.0d, 0.0012016d },
            { 456000.0d, 0.00119576d },
            { 460000.0d, 0.00118984d },
            { 464000.0d, 0.00118387d },
            { 468000.0d, 0.00117782d },
            { 472000.0d, 0.00117171d },
            { 476000.0d, 0.00116553d },
            { 480000.0d, 0.00115929d },
            { 484000.0d, 0.00115299d },
            { 488000.0d, 0.00114662d },
            { 492000.0d, 0.00114019d },
            { 496000.0d, 0.0011337d },
            { 500000.0d, 0.00112715d },
            { 504000.0d, 0.00112054d },
            { 508000.0d, 0.00111387d },
            { 512000.0d, 0.00110715d },
            { 516000.0d, 0.00110037d },
            { 520000.0d, 0.00109353d },
            { 524000.0d, 0.00108664d },
            { 528000.0d, 0.0010797d },
            { 532000.0d, 0.0010727d },
            { 536000.0d, 0.00106565d },
            { 540000.0d, 0.00105855d },
            { 544000.0d, 0.00105141d },
            { 548000.0d, 0.00104421d },
            { 552000.0d, 0.00103697d },
            { 556000.0d, 0.00102968d },
            { 560000.0d, 0.00102234d },
            { 564000.0d, 0.00101496d },
            { 568000.0d, 0.00100753d },
            { 572000.0d, 0.00100006d },
            { 576000.0d, 0.000992555d },
            { 580000.0d, 0.000985003d },
            { 584000.0d, 0.000977413d },
            { 588000.0d, 0.000969782d },
            { 592000.0d, 0.000962112d },
            { 596000.0d, 0.000954407d },
            { 600000.0d, 0.000946665d },
            { 604000.0d, 0.000938886d },
            { 608000.0d, 0.00093107d },
            { 612000.0d, 0.000923218d },
            { 616000.0d, 0.000915332d },
            { 620000.0d, 0.000907413d },
            { 624000.0d, 0.00089946d },
            { 628000.0d, 0.000891475d },
            { 632000.0d, 0.00088346d },
            { 636000.0d, 0.000875415d },
            { 640000.0d, 0.000867342d },
            { 644000.0d, 0.000859241d },
            { 648000.0d, 0.000851114d },
            { 652000.0d, 0.000842961d },
            { 656000.0d, 0.000834784d },
            { 660000.0d, 0.000826582d },
            { 664000.0d, 0.000818359d },
            { 668000.0d, 0.000810115d },
            { 672000.0d, 0.000801851d },
            { 676000.0d, 0.000793568d },
            { 680000.0d, 0.000785267d },
            { 684000.0d, 0.000776948d },
            { 688000.0d, 0.000768614d },
            { 692000.0d, 0.000760265d },
            { 696000.0d, 0.000751902d },
            { 700000.0d, 0.000743529d },
            { 704000.0d, 0.000735142d },
            { 708000.0d, 0.000726745d },
            { 712000.0d, 0.00071834d },
            { 716000.0d, 0.000709927d },
            { 720000.0d, 0.000701506d },
            { 724000.0d, 0.00069308d },
            { 728000.0d, 0.000684648d },
            { 732000.0d, 0.000676215d },
            { 736000.0d, 0.000667777d },
            { 740000.0d, 0.000659339d },
            { 744000.0d, 0.000650901d },
            { 748000.0d, 0.000642465d },
            { 752000.0d, 0.00063403d },
            { 756000.0d, 0.000625598d },
            { 760000.0d, 0.000617172d },
            { 764000.0d, 0.000608751d },
            { 768000.0d, 0.000600337d },
            { 772000.0d, 0.000591931d },
            { 776000.0d, 0.000583533d },
            { 780000.0d, 0.000575146d },
            { 784000.0d, 0.000566773d },
            { 788000.0d, 0.00055841d },
            { 792000.0d, 0.000550063d },
            { 796000.0d, 0.00054173d },
            { 800000.0d, 0.000533414d },
            { 804000.0d, 0.000525115d },
            { 808000.0d, 0.000516835d },
            { 812000.0d, 0.000508575d },
            { 816000.0d, 0.000500336d },
            { 820000.0d, 0.000492119d },
            { 824000.0d, 0.000483927d },
            { 828000.0d, 0.000475759d },
            { 832000.0d, 0.000467618d },
            { 836000.0d, 0.000459505d },
            { 840000.0d, 0.000451418d },
            { 844000.0d, 0.000443362d },
            { 848000.0d, 0.000435338d },
            { 852000.0d, 0.000427346d },
            { 856000.0d, 0.000419387d },
            { 860000.0d, 0.000411464d },
            { 864000.0d, 0.000403576d },
            { 868000.0d, 0.000395725d },
            { 872000.0d, 0.000387913d },
            { 876000.0d, 0.000380141d },
            { 880000.0d, 0.00037241d },
            { 884000.0d, 0.000364722d },
            { 888000.0d, 0.000357077d },
            { 892000.0d, 0.000349477d },
            { 896000.0d, 0.000341923d },
            { 900000.0d, 0.000334416d },
            { 904000.0d, 0.000326959d },
            { 908000.0d, 0.000319552d },
            { 912000.0d, 0.000312195d },
            { 916000.0d, 0.000304892d },
            { 920000.0d, 0.000297643d },
            { 924000.0d, 0.000290449d },
            { 928000.0d, 0.000283311d },
            { 932000.0d, 0.000276231d },
            { 936000.0d, 0.00026921d },
            { 940000.0d, 0.000262251d },
            { 944000.0d, 0.000255351d },
            { 948000.0d, 0.000248517d },
            { 952000.0d, 0.000241746d },
            { 956000.0d, 0.00023504d },
            { 960000.0d, 0.000228402d },
            { 964000.0d, 0.000221833d },
            { 968000.0d, 0.000215333d },
            { 972000.0d, 0.000208904d },
            { 976000.0d, 0.000202547d },
            { 980000.0d, 0.000196264d },
            { 984000.0d, 0.000190056d },
            { 988000.0d, 0.000183925d },
            { 992000.0d, 0.000177872d },
            { 996000.0d, 0.000171897d },
            { 1000000.0d, 0.000166003d },
            { 1004000.0d, 0.000160191d },
            { 1008000.0d, 0.000154461d },
            { 1012000.0d, 0.000148816d },
            { 1016000.0d, 0.000143258d },
            { 1020000.0d, 0.000137786d },
            { 1024000.0d, 0.000132403d },
            { 1028000.0d, 0.00012711d },
            { 1032000.0d, 0.000121908d },
            { 1036000.0d, 0.000116799d },
            { 1040000.0d, 0.000111784d },
            { 1044000.0d, 0.000106864d },
            { 1048000.0d, 0.000102041d },
            { 1052000.0d, 0.0000973162d },
            { 1056000.0d, 0.0000926909d },
            { 1060000.0d, 0.0000881666d },
            { 1064000.0d, 0.0000837446d },
            { 1068000.0d, 0.0000794262d },
            { 1072000.0d, 0.000075213d },
            { 1076000.0d, 0.0000711062d },
            { 1080000.0d, 0.0000671072d },
            { 1084000.0d, 0.0000632175d },
            { 1088000.0d, 0.0000594384d },
            { 1092000.0d, 0.0000557713d },
            { 1096000.0d, 0.0000522176d },
            { 1100000.0d, 0.0000487787d },
            { 1104000.0d, 0.0000454559d },
            { 1108000.0d, 0.000042251d },
            { 1112000.0d, 0.0000391648d },
            { 1116000.0d, 0.000036199d },
            { 1120000.0d, 0.000033355d },
            { 1124000.0d, 0.0000306342d },
            { 1128000.0d, 0.000028038d },
            { 1132000.0d, 0.0000255677d },
            { 1136000.0d, 0.0000232248d },
            { 1140000.0d, 0.0000210105d },
            { 1144000.0d, 0.0000189265d },
            { 1148000.0d, 0.000016972d },
            { 1152000.0d, 0.000015147d },
            { 1156000.0d, 0.0000134528d },
            { 1160000.0d, 0.0000118908d },
            { 1164000.0d, 0.0000104623d },
            { 1168000.0d, 0.00000916861d },
            { 1172000.0d, 0.00000801105d },
            { 1176000.0d, 0.00000699086d },
            { 1180000.0d, 0.00000610937d },
            { 1184000.0d, 0.00000536769d },
            { 1188000.0d, 0.00000476182d },
            { 1192000.0d, 0.00000421574d },
            { 1196000.0d, 0.00000370345d },
            { 1200000.0d, 0.00000322531d },
            { 1204000.0d, 0.00000278165d },
            { 1208000.0d, 0.00000237283d },
            { 1212000.0d, 0.00000199918d },
            { 1216000.0d, 0.00000166103d },
            { 1220000.0d, 0.00000135873d },
            { 1224000.0d, 0.00000109261d },
            { 1228000.0d, 0.000000862981d },
            { 1232000.0d, 0.000000669041d },
            { 1236000.0d, 0.000000501131d },
            { 1240000.0d, 0.00000035707d },
            { 1244000.0d, 0.000000237073d },
            { 1248000.0d, 0.000000141347d },
            { 1252000.0d, 0.0000000700938d },
            { 1256000.0d, 0.0000000235049d },
            { 1260000.0d, 0.00000000174271d },
            { 1261500.0d, 0d },

        }; 
    }
}
    