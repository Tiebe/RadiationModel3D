using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium171";
        public override double halfLife { get; } = 15.2d;
        public override double atomicWeight { get; } = 170.95572d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum171()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.096d, new GammaParticle(102000.0, 0.01216)), new(0.0128d, new GammaParticle(105600.0, 0.01174)), new(0.032d, new GammaParticle(131400.0, 0.00944)), new(0.0512d, new GammaParticle(133400.0, 0.00929)), new(0.0304d, new GammaParticle(207600.0, 0.00597)), new(0.0144d, new GammaParticle(233400.0, 0.00531)), new(0.0304d, new GammaParticle(360900.0, 0.00344)), new(0.07519999999999999d, new GammaParticle(434900.0, 0.00285)), new(0.0496d, new GammaParticle(466400.0, 0.00266)), new(0.0208d, new GammaParticle(498000.0, 0.00249)), new(0.16d, new GammaParticle(568400.0, 0.00218)), new(0.016d, new GammaParticle(933900.0, 0.00133)), new(0.0128d, new GammaParticle(964000.0, 0.00129)), new(0.08d, new GammaParticle(1066000.0, 0.00116)), new(1.242d, new GammaParticle(511000.0, 0.00243)), new(0.225d, new GammaParticle(9740.0, 0.12729)), new(0.221d, new GammaParticle(57983.0, 0.02138)), new(0.384d, new GammaParticle(59320.0, 0.0209)), new(0.127d, new GammaParticle(67335.0, 0.01841)), new(0.162d, new GammaParticle(68117.0, 0.0182)), new(0.0349d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 12000.0d, 0.0000000187358d },
            { 24000.0d, 0.000000184476d },
            { 36000.0d, 0.000000550544d },
            { 48000.0d, 0.00000117792d },
            { 60000.0d, 0.00000206732d },
            { 72000.0d, 0.00000319656d },
            { 84000.0d, 0.00000454196d },
            { 96000.0d, 0.00000607593d },
            { 108000.0d, 0.00000777366d },
            { 120000.0d, 0.00000961161d },
            { 132000.0d, 0.0000115677d },
            { 144000.0d, 0.0000136267d },
            { 156000.0d, 0.0000157727d },
            { 168000.0d, 0.0000179924d },
            { 180000.0d, 0.0000202742d },
            { 192000.0d, 0.0000226082d },
            { 204000.0d, 0.000024987d },
            { 216000.0d, 0.0000274033d },
            { 228000.0d, 0.0000298508d },
            { 240000.0d, 0.0000323239d },
            { 252000.0d, 0.0000348178d },
            { 264000.0d, 0.0000373287d },
            { 276000.0d, 0.0000398531d },
            { 288000.0d, 0.0000423877d },
            { 300000.0d, 0.0000449299d },
            { 312000.0d, 0.000047477d },
            { 324000.0d, 0.000050027d },
            { 336000.0d, 0.0000525778d },
            { 348000.0d, 0.0000551278d },
            { 360000.0d, 0.0000576754d },
            { 372000.0d, 0.0000602192d },
            { 384000.0d, 0.000062758d },
            { 396000.0d, 0.0000652905d },
            { 408000.0d, 0.0000678158d },
            { 420000.0d, 0.0000703329d },
            { 432000.0d, 0.0000728408d },
            { 444000.0d, 0.0000753388d },
            { 456000.0d, 0.0000778262d },
            { 468000.0d, 0.0000803024d },
            { 480000.0d, 0.0000827665d },
            { 492000.0d, 0.0000852182d },
            { 504000.0d, 0.0000876567d },
            { 516000.0d, 0.0000900817d },
            { 528000.0d, 0.0000924927d },
            { 540000.0d, 0.0000948892d },
            { 552000.0d, 0.0000972708d },
            { 564000.0d, 0.000099637d },
            { 576000.0d, 0.000101988d },
            { 588000.0d, 0.000104322d },
            { 600000.0d, 0.00010664d },
            { 612000.0d, 0.000108942d },
            { 624000.0d, 0.000111226d },
            { 636000.0d, 0.000113493d },
            { 648000.0d, 0.000115743d },
            { 660000.0d, 0.000117975d },
            { 672000.0d, 0.000120189d },
            { 684000.0d, 0.000122384d },
            { 696000.0d, 0.000124561d },
            { 708000.0d, 0.000126719d },
            { 720000.0d, 0.000128859d },
            { 732000.0d, 0.000130979d },
            { 744000.0d, 0.000133079d },
            { 756000.0d, 0.00013516d },
            { 768000.0d, 0.000137222d },
            { 780000.0d, 0.000139263d },
            { 792000.0d, 0.000141284d },
            { 804000.0d, 0.000143285d },
            { 816000.0d, 0.000145266d },
            { 828000.0d, 0.000147226d },
            { 840000.0d, 0.000149165d },
            { 852000.0d, 0.000151083d },
            { 864000.0d, 0.00015298d },
            { 876000.0d, 0.000154856d },
            { 888000.0d, 0.000156711d },
            { 900000.0d, 0.000158544d },
            { 912000.0d, 0.000160356d },
            { 924000.0d, 0.000162146d },
            { 936000.0d, 0.000163914d },
            { 948000.0d, 0.00016566d },
            { 960000.0d, 0.000167385d },
            { 972000.0d, 0.000169087d },
            { 984000.0d, 0.000170767d },
            { 996000.0d, 0.000172424d },
            { 1008000.0d, 0.000174059d },
            { 1023000.0d, 0.000176071d },
            { 1038000.0d, 0.000178048d },
            { 1053000.0d, 0.000179989d },
            { 1068000.0d, 0.000181895d },
            { 1083000.0d, 0.000183764d },
            { 1098000.0d, 0.000185598d },
            { 1113000.0d, 0.000187395d },
            { 1128000.0d, 0.000189156d },
            { 1143000.0d, 0.000190881d },
            { 1158000.0d, 0.000192569d },
            { 1173000.0d, 0.00019422d },
            { 1188000.0d, 0.000195834d },
            { 1203000.0d, 0.000197412d },
            { 1218000.0d, 0.000198953d },
            { 1233000.0d, 0.000200456d },
            { 1248000.0d, 0.000201923d },
            { 1263000.0d, 0.000203352d },
            { 1278000.0d, 0.000204744d },
            { 1293000.0d, 0.000206098d },
            { 1308000.0d, 0.000207416d },
            { 1323000.0d, 0.000208695d },
            { 1338000.0d, 0.000209937d },
            { 1353000.0d, 0.000211142d },
            { 1368000.0d, 0.000212309d },
            { 1383000.0d, 0.000213438d },
            { 1398000.0d, 0.00021453d },
            { 1413000.0d, 0.000215584d },
            { 1428000.0d, 0.0002166d },
            { 1443000.0d, 0.000217579d },
            { 1458000.0d, 0.00021852d },
            { 1473000.0d, 0.000219423d },
            { 1488000.0d, 0.000220289d },
            { 1503000.0d, 0.000221117d },
            { 1518000.0d, 0.000221907d },
            { 1533000.0d, 0.00022266d },
            { 1548000.0d, 0.000223375d },
            { 1563000.0d, 0.000224053d },
            { 1578000.0d, 0.000224694d },
            { 1593000.0d, 0.000225296d },
            { 1608000.0d, 0.000225862d },
            { 1623000.0d, 0.00022639d },
            { 1638000.0d, 0.000226881d },
            { 1653000.0d, 0.000227335d },
            { 1668000.0d, 0.000227752d },
            { 1683000.0d, 0.000228131d },
            { 1698000.0d, 0.000228474d },
            { 1713000.0d, 0.00022878d },
            { 1728000.0d, 0.00022905d },
            { 1743000.0d, 0.000229283d },
            { 1758000.0d, 0.000229479d },
            { 1773000.0d, 0.000229639d },
            { 1788000.0d, 0.000229763d },
            { 1803000.0d, 0.00022985d },
            { 1818000.0d, 0.000229902d },
            { 1833000.0d, 0.000229918d },
            { 1848000.0d, 0.000229898d },
            { 1863000.0d, 0.000229843d },
            { 1878000.0d, 0.000229752d },
            { 1893000.0d, 0.000229626d },
            { 1908000.0d, 0.000229465d },
            { 1923000.0d, 0.000229269d },
            { 1938000.0d, 0.000229039d },
            { 1953000.0d, 0.000228774d },
            { 1968000.0d, 0.000228475d },
            { 1983000.0d, 0.000228141d },
            { 1998000.0d, 0.000227774d },
            { 2013000.0d, 0.000227373d },
            { 2028000.0d, 0.000226939d },
            { 2043000.0d, 0.000226471d },
            { 2058000.0d, 0.00022597d },
            { 2073000.0d, 0.000225436d },
            { 2088000.0d, 0.00022487d },
            { 2103000.0d, 0.000224271d },
            { 2118000.0d, 0.000223641d },
            { 2133000.0d, 0.000222978d },
            { 2148000.0d, 0.000222284d },
            { 2163000.0d, 0.000221558d },
            { 2178000.0d, 0.000220802d },
            { 2193000.0d, 0.000220014d },
            { 2208000.0d, 0.000219196d },
            { 2223000.0d, 0.000218348d },
            { 2238000.0d, 0.00021747d },
            { 2253000.0d, 0.000216562d },
            { 2268000.0d, 0.000215625d },
            { 2283000.0d, 0.000214659d },
            { 2298000.0d, 0.000213664d },
            { 2313000.0d, 0.00021264d },
            { 2328000.0d, 0.000211589d },
            { 2343000.0d, 0.000210509d },
            { 2358000.0d, 0.000209402d },
            { 2373000.0d, 0.000208268d },
            { 2388000.0d, 0.000207107d },
            { 2403000.0d, 0.00020592d },
            { 2418000.0d, 0.000204706d },
            { 2433000.0d, 0.000203467d },
            { 2448000.0d, 0.000202202d },
            { 2463000.0d, 0.000200913d },
            { 2478000.0d, 0.000199598d },
            { 2493000.0d, 0.00019826d },
            { 2508000.0d, 0.000196897d },
            { 2523000.0d, 0.000195511d },
            { 2538000.0d, 0.000194102d },
            { 2553000.0d, 0.00019267d },
            { 2568000.0d, 0.000191216d },
            { 2583000.0d, 0.00018974d },
            { 2598000.0d, 0.000188242d },
            { 2613000.0d, 0.000186723d },
            { 2628000.0d, 0.000185184d },
            { 2643000.0d, 0.000183624d },
            { 2658000.0d, 0.000182044d },
            { 2673000.0d, 0.000180445d },
            { 2688000.0d, 0.000178827d },
            { 2703000.0d, 0.000177191d },
            { 2718000.0d, 0.000175537d },
            { 2733000.0d, 0.000173865d },
            { 2748000.0d, 0.000172175d },
            { 2763000.0d, 0.00017047d },
            { 2778000.0d, 0.000168748d },
            { 2793000.0d, 0.00016701d },
            { 2808000.0d, 0.000165257d },
            { 2823000.0d, 0.000163489d },
            { 2838000.0d, 0.000161707d },
            { 2853000.0d, 0.000159912d },
            { 2868000.0d, 0.000158103d },
            { 2883000.0d, 0.000156281d },
            { 2898000.0d, 0.000154447d },
            { 2913000.0d, 0.000152602d },
            { 2928000.0d, 0.000150745d },
            { 2943000.0d, 0.000148878d },
            { 2958000.0d, 0.000147d },
            { 2973000.0d, 0.000145113d },
            { 2988000.0d, 0.000143217d },
            { 3003000.0d, 0.000141312d },
            { 3018000.0d, 0.000139399d },
            { 3033000.0d, 0.000137479d },
            { 3048000.0d, 0.000135552d },
            { 3063000.0d, 0.000133619d },
            { 3078000.0d, 0.000131681d },
            { 3093000.0d, 0.000129737d },
            { 3108000.0d, 0.000127788d },
            { 3123000.0d, 0.000125835d },
            { 3138000.0d, 0.00012388d },
            { 3153000.0d, 0.000121921d },
            { 3168000.0d, 0.00011996d },
            { 3183000.0d, 0.000117998d },
            { 3198000.0d, 0.000116035d },
            { 3213000.0d, 0.000114071d },
            { 3228000.0d, 0.000112108d },
            { 3243000.0d, 0.000110145d },
            { 3258000.0d, 0.000108184d },
            { 3273000.0d, 0.000106225d },
            { 3288000.0d, 0.00010427d },
            { 3303000.0d, 0.000102317d },
            { 3318000.0d, 0.000100369d },
            { 3333000.0d, 0.0000984251d },
            { 3348000.0d, 0.0000964869d },
            { 3363000.0d, 0.0000945549d },
            { 3378000.0d, 0.0000926295d },
            { 3393000.0d, 0.0000907115d },
            { 3408000.0d, 0.0000888017d },
            { 3423000.0d, 0.0000869006d },
            { 3438000.0d, 0.0000850091d },
            { 3453000.0d, 0.0000831277d },
            { 3468000.0d, 0.0000812571d },
            { 3483000.0d, 0.000079398d },
            { 3498000.0d, 0.0000775512d },
            { 3513000.0d, 0.0000757176d },
            { 3528000.0d, 0.0000738975d },
            { 3543000.0d, 0.0000720919d },
            { 3558000.0d, 0.0000703014d },
            { 3573000.0d, 0.0000685269d },
            { 3588000.0d, 0.0000667689d },
            { 3603000.0d, 0.0000650283d },
            { 3618000.0d, 0.0000633058d },
            { 3633000.0d, 0.0000616021d },
            { 3648000.0d, 0.0000599179d },
            { 3663000.0d, 0.0000582541d },
            { 3678000.0d, 0.0000566115d },
            { 3693000.0d, 0.0000549907d },
            { 3708000.0d, 0.0000533926d },
            { 3723000.0d, 0.0000518179d },
            { 3738000.0d, 0.0000502672d },
            { 3753000.0d, 0.0000487414d },
            { 3768000.0d, 0.0000472351d },
            { 3783000.0d, 0.0000457442d },
            { 3798000.0d, 0.0000442695d },
            { 3813000.0d, 0.0000428115d },
            { 3828000.0d, 0.0000413708d },
            { 3843000.0d, 0.0000399481d },
            { 3858000.0d, 0.0000385439d },
            { 3873000.0d, 0.0000371589d },
            { 3888000.0d, 0.0000357937d },
            { 3903000.0d, 0.0000344491d },
            { 3918000.0d, 0.0000331255d },
            { 3933000.0d, 0.0000318238d },
            { 3948000.0d, 0.0000305444d },
            { 3963000.0d, 0.0000292882d },
            { 3978000.0d, 0.0000280557d },
            { 3993000.0d, 0.0000268476d },
            { 4008000.0d, 0.0000256645d },
            { 4023000.0d, 0.0000245073d },
            { 4038000.0d, 0.0000233766d },
            { 4053000.0d, 0.0000222728d },
            { 4068000.0d, 0.0000211969d },
            { 4083000.0d, 0.0000201496d },
            { 4098000.0d, 0.0000191314d },
            { 4113000.0d, 0.0000181431d },
            { 4128000.0d, 0.0000171855d },
            { 4143000.0d, 0.0000162592d },
            { 4158000.0d, 0.0000153649d },
            { 4173000.0d, 0.0000145034d },
            { 4188000.0d, 0.0000136753d },
            { 4203000.0d, 0.0000128814d },
            { 4218000.0d, 0.0000121223d },
            { 4233000.0d, 0.0000113988d },
            { 4248000.0d, 0.0000107116d },
            { 4263000.0d, 0.0000100533d },
            { 4278000.0d, 0.00000941218d },
            { 4293000.0d, 0.00000878838d },
            { 4308000.0d, 0.00000818238d },
            { 4323000.0d, 0.00000759462d },
            { 4338000.0d, 0.00000702555d },
            { 4353000.0d, 0.00000647564d },
            { 4368000.0d, 0.00000594534d },
            { 4383000.0d, 0.00000543513d },
            { 4398000.0d, 0.00000494547d },
            { 4413000.0d, 0.00000447684d },
            { 4428000.0d, 0.00000402974d },
            { 4443000.0d, 0.00000360465d },
            { 4458000.0d, 0.00000320207d },
            { 4473000.0d, 0.00000282249d },
            { 4488000.0d, 0.00000246642d },
            { 4503000.0d, 0.00000213437d },
            { 4518000.0d, 0.00000182684d },
            { 4533000.0d, 0.00000154437d },
            { 4548000.0d, 0.00000128746d },
            { 4563000.0d, 0.00000105663d },
            { 4578000.0d, 0.000000852383d },
            { 4593000.0d, 0.000000674208d },
            { 4608000.0d, 0.000000517406d },
            { 4623000.0d, 0.00000038126d },
            { 4638000.0d, 0.000000265526d },
            { 4653000.0d, 0.000000170605d },
            { 4668000.0d, 0.0000000969073d },
            { 4683000.0d, 0.0000000448186d },
            { 4698000.0d, 0.0000000133144d },
            { 4713000.0d, 0.000000000363181d },
            { 4716000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    