using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine118 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine118";
        public override double halfLife { get; } = 822.0d;
        public override double atomicWeight { get; } = 117.91307d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony118()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0028710000000000003d, new GammaParticle(331000.0, 0.00375)), new(0.0232551d, new GammaParticle(351700.0, 0.00353)), new(0.0023925d, new GammaParticle(366500.0, 0.00338)), new(0.0078474d, new GammaParticle(496800.0, 0.0025)), new(0.0084216d, new GammaParticle(524400.0, 0.00236)), new(0.0012441000000000002d, new GammaParticle(528400.0, 0.00235)), new(0.100485d, new GammaParticle(545000.0, 0.00227)), new(0.0148335d, new GammaParticle(551800.0, 0.00225)), new(9.570000000000001e-05d, new GammaParticle(560000.0, 0.00221)), new(0.080388d, new GammaParticle(600600.0, 0.00206)), new(0.776127d, new GammaParticle(605600.0, 0.00205)), new(0.0013398d, new GammaParticle(626700.0, 0.00198)), new(0.0040194d, new GammaParticle(685200.0, 0.00181)), new(0.0043064999999999996d, new GammaParticle(712500.0, 0.00174)), new(0.0032538d, new GammaParticle(719600.0, 0.00172)), new(0.0033495d, new GammaParticle(738100.0, 0.00168)), new(0.013206599999999999d, new GammaParticle(741200.0, 0.00167)), new(0.0042108d, new GammaParticle(770000.0, 0.00161)), new(0.0008613d, new GammaParticle(793700.0, 0.00156)), new(0.0030624000000000003d, new GammaParticle(840000.0, 0.00148)), new(0.0028710000000000003d, new GammaParticle(869700.0, 0.00143)), new(0.0560802d, new GammaParticle(876400.0, 0.00141)), new(0.0023925d, new GammaParticle(905700.0, 0.00137)), new(0.0030624000000000003d, new GammaParticle(911600.0, 0.00136)), new(0.00022011d, new GammaParticle(957000.0, 0.0013)), new(0.0034452d, new GammaParticle(1018000.0, 0.00122)), new(0.0053592d, new GammaParticle(1023200.0, 0.00121)), new(0.0035409d, new GammaParticle(1055800.0, 0.00117)), new(0.0014355000000000001d, new GammaParticle(1079000.0, 0.00115)), new(0.0032538d, new GammaParticle(1097500.0, 0.00113)), new(0.037323d, new GammaParticle(1150600.0, 0.00108)), new(0.0032538d, new GammaParticle(1171700.0, 0.00106)), new(0.0036366d, new GammaParticle(1231700.0, 0.00101)), new(0.020097d, new GammaParticle(1257000.0, 0.00099)), new(0.0043064999999999996d, new GammaParticle(1286300.0, 0.00096)), new(0.0032538d, new GammaParticle(1325200.0, 0.00094)), new(0.07761269999999999d, new GammaParticle(1338800.0, 0.00093)), new(0.0071775d, new GammaParticle(1350300.0, 0.00092)), new(0.0039237d, new GammaParticle(1364700.0, 0.00091)), new(0.0089958d, new GammaParticle(1370400.0, 0.0009)), new(0.0030624000000000003d, new GammaParticle(1390400.0, 0.00089)), new(0.0159819d, new GammaParticle(1414900.0, 0.00088)), new(0.0071775d, new GammaParticle(1460700.0, 0.00085)), new(0.0068904d, new GammaParticle(1482000.0, 0.00084)), new(8.613e-06d, new GammaParticle(1517000.0, 0.00082)), new(0.0023925d, new GammaParticle(1524000.0, 0.00081)), new(0.0025839d, new GammaParticle(1662600.0, 0.00075)), new(0.0024882000000000003d, new GammaParticle(1679600.0, 0.00074)), new(0.0020097d, new GammaParticle(1747000.0, 0.00071)), new(0.0090915d, new GammaParticle(1767100.0, 0.0007)), new(0.0042108d, new GammaParticle(1771800.0, 0.0007)), new(0.006029099999999999d, new GammaParticle(1895500.0, 0.00065)), new(0.0042108d, new GammaParticle(2016700.0, 0.00061)), new(0.0066032999999999994d, new GammaParticle(2102200.0, 0.00059)), new(0.0026796d, new GammaParticle(2120200.0, 0.00058)), new(0.0028710000000000003d, new GammaParticle(2156400.0, 0.00057)), new(0.0066032999999999994d, new GammaParticle(2246600.0, 0.00055)), new(0.0028710000000000003d, new GammaParticle(2257000.0, 0.00055)), new(0.004976400000000001d, new GammaParticle(2288100.0, 0.00054)), new(1.8481200000000002d, new GammaParticle(511000.0, 0.00243)), new(0.0062d, new GammaParticle(4135.0, 0.29984)), new(0.0171d, new GammaParticle(27202.0, 0.04558)), new(0.0318d, new GammaParticle(27473.0, 0.04513)), new(0.0091d, new GammaParticle(31093.0, 0.03988)), new(0.0111d, new GammaParticle(31359.0, 0.03954)), new(0.00198d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 8000.0d, 0.000000011281d },
            { 16000.0d, 0.00000018253d },
            { 24000.0d, 0.00000051873d },
            { 32000.0d, 0.00000103482d },
            { 40000.0d, 0.00000172892d },
            { 48000.0d, 0.0000025736d },
            { 56000.0d, 0.00000354913d },
            { 64000.0d, 0.00000463684d },
            { 72000.0d, 0.0000058086d },
            { 80000.0d, 0.00000706366d },
            { 88000.0d, 0.0000083745d },
            { 96000.0d, 0.00000974206d },
            { 104000.0d, 0.0000111536d },
            { 114000.0d, 0.0000129684d },
            { 124000.0d, 0.0000148313d },
            { 134000.0d, 0.0000167315d },
            { 144000.0d, 0.0000186632d },
            { 154000.0d, 0.0000206183d },
            { 164000.0d, 0.0000225939d },
            { 174000.0d, 0.0000245848d },
            { 184000.0d, 0.0000265885d },
            { 194000.0d, 0.0000286015d },
            { 204000.0d, 0.0000306217d },
            { 214000.0d, 0.000032647d },
            { 224000.0d, 0.0000346761d },
            { 234000.0d, 0.000036707d },
            { 244000.0d, 0.0000387387d },
            { 254000.0d, 0.00004077d },
            { 264000.0d, 0.0000428001d },
            { 274000.0d, 0.0000448279d },
            { 284000.0d, 0.0000468528d },
            { 294000.0d, 0.000048874d },
            { 304000.0d, 0.0000508911d },
            { 314000.0d, 0.0000529034d },
            { 324000.0d, 0.0000549104d },
            { 334000.0d, 0.0000569117d },
            { 344000.0d, 0.0000589068d },
            { 354000.0d, 0.0000608953d },
            { 364000.0d, 0.000062877d },
            { 374000.0d, 0.0000648513d },
            { 384000.0d, 0.0000668182d },
            { 394000.0d, 0.0000687772d },
            { 404000.0d, 0.000070728d },
            { 414000.0d, 0.0000726704d },
            { 424000.0d, 0.0000746042d },
            { 434000.0d, 0.0000765291d },
            { 444000.0d, 0.000078445d },
            { 454000.0d, 0.0000803513d },
            { 464000.0d, 0.0000822481d },
            { 474000.0d, 0.0000841352d },
            { 484000.0d, 0.0000860122d },
            { 494000.0d, 0.0000878792d },
            { 504000.0d, 0.0000897359d },
            { 514000.0d, 0.000091582d },
            { 524000.0d, 0.0000934173d },
            { 534000.0d, 0.0000952419d },
            { 544000.0d, 0.0000970554d },
            { 554000.0d, 0.0000988578d },
            { 564000.0d, 0.000100649d },
            { 574000.0d, 0.000102428d },
            { 584000.0d, 0.000104196d },
            { 594000.0d, 0.000105952d },
            { 604000.0d, 0.000107696d },
            { 614000.0d, 0.000109428d },
            { 624000.0d, 0.000111148d },
            { 634000.0d, 0.000112856d },
            { 644000.0d, 0.000114551d },
            { 654000.0d, 0.000116233d },
            { 664000.0d, 0.000117903d },
            { 674000.0d, 0.00011956d },
            { 684000.0d, 0.000121204d },
            { 694000.0d, 0.000122835d },
            { 704000.0d, 0.000124453d },
            { 714000.0d, 0.000126057d },
            { 724000.0d, 0.000127648d },
            { 734000.0d, 0.000129226d },
            { 744000.0d, 0.00013079d },
            { 754000.0d, 0.00013234d },
            { 764000.0d, 0.000133877d },
            { 774000.0d, 0.000135399d },
            { 784000.0d, 0.000136908d },
            { 794000.0d, 0.000138403d },
            { 804000.0d, 0.000139883d },
            { 814000.0d, 0.00014135d },
            { 824000.0d, 0.000142801d },
            { 834000.0d, 0.000144239d },
            { 844000.0d, 0.000145662d },
            { 854000.0d, 0.00014707d },
            { 864000.0d, 0.000148464d },
            { 874000.0d, 0.000149843d },
            { 884000.0d, 0.000151208d },
            { 894000.0d, 0.000152557d },
            { 904000.0d, 0.000153892d },
            { 914000.0d, 0.000155212d },
            { 924000.0d, 0.000156516d },
            { 934000.0d, 0.000157806d },
            { 944000.0d, 0.00015908d },
            { 954000.0d, 0.00016034d },
            { 964000.0d, 0.000161584d },
            { 974000.0d, 0.000162812d },
            { 984000.0d, 0.000164026d },
            { 994000.0d, 0.000165224d },
            { 1004000.0d, 0.000166406d },
            { 1024000.0d, 0.000168725d },
            { 1044000.0d, 0.000170981d },
            { 1064000.0d, 0.000173175d },
            { 1084000.0d, 0.000175306d },
            { 1104000.0d, 0.000177374d },
            { 1124000.0d, 0.000179378d },
            { 1144000.0d, 0.00018132d },
            { 1164000.0d, 0.000183197d },
            { 1184000.0d, 0.000185011d },
            { 1204000.0d, 0.000186761d },
            { 1224000.0d, 0.000188448d },
            { 1244000.0d, 0.00019007d },
            { 1264000.0d, 0.000191629d },
            { 1284000.0d, 0.000193124d },
            { 1304000.0d, 0.000194555d },
            { 1324000.0d, 0.000195921d },
            { 1344000.0d, 0.000197225d },
            { 1364000.0d, 0.000198465d },
            { 1384000.0d, 0.000199641d },
            { 1404000.0d, 0.000200754d },
            { 1424000.0d, 0.000201804d },
            { 1444000.0d, 0.00020279d },
            { 1464000.0d, 0.000203715d },
            { 1484000.0d, 0.000204576d },
            { 1504000.0d, 0.000205376d },
            { 1524000.0d, 0.000206114d },
            { 1544000.0d, 0.00020679d },
            { 1564000.0d, 0.000207405d },
            { 1584000.0d, 0.000207959d },
            { 1604000.0d, 0.000208452d },
            { 1624000.0d, 0.000208885d },
            { 1644000.0d, 0.000209259d },
            { 1664000.0d, 0.000209573d },
            { 1684000.0d, 0.000209829d },
            { 1704000.0d, 0.000210026d },
            { 1724000.0d, 0.000210166d },
            { 1744000.0d, 0.000210248d },
            { 1764000.0d, 0.000210273d },
            { 1784000.0d, 0.000210242d },
            { 1804000.0d, 0.000210155d },
            { 1824000.0d, 0.000210014d },
            { 1844000.0d, 0.000209818d },
            { 1864000.0d, 0.000209568d },
            { 1884000.0d, 0.000209264d },
            { 1904000.0d, 0.000208909d },
            { 1924000.0d, 0.000208501d },
            { 1944000.0d, 0.000208042d },
            { 1964000.0d, 0.000207533d },
            { 1984000.0d, 0.000206973d },
            { 2004000.0d, 0.000206366d },
            { 2024000.0d, 0.000205709d },
            { 2044000.0d, 0.000205006d },
            { 2064000.0d, 0.000204255d },
            { 2084000.0d, 0.000203459d },
            { 2104000.0d, 0.000202618d },
            { 2124000.0d, 0.000201733d },
            { 2144000.0d, 0.000200804d },
            { 2164000.0d, 0.000199833d },
            { 2184000.0d, 0.000198821d },
            { 2204000.0d, 0.000197768d },
            { 2224000.0d, 0.000196676d },
            { 2244000.0d, 0.000195544d },
            { 2264000.0d, 0.000194376d },
            { 2284000.0d, 0.00019317d },
            { 2304000.0d, 0.000191929d },
            { 2324000.0d, 0.000190653d },
            { 2344000.0d, 0.000189343d },
            { 2364000.0d, 0.000188001d },
            { 2384000.0d, 0.000186627d },
            { 2404000.0d, 0.000185223d },
            { 2424000.0d, 0.000183789d },
            { 2444000.0d, 0.000182327d },
            { 2464000.0d, 0.000180839d },
            { 2484000.0d, 0.000179324d },
            { 2504000.0d, 0.000177785d },
            { 2524000.0d, 0.000176221d },
            { 2544000.0d, 0.000174636d },
            { 2564000.0d, 0.000173029d },
            { 2584000.0d, 0.000171403d },
            { 2604000.0d, 0.000169756d },
            { 2624000.0d, 0.000168088d },
            { 2644000.0d, 0.000166401d },
            { 2664000.0d, 0.000164695d },
            { 2684000.0d, 0.000162972d },
            { 2704000.0d, 0.000161234d },
            { 2724000.0d, 0.000159481d },
            { 2744000.0d, 0.000157714d },
            { 2764000.0d, 0.000155936d },
            { 2784000.0d, 0.000154141d },
            { 2804000.0d, 0.000152329d },
            { 2824000.0d, 0.000150501d },
            { 2844000.0d, 0.000148657d },
            { 2864000.0d, 0.0001468d },
            { 2884000.0d, 0.000144929d },
            { 2904000.0d, 0.000143047d },
            { 2924000.0d, 0.000141154d },
            { 2944000.0d, 0.000139252d },
            { 2964000.0d, 0.000137341d },
            { 2984000.0d, 0.000135423d },
            { 3004000.0d, 0.0001335d },
            { 3024000.0d, 0.000131571d },
            { 3044000.0d, 0.00012964d },
            { 3064000.0d, 0.000127707d },
            { 3084000.0d, 0.000125772d },
            { 3104000.0d, 0.000123839d },
            { 3124000.0d, 0.000121908d },
            { 3144000.0d, 0.000119979d },
            { 3164000.0d, 0.000118056d },
            { 3184000.0d, 0.000116137d },
            { 3204000.0d, 0.000114222d },
            { 3224000.0d, 0.000112312d },
            { 3244000.0d, 0.000110408d },
            { 3264000.0d, 0.000108512d },
            { 3284000.0d, 0.000106625d },
            { 3304000.0d, 0.000104746d },
            { 3324000.0d, 0.000102878d },
            { 3344000.0d, 0.00010102d },
            { 3364000.0d, 0.0000991758d },
            { 3384000.0d, 0.0000973456d },
            { 3404000.0d, 0.0000955308d },
            { 3424000.0d, 0.0000937316d },
            { 3444000.0d, 0.0000919472d },
            { 3464000.0d, 0.0000901784d },
            { 3484000.0d, 0.0000884256d },
            { 3504000.0d, 0.0000866896d },
            { 3524000.0d, 0.0000849711d },
            { 3544000.0d, 0.0000832679d },
            { 3564000.0d, 0.0000815798d },
            { 3584000.0d, 0.0000799081d },
            { 3604000.0d, 0.0000782534d },
            { 3624000.0d, 0.0000766168d },
            { 3644000.0d, 0.0000749997d },
            { 3664000.0d, 0.0000734028d },
            { 3684000.0d, 0.0000718255d },
            { 3704000.0d, 0.0000702689d },
            { 3724000.0d, 0.0000687329d },
            { 3744000.0d, 0.0000672183d },
            { 3764000.0d, 0.0000657261d },
            { 3784000.0d, 0.0000642578d },
            { 3804000.0d, 0.000062814d },
            { 3824000.0d, 0.0000613944d },
            { 3844000.0d, 0.0000600004d },
            { 3864000.0d, 0.0000586333d },
            { 3884000.0d, 0.0000572946d },
            { 3904000.0d, 0.0000559857d },
            { 3924000.0d, 0.0000547082d },
            { 3944000.0d, 0.0000534636d },
            { 3964000.0d, 0.0000522533d },
            { 3984000.0d, 0.0000510791d },
            { 4004000.0d, 0.0000499422d },
            { 4024000.0d, 0.0000488415d },
            { 4044000.0d, 0.0000477769d },
            { 4064000.0d, 0.000046747d },
            { 4084000.0d, 0.0000457473d },
            { 4104000.0d, 0.0000447665d },
            { 4124000.0d, 0.0000438047d },
            { 4144000.0d, 0.0000428619d },
            { 4164000.0d, 0.0000419357d },
            { 4184000.0d, 0.0000410234d },
            { 4204000.0d, 0.0000401245d },
            { 4224000.0d, 0.0000392398d },
            { 4244000.0d, 0.0000383703d },
            { 4264000.0d, 0.0000375171d },
            { 4284000.0d, 0.0000366807d },
            { 4304000.0d, 0.0000358624d },
            { 4324000.0d, 0.000035063d },
            { 4344000.0d, 0.0000342785d },
            { 4364000.0d, 0.0000335072d },
            { 4384000.0d, 0.0000327494d },
            { 4404000.0d, 0.0000320058d },
            { 4424000.0d, 0.000031277d },
            { 4444000.0d, 0.0000305636d },
            { 4464000.0d, 0.0000298666d },
            { 4484000.0d, 0.0000291868d },
            { 4504000.0d, 0.0000285246d },
            { 4524000.0d, 0.0000278801d },
            { 4544000.0d, 0.0000272532d },
            { 4564000.0d, 0.0000266377d },
            { 4584000.0d, 0.0000260308d },
            { 4604000.0d, 0.0000254332d },
            { 4624000.0d, 0.0000248452d },
            { 4644000.0d, 0.0000242678d },
            { 4664000.0d, 0.0000237014d },
            { 4684000.0d, 0.0000231467d },
            { 4704000.0d, 0.0000226043d },
            { 4724000.0d, 0.0000220749d },
            { 4744000.0d, 0.0000215593d },
            { 4764000.0d, 0.000021058d },
            { 4784000.0d, 0.0000205718d },
            { 4804000.0d, 0.0000201015d },
            { 4824000.0d, 0.0000196454d },
            { 4844000.0d, 0.0000191974d },
            { 4864000.0d, 0.0000187576d },
            { 4884000.0d, 0.0000183239d },
            { 4904000.0d, 0.0000178905d },
            { 4924000.0d, 0.0000174569d },
            { 4944000.0d, 0.0000170237d },
            { 4964000.0d, 0.0000165908d },
            { 4984000.0d, 0.0000161587d },
            { 5004000.0d, 0.0000157275d },
            { 5024000.0d, 0.0000152976d },
            { 5044000.0d, 0.0000148693d },
            { 5064000.0d, 0.0000144427d },
            { 5084000.0d, 0.0000140167d },
            { 5104000.0d, 0.0000135906d },
            { 5124000.0d, 0.0000131649d },
            { 5144000.0d, 0.0000127397d },
            { 5164000.0d, 0.0000123153d },
            { 5184000.0d, 0.0000118918d },
            { 5204000.0d, 0.0000114696d },
            { 5224000.0d, 0.000011049d },
            { 5244000.0d, 0.0000106303d },
            { 5264000.0d, 0.0000102137d },
            { 5284000.0d, 0.00000979955d },
            { 5304000.0d, 0.00000938817d },
            { 5324000.0d, 0.0000089799d },
            { 5344000.0d, 0.00000857505d },
            { 5364000.0d, 0.00000817398d },
            { 5384000.0d, 0.00000777705d },
            { 5404000.0d, 0.00000738462d },
            { 5424000.0d, 0.00000699707d },
            { 5444000.0d, 0.0000066148d },
            { 5464000.0d, 0.0000062382d },
            { 5484000.0d, 0.00000586768d },
            { 5504000.0d, 0.00000550366d },
            { 5524000.0d, 0.0000051466d },
            { 5544000.0d, 0.00000479692d },
            { 5564000.0d, 0.00000445509d },
            { 5584000.0d, 0.00000412158d },
            { 5604000.0d, 0.00000379687d },
            { 5624000.0d, 0.00000348147d },
            { 5644000.0d, 0.00000317588d },
            { 5664000.0d, 0.0000028806d },
            { 5684000.0d, 0.00000259619d },
            { 5704000.0d, 0.0000023232d },
            { 5724000.0d, 0.00000206216d },
            { 5744000.0d, 0.00000181366d },
            { 5764000.0d, 0.00000157829d },
            { 5784000.0d, 0.00000135664d },
            { 5804000.0d, 0.00000114931d },
            { 5824000.0d, 0.000000956945d },
            { 5844000.0d, 0.000000780166d },
            { 5864000.0d, 0.000000619626d },
            { 5884000.0d, 0.000000475983d },
            { 5904000.0d, 0.000000349905d },
            { 5924000.0d, 0.000000242075d },
            { 5944000.0d, 0.000000153177d },
            { 5964000.0d, 0.0000000839019d },
            { 5984000.0d, 0.0000000349339d },
            { 6004000.0d, 0.00000000693211d },
            { 6020000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    