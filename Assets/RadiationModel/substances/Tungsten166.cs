using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten166 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten166";
        public override double halfLife { get; } = 19.2d;
        public override double atomicWeight { get; } = 165.95503d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99965d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium166()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0046d, new GammaParticle(45800.0, 0.02707)), new(0.0062d, new GammaParticle(97700.0, 0.01269)), new(0.33d, new GammaParticle(125800.0, 0.00986)), new(0.019d, new GammaParticle(172500.0, 0.00719)), new(0.026000000000000002d, new GammaParticle(224600.0, 0.00552)), new(0.0076d, new GammaParticle(270100.0, 0.00459)), new(0.018000000000000002d, new GammaParticle(395900.0, 0.00313)), new(0.8d, new GammaParticle(511000.0, 0.00243)), new(0.3d, new GammaParticle(9424.0, 0.13156)), new(0.27d, new GammaParticle(56280.0, 0.02203)), new(0.48d, new GammaParticle(57535.0, 0.02155)), new(0.16d, new GammaParticle(65315.0, 0.01898)), new(0.2d, new GammaParticle(66067.0, 0.01877)), new(0.043d, new GammaParticle(66981.0, 0.01851)) } },
            { 0.00035000000000000005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium162()), new(1.0d, new AlphaParticle(5878002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 9000.0d, 0.0000000155379d },
            { 18000.0d, 0.000000130039d },
            { 27000.0d, 0.000000404165d },
            { 36000.0d, 0.000000890906d },
            { 45000.0d, 0.00000160992d },
            { 54000.0d, 0.00000256092d },
            { 63000.0d, 0.00000373247d },
            { 72000.0d, 0.00000510766d },
            { 81000.0d, 0.0000066675d },
            { 90000.0d, 0.00000839275d },
            { 99000.0d, 0.0000102641d },
            { 108000.0d, 0.0000122656d },
            { 118000.0d, 0.0000146234d },
            { 128000.0d, 0.0000171031d },
            { 138000.0d, 0.0000196875d },
            { 148000.0d, 0.0000223617d },
            { 158000.0d, 0.0000251122d },
            { 168000.0d, 0.0000279277d },
            { 178000.0d, 0.0000307978d },
            { 188000.0d, 0.0000337134d },
            { 198000.0d, 0.0000366668d },
            { 208000.0d, 0.0000396509d },
            { 218000.0d, 0.0000426596d },
            { 228000.0d, 0.0000456874d },
            { 238000.0d, 0.0000487293d },
            { 248000.0d, 0.0000517812d },
            { 258000.0d, 0.0000548391d },
            { 268000.0d, 0.0000578996d },
            { 278000.0d, 0.0000609596d },
            { 288000.0d, 0.0000640162d },
            { 298000.0d, 0.000067067d },
            { 308000.0d, 0.0000701097d },
            { 318000.0d, 0.0000731422d },
            { 328000.0d, 0.0000761627d },
            { 338000.0d, 0.0000791694d },
            { 348000.0d, 0.0000821608d },
            { 358000.0d, 0.0000851356d },
            { 368000.0d, 0.0000880922d },
            { 378000.0d, 0.0000910296d },
            { 388000.0d, 0.0000939466d },
            { 398000.0d, 0.0000968423d },
            { 408000.0d, 0.0000997156d },
            { 418000.0d, 0.000102566d },
            { 428000.0d, 0.000105392d },
            { 438000.0d, 0.000108193d },
            { 448000.0d, 0.000110969d },
            { 458000.0d, 0.000113719d },
            { 468000.0d, 0.000116442d },
            { 478000.0d, 0.000119137d },
            { 488000.0d, 0.000121806d },
            { 498000.0d, 0.000124445d },
            { 508000.0d, 0.000127055d },
            { 518000.0d, 0.000129636d },
            { 528000.0d, 0.000132188d },
            { 538000.0d, 0.000134709d },
            { 548000.0d, 0.0001372d },
            { 558000.0d, 0.00013966d },
            { 568000.0d, 0.000142089d },
            { 578000.0d, 0.000144486d },
            { 588000.0d, 0.000146852d },
            { 598000.0d, 0.000149185d },
            { 608000.0d, 0.000151486d },
            { 618000.0d, 0.000153754d },
            { 628000.0d, 0.00015599d },
            { 638000.0d, 0.000158192d },
            { 648000.0d, 0.000160361d },
            { 658000.0d, 0.000162497d },
            { 668000.0d, 0.000164598d },
            { 678000.0d, 0.000166666d },
            { 688000.0d, 0.000168699d },
            { 698000.0d, 0.000170698d },
            { 708000.0d, 0.000172663d },
            { 718000.0d, 0.000174593d },
            { 728000.0d, 0.000176489d },
            { 738000.0d, 0.00017835d },
            { 748000.0d, 0.000180175d },
            { 758000.0d, 0.000181966d },
            { 768000.0d, 0.000183721d },
            { 778000.0d, 0.000185441d },
            { 788000.0d, 0.000187125d },
            { 798000.0d, 0.000188774d },
            { 808000.0d, 0.000190388d },
            { 818000.0d, 0.000191966d },
            { 828000.0d, 0.000193508d },
            { 838000.0d, 0.000195014d },
            { 848000.0d, 0.000196484d },
            { 858000.0d, 0.000197919d },
            { 868000.0d, 0.000199317d },
            { 878000.0d, 0.000200679d },
            { 888000.0d, 0.000202005d },
            { 898000.0d, 0.000203296d },
            { 908000.0d, 0.00020455d },
            { 918000.0d, 0.000205768d },
            { 928000.0d, 0.00020695d },
            { 938000.0d, 0.000208096d },
            { 948000.0d, 0.000209206d },
            { 958000.0d, 0.000210279d },
            { 968000.0d, 0.000211316d },
            { 978000.0d, 0.000212318d },
            { 988000.0d, 0.000213283d },
            { 998000.0d, 0.000214212d },
            { 1008000.0d, 0.000215105d },
            { 1018000.0d, 0.000215962d },
            { 1028000.0d, 0.000216783d },
            { 1038000.0d, 0.000217569d },
            { 1048000.0d, 0.000218318d },
            { 1058000.0d, 0.000219032d },
            { 1068000.0d, 0.00021971d },
            { 1078000.0d, 0.000220352d },
            { 1088000.0d, 0.000220958d },
            { 1098000.0d, 0.000221529d },
            { 1108000.0d, 0.000222065d },
            { 1118000.0d, 0.000222565d },
            { 1128000.0d, 0.000223029d },
            { 1138000.0d, 0.000223459d },
            { 1148000.0d, 0.000223854d },
            { 1158000.0d, 0.000224213d },
            { 1168000.0d, 0.000224538d },
            { 1178000.0d, 0.000224827d },
            { 1188000.0d, 0.000225082d },
            { 1198000.0d, 0.000225303d },
            { 1208000.0d, 0.00022549d },
            { 1218000.0d, 0.000225641d },
            { 1228000.0d, 0.000225758d },
            { 1238000.0d, 0.000225842d },
            { 1248000.0d, 0.000225892d },
            { 1258000.0d, 0.000225907d },
            { 1268000.0d, 0.000225889d },
            { 1278000.0d, 0.000225838d },
            { 1288000.0d, 0.000225754d },
            { 1298000.0d, 0.000225636d },
            { 1308000.0d, 0.000225485d },
            { 1318000.0d, 0.000225302d },
            { 1328000.0d, 0.000225085d },
            { 1338000.0d, 0.000224837d },
            { 1348000.0d, 0.000224556d },
            { 1358000.0d, 0.000224243d },
            { 1368000.0d, 0.000223898d },
            { 1378000.0d, 0.000223521d },
            { 1388000.0d, 0.000223113d },
            { 1398000.0d, 0.000222674d },
            { 1408000.0d, 0.000222203d },
            { 1418000.0d, 0.000221702d },
            { 1428000.0d, 0.00022117d },
            { 1438000.0d, 0.000220607d },
            { 1448000.0d, 0.000220014d },
            { 1458000.0d, 0.000219391d },
            { 1468000.0d, 0.000218739d },
            { 1478000.0d, 0.000218058d },
            { 1488000.0d, 0.000217346d },
            { 1498000.0d, 0.000216606d },
            { 1508000.0d, 0.000215837d },
            { 1518000.0d, 0.000215039d },
            { 1528000.0d, 0.000214214d },
            { 1538000.0d, 0.00021336d },
            { 1548000.0d, 0.000212478d },
            { 1558000.0d, 0.000211568d },
            { 1568000.0d, 0.000210632d },
            { 1578000.0d, 0.000209669d },
            { 1588000.0d, 0.00020868d },
            { 1598000.0d, 0.000207663d },
            { 1608000.0d, 0.000206621d },
            { 1618000.0d, 0.000205553d },
            { 1628000.0d, 0.000204459d },
            { 1638000.0d, 0.00020334d },
            { 1648000.0d, 0.000202197d },
            { 1658000.0d, 0.000201029d },
            { 1668000.0d, 0.000199836d },
            { 1678000.0d, 0.00019862d },
            { 1688000.0d, 0.00019738d },
            { 1698000.0d, 0.000196117d },
            { 1708000.0d, 0.000194831d },
            { 1718000.0d, 0.000193523d },
            { 1728000.0d, 0.000192191d },
            { 1738000.0d, 0.000190838d },
            { 1748000.0d, 0.000189464d },
            { 1758000.0d, 0.000188068d },
            { 1768000.0d, 0.000186651d },
            { 1778000.0d, 0.000185214d },
            { 1788000.0d, 0.000183757d },
            { 1798000.0d, 0.000182279d },
            { 1808000.0d, 0.000180783d },
            { 1818000.0d, 0.000179267d },
            { 1828000.0d, 0.000177733d },
            { 1838000.0d, 0.00017618d },
            { 1848000.0d, 0.000174609d },
            { 1858000.0d, 0.000173021d },
            { 1868000.0d, 0.000171416d },
            { 1878000.0d, 0.000169793d },
            { 1888000.0d, 0.000168155d },
            { 1898000.0d, 0.0001665d },
            { 1908000.0d, 0.00016483d },
            { 1918000.0d, 0.000163146d },
            { 1928000.0d, 0.000161445d },
            { 1938000.0d, 0.000159731d },
            { 1948000.0d, 0.000158003d },
            { 1958000.0d, 0.000156261d },
            { 1968000.0d, 0.000154507d },
            { 1978000.0d, 0.000152739d },
            { 1988000.0d, 0.00015096d },
            { 1998000.0d, 0.000149169d },
            { 2008000.0d, 0.000147367d },
            { 2018000.0d, 0.000145554d },
            { 2028000.0d, 0.00014373d },
            { 2038000.0d, 0.000141896d },
            { 2048000.0d, 0.000140053d },
            { 2058000.0d, 0.000138201d },
            { 2068000.0d, 0.000136341d },
            { 2078000.0d, 0.000134473d },
            { 2088000.0d, 0.000132596d },
            { 2098000.0d, 0.000130713d },
            { 2108000.0d, 0.000128823d },
            { 2118000.0d, 0.000126927d },
            { 2128000.0d, 0.000125025d },
            { 2138000.0d, 0.000123118d },
            { 2148000.0d, 0.000121207d },
            { 2158000.0d, 0.000119291d },
            { 2168000.0d, 0.000117371d },
            { 2178000.0d, 0.000115448d },
            { 2188000.0d, 0.000113523d },
            { 2198000.0d, 0.000111596d },
            { 2208000.0d, 0.000109667d },
            { 2218000.0d, 0.000107736d },
            { 2228000.0d, 0.000105805d },
            { 2238000.0d, 0.000103875d },
            { 2248000.0d, 0.000101944d },
            { 2258000.0d, 0.000100015d },
            { 2268000.0d, 0.000098087d },
            { 2278000.0d, 0.0000961612d },
            { 2288000.0d, 0.0000942381d },
            { 2298000.0d, 0.0000923182d },
            { 2308000.0d, 0.000090402d },
            { 2318000.0d, 0.0000884901d },
            { 2328000.0d, 0.0000865831d },
            { 2338000.0d, 0.0000846815d },
            { 2348000.0d, 0.0000827858d },
            { 2358000.0d, 0.0000808967d },
            { 2368000.0d, 0.0000790147d },
            { 2378000.0d, 0.0000771405d },
            { 2388000.0d, 0.0000752745d },
            { 2398000.0d, 0.0000734174d },
            { 2408000.0d, 0.0000715697d },
            { 2418000.0d, 0.0000697321d },
            { 2428000.0d, 0.0000679052d },
            { 2438000.0d, 0.0000660894d },
            { 2448000.0d, 0.0000642855d },
            { 2458000.0d, 0.0000624941d },
            { 2468000.0d, 0.0000607157d },
            { 2478000.0d, 0.000058951d },
            { 2488000.0d, 0.0000572006d },
            { 2498000.0d, 0.000055465d },
            { 2508000.0d, 0.000053745d },
            { 2518000.0d, 0.0000520411d },
            { 2528000.0d, 0.000050354d },
            { 2538000.0d, 0.0000486843d },
            { 2548000.0d, 0.0000470326d },
            { 2558000.0d, 0.0000453996d },
            { 2568000.0d, 0.0000437859d },
            { 2578000.0d, 0.0000421922d },
            { 2588000.0d, 0.0000406191d },
            { 2598000.0d, 0.0000390672d },
            { 2608000.0d, 0.0000375373d },
            { 2618000.0d, 0.00003603d },
            { 2628000.0d, 0.0000345458d },
            { 2638000.0d, 0.0000330855d },
            { 2648000.0d, 0.0000316498d },
            { 2658000.0d, 0.0000302394d },
            { 2668000.0d, 0.0000288548d },
            { 2678000.0d, 0.0000274968d },
            { 2688000.0d, 0.000026166d },
            { 2698000.0d, 0.0000248632d },
            { 2708000.0d, 0.0000235889d },
            { 2718000.0d, 0.000022344d },
            { 2728000.0d, 0.0000211291d },
            { 2738000.0d, 0.0000199448d },
            { 2748000.0d, 0.0000187919d },
            { 2758000.0d, 0.000017671d },
            { 2768000.0d, 0.0000165829d },
            { 2778000.0d, 0.0000155282d },
            { 2788000.0d, 0.0000145076d },
            { 2798000.0d, 0.0000135191d },
            { 2808000.0d, 0.0000125605d },
            { 2818000.0d, 0.0000116325d },
            { 2828000.0d, 0.0000107356d },
            { 2838000.0d, 0.00000987057d },
            { 2848000.0d, 0.00000903761d },
            { 2858000.0d, 0.00000823727d },
            { 2868000.0d, 0.00000747021d },
            { 2878000.0d, 0.00000673706d },
            { 2888000.0d, 0.00000603843d },
            { 2898000.0d, 0.0000053747d },
            { 2908000.0d, 0.0000047464d },
            { 2918000.0d, 0.00000415416d },
            { 2928000.0d, 0.0000035986d },
            { 2938000.0d, 0.00000308035d },
            { 2948000.0d, 0.00000260005d },
            { 2958000.0d, 0.00000215834d },
            { 2968000.0d, 0.00000175585d },
            { 2978000.0d, 0.00000139319d },
            { 2988000.0d, 0.00000107101d },
            { 2998000.0d, 0.000000789937d },
            { 3008000.0d, 0.000000550575d },
            { 3018000.0d, 0.000000353537d },
            { 3028000.0d, 0.000000199423d },
            { 3038000.0d, 0.000000088802d },
            { 3048000.0d, 0.0000000222014d },
            { 3058000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    