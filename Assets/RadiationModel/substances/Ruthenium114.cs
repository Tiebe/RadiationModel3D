using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium114";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 113.92461d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium114()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.06480000000000001d, new GammaParticle(52700.0, 0.02353)), new(0.0288d, new GammaParticle(87700.0, 0.01414)), new(0.24d, new GammaParticle(127000.0, 0.00976)), new(0.1008d, new GammaParticle(128200.0, 0.00967)), new(0.07440000000000001d, new GammaParticle(179100.0, 0.00692)), new(0.011709811963200001d, new GammaParticle(2892.0, 0.42871)), new(0.043755096951337384d, new GammaParticle(20073.0, 0.06177)), new(0.08283812372460694d, new GammaParticle(20215.0, 0.06133)), new(0.022495810741042597d, new GammaParticle(22806.0, 0.05436)), new(0.026230115324055666d, new GammaParticle(22957.0, 0.05401)), new(0.003734304583013071d, new GammaParticle(23170.0, 0.05351)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000038785d },
            { 17000.0d, 0.000040748d },
            { 34000.0d, 0.0000428382d },
            { 51000.0d, 0.0000450556d },
            { 68000.0d, 0.000047392d },
            { 85000.0d, 0.0000498242d },
            { 102000.0d, 0.0000523319d },
            { 119000.0d, 0.0000549016d },
            { 136000.0d, 0.000057524d },
            { 153000.0d, 0.0000601922d },
            { 170000.0d, 0.0000629013d },
            { 187000.0d, 0.0000656472d },
            { 204000.0d, 0.0000684268d },
            { 221000.0d, 0.0000712373d },
            { 238000.0d, 0.0000740765d },
            { 255000.0d, 0.0000769423d },
            { 272000.0d, 0.0000798328d },
            { 289000.0d, 0.0000827463d },
            { 306000.0d, 0.0000856811d },
            { 323000.0d, 0.0000886357d },
            { 340000.0d, 0.0000916088d },
            { 357000.0d, 0.0000945987d },
            { 374000.0d, 0.0000976045d },
            { 391000.0d, 0.000100625d },
            { 408000.0d, 0.000103658d },
            { 425000.0d, 0.000106703d },
            { 442000.0d, 0.000109759d },
            { 459000.0d, 0.000112824d },
            { 476000.0d, 0.000115898d },
            { 493000.0d, 0.000118978d },
            { 510000.0d, 0.000122065d },
            { 527000.0d, 0.000125157d },
            { 544000.0d, 0.000128253d },
            { 561000.0d, 0.000131352d },
            { 578000.0d, 0.000134453d },
            { 595000.0d, 0.000137554d },
            { 612000.0d, 0.000140656d },
            { 629000.0d, 0.000143756d },
            { 646000.0d, 0.000146854d },
            { 663000.0d, 0.000149949d },
            { 680000.0d, 0.00015304d },
            { 697000.0d, 0.000156126d },
            { 714000.0d, 0.000159207d },
            { 731000.0d, 0.00016228d },
            { 748000.0d, 0.000165346d },
            { 765000.0d, 0.000168404d },
            { 782000.0d, 0.000171452d },
            { 799000.0d, 0.000174489d },
            { 816000.0d, 0.000177516d },
            { 833000.0d, 0.000180531d },
            { 850000.0d, 0.000183533d },
            { 867000.0d, 0.000186521d },
            { 884000.0d, 0.000189496d },
            { 901000.0d, 0.000192455d },
            { 918000.0d, 0.000195398d },
            { 935000.0d, 0.000198326d },
            { 952000.0d, 0.000201235d },
            { 969000.0d, 0.000204127d },
            { 986000.0d, 0.000206999d },
            { 1003000.0d, 0.000209852d },
            { 1021000.0d, 0.000212851d },
            { 1039000.0d, 0.000215827d },
            { 1057000.0d, 0.000218779d },
            { 1075000.0d, 0.000221705d },
            { 1093000.0d, 0.000224606d },
            { 1111000.0d, 0.000227481d },
            { 1129000.0d, 0.000230328d },
            { 1147000.0d, 0.000233147d },
            { 1165000.0d, 0.000235938d },
            { 1183000.0d, 0.000238699d },
            { 1201000.0d, 0.00024143d },
            { 1219000.0d, 0.000244131d },
            { 1237000.0d, 0.000246801d },
            { 1255000.0d, 0.000249437d },
            { 1273000.0d, 0.000252042d },
            { 1291000.0d, 0.000254613d },
            { 1309000.0d, 0.000257151d },
            { 1327000.0d, 0.000259654d },
            { 1345000.0d, 0.000262122d },
            { 1363000.0d, 0.000264555d },
            { 1381000.0d, 0.000266951d },
            { 1399000.0d, 0.000269311d },
            { 1417000.0d, 0.000271633d },
            { 1435000.0d, 0.000273918d },
            { 1453000.0d, 0.000276165d },
            { 1471000.0d, 0.000278373d },
            { 1489000.0d, 0.000280542d },
            { 1507000.0d, 0.000282671d },
            { 1525000.0d, 0.00028476d },
            { 1543000.0d, 0.000286808d },
            { 1561000.0d, 0.000288817d },
            { 1579000.0d, 0.000290783d },
            { 1597000.0d, 0.000292707d },
            { 1615000.0d, 0.00029459d },
            { 1633000.0d, 0.000296429d },
            { 1651000.0d, 0.000298226d },
            { 1669000.0d, 0.00029998d },
            { 1687000.0d, 0.00030169d },
            { 1705000.0d, 0.000303356d },
            { 1723000.0d, 0.000304979d },
            { 1741000.0d, 0.000306556d },
            { 1759000.0d, 0.000308088d },
            { 1777000.0d, 0.000309576d },
            { 1795000.0d, 0.000311018d },
            { 1813000.0d, 0.000312414d },
            { 1831000.0d, 0.000313765d },
            { 1849000.0d, 0.000315069d },
            { 1867000.0d, 0.000316326d },
            { 1885000.0d, 0.000317538d },
            { 1903000.0d, 0.000318702d },
            { 1921000.0d, 0.00031982d },
            { 1939000.0d, 0.00032089d },
            { 1957000.0d, 0.000321913d },
            { 1975000.0d, 0.000322888d },
            { 1993000.0d, 0.000323815d },
            { 2011000.0d, 0.000324695d },
            { 2029000.0d, 0.000325527d },
            { 2047000.0d, 0.000326311d },
            { 2065000.0d, 0.000327046d },
            { 2083000.0d, 0.000327733d },
            { 2101000.0d, 0.000328373d },
            { 2119000.0d, 0.000328964d },
            { 2137000.0d, 0.000329506d },
            { 2155000.0d, 0.000329999d },
            { 2173000.0d, 0.000330444d },
            { 2191000.0d, 0.00033084d },
            { 2209000.0d, 0.000331187d },
            { 2227000.0d, 0.000331486d },
            { 2245000.0d, 0.000331737d },
            { 2263000.0d, 0.000331939d },
            { 2281000.0d, 0.000332092d },
            { 2299000.0d, 0.000332196d },
            { 2317000.0d, 0.000332251d },
            { 2335000.0d, 0.000332259d },
            { 2353000.0d, 0.000332218d },
            { 2371000.0d, 0.000332128d },
            { 2389000.0d, 0.00033199d },
            { 2407000.0d, 0.000331804d },
            { 2425000.0d, 0.00033157d },
            { 2443000.0d, 0.000331288d },
            { 2461000.0d, 0.000330957d },
            { 2479000.0d, 0.000330579d },
            { 2497000.0d, 0.000330154d },
            { 2515000.0d, 0.000329681d },
            { 2533000.0d, 0.00032916d },
            { 2551000.0d, 0.000328593d },
            { 2569000.0d, 0.000327979d },
            { 2587000.0d, 0.000327318d },
            { 2605000.0d, 0.00032661d },
            { 2623000.0d, 0.000325856d },
            { 2641000.0d, 0.000325056d },
            { 2659000.0d, 0.00032421d },
            { 2677000.0d, 0.000323318d },
            { 2695000.0d, 0.000322381d },
            { 2713000.0d, 0.000321398d },
            { 2731000.0d, 0.000320371d },
            { 2749000.0d, 0.000319299d },
            { 2767000.0d, 0.000318183d },
            { 2785000.0d, 0.000317023d },
            { 2803000.0d, 0.000315819d },
            { 2821000.0d, 0.000314571d },
            { 2839000.0d, 0.000313281d },
            { 2857000.0d, 0.000311948d },
            { 2875000.0d, 0.000310572d },
            { 2893000.0d, 0.000309155d },
            { 2911000.0d, 0.000307695d },
            { 2929000.0d, 0.000306194d },
            { 2947000.0d, 0.000304652d },
            { 2965000.0d, 0.00030307d },
            { 2983000.0d, 0.000301448d },
            { 3001000.0d, 0.000299785d },
            { 3019000.0d, 0.000298084d },
            { 3037000.0d, 0.000296343d },
            { 3055000.0d, 0.000294564d },
            { 3073000.0d, 0.000292747d },
            { 3091000.0d, 0.000290893d },
            { 3109000.0d, 0.000289001d },
            { 3127000.0d, 0.000287072d },
            { 3145000.0d, 0.000285107d },
            { 3163000.0d, 0.000283107d },
            { 3181000.0d, 0.000281071d },
            { 3199000.0d, 0.000279001d },
            { 3217000.0d, 0.000276896d },
            { 3235000.0d, 0.000274759d },
            { 3253000.0d, 0.000272587d },
            { 3271000.0d, 0.000270383d },
            { 3289000.0d, 0.000268147d },
            { 3307000.0d, 0.00026588d },
            { 3325000.0d, 0.000263582d },
            { 3343000.0d, 0.000261253d },
            { 3361000.0d, 0.000258895d },
            { 3379000.0d, 0.000256507d },
            { 3397000.0d, 0.000254091d },
            { 3415000.0d, 0.000251646d },
            { 3433000.0d, 0.000249175d },
            { 3451000.0d, 0.000246677d },
            { 3469000.0d, 0.000244153d },
            { 3487000.0d, 0.000241603d },
            { 3505000.0d, 0.000239028d },
            { 3523000.0d, 0.000236429d },
            { 3541000.0d, 0.000233807d },
            { 3559000.0d, 0.000231162d },
            { 3577000.0d, 0.000228495d },
            { 3595000.0d, 0.000225806d },
            { 3613000.0d, 0.000223097d },
            { 3631000.0d, 0.000220368d },
            { 3649000.0d, 0.000217619d },
            { 3667000.0d, 0.000214852d },
            { 3685000.0d, 0.000212068d },
            { 3703000.0d, 0.000209265d },
            { 3721000.0d, 0.000206447d },
            { 3739000.0d, 0.000203613d },
            { 3757000.0d, 0.000200764d },
            { 3775000.0d, 0.000197901d },
            { 3793000.0d, 0.000195025d },
            { 3811000.0d, 0.000192137d },
            { 3829000.0d, 0.000189237d },
            { 3847000.0d, 0.000186325d },
            { 3865000.0d, 0.000183404d },
            { 3883000.0d, 0.000180474d },
            { 3901000.0d, 0.000177535d },
            { 3919000.0d, 0.000174589d },
            { 3937000.0d, 0.000171636d },
            { 3955000.0d, 0.000168677d },
            { 3973000.0d, 0.000165713d },
            { 3991000.0d, 0.000162745d },
            { 4009000.0d, 0.000159773d },
            { 4027000.0d, 0.0001568d },
            { 4045000.0d, 0.000153824d },
            { 4063000.0d, 0.000150848d },
            { 4081000.0d, 0.000147873d },
            { 4099000.0d, 0.000144898d },
            { 4117000.0d, 0.000141926d },
            { 4135000.0d, 0.000138957d },
            { 4153000.0d, 0.000135992d },
            { 4171000.0d, 0.000133032d },
            { 4189000.0d, 0.000130077d },
            { 4207000.0d, 0.00012713d },
            { 4225000.0d, 0.00012419d },
            { 4243000.0d, 0.000121259d },
            { 4261000.0d, 0.000118338d },
            { 4279000.0d, 0.000115428d },
            { 4297000.0d, 0.000112529d },
            { 4315000.0d, 0.000109644d },
            { 4333000.0d, 0.000106771d },
            { 4351000.0d, 0.000103914d },
            { 4369000.0d, 0.000101073d },
            { 4387000.0d, 0.0000982481d },
            { 4405000.0d, 0.0000954413d },
            { 4423000.0d, 0.0000926535d },
            { 4441000.0d, 0.0000898855d },
            { 4459000.0d, 0.0000871386d },
            { 4477000.0d, 0.0000844138d },
            { 4495000.0d, 0.0000817121d },
            { 4513000.0d, 0.0000790348d },
            { 4531000.0d, 0.0000763826d },
            { 4549000.0d, 0.0000737569d },
            { 4567000.0d, 0.0000711587d },
            { 4585000.0d, 0.0000685892d },
            { 4603000.0d, 0.0000660494d },
            { 4621000.0d, 0.0000635404d },
            { 4639000.0d, 0.0000610633d },
            { 4657000.0d, 0.0000586194d },
            { 4675000.0d, 0.0000562096d },
            { 4693000.0d, 0.0000538353d },
            { 4711000.0d, 0.0000514974d },
            { 4729000.0d, 0.0000491973d },
            { 4747000.0d, 0.0000469361d },
            { 4765000.0d, 0.0000447148d },
            { 4783000.0d, 0.0000425348d },
            { 4801000.0d, 0.0000403971d },
            { 4819000.0d, 0.000038303d },
            { 4837000.0d, 0.0000362536d },
            { 4855000.0d, 0.0000342502d },
            { 4873000.0d, 0.0000322939d },
            { 4891000.0d, 0.000030386d },
            { 4909000.0d, 0.0000285276d },
            { 4927000.0d, 0.0000267201d },
            { 4945000.0d, 0.0000249645d },
            { 4963000.0d, 0.0000232621d },
            { 4981000.0d, 0.0000216142d },
            { 4999000.0d, 0.0000200221d },
            { 5017000.0d, 0.000018487d },
            { 5035000.0d, 0.0000170099d },
            { 5053000.0d, 0.0000155924d },
            { 5071000.0d, 0.0000142356d },
            { 5089000.0d, 0.0000129406d },
            { 5107000.0d, 0.0000117089d },
            { 5125000.0d, 0.0000105417d },
            { 5143000.0d, 0.00000944014d },
            { 5161000.0d, 0.00000840557d },
            { 5179000.0d, 0.00000743922d },
            { 5197000.0d, 0.00000654231d },
            { 5215000.0d, 0.00000571607d },
            { 5233000.0d, 0.00000496161d },
            { 5251000.0d, 0.00000427516d },
            { 5269000.0d, 0.00000364742d },
            { 5287000.0d, 0.00000307847d },
            { 5305000.0d, 0.00000256926d },
            { 5323000.0d, 0.0000021203d },
            { 5341000.0d, 0.00000171853d },
            { 5359000.0d, 0.0000013572d },
            { 5377000.0d, 0.00000103699d },
            { 5395000.0d, 0.000000758574d },
            { 5413000.0d, 0.000000522596d },
            { 5431000.0d, 0.000000329706d },
            { 5449000.0d, 0.00000018053d },
            { 5467000.0d, 0.0000000756552d },
            { 5485000.0d, 0.0000000155962d },
            { 5500000.0d, 0d },

        }; 
    }
}
    