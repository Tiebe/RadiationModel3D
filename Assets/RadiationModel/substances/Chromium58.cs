using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium58";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 57.94418d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese58()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.53d, new GammaParticle(126000.0, 0.00984)), new(0.00795d, new GammaParticle(174000.0, 0.00713)), new(0.1325d, new GammaParticle(289500.0, 0.00428)), new(0.11130000000000001d, new GammaParticle(520400.0, 0.00238)), new(0.5724d, new GammaParticle(682900.0, 0.00182)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000105029d },
            { 10000.0d, 0.000108457d },
            { 20000.0d, 0.000112643d },
            { 30000.0d, 0.000117587d },
            { 40000.0d, 0.000122936d },
            { 50000.0d, 0.000128459d },
            { 60000.0d, 0.00013408d },
            { 70000.0d, 0.000139754d },
            { 80000.0d, 0.000145461d },
            { 90000.0d, 0.000151187d },
            { 100000.0d, 0.000156927d },
            { 110000.0d, 0.000162677d },
            { 120000.0d, 0.000168434d },
            { 130000.0d, 0.000174198d },
            { 140000.0d, 0.000179966d },
            { 150000.0d, 0.000185738d },
            { 160000.0d, 0.000191514d },
            { 170000.0d, 0.000197293d },
            { 180000.0d, 0.000203074d },
            { 190000.0d, 0.000208857d },
            { 200000.0d, 0.00021464d },
            { 210000.0d, 0.000220425d },
            { 220000.0d, 0.000226208d },
            { 230000.0d, 0.00023199d },
            { 240000.0d, 0.00023777d },
            { 250000.0d, 0.000243547d },
            { 260000.0d, 0.00024932d },
            { 270000.0d, 0.000255089d },
            { 280000.0d, 0.000260852d },
            { 290000.0d, 0.000266608d },
            { 300000.0d, 0.000272357d },
            { 310000.0d, 0.000278097d },
            { 320000.0d, 0.000283828d },
            { 330000.0d, 0.000289549d },
            { 340000.0d, 0.000295258d },
            { 350000.0d, 0.000300955d },
            { 360000.0d, 0.000306639d },
            { 370000.0d, 0.000312306d },
            { 380000.0d, 0.00031796d },
            { 390000.0d, 0.000323597d },
            { 400000.0d, 0.000329216d },
            { 410000.0d, 0.000334817d },
            { 420000.0d, 0.000340398d },
            { 430000.0d, 0.000345959d },
            { 440000.0d, 0.000351498d },
            { 450000.0d, 0.000357015d },
            { 460000.0d, 0.000362508d },
            { 470000.0d, 0.000367977d },
            { 480000.0d, 0.00037342d },
            { 490000.0d, 0.000378837d },
            { 500000.0d, 0.000384226d },
            { 510000.0d, 0.000389587d },
            { 520000.0d, 0.000394918d },
            { 530000.0d, 0.00040022d },
            { 540000.0d, 0.000405489d },
            { 550000.0d, 0.000410728d },
            { 560000.0d, 0.000415932d },
            { 570000.0d, 0.000421103d },
            { 580000.0d, 0.00042624d },
            { 590000.0d, 0.000431339d },
            { 600000.0d, 0.000436403d },
            { 610000.0d, 0.000441429d },
            { 620000.0d, 0.000446417d },
            { 630000.0d, 0.000451365d },
            { 640000.0d, 0.000456274d },
            { 650000.0d, 0.00046114d },
            { 660000.0d, 0.000465967d },
            { 670000.0d, 0.000470749d },
            { 680000.0d, 0.00047549d },
            { 690000.0d, 0.000480185d },
            { 700000.0d, 0.000484836d },
            { 710000.0d, 0.000489441d },
            { 720000.0d, 0.000494d },
            { 730000.0d, 0.000498511d },
            { 740000.0d, 0.000502975d },
            { 750000.0d, 0.00050739d },
            { 760000.0d, 0.000511756d },
            { 770000.0d, 0.000516072d },
            { 780000.0d, 0.000520337d },
            { 790000.0d, 0.000524551d },
            { 800000.0d, 0.000528712d },
            { 810000.0d, 0.000532821d },
            { 820000.0d, 0.000536877d },
            { 830000.0d, 0.000540878d },
            { 840000.0d, 0.000544824d },
            { 850000.0d, 0.000548716d },
            { 860000.0d, 0.000552553d },
            { 870000.0d, 0.000556332d },
            { 880000.0d, 0.000560054d },
            { 890000.0d, 0.00056372d },
            { 900000.0d, 0.000567327d },
            { 910000.0d, 0.000570875d },
            { 920000.0d, 0.000574364d },
            { 930000.0d, 0.000577793d },
            { 940000.0d, 0.000581163d },
            { 950000.0d, 0.000584471d },
            { 960000.0d, 0.000587718d },
            { 970000.0d, 0.000590905d },
            { 980000.0d, 0.000594028d },
            { 990000.0d, 0.000597089d },
            { 1000000.0d, 0.000600088d },
            { 1013000.0d, 0.00060389d },
            { 1026000.0d, 0.000607585d },
            { 1039000.0d, 0.000611171d },
            { 1052000.0d, 0.000614647d },
            { 1065000.0d, 0.000618012d },
            { 1078000.0d, 0.000621266d },
            { 1091000.0d, 0.000624408d },
            { 1104000.0d, 0.000627438d },
            { 1117000.0d, 0.000630353d },
            { 1130000.0d, 0.000633155d },
            { 1143000.0d, 0.000635842d },
            { 1156000.0d, 0.000638413d },
            { 1169000.0d, 0.000640868d },
            { 1182000.0d, 0.000643208d },
            { 1195000.0d, 0.00064543d },
            { 1208000.0d, 0.000647534d },
            { 1221000.0d, 0.000649521d },
            { 1234000.0d, 0.000651391d },
            { 1247000.0d, 0.000653141d },
            { 1260000.0d, 0.000654773d },
            { 1273000.0d, 0.000656285d },
            { 1286000.0d, 0.000657679d },
            { 1299000.0d, 0.000658952d },
            { 1312000.0d, 0.000660105d },
            { 1325000.0d, 0.00066114d },
            { 1338000.0d, 0.000662053d },
            { 1351000.0d, 0.000662846d },
            { 1364000.0d, 0.000663519d },
            { 1377000.0d, 0.000664072d },
            { 1390000.0d, 0.000664505d },
            { 1403000.0d, 0.000664817d },
            { 1416000.0d, 0.00066501d },
            { 1429000.0d, 0.000665082d },
            { 1442000.0d, 0.000665034d },
            { 1455000.0d, 0.000664866d },
            { 1468000.0d, 0.000664578d },
            { 1481000.0d, 0.000664171d },
            { 1494000.0d, 0.000663645d },
            { 1507000.0d, 0.000663d },
            { 1520000.0d, 0.000662237d },
            { 1533000.0d, 0.000661355d },
            { 1546000.0d, 0.000660356d },
            { 1559000.0d, 0.000659239d },
            { 1572000.0d, 0.000658005d },
            { 1585000.0d, 0.000656655d },
            { 1598000.0d, 0.000655188d },
            { 1611000.0d, 0.000653607d },
            { 1624000.0d, 0.00065191d },
            { 1637000.0d, 0.000650099d },
            { 1650000.0d, 0.000648174d },
            { 1663000.0d, 0.000646136d },
            { 1676000.0d, 0.000643986d },
            { 1689000.0d, 0.000641725d },
            { 1702000.0d, 0.000639352d },
            { 1715000.0d, 0.000636869d },
            { 1728000.0d, 0.000634277d },
            { 1741000.0d, 0.000631577d },
            { 1754000.0d, 0.00062877d },
            { 1767000.0d, 0.000625855d },
            { 1780000.0d, 0.000622835d },
            { 1793000.0d, 0.000619711d },
            { 1806000.0d, 0.000616482d },
            { 1819000.0d, 0.00061315d },
            { 1832000.0d, 0.000609718d },
            { 1845000.0d, 0.000606185d },
            { 1858000.0d, 0.000602552d },
            { 1871000.0d, 0.00059882d },
            { 1884000.0d, 0.000594993d },
            { 1897000.0d, 0.000591069d },
            { 1910000.0d, 0.000587051d },
            { 1923000.0d, 0.000582939d },
            { 1936000.0d, 0.000578735d },
            { 1949000.0d, 0.000574441d },
            { 1962000.0d, 0.000570057d },
            { 1975000.0d, 0.000565585d },
            { 1988000.0d, 0.000561026d },
            { 2001000.0d, 0.000556383d },
            { 2014000.0d, 0.000551656d },
            { 2027000.0d, 0.000546848d },
            { 2040000.0d, 0.000541959d },
            { 2053000.0d, 0.00053699d },
            { 2066000.0d, 0.000531946d },
            { 2079000.0d, 0.000526824d },
            { 2092000.0d, 0.000521628d },
            { 2105000.0d, 0.000516361d },
            { 2118000.0d, 0.000511023d },
            { 2131000.0d, 0.000505617d },
            { 2144000.0d, 0.000500143d },
            { 2157000.0d, 0.000494603d },
            { 2170000.0d, 0.000489001d },
            { 2183000.0d, 0.000483337d },
            { 2196000.0d, 0.000477613d },
            { 2209000.0d, 0.000471832d },
            { 2222000.0d, 0.000465996d },
            { 2235000.0d, 0.000460105d },
            { 2248000.0d, 0.000454163d },
            { 2261000.0d, 0.000448171d },
            { 2274000.0d, 0.000442132d },
            { 2287000.0d, 0.000436047d },
            { 2300000.0d, 0.000429919d },
            { 2313000.0d, 0.00042375d },
            { 2326000.0d, 0.000417542d },
            { 2339000.0d, 0.000411297d },
            { 2352000.0d, 0.000405018d },
            { 2365000.0d, 0.000398706d },
            { 2378000.0d, 0.000392365d },
            { 2391000.0d, 0.000385996d },
            { 2404000.0d, 0.000379602d },
            { 2417000.0d, 0.000373186d },
            { 2430000.0d, 0.000366749d },
            { 2443000.0d, 0.000360295d },
            { 2456000.0d, 0.000353825d },
            { 2469000.0d, 0.000347342d },
            { 2482000.0d, 0.000340849d },
            { 2495000.0d, 0.000334349d },
            { 2508000.0d, 0.000327843d },
            { 2521000.0d, 0.000321334d },
            { 2534000.0d, 0.000314826d },
            { 2547000.0d, 0.000308322d },
            { 2560000.0d, 0.000301822d },
            { 2573000.0d, 0.00029533d },
            { 2586000.0d, 0.00028885d },
            { 2599000.0d, 0.000282384d },
            { 2612000.0d, 0.000275934d },
            { 2625000.0d, 0.000269504d },
            { 2638000.0d, 0.000263096d },
            { 2651000.0d, 0.000256715d },
            { 2664000.0d, 0.00025036d },
            { 2677000.0d, 0.000244037d },
            { 2690000.0d, 0.000237749d },
            { 2703000.0d, 0.000231498d },
            { 2716000.0d, 0.000225287d },
            { 2729000.0d, 0.00021912d },
            { 2742000.0d, 0.000212999d },
            { 2755000.0d, 0.000206928d },
            { 2768000.0d, 0.00020091d },
            { 2781000.0d, 0.000194947d },
            { 2794000.0d, 0.000189044d },
            { 2807000.0d, 0.000183203d },
            { 2820000.0d, 0.000177428d },
            { 2833000.0d, 0.000171722d },
            { 2846000.0d, 0.000166088d },
            { 2859000.0d, 0.00016053d },
            { 2872000.0d, 0.000155051d },
            { 2885000.0d, 0.000149654d },
            { 2898000.0d, 0.000144343d },
            { 2911000.0d, 0.000139121d },
            { 2924000.0d, 0.000133992d },
            { 2937000.0d, 0.000128959d },
            { 2950000.0d, 0.000124026d },
            { 2963000.0d, 0.000119196d },
            { 2976000.0d, 0.000114473d },
            { 2989000.0d, 0.00010986d },
            { 3002000.0d, 0.000105361d },
            { 3015000.0d, 0.000100981d },
            { 3028000.0d, 0.000096721d },
            { 3041000.0d, 0.0000925864d },
            { 3054000.0d, 0.0000885806d },
            { 3067000.0d, 0.0000847072d },
            { 3080000.0d, 0.0000809699d },
            { 3093000.0d, 0.0000773726d },
            { 3106000.0d, 0.0000739191d },
            { 3119000.0d, 0.0000706129d },
            { 3132000.0d, 0.0000674582d },
            { 3145000.0d, 0.0000644586d },
            { 3158000.0d, 0.0000616179d },
            { 3171000.0d, 0.00005894d },
            { 3184000.0d, 0.0000564289d },
            { 3197000.0d, 0.000054088d },
            { 3210000.0d, 0.0000519214d },
            { 3223000.0d, 0.0000499329d },
            { 3236000.0d, 0.0000481261d },
            { 3249000.0d, 0.0000465042d },
            { 3262000.0d, 0.0000450684d },
            { 3275000.0d, 0.000043714d },
            { 3288000.0d, 0.0000423819d },
            { 3301000.0d, 0.0000410728d },
            { 3314000.0d, 0.0000397876d },
            { 3327000.0d, 0.0000385269d },
            { 3340000.0d, 0.0000372914d },
            { 3353000.0d, 0.0000360821d },
            { 3366000.0d, 0.0000348994d },
            { 3379000.0d, 0.0000337442d },
            { 3392000.0d, 0.000032617d },
            { 3405000.0d, 0.0000315079d },
            { 3418000.0d, 0.0000304116d },
            { 3431000.0d, 0.0000293285d },
            { 3444000.0d, 0.0000282591d },
            { 3457000.0d, 0.0000272039d },
            { 3470000.0d, 0.0000261634d },
            { 3483000.0d, 0.0000251381d },
            { 3496000.0d, 0.0000241284d },
            { 3509000.0d, 0.0000231349d },
            { 3522000.0d, 0.000022158d },
            { 3535000.0d, 0.0000211983d },
            { 3548000.0d, 0.0000202563d },
            { 3561000.0d, 0.0000193325d },
            { 3574000.0d, 0.0000184272d },
            { 3587000.0d, 0.0000175413d },
            { 3600000.0d, 0.0000166749d },
            { 3613000.0d, 0.0000158287d },
            { 3626000.0d, 0.0000150013d },
            { 3639000.0d, 0.0000141922d },
            { 3652000.0d, 0.0000134019d },
            { 3665000.0d, 0.000012631d },
            { 3678000.0d, 0.0000118799d },
            { 3691000.0d, 0.0000111492d },
            { 3704000.0d, 0.0000104391d },
            { 3717000.0d, 0.0000097504d },
            { 3730000.0d, 0.00000908343d },
            { 3743000.0d, 0.0000084387d },
            { 3756000.0d, 0.00000781672d },
            { 3769000.0d, 0.00000721797d },
            { 3782000.0d, 0.00000664287d },
            { 3795000.0d, 0.00000608958d },
            { 3808000.0d, 0.00000555723d },
            { 3821000.0d, 0.00000504628d },
            { 3834000.0d, 0.00000455715d },
            { 3847000.0d, 0.00000409031d },
            { 3860000.0d, 0.00000364619d },
            { 3873000.0d, 0.00000322526d },
            { 3886000.0d, 0.00000282797d },
            { 3899000.0d, 0.00000245476d },
            { 3912000.0d, 0.00000210609d },
            { 3925000.0d, 0.00000178242d },
            { 3938000.0d, 0.0000014842d },
            { 3951000.0d, 0.00000121189d },
            { 3964000.0d, 0.000000965938d },
            { 3977000.0d, 0.000000746796d },
            { 3990000.0d, 0.000000554916d },
            { 4003000.0d, 0.000000390744d },
            { 4016000.0d, 0.00000025472d },
            { 4029000.0d, 0.000000147276d },
            { 4042000.0d, 0.0000000688241d },
            { 4055000.0d, 0.0000000197489d },
            { 4068000.0d, 0.000000000347735d },
            { 4070000.0d, 0d },

        }; 
    }
}
    