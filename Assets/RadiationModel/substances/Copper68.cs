using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper68 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper68";
        public override double halfLife { get; } = 30.9d;
        public override double atomicWeight { get; } = 67.92961d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc68()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.020952000000000002d, new GammaParticle(577800.0, 0.00215)), new(0.010476000000000001d, new GammaParticle(736900.0, 0.00168)), new(0.006984000000000001d, new GammaParticle(806900.0, 0.00154)), new(0.6111d, new GammaParticle(1077700.0, 0.00115)), new(0.144918d, new GammaParticle(1261800.0, 0.00098)), new(0.0034920000000000003d, new GammaParticle(1292900.0, 0.00096)), new(0.0026190000000000002d, new GammaParticle(1432800.0, 0.00087)), new(0.00873d, new GammaParticle(1529700.0, 0.00081)), new(0.015714d, new GammaParticle(1675700.0, 0.00074)), new(0.01746d, new GammaParticle(1743700.0, 0.00071)), new(0.020079d, new GammaParticle(1883800.0, 0.00066)), new(0.015714d, new GammaParticle(2110100.0, 0.00059)), new(0.014841d, new GammaParticle(2339500.0, 0.00053)), new(2.87576327798712e-06d, new GammaParticle(1035.0, 1.19791)), new(2.6983249296059133e-05d, new GammaParticle(8616.0, 0.1439)), new(5.2476175215984303e-05d, new GammaParticle(8639.0, 0.14352)), new(1.1259400453356556e-05d, new GammaParticle(9610.0, 0.12902)), new(1.1259400453356556e-05d, new GammaParticle(9610.0, 0.12902)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000139298d },
            { 3000.0d, 0.000140261d },
            { 6000.0d, 0.000141264d },
            { 9000.0d, 0.000142309d },
            { 12000.0d, 0.000143399d },
            { 15000.0d, 0.000144546d },
            { 18000.0d, 0.000145754d },
            { 21000.0d, 0.000147023d },
            { 24000.0d, 0.000148351d },
            { 27000.0d, 0.000149732d },
            { 30000.0d, 0.000151161d },
            { 33000.0d, 0.000152631d },
            { 36000.0d, 0.000154128d },
            { 39000.0d, 0.000155652d },
            { 42000.0d, 0.000157204d },
            { 45000.0d, 0.000158768d },
            { 48000.0d, 0.000160345d },
            { 51000.0d, 0.000161935d },
            { 54000.0d, 0.000163539d },
            { 57000.0d, 0.00016515d },
            { 60000.0d, 0.000166765d },
            { 63000.0d, 0.000168387d },
            { 66000.0d, 0.000170013d },
            { 69000.0d, 0.000171643d },
            { 72000.0d, 0.000173275d },
            { 75000.0d, 0.000174908d },
            { 78000.0d, 0.000176544d },
            { 81000.0d, 0.000178179d },
            { 84000.0d, 0.000179814d },
            { 87000.0d, 0.000181449d },
            { 90000.0d, 0.000183084d },
            { 93000.0d, 0.000184717d },
            { 96000.0d, 0.000186349d },
            { 99000.0d, 0.00018798d },
            { 102000.0d, 0.000189608d },
            { 112000.0d, 0.000195019d },
            { 122000.0d, 0.000200401d },
            { 132000.0d, 0.000205747d },
            { 142000.0d, 0.000211055d },
            { 152000.0d, 0.000216321d },
            { 162000.0d, 0.000221543d },
            { 172000.0d, 0.000226719d },
            { 182000.0d, 0.000231846d },
            { 192000.0d, 0.000236924d },
            { 202000.0d, 0.000241949d },
            { 212000.0d, 0.000246923d },
            { 222000.0d, 0.000251842d },
            { 232000.0d, 0.000256705d },
            { 242000.0d, 0.000261513d },
            { 252000.0d, 0.000266262d },
            { 262000.0d, 0.000270953d },
            { 272000.0d, 0.000275583d },
            { 282000.0d, 0.000280154d },
            { 292000.0d, 0.000284662d },
            { 302000.0d, 0.000289108d },
            { 312000.0d, 0.00029349d },
            { 322000.0d, 0.000297808d },
            { 332000.0d, 0.000302061d },
            { 342000.0d, 0.000306248d },
            { 352000.0d, 0.000310368d },
            { 362000.0d, 0.000314421d },
            { 372000.0d, 0.000318407d },
            { 382000.0d, 0.000322323d },
            { 392000.0d, 0.000326171d },
            { 402000.0d, 0.00032995d },
            { 412000.0d, 0.000333658d },
            { 422000.0d, 0.000337296d },
            { 432000.0d, 0.000340863d },
            { 442000.0d, 0.000344359d },
            { 452000.0d, 0.000347784d },
            { 462000.0d, 0.000351137d },
            { 472000.0d, 0.000354417d },
            { 482000.0d, 0.000357626d },
            { 492000.0d, 0.000360763d },
            { 502000.0d, 0.000363828d },
            { 512000.0d, 0.00036682d },
            { 522000.0d, 0.000369739d },
            { 532000.0d, 0.000372587d },
            { 542000.0d, 0.000375361d },
            { 552000.0d, 0.000378064d },
            { 562000.0d, 0.000380695d },
            { 572000.0d, 0.000383255d },
            { 582000.0d, 0.000385741d },
            { 592000.0d, 0.000388158d },
            { 602000.0d, 0.000390504d },
            { 612000.0d, 0.00039278d },
            { 622000.0d, 0.000394984d },
            { 632000.0d, 0.00039712d },
            { 642000.0d, 0.000399186d },
            { 652000.0d, 0.000401185d },
            { 662000.0d, 0.000403115d },
            { 672000.0d, 0.000404978d },
            { 682000.0d, 0.000406774d },
            { 692000.0d, 0.000408505d },
            { 702000.0d, 0.00041017d },
            { 712000.0d, 0.000411772d },
            { 722000.0d, 0.000413311d },
            { 732000.0d, 0.000414785d },
            { 742000.0d, 0.0004162d },
            { 752000.0d, 0.000417554d },
            { 762000.0d, 0.000418848d },
            { 772000.0d, 0.000420084d },
            { 782000.0d, 0.000421263d },
            { 792000.0d, 0.000422386d },
            { 802000.0d, 0.000423453d },
            { 812000.0d, 0.000424466d },
            { 822000.0d, 0.000425428d },
            { 832000.0d, 0.000426339d },
            { 842000.0d, 0.000427201d },
            { 852000.0d, 0.000428014d },
            { 862000.0d, 0.00042878d },
            { 872000.0d, 0.000429501d },
            { 882000.0d, 0.000430179d },
            { 892000.0d, 0.000430814d },
            { 902000.0d, 0.00043141d },
            { 912000.0d, 0.000431966d },
            { 922000.0d, 0.000432485d },
            { 932000.0d, 0.00043297d },
            { 942000.0d, 0.000433421d },
            { 952000.0d, 0.000433838d },
            { 962000.0d, 0.000434208d },
            { 972000.0d, 0.000434521d },
            { 982000.0d, 0.00043478d },
            { 992000.0d, 0.000434986d },
            { 1002000.0d, 0.000435138d },
            { 1016000.0d, 0.000435265d },
            { 1030000.0d, 0.000435294d },
            { 1044000.0d, 0.000435228d },
            { 1058000.0d, 0.000435069d },
            { 1072000.0d, 0.00043482d },
            { 1086000.0d, 0.000434485d },
            { 1100000.0d, 0.000434067d },
            { 1114000.0d, 0.000433571d },
            { 1128000.0d, 0.000432998d },
            { 1142000.0d, 0.000432355d },
            { 1156000.0d, 0.000431642d },
            { 1170000.0d, 0.000430865d },
            { 1184000.0d, 0.000430029d },
            { 1198000.0d, 0.000429138d },
            { 1212000.0d, 0.000428194d },
            { 1226000.0d, 0.000427204d },
            { 1240000.0d, 0.00042617d },
            { 1254000.0d, 0.000425097d },
            { 1268000.0d, 0.000423957d },
            { 1282000.0d, 0.000422723d },
            { 1296000.0d, 0.000421397d },
            { 1310000.0d, 0.000419983d },
            { 1324000.0d, 0.000418483d },
            { 1338000.0d, 0.000416896d },
            { 1352000.0d, 0.000415229d },
            { 1366000.0d, 0.000413483d },
            { 1380000.0d, 0.00041166d },
            { 1394000.0d, 0.000409762d },
            { 1408000.0d, 0.000407794d },
            { 1422000.0d, 0.000405756d },
            { 1436000.0d, 0.000403654d },
            { 1450000.0d, 0.00040149d },
            { 1464000.0d, 0.000399266d },
            { 1478000.0d, 0.000396984d },
            { 1492000.0d, 0.000394651d },
            { 1506000.0d, 0.000392269d },
            { 1520000.0d, 0.000389841d },
            { 1534000.0d, 0.000387371d },
            { 1548000.0d, 0.000384862d },
            { 1562000.0d, 0.000382318d },
            { 1576000.0d, 0.000379744d },
            { 1590000.0d, 0.00037714d },
            { 1604000.0d, 0.000374515d },
            { 1618000.0d, 0.000371871d },
            { 1632000.0d, 0.000369202d },
            { 1646000.0d, 0.000366498d },
            { 1660000.0d, 0.000363763d },
            { 1674000.0d, 0.000361002d },
            { 1688000.0d, 0.000358217d },
            { 1702000.0d, 0.000355406d },
            { 1716000.0d, 0.000352568d },
            { 1730000.0d, 0.000349705d },
            { 1744000.0d, 0.000346821d },
            { 1758000.0d, 0.000343919d },
            { 1772000.0d, 0.000341002d },
            { 1786000.0d, 0.000338072d },
            { 1800000.0d, 0.000335135d },
            { 1814000.0d, 0.000332194d },
            { 1828000.0d, 0.00032925d },
            { 1842000.0d, 0.000326309d },
            { 1856000.0d, 0.000323373d },
            { 1870000.0d, 0.000320448d },
            { 1884000.0d, 0.000317534d },
            { 1898000.0d, 0.000314638d },
            { 1912000.0d, 0.000311762d },
            { 1926000.0d, 0.00030891d },
            { 1940000.0d, 0.000306086d },
            { 1954000.0d, 0.000303291d },
            { 1968000.0d, 0.000300529d },
            { 1982000.0d, 0.000297803d },
            { 1996000.0d, 0.00029512d },
            { 2010000.0d, 0.00029248d },
            { 2024000.0d, 0.000289891d },
            { 2038000.0d, 0.000287354d },
            { 2052000.0d, 0.000284875d },
            { 2066000.0d, 0.000282456d },
            { 2080000.0d, 0.000280102d },
            { 2094000.0d, 0.000277815d },
            { 2108000.0d, 0.000275581d },
            { 2122000.0d, 0.000273322d },
            { 2136000.0d, 0.000271029d },
            { 2150000.0d, 0.000268701d },
            { 2164000.0d, 0.000266339d },
            { 2178000.0d, 0.000263946d },
            { 2192000.0d, 0.000261523d },
            { 2206000.0d, 0.000259068d },
            { 2220000.0d, 0.000256586d },
            { 2234000.0d, 0.000254075d },
            { 2248000.0d, 0.000251538d },
            { 2262000.0d, 0.000248975d },
            { 2276000.0d, 0.000246387d },
            { 2290000.0d, 0.000243778d },
            { 2304000.0d, 0.000241145d },
            { 2318000.0d, 0.000238492d },
            { 2332000.0d, 0.000235819d },
            { 2346000.0d, 0.000233127d },
            { 2360000.0d, 0.000230418d },
            { 2374000.0d, 0.000227693d },
            { 2388000.0d, 0.000224954d },
            { 2402000.0d, 0.000222201d },
            { 2416000.0d, 0.000219436d },
            { 2430000.0d, 0.000216659d },
            { 2444000.0d, 0.000213874d },
            { 2458000.0d, 0.000211081d },
            { 2472000.0d, 0.000208281d },
            { 2486000.0d, 0.000205475d },
            { 2500000.0d, 0.000202666d },
            { 2514000.0d, 0.000199854d },
            { 2528000.0d, 0.00019704d },
            { 2542000.0d, 0.000194228d },
            { 2556000.0d, 0.000191417d },
            { 2570000.0d, 0.000188603d },
            { 2584000.0d, 0.000185782d },
            { 2598000.0d, 0.000182956d },
            { 2612000.0d, 0.000180126d },
            { 2626000.0d, 0.000177293d },
            { 2640000.0d, 0.000174459d },
            { 2654000.0d, 0.000171624d },
            { 2668000.0d, 0.000168791d },
            { 2682000.0d, 0.000165959d },
            { 2696000.0d, 0.000163131d },
            { 2710000.0d, 0.000160309d },
            { 2724000.0d, 0.000157493d },
            { 2738000.0d, 0.000154684d },
            { 2752000.0d, 0.000151884d },
            { 2766000.0d, 0.000149095d },
            { 2780000.0d, 0.000146317d },
            { 2794000.0d, 0.000143552d },
            { 2808000.0d, 0.000140797d },
            { 2822000.0d, 0.000138055d },
            { 2836000.0d, 0.000135326d },
            { 2850000.0d, 0.000132612d },
            { 2864000.0d, 0.000129915d },
            { 2878000.0d, 0.000127234d },
            { 2892000.0d, 0.000124573d },
            { 2906000.0d, 0.000121932d },
            { 2920000.0d, 0.000119314d },
            { 2934000.0d, 0.000116718d },
            { 2948000.0d, 0.000114147d },
            { 2962000.0d, 0.000111603d },
            { 2976000.0d, 0.000109087d },
            { 2990000.0d, 0.000106599d },
            { 3004000.0d, 0.000104143d },
            { 3018000.0d, 0.000101719d },
            { 3032000.0d, 0.0000993284d },
            { 3046000.0d, 0.0000969734d },
            { 3060000.0d, 0.0000946554d },
            { 3074000.0d, 0.0000923761d },
            { 3088000.0d, 0.0000901368d },
            { 3102000.0d, 0.0000879393d },
            { 3116000.0d, 0.0000857849d },
            { 3130000.0d, 0.0000836757d },
            { 3144000.0d, 0.0000816129d },
            { 3158000.0d, 0.0000795982d },
            { 3172000.0d, 0.0000776335d },
            { 3186000.0d, 0.0000757202d },
            { 3200000.0d, 0.00007386d },
            { 3214000.0d, 0.0000720547d },
            { 3228000.0d, 0.0000703058d },
            { 3242000.0d, 0.0000686151d },
            { 3256000.0d, 0.0000669841d },
            { 3270000.0d, 0.0000654148d },
            { 3284000.0d, 0.0000639087d },
            { 3298000.0d, 0.0000624674d },
            { 3312000.0d, 0.0000610927d },
            { 3326000.0d, 0.0000597863d },
            { 3340000.0d, 0.0000585496d },
            { 3354000.0d, 0.0000573842d },
            { 3368000.0d, 0.0000562848d },
            { 3382000.0d, 0.0000551977d },
            { 3396000.0d, 0.0000541111d },
            { 3410000.0d, 0.0000530254d },
            { 3424000.0d, 0.0000519409d },
            { 3438000.0d, 0.0000508578d },
            { 3452000.0d, 0.0000497766d },
            { 3466000.0d, 0.0000486975d },
            { 3480000.0d, 0.0000476208d },
            { 3494000.0d, 0.0000465469d },
            { 3508000.0d, 0.0000454761d },
            { 3522000.0d, 0.0000444086d },
            { 3536000.0d, 0.000043345d },
            { 3550000.0d, 0.0000422854d },
            { 3564000.0d, 0.0000412302d },
            { 3578000.0d, 0.0000401798d },
            { 3592000.0d, 0.0000391344d },
            { 3606000.0d, 0.0000380945d },
            { 3620000.0d, 0.0000370603d },
            { 3634000.0d, 0.0000360323d },
            { 3648000.0d, 0.0000350108d },
            { 3662000.0d, 0.000033996d },
            { 3676000.0d, 0.0000329885d },
            { 3690000.0d, 0.0000319885d },
            { 3704000.0d, 0.0000309964d },
            { 3718000.0d, 0.0000300126d },
            { 3732000.0d, 0.0000290374d },
            { 3746000.0d, 0.0000280712d },
            { 3760000.0d, 0.0000271143d },
            { 3774000.0d, 0.0000261672d },
            { 3788000.0d, 0.0000252303d },
            { 3802000.0d, 0.0000243038d },
            { 3816000.0d, 0.0000233882d },
            { 3830000.0d, 0.0000224838d },
            { 3844000.0d, 0.000021591d },
            { 3858000.0d, 0.0000207103d },
            { 3872000.0d, 0.000019842d },
            { 3886000.0d, 0.0000189866d },
            { 3900000.0d, 0.0000181442d },
            { 3914000.0d, 0.0000173154d },
            { 3928000.0d, 0.0000165007d },
            { 3942000.0d, 0.0000157004d },
            { 3956000.0d, 0.0000149149d },
            { 3970000.0d, 0.0000141445d },
            { 3984000.0d, 0.0000133897d },
            { 3998000.0d, 0.000012651d },
            { 4012000.0d, 0.0000119286d },
            { 4026000.0d, 0.0000112231d },
            { 4040000.0d, 0.0000105349d },
            { 4054000.0d, 0.00000986423d },
            { 4068000.0d, 0.00000921176d },
            { 4082000.0d, 0.00000857777d },
            { 4096000.0d, 0.00000796271d },
            { 4110000.0d, 0.00000736699d },
            { 4124000.0d, 0.00000679106d },
            { 4138000.0d, 0.00000623534d },
            { 4152000.0d, 0.00000570026d },
            { 4166000.0d, 0.00000518625d },
            { 4180000.0d, 0.00000469374d },
            { 4194000.0d, 0.00000422317d },
            { 4208000.0d, 0.00000377499d },
            { 4222000.0d, 0.00000334961d },
            { 4236000.0d, 0.00000294749d },
            { 4250000.0d, 0.00000256906d },
            { 4264000.0d, 0.00000221475d },
            { 4278000.0d, 0.00000188503d },
            { 4292000.0d, 0.00000158031d },
            { 4306000.0d, 0.00000130105d },
            { 4320000.0d, 0.00000104768d },
            { 4334000.0d, 0.000000820648d },
            { 4348000.0d, 0.000000620382d },
            { 4362000.0d, 0.000000447318d },
            { 4376000.0d, 0.000000301882d },
            { 4390000.0d, 0.000000184496d },
            { 4404000.0d, 0.0000000955643d },
            { 4418000.0d, 0.0000000354669d },
            { 4432000.0d, 0.00000000452527d },
            { 4439800.0d, 0d },

        }; 
    }
}
    