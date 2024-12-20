using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium154";
        public override double halfLife { get; } = 0.409d;
        public override double atomicWeight { get; } = 153.9464d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9259999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium150()), new(1.0d, new AlphaParticle(6496002.09)) } },
            { 0.07400000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium154()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.048d, new GammaParticle(133200.0, 0.00931)), new(0.001405769232d, new GammaParticle(8215.0, 0.15092)), new(0.0016908350806363564d, new GammaParticle(49773.0, 0.02491)), new(0.002985231427677183d, new GammaParticle(50742.0, 0.02443)), new(0.0009760361045130641d, new GammaParticle(57612.0, 0.02152)), new(0.001229805491686461d, new GammaParticle(58257.0, 0.02128)), new(0.0002537693871733967d, new GammaParticle(59034.0, 0.021)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 11000.0d, 0.0000000021529d },
            { 22000.0d, 0.0000000156097d },
            { 33000.0d, 0.000000048022d },
            { 44000.0d, 0.000000102199d },
            { 55000.0d, 0.000000177857d },
            { 66000.0d, 0.00000027326d },
            { 77000.0d, 0.000000386151d },
            { 88000.0d, 0.000000514222d },
            { 99000.0d, 0.000000655314d },
            { 110000.0d, 0.000000807498d },
            { 121000.0d, 0.000000969089d },
            { 132000.0d, 0.00000113863d },
            { 143000.0d, 0.00000131488d },
            { 154000.0d, 0.00000149675d },
            { 165000.0d, 0.00000168335d },
            { 176000.0d, 0.00000187388d },
            { 187000.0d, 0.00000206767d },
            { 198000.0d, 0.00000226413d },
            { 209000.0d, 0.00000246277d },
            { 220000.0d, 0.00000266314d },
            { 231000.0d, 0.00000286487d },
            { 242000.0d, 0.00000306763d },
            { 253000.0d, 0.00000327112d },
            { 264000.0d, 0.00000347509d },
            { 275000.0d, 0.00000367931d },
            { 286000.0d, 0.00000388358d },
            { 297000.0d, 0.00000408771d },
            { 308000.0d, 0.00000429155d },
            { 319000.0d, 0.00000449496d },
            { 330000.0d, 0.0000046978d },
            { 341000.0d, 0.00000489995d },
            { 352000.0d, 0.00000510131d },
            { 363000.0d, 0.00000530178d },
            { 374000.0d, 0.00000550128d },
            { 385000.0d, 0.00000569971d },
            { 396000.0d, 0.00000589701d },
            { 407000.0d, 0.00000609311d },
            { 418000.0d, 0.00000628793d },
            { 429000.0d, 0.00000648143d },
            { 440000.0d, 0.00000667354d },
            { 451000.0d, 0.00000686422d },
            { 462000.0d, 0.00000705342d },
            { 473000.0d, 0.00000724109d },
            { 484000.0d, 0.00000742718d },
            { 495000.0d, 0.00000761166d },
            { 506000.0d, 0.00000779449d },
            { 517000.0d, 0.00000797564d },
            { 528000.0d, 0.00000815506d },
            { 539000.0d, 0.00000833274d },
            { 550000.0d, 0.00000850862d },
            { 561000.0d, 0.0000086827d },
            { 572000.0d, 0.00000885493d },
            { 583000.0d, 0.0000090253d },
            { 594000.0d, 0.00000919377d },
            { 605000.0d, 0.00000936032d },
            { 616000.0d, 0.00000952494d },
            { 627000.0d, 0.00000968759d },
            { 638000.0d, 0.00000984825d },
            { 649000.0d, 0.0000100069d },
            { 660000.0d, 0.0000101635d },
            { 671000.0d, 0.0000103181d },
            { 682000.0d, 0.0000104706d },
            { 693000.0d, 0.0000106211d },
            { 704000.0d, 0.0000107694d },
            { 715000.0d, 0.0000109157d },
            { 726000.0d, 0.0000110598d },
            { 737000.0d, 0.0000112017d },
            { 748000.0d, 0.0000113415d },
            { 759000.0d, 0.0000114791d },
            { 770000.0d, 0.0000116145d },
            { 781000.0d, 0.0000117478d },
            { 792000.0d, 0.0000118788d },
            { 803000.0d, 0.0000120076d },
            { 814000.0d, 0.0000121341d },
            { 825000.0d, 0.0000122584d },
            { 836000.0d, 0.0000123805d },
            { 847000.0d, 0.0000125003d },
            { 858000.0d, 0.0000126178d },
            { 869000.0d, 0.000012733d },
            { 880000.0d, 0.0000128459d },
            { 891000.0d, 0.0000129565d },
            { 902000.0d, 0.0000130648d },
            { 913000.0d, 0.0000131708d },
            { 924000.0d, 0.0000132745d },
            { 935000.0d, 0.0000133758d },
            { 946000.0d, 0.0000134748d },
            { 957000.0d, 0.0000135714d },
            { 968000.0d, 0.0000136657d },
            { 979000.0d, 0.0000137577d },
            { 990000.0d, 0.0000138473d },
            { 1001000.0d, 0.0000139345d },
            { 1012000.0d, 0.0000140193d },
            { 1023000.0d, 0.0000141018d },
            { 1034000.0d, 0.0000141819d },
            { 1045000.0d, 0.0000142596d },
            { 1056000.0d, 0.000014335d },
            { 1067000.0d, 0.0000144079d },
            { 1078000.0d, 0.0000144785d },
            { 1089000.0d, 0.0000145467d },
            { 1100000.0d, 0.0000146125d },
            { 1111000.0d, 0.0000146759d },
            { 1122000.0d, 0.0000147369d },
            { 1133000.0d, 0.0000147956d },
            { 1144000.0d, 0.0000148518d },
            { 1155000.0d, 0.0000149057d },
            { 1166000.0d, 0.0000149572d },
            { 1177000.0d, 0.0000150063d },
            { 1188000.0d, 0.000015053d },
            { 1199000.0d, 0.0000150973d },
            { 1210000.0d, 0.0000151393d },
            { 1221000.0d, 0.0000151789d },
            { 1232000.0d, 0.0000152161d },
            { 1243000.0d, 0.0000152509d },
            { 1254000.0d, 0.0000152834d },
            { 1265000.0d, 0.0000153135d },
            { 1276000.0d, 0.0000153413d },
            { 1287000.0d, 0.0000153667d },
            { 1298000.0d, 0.0000153897d },
            { 1309000.0d, 0.0000154104d },
            { 1320000.0d, 0.0000154288d },
            { 1331000.0d, 0.0000154449d },
            { 1342000.0d, 0.0000154586d },
            { 1353000.0d, 0.00001547d },
            { 1364000.0d, 0.0000154791d },
            { 1375000.0d, 0.0000154859d },
            { 1386000.0d, 0.0000154904d },
            { 1397000.0d, 0.0000154926d },
            { 1408000.0d, 0.0000154926d },
            { 1419000.0d, 0.0000154903d },
            { 1430000.0d, 0.0000154857d },
            { 1441000.0d, 0.0000154788d },
            { 1452000.0d, 0.0000154698d },
            { 1463000.0d, 0.0000154584d },
            { 1474000.0d, 0.0000154449d },
            { 1485000.0d, 0.0000154292d },
            { 1496000.0d, 0.0000154112d },
            { 1507000.0d, 0.0000153911d },
            { 1518000.0d, 0.0000153688d },
            { 1529000.0d, 0.0000153443d },
            { 1540000.0d, 0.0000153177d },
            { 1551000.0d, 0.0000152889d },
            { 1562000.0d, 0.000015258d },
            { 1573000.0d, 0.000015225d },
            { 1584000.0d, 0.0000151899d },
            { 1595000.0d, 0.0000151526d },
            { 1606000.0d, 0.0000151134d },
            { 1617000.0d, 0.000015072d },
            { 1628000.0d, 0.0000150286d },
            { 1639000.0d, 0.0000149832d },
            { 1650000.0d, 0.0000149358d },
            { 1661000.0d, 0.0000148863d },
            { 1672000.0d, 0.0000148349d },
            { 1683000.0d, 0.0000147815d },
            { 1694000.0d, 0.0000147262d },
            { 1705000.0d, 0.0000146689d },
            { 1716000.0d, 0.0000146097d },
            { 1727000.0d, 0.0000145486d },
            { 1738000.0d, 0.0000144856d },
            { 1749000.0d, 0.0000144208d },
            { 1760000.0d, 0.0000143541d },
            { 1771000.0d, 0.0000142855d },
            { 1782000.0d, 0.0000142152d },
            { 1793000.0d, 0.0000141431d },
            { 1804000.0d, 0.0000140692d },
            { 1815000.0d, 0.0000139935d },
            { 1826000.0d, 0.0000139161d },
            { 1837000.0d, 0.000013837d },
            { 1848000.0d, 0.0000137562d },
            { 1859000.0d, 0.0000136738d },
            { 1870000.0d, 0.0000135897d },
            { 1881000.0d, 0.0000135039d },
            { 1892000.0d, 0.0000134166d },
            { 1903000.0d, 0.0000133277d },
            { 1914000.0d, 0.0000132372d },
            { 1925000.0d, 0.0000131451d },
            { 1936000.0d, 0.0000130516d },
            { 1947000.0d, 0.0000129565d },
            { 1958000.0d, 0.00001286d },
            { 1969000.0d, 0.000012762d },
            { 1980000.0d, 0.0000126627d },
            { 1991000.0d, 0.0000125619d },
            { 2002000.0d, 0.0000124597d },
            { 2013000.0d, 0.0000123562d },
            { 2024000.0d, 0.0000122514d },
            { 2035000.0d, 0.0000121453d },
            { 2046000.0d, 0.0000120379d },
            { 2057000.0d, 0.0000119292d },
            { 2068000.0d, 0.0000118194d },
            { 2079000.0d, 0.0000117083d },
            { 2090000.0d, 0.0000115961d },
            { 2101000.0d, 0.0000114827d },
            { 2112000.0d, 0.0000113682d },
            { 2123000.0d, 0.0000112527d },
            { 2134000.0d, 0.0000111361d },
            { 2145000.0d, 0.0000110184d },
            { 2156000.0d, 0.0000108998d },
            { 2167000.0d, 0.0000107802d },
            { 2178000.0d, 0.0000106596d },
            { 2189000.0d, 0.0000105381d },
            { 2200000.0d, 0.0000104158d },
            { 2211000.0d, 0.0000102926d },
            { 2222000.0d, 0.0000101686d },
            { 2233000.0d, 0.0000100438d },
            { 2244000.0d, 0.0000099182d },
            { 2255000.0d, 0.0000097919d },
            { 2266000.0d, 0.0000096649d },
            { 2277000.0d, 0.00000953724d },
            { 2288000.0d, 0.00000940894d },
            { 2299000.0d, 0.00000928004d },
            { 2310000.0d, 0.00000915057d },
            { 2321000.0d, 0.00000902057d },
            { 2332000.0d, 0.00000889006d },
            { 2343000.0d, 0.00000875908d },
            { 2354000.0d, 0.00000862767d },
            { 2365000.0d, 0.00000849585d },
            { 2376000.0d, 0.00000836367d },
            { 2387000.0d, 0.00000823115d },
            { 2398000.0d, 0.00000809833d },
            { 2409000.0d, 0.00000796524d },
            { 2420000.0d, 0.00000783193d },
            { 2431000.0d, 0.00000769843d },
            { 2442000.0d, 0.00000756476d },
            { 2453000.0d, 0.00000743098d },
            { 2464000.0d, 0.0000072971d },
            { 2475000.0d, 0.00000716319d },
            { 2486000.0d, 0.00000702925d },
            { 2497000.0d, 0.00000689535d },
            { 2508000.0d, 0.0000067615d },
            { 2519000.0d, 0.00000662776d },
            { 2530000.0d, 0.00000649415d },
            { 2541000.0d, 0.00000636072d },
            { 2552000.0d, 0.00000622751d },
            { 2563000.0d, 0.00000609454d },
            { 2574000.0d, 0.00000596187d },
            { 2585000.0d, 0.00000582954d },
            { 2596000.0d, 0.00000569757d },
            { 2607000.0d, 0.00000556601d },
            { 2618000.0d, 0.00000543491d },
            { 2629000.0d, 0.0000053043d },
            { 2640000.0d, 0.00000517421d },
            { 2651000.0d, 0.00000504471d },
            { 2662000.0d, 0.00000491581d },
            { 2673000.0d, 0.00000478757d },
            { 2684000.0d, 0.00000466003d },
            { 2695000.0d, 0.00000453322d },
            { 2706000.0d, 0.0000044072d },
            { 2717000.0d, 0.00000428199d },
            { 2728000.0d, 0.00000415766d },
            { 2739000.0d, 0.00000403423d },
            { 2750000.0d, 0.00000391175d },
            { 2761000.0d, 0.00000379027d },
            { 2772000.0d, 0.00000366983d },
            { 2783000.0d, 0.00000355047d },
            { 2794000.0d, 0.00000343224d },
            { 2805000.0d, 0.00000331517d },
            { 2816000.0d, 0.00000319933d },
            { 2827000.0d, 0.00000308474d },
            { 2838000.0d, 0.00000297146d },
            { 2849000.0d, 0.00000285953d },
            { 2860000.0d, 0.000002749d },
            { 2871000.0d, 0.00000263991d },
            { 2882000.0d, 0.0000025323d },
            { 2893000.0d, 0.00000242624d },
            { 2904000.0d, 0.00000232175d },
            { 2915000.0d, 0.00000221889d },
            { 2926000.0d, 0.00000211771d },
            { 2937000.0d, 0.00000201825d },
            { 2948000.0d, 0.00000192056d },
            { 2959000.0d, 0.00000182469d },
            { 2970000.0d, 0.00000173069d },
            { 2981000.0d, 0.0000016386d },
            { 2992000.0d, 0.00000154847d },
            { 3003000.0d, 0.00000146035d },
            { 3014000.0d, 0.00000137429d },
            { 3025000.0d, 0.00000129034d },
            { 3036000.0d, 0.00000120855d },
            { 3047000.0d, 0.00000112897d },
            { 3058000.0d, 0.00000105165d },
            { 3069000.0d, 0.000000976632d },
            { 3080000.0d, 0.000000903973d },
            { 3091000.0d, 0.000000833722d },
            { 3102000.0d, 0.00000076593d },
            { 3113000.0d, 0.000000700647d },
            { 3124000.0d, 0.000000637924d },
            { 3135000.0d, 0.000000577812d },
            { 3146000.0d, 0.000000520362d },
            { 3157000.0d, 0.000000465626d },
            { 3168000.0d, 0.000000413655d },
            { 3179000.0d, 0.0000003645d },
            { 3190000.0d, 0.000000318213d },
            { 3201000.0d, 0.000000274847d },
            { 3212000.0d, 0.000000234452d },
            { 3223000.0d, 0.00000019708d },
            { 3234000.0d, 0.000000162784d },
            { 3245000.0d, 0.000000131615d },
            { 3256000.0d, 0.000000103625d },
            { 3267000.0d, 0.0000000788646d },
            { 3278000.0d, 0.0000000573855d },
            { 3289000.0d, 0.0000000392381d },
            { 3300000.0d, 0.0000000244722d },
            { 3311000.0d, 0.0000000131361d },
            { 3322000.0d, 0.00000000527598d },
            { 3333000.0d, 0.000000000933285d },
            { 3341000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    