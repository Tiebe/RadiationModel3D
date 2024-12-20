using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine116 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine116";
        public override double halfLife { get; } = 2.91d;
        public override double atomicWeight { get; } = 115.91689d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony116()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0017613000000000001d, new GammaParticle(380880.0, 0.00326)), new(0.012654d, new GammaParticle(540210.0, 0.0023)), new(0.0007695d, new GammaParticle(577910.0, 0.00215)), new(0.0855d, new GammaParticle(678920.0, 0.00183)), new(0.00042750000000000004d, new GammaParticle(681000.0, 0.00182)), new(0.00062415d, new GammaParticle(742700.0, 0.00167)), new(0.002565d, new GammaParticle(861840.0, 0.00144)), new(0.0048222d, new GammaParticle(958660.0, 0.00129)), new(0.0016416d, new GammaParticle(1132570.0, 0.00109)), new(1.71e-05d, new GammaParticle(1219000.0, 0.00102)), new(4.275e-05d, new GammaParticle(1360000.0, 0.00091)), new(0.0007352999999999999d, new GammaParticle(1368100.0, 0.00091)), new(0.00507015d, new GammaParticle(1402010.0, 0.00088)), new(0.0008721d, new GammaParticle(1633000.0, 0.00076)), new(7.695e-05d, new GammaParticle(1637000.0, 0.00076)), new(1.71e-05d, new GammaParticle(1811000.0, 0.00068)), new(0.00156465d, new GammaParticle(1903830.0, 0.00065)), new(0.00029925d, new GammaParticle(2081000.0, 0.0006)), new(0.0005985d, new GammaParticle(2154400.0, 0.00058)), new(1.9340000000000002d, new GammaParticle(511000.0, 0.00243)), new(0.0021527869874d, new GammaParticle(4135.0, 0.29984)), new(0.005944455814672398d, new GammaParticle(27202.0, 0.04558)), new(0.011069750120432771d, new GammaParticle(27473.0, 0.04513)), new(0.0031679696506941913d, new GammaParticle(31093.0, 0.03988)), new(0.003855419064894831d, new GammaParticle(31359.0, 0.03954)), new(0.0006874494142006394d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 15000.0d, 0.0000000769726d },
            { 30000.0d, 0.000000494023d },
            { 45000.0d, 0.00000124717d },
            { 60000.0d, 0.00000227485d },
            { 75000.0d, 0.00000351357d },
            { 90000.0d, 0.00000490729d },
            { 105000.0d, 0.00000640631d },
            { 120000.0d, 0.00000799347d },
            { 135000.0d, 0.00000964658d },
            { 150000.0d, 0.0000113501d },
            { 165000.0d, 0.0000130961d },
            { 180000.0d, 0.0000148769d },
            { 195000.0d, 0.0000166853d },
            { 210000.0d, 0.0000185179d },
            { 225000.0d, 0.0000203716d },
            { 240000.0d, 0.0000222432d },
            { 255000.0d, 0.0000241302d },
            { 270000.0d, 0.0000260315d },
            { 285000.0d, 0.0000279454d },
            { 300000.0d, 0.0000298705d },
            { 315000.0d, 0.000031806d },
            { 330000.0d, 0.0000337509d },
            { 345000.0d, 0.0000357042d },
            { 360000.0d, 0.0000376655d },
            { 375000.0d, 0.0000396341d },
            { 390000.0d, 0.0000416093d },
            { 405000.0d, 0.0000435907d },
            { 420000.0d, 0.0000455778d },
            { 435000.0d, 0.00004757d },
            { 450000.0d, 0.000049567d },
            { 465000.0d, 0.0000515684d },
            { 480000.0d, 0.0000535737d },
            { 495000.0d, 0.0000555826d },
            { 510000.0d, 0.0000575947d },
            { 525000.0d, 0.0000596097d },
            { 540000.0d, 0.0000616272d },
            { 555000.0d, 0.0000636468d },
            { 570000.0d, 0.0000656681d },
            { 585000.0d, 0.000067691d },
            { 600000.0d, 0.000069715d },
            { 615000.0d, 0.0000717399d },
            { 630000.0d, 0.0000737653d },
            { 645000.0d, 0.0000757908d },
            { 660000.0d, 0.0000778163d },
            { 675000.0d, 0.0000798414d },
            { 690000.0d, 0.0000818657d },
            { 705000.0d, 0.0000838891d },
            { 720000.0d, 0.0000859111d },
            { 735000.0d, 0.0000879315d },
            { 750000.0d, 0.0000899501d },
            { 765000.0d, 0.0000919666d },
            { 780000.0d, 0.0000939805d },
            { 795000.0d, 0.0000959918d },
            { 810000.0d, 0.000098d },
            { 825000.0d, 0.000100005d },
            { 840000.0d, 0.000102007d },
            { 855000.0d, 0.000104004d },
            { 870000.0d, 0.000105998d },
            { 885000.0d, 0.000107987d },
            { 900000.0d, 0.000109971d },
            { 915000.0d, 0.000111951d },
            { 930000.0d, 0.000113926d },
            { 945000.0d, 0.000115895d },
            { 960000.0d, 0.000117859d },
            { 975000.0d, 0.000119816d },
            { 990000.0d, 0.000121768d },
            { 1005000.0d, 0.000123713d },
            { 1027000.0d, 0.000126554d },
            { 1049000.0d, 0.00012938d },
            { 1071000.0d, 0.00013219d },
            { 1093000.0d, 0.000134984d },
            { 1115000.0d, 0.000137761d },
            { 1137000.0d, 0.00014052d },
            { 1159000.0d, 0.00014326d },
            { 1181000.0d, 0.000145981d },
            { 1203000.0d, 0.000148683d },
            { 1225000.0d, 0.000151363d },
            { 1247000.0d, 0.000154023d },
            { 1269000.0d, 0.00015666d },
            { 1291000.0d, 0.000159275d },
            { 1313000.0d, 0.000161868d },
            { 1335000.0d, 0.000164436d },
            { 1357000.0d, 0.00016698d },
            { 1379000.0d, 0.000169499d },
            { 1401000.0d, 0.000171993d },
            { 1423000.0d, 0.000174461d },
            { 1445000.0d, 0.000176902d },
            { 1467000.0d, 0.000179316d },
            { 1489000.0d, 0.000181703d },
            { 1511000.0d, 0.000184062d },
            { 1533000.0d, 0.000186391d },
            { 1555000.0d, 0.000188691d },
            { 1577000.0d, 0.000190963d },
            { 1599000.0d, 0.000193204d },
            { 1621000.0d, 0.000195414d },
            { 1643000.0d, 0.000197593d },
            { 1665000.0d, 0.000199741d },
            { 1687000.0d, 0.000201857d },
            { 1709000.0d, 0.000203941d },
            { 1731000.0d, 0.000205992d },
            { 1753000.0d, 0.000208009d },
            { 1775000.0d, 0.000209993d },
            { 1797000.0d, 0.000211943d },
            { 1819000.0d, 0.000213859d },
            { 1841000.0d, 0.00021574d },
            { 1863000.0d, 0.000217587d },
            { 1885000.0d, 0.000219397d },
            { 1907000.0d, 0.000221172d },
            { 1929000.0d, 0.000222912d },
            { 1951000.0d, 0.000224614d },
            { 1973000.0d, 0.00022628d },
            { 1995000.0d, 0.000227909d },
            { 2017000.0d, 0.000229501d },
            { 2039000.0d, 0.000231055d },
            { 2061000.0d, 0.000232572d },
            { 2083000.0d, 0.00023405d },
            { 2105000.0d, 0.00023549d },
            { 2127000.0d, 0.000236892d },
            { 2149000.0d, 0.000238255d },
            { 2171000.0d, 0.000239579d },
            { 2193000.0d, 0.000240863d },
            { 2215000.0d, 0.000242108d },
            { 2237000.0d, 0.000243313d },
            { 2259000.0d, 0.000244479d },
            { 2281000.0d, 0.000245605d },
            { 2303000.0d, 0.00024669d },
            { 2325000.0d, 0.000247735d },
            { 2347000.0d, 0.00024874d },
            { 2369000.0d, 0.000249704d },
            { 2391000.0d, 0.000250627d },
            { 2413000.0d, 0.00025151d },
            { 2435000.0d, 0.000252351d },
            { 2457000.0d, 0.000253151d },
            { 2479000.0d, 0.000253911d },
            { 2501000.0d, 0.000254629d },
            { 2523000.0d, 0.000255305d },
            { 2545000.0d, 0.000255941d },
            { 2567000.0d, 0.000256534d },
            { 2589000.0d, 0.000257086d },
            { 2611000.0d, 0.000257598d },
            { 2633000.0d, 0.000258066d },
            { 2655000.0d, 0.000258494d },
            { 2677000.0d, 0.00025888d },
            { 2699000.0d, 0.000259224d },
            { 2721000.0d, 0.000259527d },
            { 2743000.0d, 0.000259788d },
            { 2765000.0d, 0.000260007d },
            { 2787000.0d, 0.000260184d },
            { 2809000.0d, 0.00026032d },
            { 2831000.0d, 0.000260415d },
            { 2853000.0d, 0.000260469d },
            { 2875000.0d, 0.000260481d },
            { 2897000.0d, 0.000260452d },
            { 2919000.0d, 0.000260381d },
            { 2941000.0d, 0.000260269d },
            { 2963000.0d, 0.000260116d },
            { 2985000.0d, 0.000259923d },
            { 3007000.0d, 0.000259688d },
            { 3029000.0d, 0.000259414d },
            { 3051000.0d, 0.000259098d },
            { 3073000.0d, 0.000258742d },
            { 3095000.0d, 0.000258346d },
            { 3117000.0d, 0.000257909d },
            { 3139000.0d, 0.000257433d },
            { 3161000.0d, 0.000256918d },
            { 3183000.0d, 0.000256362d },
            { 3205000.0d, 0.000255768d },
            { 3227000.0d, 0.000255134d },
            { 3249000.0d, 0.000254462d },
            { 3271000.0d, 0.000253751d },
            { 3293000.0d, 0.000253001d },
            { 3315000.0d, 0.000252213d },
            { 3337000.0d, 0.000251388d },
            { 3359000.0d, 0.000250524d },
            { 3381000.0d, 0.000249624d },
            { 3403000.0d, 0.000248686d },
            { 3425000.0d, 0.000247711d },
            { 3447000.0d, 0.0002467d },
            { 3469000.0d, 0.000245653d },
            { 3491000.0d, 0.00024457d },
            { 3513000.0d, 0.000243451d },
            { 3535000.0d, 0.000242297d },
            { 3557000.0d, 0.000241108d },
            { 3579000.0d, 0.000239885d },
            { 3601000.0d, 0.000238628d },
            { 3623000.0d, 0.000237337d },
            { 3645000.0d, 0.000236013d },
            { 3667000.0d, 0.000234655d },
            { 3689000.0d, 0.000233266d },
            { 3711000.0d, 0.000231843d },
            { 3733000.0d, 0.000230389d },
            { 3755000.0d, 0.000228905d },
            { 3777000.0d, 0.000227389d },
            { 3799000.0d, 0.000225843d },
            { 3821000.0d, 0.000224266d },
            { 3843000.0d, 0.000222661d },
            { 3865000.0d, 0.000221027d },
            { 3887000.0d, 0.000219363d },
            { 3909000.0d, 0.000217673d },
            { 3931000.0d, 0.000215954d },
            { 3953000.0d, 0.000214209d },
            { 3975000.0d, 0.000212437d },
            { 3997000.0d, 0.00021064d },
            { 4019000.0d, 0.000208817d },
            { 4041000.0d, 0.00020697d },
            { 4063000.0d, 0.000205098d },
            { 4085000.0d, 0.000203203d },
            { 4107000.0d, 0.000201286d },
            { 4129000.0d, 0.000199346d },
            { 4151000.0d, 0.000197384d },
            { 4173000.0d, 0.0001954d },
            { 4195000.0d, 0.000193397d },
            { 4217000.0d, 0.000191373d },
            { 4239000.0d, 0.00018933d },
            { 4261000.0d, 0.00018727d },
            { 4283000.0d, 0.000185191d },
            { 4305000.0d, 0.000183096d },
            { 4327000.0d, 0.000180984d },
            { 4349000.0d, 0.000178856d },
            { 4371000.0d, 0.000176713d },
            { 4393000.0d, 0.000174556d },
            { 4415000.0d, 0.000172385d },
            { 4437000.0d, 0.000170202d },
            { 4459000.0d, 0.000168007d },
            { 4481000.0d, 0.000165801d },
            { 4503000.0d, 0.000163585d },
            { 4525000.0d, 0.000161359d },
            { 4547000.0d, 0.000159123d },
            { 4569000.0d, 0.00015688d },
            { 4591000.0d, 0.00015463d },
            { 4613000.0d, 0.000152374d },
            { 4635000.0d, 0.000150113d },
            { 4657000.0d, 0.000147847d },
            { 4679000.0d, 0.000145577d },
            { 4701000.0d, 0.000143302d },
            { 4723000.0d, 0.000141022d },
            { 4745000.0d, 0.000138735d },
            { 4767000.0d, 0.000136444d },
            { 4789000.0d, 0.000134148d },
            { 4811000.0d, 0.00013185d },
            { 4833000.0d, 0.000129549d },
            { 4855000.0d, 0.000127246d },
            { 4877000.0d, 0.000124944d },
            { 4899000.0d, 0.000122642d },
            { 4921000.0d, 0.000120341d },
            { 4943000.0d, 0.000118043d },
            { 4965000.0d, 0.000115747d },
            { 4987000.0d, 0.000113456d },
            { 5009000.0d, 0.000111169d },
            { 5031000.0d, 0.000108889d },
            { 5053000.0d, 0.000106616d },
            { 5075000.0d, 0.00010435d },
            { 5097000.0d, 0.000102094d },
            { 5119000.0d, 0.0000998472d },
            { 5141000.0d, 0.0000976096d },
            { 5163000.0d, 0.0000953796d },
            { 5185000.0d, 0.0000931582d },
            { 5207000.0d, 0.0000909462d },
            { 5229000.0d, 0.0000887445d },
            { 5251000.0d, 0.0000865539d },
            { 5273000.0d, 0.0000843754d },
            { 5295000.0d, 0.0000822097d },
            { 5317000.0d, 0.0000800578d },
            { 5339000.0d, 0.0000779206d },
            { 5361000.0d, 0.000075799d },
            { 5383000.0d, 0.0000736939d },
            { 5405000.0d, 0.0000716062d },
            { 5427000.0d, 0.000069537d },
            { 5449000.0d, 0.0000674871d },
            { 5471000.0d, 0.0000654573d },
            { 5493000.0d, 0.0000634487d },
            { 5515000.0d, 0.0000614623d },
            { 5537000.0d, 0.0000594989d },
            { 5559000.0d, 0.0000575581d },
            { 5581000.0d, 0.0000556387d },
            { 5603000.0d, 0.0000537416d },
            { 5625000.0d, 0.0000518676d },
            { 5647000.0d, 0.0000500176d },
            { 5669000.0d, 0.0000481927d },
            { 5691000.0d, 0.0000463936d },
            { 5713000.0d, 0.0000446213d },
            { 5735000.0d, 0.0000428766d },
            { 5757000.0d, 0.0000411603d },
            { 5779000.0d, 0.0000394734d },
            { 5801000.0d, 0.0000378168d },
            { 5823000.0d, 0.0000361916d },
            { 5845000.0d, 0.0000345986d },
            { 5867000.0d, 0.0000330388d },
            { 5889000.0d, 0.0000315133d },
            { 5911000.0d, 0.000030023d },
            { 5933000.0d, 0.0000285688d },
            { 5955000.0d, 0.0000271519d },
            { 5977000.0d, 0.0000257731d },
            { 5999000.0d, 0.0000244334d },
            { 6021000.0d, 0.0000231339d },
            { 6043000.0d, 0.0000218755d },
            { 6065000.0d, 0.0000206592d },
            { 6087000.0d, 0.0000194849d },
            { 6109000.0d, 0.0000183409d },
            { 6131000.0d, 0.0000172241d },
            { 6153000.0d, 0.0000161353d },
            { 6175000.0d, 0.000015075d },
            { 6197000.0d, 0.000014044d },
            { 6219000.0d, 0.0000130432d },
            { 6241000.0d, 0.0000120731d },
            { 6263000.0d, 0.0000111346d },
            { 6285000.0d, 0.0000102284d },
            { 6307000.0d, 0.00000935533d },
            { 6329000.0d, 0.00000851601d },
            { 6351000.0d, 0.00000771128d },
            { 6373000.0d, 0.00000694186d },
            { 6395000.0d, 0.00000620853d },
            { 6417000.0d, 0.00000551207d },
            { 6439000.0d, 0.00000485322d },
            { 6461000.0d, 0.00000423275d },
            { 6483000.0d, 0.00000365145d },
            { 6505000.0d, 0.00000311007d },
            { 6527000.0d, 0.0000026094d },
            { 6549000.0d, 0.0000021502d },
            { 6571000.0d, 0.00000173324d },
            { 6593000.0d, 0.00000135929d },
            { 6615000.0d, 0.00000102912d },
            { 6637000.0d, 0.000000743471d },
            { 6659000.0d, 0.000000503095d },
            { 6681000.0d, 0.000000308722d },
            { 6703000.0d, 0.000000161054d },
            { 6725000.0d, 0.0000000607459d },
            { 6747000.0d, 0.0000000083418d },
            { 6760000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    