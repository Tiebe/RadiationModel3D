using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium67";
        public override double halfLife { get; } = 1134.0d;
        public override double atomicWeight { get; } = 66.93272d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc67()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.8428d, new GammaParticle(167010.0, 0.00742)), new(0.0032340000000000003d, new GammaParticle(253300.0, 0.00489)), new(0.0147d, new GammaParticle(359500.0, 0.00345)), new(0.0012740000000000002d, new GammaParticle(468600.0, 0.00265)), new(0.000833d, new GammaParticle(551200.0, 0.00225)), new(0.000588d, new GammaParticle(557400.0, 0.00222)), new(0.0030380000000000003d, new GammaParticle(661100.0, 0.00188)), new(0.00441d, new GammaParticle(728200.0, 0.0017)), new(0.02352d, new GammaParticle(728700.0, 0.0017)), new(0.000686d, new GammaParticle(744200.0, 0.00167)), new(0.00784d, new GammaParticle(811800.0, 0.00153)), new(0.02989d, new GammaParticle(828300.0, 0.0015)), new(0.009555000000000001d, new GammaParticle(898500.0, 0.00138)), new(0.03087d, new GammaParticle(911200.0, 0.00136)), new(0.030379999999999997d, new GammaParticle(914800.0, 0.00136)), new(0.01127d, new GammaParticle(981300.0, 0.00126)), new(0.010289999999999999d, new GammaParticle(1081300.0, 0.00115)), new(0.0002842d, new GammaParticle(1196500.0, 0.00104)), new(0.0001274d, new GammaParticle(1203000.0, 0.00103)), new(0.0037730000000000003d, new GammaParticle(1280600.0, 0.00097)), new(0.000784d, new GammaParticle(1317600.0, 0.00094)), new(0.006566d, new GammaParticle(1450700.0, 0.00085)), new(0.049d, new GammaParticle(1472800.0, 0.00084)), new(0.00637d, new GammaParticle(1639500.0, 0.00076)), new(0.00882d, new GammaParticle(1643000.0, 0.00075)), new(0.0001274d, new GammaParticle(1668800.0, 0.00074)), new(0.0001127d, new GammaParticle(1680000.0, 0.00074)), new(0.000441d, new GammaParticle(1708200.0, 0.00073)), new(0.0006370000000000001d, new GammaParticle(1790800.0, 0.00069)), new(0.013229999999999999d, new GammaParticle(1809400.0, 0.00069)), new(0.000245d, new GammaParticle(1844700.0, 0.00067)), new(0.001372d, new GammaParticle(1976200.0, 0.00063)), new(0.00021559999999999998d, new GammaParticle(2079500.0, 0.0006)), new(0.000588d, new GammaParticle(2144000.0, 0.00058)), new(0.000686d, new GammaParticle(2395900.0, 0.00052)), new(0.0001568d, new GammaParticle(2453000.0, 0.00051)), new(0.002058d, new GammaParticle(2526600.0, 0.00049)), new(0.002254d, new GammaParticle(2563600.0, 0.00048)), new(0.0003479d, new GammaParticle(2668800.0, 0.00046)), new(0.000931d, new GammaParticle(2730600.0, 0.00045)), new(0.001029d, new GammaParticle(2865600.0, 0.00043)), new(0.000343d, new GammaParticle(3042200.0, 0.00041)), new(0.001911d, new GammaParticle(3058300.0, 0.00041)), new(0.000686d, new GammaParticle(3123100.0, 0.0004)), new(0.00013230000000000002d, new GammaParticle(3144200.0, 0.00039)), new(0.001127d, new GammaParticle(3162800.0, 0.00039)), new(0.00028910000000000003d, new GammaParticle(3225500.0, 0.00038)), new(0.0001764d, new GammaParticle(3307800.0, 0.00037)), new(0.0002009d, new GammaParticle(3361900.0, 0.00037)), new(0.0001764d, new GammaParticle(3368800.0, 0.00037)), new(0.0015190000000000002d, new GammaParticle(3401500.0, 0.00036)), new(8.33e-05d, new GammaParticle(3465700.0, 0.00036)), new(5.88e-05d, new GammaParticle(3612400.0, 0.00034)), new(5.88e-05d, new GammaParticle(3631400.0, 0.00034)), new(4.41e-05d, new GammaParticle(3655600.0, 0.00034)), new(0.0001274d, new GammaParticle(3727000.0, 0.00033)), new(1.80623d, new GammaParticle(511000.0, 0.00243)), new(0.001262856016375731d, new GammaParticle(1127.0, 1.10013)), new(0.01121060679633926d, new GammaParticle(9225.0, 0.1344)), new(0.021785088994052196d, new GammaParticle(9252.0, 0.13401)), new(0.004778800076202818d, new GammaParticle(10306.0, 0.1203)), new(0.004807472876660035d, new GammaParticle(10313.0, 0.12022)), new(2.8672800457216907e-05d, new GammaParticle(10365.0, 0.11962)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.00000000000201967d },
            { 200.0d, 0.00000000000782908d },
            { 300.0d, 0.0000000000174403d },
            { 400.0d, 0.0000000000308546d },
            { 500.0d, 0.0000000000480727d },
            { 600.0d, 0.0000000000729307d },
            { 700.0d, 0.000000000109256d },
            { 800.0d, 0.00000000015249d },
            { 900.0d, 0.000000000202632d },
            { 1000.0d, 0.000000000259684d },
            { 1500.0d, 0.00000000350613d },
            { 2000.0d, 0.0000000220383d },
            { 2500.0d, 0.000000052054d },
            { 3000.0d, 0.000000091888d },
            { 3500.0d, 0.000000141582d },
            { 4000.0d, 0.000000201121d },
            { 4500.0d, 0.000000270602d },
            { 5000.0d, 0.000000349975d },
            { 5500.0d, 0.000000439253d },
            { 6000.0d, 0.000000538431d },
            { 6500.0d, 0.000000647539d },
            { 7000.0d, 0.000000766559d },
            { 7500.0d, 0.000000895491d },
            { 8000.0d, 0.00000103433d },
            { 8500.0d, 0.00000118402d },
            { 9000.0d, 0.00000134383d },
            { 9500.0d, 0.00000151374d },
            { 10000.0d, 0.00000169375d },
            { 11000.0d, 0.00000208437d },
            { 12000.0d, 0.00000251544d },
            { 13000.0d, 0.00000298438d },
            { 14000.0d, 0.00000349267d },
            { 15000.0d, 0.00000403837d },
            { 16000.0d, 0.00000461663d },
            { 17000.0d, 0.00000522818d },
            { 18000.0d, 0.000005875d },
            { 19000.0d, 0.00000655698d },
            { 20000.0d, 0.00000727411d },
            { 21000.0d, 0.00000798103d },
            { 22000.0d, 0.00000871016d },
            { 23000.0d, 0.0000094637d },
            { 24000.0d, 0.0000102416d },
            { 25000.0d, 0.0000110415d },
            { 26000.0d, 0.0000118598d },
            { 27000.0d, 0.0000126998d },
            { 28000.0d, 0.0000135616d },
            { 29000.0d, 0.0000144408d },
            { 30000.0d, 0.0000153403d },
            { 31000.0d, 0.0000162263d },
            { 32000.0d, 0.000017126d },
            { 33000.0d, 0.0000180377d },
            { 34000.0d, 0.0000189623d },
            { 35000.0d, 0.0000198998d },
            { 36000.0d, 0.0000208461d },
            { 37000.0d, 0.0000218029d },
            { 38000.0d, 0.0000227708d },
            { 39000.0d, 0.0000237498d },
            { 40000.0d, 0.00002474d },
            { 41000.0d, 0.0000257217d },
            { 42000.0d, 0.0000267105d },
            { 43000.0d, 0.0000277054d },
            { 44000.0d, 0.0000287071d },
            { 45000.0d, 0.0000297149d },
            { 46000.0d, 0.0000307276d },
            { 47000.0d, 0.0000317464d },
            { 48000.0d, 0.0000327712d },
            { 49000.0d, 0.0000338014d },
            { 50000.0d, 0.0000348367d },
            { 51000.0d, 0.0000358673d },
            { 52000.0d, 0.0000369016d },
            { 53000.0d, 0.0000379389d },
            { 54000.0d, 0.0000389795d },
            { 55000.0d, 0.0000400236d },
            { 56000.0d, 0.0000410701d },
            { 57000.0d, 0.000042119d },
            { 58000.0d, 0.0000431707d },
            { 59000.0d, 0.0000442252d },
            { 60000.0d, 0.0000452826d },
            { 61000.0d, 0.0000463366d },
            { 62000.0d, 0.0000473922d },
            { 63000.0d, 0.0000484493d },
            { 64000.0d, 0.0000495076d },
            { 65000.0d, 0.0000505672d },
            { 66000.0d, 0.0000516277d },
            { 67000.0d, 0.0000526894d },
            { 68000.0d, 0.0000537523d },
            { 69000.0d, 0.0000548162d },
            { 70000.0d, 0.0000558812d },
            { 71000.0d, 0.0000569438d },
            { 72000.0d, 0.0000580067d },
            { 73000.0d, 0.0000590699d },
            { 74000.0d, 0.0000601334d },
            { 75000.0d, 0.0000611973d },
            { 76000.0d, 0.0000622612d },
            { 77000.0d, 0.0000633252d },
            { 78000.0d, 0.0000643892d },
            { 79000.0d, 0.0000654534d },
            { 80000.0d, 0.0000665178d },
            { 81000.0d, 0.0000675801d },
            { 82000.0d, 0.0000686421d },
            { 83000.0d, 0.0000697038d },
            { 84000.0d, 0.0000707652d },
            { 85000.0d, 0.0000718261d },
            { 86000.0d, 0.0000728864d },
            { 87000.0d, 0.0000739463d },
            { 88000.0d, 0.0000750058d },
            { 89000.0d, 0.0000760648d },
            { 90000.0d, 0.0000771233d },
            { 91000.0d, 0.0000781801d },
            { 92000.0d, 0.0000792362d },
            { 93000.0d, 0.0000802914d },
            { 94000.0d, 0.0000813459d },
            { 95000.0d, 0.0000823997d },
            { 96000.0d, 0.0000834526d },
            { 97000.0d, 0.0000845046d },
            { 98000.0d, 0.0000855559d },
            { 99000.0d, 0.0000866063d },
            { 100000.0d, 0.0000876559d },
            { 110000.0d, 0.0000980895d },
            { 120000.0d, 0.000108408d },
            { 130000.0d, 0.000118602d },
            { 140000.0d, 0.000128665d },
            { 150000.0d, 0.000138595d },
            { 160000.0d, 0.000148389d },
            { 170000.0d, 0.000158046d },
            { 180000.0d, 0.000167568d },
            { 190000.0d, 0.000176953d },
            { 200000.0d, 0.000186203d },
            { 210000.0d, 0.000195318d },
            { 220000.0d, 0.0002043d },
            { 230000.0d, 0.000213147d },
            { 240000.0d, 0.000221863d },
            { 250000.0d, 0.000230447d },
            { 260000.0d, 0.0002389d },
            { 270000.0d, 0.000247222d },
            { 280000.0d, 0.000255415d },
            { 290000.0d, 0.000263478d },
            { 300000.0d, 0.000271413d },
            { 310000.0d, 0.000279219d },
            { 320000.0d, 0.000286896d },
            { 330000.0d, 0.000294446d },
            { 340000.0d, 0.000301869d },
            { 350000.0d, 0.000309165d },
            { 360000.0d, 0.000316335d },
            { 370000.0d, 0.000323379d },
            { 380000.0d, 0.000330296d },
            { 390000.0d, 0.000337089d },
            { 400000.0d, 0.000343756d },
            { 410000.0d, 0.000350298d },
            { 420000.0d, 0.000356717d },
            { 430000.0d, 0.000363012d },
            { 440000.0d, 0.000369184d },
            { 450000.0d, 0.000375234d },
            { 460000.0d, 0.000381161d },
            { 470000.0d, 0.000386967d },
            { 480000.0d, 0.000392647d },
            { 490000.0d, 0.0003982d },
            { 500000.0d, 0.000403624d },
            { 510000.0d, 0.000408921d },
            { 520000.0d, 0.000414089d },
            { 530000.0d, 0.000419131d },
            { 540000.0d, 0.000424044d },
            { 550000.0d, 0.000428831d },
            { 560000.0d, 0.000433492d },
            { 570000.0d, 0.000438026d },
            { 580000.0d, 0.000442435d },
            { 590000.0d, 0.000446717d },
            { 600000.0d, 0.000450872d },
            { 610000.0d, 0.000454899d },
            { 620000.0d, 0.000458798d },
            { 630000.0d, 0.000462571d },
            { 640000.0d, 0.000466218d },
            { 650000.0d, 0.000469741d },
            { 660000.0d, 0.000473138d },
            { 670000.0d, 0.000476411d },
            { 680000.0d, 0.00047956d },
            { 690000.0d, 0.00048258d },
            { 700000.0d, 0.000485474d },
            { 710000.0d, 0.000488241d },
            { 720000.0d, 0.000490882d },
            { 730000.0d, 0.000493397d },
            { 740000.0d, 0.000495787d },
            { 750000.0d, 0.000498054d },
            { 760000.0d, 0.000500198d },
            { 770000.0d, 0.000502219d },
            { 780000.0d, 0.000504119d },
            { 790000.0d, 0.000505898d },
            { 800000.0d, 0.000507558d },
            { 810000.0d, 0.0005091d },
            { 820000.0d, 0.000510524d },
            { 830000.0d, 0.000511832d },
            { 840000.0d, 0.000513025d },
            { 850000.0d, 0.000514105d },
            { 860000.0d, 0.000515072d },
            { 870000.0d, 0.000515929d },
            { 880000.0d, 0.000516674d },
            { 890000.0d, 0.000517313d },
            { 900000.0d, 0.000517844d },
            { 910000.0d, 0.000518271d },
            { 920000.0d, 0.000518593d },
            { 930000.0d, 0.000518814d },
            { 940000.0d, 0.000518934d },
            { 950000.0d, 0.000518957d },
            { 960000.0d, 0.000518882d },
            { 970000.0d, 0.000518713d },
            { 980000.0d, 0.000518451d },
            { 990000.0d, 0.000518098d },
            { 1000000.0d, 0.000517656d },
            { 1010000.0d, 0.000517127d },
            { 1020000.0d, 0.000516513d },
            { 1030000.0d, 0.000515816d },
            { 1040000.0d, 0.00051504d },
            { 1050000.0d, 0.000514184d },
            { 1060000.0d, 0.000513253d },
            { 1070000.0d, 0.000512248d },
            { 1080000.0d, 0.000511172d },
            { 1090000.0d, 0.000510028d },
            { 1100000.0d, 0.000508817d },
            { 1110000.0d, 0.000507542d },
            { 1120000.0d, 0.000506207d },
            { 1130000.0d, 0.000504814d },
            { 1140000.0d, 0.000503365d },
            { 1150000.0d, 0.000501862d },
            { 1160000.0d, 0.00050031d },
            { 1170000.0d, 0.000498709d },
            { 1180000.0d, 0.000497065d },
            { 1190000.0d, 0.00049538d },
            { 1200000.0d, 0.000493657d },
            { 1210000.0d, 0.000491897d },
            { 1220000.0d, 0.000490106d },
            { 1230000.0d, 0.000488285d },
            { 1240000.0d, 0.000486437d },
            { 1250000.0d, 0.000484564d },
            { 1260000.0d, 0.00048267d },
            { 1270000.0d, 0.000480758d },
            { 1280000.0d, 0.000478832d },
            { 1290000.0d, 0.000476895d },
            { 1300000.0d, 0.000474949d },
            { 1310000.0d, 0.000473001d },
            { 1320000.0d, 0.000471051d },
            { 1330000.0d, 0.000469103d },
            { 1340000.0d, 0.000467162d },
            { 1350000.0d, 0.000465232d },
            { 1360000.0d, 0.000463315d },
            { 1370000.0d, 0.000461416d },
            { 1380000.0d, 0.000459537d },
            { 1390000.0d, 0.000457683d },
            { 1400000.0d, 0.000455831d },
            { 1410000.0d, 0.000453956d },
            { 1420000.0d, 0.00045206d },
            { 1430000.0d, 0.000450146d },
            { 1440000.0d, 0.000448216d },
            { 1450000.0d, 0.000446272d },
            { 1460000.0d, 0.000444316d },
            { 1470000.0d, 0.000442353d },
            { 1480000.0d, 0.000440381d },
            { 1490000.0d, 0.000438405d },
            { 1500000.0d, 0.000436429d },
            { 1510000.0d, 0.000434453d },
            { 1520000.0d, 0.000432478d },
            { 1530000.0d, 0.000430511d },
            { 1540000.0d, 0.000428551d },
            { 1550000.0d, 0.000426603d },
            { 1560000.0d, 0.000424667d },
            { 1570000.0d, 0.00042271d },
            { 1580000.0d, 0.0004207d },
            { 1590000.0d, 0.000418637d },
            { 1600000.0d, 0.00041652d },
            { 1610000.0d, 0.00041435d },
            { 1620000.0d, 0.00041213d },
            { 1630000.0d, 0.000409858d },
            { 1640000.0d, 0.000407536d },
            { 1650000.0d, 0.000405165d },
            { 1660000.0d, 0.000402745d },
            { 1670000.0d, 0.000400276d },
            { 1680000.0d, 0.00039776d },
            { 1690000.0d, 0.000395197d },
            { 1700000.0d, 0.000392588d },
            { 1710000.0d, 0.000389933d },
            { 1720000.0d, 0.000387235d },
            { 1730000.0d, 0.000384493d },
            { 1740000.0d, 0.000381708d },
            { 1750000.0d, 0.00037888d },
            { 1760000.0d, 0.000376012d },
            { 1770000.0d, 0.000373104d },
            { 1780000.0d, 0.000370156d },
            { 1790000.0d, 0.00036717d },
            { 1800000.0d, 0.000364146d },
            { 1810000.0d, 0.000361085d },
            { 1820000.0d, 0.000357988d },
            { 1830000.0d, 0.000354857d },
            { 1840000.0d, 0.000351692d },
            { 1850000.0d, 0.000348493d },
            { 1860000.0d, 0.000345262d },
            { 1870000.0d, 0.000342001d },
            { 1880000.0d, 0.00033871d },
            { 1890000.0d, 0.00033539d },
            { 1900000.0d, 0.000332042d },
            { 1910000.0d, 0.000328667d },
            { 1920000.0d, 0.000325266d },
            { 1930000.0d, 0.00032184d },
            { 1940000.0d, 0.00031839d },
            { 1950000.0d, 0.000314919d },
            { 1960000.0d, 0.000311425d },
            { 1970000.0d, 0.000307912d },
            { 1980000.0d, 0.000304378d },
            { 1990000.0d, 0.000300827d },
            { 2000000.0d, 0.000297258d },
            { 2010000.0d, 0.000293674d },
            { 2020000.0d, 0.000290076d },
            { 2030000.0d, 0.000286463d },
            { 2040000.0d, 0.000282838d },
            { 2050000.0d, 0.000279203d },
            { 2060000.0d, 0.000275556d },
            { 2070000.0d, 0.000271902d },
            { 2080000.0d, 0.00026824d },
            { 2090000.0d, 0.000264571d },
            { 2100000.0d, 0.000260898d },
            { 2110000.0d, 0.000257221d },
            { 2120000.0d, 0.000253542d },
            { 2130000.0d, 0.000249851d },
            { 2140000.0d, 0.000246146d },
            { 2150000.0d, 0.000242428d },
            { 2160000.0d, 0.000238698d },
            { 2170000.0d, 0.000234957d },
            { 2180000.0d, 0.000231206d },
            { 2190000.0d, 0.000227446d },
            { 2200000.0d, 0.000223677d },
            { 2210000.0d, 0.000219903d },
            { 2220000.0d, 0.000216121d },
            { 2230000.0d, 0.000212336d },
            { 2240000.0d, 0.000208547d },
            { 2250000.0d, 0.000204756d },
            { 2260000.0d, 0.000200963d },
            { 2270000.0d, 0.00019717d },
            { 2280000.0d, 0.000193378d },
            { 2290000.0d, 0.000189589d },
            { 2300000.0d, 0.000185801d },
            { 2310000.0d, 0.000182019d },
            { 2320000.0d, 0.000178243d },
            { 2330000.0d, 0.000174474d },
            { 2340000.0d, 0.000170712d },
            { 2350000.0d, 0.00016696d },
            { 2360000.0d, 0.000163218d },
            { 2370000.0d, 0.000159488d },
            { 2380000.0d, 0.00015577d },
            { 2390000.0d, 0.000152063d },
            { 2400000.0d, 0.000148368d },
            { 2410000.0d, 0.000144688d },
            { 2420000.0d, 0.000141021d },
            { 2430000.0d, 0.000137371d },
            { 2440000.0d, 0.000133739d },
            { 2450000.0d, 0.000130124d },
            { 2460000.0d, 0.00012653d },
            { 2470000.0d, 0.000122957d },
            { 2480000.0d, 0.000119406d },
            { 2490000.0d, 0.000115879d },
            { 2500000.0d, 0.000112377d },
            { 2510000.0d, 0.000108901d },
            { 2520000.0d, 0.000105452d },
            { 2530000.0d, 0.000102033d },
            { 2540000.0d, 0.0000986438d },
            { 2550000.0d, 0.0000952863d },
            { 2560000.0d, 0.0000919618d },
            { 2570000.0d, 0.0000886717d },
            { 2580000.0d, 0.0000854173d },
            { 2590000.0d, 0.0000822001d },
            { 2600000.0d, 0.0000790213d },
            { 2610000.0d, 0.0000758825d },
            { 2620000.0d, 0.0000727851d },
            { 2630000.0d, 0.0000697304d },
            { 2640000.0d, 0.0000667199d },
            { 2650000.0d, 0.0000637551d },
            { 2660000.0d, 0.0000608373d },
            { 2670000.0d, 0.0000579681d },
            { 2680000.0d, 0.000055149d },
            { 2690000.0d, 0.0000523813d },
            { 2700000.0d, 0.0000496667d },
            { 2710000.0d, 0.0000470065d },
            { 2720000.0d, 0.0000444023d },
            { 2730000.0d, 0.0000418556d },
            { 2740000.0d, 0.0000393679d },
            { 2750000.0d, 0.0000369408d },
            { 2760000.0d, 0.0000345758d },
            { 2770000.0d, 0.0000322745d },
            { 2780000.0d, 0.0000300383d },
            { 2790000.0d, 0.0000278689d },
            { 2800000.0d, 0.0000257678d },
            { 2810000.0d, 0.0000237366d },
            { 2820000.0d, 0.0000217769d },
            { 2830000.0d, 0.0000198903d },
            { 2840000.0d, 0.0000180783d },
            { 2850000.0d, 0.0000163427d },
            { 2860000.0d, 0.000014685d },
            { 2870000.0d, 0.0000131068d },
            { 2880000.0d, 0.0000116097d },
            { 2890000.0d, 0.0000101954d },
            { 2900000.0d, 0.00000886556d },
            { 2910000.0d, 0.00000762175d },
            { 2920000.0d, 0.00000646565d },
            { 2930000.0d, 0.00000539889d },
            { 2940000.0d, 0.00000442313d },
            { 2950000.0d, 0.00000354002d },
            { 2960000.0d, 0.00000275119d },
            { 2970000.0d, 0.00000205829d },
            { 2980000.0d, 0.00000146296d },
            { 2990000.0d, 0.000000966795d },
            { 3000000.0d, 0.000000571398d },
            { 3010000.0d, 0.000000278312d },
            { 3020000.0d, 0.0000000889972d },
            { 3030000.0d, 0.00000000470914d },
            { 3033000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    