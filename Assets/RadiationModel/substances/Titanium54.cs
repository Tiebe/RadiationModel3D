using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Titanium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium54";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 53.95089d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Vanadium54()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000659567d },
            { 11000.0d, 0.0000687583d },
            { 22000.0d, 0.000072125d },
            { 33000.0d, 0.0000760567d },
            { 44000.0d, 0.0000801945d },
            { 55000.0d, 0.0000844144d },
            { 66000.0d, 0.0000886687d },
            { 77000.0d, 0.0000929374d },
            { 88000.0d, 0.000097212d },
            { 99000.0d, 0.000101489d },
            { 110000.0d, 0.000105766d },
            { 121000.0d, 0.000110043d },
            { 132000.0d, 0.00011432d },
            { 143000.0d, 0.000118597d },
            { 154000.0d, 0.000122874d },
            { 165000.0d, 0.000127151d },
            { 176000.0d, 0.000131428d },
            { 187000.0d, 0.000135704d },
            { 198000.0d, 0.000139981d },
            { 209000.0d, 0.000144256d },
            { 220000.0d, 0.00014853d },
            { 231000.0d, 0.000152803d },
            { 242000.0d, 0.000157073d },
            { 253000.0d, 0.00016134d },
            { 264000.0d, 0.000165604d },
            { 275000.0d, 0.000169864d },
            { 286000.0d, 0.000174118d },
            { 297000.0d, 0.000178367d },
            { 308000.0d, 0.000182609d },
            { 319000.0d, 0.000186844d },
            { 330000.0d, 0.000191071d },
            { 341000.0d, 0.000195289d },
            { 352000.0d, 0.000199497d },
            { 363000.0d, 0.000203694d },
            { 374000.0d, 0.00020788d },
            { 385000.0d, 0.000212053d },
            { 396000.0d, 0.000216213d },
            { 407000.0d, 0.000220359d },
            { 418000.0d, 0.00022449d },
            { 429000.0d, 0.000228604d },
            { 440000.0d, 0.000232702d },
            { 451000.0d, 0.000236782d },
            { 462000.0d, 0.000240844d },
            { 473000.0d, 0.000244886d },
            { 484000.0d, 0.000248908d },
            { 495000.0d, 0.000252909d },
            { 506000.0d, 0.000256888d },
            { 517000.0d, 0.000260844d },
            { 528000.0d, 0.000264776d },
            { 539000.0d, 0.000268684d },
            { 550000.0d, 0.000272566d },
            { 561000.0d, 0.000276422d },
            { 572000.0d, 0.000280252d },
            { 583000.0d, 0.000284053d },
            { 594000.0d, 0.000287826d },
            { 605000.0d, 0.00029157d },
            { 616000.0d, 0.000295283d },
            { 627000.0d, 0.000298966d },
            { 638000.0d, 0.000302617d },
            { 649000.0d, 0.000306235d },
            { 660000.0d, 0.000309821d },
            { 671000.0d, 0.000313372d },
            { 682000.0d, 0.00031689d },
            { 693000.0d, 0.000320371d },
            { 704000.0d, 0.000323817d },
            { 715000.0d, 0.000327227d },
            { 726000.0d, 0.000330599d },
            { 737000.0d, 0.000333933d },
            { 748000.0d, 0.000337228d },
            { 759000.0d, 0.000340484d },
            { 770000.0d, 0.0003437d },
            { 781000.0d, 0.000346876d },
            { 792000.0d, 0.000350011d },
            { 803000.0d, 0.000353103d },
            { 814000.0d, 0.000356154d },
            { 825000.0d, 0.000359161d },
            { 836000.0d, 0.000362125d },
            { 847000.0d, 0.000365045d },
            { 858000.0d, 0.000367921d },
            { 869000.0d, 0.000370751d },
            { 880000.0d, 0.000373536d },
            { 891000.0d, 0.000376274d },
            { 902000.0d, 0.000378966d },
            { 913000.0d, 0.000381611d },
            { 924000.0d, 0.000384208d },
            { 935000.0d, 0.000386757d },
            { 946000.0d, 0.000389257d },
            { 957000.0d, 0.000391708d },
            { 968000.0d, 0.00039411d },
            { 979000.0d, 0.000396462d },
            { 990000.0d, 0.000398764d },
            { 1001000.0d, 0.000401015d },
            { 1012000.0d, 0.000403215d },
            { 1023000.0d, 0.000405363d },
            { 1034000.0d, 0.000407459d },
            { 1045000.0d, 0.000409503d },
            { 1056000.0d, 0.000411495d },
            { 1067000.0d, 0.000413434d },
            { 1078000.0d, 0.000415319d },
            { 1089000.0d, 0.000417151d },
            { 1100000.0d, 0.000418929d },
            { 1111000.0d, 0.000420653d },
            { 1122000.0d, 0.000422322d },
            { 1133000.0d, 0.000423937d },
            { 1144000.0d, 0.000425496d },
            { 1155000.0d, 0.000427001d },
            { 1166000.0d, 0.00042845d },
            { 1177000.0d, 0.000429843d },
            { 1188000.0d, 0.00043118d },
            { 1199000.0d, 0.000432461d },
            { 1210000.0d, 0.000433686d },
            { 1221000.0d, 0.000434854d },
            { 1232000.0d, 0.000435965d },
            { 1243000.0d, 0.00043702d },
            { 1254000.0d, 0.000438017d },
            { 1265000.0d, 0.000438958d },
            { 1276000.0d, 0.000439841d },
            { 1287000.0d, 0.000440666d },
            { 1298000.0d, 0.000441434d },
            { 1309000.0d, 0.000442144d },
            { 1320000.0d, 0.000442797d },
            { 1331000.0d, 0.000443392d },
            { 1342000.0d, 0.000443929d },
            { 1353000.0d, 0.000444408d },
            { 1364000.0d, 0.000444829d },
            { 1375000.0d, 0.000445192d },
            { 1386000.0d, 0.000445496d },
            { 1397000.0d, 0.000445743d },
            { 1408000.0d, 0.000445932d },
            { 1419000.0d, 0.000446063d },
            { 1430000.0d, 0.000446135d },
            { 1441000.0d, 0.00044615d },
            { 1452000.0d, 0.000446107d },
            { 1463000.0d, 0.000446005d },
            { 1474000.0d, 0.000445846d },
            { 1485000.0d, 0.000445629d },
            { 1496000.0d, 0.000445355d },
            { 1507000.0d, 0.000445022d },
            { 1518000.0d, 0.000444632d },
            { 1529000.0d, 0.000444185d },
            { 1540000.0d, 0.000443681d },
            { 1551000.0d, 0.000443119d },
            { 1562000.0d, 0.0004425d },
            { 1573000.0d, 0.000441825d },
            { 1584000.0d, 0.000441093d },
            { 1595000.0d, 0.000440304d },
            { 1606000.0d, 0.000439459d },
            { 1617000.0d, 0.000438558d },
            { 1628000.0d, 0.000437601d },
            { 1639000.0d, 0.000436589d },
            { 1650000.0d, 0.00043552d },
            { 1661000.0d, 0.000434397d },
            { 1672000.0d, 0.000433219d },
            { 1683000.0d, 0.000431986d },
            { 1694000.0d, 0.000430699d },
            { 1705000.0d, 0.000429357d },
            { 1716000.0d, 0.000427962d },
            { 1727000.0d, 0.000426513d },
            { 1738000.0d, 0.000425011d },
            { 1749000.0d, 0.000423456d },
            { 1760000.0d, 0.000421848d },
            { 1771000.0d, 0.000420188d },
            { 1782000.0d, 0.000418477d },
            { 1793000.0d, 0.000416714d },
            { 1804000.0d, 0.000414899d },
            { 1815000.0d, 0.000413034d },
            { 1826000.0d, 0.000411119d },
            { 1837000.0d, 0.000409154d },
            { 1848000.0d, 0.000407139d },
            { 1859000.0d, 0.000405075d },
            { 1870000.0d, 0.000402963d },
            { 1881000.0d, 0.000400802d },
            { 1892000.0d, 0.000398593d },
            { 1903000.0d, 0.000396338d },
            { 1914000.0d, 0.000394035d },
            { 1925000.0d, 0.000391687d },
            { 1936000.0d, 0.000389292d },
            { 1947000.0d, 0.000386852d },
            { 1958000.0d, 0.000384368d },
            { 1969000.0d, 0.000381839d },
            { 1980000.0d, 0.000379267d },
            { 1991000.0d, 0.000376651d },
            { 2002000.0d, 0.000373993d },
            { 2013000.0d, 0.000371293d },
            { 2024000.0d, 0.000368552d },
            { 2035000.0d, 0.000365769d },
            { 2046000.0d, 0.000362947d },
            { 2057000.0d, 0.000360085d },
            { 2068000.0d, 0.000357184d },
            { 2079000.0d, 0.000354245d },
            { 2090000.0d, 0.000351268d },
            { 2101000.0d, 0.000348253d },
            { 2112000.0d, 0.000345203d },
            { 2123000.0d, 0.000342117d },
            { 2134000.0d, 0.000338996d },
            { 2145000.0d, 0.00033584d },
            { 2156000.0d, 0.000332651d },
            { 2167000.0d, 0.000329429d },
            { 2178000.0d, 0.000326175d },
            { 2189000.0d, 0.00032289d },
            { 2200000.0d, 0.000319573d },
            { 2211000.0d, 0.000316227d },
            { 2222000.0d, 0.000312852d },
            { 2233000.0d, 0.000309448d },
            { 2244000.0d, 0.000306017d },
            { 2255000.0d, 0.000302559d },
            { 2266000.0d, 0.000299075d },
            { 2277000.0d, 0.000295565d },
            { 2288000.0d, 0.000292032d },
            { 2299000.0d, 0.000288475d },
            { 2310000.0d, 0.000284895d },
            { 2321000.0d, 0.000281293d },
            { 2332000.0d, 0.00027767d },
            { 2343000.0d, 0.000274028d },
            { 2354000.0d, 0.000270366d },
            { 2365000.0d, 0.000266686d },
            { 2376000.0d, 0.000262988d },
            { 2387000.0d, 0.000259274d },
            { 2398000.0d, 0.000255544d },
            { 2409000.0d, 0.0002518d },
            { 2420000.0d, 0.000248042d },
            { 2431000.0d, 0.000244271d },
            { 2442000.0d, 0.000240489d },
            { 2453000.0d, 0.000236696d },
            { 2464000.0d, 0.000232893d },
            { 2475000.0d, 0.000229081d },
            { 2486000.0d, 0.000225261d },
            { 2497000.0d, 0.000221435d },
            { 2508000.0d, 0.000217602d },
            { 2519000.0d, 0.000213765d },
            { 2530000.0d, 0.000209925d },
            { 2541000.0d, 0.000206081d },
            { 2552000.0d, 0.000202236d },
            { 2563000.0d, 0.000198391d },
            { 2574000.0d, 0.000194546d },
            { 2585000.0d, 0.000190703d },
            { 2596000.0d, 0.000186862d },
            { 2607000.0d, 0.000183026d },
            { 2618000.0d, 0.000179194d },
            { 2629000.0d, 0.000175369d },
            { 2640000.0d, 0.00017155d },
            { 2651000.0d, 0.000167741d },
            { 2662000.0d, 0.00016394d },
            { 2673000.0d, 0.000160151d },
            { 2684000.0d, 0.000156373d },
            { 2695000.0d, 0.000152608d },
            { 2706000.0d, 0.000148858d },
            { 2717000.0d, 0.000145123d },
            { 2728000.0d, 0.000141405d },
            { 2739000.0d, 0.000137704d },
            { 2750000.0d, 0.000134023d },
            { 2761000.0d, 0.000130362d },
            { 2772000.0d, 0.000126723d },
            { 2783000.0d, 0.000123107d },
            { 2794000.0d, 0.000119515d },
            { 2805000.0d, 0.000115948d },
            { 2816000.0d, 0.000112408d },
            { 2827000.0d, 0.000108896d },
            { 2838000.0d, 0.000105414d },
            { 2849000.0d, 0.000101962d },
            { 2860000.0d, 0.0000985416d },
            { 2871000.0d, 0.0000951549d },
            { 2882000.0d, 0.0000918029d },
            { 2893000.0d, 0.0000884868d },
            { 2904000.0d, 0.0000852082d },
            { 2915000.0d, 0.0000819682d },
            { 2926000.0d, 0.0000787684d },
            { 2937000.0d, 0.00007561d },
            { 2948000.0d, 0.0000724945d },
            { 2959000.0d, 0.0000694233d },
            { 2970000.0d, 0.0000663978d },
            { 2981000.0d, 0.0000634195d },
            { 2992000.0d, 0.0000604897d },
            { 3003000.0d, 0.0000576098d },
            { 3014000.0d, 0.0000547815d },
            { 3025000.0d, 0.000052006d },
            { 3036000.0d, 0.0000492849d },
            { 3047000.0d, 0.0000466196d },
            { 3058000.0d, 0.0000440116d },
            { 3069000.0d, 0.0000414625d },
            { 3080000.0d, 0.0000389736d },
            { 3091000.0d, 0.0000365465d },
            { 3102000.0d, 0.0000341828d },
            { 3113000.0d, 0.0000318839d },
            { 3124000.0d, 0.0000296514d },
            { 3135000.0d, 0.0000274868d },
            { 3146000.0d, 0.0000253916d },
            { 3157000.0d, 0.0000233674d },
            { 3168000.0d, 0.0000214158d },
            { 3179000.0d, 0.0000195382d },
            { 3190000.0d, 0.0000177364d },
            { 3201000.0d, 0.0000160119d },
            { 3212000.0d, 0.0000143662d },
            { 3223000.0d, 0.0000128009d },
            { 3234000.0d, 0.0000113176d },
            { 3245000.0d, 0.00000991804d },
            { 3256000.0d, 0.00000860366d },
            { 3267000.0d, 0.00000737612d },
            { 3278000.0d, 0.00000623702d },
            { 3289000.0d, 0.00000518799d },
            { 3300000.0d, 0.00000423062d },
            { 3311000.0d, 0.00000336652d },
            { 3322000.0d, 0.00000259731d },
            { 3333000.0d, 0.00000192457d },
            { 3344000.0d, 0.0000013499d },
            { 3355000.0d, 0.000000874854d },
            { 3366000.0d, 0.000000500974d },
            { 3377000.0d, 0.000000229741d },
            { 3388000.0d, 0.0000000625292d },
            { 3399000.0d, 0.000000000427239d },
            { 3400000.0d, 0d },

        }; 
    }
}
    