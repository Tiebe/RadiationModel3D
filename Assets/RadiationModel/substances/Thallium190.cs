using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium190";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 189.97384d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold190()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.000237d, new GammaParticle(292600.0, 0.00424)), new(0.002212d, new GammaParticle(403800.0, 0.00307)), new(0.79d, new GammaParticle(416400.0, 0.00298)), new(0.0079d, new GammaParticle(458700.0, 0.0027)), new(0.00553d, new GammaParticle(516800.0, 0.0024)), new(0.0014219999999999999d, new GammaParticle(529700.0, 0.00234)), new(0.01264d, new GammaParticle(557000.0, 0.00223)), new(0.0079d, new GammaParticle(615300.0, 0.00202)), new(0.1106d, new GammaParticle(625400.0, 0.00198)), new(0.08689999999999999d, new GammaParticle(683500.0, 0.00181)), new(0.0033179999999999998d, new GammaParticle(862200.0, 0.00144)), new(0.003792d, new GammaParticle(933400.0, 0.00133)), new(0.0711d, new GammaParticle(1099900.0, 0.00113)), new(0.030019999999999998d, new GammaParticle(1142500.0, 0.00109)), new(0.005451d, new GammaParticle(1155000.0, 0.00107)), new(0.0023699999999999997d, new GammaParticle(1240900.0, 0.001)), new(0.009638d, new GammaParticle(1558800.0, 0.0008)), new(0.0079d, new GammaParticle(1558900.0, 0.0008)), new(0.0016589999999999999d, new GammaParticle(1571200.0, 0.00079)), new(1.5390000000000001d, new GammaParticle(511000.0, 0.00243)), new(0.08d, new GammaParticle(11777.0, 0.10528)), new(0.06d, new GammaParticle(68894.0, 0.018)), new(0.11d, new GammaParticle(70820.0, 0.01751)), new(0.04d, new GammaParticle(80316.0, 0.01544)), new(0.05d, new GammaParticle(81285.0, 0.01525)), new(0.011000000000000001d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 13000.0d, 0.0000000114035d },
            { 26000.0d, 0.000000168744d },
            { 39000.0d, 0.000000499197d },
            { 52000.0d, 0.00000108328d },
            { 65000.0d, 0.00000191587d },
            { 78000.0d, 0.00000298609d },
            { 91000.0d, 0.00000426997d },
            { 104000.0d, 0.00000573996d },
            { 117000.0d, 0.00000737523d },
            { 130000.0d, 0.00000915176d },
            { 143000.0d, 0.0000110482d },
            { 156000.0d, 0.0000130465d },
            { 169000.0d, 0.0000151336d },
            { 182000.0d, 0.0000172952d },
            { 195000.0d, 0.0000195192d },
            { 208000.0d, 0.0000217963d },
            { 221000.0d, 0.0000241177d },
            { 234000.0d, 0.0000264768d },
            { 247000.0d, 0.000028866d },
            { 260000.0d, 0.0000312807d },
            { 273000.0d, 0.0000337161d },
            { 286000.0d, 0.0000361675d },
            { 299000.0d, 0.0000386313d },
            { 312000.0d, 0.0000411047d },
            { 325000.0d, 0.0000435849d },
            { 338000.0d, 0.0000460686d },
            { 351000.0d, 0.0000485543d },
            { 364000.0d, 0.00005104d },
            { 377000.0d, 0.0000535237d },
            { 390000.0d, 0.0000560039d },
            { 403000.0d, 0.0000584795d },
            { 416000.0d, 0.0000609489d },
            { 429000.0d, 0.000063411d },
            { 442000.0d, 0.000065865d },
            { 455000.0d, 0.00006831d },
            { 468000.0d, 0.0000707449d },
            { 481000.0d, 0.0000731691d },
            { 494000.0d, 0.000075582d },
            { 507000.0d, 0.0000779828d },
            { 520000.0d, 0.000080371d },
            { 533000.0d, 0.0000827461d },
            { 546000.0d, 0.0000851077d },
            { 559000.0d, 0.0000874553d },
            { 572000.0d, 0.0000897884d },
            { 585000.0d, 0.0000921067d },
            { 598000.0d, 0.0000944098d },
            { 611000.0d, 0.0000966976d },
            { 624000.0d, 0.0000989695d },
            { 637000.0d, 0.000101225d },
            { 650000.0d, 0.000103465d },
            { 663000.0d, 0.000105688d },
            { 676000.0d, 0.000107894d },
            { 689000.0d, 0.000110083d },
            { 702000.0d, 0.000112255d },
            { 715000.0d, 0.00011441d },
            { 728000.0d, 0.000116547d },
            { 741000.0d, 0.000118666d },
            { 754000.0d, 0.000120768d },
            { 767000.0d, 0.000122851d },
            { 780000.0d, 0.000124916d },
            { 793000.0d, 0.000126963d },
            { 806000.0d, 0.000128992d },
            { 819000.0d, 0.000131002d },
            { 832000.0d, 0.000132993d },
            { 845000.0d, 0.000134966d },
            { 858000.0d, 0.00013692d },
            { 871000.0d, 0.000138855d },
            { 884000.0d, 0.000140771d },
            { 897000.0d, 0.000142668d },
            { 910000.0d, 0.000144545d },
            { 923000.0d, 0.000146404d },
            { 936000.0d, 0.000148243d },
            { 949000.0d, 0.000150062d },
            { 962000.0d, 0.000151863d },
            { 975000.0d, 0.000153644d },
            { 988000.0d, 0.000155405d },
            { 1001000.0d, 0.000157146d },
            { 1020000.0d, 0.000159657d },
            { 1039000.0d, 0.000162125d },
            { 1058000.0d, 0.00016455d },
            { 1077000.0d, 0.000166934d },
            { 1096000.0d, 0.000169275d },
            { 1115000.0d, 0.000171573d },
            { 1134000.0d, 0.000173829d },
            { 1153000.0d, 0.000176042d },
            { 1172000.0d, 0.000178213d },
            { 1191000.0d, 0.00018034d },
            { 1210000.0d, 0.000182425d },
            { 1229000.0d, 0.000184467d },
            { 1248000.0d, 0.000186466d },
            { 1267000.0d, 0.000188422d },
            { 1286000.0d, 0.000190336d },
            { 1305000.0d, 0.000192206d },
            { 1324000.0d, 0.000194033d },
            { 1343000.0d, 0.000195818d },
            { 1362000.0d, 0.00019756d },
            { 1381000.0d, 0.000199259d },
            { 1400000.0d, 0.000200915d },
            { 1419000.0d, 0.000202528d },
            { 1438000.0d, 0.000204098d },
            { 1457000.0d, 0.000205627d },
            { 1476000.0d, 0.000207112d },
            { 1495000.0d, 0.000208555d },
            { 1514000.0d, 0.000209955d },
            { 1533000.0d, 0.000211313d },
            { 1552000.0d, 0.000212629d },
            { 1571000.0d, 0.000213902d },
            { 1590000.0d, 0.000215133d },
            { 1609000.0d, 0.000216323d },
            { 1628000.0d, 0.00021747d },
            { 1647000.0d, 0.000218576d },
            { 1666000.0d, 0.00021964d },
            { 1685000.0d, 0.000220662d },
            { 1704000.0d, 0.000221643d },
            { 1723000.0d, 0.000222582d },
            { 1742000.0d, 0.00022348d },
            { 1761000.0d, 0.000224338d },
            { 1780000.0d, 0.000225154d },
            { 1799000.0d, 0.00022593d },
            { 1818000.0d, 0.000226664d },
            { 1837000.0d, 0.000227358d },
            { 1856000.0d, 0.000228012d },
            { 1875000.0d, 0.000228626d },
            { 1894000.0d, 0.000229199d },
            { 1913000.0d, 0.000229734d },
            { 1932000.0d, 0.000230227d },
            { 1951000.0d, 0.000230682d },
            { 1970000.0d, 0.000231096d },
            { 1989000.0d, 0.000231473d },
            { 2008000.0d, 0.00023181d },
            { 2027000.0d, 0.000232108d },
            { 2046000.0d, 0.000232367d },
            { 2065000.0d, 0.000232588d },
            { 2084000.0d, 0.000232771d },
            { 2103000.0d, 0.000232916d },
            { 2122000.0d, 0.000233023d },
            { 2141000.0d, 0.000233093d },
            { 2160000.0d, 0.000233124d },
            { 2179000.0d, 0.000233119d },
            { 2198000.0d, 0.000233077d },
            { 2217000.0d, 0.000232998d },
            { 2236000.0d, 0.000232882d },
            { 2255000.0d, 0.00023273d },
            { 2274000.0d, 0.000232542d },
            { 2293000.0d, 0.000232318d },
            { 2312000.0d, 0.000232059d },
            { 2331000.0d, 0.000231764d },
            { 2350000.0d, 0.000231434d },
            { 2369000.0d, 0.000231069d },
            { 2388000.0d, 0.000230669d },
            { 2407000.0d, 0.000230236d },
            { 2426000.0d, 0.000229767d },
            { 2445000.0d, 0.000229265d },
            { 2464000.0d, 0.00022873d },
            { 2483000.0d, 0.000228161d },
            { 2502000.0d, 0.000227559d },
            { 2521000.0d, 0.000226924d },
            { 2540000.0d, 0.000226256d },
            { 2559000.0d, 0.000225557d },
            { 2578000.0d, 0.000224825d },
            { 2597000.0d, 0.000224061d },
            { 2616000.0d, 0.000223267d },
            { 2635000.0d, 0.000222441d },
            { 2654000.0d, 0.000221584d },
            { 2673000.0d, 0.000220697d },
            { 2692000.0d, 0.00021978d },
            { 2711000.0d, 0.000218832d },
            { 2730000.0d, 0.000217855d },
            { 2749000.0d, 0.000216849d },
            { 2768000.0d, 0.000215814d },
            { 2787000.0d, 0.000214749d },
            { 2806000.0d, 0.000213657d },
            { 2825000.0d, 0.000212537d },
            { 2844000.0d, 0.000211389d },
            { 2863000.0d, 0.000210214d },
            { 2882000.0d, 0.000209012d },
            { 2901000.0d, 0.000207783d },
            { 2920000.0d, 0.000206528d },
            { 2939000.0d, 0.000205247d },
            { 2958000.0d, 0.00020394d },
            { 2977000.0d, 0.000202608d },
            { 2996000.0d, 0.000201252d },
            { 3015000.0d, 0.00019987d },
            { 3034000.0d, 0.000198465d },
            { 3053000.0d, 0.000197037d },
            { 3072000.0d, 0.000195584d },
            { 3091000.0d, 0.000194109d },
            { 3110000.0d, 0.000192612d },
            { 3129000.0d, 0.000191092d },
            { 3148000.0d, 0.00018955d },
            { 3167000.0d, 0.000187987d },
            { 3186000.0d, 0.000186403d },
            { 3205000.0d, 0.000184799d },
            { 3224000.0d, 0.000183175d },
            { 3243000.0d, 0.000181531d },
            { 3262000.0d, 0.000179868d },
            { 3281000.0d, 0.000178186d },
            { 3300000.0d, 0.000176486d },
            { 3319000.0d, 0.000174768d },
            { 3338000.0d, 0.000173033d },
            { 3357000.0d, 0.000171281d },
            { 3376000.0d, 0.000169513d },
            { 3395000.0d, 0.000167728d },
            { 3414000.0d, 0.000165928d },
            { 3433000.0d, 0.000164114d },
            { 3452000.0d, 0.000162284d },
            { 3471000.0d, 0.000160441d },
            { 3490000.0d, 0.000158585d },
            { 3509000.0d, 0.000156716d },
            { 3528000.0d, 0.000154835d },
            { 3547000.0d, 0.000152941d },
            { 3566000.0d, 0.000151036d },
            { 3585000.0d, 0.000149121d },
            { 3604000.0d, 0.000147195d },
            { 3623000.0d, 0.00014526d },
            { 3642000.0d, 0.000143316d },
            { 3661000.0d, 0.000141363d },
            { 3680000.0d, 0.000139403d },
            { 3699000.0d, 0.000137435d },
            { 3718000.0d, 0.000135461d },
            { 3737000.0d, 0.000133481d },
            { 3756000.0d, 0.000131495d },
            { 3775000.0d, 0.000129505d },
            { 3794000.0d, 0.000127511d },
            { 3813000.0d, 0.000125513d },
            { 3832000.0d, 0.000123513d },
            { 3851000.0d, 0.00012151d },
            { 3870000.0d, 0.000119506d },
            { 3889000.0d, 0.000117501d },
            { 3908000.0d, 0.000115496d },
            { 3927000.0d, 0.000113492d },
            { 3946000.0d, 0.00011149d },
            { 3965000.0d, 0.000109489d },
            { 3984000.0d, 0.000107491d },
            { 4003000.0d, 0.000105497d },
            { 4022000.0d, 0.000103507d },
            { 4041000.0d, 0.00010152d },
            { 4060000.0d, 0.0000995376d },
            { 4079000.0d, 0.0000975604d },
            { 4098000.0d, 0.0000955891d },
            { 4117000.0d, 0.0000936245d },
            { 4136000.0d, 0.0000916672d },
            { 4155000.0d, 0.000089718d },
            { 4174000.0d, 0.0000877777d },
            { 4193000.0d, 0.0000858471d },
            { 4212000.0d, 0.0000839268d },
            { 4231000.0d, 0.0000820181d },
            { 4250000.0d, 0.0000801213d },
            { 4269000.0d, 0.0000782374d },
            { 4288000.0d, 0.0000763673d },
            { 4307000.0d, 0.0000745116d },
            { 4326000.0d, 0.0000726713d },
            { 4345000.0d, 0.0000708463d },
            { 4364000.0d, 0.0000690371d },
            { 4383000.0d, 0.0000672447d },
            { 4402000.0d, 0.0000654698d },
            { 4421000.0d, 0.0000637129d },
            { 4440000.0d, 0.0000619717d },
            { 4459000.0d, 0.0000602453d },
            { 4478000.0d, 0.0000585346d },
            { 4497000.0d, 0.0000568403d },
            { 4516000.0d, 0.0000551633d },
            { 4535000.0d, 0.0000535045d },
            { 4554000.0d, 0.0000518646d },
            { 4573000.0d, 0.0000502445d },
            { 4592000.0d, 0.0000486452d },
            { 4611000.0d, 0.0000470675d },
            { 4630000.0d, 0.0000455125d },
            { 4649000.0d, 0.0000439807d },
            { 4668000.0d, 0.0000424734d },
            { 4687000.0d, 0.0000409914d },
            { 4706000.0d, 0.0000395356d },
            { 4725000.0d, 0.0000381068d },
            { 4744000.0d, 0.0000367058d },
            { 4763000.0d, 0.0000353338d },
            { 4782000.0d, 0.0000339917d },
            { 4801000.0d, 0.0000326805d },
            { 4820000.0d, 0.0000314011d },
            { 4839000.0d, 0.0000301546d },
            { 4858000.0d, 0.0000289419d },
            { 4877000.0d, 0.000027764d },
            { 4896000.0d, 0.0000266157d },
            { 4915000.0d, 0.0000254921d },
            { 4934000.0d, 0.0000243937d },
            { 4953000.0d, 0.0000233178d },
            { 4972000.0d, 0.0000222602d },
            { 4991000.0d, 0.0000212217d },
            { 5010000.0d, 0.0000202026d },
            { 5029000.0d, 0.0000192038d },
            { 5048000.0d, 0.0000182257d },
            { 5067000.0d, 0.0000172688d },
            { 5086000.0d, 0.000016334d },
            { 5105000.0d, 0.0000154216d },
            { 5124000.0d, 0.0000145324d },
            { 5143000.0d, 0.000013667d },
            { 5162000.0d, 0.000012826d },
            { 5181000.0d, 0.00001201d },
            { 5200000.0d, 0.0000112196d },
            { 5219000.0d, 0.0000104555d },
            { 5238000.0d, 0.00000971842d },
            { 5257000.0d, 0.0000090089d },
            { 5276000.0d, 0.00000832764d },
            { 5295000.0d, 0.00000767529d },
            { 5314000.0d, 0.00000705253d },
            { 5333000.0d, 0.00000646001d },
            { 5352000.0d, 0.00000589844d },
            { 5371000.0d, 0.00000536848d },
            { 5390000.0d, 0.00000487082d },
            { 5409000.0d, 0.00000440614d },
            { 5428000.0d, 0.00000397514d },
            { 5447000.0d, 0.00000357851d },
            { 5466000.0d, 0.00000321694d },
            { 5485000.0d, 0.00000289111d },
            { 5504000.0d, 0.00000260171d },
            { 5523000.0d, 0.00000234938d },
            { 5542000.0d, 0.00000213475d },
            { 5561000.0d, 0.0000019583d },
            { 5580000.0d, 0.00000180319d },
            { 5599000.0d, 0.00000165273d },
            { 5618000.0d, 0.00000150712d },
            { 5637000.0d, 0.0000013666d },
            { 5656000.0d, 0.0000012314d },
            { 5675000.0d, 0.00000110177d },
            { 5694000.0d, 0.000000977943d },
            { 5713000.0d, 0.000000860179d },
            { 5732000.0d, 0.000000748729d },
            { 5751000.0d, 0.000000643855d },
            { 5770000.0d, 0.000000545825d },
            { 5789000.0d, 0.00000045491d },
            { 5808000.0d, 0.000000371388d },
            { 5827000.0d, 0.000000295541d },
            { 5846000.0d, 0.000000227655d },
            { 5865000.0d, 0.000000168023d },
            { 5884000.0d, 0.000000116938d },
            { 5903000.0d, 0.0000000746997d },
            { 5922000.0d, 0.0000000416054d },
            { 5941000.0d, 0.0000000179525d },
            { 5960000.0d, 0.00000000402638d },
            { 5977000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    