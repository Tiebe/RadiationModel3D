using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold201 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold201";
        public override double halfLife { get; } = 1560.0d;
        public override double atomicWeight { get; } = 200.97166d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury201()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(3.6e-07d, new GammaParticle(5895.0, 0.21032)), new(0.00126d, new GammaParticle(30600.0, 0.04052)), new(0.00135d, new GammaParticle(32190.0, 0.03852)), new(0.0025d, new GammaParticle(135340.0, 0.00916)), new(2.55e-06d, new GammaParticle(141100.0, 0.00879)), new(0.000142d, new GammaParticle(165880.0, 0.00747)), new(0.0096d, new GammaParticle(167430.0, 0.00741)), new(0.0034999999999999996d, new GammaParticle(352420.0, 0.00352)), new(0.0019d, new GammaParticle(358360.0, 0.00346)), new(0.0027d, new GammaParticle(384600.0, 0.00322)), new(0.0034999999999999996d, new GammaParticle(385100.0, 0.00322)), new(0.00017999999999999998d, new GammaParticle(432320.0, 0.00287)), new(0.0031d, new GammaParticle(438110.0, 0.00283)), new(0.00098d, new GammaParticle(464390.0, 0.00267)), new(0.0126d, new GammaParticle(517000.0, 0.0024)), new(0.009300000000000001d, new GammaParticle(521000.0, 0.00238)), new(0.0078000000000000005d, new GammaParticle(526900.0, 0.00235)), new(0.0182d, new GammaParticle(542600.0, 0.00229)), new(0.008d, new GammaParticle(552800.0, 0.00224)), new(0.0116d, new GammaParticle(613200.0, 0.00202)), new(0.0064d, new GammaParticle(645000.0, 0.00192)), new(0.0042d, new GammaParticle(732300.0, 0.00169)), new(0.040066932676985495d, new GammaParticle(11777.0, 0.10528)), new(0.00751929417096443d, new GammaParticle(68894.0, 0.018)), new(0.01274672685364372d, new GammaParticle(70820.0, 0.01751)), new(0.004325925601540487d, new GammaParticle(80316.0, 0.01544)), new(0.005593421802791849d, new GammaParticle(81285.0, 0.01525)), new(0.0012674962012513627d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00119612d },
            { 1000.0d, 0.00120318d },
            { 2000.0d, 0.00120921d },
            { 3000.0d, 0.00121423d },
            { 4000.0d, 0.00121855d },
            { 5000.0d, 0.00122223d },
            { 6000.0d, 0.00122526d },
            { 7000.0d, 0.00122819d },
            { 8000.0d, 0.00123083d },
            { 9000.0d, 0.00123325d },
            { 10000.0d, 0.00123546d },
            { 11000.0d, 0.00123747d },
            { 12000.0d, 0.00123927d },
            { 13000.0d, 0.00124117d },
            { 14000.0d, 0.00124298d },
            { 15000.0d, 0.00124471d },
            { 16000.0d, 0.00124637d },
            { 17000.0d, 0.00124803d },
            { 18000.0d, 0.00124965d },
            { 19000.0d, 0.00125123d },
            { 20000.0d, 0.00125277d },
            { 21000.0d, 0.0012543d },
            { 22000.0d, 0.0012558d },
            { 23000.0d, 0.00125728d },
            { 24000.0d, 0.00125873d },
            { 25000.0d, 0.00126018d },
            { 26000.0d, 0.0012616d },
            { 27000.0d, 0.00126301d },
            { 28000.0d, 0.0012644d },
            { 29000.0d, 0.00126578d },
            { 30000.0d, 0.00126714d },
            { 31000.0d, 0.00126849d },
            { 32000.0d, 0.00126982d },
            { 33000.0d, 0.00127115d },
            { 34000.0d, 0.00127246d },
            { 35000.0d, 0.00127376d },
            { 36000.0d, 0.00127505d },
            { 37000.0d, 0.00127632d },
            { 38000.0d, 0.00127759d },
            { 39000.0d, 0.00127884d },
            { 40000.0d, 0.00128008d },
            { 41000.0d, 0.00128132d },
            { 42000.0d, 0.00128254d },
            { 43000.0d, 0.00128375d },
            { 44000.0d, 0.00128495d },
            { 45000.0d, 0.00128615d },
            { 46000.0d, 0.00128733d },
            { 47000.0d, 0.0012885d },
            { 48000.0d, 0.00128966d },
            { 49000.0d, 0.00129082d },
            { 50000.0d, 0.00129196d },
            { 51000.0d, 0.00129309d },
            { 52000.0d, 0.00129422d },
            { 53000.0d, 0.00129533d },
            { 54000.0d, 0.00129644d },
            { 55000.0d, 0.00129754d },
            { 56000.0d, 0.00129863d },
            { 57000.0d, 0.00129971d },
            { 58000.0d, 0.00130078d },
            { 59000.0d, 0.00130184d },
            { 60000.0d, 0.0013029d },
            { 61000.0d, 0.00130394d },
            { 62000.0d, 0.00130498d },
            { 63000.0d, 0.00130601d },
            { 64000.0d, 0.00130702d },
            { 65000.0d, 0.00130804d },
            { 66000.0d, 0.00130904d },
            { 67000.0d, 0.00131003d },
            { 68000.0d, 0.00131102d },
            { 69000.0d, 0.001312d },
            { 70000.0d, 0.00131297d },
            { 71000.0d, 0.00131393d },
            { 72000.0d, 0.00131488d },
            { 73000.0d, 0.00131583d },
            { 74000.0d, 0.00131676d },
            { 75000.0d, 0.00131769d },
            { 76000.0d, 0.00131861d },
            { 77000.0d, 0.00131953d },
            { 78000.0d, 0.00132043d },
            { 79000.0d, 0.00132133d },
            { 80000.0d, 0.00132222d },
            { 81000.0d, 0.0013231d },
            { 82000.0d, 0.00132397d },
            { 83000.0d, 0.00132484d },
            { 84000.0d, 0.0013257d },
            { 85000.0d, 0.00132655d },
            { 86000.0d, 0.00132739d },
            { 87000.0d, 0.00132823d },
            { 88000.0d, 0.00132905d },
            { 89000.0d, 0.00132987d },
            { 90000.0d, 0.00133068d },
            { 91000.0d, 0.00133149d },
            { 92000.0d, 0.00133228d },
            { 93000.0d, 0.00133307d },
            { 94000.0d, 0.00133385d },
            { 95000.0d, 0.00133463d },
            { 96000.0d, 0.00133539d },
            { 97000.0d, 0.00133615d },
            { 98000.0d, 0.0013369d },
            { 99000.0d, 0.00133764d },
            { 100000.0d, 0.00133838d },
            { 104000.0d, 0.00134125d },
            { 108000.0d, 0.00134399d },
            { 112000.0d, 0.00134662d },
            { 116000.0d, 0.00134913d },
            { 120000.0d, 0.00135152d },
            { 124000.0d, 0.00135379d },
            { 128000.0d, 0.00135595d },
            { 132000.0d, 0.00135799d },
            { 136000.0d, 0.00135991d },
            { 140000.0d, 0.00136171d },
            { 144000.0d, 0.00136339d },
            { 148000.0d, 0.00136497d },
            { 152000.0d, 0.00136642d },
            { 156000.0d, 0.00136776d },
            { 160000.0d, 0.00136898d },
            { 164000.0d, 0.00137008d },
            { 168000.0d, 0.00137107d },
            { 172000.0d, 0.00137195d },
            { 176000.0d, 0.00137271d },
            { 180000.0d, 0.00137335d },
            { 184000.0d, 0.00137388d },
            { 188000.0d, 0.0013743d },
            { 192000.0d, 0.00137461d },
            { 196000.0d, 0.0013748d },
            { 200000.0d, 0.00137487d },
            { 204000.0d, 0.00137483d },
            { 208000.0d, 0.00137467d },
            { 212000.0d, 0.00137442d },
            { 216000.0d, 0.00137404d },
            { 220000.0d, 0.00137355d },
            { 224000.0d, 0.00137295d },
            { 228000.0d, 0.00137224d },
            { 232000.0d, 0.00137142d },
            { 236000.0d, 0.00137049d },
            { 240000.0d, 0.00136945d },
            { 244000.0d, 0.0013683d },
            { 248000.0d, 0.00136704d },
            { 252000.0d, 0.00136568d },
            { 256000.0d, 0.00136421d },
            { 260000.0d, 0.00136263d },
            { 264000.0d, 0.00136094d },
            { 268000.0d, 0.00135914d },
            { 272000.0d, 0.00135725d },
            { 276000.0d, 0.00135525d },
            { 280000.0d, 0.00135314d },
            { 284000.0d, 0.00135093d },
            { 288000.0d, 0.00134862d },
            { 292000.0d, 0.00134621d },
            { 296000.0d, 0.00134369d },
            { 300000.0d, 0.00134107d },
            { 304000.0d, 0.00133837d },
            { 308000.0d, 0.00133554d },
            { 312000.0d, 0.00133264d },
            { 316000.0d, 0.00132963d },
            { 320000.0d, 0.00132652d },
            { 324000.0d, 0.00132332d },
            { 328000.0d, 0.00132002d },
            { 332000.0d, 0.00131663d },
            { 336000.0d, 0.00131314d },
            { 340000.0d, 0.00130957d },
            { 344000.0d, 0.0013059d },
            { 348000.0d, 0.00130214d },
            { 352000.0d, 0.00129829d },
            { 356000.0d, 0.00129435d },
            { 360000.0d, 0.00129033d },
            { 364000.0d, 0.00128622d },
            { 368000.0d, 0.00128202d },
            { 372000.0d, 0.00127774d },
            { 376000.0d, 0.00127337d },
            { 380000.0d, 0.00126893d },
            { 384000.0d, 0.0012644d },
            { 388000.0d, 0.00125979d },
            { 392000.0d, 0.0012551d },
            { 396000.0d, 0.00125033d },
            { 400000.0d, 0.00124548d },
            { 404000.0d, 0.00124056d },
            { 408000.0d, 0.00123556d },
            { 412000.0d, 0.00123049d },
            { 416000.0d, 0.00122535d },
            { 420000.0d, 0.00122013d },
            { 424000.0d, 0.00121485d },
            { 428000.0d, 0.00120949d },
            { 432000.0d, 0.00120407d },
            { 436000.0d, 0.00119858d },
            { 440000.0d, 0.00119302d },
            { 444000.0d, 0.0011874d },
            { 448000.0d, 0.00118172d },
            { 452000.0d, 0.00117597d },
            { 456000.0d, 0.00117017d },
            { 460000.0d, 0.0011643d },
            { 464000.0d, 0.00115838d },
            { 468000.0d, 0.0011524d },
            { 472000.0d, 0.00114637d },
            { 476000.0d, 0.00114028d },
            { 480000.0d, 0.00113414d },
            { 484000.0d, 0.00112795d },
            { 488000.0d, 0.0011217d },
            { 492000.0d, 0.00111541d },
            { 496000.0d, 0.00110908d },
            { 500000.0d, 0.00110269d },
            { 504000.0d, 0.00109627d },
            { 508000.0d, 0.0010898d },
            { 512000.0d, 0.00108329d },
            { 516000.0d, 0.00107673d },
            { 520000.0d, 0.00107015d },
            { 524000.0d, 0.00106352d },
            { 528000.0d, 0.00105686d },
            { 532000.0d, 0.00105016d },
            { 536000.0d, 0.00104343d },
            { 540000.0d, 0.00103666d },
            { 544000.0d, 0.00102985d },
            { 548000.0d, 0.00102301d },
            { 552000.0d, 0.00101613d },
            { 556000.0d, 0.00100923d },
            { 560000.0d, 0.0010023d },
            { 564000.0d, 0.000995334d },
            { 568000.0d, 0.000988345d },
            { 572000.0d, 0.000981331d },
            { 576000.0d, 0.000974294d },
            { 580000.0d, 0.000967234d },
            { 584000.0d, 0.000960154d },
            { 588000.0d, 0.000953055d },
            { 592000.0d, 0.000945938d },
            { 596000.0d, 0.000938806d },
            { 600000.0d, 0.000931659d },
            { 604000.0d, 0.000924499d },
            { 608000.0d, 0.000917328d },
            { 612000.0d, 0.000910148d },
            { 616000.0d, 0.000902959d },
            { 620000.0d, 0.00089576d },
            { 624000.0d, 0.000888544d },
            { 628000.0d, 0.000881314d },
            { 632000.0d, 0.00087407d },
            { 636000.0d, 0.000866815d },
            { 640000.0d, 0.000859549d },
            { 644000.0d, 0.000852274d },
            { 648000.0d, 0.000844991d },
            { 652000.0d, 0.000837702d },
            { 656000.0d, 0.000830409d },
            { 660000.0d, 0.000823113d },
            { 664000.0d, 0.000815815d },
            { 668000.0d, 0.000808518d },
            { 672000.0d, 0.000801221d },
            { 676000.0d, 0.000793928d },
            { 680000.0d, 0.00078664d },
            { 684000.0d, 0.000779357d },
            { 688000.0d, 0.000772083d },
            { 692000.0d, 0.000764819d },
            { 696000.0d, 0.000757564d },
            { 700000.0d, 0.000750322d },
            { 704000.0d, 0.000743095d },
            { 708000.0d, 0.000735883d },
            { 712000.0d, 0.000728682d },
            { 716000.0d, 0.000721483d },
            { 720000.0d, 0.000714283d },
            { 724000.0d, 0.000707069d },
            { 728000.0d, 0.000699838d },
            { 732000.0d, 0.000692591d },
            { 736000.0d, 0.000685327d },
            { 740000.0d, 0.000678048d },
            { 744000.0d, 0.000670754d },
            { 748000.0d, 0.000663449d },
            { 752000.0d, 0.00065613d },
            { 756000.0d, 0.000648803d },
            { 760000.0d, 0.000641465d },
            { 764000.0d, 0.000634118d },
            { 768000.0d, 0.000626764d },
            { 772000.0d, 0.000619403d },
            { 776000.0d, 0.000612037d },
            { 780000.0d, 0.000604666d },
            { 784000.0d, 0.000597294d },
            { 788000.0d, 0.000589918d },
            { 792000.0d, 0.000582541d },
            { 796000.0d, 0.000575165d },
            { 800000.0d, 0.000567789d },
            { 804000.0d, 0.000560414d },
            { 808000.0d, 0.000553041d },
            { 812000.0d, 0.000545669d },
            { 816000.0d, 0.000538301d },
            { 820000.0d, 0.000530937d },
            { 824000.0d, 0.000523579d },
            { 828000.0d, 0.000516228d },
            { 832000.0d, 0.000508885d },
            { 836000.0d, 0.000501552d },
            { 840000.0d, 0.000494228d },
            { 844000.0d, 0.000486915d },
            { 848000.0d, 0.000479615d },
            { 852000.0d, 0.000472329d },
            { 856000.0d, 0.000465058d },
            { 860000.0d, 0.000457802d },
            { 864000.0d, 0.000450564d },
            { 868000.0d, 0.000443343d },
            { 872000.0d, 0.000436143d },
            { 876000.0d, 0.000428963d },
            { 880000.0d, 0.000421805d },
            { 884000.0d, 0.000414665d },
            { 888000.0d, 0.000407546d },
            { 892000.0d, 0.000400449d },
            { 896000.0d, 0.000393375d },
            { 900000.0d, 0.000386325d },
            { 904000.0d, 0.0003793d },
            { 908000.0d, 0.000372301d },
            { 912000.0d, 0.000365331d },
            { 916000.0d, 0.000358388d },
            { 920000.0d, 0.000351475d },
            { 924000.0d, 0.000344594d },
            { 928000.0d, 0.000337744d },
            { 932000.0d, 0.000330928d },
            { 936000.0d, 0.000324147d },
            { 940000.0d, 0.000317402d },
            { 944000.0d, 0.000310694d },
            { 948000.0d, 0.000304024d },
            { 952000.0d, 0.000297393d },
            { 956000.0d, 0.000290804d },
            { 960000.0d, 0.000284256d },
            { 964000.0d, 0.000277752d },
            { 968000.0d, 0.000271291d },
            { 972000.0d, 0.000264877d },
            { 976000.0d, 0.00025851d },
            { 980000.0d, 0.000252191d },
            { 984000.0d, 0.000245921d },
            { 988000.0d, 0.000239701d },
            { 992000.0d, 0.000233534d },
            { 996000.0d, 0.000227419d },
            { 1000000.0d, 0.00022136d },
            { 1004000.0d, 0.000215356d },
            { 1008000.0d, 0.00020941d },
            { 1012000.0d, 0.000203521d },
            { 1016000.0d, 0.000197692d },
            { 1020000.0d, 0.000191924d },
            { 1024000.0d, 0.000186218d },
            { 1028000.0d, 0.000180575d },
            { 1032000.0d, 0.000174998d },
            { 1036000.0d, 0.000169486d },
            { 1040000.0d, 0.000164042d },
            { 1044000.0d, 0.000158667d },
            { 1048000.0d, 0.000153361d },
            { 1052000.0d, 0.000148126d },
            { 1056000.0d, 0.000142965d },
            { 1060000.0d, 0.000137877d },
            { 1064000.0d, 0.000132865d },
            { 1068000.0d, 0.000127929d },
            { 1072000.0d, 0.000123072d },
            { 1076000.0d, 0.000118293d },
            { 1080000.0d, 0.000113595d },
            { 1084000.0d, 0.00010898d },
            { 1088000.0d, 0.000104447d },
            { 1092000.0d, 0.0000999987d },
            { 1096000.0d, 0.0000956361d },
            { 1100000.0d, 0.0000913548d },
            { 1104000.0d, 0.0000871545d },
            { 1108000.0d, 0.0000830365d },
            { 1112000.0d, 0.000079002d },
            { 1116000.0d, 0.0000750523d },
            { 1120000.0d, 0.0000711887d },
            { 1124000.0d, 0.0000674126d },
            { 1128000.0d, 0.0000637252d },
            { 1132000.0d, 0.0000601278d },
            { 1136000.0d, 0.0000566217d },
            { 1140000.0d, 0.0000532082d },
            { 1144000.0d, 0.0000498886d },
            { 1148000.0d, 0.0000466642d },
            { 1152000.0d, 0.0000435364d },
            { 1156000.0d, 0.0000405063d },
            { 1160000.0d, 0.0000375755d },
            { 1164000.0d, 0.0000347451d },
            { 1168000.0d, 0.0000320165d },
            { 1172000.0d, 0.0000293911d },
            { 1176000.0d, 0.00002687d },
            { 1180000.0d, 0.0000244547d },
            { 1184000.0d, 0.0000221465d },
            { 1188000.0d, 0.0000199467d },
            { 1192000.0d, 0.0000178566d },
            { 1196000.0d, 0.0000158776d },
            { 1200000.0d, 0.0000140109d },
            { 1204000.0d, 0.000012258d },
            { 1208000.0d, 0.0000106202d },
            { 1212000.0d, 0.00000909866d },
            { 1216000.0d, 0.00000769485d },
            { 1220000.0d, 0.00000641004d },
            { 1224000.0d, 0.00000524557d },
            { 1228000.0d, 0.00000420269d },
            { 1232000.0d, 0.00000328074d },
            { 1236000.0d, 0.0000024713d },
            { 1240000.0d, 0.00000177428d },
            { 1244000.0d, 0.00000119081d },
            { 1248000.0d, 0.000000722046d },
            { 1252000.0d, 0.000000369094d },
            { 1256000.0d, 0.000000133014d },
            { 1260000.0d, 0.0000000147525d },
            { 1262000.0d, 0d },

        }; 
    }
}
    