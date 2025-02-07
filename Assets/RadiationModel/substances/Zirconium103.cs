using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium103";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 102.9272d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium103()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00000186528d },
            { 23000.0d, 0.00000200068d },
            { 46000.0d, 0.00000215044d },
            { 69000.0d, 0.00000231456d },
            { 92000.0d, 0.00000248841d },
            { 115000.0d, 0.00000266937d },
            { 138000.0d, 0.00000285602d },
            { 161000.0d, 0.00000304753d },
            { 184000.0d, 0.00000324337d },
            { 207000.0d, 0.00000344317d },
            { 230000.0d, 0.00000364665d },
            { 253000.0d, 0.00000385358d },
            { 276000.0d, 0.00000406377d },
            { 299000.0d, 0.00000427704d },
            { 322000.0d, 0.00000449324d },
            { 345000.0d, 0.00000471221d },
            { 368000.0d, 0.00000493382d },
            { 391000.0d, 0.00000515792d },
            { 414000.0d, 0.0000053844d },
            { 437000.0d, 0.00000561311d },
            { 460000.0d, 0.00000584394d },
            { 483000.0d, 0.00000607676d },
            { 506000.0d, 0.00000631146d },
            { 529000.0d, 0.00000654791d },
            { 552000.0d, 0.000006786d },
            { 575000.0d, 0.00000702561d },
            { 598000.0d, 0.00000726664d },
            { 621000.0d, 0.00000750898d },
            { 644000.0d, 0.0000077525d },
            { 667000.0d, 0.00000799712d },
            { 690000.0d, 0.00000824272d },
            { 713000.0d, 0.00000848919d },
            { 736000.0d, 0.00000873644d },
            { 759000.0d, 0.00000898436d },
            { 782000.0d, 0.00000923286d },
            { 805000.0d, 0.00000948183d },
            { 828000.0d, 0.00000973117d },
            { 851000.0d, 0.00000998081d },
            { 874000.0d, 0.0000102306d },
            { 897000.0d, 0.0000104805d },
            { 920000.0d, 0.0000107305d },
            { 943000.0d, 0.0000109803d },
            { 966000.0d, 0.0000112299d },
            { 989000.0d, 0.0000114793d },
            { 1012000.0d, 0.0000117283d },
            { 1035000.0d, 0.0000119769d },
            { 1058000.0d, 0.000012225d },
            { 1081000.0d, 0.0000124725d },
            { 1104000.0d, 0.0000127193d },
            { 1127000.0d, 0.0000129653d },
            { 1150000.0d, 0.0000132105d },
            { 1173000.0d, 0.0000134548d },
            { 1196000.0d, 0.000013698d },
            { 1219000.0d, 0.0000139402d },
            { 1242000.0d, 0.0000141812d },
            { 1265000.0d, 0.000014421d },
            { 1288000.0d, 0.0000146596d },
            { 1311000.0d, 0.0000148967d },
            { 1334000.0d, 0.0000151324d },
            { 1357000.0d, 0.0000153667d },
            { 1380000.0d, 0.0000155993d },
            { 1403000.0d, 0.0000158303d },
            { 1426000.0d, 0.0000160596d },
            { 1449000.0d, 0.0000162872d },
            { 1472000.0d, 0.0000165129d },
            { 1495000.0d, 0.0000167367d },
            { 1518000.0d, 0.0000169586d },
            { 1541000.0d, 0.0000171784d },
            { 1564000.0d, 0.0000173962d },
            { 1587000.0d, 0.0000176119d },
            { 1610000.0d, 0.0000178254d },
            { 1633000.0d, 0.0000180366d },
            { 1656000.0d, 0.0000182456d },
            { 1679000.0d, 0.0000184522d },
            { 1702000.0d, 0.0000186564d },
            { 1725000.0d, 0.0000188581d },
            { 1748000.0d, 0.0000190574d },
            { 1771000.0d, 0.0000192541d },
            { 1794000.0d, 0.0000194482d },
            { 1817000.0d, 0.0000196397d },
            { 1840000.0d, 0.0000198285d },
            { 1863000.0d, 0.0000200145d },
            { 1886000.0d, 0.0000201978d },
            { 1909000.0d, 0.0000203782d },
            { 1932000.0d, 0.0000205558d },
            { 1955000.0d, 0.0000207305d },
            { 1978000.0d, 0.0000209022d },
            { 2001000.0d, 0.000021071d },
            { 2024000.0d, 0.0000212367d },
            { 2047000.0d, 0.0000213994d },
            { 2070000.0d, 0.0000215589d },
            { 2093000.0d, 0.0000217154d },
            { 2116000.0d, 0.0000218687d },
            { 2139000.0d, 0.0000220187d },
            { 2162000.0d, 0.0000221656d },
            { 2185000.0d, 0.0000223092d },
            { 2208000.0d, 0.0000224495d },
            { 2231000.0d, 0.0000225865d },
            { 2254000.0d, 0.0000227201d },
            { 2277000.0d, 0.0000228504d },
            { 2300000.0d, 0.0000229772d },
            { 2323000.0d, 0.0000231007d },
            { 2346000.0d, 0.0000232207d },
            { 2369000.0d, 0.0000233372d },
            { 2392000.0d, 0.0000234502d },
            { 2415000.0d, 0.0000235596d },
            { 2438000.0d, 0.0000236656d },
            { 2461000.0d, 0.000023768d },
            { 2484000.0d, 0.0000238667d },
            { 2507000.0d, 0.0000239619d },
            { 2530000.0d, 0.0000240535d },
            { 2553000.0d, 0.0000241415d },
            { 2576000.0d, 0.0000242258d },
            { 2599000.0d, 0.0000243064d },
            { 2622000.0d, 0.0000243833d },
            { 2645000.0d, 0.0000244566d },
            { 2668000.0d, 0.0000245261d },
            { 2691000.0d, 0.000024592d },
            { 2714000.0d, 0.0000246541d },
            { 2737000.0d, 0.0000247125d },
            { 2760000.0d, 0.0000247671d },
            { 2783000.0d, 0.000024818d },
            { 2806000.0d, 0.0000248651d },
            { 2829000.0d, 0.0000249085d },
            { 2852000.0d, 0.0000249481d },
            { 2875000.0d, 0.0000249839d },
            { 2898000.0d, 0.0000250159d },
            { 2921000.0d, 0.0000250442d },
            { 2944000.0d, 0.0000250687d },
            { 2967000.0d, 0.0000250894d },
            { 2990000.0d, 0.0000251063d },
            { 3013000.0d, 0.0000251194d },
            { 3036000.0d, 0.0000251288d },
            { 3059000.0d, 0.0000251344d },
            { 3082000.0d, 0.0000251362d },
            { 3105000.0d, 0.0000251342d },
            { 3128000.0d, 0.0000251285d },
            { 3151000.0d, 0.000025119d },
            { 3174000.0d, 0.0000251057d },
            { 3197000.0d, 0.0000250887d },
            { 3220000.0d, 0.000025068d },
            { 3243000.0d, 0.0000250435d },
            { 3266000.0d, 0.0000250153d },
            { 3289000.0d, 0.0000249834d },
            { 3312000.0d, 0.0000249478d },
            { 3335000.0d, 0.0000249086d },
            { 3358000.0d, 0.0000248656d },
            { 3381000.0d, 0.000024819d },
            { 3404000.0d, 0.0000247687d },
            { 3427000.0d, 0.0000247148d },
            { 3450000.0d, 0.0000246573d },
            { 3473000.0d, 0.0000245962d },
            { 3496000.0d, 0.0000245315d },
            { 3519000.0d, 0.0000244633d },
            { 3542000.0d, 0.0000243915d },
            { 3565000.0d, 0.0000243162d },
            { 3588000.0d, 0.0000242374d },
            { 3611000.0d, 0.0000241551d },
            { 3634000.0d, 0.0000240693d },
            { 3657000.0d, 0.0000239802d },
            { 3680000.0d, 0.0000238876d },
            { 3703000.0d, 0.0000237916d },
            { 3726000.0d, 0.0000236922d },
            { 3749000.0d, 0.0000235895d },
            { 3772000.0d, 0.0000234836d },
            { 3795000.0d, 0.0000233743d },
            { 3818000.0d, 0.0000232618d },
            { 3841000.0d, 0.000023146d },
            { 3864000.0d, 0.0000230271d },
            { 3887000.0d, 0.000022905d },
            { 3910000.0d, 0.0000227797d },
            { 3933000.0d, 0.0000226514d },
            { 3956000.0d, 0.00002252d },
            { 3979000.0d, 0.0000223855d },
            { 4002000.0d, 0.0000222481d },
            { 4025000.0d, 0.0000221077d },
            { 4048000.0d, 0.0000219643d },
            { 4071000.0d, 0.0000218181d },
            { 4094000.0d, 0.000021669d },
            { 4117000.0d, 0.0000215171d },
            { 4140000.0d, 0.0000213624d },
            { 4163000.0d, 0.0000212049d },
            { 4186000.0d, 0.0000210448d },
            { 4209000.0d, 0.000020882d },
            { 4232000.0d, 0.0000207166d },
            { 4255000.0d, 0.0000205486d },
            { 4278000.0d, 0.0000203781d },
            { 4301000.0d, 0.0000202051d },
            { 4324000.0d, 0.0000200296d },
            { 4347000.0d, 0.0000198517d },
            { 4370000.0d, 0.0000196715d },
            { 4393000.0d, 0.000019489d },
            { 4416000.0d, 0.0000193042d },
            { 4439000.0d, 0.0000191172d },
            { 4462000.0d, 0.000018928d },
            { 4485000.0d, 0.0000187367d },
            { 4508000.0d, 0.0000185433d },
            { 4531000.0d, 0.000018348d },
            { 4554000.0d, 0.0000181506d },
            { 4577000.0d, 0.0000179513d },
            { 4600000.0d, 0.0000177502d },
            { 4623000.0d, 0.0000175473d },
            { 4646000.0d, 0.0000173426d },
            { 4669000.0d, 0.0000171362d },
            { 4692000.0d, 0.0000169281d },
            { 4715000.0d, 0.0000167185d },
            { 4738000.0d, 0.0000165073d },
            { 4761000.0d, 0.0000162947d },
            { 4784000.0d, 0.0000160806d },
            { 4807000.0d, 0.0000158652d },
            { 4830000.0d, 0.0000156485d },
            { 4853000.0d, 0.0000154305d },
            { 4876000.0d, 0.0000152113d },
            { 4899000.0d, 0.0000149911d },
            { 4922000.0d, 0.0000147697d },
            { 4945000.0d, 0.0000145474d },
            { 4968000.0d, 0.0000143241d },
            { 4991000.0d, 0.0000141d },
            { 5014000.0d, 0.000013875d },
            { 5037000.0d, 0.0000136494d },
            { 5060000.0d, 0.000013423d },
            { 5083000.0d, 0.000013196d },
            { 5106000.0d, 0.0000129685d },
            { 5129000.0d, 0.0000127405d },
            { 5152000.0d, 0.0000125121d },
            { 5175000.0d, 0.0000122834d },
            { 5198000.0d, 0.0000120544d },
            { 5221000.0d, 0.0000118252d },
            { 5244000.0d, 0.0000115959d },
            { 5267000.0d, 0.0000113665d },
            { 5290000.0d, 0.0000111371d },
            { 5313000.0d, 0.0000109078d },
            { 5336000.0d, 0.0000106787d },
            { 5359000.0d, 0.0000104498d },
            { 5382000.0d, 0.0000102212d },
            { 5405000.0d, 0.00000999295d },
            { 5428000.0d, 0.0000097652d },
            { 5451000.0d, 0.00000953798d },
            { 5474000.0d, 0.00000931137d },
            { 5497000.0d, 0.00000908544d },
            { 5520000.0d, 0.00000886028d },
            { 5543000.0d, 0.00000863596d },
            { 5566000.0d, 0.00000841257d },
            { 5589000.0d, 0.00000819017d },
            { 5612000.0d, 0.00000796886d },
            { 5635000.0d, 0.0000077487d },
            { 5658000.0d, 0.0000075298d },
            { 5681000.0d, 0.00000731221d },
            { 5704000.0d, 0.00000709604d },
            { 5727000.0d, 0.00000688135d },
            { 5750000.0d, 0.00000666824d },
            { 5773000.0d, 0.00000645679d },
            { 5796000.0d, 0.00000624707d },
            { 5819000.0d, 0.00000603919d },
            { 5842000.0d, 0.00000583322d },
            { 5865000.0d, 0.00000562925d },
            { 5888000.0d, 0.00000542737d },
            { 5911000.0d, 0.00000522766d },
            { 5934000.0d, 0.00000503021d },
            { 5957000.0d, 0.00000483511d },
            { 5980000.0d, 0.00000464245d },
            { 6003000.0d, 0.00000445232d },
            { 6026000.0d, 0.00000426481d },
            { 6049000.0d, 0.00000408001d },
            { 6072000.0d, 0.00000389801d },
            { 6095000.0d, 0.0000037189d },
            { 6118000.0d, 0.00000354278d },
            { 6141000.0d, 0.00000336973d },
            { 6164000.0d, 0.00000319985d },
            { 6187000.0d, 0.00000303323d },
            { 6210000.0d, 0.00000286997d },
            { 6233000.0d, 0.00000271016d },
            { 6256000.0d, 0.0000025539d },
            { 6279000.0d, 0.00000240127d },
            { 6302000.0d, 0.00000225239d },
            { 6325000.0d, 0.00000210734d },
            { 6348000.0d, 0.00000196622d },
            { 6371000.0d, 0.00000182912d },
            { 6394000.0d, 0.00000169616d },
            { 6417000.0d, 0.00000156741d },
            { 6440000.0d, 0.00000144298d },
            { 6463000.0d, 0.00000132298d },
            { 6486000.0d, 0.00000120749d },
            { 6509000.0d, 0.00000109662d },
            { 6532000.0d, 0.000000990463d },
            { 6555000.0d, 0.000000889126d },
            { 6578000.0d, 0.000000792705d },
            { 6601000.0d, 0.000000701302d },
            { 6624000.0d, 0.000000615016d },
            { 6647000.0d, 0.000000533948d },
            { 6670000.0d, 0.000000458198d },
            { 6693000.0d, 0.000000387868d },
            { 6716000.0d, 0.000000323057d },
            { 6739000.0d, 0.000000263866d },
            { 6762000.0d, 0.000000210395d },
            { 6785000.0d, 0.000000162743d },
            { 6808000.0d, 0.000000121008d },
            { 6831000.0d, 0.0000000852885d },
            { 6854000.0d, 0.0000000556789d },
            { 6877000.0d, 0.0000000322723d },
            { 6900000.0d, 0.0000000151568d },
            { 6923000.0d, 0.00000000441187d },
            { 6946000.0d, 0.0000000000951439d },
            { 6950000.0d, 0d },

        }; 
    }
}
    