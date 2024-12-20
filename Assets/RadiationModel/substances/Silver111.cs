using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver111 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver111";
        public override double halfLife { get; } = 643680.0d;
        public override double atomicWeight { get; } = 110.9053d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium111()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00115564d, new GammaParticle(96750.0, 0.01281)), new(0.012358000000000001d, new GammaParticle(245400.0, 0.00505)), new(5.344e-06d, new GammaParticle(278300.0, 0.00446)), new(0.0668d, new GammaParticle(342130.0, 0.00362)), new(3.1396e-05d, new GammaParticle(374600.0, 0.00331)), new(1.3359999999999999e-05d, new GammaParticle(509400.0, 0.00243)), new(9.352e-06d, new GammaParticle(522400.0, 0.00237)), new(2.0708e-05d, new GammaParticle(524300.0, 0.00236)), new(5.344e-06d, new GammaParticle(619300.0, 0.002)), new(0.000109552d, new GammaParticle(620300.0, 0.002)), new(6.012e-05d, new GammaParticle(622000.0, 0.00199)), new(2.6719999999999998e-05d, new GammaParticle(754600.0, 0.00164)), new(1.5364e-05d, new GammaParticle(865100.0, 0.00143)), new(3.6072e-05d, new GammaParticle(867000.0, 0.00143)), new(0.00015409054001576194d, new GammaParticle(3388.0, 0.36595)), new(0.0005374020328330236d, new GammaParticle(22983.0, 0.05395)), new(0.0010107241542844153d, new GammaParticle(23173.0, 0.0535)), new(0.0002817275320211177d, new GammaParticle(26184.0, 0.04735)), new(0.0003330019428489611d, new GammaParticle(26381.0, 0.047)), new(5.127441082784342e-05d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00136987d },
            { 500.0d, 0.00137058d },
            { 1000.0d, 0.00137137d },
            { 1500.0d, 0.00137225d },
            { 2000.0d, 0.00137314d },
            { 2500.0d, 0.00137403d },
            { 3000.0d, 0.0013749d },
            { 3500.0d, 0.00137577d },
            { 4000.0d, 0.00137663d },
            { 4500.0d, 0.00137748d },
            { 5000.0d, 0.00137833d },
            { 5500.0d, 0.00137917d },
            { 6000.0d, 0.00138d },
            { 6500.0d, 0.00138083d },
            { 7000.0d, 0.00138166d },
            { 7500.0d, 0.00138248d },
            { 8000.0d, 0.00138329d },
            { 8500.0d, 0.00138411d },
            { 9000.0d, 0.00138492d },
            { 9500.0d, 0.00138573d },
            { 10000.0d, 0.00138654d },
            { 11000.0d, 0.00138815d },
            { 12000.0d, 0.00138975d },
            { 13000.0d, 0.00139134d },
            { 14000.0d, 0.00139292d },
            { 15000.0d, 0.00139449d },
            { 16000.0d, 0.00139606d },
            { 17000.0d, 0.00139763d },
            { 18000.0d, 0.00139918d },
            { 19000.0d, 0.00140074d },
            { 20000.0d, 0.0014023d },
            { 21000.0d, 0.00140385d },
            { 22000.0d, 0.0014054d },
            { 23000.0d, 0.00140695d },
            { 24000.0d, 0.0014085d },
            { 25000.0d, 0.00141004d },
            { 26000.0d, 0.00141158d },
            { 27000.0d, 0.00141313d },
            { 28000.0d, 0.00141467d },
            { 29000.0d, 0.00141621d },
            { 30000.0d, 0.00141776d },
            { 31000.0d, 0.0014193d },
            { 32000.0d, 0.00142084d },
            { 33000.0d, 0.00142238d },
            { 34000.0d, 0.00142391d },
            { 35000.0d, 0.00142545d },
            { 36000.0d, 0.00142699d },
            { 37000.0d, 0.00142853d },
            { 38000.0d, 0.00143006d },
            { 39000.0d, 0.0014316d },
            { 40000.0d, 0.00143313d },
            { 41000.0d, 0.00143466d },
            { 42000.0d, 0.00143619d },
            { 43000.0d, 0.00143772d },
            { 44000.0d, 0.00143925d },
            { 45000.0d, 0.00144077d },
            { 46000.0d, 0.00144229d },
            { 47000.0d, 0.00144382d },
            { 48000.0d, 0.00144534d },
            { 49000.0d, 0.00144686d },
            { 50000.0d, 0.00144837d },
            { 51000.0d, 0.00144988d },
            { 52000.0d, 0.00145139d },
            { 53000.0d, 0.00145289d },
            { 54000.0d, 0.00145439d },
            { 55000.0d, 0.00145589d },
            { 56000.0d, 0.00145738d },
            { 57000.0d, 0.00145887d },
            { 58000.0d, 0.00146035d },
            { 59000.0d, 0.00146184d },
            { 60000.0d, 0.00146332d },
            { 61000.0d, 0.0014648d },
            { 62000.0d, 0.00146626d },
            { 63000.0d, 0.00146773d },
            { 64000.0d, 0.00146919d },
            { 65000.0d, 0.00147064d },
            { 66000.0d, 0.00147209d },
            { 67000.0d, 0.00147354d },
            { 68000.0d, 0.00147497d },
            { 69000.0d, 0.00147641d },
            { 70000.0d, 0.00147784d },
            { 71000.0d, 0.00147926d },
            { 72000.0d, 0.00148068d },
            { 73000.0d, 0.00148209d },
            { 74000.0d, 0.00148349d },
            { 75000.0d, 0.00148489d },
            { 76000.0d, 0.00148628d },
            { 77000.0d, 0.00148767d },
            { 78000.0d, 0.00148905d },
            { 79000.0d, 0.00149042d },
            { 80000.0d, 0.00149179d },
            { 81000.0d, 0.00149315d },
            { 82000.0d, 0.0014945d },
            { 83000.0d, 0.00149585d },
            { 84000.0d, 0.00149718d },
            { 85000.0d, 0.00149852d },
            { 86000.0d, 0.00149984d },
            { 87000.0d, 0.00150116d },
            { 88000.0d, 0.00150247d },
            { 89000.0d, 0.00150377d },
            { 90000.0d, 0.00150507d },
            { 91000.0d, 0.00150635d },
            { 92000.0d, 0.00150763d },
            { 93000.0d, 0.0015089d },
            { 94000.0d, 0.00151017d },
            { 95000.0d, 0.00151143d },
            { 96000.0d, 0.00151268d },
            { 97000.0d, 0.00151392d },
            { 98000.0d, 0.00151515d },
            { 99000.0d, 0.00151637d },
            { 100000.0d, 0.00151758d },
            { 103000.0d, 0.00152119d },
            { 106000.0d, 0.0015247d },
            { 109000.0d, 0.00152814d },
            { 112000.0d, 0.00153151d },
            { 115000.0d, 0.00153478d },
            { 118000.0d, 0.00153798d },
            { 121000.0d, 0.00154109d },
            { 124000.0d, 0.00154412d },
            { 127000.0d, 0.00154707d },
            { 130000.0d, 0.00154992d },
            { 133000.0d, 0.00155269d },
            { 136000.0d, 0.00155538d },
            { 139000.0d, 0.00155797d },
            { 142000.0d, 0.00156048d },
            { 145000.0d, 0.00156289d },
            { 148000.0d, 0.00156521d },
            { 151000.0d, 0.00156744d },
            { 154000.0d, 0.00156958d },
            { 157000.0d, 0.00157163d },
            { 160000.0d, 0.00157358d },
            { 163000.0d, 0.00157544d },
            { 166000.0d, 0.00157721d },
            { 169000.0d, 0.00157889d },
            { 172000.0d, 0.00158046d },
            { 175000.0d, 0.00158194d },
            { 178000.0d, 0.00158333d },
            { 181000.0d, 0.00158461d },
            { 184000.0d, 0.0015858d },
            { 187000.0d, 0.00158688d },
            { 190000.0d, 0.00158787d },
            { 193000.0d, 0.00158877d },
            { 196000.0d, 0.00158955d },
            { 199000.0d, 0.00159024d },
            { 202000.0d, 0.00159083d },
            { 205000.0d, 0.00159132d },
            { 208000.0d, 0.0015917d },
            { 211000.0d, 0.00159199d },
            { 214000.0d, 0.00159218d },
            { 217000.0d, 0.00159227d },
            { 220000.0d, 0.00159225d },
            { 223000.0d, 0.00159214d },
            { 226000.0d, 0.00159193d },
            { 229000.0d, 0.00159162d },
            { 232000.0d, 0.0015912d },
            { 235000.0d, 0.00159069d },
            { 238000.0d, 0.00159007d },
            { 241000.0d, 0.00158936d },
            { 244000.0d, 0.00158855d },
            { 247000.0d, 0.00158763d },
            { 250000.0d, 0.00158663d },
            { 253000.0d, 0.00158551d },
            { 256000.0d, 0.0015843d },
            { 259000.0d, 0.00158299d },
            { 262000.0d, 0.00158158d },
            { 265000.0d, 0.00158007d },
            { 268000.0d, 0.00157847d },
            { 271000.0d, 0.00157676d },
            { 274000.0d, 0.00157496d },
            { 277000.0d, 0.00157306d },
            { 280000.0d, 0.00157107d },
            { 283000.0d, 0.00156898d },
            { 286000.0d, 0.00156679d },
            { 289000.0d, 0.0015645d },
            { 292000.0d, 0.00156211d },
            { 295000.0d, 0.00155963d },
            { 298000.0d, 0.00155706d },
            { 301000.0d, 0.00155439d },
            { 304000.0d, 0.00155162d },
            { 307000.0d, 0.00154877d },
            { 310000.0d, 0.00154582d },
            { 313000.0d, 0.00154277d },
            { 316000.0d, 0.00153963d },
            { 319000.0d, 0.00153639d },
            { 322000.0d, 0.00153307d },
            { 325000.0d, 0.00152965d },
            { 328000.0d, 0.00152615d },
            { 331000.0d, 0.00152255d },
            { 334000.0d, 0.00151886d },
            { 337000.0d, 0.00151507d },
            { 340000.0d, 0.0015112d },
            { 343000.0d, 0.00150725d },
            { 346000.0d, 0.0015032d },
            { 349000.0d, 0.00149906d },
            { 352000.0d, 0.00149484d },
            { 355000.0d, 0.00149053d },
            { 358000.0d, 0.00148614d },
            { 361000.0d, 0.00148166d },
            { 364000.0d, 0.0014771d },
            { 367000.0d, 0.00147244d },
            { 370000.0d, 0.00146771d },
            { 373000.0d, 0.00146289d },
            { 376000.0d, 0.00145799d },
            { 379000.0d, 0.001453d },
            { 382000.0d, 0.00144794d },
            { 385000.0d, 0.0014428d },
            { 388000.0d, 0.00143757d },
            { 391000.0d, 0.00143227d },
            { 394000.0d, 0.00142689d },
            { 397000.0d, 0.00142142d },
            { 400000.0d, 0.00141589d },
            { 403000.0d, 0.00141027d },
            { 406000.0d, 0.00140459d },
            { 409000.0d, 0.00139882d },
            { 412000.0d, 0.00139297d },
            { 415000.0d, 0.00138707d },
            { 418000.0d, 0.00138107d },
            { 421000.0d, 0.00137501d },
            { 424000.0d, 0.00136889d },
            { 427000.0d, 0.00136268d },
            { 430000.0d, 0.00135641d },
            { 433000.0d, 0.00135007d },
            { 436000.0d, 0.00134365d },
            { 439000.0d, 0.00133717d },
            { 442000.0d, 0.00133062d },
            { 445000.0d, 0.00132401d },
            { 448000.0d, 0.00131732d },
            { 451000.0d, 0.00131058d },
            { 454000.0d, 0.00130377d },
            { 457000.0d, 0.0012969d },
            { 460000.0d, 0.00128996d },
            { 463000.0d, 0.00128296d },
            { 466000.0d, 0.0012759d },
            { 469000.0d, 0.00126878d },
            { 472000.0d, 0.00126161d },
            { 475000.0d, 0.00125438d },
            { 478000.0d, 0.00124709d },
            { 481000.0d, 0.00123973d },
            { 484000.0d, 0.00123233d },
            { 487000.0d, 0.00122487d },
            { 490000.0d, 0.00121736d },
            { 493000.0d, 0.0012098d },
            { 496000.0d, 0.00120218d },
            { 499000.0d, 0.00119452d },
            { 502000.0d, 0.00118681d },
            { 505000.0d, 0.00117905d },
            { 508000.0d, 0.00117124d },
            { 511000.0d, 0.00116338d },
            { 514000.0d, 0.00115548d },
            { 517000.0d, 0.00114753d },
            { 520000.0d, 0.00113954d },
            { 523000.0d, 0.00113151d },
            { 526000.0d, 0.00112344d },
            { 529000.0d, 0.00111533d },
            { 532000.0d, 0.00110718d },
            { 535000.0d, 0.00109898d },
            { 538000.0d, 0.00109075d },
            { 541000.0d, 0.00108249d },
            { 544000.0d, 0.00107419d },
            { 547000.0d, 0.00106587d },
            { 550000.0d, 0.0010575d },
            { 553000.0d, 0.00104911d },
            { 556000.0d, 0.00104068d },
            { 559000.0d, 0.00103223d },
            { 562000.0d, 0.00102375d },
            { 565000.0d, 0.00101524d },
            { 568000.0d, 0.0010067d },
            { 571000.0d, 0.000998147d },
            { 574000.0d, 0.000989567d },
            { 577000.0d, 0.000980964d },
            { 580000.0d, 0.000972341d },
            { 583000.0d, 0.000963699d },
            { 586000.0d, 0.000955039d },
            { 589000.0d, 0.000946362d },
            { 592000.0d, 0.000937669d },
            { 595000.0d, 0.000928962d },
            { 598000.0d, 0.000920242d },
            { 601000.0d, 0.000911511d },
            { 604000.0d, 0.000902769d },
            { 607000.0d, 0.000894018d },
            { 610000.0d, 0.000885259d },
            { 613000.0d, 0.000876494d },
            { 616000.0d, 0.000867723d },
            { 619000.0d, 0.000858948d },
            { 622000.0d, 0.000850172d },
            { 625000.0d, 0.000841394d },
            { 628000.0d, 0.000832617d },
            { 631000.0d, 0.000823841d },
            { 634000.0d, 0.000815068d },
            { 637000.0d, 0.0008063d },
            { 640000.0d, 0.000797538d },
            { 643000.0d, 0.000788784d },
            { 646000.0d, 0.000780038d },
            { 649000.0d, 0.000771302d },
            { 652000.0d, 0.000762578d },
            { 655000.0d, 0.000753866d },
            { 658000.0d, 0.00074517d },
            { 661000.0d, 0.00073649d },
            { 664000.0d, 0.000727827d },
            { 667000.0d, 0.000719184d },
            { 670000.0d, 0.000710561d },
            { 673000.0d, 0.00070196d },
            { 676000.0d, 0.000693382d },
            { 679000.0d, 0.00068483d },
            { 682000.0d, 0.000676305d },
            { 685000.0d, 0.000667807d },
            { 688000.0d, 0.00065934d },
            { 691000.0d, 0.000650904d },
            { 694000.0d, 0.000642501d },
            { 697000.0d, 0.000634123d },
            { 700000.0d, 0.00062575d },
            { 703000.0d, 0.000617381d },
            { 706000.0d, 0.000609018d },
            { 709000.0d, 0.000600662d },
            { 712000.0d, 0.000592314d },
            { 715000.0d, 0.000583975d },
            { 718000.0d, 0.000575648d },
            { 721000.0d, 0.000567332d },
            { 724000.0d, 0.000559029d },
            { 727000.0d, 0.00055074d },
            { 730000.0d, 0.000542466d },
            { 733000.0d, 0.000534209d },
            { 736000.0d, 0.00052597d },
            { 739000.0d, 0.000517751d },
            { 742000.0d, 0.000509552d },
            { 745000.0d, 0.000501375d },
            { 748000.0d, 0.000493221d },
            { 751000.0d, 0.000485091d },
            { 754000.0d, 0.000476986d },
            { 757000.0d, 0.00046891d },
            { 760000.0d, 0.000460861d },
            { 763000.0d, 0.000452841d },
            { 766000.0d, 0.000444854d },
            { 769000.0d, 0.000436897d },
            { 772000.0d, 0.000428975d },
            { 775000.0d, 0.000421087d },
            { 778000.0d, 0.000413236d },
            { 781000.0d, 0.000405423d },
            { 784000.0d, 0.000397649d },
            { 787000.0d, 0.000389915d },
            { 790000.0d, 0.000382223d },
            { 793000.0d, 0.000374574d },
            { 796000.0d, 0.000366963d },
            { 799000.0d, 0.000359392d },
            { 802000.0d, 0.000351861d },
            { 805000.0d, 0.000344372d },
            { 808000.0d, 0.000336926d },
            { 811000.0d, 0.000329525d },
            { 814000.0d, 0.000322168d },
            { 817000.0d, 0.00031486d },
            { 820000.0d, 0.000307598d },
            { 823000.0d, 0.000300387d },
            { 826000.0d, 0.000293226d },
            { 829000.0d, 0.000286117d },
            { 832000.0d, 0.000279061d },
            { 835000.0d, 0.000272061d },
            { 838000.0d, 0.000265115d },
            { 841000.0d, 0.000258226d },
            { 844000.0d, 0.000251397d },
            { 847000.0d, 0.000244627d },
            { 850000.0d, 0.000237919d },
            { 853000.0d, 0.000231272d },
            { 856000.0d, 0.000224689d },
            { 859000.0d, 0.000218172d },
            { 862000.0d, 0.000211721d },
            { 865000.0d, 0.000205338d },
            { 868000.0d, 0.000199024d },
            { 871000.0d, 0.00019278d },
            { 874000.0d, 0.000186609d },
            { 877000.0d, 0.00018051d },
            { 880000.0d, 0.000174487d },
            { 883000.0d, 0.000168539d },
            { 886000.0d, 0.000162669d },
            { 889000.0d, 0.000156877d },
            { 892000.0d, 0.000151166d },
            { 895000.0d, 0.000145537d },
            { 898000.0d, 0.00013999d },
            { 901000.0d, 0.000134528d },
            { 904000.0d, 0.000129151d },
            { 907000.0d, 0.000123862d },
            { 910000.0d, 0.000118662d },
            { 913000.0d, 0.000113552d },
            { 916000.0d, 0.000108532d },
            { 919000.0d, 0.000103607d },
            { 922000.0d, 0.0000987762d },
            { 925000.0d, 0.0000940403d },
            { 928000.0d, 0.0000894024d },
            { 931000.0d, 0.0000848633d },
            { 934000.0d, 0.0000804244d },
            { 937000.0d, 0.0000760874d },
            { 940000.0d, 0.0000718536d },
            { 943000.0d, 0.0000677244d },
            { 946000.0d, 0.0000637016d },
            { 949000.0d, 0.0000597865d },
            { 952000.0d, 0.0000559806d },
            { 955000.0d, 0.0000522853d },
            { 958000.0d, 0.0000487024d },
            { 961000.0d, 0.0000452332d },
            { 964000.0d, 0.0000418793d },
            { 967000.0d, 0.0000386422d },
            { 970000.0d, 0.0000355234d },
            { 973000.0d, 0.0000325245d },
            { 976000.0d, 0.000029647d },
            { 979000.0d, 0.0000268923d },
            { 982000.0d, 0.0000242623d },
            { 985000.0d, 0.0000217582d },
            { 988000.0d, 0.0000193818d },
            { 991000.0d, 0.0000171345d },
            { 994000.0d, 0.000015018d },
            { 997000.0d, 0.0000130338d },
            { 1000000.0d, 0.0000111835d },
            { 1003000.0d, 0.00000946872d },
            { 1006000.0d, 0.00000789092d },
            { 1009000.0d, 0.00000645184d },
            { 1012000.0d, 0.00000515303d },
            { 1015000.0d, 0.00000399608d },
            { 1018000.0d, 0.00000298261d },
            { 1021000.0d, 0.00000211423d },
            { 1024000.0d, 0.00000139258d },
            { 1027000.0d, 0.000000819248d },
            { 1030000.0d, 0.000000395887d },
            { 1033000.0d, 0.000000124124d },
            { 1036000.0d, 0.00000000554977d },
            { 1036800.0d, 0d },

        }; 
    }
}
    