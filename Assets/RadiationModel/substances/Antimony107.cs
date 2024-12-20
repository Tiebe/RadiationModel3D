using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony107 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony107";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 106.92415d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 16000.0d, 0.000000131637d },
            { 32000.0d, 0.000000756602d },
            { 48000.0d, 0.00000184246d },
            { 64000.0d, 0.00000329245d },
            { 80000.0d, 0.00000498776d },
            { 96000.0d, 0.00000685658d },
            { 112000.0d, 0.00000885294d },
            { 128000.0d, 0.0000109426d },
            { 144000.0d, 0.0000131046d },
            { 160000.0d, 0.0000153225d },
            { 176000.0d, 0.0000175852d },
            { 192000.0d, 0.0000198846d },
            { 208000.0d, 0.0000222149d },
            { 224000.0d, 0.0000245712d },
            { 240000.0d, 0.0000269499d },
            { 256000.0d, 0.000029348d },
            { 272000.0d, 0.0000317635d },
            { 288000.0d, 0.0000341945d },
            { 304000.0d, 0.0000366392d },
            { 320000.0d, 0.0000390965d },
            { 336000.0d, 0.0000415652d },
            { 352000.0d, 0.0000440442d },
            { 368000.0d, 0.0000465327d },
            { 384000.0d, 0.0000490299d },
            { 400000.0d, 0.0000515351d },
            { 416000.0d, 0.0000540473d },
            { 432000.0d, 0.0000565661d },
            { 448000.0d, 0.0000590907d },
            { 464000.0d, 0.0000616207d },
            { 480000.0d, 0.0000641553d },
            { 496000.0d, 0.000066694d },
            { 512000.0d, 0.0000692363d },
            { 528000.0d, 0.0000717816d },
            { 544000.0d, 0.0000743294d },
            { 560000.0d, 0.0000768792d },
            { 576000.0d, 0.0000794304d },
            { 592000.0d, 0.0000819826d },
            { 608000.0d, 0.0000845351d },
            { 624000.0d, 0.0000870877d },
            { 640000.0d, 0.0000896397d },
            { 656000.0d, 0.0000921907d },
            { 672000.0d, 0.0000947402d },
            { 688000.0d, 0.0000972878d },
            { 704000.0d, 0.0000998329d },
            { 720000.0d, 0.000102375d },
            { 736000.0d, 0.000104914d },
            { 752000.0d, 0.000107449d },
            { 768000.0d, 0.000109979d },
            { 784000.0d, 0.000112505d },
            { 800000.0d, 0.000115026d },
            { 816000.0d, 0.000117541d },
            { 832000.0d, 0.00012005d },
            { 848000.0d, 0.000122553d },
            { 864000.0d, 0.000125049d },
            { 880000.0d, 0.000127537d },
            { 896000.0d, 0.000130018d },
            { 912000.0d, 0.00013249d },
            { 928000.0d, 0.000134954d },
            { 944000.0d, 0.000137409d },
            { 960000.0d, 0.000139855d },
            { 976000.0d, 0.00014229d },
            { 992000.0d, 0.000144716d },
            { 1008000.0d, 0.000147131d },
            { 1030000.0d, 0.000150434d },
            { 1052000.0d, 0.000153715d },
            { 1074000.0d, 0.000156973d },
            { 1096000.0d, 0.000160208d },
            { 1118000.0d, 0.000163418d },
            { 1140000.0d, 0.000166602d },
            { 1162000.0d, 0.000169761d },
            { 1184000.0d, 0.000172892d },
            { 1206000.0d, 0.000175994d },
            { 1228000.0d, 0.000179068d },
            { 1250000.0d, 0.000182112d },
            { 1272000.0d, 0.000185125d },
            { 1294000.0d, 0.000188106d },
            { 1316000.0d, 0.000191056d },
            { 1338000.0d, 0.000193972d },
            { 1360000.0d, 0.000196854d },
            { 1382000.0d, 0.000199701d },
            { 1404000.0d, 0.000202513d },
            { 1426000.0d, 0.000205289d },
            { 1448000.0d, 0.000208028d },
            { 1470000.0d, 0.00021073d },
            { 1492000.0d, 0.000213393d },
            { 1514000.0d, 0.000216017d },
            { 1536000.0d, 0.000218602d },
            { 1558000.0d, 0.000221147d },
            { 1580000.0d, 0.000223651d },
            { 1602000.0d, 0.000226113d },
            { 1624000.0d, 0.000228534d },
            { 1646000.0d, 0.000230912d },
            { 1668000.0d, 0.000233246d },
            { 1690000.0d, 0.000235538d },
            { 1712000.0d, 0.000237784d },
            { 1734000.0d, 0.000239987d },
            { 1756000.0d, 0.000242144d },
            { 1778000.0d, 0.000244255d },
            { 1800000.0d, 0.00024632d },
            { 1822000.0d, 0.000248338d },
            { 1844000.0d, 0.00025031d },
            { 1866000.0d, 0.000252234d },
            { 1888000.0d, 0.00025411d },
            { 1910000.0d, 0.000255937d },
            { 1932000.0d, 0.000257716d },
            { 1954000.0d, 0.000259446d },
            { 1976000.0d, 0.000261127d },
            { 1998000.0d, 0.000262758d },
            { 2020000.0d, 0.000264338d },
            { 2042000.0d, 0.000265869d },
            { 2064000.0d, 0.000267348d },
            { 2086000.0d, 0.000268777d },
            { 2108000.0d, 0.000270155d },
            { 2130000.0d, 0.000271481d },
            { 2152000.0d, 0.000272755d },
            { 2174000.0d, 0.000273977d },
            { 2196000.0d, 0.000275148d },
            { 2218000.0d, 0.000276266d },
            { 2240000.0d, 0.000277331d },
            { 2262000.0d, 0.000278344d },
            { 2284000.0d, 0.000279304d },
            { 2306000.0d, 0.00028021d },
            { 2328000.0d, 0.000281064d },
            { 2350000.0d, 0.000281865d },
            { 2372000.0d, 0.000282612d },
            { 2394000.0d, 0.000283305d },
            { 2416000.0d, 0.000283946d },
            { 2438000.0d, 0.000284533d },
            { 2460000.0d, 0.000285066d },
            { 2482000.0d, 0.000285546d },
            { 2504000.0d, 0.000285972d },
            { 2526000.0d, 0.000286344d },
            { 2548000.0d, 0.000286663d },
            { 2570000.0d, 0.000286929d },
            { 2592000.0d, 0.00028714d },
            { 2614000.0d, 0.000287299d },
            { 2636000.0d, 0.000287404d },
            { 2658000.0d, 0.000287455d },
            { 2680000.0d, 0.000287454d },
            { 2702000.0d, 0.000287399d },
            { 2724000.0d, 0.000287291d },
            { 2746000.0d, 0.000287131d },
            { 2768000.0d, 0.000286917d },
            { 2790000.0d, 0.000286652d },
            { 2812000.0d, 0.000286333d },
            { 2834000.0d, 0.000285963d },
            { 2856000.0d, 0.000285541d },
            { 2878000.0d, 0.000285067d },
            { 2900000.0d, 0.000284542d },
            { 2922000.0d, 0.000283965d },
            { 2944000.0d, 0.000283337d },
            { 2966000.0d, 0.000282659d },
            { 2988000.0d, 0.00028193d },
            { 3010000.0d, 0.000281151d },
            { 3032000.0d, 0.000280322d },
            { 3054000.0d, 0.000279443d },
            { 3076000.0d, 0.000278516d },
            { 3098000.0d, 0.000277539d },
            { 3120000.0d, 0.000276514d },
            { 3142000.0d, 0.000275441d },
            { 3164000.0d, 0.000274321d },
            { 3186000.0d, 0.000273153d },
            { 3208000.0d, 0.000271938d },
            { 3230000.0d, 0.000270677d },
            { 3252000.0d, 0.00026937d },
            { 3274000.0d, 0.000268017d },
            { 3296000.0d, 0.000266619d },
            { 3318000.0d, 0.000265177d },
            { 3340000.0d, 0.00026369d },
            { 3362000.0d, 0.00026216d },
            { 3384000.0d, 0.000260587d },
            { 3406000.0d, 0.000258971d },
            { 3428000.0d, 0.000257314d },
            { 3450000.0d, 0.000255615d },
            { 3472000.0d, 0.000253875d },
            { 3494000.0d, 0.000252095d },
            { 3516000.0d, 0.000250275d },
            { 3538000.0d, 0.000248417d },
            { 3560000.0d, 0.000246519d },
            { 3582000.0d, 0.000244585d },
            { 3604000.0d, 0.000242613d },
            { 3626000.0d, 0.000240604d },
            { 3648000.0d, 0.00023856d },
            { 3670000.0d, 0.000236481d },
            { 3692000.0d, 0.000234367d },
            { 3714000.0d, 0.00023222d },
            { 3736000.0d, 0.00023004d },
            { 3758000.0d, 0.000227827d },
            { 3780000.0d, 0.000225583d },
            { 3802000.0d, 0.000223309d },
            { 3824000.0d, 0.000221005d },
            { 3846000.0d, 0.000218671d },
            { 3868000.0d, 0.000216309d },
            { 3890000.0d, 0.00021392d },
            { 3912000.0d, 0.000211504d },
            { 3934000.0d, 0.000209063d },
            { 3956000.0d, 0.000206596d },
            { 3978000.0d, 0.000204106d },
            { 4000000.0d, 0.000201592d },
            { 4022000.0d, 0.000199056d },
            { 4044000.0d, 0.000196499d },
            { 4066000.0d, 0.000193921d },
            { 4088000.0d, 0.000191324d },
            { 4110000.0d, 0.000188708d },
            { 4132000.0d, 0.000186074d },
            { 4154000.0d, 0.000183424d },
            { 4176000.0d, 0.000180758d },
            { 4198000.0d, 0.000178078d },
            { 4220000.0d, 0.000175384d },
            { 4242000.0d, 0.000172677d },
            { 4264000.0d, 0.000169958d },
            { 4286000.0d, 0.000167229d },
            { 4308000.0d, 0.000164491d },
            { 4330000.0d, 0.000161744d },
            { 4352000.0d, 0.00015899d },
            { 4374000.0d, 0.000156229d },
            { 4396000.0d, 0.000153464d },
            { 4418000.0d, 0.000150694d },
            { 4440000.0d, 0.000147921d },
            { 4462000.0d, 0.000145147d },
            { 4484000.0d, 0.000142372d },
            { 4506000.0d, 0.000139598d },
            { 4528000.0d, 0.000136825d },
            { 4550000.0d, 0.000134055d },
            { 4572000.0d, 0.00013129d },
            { 4594000.0d, 0.00012853d },
            { 4616000.0d, 0.000125776d },
            { 4638000.0d, 0.00012303d },
            { 4660000.0d, 0.000120294d },
            { 4682000.0d, 0.000117567d },
            { 4704000.0d, 0.000114852d },
            { 4726000.0d, 0.00011215d },
            { 4748000.0d, 0.000109463d },
            { 4770000.0d, 0.000106791d },
            { 4792000.0d, 0.000104135d },
            { 4814000.0d, 0.000101498d },
            { 4836000.0d, 0.0000988803d },
            { 4858000.0d, 0.0000962834d },
            { 4880000.0d, 0.0000937066d },
            { 4902000.0d, 0.000091151d },
            { 4924000.0d, 0.0000886176d },
            { 4946000.0d, 0.0000861077d },
            { 4968000.0d, 0.0000836228d },
            { 4990000.0d, 0.0000811643d },
            { 5012000.0d, 0.0000787336d },
            { 5034000.0d, 0.0000763319d },
            { 5056000.0d, 0.0000739606d },
            { 5078000.0d, 0.0000716214d },
            { 5100000.0d, 0.0000693155d },
            { 5122000.0d, 0.0000670443d },
            { 5144000.0d, 0.0000648092d },
            { 5166000.0d, 0.0000626119d },
            { 5188000.0d, 0.0000604536d },
            { 5210000.0d, 0.0000583359d },
            { 5232000.0d, 0.0000562602d },
            { 5254000.0d, 0.000054228d },
            { 5276000.0d, 0.0000522408d },
            { 5298000.0d, 0.0000502988d },
            { 5320000.0d, 0.0000484019d },
            { 5342000.0d, 0.0000465514d },
            { 5364000.0d, 0.0000447486d },
            { 5386000.0d, 0.0000429953d },
            { 5408000.0d, 0.0000412928d },
            { 5430000.0d, 0.0000396425d },
            { 5452000.0d, 0.000038045d },
            { 5474000.0d, 0.0000364939d },
            { 5496000.0d, 0.0000349882d },
            { 5518000.0d, 0.0000335291d },
            { 5540000.0d, 0.0000321179d },
            { 5562000.0d, 0.000030756d },
            { 5584000.0d, 0.0000294446d },
            { 5606000.0d, 0.0000281848d },
            { 5628000.0d, 0.0000269752d },
            { 5650000.0d, 0.000025798d },
            { 5672000.0d, 0.0000246508d },
            { 5694000.0d, 0.0000235341d },
            { 5716000.0d, 0.000022449d },
            { 5738000.0d, 0.0000213962d },
            { 5760000.0d, 0.0000203767d },
            { 5782000.0d, 0.0000193914d },
            { 5804000.0d, 0.0000184412d },
            { 5826000.0d, 0.0000175268d },
            { 5848000.0d, 0.0000166492d },
            { 5870000.0d, 0.0000158092d },
            { 5892000.0d, 0.0000150078d },
            { 5914000.0d, 0.0000142457d },
            { 5936000.0d, 0.0000135229d },
            { 5958000.0d, 0.0000128318d },
            { 5980000.0d, 0.0000121709d },
            { 6002000.0d, 0.0000115411d },
            { 6024000.0d, 0.0000109428d },
            { 6046000.0d, 0.0000103767d },
            { 6068000.0d, 0.00000984347d },
            { 6090000.0d, 0.00000934164d },
            { 6112000.0d, 0.00000885737d },
            { 6134000.0d, 0.00000838826d },
            { 6156000.0d, 0.00000793466d },
            { 6178000.0d, 0.00000749691d },
            { 6200000.0d, 0.00000707508d },
            { 6222000.0d, 0.0000066646d },
            { 6244000.0d, 0.00000626385d },
            { 6266000.0d, 0.00000587308d },
            { 6288000.0d, 0.00000549254d },
            { 6310000.0d, 0.00000512249d },
            { 6332000.0d, 0.00000476319d },
            { 6354000.0d, 0.0000044149d },
            { 6376000.0d, 0.00000407788d },
            { 6398000.0d, 0.00000375239d },
            { 6420000.0d, 0.0000034387d },
            { 6442000.0d, 0.00000313708d },
            { 6464000.0d, 0.00000284778d },
            { 6486000.0d, 0.00000257107d },
            { 6508000.0d, 0.00000230722d },
            { 6530000.0d, 0.00000205651d },
            { 6552000.0d, 0.0000018192d },
            { 6574000.0d, 0.00000159556d },
            { 6596000.0d, 0.00000138585d },
            { 6618000.0d, 0.00000119035d },
            { 6640000.0d, 0.00000100934d },
            { 6662000.0d, 0.000000843076d },
            { 6684000.0d, 0.000000691826d },
            { 6706000.0d, 0.00000055586d },
            { 6728000.0d, 0.000000435438d },
            { 6750000.0d, 0.000000330782d },
            { 6772000.0d, 0.000000240688d },
            { 6794000.0d, 0.000000164555d },
            { 6816000.0d, 0.000000102604d },
            { 6838000.0d, 0.0000000550491d },
            { 6860000.0d, 0.0000000220914d },
            { 6882000.0d, 0.00000000390196d },
            { 6898000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    