using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum131 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum131";
        public override double halfLife { get; } = 3540.0d;
        public override double atomicWeight { get; } = 130.91007d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium131()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.008025d, new GammaParticle(79918.0, 0.01551)), new(0.000365d, new GammaParticle(98197.0, 0.01263)), new(0.00425d, new GammaParticle(107220.0, 0.01156)), new(0.25d, new GammaParticle(108081.0, 0.01147)), new(0.0006850000000000001d, new GammaParticle(157820.0, 0.00786)), new(0.000775d, new GammaParticle(159900.0, 0.00775)), new(0.018025d, new GammaParticle(160687.0, 0.00772)), new(0.000275d, new GammaParticle(176040.0, 0.00704)), new(0.0015249999999999999d, new GammaParticle(177186.0, 0.007)), new(0.001225d, new GammaParticle(192929.0, 0.00643)), new(0.03025d, new GammaParticle(208509.0, 0.00595)), new(0.0032d, new GammaParticle(209269.0, 0.00592)), new(0.01375d, new GammaParticle(240593.0, 0.00515)), new(0.003125d, new GammaParticle(245100.0, 0.00506)), new(0.034275d, new GammaParticle(257087.0, 0.00482)), new(0.0003d, new GammaParticle(276400.0, 0.00449)), new(0.124d, new GammaParticle(285246.0, 0.00435)), new(0.008725d, new GammaParticle(316575.0, 0.00392)), new(0.0027500000000000003d, new GammaParticle(317500.0, 0.00391)), new(0.00125d, new GammaParticle(352070.0, 0.00352)), new(0.009399999999999999d, new GammaParticle(353479.0, 0.00351)), new(0.0015249999999999999d, new GammaParticle(354320.0, 0.0035)), new(0.16925d, new GammaParticle(365162.0, 0.0034)), new(0.00875d, new GammaParticle(402900.0, 0.00308)), new(0.0023499999999999997d, new GammaParticle(413300.0, 0.003)), new(0.0055000000000000005d, new GammaParticle(416210.0, 0.00298)), new(0.1795d, new GammaParticle(417783.0, 0.00297)), new(0.0065249999999999996d, new GammaParticle(434330.0, 0.00285)), new(0.00075d, new GammaParticle(434830.0, 0.00285)), new(0.00106d, new GammaParticle(448920.0, 0.00276)), new(0.05875d, new GammaParticle(453659.0, 0.00273)), new(0.00065d, new GammaParticle(483870.0, 0.00256)), new(0.08725d, new GammaParticle(525851.0, 0.00236)), new(0.011000000000000001d, new GammaParticle(561785.0, 0.00221)), new(0.000265d, new GammaParticle(567100.0, 0.00219)), new(0.0006575d, new GammaParticle(584810.0, 0.00212)), new(0.014375d, new GammaParticle(594080.0, 0.00209)), new(0.007775d, new GammaParticle(611407.0, 0.00203)), new(0.0016375d, new GammaParticle(628402.0, 0.00197)), new(0.0004575d, new GammaParticle(647030.0, 0.00192)), new(0.002555d, new GammaParticle(657630.0, 0.00189)), new(0.00188d, new GammaParticle(661080.0, 0.00188)), new(0.0014874999999999999d, new GammaParticle(664630.0, 0.00187)), new(0.00029d, new GammaParticle(694620.0, 0.00178)), new(0.00027d, new GammaParticle(700380.0, 0.00177)), new(0.00015d, new GammaParticle(718500.0, 0.00173)), new(0.001725d, new GammaParticle(719530.0, 0.00172)), new(8e-05d, new GammaParticle(729190.0, 0.0017)), new(0.0006075d, new GammaParticle(768930.0, 0.00161)), new(0.00045d, new GammaParticle(771190.0, 0.00161)), new(0.00043d, new GammaParticle(837860.0, 0.00148)), new(0.0023499999999999997d, new GammaParticle(841860.0, 0.00147)), new(0.010475000000000002d, new GammaParticle(866138.0, 0.00143)), new(0.0017599999999999998d, new GammaParticle(879200.0, 0.00141)), new(0.00032250000000000003d, new GammaParticle(927400.0, 0.00134)), new(0.00043749999999999995d, new GammaParticle(933030.0, 0.00133)), new(0.0002075d, new GammaParticle(944130.0, 0.00131)), new(0.0002525d, new GammaParticle(958890.0, 0.00129)), new(0.00032250000000000003d, new GammaParticle(969720.0, 0.00128)), new(0.0064d, new GammaParticle(974204.0, 0.00127)), new(0.00025749999999999997d, new GammaParticle(1105930.0, 0.00112)), new(0.0001625d, new GammaParticle(1129300.0, 0.0011)), new(0.0008d, new GammaParticle(1135850.0, 0.00109)), new(0.00032d, new GammaParticle(1154230.0, 0.00107)), new(0.00013d, new GammaParticle(1158000.0, 0.00107)), new(0.0029249999999999996d, new GammaParticle(1178030.0, 0.00105)), new(0.0002775d, new GammaParticle(1209450.0, 0.00103)), new(0.000225d, new GammaParticle(1212850.0, 0.00102)), new(0.0002375d, new GammaParticle(1227740.0, 0.00101)), new(0.0002075d, new GammaParticle(1243720.0, 0.001)), new(0.0010199999999999999d, new GammaParticle(1291540.0, 0.00096)), new(0.000245d, new GammaParticle(1296810.0, 0.00096)), new(8.25e-05d, new GammaParticle(1315800.0, 0.00094)), new(0.00043749999999999995d, new GammaParticle(1351480.0, 0.00092)), new(0.00029749999999999997d, new GammaParticle(1355990.0, 0.00091)), new(0.00065d, new GammaParticle(1367470.0, 0.00091)), new(0.000525d, new GammaParticle(1386050.0, 0.00089)), new(0.000625d, new GammaParticle(1389640.0, 0.00089)), new(0.0002d, new GammaParticle(1420700.0, 0.00087)), new(0.0005025d, new GammaParticle(1443660.0, 0.00086)), new(0.00021999999999999998d, new GammaParticle(1455050.0, 0.00085)), new(0.00045d, new GammaParticle(1475980.0, 0.00084)), new(0.0006675d, new GammaParticle(1494650.0, 0.00083)), new(0.00125d, new GammaParticle(1500110.0, 0.00083)), new(0.0002525d, new GammaParticle(1560410.0, 0.00079)), new(0.0002425d, new GammaParticle(1564220.0, 0.00079)), new(0.0001975d, new GammaParticle(1570190.0, 0.00079)), new(0.000395d, new GammaParticle(1582240.0, 0.00078)), new(0.000215d, new GammaParticle(1591050.0, 0.00078)), new(7.75e-05d, new GammaParticle(1601530.0, 0.00077)), new(0.00018999999999999998d, new GammaParticle(1664600.0, 0.00074)), new(0.00035249999999999995d, new GammaParticle(1696560.0, 0.00073)), new(0.0008749999999999999d, new GammaParticle(1699600.0, 0.00073)), new(0.000375d, new GammaParticle(1717600.0, 0.00072)), new(0.000385d, new GammaParticle(1754390.0, 0.00071)), new(0.000155d, new GammaParticle(1771210.0, 0.0007)), new(0.00015d, new GammaParticle(1779400.0, 0.0007)), new(0.00043249999999999994d, new GammaParticle(1793240.0, 0.00069)), new(0.0014249999999999998d, new GammaParticle(1823410.0, 0.00068)), new(0.000275d, new GammaParticle(1844940.0, 0.00067)), new(0.0002625d, new GammaParticle(1849800.0, 0.00067)), new(0.00017999999999999998d, new GammaParticle(1859080.0, 0.00067)), new(0.00035499999999999996d, new GammaParticle(1873650.0, 0.00066)), new(0.00023d, new GammaParticle(1906400.0, 0.00065)), new(0.0004175d, new GammaParticle(1947220.0, 0.00064)), new(0.00037d, new GammaParticle(1954480.0, 0.00063)), new(0.0004575d, new GammaParticle(1957160.0, 0.00063)), new(0.00017250000000000002d, new GammaParticle(2055240.0, 0.0006)), new(8.750000000000001e-05d, new GammaParticle(2064940.0, 0.0006)), new(3.75e-05d, new GammaParticle(2067600.0, 0.0006)), new(0.000375d, new GammaParticle(2087440.0, 0.00059)), new(0.0002d, new GammaParticle(2100300.0, 0.00059)), new(0.00035000000000000005d, new GammaParticle(2164200.0, 0.00057)), new(0.00035000000000000005d, new GammaParticle(2172300.0, 0.00057)), new(0.0001625d, new GammaParticle(2195580.0, 0.00056)), new(0.0002425d, new GammaParticle(2206900.0, 0.00056)), new(0.00024d, new GammaParticle(2215510.0, 0.00056)), new(0.0001575d, new GammaParticle(2238600.0, 0.00055)), new(7.75e-05d, new GammaParticle(2263900.0, 0.00055)), new(0.000165d, new GammaParticle(2271230.0, 0.00055)), new(0.4680218d, new GammaParticle(511000.0, 0.00243)), new(0.09888720401340001d, new GammaParticle(4966.0, 0.24967)), new(0.22370395805792426d, new GammaParticle(31816.0, 0.03897)), new(0.41212962059308084d, new GammaParticle(32193.0, 0.03851)), new(0.12122482046644961d, new GammaParticle(36482.0, 0.03399)), new(0.15177347522399492d, new GammaParticle(36827.0, 0.03367)), new(0.030548654757545302d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 1000.0d, 0.00000000000371999d },
            { 2000.0d, 0.000000000159908d },
            { 3000.0d, 0.00000000361837d },
            { 4000.0d, 0.0000000133616d },
            { 5000.0d, 0.0000000280876d },
            { 6000.0d, 0.0000000473737d },
            { 7000.0d, 0.0000000715617d },
            { 8000.0d, 0.000000100484d },
            { 9000.0d, 0.000000137121d },
            { 10000.0d, 0.000000179973d },
            { 11000.0d, 0.000000233503d },
            { 12000.0d, 0.000000294644d },
            { 13000.0d, 0.000000367646d },
            { 14000.0d, 0.000000449775d },
            { 15000.0d, 0.000000541037d },
            { 16000.0d, 0.000000644451d },
            { 17000.0d, 0.000000759384d },
            { 18000.0d, 0.000000885024d },
            { 19000.0d, 0.00000102238d },
            { 20000.0d, 0.00000117075d },
            { 21000.0d, 0.00000133208d },
            { 22000.0d, 0.00000150515d },
            { 23000.0d, 0.00000168994d },
            { 24000.0d, 0.00000188645d },
            { 25000.0d, 0.00000209505d },
            { 26000.0d, 0.00000231568d },
            { 27000.0d, 0.0000025482d },
            { 28000.0d, 0.0000027926d },
            { 29000.0d, 0.00000304866d },
            { 30000.0d, 0.00000331651d },
            { 31000.0d, 0.00000359544d },
            { 32000.0d, 0.00000388592d },
            { 33000.0d, 0.00000418749d },
            { 34000.0d, 0.00000450037d },
            { 35000.0d, 0.00000482459d },
            { 36000.0d, 0.00000515925d },
            { 37000.0d, 0.00000550392d },
            { 38000.0d, 0.00000585924d },
            { 39000.0d, 0.00000622521d },
            { 40000.0d, 0.00000660177d },
            { 41000.0d, 0.0000069872d },
            { 42000.0d, 0.00000738262d },
            { 43000.0d, 0.00000778748d },
            { 44000.0d, 0.00000820215d },
            { 45000.0d, 0.00000862594d },
            { 46000.0d, 0.00000905805d },
            { 47000.0d, 0.00000949927d },
            { 48000.0d, 0.0000099496d },
            { 49000.0d, 0.0000104078d },
            { 50000.0d, 0.0000108746d },
            { 51000.0d, 0.0000113489d },
            { 52000.0d, 0.0000118315d },
            { 53000.0d, 0.0000123215d },
            { 54000.0d, 0.0000128196d },
            { 55000.0d, 0.000013325d },
            { 56000.0d, 0.0000138372d },
            { 57000.0d, 0.0000143561d },
            { 58000.0d, 0.000014882d },
            { 59000.0d, 0.0000154151d },
            { 60000.0d, 0.0000159554d },
            { 61000.0d, 0.0000165006d },
            { 62000.0d, 0.0000170521d },
            { 63000.0d, 0.00001761d },
            { 64000.0d, 0.0000181743d },
            { 65000.0d, 0.0000187443d },
            { 66000.0d, 0.0000193194d },
            { 67000.0d, 0.0000198999d },
            { 68000.0d, 0.000020486d },
            { 69000.0d, 0.0000210772d },
            { 70000.0d, 0.0000216738d },
            { 71000.0d, 0.0000222749d },
            { 72000.0d, 0.0000228811d },
            { 73000.0d, 0.0000234915d },
            { 74000.0d, 0.0000241066d },
            { 75000.0d, 0.0000247266d },
            { 76000.0d, 0.0000253504d },
            { 77000.0d, 0.0000259783d },
            { 78000.0d, 0.0000266105d },
            { 79000.0d, 0.0000272466d },
            { 80000.0d, 0.0000278869d },
            { 81000.0d, 0.0000285302d },
            { 82000.0d, 0.0000291773d },
            { 83000.0d, 0.000029828d },
            { 84000.0d, 0.0000304826d },
            { 85000.0d, 0.0000311401d },
            { 86000.0d, 0.0000318005d },
            { 87000.0d, 0.0000324642d },
            { 88000.0d, 0.0000331311d },
            { 89000.0d, 0.0000338009d },
            { 90000.0d, 0.0000344738d },
            { 91000.0d, 0.0000351489d },
            { 92000.0d, 0.0000358268d },
            { 93000.0d, 0.0000365072d },
            { 94000.0d, 0.0000371903d },
            { 95000.0d, 0.000037876d },
            { 96000.0d, 0.0000385639d },
            { 97000.0d, 0.0000392536d },
            { 98000.0d, 0.0000399457d },
            { 99000.0d, 0.0000406401d },
            { 100000.0d, 0.0000413368d },
            { 106000.0d, 0.0000455531d },
            { 112000.0d, 0.0000498258d },
            { 118000.0d, 0.0000541416d },
            { 124000.0d, 0.0000584894d },
            { 130000.0d, 0.0000628591d },
            { 136000.0d, 0.0000672415d },
            { 142000.0d, 0.0000716292d },
            { 148000.0d, 0.000076015d },
            { 154000.0d, 0.0000803925d },
            { 160000.0d, 0.0000847564d },
            { 166000.0d, 0.0000891015d },
            { 172000.0d, 0.0000934232d },
            { 178000.0d, 0.0000977177d },
            { 184000.0d, 0.000101981d },
            { 190000.0d, 0.000106211d },
            { 196000.0d, 0.000110403d },
            { 202000.0d, 0.000114556d },
            { 208000.0d, 0.000118666d },
            { 214000.0d, 0.000122732d },
            { 220000.0d, 0.000126752d },
            { 226000.0d, 0.000130724d },
            { 232000.0d, 0.000134646d },
            { 238000.0d, 0.000138517d },
            { 244000.0d, 0.000142336d },
            { 250000.0d, 0.000146101d },
            { 256000.0d, 0.000149811d },
            { 262000.0d, 0.000153466d },
            { 268000.0d, 0.000157064d },
            { 274000.0d, 0.000160604d },
            { 280000.0d, 0.000164086d },
            { 286000.0d, 0.000167509d },
            { 292000.0d, 0.000170873d },
            { 298000.0d, 0.000174177d },
            { 304000.0d, 0.00017742d },
            { 310000.0d, 0.000180602d },
            { 316000.0d, 0.000183723d },
            { 322000.0d, 0.000186781d },
            { 328000.0d, 0.000189778d },
            { 334000.0d, 0.000192713d },
            { 340000.0d, 0.000195584d },
            { 346000.0d, 0.000198393d },
            { 352000.0d, 0.000201139d },
            { 358000.0d, 0.000203821d },
            { 364000.0d, 0.000206441d },
            { 370000.0d, 0.000208997d },
            { 376000.0d, 0.000211489d },
            { 382000.0d, 0.000213918d },
            { 388000.0d, 0.000216283d },
            { 394000.0d, 0.000218585d },
            { 400000.0d, 0.000220823d },
            { 406000.0d, 0.000222997d },
            { 412000.0d, 0.000225108d },
            { 418000.0d, 0.000227154d },
            { 424000.0d, 0.000229137d },
            { 430000.0d, 0.000231057d },
            { 436000.0d, 0.000232913d },
            { 442000.0d, 0.000234705d },
            { 448000.0d, 0.000236434d },
            { 454000.0d, 0.0002381d },
            { 460000.0d, 0.000239703d },
            { 466000.0d, 0.000241243d },
            { 472000.0d, 0.00024272d },
            { 478000.0d, 0.000244135d },
            { 484000.0d, 0.000245488d },
            { 490000.0d, 0.000246778d },
            { 496000.0d, 0.000248007d },
            { 502000.0d, 0.000249174d },
            { 508000.0d, 0.000250279d },
            { 514000.0d, 0.000251324d },
            { 520000.0d, 0.000252308d },
            { 526000.0d, 0.000253231d },
            { 532000.0d, 0.000254094d },
            { 538000.0d, 0.000254898d },
            { 544000.0d, 0.000255641d },
            { 550000.0d, 0.000256326d },
            { 556000.0d, 0.000256951d },
            { 562000.0d, 0.000257518d },
            { 568000.0d, 0.000258027d },
            { 574000.0d, 0.000258478d },
            { 580000.0d, 0.000258872d },
            { 586000.0d, 0.000259208d },
            { 592000.0d, 0.000259488d },
            { 598000.0d, 0.000259712d },
            { 604000.0d, 0.00025988d },
            { 610000.0d, 0.000259992d },
            { 616000.0d, 0.000260049d },
            { 622000.0d, 0.000260051d },
            { 628000.0d, 0.000259999d },
            { 634000.0d, 0.000259894d },
            { 640000.0d, 0.000259734d },
            { 646000.0d, 0.000259522d },
            { 652000.0d, 0.000259258d },
            { 658000.0d, 0.000258941d },
            { 664000.0d, 0.000258573d },
            { 670000.0d, 0.000258154d },
            { 676000.0d, 0.000257684d },
            { 682000.0d, 0.000257164d },
            { 688000.0d, 0.000256595d },
            { 694000.0d, 0.000255977d },
            { 700000.0d, 0.000255311d },
            { 706000.0d, 0.000254597d },
            { 712000.0d, 0.000253836d },
            { 718000.0d, 0.000253028d },
            { 724000.0d, 0.000252174d },
            { 730000.0d, 0.000251275d },
            { 736000.0d, 0.00025033d },
            { 742000.0d, 0.000249342d },
            { 748000.0d, 0.00024831d },
            { 754000.0d, 0.000247235d },
            { 760000.0d, 0.000246117d },
            { 766000.0d, 0.000244958d },
            { 772000.0d, 0.000243757d },
            { 778000.0d, 0.000242516d },
            { 784000.0d, 0.000241235d },
            { 790000.0d, 0.000239915d },
            { 796000.0d, 0.000238556d },
            { 802000.0d, 0.00023716d },
            { 808000.0d, 0.000235726d },
            { 814000.0d, 0.000234257d },
            { 820000.0d, 0.000232751d },
            { 826000.0d, 0.000231211d },
            { 832000.0d, 0.000229637d },
            { 838000.0d, 0.000228029d },
            { 844000.0d, 0.000226388d },
            { 850000.0d, 0.000224716d },
            { 856000.0d, 0.000223013d },
            { 862000.0d, 0.000221279d },
            { 868000.0d, 0.000219516d },
            { 874000.0d, 0.000217724d },
            { 880000.0d, 0.000215905d },
            { 886000.0d, 0.000214058d },
            { 892000.0d, 0.000212185d },
            { 898000.0d, 0.000210287d },
            { 904000.0d, 0.000208364d },
            { 910000.0d, 0.000206417d },
            { 916000.0d, 0.000204448d },
            { 922000.0d, 0.000202456d },
            { 928000.0d, 0.000200442d },
            { 934000.0d, 0.000198407d },
            { 940000.0d, 0.00019635d },
            { 946000.0d, 0.000194274d },
            { 952000.0d, 0.000192177d },
            { 958000.0d, 0.000190063d },
            { 964000.0d, 0.00018793d },
            { 970000.0d, 0.00018578d },
            { 976000.0d, 0.000183615d },
            { 982000.0d, 0.000181434d },
            { 988000.0d, 0.000179239d },
            { 994000.0d, 0.000177031d },
            { 1000000.0d, 0.000174811d },
            { 1006000.0d, 0.000172579d },
            { 1012000.0d, 0.000170336d },
            { 1018000.0d, 0.000168084d },
            { 1024000.0d, 0.00016582d },
            { 1030000.0d, 0.000163546d },
            { 1036000.0d, 0.000161262d },
            { 1042000.0d, 0.00015897d },
            { 1048000.0d, 0.000156671d },
            { 1054000.0d, 0.000154365d },
            { 1060000.0d, 0.000152053d },
            { 1066000.0d, 0.000149736d },
            { 1072000.0d, 0.000147416d },
            { 1078000.0d, 0.000145092d },
            { 1084000.0d, 0.000142767d },
            { 1090000.0d, 0.000140441d },
            { 1096000.0d, 0.000138115d },
            { 1102000.0d, 0.00013579d },
            { 1108000.0d, 0.000133467d },
            { 1114000.0d, 0.000131147d },
            { 1120000.0d, 0.000128831d },
            { 1126000.0d, 0.00012652d },
            { 1132000.0d, 0.000124215d },
            { 1138000.0d, 0.000121918d },
            { 1144000.0d, 0.000119628d },
            { 1150000.0d, 0.000117348d },
            { 1156000.0d, 0.000115078d },
            { 1162000.0d, 0.000112819d },
            { 1168000.0d, 0.000110573d },
            { 1174000.0d, 0.00010834d },
            { 1180000.0d, 0.00010612d },
            { 1186000.0d, 0.000103914d },
            { 1192000.0d, 0.000101721d },
            { 1198000.0d, 0.000099544d },
            { 1204000.0d, 0.0000973832d },
            { 1210000.0d, 0.0000952396d },
            { 1216000.0d, 0.0000931145d },
            { 1222000.0d, 0.0000910088d },
            { 1228000.0d, 0.0000889237d },
            { 1234000.0d, 0.0000868602d },
            { 1240000.0d, 0.0000848195d },
            { 1246000.0d, 0.0000828025d },
            { 1252000.0d, 0.0000808105d },
            { 1258000.0d, 0.0000788446d },
            { 1264000.0d, 0.0000769059d },
            { 1270000.0d, 0.0000749956d },
            { 1276000.0d, 0.0000731144d },
            { 1282000.0d, 0.000071264d },
            { 1288000.0d, 0.0000694454d },
            { 1294000.0d, 0.0000676594d },
            { 1300000.0d, 0.0000659075d },
            { 1306000.0d, 0.0000641908d },
            { 1312000.0d, 0.0000625103d },
            { 1318000.0d, 0.0000608675d },
            { 1324000.0d, 0.0000592632d },
            { 1330000.0d, 0.0000576987d },
            { 1336000.0d, 0.000056173d },
            { 1342000.0d, 0.0000546828d },
            { 1348000.0d, 0.0000532293d },
            { 1354000.0d, 0.0000518135d },
            { 1360000.0d, 0.0000504364d },
            { 1366000.0d, 0.000049099d },
            { 1372000.0d, 0.0000477928d },
            { 1378000.0d, 0.0000465015d },
            { 1384000.0d, 0.0000452251d },
            { 1390000.0d, 0.0000439642d },
            { 1396000.0d, 0.0000427196d },
            { 1402000.0d, 0.0000414917d },
            { 1408000.0d, 0.0000402812d },
            { 1414000.0d, 0.0000390887d },
            { 1420000.0d, 0.0000379147d },
            { 1426000.0d, 0.00003676d },
            { 1432000.0d, 0.000035625d },
            { 1438000.0d, 0.0000345105d },
            { 1444000.0d, 0.000033417d },
            { 1450000.0d, 0.000032345d },
            { 1456000.0d, 0.0000312955d },
            { 1462000.0d, 0.0000302687d },
            { 1468000.0d, 0.0000292656d },
            { 1474000.0d, 0.0000282866d },
            { 1480000.0d, 0.0000273323d },
            { 1486000.0d, 0.0000264035d },
            { 1492000.0d, 0.0000255007d },
            { 1498000.0d, 0.0000246246d },
            { 1504000.0d, 0.0000237758d },
            { 1510000.0d, 0.000022955d },
            { 1516000.0d, 0.0000221627d },
            { 1522000.0d, 0.0000213997d },
            { 1528000.0d, 0.0000206664d },
            { 1534000.0d, 0.0000199543d },
            { 1540000.0d, 0.0000192548d },
            { 1546000.0d, 0.0000185683d },
            { 1552000.0d, 0.0000178949d },
            { 1558000.0d, 0.0000172351d },
            { 1564000.0d, 0.0000165892d },
            { 1570000.0d, 0.0000159577d },
            { 1576000.0d, 0.0000153407d },
            { 1582000.0d, 0.0000147379d },
            { 1588000.0d, 0.0000141486d },
            { 1594000.0d, 0.0000135731d },
            { 1600000.0d, 0.0000130118d },
            { 1606000.0d, 0.000012465d },
            { 1612000.0d, 0.0000119316d },
            { 1618000.0d, 0.0000114078d },
            { 1624000.0d, 0.0000108934d },
            { 1630000.0d, 0.0000103887d },
            { 1636000.0d, 0.00000989392d },
            { 1642000.0d, 0.00000940931d },
            { 1648000.0d, 0.0000089351d },
            { 1654000.0d, 0.00000847155d },
            { 1660000.0d, 0.00000801889d },
            { 1666000.0d, 0.0000075774d },
            { 1672000.0d, 0.00000714729d },
            { 1678000.0d, 0.00000672884d },
            { 1684000.0d, 0.00000632229d },
            { 1690000.0d, 0.00000592789d },
            { 1696000.0d, 0.00000554589d },
            { 1702000.0d, 0.00000517654d },
            { 1708000.0d, 0.00000482011d },
            { 1714000.0d, 0.00000447684d },
            { 1720000.0d, 0.00000414699d },
            { 1726000.0d, 0.00000383082d },
            { 1732000.0d, 0.00000352858d },
            { 1738000.0d, 0.00000324053d },
            { 1744000.0d, 0.00000296692d },
            { 1750000.0d, 0.00000270802d },
            { 1756000.0d, 0.00000246409d },
            { 1762000.0d, 0.00000223537d },
            { 1768000.0d, 0.00000202213d },
            { 1774000.0d, 0.00000182461d },
            { 1780000.0d, 0.00000164306d },
            { 1786000.0d, 0.00000147759d },
            { 1792000.0d, 0.00000132281d },
            { 1798000.0d, 0.00000117585d },
            { 1804000.0d, 0.00000103686d },
            { 1810000.0d, 0.00000090596d },
            { 1816000.0d, 0.0000007833d },
            { 1822000.0d, 0.000000669012d },
            { 1828000.0d, 0.000000563234d },
            { 1834000.0d, 0.000000466103d },
            { 1840000.0d, 0.000000377755d },
            { 1846000.0d, 0.000000298328d },
            { 1852000.0d, 0.000000227959d },
            { 1858000.0d, 0.000000166783d },
            { 1864000.0d, 0.000000114936d },
            { 1870000.0d, 0.0000000725508d },
            { 1876000.0d, 0.0000000397587d },
            { 1882000.0d, 0.0000000166866d },
            { 1888000.0d, 0.00000000345184d },
            { 1893000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    