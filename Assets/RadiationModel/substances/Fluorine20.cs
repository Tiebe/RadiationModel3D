using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fluorine20 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine20";
        public override double halfLife { get; } = 11.07d;
        public override double atomicWeight { get; } = 19.99998d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neon20()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.999995d, new GammaParticle(1633602.0, 0.00076)), new(8.2e-05d, new GammaParticle(3332540.0, 0.00037)), new(5e-07d, new GammaParticle(4965850.0, 0.00025)), new(3.813197372690977e-08d, new GammaParticle(848.0, 1.46208)), new(1.9172756389890232e-08d, new GammaParticle(848.0, 1.46208)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000116702d },
            { 6000.0d, 0.0000129173d },
            { 12000.0d, 0.0000141303d },
            { 18000.0d, 0.0000153092d },
            { 24000.0d, 0.000016454d },
            { 30000.0d, 0.0000175647d },
            { 36000.0d, 0.0000186414d },
            { 42000.0d, 0.0000196839d },
            { 48000.0d, 0.0000206924d },
            { 54000.0d, 0.0000216802d },
            { 60000.0d, 0.0000226593d },
            { 66000.0d, 0.0000236203d },
            { 72000.0d, 0.0000245727d },
            { 78000.0d, 0.0000255183d },
            { 84000.0d, 0.000026454d },
            { 90000.0d, 0.0000273863d },
            { 96000.0d, 0.0000283141d },
            { 102000.0d, 0.0000292362d },
            { 112000.0d, 0.0000307705d },
            { 122000.0d, 0.000032298d },
            { 132000.0d, 0.0000338235d },
            { 142000.0d, 0.0000353477d },
            { 152000.0d, 0.0000368723d },
            { 162000.0d, 0.000038399d },
            { 172000.0d, 0.0000399279d },
            { 182000.0d, 0.0000414605d },
            { 192000.0d, 0.0000429969d },
            { 202000.0d, 0.0000445379d },
            { 212000.0d, 0.0000460839d },
            { 222000.0d, 0.000047635d },
            { 232000.0d, 0.0000491918d },
            { 242000.0d, 0.0000507542d },
            { 252000.0d, 0.0000523226d },
            { 262000.0d, 0.000053897d },
            { 272000.0d, 0.0000554774d },
            { 282000.0d, 0.000057064d },
            { 292000.0d, 0.0000586566d },
            { 302000.0d, 0.0000602555d },
            { 312000.0d, 0.0000618604d },
            { 322000.0d, 0.0000634715d },
            { 332000.0d, 0.0000650885d },
            { 342000.0d, 0.0000667116d },
            { 352000.0d, 0.0000683405d },
            { 362000.0d, 0.0000699752d },
            { 372000.0d, 0.0000716155d },
            { 382000.0d, 0.0000732615d },
            { 392000.0d, 0.000074913d },
            { 402000.0d, 0.0000765697d },
            { 412000.0d, 0.0000782317d },
            { 422000.0d, 0.0000798988d },
            { 432000.0d, 0.0000815708d },
            { 442000.0d, 0.0000832477d },
            { 452000.0d, 0.0000849292d },
            { 462000.0d, 0.0000866152d },
            { 472000.0d, 0.0000883056d },
            { 482000.0d, 0.0000900002d },
            { 492000.0d, 0.0000916989d },
            { 502000.0d, 0.0000934014d },
            { 512000.0d, 0.0000951076d },
            { 522000.0d, 0.0000968175d },
            { 532000.0d, 0.0000985309d },
            { 542000.0d, 0.000100248d },
            { 552000.0d, 0.000101967d },
            { 562000.0d, 0.00010369d },
            { 572000.0d, 0.000105415d },
            { 582000.0d, 0.000107142d },
            { 592000.0d, 0.000108873d },
            { 602000.0d, 0.000110606d },
            { 612000.0d, 0.00011234d },
            { 622000.0d, 0.000114077d },
            { 632000.0d, 0.000115816d },
            { 642000.0d, 0.000117556d },
            { 652000.0d, 0.000119297d },
            { 662000.0d, 0.00012104d },
            { 672000.0d, 0.000122783d },
            { 682000.0d, 0.000124528d },
            { 692000.0d, 0.000126274d },
            { 702000.0d, 0.00012802d },
            { 712000.0d, 0.000129767d },
            { 722000.0d, 0.000131513d },
            { 732000.0d, 0.00013326d },
            { 742000.0d, 0.000135007d },
            { 752000.0d, 0.000136753d },
            { 762000.0d, 0.0001385d },
            { 772000.0d, 0.000140245d },
            { 782000.0d, 0.00014199d },
            { 792000.0d, 0.000143734d },
            { 802000.0d, 0.000145478d },
            { 812000.0d, 0.00014722d },
            { 822000.0d, 0.00014896d },
            { 832000.0d, 0.000150698d },
            { 842000.0d, 0.000152435d },
            { 852000.0d, 0.000154171d },
            { 862000.0d, 0.000155905d },
            { 872000.0d, 0.000157636d },
            { 882000.0d, 0.000159365d },
            { 892000.0d, 0.000161092d },
            { 902000.0d, 0.000162816d },
            { 912000.0d, 0.000164536d },
            { 922000.0d, 0.000166254d },
            { 932000.0d, 0.00016797d },
            { 942000.0d, 0.000169681d },
            { 952000.0d, 0.000171389d },
            { 962000.0d, 0.000173094d },
            { 972000.0d, 0.000174796d },
            { 982000.0d, 0.000176493d },
            { 992000.0d, 0.000178187d },
            { 1002000.0d, 0.000179876d },
            { 1025000.0d, 0.000183745d },
            { 1048000.0d, 0.00018759d },
            { 1071000.0d, 0.000191409d },
            { 1094000.0d, 0.0001952d },
            { 1117000.0d, 0.000198961d },
            { 1140000.0d, 0.000202693d },
            { 1163000.0d, 0.00020639d },
            { 1186000.0d, 0.000210054d },
            { 1209000.0d, 0.000213681d },
            { 1232000.0d, 0.000217272d },
            { 1255000.0d, 0.000220824d },
            { 1278000.0d, 0.000224334d },
            { 1301000.0d, 0.000227803d },
            { 1324000.0d, 0.00023123d },
            { 1347000.0d, 0.000234611d },
            { 1370000.0d, 0.000237945d },
            { 1393000.0d, 0.000241233d },
            { 1416000.0d, 0.000244472d },
            { 1439000.0d, 0.00024766d },
            { 1462000.0d, 0.000250797d },
            { 1485000.0d, 0.000253882d },
            { 1508000.0d, 0.000256912d },
            { 1531000.0d, 0.000259888d },
            { 1554000.0d, 0.000262808d },
            { 1577000.0d, 0.000265669d },
            { 1600000.0d, 0.000268473d },
            { 1623000.0d, 0.000271216d },
            { 1646000.0d, 0.0002739d },
            { 1669000.0d, 0.000276521d },
            { 1692000.0d, 0.00027908d },
            { 1715000.0d, 0.000281575d },
            { 1738000.0d, 0.000284006d },
            { 1761000.0d, 0.000286371d },
            { 1784000.0d, 0.00028867d },
            { 1807000.0d, 0.000290902d },
            { 1830000.0d, 0.000293065d },
            { 1853000.0d, 0.00029516d },
            { 1876000.0d, 0.000297184d },
            { 1899000.0d, 0.000299139d },
            { 1922000.0d, 0.000301023d },
            { 1945000.0d, 0.000302835d },
            { 1968000.0d, 0.000304574d },
            { 1991000.0d, 0.00030624d },
            { 2014000.0d, 0.000307833d },
            { 2037000.0d, 0.00030935d },
            { 2060000.0d, 0.000310794d },
            { 2083000.0d, 0.000312162d },
            { 2106000.0d, 0.000313454d },
            { 2129000.0d, 0.000314669d },
            { 2152000.0d, 0.000315808d },
            { 2175000.0d, 0.000316869d },
            { 2198000.0d, 0.000317852d },
            { 2221000.0d, 0.000318758d },
            { 2244000.0d, 0.000319585d },
            { 2267000.0d, 0.000320334d },
            { 2290000.0d, 0.000321003d },
            { 2313000.0d, 0.000321593d },
            { 2336000.0d, 0.000322104d },
            { 2359000.0d, 0.000322535d },
            { 2382000.0d, 0.000322886d },
            { 2405000.0d, 0.000323159d },
            { 2428000.0d, 0.00032335d },
            { 2451000.0d, 0.000323461d },
            { 2474000.0d, 0.000323493d },
            { 2497000.0d, 0.000323444d },
            { 2520000.0d, 0.000323316d },
            { 2543000.0d, 0.000323108d },
            { 2566000.0d, 0.000322819d },
            { 2589000.0d, 0.00032245d },
            { 2612000.0d, 0.000322003d },
            { 2635000.0d, 0.000321475d },
            { 2658000.0d, 0.000320868d },
            { 2681000.0d, 0.000320183d },
            { 2704000.0d, 0.000319418d },
            { 2727000.0d, 0.000318574d },
            { 2750000.0d, 0.000317653d },
            { 2773000.0d, 0.000316653d },
            { 2796000.0d, 0.000315577d },
            { 2819000.0d, 0.000314422d },
            { 2842000.0d, 0.000313192d },
            { 2865000.0d, 0.000311885d },
            { 2888000.0d, 0.000310502d },
            { 2911000.0d, 0.000309044d },
            { 2934000.0d, 0.000307512d },
            { 2957000.0d, 0.000305905d },
            { 2980000.0d, 0.000304225d },
            { 3003000.0d, 0.000302472d },
            { 3026000.0d, 0.000300646d },
            { 3049000.0d, 0.00029875d },
            { 3072000.0d, 0.000296783d },
            { 3095000.0d, 0.000294745d },
            { 3118000.0d, 0.000292639d },
            { 3141000.0d, 0.000290463d },
            { 3164000.0d, 0.000288221d },
            { 3187000.0d, 0.000285911d },
            { 3210000.0d, 0.000283536d },
            { 3233000.0d, 0.000281096d },
            { 3256000.0d, 0.000278592d },
            { 3279000.0d, 0.000276025d },
            { 3302000.0d, 0.000273397d },
            { 3325000.0d, 0.000270708d },
            { 3348000.0d, 0.000267958d },
            { 3371000.0d, 0.00026515d },
            { 3394000.0d, 0.000262285d },
            { 3417000.0d, 0.000259363d },
            { 3440000.0d, 0.000256387d },
            { 3463000.0d, 0.000253356d },
            { 3486000.0d, 0.000250273d },
            { 3509000.0d, 0.000247139d },
            { 3532000.0d, 0.000243954d },
            { 3555000.0d, 0.000240721d },
            { 3578000.0d, 0.000237441d },
            { 3601000.0d, 0.000234114d },
            { 3624000.0d, 0.000230744d },
            { 3647000.0d, 0.00022733d },
            { 3670000.0d, 0.000223875d },
            { 3693000.0d, 0.000220381d },
            { 3716000.0d, 0.000216848d },
            { 3739000.0d, 0.000213278d },
            { 3762000.0d, 0.000209672d },
            { 3785000.0d, 0.000206034d },
            { 3808000.0d, 0.000202364d },
            { 3831000.0d, 0.000198664d },
            { 3854000.0d, 0.000194935d },
            { 3877000.0d, 0.00019118d },
            { 3900000.0d, 0.0001874d },
            { 3923000.0d, 0.000183598d },
            { 3946000.0d, 0.000179774d },
            { 3969000.0d, 0.000175932d },
            { 3992000.0d, 0.000172071d },
            { 4015000.0d, 0.000168196d },
            { 4038000.0d, 0.000164307d },
            { 4061000.0d, 0.000160408d },
            { 4084000.0d, 0.000156499d },
            { 4107000.0d, 0.000152582d },
            { 4130000.0d, 0.000148662d },
            { 4153000.0d, 0.000144737d },
            { 4176000.0d, 0.000140813d },
            { 4199000.0d, 0.00013689d },
            { 4222000.0d, 0.00013297d },
            { 4245000.0d, 0.000129057d },
            { 4268000.0d, 0.000125151d },
            { 4291000.0d, 0.000121257d },
            { 4314000.0d, 0.000117376d },
            { 4337000.0d, 0.000113509d },
            { 4360000.0d, 0.000109661d },
            { 4383000.0d, 0.000105833d },
            { 4406000.0d, 0.000102027d },
            { 4429000.0d, 0.0000982473d },
            { 4452000.0d, 0.0000944946d },
            { 4475000.0d, 0.0000907724d },
            { 4498000.0d, 0.0000870831d },
            { 4521000.0d, 0.0000834293d },
            { 4544000.0d, 0.0000798136d },
            { 4567000.0d, 0.0000762389d },
            { 4590000.0d, 0.0000727077d },
            { 4613000.0d, 0.000069223d },
            { 4636000.0d, 0.0000657873d },
            { 4659000.0d, 0.0000624036d },
            { 4682000.0d, 0.0000590747d },
            { 4705000.0d, 0.0000558035d },
            { 4728000.0d, 0.0000525927d },
            { 4751000.0d, 0.0000494457d },
            { 4774000.0d, 0.000046365d },
            { 4797000.0d, 0.0000433538d },
            { 4820000.0d, 0.0000404151d },
            { 4843000.0d, 0.000037552d },
            { 4866000.0d, 0.0000347675d },
            { 4889000.0d, 0.0000320649d },
            { 4912000.0d, 0.0000294471d },
            { 4935000.0d, 0.0000269174d },
            { 4958000.0d, 0.0000244791d },
            { 4981000.0d, 0.0000221353d },
            { 5004000.0d, 0.0000198894d },
            { 5027000.0d, 0.0000177447d },
            { 5050000.0d, 0.0000157044d },
            { 5073000.0d, 0.0000137721d },
            { 5096000.0d, 0.000011951d },
            { 5119000.0d, 0.0000102444d },
            { 5142000.0d, 0.00000865625d },
            { 5165000.0d, 0.00000718958d },
            { 5188000.0d, 0.00000584808d },
            { 5211000.0d, 0.00000463537d },
            { 5234000.0d, 0.00000355488d },
            { 5257000.0d, 0.00000261036d },
            { 5280000.0d, 0.00000180544d },
            { 5303000.0d, 0.00000114367d },
            { 5326000.0d, 0.000000628961d },
            { 5349000.0d, 0.000000264935d },
            { 5372000.0d, 0.000000055254d },
            { 5395000.0d, 0.00000000132054d },
            { 5418000.0d, 0.00000000130009d },
            { 5441000.0d, 0.00000000127941d },
            { 5464000.0d, 0.00000000125853d },
            { 5487000.0d, 0.00000000123745d },
            { 5510000.0d, 0.00000000121617d },
            { 5533000.0d, 0.00000000119469d },
            { 5556000.0d, 0.00000000117302d },
            { 5579000.0d, 0.00000000115118d },
            { 5602000.0d, 0.00000000112917d },
            { 5625000.0d, 0.00000000110698d },
            { 5648000.0d, 0.00000000108464d },
            { 5671000.0d, 0.00000000106215d },
            { 5694000.0d, 0.00000000103952d },
            { 5717000.0d, 0.00000000101674d },
            { 5740000.0d, 0.000000000993844d },
            { 5763000.0d, 0.00000000097083d },
            { 5786000.0d, 0.000000000947706d },
            { 5809000.0d, 0.000000000924485d },
            { 5832000.0d, 0.000000000901176d },
            { 5855000.0d, 0.00000000087779d },
            { 5878000.0d, 0.000000000854339d },
            { 5901000.0d, 0.000000000830835d },
            { 5924000.0d, 0.000000000807288d },
            { 5947000.0d, 0.000000000783713d },
            { 5970000.0d, 0.000000000760121d },
            { 5993000.0d, 0.000000000736528d },
            { 6016000.0d, 0.000000000712945d },
            { 6039000.0d, 0.000000000689389d },
            { 6062000.0d, 0.000000000665874d },
            { 6085000.0d, 0.000000000642414d },
            { 6108000.0d, 0.000000000619027d },
            { 6131000.0d, 0.00000000059573d },
            { 6154000.0d, 0.000000000572538d },
            { 6177000.0d, 0.00000000054947d },
            { 6200000.0d, 0.000000000526545d },
            { 6223000.0d, 0.00000000050378d },
            { 6246000.0d, 0.000000000481194d },
            { 6269000.0d, 0.000000000458808d },
            { 6292000.0d, 0.000000000436643d },
            { 6315000.0d, 0.00000000041472d },
            { 6338000.0d, 0.000000000393059d },
            { 6361000.0d, 0.000000000371683d },
            { 6384000.0d, 0.000000000350616d },
            { 6407000.0d, 0.000000000329881d },
            { 6430000.0d, 0.000000000309502d },
            { 6453000.0d, 0.000000000289504d },
            { 6476000.0d, 0.000000000269913d },
            { 6499000.0d, 0.000000000250754d },
            { 6522000.0d, 0.000000000232054d },
            { 6545000.0d, 0.000000000213841d },
            { 6568000.0d, 0.000000000196144d },
            { 6591000.0d, 0.000000000178991d },
            { 6614000.0d, 0.000000000162413d },
            { 6637000.0d, 0.000000000146438d },
            { 6660000.0d, 0.000000000131097d },
            { 6683000.0d, 0.000000000116424d },
            { 6706000.0d, 0.000000000102451d },
            { 6729000.0d, 0.0000000000892093d },
            { 6752000.0d, 0.0000000000767344d },
            { 6775000.0d, 0.0000000000650605d },
            { 6798000.0d, 0.0000000000542229d },
            { 6821000.0d, 0.0000000000442575d },
            { 6844000.0d, 0.000000000035201d },
            { 6867000.0d, 0.0000000000270906d },
            { 6890000.0d, 0.0000000000199642d },
            { 6913000.0d, 0.0000000000138601d },
            { 6936000.0d, 0.00000000000881695d },
            { 6959000.0d, 0.00000000000487358d },
            { 6982000.0d, 0.0000000000020686d },
            { 7005000.0d, 0.000000000000438958d },
            { 7024530.0d, 0d },

        }; 
    }
}
    