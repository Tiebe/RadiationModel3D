using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum148 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum148";
        public override double halfLife { get; } = 1.26d;
        public override double atomicWeight { get; } = 147.93268d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium148()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.556d, new GammaParticle(158468.0, 0.00782)), new(0.01668d, new GammaParticle(252450.0, 0.00491)), new(0.003336d, new GammaParticle(257090.0, 0.00482)), new(0.06672d, new GammaParticle(295070.0, 0.0042)), new(0.007228d, new GammaParticle(298810.0, 0.00415)), new(0.006672d, new GammaParticle(369450.0, 0.00336)), new(0.039476d, new GammaParticle(378930.0, 0.00327)), new(0.0139d, new GammaParticle(387920.0, 0.0032)), new(0.010008d, new GammaParticle(425680.0, 0.00291)), new(0.011120000000000001d, new GammaParticle(433320.0, 0.00286)), new(0.009452d, new GammaParticle(482190.0, 0.00257)), new(0.005004d, new GammaParticle(536380.0, 0.00231)), new(0.076172d, new GammaParticle(601880.0, 0.00206)), new(0.028912d, new GammaParticle(611810.0, 0.00203)), new(0.007784d, new GammaParticle(654530.0, 0.00189)), new(0.015012000000000001d, new GammaParticle(663200.0, 0.00187)), new(0.064496d, new GammaParticle(682970.0, 0.00182)), new(0.005004d, new GammaParticle(713370.0, 0.00174)), new(0.085624d, new GammaParticle(760300.0, 0.00163)), new(0.005004d, new GammaParticle(770530.0, 0.00161)), new(0.071724d, new GammaParticle(777160.0, 0.0016)), new(0.007228d, new GammaParticle(794440.0, 0.00156)), new(0.013344d, new GammaParticle(819280.0, 0.00151)), new(0.051708d, new GammaParticle(831330.0, 0.00149)), new(0.004448d, new GammaParticle(887120.0, 0.0014)), new(0.005560000000000001d, new GammaParticle(921310.0, 0.00135)), new(0.039476d, new GammaParticle(958230.0, 0.00129)), new(0.003892d, new GammaParticle(967400.0, 0.00128)), new(0.09340799999999999d, new GammaParticle(989850.0, 0.00125)), new(0.003336d, new GammaParticle(1105060.0, 0.00112)), new(0.010564d, new GammaParticle(1130950.0, 0.0011)), new(0.006116d, new GammaParticle(1257420.0, 0.00099)), new(0.00834d, new GammaParticle(1298460.0, 0.00095)), new(0.001112d, new GammaParticle(1303300.0, 0.00095)), new(0.004448d, new GammaParticle(1316690.0, 0.00094)), new(0.017792d, new GammaParticle(1338640.0, 0.00093)), new(0.008896d, new GammaParticle(1425580.0, 0.00087)), new(0.013344d, new GammaParticle(1431560.0, 0.00087)), new(0.008896d, new GammaParticle(1464360.0, 0.00085)), new(0.006116d, new GammaParticle(1496970.0, 0.00083)), new(0.003892d, new GammaParticle(1569650.0, 0.00079)), new(0.00834d, new GammaParticle(1589930.0, 0.00078)), new(0.006672d, new GammaParticle(1732670.0, 0.00072)), new(0.008896d, new GammaParticle(1769270.0, 0.0007)), new(0.012232d, new GammaParticle(1891020.0, 0.00066)), new(0.024464d, new GammaParticle(1985930.0, 0.00062)), new(0.032804d, new GammaParticle(1995230.0, 0.00062)), new(0.011675999999999999d, new GammaParticle(2031170.0, 0.00061)), new(0.006672d, new GammaParticle(2033950.0, 0.00061)), new(0.07005600000000001d, new GammaParticle(2093660.0, 0.00059)), new(0.007228d, new GammaParticle(2153560.0, 0.00058)), new(0.015012000000000001d, new GammaParticle(2219890.0, 0.00056)), new(0.038919999999999996d, new GammaParticle(2391940.0, 0.00052)), new(0.003336d, new GammaParticle(2549800.0, 0.00049)), new(0.02445327418176d, new GammaParticle(5410.0, 0.22918)), new(0.0428265853233507d, new GammaParticle(34279.0, 0.03617)), new(0.07843696945668627d, new GammaParticle(34720.0, 0.03571)), new(0.0236241518602576d, new GammaParticle(39366.0, 0.0315)), new(0.02962468643276303d, new GammaParticle(39753.0, 0.03119)), new(0.00600053457250543d, new GammaParticle(40229.0, 0.03082)) } },
            { 0.0015d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium148()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.556d, new GammaParticle(158468.0, 0.00782)), new(0.01668d, new GammaParticle(252450.0, 0.00491)), new(0.003336d, new GammaParticle(257090.0, 0.00482)), new(0.06672d, new GammaParticle(295070.0, 0.0042)), new(0.007228d, new GammaParticle(298810.0, 0.00415)), new(0.006672d, new GammaParticle(369450.0, 0.00336)), new(0.039476d, new GammaParticle(378930.0, 0.00327)), new(0.0139d, new GammaParticle(387920.0, 0.0032)), new(0.010008d, new GammaParticle(425680.0, 0.00291)), new(0.011120000000000001d, new GammaParticle(433320.0, 0.00286)), new(0.009452d, new GammaParticle(482190.0, 0.00257)), new(0.005004d, new GammaParticle(536380.0, 0.00231)), new(0.076172d, new GammaParticle(601880.0, 0.00206)), new(0.028912d, new GammaParticle(611810.0, 0.00203)), new(0.007784d, new GammaParticle(654530.0, 0.00189)), new(0.015012000000000001d, new GammaParticle(663200.0, 0.00187)), new(0.064496d, new GammaParticle(682970.0, 0.00182)), new(0.005004d, new GammaParticle(713370.0, 0.00174)), new(0.085624d, new GammaParticle(760300.0, 0.00163)), new(0.005004d, new GammaParticle(770530.0, 0.00161)), new(0.071724d, new GammaParticle(777160.0, 0.0016)), new(0.007228d, new GammaParticle(794440.0, 0.00156)), new(0.013344d, new GammaParticle(819280.0, 0.00151)), new(0.051708d, new GammaParticle(831330.0, 0.00149)), new(0.004448d, new GammaParticle(887120.0, 0.0014)), new(0.005560000000000001d, new GammaParticle(921310.0, 0.00135)), new(0.039476d, new GammaParticle(958230.0, 0.00129)), new(0.003892d, new GammaParticle(967400.0, 0.00128)), new(0.09340799999999999d, new GammaParticle(989850.0, 0.00125)), new(0.003336d, new GammaParticle(1105060.0, 0.00112)), new(0.010564d, new GammaParticle(1130950.0, 0.0011)), new(0.006116d, new GammaParticle(1257420.0, 0.00099)), new(0.00834d, new GammaParticle(1298460.0, 0.00095)), new(0.001112d, new GammaParticle(1303300.0, 0.00095)), new(0.004448d, new GammaParticle(1316690.0, 0.00094)), new(0.017792d, new GammaParticle(1338640.0, 0.00093)), new(0.008896d, new GammaParticle(1425580.0, 0.00087)), new(0.013344d, new GammaParticle(1431560.0, 0.00087)), new(0.008896d, new GammaParticle(1464360.0, 0.00085)), new(0.006116d, new GammaParticle(1496970.0, 0.00083)), new(0.003892d, new GammaParticle(1569650.0, 0.00079)), new(0.00834d, new GammaParticle(1589930.0, 0.00078)), new(0.006672d, new GammaParticle(1732670.0, 0.00072)), new(0.008896d, new GammaParticle(1769270.0, 0.0007)), new(0.012232d, new GammaParticle(1891020.0, 0.00066)), new(0.024464d, new GammaParticle(1985930.0, 0.00062)), new(0.032804d, new GammaParticle(1995230.0, 0.00062)), new(0.011675999999999999d, new GammaParticle(2031170.0, 0.00061)), new(0.006672d, new GammaParticle(2033950.0, 0.00061)), new(0.07005600000000001d, new GammaParticle(2093660.0, 0.00059)), new(0.007228d, new GammaParticle(2153560.0, 0.00058)), new(0.015012000000000001d, new GammaParticle(2219890.0, 0.00056)), new(0.038919999999999996d, new GammaParticle(2391940.0, 0.00052)), new(0.003336d, new GammaParticle(2549800.0, 0.00049)), new(0.02445327418176d, new GammaParticle(5410.0, 0.22918)), new(0.0428265853233507d, new GammaParticle(34279.0, 0.03617)), new(0.07843696945668627d, new GammaParticle(34720.0, 0.03571)), new(0.0236241518602576d, new GammaParticle(39366.0, 0.0315)), new(0.02962468643276303d, new GammaParticle(39753.0, 0.03119)), new(0.00600053457250543d, new GammaParticle(40229.0, 0.03082)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000316317d },
            { 17000.0d, 0.0000332369d },
            { 34000.0d, 0.0000348717d },
            { 51000.0d, 0.0000365363d },
            { 68000.0d, 0.0000382374d },
            { 85000.0d, 0.0000399842d },
            { 102000.0d, 0.0000417738d },
            { 119000.0d, 0.0000436018d },
            { 136000.0d, 0.0000454645d },
            { 153000.0d, 0.0000473586d },
            { 170000.0d, 0.000049281d },
            { 187000.0d, 0.0000512295d },
            { 204000.0d, 0.000053202d },
            { 221000.0d, 0.0000551966d },
            { 238000.0d, 0.0000572116d },
            { 255000.0d, 0.0000592456d },
            { 272000.0d, 0.0000612972d },
            { 289000.0d, 0.0000633652d },
            { 306000.0d, 0.0000654485d },
            { 323000.0d, 0.0000675459d },
            { 340000.0d, 0.0000696565d },
            { 357000.0d, 0.0000717792d },
            { 374000.0d, 0.0000739131d },
            { 391000.0d, 0.0000760574d },
            { 408000.0d, 0.0000782111d },
            { 425000.0d, 0.0000803735d },
            { 442000.0d, 0.0000825438d },
            { 459000.0d, 0.0000847211d },
            { 476000.0d, 0.0000869047d },
            { 493000.0d, 0.0000890938d },
            { 510000.0d, 0.0000912879d },
            { 527000.0d, 0.0000934861d },
            { 544000.0d, 0.0000956877d },
            { 561000.0d, 0.0000978921d },
            { 578000.0d, 0.000100099d },
            { 595000.0d, 0.000102307d },
            { 612000.0d, 0.000104516d },
            { 629000.0d, 0.000106725d },
            { 646000.0d, 0.000108934d },
            { 663000.0d, 0.000111142d },
            { 680000.0d, 0.000113348d },
            { 697000.0d, 0.000115552d },
            { 714000.0d, 0.000117754d },
            { 731000.0d, 0.000119952d },
            { 748000.0d, 0.000122147d },
            { 765000.0d, 0.000124337d },
            { 782000.0d, 0.000126523d },
            { 799000.0d, 0.000128703d },
            { 816000.0d, 0.000130877d },
            { 833000.0d, 0.000133045d },
            { 850000.0d, 0.000135207d },
            { 867000.0d, 0.000137361d },
            { 884000.0d, 0.000139507d },
            { 901000.0d, 0.000141645d },
            { 918000.0d, 0.000143774d },
            { 935000.0d, 0.000145895d },
            { 952000.0d, 0.000148005d },
            { 969000.0d, 0.000150106d },
            { 986000.0d, 0.000152197d },
            { 1003000.0d, 0.000154277d },
            { 1028000.0d, 0.000157315d },
            { 1053000.0d, 0.000160327d },
            { 1078000.0d, 0.000163313d },
            { 1103000.0d, 0.000166271d },
            { 1128000.0d, 0.0001692d },
            { 1153000.0d, 0.000172098d },
            { 1178000.0d, 0.000174966d },
            { 1203000.0d, 0.000177801d },
            { 1228000.0d, 0.000180603d },
            { 1253000.0d, 0.00018337d },
            { 1278000.0d, 0.000186102d },
            { 1303000.0d, 0.000188798d },
            { 1328000.0d, 0.000191456d },
            { 1353000.0d, 0.000194076d },
            { 1378000.0d, 0.000196658d },
            { 1403000.0d, 0.0001992d },
            { 1428000.0d, 0.0002017d },
            { 1453000.0d, 0.00020416d },
            { 1478000.0d, 0.000206577d },
            { 1503000.0d, 0.000208951d },
            { 1528000.0d, 0.000211282d },
            { 1553000.0d, 0.000213569d },
            { 1578000.0d, 0.00021581d },
            { 1603000.0d, 0.000218006d },
            { 1628000.0d, 0.000220155d },
            { 1653000.0d, 0.000222258d },
            { 1678000.0d, 0.000224313d },
            { 1703000.0d, 0.000226321d },
            { 1728000.0d, 0.00022828d },
            { 1753000.0d, 0.00023019d },
            { 1778000.0d, 0.000232051d },
            { 1803000.0d, 0.000233861d },
            { 1828000.0d, 0.000235622d },
            { 1853000.0d, 0.000237332d },
            { 1878000.0d, 0.00023899d },
            { 1903000.0d, 0.000240597d },
            { 1928000.0d, 0.000242153d },
            { 1953000.0d, 0.000243656d },
            { 1978000.0d, 0.000245107d },
            { 2003000.0d, 0.000246504d },
            { 2028000.0d, 0.00024785d },
            { 2053000.0d, 0.000249141d },
            { 2078000.0d, 0.00025038d },
            { 2103000.0d, 0.000251564d },
            { 2128000.0d, 0.000252695d },
            { 2153000.0d, 0.000253772d },
            { 2178000.0d, 0.000254794d },
            { 2203000.0d, 0.000255762d },
            { 2228000.0d, 0.000256676d },
            { 2253000.0d, 0.000257535d },
            { 2278000.0d, 0.000258339d },
            { 2303000.0d, 0.000259089d },
            { 2328000.0d, 0.000259784d },
            { 2353000.0d, 0.000260425d },
            { 2378000.0d, 0.00026101d },
            { 2403000.0d, 0.000261541d },
            { 2428000.0d, 0.000262017d },
            { 2453000.0d, 0.000262438d },
            { 2478000.0d, 0.000262805d },
            { 2503000.0d, 0.000263117d },
            { 2528000.0d, 0.000263375d },
            { 2553000.0d, 0.000263579d },
            { 2578000.0d, 0.000263728d },
            { 2603000.0d, 0.000263823d },
            { 2628000.0d, 0.000263864d },
            { 2653000.0d, 0.000263852d },
            { 2678000.0d, 0.000263786d },
            { 2703000.0d, 0.000263666d },
            { 2728000.0d, 0.000263494d },
            { 2753000.0d, 0.000263269d },
            { 2778000.0d, 0.000262991d },
            { 2803000.0d, 0.00026266d },
            { 2828000.0d, 0.000262278d },
            { 2853000.0d, 0.000261843d },
            { 2878000.0d, 0.000261358d },
            { 2903000.0d, 0.000260821d },
            { 2928000.0d, 0.000260233d },
            { 2953000.0d, 0.000259595d },
            { 2978000.0d, 0.000258907d },
            { 3003000.0d, 0.000258169d },
            { 3028000.0d, 0.000257381d },
            { 3053000.0d, 0.000256545d },
            { 3078000.0d, 0.00025566d },
            { 3103000.0d, 0.000254728d },
            { 3128000.0d, 0.000253747d },
            { 3153000.0d, 0.00025272d },
            { 3178000.0d, 0.000251646d },
            { 3203000.0d, 0.000250526d },
            { 3228000.0d, 0.00024936d },
            { 3253000.0d, 0.000248149d },
            { 3278000.0d, 0.000246893d },
            { 3303000.0d, 0.000245594d },
            { 3328000.0d, 0.000244251d },
            { 3353000.0d, 0.000242865d },
            { 3378000.0d, 0.000241437d },
            { 3403000.0d, 0.000239967d },
            { 3428000.0d, 0.000238456d },
            { 3453000.0d, 0.000236904d },
            { 3478000.0d, 0.000235313d },
            { 3503000.0d, 0.000233682d },
            { 3528000.0d, 0.000232013d },
            { 3553000.0d, 0.000230306d },
            { 3578000.0d, 0.000228562d },
            { 3603000.0d, 0.000226782d },
            { 3628000.0d, 0.000224966d },
            { 3653000.0d, 0.000223114d },
            { 3678000.0d, 0.000221229d },
            { 3703000.0d, 0.00021931d },
            { 3728000.0d, 0.000217358d },
            { 3753000.0d, 0.000215374d },
            { 3778000.0d, 0.000213359d },
            { 3803000.0d, 0.000211314d },
            { 3828000.0d, 0.000209239d },
            { 3853000.0d, 0.000207135d },
            { 3878000.0d, 0.000205003d },
            { 3903000.0d, 0.000202845d },
            { 3928000.0d, 0.00020066d },
            { 3953000.0d, 0.000198449d },
            { 3978000.0d, 0.000196214d },
            { 4003000.0d, 0.000193956d },
            { 4028000.0d, 0.000191675d },
            { 4053000.0d, 0.000189372d },
            { 4078000.0d, 0.000187048d },
            { 4103000.0d, 0.000184704d },
            { 4128000.0d, 0.000182341d },
            { 4153000.0d, 0.00017996d },
            { 4178000.0d, 0.000177563d },
            { 4203000.0d, 0.000175149d },
            { 4228000.0d, 0.00017272d },
            { 4253000.0d, 0.000170277d },
            { 4278000.0d, 0.000167821d },
            { 4303000.0d, 0.000165353d },
            { 4328000.0d, 0.000162874d },
            { 4353000.0d, 0.000160385d },
            { 4378000.0d, 0.000157887d },
            { 4403000.0d, 0.000155382d },
            { 4428000.0d, 0.000152869d },
            { 4453000.0d, 0.000150351d },
            { 4478000.0d, 0.000147829d },
            { 4503000.0d, 0.000145303d },
            { 4528000.0d, 0.000142775d },
            { 4553000.0d, 0.000140245d },
            { 4578000.0d, 0.000137716d },
            { 4603000.0d, 0.000135188d },
            { 4628000.0d, 0.000132662d },
            { 4653000.0d, 0.000130139d },
            { 4678000.0d, 0.000127622d },
            { 4703000.0d, 0.00012511d },
            { 4728000.0d, 0.000122605d },
            { 4753000.0d, 0.000120108d },
            { 4778000.0d, 0.000117621d },
            { 4803000.0d, 0.000115145d },
            { 4828000.0d, 0.000112681d },
            { 4853000.0d, 0.00011023d },
            { 4878000.0d, 0.000107793d },
            { 4903000.0d, 0.000105373d },
            { 4928000.0d, 0.000102969d },
            { 4953000.0d, 0.000100584d },
            { 4978000.0d, 0.0000982183d },
            { 5003000.0d, 0.0000958738d },
            { 5028000.0d, 0.0000935516d },
            { 5053000.0d, 0.000091253d },
            { 5078000.0d, 0.0000889795d },
            { 5103000.0d, 0.0000867321d },
            { 5128000.0d, 0.0000845124d },
            { 5153000.0d, 0.0000823207d },
            { 5178000.0d, 0.0000801533d },
            { 5203000.0d, 0.0000780103d },
            { 5228000.0d, 0.0000758932d },
            { 5253000.0d, 0.0000738032d },
            { 5278000.0d, 0.0000717415d },
            { 5303000.0d, 0.0000697095d },
            { 5328000.0d, 0.0000677083d },
            { 5353000.0d, 0.0000657392d },
            { 5378000.0d, 0.0000638035d },
            { 5403000.0d, 0.0000619026d },
            { 5428000.0d, 0.0000600377d },
            { 5453000.0d, 0.0000582079d },
            { 5478000.0d, 0.0000564069d },
            { 5503000.0d, 0.0000546349d },
            { 5528000.0d, 0.0000528923d },
            { 5553000.0d, 0.0000511787d },
            { 5578000.0d, 0.0000494887d },
            { 5603000.0d, 0.0000478222d },
            { 5628000.0d, 0.0000461803d },
            { 5653000.0d, 0.0000445637d },
            { 5678000.0d, 0.0000429736d },
            { 5703000.0d, 0.000041411d },
            { 5728000.0d, 0.0000398767d },
            { 5753000.0d, 0.0000383719d },
            { 5778000.0d, 0.0000368971d },
            { 5803000.0d, 0.0000354527d },
            { 5828000.0d, 0.0000340373d },
            { 5853000.0d, 0.0000326507d },
            { 5878000.0d, 0.0000312938d },
            { 5903000.0d, 0.0000299676d },
            { 5928000.0d, 0.000028673d },
            { 5953000.0d, 0.0000274109d },
            { 5978000.0d, 0.0000261821d },
            { 6003000.0d, 0.0000249865d },
            { 6028000.0d, 0.0000238251d },
            { 6053000.0d, 0.0000226987d },
            { 6078000.0d, 0.0000216081d },
            { 6103000.0d, 0.0000205534d },
            { 6128000.0d, 0.0000195322d },
            { 6153000.0d, 0.0000185427d },
            { 6178000.0d, 0.0000175848d },
            { 6203000.0d, 0.0000166591d },
            { 6228000.0d, 0.000015764d },
            { 6253000.0d, 0.0000148991d },
            { 6278000.0d, 0.0000140646d },
            { 6303000.0d, 0.0000132598d },
            { 6328000.0d, 0.0000124845d },
            { 6353000.0d, 0.0000117351d },
            { 6378000.0d, 0.0000110109d },
            { 6403000.0d, 0.0000103125d },
            { 6428000.0d, 0.00000964067d },
            { 6453000.0d, 0.00000899595d },
            { 6478000.0d, 0.00000837894d },
            { 6503000.0d, 0.00000778967d },
            { 6528000.0d, 0.0000072287d },
            { 6553000.0d, 0.00000669666d },
            { 6578000.0d, 0.00000619413d },
            { 6603000.0d, 0.00000572045d },
            { 6628000.0d, 0.00000527561d },
            { 6653000.0d, 0.00000486021d },
            { 6678000.0d, 0.00000447484d },
            { 6703000.0d, 0.00000411996d },
            { 6728000.0d, 0.00000379119d },
            { 6753000.0d, 0.00000348588d },
            { 6778000.0d, 0.00000320266d },
            { 6803000.0d, 0.00000293984d },
            { 6828000.0d, 0.00000269784d },
            { 6853000.0d, 0.00000247698d },
            { 6878000.0d, 0.00000227452d },
            { 6903000.0d, 0.00000208911d },
            { 6928000.0d, 0.00000192093d },
            { 6953000.0d, 0.00000176461d },
            { 6978000.0d, 0.00000161435d },
            { 7003000.0d, 0.00000147026d },
            { 7028000.0d, 0.00000133253d },
            { 7053000.0d, 0.00000120129d },
            { 7078000.0d, 0.00000107672d },
            { 7103000.0d, 0.000000958971d },
            { 7128000.0d, 0.000000848214d },
            { 7153000.0d, 0.000000744611d },
            { 7178000.0d, 0.000000648325d },
            { 7203000.0d, 0.000000559518d },
            { 7228000.0d, 0.000000478348d },
            { 7253000.0d, 0.000000404531d },
            { 7278000.0d, 0.000000336687d },
            { 7303000.0d, 0.00000027478d },
            { 7328000.0d, 0.000000218906d },
            { 7353000.0d, 0.00000016916d },
            { 7378000.0d, 0.000000125636d },
            { 7403000.0d, 0.0000000884265d },
            { 7428000.0d, 0.0000000576221d },
            { 7453000.0d, 0.0000000333097d },
            { 7478000.0d, 0.0000000155715d },
            { 7503000.0d, 0.00000000447981d },
            { 7528000.0d, 0.0000000000829662d },
            { 7532000.0d, 0d },

        }; 
    }
}
    