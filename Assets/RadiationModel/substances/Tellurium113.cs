using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium113";
        public override double halfLife { get; } = 102.0d;
        public override double atomicWeight { get; } = 112.91589d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin113()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00462d, new GammaParticle(238400.0, 0.0052)), new(0.00594d, new GammaParticle(269800.0, 0.0046)), new(0.0264d, new GammaParticle(391800.0, 0.00316)), new(0.00242d, new GammaParticle(437700.0, 0.00283)), new(0.0066d, new GammaParticle(443300.0, 0.0028)), new(0.0055000000000000005d, new GammaParticle(473100.0, 0.00262)), new(0.0066d, new GammaParticle(583000.0, 0.00213)), new(0.011000000000000001d, new GammaParticle(609300.0, 0.00203)), new(0.0638d, new GammaParticle(644800.0, 0.00192)), new(0.00792d, new GammaParticle(647500.0, 0.00191)), new(0.00968d, new GammaParticle(737000.0, 0.00168)), new(0.22d, new GammaParticle(814400.0, 0.00152)), new(0.013859999999999999d, new GammaParticle(915000.0, 0.00136)), new(0.1298d, new GammaParticle(1018100.0, 0.00122)), new(0.0154d, new GammaParticle(1039500.0, 0.00119)), new(0.0154d, new GammaParticle(1071700.0, 0.00116)), new(0.1232d, new GammaParticle(1181000.0, 0.00105)), new(0.0132d, new GammaParticle(1206600.0, 0.00103)), new(0.0088d, new GammaParticle(1245400.0, 0.001)), new(0.055d, new GammaParticle(1256700.0, 0.00099)), new(0.0176d, new GammaParticle(1301300.0, 0.00095)), new(0.0132d, new GammaParticle(1317900.0, 0.00094)), new(0.011659999999999998d, new GammaParticle(1358000.0, 0.00091)), new(0.0176d, new GammaParticle(1449700.0, 0.00086)), new(0.0176d, new GammaParticle(1460000.0, 0.00085)), new(0.0154d, new GammaParticle(1515100.0, 0.00082)), new(0.022000000000000002d, new GammaParticle(1550300.0, 0.0008)), new(0.0132d, new GammaParticle(1567200.0, 0.00079)), new(0.008579999999999999d, new GammaParticle(1719800.0, 0.00072)), new(0.0176d, new GammaParticle(1803600.0, 0.00069)), new(0.0242d, new GammaParticle(1868100.0, 0.00066)), new(0.0088d, new GammaParticle(1944300.0, 0.00064)), new(0.0154d, new GammaParticle(2047800.0, 0.00061)), new(0.0286d, new GammaParticle(2093700.0, 0.00059)), new(0.019799999999999998d, new GammaParticle(2115500.0, 0.00059)), new(0.019799999999999998d, new GammaParticle(2221200.0, 0.00056)), new(0.0264d, new GammaParticle(2535200.0, 0.00049)), new(0.0154d, new GammaParticle(2552400.0, 0.00049)), new(0.0176d, new GammaParticle(2606500.0, 0.00048)), new(1.8119999999999998d, new GammaParticle(511000.0, 0.00243)), new(0.0076d, new GammaParticle(3941.0, 0.3146)), new(0.022400000000000003d, new GammaParticle(26111.0, 0.04748)), new(0.0418d, new GammaParticle(26359.0, 0.04704)), new(0.011899999999999999d, new GammaParticle(29821.0, 0.04158)), new(0.0144d, new GammaParticle(30069.0, 0.04123)), new(0.00246d, new GammaParticle(30387.0, 0.0408)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 8000.0d, 0.0000000361007d },
            { 16000.0d, 0.000000368797d },
            { 24000.0d, 0.00000102521d },
            { 32000.0d, 0.00000203688d },
            { 40000.0d, 0.00000338562d },
            { 48000.0d, 0.0000050243d },
            { 56000.0d, 0.00000689892d },
            { 64000.0d, 0.00000897684d },
            { 72000.0d, 0.0000112191d },
            { 80000.0d, 0.0000136006d },
            { 88000.0d, 0.000016095d },
            { 96000.0d, 0.0000186884d },
            { 104000.0d, 0.0000213584d },
            { 114000.0d, 0.0000247915d },
            { 124000.0d, 0.000028307d },
            { 134000.0d, 0.0000318905d },
            { 144000.0d, 0.0000355286d },
            { 154000.0d, 0.0000392086d },
            { 164000.0d, 0.0000429232d },
            { 174000.0d, 0.000046665d },
            { 184000.0d, 0.0000504279d },
            { 194000.0d, 0.0000542067d },
            { 204000.0d, 0.000057997d },
            { 214000.0d, 0.0000617955d },
            { 224000.0d, 0.0000655992d },
            { 234000.0d, 0.000069405d },
            { 244000.0d, 0.000073211d },
            { 254000.0d, 0.0000770151d },
            { 264000.0d, 0.0000808153d },
            { 274000.0d, 0.0000846104d },
            { 284000.0d, 0.0000883988d },
            { 294000.0d, 0.0000921793d },
            { 304000.0d, 0.0000959509d },
            { 314000.0d, 0.0000997123d },
            { 324000.0d, 0.000103463d },
            { 334000.0d, 0.000107201d },
            { 344000.0d, 0.000110927d },
            { 354000.0d, 0.00011464d },
            { 364000.0d, 0.000118338d },
            { 374000.0d, 0.000122022d },
            { 384000.0d, 0.00012569d },
            { 394000.0d, 0.000129342d },
            { 404000.0d, 0.000132978d },
            { 414000.0d, 0.000136597d },
            { 424000.0d, 0.000140198d },
            { 434000.0d, 0.000143781d },
            { 444000.0d, 0.000147346d },
            { 454000.0d, 0.000150891d },
            { 464000.0d, 0.000154418d },
            { 474000.0d, 0.000157924d },
            { 484000.0d, 0.00016141d },
            { 494000.0d, 0.000164875d },
            { 504000.0d, 0.000168319d },
            { 514000.0d, 0.000171742d },
            { 524000.0d, 0.000175142d },
            { 534000.0d, 0.000178521d },
            { 544000.0d, 0.000181877d },
            { 554000.0d, 0.00018521d },
            { 564000.0d, 0.000188519d },
            { 574000.0d, 0.000191805d },
            { 584000.0d, 0.000195067d },
            { 594000.0d, 0.000198305d },
            { 604000.0d, 0.000201518d },
            { 614000.0d, 0.000204706d },
            { 624000.0d, 0.000207869d },
            { 634000.0d, 0.000211006d },
            { 644000.0d, 0.000214117d },
            { 654000.0d, 0.000217202d },
            { 664000.0d, 0.000220261d },
            { 674000.0d, 0.000223293d },
            { 684000.0d, 0.000226298d },
            { 694000.0d, 0.000229276d },
            { 704000.0d, 0.000232226d },
            { 714000.0d, 0.000235149d },
            { 724000.0d, 0.000238043d },
            { 734000.0d, 0.000240909d },
            { 744000.0d, 0.000243747d },
            { 754000.0d, 0.000246555d },
            { 764000.0d, 0.000249335d },
            { 774000.0d, 0.000252086d },
            { 784000.0d, 0.000254807d },
            { 794000.0d, 0.000257498d },
            { 804000.0d, 0.000260159d },
            { 814000.0d, 0.00026279d },
            { 824000.0d, 0.000265391d },
            { 834000.0d, 0.000267961d },
            { 844000.0d, 0.0002705d },
            { 854000.0d, 0.000273009d },
            { 864000.0d, 0.000275487d },
            { 874000.0d, 0.000277933d },
            { 884000.0d, 0.000280347d },
            { 894000.0d, 0.00028273d },
            { 904000.0d, 0.000285081d },
            { 914000.0d, 0.0002874d },
            { 924000.0d, 0.000289688d },
            { 934000.0d, 0.000291942d },
            { 944000.0d, 0.000294164d },
            { 954000.0d, 0.000296354d },
            { 964000.0d, 0.00029851d },
            { 974000.0d, 0.000300634d },
            { 984000.0d, 0.000302725d },
            { 994000.0d, 0.000304783d },
            { 1004000.0d, 0.000306807d },
            { 1020000.0d, 0.000309977d },
            { 1036000.0d, 0.00031306d },
            { 1052000.0d, 0.000316058d },
            { 1068000.0d, 0.000318968d },
            { 1084000.0d, 0.000321791d },
            { 1100000.0d, 0.000324527d },
            { 1116000.0d, 0.000327175d },
            { 1132000.0d, 0.000329735d },
            { 1148000.0d, 0.000332207d },
            { 1164000.0d, 0.00033459d },
            { 1180000.0d, 0.000336884d },
            { 1196000.0d, 0.000339089d },
            { 1212000.0d, 0.000341206d },
            { 1228000.0d, 0.000343233d },
            { 1244000.0d, 0.000345172d },
            { 1260000.0d, 0.000347021d },
            { 1276000.0d, 0.000348781d },
            { 1292000.0d, 0.000350451d },
            { 1308000.0d, 0.000352033d },
            { 1324000.0d, 0.000353525d },
            { 1340000.0d, 0.000354929d },
            { 1356000.0d, 0.000356244d },
            { 1372000.0d, 0.00035747d },
            { 1388000.0d, 0.000358608d },
            { 1404000.0d, 0.000359658d },
            { 1420000.0d, 0.00036062d },
            { 1436000.0d, 0.000361494d },
            { 1452000.0d, 0.000362281d },
            { 1468000.0d, 0.000362981d },
            { 1484000.0d, 0.000363594d },
            { 1500000.0d, 0.000364122d },
            { 1516000.0d, 0.000364563d },
            { 1532000.0d, 0.00036492d },
            { 1548000.0d, 0.000365192d },
            { 1564000.0d, 0.000365379d },
            { 1580000.0d, 0.000365483d },
            { 1596000.0d, 0.000365505d },
            { 1612000.0d, 0.000365444d },
            { 1628000.0d, 0.000365301d },
            { 1644000.0d, 0.000365077d },
            { 1660000.0d, 0.000364772d },
            { 1676000.0d, 0.000364389d },
            { 1692000.0d, 0.000363926d },
            { 1708000.0d, 0.000363385d },
            { 1724000.0d, 0.000362768d },
            { 1740000.0d, 0.000362074d },
            { 1756000.0d, 0.000361304d },
            { 1772000.0d, 0.00036046d },
            { 1788000.0d, 0.000359543d },
            { 1804000.0d, 0.000358552d },
            { 1820000.0d, 0.000357491d },
            { 1836000.0d, 0.000356359d },
            { 1852000.0d, 0.000355157d },
            { 1868000.0d, 0.000353887d },
            { 1884000.0d, 0.00035255d },
            { 1900000.0d, 0.000351147d },
            { 1916000.0d, 0.000349679d },
            { 1932000.0d, 0.000348148d },
            { 1948000.0d, 0.000346553d },
            { 1964000.0d, 0.000344898d },
            { 1980000.0d, 0.000343183d },
            { 1996000.0d, 0.000341409d },
            { 2012000.0d, 0.000339579d },
            { 2028000.0d, 0.000337692d },
            { 2044000.0d, 0.000335752d },
            { 2060000.0d, 0.000333758d },
            { 2076000.0d, 0.000331712d },
            { 2092000.0d, 0.000329618d },
            { 2108000.0d, 0.000327474d },
            { 2124000.0d, 0.000325284d },
            { 2140000.0d, 0.000323048d },
            { 2156000.0d, 0.000320769d },
            { 2172000.0d, 0.000318448d },
            { 2188000.0d, 0.000316087d },
            { 2204000.0d, 0.000313687d },
            { 2220000.0d, 0.00031125d },
            { 2236000.0d, 0.000308778d },
            { 2252000.0d, 0.000306272d },
            { 2268000.0d, 0.000303735d },
            { 2284000.0d, 0.000301169d },
            { 2300000.0d, 0.000298575d },
            { 2316000.0d, 0.000295954d },
            { 2332000.0d, 0.00029331d },
            { 2348000.0d, 0.000290644d },
            { 2364000.0d, 0.000287958d },
            { 2380000.0d, 0.000285253d },
            { 2396000.0d, 0.000282533d },
            { 2412000.0d, 0.000279798d },
            { 2428000.0d, 0.000277052d },
            { 2444000.0d, 0.000274296d },
            { 2460000.0d, 0.000271532d },
            { 2476000.0d, 0.000268763d },
            { 2492000.0d, 0.00026599d },
            { 2508000.0d, 0.000263216d },
            { 2524000.0d, 0.000260437d },
            { 2540000.0d, 0.000257641d },
            { 2556000.0d, 0.000254827d },
            { 2572000.0d, 0.000251997d },
            { 2588000.0d, 0.000249153d },
            { 2604000.0d, 0.000246297d },
            { 2620000.0d, 0.000243431d },
            { 2636000.0d, 0.000240555d },
            { 2652000.0d, 0.000237672d },
            { 2668000.0d, 0.000234784d },
            { 2684000.0d, 0.000231892d },
            { 2700000.0d, 0.000228999d },
            { 2716000.0d, 0.000226105d },
            { 2732000.0d, 0.000223214d },
            { 2748000.0d, 0.000220326d },
            { 2764000.0d, 0.000217444d },
            { 2780000.0d, 0.000214569d },
            { 2796000.0d, 0.000211704d },
            { 2812000.0d, 0.000208851d },
            { 2828000.0d, 0.000206011d },
            { 2844000.0d, 0.000203186d },
            { 2860000.0d, 0.000200378d },
            { 2876000.0d, 0.00019759d },
            { 2892000.0d, 0.000194819d },
            { 2908000.0d, 0.000192062d },
            { 2924000.0d, 0.000189323d },
            { 2940000.0d, 0.000186599d },
            { 2956000.0d, 0.000183887d },
            { 2972000.0d, 0.000181175d },
            { 2988000.0d, 0.00017846d },
            { 3004000.0d, 0.000175743d },
            { 3020000.0d, 0.000173025d },
            { 3036000.0d, 0.000170308d },
            { 3052000.0d, 0.000167593d },
            { 3068000.0d, 0.000164882d },
            { 3084000.0d, 0.000162174d },
            { 3100000.0d, 0.000159474d },
            { 3116000.0d, 0.00015678d },
            { 3132000.0d, 0.000154094d },
            { 3148000.0d, 0.000151419d },
            { 3164000.0d, 0.000148755d },
            { 3180000.0d, 0.000146104d },
            { 3196000.0d, 0.000143467d },
            { 3212000.0d, 0.000140839d },
            { 3228000.0d, 0.000138217d },
            { 3244000.0d, 0.000135602d },
            { 3260000.0d, 0.000132996d },
            { 3276000.0d, 0.000130398d },
            { 3292000.0d, 0.000127811d },
            { 3308000.0d, 0.000125236d },
            { 3324000.0d, 0.000122675d },
            { 3340000.0d, 0.000120127d },
            { 3356000.0d, 0.000117595d },
            { 3372000.0d, 0.00011508d },
            { 3388000.0d, 0.000112584d },
            { 3404000.0d, 0.000110106d },
            { 3420000.0d, 0.00010765d },
            { 3436000.0d, 0.000105216d },
            { 3452000.0d, 0.000102805d },
            { 3468000.0d, 0.000100419d },
            { 3484000.0d, 0.000098059d },
            { 3500000.0d, 0.0000957265d },
            { 3516000.0d, 0.0000934186d },
            { 3532000.0d, 0.000091134d },
            { 3548000.0d, 0.0000888741d },
            { 3564000.0d, 0.0000866403d },
            { 3580000.0d, 0.0000844339d },
            { 3596000.0d, 0.0000822561d },
            { 3612000.0d, 0.0000801082d },
            { 3628000.0d, 0.0000779917d },
            { 3644000.0d, 0.0000759077d },
            { 3660000.0d, 0.0000738579d },
            { 3676000.0d, 0.0000718434d },
            { 3692000.0d, 0.0000698657d },
            { 3708000.0d, 0.0000679261d },
            { 3724000.0d, 0.0000660261d },
            { 3740000.0d, 0.0000641671d },
            { 3756000.0d, 0.0000623506d },
            { 3772000.0d, 0.000060578d },
            { 3788000.0d, 0.0000588506d },
            { 3804000.0d, 0.0000571669d },
            { 3820000.0d, 0.0000555226d },
            { 3836000.0d, 0.0000539188d },
            { 3852000.0d, 0.0000523569d },
            { 3868000.0d, 0.000050838d },
            { 3884000.0d, 0.0000493523d },
            { 3900000.0d, 0.0000478922d },
            { 3916000.0d, 0.0000464589d },
            { 3932000.0d, 0.0000450534d },
            { 3948000.0d, 0.0000436766d },
            { 3964000.0d, 0.0000423298d },
            { 3980000.0d, 0.0000410138d },
            { 3996000.0d, 0.0000397298d },
            { 4012000.0d, 0.0000384788d },
            { 4028000.0d, 0.000037262d },
            { 4044000.0d, 0.0000360742d },
            { 4060000.0d, 0.0000349066d },
            { 4076000.0d, 0.0000337601d },
            { 4092000.0d, 0.0000326356d },
            { 4108000.0d, 0.0000315339d },
            { 4124000.0d, 0.000030456d },
            { 4140000.0d, 0.0000294029d },
            { 4156000.0d, 0.0000283755d },
            { 4172000.0d, 0.0000273748d },
            { 4188000.0d, 0.0000264019d },
            { 4204000.0d, 0.0000254577d },
            { 4220000.0d, 0.0000245433d },
            { 4236000.0d, 0.0000236595d },
            { 4252000.0d, 0.0000227964d },
            { 4268000.0d, 0.000021948d },
            { 4284000.0d, 0.0000211152d },
            { 4300000.0d, 0.0000202988d },
            { 4316000.0d, 0.0000194998d },
            { 4332000.0d, 0.0000187191d },
            { 4348000.0d, 0.0000179576d },
            { 4364000.0d, 0.0000172162d },
            { 4380000.0d, 0.0000164959d },
            { 4396000.0d, 0.0000157978d },
            { 4412000.0d, 0.0000151206d },
            { 4428000.0d, 0.0000144549d },
            { 4444000.0d, 0.0000137997d },
            { 4460000.0d, 0.0000131553d },
            { 4476000.0d, 0.0000125221d },
            { 4492000.0d, 0.0000119005d },
            { 4508000.0d, 0.0000112906d },
            { 4524000.0d, 0.0000106929d },
            { 4540000.0d, 0.0000101077d },
            { 4556000.0d, 0.00000953521d },
            { 4572000.0d, 0.00000897591d },
            { 4588000.0d, 0.00000843007d },
            { 4604000.0d, 0.00000789802d },
            { 4620000.0d, 0.00000738011d },
            { 4636000.0d, 0.00000687667d },
            { 4652000.0d, 0.00000638804d },
            { 4668000.0d, 0.00000591456d },
            { 4684000.0d, 0.00000545658d },
            { 4700000.0d, 0.00000501443d },
            { 4716000.0d, 0.00000458846d },
            { 4732000.0d, 0.00000417902d },
            { 4748000.0d, 0.00000378646d },
            { 4764000.0d, 0.00000341112d },
            { 4780000.0d, 0.00000305336d },
            { 4796000.0d, 0.00000271353d },
            { 4812000.0d, 0.00000239196d },
            { 4828000.0d, 0.00000208904d },
            { 4844000.0d, 0.00000180509d },
            { 4860000.0d, 0.00000154048d },
            { 4876000.0d, 0.00000129558d },
            { 4892000.0d, 0.00000107071d },
            { 4908000.0d, 0.000000866245d },
            { 4924000.0d, 0.000000682533d },
            { 4940000.0d, 0.000000519926d },
            { 4956000.0d, 0.000000378773d },
            { 4972000.0d, 0.000000259415d },
            { 4988000.0d, 0.000000162193d },
            { 5004000.0d, 0.0000000874327d },
            { 5020000.0d, 0.0000000354434d },
            { 5036000.0d, 0.00000000649553d },
            { 5048000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    