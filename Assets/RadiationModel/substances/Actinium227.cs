using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium227";
        public override double halfLife { get; } = 687057392.31882d;
        public override double atomicWeight { get; } = 227.02775d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9862000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium227()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.1e-06d, new GammaParticle(9300.0, 0.13332)), new(6.29998e-06d, new GammaParticle(15200.0, 0.08157)), new(0.000279999d, new GammaParticle(24500.0, 0.05061)), new(0.000419999d, new GammaParticle(28600.0, 0.04335)), new(0.0004899980000000001d, new GammaParticle(37900.0, 0.03271)), new(0.03327023481404d, new GammaParticle(15784.0, 0.07855)) } },
            { 0.0138d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium223()), new(1.0d, new AlphaParticle(6064202.09)), new(1.5e-07d, new GammaParticle(12900.0, 0.09611)), new(6.1e-09d, new GammaParticle(25950.0, 0.04778)), new(1.2e-06d, new GammaParticle(33500.0, 0.03701)), new(3e-07d, new GammaParticle(35000.0, 0.03542)), new(3.0000000000000004e-08d, new GammaParticle(37470.0, 0.03309)), new(1.2e-06d, new GammaParticle(44700.0, 0.02774)), new(3e-09d, new GammaParticle(51060.0, 0.02428)), new(1.5000000000000002e-08d, new GammaParticle(52320.0, 0.0237)), new(4.6e-07d, new GammaParticle(53700.0, 0.02309)), new(4.9e-06d, new GammaParticle(55000.0, 0.02254)), new(4.3e-08d, new GammaParticle(55800.0, 0.02222)), new(3.5e-08d, new GammaParticle(57560.0, 0.02154)), new(4.6e-07d, new GammaParticle(59400.0, 0.02087)), new(4.6e-07d, new GammaParticle(60600.0, 0.02046)), new(4.3e-05d, new GammaParticle(69280.0, 0.0179)), new(9.000000000000001e-07d, new GammaParticle(70600.0, 0.01756)), new(8.000000000000001e-07d, new GammaParticle(72500.0, 0.0171)), new(8.000000000000001e-07d, new GammaParticle(72500.0, 0.0171)), new(1.1999999999999999e-05d, new GammaParticle(79540.0, 0.01559)), new(9e-06d, new GammaParticle(82200.0, 0.01508)), new(1.5000000000000002e-08d, new GammaParticle(83000.0, 0.01494)), new(1.2000000000000002e-07d, new GammaParticle(85000.0, 0.01459)), new(5.199999999999999e-06d, new GammaParticle(86100.0, 0.0144)), new(3e-05d, new GammaParticle(86700.0, 0.0143)), new(8e-06d, new GammaParticle(88100.0, 0.01407)), new(8e-06d, new GammaParticle(88100.0, 0.01407)), new(1.1000000000000001e-08d, new GammaParticle(88500.0, 0.01401)), new(2e-06d, new GammaParticle(90000.0, 0.01378)), new(5.6e-05d, new GammaParticle(99600.0, 0.01245)), new(8e-06d, new GammaParticle(101000.0, 0.01228)), new(3.8e-06d, new GammaParticle(105000.0, 0.01181)), new(1.1999999999999999e-05d, new GammaParticle(106850.0, 0.0116)), new(4.6e-07d, new GammaParticle(108000.0, 0.01148)), new(4.6e-07d, new GammaParticle(118700.0, 0.01045)), new(1.4e-05d, new GammaParticle(121600.0, 0.0102)), new(1.4e-05d, new GammaParticle(121600.0, 0.0102)), new(6.1e-06d, new GammaParticle(134500.0, 0.00922)), new(4.6e-06d, new GammaParticle(137400.0, 0.00902)), new(2.3e-06d, new GammaParticle(140900.0, 0.0088)), new(2.9999999999999997e-06d, new GammaParticle(143000.0, 0.00867)), new(2.9999999999999997e-06d, new GammaParticle(143000.0, 0.00867)), new(2.9e-07d, new GammaParticle(143650.0, 0.00863)), new(1.0000000000000001e-07d, new GammaParticle(146000.0, 0.00849)), new(2.7000000000000002e-05d, new GammaParticle(147610.0, 0.0084)), new(1.5e-07d, new GammaParticle(149300.0, 0.0083)), new(6.1e-06d, new GammaParticle(159200.0, 0.00779)), new(4.9e-05d, new GammaParticle(160490.0, 0.00773)), new(1.4999999999999998e-06d, new GammaParticle(161400.0, 0.00768)), new(6e-07d, new GammaParticle(162600.0, 0.00763)), new(1.1000000000000001e-05d, new GammaParticle(172000.0, 0.00721)), new(2.9999999999999997e-06d, new GammaParticle(174300.0, 0.00711)), new(3.6000000000000003e-06d, new GammaParticle(176100.0, 0.00704)), new(3.6000000000000003e-06d, new GammaParticle(176100.0, 0.00704)), new(1.1000000000000001e-05d, new GammaParticle(206800.0, 0.006)), new(6e-07d, new GammaParticle(216600.0, 0.00572)), new(1.5e-07d, new GammaParticle(219200.0, 0.00566)), new(4.6e-06d, new GammaParticle(229700.0, 0.0054)), new(1.5e-07d, new GammaParticle(230900.0, 0.00537)), new(7.9e-08d, new GammaParticle(231790.0, 0.00535)), new(2.9999999999999997e-06d, new GammaParticle(242600.0, 0.00511)), new(3e-07d, new GammaParticle(243900.0, 0.00508)), new(6e-07d, new GammaParticle(283400.0, 0.00437)), new(6e-07d, new GammaParticle(351700.0, 0.00353)), new(2.3e-06d, new GammaParticle(415600.0, 0.00298)), new(3.8e-07d, new GammaParticle(439600.0, 0.00282)), new(6e-07d, new GammaParticle(441000.0, 0.00281)), new(2.3e-06d, new GammaParticle(460200.0, 0.00269)), new(3.2e-07d, new GammaParticle(527600.0, 0.00235)), new(7.7e-07d, new GammaParticle(540400.0, 0.00229)), new(0.0008219298449736d, new GammaParticle(14500.0, 0.08551)), new(3.5730511343029326e-05d, new GammaParticle(83227.0, 0.0149)), new(5.865152879683081e-05d, new GammaParticle(86102.0, 0.0144)), new(2.0458946767477232e-05d, new GammaParticle(97469.0, 0.01272)), new(2.708764552013986e-05d, new GammaParticle(98682.0, 0.01256)), new(6.628698752662623e-06d, new GammaParticle(100209.0, 0.01237)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0189261d },
            { 100.0d, 0.0357805d },
            { 200.0d, 0.0471497d },
            { 300.0d, 0.0540617d },
            { 400.0d, 0.0587413d },
            { 500.0d, 0.0620582d },
            { 600.0d, 0.0644747d },
            { 700.0d, 0.0662624d },
            { 800.0d, 0.0675924d },
            { 900.0d, 0.0685807d },
            { 1000.0d, 0.0693089d },
            { 1100.0d, 0.069834d },
            { 1200.0d, 0.0701995d },
            { 1300.0d, 0.0704376d },
            { 1400.0d, 0.0705725d },
            { 1500.0d, 0.0706234d },
            { 1600.0d, 0.0706055d },
            { 1700.0d, 0.0705305d },
            { 1800.0d, 0.070408d },
            { 1900.0d, 0.0702457d },
            { 2000.0d, 0.07005d },
            { 2100.0d, 0.0698259d },
            { 2200.0d, 0.0695781d },
            { 2300.0d, 0.0693096d },
            { 2400.0d, 0.0690239d },
            { 2500.0d, 0.0687231d },
            { 2600.0d, 0.0684098d },
            { 2700.0d, 0.0680854d },
            { 2800.0d, 0.0677518d },
            { 2900.0d, 0.06741d },
            { 3000.0d, 0.0670614d },
            { 3100.0d, 0.0667067d },
            { 3200.0d, 0.0663472d },
            { 3300.0d, 0.0659833d },
            { 3400.0d, 0.0656157d },
            { 3500.0d, 0.0652453d },
            { 3600.0d, 0.0648721d },
            { 3700.0d, 0.0644969d },
            { 3800.0d, 0.0641198d },
            { 3900.0d, 0.0637416d },
            { 4000.0d, 0.0633622d },
            { 4100.0d, 0.0629818d },
            { 4200.0d, 0.0626012d },
            { 4300.0d, 0.0622201d },
            { 4400.0d, 0.0618388d },
            { 4500.0d, 0.0614576d },
            { 4600.0d, 0.0610766d },
            { 4700.0d, 0.060696d },
            { 4800.0d, 0.0603158d },
            { 4900.0d, 0.0599362d },
            { 5000.0d, 0.0595573d },
            { 5100.0d, 0.0591792d },
            { 5200.0d, 0.0588019d },
            { 5300.0d, 0.0584257d },
            { 5400.0d, 0.0580504d },
            { 5500.0d, 0.0576763d },
            { 5600.0d, 0.0573033d },
            { 5700.0d, 0.0569315d },
            { 5800.0d, 0.0565608d },
            { 5900.0d, 0.0561917d },
            { 6000.0d, 0.0558239d },
            { 6100.0d, 0.0554575d },
            { 6200.0d, 0.0550924d },
            { 6300.0d, 0.0547288d },
            { 6400.0d, 0.0543667d },
            { 6500.0d, 0.0540063d },
            { 6600.0d, 0.0536473d },
            { 6700.0d, 0.05329d },
            { 6800.0d, 0.0529342d },
            { 6900.0d, 0.0525801d },
            { 7000.0d, 0.0522272d },
            { 7100.0d, 0.0518756d },
            { 7200.0d, 0.0515249d },
            { 7300.0d, 0.0511752d },
            { 7400.0d, 0.0508267d },
            { 7500.0d, 0.0504792d },
            { 7600.0d, 0.050133d },
            { 7700.0d, 0.0497878d },
            { 7800.0d, 0.0494436d },
            { 7900.0d, 0.0491008d },
            { 8000.0d, 0.048759d },
            { 8100.0d, 0.0484185d },
            { 8200.0d, 0.0480791d },
            { 8300.0d, 0.0477409d },
            { 8400.0d, 0.0474041d },
            { 8500.0d, 0.0470683d },
            { 8600.0d, 0.0467338d },
            { 8700.0d, 0.0464004d },
            { 8800.0d, 0.0460684d },
            { 8900.0d, 0.0457376d },
            { 9000.0d, 0.045408d },
            { 9100.0d, 0.0450798d },
            { 9200.0d, 0.0447528d },
            { 9300.0d, 0.044427d },
            { 9400.0d, 0.0441025d },
            { 9500.0d, 0.0437794d },
            { 9600.0d, 0.0434576d },
            { 9700.0d, 0.043137d },
            { 9800.0d, 0.0428178d },
            { 9900.0d, 0.0424998d },
            { 10000.0d, 0.0421831d },
            { 10000.0d, 0.0421831d },
            { 10100.0d, 0.0418678d },
            { 10200.0d, 0.0415539d },
            { 10300.0d, 0.0412412d },
            { 10400.0d, 0.04093d },
            { 10500.0d, 0.04062d },
            { 10600.0d, 0.0403113d },
            { 10700.0d, 0.0400041d },
            { 10800.0d, 0.0396981d },
            { 10900.0d, 0.0393935d },
            { 11000.0d, 0.0390902d },
            { 11100.0d, 0.0387885d },
            { 11200.0d, 0.038488d },
            { 11300.0d, 0.038189d },
            { 11400.0d, 0.0378911d },
            { 11500.0d, 0.0375948d },
            { 11600.0d, 0.0372998d },
            { 11700.0d, 0.0370063d },
            { 11800.0d, 0.0367141d },
            { 11900.0d, 0.0364234d },
            { 12000.0d, 0.0361339d },
            { 12100.0d, 0.035846d },
            { 12200.0d, 0.0355594d },
            { 12300.0d, 0.0352742d },
            { 12400.0d, 0.0349904d },
            { 12500.0d, 0.034708d },
            { 12600.0d, 0.0344271d },
            { 12700.0d, 0.0341475d },
            { 12800.0d, 0.0338695d },
            { 12900.0d, 0.0335928d },
            { 13000.0d, 0.0333175d },
            { 13100.0d, 0.0330436d },
            { 13200.0d, 0.0327712d },
            { 13300.0d, 0.0325003d },
            { 13400.0d, 0.0322308d },
            { 13500.0d, 0.0319627d },
            { 13600.0d, 0.031696d },
            { 13700.0d, 0.0314308d },
            { 13800.0d, 0.0311671d },
            { 13900.0d, 0.0309048d },
            { 14000.0d, 0.0306439d },
            { 14100.0d, 0.0303845d },
            { 14200.0d, 0.0301266d },
            { 14300.0d, 0.02987d },
            { 14400.0d, 0.0296151d },
            { 14500.0d, 0.0293615d },
            { 14600.0d, 0.0291094d },
            { 14700.0d, 0.0288587d },
            { 14800.0d, 0.0286097d },
            { 14900.0d, 0.028362d },
            { 15000.0d, 0.0281157d },
            { 15100.0d, 0.027871d },
            { 15200.0d, 0.0276277d },
            { 15300.0d, 0.0273859d },
            { 15400.0d, 0.0271457d },
            { 15500.0d, 0.0269069d },
            { 15600.0d, 0.0266695d },
            { 15700.0d, 0.0264337d },
            { 15800.0d, 0.0261994d },
            { 15900.0d, 0.0259665d },
            { 16000.0d, 0.0257352d },
            { 16100.000000000002d, 0.0255053d },
            { 16200.0d, 0.025277d },
            { 16300.0d, 0.0250502d },
            { 16400.0d, 0.0248248d },
            { 16500.0d, 0.024601d },
            { 16600.0d, 0.0243786d },
            { 16700.0d, 0.0241578d },
            { 16800.0d, 0.0239385d },
            { 16900.0d, 0.0237206d },
            { 17000.0d, 0.0235044d },
            { 17100.0d, 0.0232896d },
            { 17200.0d, 0.0230763d },
            { 17300.0d, 0.0228647d },
            { 17400.0d, 0.0226544d },
            { 17500.0d, 0.0224457d },
            { 17600.0d, 0.0222386d },
            { 17700.0d, 0.022033d },
            { 17800.0d, 0.0218289d },
            { 17900.0d, 0.0216263d },
            { 18000.0d, 0.0214252d },
            { 18100.0d, 0.0212258d },
            { 18200.0d, 0.0210278d },
            { 18300.0d, 0.0208314d },
            { 18400.0d, 0.0206365d },
            { 18500.0d, 0.0204431d },
            { 18600.0d, 0.0202514d },
            { 18700.0d, 0.0200612d },
            { 18800.0d, 0.0198724d },
            { 18900.0d, 0.0196852d },
            { 19000.0d, 0.0194997d },
            { 19100.0d, 0.0193157d },
            { 19200.0d, 0.0191332d },
            { 19300.0d, 0.0189522d },
            { 19400.0d, 0.0187728d },
            { 19500.0d, 0.018595d },
            { 19600.0d, 0.0184188d },
            { 19700.0d, 0.0182441d },
            { 19800.0d, 0.0180709d },
            { 19900.0d, 0.0178993d },
            { 20000.0d, 0.0177294d },
            { 20100.0d, 0.0175609d },
            { 20200.0d, 0.017394d },
            { 20300.0d, 0.0172288d },
            { 20400.0d, 0.0170647d },
            { 20500.0d, 0.0169014d },
            { 20600.0d, 0.0167389d },
            { 20700.0d, 0.0165771d },
            { 20800.0d, 0.0164161d },
            { 20900.0d, 0.0162559d },
            { 21000.0d, 0.0160965d },
            { 21100.0d, 0.0159379d },
            { 21200.0d, 0.01578d },
            { 21300.0d, 0.0156229d },
            { 21400.0d, 0.0154667d },
            { 21500.0d, 0.0153112d },
            { 21600.0d, 0.0151564d },
            { 21700.0d, 0.0150026d },
            { 21800.0d, 0.0148494d },
            { 21900.0d, 0.0146972d },
            { 22000.0d, 0.0145456d },
            { 22100.0d, 0.0143949d },
            { 22200.0d, 0.014245d },
            { 22300.0d, 0.0140958d },
            { 22400.0d, 0.0139475d },
            { 22500.0d, 0.0137999d },
            { 22600.0d, 0.0136532d },
            { 22700.0d, 0.0135072d },
            { 22800.0d, 0.0133621d },
            { 22900.0d, 0.0132177d },
            { 23000.0d, 0.0130742d },
            { 23100.0d, 0.0129314d },
            { 23200.0d, 0.0127895d },
            { 23300.0d, 0.0126484d },
            { 23400.0d, 0.012508d },
            { 23500.0d, 0.0123685d },
            { 23600.0d, 0.0122298d },
            { 23700.0d, 0.0120919d },
            { 23800.0d, 0.0119548d },
            { 23900.0d, 0.0118185d },
            { 24000.0d, 0.011683d },
            { 24100.0d, 0.0115483d },
            { 24200.0d, 0.0114145d },
            { 24300.0d, 0.0112814d },
            { 24400.0d, 0.0111492d },
            { 24500.0d, 0.0110178d },
            { 24600.0d, 0.0108872d },
            { 24700.0d, 0.0107574d },
            { 24800.0d, 0.0106284d },
            { 24900.0d, 0.0105003d },
            { 25000.0d, 0.0103729d },
            { 25100.0d, 0.0102464d },
            { 25200.0d, 0.0101207d },
            { 25300.0d, 0.00999587d },
            { 25400.0d, 0.00987183d },
            { 25500.0d, 0.0097486d },
            { 25600.0d, 0.0096262d },
            { 25700.0d, 0.00950462d },
            { 25800.0d, 0.00938387d },
            { 25900.0d, 0.00926394d },
            { 26000.0d, 0.00914484d },
            { 26100.0d, 0.00902657d },
            { 26200.0d, 0.00890913d },
            { 26300.0d, 0.00879252d },
            { 26400.0d, 0.00867673d },
            { 26500.0d, 0.00856178d },
            { 26600.0d, 0.00844766d },
            { 26700.0d, 0.00833438d },
            { 26800.0d, 0.00822193d },
            { 26900.0d, 0.0081103d },
            { 27000.0d, 0.00799952d },
            { 27100.0d, 0.00788957d },
            { 27200.0d, 0.00778046d },
            { 27300.0d, 0.00767218d },
            { 27400.0d, 0.00756474d },
            { 27500.0d, 0.00745815d },
            { 27600.0d, 0.00735238d },
            { 27700.0d, 0.00724747d },
            { 27800.0d, 0.00714339d },
            { 27900.0d, 0.00704016d },
            { 28000.0d, 0.00693776d },
            { 28100.0d, 0.00683622d },
            { 28200.0d, 0.00673552d },
            { 28300.0d, 0.00663566d },
            { 28400.0d, 0.00653665d },
            { 28500.0d, 0.00643848d },
            { 28600.0d, 0.00634117d },
            { 28700.0d, 0.0062447d },
            { 28800.0d, 0.00614909d },
            { 28900.0d, 0.00605432d },
            { 29000.0d, 0.0059604d },
            { 29100.0d, 0.00586734d },
            { 29200.0d, 0.00577512d },
            { 29300.0d, 0.00568376d },
            { 29400.0d, 0.00559326d },
            { 29500.0d, 0.00550361d },
            { 29600.0d, 0.00541481d },
            { 29700.0d, 0.00532688d },
            { 29800.0d, 0.0052398d },
            { 29900.0d, 0.00515358d },
            { 30000.0d, 0.00506821d },
            { 30100.0d, 0.00498371d },
            { 30200.0d, 0.00490007d },
            { 30300.0d, 0.00481729d },
            { 30400.0d, 0.00473536d },
            { 30500.0d, 0.0046543d },
            { 30600.0d, 0.00457411d },
            { 30700.0d, 0.00449478d },
            { 30800.0d, 0.00441632d },
            { 30900.0d, 0.00433872d },
            { 31000.0d, 0.00426199d },
            { 31100.0d, 0.00418612d },
            { 31200.0d, 0.00411112d },
            { 31300.0d, 0.004037d },
            { 31400.0d, 0.00396373d },
            { 31500.0d, 0.00389135d },
            { 31600.0d, 0.00381984d },
            { 31700.0d, 0.00374919d },
            { 31800.0d, 0.00367942d },
            { 31900.0d, 0.00361052d },
            { 32000.0d, 0.0035425d },
            { 32100.0d, 0.00347535d },
            { 32200.000000000004d, 0.00340908d },
            { 32299.999999999996d, 0.00334368d },
            { 32400.0d, 0.00327916d },
            { 32500.0d, 0.00321552d },
            { 32600.0d, 0.00315275d },
            { 32700.000000000004d, 0.00309088d },
            { 32800.0d, 0.00302988d },
            { 32900.0d, 0.00296975d },
            { 33000.0d, 0.00291052d },
            { 33100.0d, 0.00285216d },
            { 33200.0d, 0.0027947d },
            { 33300.0d, 0.00273811d },
            { 33400.0d, 0.0026824d },
            { 33500.0d, 0.00262759d },
            { 33600.0d, 0.00257366d },
            { 33700.0d, 0.00252063d },
            { 33800.0d, 0.00246847d },
            { 33900.0d, 0.00241721d },
            { 34000.0d, 0.00236683d },
            { 34100.0d, 0.00231735d },
            { 34200.0d, 0.00226875d },
            { 34300.0d, 0.00222106d },
            { 34400.0d, 0.00217424d },
            { 34500.0d, 0.00212833d },
            { 34600.0d, 0.00208331d },
            { 34700.0d, 0.00203918d },
            { 34800.0d, 0.00199596d },
            { 34900.0d, 0.00195363d },
            { 35000.0d, 0.00191219d },
            { 35100.0d, 0.00187165d },
            { 35200.0d, 0.00183202d },
            { 35300.0d, 0.00179328d },
            { 35400.0d, 0.00175544d },
            { 35500.0d, 0.0017185d },
            { 35600.0d, 0.0016822d },
            { 35700.0d, 0.00164628d },
            { 35800.0d, 0.00161074d },
            { 35900.0d, 0.00157557d },
            { 36000.0d, 0.00154079d },
            { 36100.0d, 0.00150638d },
            { 36200.0d, 0.00147235d },
            { 36300.0d, 0.0014387d },
            { 36400.0d, 0.00140543d },
            { 36500.0d, 0.00137254d },
            { 36600.0d, 0.00134003d },
            { 36700.0d, 0.0013079d },
            { 36800.0d, 0.00127616d },
            { 36900.0d, 0.00124479d },
            { 37000.0d, 0.0012138d },
            { 37100.0d, 0.0011832d },
            { 37200.0d, 0.00115298d },
            { 37300.0d, 0.00112314d },
            { 37400.0d, 0.00109369d },
            { 37500.0d, 0.00106462d },
            { 37600.0d, 0.00103593d },
            { 37700.0d, 0.00100763d },
            { 37800.0d, 0.000979709d },
            { 37900.0d, 0.000952174d },
            { 38000.0d, 0.000925025d },
            { 38100.0d, 0.000898261d },
            { 38200.0d, 0.000871883d },
            { 38300.0d, 0.00084589d },
            { 38400.0d, 0.000820284d },
            { 38500.0d, 0.000795065d },
            { 38600.0d, 0.000770232d },
            { 38700.0d, 0.000745787d },
            { 38800.0d, 0.000721729d },
            { 38900.0d, 0.00069806d },
            { 39000.0d, 0.000674778d },
            { 39100.0d, 0.000651886d },
            { 39200.0d, 0.000629382d },
            { 39300.0d, 0.000607267d },
            { 39400.0d, 0.000585543d },
            { 39500.0d, 0.000564208d },
            { 39600.0d, 0.000543263d },
            { 39700.0d, 0.000522709d },
            { 39800.0d, 0.000502546d },
            { 39900.0d, 0.000482774d },
            { 40000.0d, 0.000463393d },
            { 40100.0d, 0.000444405d },
            { 40200.0d, 0.000425808d },
            { 40300.0d, 0.000407605d },
            { 40400.0d, 0.000389794d },
            { 40500.0d, 0.000372376d },
            { 40600.0d, 0.000355352d },
            { 40700.0d, 0.000338722d },
            { 40800.0d, 0.000322485d },
            { 40900.0d, 0.000306644d },
            { 41000.0d, 0.000291197d },
            { 41100.0d, 0.000276145d },
            { 41200.0d, 0.000261489d },
            { 41300.0d, 0.000247229d },
            { 41400.0d, 0.000233365d },
            { 41500.0d, 0.000219897d },
            { 41600.0d, 0.000206826d },
            { 41700.0d, 0.000194153d },
            { 41800.0d, 0.000181876d },
            { 41900.0d, 0.000169998d },
            { 42000.0d, 0.000158517d },
            { 42100.0d, 0.000147435d },
            { 42200.0d, 0.000136752d },
            { 42300.0d, 0.000126467d },
            { 42400.0d, 0.000116583d },
            { 42500.0d, 0.000107097d },
            { 42600.0d, 0.0000980124d },
            { 42700.0d, 0.0000893276d },
            { 42800.0d, 0.0000810436d },
            { 42900.0d, 0.0000731605d },
            { 43000.0d, 0.0000656788d },
            { 43100.0d, 0.0000585988d },
            { 43200.0d, 0.0000519207d },
            { 43300.0d, 0.0000456449d },
            { 43400.0d, 0.0000397717d },
            { 43500.0d, 0.0000343015d },
            { 43600.0d, 0.0000292345d },
            { 43700.0d, 0.0000245712d },
            { 43800.0d, 0.0000203117d },
            { 43900.0d, 0.0000164564d },
            { 44000.0d, 0.0000130057d },
            { 44100.0d, 0.00000995978d },
            { 44200.0d, 0.00000731905d },
            { 44300.0d, 0.00000508379d },
            { 44400.0d, 0.0000032543d },
            { 44500.0d, 0.00000183089d },
            { 44600.0d, 0.000000813859d },
            { 44700.0d, 0.000000203481d },
            { 44800.0d, 0d },

        }; 
    }
}
    