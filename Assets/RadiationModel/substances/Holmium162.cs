using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium162";
        public override double halfLife { get; } = 900.0d;
        public override double atomicWeight { get; } = 161.9291d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium162()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.08d, new GammaParticle(80700.0, 0.01536)), new(0.0042d, new GammaParticle(185000.0, 0.0067)), new(6.9e-05d, new GammaParticle(392485.0, 0.00316)), new(0.0031d, new GammaParticle(512000.0, 0.00242)), new(0.00023d, new GammaParticle(540000.0, 0.0023)), new(0.00073d, new GammaParticle(807650.0, 0.00154)), new(0.00061d, new GammaParticle(888000.0, 0.0014)), new(0.00037999999999999997d, new GammaParticle(1134000.0, 0.00109)), new(0.00481d, new GammaParticle(1187850.0, 0.00104)), new(0.00073d, new GammaParticle(1195100.0, 0.00104)), new(0.00015d, new GammaParticle(1276000.0, 0.00097)), new(0.0382d, new GammaParticle(1319750.0, 0.00094)), new(0.0079d, new GammaParticle(1372930.0, 0.0009)), new(0.00027d, new GammaParticle(1453770.0, 0.00085)), new(4.6e-05d, new GammaParticle(1517200.0, 0.00082)), new(8e-05d, new GammaParticle(1669000.0, 0.00074)), new(0.00017999999999999998d, new GammaParticle(1702200.0, 0.00073)), new(5.7e-05d, new GammaParticle(1740000.0, 0.00071)), new(0.000157d, new GammaParticle(1783000.0, 0.0007)), new(0.00015d, new GammaParticle(1806000.0, 0.00069)), new(0.076d, new GammaParticle(511000.0, 0.00243)), new(0.23022403913980266d, new GammaParticle(7384.0, 0.16791)), new(0.24976208102023364d, new GammaParticle(45207.0, 0.02743)), new(0.44632251790606436d, new GammaParticle(45998.0, 0.02695)), new(0.14330503568371566d, new GammaParticle(52220.0, 0.02374)), new(0.18056434496148174d, new GammaParticle(52791.0, 0.02349)), new(0.03725930927776608d, new GammaParticle(53478.0, 0.02318)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 3000.0d, 0.000000000140697d },
            { 6000.0d, 0.0000000022425d },
            { 9000.0d, 0.0000000109238d },
            { 12000.0d, 0.00000003211d },
            { 15000.0d, 0.00000007151d },
            { 18000.0d, 0.000000133966d },
            { 21000.0d, 0.000000223226d },
            { 24000.0d, 0.000000341964d },
            { 27000.0d, 0.000000492015d },
            { 30000.0d, 0.000000674303d },
            { 33000.0d, 0.000000889142d },
            { 36000.0d, 0.00000113655d },
            { 39000.0d, 0.00000141599d },
            { 42000.0d, 0.00000172672d },
            { 45000.0d, 0.00000206759d },
            { 48000.0d, 0.00000243747d },
            { 51000.0d, 0.00000283527d },
            { 54000.0d, 0.00000325966d },
            { 57000.0d, 0.00000370913d },
            { 60000.0d, 0.00000418209d },
            { 63000.0d, 0.00000467749d },
            { 66000.0d, 0.00000519406d },
            { 69000.0d, 0.00000573032d },
            { 72000.0d, 0.00000628462d },
            { 75000.0d, 0.00000685602d },
            { 78000.0d, 0.00000744346d },
            { 81000.0d, 0.00000804563d },
            { 84000.0d, 0.00000866122d },
            { 87000.0d, 0.00000928894d },
            { 90000.0d, 0.00000992822d },
            { 93000.0d, 0.000010578d },
            { 96000.0d, 0.0000112372d },
            { 99000.0d, 0.0000119049d },
            { 102000.0d, 0.0000125802d },
            { 105000.0d, 0.0000132622d },
            { 108000.0d, 0.0000139507d },
            { 111000.0d, 0.0000146441d },
            { 114000.0d, 0.0000153421d },
            { 117000.0d, 0.0000160443d },
            { 120000.0d, 0.0000167496d },
            { 123000.0d, 0.0000174576d },
            { 126000.0d, 0.0000181678d },
            { 129000.0d, 0.000018879d },
            { 132000.0d, 0.0000195923d },
            { 135000.0d, 0.0000203053d },
            { 138000.0d, 0.0000210181d },
            { 141000.0d, 0.0000217314d },
            { 144000.0d, 0.0000224436d },
            { 147000.0d, 0.000023154d },
            { 150000.0d, 0.0000238631d },
            { 153000.0d, 0.0000245708d },
            { 156000.0d, 0.0000252761d },
            { 159000.0d, 0.0000259782d },
            { 162000.0d, 0.0000266773d },
            { 165000.0d, 0.0000273732d },
            { 168000.0d, 0.0000280658d },
            { 171000.0d, 0.0000287549d },
            { 174000.0d, 0.0000294398d },
            { 177000.0d, 0.0000301205d },
            { 180000.0d, 0.0000307966d },
            { 183000.0d, 0.0000314678d },
            { 186000.0d, 0.0000321342d },
            { 189000.0d, 0.0000327954d },
            { 192000.0d, 0.0000334512d },
            { 195000.0d, 0.0000341016d },
            { 198000.0d, 0.0000347463d },
            { 201000.0d, 0.0000353851d },
            { 204000.0d, 0.000036018d },
            { 207000.0d, 0.0000366447d },
            { 210000.0d, 0.000037265d },
            { 213000.0d, 0.000037879d },
            { 216000.0d, 0.0000384864d },
            { 219000.0d, 0.0000390871d },
            { 222000.0d, 0.0000396813d },
            { 225000.0d, 0.0000402688d },
            { 228000.0d, 0.0000408495d },
            { 231000.0d, 0.0000414233d },
            { 234000.0d, 0.0000419898d },
            { 237000.0d, 0.0000425489d },
            { 240000.0d, 0.0000431004d },
            { 243000.0d, 0.0000436446d },
            { 246000.0d, 0.0000441815d },
            { 249000.0d, 0.0000447114d },
            { 252000.0d, 0.0000452339d },
            { 255000.0d, 0.0000457482d },
            { 258000.0d, 0.0000462548d },
            { 261000.0d, 0.0000467534d },
            { 264000.0d, 0.0000472449d },
            { 267000.0d, 0.0000477289d },
            { 270000.0d, 0.0000482044d },
            { 273000.0d, 0.0000486719d },
            { 276000.0d, 0.0000491316d },
            { 279000.0d, 0.0000495836d },
            { 282000.0d, 0.0000500278d },
            { 285000.0d, 0.0000504637d },
            { 288000.0d, 0.0000508911d },
            { 291000.0d, 0.0000513109d },
            { 294000.0d, 0.000051723d },
            { 297000.0d, 0.0000521268d },
            { 300000.0d, 0.0000525219d },
            { 303000.0d, 0.0000529092d },
            { 306000.0d, 0.0000532887d },
            { 309000.0d, 0.00005366d },
            { 312000.0d, 0.000054023d },
            { 315000.0d, 0.0000543777d },
            { 318000.0d, 0.000054724d },
            { 321000.0d, 0.0000550623d },
            { 324000.0d, 0.0000553929d },
            { 327000.0d, 0.0000557155d },
            { 330000.0d, 0.0000560294d },
            { 333000.0d, 0.000056335d },
            { 336000.0d, 0.0000566324d },
            { 339000.0d, 0.0000569216d },
            { 342000.0d, 0.0000572028d },
            { 345000.0d, 0.000057476d },
            { 348000.0d, 0.0000577413d },
            { 351000.0d, 0.0000579985d },
            { 354000.0d, 0.0000582475d },
            { 357000.0d, 0.0000584883d },
            { 360000.0d, 0.0000587209d },
            { 363000.0d, 0.0000589456d },
            { 366000.0d, 0.0000591621d },
            { 369000.0d, 0.0000593705d },
            { 372000.0d, 0.0000595709d },
            { 375000.0d, 0.0000597633d },
            { 378000.0d, 0.0000599478d },
            { 381000.0d, 0.0000601243d },
            { 384000.0d, 0.0000602929d },
            { 387000.0d, 0.0000604537d },
            { 390000.0d, 0.0000606065d },
            { 393000.0d, 0.0000607516d },
            { 396000.0d, 0.0000608889d },
            { 399000.0d, 0.0000610183d },
            { 402000.0d, 0.0000611399d },
            { 405000.0d, 0.0000612539d },
            { 408000.0d, 0.0000613602d },
            { 411000.0d, 0.0000614587d },
            { 414000.0d, 0.0000615496d },
            { 417000.0d, 0.0000616328d },
            { 420000.0d, 0.0000617084d },
            { 423000.0d, 0.0000617764d },
            { 426000.0d, 0.0000618368d },
            { 429000.0d, 0.0000618898d },
            { 432000.0d, 0.0000619352d },
            { 435000.0d, 0.0000619733d },
            { 438000.0d, 0.0000620041d },
            { 441000.0d, 0.0000620276d },
            { 444000.0d, 0.0000620439d },
            { 447000.0d, 0.000062053d },
            { 450000.0d, 0.0000620549d },
            { 453000.0d, 0.0000620494d },
            { 456000.0d, 0.0000620367d },
            { 459000.0d, 0.0000620168d },
            { 462000.0d, 0.0000619898d },
            { 465000.0d, 0.0000619559d },
            { 468000.0d, 0.0000619151d },
            { 471000.0d, 0.0000618673d },
            { 474000.0d, 0.0000618129d },
            { 477000.0d, 0.0000617515d },
            { 480000.0d, 0.0000616833d },
            { 483000.0d, 0.0000616081d },
            { 486000.0d, 0.0000615261d },
            { 489000.0d, 0.0000614375d },
            { 492000.0d, 0.0000613425d },
            { 495000.0d, 0.000061241d },
            { 498000.0d, 0.0000611332d },
            { 501000.0d, 0.0000610185d },
            { 504000.0d, 0.0000608974d },
            { 507000.0d, 0.0000607698d },
            { 510000.0d, 0.000060636d },
            { 513000.0d, 0.0000604958d },
            { 516000.0d, 0.0000603495d },
            { 519000.0d, 0.0000601971d },
            { 522000.0d, 0.0000600387d },
            { 525000.0d, 0.0000598741d },
            { 528000.0d, 0.0000597037d },
            { 531000.0d, 0.0000595272d },
            { 534000.0d, 0.0000593446d },
            { 537000.0d, 0.0000591561d },
            { 540000.0d, 0.0000589619d },
            { 543000.0d, 0.0000587618d },
            { 546000.0d, 0.0000585561d },
            { 549000.0d, 0.0000583448d },
            { 552000.0d, 0.0000581278d },
            { 555000.0d, 0.0000579054d },
            { 558000.0d, 0.0000576776d },
            { 561000.0d, 0.0000574444d },
            { 564000.0d, 0.0000572059d },
            { 567000.0d, 0.0000569619d },
            { 570000.0d, 0.0000567128d },
            { 573000.0d, 0.0000564586d },
            { 576000.0d, 0.0000561992d },
            { 579000.0d, 0.0000559347d },
            { 582000.0d, 0.0000556653d },
            { 585000.0d, 0.000055391d },
            { 588000.0d, 0.0000551117d },
            { 591000.0d, 0.0000548276d },
            { 594000.0d, 0.0000545388d },
            { 597000.0d, 0.0000542453d },
            { 600000.0d, 0.0000539472d },
            { 603000.0d, 0.0000536445d },
            { 606000.0d, 0.0000533373d },
            { 609000.0d, 0.0000530258d },
            { 612000.0d, 0.0000527099d },
            { 615000.0d, 0.0000523897d },
            { 618000.0d, 0.0000520652d },
            { 621000.0d, 0.0000517366d },
            { 624000.0d, 0.0000514039d },
            { 627000.0d, 0.0000510672d },
            { 630000.0d, 0.0000507265d },
            { 633000.0d, 0.0000503819d },
            { 636000.0d, 0.0000500334d },
            { 639000.0d, 0.0000496811d },
            { 642000.0d, 0.0000493251d },
            { 645000.0d, 0.0000489654d },
            { 648000.0d, 0.0000486023d },
            { 651000.0d, 0.0000482356d },
            { 654000.0d, 0.0000478654d },
            { 657000.0d, 0.0000474921d },
            { 660000.0d, 0.0000471153d },
            { 663000.0d, 0.0000467354d },
            { 666000.0d, 0.0000463524d },
            { 669000.0d, 0.0000459665d },
            { 672000.0d, 0.0000455775d },
            { 675000.0d, 0.0000451855d },
            { 678000.0d, 0.0000447906d },
            { 681000.0d, 0.0000443929d },
            { 684000.0d, 0.0000439925d },
            { 687000.0d, 0.0000435894d },
            { 690000.0d, 0.0000431839d },
            { 693000.0d, 0.0000427759d },
            { 696000.0d, 0.0000423657d },
            { 699000.0d, 0.000041953d },
            { 702000.0d, 0.0000415382d },
            { 705000.0d, 0.000041121d },
            { 708000.0d, 0.0000407017d },
            { 711000.0d, 0.0000402804d },
            { 714000.0d, 0.0000398572d },
            { 717000.0d, 0.0000394321d },
            { 720000.0d, 0.0000390053d },
            { 723000.0d, 0.0000385767d },
            { 726000.0d, 0.0000381465d },
            { 729000.0d, 0.0000377147d },
            { 732000.0d, 0.0000372815d },
            { 735000.0d, 0.0000368469d },
            { 738000.0d, 0.0000364111d },
            { 741000.0d, 0.0000359739d },
            { 744000.0d, 0.0000355356d },
            { 747000.0d, 0.0000350963d },
            { 750000.0d, 0.0000346559d },
            { 753000.0d, 0.0000342147d },
            { 756000.0d, 0.0000337727d },
            { 759000.0d, 0.0000333298d },
            { 762000.0d, 0.0000328863d },
            { 765000.0d, 0.0000324423d },
            { 768000.0d, 0.0000319977d },
            { 771000.0d, 0.0000315527d },
            { 774000.0d, 0.0000311075d },
            { 777000.0d, 0.000030662d },
            { 780000.0d, 0.0000302163d },
            { 783000.0d, 0.0000297706d },
            { 786000.0d, 0.0000293247d },
            { 789000.0d, 0.0000288792d },
            { 792000.0d, 0.0000284337d },
            { 795000.0d, 0.0000279885d },
            { 798000.0d, 0.0000275438d },
            { 801000.0d, 0.0000270994d },
            { 804000.0d, 0.0000266556d },
            { 807000.0d, 0.0000262123d },
            { 810000.0d, 0.0000257699d },
            { 813000.0d, 0.0000253281d },
            { 816000.0d, 0.0000248874d },
            { 819000.0d, 0.0000244476d },
            { 822000.0d, 0.0000240088d },
            { 825000.0d, 0.0000235713d },
            { 828000.0d, 0.0000231349d },
            { 831000.0d, 0.0000227d },
            { 834000.0d, 0.0000222665d },
            { 837000.0d, 0.0000218345d },
            { 840000.0d, 0.000021404d },
            { 843000.0d, 0.0000209754d },
            { 846000.0d, 0.0000205484d },
            { 849000.0d, 0.0000201235d },
            { 852000.0d, 0.0000197005d },
            { 855000.0d, 0.0000192796d },
            { 858000.0d, 0.0000188608d },
            { 861000.0d, 0.0000184443d },
            { 864000.0d, 0.0000180301d },
            { 867000.0d, 0.0000176185d },
            { 870000.0d, 0.0000172093d },
            { 873000.0d, 0.0000168027d },
            { 876000.0d, 0.0000163989d },
            { 879000.0d, 0.0000159981d },
            { 882000.0d, 0.0000156001d },
            { 885000.0d, 0.0000152052d },
            { 888000.0d, 0.0000148133d },
            { 891000.0d, 0.0000144248d },
            { 894000.0d, 0.0000140395d },
            { 897000.0d, 0.0000136576d },
            { 900000.0d, 0.0000132793d },
            { 903000.0d, 0.0000129045d },
            { 906000.0d, 0.0000125335d },
            { 909000.0d, 0.0000121663d },
            { 912000.0d, 0.000011803d },
            { 915000.0d, 0.0000114437d },
            { 918000.0d, 0.0000110885d },
            { 921000.0d, 0.0000107376d },
            { 924000.0d, 0.0000103909d },
            { 927000.0d, 0.0000100487d },
            { 930000.0d, 0.00000971096d },
            { 933000.0d, 0.00000937786d },
            { 936000.0d, 0.00000904947d },
            { 939000.0d, 0.00000872591d },
            { 942000.0d, 0.00000840727d },
            { 945000.0d, 0.00000809365d },
            { 948000.0d, 0.00000778516d },
            { 951000.0d, 0.0000074819d },
            { 954000.0d, 0.00000718397d },
            { 957000.0d, 0.00000689148d },
            { 960000.0d, 0.00000660454d },
            { 963000.0d, 0.00000632323d },
            { 966000.0d, 0.00000604768d },
            { 969000.0d, 0.00000577798d },
            { 972000.0d, 0.00000551424d },
            { 975000.0d, 0.00000525657d },
            { 978000.0d, 0.00000500508d },
            { 981000.0d, 0.00000475985d },
            { 984000.0d, 0.00000452101d },
            { 987000.0d, 0.00000428867d },
            { 990000.0d, 0.00000406292d },
            { 993000.0d, 0.00000384387d },
            { 996000.0d, 0.00000363163d },
            { 999000.0d, 0.0000034263d },
            { 1002000.0d, 0.00000322802d },
            { 1005000.0d, 0.00000303684d },
            { 1008000.0d, 0.00000285292d },
            { 1011000.0d, 0.00000267634d },
            { 1014000.0d, 0.00000250722d },
            { 1017000.0d, 0.00000234567d },
            { 1020000.0d, 0.00000219177d },
            { 1023000.0d, 0.00000204566d },
            { 1026000.0d, 0.00000190743d },
            { 1029000.0d, 0.0000017772d },
            { 1032000.0d, 0.00000165506d },
            { 1035000.0d, 0.00000154113d },
            { 1038000.0d, 0.00000143548d },
            { 1041000.0d, 0.00000133617d },
            { 1044000.0d, 0.00000124004d },
            { 1047000.0d, 0.00000114712d },
            { 1050000.0d, 0.00000105744d },
            { 1053000.0d, 0.000000971059d },
            { 1056000.0d, 0.000000888018d },
            { 1059000.0d, 0.000000808365d },
            { 1062000.0d, 0.00000073215d },
            { 1065000.0d, 0.000000659417d },
            { 1068000.0d, 0.000000590216d },
            { 1071000.0d, 0.000000524594d },
            { 1074000.0d, 0.000000462599d },
            { 1077000.0d, 0.000000404276d },
            { 1080000.0d, 0.000000349676d },
            { 1083000.0d, 0.000000298844d },
            { 1086000.0d, 0.000000251828d },
            { 1089000.0d, 0.000000208676d },
            { 1092000.0d, 0.000000169436d },
            { 1095000.0d, 0.000000134155d },
            { 1098000.0d, 0.000000102879d },
            { 1101000.0d, 0.0000000756574d },
            { 1104000.0d, 0.0000000525355d },
            { 1107000.0d, 0.0000000335599d },
            { 1110000.0d, 0.0000000187761d },
            { 1113000.0d, 0.00000000822831d },
            { 1116000.0d, 0.00000000195828d },
            { 1119000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    