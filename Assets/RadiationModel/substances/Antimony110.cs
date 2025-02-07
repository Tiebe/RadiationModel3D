using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony110 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony110";
        public override double halfLife { get; } = 23.6d;
        public override double atomicWeight { get; } = 109.91685d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium110()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.8319999999999999d, new GammaParticle(511000.0, 0.00243)), new(0.010076d, new GammaParticle(624400.0, 0.00199)), new(0.043052d, new GammaParticle(636500.0, 0.00195)), new(0.04122d, new GammaParticle(751500.0, 0.00165)), new(0.008244d, new GammaParticle(766800.0, 0.00162)), new(0.004122d, new GammaParticle(796200.0, 0.00156)), new(0.09434799999999999d, new GammaParticle(827100.0, 0.0015)), new(0.07786d, new GammaParticle(908900.0, 0.00136)), new(0.312356d, new GammaParticle(984700.0, 0.00126)), new(0.012824d, new GammaParticle(996700.0, 0.00124)), new(0.0229d, new GammaParticle(1025800.0, 0.00121)), new(0.0076028d, new GammaParticle(1101200.0, 0.00113)), new(0.9159999999999999d, new GammaParticle(1211700.0, 0.00102)), new(0.133736d, new GammaParticle(1243300.0, 0.001)), new(0.005038d, new GammaParticle(1325600.0, 0.00094)), new(0.015571999999999999d, new GammaParticle(1333600.0, 0.00093)), new(0.0047632d, new GammaParticle(1339200.0, 0.00093)), new(0.012824d, new GammaParticle(1351800.0, 0.00092)), new(0.0021984d, new GammaParticle(1375800.0, 0.0009)), new(0.0031144d, new GammaParticle(1419600.0, 0.00087)), new(0.012824d, new GammaParticle(1432600.0, 0.00087)), new(0.04213599999999999d, new GammaParticle(1482500.0, 0.00084)), new(0.0229d, new GammaParticle(1609500.0, 0.00077)), new(0.016488d, new GammaParticle(1621400.0, 0.00076)), new(0.0025648d, new GammaParticle(1702500.0, 0.00073)), new(0.070532d, new GammaParticle(1735900.0, 0.00071)), new(0.040304d, new GammaParticle(1765300.0, 0.0007)), new(0.0032976d, new GammaParticle(1780200.0, 0.0007)), new(0.048548d, new GammaParticle(1970900.0, 0.00063)), new(0.004122d, new GammaParticle(2010100.0, 0.00062)), new(0.03664d, new GammaParticle(2029100.0, 0.00061)), new(0.07328d, new GammaParticle(2120800.0, 0.00058)), new(0.0010992d, new GammaParticle(2172300.0, 0.00057)), new(0.0229d, new GammaParticle(2234900.0, 0.00055)), new(0.010992d, new GammaParticle(2328400.0, 0.00053)), new(0.008244d, new GammaParticle(2382400.0, 0.00052)), new(0.0071448d, new GammaParticle(2417800.0, 0.00051)), new(0.0054044d, new GammaParticle(2545400.0, 0.00049)), new(0.021067999999999996d, new GammaParticle(2673200.0, 0.00046)), new(0.0035724d, new GammaParticle(2834300.0, 0.00044)), new(0.0021984d, new GammaParticle(2915100.0, 0.00043)), new(1.854d, new GammaParticle(511000.0, 0.00243)), new(0.005064911409592128d, new GammaParticle(3753.0, 0.33036)), new(0.015803480663741654d, new GammaParticle(25044.0, 0.04951)), new(0.029577916271273916d, new GammaParticle(25271.0, 0.04906)), new(0.00836352227557597d, new GammaParticle(28579.0, 0.04338)), new(0.010011136163864436d, new GammaParticle(28810.0, 0.04304)), new(0.001647613888288466d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 7000.0d, 0.00000000814312d },
            { 14000.0d, 0.000000194692d },
            { 21000.0d, 0.000000571082d },
            { 28000.0d, 0.00000114136d },
            { 35000.0d, 0.00000191032d },
            { 42000.0d, 0.00000286252d },
            { 49000.0d, 0.00000396973d },
            { 56000.0d, 0.00000520902d },
            { 63000.0d, 0.00000655954d },
            { 70000.0d, 0.00000800715d },
            { 77000.0d, 0.00000953276d },
            { 84000.0d, 0.0000111305d },
            { 91000.0d, 0.0000127842d },
            { 98000.0d, 0.0000144902d },
            { 105000.0d, 0.0000162393d },
            { 115000.0d, 0.0000188012d },
            { 125000.0d, 0.0000214264d },
            { 135000.0d, 0.0000241027d },
            { 145000.0d, 0.0000268208d },
            { 155000.0d, 0.000029574d },
            { 165000.0d, 0.0000323555d },
            { 175000.0d, 0.0000351609d },
            { 185000.0d, 0.0000379862d },
            { 195000.0d, 0.0000408278d },
            { 205000.0d, 0.0000436827d },
            { 215000.0d, 0.0000465485d },
            { 225000.0d, 0.0000494236d },
            { 235000.0d, 0.0000523055d },
            { 245000.0d, 0.000055193d },
            { 255000.0d, 0.0000580849d },
            { 265000.0d, 0.0000609797d },
            { 275000.0d, 0.0000638765d },
            { 285000.0d, 0.0000667742d },
            { 295000.0d, 0.000069672d },
            { 305000.0d, 0.0000725693d },
            { 315000.0d, 0.0000754652d },
            { 325000.0d, 0.0000783591d },
            { 335000.0d, 0.0000812503d },
            { 345000.0d, 0.0000841384d },
            { 355000.0d, 0.0000870226d },
            { 365000.0d, 0.0000899027d },
            { 375000.0d, 0.0000927781d },
            { 385000.0d, 0.0000956483d },
            { 395000.0d, 0.000098513d },
            { 405000.0d, 0.000101372d },
            { 415000.0d, 0.000104224d },
            { 425000.0d, 0.000107069d },
            { 435000.0d, 0.000109908d },
            { 445000.0d, 0.000112738d },
            { 455000.0d, 0.000115561d },
            { 465000.0d, 0.000118376d },
            { 475000.0d, 0.000121182d },
            { 485000.0d, 0.000123979d },
            { 495000.0d, 0.000126768d },
            { 505000.0d, 0.000129546d },
            { 515000.0d, 0.000132315d },
            { 525000.0d, 0.000135074d },
            { 535000.0d, 0.000137822d },
            { 545000.0d, 0.00014056d },
            { 555000.0d, 0.000143287d },
            { 565000.0d, 0.000146002d },
            { 575000.0d, 0.000148706d },
            { 585000.0d, 0.000151398d },
            { 595000.0d, 0.000154078d },
            { 605000.0d, 0.000156745d },
            { 615000.0d, 0.000159401d },
            { 625000.0d, 0.000162043d },
            { 635000.0d, 0.000164672d },
            { 645000.0d, 0.000167287d },
            { 655000.0d, 0.00016989d },
            { 665000.0d, 0.000172478d },
            { 675000.0d, 0.000175052d },
            { 685000.0d, 0.000177612d },
            { 695000.0d, 0.000180157d },
            { 705000.0d, 0.000182687d },
            { 715000.0d, 0.000185202d },
            { 725000.0d, 0.000187702d },
            { 735000.0d, 0.000190187d },
            { 745000.0d, 0.000192656d },
            { 755000.0d, 0.000195109d },
            { 765000.0d, 0.000197545d },
            { 775000.0d, 0.000199966d },
            { 785000.0d, 0.00020237d },
            { 795000.0d, 0.000204757d },
            { 805000.0d, 0.000207127d },
            { 815000.0d, 0.00020948d },
            { 825000.0d, 0.000211816d },
            { 835000.0d, 0.000214134d },
            { 845000.0d, 0.000216435d },
            { 855000.0d, 0.000218717d },
            { 865000.0d, 0.000220982d },
            { 875000.0d, 0.000223228d },
            { 885000.0d, 0.000225456d },
            { 895000.0d, 0.000227665d },
            { 905000.0d, 0.000229856d },
            { 915000.0d, 0.000232027d },
            { 925000.0d, 0.00023418d },
            { 935000.0d, 0.000236313d },
            { 945000.0d, 0.000238427d },
            { 955000.0d, 0.000240521d },
            { 965000.0d, 0.000242595d },
            { 975000.0d, 0.00024465d },
            { 985000.0d, 0.000246684d },
            { 995000.0d, 0.000248699d },
            { 1005000.0d, 0.000250693d },
            { 1025000.0d, 0.00025462d },
            { 1045000.0d, 0.000258464d },
            { 1065000.0d, 0.000262225d },
            { 1085000.0d, 0.000265901d },
            { 1105000.0d, 0.000269492d },
            { 1125000.0d, 0.000272996d },
            { 1145000.0d, 0.000276413d },
            { 1165000.0d, 0.000279742d },
            { 1185000.0d, 0.000282983d },
            { 1205000.0d, 0.000286134d },
            { 1225000.0d, 0.000289196d },
            { 1245000.0d, 0.000292168d },
            { 1265000.0d, 0.000295048d },
            { 1285000.0d, 0.000297838d },
            { 1305000.0d, 0.000300536d },
            { 1325000.0d, 0.000303142d },
            { 1345000.0d, 0.000305656d },
            { 1365000.0d, 0.000308077d },
            { 1385000.0d, 0.000310405d },
            { 1405000.0d, 0.000312641d },
            { 1425000.0d, 0.000314783d },
            { 1445000.0d, 0.000316833d },
            { 1465000.0d, 0.00031879d },
            { 1485000.0d, 0.000320653d },
            { 1505000.0d, 0.000322424d },
            { 1525000.0d, 0.000324102d },
            { 1545000.0d, 0.000325688d },
            { 1565000.0d, 0.000327181d },
            { 1585000.0d, 0.000328583d },
            { 1605000.0d, 0.000329893d },
            { 1625000.0d, 0.000331111d },
            { 1645000.0d, 0.000332239d },
            { 1665000.0d, 0.000333276d },
            { 1685000.0d, 0.000334223d },
            { 1705000.0d, 0.000335081d },
            { 1725000.0d, 0.000335851d },
            { 1745000.0d, 0.000336532d },
            { 1765000.0d, 0.000337126d },
            { 1785000.0d, 0.000337634d },
            { 1805000.0d, 0.000338056d },
            { 1825000.0d, 0.000338393d },
            { 1845000.0d, 0.000338646d },
            { 1865000.0d, 0.000338816d },
            { 1885000.0d, 0.000338904d },
            { 1905000.0d, 0.000338911d },
            { 1925000.0d, 0.000338838d },
            { 1945000.0d, 0.000338686d },
            { 1965000.0d, 0.000338457d },
            { 1985000.0d, 0.000338151d },
            { 2005000.0d, 0.00033777d },
            { 2025000.0d, 0.000337315d },
            { 2045000.0d, 0.000336787d },
            { 2065000.0d, 0.000336189d },
            { 2085000.0d, 0.00033552d },
            { 2105000.0d, 0.000334784d },
            { 2125000.0d, 0.000333981d },
            { 2145000.0d, 0.000333113d },
            { 2165000.0d, 0.000332181d },
            { 2185000.0d, 0.000331188d },
            { 2205000.0d, 0.000330134d },
            { 2225000.0d, 0.000329022d },
            { 2245000.0d, 0.000327854d },
            { 2265000.0d, 0.00032663d },
            { 2285000.0d, 0.000325354d },
            { 2305000.0d, 0.000324027d },
            { 2325000.0d, 0.000322651d },
            { 2345000.0d, 0.000321227d },
            { 2365000.0d, 0.000319758d },
            { 2385000.0d, 0.000318231d },
            { 2405000.0d, 0.000316631d },
            { 2425000.0d, 0.000314958d },
            { 2445000.0d, 0.000313213d },
            { 2465000.0d, 0.000311397d },
            { 2485000.0d, 0.000309512d },
            { 2505000.0d, 0.000307557d },
            { 2525000.0d, 0.000305534d },
            { 2545000.0d, 0.000303445d },
            { 2565000.0d, 0.000301289d },
            { 2585000.0d, 0.00029907d },
            { 2605000.0d, 0.000296786d },
            { 2625000.0d, 0.00029444d },
            { 2645000.0d, 0.000292034d },
            { 2665000.0d, 0.000289567d },
            { 2685000.0d, 0.000287042d },
            { 2705000.0d, 0.00028446d },
            { 2725000.0d, 0.000281821d },
            { 2745000.0d, 0.000279129d },
            { 2765000.0d, 0.000276383d },
            { 2785000.0d, 0.000273584d },
            { 2805000.0d, 0.000270736d },
            { 2825000.0d, 0.000267839d },
            { 2845000.0d, 0.000264894d },
            { 2865000.0d, 0.000261903d },
            { 2885000.0d, 0.000258868d },
            { 2905000.0d, 0.00025579d },
            { 2925000.0d, 0.000252671d },
            { 2945000.0d, 0.000249513d },
            { 2965000.0d, 0.000246316d },
            { 2985000.0d, 0.000243084d },
            { 3005000.0d, 0.000239817d },
            { 3025000.0d, 0.000236517d },
            { 3045000.0d, 0.000233186d },
            { 3065000.0d, 0.000229826d },
            { 3085000.0d, 0.000226438d },
            { 3105000.0d, 0.000223025d },
            { 3125000.0d, 0.000219588d },
            { 3145000.0d, 0.00021613d },
            { 3165000.0d, 0.000212652d },
            { 3185000.0d, 0.000209155d },
            { 3205000.0d, 0.000205643d },
            { 3225000.0d, 0.000202117d },
            { 3245000.0d, 0.00019858d },
            { 3265000.0d, 0.000195032d },
            { 3285000.0d, 0.000191477d },
            { 3305000.0d, 0.000187916d },
            { 3325000.0d, 0.000184352d },
            { 3345000.0d, 0.000180787d },
            { 3365000.0d, 0.000177222d },
            { 3385000.0d, 0.000173661d },
            { 3405000.0d, 0.000170105d },
            { 3425000.0d, 0.000166557d },
            { 3445000.0d, 0.000163019d },
            { 3465000.0d, 0.000159493d },
            { 3485000.0d, 0.000155982d },
            { 3505000.0d, 0.000152483d },
            { 3525000.0d, 0.000148996d },
            { 3545000.0d, 0.000145521d },
            { 3565000.0d, 0.000142061d },
            { 3585000.0d, 0.000138618d },
            { 3605000.0d, 0.000135194d },
            { 3625000.0d, 0.000131792d },
            { 3645000.0d, 0.000128414d },
            { 3665000.0d, 0.000125062d },
            { 3685000.0d, 0.000121739d },
            { 3705000.0d, 0.000118446d },
            { 3725000.0d, 0.000115187d },
            { 3745000.0d, 0.000111964d },
            { 3765000.0d, 0.000108774d },
            { 3785000.0d, 0.000105619d },
            { 3805000.0d, 0.000102501d },
            { 3825000.0d, 0.0000994213d },
            { 3845000.0d, 0.0000963822d },
            { 3865000.0d, 0.0000933832d },
            { 3885000.0d, 0.0000904259d },
            { 3905000.0d, 0.0000875133d },
            { 3925000.0d, 0.0000846473d },
            { 3945000.0d, 0.0000818272d },
            { 3965000.0d, 0.0000790515d },
            { 3985000.0d, 0.0000763224d },
            { 4005000.0d, 0.0000736421d },
            { 4025000.0d, 0.0000710131d },
            { 4045000.0d, 0.0000684373d },
            { 4065000.0d, 0.0000659172d },
            { 4085000.0d, 0.0000634552d },
            { 4105000.0d, 0.0000610533d },
            { 4125000.0d, 0.0000587142d },
            { 4145000.0d, 0.0000564399d },
            { 4165000.0d, 0.0000542303d },
            { 4185000.0d, 0.0000520811d },
            { 4205000.0d, 0.0000499912d },
            { 4225000.0d, 0.0000479557d },
            { 4245000.0d, 0.0000459763d },
            { 4265000.0d, 0.0000440554d },
            { 4285000.0d, 0.0000421946d },
            { 4305000.0d, 0.0000403961d },
            { 4325000.0d, 0.0000386619d },
            { 4345000.0d, 0.000036994d },
            { 4365000.0d, 0.0000353943d },
            { 4385000.0d, 0.0000338651d },
            { 4405000.0d, 0.0000324081d },
            { 4425000.0d, 0.0000310244d },
            { 4445000.0d, 0.0000296955d },
            { 4465000.0d, 0.0000284059d },
            { 4485000.0d, 0.0000271564d },
            { 4505000.0d, 0.000025948d },
            { 4525000.0d, 0.000024782d },
            { 4545000.0d, 0.0000236591d },
            { 4565000.0d, 0.0000225722d },
            { 4585000.0d, 0.0000215161d },
            { 4605000.0d, 0.0000204914d },
            { 4625000.0d, 0.0000194992d },
            { 4645000.0d, 0.0000185404d },
            { 4665000.0d, 0.0000176161d },
            { 4685000.0d, 0.0000167267d },
            { 4705000.0d, 0.0000158684d },
            { 4725000.0d, 0.0000150408d },
            { 4745000.0d, 0.0000142448d },
            { 4765000.0d, 0.0000134812d },
            { 4785000.0d, 0.0000127509d },
            { 4805000.0d, 0.0000120547d },
            { 4825000.0d, 0.0000113937d },
            { 4845000.0d, 0.0000107676d },
            { 4865000.0d, 0.000010176d },
            { 4885000.0d, 0.00000961972d },
            { 4905000.0d, 0.00000909957d },
            { 4925000.0d, 0.00000861486d },
            { 4945000.0d, 0.00000815386d },
            { 4965000.0d, 0.00000771415d },
            { 4985000.0d, 0.00000729624d },
            { 5005000.0d, 0.00000690069d },
            { 5025000.0d, 0.00000652802d },
            { 5045000.0d, 0.00000617876d },
            { 5065000.0d, 0.00000585345d },
            { 5085000.0d, 0.00000555265d },
            { 5105000.0d, 0.00000527687d },
            { 5125000.0d, 0.00000502661d },
            { 5145000.0d, 0.00000480239d },
            { 5165000.0d, 0.00000460466d },
            { 5185000.0d, 0.00000443157d },
            { 5205000.0d, 0.00000426749d },
            { 5225000.0d, 0.00000410935d },
            { 5245000.0d, 0.00000395728d },
            { 5265000.0d, 0.00000381026d },
            { 5285000.0d, 0.00000366512d },
            { 5305000.0d, 0.00000352172d },
            { 5325000.0d, 0.00000338014d },
            { 5345000.0d, 0.00000324042d },
            { 5365000.0d, 0.00000310266d },
            { 5385000.0d, 0.00000296691d },
            { 5405000.0d, 0.00000283323d },
            { 5425000.0d, 0.0000027017d },
            { 5445000.0d, 0.00000257238d },
            { 5465000.0d, 0.00000244535d },
            { 5485000.0d, 0.00000232068d },
            { 5505000.0d, 0.00000219842d },
            { 5525000.0d, 0.00000207866d },
            { 5545000.0d, 0.00000196147d },
            { 5565000.0d, 0.0000018469d },
            { 5585000.0d, 0.00000173504d },
            { 5605000.0d, 0.00000162596d },
            { 5625000.0d, 0.00000151973d },
            { 5645000.0d, 0.00000141642d },
            { 5665000.0d, 0.00000131611d },
            { 5685000.0d, 0.00000121885d },
            { 5705000.0d, 0.00000112476d },
            { 5725000.0d, 0.00000103387d },
            { 5745000.0d, 0.000000946264d },
            { 5765000.0d, 0.00000086203d },
            { 5785000.0d, 0.000000781234d },
            { 5805000.0d, 0.000000703952d },
            { 5825000.0d, 0.000000630261d },
            { 5845000.0d, 0.000000560235d },
            { 5865000.0d, 0.000000493951d },
            { 5885000.0d, 0.000000431483d },
            { 5905000.0d, 0.000000372911d },
            { 5925000.0d, 0.000000318308d },
            { 5945000.0d, 0.000000267751d },
            { 5965000.0d, 0.000000221318d },
            { 5985000.0d, 0.000000179084d },
            { 6005000.0d, 0.000000141125d },
            { 6025000.0d, 0.000000107518d },
            { 6045000.0d, 0.0000000783364d },
            { 6065000.0d, 0.0000000536554d },
            { 6085000.0d, 0.0000000335475d },
            { 6105000.0d, 0.0000000180833d },
            { 6125000.0d, 0.0000000073287d },
            { 6145000.0d, 0.00000000134099d },
            { 6160000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    