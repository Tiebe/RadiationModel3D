using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium154";
        public override double halfLife { get; } = 705.6d;
        public override double atomicWeight { get; } = 153.93061d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99981d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium154()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.005d, new GammaParticle(152700.0, 0.00812)), new(0.0064d, new GammaParticle(182000.0, 0.00681)), new(0.0042d, new GammaParticle(244300.0, 0.00508)), new(0.013146d, new GammaParticle(280400.0, 0.00442)), new(0.048827999999999996d, new GammaParticle(289300.0, 0.00429)), new(0.038499d, new GammaParticle(309500.0, 0.00401)), new(0.052000000000000005d, new GammaParticle(326100.0, 0.0038)), new(0.9390000000000001d, new GammaParticle(334600.0, 0.00371)), new(0.8440000000000001d, new GammaParticle(334600.0, 0.00371)), new(0.098595d, new GammaParticle(346500.0, 0.00358)), new(0.01d, new GammaParticle(346700.0, 0.00358)), new(0.0034999999999999996d, new GammaParticle(363400.0, 0.00341)), new(0.010700000000000001d, new GammaParticle(366200.0, 0.00339)), new(0.029109d, new GammaParticle(405800.0, 0.00306)), new(0.189678d, new GammaParticle(406900.0, 0.00305)), new(0.152d, new GammaParticle(412400.0, 0.00301)), new(0.78876d, new GammaParticle(412400.0, 0.00301)), new(0.004d, new GammaParticle(415800.0, 0.00298)), new(0.0045000000000000005d, new GammaParticle(429000.0, 0.00289)), new(0.025353d, new GammaParticle(434700.0, 0.00285)), new(0.051645d, new GammaParticle(443400.0, 0.0028)), new(0.0084d, new GammaParticle(461000.0, 0.00269)), new(0.55401d, new GammaParticle(477100.0, 0.0026)), new(0.0022d, new GammaParticle(480000.0, 0.00258)), new(0.005600000000000001d, new GammaParticle(485300.0, 0.00255)), new(0.036621d, new GammaParticle(504600.0, 0.00246)), new(0.12676500000000002d, new GammaParticle(504800.0, 0.00246)), new(0.015d, new GammaParticle(504900.0, 0.00246)), new(0.0040999999999999995d, new GammaParticle(515200.0, 0.00241)), new(0.018779999999999998d, new GammaParticle(515600.0, 0.0024)), new(0.18310500000000002d, new GammaParticle(523800.0, 0.00237)), new(0.111d, new GammaParticle(569000.0, 0.00218)), new(0.111d, new GammaParticle(570600.0, 0.00217)), new(0.105168d, new GammaParticle(570700.0, 0.00217)), new(0.006573d, new GammaParticle(587300.0, 0.00211)), new(0.005634d, new GammaParticle(587300.0, 0.00211)), new(0.0079d, new GammaParticle(587500.0, 0.00211)), new(0.003d, new GammaParticle(602900.0, 0.00206)), new(0.003d, new GammaParticle(610600.0, 0.00203)), new(0.0046d, new GammaParticle(642800.0, 0.00193)), new(0.017841d, new GammaParticle(661500.0, 0.00187)), new(0.051d, new GammaParticle(692600.0, 0.00179)), new(0.0118d, new GammaParticle(695300.0, 0.00178)), new(0.0017000000000000001d, new GammaParticle(723600.0, 0.00171)), new(0.124887d, new GammaParticle(725100.0, 0.00171)), new(0.013500000000000002d, new GammaParticle(729800.0, 0.0017)), new(0.030987d, new GammaParticle(732800.0, 0.00169)), new(0.023475000000000003d, new GammaParticle(740600.0, 0.00167)), new(0.0055000000000000005d, new GammaParticle(755100.0, 0.00164)), new(0.014085d, new GammaParticle(798900.0, 0.00155)), new(0.005600000000000001d, new GammaParticle(798900.0, 0.00155)), new(0.14085d, new GammaParticle(814200.0, 0.00152)), new(0.0084d, new GammaParticle(846700.0, 0.00146)), new(0.122d, new GammaParticle(873300.0, 0.00142)), new(0.0060999999999999995d, new GammaParticle(876600.0, 0.00141)), new(0.016902d, new GammaParticle(905200.0, 0.00137)), new(0.0219d, new GammaParticle(905300.0, 0.00137)), new(0.024413999999999998d, new GammaParticle(959100.0, 0.00129)), new(0.025353d, new GammaParticle(968300.0, 0.00128)), new(0.049767d, new GammaParticle(992900.0, 0.00125)), new(0.023475000000000003d, new GammaParticle(999700.0, 0.00124)), new(0.0329d, new GammaParticle(999800.0, 0.00124)), new(0.053d, new GammaParticle(1027200.0, 0.00121)), new(0.009300000000000001d, new GammaParticle(1055800.0, 0.00117)), new(0.0084d, new GammaParticle(1072200.0, 0.00116)), new(0.002817d, new GammaParticle(1072200.0, 0.00116)), new(0.0152d, new GammaParticle(1085900.0, 0.00114)), new(0.0063d, new GammaParticle(1108000.0, 0.00112)), new(0.009389999999999999d, new GammaParticle(1138500.0, 0.00109)), new(0.0068000000000000005d, new GammaParticle(1156800.0, 0.00107)), new(0.016d, new GammaParticle(1173200.0, 0.00106)), new(0.0034000000000000002d, new GammaParticle(1244600.0, 0.001)), new(0.177471d, new GammaParticle(1250100.0, 0.00099)), new(0.0378d, new GammaParticle(1300600.0, 0.00095)), new(0.0049d, new GammaParticle(1390000.0, 0.00089)), new(0.0203d, new GammaParticle(1420300.0, 0.00087)), new(0.005699999999999999d, new GammaParticle(1431000.0, 0.00087)), new(0.005d, new GammaParticle(1447100.0, 0.00086)), new(0.014199999999999999d, new GammaParticle(1498300.0, 0.00083)), new(0.006500000000000001d, new GammaParticle(1502500.0, 0.00083)), new(0.0075d, new GammaParticle(1507600.0, 0.00082)), new(0.018600000000000002d, new GammaParticle(1510300.0, 0.00082)), new(0.0089d, new GammaParticle(1542700.0, 0.0008)), new(0.0031d, new GammaParticle(1611200.0, 0.00077)), new(0.0068000000000000005d, new GammaParticle(1623700.0, 0.00076)), new(0.0139d, new GammaParticle(1656500.0, 0.00075)), new(0.0054d, new GammaParticle(1813800.0, 0.00068)), new(0.01d, new GammaParticle(1834100.0, 0.00068)), new(0.0051d, new GammaParticle(1843800.0, 0.00067)), new(0.0092d, new GammaParticle(1849300.0, 0.00067)), new(0.0046d, new GammaParticle(1877100.0, 0.00066)), new(0.0062d, new GammaParticle(1937800.0, 0.00064)), new(0.0052d, new GammaParticle(2010300.0, 0.00062)), new(1.068d, new GammaParticle(511000.0, 0.00243)), new(0.6056d, new GammaParticle(511000.0, 0.00243)), new(0.0509183290785092d, new GammaParticle(7384.0, 0.16791)), new(0.08009637061908582d, new GammaParticle(7384.0, 0.16791)), new(0.10858800623331842d, new GammaParticle(45207.0, 0.02743)), new(0.06894682709762248d, new GammaParticle(45207.0, 0.02743)), new(0.12320733934528678d, new GammaParticle(45998.0, 0.02695)), new(0.1940457581009979d, new GammaParticle(45998.0, 0.02695)), new(0.06230412576850926d, new GammaParticle(52220.0, 0.02374)), new(0.0395593577581672d, new GammaParticle(52220.0, 0.02374)), new(0.04984479077529067d, new GammaParticle(52791.0, 0.02349)), new(0.07850319846832166d, new GammaParticle(52791.0, 0.02349)), new(0.016199072699812408d, new GammaParticle(53478.0, 0.02318)), new(0.010285433017123471d, new GammaParticle(53478.0, 0.02318)) } },
            { 0.00018999999999999998d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium150()), new(1.0d, new AlphaParticle(5064002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 10000.0d, 0.0000000216325d },
            { 20000.0d, 0.000000197365d },
            { 30000.0d, 0.000000581504d },
            { 40000.0d, 0.00000123084d },
            { 50000.0d, 0.00000214053d },
            { 60000.0d, 0.00000329104d },
            { 70000.0d, 0.00000465478d },
            { 80000.0d, 0.0000062039d },
            { 90000.0d, 0.00000791409d },
            { 100000.0d, 0.00000976173d },
            { 110000.0d, 0.0000117261d },
            { 120000.0d, 0.0000137897d },
            { 130000.0d, 0.0000159375d },
            { 140000.0d, 0.0000181569d },
            { 150000.0d, 0.0000204366d },
            { 160000.0d, 0.0000227674d },
            { 170000.0d, 0.0000251411d },
            { 180000.0d, 0.00002755d },
            { 190000.0d, 0.0000299883d },
            { 200000.0d, 0.0000324509d },
            { 210000.0d, 0.0000349332d },
            { 220000.0d, 0.0000374308d },
            { 230000.0d, 0.0000399405d },
            { 240000.0d, 0.0000424592d },
            { 250000.0d, 0.000044984d },
            { 260000.0d, 0.0000475126d },
            { 270000.0d, 0.0000500429d },
            { 280000.0d, 0.0000525728d },
            { 290000.0d, 0.0000551008d },
            { 300000.0d, 0.0000576252d },
            { 310000.0d, 0.0000601447d },
            { 320000.0d, 0.000062658d },
            { 330000.0d, 0.000065164d },
            { 340000.0d, 0.0000676617d },
            { 350000.0d, 0.0000701503d },
            { 360000.0d, 0.0000726286d },
            { 370000.0d, 0.000075096d },
            { 380000.0d, 0.000077552d },
            { 390000.0d, 0.0000799956d },
            { 400000.0d, 0.0000824264d },
            { 410000.0d, 0.0000848438d },
            { 420000.0d, 0.0000872471d },
            { 430000.0d, 0.0000896361d },
            { 440000.0d, 0.0000920103d },
            { 450000.0d, 0.000094369d },
            { 460000.0d, 0.0000967119d },
            { 470000.0d, 0.0000990389d },
            { 480000.0d, 0.00010135d },
            { 490000.0d, 0.000103643d },
            { 500000.0d, 0.00010592d },
            { 510000.0d, 0.000108179d },
            { 520000.0d, 0.000110421d },
            { 530000.0d, 0.000112645d },
            { 540000.0d, 0.00011485d },
            { 550000.0d, 0.000117038d },
            { 560000.0d, 0.000119206d },
            { 570000.0d, 0.000121356d },
            { 580000.0d, 0.000123486d },
            { 590000.0d, 0.000125598d },
            { 600000.0d, 0.00012769d },
            { 610000.0d, 0.000129762d },
            { 620000.0d, 0.000131815d },
            { 630000.0d, 0.000133847d },
            { 640000.0d, 0.00013586d },
            { 650000.0d, 0.000137852d },
            { 660000.0d, 0.000139824d },
            { 670000.0d, 0.000141775d },
            { 680000.0d, 0.000143706d },
            { 690000.0d, 0.000145616d },
            { 700000.0d, 0.000147505d },
            { 710000.0d, 0.000149372d },
            { 720000.0d, 0.000151219d },
            { 730000.0d, 0.000153044d },
            { 740000.0d, 0.000154848d },
            { 750000.0d, 0.000156631d },
            { 760000.0d, 0.000158392d },
            { 770000.0d, 0.000160131d },
            { 780000.0d, 0.000161848d },
            { 790000.0d, 0.000163544d },
            { 800000.0d, 0.000165218d },
            { 810000.0d, 0.000166869d },
            { 820000.0d, 0.000168499d },
            { 830000.0d, 0.000170106d },
            { 840000.0d, 0.000171692d },
            { 850000.0d, 0.000173255d },
            { 860000.0d, 0.000174795d },
            { 870000.0d, 0.000176313d },
            { 880000.0d, 0.000177809d },
            { 890000.0d, 0.000179282d },
            { 900000.0d, 0.000180733d },
            { 910000.0d, 0.000182161d },
            { 920000.0d, 0.000183566d },
            { 930000.0d, 0.000184949d },
            { 940000.0d, 0.000186308d },
            { 950000.0d, 0.000187645d },
            { 960000.0d, 0.000188959d },
            { 970000.0d, 0.000190251d },
            { 980000.0d, 0.000191519d },
            { 990000.0d, 0.000192765d },
            { 1000000.0d, 0.000193987d },
            { 1014000.0d, 0.00019566d },
            { 1028000.0d, 0.000197288d },
            { 1042000.0d, 0.000198871d },
            { 1056000.0d, 0.000200408d },
            { 1070000.0d, 0.000201901d },
            { 1084000.0d, 0.000203348d },
            { 1098000.0d, 0.00020475d },
            { 1112000.0d, 0.000206107d },
            { 1126000.0d, 0.000207419d },
            { 1140000.0d, 0.000208685d },
            { 1154000.0d, 0.000209906d },
            { 1168000.0d, 0.000211082d },
            { 1182000.0d, 0.000212213d },
            { 1196000.0d, 0.000213298d },
            { 1210000.0d, 0.000214339d },
            { 1224000.0d, 0.000215335d },
            { 1238000.0d, 0.000216285d },
            { 1252000.0d, 0.000217191d },
            { 1266000.0d, 0.000218052d },
            { 1280000.0d, 0.000218869d },
            { 1294000.0d, 0.000219641d },
            { 1308000.0d, 0.000220368d },
            { 1322000.0d, 0.00022105d },
            { 1336000.0d, 0.000221689d },
            { 1350000.0d, 0.000222283d },
            { 1364000.0d, 0.000222834d },
            { 1378000.0d, 0.00022334d },
            { 1392000.0d, 0.000223803d },
            { 1406000.0d, 0.000224222d },
            { 1420000.0d, 0.000224598d },
            { 1434000.0d, 0.00022493d },
            { 1448000.0d, 0.000225219d },
            { 1462000.0d, 0.000225465d },
            { 1476000.0d, 0.000225668d },
            { 1490000.0d, 0.000225829d },
            { 1504000.0d, 0.000225947d },
            { 1518000.0d, 0.000226024d },
            { 1532000.0d, 0.000226058d },
            { 1546000.0d, 0.00022605d },
            { 1560000.0d, 0.000226001d },
            { 1574000.0d, 0.00022591d },
            { 1588000.0d, 0.000225778d },
            { 1602000.0d, 0.000225605d },
            { 1616000.0d, 0.000225392d },
            { 1630000.0d, 0.000225138d },
            { 1644000.0d, 0.000224844d },
            { 1658000.0d, 0.000224511d },
            { 1672000.0d, 0.000224137d },
            { 1686000.0d, 0.000223724d },
            { 1700000.0d, 0.000223272d },
            { 1714000.0d, 0.000222781d },
            { 1728000.0d, 0.000222252d },
            { 1742000.0d, 0.000221685d },
            { 1756000.0d, 0.00022108d },
            { 1770000.0d, 0.000220437d },
            { 1784000.0d, 0.000219757d },
            { 1798000.0d, 0.00021904d },
            { 1812000.0d, 0.000218286d },
            { 1826000.0d, 0.000217496d },
            { 1840000.0d, 0.00021667d },
            { 1854000.0d, 0.000215809d },
            { 1868000.0d, 0.000214912d },
            { 1882000.0d, 0.000213981d },
            { 1896000.0d, 0.000213015d },
            { 1910000.0d, 0.000212014d },
            { 1924000.0d, 0.000210981d },
            { 1938000.0d, 0.000209913d },
            { 1952000.0d, 0.000208813d },
            { 1966000.0d, 0.000207681d },
            { 1980000.0d, 0.000206516d },
            { 1994000.0d, 0.000205319d },
            { 2008000.0d, 0.000204091d },
            { 2022000.0d, 0.000202833d },
            { 2036000.0d, 0.000201543d },
            { 2050000.0d, 0.000200224d },
            { 2064000.0d, 0.000198875d },
            { 2078000.0d, 0.000197498d },
            { 2092000.0d, 0.000196091d },
            { 2106000.0d, 0.000194656d },
            { 2120000.0d, 0.000193194d },
            { 2134000.0d, 0.000191705d },
            { 2148000.0d, 0.000190188d },
            { 2162000.0d, 0.000188646d },
            { 2176000.0d, 0.000187078d },
            { 2190000.0d, 0.000185484d },
            { 2204000.0d, 0.000183866d },
            { 2218000.0d, 0.000182224d },
            { 2232000.0d, 0.000180558d },
            { 2246000.0d, 0.000178869d },
            { 2260000.0d, 0.000177158d },
            { 2274000.0d, 0.000175425d },
            { 2288000.0d, 0.00017367d },
            { 2302000.0d, 0.000171894d },
            { 2316000.0d, 0.000170099d },
            { 2330000.0d, 0.000168283d },
            { 2344000.0d, 0.000166449d },
            { 2358000.0d, 0.000164596d },
            { 2372000.0d, 0.000162725d },
            { 2386000.0d, 0.000160837d },
            { 2400000.0d, 0.000158932d },
            { 2414000.0d, 0.000157012d },
            { 2428000.0d, 0.000155076d },
            { 2442000.0d, 0.000153126d },
            { 2456000.0d, 0.000151161d },
            { 2470000.0d, 0.000149184d },
            { 2484000.0d, 0.000147193d },
            { 2498000.0d, 0.000145191d },
            { 2512000.0d, 0.000143178d },
            { 2526000.0d, 0.000141154d },
            { 2540000.0d, 0.00013912d },
            { 2554000.0d, 0.000137077d },
            { 2568000.0d, 0.000135026d },
            { 2582000.0d, 0.000132967d },
            { 2596000.0d, 0.000130901d },
            { 2610000.0d, 0.00012883d },
            { 2624000.0d, 0.000126753d },
            { 2638000.0d, 0.000124671d },
            { 2652000.0d, 0.000122586d },
            { 2666000.0d, 0.000120498d },
            { 2680000.0d, 0.000118408d },
            { 2694000.0d, 0.000116316d },
            { 2708000.0d, 0.000114224d },
            { 2722000.0d, 0.000112133d },
            { 2736000.0d, 0.000110043d },
            { 2750000.0d, 0.000107955d },
            { 2764000.0d, 0.000105869d },
            { 2778000.0d, 0.000103788d },
            { 2792000.0d, 0.000101712d },
            { 2806000.0d, 0.0000996414d },
            { 2820000.0d, 0.0000975774d },
            { 2834000.0d, 0.0000955209d },
            { 2848000.0d, 0.000093473d },
            { 2862000.0d, 0.0000914346d },
            { 2876000.0d, 0.0000894066d },
            { 2890000.0d, 0.0000873899d },
            { 2904000.0d, 0.0000853858d },
            { 2918000.0d, 0.0000833951d },
            { 2932000.0d, 0.0000814186d },
            { 2946000.0d, 0.0000794576d },
            { 2960000.0d, 0.0000775132d },
            { 2974000.0d, 0.0000755862d },
            { 2988000.0d, 0.0000736778d },
            { 3002000.0d, 0.0000717891d },
            { 3016000.0d, 0.0000699212d },
            { 3030000.0d, 0.000068075d },
            { 3044000.0d, 0.0000662518d },
            { 3058000.0d, 0.0000644526d },
            { 3072000.0d, 0.0000626787d },
            { 3086000.0d, 0.000060931d },
            { 3100000.0d, 0.0000592107d },
            { 3114000.0d, 0.0000575154d },
            { 3128000.0d, 0.0000558446d },
            { 3142000.0d, 0.0000541996d },
            { 3156000.0d, 0.0000525812d },
            { 3170000.0d, 0.0000509908d },
            { 3184000.0d, 0.0000494294d },
            { 3198000.0d, 0.000047898d },
            { 3212000.0d, 0.0000463979d },
            { 3226000.0d, 0.0000449302d },
            { 3240000.0d, 0.0000434928d },
            { 3254000.0d, 0.0000420851d },
            { 3268000.0d, 0.0000407079d },
            { 3282000.0d, 0.0000393627d },
            { 3296000.0d, 0.00003805d },
            { 3310000.0d, 0.0000367689d },
            { 3324000.0d, 0.0000355184d },
            { 3338000.0d, 0.0000342963d },
            { 3352000.0d, 0.000033102d },
            { 3366000.0d, 0.0000319324d },
            { 3380000.0d, 0.000030788d },
            { 3394000.0d, 0.0000296698d },
            { 3408000.0d, 0.0000285785d },
            { 3422000.0d, 0.0000275153d },
            { 3436000.0d, 0.0000264811d },
            { 3450000.0d, 0.0000254765d },
            { 3464000.0d, 0.0000245027d },
            { 3478000.0d, 0.0000235605d },
            { 3492000.0d, 0.0000226498d },
            { 3506000.0d, 0.0000217694d },
            { 3520000.0d, 0.0000209202d },
            { 3534000.0d, 0.0000200994d },
            { 3548000.0d, 0.0000192983d },
            { 3562000.0d, 0.0000185169d },
            { 3576000.0d, 0.0000177559d },
            { 3590000.0d, 0.0000170159d },
            { 3604000.0d, 0.0000162975d },
            { 3618000.0d, 0.0000156015d },
            { 3632000.0d, 0.0000149285d },
            { 3646000.0d, 0.0000142791d },
            { 3660000.0d, 0.000013654d },
            { 3674000.0d, 0.0000130538d },
            { 3688000.0d, 0.0000124782d },
            { 3702000.0d, 0.0000119263d },
            { 3716000.0d, 0.000011396d },
            { 3730000.0d, 0.0000108812d },
            { 3744000.0d, 0.0000103823d },
            { 3758000.0d, 0.00000989985d },
            { 3772000.0d, 0.00000943419d },
            { 3786000.0d, 0.00000898583d },
            { 3800000.0d, 0.00000855523d },
            { 3814000.0d, 0.00000814285d },
            { 3828000.0d, 0.0000077491d },
            { 3842000.0d, 0.00000736891d },
            { 3856000.0d, 0.00000699847d },
            { 3870000.0d, 0.00000663815d },
            { 3884000.0d, 0.00000628829d },
            { 3898000.0d, 0.00000594925d },
            { 3912000.0d, 0.00000562139d },
            { 3926000.0d, 0.00000530508d },
            { 3940000.0d, 0.00000500068d },
            { 3954000.0d, 0.00000470858d },
            { 3968000.0d, 0.00000442912d },
            { 3982000.0d, 0.00000416268d },
            { 3996000.0d, 0.0000039074d },
            { 4010000.0d, 0.00000365886d },
            { 4024000.0d, 0.00000341707d },
            { 4038000.0d, 0.00000318217d },
            { 4052000.0d, 0.00000295431d },
            { 4066000.0d, 0.00000273365d },
            { 4080000.0d, 0.00000252035d },
            { 4094000.0d, 0.00000231454d },
            { 4108000.0d, 0.0000021164d },
            { 4122000.0d, 0.00000192607d },
            { 4136000.0d, 0.00000174371d },
            { 4150000.0d, 0.00000156947d },
            { 4164000.0d, 0.00000140352d },
            { 4178000.0d, 0.00000124599d },
            { 4192000.0d, 0.00000109707d },
            { 4206000.0d, 0.000000956897d },
            { 4220000.0d, 0.000000825631d },
            { 4234000.0d, 0.000000703433d },
            { 4248000.0d, 0.00000059046d },
            { 4262000.0d, 0.000000486867d },
            { 4276000.0d, 0.000000392814d },
            { 4290000.0d, 0.000000308456d },
            { 4304000.0d, 0.00000023395d },
            { 4318000.0d, 0.000000169449d },
            { 4332000.0d, 0.000000115107d },
            { 4346000.0d, 0.0000000710731d },
            { 4360000.0d, 0.0000000374921d },
            { 4374000.0d, 0.0000000145d },
            { 4388000.0d, 0.00000000221294d },
            { 4397000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    