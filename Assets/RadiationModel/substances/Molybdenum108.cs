using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum108 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum108";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 107.92405d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium108()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.03526d, new GammaParticle(28000.0, 0.04428)), new(0.0387d, new GammaParticle(58400.0, 0.02123)), new(0.0559d, new GammaParticle(65700.0, 0.01887)), new(0.041710000000000004d, new GammaParticle(67800.0, 0.01829)), new(0.0774d, new GammaParticle(86400.0, 0.01435)), new(0.03569d, new GammaParticle(106200.0, 0.01167)), new(0.02709d, new GammaParticle(118400.0, 0.01047)), new(0.0086d, new GammaParticle(161800.0, 0.00766)), new(0.0645d, new GammaParticle(190500.0, 0.00651)), new(0.02795d, new GammaParticle(223300.0, 0.00555)), new(0.0129d, new GammaParticle(228200.0, 0.00543)), new(0.1118d, new GammaParticle(240500.0, 0.00516)), new(0.00817d, new GammaParticle(254200.0, 0.00488)), new(0.2236d, new GammaParticle(268300.0, 0.00462)), new(0.03569d, new GammaParticle(295600.0, 0.00419)), new(0.00731d, new GammaParticle(299600.0, 0.00414)), new(0.01849d, new GammaParticle(312200.0, 0.00397)), new(0.0086d, new GammaParticle(334600.0, 0.00371)), new(0.0473d, new GammaParticle(340300.0, 0.00364)), new(0.1032d, new GammaParticle(372400.0, 0.00333)), new(0.0688d, new GammaParticle(391000.0, 0.00317)), new(0.0086d, new GammaParticle(430800.0, 0.00288)), new(0.01978d, new GammaParticle(458500.0, 0.0027)), new(0.03483d, new GammaParticle(477500.0, 0.0026)), new(0.01075d, new GammaParticle(535800.0, 0.00231)), new(0.01892d, new GammaParticle(570100.0, 0.00217)), new(0.02365d, new GammaParticle(635800.0, 0.00195)), new(0.03252958029777d, new GammaParticle(2586.0, 0.47944)), new(0.1403844091911178d, new GammaParticle(18250.0, 0.06794)), new(0.2669412610593607d, new GammaParticle(18367.0, 0.0675)), new(0.07094783047454363d, new GammaParticle(20695.0, 0.05991)), new(0.08215758768952151d, new GammaParticle(20820.0, 0.05955)), new(0.011209757214977894d, new GammaParticle(21003.0, 0.05903)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000678928d },
            { 12000.0d, 0.0000702305d },
            { 24000.0d, 0.0000726807d },
            { 36000.0d, 0.0000752433d },
            { 48000.0d, 0.0000779262d },
            { 60000.0d, 0.0000807251d },
            { 72000.0d, 0.0000836131d },
            { 84000.0d, 0.0000865736d },
            { 96000.0d, 0.0000895927d },
            { 108000.0d, 0.0000926608d },
            { 120000.0d, 0.00009577d },
            { 132000.0d, 0.0000989147d },
            { 144000.0d, 0.000102091d },
            { 156000.0d, 0.000105294d },
            { 168000.0d, 0.000108522d },
            { 180000.0d, 0.000111771d },
            { 192000.0d, 0.00011504d },
            { 204000.0d, 0.000118327d },
            { 216000.0d, 0.00012163d },
            { 228000.0d, 0.000124947d },
            { 240000.0d, 0.000128277d },
            { 252000.0d, 0.000131619d },
            { 264000.0d, 0.000134972d },
            { 276000.0d, 0.000138333d },
            { 288000.0d, 0.000141703d },
            { 300000.0d, 0.000145079d },
            { 312000.0d, 0.000148462d },
            { 324000.0d, 0.000151849d },
            { 336000.0d, 0.00015524d },
            { 348000.0d, 0.000158634d },
            { 360000.0d, 0.000162031d },
            { 372000.0d, 0.000165428d },
            { 384000.0d, 0.000168826d },
            { 396000.0d, 0.000172223d },
            { 408000.0d, 0.000175619d },
            { 420000.0d, 0.000179013d },
            { 432000.0d, 0.000182403d },
            { 444000.0d, 0.000185789d },
            { 456000.0d, 0.000189171d },
            { 468000.0d, 0.000192548d },
            { 480000.0d, 0.000195918d },
            { 492000.0d, 0.000199282d },
            { 504000.0d, 0.000202638d },
            { 516000.0d, 0.000205985d },
            { 528000.0d, 0.000209323d },
            { 540000.0d, 0.000212652d },
            { 552000.0d, 0.00021597d },
            { 564000.0d, 0.000219277d },
            { 576000.0d, 0.000222572d },
            { 588000.0d, 0.000225854d },
            { 600000.0d, 0.000229124d },
            { 612000.0d, 0.000232379d },
            { 624000.0d, 0.00023562d },
            { 636000.0d, 0.000238846d },
            { 648000.0d, 0.000242057d },
            { 660000.0d, 0.000245251d },
            { 672000.0d, 0.000248428d },
            { 684000.0d, 0.000251588d },
            { 696000.0d, 0.00025473d },
            { 708000.0d, 0.000257853d },
            { 720000.0d, 0.000260957d },
            { 732000.0d, 0.000264042d },
            { 744000.0d, 0.000267106d },
            { 756000.0d, 0.000270149d },
            { 768000.0d, 0.000273171d },
            { 780000.0d, 0.000276172d },
            { 792000.0d, 0.00027915d },
            { 804000.0d, 0.000282105d },
            { 816000.0d, 0.000285036d },
            { 828000.0d, 0.000287944d },
            { 840000.0d, 0.000290828d },
            { 852000.0d, 0.000293687d },
            { 864000.0d, 0.000296521d },
            { 876000.0d, 0.000299329d },
            { 888000.0d, 0.000302111d },
            { 900000.0d, 0.000304866d },
            { 912000.0d, 0.000307594d },
            { 924000.0d, 0.000310295d },
            { 936000.0d, 0.000312969d },
            { 948000.0d, 0.000315613d },
            { 960000.0d, 0.00031823d },
            { 972000.0d, 0.000320817d },
            { 984000.0d, 0.000323375d },
            { 996000.0d, 0.000325903d },
            { 1008000.0d, 0.000328402d },
            { 1023000.0d, 0.000331481d },
            { 1038000.0d, 0.000334512d },
            { 1053000.0d, 0.000337494d },
            { 1068000.0d, 0.000340427d },
            { 1083000.0d, 0.000343309d },
            { 1098000.0d, 0.00034614d },
            { 1113000.0d, 0.00034892d },
            { 1128000.0d, 0.000351647d },
            { 1143000.0d, 0.000354322d },
            { 1158000.0d, 0.000356943d },
            { 1173000.0d, 0.000359511d },
            { 1188000.0d, 0.000362023d },
            { 1203000.0d, 0.000364482d },
            { 1218000.0d, 0.000366884d },
            { 1233000.0d, 0.000369232d },
            { 1248000.0d, 0.000371523d },
            { 1263000.0d, 0.000373758d },
            { 1278000.0d, 0.000375934d },
            { 1293000.0d, 0.000378053d },
            { 1308000.0d, 0.000380115d },
            { 1323000.0d, 0.000382118d },
            { 1338000.0d, 0.000384062d },
            { 1353000.0d, 0.000385948d },
            { 1368000.0d, 0.000387774d },
            { 1383000.0d, 0.00038954d },
            { 1398000.0d, 0.000391246d },
            { 1413000.0d, 0.000392892d },
            { 1428000.0d, 0.000394478d },
            { 1443000.0d, 0.000396002d },
            { 1458000.0d, 0.000397466d },
            { 1473000.0d, 0.000398868d },
            { 1488000.0d, 0.000400209d },
            { 1503000.0d, 0.000401488d },
            { 1518000.0d, 0.000402705d },
            { 1533000.0d, 0.00040386d },
            { 1548000.0d, 0.000404953d },
            { 1563000.0d, 0.000405983d },
            { 1578000.0d, 0.000406951d },
            { 1593000.0d, 0.000407856d },
            { 1608000.0d, 0.000408699d },
            { 1623000.0d, 0.000409479d },
            { 1638000.0d, 0.000410195d },
            { 1653000.0d, 0.000410849d },
            { 1668000.0d, 0.00041144d },
            { 1683000.0d, 0.000411968d },
            { 1698000.0d, 0.000412433d },
            { 1713000.0d, 0.000412835d },
            { 1728000.0d, 0.000413174d },
            { 1743000.0d, 0.00041345d },
            { 1758000.0d, 0.000413663d },
            { 1773000.0d, 0.000413813d },
            { 1788000.0d, 0.0004139d },
            { 1803000.0d, 0.000413925d },
            { 1818000.0d, 0.000413887d },
            { 1833000.0d, 0.000413786d },
            { 1848000.0d, 0.000413622d },
            { 1863000.0d, 0.000413398d },
            { 1878000.0d, 0.000413109d },
            { 1893000.0d, 0.00041276d },
            { 1908000.0d, 0.000412348d },
            { 1923000.0d, 0.000411875d },
            { 1938000.0d, 0.00041134d },
            { 1953000.0d, 0.000410745d },
            { 1968000.0d, 0.000410087d },
            { 1983000.0d, 0.000409369d },
            { 1998000.0d, 0.000408591d },
            { 2013000.0d, 0.000407753d },
            { 2028000.0d, 0.000406854d },
            { 2043000.0d, 0.000405896d },
            { 2058000.0d, 0.000404878d },
            { 2073000.0d, 0.000403801d },
            { 2088000.0d, 0.000402666d },
            { 2103000.0d, 0.000401471d },
            { 2118000.0d, 0.000400219d },
            { 2133000.0d, 0.000398909d },
            { 2148000.0d, 0.000397541d },
            { 2163000.0d, 0.000396117d },
            { 2178000.0d, 0.000394636d },
            { 2193000.0d, 0.000393098d },
            { 2208000.0d, 0.000391506d },
            { 2223000.0d, 0.000389856d },
            { 2238000.0d, 0.000388153d },
            { 2253000.0d, 0.000386396d },
            { 2268000.0d, 0.000384584d },
            { 2283000.0d, 0.000382719d },
            { 2298000.0d, 0.000380801d },
            { 2313000.0d, 0.00037883d },
            { 2328000.0d, 0.000376808d },
            { 2343000.0d, 0.000374734d },
            { 2358000.0d, 0.000372608d },
            { 2373000.0d, 0.000370433d },
            { 2388000.0d, 0.000368208d },
            { 2403000.0d, 0.000365934d },
            { 2418000.0d, 0.00036361d },
            { 2433000.0d, 0.00036124d },
            { 2448000.0d, 0.000358822d },
            { 2463000.0d, 0.000356357d },
            { 2478000.0d, 0.000353845d },
            { 2493000.0d, 0.000351289d },
            { 2508000.0d, 0.000348687d },
            { 2523000.0d, 0.000346042d },
            { 2538000.0d, 0.000343353d },
            { 2553000.0d, 0.000340621d },
            { 2568000.0d, 0.000337847d },
            { 2583000.0d, 0.000335033d },
            { 2598000.0d, 0.000332177d },
            { 2613000.0d, 0.000329281d },
            { 2628000.0d, 0.000326347d },
            { 2643000.0d, 0.000323374d },
            { 2658000.0d, 0.000320364d },
            { 2673000.0d, 0.000317316d },
            { 2688000.0d, 0.000314233d },
            { 2703000.0d, 0.000311115d },
            { 2718000.0d, 0.000307963d },
            { 2733000.0d, 0.000304777d },
            { 2748000.0d, 0.000301558d },
            { 2763000.0d, 0.000298308d },
            { 2778000.0d, 0.000295027d },
            { 2793000.0d, 0.000291716d },
            { 2808000.0d, 0.000288376d },
            { 2823000.0d, 0.000285008d },
            { 2838000.0d, 0.000281612d },
            { 2853000.0d, 0.00027819d },
            { 2868000.0d, 0.000274743d },
            { 2883000.0d, 0.000271271d },
            { 2898000.0d, 0.000267776d },
            { 2913000.0d, 0.000264259d },
            { 2928000.0d, 0.00026072d },
            { 2943000.0d, 0.00025716d },
            { 2958000.0d, 0.000253581d },
            { 2973000.0d, 0.000249984d },
            { 2988000.0d, 0.000246369d },
            { 3003000.0d, 0.000242738d },
            { 3018000.0d, 0.000239092d },
            { 3033000.0d, 0.000235431d },
            { 3048000.0d, 0.000231758d },
            { 3063000.0d, 0.000228072d },
            { 3078000.0d, 0.000224375d },
            { 3093000.0d, 0.000220669d },
            { 3108000.0d, 0.000216954d },
            { 3123000.0d, 0.000213232d },
            { 3138000.0d, 0.000209503d },
            { 3153000.0d, 0.000205769d },
            { 3168000.0d, 0.000202031d },
            { 3183000.0d, 0.00019829d },
            { 3198000.0d, 0.000194547d },
            { 3213000.0d, 0.000190805d },
            { 3228000.0d, 0.000187062d },
            { 3243000.0d, 0.000183322d },
            { 3258000.0d, 0.000179586d },
            { 3273000.0d, 0.000175854d },
            { 3288000.0d, 0.000172128d },
            { 3303000.0d, 0.000168408d },
            { 3318000.0d, 0.000164698d },
            { 3333000.0d, 0.000160997d },
            { 3348000.0d, 0.000157307d },
            { 3363000.0d, 0.00015363d },
            { 3378000.0d, 0.000149966d },
            { 3393000.0d, 0.000146317d },
            { 3408000.0d, 0.000142685d },
            { 3423000.0d, 0.000139071d },
            { 3438000.0d, 0.000135476d },
            { 3453000.0d, 0.000131902d },
            { 3468000.0d, 0.00012835d },
            { 3483000.0d, 0.000124821d },
            { 3498000.0d, 0.000121317d },
            { 3513000.0d, 0.00011784d },
            { 3528000.0d, 0.00011439d },
            { 3543000.0d, 0.00011097d },
            { 3558000.0d, 0.00010758d },
            { 3573000.0d, 0.000104223d },
            { 3588000.0d, 0.0001009d },
            { 3603000.0d, 0.0000976117d },
            { 3618000.0d, 0.0000943605d },
            { 3633000.0d, 0.0000911478d },
            { 3648000.0d, 0.000087975d },
            { 3663000.0d, 0.0000848438d },
            { 3678000.0d, 0.0000817557d },
            { 3693000.0d, 0.0000787122d },
            { 3708000.0d, 0.000075715d },
            { 3723000.0d, 0.0000727658d },
            { 3738000.0d, 0.0000698661d },
            { 3753000.0d, 0.0000670166d },
            { 3768000.0d, 0.0000642139d },
            { 3783000.0d, 0.0000614585d },
            { 3798000.0d, 0.000058752d },
            { 3813000.0d, 0.0000560959d },
            { 3828000.0d, 0.0000534918d },
            { 3843000.0d, 0.0000509413d },
            { 3858000.0d, 0.0000484459d },
            { 3873000.0d, 0.0000460072d },
            { 3888000.0d, 0.0000436269d },
            { 3903000.0d, 0.0000413067d },
            { 3918000.0d, 0.0000390481d },
            { 3933000.0d, 0.0000368526d },
            { 3948000.0d, 0.000034722d },
            { 3963000.0d, 0.0000326581d },
            { 3978000.0d, 0.0000306622d },
            { 3993000.0d, 0.0000287364d },
            { 4008000.0d, 0.0000268821d },
            { 4023000.0d, 0.000025101d },
            { 4038000.0d, 0.0000233949d },
            { 4053000.0d, 0.0000217654d },
            { 4068000.0d, 0.0000202141d },
            { 4083000.0d, 0.0000187429d },
            { 4098000.0d, 0.000017349d },
            { 4113000.0d, 0.0000160251d },
            { 4128000.0d, 0.0000147724d },
            { 4143000.0d, 0.0000135923d },
            { 4158000.0d, 0.0000124864d },
            { 4173000.0d, 0.0000114561d },
            { 4188000.0d, 0.0000105029d },
            { 4203000.0d, 0.00000961689d },
            { 4218000.0d, 0.00000877573d },
            { 4233000.0d, 0.00000797958d },
            { 4248000.0d, 0.00000722942d },
            { 4263000.0d, 0.00000652626d },
            { 4278000.0d, 0.00000587104d },
            { 4293000.0d, 0.00000526475d },
            { 4308000.0d, 0.0000047083d },
            { 4323000.0d, 0.0000042006d },
            { 4338000.0d, 0.00000372611d },
            { 4353000.0d, 0.000003277d },
            { 4368000.0d, 0.0000028539d },
            { 4383000.0d, 0.00000245743d },
            { 4398000.0d, 0.00000208823d },
            { 4413000.0d, 0.00000174693d },
            { 4428000.0d, 0.00000143416d },
            { 4443000.0d, 0.00000115057d },
            { 4458000.0d, 0.000000896801d },
            { 4473000.0d, 0.00000067351d },
            { 4488000.0d, 0.000000481338d },
            { 4503000.0d, 0.000000320934d },
            { 4518000.0d, 0.000000192935d },
            { 4533000.0d, 0.0000000979626d },
            { 4548000.0d, 0.0000000365203d },
            { 4563000.0d, 0.00000000763643d },
            { 4578000.0d, 0.00000000036678d },
            { 4582220.0d, 0d },

        }; 
    }
}
    