using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium81";
        public override double halfLife { get; } = 16459.2d;
        public override double atomicWeight { get; } = 80.91899d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine81()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0006815d, new GammaParticle(49570.0, 0.02501)), new(8.225e-05d, new GammaParticle(59650.0, 0.02079)), new(0.0005639999999999999d, new GammaParticle(63970.0, 0.01938)), new(0.00016215d, new GammaParticle(68790.0, 0.01802)), new(0.00016215d, new GammaParticle(87800.0, 0.01412)), new(0.00154865d, new GammaParticle(180200.0, 0.00688)), new(0.6486d, new GammaParticle(190460.0, 0.00651)), new(0.00018800000000000002d, new GammaParticle(218800.0, 0.00567)), new(0.0031255d, new GammaParticle(243870.0, 0.00508)), new(0.00037600000000000003d, new GammaParticle(266200.0, 0.00466)), new(0.0004465d, new GammaParticle(283100.0, 0.00438)), new(0.0004465d, new GammaParticle(319090.0, 0.00389)), new(0.0005874999999999999d, new GammaParticle(339640.0, 0.00365)), new(0.007661d, new GammaParticle(357390.0, 0.00347)), new(0.000846d, new GammaParticle(386090.0, 0.00321)), new(0.004606d, new GammaParticle(388850.0, 0.00319)), new(0.0002585d, new GammaParticle(399700.0, 0.0031)), new(0.00016215d, new GammaParticle(443000.0, 0.0028)), new(0.235d, new GammaParticle(446150.0, 0.00278)), new(0.03055d, new GammaParticle(456730.0, 0.00271)), new(0.0052875000000000005d, new GammaParticle(476690.0, 0.0026)), new(0.0011985d, new GammaParticle(499440.0, 0.00248)), new(0.05405d, new GammaParticle(510430.0, 0.00243)), new(0.0024205d, new GammaParticle(532300.0, 0.00233)), new(0.022559999999999997d, new GammaParticle(537600.0, 0.00231)), new(0.00188d, new GammaParticle(538190.0, 0.0023)), new(0.0047705d, new GammaParticle(549030.0, 0.00226)), new(0.0058985d, new GammaParticle(568900.0, 0.00218)), new(0.000517d, new GammaParticle(602540.0, 0.00206)), new(0.0026085d, new GammaParticle(608460.0, 0.00204)), new(0.002162d, new GammaParticle(682300.0, 0.00182)), new(0.0003055d, new GammaParticle(689900.0, 0.0018)), new(0.00016215d, new GammaParticle(698900.0, 0.00177)), new(0.0005405d, new GammaParticle(701530.0, 0.00177)), new(0.0005405d, new GammaParticle(701530.0, 0.00177)), new(0.0029844999999999997d, new GammaParticle(729090.0, 0.0017)), new(0.000517d, new GammaParticle(758250.0, 0.00164)), new(0.00014099999999999998d, new GammaParticle(782500.0, 0.00158)), new(0.0084365d, new GammaParticle(803720.0, 0.00154)), new(0.0015745000000000002d, new GammaParticle(822800.0, 0.00151)), new(0.008225d, new GammaParticle(834740.0, 0.00149)), new(4.7000000000000004e-05d, new GammaParticle(903200.0, 0.00137)), new(4.7000000000000004e-05d, new GammaParticle(912500.0, 0.00136)), new(2.3500000000000002e-05d, new GammaParticle(968400.0, 0.00128)), new(0.005710499999999999d, new GammaParticle(977150.0, 0.00127)), new(0.00016215d, new GammaParticle(993690.0, 0.00125)), new(8.225e-05d, new GammaParticle(1025080.0, 0.00121)), new(0.005405d, new GammaParticle(1041240.0, 0.00119)), new(0.00047d, new GammaParticle(1047940.0, 0.00118)), new(0.000611d, new GammaParticle(1069420.0, 0.00116)), new(7.049999999999999e-05d, new GammaParticle(1087700.0, 0.00114)), new(0.0001175d, new GammaParticle(1090200.0, 0.00114)), new(0.0011279999999999999d, new GammaParticle(1100300.0, 0.00113)), new(0.000517d, new GammaParticle(1107960.0, 0.00112)), new(0.0001175d, new GammaParticle(1136400.0, 0.00109)), new(4.7000000000000004e-05d, new GammaParticle(1363800.0, 0.00091)), new(0.008695000000000001d, new GammaParticle(1368100.0, 0.00091)), new(9.400000000000001e-05d, new GammaParticle(1381500.0, 0.0009)), new(0.000329d, new GammaParticle(1427850.0, 0.00087)), new(9.400000000000001e-05d, new GammaParticle(1487070.0, 0.00083)), new(4.7000000000000004e-05d, new GammaParticle(1536000.0, 0.00081)), new(0.000423d, new GammaParticle(1554600.0, 0.0008)), new(0.00014099999999999998d, new GammaParticle(1874000.0, 0.00066)), new(0.5451148d, new GammaParticle(511000.0, 0.00243)), new(0.024700000000000003d, new GammaParticle(1648.0, 0.75233)), new(0.17d, new GammaParticle(12596.0, 0.09843)), new(0.32799999999999996d, new GammaParticle(12649.0, 0.09802)), new(0.0786d, new GammaParticle(14169.0, 0.0875)), new(0.08650000000000001d, new GammaParticle(14209.0, 0.08726)), new(0.0079d, new GammaParticle(14313.0, 0.08662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 300.0d, 0.000000000435546d },
            { 600.0d, 0.00000000163731d },
            { 900.0d, 0.00000000361874d },
            { 1200.0d, 0.00000000723542d },
            { 1700.0d, 0.0000000335473d },
            { 2200.0d, 0.0000000741638d },
            { 2700.0d, 0.00000012998d },
            { 3200.0d, 0.000000200989d },
            { 3700.0d, 0.000000287951d },
            { 4200.0d, 0.000000390863d },
            { 4700.0d, 0.000000510339d },
            { 5200.0d, 0.000000646333d },
            { 5700.0d, 0.000000799285d },
            { 6200.0d, 0.000000975117d },
            { 6700.0d, 0.00000118037d },
            { 7200.0d, 0.00000140746d },
            { 7700.0d, 0.00000165659d },
            { 8200.0d, 0.00000192772d },
            { 8700.0d, 0.00000222099d },
            { 9200.0d, 0.00000253799d },
            { 9700.0d, 0.0000028805d },
            { 10000.0d, 0.00000309723d },
            { 11000.0d, 0.00000388021d },
            { 12000.0d, 0.00000475603d },
            { 13000.0d, 0.00000571967d },
            { 14000.0d, 0.00000677265d },
            { 15000.0d, 0.00000791415d },
            { 16000.0d, 0.00000913202d },
            { 17000.0d, 0.000010431d },
            { 18000.0d, 0.0000118101d },
            { 19000.0d, 0.0000132547d },
            { 20000.0d, 0.0000147709d },
            { 21000.0d, 0.0000163576d },
            { 22000.0d, 0.0000179998d },
            { 23000.0d, 0.0000197039d },
            { 24000.0d, 0.000021469d },
            { 25000.0d, 0.000023281d },
            { 26000.0d, 0.0000251458d },
            { 27000.0d, 0.0000270626d },
            { 28000.0d, 0.0000290187d },
            { 29000.0d, 0.0000310193d },
            { 30000.0d, 0.0000330639d },
            { 31000.0d, 0.0000351411d },
            { 32000.0d, 0.0000372558d },
            { 33000.0d, 0.0000394072d },
            { 34000.0d, 0.0000415856d },
            { 35000.0d, 0.000043795d },
            { 36000.0d, 0.000046035d },
            { 37000.0d, 0.000048297d },
            { 38000.0d, 0.0000505845d },
            { 39000.0d, 0.0000528971d },
            { 40000.0d, 0.0000552275d },
            { 41000.0d, 0.0000575787d },
            { 42000.0d, 0.0000599503d },
            { 43000.0d, 0.0000623359d },
            { 44000.0d, 0.0000647381d },
            { 45000.0d, 0.0000671568d },
            { 46000.0d, 0.0000695862d },
            { 47000.0d, 0.0000720287d },
            { 48000.0d, 0.0000744842d },
            { 49000.0d, 0.0000769475d },
            { 50000.0d, 0.0000794209d },
            { 51000.0d, 0.0000819042d },
            { 52000.0d, 0.0000843931d },
            { 53000.0d, 0.0000868893d },
            { 54000.0d, 0.0000893927d },
            { 55000.0d, 0.0000918996d },
            { 56000.0d, 0.0000944117d },
            { 57000.0d, 0.0000969285d },
            { 58000.0d, 0.0000994471d },
            { 59000.0d, 0.000101969d },
            { 60000.0d, 0.000104493d },
            { 61000.0d, 0.000107018d },
            { 62000.0d, 0.000109544d },
            { 63000.0d, 0.000112071d },
            { 64000.0d, 0.000114597d },
            { 65000.0d, 0.000117122d },
            { 66000.0d, 0.000119647d },
            { 67000.0d, 0.00012217d },
            { 68000.0d, 0.000124691d },
            { 69000.0d, 0.000127211d },
            { 70000.0d, 0.000129727d },
            { 71000.0d, 0.00013224d },
            { 72000.0d, 0.00013475d },
            { 73000.0d, 0.000137257d },
            { 74000.0d, 0.000139759d },
            { 75000.0d, 0.000142258d },
            { 76000.0d, 0.000144751d },
            { 77000.0d, 0.00014724d },
            { 78000.0d, 0.000149725d },
            { 79000.0d, 0.000152203d },
            { 80000.0d, 0.000154675d },
            { 81000.0d, 0.000157142d },
            { 82000.0d, 0.000159603d },
            { 83000.0d, 0.000162057d },
            { 84000.0d, 0.000164506d },
            { 85000.0d, 0.000166947d },
            { 86000.0d, 0.000169382d },
            { 87000.0d, 0.00017181d },
            { 88000.0d, 0.000174231d },
            { 89000.0d, 0.000176644d },
            { 90000.0d, 0.00017905d },
            { 91000.0d, 0.000181448d },
            { 92000.0d, 0.000183839d },
            { 93000.0d, 0.000186221d },
            { 94000.0d, 0.000188596d },
            { 95000.0d, 0.000190962d },
            { 96000.0d, 0.00019332d },
            { 97000.0d, 0.000195669d },
            { 98000.0d, 0.00019801d },
            { 99000.0d, 0.000200343d },
            { 100000.0d, 0.000202666d },
            { 104000.0d, 0.000211873d },
            { 108000.0d, 0.000220934d },
            { 112000.0d, 0.000229845d },
            { 116000.0d, 0.000238601d },
            { 120000.0d, 0.000247199d },
            { 124000.0d, 0.000255639d },
            { 128000.0d, 0.000263917d },
            { 132000.0d, 0.000272033d },
            { 136000.0d, 0.000279984d },
            { 140000.0d, 0.00028777d },
            { 144000.0d, 0.000295391d },
            { 148000.0d, 0.000302847d },
            { 152000.0d, 0.000310136d },
            { 156000.0d, 0.000317261d },
            { 160000.0d, 0.00032422d },
            { 164000.0d, 0.000331015d },
            { 168000.0d, 0.000337645d },
            { 172000.0d, 0.000344113d },
            { 176000.0d, 0.000350418d },
            { 180000.0d, 0.000356562d },
            { 184000.0d, 0.000362545d },
            { 188000.0d, 0.000368368d },
            { 192000.0d, 0.000374034d },
            { 196000.0d, 0.00037954d },
            { 200000.0d, 0.000384888d },
            { 204000.0d, 0.000390079d },
            { 208000.0d, 0.000395114d },
            { 212000.0d, 0.000399995d },
            { 216000.0d, 0.000404721d },
            { 220000.0d, 0.000409296d },
            { 224000.0d, 0.000413719d },
            { 228000.0d, 0.00041799d },
            { 232000.0d, 0.000422106d },
            { 236000.0d, 0.000426071d },
            { 240000.0d, 0.000429886d },
            { 244000.0d, 0.000433549d },
            { 248000.0d, 0.000437065d },
            { 252000.0d, 0.000440434d },
            { 256000.0d, 0.000443655d },
            { 260000.0d, 0.000446733d },
            { 264000.0d, 0.000449666d },
            { 268000.0d, 0.000452457d },
            { 272000.0d, 0.000455106d },
            { 276000.0d, 0.000457617d },
            { 280000.0d, 0.000459988d },
            { 284000.0d, 0.000462222d },
            { 288000.0d, 0.000464321d },
            { 292000.0d, 0.000466285d },
            { 296000.0d, 0.000468117d },
            { 300000.0d, 0.000469817d },
            { 304000.0d, 0.000471386d },
            { 308000.0d, 0.000472826d },
            { 312000.0d, 0.00047414d },
            { 316000.0d, 0.000475326d },
            { 320000.0d, 0.000476389d },
            { 324000.0d, 0.000477328d },
            { 328000.0d, 0.000478146d },
            { 332000.0d, 0.000478843d },
            { 336000.0d, 0.000479422d },
            { 340000.0d, 0.000479885d },
            { 344000.0d, 0.000480231d },
            { 348000.0d, 0.000480465d },
            { 352000.0d, 0.000480586d },
            { 356000.0d, 0.000480597d },
            { 360000.0d, 0.000480499d },
            { 364000.0d, 0.000480295d },
            { 368000.0d, 0.000479985d },
            { 372000.0d, 0.000479572d },
            { 376000.0d, 0.000479056d },
            { 380000.0d, 0.00047844d },
            { 384000.0d, 0.000477727d },
            { 388000.0d, 0.000476916d },
            { 392000.0d, 0.000476011d },
            { 396000.0d, 0.000475013d },
            { 400000.0d, 0.000473924d },
            { 404000.0d, 0.000472746d },
            { 408000.0d, 0.000471481d },
            { 412000.0d, 0.000470129d },
            { 416000.0d, 0.000468695d },
            { 420000.0d, 0.000467179d },
            { 424000.0d, 0.000465584d },
            { 428000.0d, 0.000463911d },
            { 432000.0d, 0.000462162d },
            { 436000.0d, 0.000460339d },
            { 440000.0d, 0.000458446d },
            { 444000.0d, 0.000456482d },
            { 448000.0d, 0.000454452d },
            { 452000.0d, 0.000452356d },
            { 456000.0d, 0.000450197d },
            { 460000.0d, 0.000447976d },
            { 464000.0d, 0.000445697d },
            { 468000.0d, 0.000443362d },
            { 472000.0d, 0.00044097d },
            { 476000.0d, 0.000438527d },
            { 480000.0d, 0.000436035d },
            { 484000.0d, 0.000433494d },
            { 488000.0d, 0.000430907d },
            { 492000.0d, 0.000428277d },
            { 496000.0d, 0.000425605d },
            { 500000.0d, 0.000422895d },
            { 504000.0d, 0.000420148d },
            { 508000.0d, 0.000417369d },
            { 512000.0d, 0.000414556d },
            { 516000.0d, 0.000411715d },
            { 520000.0d, 0.000408841d },
            { 524000.0d, 0.000405932d },
            { 528000.0d, 0.00040299d },
            { 532000.0d, 0.000400016d },
            { 536000.0d, 0.000397014d },
            { 540000.0d, 0.000393985d },
            { 544000.0d, 0.000390931d },
            { 548000.0d, 0.000387855d },
            { 552000.0d, 0.000384758d },
            { 556000.0d, 0.000381645d },
            { 560000.0d, 0.000378515d },
            { 564000.0d, 0.000375372d },
            { 568000.0d, 0.000372219d },
            { 572000.0d, 0.000369056d },
            { 576000.0d, 0.000365887d },
            { 580000.0d, 0.000362713d },
            { 584000.0d, 0.000359514d },
            { 588000.0d, 0.000356264d },
            { 592000.0d, 0.000352968d },
            { 596000.0d, 0.000349624d },
            { 600000.0d, 0.000346235d },
            { 604000.0d, 0.0003428d },
            { 608000.0d, 0.000339321d },
            { 612000.0d, 0.0003358d },
            { 616000.0d, 0.000332237d },
            { 620000.0d, 0.000328633d },
            { 624000.0d, 0.00032499d },
            { 628000.0d, 0.000321308d },
            { 632000.0d, 0.00031759d },
            { 636000.0d, 0.000313834d },
            { 640000.0d, 0.000310044d },
            { 644000.0d, 0.00030622d },
            { 648000.0d, 0.000302364d },
            { 652000.0d, 0.000298476d },
            { 656000.0d, 0.000294558d },
            { 660000.0d, 0.000290612d },
            { 664000.0d, 0.000286637d },
            { 668000.0d, 0.000282636d },
            { 672000.0d, 0.00027861d },
            { 676000.0d, 0.000274561d },
            { 680000.0d, 0.000270488d },
            { 684000.0d, 0.000266394d },
            { 688000.0d, 0.000262281d },
            { 692000.0d, 0.000258149d },
            { 696000.0d, 0.000253998d },
            { 700000.0d, 0.000249833d },
            { 704000.0d, 0.000245652d },
            { 708000.0d, 0.000241458d },
            { 712000.0d, 0.000237251d },
            { 716000.0d, 0.000233035d },
            { 720000.0d, 0.000228808d },
            { 724000.0d, 0.000224575d },
            { 728000.0d, 0.000220334d },
            { 732000.0d, 0.000216089d },
            { 736000.0d, 0.000211839d },
            { 740000.0d, 0.000207588d },
            { 744000.0d, 0.000203335d },
            { 748000.0d, 0.000199084d },
            { 752000.0d, 0.000194835d },
            { 756000.0d, 0.000190589d },
            { 760000.0d, 0.000186348d },
            { 764000.0d, 0.000182114d },
            { 768000.0d, 0.000177888d },
            { 772000.0d, 0.000173671d },
            { 776000.0d, 0.000169466d },
            { 780000.0d, 0.000165273d },
            { 784000.0d, 0.000161095d },
            { 788000.0d, 0.000156932d },
            { 792000.0d, 0.000152786d },
            { 796000.0d, 0.00014866d },
            { 800000.0d, 0.000144553d },
            { 804000.0d, 0.000140469d },
            { 808000.0d, 0.000136409d },
            { 812000.0d, 0.000132373d },
            { 816000.0d, 0.000128365d },
            { 820000.0d, 0.000124385d },
            { 824000.0d, 0.000120435d },
            { 828000.0d, 0.000116517d },
            { 832000.0d, 0.000112633d },
            { 836000.0d, 0.000108783d },
            { 840000.0d, 0.00010497d },
            { 844000.0d, 0.000101197d },
            { 848000.0d, 0.0000974629d },
            { 852000.0d, 0.000093771d },
            { 856000.0d, 0.0000901227d },
            { 860000.0d, 0.0000865198d },
            { 864000.0d, 0.000082964d },
            { 868000.0d, 0.0000794571d },
            { 872000.0d, 0.0000760008d },
            { 876000.0d, 0.0000725967d },
            { 880000.0d, 0.000069247d },
            { 884000.0d, 0.0000659533d },
            { 888000.0d, 0.0000627171d },
            { 892000.0d, 0.0000595406d },
            { 896000.0d, 0.0000564255d },
            { 900000.0d, 0.0000533736d },
            { 904000.0d, 0.0000503868d },
            { 908000.0d, 0.0000474668d },
            { 912000.0d, 0.0000446155d },
            { 916000.0d, 0.0000418349d },
            { 920000.0d, 0.0000391268d },
            { 924000.0d, 0.000036493d },
            { 928000.0d, 0.0000339355d },
            { 932000.0d, 0.0000314562d },
            { 936000.0d, 0.0000290568d },
            { 940000.0d, 0.0000267396d },
            { 944000.0d, 0.0000245063d },
            { 948000.0d, 0.0000223588d },
            { 952000.0d, 0.000020299d },
            { 956000.0d, 0.0000183292d },
            { 960000.0d, 0.0000164509d },
            { 964000.0d, 0.0000146663d },
            { 968000.0d, 0.0000129775d },
            { 972000.0d, 0.0000113862d },
            { 976000.0d, 0.00000989457d },
            { 980000.0d, 0.0000085046d },
            { 984000.0d, 0.00000721821d },
            { 988000.0d, 0.00000603757d },
            { 992000.0d, 0.00000496455d },
            { 996000.0d, 0.00000400114d },
            { 1000000.0d, 0.00000314952d },
            { 1004000.0d, 0.00000241157d },
            { 1008000.0d, 0.00000178927d },
            { 1012000.0d, 0.00000128479d },
            { 1016000.0d, 0.000000899984d },
            { 1020000.0d, 0.000000636757d },
            { 1024000.0d, 0.000000497089d },
            { 1028000.0d, 0.000000466581d },
            { 1032000.0d, 0.000000451761d },
            { 1036000.0d, 0.000000436997d },
            { 1040000.0d, 0.000000422297d },
            { 1044000.0d, 0.000000407669d },
            { 1048000.0d, 0.00000039312d },
            { 1052000.0d, 0.000000378661d },
            { 1056000.0d, 0.000000364299d },
            { 1060000.0d, 0.000000350045d },
            { 1064000.0d, 0.000000335906d },
            { 1068000.0d, 0.000000321892d },
            { 1072000.0d, 0.000000308014d },
            { 1076000.0d, 0.000000294281d },
            { 1080000.0d, 0.000000280703d },
            { 1084000.0d, 0.000000267291d },
            { 1088000.0d, 0.000000254055d },
            { 1092000.0d, 0.000000241005d },
            { 1096000.0d, 0.000000228155d },
            { 1100000.0d, 0.000000215513d },
            { 1104000.0d, 0.000000203092d },
            { 1108000.0d, 0.000000190905d },
            { 1112000.0d, 0.000000178962d },
            { 1116000.0d, 0.000000167276d },
            { 1120000.0d, 0.00000015586d },
            { 1124000.0d, 0.000000144726d },
            { 1128000.0d, 0.000000133888d },
            { 1132000.0d, 0.000000123359d },
            { 1136000.0d, 0.000000113152d },
            { 1140000.0d, 0.000000103281d },
            { 1144000.0d, 0.0000000937613d },
            { 1148000.0d, 0.0000000846059d },
            { 1152000.0d, 0.0000000758299d },
            { 1156000.0d, 0.0000000674483d },
            { 1160000.0d, 0.0000000594762d },
            { 1164000.0d, 0.0000000519292d },
            { 1168000.0d, 0.0000000448229d },
            { 1172000.0d, 0.0000000381734d },
            { 1176000.0d, 0.0000000319969d },
            { 1180000.0d, 0.0000000263101d },
            { 1184000.0d, 0.0000000211298d },
            { 1188000.0d, 0.0000000164731d },
            { 1192000.0d, 0.0000000123574d },
            { 1196000.0d, 0.00000000880014d },
            { 1200000.0d, 0.00000000581932d },
            { 1204000.0d, 0.0000000034329d },
            { 1208000.0d, 0.00000000165901d },
            { 1212000.0d, 0.000000000515742d },
            { 1216000.0d, 0.0000000000206781d },
            { 1217000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    