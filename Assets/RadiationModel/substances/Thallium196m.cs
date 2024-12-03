using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium196m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium196m";
        public override double halfLife { get; } = 5076.0d;
        public override double atomicWeight { get; } = 195.9709d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9620000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold196()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.071d, new GammaParticle(84030.0, 0.01475)), new(0.05d, new GammaParticle(222900.0, 0.00556)), new(0.08d, new GammaParticle(301500.0, 0.00411)), new(0.92d, new GammaParticle(426300.0, 0.00291)), new(0.13d, new GammaParticle(505200.0, 0.00245)), new(0.033d, new GammaParticle(588800.0, 0.00211)), new(0.94d, new GammaParticle(635300.0, 0.00195)), new(0.9d, new GammaParticle(695400.0, 0.00178)), new(0.05d, new GammaParticle(723500.0, 0.00171)), new(0.1332d, new GammaParticle(511000.0, 0.00243)), new(0.472031002012d, new GammaParticle(11777.0, 0.10528)), new(0.20439272557383684d, new GammaParticle(68894.0, 0.018)), new(0.3464870750531223d, new GammaParticle(70820.0, 0.01751)), new(0.11758919178116069d, new GammaParticle(80316.0, 0.01544)), new(0.15204282497304075d, new GammaParticle(81285.0, 0.01525)), new(0.03445363319188008d, new GammaParticle(82477.0, 0.01503)) } },
            { 0.038d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium196()), new(0.00015d, new GammaParticle(33700.0, 0.03679)), new(1.65e-05d, new GammaParticle(120100.0, 0.01032)), new(0.0036d, new GammaParticle(240700.0, 0.00515)), new(0.021d, new GammaParticle(274600.0, 0.00452)), new(0.0152077319072d, new GammaParticle(12148.0, 0.10206)), new(0.0036335270717977736d, new GammaParticle(70832.0, 0.0175)), new(0.00613357034402055d, new GammaParticle(72874.0, 0.01701)), new(0.002085956811242618d, new GammaParticle(82629.0, 0.015)), new(0.002705485984181676d, new GammaParticle(83631.0, 0.01483)), new(0.0006195291729390577d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 4000.0d, 0.000000000408002d },
            { 8000.0d, 0.00000000572787d },
            { 12000.0d, 0.0000000161275d },
            { 16000.0d, 0.0000000376424d },
            { 20000.0d, 0.0000000713877d },
            { 24000.0d, 0.000000120692d },
            { 28000.0d, 0.000000188693d },
            { 32000.0d, 0.000000275749d },
            { 36000.0d, 0.000000383567d },
            { 40000.0d, 0.000000513204d },
            { 44000.0d, 0.000000664598d },
            { 48000.0d, 0.000000838121d },
            { 52000.0d, 0.00000103354d },
            { 56000.0d, 0.00000125058d },
            { 60000.0d, 0.00000148885d },
            { 64000.0d, 0.00000174743d },
            { 68000.0d, 0.000002026d },
            { 72000.0d, 0.00000232376d },
            { 76000.0d, 0.00000263954d },
            { 80000.0d, 0.00000297299d },
            { 84000.0d, 0.00000332317d },
            { 88000.0d, 0.00000368887d },
            { 92000.0d, 0.00000406973d },
            { 96000.0d, 0.00000446482d },
            { 100000.0d, 0.00000487296d },
            { 106000.0d, 0.00000550867d },
            { 112000.0d, 0.00000617002d },
            { 118000.0d, 0.00000685457d },
            { 124000.0d, 0.00000756d },
            { 130000.0d, 0.00000828412d },
            { 136000.0d, 0.00000902489d },
            { 142000.0d, 0.00000978039d },
            { 148000.0d, 0.0000105488d },
            { 154000.0d, 0.0000113285d },
            { 160000.0d, 0.0000121179d },
            { 166000.0d, 0.0000129156d },
            { 172000.0d, 0.0000137202d },
            { 178000.0d, 0.0000145305d },
            { 184000.0d, 0.0000153452d },
            { 190000.0d, 0.0000161634d },
            { 196000.0d, 0.000016984d },
            { 202000.0d, 0.000017806d },
            { 208000.0d, 0.0000186286d },
            { 214000.0d, 0.0000194511d },
            { 220000.0d, 0.0000202726d },
            { 226000.0d, 0.0000210925d },
            { 232000.0d, 0.00002191d },
            { 238000.0d, 0.0000227247d },
            { 244000.0d, 0.0000235359d },
            { 250000.0d, 0.0000243431d },
            { 256000.0d, 0.0000251458d },
            { 262000.0d, 0.0000259437d },
            { 268000.0d, 0.0000267362d },
            { 274000.0d, 0.0000275229d },
            { 280000.0d, 0.0000283036d },
            { 286000.0d, 0.0000290779d },
            { 292000.0d, 0.0000298454d },
            { 298000.0d, 0.0000306058d },
            { 304000.0d, 0.000031359d },
            { 310000.0d, 0.0000321045d },
            { 316000.0d, 0.0000328423d },
            { 322000.0d, 0.000033572d },
            { 328000.0d, 0.0000342935d },
            { 334000.0d, 0.0000350066d },
            { 340000.0d, 0.000035711d },
            { 346000.0d, 0.0000364067d },
            { 352000.0d, 0.0000370935d },
            { 358000.0d, 0.0000377713d },
            { 364000.0d, 0.0000384398d },
            { 370000.0d, 0.0000390991d },
            { 376000.0d, 0.0000397488d },
            { 382000.0d, 0.0000403891d },
            { 388000.0d, 0.0000410197d },
            { 394000.0d, 0.0000416406d },
            { 400000.0d, 0.0000422517d },
            { 406000.0d, 0.0000428528d },
            { 412000.0d, 0.0000434442d },
            { 418000.0d, 0.0000440254d },
            { 424000.0d, 0.0000445966d },
            { 430000.0d, 0.0000451576d },
            { 436000.0d, 0.0000457085d },
            { 442000.0d, 0.0000462492d },
            { 448000.0d, 0.0000467797d },
            { 454000.0d, 0.0000472998d },
            { 460000.0d, 0.0000478096d },
            { 466000.0d, 0.0000483091d },
            { 472000.0d, 0.0000487982d },
            { 478000.0d, 0.000049277d },
            { 484000.0d, 0.0000497453d },
            { 490000.0d, 0.0000502032d },
            { 496000.0d, 0.0000506507d },
            { 502000.0d, 0.0000510878d },
            { 508000.0d, 0.0000515144d },
            { 514000.0d, 0.0000519306d },
            { 520000.0d, 0.0000523364d },
            { 526000.0d, 0.0000527317d },
            { 532000.0d, 0.0000531167d },
            { 538000.0d, 0.0000534912d },
            { 544000.0d, 0.0000538552d },
            { 550000.0d, 0.0000542089d },
            { 556000.0d, 0.0000545521d },
            { 562000.0d, 0.0000548851d },
            { 568000.0d, 0.0000552076d },
            { 574000.0d, 0.0000555198d },
            { 580000.0d, 0.0000558217d },
            { 586000.0d, 0.0000561133d },
            { 592000.0d, 0.0000563946d },
            { 598000.0d, 0.0000566657d },
            { 604000.0d, 0.0000569265d },
            { 610000.0d, 0.0000571771d },
            { 616000.0d, 0.0000574177d },
            { 622000.0d, 0.000057648d },
            { 628000.0d, 0.0000578682d },
            { 634000.0d, 0.0000580784d },
            { 640000.0d, 0.0000582785d },
            { 646000.0d, 0.0000584686d },
            { 652000.0d, 0.0000586487d },
            { 658000.0d, 0.0000588189d },
            { 664000.0d, 0.0000589792d },
            { 670000.0d, 0.0000591297d },
            { 676000.0d, 0.0000592703d },
            { 682000.0d, 0.000059401d },
            { 688000.0d, 0.0000595222d },
            { 694000.0d, 0.0000596336d },
            { 700000.0d, 0.0000597354d },
            { 706000.0d, 0.0000598276d },
            { 712000.0d, 0.0000599102d },
            { 718000.0d, 0.0000599833d },
            { 724000.0d, 0.0000600469d },
            { 730000.0d, 0.0000601011d },
            { 736000.0d, 0.0000601459d },
            { 742000.0d, 0.0000601815d },
            { 748000.0d, 0.0000602078d },
            { 754000.0d, 0.0000602248d },
            { 760000.0d, 0.0000602328d },
            { 766000.0d, 0.0000602316d },
            { 772000.0d, 0.0000602214d },
            { 778000.0d, 0.0000602021d },
            { 784000.0d, 0.0000601739d },
            { 790000.0d, 0.0000601369d },
            { 796000.0d, 0.000060091d },
            { 802000.0d, 0.0000600364d },
            { 808000.0d, 0.000059973d },
            { 814000.0d, 0.000059901d },
            { 820000.0d, 0.0000598205d },
            { 826000.0d, 0.0000597314d },
            { 832000.0d, 0.0000596338d },
            { 838000.0d, 0.0000595279d },
            { 844000.0d, 0.0000594136d },
            { 850000.0d, 0.0000592911d },
            { 856000.0d, 0.0000591604d },
            { 862000.0d, 0.0000590215d },
            { 868000.0d, 0.0000588746d },
            { 874000.0d, 0.0000587197d },
            { 880000.0d, 0.0000585569d },
            { 886000.0d, 0.0000583861d },
            { 892000.0d, 0.0000582077d },
            { 898000.0d, 0.0000580215d },
            { 904000.0d, 0.0000578277d },
            { 910000.0d, 0.0000576263d },
            { 916000.0d, 0.0000574175d },
            { 922000.0d, 0.0000572012d },
            { 928000.0d, 0.0000569776d },
            { 934000.0d, 0.0000567467d },
            { 940000.0d, 0.0000565086d },
            { 946000.0d, 0.0000562634d },
            { 952000.0d, 0.0000560112d },
            { 958000.0d, 0.0000557522d },
            { 964000.0d, 0.0000554861d },
            { 970000.0d, 0.0000552134d },
            { 976000.0d, 0.0000549339d },
            { 982000.0d, 0.0000546478d },
            { 988000.0d, 0.0000543552d },
            { 994000.0d, 0.0000540562d },
            { 1000000.0d, 0.0000537508d },
            { 1006000.0d, 0.0000534391d },
            { 1012000.0d, 0.0000531213d },
            { 1018000.0d, 0.0000527974d },
            { 1024000.0d, 0.0000524675d },
            { 1030000.0d, 0.0000521317d },
            { 1036000.0d, 0.0000517901d },
            { 1042000.0d, 0.0000514427d },
            { 1048000.0d, 0.0000510898d },
            { 1054000.0d, 0.0000507312d },
            { 1060000.0d, 0.0000503673d },
            { 1066000.0d, 0.0000499981d },
            { 1072000.0d, 0.0000496236d },
            { 1078000.0d, 0.000049244d },
            { 1084000.0d, 0.0000488593d },
            { 1090000.0d, 0.0000484698d },
            { 1096000.0d, 0.0000480754d },
            { 1102000.0d, 0.0000476762d },
            { 1108000.0d, 0.0000472724d },
            { 1114000.0d, 0.0000468641d },
            { 1120000.0d, 0.0000464515d },
            { 1126000.0d, 0.0000460345d },
            { 1132000.0d, 0.0000456134d },
            { 1138000.0d, 0.0000451881d },
            { 1144000.0d, 0.0000447589d },
            { 1150000.0d, 0.0000443258d },
            { 1156000.0d, 0.0000438889d },
            { 1162000.0d, 0.0000434485d },
            { 1168000.0d, 0.0000430046d },
            { 1174000.0d, 0.0000425572d },
            { 1180000.0d, 0.0000421066d },
            { 1186000.0d, 0.0000416528d },
            { 1192000.0d, 0.000041196d },
            { 1198000.0d, 0.0000407363d },
            { 1204000.0d, 0.0000402737d },
            { 1210000.0d, 0.0000398086d },
            { 1216000.0d, 0.0000393408d },
            { 1222000.0d, 0.0000388707d },
            { 1228000.0d, 0.0000383983d },
            { 1234000.0d, 0.0000379237d },
            { 1240000.0d, 0.0000374471d },
            { 1246000.0d, 0.0000369686d },
            { 1252000.0d, 0.0000364883d },
            { 1258000.0d, 0.0000360064d },
            { 1264000.0d, 0.0000355231d },
            { 1270000.0d, 0.0000350383d },
            { 1276000.0d, 0.0000345523d },
            { 1282000.0d, 0.0000340653d },
            { 1288000.0d, 0.0000335773d },
            { 1294000.0d, 0.0000330886d },
            { 1300000.0d, 0.0000325992d },
            { 1306000.0d, 0.0000321093d },
            { 1312000.0d, 0.000031619d },
            { 1318000.0d, 0.0000311285d },
            { 1324000.0d, 0.0000306379d },
            { 1330000.0d, 0.0000301475d },
            { 1336000.0d, 0.0000296572d },
            { 1342000.0d, 0.0000291674d },
            { 1348000.0d, 0.0000286782d },
            { 1354000.0d, 0.0000281895d },
            { 1360000.0d, 0.0000277017d },
            { 1366000.0d, 0.000027214d },
            { 1372000.0d, 0.0000267265d },
            { 1378000.0d, 0.0000262392d },
            { 1384000.0d, 0.0000257524d },
            { 1390000.0d, 0.0000252661d },
            { 1396000.0d, 0.0000247804d },
            { 1402000.0d, 0.0000242956d },
            { 1408000.0d, 0.0000238117d },
            { 1414000.0d, 0.0000233288d },
            { 1420000.0d, 0.000022847d },
            { 1426000.0d, 0.0000223665d },
            { 1432000.0d, 0.0000218875d },
            { 1438000.0d, 0.00002141d },
            { 1444000.0d, 0.0000209341d },
            { 1450000.0d, 0.00002046d },
            { 1456000.0d, 0.0000199879d },
            { 1462000.0d, 0.0000195179d },
            { 1468000.0d, 0.00001905d },
            { 1474000.0d, 0.0000185846d },
            { 1480000.0d, 0.0000181214d },
            { 1486000.0d, 0.0000176609d },
            { 1492000.0d, 0.0000172032d },
            { 1498000.0d, 0.0000167482d },
            { 1504000.0d, 0.0000162963d },
            { 1510000.0d, 0.0000158475d },
            { 1516000.0d, 0.0000154019d },
            { 1522000.0d, 0.0000149597d },
            { 1528000.0d, 0.000014521d },
            { 1534000.0d, 0.0000140861d },
            { 1540000.0d, 0.000013655d },
            { 1546000.0d, 0.0000132277d },
            { 1552000.0d, 0.0000128046d },
            { 1558000.0d, 0.0000123856d },
            { 1564000.0d, 0.0000119711d },
            { 1570000.0d, 0.000011561d },
            { 1576000.0d, 0.0000111555d },
            { 1582000.0d, 0.0000107549d },
            { 1588000.0d, 0.0000103592d },
            { 1594000.0d, 0.00000996851d },
            { 1600000.0d, 0.00000958306d },
            { 1606000.0d, 0.00000920295d },
            { 1612000.0d, 0.00000882834d },
            { 1618000.0d, 0.00000845937d },
            { 1624000.0d, 0.00000809618d },
            { 1630000.0d, 0.00000773893d },
            { 1636000.0d, 0.00000738775d },
            { 1642000.0d, 0.00000704279d },
            { 1648000.0d, 0.0000067042d },
            { 1654000.0d, 0.00000637212d },
            { 1660000.0d, 0.00000604671d },
            { 1666000.0d, 0.00000572811d },
            { 1672000.0d, 0.00000541647d },
            { 1678000.0d, 0.00000511194d },
            { 1684000.0d, 0.00000481467d },
            { 1690000.0d, 0.00000452481d },
            { 1696000.0d, 0.0000042425d },
            { 1702000.0d, 0.00000396791d },
            { 1708000.0d, 0.00000370118d },
            { 1714000.0d, 0.00000344247d },
            { 1720000.0d, 0.00000319192d },
            { 1726000.0d, 0.0000029497d },
            { 1732000.0d, 0.00000271594d },
            { 1738000.0d, 0.00000249081d },
            { 1744000.0d, 0.00000227446d },
            { 1750000.0d, 0.00000206704d },
            { 1756000.0d, 0.00000186871d },
            { 1762000.0d, 0.00000167963d },
            { 1768000.0d, 0.00000149994d },
            { 1774000.0d, 0.00000132981d },
            { 1780000.0d, 0.00000116938d },
            { 1786000.0d, 0.00000101882d },
            { 1792000.0d, 0.000000878278d },
            { 1798000.0d, 0.00000074791d },
            { 1804000.0d, 0.000000627873d },
            { 1810000.0d, 0.000000518323d },
            { 1816000.0d, 0.000000419414d },
            { 1822000.0d, 0.0000003313d },
            { 1828000.0d, 0.000000254135d },
            { 1834000.0d, 0.000000188072d },
            { 1840000.0d, 0.00000013326d },
            { 1846000.0d, 0.0000000898479d },
            { 1852000.0d, 0.0000000579764d },
            { 1858000.0d, 0.000000037775d },
            { 1864000.0d, 0.0000000287099d },
            { 1870000.0d, 0.0000000227721d },
            { 1876000.0d, 0.0000000175003d },
            { 1882000.0d, 0.0000000129039d },
            { 1888000.0d, 0.00000000899176d },
            { 1894000.0d, 0.00000000577297d },
            { 1900000.0d, 0.00000000325633d },
            { 1906000.0d, 0.00000000145035d },
            { 1912000.0d, 0.000000000362918d },
            { 1918000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    