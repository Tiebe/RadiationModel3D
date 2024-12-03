using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth212n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth212n";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 211.99287d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.75d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth212()) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium212()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00205267d },
            { 2000.0d, 0.00211976d },
            { 4000.0d, 0.00215935d },
            { 6000.0d, 0.00217144d },
            { 8000.0d, 0.0021787d },
            { 10000.0d, 0.00218408d },
            { 12000.0d, 0.00218842d },
            { 14000.0d, 0.00219207d },
            { 16000.0d, 0.00219523d },
            { 18000.0d, 0.00219802d },
            { 20000.0d, 0.00220052d },
            { 22000.0d, 0.00220279d },
            { 24000.0d, 0.00220487d },
            { 26000.0d, 0.00220678d },
            { 28000.0d, 0.00220854d },
            { 30000.0d, 0.00221016d },
            { 32000.0d, 0.00221165d },
            { 34000.0d, 0.00221303d },
            { 36000.0d, 0.0022143d },
            { 38000.0d, 0.00221546d },
            { 40000.0d, 0.00221653d },
            { 42000.0d, 0.00221749d },
            { 44000.0d, 0.00221835d },
            { 46000.0d, 0.00221913d },
            { 48000.0d, 0.00221981d },
            { 50000.0d, 0.0022204d },
            { 52000.0d, 0.0022209d },
            { 54000.0d, 0.00222132d },
            { 56000.0d, 0.00222165d },
            { 58000.0d, 0.0022219d },
            { 60000.0d, 0.00222207d },
            { 62000.0d, 0.00222215d },
            { 64000.0d, 0.00222215d },
            { 66000.0d, 0.00222207d },
            { 68000.0d, 0.00222191d },
            { 70000.0d, 0.00222167d },
            { 72000.0d, 0.00222135d },
            { 74000.0d, 0.00222096d },
            { 76000.0d, 0.00222049d },
            { 78000.0d, 0.00221994d },
            { 80000.0d, 0.00221931d },
            { 82000.0d, 0.00221861d },
            { 84000.0d, 0.00221784d },
            { 86000.0d, 0.00221699d },
            { 88000.0d, 0.00221607d },
            { 90000.0d, 0.00221507d },
            { 92000.0d, 0.002214d },
            { 94000.0d, 0.00221286d },
            { 96000.0d, 0.00221164d },
            { 98000.0d, 0.00221035d },
            { 100000.0d, 0.00220899d },
            { 102000.0d, 0.00220756d },
            { 104000.0d, 0.00220606d },
            { 106000.0d, 0.00220449d },
            { 108000.0d, 0.00220284d },
            { 110000.0d, 0.00220113d },
            { 112000.0d, 0.00219935d },
            { 114000.0d, 0.0021975d },
            { 116000.0d, 0.00219557d },
            { 118000.0d, 0.00219358d },
            { 120000.0d, 0.00219152d },
            { 122000.0d, 0.0021894d },
            { 124000.0d, 0.0021872d },
            { 126000.0d, 0.00218494d },
            { 128000.0d, 0.0021826d },
            { 130000.0d, 0.0021802d },
            { 132000.0d, 0.00217774d },
            { 134000.0d, 0.0021752d },
            { 136000.0d, 0.0021726d },
            { 138000.0d, 0.00216994d },
            { 140000.0d, 0.0021672d },
            { 142000.0d, 0.00216441d },
            { 144000.0d, 0.00216154d },
            { 146000.0d, 0.00215861d },
            { 148000.0d, 0.00215561d },
            { 150000.0d, 0.00215255d },
            { 152000.0d, 0.00214943d },
            { 154000.0d, 0.00214624d },
            { 156000.0d, 0.00214298d },
            { 158000.0d, 0.00213967d },
            { 160000.0d, 0.00213628d },
            { 162000.0d, 0.00213284d },
            { 164000.0d, 0.00212933d },
            { 166000.0d, 0.00212576d },
            { 168000.0d, 0.00212212d },
            { 170000.0d, 0.00211842d },
            { 172000.0d, 0.00211466d },
            { 174000.0d, 0.00211084d },
            { 176000.0d, 0.00210695d },
            { 178000.0d, 0.00210301d },
            { 180000.0d, 0.002099d },
            { 182000.0d, 0.00209493d },
            { 184000.0d, 0.0020908d },
            { 186000.0d, 0.00208661d },
            { 188000.0d, 0.00208236d },
            { 190000.0d, 0.00207805d },
            { 192000.0d, 0.00207368d },
            { 194000.0d, 0.00206925d },
            { 196000.0d, 0.00206476d },
            { 198000.0d, 0.00206021d },
            { 200000.0d, 0.0020556d },
            { 202000.0d, 0.00205094d },
            { 204000.0d, 0.00204621d },
            { 206000.0d, 0.00204143d },
            { 208000.0d, 0.00203659d },
            { 210000.0d, 0.00203169d },
            { 212000.0d, 0.00202674d },
            { 214000.0d, 0.00202172d },
            { 216000.0d, 0.00201666d },
            { 218000.0d, 0.00201153d },
            { 220000.0d, 0.00200635d },
            { 222000.0d, 0.00200112d },
            { 224000.0d, 0.00199582d },
            { 226000.0d, 0.00199048d },
            { 228000.0d, 0.00198508d },
            { 230000.0d, 0.00197962d },
            { 232000.0d, 0.00197411d },
            { 234000.0d, 0.00196855d },
            { 236000.0d, 0.00196293d },
            { 238000.0d, 0.00195726d },
            { 240000.0d, 0.00195154d },
            { 242000.0d, 0.00194576d },
            { 244000.0d, 0.00193993d },
            { 246000.0d, 0.00193405d },
            { 248000.0d, 0.00192812d },
            { 250000.0d, 0.00192213d },
            { 252000.0d, 0.0019161d },
            { 254000.0d, 0.00191002d },
            { 256000.0d, 0.00190388d },
            { 258000.0d, 0.0018977d },
            { 260000.0d, 0.00189146d },
            { 262000.0d, 0.00188518d },
            { 264000.0d, 0.00187884d },
            { 266000.0d, 0.00187246d },
            { 268000.0d, 0.00186603d },
            { 270000.0d, 0.00185955d },
            { 272000.0d, 0.00185303d },
            { 274000.0d, 0.00184646d },
            { 276000.0d, 0.00183984d },
            { 278000.0d, 0.00183317d },
            { 280000.0d, 0.00182646d },
            { 282000.0d, 0.0018197d },
            { 284000.0d, 0.0018129d },
            { 286000.0d, 0.00180605d },
            { 288000.0d, 0.00179916d },
            { 290000.0d, 0.00179223d },
            { 292000.0d, 0.00178525d },
            { 294000.0d, 0.00177822d },
            { 296000.0d, 0.00177116d },
            { 298000.0d, 0.00176405d },
            { 300000.0d, 0.00175689d },
            { 302000.0d, 0.0017497d },
            { 304000.0d, 0.00174247d },
            { 306000.0d, 0.00173519d },
            { 308000.0d, 0.00172787d },
            { 310000.0d, 0.00172052d },
            { 312000.0d, 0.00171312d },
            { 314000.0d, 0.00170568d },
            { 316000.0d, 0.00169821d },
            { 318000.0d, 0.00169069d },
            { 320000.0d, 0.00168314d },
            { 322000.0d, 0.00167555d },
            { 324000.0d, 0.00166792d },
            { 326000.0d, 0.00166026d },
            { 328000.0d, 0.00165256d },
            { 330000.0d, 0.00164482d },
            { 332000.0d, 0.00163705d },
            { 334000.0d, 0.00162924d },
            { 336000.0d, 0.0016214d },
            { 338000.0d, 0.00161352d },
            { 340000.0d, 0.00160561d },
            { 342000.0d, 0.00159766d },
            { 344000.0d, 0.00158968d },
            { 346000.0d, 0.00158167d },
            { 348000.0d, 0.00157363d },
            { 350000.0d, 0.00156555d },
            { 352000.0d, 0.00155745d },
            { 354000.0d, 0.00154931d },
            { 356000.0d, 0.00154114d },
            { 358000.0d, 0.00153294d },
            { 360000.0d, 0.00152472d },
            { 362000.0d, 0.00151646d },
            { 364000.0d, 0.00150817d },
            { 366000.0d, 0.00149986d },
            { 368000.0d, 0.00149152d },
            { 370000.0d, 0.00148315d },
            { 372000.0d, 0.00147476d },
            { 374000.0d, 0.00146633d },
            { 376000.0d, 0.00145789d },
            { 378000.0d, 0.00144941d },
            { 380000.0d, 0.00144092d },
            { 382000.0d, 0.00143239d },
            { 384000.0d, 0.00142385d },
            { 386000.0d, 0.00141528d },
            { 388000.0d, 0.00140669d },
            { 390000.0d, 0.00139807d },
            { 392000.0d, 0.00138944d },
            { 394000.0d, 0.00138078d },
            { 396000.0d, 0.0013721d },
            { 398000.0d, 0.0013634d },
            { 400000.0d, 0.00135468d },
            { 402000.0d, 0.00134594d },
            { 404000.0d, 0.00133718d },
            { 406000.0d, 0.00132841d },
            { 408000.0d, 0.00131961d },
            { 410000.0d, 0.0013108d },
            { 412000.0d, 0.00130197d },
            { 414000.0d, 0.00129312d },
            { 416000.0d, 0.00128426d },
            { 418000.0d, 0.00127539d },
            { 420000.0d, 0.00126649d },
            { 422000.0d, 0.00125759d },
            { 424000.0d, 0.00124867d },
            { 426000.0d, 0.00123973d },
            { 428000.0d, 0.00123079d },
            { 430000.0d, 0.00122183d },
            { 432000.0d, 0.00121286d },
            { 434000.0d, 0.00120388d },
            { 436000.0d, 0.00119488d },
            { 438000.0d, 0.00118588d },
            { 440000.0d, 0.00117687d },
            { 442000.0d, 0.00116785d },
            { 444000.0d, 0.00115882d },
            { 446000.0d, 0.00114978d },
            { 448000.0d, 0.00114073d },
            { 450000.0d, 0.00113168d },
            { 452000.0d, 0.00112262d },
            { 454000.0d, 0.00111356d },
            { 456000.0d, 0.00110449d },
            { 458000.0d, 0.00109541d },
            { 460000.0d, 0.00108633d },
            { 462000.0d, 0.00107725d },
            { 464000.0d, 0.00106816d },
            { 466000.0d, 0.00105907d },
            { 468000.0d, 0.00104998d },
            { 470000.0d, 0.00104089d },
            { 472000.0d, 0.0010318d },
            { 474000.0d, 0.00102271d },
            { 476000.0d, 0.00101361d },
            { 478000.0d, 0.00100452d },
            { 480000.0d, 0.00099543d },
            { 482000.0d, 0.000986341d },
            { 484000.0d, 0.000977255d },
            { 486000.0d, 0.000968172d },
            { 488000.0d, 0.000959093d },
            { 490000.0d, 0.000950018d },
            { 492000.0d, 0.000940948d },
            { 494000.0d, 0.000931883d },
            { 496000.0d, 0.000922825d },
            { 498000.0d, 0.000913773d },
            { 500000.0d, 0.000904728d },
            { 502000.0d, 0.000895691d },
            { 504000.0d, 0.000886662d },
            { 506000.0d, 0.000877643d },
            { 508000.0d, 0.000868633d },
            { 510000.0d, 0.000859633d },
            { 512000.0d, 0.000850644d },
            { 514000.0d, 0.000841667d },
            { 516000.0d, 0.000832701d },
            { 518000.0d, 0.000823748d },
            { 520000.0d, 0.000814808d },
            { 522000.0d, 0.000805882d },
            { 524000.0d, 0.00079697d },
            { 526000.0d, 0.000788073d },
            { 528000.0d, 0.000779192d },
            { 530000.0d, 0.000770327d },
            { 532000.0d, 0.000761479d },
            { 534000.0d, 0.000752649d },
            { 536000.0d, 0.000743836d },
            { 538000.0d, 0.000735043d },
            { 540000.0d, 0.000726268d },
            { 542000.0d, 0.000717514d },
            { 544000.0d, 0.00070878d },
            { 546000.0d, 0.000700067d },
            { 548000.0d, 0.000691376d },
            { 550000.0d, 0.000682707d },
            { 552000.0d, 0.000674062d },
            { 554000.0d, 0.00066544d },
            { 556000.0d, 0.000656843d },
            { 558000.0d, 0.00064827d },
            { 560000.0d, 0.000639723d },
            { 562000.0d, 0.000631203d },
            { 564000.0d, 0.000622709d },
            { 566000.0d, 0.000614243d },
            { 568000.0d, 0.000605805d },
            { 570000.0d, 0.000597396d },
            { 572000.0d, 0.000589016d },
            { 574000.0d, 0.000580667d },
            { 576000.0d, 0.000572348d },
            { 578000.0d, 0.00056406d },
            { 580000.0d, 0.000555805d },
            { 582000.0d, 0.000547582d },
            { 584000.0d, 0.000539393d },
            { 586000.0d, 0.000531238d },
            { 588000.0d, 0.000523117d },
            { 590000.0d, 0.000515032d },
            { 592000.0d, 0.000506982d },
            { 594000.0d, 0.00049897d },
            { 596000.0d, 0.000490994d },
            { 598000.0d, 0.000483057d },
            { 600000.0d, 0.000475158d },
            { 602000.0d, 0.000467299d },
            { 604000.0d, 0.000459479d },
            { 606000.0d, 0.000451701d },
            { 608000.0d, 0.000443963d },
            { 610000.0d, 0.000436268d },
            { 612000.0d, 0.000428615d },
            { 614000.0d, 0.000421006d },
            { 616000.0d, 0.00041344d },
            { 618000.0d, 0.00040592d },
            { 620000.0d, 0.000398444d },
            { 622000.0d, 0.000391015d },
            { 624000.0d, 0.000383633d },
            { 626000.0d, 0.000376298d },
            { 628000.0d, 0.000369011d },
            { 630000.0d, 0.000361773d },
            { 632000.0d, 0.000354584d },
            { 634000.0d, 0.000347446d },
            { 636000.0d, 0.000340358d },
            { 638000.0d, 0.000333323d },
            { 640000.0d, 0.000326339d },
            { 642000.0d, 0.000319408d },
            { 644000.0d, 0.000312531d },
            { 646000.0d, 0.000305709d },
            { 648000.0d, 0.000298941d },
            { 650000.0d, 0.000292229d },
            { 652000.0d, 0.000285574d },
            { 654000.0d, 0.000278975d },
            { 656000.0d, 0.000272435d },
            { 658000.0d, 0.000265953d },
            { 660000.0d, 0.000259531d },
            { 662000.0d, 0.000253168d },
            { 664000.0d, 0.000246866d },
            { 666000.0d, 0.000240626d },
            { 668000.0d, 0.000234448d },
            { 670000.0d, 0.000228332d },
            { 672000.0d, 0.00022228d },
            { 674000.0d, 0.000216292d },
            { 676000.0d, 0.00021037d },
            { 678000.0d, 0.000204513d },
            { 680000.0d, 0.000198722d },
            { 682000.0d, 0.000192999d },
            { 684000.0d, 0.000187343d },
            { 686000.0d, 0.000181756d },
            { 688000.0d, 0.000176238d },
            { 690000.0d, 0.000170791d },
            { 692000.0d, 0.000165414d },
            { 694000.0d, 0.000160109d },
            { 696000.0d, 0.000154875d },
            { 698000.0d, 0.000149715d },
            { 700000.0d, 0.000144629d },
            { 702000.0d, 0.000139617d },
            { 704000.0d, 0.00013468d },
            { 706000.0d, 0.000129818d },
            { 708000.0d, 0.000125034d },
            { 710000.0d, 0.000120327d },
            { 712000.0d, 0.000115698d },
            { 714000.0d, 0.000111148d },
            { 716000.0d, 0.000106677d },
            { 718000.0d, 0.000102287d },
            { 720000.0d, 0.0000979774d },
            { 722000.0d, 0.00009375d },
            { 724000.0d, 0.000089605d },
            { 726000.0d, 0.0000855434d },
            { 728000.0d, 0.0000815658d },
            { 730000.0d, 0.000077673d },
            { 732000.0d, 0.0000738657d },
            { 734000.0d, 0.0000701447d },
            { 736000.0d, 0.0000665107d },
            { 738000.0d, 0.0000629645d },
            { 740000.0d, 0.0000595068d },
            { 742000.0d, 0.0000561385d },
            { 744000.0d, 0.0000528601d },
            { 746000.0d, 0.0000496725d },
            { 748000.0d, 0.0000465765d },
            { 750000.0d, 0.0000435728d },
            { 752000.0d, 0.0000406621d },
            { 754000.0d, 0.0000378453d },
            { 756000.0d, 0.000035123d },
            { 758000.0d, 0.000032496d },
            { 760000.0d, 0.0000299651d },
            { 762000.0d, 0.0000275311d },
            { 764000.0d, 0.0000251947d },
            { 766000.0d, 0.0000229566d },
            { 768000.0d, 0.0000208177d },
            { 770000.0d, 0.0000187786d },
            { 772000.0d, 0.0000168402d },
            { 774000.0d, 0.0000150031d },
            { 776000.0d, 0.0000132682d },
            { 778000.0d, 0.0000116363d },
            { 780000.0d, 0.000010108d },
            { 782000.0d, 0.00000868413d },
            { 784000.0d, 0.00000736544d },
            { 786000.0d, 0.0000061527d },
            { 788000.0d, 0.00000504664d },
            { 790000.0d, 0.00000404801d },
            { 792000.0d, 0.00000315756d },
            { 794000.0d, 0.00000237603d },
            { 796000.0d, 0.00000170415d },
            { 798000.0d, 0.00000114265d },
            { 800000.0d, 0.000000692227d },
            { 802000.0d, 0.000000353577d },
            { 804000.0d, 0.000000127353d },
            { 806000.0d, 0.000000014128d },
            { 807000.0d, 0d },

        }; 
    }
}
    