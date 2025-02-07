using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium144";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 143.93305d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium144()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.21d, new GammaParticle(743000.0, 0.00167)), new(0.0063d, new GammaParticle(1133400.0, 0.00109)), new(0.039900000000000005d, new GammaParticle(1143900.0, 0.00108)), new(0.0105d, new GammaParticle(1483500.0, 0.00084)), new(0.0168d, new GammaParticle(1719100.0, 0.00072)), new(0.0084d, new GammaParticle(1876400.0, 0.00066)), new(0.0084d, new GammaParticle(2226500.0, 0.00056)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 18000.0d, 0.0000000363628d },
            { 36000.0d, 0.000000302212d },
            { 54000.0d, 0.000000803353d },
            { 72000.0d, 0.00000153542d },
            { 90000.0d, 0.00000245039d },
            { 108000.0d, 0.0000035107d },
            { 126000.0d, 0.00000467644d },
            { 144000.0d, 0.00000592846d },
            { 162000.0d, 0.00000724971d },
            { 180000.0d, 0.0000086252d },
            { 198000.0d, 0.0000100447d },
            { 216000.0d, 0.0000115025d },
            { 234000.0d, 0.0000129913d },
            { 252000.0d, 0.0000145058d },
            { 270000.0d, 0.0000160437d },
            { 288000.0d, 0.0000176015d },
            { 306000.0d, 0.0000191761d },
            { 324000.0d, 0.0000207663d },
            { 342000.0d, 0.0000223702d },
            { 360000.0d, 0.0000239862d },
            { 378000.0d, 0.0000256131d },
            { 396000.0d, 0.0000272501d },
            { 414000.0d, 0.0000288961d },
            { 432000.0d, 0.0000305502d },
            { 450000.0d, 0.000032212d },
            { 468000.0d, 0.0000338805d },
            { 486000.0d, 0.0000355551d },
            { 504000.0d, 0.0000372355d },
            { 522000.0d, 0.0000389212d },
            { 540000.0d, 0.0000406114d },
            { 558000.0d, 0.000042306d },
            { 576000.0d, 0.0000440043d },
            { 594000.0d, 0.0000457061d },
            { 612000.0d, 0.0000474109d },
            { 630000.0d, 0.0000491184d },
            { 648000.0d, 0.0000508282d },
            { 666000.0d, 0.0000525399d },
            { 684000.0d, 0.0000542533d },
            { 702000.0d, 0.000055968d },
            { 720000.0d, 0.0000576837d },
            { 738000.0d, 0.0000594001d },
            { 756000.0d, 0.0000611169d },
            { 774000.0d, 0.0000628337d },
            { 792000.0d, 0.0000645503d },
            { 810000.0d, 0.0000662665d },
            { 828000.0d, 0.0000679818d },
            { 846000.0d, 0.0000696961d },
            { 864000.0d, 0.0000714091d },
            { 882000.0d, 0.0000731204d },
            { 900000.0d, 0.0000748299d },
            { 918000.0d, 0.0000765372d },
            { 936000.0d, 0.0000782422d },
            { 954000.0d, 0.0000799445d },
            { 972000.0d, 0.000081644d },
            { 990000.0d, 0.0000833402d },
            { 1008000.0d, 0.0000850331d },
            { 1034000.0d, 0.0000874721d },
            { 1060000.0d, 0.0000899025d },
            { 1086000.0d, 0.0000923241d },
            { 1112000.0d, 0.0000947359d },
            { 1138000.0d, 0.0000971374d },
            { 1164000.0d, 0.0000995277d },
            { 1190000.0d, 0.000101906d },
            { 1216000.0d, 0.000104273d },
            { 1242000.0d, 0.000106626d },
            { 1268000.0d, 0.000108966d },
            { 1294000.0d, 0.000111291d },
            { 1320000.0d, 0.000113602d },
            { 1346000.0d, 0.000115897d },
            { 1372000.0d, 0.000118176d },
            { 1398000.0d, 0.000120438d },
            { 1424000.0d, 0.000122684d },
            { 1450000.0d, 0.000124911d },
            { 1476000.0d, 0.000127121d },
            { 1502000.0d, 0.000129311d },
            { 1528000.0d, 0.000131482d },
            { 1554000.0d, 0.000133633d },
            { 1580000.0d, 0.000135764d },
            { 1606000.0d, 0.000137874d },
            { 1632000.0d, 0.000139963d },
            { 1658000.0d, 0.00014203d },
            { 1684000.0d, 0.000144075d },
            { 1710000.0d, 0.000146097d },
            { 1736000.0d, 0.000148095d },
            { 1762000.0d, 0.00015007d },
            { 1788000.0d, 0.000152022d },
            { 1814000.0d, 0.000153948d },
            { 1840000.0d, 0.00015585d },
            { 1866000.0d, 0.000157726d },
            { 1892000.0d, 0.000159577d },
            { 1918000.0d, 0.000161402d },
            { 1944000.0d, 0.0001632d },
            { 1970000.0d, 0.000164971d },
            { 1996000.0d, 0.000166716d },
            { 2022000.0d, 0.000168433d },
            { 2048000.0d, 0.000170122d },
            { 2074000.0d, 0.000171783d },
            { 2100000.0d, 0.000173415d },
            { 2126000.0d, 0.000175019d },
            { 2152000.0d, 0.000176593d },
            { 2178000.0d, 0.000178138d },
            { 2204000.0d, 0.000179654d },
            { 2230000.0d, 0.00018114d },
            { 2256000.0d, 0.000182595d },
            { 2282000.0d, 0.00018402d },
            { 2308000.0d, 0.000185414d },
            { 2334000.0d, 0.000186778d },
            { 2360000.0d, 0.00018811d },
            { 2386000.0d, 0.00018941d },
            { 2412000.0d, 0.00019068d },
            { 2438000.0d, 0.000191917d },
            { 2464000.0d, 0.000193122d },
            { 2490000.0d, 0.000194296d },
            { 2516000.0d, 0.000195437d },
            { 2542000.0d, 0.000196545d },
            { 2568000.0d, 0.00019762d },
            { 2594000.0d, 0.000198662d },
            { 2620000.0d, 0.000199672d },
            { 2646000.0d, 0.000200649d },
            { 2672000.0d, 0.000201592d },
            { 2698000.0d, 0.000202501d },
            { 2724000.0d, 0.000203377d },
            { 2750000.0d, 0.00020422d },
            { 2776000.0d, 0.000205028d },
            { 2802000.0d, 0.000205803d },
            { 2828000.0d, 0.000206543d },
            { 2854000.0d, 0.00020725d },
            { 2880000.0d, 0.000207923d },
            { 2906000.0d, 0.000208562d },
            { 2932000.0d, 0.000209166d },
            { 2958000.0d, 0.000209735d },
            { 2984000.0d, 0.000210272d },
            { 3010000.0d, 0.000210773d },
            { 3036000.0d, 0.00021124d },
            { 3062000.0d, 0.000211674d },
            { 3088000.0d, 0.000212072d },
            { 3114000.0d, 0.000212436d },
            { 3140000.0d, 0.000212766d },
            { 3166000.0d, 0.000213061d },
            { 3192000.0d, 0.000213323d },
            { 3218000.0d, 0.00021355d },
            { 3244000.0d, 0.000213743d },
            { 3270000.0d, 0.000213902d },
            { 3296000.0d, 0.000214026d },
            { 3322000.0d, 0.000214116d },
            { 3348000.0d, 0.000214172d },
            { 3374000.0d, 0.000214195d },
            { 3400000.0d, 0.000214184d },
            { 3426000.0d, 0.000214139d },
            { 3452000.0d, 0.00021406d },
            { 3478000.0d, 0.000213948d },
            { 3504000.0d, 0.000213803d },
            { 3530000.0d, 0.000213624d },
            { 3556000.0d, 0.000213412d },
            { 3582000.0d, 0.000213168d },
            { 3608000.0d, 0.000212889d },
            { 3634000.0d, 0.000212579d },
            { 3660000.0d, 0.000212236d },
            { 3686000.0d, 0.000211861d },
            { 3712000.0d, 0.000211453d },
            { 3738000.0d, 0.000211014d },
            { 3764000.0d, 0.000210542d },
            { 3790000.0d, 0.000210039d },
            { 3816000.0d, 0.000209505d },
            { 3842000.0d, 0.000208939d },
            { 3868000.0d, 0.000208342d },
            { 3894000.0d, 0.000207715d },
            { 3920000.0d, 0.000207057d },
            { 3946000.0d, 0.000206369d },
            { 3972000.0d, 0.000205651d },
            { 3998000.0d, 0.000204903d },
            { 4024000.0d, 0.000204125d },
            { 4050000.0d, 0.000203318d },
            { 4076000.0d, 0.000202482d },
            { 4102000.0d, 0.000201618d },
            { 4128000.0d, 0.000200725d },
            { 4154000.0d, 0.000199804d },
            { 4180000.0d, 0.000198856d },
            { 4206000.0d, 0.00019788d },
            { 4232000.0d, 0.000196877d },
            { 4258000.0d, 0.000195846d },
            { 4284000.0d, 0.00019479d },
            { 4310000.0d, 0.000193707d },
            { 4336000.0d, 0.000192598d },
            { 4362000.0d, 0.000191464d },
            { 4388000.0d, 0.000190306d },
            { 4414000.0d, 0.000189122d },
            { 4440000.0d, 0.000187914d },
            { 4466000.0d, 0.000186682d },
            { 4492000.0d, 0.000185426d },
            { 4518000.0d, 0.000184148d },
            { 4544000.0d, 0.000182846d },
            { 4570000.0d, 0.000181523d },
            { 4596000.0d, 0.000180177d },
            { 4622000.0d, 0.00017881d },
            { 4648000.0d, 0.000177422d },
            { 4674000.0d, 0.000176014d },
            { 4700000.0d, 0.000174584d },
            { 4726000.0d, 0.000173136d },
            { 4752000.0d, 0.000171668d },
            { 4778000.0d, 0.000170181d },
            { 4804000.0d, 0.000168676d },
            { 4830000.0d, 0.000167154d },
            { 4856000.0d, 0.000165614d },
            { 4882000.0d, 0.000164057d },
            { 4908000.0d, 0.000162484d },
            { 4934000.0d, 0.000160895d },
            { 4960000.0d, 0.000159291d },
            { 4986000.0d, 0.000157672d },
            { 5012000.0d, 0.00015604d },
            { 5038000.0d, 0.000154393d },
            { 5064000.0d, 0.000152732d },
            { 5090000.0d, 0.00015106d },
            { 5116000.0d, 0.000149375d },
            { 5142000.0d, 0.000147679d },
            { 5168000.0d, 0.000145972d },
            { 5194000.0d, 0.000144255d },
            { 5220000.0d, 0.000142527d },
            { 5246000.0d, 0.000140791d },
            { 5272000.0d, 0.000139047d },
            { 5298000.0d, 0.000137295d },
            { 5324000.0d, 0.000135534d },
            { 5350000.0d, 0.000133767d },
            { 5376000.0d, 0.000131994d },
            { 5402000.0d, 0.000130217d },
            { 5428000.0d, 0.000128434d },
            { 5454000.0d, 0.000126647d },
            { 5480000.0d, 0.000124856d },
            { 5506000.0d, 0.000123062d },
            { 5532000.0d, 0.000121266d },
            { 5558000.0d, 0.000119469d },
            { 5584000.0d, 0.000117671d },
            { 5610000.0d, 0.000115872d },
            { 5636000.0d, 0.000114071d },
            { 5662000.0d, 0.000112269d },
            { 5688000.0d, 0.000110466d },
            { 5714000.0d, 0.000108664d },
            { 5740000.0d, 0.000106862d },
            { 5766000.0d, 0.000105062d },
            { 5792000.0d, 0.000103264d },
            { 5818000.0d, 0.000101468d },
            { 5844000.0d, 0.0000996759d },
            { 5870000.0d, 0.0000978851d },
            { 5896000.0d, 0.0000960963d },
            { 5922000.0d, 0.0000943105d },
            { 5948000.0d, 0.0000925281d },
            { 5974000.0d, 0.00009075d },
            { 6000000.0d, 0.0000889766d },
            { 6026000.0d, 0.0000872087d },
            { 6052000.0d, 0.0000854469d },
            { 6078000.0d, 0.000083692d },
            { 6104000.0d, 0.0000819446d },
            { 6130000.0d, 0.0000802053d },
            { 6156000.0d, 0.0000784749d },
            { 6182000.0d, 0.0000767529d },
            { 6208000.0d, 0.0000750356d },
            { 6234000.0d, 0.000073323d },
            { 6260000.0d, 0.0000716155d },
            { 6286000.0d, 0.0000699137d },
            { 6312000.0d, 0.0000682183d },
            { 6338000.0d, 0.00006653d },
            { 6364000.0d, 0.0000648491d },
            { 6390000.0d, 0.0000631764d },
            { 6416000.0d, 0.0000615126d },
            { 6442000.0d, 0.0000598582d },
            { 6468000.0d, 0.0000582138d },
            { 6494000.0d, 0.0000565802d },
            { 6520000.0d, 0.0000549579d },
            { 6546000.0d, 0.0000533475d },
            { 6572000.0d, 0.0000517498d },
            { 6598000.0d, 0.0000501653d },
            { 6624000.0d, 0.0000485947d },
            { 6650000.0d, 0.0000470388d },
            { 6676000.0d, 0.0000454982d },
            { 6702000.0d, 0.0000439734d },
            { 6728000.0d, 0.0000424652d },
            { 6754000.0d, 0.0000409743d },
            { 6780000.0d, 0.0000395013d },
            { 6806000.0d, 0.0000380471d },
            { 6832000.0d, 0.0000366122d },
            { 6858000.0d, 0.0000351973d },
            { 6884000.0d, 0.0000338031d },
            { 6910000.0d, 0.0000324304d },
            { 6936000.0d, 0.0000310799d },
            { 6962000.0d, 0.0000297522d },
            { 6988000.0d, 0.0000284481d },
            { 7014000.0d, 0.0000271683d },
            { 7040000.0d, 0.0000259136d },
            { 7066000.0d, 0.0000246846d },
            { 7092000.0d, 0.0000234822d },
            { 7118000.0d, 0.0000223069d },
            { 7144000.0d, 0.0000211597d },
            { 7170000.0d, 0.0000200411d },
            { 7196000.0d, 0.000018952d },
            { 7222000.0d, 0.0000178932d },
            { 7248000.0d, 0.0000168652d },
            { 7274000.0d, 0.0000158689d },
            { 7300000.0d, 0.000014905d },
            { 7326000.0d, 0.0000139721d },
            { 7352000.0d, 0.000013064d },
            { 7378000.0d, 0.0000121808d },
            { 7404000.0d, 0.000011323d },
            { 7430000.0d, 0.0000104914d },
            { 7456000.0d, 0.00000968657d },
            { 7482000.0d, 0.00000890903d },
            { 7508000.0d, 0.0000081595d },
            { 7534000.0d, 0.00000743857d },
            { 7560000.0d, 0.00000674687d },
            { 7586000.0d, 0.00000608503d },
            { 7612000.0d, 0.00000545368d },
            { 7638000.0d, 0.00000485346d },
            { 7664000.0d, 0.000004285d },
            { 7690000.0d, 0.00000374894d },
            { 7716000.0d, 0.00000324592d },
            { 7742000.0d, 0.00000277657d },
            { 7768000.0d, 0.00000234155d },
            { 7794000.0d, 0.00000194149d },
            { 7820000.0d, 0.00000157701d },
            { 7846000.0d, 0.00000124876d },
            { 7872000.0d, 0.000000957376d },
            { 7898000.0d, 0.000000703477d },
            { 7924000.0d, 0.00000048768d },
            { 7950000.0d, 0.000000310591d },
            { 7976000.0d, 0.000000172793d },
            { 8002000.0d, 0.0000000748334d },
            { 8028000.0d, 0.0000000171906d },
            { 8052000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    