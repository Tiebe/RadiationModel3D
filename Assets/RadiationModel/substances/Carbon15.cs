using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Carbon15 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon15";
        public override double halfLife { get; } = 2.449d;
        public override double atomicWeight { get; } = 15.0106d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nitrogen15()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(2.4000000000000003e-07d, new GammaParticle(977020.0, 0.00127)), new(1.8e-05d, new GammaParticle(1011750.0, 0.00123)), new(5e-06d, new GammaParticle(1157520.0, 0.00107)), new(4.7e-06d, new GammaParticle(1416280.0, 0.00088)), new(4.1e-06d, new GammaParticle(1748770.0, 0.00071)), new(1e-05d, new GammaParticle(1884770.0, 0.00066)), new(1.8e-05d, new GammaParticle(1988700.0, 0.00062)), new(1.9e-07d, new GammaParticle(2001860.0, 0.00062)), new(5.8e-07d, new GammaParticle(2030530.0, 0.00061)), new(1.8000000000000001e-06d, new GammaParticle(2247440.0, 0.00055)), new(1.5e-05d, new GammaParticle(2725660.0, 0.00045)), new(4.1e-05d, new GammaParticle(3013470.0, 0.00041)), new(1.4e-05d, new GammaParticle(3042130.0, 0.00041)), new(8.4e-05d, new GammaParticle(3300850.0, 0.00038)), new(1.1999999999999999e-05d, new GammaParticle(3779040.0, 0.00033)), new(3.7000000000000005e-05d, new GammaParticle(5269161.0, 0.00024)), new(0.632d, new GammaParticle(5297817.0, 0.00023)), new(5.4999999999999995e-05d, new GammaParticle(6322350.0, 0.0002)), new(9.499999999999999e-05d, new GammaParticle(7298920.0, 0.00017)), new(0.00032d, new GammaParticle(8310150.0, 0.00015)), new(4.3e-05d, new GammaParticle(8568770.0, 0.00014)), new(0.00031d, new GammaParticle(9046780.0, 0.00014)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000010736d },
            { 2000.0d, 0.0000113369d },
            { 4000.0d, 0.0000119297d },
            { 6000.0d, 0.0000125144d },
            { 8000.0d, 0.0000130893d },
            { 10000.0d, 0.0000136542d },
            { 12000.0d, 0.000014209d },
            { 14000.0d, 0.0000147541d },
            { 16000.0d, 0.0000152894d },
            { 18000.0d, 0.0000158152d },
            { 20000.0d, 0.0000163315d },
            { 22000.0d, 0.0000168383d },
            { 24000.0d, 0.0000173358d },
            { 26000.0d, 0.0000178241d },
            { 28000.0d, 0.0000183031d },
            { 30000.0d, 0.0000187729d },
            { 32000.0d, 0.0000192336d },
            { 34000.0d, 0.0000196852d },
            { 36000.0d, 0.0000201276d },
            { 38000.0d, 0.000020561d },
            { 40000.0d, 0.0000209854d },
            { 42000.0d, 0.0000214007d },
            { 44000.0d, 0.0000218237d },
            { 46000.0d, 0.000022242d },
            { 48000.0d, 0.0000226554d },
            { 50000.0d, 0.000023064d },
            { 52000.0d, 0.0000234679d },
            { 54000.0d, 0.000023867d },
            { 56000.0d, 0.0000242613d },
            { 58000.0d, 0.0000246581d },
            { 60000.0d, 0.000025052d },
            { 62000.0d, 0.0000254429d },
            { 64000.0d, 0.0000258309d },
            { 66000.0d, 0.000026216d },
            { 68000.0d, 0.0000265982d },
            { 70000.0d, 0.0000269775d },
            { 72000.0d, 0.0000273576d },
            { 74000.0d, 0.0000277358d },
            { 76000.0d, 0.000028112d },
            { 78000.0d, 0.0000284862d },
            { 80000.0d, 0.0000288586d },
            { 82000.0d, 0.000029229d },
            { 84000.0d, 0.0000295974d },
            { 86000.0d, 0.0000299662d },
            { 88000.0d, 0.0000303335d },
            { 90000.0d, 0.0000306996d },
            { 92000.0d, 0.0000310642d },
            { 94000.0d, 0.0000314275d },
            { 96000.0d, 0.0000317894d },
            { 98000.0d, 0.0000321509d },
            { 100000.0d, 0.0000325125d },
            { 110000.0d, 0.0000343072d },
            { 120000.0d, 0.000036085d },
            { 130000.0d, 0.0000378493d },
            { 140000.0d, 0.0000396046d },
            { 150000.0d, 0.0000413528d },
            { 160000.0d, 0.0000430947d },
            { 170000.0d, 0.0000448328d },
            { 180000.0d, 0.0000465682d },
            { 190000.0d, 0.0000483014d },
            { 200000.0d, 0.0000500334d },
            { 210000.0d, 0.000051765d },
            { 220000.0d, 0.0000534966d },
            { 230000.0d, 0.0000552287d },
            { 240000.0d, 0.0000569616d },
            { 250000.0d, 0.0000586955d },
            { 260000.0d, 0.0000604308d },
            { 270000.0d, 0.0000621676d },
            { 280000.0d, 0.000063906d },
            { 290000.0d, 0.0000656461d },
            { 300000.0d, 0.0000673879d },
            { 310000.0d, 0.0000691316d },
            { 320000.0d, 0.0000708771d },
            { 330000.0d, 0.0000726244d },
            { 340000.0d, 0.0000743734d },
            { 350000.0d, 0.0000761242d },
            { 360000.0d, 0.0000778766d },
            { 370000.0d, 0.0000796306d },
            { 380000.0d, 0.0000813863d },
            { 390000.0d, 0.0000831434d },
            { 400000.0d, 0.0000849018d },
            { 410000.0d, 0.0000866616d },
            { 420000.0d, 0.0000884224d },
            { 430000.0d, 0.0000901844d },
            { 440000.0d, 0.0000919473d },
            { 450000.0d, 0.0000937111d },
            { 460000.0d, 0.0000954756d },
            { 470000.0d, 0.0000972408d },
            { 480000.0d, 0.0000990064d },
            { 490000.0d, 0.000100772d },
            { 500000.0d, 0.000102539d },
            { 510000.0d, 0.000104305d },
            { 520000.0d, 0.000106072d },
            { 530000.0d, 0.000107838d },
            { 540000.0d, 0.000109605d },
            { 550000.0d, 0.000111371d },
            { 560000.0d, 0.000113136d },
            { 570000.0d, 0.000114901d },
            { 580000.0d, 0.000116666d },
            { 590000.0d, 0.00011843d },
            { 600000.0d, 0.000120193d },
            { 610000.0d, 0.000121955d },
            { 620000.0d, 0.000123715d },
            { 630000.0d, 0.000125474d },
            { 640000.0d, 0.000127233d },
            { 650000.0d, 0.000128991d },
            { 660000.0d, 0.000130745d },
            { 670000.0d, 0.0001325d },
            { 680000.0d, 0.000134253d },
            { 690000.0d, 0.000136003d },
            { 700000.0d, 0.000137752d },
            { 710000.0d, 0.000139499d },
            { 720000.0d, 0.000141244d },
            { 730000.0d, 0.000142986d },
            { 740000.0d, 0.000144724d },
            { 750000.0d, 0.000146458d },
            { 760000.0d, 0.000148187d },
            { 770000.0d, 0.000149911d },
            { 780000.0d, 0.00015163d },
            { 790000.0d, 0.000153344d },
            { 800000.0d, 0.000155053d },
            { 810000.0d, 0.000156755d },
            { 820000.0d, 0.000158452d },
            { 830000.0d, 0.000160144d },
            { 840000.0d, 0.000161829d },
            { 850000.0d, 0.000163508d },
            { 860000.0d, 0.00016518d },
            { 870000.0d, 0.000166846d },
            { 880000.0d, 0.000168506d },
            { 890000.0d, 0.000170158d },
            { 900000.0d, 0.000171803d },
            { 910000.0d, 0.000173441d },
            { 920000.0d, 0.000175071d },
            { 930000.0d, 0.000176694d },
            { 940000.0d, 0.00017831d },
            { 950000.0d, 0.000179917d },
            { 960000.0d, 0.000181517d },
            { 970000.0d, 0.000183109d },
            { 980000.0d, 0.000184692d },
            { 990000.0d, 0.000186267d },
            { 1000000.0d, 0.000187833d },
            { 1032000.0d, 0.000192785d },
            { 1064000.0d, 0.000197644d },
            { 1096000.0d, 0.000202403d },
            { 1128000.0d, 0.000207061d },
            { 1160000.0d, 0.000211612d },
            { 1192000.0d, 0.000216053d },
            { 1224000.0d, 0.000220379d },
            { 1256000.0d, 0.000224585d },
            { 1288000.0d, 0.000228668d },
            { 1320000.0d, 0.000232625d },
            { 1352000.0d, 0.000236451d },
            { 1384000.0d, 0.000240145d },
            { 1416000.0d, 0.000243703d },
            { 1448000.0d, 0.000247122d },
            { 1480000.0d, 0.000250398d },
            { 1512000.0d, 0.000253529d },
            { 1544000.0d, 0.000256509d },
            { 1576000.0d, 0.000259336d },
            { 1608000.0d, 0.000262008d },
            { 1640000.0d, 0.000264523d },
            { 1672000.0d, 0.00026688d },
            { 1704000.0d, 0.000269076d },
            { 1736000.0d, 0.00027111d },
            { 1768000.0d, 0.000272981d },
            { 1800000.0d, 0.000274687d },
            { 1832000.0d, 0.000276228d },
            { 1864000.0d, 0.000277601d },
            { 1896000.0d, 0.000278808d },
            { 1928000.0d, 0.000279847d },
            { 1960000.0d, 0.000280717d },
            { 1992000.0d, 0.00028142d },
            { 2024000.0d, 0.000281954d },
            { 2056000.0d, 0.000282319d },
            { 2088000.0d, 0.000282516d },
            { 2120000.0d, 0.000282546d },
            { 2152000.0d, 0.000282408d },
            { 2184000.0d, 0.000282105d },
            { 2216000.0d, 0.000281635d },
            { 2248000.0d, 0.000281002d },
            { 2280000.0d, 0.000280206d },
            { 2312000.0d, 0.000279248d },
            { 2344000.0d, 0.00027813d },
            { 2376000.0d, 0.000276854d },
            { 2408000.0d, 0.000275422d },
            { 2440000.0d, 0.000273835d },
            { 2472000.0d, 0.000272096d },
            { 2504000.0d, 0.000270208d },
            { 2536000.0d, 0.000268172d },
            { 2568000.0d, 0.000265992d },
            { 2600000.0d, 0.00026367d },
            { 2632000.0d, 0.000261209d },
            { 2664000.0d, 0.000258614d },
            { 2696000.0d, 0.000255885d },
            { 2728000.0d, 0.00025303d },
            { 2760000.0d, 0.000250048d },
            { 2792000.0d, 0.000246946d },
            { 2824000.0d, 0.000243726d },
            { 2856000.0d, 0.000240393d },
            { 2888000.0d, 0.000236953d },
            { 2920000.0d, 0.000233408d },
            { 2952000.0d, 0.000229764d },
            { 2984000.0d, 0.000226025d },
            { 3016000.0d, 0.000222196d },
            { 3048000.0d, 0.000218283d },
            { 3080000.0d, 0.00021429d },
            { 3112000.0d, 0.000210224d },
            { 3144000.0d, 0.000206089d },
            { 3176000.0d, 0.000201892d },
            { 3208000.0d, 0.000197638d },
            { 3240000.0d, 0.000193334d },
            { 3272000.0d, 0.000188985d },
            { 3304000.0d, 0.000184597d },
            { 3336000.0d, 0.000180179d },
            { 3368000.0d, 0.000175736d },
            { 3400000.0d, 0.000171275d },
            { 3432000.0d, 0.000166803d },
            { 3464000.0d, 0.000162327d },
            { 3496000.0d, 0.000157854d },
            { 3528000.0d, 0.000153393d },
            { 3560000.0d, 0.000148949d },
            { 3592000.0d, 0.000144532d },
            { 3624000.0d, 0.000140149d },
            { 3656000.0d, 0.000135809d },
            { 3688000.0d, 0.000131518d },
            { 3720000.0d, 0.000127286d },
            { 3752000.0d, 0.000123122d },
            { 3784000.0d, 0.000119033d },
            { 3816000.0d, 0.000115029d },
            { 3848000.0d, 0.000111119d },
            { 3880000.0d, 0.000107311d },
            { 3912000.0d, 0.000103614d },
            { 3944000.0d, 0.00010004d },
            { 3976000.0d, 0.0000965955d },
            { 4008000.0d, 0.0000932917d },
            { 4040000.0d, 0.0000901381d },
            { 4072000.0d, 0.0000871445d },
            { 4104000.0d, 0.0000843209d },
            { 4136000.0d, 0.0000816777d },
            { 4168000.0d, 0.0000792249d },
            { 4200000.0d, 0.000076973d },
            { 4232000.0d, 0.0000749326d },
            { 4264000.0d, 0.0000731143d },
            { 4296000.0d, 0.0000715285d },
            { 4328000.0d, 0.0000701862d },
            { 4360000.0d, 0.0000690981d },
            { 4392000.0d, 0.0000682749d },
            { 4424000.0d, 0.0000677273d },
            { 4456000.0d, 0.0000674652d },
            { 4488000.0d, 0.0000674622d },
            { 4520000.0d, 0.000067491d },
            { 4552000.0d, 0.0000675095d },
            { 4584000.0d, 0.0000675174d },
            { 4616000.0d, 0.0000675148d },
            { 4648000.0d, 0.0000675016d },
            { 4680000.0d, 0.0000674779d },
            { 4712000.0d, 0.0000674437d },
            { 4744000.0d, 0.000067399d },
            { 4776000.0d, 0.0000673438d },
            { 4808000.0d, 0.0000672782d },
            { 4840000.0d, 0.0000672021d },
            { 4872000.0d, 0.0000671156d },
            { 4904000.0d, 0.0000670187d },
            { 4936000.0d, 0.0000669114d },
            { 4968000.0d, 0.0000667938d },
            { 5000000.0d, 0.0000666658d },
            { 5032000.0d, 0.0000665276d },
            { 5064000.0d, 0.0000663791d },
            { 5096000.0d, 0.0000662205d },
            { 5128000.0d, 0.0000660515d },
            { 5160000.0d, 0.0000658726d },
            { 5192000.0d, 0.0000656835d },
            { 5224000.0d, 0.0000654845d },
            { 5256000.0d, 0.0000652754d },
            { 5288000.0d, 0.0000650563d },
            { 5320000.0d, 0.0000648275d },
            { 5352000.0d, 0.0000645888d },
            { 5384000.0d, 0.0000643404d },
            { 5416000.0d, 0.0000640822d },
            { 5448000.0d, 0.0000638144d },
            { 5480000.0d, 0.0000635371d },
            { 5512000.0d, 0.0000632502d },
            { 5544000.0d, 0.000062954d },
            { 5576000.0d, 0.0000626483d },
            { 5608000.0d, 0.0000623335d },
            { 5640000.0d, 0.0000620094d },
            { 5672000.0d, 0.0000616763d },
            { 5704000.0d, 0.000061334d },
            { 5736000.0d, 0.0000609829d },
            { 5768000.0d, 0.0000606229d },
            { 5800000.0d, 0.0000602541d },
            { 5832000.0d, 0.0000598767d },
            { 5864000.0d, 0.0000594907d },
            { 5896000.0d, 0.0000590962d },
            { 5928000.0d, 0.0000586933d },
            { 5960000.0d, 0.0000582823d },
            { 5992000.0d, 0.0000578629d },
            { 6024000.0d, 0.0000574356d },
            { 6056000.0d, 0.0000570003d },
            { 6088000.0d, 0.0000565572d },
            { 6120000.0d, 0.0000561063d },
            { 6152000.0d, 0.0000556478d },
            { 6184000.0d, 0.0000551819d },
            { 6216000.0d, 0.0000547086d },
            { 6248000.0d, 0.000054228d },
            { 6280000.0d, 0.0000537403d },
            { 6312000.0d, 0.0000532457d },
            { 6344000.0d, 0.0000527441d },
            { 6376000.0d, 0.0000522359d },
            { 6408000.0d, 0.0000517211d },
            { 6440000.0d, 0.0000511998d },
            { 6472000.0d, 0.0000506722d },
            { 6504000.0d, 0.0000501384d },
            { 6536000.0d, 0.0000495987d },
            { 6568000.0d, 0.000049053d },
            { 6600000.0d, 0.0000485016d },
            { 6632000.0d, 0.0000479447d },
            { 6664000.0d, 0.0000473823d },
            { 6696000.0d, 0.0000468147d },
            { 6728000.0d, 0.0000462419d },
            { 6760000.0d, 0.0000456642d },
            { 6792000.0d, 0.0000450818d },
            { 6824000.0d, 0.0000444947d },
            { 6856000.0d, 0.0000439032d },
            { 6888000.0d, 0.0000433074d },
            { 6920000.0d, 0.0000427074d },
            { 6952000.0d, 0.0000421036d },
            { 6984000.0d, 0.0000414961d },
            { 7016000.0d, 0.0000408849d },
            { 7048000.0d, 0.0000402704d },
            { 7080000.0d, 0.0000396526d },
            { 7112000.0d, 0.0000390317d },
            { 7144000.0d, 0.0000384082d },
            { 7176000.0d, 0.0000377819d },
            { 7208000.0d, 0.0000371532d },
            { 7240000.0d, 0.0000365223d },
            { 7272000.0d, 0.0000358893d },
            { 7304000.0d, 0.0000352543d },
            { 7336000.0d, 0.0000346178d },
            { 7368000.0d, 0.0000339799d },
            { 7400000.0d, 0.0000333406d },
            { 7432000.0d, 0.0000327004d },
            { 7464000.0d, 0.0000320593d },
            { 7496000.0d, 0.0000314175d },
            { 7528000.0d, 0.0000307755d },
            { 7560000.0d, 0.0000301332d },
            { 7592000.0d, 0.000029491d },
            { 7624000.0d, 0.0000288491d },
            { 7656000.0d, 0.0000282076d },
            { 7688000.0d, 0.0000275668d },
            { 7720000.0d, 0.000026927d },
            { 7752000.0d, 0.0000262884d },
            { 7784000.0d, 0.000025651d },
            { 7816000.0d, 0.0000250155d },
            { 7848000.0d, 0.0000243818d },
            { 7880000.0d, 0.0000237502d },
            { 7912000.0d, 0.0000231209d },
            { 7944000.0d, 0.0000224943d },
            { 7976000.0d, 0.0000218705d },
            { 8008000.0d, 0.0000212498d },
            { 8040000.0d, 0.0000206325d },
            { 8072000.0d, 0.0000200187d },
            { 8104000.0d, 0.0000194089d },
            { 8136000.0d, 0.0000188032d },
            { 8168000.0d, 0.0000182017d },
            { 8200000.0d, 0.000017605d },
            { 8232000.0d, 0.0000170131d },
            { 8264000.0d, 0.0000164264d },
            { 8296000.0d, 0.0000158451d },
            { 8328000.0d, 0.0000152696d },
            { 8360000.0d, 0.0000147d },
            { 8392000.0d, 0.0000141366d },
            { 8424000.0d, 0.0000135797d },
            { 8456000.0d, 0.0000130297d },
            { 8488000.0d, 0.0000124868d },
            { 8520000.0d, 0.0000119511d },
            { 8552000.0d, 0.0000114231d },
            { 8584000.0d, 0.0000109031d },
            { 8616000.0d, 0.0000103912d },
            { 8648000.0d, 0.00000988789d },
            { 8680000.0d, 0.00000939332d },
            { 8712000.0d, 0.00000890786d },
            { 8744000.0d, 0.00000843179d },
            { 8776000.0d, 0.0000079654d },
            { 8808000.0d, 0.00000750897d },
            { 8840000.0d, 0.00000706284d },
            { 8872000.0d, 0.00000662728d },
            { 8904000.0d, 0.0000062026d },
            { 8936000.0d, 0.00000578913d },
            { 8968000.0d, 0.00000538714d },
            { 9000000.0d, 0.00000499697d },
            { 9032000.0d, 0.00000461892d },
            { 9064000.0d, 0.0000042533d },
            { 9096000.0d, 0.00000390043d },
            { 9128000.0d, 0.00000356061d },
            { 9160000.0d, 0.00000323419d },
            { 9192000.0d, 0.00000292145d },
            { 9224000.0d, 0.00000262273d },
            { 9256000.0d, 0.00000233835d },
            { 9288000.0d, 0.00000206862d },
            { 9320000.0d, 0.00000181389d },
            { 9352000.0d, 0.00000157445d },
            { 9384000.0d, 0.00000135064d },
            { 9416000.0d, 0.00000114278d },
            { 9448000.0d, 0.000000951201d },
            { 9480000.0d, 0.000000776218d },
            { 9512000.0d, 0.000000618157d },
            { 9544000.0d, 0.000000477339d },
            { 9576000.0d, 0.00000035408d },
            { 9608000.0d, 0.000000248697d },
            { 9640000.0d, 0.000000161496d },
            { 9672000.0d, 0.0000000927755d },
            { 9704000.0d, 0.0000000428194d },
            { 9736000.0d, 0.0000000118783d },
            { 9768000.0d, 0.00000000012161d },
            { 9771700.0d, 0d },

        }; 
    }
}
    