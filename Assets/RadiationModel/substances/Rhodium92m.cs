using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium92m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium92m";
        public override double halfLife { get; } = 0.53d;
        public override double atomicWeight { get; } = 91.93242d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium92()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.068d, new GammaParticle(163100.0, 0.0076)), new(0.43d, new GammaParticle(339900.0, 0.00365)), new(0.76d, new GammaParticle(817800.0, 0.00152)), new(1.03d, new GammaParticle(865700.0, 0.00143)), new(0.1d, new GammaParticle(919100.0, 0.00135)), new(1.0d, new GammaParticle(991100.0, 0.00125)), new(2.002d, new GammaParticle(511000.0, 0.00243)), new(0.0011762818158d, new GammaParticle(2737.0, 0.45299)), new(0.00517942456979951d, new GammaParticle(19150.0, 0.06474)), new(0.009828130113471558d, new GammaParticle(19279.0, 0.06431)), new(0.0026411746409026964d, new GammaParticle(21736.0, 0.05704)), new(0.003069044932728933d, new GammaParticle(21875.0, 0.05668)), new(0.00042787029182623685d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 24000.0d, 0.00000030016d },
            { 48000.0d, 0.00000129353d },
            { 72000.0d, 0.00000270953d },
            { 96000.0d, 0.00000434666d },
            { 120000.0d, 0.000006109d },
            { 144000.0d, 0.00000795087d },
            { 168000.0d, 0.00000984833d },
            { 192000.0d, 0.0000117879d },
            { 216000.0d, 0.0000137618d },
            { 240000.0d, 0.0000157651d },
            { 264000.0d, 0.0000177947d },
            { 288000.0d, 0.0000198483d },
            { 312000.0d, 0.0000219244d },
            { 336000.0d, 0.0000240216d },
            { 360000.0d, 0.000026139d },
            { 384000.0d, 0.0000282756d },
            { 408000.0d, 0.0000304306d },
            { 432000.0d, 0.0000326032d },
            { 456000.0d, 0.0000347926d },
            { 480000.0d, 0.0000369981d },
            { 504000.0d, 0.0000392189d },
            { 528000.0d, 0.0000414543d },
            { 552000.0d, 0.0000437034d },
            { 576000.0d, 0.0000459657d },
            { 600000.0d, 0.0000482402d },
            { 624000.0d, 0.0000505262d },
            { 648000.0d, 0.0000528232d },
            { 672000.0d, 0.0000551301d },
            { 696000.0d, 0.0000574464d },
            { 720000.0d, 0.0000597711d },
            { 744000.0d, 0.0000621037d },
            { 768000.0d, 0.0000644433d },
            { 792000.0d, 0.0000667892d },
            { 816000.0d, 0.0000691405d },
            { 840000.0d, 0.0000714967d },
            { 864000.0d, 0.000073857d },
            { 888000.0d, 0.0000762205d },
            { 912000.0d, 0.0000785867d },
            { 936000.0d, 0.0000809547d },
            { 960000.0d, 0.0000833239d },
            { 984000.0d, 0.0000856935d },
            { 1008000.0d, 0.0000880629d },
            { 1036000.0d, 0.0000908257d },
            { 1064000.0d, 0.0000935863d },
            { 1092000.0d, 0.0000963433d },
            { 1120000.0d, 0.0000990958d },
            { 1148000.0d, 0.000101843d },
            { 1176000.0d, 0.000104583d },
            { 1204000.0d, 0.000107315d },
            { 1232000.0d, 0.000110039d },
            { 1260000.0d, 0.000112753d },
            { 1288000.0d, 0.000115456d },
            { 1316000.0d, 0.000118148d },
            { 1344000.0d, 0.000120826d },
            { 1372000.0d, 0.000123491d },
            { 1400000.0d, 0.000126142d },
            { 1428000.0d, 0.000128777d },
            { 1456000.0d, 0.000131396d },
            { 1484000.0d, 0.000133997d },
            { 1512000.0d, 0.000136581d },
            { 1540000.0d, 0.000139145d },
            { 1568000.0d, 0.000141689d },
            { 1596000.0d, 0.000144213d },
            { 1624000.0d, 0.000146715d },
            { 1652000.0d, 0.000149195d },
            { 1680000.0d, 0.000151651d },
            { 1708000.0d, 0.000154084d },
            { 1736000.0d, 0.000156492d },
            { 1764000.0d, 0.000158874d },
            { 1792000.0d, 0.00016123d },
            { 1820000.0d, 0.00016356d },
            { 1848000.0d, 0.000165861d },
            { 1876000.0d, 0.000168135d },
            { 1904000.0d, 0.000170379d },
            { 1932000.0d, 0.000172594d },
            { 1960000.0d, 0.000174778d },
            { 1988000.0d, 0.000176932d },
            { 2016000.0d, 0.000179053d },
            { 2044000.0d, 0.000181143d },
            { 2072000.0d, 0.0001832d },
            { 2100000.0d, 0.000185224d },
            { 2128000.0d, 0.000187213d },
            { 2156000.0d, 0.000189168d },
            { 2184000.0d, 0.000191088d },
            { 2212000.0d, 0.000192972d },
            { 2240000.0d, 0.000194821d },
            { 2268000.0d, 0.000196632d },
            { 2296000.0d, 0.000198407d },
            { 2324000.0d, 0.000200144d },
            { 2352000.0d, 0.000201843d },
            { 2380000.0d, 0.000203503d },
            { 2408000.0d, 0.000205125d },
            { 2436000.0d, 0.000206707d },
            { 2464000.0d, 0.000208249d },
            { 2492000.0d, 0.000209752d },
            { 2520000.0d, 0.000211214d },
            { 2548000.0d, 0.000212634d },
            { 2576000.0d, 0.000214014d },
            { 2604000.0d, 0.000215352d },
            { 2632000.0d, 0.000216648d },
            { 2660000.0d, 0.000217902d },
            { 2688000.0d, 0.000219114d },
            { 2716000.0d, 0.000220282d },
            { 2744000.0d, 0.000221407d },
            { 2772000.0d, 0.000222489d },
            { 2800000.0d, 0.000223528d },
            { 2828000.0d, 0.000224522d },
            { 2856000.0d, 0.000225473d },
            { 2884000.0d, 0.000226379d },
            { 2912000.0d, 0.00022724d },
            { 2940000.0d, 0.000228058d },
            { 2968000.0d, 0.00022883d },
            { 2996000.0d, 0.000229557d },
            { 3024000.0d, 0.000230239d },
            { 3052000.0d, 0.000230876d },
            { 3080000.0d, 0.000231466d },
            { 3108000.0d, 0.000232012d },
            { 3136000.0d, 0.000232513d },
            { 3164000.0d, 0.000232967d },
            { 3192000.0d, 0.000233376d },
            { 3220000.0d, 0.000233739d },
            { 3248000.0d, 0.000234056d },
            { 3276000.0d, 0.000234327d },
            { 3304000.0d, 0.000234552d },
            { 3332000.0d, 0.000234731d },
            { 3360000.0d, 0.000234864d },
            { 3388000.0d, 0.000234951d },
            { 3416000.0d, 0.000234993d },
            { 3444000.0d, 0.000234988d },
            { 3472000.0d, 0.000234938d },
            { 3500000.0d, 0.000234842d },
            { 3528000.0d, 0.0002347d },
            { 3556000.0d, 0.000234514d },
            { 3584000.0d, 0.000234281d },
            { 3612000.0d, 0.000234003d },
            { 3640000.0d, 0.00023368d },
            { 3668000.0d, 0.000233312d },
            { 3696000.0d, 0.000232899d },
            { 3724000.0d, 0.000232441d },
            { 3752000.0d, 0.000231939d },
            { 3780000.0d, 0.000231393d },
            { 3808000.0d, 0.000230802d },
            { 3836000.0d, 0.000230167d },
            { 3864000.0d, 0.000229489d },
            { 3892000.0d, 0.000228767d },
            { 3920000.0d, 0.000228002d },
            { 3948000.0d, 0.000227195d },
            { 3976000.0d, 0.000226344d },
            { 4004000.0d, 0.000225451d },
            { 4032000.0d, 0.000224516d },
            { 4060000.0d, 0.00022354d },
            { 4088000.0d, 0.000222522d },
            { 4116000.0d, 0.000221462d },
            { 4144000.0d, 0.000220363d },
            { 4172000.0d, 0.000219222d },
            { 4200000.0d, 0.000218042d },
            { 4228000.0d, 0.000216823d },
            { 4256000.0d, 0.000215564d },
            { 4284000.0d, 0.000214266d },
            { 4312000.0d, 0.00021293d },
            { 4340000.0d, 0.000211556d },
            { 4368000.0d, 0.000210145d },
            { 4396000.0d, 0.000208696d },
            { 4424000.0d, 0.000207212d },
            { 4452000.0d, 0.000205691d },
            { 4480000.0d, 0.000204135d },
            { 4508000.0d, 0.000202543d },
            { 4536000.0d, 0.000200917d },
            { 4564000.0d, 0.000199257d },
            { 4592000.0d, 0.000197564d },
            { 4620000.0d, 0.000195838d },
            { 4648000.0d, 0.00019408d },
            { 4676000.0d, 0.00019229d },
            { 4704000.0d, 0.000190469d },
            { 4732000.0d, 0.000188617d },
            { 4760000.0d, 0.000186736d },
            { 4788000.0d, 0.000184825d },
            { 4816000.0d, 0.000182886d },
            { 4844000.0d, 0.000180918d },
            { 4872000.0d, 0.000178924d },
            { 4900000.0d, 0.000176903d },
            { 4928000.0d, 0.000174856d },
            { 4956000.0d, 0.000172784d },
            { 4984000.0d, 0.000170687d },
            { 5012000.0d, 0.000168567d },
            { 5040000.0d, 0.000166424d },
            { 5068000.0d, 0.000164258d },
            { 5096000.0d, 0.000162071d },
            { 5124000.0d, 0.000159863d },
            { 5152000.0d, 0.000157635d },
            { 5180000.0d, 0.000155388d },
            { 5208000.0d, 0.000153123d },
            { 5236000.0d, 0.00015084d },
            { 5264000.0d, 0.000148541d },
            { 5292000.0d, 0.000146226d },
            { 5320000.0d, 0.000143896d },
            { 5348000.0d, 0.000141551d },
            { 5376000.0d, 0.000139194d },
            { 5404000.0d, 0.000136824d },
            { 5432000.0d, 0.000134443d },
            { 5460000.0d, 0.000132051d },
            { 5488000.0d, 0.00012965d },
            { 5516000.0d, 0.00012724d },
            { 5544000.0d, 0.000124822d },
            { 5572000.0d, 0.000122398d },
            { 5600000.0d, 0.000119968d },
            { 5628000.0d, 0.000117533d },
            { 5656000.0d, 0.000115095d },
            { 5684000.0d, 0.000112653d },
            { 5712000.0d, 0.00011021d },
            { 5740000.0d, 0.000107767d },
            { 5768000.0d, 0.000105323d },
            { 5796000.0d, 0.000102881d },
            { 5824000.0d, 0.000100442d },
            { 5852000.0d, 0.000098006d },
            { 5880000.0d, 0.0000955748d },
            { 5908000.0d, 0.0000931494d },
            { 5936000.0d, 0.0000907308d },
            { 5964000.0d, 0.0000883201d },
            { 5992000.0d, 0.0000859187d },
            { 6020000.0d, 0.0000835274d },
            { 6048000.0d, 0.0000811476d },
            { 6076000.0d, 0.0000787805d },
            { 6104000.0d, 0.0000764271d },
            { 6132000.0d, 0.0000740886d },
            { 6160000.0d, 0.0000717664d },
            { 6188000.0d, 0.0000694616d },
            { 6216000.0d, 0.0000671753d },
            { 6244000.0d, 0.000064909d },
            { 6272000.0d, 0.0000626637d },
            { 6300000.0d, 0.0000604409d },
            { 6328000.0d, 0.0000582417d },
            { 6356000.0d, 0.0000560673d },
            { 6384000.0d, 0.0000539193d },
            { 6412000.0d, 0.0000517987d },
            { 6440000.0d, 0.0000497069d },
            { 6468000.0d, 0.0000476453d },
            { 6496000.0d, 0.0000456152d },
            { 6524000.0d, 0.0000436179d },
            { 6552000.0d, 0.0000416548d },
            { 6580000.0d, 0.0000397273d },
            { 6608000.0d, 0.0000378367d },
            { 6636000.0d, 0.0000359844d },
            { 6664000.0d, 0.0000341719d },
            { 6692000.0d, 0.0000324005d },
            { 6720000.0d, 0.0000306716d },
            { 6748000.0d, 0.0000289866d },
            { 6776000.0d, 0.0000273471d },
            { 6804000.0d, 0.0000257544d },
            { 6832000.0d, 0.00002421d },
            { 6860000.0d, 0.0000227154d },
            { 6888000.0d, 0.0000212719d },
            { 6916000.0d, 0.0000198812d },
            { 6944000.0d, 0.0000185447d },
            { 6972000.0d, 0.0000172638d },
            { 7000000.0d, 0.0000160401d },
            { 7028000.0d, 0.000014875d },
            { 7056000.0d, 0.0000137702d },
            { 7084000.0d, 0.000012727d },
            { 7112000.0d, 0.000011747d },
            { 7140000.0d, 0.0000108317d },
            { 7168000.0d, 0.00000998261d },
            { 7196000.0d, 0.00000920111d },
            { 7224000.0d, 0.00000848871d },
            { 7252000.0d, 0.00000784675d },
            { 7280000.0d, 0.00000727136d },
            { 7308000.0d, 0.00000673407d },
            { 7336000.0d, 0.00000623084d },
            { 7364000.0d, 0.00000576242d },
            { 7392000.0d, 0.00000532959d },
            { 7420000.0d, 0.00000493309d },
            { 7448000.0d, 0.00000457346d },
            { 7476000.0d, 0.00000424662d },
            { 7504000.0d, 0.00000395102d },
            { 7532000.0d, 0.00000368297d },
            { 7560000.0d, 0.00000343883d },
            { 7588000.0d, 0.00000321901d },
            { 7616000.0d, 0.0000030222d },
            { 7644000.0d, 0.00000283372d },
            { 7672000.0d, 0.00000265003d },
            { 7700000.0d, 0.00000247127d },
            { 7728000.0d, 0.00000229756d },
            { 7756000.0d, 0.00000212904d },
            { 7784000.0d, 0.00000196584d },
            { 7812000.0d, 0.00000180811d },
            { 7840000.0d, 0.00000165597d },
            { 7868000.0d, 0.00000150957d },
            { 7896000.0d, 0.00000136904d },
            { 7924000.0d, 0.00000123453d },
            { 7952000.0d, 0.00000110616d },
            { 7980000.0d, 0.00000098408d },
            { 8008000.0d, 0.000000868431d },
            { 8036000.0d, 0.000000759351d },
            { 8064000.0d, 0.000000656981d },
            { 8092000.0d, 0.000000561462d },
            { 8120000.0d, 0.000000472935d },
            { 8148000.0d, 0.00000039154d },
            { 8176000.0d, 0.000000317419d },
            { 8204000.0d, 0.000000250711d },
            { 8232000.0d, 0.000000191557d },
            { 8260000.0d, 0.000000140095d },
            { 8288000.0d, 0.0000000964613d },
            { 8316000.0d, 0.0000000607906d },
            { 8344000.0d, 0.0000000332123d },
            { 8372000.0d, 0.0000000138482d },
            { 8400000.0d, 0.00000000280462d },
            { 8423000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    