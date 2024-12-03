using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth196 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth196";
        public override double halfLife { get; } = 308.0d;
        public override double atomicWeight { get; } = 195.98067d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium196()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0048d, new GammaParticle(288700.0, 0.00429)), new(0.011200000000000002d, new GammaParticle(306900.0, 0.00404)), new(0.008d, new GammaParticle(375500.0, 0.0033)), new(0.062400000000000004d, new GammaParticle(400900.0, 0.00309)), new(0.0288d, new GammaParticle(471500.0, 0.00263)), new(0.0368d, new GammaParticle(473700.0, 0.00262)), new(0.0208d, new GammaParticle(519100.0, 0.00239)), new(0.0032d, new GammaParticle(550400.0, 0.00225)), new(0.0208d, new GammaParticle(620800.0, 0.002)), new(0.027200000000000002d, new GammaParticle(637800.0, 0.00194)), new(0.0304d, new GammaParticle(665400.0, 0.00186)), new(0.016d, new GammaParticle(674600.0, 0.00184)), new(0.3552d, new GammaParticle(689300.0, 0.0018)), new(0.0144d, new GammaParticle(732500.0, 0.00169)), new(0.022400000000000003d, new GammaParticle(753400.0, 0.00165)), new(0.0128d, new GammaParticle(753400.0, 0.00165)), new(0.09119999999999999d, new GammaParticle(776600.0, 0.0016)), new(0.0384d, new GammaParticle(846700.0, 0.00146)), new(0.0192d, new GammaParticle(868800.0, 0.00143)), new(0.0064d, new GammaParticle(916800.0, 0.00135)), new(0.064d, new GammaParticle(942400.0, 0.00132)), new(0.008d, new GammaParticle(947600.0, 0.00131)), new(0.0192d, new GammaParticle(1011100.0, 0.00123)), new(0.011200000000000002d, new GammaParticle(1030900.0, 0.0012)), new(0.8687999999999999d, new GammaParticle(1049400.0, 0.00118)), new(0.011200000000000002d, new GammaParticle(1075000.0, 0.00115)), new(0.0688d, new GammaParticle(1449700.0, 0.00086)), new(0.0144d, new GammaParticle(1896300.0, 0.00065)), new(0.0032d, new GammaParticle(2060900.0, 0.0006)), new(1.0728d, new GammaParticle(511000.0, 0.00243)), new(0.15770551737308d, new GammaParticle(12522.0, 0.09901)), new(0.11778973200467645d, new GammaParticle(72805.0, 0.01703)), new(0.19796593614231336d, new GammaParticle(74970.0, 0.01654)), new(0.06766192888864068d, new GammaParticle(84986.0, 0.01459)), new(0.08809583141301017d, new GammaParticle(86022.0, 0.01441)), new(0.020433902524369486d, new GammaParticle(87301.0, 0.0142)) } },
            { 1.15e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium192()), new(1.0d, new AlphaParticle(6458002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 10000.0d, 0.00000000151475d },
            { 20000.0d, 0.0000000632298d },
            { 30000.0d, 0.000000190711d },
            { 40000.0d, 0.000000429305d },
            { 50000.0d, 0.000000785736d },
            { 60000.0d, 0.00000126773d },
            { 70000.0d, 0.0000018707d },
            { 80000.0d, 0.00000258799d },
            { 90000.0d, 0.00000341194d },
            { 100000.0d, 0.00000433167d },
            { 110000.0d, 0.00000533923d },
            { 120000.0d, 0.00000642634d },
            { 130000.0d, 0.00000758216d },
            { 140000.0d, 0.00000880205d },
            { 150000.0d, 0.0000100775d },
            { 160000.0d, 0.0000114019d },
            { 170000.0d, 0.0000127711d },
            { 180000.0d, 0.0000141787d },
            { 190000.0d, 0.0000156202d },
            { 200000.0d, 0.0000170922d },
            { 210000.0d, 0.0000185912d },
            { 220000.0d, 0.0000201126d },
            { 230000.0d, 0.0000216546d },
            { 240000.0d, 0.0000232146d },
            { 250000.0d, 0.0000247891d },
            { 260000.0d, 0.0000263772d },
            { 270000.0d, 0.0000279766d },
            { 280000.0d, 0.000029585d },
            { 290000.0d, 0.0000312015d },
            { 300000.0d, 0.0000328243d },
            { 310000.0d, 0.0000344522d },
            { 320000.0d, 0.000036084d },
            { 330000.0d, 0.0000377187d },
            { 340000.0d, 0.0000393553d },
            { 350000.0d, 0.0000409928d },
            { 360000.0d, 0.0000426305d },
            { 370000.0d, 0.0000442674d },
            { 380000.0d, 0.0000459032d },
            { 390000.0d, 0.000047537d },
            { 400000.0d, 0.0000491682d },
            { 410000.0d, 0.0000507964d },
            { 420000.0d, 0.0000524211d },
            { 430000.0d, 0.0000540416d },
            { 440000.0d, 0.0000556577d },
            { 450000.0d, 0.000057269d },
            { 460000.0d, 0.0000588751d },
            { 470000.0d, 0.0000604755d },
            { 480000.0d, 0.0000620701d },
            { 490000.0d, 0.0000636585d },
            { 500000.0d, 0.0000652403d },
            { 510000.0d, 0.0000668154d },
            { 520000.0d, 0.0000683835d },
            { 530000.0d, 0.0000699445d },
            { 540000.0d, 0.0000714979d },
            { 550000.0d, 0.0000730437d },
            { 560000.0d, 0.0000745816d },
            { 570000.0d, 0.0000761115d },
            { 580000.0d, 0.0000776332d },
            { 590000.0d, 0.0000791466d },
            { 600000.0d, 0.0000806513d },
            { 610000.0d, 0.0000821474d },
            { 620000.0d, 0.0000836347d },
            { 630000.0d, 0.0000851131d },
            { 640000.0d, 0.0000865823d },
            { 650000.0d, 0.0000880423d },
            { 660000.0d, 0.000089493d },
            { 670000.0d, 0.0000909342d },
            { 680000.0d, 0.000092366d },
            { 690000.0d, 0.0000937881d },
            { 700000.0d, 0.0000952004d },
            { 710000.0d, 0.0000966029d },
            { 720000.0d, 0.0000979954d },
            { 730000.0d, 0.0000993779d },
            { 740000.0d, 0.00010075d },
            { 750000.0d, 0.000102113d },
            { 760000.0d, 0.000103465d },
            { 770000.0d, 0.000104806d },
            { 780000.0d, 0.000106138d },
            { 790000.0d, 0.000107458d },
            { 800000.0d, 0.000108769d },
            { 810000.0d, 0.000110068d },
            { 820000.0d, 0.000111357d },
            { 830000.0d, 0.000112636d },
            { 840000.0d, 0.000113903d },
            { 850000.0d, 0.00011516d },
            { 860000.0d, 0.000116406d },
            { 870000.0d, 0.00011764d },
            { 880000.0d, 0.000118864d },
            { 890000.0d, 0.000120077d },
            { 900000.0d, 0.000121279d },
            { 910000.0d, 0.000122469d },
            { 920000.0d, 0.000123648d },
            { 930000.0d, 0.000124817d },
            { 940000.0d, 0.000125974d },
            { 950000.0d, 0.000127119d },
            { 960000.0d, 0.000128253d },
            { 970000.0d, 0.000129376d },
            { 980000.0d, 0.000130488d },
            { 990000.0d, 0.000131588d },
            { 1000000.0d, 0.000132676d },
            { 1017000.0d, 0.0001345d },
            { 1034000.0d, 0.000136291d },
            { 1051000.0d, 0.000138048d },
            { 1068000.0d, 0.000139771d },
            { 1085000.0d, 0.000141461d },
            { 1102000.0d, 0.000143116d },
            { 1119000.0d, 0.000144738d },
            { 1136000.0d, 0.000146325d },
            { 1153000.0d, 0.000147878d },
            { 1170000.0d, 0.000149396d },
            { 1187000.0d, 0.000150881d },
            { 1204000.0d, 0.00015233d },
            { 1221000.0d, 0.000153746d },
            { 1238000.0d, 0.000155126d },
            { 1255000.0d, 0.000156472d },
            { 1272000.0d, 0.000157783d },
            { 1289000.0d, 0.00015906d },
            { 1306000.0d, 0.000160301d },
            { 1323000.0d, 0.000161508d },
            { 1340000.0d, 0.00016268d },
            { 1357000.0d, 0.000163817d },
            { 1374000.0d, 0.000164919d },
            { 1391000.0d, 0.000165986d },
            { 1408000.0d, 0.000167019d },
            { 1425000.0d, 0.000168016d },
            { 1442000.0d, 0.000168979d },
            { 1459000.0d, 0.000169907d },
            { 1476000.0d, 0.0001708d },
            { 1493000.0d, 0.000171658d },
            { 1510000.0d, 0.000172482d },
            { 1527000.0d, 0.00017327d },
            { 1544000.0d, 0.000174025d },
            { 1561000.0d, 0.000174744d },
            { 1578000.0d, 0.000175429d },
            { 1595000.0d, 0.00017608d },
            { 1612000.0d, 0.000176696d },
            { 1629000.0d, 0.000177278d },
            { 1646000.0d, 0.000177826d },
            { 1663000.0d, 0.000178339d },
            { 1680000.0d, 0.000178819d },
            { 1697000.0d, 0.000179264d },
            { 1714000.0d, 0.000179676d },
            { 1731000.0d, 0.000180054d },
            { 1748000.0d, 0.000180398d },
            { 1765000.0d, 0.000180709d },
            { 1782000.0d, 0.000180986d },
            { 1799000.0d, 0.00018123d },
            { 1816000.0d, 0.000181441d },
            { 1833000.0d, 0.000181619d },
            { 1850000.0d, 0.000181763d },
            { 1867000.0d, 0.000181876d },
            { 1884000.0d, 0.000181955d },
            { 1901000.0d, 0.000182002d },
            { 1918000.0d, 0.000182017d },
            { 1935000.0d, 0.000182d },
            { 1952000.0d, 0.000181951d },
            { 1969000.0d, 0.00018187d },
            { 1986000.0d, 0.000181758d },
            { 2003000.0d, 0.000181614d },
            { 2020000.0d, 0.000181439d },
            { 2037000.0d, 0.000181233d },
            { 2054000.0d, 0.000180997d },
            { 2071000.0d, 0.000180729d },
            { 2088000.0d, 0.000180432d },
            { 2105000.0d, 0.000180104d },
            { 2122000.0d, 0.000179746d },
            { 2139000.0d, 0.000179359d },
            { 2156000.0d, 0.000178942d },
            { 2173000.0d, 0.000178496d },
            { 2190000.0d, 0.000178021d },
            { 2207000.0d, 0.000177517d },
            { 2224000.0d, 0.000176985d },
            { 2241000.0d, 0.000176424d },
            { 2258000.0d, 0.000175836d },
            { 2275000.0d, 0.000175219d },
            { 2292000.0d, 0.000174576d },
            { 2309000.0d, 0.000173905d },
            { 2326000.0d, 0.000173207d },
            { 2343000.0d, 0.000172483d },
            { 2360000.0d, 0.000171732d },
            { 2377000.0d, 0.000170955d },
            { 2394000.0d, 0.000170153d },
            { 2411000.0d, 0.000169325d },
            { 2428000.0d, 0.000168472d },
            { 2445000.0d, 0.000167594d },
            { 2462000.0d, 0.000166692d },
            { 2479000.0d, 0.000165766d },
            { 2496000.0d, 0.000164815d },
            { 2513000.0d, 0.000163842d },
            { 2530000.0d, 0.000162845d },
            { 2547000.0d, 0.000161825d },
            { 2564000.0d, 0.000160783d },
            { 2581000.0d, 0.000159719d },
            { 2598000.0d, 0.000158633d },
            { 2615000.0d, 0.000157525d },
            { 2632000.0d, 0.000156397d },
            { 2649000.0d, 0.000155248d },
            { 2666000.0d, 0.000154078d },
            { 2683000.0d, 0.000152889d },
            { 2700000.0d, 0.00015168d },
            { 2717000.0d, 0.000150453d },
            { 2734000.0d, 0.000149206d },
            { 2751000.0d, 0.000147941d },
            { 2768000.0d, 0.000146658d },
            { 2785000.0d, 0.000145358d },
            { 2802000.0d, 0.000144041d },
            { 2819000.0d, 0.000142707d },
            { 2836000.0d, 0.000141357d },
            { 2853000.0d, 0.000139991d },
            { 2870000.0d, 0.000138609d },
            { 2887000.0d, 0.000137213d },
            { 2904000.0d, 0.000135802d },
            { 2921000.0d, 0.000134377d },
            { 2938000.0d, 0.000132939d },
            { 2955000.0d, 0.000131488d },
            { 2972000.0d, 0.000130024d },
            { 2989000.0d, 0.000128548d },
            { 3006000.0d, 0.00012706d },
            { 3023000.0d, 0.000125561d },
            { 3040000.0d, 0.000124051d },
            { 3057000.0d, 0.000122531d },
            { 3074000.0d, 0.000121002d },
            { 3091000.0d, 0.000119463d },
            { 3108000.0d, 0.000117915d },
            { 3125000.0d, 0.00011636d },
            { 3142000.0d, 0.000114796d },
            { 3159000.0d, 0.000113226d },
            { 3176000.0d, 0.000111649d },
            { 3193000.0d, 0.000110066d },
            { 3210000.0d, 0.000108477d },
            { 3227000.0d, 0.000106883d },
            { 3244000.0d, 0.000105285d },
            { 3261000.0d, 0.000103683d },
            { 3278000.0d, 0.000102078d },
            { 3295000.0d, 0.00010047d },
            { 3312000.0d, 0.0000988575d },
            { 3329000.0d, 0.0000972408d },
            { 3346000.0d, 0.0000956205d },
            { 3363000.0d, 0.0000939971d },
            { 3380000.0d, 0.0000923711d },
            { 3397000.0d, 0.0000907429d },
            { 3414000.0d, 0.0000891134d },
            { 3431000.0d, 0.0000874829d },
            { 3448000.0d, 0.0000858521d },
            { 3465000.0d, 0.0000842214d },
            { 3482000.0d, 0.0000825916d },
            { 3499000.0d, 0.000080963d },
            { 3516000.0d, 0.0000793364d },
            { 3533000.0d, 0.0000777124d },
            { 3550000.0d, 0.0000760914d },
            { 3567000.0d, 0.0000744741d },
            { 3584000.0d, 0.0000728611d },
            { 3601000.0d, 0.000071253d },
            { 3618000.0d, 0.0000696505d },
            { 3635000.0d, 0.0000680541d },
            { 3652000.0d, 0.0000664646d },
            { 3669000.0d, 0.0000648824d },
            { 3686000.0d, 0.0000633083d },
            { 3703000.0d, 0.0000617428d },
            { 3720000.0d, 0.0000601868d },
            { 3737000.0d, 0.0000586406d },
            { 3754000.0d, 0.0000571051d },
            { 3771000.0d, 0.000055581d },
            { 3788000.0d, 0.0000540689d },
            { 3805000.0d, 0.0000525694d },
            { 3822000.0d, 0.0000510832d },
            { 3839000.0d, 0.0000496112d },
            { 3856000.0d, 0.0000481538d },
            { 3873000.0d, 0.0000467115d },
            { 3890000.0d, 0.0000452844d },
            { 3907000.0d, 0.0000438731d },
            { 3924000.0d, 0.0000424784d },
            { 3941000.0d, 0.0000411011d },
            { 3958000.0d, 0.0000397416d },
            { 3975000.0d, 0.0000384008d },
            { 3992000.0d, 0.0000370795d },
            { 4009000.0d, 0.0000357782d },
            { 4026000.0d, 0.0000344978d },
            { 4043000.0d, 0.0000332392d },
            { 4060000.0d, 0.0000320028d },
            { 4077000.0d, 0.0000307895d },
            { 4094000.0d, 0.0000296001d },
            { 4111000.0d, 0.0000284354d },
            { 4128000.0d, 0.0000272961d },
            { 4145000.0d, 0.0000261824d },
            { 4162000.0d, 0.0000250949d },
            { 4179000.0d, 0.0000240341d },
            { 4196000.0d, 0.0000230012d },
            { 4213000.0d, 0.0000219964d },
            { 4230000.0d, 0.0000210197d },
            { 4247000.0d, 0.0000200715d },
            { 4264000.0d, 0.0000191526d },
            { 4281000.0d, 0.0000182634d },
            { 4298000.0d, 0.0000174035d },
            { 4315000.0d, 0.0000165735d },
            { 4332000.0d, 0.0000157742d },
            { 4349000.0d, 0.0000150054d },
            { 4366000.0d, 0.0000142648d },
            { 4383000.0d, 0.0000135532d },
            { 4400000.0d, 0.0000128709d },
            { 4417000.0d, 0.0000122187d },
            { 4434000.0d, 0.0000115972d },
            { 4451000.0d, 0.0000110047d },
            { 4468000.0d, 0.0000104398d },
            { 4485000.0d, 0.00000990291d },
            { 4502000.0d, 0.0000093947d },
            { 4519000.0d, 0.00000891352d },
            { 4536000.0d, 0.00000845661d },
            { 4553000.0d, 0.0000080244d },
            { 4570000.0d, 0.00000761734d },
            { 4587000.0d, 0.00000723581d },
            { 4604000.0d, 0.00000687502d },
            { 4621000.0d, 0.0000065234d },
            { 4638000.0d, 0.00000618068d },
            { 4655000.0d, 0.00000584697d },
            { 4672000.0d, 0.00000552246d },
            { 4689000.0d, 0.00000520734d },
            { 4706000.0d, 0.00000490184d },
            { 4723000.0d, 0.00000460615d },
            { 4740000.0d, 0.00000432048d },
            { 4757000.0d, 0.00000404503d },
            { 4774000.0d, 0.00000378003d },
            { 4791000.0d, 0.00000352566d },
            { 4808000.0d, 0.00000328215d },
            { 4825000.0d, 0.0000030497d },
            { 4842000.0d, 0.0000028285d },
            { 4859000.0d, 0.00000261875d },
            { 4876000.0d, 0.00000242064d },
            { 4893000.0d, 0.00000223275d },
            { 4910000.0d, 0.00000205159d },
            { 4927000.0d, 0.00000187715d },
            { 4944000.0d, 0.00000170956d },
            { 4961000.0d, 0.00000154895d },
            { 4978000.0d, 0.00000139545d },
            { 4995000.0d, 0.0000012492d },
            { 5012000.0d, 0.00000111033d },
            { 5029000.0d, 0.00000097897d },
            { 5046000.0d, 0.00000085526d },
            { 5063000.0d, 0.00000073933d },
            { 5080000.0d, 0.000000631314d },
            { 5097000.0d, 0.000000531346d },
            { 5114000.0d, 0.000000439558d },
            { 5131000.0d, 0.000000356085d },
            { 5148000.0d, 0.000000281058d },
            { 5165000.0d, 0.00000021461d },
            { 5182000.0d, 0.000000156869d },
            { 5199000.0d, 0.000000107966d },
            { 5216000.0d, 0.0000000680257d },
            { 5233000.0d, 0.0000000371703d },
            { 5250000.0d, 0.0000000155138d },
            { 5267000.0d, 0.00000000315569d },
            { 5281000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    