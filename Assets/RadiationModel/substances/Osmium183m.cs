using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium183m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium183m";
        public override double halfLife { get; } = 35640.0d;
        public override double atomicWeight { get; } = 182.95331d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten183()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0086d, new GammaParticle(67240.0, 0.01844)), new(0.000867d, new GammaParticle(80030.0, 0.01549)), new(0.0021d, new GammaParticle(101790.0, 0.01218)), new(0.0070999999999999995d, new GammaParticle(114350.0, 0.01084)), new(0.0019d, new GammaParticle(126200.0, 0.00982)), new(0.0014000000000000002d, new GammaParticle(128300.0, 0.00966)), new(0.0045000000000000005d, new GammaParticle(147110.0, 0.00843)), new(0.0034999999999999996d, new GammaParticle(230100.0, 0.00539)), new(0.002d, new GammaParticle(237000.0, 0.00523)), new(0.0031d, new GammaParticle(245900.0, 0.00504)), new(0.0039000000000000003d, new GammaParticle(251920.0, 0.00492)), new(0.0017000000000000001d, new GammaParticle(365510.0, 0.00339)), new(0.0042d, new GammaParticle(401320.0, 0.00309)), new(0.0222d, new GammaParticle(484490.0, 0.00256)), new(4e-05d, new GammaParticle(535620.0, 0.00231)), new(0.0019d, new GammaParticle(550280.0, 0.00225)), new(0.0021d, new GammaParticle(585600.0, 0.00212)), new(0.001d, new GammaParticle(714200.0, 0.00174)), new(0.0009d, new GammaParticle(724600.0, 0.00171)), new(0.0016d, new GammaParticle(734010.0, 0.00169)), new(0.0012d, new GammaParticle(762000.0, 0.00163)), new(0.0033d, new GammaParticle(795940.0, 0.00156)), new(0.0009d, new GammaParticle(815530.0, 0.00152)), new(0.0013d, new GammaParticle(829010.0, 0.0015)), new(0.0064d, new GammaParticle(840580.0, 0.00147)), new(0.0033d, new GammaParticle(853370.0, 0.00145)), new(0.02d, new GammaParticle(878910.0, 0.00141)), new(0.0013d, new GammaParticle(926060.0, 0.00134)), new(0.00231d, new GammaParticle(948980.0, 0.00131)), new(0.0139d, new GammaParticle(954880.0, 0.0013)), new(0.00064d, new GammaParticle(964540.0, 0.00129)), new(0.00172d, new GammaParticle(993430.0, 0.00125)), new(0.0605d, new GammaParticle(1034680.0, 0.0012)), new(0.0029d, new GammaParticle(1040770.0, 0.00119)), new(0.49200000000000005d, new GammaParticle(1101930.0, 0.00113)), new(0.0054d, new GammaParticle(1104660.0, 0.00112)), new(0.225d, new GammaParticle(1107930.0, 0.00112)), new(0.003d, new GammaParticle(1110440.0, 0.00112)), new(0.0054d, new GammaParticle(1161110.0, 0.00107)), new(0.0009d, new GammaParticle(1168000.0, 0.00106)), new(0.0019d, new GammaParticle(1173990.0, 0.00106)), new(0.0011d, new GammaParticle(1283420.0, 0.00097)), new(0.0007000000000000001d, new GammaParticle(1331080.0, 0.00093)), new(0.0017000000000000001d, new GammaParticle(1353570.0, 0.00092)), new(0.00015d, new GammaParticle(1468910.0, 0.00084)), new(0.00015d, new GammaParticle(1473130.0, 0.00084)), new(0.0003d, new GammaParticle(1562600.0, 0.00079)), new(0.00064d, new GammaParticle(1626390.0, 0.00076)), new(0.00039d, new GammaParticle(1642000.0, 0.00076)), new(0.0003d, new GammaParticle(1650020.0, 0.00075)), new(0.00034d, new GammaParticle(1678480.0, 0.00074)), new(0.00043999999999999996d, new GammaParticle(1707000.0, 0.00073)), new(0.00039d, new GammaParticle(1725000.0, 0.00072)), new(0.00049d, new GammaParticle(1787000.0, 0.00069)), new(0.00094d, new GammaParticle(1806710.0, 0.00069)), new(0.00079d, new GammaParticle(1826060.0, 0.00068)), new(0.00113d, new GammaParticle(1903500.0, 0.00065)), new(0.0002d, new GammaParticle(1919000.0, 0.00065)), new(0.00034d, new GammaParticle(1948130.0, 0.00064)), new(0.002218d, new GammaParticle(511000.0, 0.00243)), new(0.217d, new GammaParticle(10063.0, 0.12321)), new(0.2d, new GammaParticle(59718.0, 0.02076)), new(0.34d, new GammaParticle(61141.0, 0.02028)), new(0.113d, new GammaParticle(69395.0, 0.01787)), new(0.14400000000000002d, new GammaParticle(70206.0, 0.01766)), new(0.031d, new GammaParticle(71195.0, 0.01741)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium183()), new(0.0007199999999999999d, new GammaParticle(170700.0, 0.00726)), new(0.034795274976d, new GammaParticle(10393.0, 0.1193)), new(0.012561493367018475d, new GammaParticle(61486.0, 0.02016)), new(0.021646550692776968d, new GammaParticle(63000.0, 0.01968)), new(0.007242484328284815d, new GammaParticle(71496.0, 0.01734)), new(0.009270379940204564d, new GammaParticle(72338.0, 0.01714)), new(0.0020278956119197484d, new GammaParticle(73364.0, 0.0169)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 600.0d, 0.00000000000373039d },
            { 1200.0d, 0.0000000000100129d },
            { 1800.0d, 0.0000000000200154d },
            { 2400.0d, 0.0000000000440051d },
            { 3000.0d, 0.0000000000810861d },
            { 3600.0d, 0.000000000130746d },
            { 4200.0d, 0.000000000193954d },
            { 4800.0d, 0.000000000271885d },
            { 5400.0d, 0.000000000365635d },
            { 6000.0d, 0.000000000476261d },
            { 6600.0d, 0.000000000604974d },
            { 7200.0d, 0.000000000752753d },
            { 7800.0d, 0.000000000920775d },
            { 8400.0d, 0.00000000112289d },
            { 9000.0d, 0.00000000135806d },
            { 9600.0d, 0.00000000162184d },
            { 10000.0d, 0.00000000181403d },
            { 11000.0d, 0.00000000235362d },
            { 12000.0d, 0.00000000298099d },
            { 13000.0d, 0.00000000373574d },
            { 14000.0d, 0.00000000459974d },
            { 15000.0d, 0.00000000557611d },
            { 16000.0d, 0.00000000666759d },
            { 17000.0d, 0.00000000790716d },
            { 18000.0d, 0.00000000927837d },
            { 19000.0d, 0.0000000107828d },
            { 20000.0d, 0.0000000124218d },
            { 21000.0d, 0.0000000142201d },
            { 22000.0d, 0.000000016164d },
            { 23000.0d, 0.0000000182537d },
            { 24000.0d, 0.0000000204892d },
            { 25000.0d, 0.0000000228871d },
            { 26000.0d, 0.0000000254367d },
            { 27000.0d, 0.0000000281371d },
            { 28000.0d, 0.0000000309872d },
            { 29000.0d, 0.0000000339964d },
            { 30000.0d, 0.0000000371567d },
            { 31000.0d, 0.0000000404666d },
            { 32000.0d, 0.000000043924d },
            { 33000.0d, 0.0000000475322d },
            { 34000.0d, 0.0000000512859d },
            { 35000.0d, 0.0000000551826d },
            { 36000.0d, 0.0000000592201d },
            { 37000.0d, 0.0000000633965d },
            { 38000.0d, 0.0000000677089d },
            { 39000.0d, 0.0000000721543d },
            { 40000.0d, 0.0000000767301d },
            { 41000.0d, 0.0000000814306d },
            { 42000.0d, 0.0000000862547d },
            { 43000.0d, 0.0000000911992d },
            { 44000.0d, 0.0000000962613d },
            { 45000.0d, 0.000000101433d },
            { 46000.0d, 0.000000106713d },
            { 47000.0d, 0.0000001121d },
            { 48000.0d, 0.000000117591d },
            { 49000.0d, 0.000000123174d },
            { 50000.0d, 0.000000128851d },
            { 51000.0d, 0.00000013462d },
            { 52000.0d, 0.000000140477d },
            { 53000.0d, 0.00000014641d },
            { 54000.0d, 0.000000152422d },
            { 55000.0d, 0.00000015851d },
            { 56000.0d, 0.000000164671d },
            { 57000.0d, 0.000000170892d },
            { 58000.0d, 0.000000177177d },
            { 59000.0d, 0.000000183522d },
            { 60000.0d, 0.000000189925d },
            { 61000.0d, 0.000000196373d },
            { 62000.0d, 0.000000202869d },
            { 63000.0d, 0.000000209412d },
            { 64000.0d, 0.000000215997d },
            { 65000.0d, 0.000000222613d },
            { 66000.0d, 0.000000229263d },
            { 67000.0d, 0.000000235945d },
            { 68000.0d, 0.000000242657d },
            { 69000.0d, 0.000000249386d },
            { 70000.0d, 0.000000256135d },
            { 71000.0d, 0.000000262904d },
            { 72000.0d, 0.000000269689d },
            { 73000.0d, 0.000000276479d },
            { 74000.0d, 0.000000283277d },
            { 75000.0d, 0.000000290082d },
            { 76000.0d, 0.000000296893d },
            { 77000.0d, 0.000000303696d },
            { 78000.0d, 0.000000310497d },
            { 79000.0d, 0.000000317293d },
            { 80000.0d, 0.000000324085d },
            { 81000.0d, 0.000000330859d },
            { 82000.0d, 0.000000337621d },
            { 83000.0d, 0.000000344369d },
            { 84000.0d, 0.000000351103d },
            { 85000.0d, 0.00000035781d },
            { 86000.0d, 0.000000364497d },
            { 87000.0d, 0.000000371161d },
            { 88000.0d, 0.000000377803d },
            { 89000.0d, 0.00000038441d },
            { 90000.0d, 0.000000390989d },
            { 91000.0d, 0.000000397538d },
            { 92000.0d, 0.000000404058d },
            { 93000.0d, 0.000000410537d },
            { 94000.0d, 0.000000416981d },
            { 95000.0d, 0.00000042339d },
            { 96000.0d, 0.000000429762d },
            { 97000.0d, 0.00000043609d },
            { 98000.0d, 0.000000442376d },
            { 99000.0d, 0.000000448622d },
            { 100000.0d, 0.000000454828d },
            { 104000.0d, 0.000000479181d },
            { 108000.0d, 0.000000502772d },
            { 112000.0d, 0.00000052556d },
            { 116000.0d, 0.000000547526d },
            { 120000.0d, 0.00000056866d },
            { 124000.0d, 0.000000588971d },
            { 128000.0d, 0.000000608479d },
            { 132000.0d, 0.000000627217d },
            { 136000.0d, 0.000000645229d },
            { 140000.0d, 0.000000662572d },
            { 144000.0d, 0.000000679313d },
            { 148000.0d, 0.000000695529d },
            { 152000.0d, 0.000000711304d },
            { 156000.0d, 0.000000726736d },
            { 160000.0d, 0.000000741928d },
            { 164000.0d, 0.000000756991d },
            { 168000.0d, 0.000000772042d },
            { 172000.0d, 0.000000787209d },
            { 176000.0d, 0.000000802624d },
            { 180000.0d, 0.000000818425d },
            { 184000.0d, 0.000000834758d },
            { 188000.0d, 0.000000851772d },
            { 192000.0d, 0.000000869565d },
            { 196000.0d, 0.000000887939d },
            { 200000.0d, 0.000000906953d },
            { 204000.0d, 0.000000926143d },
            { 208000.0d, 0.000000944976d },
            { 212000.0d, 0.000000963452d },
            { 216000.0d, 0.000000981576d },
            { 220000.0d, 0.000000999353d },
            { 224000.0d, 0.00000101679d },
            { 228000.0d, 0.00000103389d },
            { 232000.0d, 0.00000105067d },
            { 236000.0d, 0.00000106711d },
            { 240000.0d, 0.00000108324d },
            { 244000.0d, 0.00000109904d },
            { 248000.0d, 0.00000111454d },
            { 252000.0d, 0.00000112974d },
            { 256000.0d, 0.00000114465d },
            { 260000.0d, 0.00000115931d },
            { 264000.0d, 0.00000117362d },
            { 268000.0d, 0.00000118758d },
            { 272000.0d, 0.00000120117d },
            { 276000.0d, 0.0000012144d },
            { 280000.0d, 0.00000122728d },
            { 284000.0d, 0.0000012398d },
            { 288000.0d, 0.00000125198d },
            { 292000.0d, 0.00000126382d },
            { 296000.0d, 0.00000127534d },
            { 300000.0d, 0.0000012865d },
            { 304000.0d, 0.00000129737d },
            { 308000.0d, 0.00000130791d },
            { 312000.0d, 0.00000131814d },
            { 316000.0d, 0.00000132807d },
            { 320000.0d, 0.0000013377d },
            { 324000.0d, 0.00000134705d },
            { 328000.0d, 0.00000135611d },
            { 332000.0d, 0.0000013649d },
            { 336000.0d, 0.00000137343d },
            { 340000.0d, 0.00000138169d },
            { 344000.0d, 0.0000013897d },
            { 348000.0d, 0.00000139746d },
            { 352000.0d, 0.00000140499d },
            { 356000.0d, 0.00000141229d },
            { 360000.0d, 0.00000141937d },
            { 364000.0d, 0.00000142624d },
            { 368000.0d, 0.00000143289d },
            { 372000.0d, 0.00000143937d },
            { 376000.0d, 0.00000144564d },
            { 380000.0d, 0.00000145173d },
            { 384000.0d, 0.00000145765d },
            { 388000.0d, 0.0000014634d },
            { 392000.0d, 0.000001469d },
            { 396000.0d, 0.00000147445d },
            { 400000.0d, 0.00000147976d },
            { 404000.0d, 0.00000148493d },
            { 408000.0d, 0.00000148999d },
            { 412000.0d, 0.00000149493d },
            { 416000.0d, 0.00000149976d },
            { 420000.0d, 0.00000150449d },
            { 424000.0d, 0.00000150907d },
            { 428000.0d, 0.00000151346d },
            { 432000.0d, 0.00000151765d },
            { 436000.0d, 0.00000152165d },
            { 440000.0d, 0.00000152547d },
            { 444000.0d, 0.0000015291d },
            { 448000.0d, 0.00000153255d },
            { 452000.0d, 0.00000153582d },
            { 456000.0d, 0.00000153893d },
            { 460000.0d, 0.00000154186d },
            { 464000.0d, 0.00000154464d },
            { 468000.0d, 0.00000154724d },
            { 472000.0d, 0.00000154968d },
            { 476000.0d, 0.00000155195d },
            { 480000.0d, 0.00000155403d },
            { 484000.0d, 0.00000155594d },
            { 488000.0d, 0.00000155768d },
            { 492000.0d, 0.00000155925d },
            { 496000.0d, 0.00000156065d },
            { 500000.0d, 0.00000156188d },
            { 504000.0d, 0.00000156295d },
            { 508000.0d, 0.00000156385d },
            { 512000.0d, 0.0000015646d },
            { 516000.0d, 0.00000156518d },
            { 520000.0d, 0.00000156561d },
            { 524000.0d, 0.00000156588d },
            { 528000.0d, 0.000001566d },
            { 532000.0d, 0.00000156597d },
            { 536000.0d, 0.00000156579d },
            { 540000.0d, 0.00000156547d },
            { 544000.0d, 0.00000156499d },
            { 548000.0d, 0.00000156437d },
            { 552000.0d, 0.00000156361d },
            { 556000.0d, 0.00000156271d },
            { 560000.0d, 0.00000156166d },
            { 564000.0d, 0.00000156048d },
            { 568000.0d, 0.00000155916d },
            { 572000.0d, 0.00000155771d },
            { 576000.0d, 0.00000155612d },
            { 580000.0d, 0.00000155439d },
            { 584000.0d, 0.00000155254d },
            { 588000.0d, 0.00000155055d },
            { 592000.0d, 0.00000154843d },
            { 596000.0d, 0.00000154619d },
            { 600000.0d, 0.00000154381d },
            { 604000.0d, 0.00000154131d },
            { 608000.0d, 0.00000153869d },
            { 612000.0d, 0.00000153593d },
            { 616000.0d, 0.00000153306d },
            { 620000.0d, 0.00000153006d },
            { 624000.0d, 0.00000152694d },
            { 628000.0d, 0.0000015237d },
            { 632000.0d, 0.00000152033d },
            { 636000.0d, 0.00000151685d },
            { 640000.0d, 0.00000151325d },
            { 644000.0d, 0.00000150952d },
            { 648000.0d, 0.00000150568d },
            { 652000.0d, 0.00000150173d },
            { 656000.0d, 0.00000149765d },
            { 660000.0d, 0.00000149346d },
            { 664000.0d, 0.00000148915d },
            { 668000.0d, 0.00000148473d },
            { 672000.0d, 0.00000148019d },
            { 676000.0d, 0.00000147554d },
            { 680000.0d, 0.00000147077d },
            { 684000.0d, 0.00000146589d },
            { 688000.0d, 0.0000014609d },
            { 692000.0d, 0.00000145579d },
            { 696000.0d, 0.00000145057d },
            { 700000.0d, 0.00000144524d },
            { 704000.0d, 0.0000014398d },
            { 708000.0d, 0.00000143424d },
            { 712000.0d, 0.00000142857d },
            { 716000.0d, 0.00000142279d },
            { 720000.0d, 0.0000014169d },
            { 724000.0d, 0.0000014109d },
            { 728000.0d, 0.00000140479d },
            { 732000.0d, 0.00000139856d },
            { 736000.0d, 0.00000139223d },
            { 740000.0d, 0.00000138578d },
            { 744000.0d, 0.00000137923d },
            { 748000.0d, 0.00000137256d },
            { 752000.0d, 0.00000136579d },
            { 756000.0d, 0.0000013589d },
            { 760000.0d, 0.00000135191d },
            { 764000.0d, 0.00000134481d },
            { 768000.0d, 0.00000133759d },
            { 772000.0d, 0.00000133027d },
            { 776000.0d, 0.00000132284d },
            { 780000.0d, 0.0000013153d },
            { 784000.0d, 0.00000130765d },
            { 788000.0d, 0.0000012999d },
            { 792000.0d, 0.00000129203d },
            { 796000.0d, 0.00000128406d },
            { 800000.0d, 0.00000127597d },
            { 804000.0d, 0.00000126778d },
            { 808000.0d, 0.00000125949d },
            { 812000.0d, 0.00000125108d },
            { 816000.0d, 0.00000124257d },
            { 820000.0d, 0.00000123395d },
            { 824000.0d, 0.00000122522d },
            { 828000.0d, 0.00000121639d },
            { 832000.0d, 0.00000120745d },
            { 836000.0d, 0.00000119841d },
            { 840000.0d, 0.00000118926d },
            { 844000.0d, 0.00000118d },
            { 848000.0d, 0.00000117064d },
            { 852000.0d, 0.00000116118d },
            { 856000.0d, 0.00000115161d },
            { 860000.0d, 0.00000114194d },
            { 864000.0d, 0.00000113217d },
            { 868000.0d, 0.00000112229d },
            { 872000.0d, 0.00000111232d },
            { 876000.0d, 0.00000110224d },
            { 880000.0d, 0.00000109206d },
            { 884000.0d, 0.00000108178d },
            { 888000.0d, 0.00000107141d },
            { 892000.0d, 0.00000106093d },
            { 896000.0d, 0.00000105036d },
            { 900000.0d, 0.00000103969d },
            { 904000.0d, 0.00000102893d },
            { 908000.0d, 0.00000101807d },
            { 912000.0d, 0.00000100712d },
            { 916000.0d, 0.00000099608d },
            { 920000.0d, 0.000000984946d },
            { 924000.0d, 0.000000973722d },
            { 928000.0d, 0.00000096241d },
            { 932000.0d, 0.000000951011d },
            { 936000.0d, 0.000000939525d },
            { 940000.0d, 0.000000927956d },
            { 944000.0d, 0.000000916303d },
            { 948000.0d, 0.000000904569d },
            { 952000.0d, 0.000000892755d },
            { 956000.0d, 0.000000880863d },
            { 960000.0d, 0.000000868894d },
            { 964000.0d, 0.000000856852d },
            { 968000.0d, 0.000000844736d },
            { 972000.0d, 0.00000083255d },
            { 976000.0d, 0.000000820296d },
            { 980000.0d, 0.000000807975d },
            { 984000.0d, 0.000000795591d },
            { 988000.0d, 0.000000783144d },
            { 992000.0d, 0.000000770638d },
            { 996000.0d, 0.000000758075d },
            { 1000000.0d, 0.000000745458d },
            { 1004000.0d, 0.000000732789d },
            { 1008000.0d, 0.000000720072d },
            { 1012000.0d, 0.000000707308d },
            { 1016000.0d, 0.000000694501d },
            { 1020000.0d, 0.000000681654d },
            { 1024000.0d, 0.00000066877d },
            { 1028000.0d, 0.000000655853d },
            { 1032000.0d, 0.000000642905d },
            { 1036000.0d, 0.00000062993d },
            { 1040000.0d, 0.000000616931d },
            { 1044000.0d, 0.000000603913d },
            { 1048000.0d, 0.000000590879d },
            { 1052000.0d, 0.000000577833d },
            { 1056000.0d, 0.000000564779d },
            { 1060000.0d, 0.000000551721d },
            { 1064000.0d, 0.000000538663d },
            { 1068000.0d, 0.00000052561d },
            { 1072000.0d, 0.000000512566d },
            { 1076000.0d, 0.000000499536d },
            { 1080000.0d, 0.000000486524d },
            { 1084000.0d, 0.000000473535d },
            { 1088000.0d, 0.000000460574d },
            { 1092000.0d, 0.000000447647d },
            { 1096000.0d, 0.000000434758d },
            { 1100000.0d, 0.000000421914d },
            { 1104000.0d, 0.000000409118d },
            { 1108000.0d, 0.000000396378d },
            { 1112000.0d, 0.000000383698d },
            { 1116000.0d, 0.000000371086d },
            { 1120000.0d, 0.000000358546d },
            { 1124000.0d, 0.000000346085d },
            { 1128000.0d, 0.00000033371d },
            { 1132000.0d, 0.000000321427d },
            { 1136000.0d, 0.000000309242d },
            { 1140000.0d, 0.000000297163d },
            { 1144000.0d, 0.000000285196d },
            { 1148000.0d, 0.000000273349d },
            { 1152000.0d, 0.000000261629d },
            { 1156000.0d, 0.000000250043d },
            { 1160000.0d, 0.000000238599d },
            { 1164000.0d, 0.000000227305d },
            { 1168000.0d, 0.000000216169d },
            { 1172000.0d, 0.000000205199d },
            { 1176000.0d, 0.000000194403d },
            { 1180000.0d, 0.000000183789d },
            { 1184000.0d, 0.000000173367d },
            { 1188000.0d, 0.000000163145d },
            { 1192000.0d, 0.000000153133d },
            { 1196000.0d, 0.000000143338d },
            { 1200000.0d, 0.000000133772d },
            { 1204000.0d, 0.000000124443d },
            { 1208000.0d, 0.000000115361d },
            { 1212000.0d, 0.000000106536d },
            { 1216000.0d, 0.0000000979778d },
            { 1220000.0d, 0.0000000896975d },
            { 1224000.0d, 0.0000000817052d },
            { 1228000.0d, 0.0000000740116d },
            { 1232000.0d, 0.0000000666277d },
            { 1236000.0d, 0.0000000595646d },
            { 1240000.0d, 0.0000000528335d },
            { 1244000.0d, 0.000000046446d },
            { 1248000.0d, 0.0000000404137d },
            { 1252000.0d, 0.0000000347487d },
            { 1256000.0d, 0.0000000294629d },
            { 1260000.0d, 0.0000000245688d },
            { 1264000.0d, 0.0000000200787d },
            { 1268000.0d, 0.0000000160054d },
            { 1272000.0d, 0.0000000123618d },
            { 1276000.0d, 0.00000000916088d },
            { 1280000.0d, 0.00000000641593d },
            { 1284000.0d, 0.00000000414031d },
            { 1288000.0d, 0.0000000023475d },
            { 1292000.0d, 0.00000000105103d },
            { 1296000.0d, 0.000000000264317d },
            { 1300000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    