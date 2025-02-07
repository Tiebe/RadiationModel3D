using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum90 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum90";
        public override double halfLife { get; } = 20016.0d;
        public override double atomicWeight { get; } = 89.91393d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium90()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(2.0000000000000002e-11d, new GammaParticle(2300.0, 0.53906)), new(0.021671999999999997d, new GammaParticle(42700.0, 0.02904)), new(0.64242d, new GammaParticle(122370.0, 0.01013)), new(0.059598000000000005d, new GammaParticle(162930.0, 0.00761)), new(0.063468d, new GammaParticle(203130.0, 0.0061)), new(0.774d, new GammaParticle(257340.0, 0.00482)), new(0.062694d, new GammaParticle(323200.0, 0.00384)), new(0.0024768d, new GammaParticle(421000.0, 0.00294)), new(0.0035604d, new GammaParticle(425100.0, 0.00292)), new(0.009288d, new GammaParticle(440500.0, 0.00281)), new(0.059598000000000005d, new GammaParticle(445370.0, 0.00278)), new(0.0141642d, new GammaParticle(472200.0, 0.00263)), new(0.0072756d, new GammaParticle(489800.0, 0.00253)), new(0.001548d, new GammaParticle(517700.0, 0.00239)), new(0.054954d, new GammaParticle(941500.0, 0.00132)), new(0.006966d, new GammaParticle(946400.0, 0.00131)), new(0.0013932d, new GammaParticle(987300.0, 0.00126)), new(0.0101394d, new GammaParticle(990200.0, 0.00125)), new(0.041021999999999996d, new GammaParticle(1271300.0, 0.00098)), new(0.018576d, new GammaParticle(1387400.0, 0.00089)), new(0.0004644d, new GammaParticle(1446000.0, 0.00086)), new(0.018576d, new GammaParticle(1454600.0, 0.00085)), new(0.006966d, new GammaParticle(1463500.0, 0.00085)), new(0.002322d, new GammaParticle(1481600.0, 0.00084)), new(0.5d, new GammaParticle(511000.0, 0.00243)), new(0.045381919930565534d, new GammaParticle(2299.0, 0.5393)), new(0.23796515071133598d, new GammaParticle(16521.0, 0.07505)), new(0.4544788974624446d, new GammaParticle(16615.0, 0.07462)), new(0.11759506313768639d, new GammaParticle(18694.0, 0.06632)), new(0.13523432260833934d, new GammaParticle(18795.0, 0.06597)), new(0.01763925947065296d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 400.0d, 0.000000000000606894d },
            { 800.0d, 0.00000000000176562d },
            { 1200.0d, 0.00000000000373771d },
            { 1700.0d, 0.00000000458037d },
            { 2200.0d, 0.0000000183601d },
            { 2700.0d, 0.0000000377918d },
            { 3200.0d, 0.0000000628757d },
            { 3700.0d, 0.0000000936122d },
            { 4200.0d, 0.000000130002d },
            { 4700.0d, 0.000000172044d },
            { 5200.0d, 0.00000021974d },
            { 5700.0d, 0.000000273089d },
            { 6200.0d, 0.000000336582d },
            { 6700.0d, 0.000000414917d },
            { 7200.0d, 0.000000502412d },
            { 7700.0d, 0.000000599069d },
            { 8200.0d, 0.000000704888d },
            { 8700.0d, 0.000000819867d },
            { 9200.0d, 0.00000094644d },
            { 9700.0d, 0.00000108715d },
            { 10000.0d, 0.00000117689d },
            { 11000.0d, 0.00000150477d },
            { 12000.0d, 0.00000187689d },
            { 13000.0d, 0.00000229838d },
            { 14000.0d, 0.00000276667d },
            { 15000.0d, 0.00000328176d },
            { 16000.0d, 0.00000384237d },
            { 17000.0d, 0.00000444915d },
            { 18000.0d, 0.00000510209d },
            { 19000.0d, 0.0000057963d },
            { 20000.0d, 0.00000653423d },
            { 21000.0d, 0.00000731587d },
            { 22000.0d, 0.00000813451d },
            { 23000.0d, 0.00000899351d },
            { 24000.0d, 0.00000989287d },
            { 25000.0d, 0.0000108251d },
            { 26000.0d, 0.0000117941d },
            { 27000.0d, 0.0000127996d },
            { 28000.0d, 0.0000138343d },
            { 29000.0d, 0.0000149019d },
            { 30000.0d, 0.0000160025d },
            { 31000.0d, 0.0000171286d },
            { 32000.0d, 0.0000182841d },
            { 33000.0d, 0.0000194689d },
            { 34000.0d, 0.0000206761d },
            { 35000.0d, 0.0000219093d },
            { 36000.0d, 0.0000231683d },
            { 37000.0d, 0.000024447d },
            { 38000.0d, 0.0000257486d },
            { 39000.0d, 0.000027073d },
            { 40000.0d, 0.0000284144d },
            { 41000.0d, 0.0000297759d },
            { 42000.0d, 0.0000311572d },
            { 43000.0d, 0.0000325535d },
            { 44000.0d, 0.0000339672d },
            { 45000.0d, 0.0000353982d },
            { 46000.0d, 0.0000368421d },
            { 47000.0d, 0.0000383011d },
            { 48000.0d, 0.0000397752d },
            { 49000.0d, 0.0000412604d },
            { 50000.0d, 0.0000427585d },
            { 51000.0d, 0.0000442698d },
            { 52000.0d, 0.0000457904d },
            { 53000.0d, 0.0000473223d },
            { 54000.0d, 0.0000488653d },
            { 55000.0d, 0.0000504163d },
            { 56000.0d, 0.0000519768d },
            { 57000.0d, 0.0000535469d },
            { 58000.0d, 0.0000551236d },
            { 59000.0d, 0.0000567083d },
            { 60000.0d, 0.0000583011d },
            { 61000.0d, 0.0000598995d },
            { 62000.0d, 0.0000615046d },
            { 63000.0d, 0.0000631164d },
            { 64000.0d, 0.0000647327d },
            { 65000.0d, 0.0000663546d },
            { 66000.0d, 0.000067982d },
            { 67000.0d, 0.0000696129d },
            { 68000.0d, 0.0000712484d },
            { 69000.0d, 0.0000728883d },
            { 70000.0d, 0.0000745309d },
            { 71000.0d, 0.000076177d },
            { 72000.0d, 0.0000778267d },
            { 73000.0d, 0.0000794783d },
            { 74000.0d, 0.0000811327d },
            { 75000.0d, 0.0000827898d },
            { 76000.0d, 0.000084448d },
            { 77000.0d, 0.0000861082d },
            { 78000.0d, 0.0000877704d },
            { 79000.0d, 0.0000894331d },
            { 80000.0d, 0.0000910972d },
            { 81000.0d, 0.0000927625d },
            { 82000.0d, 0.0000944278d },
            { 83000.0d, 0.0000960938d },
            { 84000.0d, 0.0000977604d },
            { 85000.0d, 0.0000994265d },
            { 86000.0d, 0.000101093d },
            { 87000.0d, 0.000102759d },
            { 88000.0d, 0.000104424d },
            { 89000.0d, 0.000106089d },
            { 90000.0d, 0.000107754d },
            { 91000.0d, 0.000109417d },
            { 92000.0d, 0.000111079d },
            { 93000.0d, 0.00011274d },
            { 94000.0d, 0.0001144d },
            { 95000.0d, 0.000116059d },
            { 96000.0d, 0.000117717d },
            { 97000.0d, 0.000119372d },
            { 98000.0d, 0.000121025d },
            { 99000.0d, 0.000122677d },
            { 100000.0d, 0.000124327d },
            { 103000.0d, 0.000129262d },
            { 106000.0d, 0.000134176d },
            { 109000.0d, 0.000139066d },
            { 112000.0d, 0.00014393d },
            { 115000.0d, 0.000148765d },
            { 118000.0d, 0.00015357d },
            { 121000.0d, 0.000158343d },
            { 124000.0d, 0.000163083d },
            { 127000.0d, 0.000167788d },
            { 130000.0d, 0.000172457d },
            { 133000.0d, 0.000177087d },
            { 136000.0d, 0.00018168d },
            { 139000.0d, 0.000186233d },
            { 142000.0d, 0.000190746d },
            { 145000.0d, 0.000195218d },
            { 148000.0d, 0.000199647d },
            { 151000.0d, 0.000204033d },
            { 154000.0d, 0.000208377d },
            { 157000.0d, 0.000212676d },
            { 160000.0d, 0.000216931d },
            { 163000.0d, 0.000221141d },
            { 166000.0d, 0.000225306d },
            { 169000.0d, 0.000229425d },
            { 172000.0d, 0.000233497d },
            { 175000.0d, 0.000237523d },
            { 178000.0d, 0.000241502d },
            { 181000.0d, 0.000245433d },
            { 184000.0d, 0.000249318d },
            { 187000.0d, 0.000253155d },
            { 190000.0d, 0.000256944d },
            { 193000.0d, 0.000260685d },
            { 196000.0d, 0.000264377d },
            { 199000.0d, 0.000268021d },
            { 202000.0d, 0.000271617d },
            { 205000.0d, 0.000275164d },
            { 208000.0d, 0.000278662d },
            { 211000.0d, 0.000282111d },
            { 214000.0d, 0.000285511d },
            { 217000.0d, 0.000288863d },
            { 220000.0d, 0.000292165d },
            { 223000.0d, 0.000295418d },
            { 226000.0d, 0.000298621d },
            { 229000.0d, 0.000301776d },
            { 232000.0d, 0.000304881d },
            { 235000.0d, 0.000307937d },
            { 238000.0d, 0.000310944d },
            { 241000.0d, 0.0003139d },
            { 244000.0d, 0.000316809d },
            { 247000.0d, 0.000319667d },
            { 250000.0d, 0.000322477d },
            { 253000.0d, 0.000325236d },
            { 256000.0d, 0.000327947d },
            { 259000.0d, 0.000330609d },
            { 262000.0d, 0.000333221d },
            { 265000.0d, 0.000335785d },
            { 268000.0d, 0.0003383d },
            { 271000.0d, 0.000340765d },
            { 274000.0d, 0.000343181d },
            { 277000.0d, 0.000345549d },
            { 280000.0d, 0.000347867d },
            { 283000.0d, 0.000350137d },
            { 286000.0d, 0.000352359d },
            { 289000.0d, 0.000354532d },
            { 292000.0d, 0.000356656d },
            { 295000.0d, 0.000358732d },
            { 298000.0d, 0.000360759d },
            { 301000.0d, 0.000362738d },
            { 304000.0d, 0.000364669d },
            { 307000.0d, 0.000366552d },
            { 310000.0d, 0.000368387d },
            { 313000.0d, 0.000370175d },
            { 316000.0d, 0.000371915d },
            { 319000.0d, 0.000373607d },
            { 322000.0d, 0.000375251d },
            { 325000.0d, 0.000376847d },
            { 328000.0d, 0.000378397d },
            { 331000.0d, 0.0003799d },
            { 334000.0d, 0.000381355d },
            { 337000.0d, 0.000382763d },
            { 340000.0d, 0.000384126d },
            { 343000.0d, 0.00038544d },
            { 346000.0d, 0.00038671d },
            { 349000.0d, 0.000387931d },
            { 352000.0d, 0.000389108d },
            { 355000.0d, 0.000390237d },
            { 358000.0d, 0.000391321d },
            { 361000.0d, 0.00039236d },
            { 364000.0d, 0.000393353d },
            { 367000.0d, 0.0003943d },
            { 370000.0d, 0.000395201d },
            { 373000.0d, 0.000396058d },
            { 376000.0d, 0.000396869d },
            { 379000.0d, 0.000397636d },
            { 382000.0d, 0.000398358d },
            { 385000.0d, 0.000399036d },
            { 388000.0d, 0.000399668d },
            { 391000.0d, 0.000400258d },
            { 394000.0d, 0.000400803d },
            { 397000.0d, 0.000401303d },
            { 400000.0d, 0.000401761d },
            { 403000.0d, 0.000402175d },
            { 406000.0d, 0.000402546d },
            { 409000.0d, 0.000402873d },
            { 412000.0d, 0.000403158d },
            { 415000.0d, 0.0004034d },
            { 418000.0d, 0.0004036d },
            { 421000.0d, 0.000403757d },
            { 424000.0d, 0.000403872d },
            { 427000.0d, 0.000403945d },
            { 430000.0d, 0.000403976d },
            { 433000.0d, 0.000403965d },
            { 436000.0d, 0.000403914d },
            { 439000.0d, 0.000403822d },
            { 442000.0d, 0.000403688d },
            { 445000.0d, 0.000403513d },
            { 448000.0d, 0.000403298d },
            { 451000.0d, 0.000403044d },
            { 454000.0d, 0.000402748d },
            { 457000.0d, 0.000402414d },
            { 460000.0d, 0.000402039d },
            { 463000.0d, 0.000401626d },
            { 466000.0d, 0.000401173d },
            { 469000.0d, 0.000400681d },
            { 472000.0d, 0.00040015d },
            { 475000.0d, 0.000399581d },
            { 478000.0d, 0.000398974d },
            { 481000.0d, 0.000398329d },
            { 484000.0d, 0.000397646d },
            { 487000.0d, 0.000396927d },
            { 490000.0d, 0.000396169d },
            { 493000.0d, 0.000395375d },
            { 496000.0d, 0.000394544d },
            { 499000.0d, 0.000393677d },
            { 502000.0d, 0.000392773d },
            { 505000.0d, 0.000391834d },
            { 508000.0d, 0.000390859d },
            { 511000.0d, 0.000389848d },
            { 514000.0d, 0.000388803d },
            { 517000.0d, 0.000387722d },
            { 520000.0d, 0.000386608d },
            { 523000.0d, 0.000385458d },
            { 526000.0d, 0.000384275d },
            { 529000.0d, 0.000383058d },
            { 532000.0d, 0.000381807d },
            { 535000.0d, 0.000380523d },
            { 538000.0d, 0.000379207d },
            { 541000.0d, 0.000377858d },
            { 544000.0d, 0.000376477d },
            { 547000.0d, 0.000375063d },
            { 550000.0d, 0.000373618d },
            { 553000.0d, 0.000372141d },
            { 556000.0d, 0.000370634d },
            { 559000.0d, 0.000369096d },
            { 562000.0d, 0.000367527d },
            { 565000.0d, 0.000365928d },
            { 568000.0d, 0.000364299d },
            { 571000.0d, 0.00036264d },
            { 574000.0d, 0.000360952d },
            { 577000.0d, 0.000359236d },
            { 580000.0d, 0.00035749d },
            { 583000.0d, 0.000355717d },
            { 586000.0d, 0.000353915d },
            { 589000.0d, 0.000352086d },
            { 592000.0d, 0.000350229d },
            { 595000.0d, 0.000348346d },
            { 598000.0d, 0.000346436d },
            { 601000.0d, 0.0003445d },
            { 604000.0d, 0.000342537d },
            { 607000.0d, 0.00034055d },
            { 610000.0d, 0.000338536d },
            { 613000.0d, 0.000336499d },
            { 616000.0d, 0.000334436d },
            { 619000.0d, 0.000332349d },
            { 622000.0d, 0.000330239d },
            { 625000.0d, 0.000328104d },
            { 628000.0d, 0.000325947d },
            { 631000.0d, 0.000323767d },
            { 634000.0d, 0.000321564d },
            { 637000.0d, 0.00031934d },
            { 640000.0d, 0.000317094d },
            { 643000.0d, 0.000314827d },
            { 646000.0d, 0.000312538d },
            { 649000.0d, 0.000310229d },
            { 652000.0d, 0.000307901d },
            { 655000.0d, 0.000305552d },
            { 658000.0d, 0.000303183d },
            { 661000.0d, 0.000300796d },
            { 664000.0d, 0.00029839d },
            { 667000.0d, 0.000295966d },
            { 670000.0d, 0.000293524d },
            { 673000.0d, 0.000291064d },
            { 676000.0d, 0.000288589d },
            { 679000.0d, 0.000286095d },
            { 682000.0d, 0.000283586d },
            { 685000.0d, 0.000281061d },
            { 688000.0d, 0.00027852d },
            { 691000.0d, 0.000275965d },
            { 694000.0d, 0.000273395d },
            { 697000.0d, 0.00027081d },
            { 700000.0d, 0.000268211d },
            { 703000.0d, 0.0002656d },
            { 706000.0d, 0.000262976d },
            { 709000.0d, 0.00026034d },
            { 712000.0d, 0.000257691d },
            { 715000.0d, 0.00025503d },
            { 718000.0d, 0.000252358d },
            { 721000.0d, 0.000249676d },
            { 724000.0d, 0.000246982d },
            { 727000.0d, 0.00024428d },
            { 730000.0d, 0.000241568d },
            { 733000.0d, 0.000238846d },
            { 736000.0d, 0.000236116d },
            { 739000.0d, 0.000233379d },
            { 742000.0d, 0.000230633d },
            { 745000.0d, 0.000227881d },
            { 748000.0d, 0.000225121d },
            { 751000.0d, 0.000222355d },
            { 754000.0d, 0.000219584d },
            { 757000.0d, 0.000216807d },
            { 760000.0d, 0.000214025d },
            { 763000.0d, 0.000211239d },
            { 766000.0d, 0.000208449d },
            { 769000.0d, 0.000205655d },
            { 772000.0d, 0.000202859d },
            { 775000.0d, 0.00020006d },
            { 778000.0d, 0.000197259d },
            { 781000.0d, 0.000194456d },
            { 784000.0d, 0.000191652d },
            { 787000.0d, 0.000188848d },
            { 790000.0d, 0.000186043d },
            { 793000.0d, 0.00018324d },
            { 796000.0d, 0.000180437d },
            { 799000.0d, 0.000177635d },
            { 802000.0d, 0.000174835d },
            { 805000.0d, 0.000172038d },
            { 808000.0d, 0.000169244d },
            { 811000.0d, 0.000166453d },
            { 814000.0d, 0.000163665d },
            { 817000.0d, 0.000160883d },
            { 820000.0d, 0.000158106d },
            { 823000.0d, 0.000155334d },
            { 826000.0d, 0.000152568d },
            { 829000.0d, 0.000149808d },
            { 832000.0d, 0.000147055d },
            { 835000.0d, 0.000144311d },
            { 838000.0d, 0.000141574d },
            { 841000.0d, 0.000138846d },
            { 844000.0d, 0.000136127d },
            { 847000.0d, 0.000133418d },
            { 850000.0d, 0.000130719d },
            { 853000.0d, 0.000128031d },
            { 856000.0d, 0.000125354d },
            { 859000.0d, 0.000122689d },
            { 862000.0d, 0.000120036d },
            { 865000.0d, 0.000117397d },
            { 868000.0d, 0.000114771d },
            { 871000.0d, 0.000112159d },
            { 874000.0d, 0.000109562d },
            { 877000.0d, 0.00010698d },
            { 880000.0d, 0.000104413d },
            { 883000.0d, 0.000101864d },
            { 886000.0d, 0.0000993316d },
            { 889000.0d, 0.0000968157d },
            { 892000.0d, 0.0000943184d },
            { 895000.0d, 0.0000918397d },
            { 898000.0d, 0.0000893802d },
            { 901000.0d, 0.0000869405d },
            { 904000.0d, 0.0000845212d },
            { 907000.0d, 0.0000821228d },
            { 910000.0d, 0.000079746d },
            { 913000.0d, 0.0000773913d },
            { 916000.0d, 0.0000750594d },
            { 919000.0d, 0.0000727507d },
            { 922000.0d, 0.0000704661d },
            { 925000.0d, 0.0000682059d },
            { 928000.0d, 0.0000659708d },
            { 931000.0d, 0.0000637615d },
            { 934000.0d, 0.0000615784d },
            { 937000.0d, 0.0000594224d },
            { 940000.0d, 0.0000572938d },
            { 943000.0d, 0.0000551935d },
            { 946000.0d, 0.0000531218d },
            { 949000.0d, 0.0000510796d },
            { 952000.0d, 0.0000490674d },
            { 955000.0d, 0.0000470858d },
            { 958000.0d, 0.0000451354d },
            { 961000.0d, 0.000043217d },
            { 964000.0d, 0.000041331d },
            { 967000.0d, 0.0000394782d },
            { 970000.0d, 0.0000376592d },
            { 973000.0d, 0.0000358745d },
            { 976000.0d, 0.000034125d },
            { 979000.0d, 0.000032411d },
            { 982000.0d, 0.0000307334d },
            { 985000.0d, 0.0000290927d },
            { 988000.0d, 0.0000274897d },
            { 991000.0d, 0.0000259248d },
            { 994000.0d, 0.000024399d },
            { 997000.0d, 0.0000229126d },
            { 1000000.0d, 0.0000214665d },
            { 1003000.0d, 0.0000200612d },
            { 1006000.0d, 0.0000186974d },
            { 1009000.0d, 0.0000173758d },
            { 1012000.0d, 0.0000160971d },
            { 1015000.0d, 0.0000148619d },
            { 1018000.0d, 0.0000136709d },
            { 1021000.0d, 0.0000125246d },
            { 1024000.0d, 0.0000114238d },
            { 1027000.0d, 0.0000103693d },
            { 1030000.0d, 0.00000936158d },
            { 1033000.0d, 0.00000840138d },
            { 1036000.0d, 0.00000748937d },
            { 1039000.0d, 0.00000662622d },
            { 1042000.0d, 0.00000581262d },
            { 1045000.0d, 0.00000504923d },
            { 1048000.0d, 0.00000433675d },
            { 1051000.0d, 0.00000367585d },
            { 1054000.0d, 0.0000030672d },
            { 1057000.0d, 0.00000251149d },
            { 1060000.0d, 0.0000020094d },
            { 1063000.0d, 0.0000015616d },
            { 1066000.0d, 0.00000116878d },
            { 1069000.0d, 0.000000831603d },
            { 1072000.0d, 0.000000550736d },
            { 1075000.0d, 0.000000326842d },
            { 1078000.0d, 0.000000160566d },
            { 1081000.0d, 0.0000000525302d },
            { 1084000.0d, 0.0000000032804d },
            { 1085000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    