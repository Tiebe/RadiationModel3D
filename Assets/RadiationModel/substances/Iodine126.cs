using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine126 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine126";
        public override double halfLife { get; } = 1117152.0d;
        public override double atomicWeight { get; } = 125.90562d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.527d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony126()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.32899999999999996d, new GammaParticle(666331.0, 0.00186)), new(2e-06d, new GammaParticle(695000.0, 0.00178)), new(0.0415d, new GammaParticle(753819.0, 0.00164)), new(4.6e-06d, new GammaParticle(1206800.0, 0.00103)), new(2.37e-05d, new GammaParticle(1378760.0, 0.0009)), new(0.0030399999999999997d, new GammaParticle(1420190.0, 0.00087)), new(4.6e-05d, new GammaParticle(2045090.0, 0.00061)), new(0.01992d, new GammaParticle(511000.0, 0.00243)), new(0.04019999999999999d, new GammaParticle(4135.0, 0.29984)), new(0.1105d, new GammaParticle(27202.0, 0.04558)), new(0.20600000000000002d, new GammaParticle(27473.0, 0.04513)), new(0.058899999999999994d, new GammaParticle(31093.0, 0.03988)), new(0.0717d, new GammaParticle(31359.0, 0.03954)), new(0.0128d, new GammaParticle(31698.0, 0.03911)) } },
            { 0.473d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon126()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.35600000000000004d, new GammaParticle(388633.0, 0.00319)), new(0.0288d, new GammaParticle(491243.0, 0.00252)), new(0.00743d, new GammaParticle(879876.0, 0.00141)), new(0.00059385276368d, new GammaParticle(4540.0, 0.27309)), new(0.0014624691004647325d, new GammaParticle(29458.0, 0.04209)), new(0.002709279548841668d, new GammaParticle(29778.0, 0.04164)), new(0.0007854093128588993d, new GammaParticle(33726.0, 0.03676)), new(0.0009707659106935995d, new GammaParticle(34030.0, 0.03643)), new(0.00018535659783470025d, new GammaParticle(34414.0, 0.03603)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 1000.0d, 0.000000000179314d },
            { 2000.0d, 0.000000000890813d },
            { 3000.0d, 0.00000000246839d },
            { 4000.0d, 0.00000000502413d },
            { 5000.0d, 0.00000000872141d },
            { 6000.0d, 0.0000000137153d },
            { 7000.0d, 0.000000020644d },
            { 8000.0d, 0.0000000293898d },
            { 9000.0d, 0.000000040068d },
            { 10000.0d, 0.0000000531635d },
            { 11000.0d, 0.0000000685695d },
            { 12000.0d, 0.0000000863574d },
            { 13000.0d, 0.00000010684d },
            { 14000.0d, 0.000000129936d },
            { 15000.0d, 0.000000155679d },
            { 16000.0d, 0.000000184233d },
            { 17000.0d, 0.000000215542d },
            { 18000.0d, 0.000000249611d },
            { 19000.0d, 0.000000286488d },
            { 20000.0d, 0.000000326141d },
            { 21000.0d, 0.000000368553d },
            { 22000.0d, 0.000000413689d },
            { 23000.0d, 0.000000461532d },
            { 24000.0d, 0.000000512054d },
            { 25000.0d, 0.00000056516d },
            { 26000.0d, 0.000000620847d },
            { 27000.0d, 0.000000679077d },
            { 28000.0d, 0.000000739718d },
            { 29000.0d, 0.000000802775d },
            { 30000.0d, 0.000000868205d },
            { 31000.0d, 0.000000935854d },
            { 32000.0d, 0.00000100573d },
            { 33000.0d, 0.0000010778d },
            { 34000.0d, 0.00000115188d },
            { 35000.0d, 0.00000122799d },
            { 36000.0d, 0.00000130609d },
            { 37000.0d, 0.000001386d },
            { 38000.0d, 0.00000146775d },
            { 39000.0d, 0.00000155129d },
            { 40000.0d, 0.00000163644d },
            { 41000.0d, 0.00000172323d },
            { 42000.0d, 0.0000018116d },
            { 43000.0d, 0.00000190141d },
            { 44000.0d, 0.00000199265d },
            { 45000.0d, 0.0000020853d },
            { 46000.0d, 0.0000021792d },
            { 47000.0d, 0.00000227436d },
            { 48000.0d, 0.00000237073d },
            { 49000.0d, 0.00000246818d },
            { 50000.0d, 0.00000256671d },
            { 51000.0d, 0.0000026663d },
            { 52000.0d, 0.0000027668d },
            { 53000.0d, 0.00000286822d },
            { 54000.0d, 0.00000297053d },
            { 55000.0d, 0.0000030736d },
            { 56000.0d, 0.00000317745d },
            { 57000.0d, 0.00000328204d },
            { 58000.0d, 0.00000338724d },
            { 59000.0d, 0.00000349308d },
            { 60000.0d, 0.00000359953d },
            { 61000.0d, 0.00000370646d },
            { 62000.0d, 0.0000038139d },
            { 63000.0d, 0.0000039218d },
            { 64000.0d, 0.00000403007d },
            { 65000.0d, 0.00000413874d },
            { 66000.0d, 0.00000424776d },
            { 67000.0d, 0.00000435703d },
            { 68000.0d, 0.00000446658d },
            { 69000.0d, 0.00000457637d },
            { 70000.0d, 0.00000468632d },
            { 71000.0d, 0.00000479644d },
            { 72000.0d, 0.00000490671d },
            { 73000.0d, 0.00000501703d },
            { 74000.0d, 0.00000512744d },
            { 75000.0d, 0.0000052379d },
            { 76000.0d, 0.00000534834d },
            { 77000.0d, 0.00000545877d },
            { 78000.0d, 0.00000556915d },
            { 79000.0d, 0.00000567945d },
            { 80000.0d, 0.00000578966d },
            { 81000.0d, 0.00000589975d },
            { 82000.0d, 0.00000600968d },
            { 83000.0d, 0.00000611943d },
            { 84000.0d, 0.00000622901d },
            { 85000.0d, 0.00000633836d },
            { 86000.0d, 0.00000644747d },
            { 87000.0d, 0.00000655635d },
            { 88000.0d, 0.00000666492d },
            { 89000.0d, 0.00000677321d },
            { 90000.0d, 0.00000688119d },
            { 91000.0d, 0.00000698882d },
            { 92000.0d, 0.00000709611d },
            { 93000.0d, 0.00000720304d },
            { 94000.0d, 0.00000730957d },
            { 95000.0d, 0.00000741569d },
            { 96000.0d, 0.00000752142d },
            { 97000.0d, 0.00000762671d },
            { 98000.0d, 0.00000773154d },
            { 99000.0d, 0.00000783594d },
            { 100000.0d, 0.00000793985d },
            { 103000.0d, 0.0000082486d },
            { 106000.0d, 0.00000855265d },
            { 109000.0d, 0.00000885169d },
            { 112000.0d, 0.00000914545d },
            { 115000.0d, 0.00000943366d },
            { 118000.0d, 0.00000971613d },
            { 121000.0d, 0.00000999266d },
            { 124000.0d, 0.000010263d },
            { 127000.0d, 0.0000105272d },
            { 130000.0d, 0.0000107849d },
            { 133000.0d, 0.000011036d },
            { 136000.0d, 0.0000112806d },
            { 139000.0d, 0.0000115184d },
            { 142000.0d, 0.0000117493d },
            { 145000.0d, 0.0000119735d },
            { 148000.0d, 0.0000121907d },
            { 151000.0d, 0.0000124009d },
            { 154000.0d, 0.0000126042d },
            { 157000.0d, 0.0000128005d },
            { 160000.0d, 0.0000129897d },
            { 163000.0d, 0.0000131719d },
            { 166000.0d, 0.0000133471d },
            { 169000.0d, 0.0000135154d },
            { 172000.0d, 0.0000136766d },
            { 175000.0d, 0.0000138309d },
            { 178000.0d, 0.0000139782d },
            { 181000.0d, 0.0000141187d },
            { 184000.0d, 0.0000142523d },
            { 187000.0d, 0.0000143792d },
            { 190000.0d, 0.0000144993d },
            { 193000.0d, 0.0000146127d },
            { 196000.0d, 0.0000147195d },
            { 199000.0d, 0.0000148198d },
            { 202000.0d, 0.0000149135d },
            { 205000.0d, 0.0000150009d },
            { 208000.0d, 0.000015082d },
            { 211000.0d, 0.0000151567d },
            { 214000.0d, 0.0000152254d },
            { 217000.0d, 0.0000152879d },
            { 220000.0d, 0.0000153444d },
            { 223000.0d, 0.0000153951d },
            { 226000.0d, 0.0000154399d },
            { 229000.0d, 0.000015479d },
            { 232000.0d, 0.0000155125d },
            { 235000.0d, 0.0000155405d },
            { 238000.0d, 0.0000155631d },
            { 241000.0d, 0.0000155803d },
            { 244000.0d, 0.0000155924d },
            { 247000.0d, 0.0000155994d },
            { 250000.0d, 0.0000156014d },
            { 253000.0d, 0.0000155985d },
            { 256000.0d, 0.0000155909d },
            { 259000.0d, 0.0000155786d },
            { 262000.0d, 0.0000155618d },
            { 265000.0d, 0.0000155406d },
            { 268000.0d, 0.0000155151d },
            { 271000.0d, 0.0000154855d },
            { 274000.0d, 0.0000154518d },
            { 277000.0d, 0.0000154142d },
            { 280000.0d, 0.0000153727d },
            { 283000.0d, 0.0000153277d },
            { 286000.0d, 0.000015279d },
            { 289000.0d, 0.000015227d },
            { 292000.0d, 0.0000151717d },
            { 295000.0d, 0.0000151132d },
            { 298000.0d, 0.0000150517d },
            { 301000.0d, 0.0000149873d },
            { 304000.0d, 0.0000149201d },
            { 307000.0d, 0.0000148503d },
            { 310000.0d, 0.0000147781d },
            { 313000.0d, 0.0000147034d },
            { 316000.0d, 0.0000146266d },
            { 319000.0d, 0.0000145477d },
            { 322000.0d, 0.0000144668d },
            { 325000.0d, 0.0000143842d },
            { 328000.0d, 0.0000142999d },
            { 331000.0d, 0.0000142141d },
            { 334000.0d, 0.0000141268d },
            { 337000.0d, 0.0000140384d },
            { 340000.0d, 0.0000139489d },
            { 343000.0d, 0.0000138585d },
            { 346000.0d, 0.0000137672d },
            { 349000.0d, 0.0000136753d },
            { 352000.0d, 0.000013583d },
            { 355000.0d, 0.0000134902d },
            { 358000.0d, 0.0000133973d },
            { 361000.0d, 0.0000133043d },
            { 364000.0d, 0.0000132114d },
            { 367000.0d, 0.0000131187d },
            { 370000.0d, 0.0000130265d },
            { 373000.0d, 0.0000129347d },
            { 376000.0d, 0.0000128438d },
            { 379000.0d, 0.0000127537d },
            { 382000.0d, 0.0000126645d },
            { 385000.0d, 0.0000125765d },
            { 388000.0d, 0.0000124899d },
            { 391000.0d, 0.0000124048d },
            { 394000.0d, 0.0000123213d },
            { 397000.0d, 0.0000122395d },
            { 400000.0d, 0.0000121598d },
            { 403000.0d, 0.0000120822d },
            { 406000.0d, 0.0000120068d },
            { 409000.0d, 0.0000119339d },
            { 412000.0d, 0.0000118635d },
            { 415000.0d, 0.000011796d },
            { 418000.0d, 0.0000117313d },
            { 421000.0d, 0.0000116697d },
            { 424000.0d, 0.0000116114d },
            { 427000.0d, 0.0000115565d },
            { 430000.0d, 0.0000115052d },
            { 433000.0d, 0.0000114576d },
            { 436000.0d, 0.0000114139d },
            { 439000.0d, 0.0000113743d },
            { 442000.0d, 0.0000113389d },
            { 445000.0d, 0.000011308d },
            { 448000.0d, 0.0000112817d },
            { 451000.0d, 0.00001126d },
            { 454000.0d, 0.0000112434d },
            { 457000.0d, 0.0000112317d },
            { 460000.0d, 0.0000112253d },
            { 463000.0d, 0.0000112243d },
            { 466000.0d, 0.0000112289d },
            { 469000.0d, 0.0000112354d },
            { 472000.0d, 0.0000112411d },
            { 475000.0d, 0.0000112461d },
            { 478000.0d, 0.0000112503d },
            { 481000.0d, 0.0000112539d },
            { 484000.0d, 0.0000112568d },
            { 487000.0d, 0.0000112589d },
            { 490000.0d, 0.0000112603d },
            { 493000.0d, 0.0000112611d },
            { 496000.0d, 0.000011261d },
            { 499000.0d, 0.0000112603d },
            { 502000.0d, 0.0000112588d },
            { 505000.0d, 0.0000112567d },
            { 508000.0d, 0.0000112539d },
            { 511000.0d, 0.0000112503d },
            { 514000.0d, 0.0000112461d },
            { 517000.0d, 0.0000112412d },
            { 520000.0d, 0.0000112355d },
            { 523000.0d, 0.0000112292d },
            { 526000.0d, 0.0000112222d },
            { 529000.0d, 0.0000112144d },
            { 532000.0d, 0.000011206d },
            { 535000.0d, 0.000011197d },
            { 538000.0d, 0.0000111871d },
            { 541000.0d, 0.0000111766d },
            { 544000.0d, 0.0000111654d },
            { 547000.0d, 0.0000111535d },
            { 550000.0d, 0.0000111409d },
            { 553000.0d, 0.0000111276d },
            { 556000.0d, 0.0000111136d },
            { 559000.0d, 0.0000110989d },
            { 562000.0d, 0.0000110835d },
            { 565000.0d, 0.0000110675d },
            { 568000.0d, 0.0000110506d },
            { 571000.0d, 0.0000110331d },
            { 574000.0d, 0.000011015d },
            { 577000.0d, 0.0000109961d },
            { 580000.0d, 0.0000109765d },
            { 583000.0d, 0.0000109563d },
            { 586000.0d, 0.0000109352d },
            { 589000.0d, 0.0000109136d },
            { 592000.0d, 0.0000108911d },
            { 595000.0d, 0.000010868d },
            { 598000.0d, 0.0000108443d },
            { 601000.0d, 0.0000108198d },
            { 604000.0d, 0.0000107946d },
            { 607000.0d, 0.0000107687d },
            { 610000.0d, 0.000010742d },
            { 613000.0d, 0.0000107147d },
            { 616000.0d, 0.0000106867d },
            { 619000.0d, 0.0000106579d },
            { 622000.0d, 0.0000106285d },
            { 625000.0d, 0.0000105983d },
            { 628000.0d, 0.0000105674d },
            { 631000.0d, 0.0000105358d },
            { 634000.0d, 0.0000105036d },
            { 637000.0d, 0.0000104705d },
            { 640000.0d, 0.0000104368d },
            { 643000.0d, 0.0000104022d },
            { 646000.0d, 0.0000103671d },
            { 649000.0d, 0.0000103313d },
            { 652000.0d, 0.0000102946d },
            { 655000.0d, 0.0000102573d },
            { 658000.0d, 0.0000102192d },
            { 661000.0d, 0.0000101804d },
            { 664000.0d, 0.000010141d },
            { 667000.0d, 0.0000101007d },
            { 670000.0d, 0.0000100598d },
            { 673000.0d, 0.0000100181d },
            { 676000.0d, 0.00000997573d },
            { 679000.0d, 0.00000993262d },
            { 682000.0d, 0.00000988879d },
            { 685000.0d, 0.00000984424d },
            { 688000.0d, 0.00000979897d },
            { 691000.0d, 0.00000975297d },
            { 694000.0d, 0.00000970625d },
            { 697000.0d, 0.0000096588d },
            { 700000.0d, 0.00000961064d },
            { 703000.0d, 0.00000956175d },
            { 706000.0d, 0.00000951215d },
            { 709000.0d, 0.00000946183d },
            { 712000.0d, 0.00000941079d },
            { 715000.0d, 0.00000935903d },
            { 718000.0d, 0.00000930655d },
            { 721000.0d, 0.00000925335d },
            { 724000.0d, 0.00000919945d },
            { 727000.0d, 0.00000914484d },
            { 730000.0d, 0.00000908951d },
            { 733000.0d, 0.00000903347d },
            { 736000.0d, 0.00000897673d },
            { 739000.0d, 0.00000891928d },
            { 742000.0d, 0.00000886113d },
            { 745000.0d, 0.00000880229d },
            { 748000.0d, 0.00000874274d },
            { 751000.0d, 0.00000868251d },
            { 754000.0d, 0.00000862158d },
            { 757000.0d, 0.00000855997d },
            { 760000.0d, 0.00000849767d },
            { 763000.0d, 0.00000843469d },
            { 766000.0d, 0.00000837103d },
            { 769000.0d, 0.0000083067d },
            { 772000.0d, 0.00000824171d },
            { 775000.0d, 0.00000817605d },
            { 778000.0d, 0.00000810973d },
            { 781000.0d, 0.00000804275d },
            { 784000.0d, 0.00000797514d },
            { 787000.0d, 0.00000790687d },
            { 790000.0d, 0.00000783797d },
            { 793000.0d, 0.00000776843d },
            { 796000.0d, 0.00000769828d },
            { 799000.0d, 0.0000076275d },
            { 802000.0d, 0.0000075561d },
            { 805000.0d, 0.0000074841d },
            { 808000.0d, 0.00000741151d },
            { 811000.0d, 0.00000733832d },
            { 814000.0d, 0.00000726455d },
            { 817000.0d, 0.0000071902d },
            { 820000.0d, 0.00000711529d },
            { 823000.0d, 0.00000703981d },
            { 826000.0d, 0.00000696379d },
            { 829000.0d, 0.00000688723d },
            { 832000.0d, 0.00000681013d },
            { 835000.0d, 0.00000673252d },
            { 838000.0d, 0.0000066544d },
            { 841000.0d, 0.00000657578d },
            { 844000.0d, 0.00000649667d },
            { 847000.0d, 0.00000641708d },
            { 850000.0d, 0.00000633702d },
            { 853000.0d, 0.00000625651d },
            { 856000.0d, 0.00000617556d },
            { 859000.0d, 0.00000609418d },
            { 862000.0d, 0.00000601238d },
            { 865000.0d, 0.00000593018d },
            { 868000.0d, 0.00000584759d },
            { 871000.0d, 0.00000576462d },
            { 874000.0d, 0.0000056813d },
            { 877000.0d, 0.00000559762d },
            { 880000.0d, 0.00000551363d },
            { 883000.0d, 0.00000542931d },
            { 886000.0d, 0.0000053447d },
            { 889000.0d, 0.0000052598d },
            { 892000.0d, 0.00000517465d },
            { 895000.0d, 0.00000508925d },
            { 898000.0d, 0.00000500361d },
            { 901000.0d, 0.00000491777d },
            { 904000.0d, 0.00000483173d },
            { 907000.0d, 0.00000474553d },
            { 910000.0d, 0.00000465917d },
            { 913000.0d, 0.00000457268d },
            { 916000.0d, 0.00000448607d },
            { 919000.0d, 0.00000439939d },
            { 922000.0d, 0.00000431263d },
            { 925000.0d, 0.00000422582d },
            { 928000.0d, 0.00000413899d },
            { 931000.0d, 0.00000405216d },
            { 934000.0d, 0.00000396535d },
            { 937000.0d, 0.00000387859d },
            { 940000.0d, 0.0000037919d },
            { 943000.0d, 0.00000370531d },
            { 946000.0d, 0.00000361884d },
            { 949000.0d, 0.00000353253d },
            { 952000.0d, 0.00000344639d },
            { 955000.0d, 0.00000336046d },
            { 958000.0d, 0.00000327476d },
            { 961000.0d, 0.00000318931d },
            { 964000.0d, 0.00000310417d },
            { 967000.0d, 0.00000301934d },
            { 970000.0d, 0.00000293486d },
            { 973000.0d, 0.00000285076d },
            { 976000.0d, 0.00000276709d },
            { 979000.0d, 0.00000268385d },
            { 982000.0d, 0.00000260108d },
            { 985000.0d, 0.00000251883d },
            { 988000.0d, 0.00000243713d },
            { 991000.0d, 0.00000235602d },
            { 994000.0d, 0.00000227551d },
            { 997000.0d, 0.00000219566d },
            { 1000000.0d, 0.00000211649d },
            { 1003000.0d, 0.00000203806d },
            { 1006000.0d, 0.00000196039d },
            { 1009000.0d, 0.00000188352d },
            { 1012000.0d, 0.00000180749d },
            { 1015000.0d, 0.00000173234d },
            { 1018000.0d, 0.00000165813d },
            { 1021000.0d, 0.00000158487d },
            { 1024000.0d, 0.00000151262d },
            { 1027000.0d, 0.00000144142d },
            { 1030000.0d, 0.00000137132d },
            { 1033000.0d, 0.00000130234d },
            { 1036000.0d, 0.00000123456d },
            { 1039000.0d, 0.000001168d },
            { 1042000.0d, 0.00000110272d },
            { 1045000.0d, 0.00000103876d },
            { 1048000.0d, 0.000000976171d },
            { 1051000.0d, 0.000000915001d },
            { 1054000.0d, 0.000000855302d },
            { 1057000.0d, 0.000000797121d },
            { 1060000.0d, 0.00000074051d },
            { 1063000.0d, 0.000000685523d },
            { 1066000.0d, 0.00000063221d },
            { 1069000.0d, 0.000000580627d },
            { 1072000.0d, 0.000000530826d },
            { 1075000.0d, 0.000000482863d },
            { 1078000.0d, 0.000000436796d },
            { 1081000.0d, 0.000000392678d },
            { 1084000.0d, 0.000000350569d },
            { 1087000.0d, 0.000000310528d },
            { 1090000.0d, 0.000000272613d },
            { 1093000.0d, 0.000000236884d },
            { 1096000.0d, 0.000000203401d },
            { 1099000.0d, 0.000000172227d },
            { 1102000.0d, 0.000000143423d },
            { 1105000.0d, 0.000000117054d },
            { 1108000.0d, 0.0000000931827d },
            { 1111000.0d, 0.0000000718744d },
            { 1114000.0d, 0.0000000531937d },
            { 1117000.0d, 0.0000000372068d },
            { 1120000.0d, 0.0000000239802d },
            { 1123000.0d, 0.0000000135806d },
            { 1126000.0d, 0.00000000607474d },
            { 1129000.0d, 0.00000000152822d },
            { 1132000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000955094d },
            { 1000.0d, 0.000947993d },
            { 2000.0d, 0.000944613d },
            { 3000.0d, 0.000944953d },
            { 4000.0d, 0.000945651d },
            { 5000.0d, 0.000946406d },
            { 6000.0d, 0.000947198d },
            { 7000.0d, 0.000947735d },
            { 8000.0d, 0.00094813d },
            { 9000.0d, 0.000948473d },
            { 10000.0d, 0.000948739d },
            { 11000.0d, 0.000948969d },
            { 12000.0d, 0.000949149d },
            { 13000.0d, 0.000949322d },
            { 14000.0d, 0.000949468d },
            { 15000.0d, 0.000949593d },
            { 16000.0d, 0.000949694d },
            { 17000.0d, 0.000949781d },
            { 18000.0d, 0.00094985d },
            { 19000.0d, 0.000949904d },
            { 20000.0d, 0.00094994d },
            { 21000.0d, 0.000949965d },
            { 22000.0d, 0.000949975d },
            { 23000.0d, 0.000949972d },
            { 24000.0d, 0.000949957d },
            { 25000.0d, 0.000949932d },
            { 26000.0d, 0.000949895d },
            { 27000.0d, 0.000949849d },
            { 28000.0d, 0.000949791d },
            { 29000.0d, 0.000949725d },
            { 30000.0d, 0.00094965d },
            { 31000.0d, 0.000949565d },
            { 32000.0d, 0.000949472d },
            { 33000.0d, 0.000949371d },
            { 34000.0d, 0.000949264d },
            { 35000.0d, 0.000949147d },
            { 36000.0d, 0.000949024d },
            { 37000.0d, 0.000948894d },
            { 38000.0d, 0.000948758d },
            { 39000.0d, 0.000948614d },
            { 40000.0d, 0.000948464d },
            { 41000.0d, 0.000948306d },
            { 42000.0d, 0.000948144d },
            { 43000.0d, 0.000947975d },
            { 44000.0d, 0.0009478d },
            { 45000.0d, 0.000947618d },
            { 46000.0d, 0.000947432d },
            { 47000.0d, 0.000947238d },
            { 48000.0d, 0.000947039d },
            { 49000.0d, 0.000946833d },
            { 50000.0d, 0.000946622d },
            { 51000.0d, 0.000946405d },
            { 52000.0d, 0.000946182d },
            { 53000.0d, 0.000945954d },
            { 54000.0d, 0.00094572d },
            { 55000.0d, 0.00094548d },
            { 56000.0d, 0.000945235d },
            { 57000.0d, 0.000944984d },
            { 58000.0d, 0.000944726d },
            { 59000.0d, 0.000944463d },
            { 60000.0d, 0.000944195d },
            { 61000.0d, 0.000943921d },
            { 62000.0d, 0.00094364d },
            { 63000.0d, 0.000943354d },
            { 64000.0d, 0.000943062d },
            { 65000.0d, 0.000942764d },
            { 66000.0d, 0.000942459d },
            { 67000.0d, 0.000942149d },
            { 68000.0d, 0.000941833d },
            { 69000.0d, 0.000941511d },
            { 70000.0d, 0.000941183d },
            { 71000.0d, 0.000940848d },
            { 72000.0d, 0.000940509d },
            { 73000.0d, 0.000940163d },
            { 74000.0d, 0.000939811d },
            { 75000.0d, 0.000939453d },
            { 76000.0d, 0.000939088d },
            { 77000.0d, 0.000938717d },
            { 78000.0d, 0.00093834d },
            { 79000.0d, 0.000937956d },
            { 80000.0d, 0.000937567d },
            { 81000.0d, 0.000937171d },
            { 82000.0d, 0.000936769d },
            { 83000.0d, 0.000936361d },
            { 84000.0d, 0.000935947d },
            { 85000.0d, 0.000935525d },
            { 86000.0d, 0.000935097d },
            { 87000.0d, 0.000934663d },
            { 88000.0d, 0.000934223d },
            { 89000.0d, 0.000933777d },
            { 90000.0d, 0.000933324d },
            { 91000.0d, 0.000932864d },
            { 92000.0d, 0.000932398d },
            { 93000.0d, 0.000931926d },
            { 94000.0d, 0.000931447d },
            { 95000.0d, 0.000930961d },
            { 96000.0d, 0.000930469d },
            { 97000.0d, 0.00092997d },
            { 98000.0d, 0.000929466d },
            { 99000.0d, 0.000928955d },
            { 100000.0d, 0.000928436d },
            { 104000.0d, 0.000926299d },
            { 108000.0d, 0.000924055d },
            { 112000.0d, 0.000921708d },
            { 116000.0d, 0.000919257d },
            { 120000.0d, 0.000916698d },
            { 124000.0d, 0.000914037d },
            { 128000.0d, 0.000911272d },
            { 132000.0d, 0.000908404d },
            { 136000.0d, 0.000905435d },
            { 140000.0d, 0.000902365d },
            { 144000.0d, 0.000899195d },
            { 148000.0d, 0.000895928d },
            { 152000.0d, 0.000892564d },
            { 156000.0d, 0.000889105d },
            { 160000.0d, 0.000885554d },
            { 164000.0d, 0.000881911d },
            { 168000.0d, 0.000878179d },
            { 172000.0d, 0.000874359d },
            { 176000.0d, 0.000870454d },
            { 180000.0d, 0.000866468d },
            { 184000.0d, 0.000862399d },
            { 188000.0d, 0.000858254d },
            { 192000.0d, 0.000854032d },
            { 196000.0d, 0.000849737d },
            { 200000.0d, 0.000845372d },
            { 204000.0d, 0.00084094d },
            { 208000.0d, 0.000836443d },
            { 212000.0d, 0.000831884d },
            { 216000.0d, 0.000827266d },
            { 220000.0d, 0.000822592d },
            { 224000.0d, 0.000817867d },
            { 228000.0d, 0.000813091d },
            { 232000.0d, 0.000808268d },
            { 236000.0d, 0.000803403d },
            { 240000.0d, 0.000798498d },
            { 244000.0d, 0.000793556d },
            { 248000.0d, 0.000788582d },
            { 252000.0d, 0.000783578d },
            { 256000.0d, 0.000778549d },
            { 260000.0d, 0.000773497d },
            { 264000.0d, 0.000768428d },
            { 268000.0d, 0.000763344d },
            { 272000.0d, 0.000758249d },
            { 276000.0d, 0.000753148d },
            { 280000.0d, 0.000748041d },
            { 284000.0d, 0.000742938d },
            { 288000.0d, 0.000737838d },
            { 292000.0d, 0.000732749d },
            { 296000.0d, 0.000727671d },
            { 300000.0d, 0.000722611d },
            { 304000.0d, 0.000717573d },
            { 308000.0d, 0.00071256d },
            { 312000.0d, 0.000707577d },
            { 316000.0d, 0.000702627d },
            { 320000.0d, 0.000697718d },
            { 324000.0d, 0.000692852d },
            { 328000.0d, 0.000688032d },
            { 332000.0d, 0.000683266d },
            { 336000.0d, 0.000678554d },
            { 340000.0d, 0.000673907d },
            { 344000.0d, 0.000669323d },
            { 348000.0d, 0.00066481d },
            { 352000.0d, 0.000660373d },
            { 356000.0d, 0.000656016d },
            { 360000.0d, 0.000651671d },
            { 364000.0d, 0.000647261d },
            { 368000.0d, 0.000642787d },
            { 372000.0d, 0.000638252d },
            { 376000.0d, 0.000633655d },
            { 380000.0d, 0.000628996d },
            { 384000.0d, 0.000624279d },
            { 388000.0d, 0.000619504d },
            { 392000.0d, 0.000614672d },
            { 396000.0d, 0.000609782d },
            { 400000.0d, 0.000604838d },
            { 404000.0d, 0.000599841d },
            { 408000.0d, 0.000594791d },
            { 412000.0d, 0.000589689d },
            { 416000.0d, 0.000584536d },
            { 420000.0d, 0.000579336d },
            { 424000.0d, 0.000574087d },
            { 428000.0d, 0.000568791d },
            { 432000.0d, 0.00056345d },
            { 436000.0d, 0.000558064d },
            { 440000.0d, 0.000552635d },
            { 444000.0d, 0.000547166d },
            { 448000.0d, 0.000541655d },
            { 452000.0d, 0.000536106d },
            { 456000.0d, 0.000530519d },
            { 460000.0d, 0.000524895d },
            { 464000.0d, 0.000519237d },
            { 468000.0d, 0.000513544d },
            { 472000.0d, 0.00050782d },
            { 476000.0d, 0.000502064d },
            { 480000.0d, 0.000496279d },
            { 484000.0d, 0.000490466d },
            { 488000.0d, 0.000484626d },
            { 492000.0d, 0.000478761d },
            { 496000.0d, 0.000472872d },
            { 500000.0d, 0.00046696d },
            { 504000.0d, 0.000461028d },
            { 508000.0d, 0.000455076d },
            { 512000.0d, 0.000449106d },
            { 516000.0d, 0.00044312d },
            { 520000.0d, 0.00043712d },
            { 524000.0d, 0.000431106d },
            { 528000.0d, 0.00042508d },
            { 532000.0d, 0.000419044d },
            { 536000.0d, 0.000412999d },
            { 540000.0d, 0.000406947d },
            { 544000.0d, 0.00040089d },
            { 548000.0d, 0.000394829d },
            { 552000.0d, 0.000388766d },
            { 556000.0d, 0.000382702d },
            { 560000.0d, 0.00037664d },
            { 564000.0d, 0.00037058d },
            { 568000.0d, 0.000364525d },
            { 572000.0d, 0.000358476d },
            { 576000.0d, 0.000352435d },
            { 580000.0d, 0.000346403d },
            { 584000.0d, 0.000340384d },
            { 588000.0d, 0.000334376d },
            { 592000.0d, 0.000328384d },
            { 596000.0d, 0.000322408d },
            { 600000.0d, 0.000316451d },
            { 604000.0d, 0.000310514d },
            { 608000.0d, 0.000304599d },
            { 612000.0d, 0.000298708d },
            { 616000.0d, 0.000292842d },
            { 620000.0d, 0.000287004d },
            { 624000.0d, 0.000281195d },
            { 628000.0d, 0.000275418d },
            { 632000.0d, 0.000269674d },
            { 636000.0d, 0.000263964d },
            { 640000.0d, 0.000258292d },
            { 644000.0d, 0.000252659d },
            { 648000.0d, 0.000247067d },
            { 652000.0d, 0.000241517d },
            { 656000.0d, 0.000236012d },
            { 660000.0d, 0.000230553d },
            { 664000.0d, 0.000225144d },
            { 668000.0d, 0.000219785d },
            { 672000.0d, 0.000214479d },
            { 676000.0d, 0.000209228d },
            { 680000.0d, 0.000204034d },
            { 684000.0d, 0.000198899d },
            { 688000.0d, 0.000193824d },
            { 692000.0d, 0.000188812d },
            { 696000.0d, 0.000183866d },
            { 700000.0d, 0.000178987d },
            { 704000.0d, 0.000174177d },
            { 708000.0d, 0.000169439d },
            { 712000.0d, 0.000164775d },
            { 716000.0d, 0.000160187d },
            { 720000.0d, 0.000155676d },
            { 724000.0d, 0.000151246d },
            { 728000.0d, 0.000146898d },
            { 732000.0d, 0.000142635d },
            { 736000.0d, 0.000138459d },
            { 740000.0d, 0.000134372d },
            { 744000.0d, 0.000130376d },
            { 748000.0d, 0.000126474d },
            { 752000.0d, 0.000122668d },
            { 756000.0d, 0.000118961d },
            { 760000.0d, 0.000115354d },
            { 764000.0d, 0.000111849d },
            { 768000.0d, 0.000108451d },
            { 772000.0d, 0.000105159d },
            { 776000.0d, 0.000101978d },
            { 780000.0d, 0.0000989088d },
            { 784000.0d, 0.0000959546d },
            { 788000.0d, 0.0000931174d },
            { 792000.0d, 0.0000903999d },
            { 796000.0d, 0.0000878043d },
            { 800000.0d, 0.0000853332d },
            { 804000.0d, 0.0000829889d },
            { 808000.0d, 0.000080774d },
            { 812000.0d, 0.0000786909d },
            { 816000.0d, 0.0000767421d },
            { 820000.0d, 0.0000749301d },
            { 824000.0d, 0.0000732572d },
            { 828000.0d, 0.0000717262d },
            { 832000.0d, 0.0000703393d },
            { 836000.0d, 0.0000690992d },
            { 840000.0d, 0.0000680081d },
            { 844000.0d, 0.0000670686d },
            { 848000.0d, 0.0000662809d },
            { 852000.0d, 0.0000655454d },
            { 856000.0d, 0.0000648046d },
            { 860000.0d, 0.0000640584d },
            { 864000.0d, 0.0000633069d },
            { 868000.0d, 0.0000625502d },
            { 872000.0d, 0.0000617883d },
            { 876000.0d, 0.0000610214d },
            { 880000.0d, 0.0000602495d },
            { 884000.0d, 0.0000594727d },
            { 888000.0d, 0.000058691d },
            { 892000.0d, 0.0000579047d },
            { 896000.0d, 0.0000571137d },
            { 900000.0d, 0.0000563181d },
            { 904000.0d, 0.0000555182d },
            { 908000.0d, 0.0000547139d },
            { 912000.0d, 0.0000539054d },
            { 916000.0d, 0.0000530929d },
            { 920000.0d, 0.0000522765d },
            { 924000.0d, 0.0000514563d },
            { 928000.0d, 0.0000506324d },
            { 932000.0d, 0.0000498051d },
            { 936000.0d, 0.0000489743d },
            { 940000.0d, 0.0000481405d },
            { 944000.0d, 0.0000473036d },
            { 948000.0d, 0.0000464638d },
            { 952000.0d, 0.0000456214d },
            { 956000.0d, 0.0000447766d },
            { 960000.0d, 0.0000439294d },
            { 964000.0d, 0.0000430802d },
            { 968000.0d, 0.0000422291d },
            { 972000.0d, 0.0000413764d },
            { 976000.0d, 0.0000405223d },
            { 980000.0d, 0.000039667d },
            { 984000.0d, 0.0000388107d },
            { 988000.0d, 0.0000379537d },
            { 992000.0d, 0.0000370963d },
            { 996000.0d, 0.0000362386d },
            { 1000000.0d, 0.0000353811d },
            { 1004000.0d, 0.0000345239d },
            { 1008000.0d, 0.0000336674d },
            { 1012000.0d, 0.0000328118d },
            { 1016000.0d, 0.0000319574d },
            { 1020000.0d, 0.0000311046d },
            { 1024000.0d, 0.0000302537d },
            { 1028000.0d, 0.000029405d },
            { 1032000.0d, 0.0000285588d },
            { 1036000.0d, 0.0000277156d },
            { 1040000.0d, 0.0000268755d },
            { 1044000.0d, 0.0000260391d },
            { 1048000.0d, 0.0000252067d },
            { 1052000.0d, 0.0000243787d },
            { 1056000.0d, 0.0000235554d },
            { 1060000.0d, 0.0000227374d },
            { 1064000.0d, 0.0000219249d },
            { 1068000.0d, 0.0000211184d },
            { 1072000.0d, 0.0000203184d },
            { 1076000.0d, 0.0000195253d },
            { 1080000.0d, 0.0000187396d },
            { 1084000.0d, 0.0000179617d },
            { 1088000.0d, 0.0000171921d },
            { 1092000.0d, 0.0000164313d },
            { 1096000.0d, 0.0000156798d },
            { 1100000.0d, 0.0000149381d },
            { 1104000.0d, 0.0000142067d },
            { 1108000.0d, 0.0000134862d },
            { 1112000.0d, 0.0000127771d },
            { 1116000.0d, 0.00001208d },
            { 1120000.0d, 0.0000113954d },
            { 1124000.0d, 0.0000107239d },
            { 1128000.0d, 0.0000100661d },
            { 1132000.0d, 0.00000942263d },
            { 1136000.0d, 0.00000879409d },
            { 1140000.0d, 0.00000818112d },
            { 1144000.0d, 0.00000758434d },
            { 1148000.0d, 0.00000700443d },
            { 1152000.0d, 0.00000644203d },
            { 1156000.0d, 0.00000589784d },
            { 1160000.0d, 0.00000537255d },
            { 1164000.0d, 0.00000486687d },
            { 1168000.0d, 0.0000043815d },
            { 1172000.0d, 0.00000391719d },
            { 1176000.0d, 0.00000347469d },
            { 1180000.0d, 0.00000305474d },
            { 1184000.0d, 0.00000265812d },
            { 1188000.0d, 0.00000228562d },
            { 1192000.0d, 0.00000193804d },
            { 1196000.0d, 0.00000161619d },
            { 1200000.0d, 0.00000132089d },
            { 1204000.0d, 0.00000105298d },
            { 1208000.0d, 0.000000813316d },
            { 1212000.0d, 0.000000602755d },
            { 1216000.0d, 0.000000422174d },
            { 1220000.0d, 0.000000272455d },
            { 1224000.0d, 0.00000015449d },
            { 1228000.0d, 0.0000000691759d },
            { 1232000.0d, 0.0000000173992d },
            { 1236000.0d, 0d },

        }; 
    }
}
    