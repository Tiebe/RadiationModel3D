using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium236";
        public override double halfLife { get; } = 2250.0d;
        public override double atomicWeight { get; } = 236.04966d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium236()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.042d, new GammaParticle(110800.0, 0.01119)), new(0.0024d, new GammaParticle(112800.0, 0.01099)), new(0.005600000000000001d, new GammaParticle(131600.0, 0.00942)), new(0.0069d, new GammaParticle(196000.0, 0.00633)), new(0.006999999999999999d, new GammaParticle(229500.0, 0.0054)), new(0.0042d, new GammaParticle(308700.0, 0.00402)), new(0.0067d, new GammaParticle(340100.0, 0.00365)), new(0.0017000000000000001d, new GammaParticle(392400.0, 0.00316)), new(0.0013d, new GammaParticle(414800.0, 0.00299)), new(0.0067d, new GammaParticle(434300.0, 0.00285)), new(0.0032d, new GammaParticle(549200.0, 0.00226)), new(0.0013d, new GammaParticle(567100.0, 0.00219)), new(0.002d, new GammaParticle(581100.0, 0.00213)), new(0.0009d, new GammaParticle(586400.0, 0.00211)), new(0.0024d, new GammaParticle(599700.0, 0.00207)), new(0.0072d, new GammaParticle(646600.0, 0.00192)), new(0.004699999999999999d, new GammaParticle(678100.0, 0.00183)), new(0.0021d, new GammaParticle(719900.0, 0.00172)), new(0.01317838876d, new GammaParticle(16228.0, 0.0764)), new(0.007848375602664668d, new GammaParticle(92282.0, 0.01344)), new(0.012630150631903233d, new GammaParticle(95865.0, 0.01293)), new(0.00452699310338469d, new GammaParticle(108373.0, 0.01144)), new(0.006061643765432099d, new GammaParticle(109740.0, 0.0113)), new(0.0015346506620474095d, new GammaParticle(111482.0, 0.01112)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00197325d },
            { 800.0d, 0.00202686d },
            { 1600.0d, 0.00206555d },
            { 2400.0d, 0.00208933d },
            { 3200.0d, 0.00210482d },
            { 4000.0d, 0.00211717d },
            { 4800.0d, 0.002127d },
            { 5600.0d, 0.00213456d },
            { 6400.0d, 0.0021403d },
            { 7200.0d, 0.00214454d },
            { 8000.0d, 0.00214716d },
            { 8800.0d, 0.00214827d },
            { 9600.0d, 0.00214983d },
            { 10000.0d, 0.00215074d },
            { 11000.0d, 0.00215266d },
            { 12000.0d, 0.00215406d },
            { 13000.0d, 0.00215551d },
            { 14000.0d, 0.00215674d },
            { 15000.0d, 0.00215775d },
            { 16000.0d, 0.0021587d },
            { 17000.0d, 0.00215953d },
            { 18000.0d, 0.00216023d },
            { 19000.0d, 0.00216088d },
            { 20000.0d, 0.00216145d },
            { 21000.0d, 0.00216194d },
            { 22000.0d, 0.00216238d },
            { 23000.0d, 0.00216277d },
            { 24000.0d, 0.00216309d },
            { 25000.0d, 0.00216338d },
            { 26000.0d, 0.00216361d },
            { 27000.0d, 0.0021638d },
            { 28000.0d, 0.00216396d },
            { 29000.0d, 0.00216409d },
            { 30000.0d, 0.00216417d },
            { 31000.0d, 0.00216423d },
            { 32000.0d, 0.00216425d },
            { 33000.0d, 0.00216424d },
            { 34000.0d, 0.0021642d },
            { 35000.0d, 0.00216414d },
            { 36000.0d, 0.00216405d },
            { 37000.0d, 0.00216393d },
            { 38000.0d, 0.00216379d },
            { 39000.0d, 0.00216362d },
            { 40000.0d, 0.00216343d },
            { 41000.0d, 0.00216322d },
            { 42000.0d, 0.00216298d },
            { 43000.0d, 0.00216272d },
            { 44000.0d, 0.00216244d },
            { 45000.0d, 0.00216214d },
            { 46000.0d, 0.00216182d },
            { 47000.0d, 0.00216147d },
            { 48000.0d, 0.00216111d },
            { 49000.0d, 0.00216072d },
            { 50000.0d, 0.00216031d },
            { 51000.0d, 0.00215989d },
            { 52000.0d, 0.00215944d },
            { 53000.0d, 0.00215898d },
            { 54000.0d, 0.0021585d },
            { 55000.0d, 0.002158d },
            { 56000.0d, 0.00215748d },
            { 57000.0d, 0.00215694d },
            { 58000.0d, 0.00215639d },
            { 59000.0d, 0.00215581d },
            { 60000.0d, 0.00215522d },
            { 61000.0d, 0.00215462d },
            { 62000.0d, 0.00215399d },
            { 63000.0d, 0.00215334d },
            { 64000.0d, 0.00215268d },
            { 65000.0d, 0.002152d },
            { 66000.0d, 0.0021513d },
            { 67000.0d, 0.00215059d },
            { 68000.0d, 0.00214987d },
            { 69000.0d, 0.00214913d },
            { 70000.0d, 0.00214836d },
            { 71000.0d, 0.00214759d },
            { 72000.0d, 0.00214679d },
            { 73000.0d, 0.00214598d },
            { 74000.0d, 0.00214515d },
            { 75000.0d, 0.00214431d },
            { 76000.0d, 0.00214346d },
            { 77000.0d, 0.00214259d },
            { 78000.0d, 0.0021417d },
            { 79000.0d, 0.0021408d },
            { 80000.0d, 0.00213988d },
            { 81000.0d, 0.00213895d },
            { 82000.0d, 0.002138d },
            { 83000.0d, 0.00213704d },
            { 84000.0d, 0.00213606d },
            { 85000.0d, 0.00213507d },
            { 86000.0d, 0.00213406d },
            { 87000.0d, 0.00213304d },
            { 88000.0d, 0.002132d },
            { 89000.0d, 0.00213095d },
            { 90000.0d, 0.00212989d },
            { 91000.0d, 0.00212881d },
            { 92000.0d, 0.00212773d },
            { 93000.0d, 0.00212662d },
            { 94000.0d, 0.00212551d },
            { 95000.0d, 0.00212437d },
            { 96000.0d, 0.00212322d },
            { 97000.0d, 0.00212206d },
            { 98000.0d, 0.00212089d },
            { 99000.0d, 0.0021197d },
            { 100000.0d, 0.0021185d },
            { 103000.0d, 0.00211482d },
            { 106000.0d, 0.00211103d },
            { 109000.0d, 0.00210712d },
            { 112000.0d, 0.00210309d },
            { 115000.0d, 0.00209896d },
            { 118000.0d, 0.00209472d },
            { 121000.0d, 0.00209038d },
            { 124000.0d, 0.00208593d },
            { 127000.0d, 0.00208138d },
            { 130000.0d, 0.00207674d },
            { 133000.0d, 0.00207199d },
            { 136000.0d, 0.00206715d },
            { 139000.0d, 0.00206223d },
            { 142000.0d, 0.0020572d },
            { 145000.0d, 0.00205209d },
            { 148000.0d, 0.00204689d },
            { 151000.0d, 0.00204161d },
            { 154000.0d, 0.00203624d },
            { 157000.0d, 0.00203079d },
            { 160000.0d, 0.00202527d },
            { 163000.0d, 0.00201968d },
            { 166000.0d, 0.002014d },
            { 169000.0d, 0.00200825d },
            { 172000.0d, 0.00200244d },
            { 175000.0d, 0.00199655d },
            { 178000.0d, 0.00199061d },
            { 181000.0d, 0.00198459d },
            { 184000.0d, 0.00197851d },
            { 187000.0d, 0.00197237d },
            { 190000.0d, 0.00196618d },
            { 193000.0d, 0.00195993d },
            { 196000.0d, 0.00195363d },
            { 199000.0d, 0.00194728d },
            { 202000.0d, 0.00194088d },
            { 205000.0d, 0.00193443d },
            { 208000.0d, 0.00192793d },
            { 211000.0d, 0.0019214d },
            { 214000.0d, 0.00191482d },
            { 217000.0d, 0.0019082d },
            { 220000.0d, 0.00190155d },
            { 223000.0d, 0.00189487d },
            { 226000.0d, 0.00188815d },
            { 229000.0d, 0.00188141d },
            { 232000.0d, 0.00187464d },
            { 235000.0d, 0.00186784d },
            { 238000.0d, 0.00186102d },
            { 241000.0d, 0.00185418d },
            { 244000.0d, 0.00184732d },
            { 247000.0d, 0.00184038d },
            { 250000.0d, 0.00183336d },
            { 253000.0d, 0.00182624d },
            { 256000.0d, 0.00181905d },
            { 259000.0d, 0.00181176d },
            { 262000.0d, 0.00180438d },
            { 265000.0d, 0.00179693d },
            { 268000.0d, 0.00178939d },
            { 271000.0d, 0.00178177d },
            { 274000.0d, 0.00177406d },
            { 277000.0d, 0.00176628d },
            { 280000.0d, 0.00175842d },
            { 283000.0d, 0.00175048d },
            { 286000.0d, 0.00174247d },
            { 289000.0d, 0.00173438d },
            { 292000.0d, 0.00172621d },
            { 295000.0d, 0.00171797d },
            { 298000.0d, 0.00170967d },
            { 301000.0d, 0.00170128d },
            { 304000.0d, 0.00169284d },
            { 307000.0d, 0.00168432d },
            { 310000.0d, 0.00167574d },
            { 313000.0d, 0.00166709d },
            { 316000.0d, 0.00165837d },
            { 319000.0d, 0.00164959d },
            { 322000.0d, 0.00164076d },
            { 325000.0d, 0.00163186d },
            { 328000.0d, 0.00162289d },
            { 331000.0d, 0.00161388d },
            { 334000.0d, 0.00160479d },
            { 337000.0d, 0.00159566d },
            { 340000.0d, 0.00158647d },
            { 343000.0d, 0.00157723d },
            { 346000.0d, 0.00156792d },
            { 349000.0d, 0.00155854d },
            { 352000.0d, 0.00154911d },
            { 355000.0d, 0.0015396d },
            { 358000.0d, 0.00153005d },
            { 361000.0d, 0.00152043d },
            { 364000.0d, 0.00151076d },
            { 367000.0d, 0.00150103d },
            { 370000.0d, 0.00149124d },
            { 373000.0d, 0.0014814d },
            { 376000.0d, 0.00147151d },
            { 379000.0d, 0.00146156d },
            { 382000.0d, 0.00145157d },
            { 385000.0d, 0.00144152d },
            { 388000.0d, 0.00143143d },
            { 391000.0d, 0.00142129d },
            { 394000.0d, 0.0014111d },
            { 397000.0d, 0.00140087d },
            { 400000.0d, 0.0013906d },
            { 403000.0d, 0.00138027d },
            { 406000.0d, 0.00136992d },
            { 409000.0d, 0.00135952d },
            { 412000.0d, 0.00134908d },
            { 415000.0d, 0.00133861d },
            { 418000.0d, 0.0013281d },
            { 421000.0d, 0.00131755d },
            { 424000.0d, 0.00130697d },
            { 427000.0d, 0.00129636d },
            { 430000.0d, 0.00128572d },
            { 433000.0d, 0.00127504d },
            { 436000.0d, 0.00126434d },
            { 439000.0d, 0.00125361d },
            { 442000.0d, 0.00124286d },
            { 445000.0d, 0.00123209d },
            { 448000.0d, 0.00122128d },
            { 451000.0d, 0.00121046d },
            { 454000.0d, 0.00119961d },
            { 457000.0d, 0.00118875d },
            { 460000.0d, 0.00117786d },
            { 463000.0d, 0.00116697d },
            { 466000.0d, 0.00115605d },
            { 469000.0d, 0.00114512d },
            { 472000.0d, 0.00113418d },
            { 475000.0d, 0.00112323d },
            { 478000.0d, 0.00111226d },
            { 481000.0d, 0.00110129d },
            { 484000.0d, 0.00109031d },
            { 487000.0d, 0.00107933d },
            { 490000.0d, 0.00106834d },
            { 493000.0d, 0.00105735d },
            { 496000.0d, 0.00104636d },
            { 499000.0d, 0.00103536d },
            { 502000.0d, 0.00102436d },
            { 505000.0d, 0.00101337d },
            { 508000.0d, 0.00100238d },
            { 511000.0d, 0.000991402d },
            { 514000.0d, 0.000980426d },
            { 517000.0d, 0.000969459d },
            { 520000.0d, 0.000958501d },
            { 523000.0d, 0.000947553d },
            { 526000.0d, 0.000936619d },
            { 529000.0d, 0.000925698d },
            { 532000.0d, 0.000914792d },
            { 535000.0d, 0.000903904d },
            { 538000.0d, 0.000893033d },
            { 541000.0d, 0.000882182d },
            { 544000.0d, 0.000871352d },
            { 547000.0d, 0.000860545d },
            { 550000.0d, 0.000849761d },
            { 553000.0d, 0.000839003d },
            { 556000.0d, 0.000828273d },
            { 559000.0d, 0.00081757d },
            { 562000.0d, 0.000806899d },
            { 565000.0d, 0.000796258d },
            { 568000.0d, 0.00078565d },
            { 571000.0d, 0.000775077d },
            { 574000.0d, 0.00076454d },
            { 577000.0d, 0.00075404d },
            { 580000.0d, 0.000743578d },
            { 583000.0d, 0.000733154d },
            { 586000.0d, 0.000722753d },
            { 589000.0d, 0.000712376d },
            { 592000.0d, 0.000702023d },
            { 595000.0d, 0.000691697d },
            { 598000.0d, 0.000681399d },
            { 601000.0d, 0.000671131d },
            { 604000.0d, 0.000660893d },
            { 607000.0d, 0.000650686d },
            { 610000.0d, 0.000640513d },
            { 613000.0d, 0.000630373d },
            { 616000.0d, 0.00062027d },
            { 619000.0d, 0.000610204d },
            { 622000.0d, 0.000600176d },
            { 625000.0d, 0.000590189d },
            { 628000.0d, 0.000580242d },
            { 631000.0d, 0.000570338d },
            { 634000.0d, 0.000560477d },
            { 637000.0d, 0.000550662d },
            { 640000.0d, 0.000540894d },
            { 643000.0d, 0.000531173d },
            { 646000.0d, 0.000521502d },
            { 649000.0d, 0.000511882d },
            { 652000.0d, 0.000502313d },
            { 655000.0d, 0.000492799d },
            { 658000.0d, 0.000483339d },
            { 661000.0d, 0.000473935d },
            { 664000.0d, 0.000464589d },
            { 667000.0d, 0.000455302d },
            { 670000.0d, 0.000446076d },
            { 673000.0d, 0.000436911d },
            { 676000.0d, 0.00042781d },
            { 679000.0d, 0.000418774d },
            { 682000.0d, 0.000409803d },
            { 685000.0d, 0.0004009d },
            { 688000.0d, 0.000392066d },
            { 691000.0d, 0.000383303d },
            { 694000.0d, 0.000374611d },
            { 697000.0d, 0.000365988d },
            { 700000.0d, 0.00035743d },
            { 703000.0d, 0.000348939d },
            { 706000.0d, 0.000340517d },
            { 709000.0d, 0.000332164d },
            { 712000.0d, 0.000323882d },
            { 715000.0d, 0.000315672d },
            { 718000.0d, 0.000307536d },
            { 721000.0d, 0.000299475d },
            { 724000.0d, 0.00029149d },
            { 727000.0d, 0.000283583d },
            { 730000.0d, 0.000275756d },
            { 733000.0d, 0.000268009d },
            { 736000.0d, 0.000260343d },
            { 739000.0d, 0.000252761d },
            { 742000.0d, 0.000245263d },
            { 745000.0d, 0.000237851d },
            { 748000.0d, 0.000230527d },
            { 751000.0d, 0.000223291d },
            { 754000.0d, 0.000216146d },
            { 757000.0d, 0.000209092d },
            { 760000.0d, 0.000202131d },
            { 763000.0d, 0.000195265d },
            { 766000.0d, 0.000188494d },
            { 769000.0d, 0.00018182d },
            { 772000.0d, 0.000175246d },
            { 775000.0d, 0.00016877d },
            { 778000.0d, 0.000162396d },
            { 781000.0d, 0.000156125d },
            { 784000.0d, 0.000149959d },
            { 787000.0d, 0.000143898d },
            { 790000.0d, 0.000137943d },
            { 793000.0d, 0.000132097d },
            { 796000.0d, 0.000126362d },
            { 799000.0d, 0.000120737d },
            { 802000.0d, 0.000115225d },
            { 805000.0d, 0.000109828d },
            { 808000.0d, 0.000104546d },
            { 811000.0d, 0.0000993802d },
            { 814000.0d, 0.0000943297d },
            { 817000.0d, 0.000089394d },
            { 820000.0d, 0.0000845747d },
            { 823000.0d, 0.0000798732d },
            { 826000.0d, 0.0000752909d },
            { 829000.0d, 0.0000708291d },
            { 832000.0d, 0.0000664893d },
            { 835000.0d, 0.000062273d },
            { 838000.0d, 0.0000581814d },
            { 841000.0d, 0.000054216d },
            { 844000.0d, 0.0000503782d },
            { 847000.0d, 0.0000466695d },
            { 850000.0d, 0.0000430912d },
            { 853000.0d, 0.0000396447d },
            { 856000.0d, 0.0000363315d },
            { 859000.0d, 0.0000331529d },
            { 862000.0d, 0.0000301104d },
            { 865000.0d, 0.0000272055d },
            { 868000.0d, 0.0000244395d },
            { 871000.0d, 0.0000218137d },
            { 874000.0d, 0.0000193298d },
            { 877000.0d, 0.000016989d },
            { 880000.0d, 0.0000147928d },
            { 883000.0d, 0.0000127426d },
            { 886000.0d, 0.0000108398d },
            { 889000.0d, 0.00000908579d },
            { 892000.0d, 0.00000748203d },
            { 895000.0d, 0.00000602989d },
            { 898000.0d, 0.00000473078d },
            { 901000.0d, 0.00000358607d },
            { 904000.0d, 0.00000259715d },
            { 907000.0d, 0.0000017654d },
            { 910000.0d, 0.00000109214d },
            { 913000.0d, 0.00000057871d },
            { 916000.0d, 0.000000226353d },
            { 919000.0d, 0.000000036218d },
            { 921000.0d, 0d },

        }; 
    }
}
    