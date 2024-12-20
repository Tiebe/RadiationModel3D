using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium159";
        public override double halfLife { get; } = 66524.4d;
        public override double atomicWeight { get; } = 158.9264d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium159()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0248558d, new GammaParticle(58000.0, 0.02138)), new(0.000467666d, new GammaParticle(79513.2, 0.01559)), new(6.467220000000001e-05d, new GammaParticle(137515.0, 0.00902)), new(0.00020025999999999998d, new GammaParticle(210783.0, 0.00588)), new(0.002169876d, new GammaParticle(226040.6, 0.00549)), new(7.69234e-05d, new GammaParticle(237341.0, 0.00522)), new(7.068000000000001e-06d, new GammaParticle(273620.0, 0.00453)), new(5.6544000000000006e-05d, new GammaParticle(274163.0, 0.00452)), new(0.000322772d, new GammaParticle(290286.5, 0.00427)), new(0.000619628d, new GammaParticle(305549.2, 0.00406)), new(0.0023925179999999997d, new GammaParticle(348280.7, 0.00356)), new(0.11779999999999999d, new GammaParticle(363543.0, 0.00341)), new(2.42668e-06d, new GammaParticle(479840.0, 0.00258)), new(1.60208e-05d, new GammaParticle(536780.0, 0.00231)), new(0.000221464d, new GammaParticle(559623.0, 0.00222)), new(0.00068324d, new GammaParticle(580808.0, 0.00213)), new(1.8848e-05d, new GammaParticle(616233.0, 0.00201)), new(0.00015903d, new GammaParticle(617615.0, 0.00201)), new(3.15704e-06d, new GammaParticle(674260.0, 0.00184)), new(1.8023400000000001e-06d, new GammaParticle(753740.0, 0.00164)), new(2.4620200000000002e-05d, new GammaParticle(854947.0, 0.00145)), new(0.041968828290531605d, new GammaParticle(7118.0, 0.17418)), new(0.058999604389243385d, new GammaParticle(43743.0, 0.02834)), new(0.10579093489195515d, new GammaParticle(44481.0, 0.02787)), new(0.03378271500276199d, new GammaParticle(50494.0, 0.02455)), new(0.04253243818847734d, new GammaParticle(51040.0, 0.02429)), new(0.008749723185715355d, new GammaParticle(51699.0, 0.02398)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00176735d },
            { 200.0d, 0.00176726d },
            { 400.0d, 0.00176727d },
            { 600.0d, 0.00176736d },
            { 800.0d, 0.00176753d },
            { 1000.0d, 0.00176776d },
            { 1500.0d, 0.00176844d },
            { 2000.0d, 0.00176924d },
            { 2500.0d, 0.00177013d },
            { 3000.0d, 0.00177112d },
            { 3500.0d, 0.00177217d },
            { 4000.0d, 0.00177328d },
            { 4500.0d, 0.00177445d },
            { 5000.0d, 0.00177569d },
            { 5500.0d, 0.00177699d },
            { 6000.0d, 0.00177836d },
            { 6500.0d, 0.00177956d },
            { 7000.0d, 0.00178075d },
            { 7500.0d, 0.00178191d },
            { 8000.0d, 0.00178305d },
            { 8500.0d, 0.00178416d },
            { 9000.0d, 0.00178525d },
            { 9500.0d, 0.00178626d },
            { 10000.0d, 0.00178724d },
            { 11000.0d, 0.0017891d },
            { 12000.0d, 0.00179082d },
            { 13000.0d, 0.00179253d },
            { 14000.0d, 0.00179415d },
            { 15000.0d, 0.00179571d },
            { 16000.0d, 0.00179725d },
            { 17000.0d, 0.00179874d },
            { 18000.0d, 0.00180019d },
            { 19000.0d, 0.00180161d },
            { 20000.0d, 0.00180301d },
            { 21000.0d, 0.00180437d },
            { 22000.0d, 0.0018057d },
            { 23000.0d, 0.00180702d },
            { 24000.0d, 0.0018083d },
            { 25000.0d, 0.00180957d },
            { 26000.0d, 0.00181081d },
            { 27000.0d, 0.00181203d },
            { 28000.0d, 0.00181323d },
            { 29000.0d, 0.0018144d },
            { 30000.0d, 0.00181556d },
            { 31000.0d, 0.0018167d },
            { 32000.0d, 0.00181782d },
            { 33000.0d, 0.00181893d },
            { 34000.0d, 0.00182001d },
            { 35000.0d, 0.00182108d },
            { 36000.0d, 0.00182213d },
            { 37000.0d, 0.00182316d },
            { 38000.0d, 0.00182418d },
            { 39000.0d, 0.00182518d },
            { 40000.0d, 0.00182616d },
            { 41000.0d, 0.00182713d },
            { 42000.0d, 0.00182808d },
            { 43000.0d, 0.00182902d },
            { 44000.0d, 0.00182995d },
            { 45000.0d, 0.00183086d },
            { 46000.0d, 0.00183175d },
            { 47000.0d, 0.00183263d },
            { 48000.0d, 0.0018335d },
            { 49000.0d, 0.00183435d },
            { 50000.0d, 0.00183519d },
            { 51000.0d, 0.00183601d },
            { 52000.0d, 0.00183683d },
            { 53000.0d, 0.00183762d },
            { 54000.0d, 0.00183841d },
            { 55000.0d, 0.00183918d },
            { 56000.0d, 0.00183994d },
            { 57000.0d, 0.00184069d },
            { 58000.0d, 0.00184142d },
            { 59000.0d, 0.00184214d },
            { 60000.0d, 0.00184285d },
            { 61000.0d, 0.00184355d },
            { 62000.0d, 0.00184423d },
            { 63000.0d, 0.0018449d },
            { 64000.0d, 0.00184556d },
            { 65000.0d, 0.0018462d },
            { 66000.0d, 0.00184684d },
            { 67000.0d, 0.00184746d },
            { 68000.0d, 0.00184807d },
            { 69000.0d, 0.00184866d },
            { 70000.0d, 0.00184925d },
            { 71000.0d, 0.00184982d },
            { 72000.0d, 0.00185038d },
            { 73000.0d, 0.00185093d },
            { 74000.0d, 0.00185147d },
            { 75000.0d, 0.00185199d },
            { 76000.0d, 0.00185251d },
            { 77000.0d, 0.00185301d },
            { 78000.0d, 0.00185349d },
            { 79000.0d, 0.00185397d },
            { 80000.0d, 0.00185444d },
            { 81000.0d, 0.00185489d },
            { 82000.0d, 0.00185533d },
            { 83000.0d, 0.00185576d },
            { 84000.0d, 0.00185617d },
            { 85000.0d, 0.00185658d },
            { 86000.0d, 0.00185697d },
            { 87000.0d, 0.00185735d },
            { 88000.0d, 0.00185772d },
            { 89000.0d, 0.00185807d },
            { 90000.0d, 0.00185842d },
            { 91000.0d, 0.00185875d },
            { 92000.0d, 0.00185907d },
            { 93000.0d, 0.00185938d },
            { 94000.0d, 0.00185967d },
            { 95000.0d, 0.00185995d },
            { 96000.0d, 0.00186022d },
            { 97000.0d, 0.00186048d },
            { 98000.0d, 0.00186073d },
            { 99000.0d, 0.00186096d },
            { 100000.0d, 0.00186119d },
            { 103000.0d, 0.00186178d },
            { 106000.0d, 0.00186227d },
            { 109000.0d, 0.00186264d },
            { 112000.0d, 0.00186291d },
            { 115000.0d, 0.00186306d },
            { 118000.0d, 0.00186311d },
            { 121000.0d, 0.00186303d },
            { 124000.0d, 0.00186284d },
            { 127000.0d, 0.00186253d },
            { 130000.0d, 0.0018621d },
            { 133000.0d, 0.00186155d },
            { 136000.0d, 0.00186088d },
            { 139000.0d, 0.00186009d },
            { 142000.0d, 0.00185919d },
            { 145000.0d, 0.00185816d },
            { 148000.0d, 0.00185702d },
            { 151000.0d, 0.00185575d },
            { 154000.0d, 0.00185437d },
            { 157000.0d, 0.00185286d },
            { 160000.0d, 0.00185124d },
            { 163000.0d, 0.0018495d },
            { 166000.0d, 0.00184763d },
            { 169000.0d, 0.00184565d },
            { 172000.0d, 0.00184355d },
            { 175000.0d, 0.00184133d },
            { 178000.0d, 0.00183899d },
            { 181000.0d, 0.00183653d },
            { 184000.0d, 0.00183395d },
            { 187000.0d, 0.00183125d },
            { 190000.0d, 0.00182844d },
            { 193000.0d, 0.00182551d },
            { 196000.0d, 0.00182246d },
            { 199000.0d, 0.00181929d },
            { 202000.0d, 0.00181601d },
            { 205000.0d, 0.00181261d },
            { 208000.0d, 0.0018091d },
            { 211000.0d, 0.00180546d },
            { 214000.0d, 0.00180172d },
            { 217000.0d, 0.00179786d },
            { 220000.0d, 0.00179388d },
            { 223000.0d, 0.00178979d },
            { 226000.0d, 0.00178559d },
            { 229000.0d, 0.00178128d },
            { 232000.0d, 0.00177685d },
            { 235000.0d, 0.00177232d },
            { 238000.0d, 0.00176767d },
            { 241000.0d, 0.00176291d },
            { 244000.0d, 0.00175804d },
            { 247000.0d, 0.00175307d },
            { 250000.0d, 0.00174798d },
            { 253000.0d, 0.00174279d },
            { 256000.0d, 0.0017375d },
            { 259000.0d, 0.00173209d },
            { 262000.0d, 0.00172658d },
            { 265000.0d, 0.00172097d },
            { 268000.0d, 0.00171526d },
            { 271000.0d, 0.00170944d },
            { 274000.0d, 0.00170352d },
            { 277000.0d, 0.0016975d },
            { 280000.0d, 0.00169138d },
            { 283000.0d, 0.00168515d },
            { 286000.0d, 0.00167884d },
            { 289000.0d, 0.00167242d },
            { 292000.0d, 0.00166591d },
            { 295000.0d, 0.0016593d },
            { 298000.0d, 0.0016526d },
            { 301000.0d, 0.0016458d },
            { 304000.0d, 0.00163891d },
            { 307000.0d, 0.00163193d },
            { 310000.0d, 0.00162486d },
            { 313000.0d, 0.0016177d },
            { 316000.0d, 0.00161046d },
            { 319000.0d, 0.00160312d },
            { 322000.0d, 0.0015957d },
            { 325000.0d, 0.00158819d },
            { 328000.0d, 0.0015806d },
            { 331000.0d, 0.00157293d },
            { 334000.0d, 0.00156517d },
            { 337000.0d, 0.00155733d },
            { 340000.0d, 0.00154942d },
            { 343000.0d, 0.00154142d },
            { 346000.0d, 0.00153335d },
            { 349000.0d, 0.0015252d },
            { 352000.0d, 0.00151698d },
            { 355000.0d, 0.00150869d },
            { 358000.0d, 0.00150032d },
            { 361000.0d, 0.00149188d },
            { 364000.0d, 0.00148337d },
            { 367000.0d, 0.00147479d },
            { 370000.0d, 0.00146615d },
            { 373000.0d, 0.00145743d },
            { 376000.0d, 0.00144865d },
            { 379000.0d, 0.00143981d },
            { 382000.0d, 0.00143091d },
            { 385000.0d, 0.00142194d },
            { 388000.0d, 0.00141292d },
            { 391000.0d, 0.00140384d },
            { 394000.0d, 0.0013947d },
            { 397000.0d, 0.0013855d },
            { 400000.0d, 0.00137625d },
            { 403000.0d, 0.00136694d },
            { 406000.0d, 0.00135759d },
            { 409000.0d, 0.00134818d },
            { 412000.0d, 0.00133872d },
            { 415000.0d, 0.00132921d },
            { 418000.0d, 0.00131966d },
            { 421000.0d, 0.00131006d },
            { 424000.0d, 0.00130042d },
            { 427000.0d, 0.00129074d },
            { 430000.0d, 0.00128102d },
            { 433000.0d, 0.00127126d },
            { 436000.0d, 0.00126146d },
            { 439000.0d, 0.00125163d },
            { 442000.0d, 0.00124176d },
            { 445000.0d, 0.00123186d },
            { 448000.0d, 0.00122193d },
            { 451000.0d, 0.00121197d },
            { 454000.0d, 0.00120198d },
            { 457000.0d, 0.00119197d },
            { 460000.0d, 0.00118193d },
            { 463000.0d, 0.00117187d },
            { 466000.0d, 0.00116179d },
            { 469000.0d, 0.00115169d },
            { 472000.0d, 0.00114157d },
            { 475000.0d, 0.00113144d },
            { 478000.0d, 0.00112129d },
            { 481000.0d, 0.00111113d },
            { 484000.0d, 0.00110096d },
            { 487000.0d, 0.00109078d },
            { 490000.0d, 0.00108059d },
            { 493000.0d, 0.0010704d },
            { 496000.0d, 0.0010602d },
            { 499000.0d, 0.00105001d },
            { 502000.0d, 0.00103981d },
            { 505000.0d, 0.00102962d },
            { 508000.0d, 0.00101942d },
            { 511000.0d, 0.00100924d },
            { 514000.0d, 0.00099906d },
            { 517000.0d, 0.000988892d },
            { 520000.0d, 0.000978735d },
            { 523000.0d, 0.00096859d },
            { 526000.0d, 0.000958461d },
            { 529000.0d, 0.00094835d },
            { 532000.0d, 0.000938257d },
            { 535000.0d, 0.000928184d },
            { 538000.0d, 0.000918135d },
            { 541000.0d, 0.00090811d },
            { 544000.0d, 0.000898112d },
            { 547000.0d, 0.000888143d },
            { 550000.0d, 0.000878205d },
            { 553000.0d, 0.000868298d },
            { 556000.0d, 0.000858427d },
            { 559000.0d, 0.000848592d },
            { 562000.0d, 0.000838797d },
            { 565000.0d, 0.000829042d },
            { 568000.0d, 0.000819329d },
            { 571000.0d, 0.000809662d },
            { 574000.0d, 0.000800042d },
            { 577000.0d, 0.000790469d },
            { 580000.0d, 0.000780949d },
            { 583000.0d, 0.000771481d },
            { 586000.0d, 0.00076207d },
            { 589000.0d, 0.000752715d },
            { 592000.0d, 0.000743419d },
            { 595000.0d, 0.000734186d },
            { 598000.0d, 0.000725016d },
            { 601000.0d, 0.000715911d },
            { 604000.0d, 0.000706875d },
            { 607000.0d, 0.000697909d },
            { 610000.0d, 0.000688978d },
            { 613000.0d, 0.00068005d },
            { 616000.0d, 0.000671125d },
            { 619000.0d, 0.000662204d },
            { 622000.0d, 0.000653288d },
            { 625000.0d, 0.000644379d },
            { 628000.0d, 0.000635477d },
            { 631000.0d, 0.000626582d },
            { 634000.0d, 0.000617696d },
            { 637000.0d, 0.00060882d },
            { 640000.0d, 0.000599955d },
            { 643000.0d, 0.000591102d },
            { 646000.0d, 0.000582263d },
            { 649000.0d, 0.000573439d },
            { 652000.0d, 0.000564632d },
            { 655000.0d, 0.000555842d },
            { 658000.0d, 0.00054707d },
            { 661000.0d, 0.000538319d },
            { 664000.0d, 0.000529591d },
            { 667000.0d, 0.000520883d },
            { 670000.0d, 0.000512199d },
            { 673000.0d, 0.000503541d },
            { 676000.0d, 0.00049491d },
            { 679000.0d, 0.000486306d },
            { 682000.0d, 0.000477731d },
            { 685000.0d, 0.000469187d },
            { 688000.0d, 0.000460675d },
            { 691000.0d, 0.000452196d },
            { 694000.0d, 0.000443752d },
            { 697000.0d, 0.000435343d },
            { 700000.0d, 0.000426972d },
            { 703000.0d, 0.000418639d },
            { 706000.0d, 0.000410346d },
            { 709000.0d, 0.000402094d },
            { 712000.0d, 0.000393886d },
            { 715000.0d, 0.000385721d },
            { 718000.0d, 0.000377601d },
            { 721000.0d, 0.000369528d },
            { 724000.0d, 0.000361504d },
            { 727000.0d, 0.00035353d },
            { 730000.0d, 0.000345606d },
            { 733000.0d, 0.000337735d },
            { 736000.0d, 0.000329918d },
            { 739000.0d, 0.000322156d },
            { 742000.0d, 0.000314451d },
            { 745000.0d, 0.000306804d },
            { 748000.0d, 0.000299217d },
            { 751000.0d, 0.000291692d },
            { 754000.0d, 0.000284229d },
            { 757000.0d, 0.00027683d },
            { 760000.0d, 0.000269496d },
            { 763000.0d, 0.000262229d },
            { 766000.0d, 0.000255031d },
            { 769000.0d, 0.000247903d },
            { 772000.0d, 0.000240846d },
            { 775000.0d, 0.000233862d },
            { 778000.0d, 0.000226953d },
            { 781000.0d, 0.00022012d },
            { 784000.0d, 0.000213364d },
            { 787000.0d, 0.000206687d },
            { 790000.0d, 0.000200091d },
            { 793000.0d, 0.000193576d },
            { 796000.0d, 0.000187146d },
            { 799000.0d, 0.000180801d },
            { 802000.0d, 0.000174542d },
            { 805000.0d, 0.000168371d },
            { 808000.0d, 0.000162291d },
            { 811000.0d, 0.000156301d },
            { 814000.0d, 0.000150404d },
            { 817000.0d, 0.000144602d },
            { 820000.0d, 0.000138896d },
            { 823000.0d, 0.000133288d },
            { 826000.0d, 0.000127778d },
            { 829000.0d, 0.00012237d },
            { 832000.0d, 0.000117064d },
            { 835000.0d, 0.000111862d },
            { 838000.0d, 0.000106765d },
            { 841000.0d, 0.000101776d },
            { 844000.0d, 0.0000968958d },
            { 847000.0d, 0.0000921257d },
            { 850000.0d, 0.0000874677d },
            { 853000.0d, 0.0000829233d },
            { 856000.0d, 0.0000784942d },
            { 859000.0d, 0.0000741821d },
            { 862000.0d, 0.0000699886d },
            { 865000.0d, 0.0000659153d },
            { 868000.0d, 0.0000619638d },
            { 871000.0d, 0.0000581359d },
            { 874000.0d, 0.0000544331d },
            { 877000.0d, 0.0000508571d },
            { 880000.0d, 0.0000474096d },
            { 883000.0d, 0.0000440923d },
            { 886000.0d, 0.0000409067d },
            { 889000.0d, 0.0000378547d },
            { 892000.0d, 0.0000349378d },
            { 895000.0d, 0.0000321578d },
            { 898000.0d, 0.0000295162d },
            { 901000.0d, 0.0000270148d },
            { 904000.0d, 0.0000246551d },
            { 907000.0d, 0.000022439d },
            { 910000.0d, 0.0000203679d },
            { 913000.0d, 0.0000184425d },
            { 916000.0d, 0.0000166252d },
            { 919000.0d, 0.000014896d },
            { 922000.0d, 0.000013256d },
            { 925000.0d, 0.0000117061d },
            { 928000.0d, 0.0000102476d },
            { 931000.0d, 0.00000888123d },
            { 934000.0d, 0.00000760833d },
            { 937000.0d, 0.00000642988d },
            { 940000.0d, 0.00000534694d },
            { 943000.0d, 0.00000436056d },
            { 946000.0d, 0.00000347182d },
            { 949000.0d, 0.00000268175d },
            { 952000.0d, 0.00000199143d },
            { 955000.0d, 0.0000014019d },
            { 958000.0d, 0.000000914199d },
            { 961000.0d, 0.000000529336d },
            { 964000.0d, 0.000000248321d },
            { 967000.0d, 0.0000000720967d },
            { 970000.0d, 0.00000000146478d },
            { 970500.0d, 0d },

        }; 
    }
}
    