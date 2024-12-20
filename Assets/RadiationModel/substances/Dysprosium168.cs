using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium168";
        public override double halfLife { get; } = 522.0d;
        public override double atomicWeight { get; } = 167.93713d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium168()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.044000000000000004d, new GammaParticle(43800.0, 0.02831)), new(0.065d, new GammaParticle(143500.0, 0.00864)), new(0.32799999999999996d, new GammaParticle(192500.0, 0.00644)), new(0.085d, new GammaParticle(437000.0, 0.00284)), new(0.155d, new GammaParticle(443300.0, 0.0028)), new(0.225d, new GammaParticle(487000.0, 0.00255)), new(0.136d, new GammaParticle(630400.0, 0.00197)), new(0.12177304602016d, new GammaParticle(7656.0, 0.16194)), new(0.10482343231980992d, new GammaParticle(46700.0, 0.02655)), new(0.18668465239503104d, new GammaParticle(47547.0, 0.02608)), new(0.06031441086123733d, new GammaParticle(53982.0, 0.02297)), new(0.07599615768515905d, new GammaParticle(54577.0, 0.02272)), new(0.015681746823921705d, new GammaParticle(55293.0, 0.02242)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00150175d },
            { 2000.0d, 0.00150139d },
            { 4000.0d, 0.00150403d },
            { 6000.0d, 0.00150967d },
            { 8000.0d, 0.00151474d },
            { 10000.0d, 0.00151923d },
            { 12000.0d, 0.00152327d },
            { 14000.0d, 0.00152707d },
            { 16000.0d, 0.00153066d },
            { 18000.0d, 0.00153413d },
            { 20000.0d, 0.00153748d },
            { 22000.0d, 0.00154074d },
            { 24000.0d, 0.00154392d },
            { 26000.0d, 0.00154701d },
            { 28000.0d, 0.00155004d },
            { 30000.0d, 0.00155301d },
            { 32000.0d, 0.0015559d },
            { 34000.0d, 0.00155874d },
            { 36000.0d, 0.00156152d },
            { 38000.0d, 0.00156425d },
            { 40000.0d, 0.00156693d },
            { 42000.0d, 0.00156956d },
            { 44000.0d, 0.00157213d },
            { 46000.0d, 0.00157466d },
            { 48000.0d, 0.00157714d },
            { 50000.0d, 0.00157957d },
            { 52000.0d, 0.00158196d },
            { 54000.0d, 0.00158432d },
            { 56000.0d, 0.00158662d },
            { 58000.0d, 0.00158888d },
            { 60000.0d, 0.0015911d },
            { 62000.0d, 0.00159329d },
            { 64000.0d, 0.00159542d },
            { 66000.0d, 0.00159752d },
            { 68000.0d, 0.00159959d },
            { 70000.0d, 0.0016016d },
            { 72000.0d, 0.00160358d },
            { 74000.0d, 0.00160552d },
            { 76000.0d, 0.00160743d },
            { 78000.0d, 0.00160929d },
            { 80000.0d, 0.0016111d },
            { 82000.0d, 0.00161289d },
            { 84000.0d, 0.00161463d },
            { 86000.0d, 0.00161634d },
            { 88000.0d, 0.00161801d },
            { 90000.0d, 0.00161963d },
            { 92000.0d, 0.00162121d },
            { 94000.0d, 0.00162276d },
            { 96000.0d, 0.00162428d },
            { 98000.0d, 0.00162574d },
            { 100000.0d, 0.00162717d },
            { 104000.0d, 0.00162992d },
            { 108000.0d, 0.0016325d },
            { 112000.0d, 0.00163491d },
            { 116000.0d, 0.00163718d },
            { 120000.0d, 0.00163927d },
            { 124000.0d, 0.00164121d },
            { 128000.0d, 0.00164298d },
            { 132000.0d, 0.00164459d },
            { 136000.0d, 0.00164604d },
            { 140000.0d, 0.00164731d },
            { 144000.0d, 0.00164843d },
            { 148000.0d, 0.00164936d },
            { 152000.0d, 0.00165014d },
            { 156000.0d, 0.00165076d },
            { 160000.0d, 0.0016512d },
            { 164000.0d, 0.00165147d },
            { 168000.0d, 0.00165157d },
            { 172000.0d, 0.00165151d },
            { 176000.0d, 0.00165127d },
            { 180000.0d, 0.00165086d },
            { 184000.0d, 0.00165029d },
            { 188000.0d, 0.00164955d },
            { 192000.0d, 0.00164863d },
            { 196000.0d, 0.00164755d },
            { 200000.0d, 0.00164629d },
            { 204000.0d, 0.00164487d },
            { 208000.0d, 0.00164327d },
            { 212000.0d, 0.00164151d },
            { 216000.0d, 0.00163957d },
            { 220000.0d, 0.00163748d },
            { 224000.0d, 0.0016352d },
            { 228000.0d, 0.00163277d },
            { 232000.0d, 0.00163016d },
            { 236000.0d, 0.0016274d },
            { 240000.0d, 0.00162446d },
            { 244000.0d, 0.00162135d },
            { 248000.0d, 0.00161808d },
            { 252000.0d, 0.00161464d },
            { 256000.0d, 0.00161104d },
            { 260000.0d, 0.00160728d },
            { 264000.0d, 0.00160335d },
            { 268000.0d, 0.00159927d },
            { 272000.0d, 0.00159503d },
            { 276000.0d, 0.00159062d },
            { 280000.0d, 0.00158605d },
            { 284000.0d, 0.00158132d },
            { 288000.0d, 0.00157644d },
            { 292000.0d, 0.0015714d },
            { 296000.0d, 0.00156621d },
            { 300000.0d, 0.00156086d },
            { 304000.0d, 0.00155535d },
            { 308000.0d, 0.00154971d },
            { 312000.0d, 0.0015439d },
            { 316000.0d, 0.00153795d },
            { 320000.0d, 0.00153184d },
            { 324000.0d, 0.0015256d },
            { 328000.0d, 0.00151921d },
            { 332000.0d, 0.00151267d },
            { 336000.0d, 0.00150599d },
            { 340000.0d, 0.00149917d },
            { 344000.0d, 0.0014922d },
            { 348000.0d, 0.00148511d },
            { 352000.0d, 0.00147787d },
            { 356000.0d, 0.00147049d },
            { 360000.0d, 0.00146299d },
            { 364000.0d, 0.00145535d },
            { 368000.0d, 0.00144758d },
            { 372000.0d, 0.00143968d },
            { 376000.0d, 0.00143165d },
            { 380000.0d, 0.0014235d },
            { 384000.0d, 0.00141522d },
            { 388000.0d, 0.00140682d },
            { 392000.0d, 0.0013983d },
            { 396000.0d, 0.00138966d },
            { 400000.0d, 0.0013809d },
            { 404000.0d, 0.00137203d },
            { 408000.0d, 0.00136305d },
            { 412000.0d, 0.00135395d },
            { 416000.0d, 0.00134474d },
            { 420000.0d, 0.00133543d },
            { 424000.0d, 0.00132601d },
            { 428000.0d, 0.00131649d },
            { 432000.0d, 0.00130687d },
            { 436000.0d, 0.00129714d },
            { 440000.0d, 0.00128732d },
            { 444000.0d, 0.00127741d },
            { 448000.0d, 0.0012674d },
            { 452000.0d, 0.0012573d },
            { 456000.0d, 0.00124711d },
            { 460000.0d, 0.00123684d },
            { 464000.0d, 0.00122648d },
            { 468000.0d, 0.00121604d },
            { 472000.0d, 0.00120551d },
            { 476000.0d, 0.00119492d },
            { 480000.0d, 0.00118424d },
            { 484000.0d, 0.0011735d },
            { 488000.0d, 0.00116268d },
            { 492000.0d, 0.0011518d },
            { 496000.0d, 0.00114085d },
            { 500000.0d, 0.00112983d },
            { 504000.0d, 0.00111876d },
            { 508000.0d, 0.00110763d },
            { 512000.0d, 0.00109644d },
            { 516000.0d, 0.0010852d },
            { 520000.0d, 0.00107391d },
            { 524000.0d, 0.00106257d },
            { 528000.0d, 0.00105119d },
            { 532000.0d, 0.00103976d },
            { 536000.0d, 0.00102829d },
            { 540000.0d, 0.00101679d },
            { 544000.0d, 0.00100525d },
            { 548000.0d, 0.000993677d },
            { 552000.0d, 0.000982078d },
            { 556000.0d, 0.00097045d },
            { 560000.0d, 0.000958802d },
            { 564000.0d, 0.000947131d },
            { 568000.0d, 0.000935443d },
            { 572000.0d, 0.000923739d },
            { 576000.0d, 0.000912023d },
            { 580000.0d, 0.000900299d },
            { 584000.0d, 0.000888568d },
            { 588000.0d, 0.000876832d },
            { 592000.0d, 0.000865098d },
            { 596000.0d, 0.000853365d },
            { 600000.0d, 0.000841638d },
            { 604000.0d, 0.000829919d },
            { 608000.0d, 0.000818213d },
            { 612000.0d, 0.000806521d },
            { 616000.0d, 0.000794845d },
            { 620000.0d, 0.000783192d },
            { 624000.0d, 0.000771563d },
            { 628000.0d, 0.000759962d },
            { 632000.0d, 0.000748388d },
            { 636000.0d, 0.000736851d },
            { 640000.0d, 0.000725349d },
            { 644000.0d, 0.000713887d },
            { 648000.0d, 0.00070247d },
            { 652000.0d, 0.000691098d },
            { 656000.0d, 0.000679777d },
            { 660000.0d, 0.000668508d },
            { 664000.0d, 0.000657296d },
            { 668000.0d, 0.000646144d },
            { 672000.0d, 0.000635055d },
            { 676000.0d, 0.000624033d },
            { 680000.0d, 0.000613082d },
            { 684000.0d, 0.000602203d },
            { 688000.0d, 0.000591402d },
            { 692000.0d, 0.00058068d },
            { 696000.0d, 0.000570043d },
            { 700000.0d, 0.000559494d },
            { 704000.0d, 0.000549035d },
            { 708000.0d, 0.000538672d },
            { 712000.0d, 0.000528405d },
            { 716000.0d, 0.00051824d },
            { 720000.0d, 0.000508182d },
            { 724000.0d, 0.000498231d },
            { 728000.0d, 0.000488394d },
            { 732000.0d, 0.000478673d },
            { 736000.0d, 0.000469072d },
            { 740000.0d, 0.000459595d },
            { 744000.0d, 0.000450244d },
            { 748000.0d, 0.000441025d },
            { 752000.0d, 0.000431942d },
            { 756000.0d, 0.000422997d },
            { 760000.0d, 0.000414194d },
            { 764000.0d, 0.000405537d },
            { 768000.0d, 0.00039703d },
            { 772000.0d, 0.000388678d },
            { 776000.0d, 0.000380483d },
            { 780000.0d, 0.00037245d },
            { 784000.0d, 0.000364582d },
            { 788000.0d, 0.000356884d },
            { 792000.0d, 0.000349359d },
            { 796000.0d, 0.000342012d },
            { 800000.0d, 0.000334845d },
            { 804000.0d, 0.000327864d },
            { 808000.0d, 0.000321073d },
            { 812000.0d, 0.000314475d },
            { 816000.0d, 0.000308073d },
            { 820000.0d, 0.000301873d },
            { 824000.0d, 0.000295878d },
            { 828000.0d, 0.000290093d },
            { 832000.0d, 0.000284522d },
            { 836000.0d, 0.000279168d },
            { 840000.0d, 0.000274034d },
            { 844000.0d, 0.000269127d },
            { 848000.0d, 0.00026445d },
            { 852000.0d, 0.000260007d },
            { 856000.0d, 0.0002558d },
            { 860000.0d, 0.000251837d },
            { 864000.0d, 0.000248119d },
            { 868000.0d, 0.000244649d },
            { 872000.0d, 0.000241401d },
            { 876000.0d, 0.000238183d },
            { 880000.0d, 0.000234965d },
            { 884000.0d, 0.000231747d },
            { 888000.0d, 0.000228528d },
            { 892000.0d, 0.000225311d },
            { 896000.0d, 0.000222095d },
            { 900000.0d, 0.000218881d },
            { 904000.0d, 0.000215669d },
            { 908000.0d, 0.000212459d },
            { 912000.0d, 0.000209253d },
            { 916000.0d, 0.000206051d },
            { 920000.0d, 0.000202852d },
            { 924000.0d, 0.000199659d },
            { 928000.0d, 0.000196471d },
            { 932000.0d, 0.000193289d },
            { 936000.0d, 0.000190112d },
            { 940000.0d, 0.000186943d },
            { 944000.0d, 0.000183782d },
            { 948000.0d, 0.000180627d },
            { 952000.0d, 0.000177481d },
            { 956000.0d, 0.000174343d },
            { 960000.0d, 0.000171216d },
            { 964000.0d, 0.000168098d },
            { 968000.0d, 0.00016499d },
            { 972000.0d, 0.000161893d },
            { 976000.0d, 0.000158807d },
            { 980000.0d, 0.000155735d },
            { 984000.0d, 0.000152674d },
            { 988000.0d, 0.000149626d },
            { 992000.0d, 0.000146592d },
            { 996000.0d, 0.000143571d },
            { 1000000.0d, 0.000140566d },
            { 1004000.0d, 0.000137577d },
            { 1008000.0d, 0.000134602d },
            { 1012000.0d, 0.000131644d },
            { 1016000.0d, 0.000128703d },
            { 1020000.0d, 0.00012578d },
            { 1024000.0d, 0.000122874d },
            { 1028000.0d, 0.000119987d },
            { 1032000.0d, 0.000117119d },
            { 1036000.0d, 0.000114271d },
            { 1040000.0d, 0.000111443d },
            { 1044000.0d, 0.000108636d },
            { 1048000.0d, 0.000105851d },
            { 1052000.0d, 0.000103087d },
            { 1056000.0d, 0.000100346d },
            { 1060000.0d, 0.0000976287d },
            { 1064000.0d, 0.0000949348d },
            { 1068000.0d, 0.0000922651d },
            { 1072000.0d, 0.0000896204d },
            { 1076000.0d, 0.0000870012d },
            { 1080000.0d, 0.0000844082d },
            { 1084000.0d, 0.0000818417d },
            { 1088000.0d, 0.0000793026d },
            { 1092000.0d, 0.0000767915d },
            { 1096000.0d, 0.0000743088d },
            { 1100000.0d, 0.0000718552d },
            { 1104000.0d, 0.0000694313d },
            { 1108000.0d, 0.0000670377d },
            { 1112000.0d, 0.0000646752d },
            { 1116000.0d, 0.000062344d },
            { 1120000.0d, 0.0000600451d },
            { 1124000.0d, 0.000057779d },
            { 1128000.0d, 0.0000555462d },
            { 1132000.0d, 0.0000533474d },
            { 1136000.0d, 0.0000511832d },
            { 1140000.0d, 0.0000490544d },
            { 1144000.0d, 0.0000469613d },
            { 1148000.0d, 0.0000449049d },
            { 1152000.0d, 0.0000428854d },
            { 1156000.0d, 0.0000409039d },
            { 1160000.0d, 0.0000389607d },
            { 1164000.0d, 0.0000370565d },
            { 1168000.0d, 0.0000351921d },
            { 1172000.0d, 0.0000333679d },
            { 1176000.0d, 0.0000315846d },
            { 1180000.0d, 0.000029843d },
            { 1184000.0d, 0.0000281437d },
            { 1188000.0d, 0.0000264872d },
            { 1192000.0d, 0.0000248743d },
            { 1196000.0d, 0.0000233057d },
            { 1200000.0d, 0.0000217818d },
            { 1204000.0d, 0.0000203034d },
            { 1208000.0d, 0.0000188712d },
            { 1212000.0d, 0.0000174859d },
            { 1216000.0d, 0.0000161479d },
            { 1220000.0d, 0.0000148581d },
            { 1224000.0d, 0.0000136172d },
            { 1228000.0d, 0.0000124256d },
            { 1232000.0d, 0.0000112842d },
            { 1236000.0d, 0.0000101936d },
            { 1240000.0d, 0.00000915442d },
            { 1244000.0d, 0.00000816738d },
            { 1248000.0d, 0.00000723313d },
            { 1252000.0d, 0.00000635234d },
            { 1256000.0d, 0.00000552568d },
            { 1260000.0d, 0.00000475382d },
            { 1264000.0d, 0.00000403743d },
            { 1268000.0d, 0.00000337718d },
            { 1272000.0d, 0.00000277373d },
            { 1276000.0d, 0.00000222777d },
            { 1280000.0d, 0.00000173995d },
            { 1284000.0d, 0.00000131092d },
            { 1288000.0d, 0.000000941361d },
            { 1292000.0d, 0.000000631919d },
            { 1296000.0d, 0.000000383234d },
            { 1300000.0d, 0.000000195935d },
            { 1304000.0d, 0.0000000706217d },
            { 1308000.0d, 0.00000000783328d },
            { 1310000.0d, 0d },

        }; 
    }
}
    