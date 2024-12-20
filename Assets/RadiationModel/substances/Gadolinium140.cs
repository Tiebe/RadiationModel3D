using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium140";
        public override double halfLife { get; } = 15.8d;
        public override double atomicWeight { get; } = 139.93367d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium140()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.1188d, new GammaParticle(174800.0, 0.00709)), new(0.011000000000000001d, new GammaParticle(185300.0, 0.00669)), new(0.00418d, new GammaParticle(186700.0, 0.00664)), new(0.053899999999999997d, new GammaParticle(191200.0, 0.00648)), new(0.00979d, new GammaParticle(236700.0, 0.00524)), new(0.00979d, new GammaParticle(253300.0, 0.00489)), new(0.00836d, new GammaParticle(261800.0, 0.00474)), new(0.00209d, new GammaParticle(269000.0, 0.00461)), new(0.00099d, new GammaParticle(272400.0, 0.00455)), new(0.01111d, new GammaParticle(278400.0, 0.00445)), new(0.01397d, new GammaParticle(296600.0, 0.00418)), new(0.0014299999999999998d, new GammaParticle(304500.0, 0.00407)), new(0.0132d, new GammaParticle(313500.0, 0.00395)), new(0.00209d, new GammaParticle(344500.0, 0.0036)), new(0.00418d, new GammaParticle(372000.0, 0.00333)), new(0.0594d, new GammaParticle(379000.0, 0.00327)), new(0.0429d, new GammaParticle(417700.0, 0.00297)), new(0.01254d, new GammaParticle(427900.0, 0.0029)), new(0.0077d, new GammaParticle(436400.0, 0.00284)), new(0.0069299999999999995d, new GammaParticle(446900.0, 0.00277)), new(0.0209d, new GammaParticle(453400.0, 0.00273)), new(0.01045d, new GammaParticle(495800.0, 0.0025)), new(0.009899999999999999d, new GammaParticle(532000.0, 0.00233)), new(0.022330000000000003d, new GammaParticle(546500.0, 0.00227)), new(0.0363d, new GammaParticle(558700.0, 0.00222)), new(0.0429d, new GammaParticle(575400.0, 0.00215)), new(0.0066d, new GammaParticle(686200.0, 0.00181)), new(0.01045d, new GammaParticle(708100.0, 0.00175)), new(0.0297d, new GammaParticle(722300.0, 0.00172)), new(0.11d, new GammaParticle(749900.0, 0.00165)), new(0.0035199999999999997d, new GammaParticle(903200.0, 0.00137)), new(0.009899999999999999d, new GammaParticle(918000.0, 0.00135)), new(0.0143d, new GammaParticle(1041400.0, 0.00119)), new(0.00561d, new GammaParticle(1131100.0, 0.0011)), new(1.4709999999999999d, new GammaParticle(511000.0, 0.00243)), new(0.043944666819647996d, new GammaParticle(6603.0, 0.18777)), new(0.06914162504370967d, new GammaParticle(40901.0, 0.03031)), new(0.12475933786306329d, new GammaParticle(41541.0, 0.02985)), new(0.03930424923785938d, new GammaParticle(47146.0, 0.0263)), new(0.0494447455412271d, new GammaParticle(47645.0, 0.02602)), new(0.01014049630336772d, new GammaParticle(48248.0, 0.0257)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 9000.0d, 0.0000000191003d },
            { 18000.0d, 0.00000022652d },
            { 27000.0d, 0.000000650413d },
            { 36000.0d, 0.00000137821d },
            { 45000.0d, 0.00000239852d },
            { 54000.0d, 0.00000369552d },
            { 63000.0d, 0.0000052381d },
            { 72000.0d, 0.00000699851d },
            { 81000.0d, 0.00000894939d },
            { 90000.0d, 0.0000110647d },
            { 99000.0d, 0.000013321d },
            { 108000.0d, 0.0000157006d },
            { 118000.0d, 0.0000184678d },
            { 128000.0d, 0.0000213449d },
            { 138000.0d, 0.0000243165d },
            { 148000.0d, 0.0000273682d },
            { 158000.0d, 0.0000304878d },
            { 168000.0d, 0.0000336643d },
            { 178000.0d, 0.0000368887d },
            { 188000.0d, 0.0000401543d },
            { 198000.0d, 0.0000434542d },
            { 208000.0d, 0.0000467828d },
            { 218000.0d, 0.0000501346d },
            { 228000.0d, 0.0000535058d },
            { 238000.0d, 0.0000568925d },
            { 248000.0d, 0.0000602914d },
            { 258000.0d, 0.0000636993d },
            { 268000.0d, 0.0000671139d },
            { 278000.0d, 0.0000705325d },
            { 288000.0d, 0.0000739533d },
            { 298000.0d, 0.000077374d },
            { 308000.0d, 0.0000807933d },
            { 318000.0d, 0.0000842095d },
            { 328000.0d, 0.0000876212d },
            { 338000.0d, 0.000091027d },
            { 348000.0d, 0.0000944259d },
            { 358000.0d, 0.0000978166d },
            { 368000.0d, 0.000101198d },
            { 378000.0d, 0.00010457d },
            { 388000.0d, 0.00010793d },
            { 398000.0d, 0.000111279d },
            { 408000.0d, 0.000114616d },
            { 418000.0d, 0.000117939d },
            { 428000.0d, 0.000121248d },
            { 438000.0d, 0.000124543d },
            { 448000.0d, 0.000127822d },
            { 458000.0d, 0.000131086d },
            { 468000.0d, 0.000134334d },
            { 478000.0d, 0.000137565d },
            { 488000.0d, 0.000140778d },
            { 498000.0d, 0.000143974d },
            { 508000.0d, 0.000147152d },
            { 518000.0d, 0.000150311d },
            { 528000.0d, 0.000153451d },
            { 538000.0d, 0.000156571d },
            { 548000.0d, 0.000159672d },
            { 558000.0d, 0.000162752d },
            { 568000.0d, 0.000165812d },
            { 578000.0d, 0.000168851d },
            { 588000.0d, 0.000171868d },
            { 598000.0d, 0.000174864d },
            { 608000.0d, 0.000177838d },
            { 618000.0d, 0.000180789d },
            { 628000.0d, 0.000183718d },
            { 638000.0d, 0.000186624d },
            { 648000.0d, 0.000189507d },
            { 658000.0d, 0.000192366d },
            { 668000.0d, 0.000195202d },
            { 678000.0d, 0.000198013d },
            { 688000.0d, 0.0002008d },
            { 698000.0d, 0.000203563d },
            { 708000.0d, 0.000206301d },
            { 718000.0d, 0.000209014d },
            { 728000.0d, 0.000211701d },
            { 738000.0d, 0.000214363d },
            { 748000.0d, 0.000216999d },
            { 758000.0d, 0.000219609d },
            { 768000.0d, 0.000222193d },
            { 778000.0d, 0.000224751d },
            { 788000.0d, 0.000227282d },
            { 798000.0d, 0.000229786d },
            { 808000.0d, 0.000232263d },
            { 818000.0d, 0.000234713d },
            { 828000.0d, 0.000237135d },
            { 838000.0d, 0.00023953d },
            { 848000.0d, 0.000241897d },
            { 858000.0d, 0.000244236d },
            { 868000.0d, 0.000246547d },
            { 878000.0d, 0.00024883d },
            { 888000.0d, 0.000251084d },
            { 898000.0d, 0.000253309d },
            { 908000.0d, 0.000255506d },
            { 918000.0d, 0.000257673d },
            { 928000.0d, 0.000259812d },
            { 938000.0d, 0.000261921d },
            { 948000.0d, 0.000264001d },
            { 958000.0d, 0.000266052d },
            { 968000.0d, 0.000268073d },
            { 978000.0d, 0.000270064d },
            { 988000.0d, 0.000272025d },
            { 998000.0d, 0.000273956d },
            { 1008000.0d, 0.000275858d },
            { 1021000.0d, 0.000278284d },
            { 1034000.0d, 0.000280659d },
            { 1047000.0d, 0.000282982d },
            { 1060000.0d, 0.000285254d },
            { 1073000.0d, 0.000287473d },
            { 1086000.0d, 0.000289641d },
            { 1099000.0d, 0.000291755d },
            { 1112000.0d, 0.000293818d },
            { 1125000.0d, 0.000295827d },
            { 1138000.0d, 0.000297783d },
            { 1151000.0d, 0.000299687d },
            { 1164000.0d, 0.000301538d },
            { 1177000.0d, 0.000303335d },
            { 1190000.0d, 0.000305079d },
            { 1203000.0d, 0.00030677d },
            { 1216000.0d, 0.000308406d },
            { 1229000.0d, 0.000309988d },
            { 1242000.0d, 0.000311518d },
            { 1255000.0d, 0.000312993d },
            { 1268000.0d, 0.000314414d },
            { 1281000.0d, 0.000315782d },
            { 1294000.0d, 0.000317095d },
            { 1307000.0d, 0.000318354d },
            { 1320000.0d, 0.00031956d },
            { 1333000.0d, 0.000320711d },
            { 1346000.0d, 0.000321808d },
            { 1359000.0d, 0.000322852d },
            { 1372000.0d, 0.00032384d },
            { 1385000.0d, 0.000324775d },
            { 1398000.0d, 0.000325656d },
            { 1411000.0d, 0.000326484d },
            { 1424000.0d, 0.000327257d },
            { 1437000.0d, 0.000327977d },
            { 1450000.0d, 0.000328642d },
            { 1463000.0d, 0.000329255d },
            { 1476000.0d, 0.000329814d },
            { 1489000.0d, 0.000330319d },
            { 1502000.0d, 0.000330771d },
            { 1515000.0d, 0.00033117d },
            { 1528000.0d, 0.000331515d },
            { 1541000.0d, 0.000331808d },
            { 1554000.0d, 0.000332048d },
            { 1567000.0d, 0.000332235d },
            { 1580000.0d, 0.00033237d },
            { 1593000.0d, 0.000332452d },
            { 1606000.0d, 0.000332483d },
            { 1619000.0d, 0.000332462d },
            { 1632000.0d, 0.000332388d },
            { 1645000.0d, 0.000332263d },
            { 1658000.0d, 0.000332087d },
            { 1671000.0d, 0.00033186d },
            { 1684000.0d, 0.000331582d },
            { 1697000.0d, 0.000331254d },
            { 1710000.0d, 0.000330875d },
            { 1723000.0d, 0.000330446d },
            { 1736000.0d, 0.000329967d },
            { 1749000.0d, 0.000329439d },
            { 1762000.0d, 0.000328862d },
            { 1775000.0d, 0.000328235d },
            { 1788000.0d, 0.00032756d },
            { 1801000.0d, 0.000326837d },
            { 1814000.0d, 0.000326066d },
            { 1827000.0d, 0.000325247d },
            { 1840000.0d, 0.000324381d },
            { 1853000.0d, 0.000323468d },
            { 1866000.0d, 0.000322508d },
            { 1879000.0d, 0.000321502d },
            { 1892000.0d, 0.000320451d },
            { 1905000.0d, 0.000319353d },
            { 1918000.0d, 0.000318211d },
            { 1931000.0d, 0.000317024d },
            { 1944000.0d, 0.000315793d },
            { 1957000.0d, 0.000314518d },
            { 1970000.0d, 0.000313199d },
            { 1983000.0d, 0.000311838d },
            { 1996000.0d, 0.000310434d },
            { 2009000.0d, 0.000308987d },
            { 2022000.0d, 0.0003075d },
            { 2035000.0d, 0.000305971d },
            { 2048000.0d, 0.000304401d },
            { 2061000.0d, 0.000302792d },
            { 2074000.0d, 0.000301142d },
            { 2087000.0d, 0.000299454d },
            { 2100000.0d, 0.000297727d },
            { 2113000.0d, 0.000295961d },
            { 2126000.0d, 0.000294158d },
            { 2139000.0d, 0.000292318d },
            { 2152000.0d, 0.000290442d },
            { 2165000.0d, 0.00028853d },
            { 2178000.0d, 0.000286581d },
            { 2191000.0d, 0.000284598d },
            { 2204000.0d, 0.000282581d },
            { 2217000.0d, 0.00028053d },
            { 2230000.0d, 0.000278446d },
            { 2243000.0d, 0.000276331d },
            { 2256000.0d, 0.000274182d },
            { 2269000.0d, 0.000272002d },
            { 2282000.0d, 0.000269792d },
            { 2295000.0d, 0.000267552d },
            { 2308000.0d, 0.000265283d },
            { 2321000.0d, 0.000262984d },
            { 2334000.0d, 0.000260659d },
            { 2347000.0d, 0.000258305d },
            { 2360000.0d, 0.000255925d },
            { 2373000.0d, 0.000253519d },
            { 2386000.0d, 0.000251087d },
            { 2399000.0d, 0.000248631d },
            { 2412000.0d, 0.000246152d },
            { 2425000.0d, 0.000243648d },
            { 2438000.0d, 0.000241123d },
            { 2451000.0d, 0.000238576d },
            { 2464000.0d, 0.000236008d },
            { 2477000.0d, 0.00023342d },
            { 2490000.0d, 0.000230812d },
            { 2503000.0d, 0.000228185d },
            { 2516000.0d, 0.000225541d },
            { 2529000.0d, 0.00022288d },
            { 2542000.0d, 0.000220203d },
            { 2555000.0d, 0.00021751d },
            { 2568000.0d, 0.000214802d },
            { 2581000.0d, 0.00021208d },
            { 2594000.0d, 0.000209345d },
            { 2607000.0d, 0.000206598d },
            { 2620000.0d, 0.00020384d },
            { 2633000.0d, 0.000201071d },
            { 2646000.0d, 0.000198293d },
            { 2659000.0d, 0.000195506d },
            { 2672000.0d, 0.00019271d },
            { 2685000.0d, 0.000189908d },
            { 2698000.0d, 0.0001871d },
            { 2711000.0d, 0.000184287d },
            { 2724000.0d, 0.000181469d },
            { 2737000.0d, 0.000178647d },
            { 2750000.0d, 0.000175824d },
            { 2763000.0d, 0.000172998d },
            { 2776000.0d, 0.000170173d },
            { 2789000.0d, 0.000167348d },
            { 2802000.0d, 0.000164523d },
            { 2815000.0d, 0.000161701d },
            { 2828000.0d, 0.000158882d },
            { 2841000.0d, 0.000156068d },
            { 2854000.0d, 0.000153259d },
            { 2867000.0d, 0.000150456d },
            { 2880000.0d, 0.00014766d },
            { 2893000.0d, 0.000144872d },
            { 2906000.0d, 0.000142094d },
            { 2919000.0d, 0.000139326d },
            { 2932000.0d, 0.000136569d },
            { 2945000.0d, 0.000133824d },
            { 2958000.0d, 0.000131093d },
            { 2971000.0d, 0.000128376d },
            { 2984000.0d, 0.000125672d },
            { 2997000.0d, 0.000122983d },
            { 3010000.0d, 0.000120309d },
            { 3023000.0d, 0.000117652d },
            { 3036000.0d, 0.000115013d },
            { 3049000.0d, 0.000112392d },
            { 3062000.0d, 0.000109791d },
            { 3075000.0d, 0.00010721d },
            { 3088000.0d, 0.00010465d },
            { 3101000.0d, 0.000102112d },
            { 3114000.0d, 0.0000995953d },
            { 3127000.0d, 0.0000971016d },
            { 3140000.0d, 0.0000946316d },
            { 3153000.0d, 0.0000921863d },
            { 3166000.0d, 0.000089767d },
            { 3179000.0d, 0.0000873745d },
            { 3192000.0d, 0.0000850101d },
            { 3205000.0d, 0.0000826749d },
            { 3218000.0d, 0.0000803699d },
            { 3231000.0d, 0.0000780963d },
            { 3244000.0d, 0.0000758552d },
            { 3257000.0d, 0.0000736478d },
            { 3270000.0d, 0.0000714751d },
            { 3283000.0d, 0.0000693383d },
            { 3296000.0d, 0.0000672386d },
            { 3309000.0d, 0.0000651768d },
            { 3322000.0d, 0.0000631531d },
            { 3335000.0d, 0.0000611688d },
            { 3348000.0d, 0.0000592249d },
            { 3361000.0d, 0.0000573226d },
            { 3374000.0d, 0.000055463d },
            { 3387000.0d, 0.0000536473d },
            { 3400000.0d, 0.0000518766d },
            { 3413000.0d, 0.000050152d },
            { 3426000.0d, 0.0000484747d },
            { 3439000.0d, 0.0000468401d },
            { 3452000.0d, 0.0000452329d },
            { 3465000.0d, 0.0000436527d },
            { 3478000.0d, 0.0000420974d },
            { 3491000.0d, 0.0000405674d },
            { 3504000.0d, 0.0000390627d },
            { 3517000.0d, 0.0000375834d },
            { 3530000.0d, 0.0000361305d },
            { 3543000.0d, 0.0000347048d },
            { 3556000.0d, 0.0000333069d },
            { 3569000.0d, 0.0000319374d },
            { 3582000.0d, 0.000030597d },
            { 3595000.0d, 0.000029286d },
            { 3608000.0d, 0.0000280051d },
            { 3621000.0d, 0.000026755d },
            { 3634000.0d, 0.0000255364d },
            { 3647000.0d, 0.0000243481d },
            { 3660000.0d, 0.0000231901d },
            { 3673000.0d, 0.0000220632d },
            { 3686000.0d, 0.0000209679d },
            { 3699000.0d, 0.0000199049d },
            { 3712000.0d, 0.0000188738d },
            { 3725000.0d, 0.0000178752d },
            { 3738000.0d, 0.0000169082d },
            { 3751000.0d, 0.0000159722d },
            { 3764000.0d, 0.0000150662d },
            { 3777000.0d, 0.0000141867d },
            { 3790000.0d, 0.0000133336d },
            { 3803000.0d, 0.0000125073d },
            { 3816000.0d, 0.0000117048d },
            { 3829000.0d, 0.0000109248d },
            { 3842000.0d, 0.0000101679d },
            { 3855000.0d, 0.00000943436d },
            { 3868000.0d, 0.00000872488d },
            { 3881000.0d, 0.00000803992d },
            { 3894000.0d, 0.00000738004d },
            { 3907000.0d, 0.00000674578d },
            { 3920000.0d, 0.00000613768d },
            { 3933000.0d, 0.0000055563d },
            { 3946000.0d, 0.00000500218d },
            { 3959000.0d, 0.00000447587d },
            { 3972000.0d, 0.00000397794d },
            { 3985000.0d, 0.00000350893d },
            { 3998000.0d, 0.00000306939d },
            { 4011000.0d, 0.00000265881d },
            { 4024000.0d, 0.00000227584d },
            { 4037000.0d, 0.00000192091d },
            { 4050000.0d, 0.00000159449d },
            { 4063000.0d, 0.00000129707d },
            { 4076000.0d, 0.00000102909d },
            { 4089000.0d, 0.000000791033d },
            { 4102000.0d, 0.00000058336d },
            { 4115000.0d, 0.000000406527d },
            { 4128000.0d, 0.000000260985d },
            { 4141000.0d, 0.000000147172d },
            { 4154000.0d, 0.0000000655064d },
            { 4167000.0d, 0.0000000163634d },
            { 4180000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    