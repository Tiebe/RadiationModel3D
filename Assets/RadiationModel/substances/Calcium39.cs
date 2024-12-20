using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Calcium39 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium39";
        public override double halfLife { get; } = 0.8603d;
        public override double atomicWeight { get; } = 38.97071d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Argon39()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(2.5e-05d, new GammaParticle(2522200.0, 0.00049)), new(1.9985758000000002d, new GammaParticle(511000.0, 0.00243)), new(2.2e-06d, new GammaParticle(311.0, 3.98663)), new(2.97e-05d, new GammaParticle(3311.0, 0.37446)), new(5.8700000000000004e-05d, new GammaParticle(3314.0, 0.37412)), new(1.08e-05d, new GammaParticle(3591.0, 0.34526)), new(1.08e-05d, new GammaParticle(3591.0, 0.34526)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 3000.0d, 0.000000279913d },
            { 6000.0d, 0.000000592358d },
            { 9000.0d, 0.000000937319d },
            { 12000.0d, 0.00000131474d },
            { 15000.0d, 0.00000172457d },
            { 18000.0d, 0.00000216679d },
            { 21000.0d, 0.00000264137d },
            { 24000.0d, 0.00000314832d },
            { 27000.0d, 0.00000368761d },
            { 30000.0d, 0.00000425926d },
            { 33000.0d, 0.00000486325d },
            { 36000.0d, 0.00000549959d },
            { 39000.0d, 0.00000605466d },
            { 42000.0d, 0.00000660961d },
            { 45000.0d, 0.00000716445d },
            { 48000.0d, 0.00000771916d },
            { 51000.0d, 0.00000827376d },
            { 54000.0d, 0.00000882823d },
            { 57000.0d, 0.00000937413d },
            { 60000.0d, 0.00000991749d },
            { 63000.0d, 0.0000104583d },
            { 66000.0d, 0.0000109966d },
            { 69000.0d, 0.0000115324d },
            { 72000.0d, 0.0000120656d },
            { 75000.0d, 0.0000125974d },
            { 78000.0d, 0.000013127d },
            { 81000.0d, 0.0000136545d },
            { 84000.0d, 0.0000141797d },
            { 87000.0d, 0.0000147027d },
            { 90000.0d, 0.0000152235d },
            { 93000.0d, 0.0000157441d },
            { 96000.0d, 0.0000162631d },
            { 99000.0d, 0.0000167805d },
            { 102000.0d, 0.0000172963d },
            { 112000.0d, 0.0000190063d },
            { 122000.0d, 0.0000207058d },
            { 132000.0d, 0.0000223958d },
            { 142000.0d, 0.0000240788d },
            { 152000.0d, 0.0000257569d },
            { 162000.0d, 0.0000274305d },
            { 172000.0d, 0.0000291024d },
            { 182000.0d, 0.0000307721d },
            { 192000.0d, 0.0000324417d },
            { 202000.0d, 0.000034111d },
            { 212000.0d, 0.0000357814d },
            { 222000.0d, 0.0000374531d },
            { 232000.0d, 0.0000391266d },
            { 242000.0d, 0.0000408024d },
            { 252000.0d, 0.0000424806d },
            { 262000.0d, 0.000044162d },
            { 272000.0d, 0.0000458462d },
            { 282000.0d, 0.0000475339d },
            { 292000.0d, 0.000049225d },
            { 302000.0d, 0.0000509196d },
            { 312000.0d, 0.0000526179d },
            { 322000.0d, 0.0000543199d },
            { 332000.0d, 0.0000560257d },
            { 342000.0d, 0.0000577352d },
            { 352000.0d, 0.0000594486d },
            { 362000.0d, 0.0000611658d },
            { 372000.0d, 0.0000628867d },
            { 382000.0d, 0.0000646114d },
            { 392000.0d, 0.0000663397d },
            { 402000.0d, 0.0000680716d },
            { 412000.0d, 0.000069807d },
            { 422000.0d, 0.0000715459d },
            { 432000.0d, 0.0000732883d },
            { 442000.0d, 0.0000750338d },
            { 452000.0d, 0.0000767826d },
            { 462000.0d, 0.0000785344d },
            { 472000.0d, 0.0000802892d },
            { 482000.0d, 0.0000820468d },
            { 492000.0d, 0.0000838072d },
            { 502000.0d, 0.0000855701d },
            { 512000.0d, 0.0000873355d },
            { 522000.0d, 0.0000891035d },
            { 532000.0d, 0.0000908734d },
            { 542000.0d, 0.0000926455d },
            { 552000.0d, 0.0000944195d },
            { 562000.0d, 0.0000961954d },
            { 572000.0d, 0.0000979729d },
            { 582000.0d, 0.0000997519d },
            { 592000.0d, 0.000101532d },
            { 602000.0d, 0.000103314d },
            { 612000.0d, 0.000105097d },
            { 622000.0d, 0.00010688d },
            { 632000.0d, 0.000108665d },
            { 642000.0d, 0.00011045d },
            { 652000.0d, 0.000112236d },
            { 662000.0d, 0.000114022d },
            { 672000.0d, 0.000115808d },
            { 682000.0d, 0.000117594d },
            { 692000.0d, 0.00011938d },
            { 702000.0d, 0.000121166d },
            { 712000.0d, 0.000122952d },
            { 722000.0d, 0.000124737d },
            { 732000.0d, 0.000126522d },
            { 742000.0d, 0.000128305d },
            { 752000.0d, 0.000130088d },
            { 762000.0d, 0.000131869d },
            { 772000.0d, 0.000133649d },
            { 782000.0d, 0.000135428d },
            { 792000.0d, 0.000137205d },
            { 802000.0d, 0.00013898d },
            { 812000.0d, 0.000140753d },
            { 822000.0d, 0.000142524d },
            { 832000.0d, 0.000144293d },
            { 842000.0d, 0.00014606d },
            { 852000.0d, 0.000147824d },
            { 862000.0d, 0.000149586d },
            { 872000.0d, 0.000151346d },
            { 882000.0d, 0.000153102d },
            { 892000.0d, 0.000154855d },
            { 902000.0d, 0.000156605d },
            { 912000.0d, 0.000158351d },
            { 922000.0d, 0.000160094d },
            { 932000.0d, 0.000161833d },
            { 942000.0d, 0.000163569d },
            { 952000.0d, 0.000165301d },
            { 962000.0d, 0.000167029d },
            { 972000.0d, 0.000168752d },
            { 982000.0d, 0.000170471d },
            { 992000.0d, 0.000172186d },
            { 1002000.0d, 0.000173896d },
            { 1020000.0d, 0.000176962d },
            { 1038000.0d, 0.000180013d },
            { 1056000.0d, 0.000183046d },
            { 1074000.0d, 0.000186062d },
            { 1092000.0d, 0.000189059d },
            { 1110000.0d, 0.000192038d },
            { 1128000.0d, 0.000194996d },
            { 1146000.0d, 0.000197934d },
            { 1164000.0d, 0.00020085d },
            { 1182000.0d, 0.000203745d },
            { 1200000.0d, 0.000206616d },
            { 1218000.0d, 0.000209465d },
            { 1236000.0d, 0.000212289d },
            { 1254000.0d, 0.000215088d },
            { 1272000.0d, 0.000217862d },
            { 1290000.0d, 0.00022061d },
            { 1308000.0d, 0.000223332d },
            { 1326000.0d, 0.000226025d },
            { 1344000.0d, 0.000228691d },
            { 1362000.0d, 0.000231328d },
            { 1380000.0d, 0.000233936d },
            { 1398000.0d, 0.000236514d },
            { 1416000.0d, 0.000239062d },
            { 1434000.0d, 0.00024158d },
            { 1452000.0d, 0.000244065d },
            { 1470000.0d, 0.000246518d },
            { 1488000.0d, 0.000248939d },
            { 1506000.0d, 0.000251327d },
            { 1524000.0d, 0.000253681d },
            { 1542000.0d, 0.000256001d },
            { 1560000.0d, 0.000258286d },
            { 1578000.0d, 0.000260537d },
            { 1596000.0d, 0.000262752d },
            { 1614000.0d, 0.00026493d },
            { 1632000.0d, 0.000267072d },
            { 1650000.0d, 0.000269176d },
            { 1668000.0d, 0.000271244d },
            { 1686000.0d, 0.000273273d },
            { 1704000.0d, 0.000275264d },
            { 1722000.0d, 0.000277216d },
            { 1740000.0d, 0.000279128d },
            { 1758000.0d, 0.000281002d },
            { 1776000.0d, 0.000282835d },
            { 1794000.0d, 0.000284628d },
            { 1812000.0d, 0.000286379d },
            { 1830000.0d, 0.00028809d },
            { 1848000.0d, 0.00028976d },
            { 1866000.0d, 0.000291387d },
            { 1884000.0d, 0.000292973d },
            { 1902000.0d, 0.000294516d },
            { 1920000.0d, 0.000296016d },
            { 1938000.0d, 0.000297474d },
            { 1956000.0d, 0.000298888d },
            { 1974000.0d, 0.000300258d },
            { 1992000.0d, 0.000301585d },
            { 2010000.0d, 0.000302868d },
            { 2028000.0d, 0.000304105d },
            { 2046000.0d, 0.000305299d },
            { 2064000.0d, 0.000306447d },
            { 2082000.0d, 0.000307551d },
            { 2100000.0d, 0.000308609d },
            { 2118000.0d, 0.000309622d },
            { 2136000.0d, 0.00031059d },
            { 2154000.0d, 0.000311511d },
            { 2172000.0d, 0.000312387d },
            { 2190000.0d, 0.000313216d },
            { 2208000.0d, 0.000313999d },
            { 2226000.0d, 0.000314736d },
            { 2244000.0d, 0.000315427d },
            { 2262000.0d, 0.00031607d },
            { 2280000.0d, 0.000316666d },
            { 2298000.0d, 0.000317216d },
            { 2316000.0d, 0.00031772d },
            { 2334000.0d, 0.000318176d },
            { 2352000.0d, 0.000318584d },
            { 2370000.0d, 0.000318946d },
            { 2388000.0d, 0.000319261d },
            { 2406000.0d, 0.000319529d },
            { 2424000.0d, 0.000319749d },
            { 2442000.0d, 0.000319922d },
            { 2460000.0d, 0.000320048d },
            { 2478000.0d, 0.000320126d },
            { 2496000.0d, 0.000320157d },
            { 2514000.0d, 0.000320141d },
            { 2532000.0d, 0.000320078d },
            { 2550000.0d, 0.000319968d },
            { 2568000.0d, 0.000319811d },
            { 2586000.0d, 0.000319606d },
            { 2604000.0d, 0.000319355d },
            { 2622000.0d, 0.000319057d },
            { 2640000.0d, 0.000318712d },
            { 2658000.0d, 0.000318321d },
            { 2676000.0d, 0.000317882d },
            { 2694000.0d, 0.000317397d },
            { 2712000.0d, 0.000316866d },
            { 2730000.0d, 0.000316289d },
            { 2748000.0d, 0.000315667d },
            { 2766000.0d, 0.000314998d },
            { 2784000.0d, 0.000314283d },
            { 2802000.0d, 0.000313523d },
            { 2820000.0d, 0.000312718d },
            { 2838000.0d, 0.000311867d },
            { 2856000.0d, 0.000310971d },
            { 2874000.0d, 0.000310032d },
            { 2892000.0d, 0.000309047d },
            { 2910000.0d, 0.000308019d },
            { 2928000.0d, 0.000306946d },
            { 2946000.0d, 0.00030583d },
            { 2964000.0d, 0.00030467d },
            { 2982000.0d, 0.000303467d },
            { 3000000.0d, 0.000302222d },
            { 3018000.0d, 0.000300934d },
            { 3036000.0d, 0.000299603d },
            { 3054000.0d, 0.000298231d },
            { 3072000.0d, 0.000296817d },
            { 3090000.0d, 0.000295361d },
            { 3108000.0d, 0.000293865d },
            { 3126000.0d, 0.000292329d },
            { 3144000.0d, 0.000290752d },
            { 3162000.0d, 0.000289135d },
            { 3180000.0d, 0.000287479d },
            { 3198000.0d, 0.000285784d },
            { 3216000.0d, 0.00028405d },
            { 3234000.0d, 0.000282278d },
            { 3252000.0d, 0.000280468d },
            { 3270000.0d, 0.000278621d },
            { 3288000.0d, 0.000276737d },
            { 3306000.0d, 0.000274817d },
            { 3324000.0d, 0.00027286d },
            { 3342000.0d, 0.000270868d },
            { 3360000.0d, 0.000268842d },
            { 3378000.0d, 0.00026678d },
            { 3396000.0d, 0.000264684d },
            { 3414000.0d, 0.000262555d },
            { 3432000.0d, 0.000260393d },
            { 3450000.0d, 0.000258199d },
            { 3468000.0d, 0.000255972d },
            { 3486000.0d, 0.000253714d },
            { 3504000.0d, 0.000251426d },
            { 3522000.0d, 0.000249107d },
            { 3540000.0d, 0.000246758d },
            { 3558000.0d, 0.000244381d },
            { 3576000.0d, 0.000241975d },
            { 3594000.0d, 0.000239541d },
            { 3612000.0d, 0.00023708d },
            { 3630000.0d, 0.000234592d },
            { 3648000.0d, 0.000232078d },
            { 3666000.0d, 0.000229539d },
            { 3684000.0d, 0.000226976d },
            { 3702000.0d, 0.000224388d },
            { 3720000.0d, 0.000221777d },
            { 3738000.0d, 0.000219143d },
            { 3756000.0d, 0.000216487d },
            { 3774000.0d, 0.000213811d },
            { 3792000.0d, 0.000211113d },
            { 3810000.0d, 0.000208396d },
            { 3828000.0d, 0.00020566d },
            { 3846000.0d, 0.000202905d },
            { 3864000.0d, 0.000200133d },
            { 3882000.0d, 0.000197344d },
            { 3900000.0d, 0.000194538d },
            { 3918000.0d, 0.000191718d },
            { 3936000.0d, 0.000188883d },
            { 3954000.0d, 0.000186035d },
            { 3972000.0d, 0.000183173d },
            { 3990000.0d, 0.000180299d },
            { 4008000.0d, 0.000177415d },
            { 4026000.0d, 0.00017452d },
            { 4044000.0d, 0.000171615d },
            { 4062000.0d, 0.000168702d },
            { 4080000.0d, 0.000165781d },
            { 4098000.0d, 0.000162852d },
            { 4116000.0d, 0.000159918d },
            { 4134000.0d, 0.000156979d },
            { 4152000.0d, 0.000154035d },
            { 4170000.0d, 0.000151088d },
            { 4188000.0d, 0.000148139d },
            { 4206000.0d, 0.000145188d },
            { 4224000.0d, 0.000142237d },
            { 4242000.0d, 0.000139286d },
            { 4260000.0d, 0.000136336d },
            { 4278000.0d, 0.000133389d },
            { 4296000.0d, 0.000130445d },
            { 4314000.0d, 0.000127505d },
            { 4332000.0d, 0.00012457d },
            { 4350000.0d, 0.000121642d },
            { 4368000.0d, 0.000118721d },
            { 4386000.0d, 0.000115808d },
            { 4404000.0d, 0.000112905d },
            { 4422000.0d, 0.000110011d },
            { 4440000.0d, 0.00010713d },
            { 4458000.0d, 0.000104261d },
            { 4476000.0d, 0.000101405d },
            { 4494000.0d, 0.0000985641d },
            { 4512000.0d, 0.0000957392d },
            { 4530000.0d, 0.0000929308d },
            { 4548000.0d, 0.0000901403d },
            { 4566000.0d, 0.0000873689d },
            { 4584000.0d, 0.0000846177d },
            { 4602000.0d, 0.0000818878d },
            { 4620000.0d, 0.0000791803d },
            { 4638000.0d, 0.0000764964d },
            { 4656000.0d, 0.0000738372d },
            { 4674000.0d, 0.0000712039d },
            { 4692000.0d, 0.0000685978d },
            { 4710000.0d, 0.0000660198d },
            { 4728000.0d, 0.0000634713d },
            { 4746000.0d, 0.0000609535d },
            { 4764000.0d, 0.0000584676d },
            { 4782000.0d, 0.0000560148d },
            { 4800000.0d, 0.0000535963d },
            { 4818000.0d, 0.0000512133d },
            { 4836000.0d, 0.0000488671d },
            { 4854000.0d, 0.0000465591d },
            { 4872000.0d, 0.0000442903d },
            { 4890000.0d, 0.0000420621d },
            { 4908000.0d, 0.0000398757d },
            { 4926000.0d, 0.0000377326d },
            { 4944000.0d, 0.0000356338d },
            { 4962000.0d, 0.0000335808d },
            { 4980000.0d, 0.0000315749d },
            { 4998000.0d, 0.0000296172d },
            { 5016000.0d, 0.0000277094d },
            { 5034000.0d, 0.0000258525d },
            { 5052000.0d, 0.0000240481d },
            { 5070000.0d, 0.0000222974d },
            { 5088000.0d, 0.0000206017d },
            { 5106000.0d, 0.0000189625d },
            { 5124000.0d, 0.0000173811d },
            { 5142000.0d, 0.0000158589d },
            { 5160000.0d, 0.0000143973d },
            { 5178000.0d, 0.0000129976d },
            { 5196000.0d, 0.0000116613d },
            { 5214000.0d, 0.0000103897d },
            { 5232000.0d, 0.00000918427d },
            { 5250000.0d, 0.00000804643d },
            { 5268000.0d, 0.00000697757d },
            { 5286000.0d, 0.0000059791d },
            { 5304000.0d, 0.00000505245d },
            { 5322000.0d, 0.00000419903d },
            { 5340000.0d, 0.00000342027d },
            { 5358000.0d, 0.00000271758d },
            { 5376000.0d, 0.00000209239d },
            { 5394000.0d, 0.00000154608d },
            { 5412000.0d, 0.00000108005d },
            { 5430000.0d, 0.000000695678d },
            { 5448000.0d, 0.000000394294d },
            { 5466000.0d, 0.000000177177d },
            { 5484000.0d, 0.0000000454883d },
            { 5502000.0d, 0.0000000000280196d },
            { 5502500.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    