using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin105 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin105";
        public override double halfLife { get; } = 32.7d;
        public override double atomicWeight { get; } = 104.92127d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium105()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.006237d, new GammaParticle(287900.0, 0.00431)), new(0.08375400000000001d, new GammaParticle(309100.0, 0.00401)), new(0.004752d, new GammaParticle(341200.0, 0.00363)), new(0.003564d, new GammaParticle(388000.0, 0.0032)), new(0.002673d, new GammaParticle(402100.0, 0.00308)), new(0.023166000000000003d, new GammaParticle(424100.0, 0.00292)), new(0.016335d, new GammaParticle(476600.0, 0.0026)), new(0.062073d, new GammaParticle(535500.0, 0.00232)), new(0.00594d, new GammaParticle(561700.0, 0.00221)), new(0.010692d, new GammaParticle(599600.0, 0.00207)), new(0.020790000000000003d, new GammaParticle(628700.0, 0.00197)), new(0.01485d, new GammaParticle(629300.0, 0.00197)), new(0.201663d, new GammaParticle(674100.0, 0.00184)), new(0.007128d, new GammaParticle(697000.0, 0.00178)), new(0.011583000000000001d, new GammaParticle(722500.0, 0.00172)), new(0.002079d, new GammaParticle(733700.0, 0.00169)), new(0.014553d, new GammaParticle(756200.0, 0.00164)), new(0.009800999999999999d, new GammaParticle(778300.0, 0.00159)), new(0.004455d, new GammaParticle(832300.0, 0.00149)), new(0.010692d, new GammaParticle(880100.0, 0.00141)), new(0.008316d, new GammaParticle(889900.0, 0.00139)), new(0.01485d, new GammaParticle(895700.0, 0.00138)), new(0.014553d, new GammaParticle(903200.0, 0.00137)), new(0.014256d, new GammaParticle(933200.0, 0.00133)), new(0.007425d, new GammaParticle(954400.0, 0.0013)), new(0.081972d, new GammaParticle(991800.0, 0.00125)), new(0.009207d, new GammaParticle(1012400.0, 0.00122)), new(0.0050490000000000005d, new GammaParticle(1026000.0, 0.00121)), new(0.01188d, new GammaParticle(1040000.0, 0.00119)), new(0.0056430000000000004d, new GammaParticle(1046000.0, 0.00119)), new(0.007722d, new GammaParticle(1051500.0, 0.00118)), new(0.004158d, new GammaParticle(1060200.0, 0.00117)), new(0.003267d, new GammaParticle(1074000.0, 0.00115)), new(0.011583000000000001d, new GammaParticle(1161500.0, 0.00107)), new(0.003564d, new GammaParticle(1167800.0, 0.00106)), new(0.006534d, new GammaParticle(1189700.0, 0.00104)), new(0.010098000000000001d, new GammaParticle(1244500.0, 0.001)), new(0.019601999999999998d, new GammaParticle(1258200.0, 0.00099)), new(0.297d, new GammaParticle(1281700.0, 0.00097)), new(0.009207d, new GammaParticle(1361900.0, 0.00091)), new(0.014256d, new GammaParticle(1364700.0, 0.00091)), new(0.008612999999999999d, new GammaParticle(1400500.0, 0.00089)), new(0.064152d, new GammaParticle(1415900.0, 0.00088)), new(0.068607d, new GammaParticle(1416900.0, 0.00088)), new(0.013365d, new GammaParticle(1433900.0, 0.00086)), new(0.007425d, new GammaParticle(1434200.0, 0.00086)), new(0.164241d, new GammaParticle(1465900.0, 0.00085)), new(0.00297d, new GammaParticle(1477000.0, 0.00084)), new(0.008019d, new GammaParticle(1486800.0, 0.00083)), new(0.015741d, new GammaParticle(1500400.0, 0.00083)), new(0.013365d, new GammaParticle(1521700.0, 0.00081)), new(0.004158d, new GammaParticle(1547500.0, 0.0008)), new(0.004158d, new GammaParticle(1547500.0, 0.0008)), new(0.010395000000000001d, new GammaParticle(1590800.0, 0.00078)), new(0.007722d, new GammaParticle(1607600.0, 0.00077)), new(0.008612999999999999d, new GammaParticle(1633900.0, 0.00076)), new(0.004752d, new GammaParticle(1651300.0, 0.00075)), new(0.0050490000000000005d, new GammaParticle(1651300.0, 0.00075)), new(0.006237d, new GammaParticle(1671300.0, 0.00074)), new(0.019899d, new GammaParticle(1692500.0, 0.00073)), new(0.007722d, new GammaParticle(1713000.0, 0.00072)), new(0.0056430000000000004d, new GammaParticle(1725600.0, 0.00072)), new(0.016632d, new GammaParticle(1742800.0, 0.00071)), new(0.0050490000000000005d, new GammaParticle(1770500.0, 0.0007)), new(0.004455d, new GammaParticle(1822900.0, 0.00068)), new(0.044253d, new GammaParticle(1916200.0, 0.00065)), new(0.020196000000000002d, new GammaParticle(1934000.0, 0.00064)), new(0.00594d, new GammaParticle(1934000.0, 0.00064)), new(0.00891d, new GammaParticle(1942200.0, 0.00064)), new(0.041283d, new GammaParticle(1984500.0, 0.00062)), new(0.007128d, new GammaParticle(2005900.0, 0.00062)), new(0.006534d, new GammaParticle(2019700.0, 0.00061)), new(0.017523d, new GammaParticle(2108100.0, 0.00059)), new(0.009504d, new GammaParticle(2120400.0, 0.00058)), new(0.019008d, new GammaParticle(2132500.0, 0.00058)), new(0.008316d, new GammaParticle(2189800.0, 0.00057)), new(0.008019d, new GammaParticle(2189800.0, 0.00057)), new(0.012177d, new GammaParticle(2219900.0, 0.00056)), new(0.010395000000000001d, new GammaParticle(2261200.0, 0.00055)), new(0.006831d, new GammaParticle(2283600.0, 0.00054)), new(0.006831d, new GammaParticle(2283600.0, 0.00054)), new(0.003861d, new GammaParticle(2290300.0, 0.00054)), new(0.003564d, new GammaParticle(2291600.0, 0.00054)), new(0.007722d, new GammaParticle(2311900.0, 0.00054)), new(0.008019d, new GammaParticle(2344800.0, 0.00053)), new(0.007722d, new GammaParticle(2351300.0, 0.00053)), new(0.015146999999999999d, new GammaParticle(2371000.0, 0.00052)), new(0.009800999999999999d, new GammaParticle(2426000.0, 0.00051)), new(0.020196000000000002d, new GammaParticle(2527000.0, 0.00049)), new(0.011583000000000001d, new GammaParticle(2589000.0, 0.00048)), new(0.004752d, new GammaParticle(2676000.0, 0.00046)), new(0.0056430000000000004d, new GammaParticle(2706000.0, 0.00046)), new(0.013365d, new GammaParticle(2732000.0, 0.00045)), new(0.007128d, new GammaParticle(2953000.0, 0.00042)), new(0.012474d, new GammaParticle(2984000.0, 0.00042)), new(0.004752d, new GammaParticle(3254000.0, 0.00038)), new(0.028512d, new GammaParticle(3278000.0, 0.00038)), new(0.006534d, new GammaParticle(3466220.0, 0.00036)), new(0.009800999999999999d, new GammaParticle(3472000.0, 0.00036)), new(0.007128d, new GammaParticle(3542000.0, 0.00035)), new(0.004158d, new GammaParticle(3636000.0, 0.00034)), new(0.003564d, new GammaParticle(3681000.0, 0.00034)), new(0.008612999999999999d, new GammaParticle(3700000.0, 0.00034)), new(0.001485d, new GammaParticle(3751000.0, 0.00033)), new(0.00297d, new GammaParticle(3787000.0, 0.00033)), new(0.00297d, new GammaParticle(3819000.0, 0.00032)), new(1.45238d, new GammaParticle(511000.0, 0.00243)), new(0.01662560675847677d, new GammaParticle(3571.0, 0.3472)), new(0.055026280350111395d, new GammaParticle(24001.0, 0.05166)), new(0.10323879990640035d, new GammaParticle(24209.0, 0.05121)), new(0.0289664995629145d, new GammaParticle(27367.0, 0.0453)), new(0.034470134479868256d, new GammaParticle(27581.0, 0.04495)), new(0.0055036349169537545d, new GammaParticle(27858.0, 0.04451)) } },
            { 0.00010999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium104()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 3000.0d, 0.00000000144878d },
            { 6000.0d, 0.0000000457824d },
            { 9000.0d, 0.000000182781d },
            { 12000.0d, 0.000000404119d },
            { 15000.0d, 0.000000723979d },
            { 18000.0d, 0.0000011508d },
            { 21000.0d, 0.00000168859d },
            { 24000.0d, 0.00000233783d },
            { 27000.0d, 0.00000309769d },
            { 30000.0d, 0.00000396394d },
            { 33000.0d, 0.00000492926d },
            { 36000.0d, 0.00000599013d },
            { 39000.0d, 0.00000713502d },
            { 42000.0d, 0.00000836238d },
            { 45000.0d, 0.00000966378d },
            { 48000.0d, 0.0000110374d },
            { 51000.0d, 0.0000124723d },
            { 54000.0d, 0.0000139682d },
            { 57000.0d, 0.0000155181d },
            { 60000.0d, 0.0000171195d },
            { 63000.0d, 0.000018766d },
            { 66000.0d, 0.0000204556d },
            { 69000.0d, 0.0000221835d },
            { 72000.0d, 0.0000239498d },
            { 75000.0d, 0.000025746d },
            { 78000.0d, 0.0000275748d },
            { 81000.0d, 0.0000294305d },
            { 84000.0d, 0.0000313123d },
            { 87000.0d, 0.0000332163d },
            { 90000.0d, 0.000035143d },
            { 93000.0d, 0.0000370878d },
            { 96000.0d, 0.0000390518d },
            { 99000.0d, 0.0000410314d },
            { 102000.0d, 0.0000430252d },
            { 112000.0d, 0.0000497629d },
            { 122000.0d, 0.0000566065d },
            { 132000.0d, 0.0000635224d },
            { 142000.0d, 0.0000704827d },
            { 152000.0d, 0.0000774661d },
            { 162000.0d, 0.0000844551d },
            { 172000.0d, 0.000091435d },
            { 182000.0d, 0.0000983942d },
            { 192000.0d, 0.000105323d },
            { 202000.0d, 0.000112212d },
            { 212000.0d, 0.000119056d },
            { 222000.0d, 0.000125849d },
            { 232000.0d, 0.000132584d },
            { 242000.0d, 0.000139259d },
            { 252000.0d, 0.000145869d },
            { 262000.0d, 0.000152412d },
            { 272000.0d, 0.000158883d },
            { 282000.0d, 0.000165281d },
            { 292000.0d, 0.000171604d },
            { 302000.0d, 0.000177849d },
            { 312000.0d, 0.000184015d },
            { 322000.0d, 0.0001901d },
            { 332000.0d, 0.000196102d },
            { 342000.0d, 0.000202021d },
            { 352000.0d, 0.000207854d },
            { 362000.0d, 0.000213602d },
            { 372000.0d, 0.000219262d },
            { 382000.0d, 0.000224834d },
            { 392000.0d, 0.000230317d },
            { 402000.0d, 0.000235711d },
            { 412000.0d, 0.000241013d },
            { 422000.0d, 0.000246225d },
            { 432000.0d, 0.000251345d },
            { 442000.0d, 0.000256372d },
            { 452000.0d, 0.000261306d },
            { 462000.0d, 0.000266147d },
            { 472000.0d, 0.000270894d },
            { 482000.0d, 0.000275546d },
            { 492000.0d, 0.000280104d },
            { 502000.0d, 0.000284567d },
            { 512000.0d, 0.000288934d },
            { 522000.0d, 0.000293206d },
            { 532000.0d, 0.000297382d },
            { 542000.0d, 0.000301462d },
            { 552000.0d, 0.000305446d },
            { 562000.0d, 0.000309333d },
            { 572000.0d, 0.000313125d },
            { 582000.0d, 0.00031682d },
            { 592000.0d, 0.000320418d },
            { 602000.0d, 0.00032392d },
            { 612000.0d, 0.000327326d },
            { 622000.0d, 0.000330635d },
            { 632000.0d, 0.000333848d },
            { 642000.0d, 0.000336965d },
            { 652000.0d, 0.000339986d },
            { 662000.0d, 0.000342912d },
            { 672000.0d, 0.000345742d },
            { 682000.0d, 0.000348476d },
            { 692000.0d, 0.000351116d },
            { 702000.0d, 0.000353661d },
            { 712000.0d, 0.000356112d },
            { 722000.0d, 0.000358469d },
            { 732000.0d, 0.000360732d },
            { 742000.0d, 0.000362902d },
            { 752000.0d, 0.00036498d },
            { 762000.0d, 0.000366966d },
            { 772000.0d, 0.00036886d },
            { 782000.0d, 0.000370663d },
            { 792000.0d, 0.000372376d },
            { 802000.0d, 0.000373998d },
            { 812000.0d, 0.000375532d },
            { 822000.0d, 0.000376978d },
            { 832000.0d, 0.000378335d },
            { 842000.0d, 0.000379605d },
            { 852000.0d, 0.00038079d },
            { 862000.0d, 0.000381888d },
            { 872000.0d, 0.000382902d },
            { 882000.0d, 0.000383833d },
            { 892000.0d, 0.00038468d },
            { 902000.0d, 0.000385446d },
            { 912000.0d, 0.00038613d },
            { 922000.0d, 0.000386735d },
            { 932000.0d, 0.00038726d },
            { 942000.0d, 0.000387707d },
            { 952000.0d, 0.000388078d },
            { 962000.0d, 0.000388373d },
            { 972000.0d, 0.000388592d },
            { 982000.0d, 0.000388739d },
            { 992000.0d, 0.000388813d },
            { 1002000.0d, 0.000388815d },
            { 1016000.0d, 0.000388703d },
            { 1030000.0d, 0.000388456d },
            { 1044000.0d, 0.000388079d },
            { 1058000.0d, 0.000387576d },
            { 1072000.0d, 0.00038695d },
            { 1086000.0d, 0.000386206d },
            { 1100000.0d, 0.000385343d },
            { 1114000.0d, 0.000384362d },
            { 1128000.0d, 0.000383268d },
            { 1142000.0d, 0.000382063d },
            { 1156000.0d, 0.000380754d },
            { 1170000.0d, 0.000379342d },
            { 1184000.0d, 0.000377834d },
            { 1198000.0d, 0.000376233d },
            { 1212000.0d, 0.000374544d },
            { 1226000.0d, 0.000372772d },
            { 1240000.0d, 0.00037092d },
            { 1254000.0d, 0.000368995d },
            { 1268000.0d, 0.000367d },
            { 1282000.0d, 0.000364942d },
            { 1296000.0d, 0.000362824d },
            { 1310000.0d, 0.000360653d },
            { 1324000.0d, 0.000358433d },
            { 1338000.0d, 0.000356163d },
            { 1352000.0d, 0.000353826d },
            { 1366000.0d, 0.000351423d },
            { 1380000.0d, 0.000348958d },
            { 1394000.0d, 0.000346437d },
            { 1408000.0d, 0.000343862d },
            { 1422000.0d, 0.000341239d },
            { 1436000.0d, 0.000338573d },
            { 1450000.0d, 0.000335867d },
            { 1464000.0d, 0.000333128d },
            { 1478000.0d, 0.000330358d },
            { 1492000.0d, 0.000327564d },
            { 1506000.0d, 0.000324751d },
            { 1520000.0d, 0.000321923d },
            { 1534000.0d, 0.000319085d },
            { 1548000.0d, 0.000316244d },
            { 1562000.0d, 0.000313403d },
            { 1576000.0d, 0.000310569d },
            { 1590000.0d, 0.000307744d },
            { 1604000.0d, 0.000304925d },
            { 1618000.0d, 0.000302117d },
            { 1632000.0d, 0.000299324d },
            { 1646000.0d, 0.000296542d },
            { 1660000.0d, 0.000293764d },
            { 1674000.0d, 0.000290982d },
            { 1688000.0d, 0.000288196d },
            { 1702000.0d, 0.000285406d },
            { 1716000.0d, 0.000282613d },
            { 1730000.0d, 0.00027982d },
            { 1744000.0d, 0.000277031d },
            { 1758000.0d, 0.00027425d },
            { 1772000.0d, 0.000271479d },
            { 1786000.0d, 0.000268721d },
            { 1800000.0d, 0.000265979d },
            { 1814000.0d, 0.000263256d },
            { 1828000.0d, 0.000260531d },
            { 1842000.0d, 0.000257795d },
            { 1856000.0d, 0.00025505d },
            { 1870000.0d, 0.000252298d },
            { 1884000.0d, 0.000249534d },
            { 1898000.0d, 0.000246755d },
            { 1912000.0d, 0.000243963d },
            { 1926000.0d, 0.000241161d },
            { 1940000.0d, 0.000238352d },
            { 1954000.0d, 0.000235539d },
            { 1968000.0d, 0.000232724d },
            { 1982000.0d, 0.000229909d },
            { 1996000.0d, 0.000227098d },
            { 2010000.0d, 0.000224293d },
            { 2024000.0d, 0.000221497d },
            { 2038000.0d, 0.00021871d },
            { 2052000.0d, 0.000215932d },
            { 2066000.0d, 0.000213166d },
            { 2080000.0d, 0.000210413d },
            { 2094000.0d, 0.000207677d },
            { 2108000.0d, 0.000204961d },
            { 2122000.0d, 0.000202266d },
            { 2136000.0d, 0.000199592d },
            { 2150000.0d, 0.000196931d },
            { 2164000.0d, 0.000194281d },
            { 2178000.0d, 0.000191641d },
            { 2192000.0d, 0.000189006d },
            { 2206000.0d, 0.000186376d },
            { 2220000.0d, 0.000183754d },
            { 2234000.0d, 0.000181143d },
            { 2248000.0d, 0.000178543d },
            { 2262000.0d, 0.000175957d },
            { 2276000.0d, 0.000173376d },
            { 2290000.0d, 0.000170799d },
            { 2304000.0d, 0.000168229d },
            { 2318000.0d, 0.000165668d },
            { 2332000.0d, 0.000163115d },
            { 2346000.0d, 0.000160568d },
            { 2360000.0d, 0.00015803d },
            { 2374000.0d, 0.000155503d },
            { 2388000.0d, 0.000152987d },
            { 2402000.0d, 0.000150485d },
            { 2416000.0d, 0.000147998d },
            { 2430000.0d, 0.000145529d },
            { 2444000.0d, 0.000143079d },
            { 2458000.0d, 0.00014065d },
            { 2472000.0d, 0.000138244d },
            { 2486000.0d, 0.000135863d },
            { 2500000.0d, 0.000133508d },
            { 2514000.0d, 0.000131172d },
            { 2528000.0d, 0.000128849d },
            { 2542000.0d, 0.000126536d },
            { 2556000.0d, 0.000124234d },
            { 2570000.0d, 0.000121942d },
            { 2584000.0d, 0.000119662d },
            { 2598000.0d, 0.000117397d },
            { 2612000.0d, 0.000115147d },
            { 2626000.0d, 0.000112913d },
            { 2640000.0d, 0.000110696d },
            { 2654000.0d, 0.000108498d },
            { 2668000.0d, 0.000106318d },
            { 2682000.0d, 0.000104157d },
            { 2696000.0d, 0.000102015d },
            { 2710000.0d, 0.000099889d },
            { 2724000.0d, 0.0000977788d },
            { 2738000.0d, 0.0000956858d },
            { 2752000.0d, 0.0000936109d },
            { 2766000.0d, 0.0000915557d },
            { 2780000.0d, 0.0000895195d },
            { 2794000.0d, 0.0000875032d },
            { 2808000.0d, 0.0000855079d },
            { 2822000.0d, 0.0000835332d },
            { 2836000.0d, 0.000081577d },
            { 2850000.0d, 0.0000796408d },
            { 2864000.0d, 0.0000777253d },
            { 2878000.0d, 0.0000758308d },
            { 2892000.0d, 0.0000739572d },
            { 2906000.0d, 0.0000721031d },
            { 2920000.0d, 0.0000702693d },
            { 2934000.0d, 0.0000684551d },
            { 2948000.0d, 0.0000666617d },
            { 2962000.0d, 0.00006489d },
            { 2976000.0d, 0.0000631406d },
            { 2990000.0d, 0.0000614121d },
            { 3004000.0d, 0.0000597048d },
            { 3018000.0d, 0.0000580198d },
            { 3032000.0d, 0.0000563572d },
            { 3046000.0d, 0.000054718d },
            { 3060000.0d, 0.0000531029d },
            { 3074000.0d, 0.0000515103d },
            { 3088000.0d, 0.0000499385d },
            { 3102000.0d, 0.0000483884d },
            { 3116000.0d, 0.000046861d },
            { 3130000.0d, 0.0000453573d },
            { 3144000.0d, 0.0000438782d },
            { 3158000.0d, 0.0000424248d },
            { 3172000.0d, 0.0000409977d },
            { 3186000.0d, 0.0000395983d },
            { 3200000.0d, 0.0000382273d },
            { 3214000.0d, 0.0000368858d },
            { 3228000.0d, 0.0000355748d },
            { 3242000.0d, 0.0000342951d },
            { 3256000.0d, 0.0000330479d },
            { 3270000.0d, 0.0000318341d },
            { 3284000.0d, 0.0000306548d },
            { 3298000.0d, 0.0000295106d },
            { 3312000.0d, 0.0000283968d },
            { 3326000.0d, 0.0000273088d },
            { 3340000.0d, 0.0000262475d },
            { 3354000.0d, 0.0000252115d },
            { 3368000.0d, 0.0000241943d },
            { 3382000.0d, 0.000023195d },
            { 3396000.0d, 0.0000222141d },
            { 3410000.0d, 0.0000212513d },
            { 3424000.0d, 0.0000203048d },
            { 3438000.0d, 0.0000193751d },
            { 3452000.0d, 0.0000184628d },
            { 3466000.0d, 0.0000175684d },
            { 3480000.0d, 0.0000166925d },
            { 3494000.0d, 0.0000158356d },
            { 3508000.0d, 0.0000149984d },
            { 3522000.0d, 0.0000141815d },
            { 3536000.0d, 0.0000133853d },
            { 3550000.0d, 0.0000126106d },
            { 3564000.0d, 0.0000118578d },
            { 3578000.0d, 0.0000111277d },
            { 3592000.0d, 0.0000104208d },
            { 3606000.0d, 0.00000973776d },
            { 3620000.0d, 0.00000907914d },
            { 3634000.0d, 0.00000844559d },
            { 3648000.0d, 0.00000783772d },
            { 3662000.0d, 0.00000725618d },
            { 3676000.0d, 0.00000670159d },
            { 3690000.0d, 0.00000617455d },
            { 3704000.0d, 0.00000567449d },
            { 3718000.0d, 0.00000520087d },
            { 3732000.0d, 0.00000475425d },
            { 3746000.0d, 0.00000433528d },
            { 3760000.0d, 0.00000394455d },
            { 3774000.0d, 0.00000358266d },
            { 3788000.0d, 0.00000325022d },
            { 3802000.0d, 0.00000294782d },
            { 3816000.0d, 0.00000267599d },
            { 3830000.0d, 0.00000242963d },
            { 3844000.0d, 0.00000220494d },
            { 3858000.0d, 0.00000200235d },
            { 3872000.0d, 0.00000182057d },
            { 3886000.0d, 0.00000165148d },
            { 3900000.0d, 0.00000149412d },
            { 3914000.0d, 0.0000013488d },
            { 3928000.0d, 0.00000121581d },
            { 3942000.0d, 0.00000109542d },
            { 3956000.0d, 0.000000987938d },
            { 3970000.0d, 0.000000893649d },
            { 3984000.0d, 0.000000812832d },
            { 3998000.0d, 0.000000745732d },
            { 4012000.0d, 0.000000687052d },
            { 4026000.0d, 0.000000629785d },
            { 4040000.0d, 0.000000574024d },
            { 4054000.0d, 0.000000519892d },
            { 4068000.0d, 0.000000467523d },
            { 4082000.0d, 0.000000417054d },
            { 4096000.0d, 0.000000368629d },
            { 4110000.0d, 0.000000322397d },
            { 4124000.0d, 0.000000278512d },
            { 4138000.0d, 0.000000237138d },
            { 4152000.0d, 0.000000198441d },
            { 4166000.0d, 0.000000162595d },
            { 4180000.0d, 0.000000129781d },
            { 4194000.0d, 0.000000100186d },
            { 4208000.0d, 0.0000000740041d },
            { 4222000.0d, 0.0000000514342d },
            { 4236000.0d, 0.0000000326829d },
            { 4250000.0d, 0.0000000179618d },
            { 4264000.0d, 0.00000000748678d },
            { 4278000.0d, 0.00000000147368d },
            { 4289000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    