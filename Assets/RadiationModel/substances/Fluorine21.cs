using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fluorine21 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine21";
        public override double halfLife { get; } = 4.158d;
        public override double atomicWeight { get; } = 20.99995d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neon21()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.008955d, new GammaParticle(350725.0, 0.00354)), new(0.15339914999999998d, new GammaParticle(1395131.0, 0.00089)), new(0.007737119999999999d, new GammaParticle(1745800.0, 0.00071)), new(1.791e-05d, new GammaParticle(1890400.0, 0.00066)), new(1.9701e-06d, new GammaParticle(1989000.0, 0.00062)), new(1.585035e-05d, new GammaParticle(2779400.0, 0.00045)), new(1.791e-05d, new GammaParticle(2793940.0, 0.00044)), new(3.49245e-06d, new GammaParticle(3384600.0, 0.00037)), new(2.91933e-05d, new GammaParticle(3533200.0, 0.00035)), new(2.48949e-05d, new GammaParticle(3735200.0, 0.00033)), new(9.58185e-06d, new GammaParticle(3883900.0, 0.00032)), new(0.0003196935d, new GammaParticle(4174100.0, 0.0003)), new(0.00047551049999999996d, new GammaParticle(4333520.0, 0.00029)), new(9.4923e-05d, new GammaParticle(4525840.0, 0.00027)), new(0.0002802915d, new GammaParticle(4684270.0, 0.00026)), new(3.684316297577855e-14d, new GammaParticle(848.0, 1.46208)), new(1.8524742344221454e-14d, new GammaParticle(848.0, 1.46208)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000151922d },
            { 3000.0d, 0.0000160239d },
            { 6000.0d, 0.0000168479d },
            { 9000.0d, 0.0000176641d },
            { 12000.0d, 0.0000184678d },
            { 15000.0d, 0.000019258d },
            { 18000.0d, 0.0000200345d },
            { 21000.0d, 0.0000207972d },
            { 24000.0d, 0.0000215463d },
            { 27000.0d, 0.0000222819d },
            { 30000.0d, 0.000023004d },
            { 33000.0d, 0.0000237127d },
            { 36000.0d, 0.000024408d },
            { 39000.0d, 0.0000250901d },
            { 42000.0d, 0.0000257636d },
            { 45000.0d, 0.0000264258d },
            { 48000.0d, 0.0000270765d },
            { 51000.0d, 0.0000277159d },
            { 54000.0d, 0.000028357d },
            { 57000.0d, 0.0000289932d },
            { 60000.0d, 0.0000296229d },
            { 63000.0d, 0.0000302461d },
            { 66000.0d, 0.0000308633d },
            { 69000.0d, 0.0000314772d },
            { 72000.0d, 0.0000320897d },
            { 75000.0d, 0.0000326986d },
            { 78000.0d, 0.0000333037d },
            { 81000.0d, 0.0000339058d },
            { 84000.0d, 0.0000345044d },
            { 87000.0d, 0.0000351015d },
            { 90000.0d, 0.0000356967d },
            { 93000.0d, 0.0000362901d },
            { 96000.0d, 0.0000368814d },
            { 99000.0d, 0.0000374704d },
            { 102000.0d, 0.0000380573d },
            { 112000.0d, 0.0000400075d },
            { 122000.0d, 0.0000419442d },
            { 132000.0d, 0.0000438725d },
            { 142000.0d, 0.0000457939d },
            { 152000.0d, 0.0000477107d },
            { 162000.0d, 0.0000496247d },
            { 172000.0d, 0.0000515365d },
            { 182000.0d, 0.000053448d },
            { 192000.0d, 0.0000553596d },
            { 202000.0d, 0.000057272d },
            { 212000.0d, 0.0000591857d },
            { 222000.0d, 0.0000611012d },
            { 232000.0d, 0.000063019d },
            { 242000.0d, 0.0000649391d },
            { 252000.0d, 0.000066862d },
            { 262000.0d, 0.0000687876d },
            { 272000.0d, 0.0000707161d },
            { 282000.0d, 0.0000726475d },
            { 292000.0d, 0.0000745819d },
            { 302000.0d, 0.0000765194d },
            { 312000.0d, 0.0000784599d },
            { 322000.0d, 0.0000804032d },
            { 332000.0d, 0.0000823494d },
            { 342000.0d, 0.0000842985d },
            { 352000.0d, 0.0000862503d },
            { 362000.0d, 0.0000882046d },
            { 372000.0d, 0.0000901615d },
            { 382000.0d, 0.0000921206d },
            { 392000.0d, 0.0000940819d },
            { 402000.0d, 0.0000960453d },
            { 412000.0d, 0.0000980107d },
            { 422000.0d, 0.0000999778d },
            { 432000.0d, 0.000101947d },
            { 442000.0d, 0.000103917d },
            { 452000.0d, 0.000105888d },
            { 462000.0d, 0.000107861d },
            { 472000.0d, 0.000109834d },
            { 482000.0d, 0.000111809d },
            { 492000.0d, 0.000113784d },
            { 502000.0d, 0.000115759d },
            { 512000.0d, 0.000117735d },
            { 522000.0d, 0.00011971d },
            { 532000.0d, 0.000121686d },
            { 542000.0d, 0.000123661d },
            { 552000.0d, 0.000125636d },
            { 562000.0d, 0.000127611d },
            { 572000.0d, 0.000129585d },
            { 582000.0d, 0.000131557d },
            { 592000.0d, 0.000133529d },
            { 602000.0d, 0.000135499d },
            { 612000.0d, 0.000137468d },
            { 622000.0d, 0.000139435d },
            { 632000.0d, 0.000141401d },
            { 642000.0d, 0.000143365d },
            { 652000.0d, 0.000145326d },
            { 662000.0d, 0.000147286d },
            { 672000.0d, 0.000149243d },
            { 682000.0d, 0.000151197d },
            { 692000.0d, 0.000153149d },
            { 702000.0d, 0.000155098d },
            { 712000.0d, 0.000157044d },
            { 722000.0d, 0.000158987d },
            { 732000.0d, 0.000160926d },
            { 742000.0d, 0.000162863d },
            { 752000.0d, 0.000164795d },
            { 762000.0d, 0.000166724d },
            { 772000.0d, 0.000168649d },
            { 782000.0d, 0.000170571d },
            { 792000.0d, 0.000172488d },
            { 802000.0d, 0.000174401d },
            { 812000.0d, 0.00017631d },
            { 822000.0d, 0.000178214d },
            { 832000.0d, 0.000180113d },
            { 842000.0d, 0.000182009d },
            { 852000.0d, 0.000183899d },
            { 862000.0d, 0.000185785d },
            { 872000.0d, 0.000187665d },
            { 882000.0d, 0.000189541d },
            { 892000.0d, 0.000191411d },
            { 902000.0d, 0.000193277d },
            { 912000.0d, 0.000195136d },
            { 922000.0d, 0.00019699d },
            { 932000.0d, 0.000198839d },
            { 942000.0d, 0.000200682d },
            { 952000.0d, 0.00020252d },
            { 962000.0d, 0.000204352d },
            { 972000.0d, 0.000206178d },
            { 982000.0d, 0.000207997d },
            { 992000.0d, 0.000209811d },
            { 1002000.0d, 0.000211618d },
            { 1020000.0d, 0.000214853d },
            { 1038000.0d, 0.00021806d },
            { 1056000.0d, 0.000221238d },
            { 1074000.0d, 0.000224388d },
            { 1092000.0d, 0.000227508d },
            { 1110000.0d, 0.000230597d },
            { 1128000.0d, 0.000233655d },
            { 1146000.0d, 0.000236681d },
            { 1164000.0d, 0.000239674d },
            { 1182000.0d, 0.000242632d },
            { 1200000.0d, 0.000245553d },
            { 1218000.0d, 0.000248436d },
            { 1236000.0d, 0.000251281d },
            { 1254000.0d, 0.000254086d },
            { 1272000.0d, 0.000256852d },
            { 1290000.0d, 0.000259577d },
            { 1308000.0d, 0.000262261d },
            { 1326000.0d, 0.000264902d },
            { 1344000.0d, 0.0002675d },
            { 1362000.0d, 0.000270054d },
            { 1380000.0d, 0.000272565d },
            { 1398000.0d, 0.00027503d },
            { 1416000.0d, 0.00027745d },
            { 1434000.0d, 0.000279823d },
            { 1452000.0d, 0.000282151d },
            { 1470000.0d, 0.00028443d },
            { 1488000.0d, 0.000286662d },
            { 1506000.0d, 0.000288844d },
            { 1524000.0d, 0.000290978d },
            { 1542000.0d, 0.000293063d },
            { 1560000.0d, 0.000295097d },
            { 1578000.0d, 0.000297081d },
            { 1596000.0d, 0.000299014d },
            { 1614000.0d, 0.000300895d },
            { 1632000.0d, 0.000302725d },
            { 1650000.0d, 0.000304502d },
            { 1668000.0d, 0.000306227d },
            { 1686000.0d, 0.000307899d },
            { 1704000.0d, 0.000309516d },
            { 1722000.0d, 0.000311081d },
            { 1740000.0d, 0.000312591d },
            { 1758000.0d, 0.000314047d },
            { 1776000.0d, 0.000315448d },
            { 1794000.0d, 0.000316794d },
            { 1812000.0d, 0.000318084d },
            { 1830000.0d, 0.000319319d },
            { 1848000.0d, 0.000320498d },
            { 1866000.0d, 0.000321621d },
            { 1884000.0d, 0.000322688d },
            { 1902000.0d, 0.000323698d },
            { 1920000.0d, 0.000324652d },
            { 1938000.0d, 0.000325549d },
            { 1956000.0d, 0.00032639d },
            { 1974000.0d, 0.000327172d },
            { 1992000.0d, 0.000327898d },
            { 2010000.0d, 0.000328567d },
            { 2028000.0d, 0.000329178d },
            { 2046000.0d, 0.000329732d },
            { 2064000.0d, 0.000330229d },
            { 2082000.0d, 0.000330668d },
            { 2100000.0d, 0.00033105d },
            { 2118000.0d, 0.000331374d },
            { 2136000.0d, 0.000331641d },
            { 2154000.0d, 0.000331851d },
            { 2172000.0d, 0.000332003d },
            { 2190000.0d, 0.000332098d },
            { 2208000.0d, 0.000332136d },
            { 2226000.0d, 0.000332117d },
            { 2244000.0d, 0.000332042d },
            { 2262000.0d, 0.000331909d },
            { 2280000.0d, 0.00033172d },
            { 2298000.0d, 0.000331475d },
            { 2316000.0d, 0.000331174d },
            { 2334000.0d, 0.000330816d },
            { 2352000.0d, 0.000330403d },
            { 2370000.0d, 0.000329934d },
            { 2388000.0d, 0.000329411d },
            { 2406000.0d, 0.000328832d },
            { 2424000.0d, 0.000328199d },
            { 2442000.0d, 0.000327511d },
            { 2460000.0d, 0.000326769d },
            { 2478000.0d, 0.000325973d },
            { 2496000.0d, 0.000325125d },
            { 2514000.0d, 0.000324224d },
            { 2532000.0d, 0.000323269d },
            { 2550000.0d, 0.000322264d },
            { 2568000.0d, 0.000321206d },
            { 2586000.0d, 0.000320096d },
            { 2604000.0d, 0.000318937d },
            { 2622000.0d, 0.000317726d },
            { 2640000.0d, 0.000316466d },
            { 2658000.0d, 0.000315158d },
            { 2676000.0d, 0.000313799d },
            { 2694000.0d, 0.000312393d },
            { 2712000.0d, 0.000310939d },
            { 2730000.0d, 0.000309438d },
            { 2748000.0d, 0.00030789d },
            { 2766000.0d, 0.000306296d },
            { 2784000.0d, 0.000304657d },
            { 2802000.0d, 0.000302974d },
            { 2820000.0d, 0.000301246d },
            { 2838000.0d, 0.000299475d },
            { 2856000.0d, 0.000297662d },
            { 2874000.0d, 0.000295806d },
            { 2892000.0d, 0.00029391d },
            { 2910000.0d, 0.000291972d },
            { 2928000.0d, 0.000289994d },
            { 2946000.0d, 0.000287978d },
            { 2964000.0d, 0.000285924d },
            { 2982000.0d, 0.000283833d },
            { 3000000.0d, 0.000281704d },
            { 3018000.0d, 0.00027954d },
            { 3036000.0d, 0.000277341d },
            { 3054000.0d, 0.000275108d },
            { 3072000.0d, 0.000272841d },
            { 3090000.0d, 0.000270542d },
            { 3108000.0d, 0.000268212d },
            { 3126000.0d, 0.000265852d },
            { 3144000.0d, 0.000263462d },
            { 3162000.0d, 0.000261043d },
            { 3180000.0d, 0.000258596d },
            { 3198000.0d, 0.000256124d },
            { 3216000.0d, 0.000253625d },
            { 3234000.0d, 0.000251102d },
            { 3252000.0d, 0.000248555d },
            { 3270000.0d, 0.000245986d },
            { 3288000.0d, 0.000243395d },
            { 3306000.0d, 0.000240784d },
            { 3324000.0d, 0.000238154d },
            { 3342000.0d, 0.000235505d },
            { 3360000.0d, 0.000232839d },
            { 3378000.0d, 0.000230158d },
            { 3396000.0d, 0.000227461d },
            { 3414000.0d, 0.000224751d },
            { 3432000.0d, 0.00022203d },
            { 3450000.0d, 0.000219296d },
            { 3468000.0d, 0.000216552d },
            { 3486000.0d, 0.0002138d },
            { 3504000.0d, 0.000211041d },
            { 3522000.0d, 0.000208275d },
            { 3540000.0d, 0.000205504d },
            { 3558000.0d, 0.000202729d },
            { 3576000.0d, 0.000199952d },
            { 3594000.0d, 0.000197174d },
            { 3612000.0d, 0.000194397d },
            { 3630000.0d, 0.000191621d },
            { 3648000.0d, 0.000188848d },
            { 3666000.0d, 0.000186079d },
            { 3684000.0d, 0.000183317d },
            { 3702000.0d, 0.000180561d },
            { 3720000.0d, 0.000177814d },
            { 3738000.0d, 0.000175077d },
            { 3756000.0d, 0.000172352d },
            { 3774000.0d, 0.00016964d },
            { 3792000.0d, 0.000166941d },
            { 3810000.0d, 0.000164259d },
            { 3828000.0d, 0.000161594d },
            { 3846000.0d, 0.000158948d },
            { 3864000.0d, 0.000156323d },
            { 3882000.0d, 0.00015372d },
            { 3900000.0d, 0.000151139d },
            { 3918000.0d, 0.000148583d },
            { 3936000.0d, 0.000146054d },
            { 3954000.0d, 0.000143539d },
            { 3972000.0d, 0.000141017d },
            { 3990000.0d, 0.000138489d },
            { 4008000.0d, 0.000135956d },
            { 4026000.0d, 0.000133419d },
            { 4044000.0d, 0.000130878d },
            { 4062000.0d, 0.000128333d },
            { 4080000.0d, 0.000125788d },
            { 4098000.0d, 0.00012324d },
            { 4116000.0d, 0.000120693d },
            { 4134000.0d, 0.000118146d },
            { 4152000.0d, 0.000115601d },
            { 4170000.0d, 0.000113058d },
            { 4188000.0d, 0.000110518d },
            { 4206000.0d, 0.000107982d },
            { 4224000.0d, 0.000105451d },
            { 4242000.0d, 0.000102926d },
            { 4260000.0d, 0.000100408d },
            { 4278000.0d, 0.0000978981d },
            { 4296000.0d, 0.0000953963d },
            { 4314000.0d, 0.0000929043d },
            { 4332000.0d, 0.0000904228d },
            { 4350000.0d, 0.0000879529d },
            { 4368000.0d, 0.0000854954d },
            { 4386000.0d, 0.0000830515d },
            { 4404000.0d, 0.000080622d },
            { 4422000.0d, 0.0000782078d },
            { 4440000.0d, 0.0000758103d },
            { 4458000.0d, 0.00007343d },
            { 4476000.0d, 0.0000710683d },
            { 4494000.0d, 0.0000687261d },
            { 4512000.0d, 0.0000664044d },
            { 4530000.0d, 0.0000641044d },
            { 4548000.0d, 0.0000618269d },
            { 4566000.0d, 0.000059573d },
            { 4584000.0d, 0.0000573439d },
            { 4602000.0d, 0.0000551406d },
            { 4620000.0d, 0.0000529643d },
            { 4638000.0d, 0.0000508159d },
            { 4656000.0d, 0.0000486966d },
            { 4674000.0d, 0.0000466074d },
            { 4692000.0d, 0.0000445495d },
            { 4710000.0d, 0.0000425241d },
            { 4728000.0d, 0.0000405322d },
            { 4746000.0d, 0.0000385751d },
            { 4764000.0d, 0.0000366537d },
            { 4782000.0d, 0.0000347693d },
            { 4800000.0d, 0.0000329231d },
            { 4818000.0d, 0.0000311161d },
            { 4836000.0d, 0.0000293495d },
            { 4854000.0d, 0.0000276247d },
            { 4872000.0d, 0.0000259426d },
            { 4890000.0d, 0.0000243046d },
            { 4908000.0d, 0.0000227118d },
            { 4926000.0d, 0.0000211654d },
            { 4944000.0d, 0.0000196667d },
            { 4962000.0d, 0.0000182168d },
            { 4980000.0d, 0.000016817d },
            { 4998000.0d, 0.0000154685d },
            { 5016000.0d, 0.0000141726d },
            { 5034000.0d, 0.0000129305d },
            { 5052000.0d, 0.0000117434d },
            { 5070000.0d, 0.0000106127d },
            { 5088000.0d, 0.00000953947d },
            { 5106000.0d, 0.00000852509d },
            { 5124000.0d, 0.0000075708d },
            { 5142000.0d, 0.00000667784d },
            { 5160000.0d, 0.00000584751d },
            { 5178000.0d, 0.00000508107d },
            { 5196000.0d, 0.00000437978d },
            { 5214000.0d, 0.00000374488d },
            { 5232000.0d, 0.00000317767d },
            { 5250000.0d, 0.00000267937d },
            { 5268000.0d, 0.00000225122d },
            { 5286000.0d, 0.0000018944d },
            { 5304000.0d, 0.00000161005d },
            { 5322000.0d, 0.00000139921d },
            { 5340000.0d, 0.00000125792d },
            { 5358000.0d, 0.00000113598d },
            { 5376000.0d, 0.00000101957d },
            { 5394000.0d, 0.000000908812d },
            { 5412000.0d, 0.000000803811d },
            { 5430000.0d, 0.000000704691d },
            { 5448000.0d, 0.000000611569d },
            { 5466000.0d, 0.000000524564d },
            { 5484000.0d, 0.000000443792d },
            { 5502000.0d, 0.000000369372d },
            { 5520000.0d, 0.000000301422d },
            { 5538000.0d, 0.000000240061d },
            { 5556000.0d, 0.000000185405d },
            { 5574000.0d, 0.00000013757d },
            { 5592000.0d, 0.0000000966731d },
            { 5610000.0d, 0.0000000628275d },
            { 5628000.0d, 0.0000000361435d },
            { 5646000.0d, 0.0000000167271d },
            { 5664000.0d, 0.00000000467433d },
            { 5682000.0d, 0.000000000053489d },
            { 5684200.0d, 0d },

        }; 
    }
}
    