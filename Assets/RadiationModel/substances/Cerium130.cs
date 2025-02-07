using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium130";
        public override double halfLife { get; } = 1374.0d;
        public override double atomicWeight { get; } = 129.91474d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium130()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.000259d, new GammaParticle(46700.0, 0.02655)), new(0.00037d, new GammaParticle(47500.0, 0.0261)), new(0.0015170000000000001d, new GammaParticle(59600.0, 0.0208)), new(0.000481d, new GammaParticle(73500.0, 0.01687)), new(0.000185d, new GammaParticle(77600.0, 0.01598)), new(0.000222d, new GammaParticle(80500.0, 0.0154)), new(0.001036d, new GammaParticle(83400.0, 0.01487)), new(0.001258d, new GammaParticle(87900.0, 0.01411)), new(0.00888d, new GammaParticle(88900.0, 0.01395)), new(0.00333d, new GammaParticle(93300.0, 0.01329)), new(0.002405d, new GammaParticle(103900.0, 0.01193)), new(0.02146d, new GammaParticle(109300.0, 0.01134)), new(0.02146d, new GammaParticle(110400.0, 0.01123)), new(0.000222d, new GammaParticle(127500.0, 0.00972)), new(0.003219d, new GammaParticle(131000.0, 0.00946)), new(0.37d, new GammaParticle(131100.0, 0.00946)), new(0.05069d, new GammaParticle(136400.0, 0.00909)), new(0.003552d, new GammaParticle(136600.0, 0.00908)), new(0.000222d, new GammaParticle(139000.0, 0.00892)), new(0.00222d, new GammaParticle(141300.0, 0.00877)), new(0.00777d, new GammaParticle(163000.0, 0.00761)), new(0.002516d, new GammaParticle(170500.0, 0.00727)), new(0.002183d, new GammaParticle(173100.0, 0.00716)), new(0.001961d, new GammaParticle(175800.0, 0.00705)), new(0.013024d, new GammaParticle(176900.0, 0.00701)), new(0.008843d, new GammaParticle(183200.0, 0.00677)), new(0.001554d, new GammaParticle(193600.0, 0.0064)), new(0.009065d, new GammaParticle(196900.0, 0.0063)), new(0.043845d, new GammaParticle(209600.0, 0.00592)), new(0.0031450000000000002d, new GammaParticle(209900.0, 0.00591)), new(0.001332d, new GammaParticle(214700.0, 0.00577)), new(0.05809d, new GammaParticle(219800.0, 0.00564)), new(0.0030340000000000002d, new GammaParticle(230500.0, 0.00538)), new(0.002627d, new GammaParticle(240100.0, 0.00516)), new(0.0021460000000000003d, new GammaParticle(248400.0, 0.00499)), new(0.0148d, new GammaParticle(253700.0, 0.00489)), new(0.01665d, new GammaParticle(256500.0, 0.00483)), new(0.0030340000000000002d, new GammaParticle(266900.0, 0.00465)), new(0.047729999999999995d, new GammaParticle(267300.0, 0.00464)), new(0.009102d, new GammaParticle(274200.0, 0.00452)), new(0.0024790000000000003d, new GammaParticle(294800.0, 0.00421)), new(0.008029d, new GammaParticle(300500.0, 0.00413)), new(0.010434d, new GammaParticle(304100.0, 0.00408)), new(0.053094999999999996d, new GammaParticle(307500.0, 0.00403)), new(0.002442d, new GammaParticle(313300.0, 0.00396)), new(0.00148d, new GammaParticle(321700.0, 0.00385)), new(0.002405d, new GammaParticle(333900.0, 0.00371)), new(0.015836d, new GammaParticle(340600.0, 0.00364)), new(0.0111d, new GammaParticle(346800.0, 0.00358)), new(0.006327d, new GammaParticle(350800.0, 0.00353)), new(0.00703d, new GammaParticle(384800.0, 0.00322)), new(0.002294d, new GammaParticle(387000.0, 0.0032)), new(0.001221d, new GammaParticle(389200.0, 0.00319)), new(0.003552d, new GammaParticle(393000.0, 0.00315)), new(0.00703d, new GammaParticle(430200.0, 0.00288)), new(0.0025900000000000003d, new GammaParticle(431500.0, 0.00287)), new(0.0062900000000000005d, new GammaParticle(443200.0, 0.0028)), new(0.00481d, new GammaParticle(444200.0, 0.00279)), new(0.006882d, new GammaParticle(463300.0, 0.00268)), new(0.002035d, new GammaParticle(470500.0, 0.00264)), new(0.0037d, new GammaParticle(477000.0, 0.0026)), new(0.0037d, new GammaParticle(478000.0, 0.00259)), new(0.002442d, new GammaParticle(481700.0, 0.00257)), new(0.003589d, new GammaParticle(520000.0, 0.00238)), new(0.004033d, new GammaParticle(524000.0, 0.00237)), new(0.004551d, new GammaParticle(528800.0, 0.00234)), new(0.00296d, new GammaParticle(535100.0, 0.00232)), new(0.0074d, new GammaParticle(541700.0, 0.00229)), new(0.0007030000000000001d, new GammaParticle(562700.0, 0.0022)), new(0.00481d, new GammaParticle(566200.0, 0.00219)), new(0.004107d, new GammaParticle(589200.0, 0.0021)), new(0.001554d, new GammaParticle(590700.0, 0.0021)), new(0.000777d, new GammaParticle(594200.0, 0.00209)), new(0.00555d, new GammaParticle(605800.0, 0.00205)), new(0.00555d, new GammaParticle(606800.0, 0.00204)), new(0.0022570000000000003d, new GammaParticle(645300.0, 0.00192)), new(0.0014060000000000001d, new GammaParticle(694200.0, 0.00179)), new(0.000629d, new GammaParticle(696700.0, 0.00178)), new(0.0028120000000000003d, new GammaParticle(718600.0, 0.00173)), new(0.003367d, new GammaParticle(724900.0, 0.00171)), new(0.004033d, new GammaParticle(737300.0, 0.00168)), new(0.011692000000000001d, new GammaParticle(752200.0, 0.00165)), new(0.002294d, new GammaParticle(765200.0, 0.00162)), new(0.001665d, new GammaParticle(782500.0, 0.00158)), new(0.00185d, new GammaParticle(810500.0, 0.00153)), new(0.0062900000000000005d, new GammaParticle(812000.0, 0.00153)), new(0.00481d, new GammaParticle(818000.0, 0.00152)), new(0.002627d, new GammaParticle(828300.0, 0.0015)), new(0.003848d, new GammaParticle(845600.0, 0.00147)), new(0.014171d, new GammaParticle(856300.0, 0.00145)), new(0.011063d, new GammaParticle(861200.0, 0.00144)), new(0.012136000000000001d, new GammaParticle(889400.0, 0.00139)), new(0.005069000000000001d, new GammaParticle(901300.0, 0.00138)), new(0.0014060000000000001d, new GammaParticle(922000.0, 0.00134)), new(0.00592d, new GammaParticle(948800.0, 0.00131)), new(0.038849999999999996d, new GammaParticle(977200.0, 0.00127)), new(0.0025900000000000003d, new GammaParticle(986600.0, 0.00126)), new(0.001998d, new GammaParticle(1032800.0, 0.0012)), new(0.007289d, new GammaParticle(1037500.0, 0.0012)), new(0.007437d, new GammaParticle(1065800.0, 0.00116)), new(0.0028120000000000003d, new GammaParticle(1069300.0, 0.00116)), new(0.001369d, new GammaParticle(1123800.0, 0.0011)), new(0.010175d, new GammaParticle(1158000.0, 0.00107)), new(0.002072d, new GammaParticle(1164000.0, 0.00107)), new(0.019129d, new GammaParticle(1196600.0, 0.00104)), new(0.020720000000000002d, new GammaParticle(1289100.0, 0.00096)), new(0.002109d, new GammaParticle(1300300.0, 0.00095)), new(0.002109d, new GammaParticle(1431300.0, 0.00087)), new(0.0922d, new GammaParticle(511000.0, 0.00243)), new(0.13d, new GammaParticle(5185.0, 0.23912)), new(0.268d, new GammaParticle(33034.0, 0.03753)), new(0.49d, new GammaParticle(33442.0, 0.03707)), new(0.147d, new GammaParticle(37908.0, 0.03271)), new(0.184d, new GammaParticle(38273.0, 0.03239)), new(0.037000000000000005d, new GammaParticle(38725.0, 0.03202)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.000000000000649895d },
            { 200.0d, 0.00000000000165054d },
            { 300.0d, 0.00000000000300307d },
            { 400.0d, 0.0000000000047075d },
            { 500.0d, 0.00000000000676385d },
            { 600.0d, 0.0000000000109675d },
            { 700.0d, 0.0000000000239706d },
            { 800.0d, 0.0000000000401666d },
            { 900.0d, 0.0000000000595557d },
            { 1000.0d, 0.0000000000821378d },
            { 1500.0d, 0.000000000411176d },
            { 2000.0d, 0.00000000135909d },
            { 2500.0d, 0.00000000271972d },
            { 3000.0d, 0.00000000449109d },
            { 3500.0d, 0.00000000668022d },
            { 4000.0d, 0.00000000928528d },
            { 4500.0d, 0.0000000124448d },
            { 5000.0d, 0.0000000160782d },
            { 5500.0d, 0.0000000201921d },
            { 6000.0d, 0.0000000247848d },
            { 6500.0d, 0.0000000309055d },
            { 7000.0d, 0.0000000378225d },
            { 7500.0d, 0.000000045542d },
            { 8000.0d, 0.0000000540621d },
            { 8500.0d, 0.0000000635056d },
            { 9000.0d, 0.0000000738005d },
            { 9500.0d, 0.0000000857541d },
            { 10000.0d, 0.0000000987919d },
            { 11000.0d, 0.000000128372d },
            { 12000.0d, 0.000000162475d },
            { 13000.0d, 0.000000202717d },
            { 14000.0d, 0.000000248337d },
            { 15000.0d, 0.00000029949d },
            { 16000.0d, 0.000000357118d },
            { 17000.0d, 0.000000420841d },
            { 18000.0d, 0.000000490626d },
            { 19000.0d, 0.00000056715d },
            { 20000.0d, 0.00000065009d },
            { 21000.0d, 0.000000739486d },
            { 22000.0d, 0.000000835615d },
            { 23000.0d, 0.000000938345d },
            { 24000.0d, 0.00000104767d },
            { 25000.0d, 0.00000116362d },
            { 26000.0d, 0.00000128618d },
            { 27000.0d, 0.00000141532d },
            { 28000.0d, 0.0000015509d },
            { 29000.0d, 0.00000169295d },
            { 30000.0d, 0.00000184148d },
            { 31000.0d, 0.00000199616d },
            { 32000.0d, 0.00000215714d },
            { 33000.0d, 0.00000232435d },
            { 34000.0d, 0.00000249744d },
            { 35000.0d, 0.00000267653d },
            { 36000.0d, 0.00000286162d },
            { 37000.0d, 0.00000305221d },
            { 38000.0d, 0.00000324854d },
            { 39000.0d, 0.00000345052d },
            { 40000.0d, 0.00000365771d },
            { 41000.0d, 0.00000387025d },
            { 42000.0d, 0.00000408816d },
            { 43000.0d, 0.00000431088d },
            { 44000.0d, 0.00000453866d },
            { 45000.0d, 0.00000477142d },
            { 46000.0d, 0.00000500869d },
            { 47000.0d, 0.00000525063d },
            { 48000.0d, 0.00000549725d },
            { 49000.0d, 0.00000574799d },
            { 50000.0d, 0.0000060031d },
            { 51000.0d, 0.00000626251d },
            { 52000.0d, 0.00000652574d },
            { 53000.0d, 0.00000679297d },
            { 54000.0d, 0.00000706421d },
            { 55000.0d, 0.00000733891d },
            { 56000.0d, 0.00000761732d },
            { 57000.0d, 0.00000789937d },
            { 58000.0d, 0.00000818462d },
            { 59000.0d, 0.00000847323d },
            { 60000.0d, 0.0000087652d },
            { 61000.0d, 0.00000906004d },
            { 62000.0d, 0.00000935798d },
            { 63000.0d, 0.00000965895d },
            { 64000.0d, 0.00000996255d },
            { 65000.0d, 0.0000102689d },
            { 66000.0d, 0.0000105781d },
            { 67000.0d, 0.0000108896d },
            { 68000.0d, 0.0000112036d },
            { 69000.0d, 0.0000115201d },
            { 70000.0d, 0.0000118387d },
            { 71000.0d, 0.0000121596d },
            { 72000.0d, 0.0000124828d },
            { 73000.0d, 0.0000128077d },
            { 74000.0d, 0.0000131348d },
            { 75000.0d, 0.0000134638d },
            { 76000.0d, 0.0000137945d },
            { 77000.0d, 0.0000141269d },
            { 78000.0d, 0.0000144612d },
            { 79000.0d, 0.0000147969d },
            { 80000.0d, 0.0000151341d },
            { 81000.0d, 0.000015473d },
            { 82000.0d, 0.0000158131d },
            { 83000.0d, 0.0000161545d },
            { 84000.0d, 0.0000164974d },
            { 85000.0d, 0.0000168413d },
            { 86000.0d, 0.0000171864d },
            { 87000.0d, 0.0000175327d },
            { 88000.0d, 0.0000178798d },
            { 89000.0d, 0.000018228d },
            { 90000.0d, 0.0000185771d },
            { 91000.0d, 0.0000189271d },
            { 92000.0d, 0.0000192779d },
            { 93000.0d, 0.0000196295d },
            { 94000.0d, 0.0000199817d },
            { 95000.0d, 0.0000203346d },
            { 96000.0d, 0.0000206881d },
            { 97000.0d, 0.0000210421d },
            { 98000.0d, 0.0000213967d },
            { 99000.0d, 0.0000217518d },
            { 100000.0d, 0.0000221073d },
            { 103000.0d, 0.0000231758d },
            { 106000.0d, 0.0000242465d },
            { 109000.0d, 0.0000253185d },
            { 112000.0d, 0.0000263907d },
            { 115000.0d, 0.0000274622d },
            { 118000.0d, 0.0000285321d },
            { 121000.0d, 0.0000295996d },
            { 124000.0d, 0.0000306639d },
            { 127000.0d, 0.0000317244d },
            { 130000.0d, 0.0000327803d },
            { 133000.0d, 0.0000338311d },
            { 136000.0d, 0.000034876d },
            { 139000.0d, 0.0000359146d },
            { 142000.0d, 0.0000369464d },
            { 145000.0d, 0.000037971d },
            { 148000.0d, 0.0000389878d },
            { 151000.0d, 0.0000399964d },
            { 154000.0d, 0.0000409964d },
            { 157000.0d, 0.0000419875d },
            { 160000.0d, 0.0000429693d },
            { 163000.0d, 0.0000439414d },
            { 166000.0d, 0.0000449036d },
            { 169000.0d, 0.0000458555d },
            { 172000.0d, 0.0000467968d },
            { 175000.0d, 0.0000477274d },
            { 178000.0d, 0.000048647d },
            { 181000.0d, 0.0000495553d },
            { 184000.0d, 0.0000504522d },
            { 187000.0d, 0.0000513375d },
            { 190000.0d, 0.0000522111d },
            { 193000.0d, 0.0000530726d },
            { 196000.0d, 0.0000539221d },
            { 199000.0d, 0.0000547593d },
            { 202000.0d, 0.0000555843d },
            { 205000.0d, 0.0000563966d },
            { 208000.0d, 0.0000571964d },
            { 211000.0d, 0.0000579836d },
            { 214000.0d, 0.0000587578d },
            { 217000.0d, 0.0000595192d },
            { 220000.0d, 0.0000602676d },
            { 223000.0d, 0.000061003d },
            { 226000.0d, 0.0000617254d },
            { 229000.0d, 0.0000624345d },
            { 232000.0d, 0.0000631305d },
            { 235000.0d, 0.0000638133d },
            { 238000.0d, 0.0000644828d },
            { 241000.0d, 0.0000651389d },
            { 244000.0d, 0.0000657818d },
            { 247000.0d, 0.0000664114d },
            { 250000.0d, 0.0000670275d },
            { 253000.0d, 0.0000676303d },
            { 256000.0d, 0.0000682198d },
            { 259000.0d, 0.0000687958d },
            { 262000.0d, 0.0000693585d },
            { 265000.0d, 0.0000699079d },
            { 268000.0d, 0.0000704438d },
            { 271000.0d, 0.0000709664d },
            { 274000.0d, 0.0000714758d },
            { 277000.0d, 0.0000719718d },
            { 280000.0d, 0.0000724544d },
            { 283000.0d, 0.0000729236d },
            { 286000.0d, 0.0000733794d },
            { 289000.0d, 0.0000738219d },
            { 292000.0d, 0.0000742511d },
            { 295000.0d, 0.000074667d },
            { 298000.0d, 0.0000750697d },
            { 301000.0d, 0.0000754591d },
            { 304000.0d, 0.0000758353d },
            { 307000.0d, 0.0000761985d },
            { 310000.0d, 0.0000765486d },
            { 313000.0d, 0.0000768856d },
            { 316000.0d, 0.0000772097d },
            { 319000.0d, 0.0000775209d },
            { 322000.0d, 0.0000778192d },
            { 325000.0d, 0.0000781046d },
            { 328000.0d, 0.0000783773d },
            { 331000.0d, 0.0000786372d },
            { 334000.0d, 0.0000788845d },
            { 337000.0d, 0.0000791193d },
            { 340000.0d, 0.0000793415d },
            { 343000.0d, 0.0000795513d },
            { 346000.0d, 0.0000797486d },
            { 349000.0d, 0.0000799337d },
            { 352000.0d, 0.0000801066d },
            { 355000.0d, 0.0000802673d },
            { 358000.0d, 0.0000804159d },
            { 361000.0d, 0.0000805525d },
            { 364000.0d, 0.0000806771d },
            { 367000.0d, 0.0000807898d },
            { 370000.0d, 0.0000808907d },
            { 373000.0d, 0.0000809798d },
            { 376000.0d, 0.0000810573d },
            { 379000.0d, 0.0000811232d },
            { 382000.0d, 0.0000811776d },
            { 385000.0d, 0.0000812205d },
            { 388000.0d, 0.000081252d },
            { 391000.0d, 0.0000812723d },
            { 394000.0d, 0.0000812814d },
            { 397000.0d, 0.0000812794d },
            { 400000.0d, 0.0000812664d },
            { 403000.0d, 0.0000812424d },
            { 406000.0d, 0.0000812076d },
            { 409000.0d, 0.0000811622d },
            { 412000.0d, 0.000081106d },
            { 415000.0d, 0.0000810394d },
            { 418000.0d, 0.0000809623d },
            { 421000.0d, 0.0000808749d },
            { 424000.0d, 0.0000807772d },
            { 427000.0d, 0.0000806693d },
            { 430000.0d, 0.0000805514d },
            { 433000.0d, 0.0000804237d },
            { 436000.0d, 0.000080286d },
            { 439000.0d, 0.0000801387d },
            { 442000.0d, 0.0000799817d },
            { 445000.0d, 0.0000798151d },
            { 448000.0d, 0.0000796392d },
            { 451000.0d, 0.000079454d },
            { 454000.0d, 0.0000792597d },
            { 457000.0d, 0.0000790562d },
            { 460000.0d, 0.0000788439d },
            { 463000.0d, 0.0000786226d },
            { 466000.0d, 0.0000783925d },
            { 469000.0d, 0.0000781539d },
            { 472000.0d, 0.0000779068d },
            { 475000.0d, 0.0000776513d },
            { 478000.0d, 0.0000773876d },
            { 481000.0d, 0.0000771157d },
            { 484000.0d, 0.0000768357d },
            { 487000.0d, 0.0000765479d },
            { 490000.0d, 0.0000762522d },
            { 493000.0d, 0.0000759489d },
            { 496000.0d, 0.000075638d },
            { 499000.0d, 0.0000753195d },
            { 502000.0d, 0.0000749935d },
            { 505000.0d, 0.0000746602d },
            { 508000.0d, 0.0000743197d },
            { 511000.0d, 0.0000739721d },
            { 514000.0d, 0.0000736176d },
            { 517000.0d, 0.0000732563d },
            { 520000.0d, 0.0000728882d },
            { 523000.0d, 0.0000725133d },
            { 526000.0d, 0.0000721319d },
            { 529000.0d, 0.000071744d },
            { 532000.0d, 0.0000713499d },
            { 535000.0d, 0.0000709496d },
            { 538000.0d, 0.0000705432d },
            { 541000.0d, 0.0000701309d },
            { 544000.0d, 0.0000697128d },
            { 547000.0d, 0.0000692889d },
            { 550000.0d, 0.0000688594d },
            { 553000.0d, 0.0000684243d },
            { 556000.0d, 0.0000679838d },
            { 559000.0d, 0.0000675381d },
            { 562000.0d, 0.0000670872d },
            { 565000.0d, 0.0000666314d },
            { 568000.0d, 0.0000661706d },
            { 571000.0d, 0.0000657052d },
            { 574000.0d, 0.0000652352d },
            { 577000.0d, 0.0000647606d },
            { 580000.0d, 0.0000642818d },
            { 583000.0d, 0.0000637987d },
            { 586000.0d, 0.0000633116d },
            { 589000.0d, 0.0000628204d },
            { 592000.0d, 0.0000623253d },
            { 595000.0d, 0.0000618264d },
            { 598000.0d, 0.0000613238d },
            { 601000.0d, 0.0000608176d },
            { 604000.0d, 0.0000603078d },
            { 607000.0d, 0.0000597944d },
            { 610000.0d, 0.0000592779d },
            { 613000.0d, 0.000058758d },
            { 616000.0d, 0.000058235d },
            { 619000.0d, 0.0000577091d },
            { 622000.0d, 0.0000571805d },
            { 625000.0d, 0.0000566492d },
            { 628000.0d, 0.0000561154d },
            { 631000.0d, 0.0000555792d },
            { 634000.0d, 0.0000550408d },
            { 637000.0d, 0.0000545002d },
            { 640000.0d, 0.0000539579d },
            { 643000.0d, 0.0000534136d },
            { 646000.0d, 0.0000528678d },
            { 649000.0d, 0.0000523203d },
            { 652000.0d, 0.0000517716d },
            { 655000.0d, 0.0000512216d },
            { 658000.0d, 0.0000506706d },
            { 661000.0d, 0.0000501187d },
            { 664000.0d, 0.0000495659d },
            { 667000.0d, 0.0000490125d },
            { 670000.0d, 0.000048458d },
            { 673000.0d, 0.0000479024d },
            { 676000.0d, 0.0000473459d },
            { 679000.0d, 0.0000467887d },
            { 682000.0d, 0.0000462308d },
            { 685000.0d, 0.0000456725d },
            { 688000.0d, 0.0000451138d },
            { 691000.0d, 0.000044555d },
            { 694000.0d, 0.0000439962d },
            { 697000.0d, 0.0000434374d },
            { 700000.0d, 0.0000428789d },
            { 703000.0d, 0.0000423208d },
            { 706000.0d, 0.0000417632d },
            { 709000.0d, 0.0000412063d },
            { 712000.0d, 0.0000406502d },
            { 715000.0d, 0.0000400944d },
            { 718000.0d, 0.0000395389d },
            { 721000.0d, 0.0000389839d },
            { 724000.0d, 0.0000384297d },
            { 727000.0d, 0.0000378762d },
            { 730000.0d, 0.0000373235d },
            { 733000.0d, 0.000036772d },
            { 736000.0d, 0.0000362216d },
            { 739000.0d, 0.0000356726d },
            { 742000.0d, 0.0000351251d },
            { 745000.0d, 0.0000345791d },
            { 748000.0d, 0.0000340345d },
            { 751000.0d, 0.000033491d },
            { 754000.0d, 0.0000329489d },
            { 757000.0d, 0.0000324083d },
            { 760000.0d, 0.0000318691d },
            { 763000.0d, 0.0000313314d },
            { 766000.0d, 0.000030795d },
            { 769000.0d, 0.0000302603d },
            { 772000.0d, 0.0000297272d },
            { 775000.0d, 0.000029196d },
            { 778000.0d, 0.0000286668d },
            { 781000.0d, 0.0000281396d },
            { 784000.0d, 0.0000276146d },
            { 787000.0d, 0.0000270921d },
            { 790000.0d, 0.000026572d },
            { 793000.0d, 0.0000260545d },
            { 796000.0d, 0.0000255399d },
            { 799000.0d, 0.000025028d },
            { 802000.0d, 0.0000245192d },
            { 805000.0d, 0.0000240136d },
            { 808000.0d, 0.000023511d },
            { 811000.0d, 0.0000230116d },
            { 814000.0d, 0.0000225155d },
            { 817000.0d, 0.0000220229d },
            { 820000.0d, 0.0000215338d },
            { 823000.0d, 0.0000210485d },
            { 826000.0d, 0.000020567d },
            { 829000.0d, 0.0000200894d },
            { 832000.0d, 0.000019616d },
            { 835000.0d, 0.0000191469d },
            { 838000.0d, 0.000018682d },
            { 841000.0d, 0.0000182216d },
            { 844000.0d, 0.0000177656d },
            { 847000.0d, 0.0000173142d },
            { 850000.0d, 0.0000168674d },
            { 853000.0d, 0.0000164248d },
            { 856000.0d, 0.0000159866d },
            { 859000.0d, 0.000015553d },
            { 862000.0d, 0.0000151239d },
            { 865000.0d, 0.0000146995d },
            { 868000.0d, 0.0000142801d },
            { 871000.0d, 0.0000138657d },
            { 874000.0d, 0.0000134565d },
            { 877000.0d, 0.0000130524d },
            { 880000.0d, 0.0000126538d },
            { 883000.0d, 0.0000122606d },
            { 886000.0d, 0.0000118726d },
            { 889000.0d, 0.00001149d },
            { 892000.0d, 0.0000111127d },
            { 895000.0d, 0.0000107409d },
            { 898000.0d, 0.0000103748d },
            { 901000.0d, 0.0000100143d },
            { 904000.0d, 0.00000965969d },
            { 907000.0d, 0.00000931106d },
            { 910000.0d, 0.00000896854d },
            { 913000.0d, 0.00000863224d },
            { 916000.0d, 0.0000083023d },
            { 919000.0d, 0.00000797884d },
            { 922000.0d, 0.00000766197d },
            { 925000.0d, 0.00000735093d },
            { 928000.0d, 0.00000704522d },
            { 931000.0d, 0.00000674494d },
            { 934000.0d, 0.00000645021d },
            { 937000.0d, 0.00000616113d },
            { 940000.0d, 0.00000587782d },
            { 943000.0d, 0.00000560037d },
            { 946000.0d, 0.00000532891d },
            { 949000.0d, 0.00000506354d },
            { 952000.0d, 0.00000480438d },
            { 955000.0d, 0.00000455152d },
            { 958000.0d, 0.0000043051d },
            { 961000.0d, 0.00000406521d },
            { 964000.0d, 0.00000383197d },
            { 967000.0d, 0.00000360548d },
            { 970000.0d, 0.00000338583d },
            { 973000.0d, 0.00000317238d },
            { 976000.0d, 0.00000296494d },
            { 979000.0d, 0.00000276359d },
            { 982000.0d, 0.00000256844d },
            { 985000.0d, 0.00000237959d },
            { 988000.0d, 0.00000219715d },
            { 991000.0d, 0.0000020212d },
            { 994000.0d, 0.00000185186d },
            { 997000.0d, 0.00000168921d },
            { 1000000.0d, 0.00000153337d },
            { 1003000.0d, 0.00000138443d },
            { 1006000.0d, 0.0000012425d },
            { 1009000.0d, 0.00000110768d },
            { 1012000.0d, 0.000000980064d },
            { 1015000.0d, 0.000000859761d },
            { 1018000.0d, 0.000000746876d },
            { 1021000.0d, 0.000000641506d },
            { 1024000.0d, 0.000000543755d },
            { 1027000.0d, 0.000000453727d },
            { 1030000.0d, 0.000000371522d },
            { 1033000.0d, 0.000000297244d },
            { 1036000.0d, 0.000000230994d },
            { 1039000.0d, 0.000000172874d },
            { 1042000.0d, 0.000000122987d },
            { 1045000.0d, 0.0000000814317d },
            { 1048000.0d, 0.0000000483081d },
            { 1051000.0d, 0.0000000237136d },
            { 1054000.0d, 0.00000000774222d },
            { 1057000.0d, 0.000000000476365d },
            { 1057990.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    