using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium86m";
        public override double halfLife { get; } = 2844.0d;
        public override double atomicWeight { get; } = 85.91512d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9931d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium86()), new(4.3999999999999997e-07d, new GammaParticle(10200.0, 0.12155)), new(0.938d, new GammaParticle(208100.0, 0.00596)), new(0.02520164367192d, new GammaParticle(2027.0, 0.61166)), new(0.00984886708992403d, new GammaParticle(14883.0, 0.08331)), new(0.018885651179144834d, new GammaParticle(14958.0, 0.08289)), new(0.004741953014877973d, new GammaParticle(16803.0, 0.07379)), new(0.005396342530931133d, new GammaParticle(16880.0, 0.07345)), new(0.0006543895160531603d, new GammaParticle(17011.0, 0.07288)) } },
            { 0.0069d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium86()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0033d, new GammaParticle(98600.0, 0.01257)), new(0.0069d, new GammaParticle(627200.0, 0.00198)), new(0.0069d, new GammaParticle(1076600.0, 0.00115)), new(0.0069d, new GammaParticle(1153100.0, 0.00108)), new(0.0088d, new GammaParticle(511000.0, 0.00243)), new(0.00017042014900800002d, new GammaParticle(1890.0, 0.656)), new(0.001051248770428979d, new GammaParticle(14098.0, 0.08794)), new(0.0020196902409778655d, new GammaParticle(14165.0, 0.08753)), new(0.0004986878837107574d, new GammaParticle(15898.0, 0.07799)), new(0.0005635173085931558d, new GammaParticle(15955.0, 0.07771)), new(6.482942488239847e-05d, new GammaParticle(16085.0, 0.07708)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 4000.0d, 0.0000000014662d },
            { 8000.0d, 0.00000000811873d },
            { 12000.0d, 0.0000000218705d },
            { 16000.0d, 0.0000000429587d },
            { 20000.0d, 0.0000000708401d },
            { 24000.0d, 0.000000104699d },
            { 28000.0d, 0.000000143681d },
            { 32000.0d, 0.000000186992d },
            { 36000.0d, 0.00000023393d },
            { 40000.0d, 0.000000283888d },
            { 44000.0d, 0.000000336352d },
            { 48000.0d, 0.000000390885d },
            { 52000.0d, 0.000000447119d },
            { 56000.0d, 0.000000504742d },
            { 60000.0d, 0.000000563492d },
            { 64000.0d, 0.000000623145d },
            { 68000.0d, 0.000000683512d },
            { 72000.0d, 0.000000744431d },
            { 76000.0d, 0.000000805764d },
            { 80000.0d, 0.000000867393d },
            { 84000.0d, 0.000000929216d },
            { 88000.0d, 0.000000991145d },
            { 92000.0d, 0.0000010531d },
            { 96000.0d, 0.00000111503d },
            { 100000.0d, 0.00000117686d },
            { 104000.0d, 0.00000123855d },
            { 108000.0d, 0.00000130005d },
            { 112000.0d, 0.00000136133d },
            { 116000.0d, 0.00000142235d },
            { 120000.0d, 0.00000148309d },
            { 124000.0d, 0.00000154351d },
            { 128000.0d, 0.00000160359d },
            { 132000.0d, 0.00000166332d },
            { 136000.0d, 0.00000172268d },
            { 140000.0d, 0.00000178164d },
            { 144000.0d, 0.0000018402d },
            { 148000.0d, 0.00000189835d },
            { 152000.0d, 0.00000195606d },
            { 156000.0d, 0.00000201333d },
            { 160000.0d, 0.00000207016d },
            { 164000.0d, 0.00000212653d },
            { 168000.0d, 0.00000218244d },
            { 172000.0d, 0.00000223788d },
            { 176000.0d, 0.00000229284d },
            { 180000.0d, 0.00000234732d },
            { 184000.0d, 0.00000240131d },
            { 188000.0d, 0.00000245482d },
            { 192000.0d, 0.00000250783d },
            { 196000.0d, 0.00000256034d },
            { 200000.0d, 0.00000261234d },
            { 204000.0d, 0.00000266385d },
            { 208000.0d, 0.00000271484d },
            { 212000.0d, 0.00000276533d },
            { 216000.0d, 0.0000028153d },
            { 220000.0d, 0.00000286476d },
            { 224000.0d, 0.0000029137d },
            { 228000.0d, 0.00000296212d },
            { 232000.0d, 0.00000301003d },
            { 236000.0d, 0.00000305741d },
            { 240000.0d, 0.00000310427d },
            { 244000.0d, 0.0000031506d },
            { 248000.0d, 0.00000319641d },
            { 252000.0d, 0.00000324169d },
            { 256000.0d, 0.00000328644d },
            { 260000.0d, 0.00000333066d },
            { 264000.0d, 0.00000337436d },
            { 268000.0d, 0.00000341752d },
            { 272000.0d, 0.00000346015d },
            { 276000.0d, 0.00000350225d },
            { 280000.0d, 0.00000354382d },
            { 284000.0d, 0.00000358485d },
            { 288000.0d, 0.00000362535d },
            { 292000.0d, 0.00000366532d },
            { 296000.0d, 0.00000370474d },
            { 300000.0d, 0.00000374364d },
            { 304000.0d, 0.000003782d },
            { 308000.0d, 0.00000381982d },
            { 312000.0d, 0.0000038571d },
            { 316000.0d, 0.00000389385d },
            { 320000.0d, 0.00000393006d },
            { 324000.0d, 0.00000396573d },
            { 328000.0d, 0.00000400086d },
            { 332000.0d, 0.00000403546d },
            { 336000.0d, 0.00000406952d },
            { 340000.0d, 0.00000410304d },
            { 344000.0d, 0.00000413602d },
            { 348000.0d, 0.00000416846d },
            { 352000.0d, 0.00000420037d },
            { 356000.0d, 0.00000423173d },
            { 360000.0d, 0.00000426256d },
            { 364000.0d, 0.00000429285d },
            { 368000.0d, 0.0000043226d },
            { 372000.0d, 0.00000435181d },
            { 376000.0d, 0.00000438048d },
            { 380000.0d, 0.00000440862d },
            { 384000.0d, 0.00000443621d },
            { 388000.0d, 0.00000446327d },
            { 392000.0d, 0.00000448979d },
            { 396000.0d, 0.00000451578d },
            { 400000.0d, 0.00000454122d },
            { 404000.0d, 0.00000456613d },
            { 408000.0d, 0.00000459051d },
            { 412000.0d, 0.00000461435d },
            { 416000.0d, 0.00000463765d },
            { 420000.0d, 0.00000466042d },
            { 424000.0d, 0.00000468265d },
            { 428000.0d, 0.00000470435d },
            { 432000.0d, 0.00000472551d },
            { 436000.0d, 0.00000474614d },
            { 440000.0d, 0.00000476624d },
            { 444000.0d, 0.0000047858d },
            { 448000.0d, 0.00000480484d },
            { 452000.0d, 0.00000482334d },
            { 456000.0d, 0.00000484131d },
            { 460000.0d, 0.00000485876d },
            { 464000.0d, 0.00000487567d },
            { 468000.0d, 0.00000489206d },
            { 472000.0d, 0.00000490792d },
            { 476000.0d, 0.00000492325d },
            { 480000.0d, 0.00000493806d },
            { 484000.0d, 0.00000495234d },
            { 488000.0d, 0.0000049661d },
            { 492000.0d, 0.00000497933d },
            { 496000.0d, 0.00000499205d },
            { 500000.0d, 0.00000500424d },
            { 504000.0d, 0.00000501591d },
            { 508000.0d, 0.00000502707d },
            { 512000.0d, 0.0000050377d },
            { 516000.0d, 0.00000504782d },
            { 520000.0d, 0.00000505743d },
            { 524000.0d, 0.00000506652d },
            { 528000.0d, 0.0000050751d },
            { 532000.0d, 0.00000508316d },
            { 536000.0d, 0.00000509072d },
            { 540000.0d, 0.00000509776d },
            { 544000.0d, 0.0000051043d },
            { 548000.0d, 0.00000511033d },
            { 552000.0d, 0.00000511586d },
            { 556000.0d, 0.00000512088d },
            { 560000.0d, 0.0000051254d },
            { 564000.0d, 0.00000512942d },
            { 568000.0d, 0.00000513294d },
            { 572000.0d, 0.00000513596d },
            { 576000.0d, 0.00000513849d },
            { 580000.0d, 0.00000514052d },
            { 584000.0d, 0.00000514207d },
            { 588000.0d, 0.00000514312d },
            { 592000.0d, 0.00000514368d },
            { 596000.0d, 0.00000514375d },
            { 600000.0d, 0.00000514334d },
            { 604000.0d, 0.00000514244d },
            { 608000.0d, 0.00000514106d },
            { 612000.0d, 0.00000513921d },
            { 616000.0d, 0.00000513687d },
            { 620000.0d, 0.00000513406d },
            { 624000.0d, 0.00000513077d },
            { 628000.0d, 0.00000512701d },
            { 632000.0d, 0.00000512279d },
            { 636000.0d, 0.00000511809d },
            { 640000.0d, 0.00000511293d },
            { 644000.0d, 0.00000510731d },
            { 648000.0d, 0.00000510122d },
            { 652000.0d, 0.00000509468d },
            { 656000.0d, 0.00000508768d },
            { 660000.0d, 0.00000508022d },
            { 664000.0d, 0.00000507231d },
            { 668000.0d, 0.00000506396d },
            { 672000.0d, 0.00000505515d },
            { 676000.0d, 0.0000050459d },
            { 680000.0d, 0.00000503621d },
            { 684000.0d, 0.00000502608d },
            { 688000.0d, 0.00000501551d },
            { 692000.0d, 0.00000500451d },
            { 696000.0d, 0.00000499308d },
            { 700000.0d, 0.00000498121d },
            { 704000.0d, 0.00000496892d },
            { 708000.0d, 0.00000495621d },
            { 712000.0d, 0.00000494307d },
            { 716000.0d, 0.00000492952d },
            { 720000.0d, 0.00000491555d },
            { 724000.0d, 0.00000490117d },
            { 728000.0d, 0.00000488638d },
            { 732000.0d, 0.00000487118d },
            { 736000.0d, 0.00000485558d },
            { 740000.0d, 0.00000483958d },
            { 744000.0d, 0.00000482318d },
            { 748000.0d, 0.00000480639d },
            { 752000.0d, 0.0000047892d },
            { 756000.0d, 0.00000477163d },
            { 760000.0d, 0.00000475367d },
            { 764000.0d, 0.00000473533d },
            { 768000.0d, 0.00000471661d },
            { 772000.0d, 0.00000469752d },
            { 776000.0d, 0.00000467805d },
            { 780000.0d, 0.00000465822d },
            { 784000.0d, 0.00000463802d },
            { 788000.0d, 0.00000461745d },
            { 792000.0d, 0.00000459654d },
            { 796000.0d, 0.00000457526d },
            { 800000.0d, 0.00000455363d },
            { 804000.0d, 0.00000453166d },
            { 808000.0d, 0.00000450934d },
            { 812000.0d, 0.00000448669d },
            { 816000.0d, 0.00000446369d },
            { 820000.0d, 0.00000444037d },
            { 824000.0d, 0.00000441671d },
            { 828000.0d, 0.00000439273d },
            { 832000.0d, 0.00000436843d },
            { 836000.0d, 0.0000043438d },
            { 840000.0d, 0.00000431887d },
            { 844000.0d, 0.00000429363d },
            { 848000.0d, 0.00000426808d },
            { 852000.0d, 0.00000424222d },
            { 856000.0d, 0.00000421607d },
            { 860000.0d, 0.00000418963d },
            { 864000.0d, 0.0000041629d },
            { 868000.0d, 0.00000413588d },
            { 872000.0d, 0.00000410858d },
            { 876000.0d, 0.000004081d },
            { 880000.0d, 0.00000405315d },
            { 884000.0d, 0.00000402503d },
            { 888000.0d, 0.00000399665d },
            { 892000.0d, 0.00000396801d },
            { 896000.0d, 0.00000393911d },
            { 900000.0d, 0.00000390996d },
            { 904000.0d, 0.00000388057d },
            { 908000.0d, 0.00000385093d },
            { 912000.0d, 0.00000382106d },
            { 916000.0d, 0.00000379095d },
            { 920000.0d, 0.00000376061d },
            { 924000.0d, 0.00000373005d },
            { 928000.0d, 0.00000369928d },
            { 932000.0d, 0.00000366828d },
            { 936000.0d, 0.00000363708d },
            { 940000.0d, 0.00000360567d },
            { 944000.0d, 0.00000357407d },
            { 948000.0d, 0.00000354227d },
            { 952000.0d, 0.00000351028d },
            { 956000.0d, 0.0000034781d },
            { 960000.0d, 0.00000344574d },
            { 964000.0d, 0.00000341321d },
            { 968000.0d, 0.00000338051d },
            { 972000.0d, 0.00000334764d },
            { 976000.0d, 0.00000331461d },
            { 980000.0d, 0.00000328143d },
            { 984000.0d, 0.0000032481d },
            { 988000.0d, 0.00000321462d },
            { 992000.0d, 0.00000318101d },
            { 996000.0d, 0.00000314726d },
            { 1000000.0d, 0.00000311338d },
            { 1004000.0d, 0.00000307938d },
            { 1008000.0d, 0.00000304526d },
            { 1012000.0d, 0.00000301103d },
            { 1016000.0d, 0.00000297669d },
            { 1020000.0d, 0.00000294225d },
            { 1024000.0d, 0.00000290771d },
            { 1028000.0d, 0.00000287309d },
            { 1032000.0d, 0.00000283838d },
            { 1036000.0d, 0.00000280359d },
            { 1040000.0d, 0.00000276872d },
            { 1044000.0d, 0.00000273379d },
            { 1048000.0d, 0.0000026988d },
            { 1052000.0d, 0.00000266375d },
            { 1056000.0d, 0.00000262865d },
            { 1060000.0d, 0.00000259351d },
            { 1064000.0d, 0.00000255832d },
            { 1068000.0d, 0.00000252311d },
            { 1072000.0d, 0.00000248786d },
            { 1076000.0d, 0.0000024526d },
            { 1080000.0d, 0.00000241732d },
            { 1084000.0d, 0.00000238204d },
            { 1088000.0d, 0.00000234675d },
            { 1092000.0d, 0.00000231146d },
            { 1096000.0d, 0.00000227618d },
            { 1100000.0d, 0.00000224092d },
            { 1104000.0d, 0.00000220569d },
            { 1108000.0d, 0.00000217047d },
            { 1112000.0d, 0.0000021353d },
            { 1116000.0d, 0.00000210016d },
            { 1120000.0d, 0.00000206508d },
            { 1124000.0d, 0.00000203004d },
            { 1128000.0d, 0.00000199507d },
            { 1132000.0d, 0.00000196016d },
            { 1136000.0d, 0.00000192533d },
            { 1140000.0d, 0.00000189058d },
            { 1144000.0d, 0.00000185591d },
            { 1148000.0d, 0.00000182134d },
            { 1152000.0d, 0.00000178686d },
            { 1156000.0d, 0.00000175249d },
            { 1160000.0d, 0.00000171824d },
            { 1164000.0d, 0.0000016841d },
            { 1168000.0d, 0.00000165009d },
            { 1172000.0d, 0.00000161622d },
            { 1176000.0d, 0.00000158248d },
            { 1180000.0d, 0.00000154889d },
            { 1184000.0d, 0.00000151546d },
            { 1188000.0d, 0.00000148219d },
            { 1192000.0d, 0.00000144908d },
            { 1196000.0d, 0.00000141615d },
            { 1200000.0d, 0.0000013834d },
            { 1204000.0d, 0.00000135084d },
            { 1208000.0d, 0.00000131848d },
            { 1212000.0d, 0.00000128632d },
            { 1216000.0d, 0.00000125437d },
            { 1220000.0d, 0.00000122264d },
            { 1224000.0d, 0.00000119113d },
            { 1228000.0d, 0.00000115986d },
            { 1232000.0d, 0.00000112882d },
            { 1236000.0d, 0.00000109804d },
            { 1240000.0d, 0.0000010675d },
            { 1244000.0d, 0.00000103723d },
            { 1248000.0d, 0.00000100723d },
            { 1252000.0d, 0.000000977509d },
            { 1256000.0d, 0.000000948069d },
            { 1260000.0d, 0.000000918921d },
            { 1264000.0d, 0.000000890073d },
            { 1268000.0d, 0.000000861532d },
            { 1272000.0d, 0.000000833306d },
            { 1276000.0d, 0.000000805402d },
            { 1280000.0d, 0.000000777829d },
            { 1284000.0d, 0.000000750594d },
            { 1288000.0d, 0.000000723704d },
            { 1292000.0d, 0.000000697169d },
            { 1296000.0d, 0.000000670995d },
            { 1300000.0d, 0.00000064519d },
            { 1304000.0d, 0.000000619762d },
            { 1308000.0d, 0.00000059472d },
            { 1312000.0d, 0.000000570072d },
            { 1316000.0d, 0.000000545824d },
            { 1320000.0d, 0.000000521986d },
            { 1324000.0d, 0.000000498565d },
            { 1328000.0d, 0.00000047557d },
            { 1332000.0d, 0.000000453009d },
            { 1336000.0d, 0.000000430889d },
            { 1340000.0d, 0.000000409219d },
            { 1344000.0d, 0.000000388008d },
            { 1348000.0d, 0.000000367263d },
            { 1352000.0d, 0.000000346993d },
            { 1356000.0d, 0.000000327207d },
            { 1360000.0d, 0.000000307912d },
            { 1364000.0d, 0.000000289116d },
            { 1368000.0d, 0.000000270829d },
            { 1372000.0d, 0.000000253059d },
            { 1376000.0d, 0.000000235814d },
            { 1380000.0d, 0.000000219102d },
            { 1384000.0d, 0.000000202933d },
            { 1388000.0d, 0.000000187315d },
            { 1392000.0d, 0.000000172256d },
            { 1396000.0d, 0.000000157765d },
            { 1400000.0d, 0.00000014385d },
            { 1404000.0d, 0.000000130521d },
            { 1408000.0d, 0.000000117785d },
            { 1412000.0d, 0.000000105652d },
            { 1416000.0d, 0.0000000941303d },
            { 1420000.0d, 0.0000000832284d },
            { 1424000.0d, 0.0000000729551d },
            { 1428000.0d, 0.0000000633193d },
            { 1432000.0d, 0.0000000543297d },
            { 1436000.0d, 0.000000045995d },
            { 1440000.0d, 0.0000000383239d },
            { 1444000.0d, 0.0000000313254d },
            { 1448000.0d, 0.000000025008d },
            { 1452000.0d, 0.0000000193806d },
            { 1456000.0d, 0.0000000144518d },
            { 1460000.0d, 0.0000000102302d },
            { 1464000.0d, 0.00000000672446d },
            { 1468000.0d, 0.00000000394297d },
            { 1472000.0d, 0.00000000189392d },
            { 1476000.0d, 0.000000000585109d },
            { 1480000.0d, 0.0000000000232978d },
            { 1481000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    