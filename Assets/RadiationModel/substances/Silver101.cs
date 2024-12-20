using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver101 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver101";
        public override double halfLife { get; } = 666.0d;
        public override double atomicWeight { get; } = 100.91268d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium101()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.04734d, new GammaParticle(80260.0, 0.01545)), new(0.00263d, new GammaParticle(180500.0, 0.00687)), new(0.526d, new GammaParticle(261010.0, 0.00475)), new(0.016832d, new GammaParticle(274680.0, 0.00451)), new(0.018935999999999998d, new GammaParticle(326910.0, 0.00379)), new(0.0023669999999999997d, new GammaParticle(386700.0, 0.00321)), new(0.006312d, new GammaParticle(406290.0, 0.00305)), new(0.000789d, new GammaParticle(420100.0, 0.00295)), new(0.0285092d, new GammaParticle(439200.0, 0.00282)), new(0.0036820000000000004d, new GammaParticle(459900.0, 0.0027)), new(0.003156d, new GammaParticle(470600.0, 0.00263)), new(0.00263d, new GammaParticle(494000.0, 0.00251)), new(0.005786d, new GammaParticle(506600.0, 0.00245)), new(0.020514d, new GammaParticle(507600.0, 0.00244)), new(0.003156d, new GammaParticle(532200.0, 0.00233)), new(0.0138338d, new GammaParticle(537920.0, 0.0023)), new(0.023144d, new GammaParticle(543320.0, 0.00228)), new(0.0038924d, new GammaParticle(550220.0, 0.00225)), new(0.0035242d, new GammaParticle(575550.0, 0.00215)), new(0.000526d, new GammaParticle(577900.0, 0.00215)), new(0.002104d, new GammaParticle(581300.0, 0.00213)), new(0.01052d, new GammaParticle(585900.0, 0.00212)), new(0.09994d, new GammaParticle(588000.0, 0.00211)), new(0.0059964d, new GammaParticle(598220.0, 0.00207)), new(0.006575d, new GammaParticle(611300.0, 0.00203)), new(0.001578d, new GammaParticle(617600.0, 0.00201)), new(0.0077322d, new GammaParticle(623580.0, 0.00199)), new(0.015780000000000002d, new GammaParticle(654400.0, 0.00189)), new(0.098362d, new GammaParticle(667320.0, 0.00186)), new(0.01315d, new GammaParticle(677700.0, 0.00183)), new(0.02367d, new GammaParticle(677900.0, 0.00183)), new(0.032612d, new GammaParticle(734710.0, 0.00169)), new(0.009467999999999999d, new GammaParticle(736500.0, 0.00168)), new(0.0029456d, new GammaParticle(799900.0, 0.00155)), new(0.001052d, new GammaParticle(806900.0, 0.00154)), new(0.0024722d, new GammaParticle(825900.0, 0.0015)), new(0.0027877999999999996d, new GammaParticle(867200.0, 0.00143)), new(0.0112564d, new GammaParticle(893200.0, 0.00139)), new(0.004786599999999999d, new GammaParticle(899390.0, 0.00138)), new(0.0006312d, new GammaParticle(910000.0, 0.00136)), new(0.005786d, new GammaParticle(912840.0, 0.00136)), new(0.003156d, new GammaParticle(930500.0, 0.00133)), new(0.013675999999999999d, new GammaParticle(938320.0, 0.00132)), new(0.011572d, new GammaParticle(944330.0, 0.00131)), new(0.0263d, new GammaParticle(1093590.0, 0.00113)), new(0.0041554d, new GammaParticle(1125270.0, 0.0011)), new(0.08942d, new GammaParticle(1173940.0, 0.00106)), new(0.0263d, new GammaParticle(1205260.0, 0.00103)), new(0.0093628d, new GammaParticle(1299460.0, 0.00095)), new(0.007364000000000001d, new GammaParticle(1306700.0, 0.00095)), new(0.0068379999999999995d, new GammaParticle(1326100.0, 0.00093)), new(0.002893d, new GammaParticle(1353580.0, 0.00092)), new(0.001052d, new GammaParticle(1399300.0, 0.00089)), new(0.004208d, new GammaParticle(1418010.0, 0.00087)), new(0.0044184d, new GammaParticle(1454020.0, 0.00085)), new(0.0016832d, new GammaParticle(1487500.0, 0.00083)), new(0.0047339999999999995d, new GammaParticle(1632800.0, 0.00076)), new(0.004208d, new GammaParticle(1632900.0, 0.00076)), new(0.0016306d, new GammaParticle(1641800.0, 0.00076)), new(0.0013675999999999998d, new GammaParticle(1671900.0, 0.00074)), new(0.0025248d, new GammaParticle(1815500.0, 0.00068)), new(0.0024196d, new GammaParticle(1901200.0, 0.00065)), new(0.0024722d, new GammaParticle(1959000.0, 0.00063)), new(0.006154199999999999d, new GammaParticle(2041810.0, 0.00061)), new(0.0082056d, new GammaParticle(2053100.0, 0.0006)), new(0.003156d, new GammaParticle(2131700.0, 0.00058)), new(0.006312d, new GammaParticle(2307800.0, 0.00054)), new(0.001052d, new GammaParticle(2444400.0, 0.00051)), new(0.0008416d, new GammaParticle(2519400.0, 0.00049)), new(0.0029456d, new GammaParticle(2635100.0, 0.00047)), new(0.0017883999999999999d, new GammaParticle(2664300.0, 0.00047)), new(0.0036820000000000004d, new GammaParticle(2699100.0, 0.00046)), new(0.0013675999999999998d, new GammaParticle(2854000.0, 0.00043)), new(0.0013675999999999998d, new GammaParticle(2888100.0, 0.00043)), new(0.0017358d, new GammaParticle(3143300.0, 0.00039)), new(0.0006837999999999999d, new GammaParticle(3197400.0, 0.00039)), new(1.44066d, new GammaParticle(511000.0, 0.00243)), new(0.017431554712799998d, new GammaParticle(3053.0, 0.40611)), new(0.06884496084603185d, new GammaParticle(21020.0, 0.05898)), new(0.13006794038547487d, new GammaParticle(21177.0, 0.05855)), new(0.0356853145029857d, new GammaParticle(23904.0, 0.05187)), new(0.04175181796849326d, new GammaParticle(24070.0, 0.05151)), new(0.006066503465507569d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 700.0d, 0.0000000000156314d },
            { 1400.0d, 0.000000000119371d },
            { 2100.0d, 0.000000000611276d },
            { 2800.0d, 0.00000000169701d },
            { 3500.0d, 0.00000000725953d },
            { 4200.0d, 0.000000018632d },
            { 4900.0d, 0.0000000410685d },
            { 5600.0d, 0.0000000719569d },
            { 6300.0d, 0.000000109287d },
            { 7000.0d, 0.000000153236d },
            { 7700.0d, 0.000000203642d },
            { 8400.0d, 0.000000260533d },
            { 9100.0d, 0.000000323954d },
            { 9800.0d, 0.0000003941d },
            { 10000.0d, 0.00000041535d },
            { 11000.0d, 0.000000530771d },
            { 12000.0d, 0.000000660012d },
            { 13000.0d, 0.000000810292d },
            { 14000.0d, 0.00000097651d },
            { 15000.0d, 0.00000115912d },
            { 16000.0d, 0.0000013582d },
            { 17000.0d, 0.000001576d },
            { 18000.0d, 0.00000181055d },
            { 19000.0d, 0.00000206761d },
            { 20000.0d, 0.00000234265d },
            { 21000.0d, 0.00000263555d },
            { 22000.0d, 0.00000294627d },
            { 23000.0d, 0.00000327485d },
            { 24000.0d, 0.00000362129d },
            { 25000.0d, 0.00000398286d },
            { 26000.0d, 0.00000436123d },
            { 27000.0d, 0.00000475657d },
            { 28000.0d, 0.00000516569d },
            { 29000.0d, 0.00000559085d },
            { 30000.0d, 0.00000603223d },
            { 31000.0d, 0.00000648653d },
            { 32000.0d, 0.00000695604d },
            { 33000.0d, 0.00000743902d },
            { 34000.0d, 0.00000793667d },
            { 35000.0d, 0.00000844902d },
            { 36000.0d, 0.00000897547d },
            { 37000.0d, 0.00000950879d },
            { 38000.0d, 0.0000100548d },
            { 39000.0d, 0.0000106135d },
            { 40000.0d, 0.0000111847d },
            { 41000.0d, 0.0000117664d },
            { 42000.0d, 0.0000123602d },
            { 43000.0d, 0.000012963d },
            { 44000.0d, 0.0000135771d },
            { 45000.0d, 0.0000142023d },
            { 46000.0d, 0.000014834d },
            { 47000.0d, 0.0000154759d },
            { 48000.0d, 0.0000161279d },
            { 49000.0d, 0.0000167861d },
            { 50000.0d, 0.0000174532d },
            { 51000.0d, 0.0000181291d },
            { 52000.0d, 0.0000188138d },
            { 53000.0d, 0.0000195074d },
            { 54000.0d, 0.0000202098d },
            { 55000.0d, 0.0000209155d },
            { 56000.0d, 0.0000216286d },
            { 57000.0d, 0.0000223478d },
            { 58000.0d, 0.0000230741d },
            { 59000.0d, 0.0000238074d },
            { 60000.0d, 0.0000245479d },
            { 61000.0d, 0.0000252934d },
            { 62000.0d, 0.0000260455d },
            { 63000.0d, 0.0000268041d },
            { 64000.0d, 0.0000275663d },
            { 65000.0d, 0.0000283334d },
            { 66000.0d, 0.000029106d },
            { 67000.0d, 0.0000298828d },
            { 68000.0d, 0.0000306647d },
            { 69000.0d, 0.0000314518d },
            { 70000.0d, 0.000032244d },
            { 71000.0d, 0.000033041d },
            { 72000.0d, 0.0000338431d },
            { 73000.0d, 0.0000346462d },
            { 74000.0d, 0.0000354533d },
            { 75000.0d, 0.0000362646d },
            { 76000.0d, 0.0000370797d },
            { 77000.0d, 0.0000378989d },
            { 78000.0d, 0.000038722d },
            { 79000.0d, 0.000039548d },
            { 80000.0d, 0.0000403777d },
            { 81000.0d, 0.0000412104d },
            { 82000.0d, 0.000042045d },
            { 83000.0d, 0.0000428827d },
            { 84000.0d, 0.0000437236d },
            { 85000.0d, 0.0000445667d },
            { 86000.0d, 0.0000454126d },
            { 87000.0d, 0.0000462613d },
            { 88000.0d, 0.0000471129d },
            { 89000.0d, 0.0000479668d },
            { 90000.0d, 0.0000488234d },
            { 91000.0d, 0.0000496806d },
            { 92000.0d, 0.0000505401d },
            { 93000.0d, 0.0000514017d },
            { 94000.0d, 0.0000522655d },
            { 95000.0d, 0.0000531315d },
            { 96000.0d, 0.0000539996d },
            { 97000.0d, 0.0000548689d },
            { 98000.0d, 0.00005574d },
            { 99000.0d, 0.000056613d },
            { 100000.0d, 0.0000574869d },
            { 109000.0d, 0.0000654147d },
            { 118000.0d, 0.0000734237d },
            { 127000.0d, 0.0000814836d },
            { 136000.0d, 0.000089569d },
            { 145000.0d, 0.0000976602d },
            { 154000.0d, 0.000105741d },
            { 163000.0d, 0.000113799d },
            { 172000.0d, 0.000121823d },
            { 181000.0d, 0.000129804d },
            { 190000.0d, 0.000137736d },
            { 199000.0d, 0.000145611d },
            { 208000.0d, 0.000153425d },
            { 217000.0d, 0.000161174d },
            { 226000.0d, 0.000168855d },
            { 235000.0d, 0.000176462d },
            { 244000.0d, 0.000183994d },
            { 253000.0d, 0.000191449d },
            { 262000.0d, 0.000198824d },
            { 271000.0d, 0.000206117d },
            { 280000.0d, 0.000213328d },
            { 289000.0d, 0.000220453d },
            { 298000.0d, 0.000227491d },
            { 307000.0d, 0.00023444d },
            { 316000.0d, 0.000241299d },
            { 325000.0d, 0.000248066d },
            { 334000.0d, 0.000254742d },
            { 343000.0d, 0.000261325d },
            { 352000.0d, 0.000267814d },
            { 361000.0d, 0.000274209d },
            { 370000.0d, 0.000280509d },
            { 379000.0d, 0.000286713d },
            { 388000.0d, 0.000292822d },
            { 397000.0d, 0.000298835d },
            { 406000.0d, 0.000304751d },
            { 415000.0d, 0.000310569d },
            { 424000.0d, 0.00031629d },
            { 433000.0d, 0.000321913d },
            { 442000.0d, 0.000327439d },
            { 451000.0d, 0.000332866d },
            { 460000.0d, 0.000338195d },
            { 469000.0d, 0.000343426d },
            { 478000.0d, 0.000348559d },
            { 487000.0d, 0.000353592d },
            { 496000.0d, 0.000358528d },
            { 505000.0d, 0.000363365d },
            { 514000.0d, 0.000368104d },
            { 523000.0d, 0.000372744d },
            { 532000.0d, 0.000377286d },
            { 541000.0d, 0.000381731d },
            { 550000.0d, 0.000386075d },
            { 559000.0d, 0.000390318d },
            { 568000.0d, 0.000394459d },
            { 577000.0d, 0.0003985d },
            { 586000.0d, 0.00040244d },
            { 595000.0d, 0.000406279d },
            { 604000.0d, 0.000410018d },
            { 613000.0d, 0.000413656d },
            { 622000.0d, 0.000417194d },
            { 631000.0d, 0.000420632d },
            { 640000.0d, 0.000423969d },
            { 649000.0d, 0.000427208d },
            { 658000.0d, 0.000430347d },
            { 667000.0d, 0.000433387d },
            { 676000.0d, 0.000436329d },
            { 685000.0d, 0.000439172d },
            { 694000.0d, 0.000441919d },
            { 703000.0d, 0.000444567d },
            { 712000.0d, 0.000447119d },
            { 721000.0d, 0.000449574d },
            { 730000.0d, 0.000451934d },
            { 739000.0d, 0.000454198d },
            { 748000.0d, 0.000456368d },
            { 757000.0d, 0.000458444d },
            { 766000.0d, 0.000460427d },
            { 775000.0d, 0.000462316d },
            { 784000.0d, 0.000464114d },
            { 793000.0d, 0.000465821d },
            { 802000.0d, 0.000467435d },
            { 811000.0d, 0.00046896d },
            { 820000.0d, 0.000470392d },
            { 829000.0d, 0.000471735d },
            { 838000.0d, 0.00047299d },
            { 847000.0d, 0.000474155d },
            { 856000.0d, 0.000475234d },
            { 865000.0d, 0.000476226d },
            { 874000.0d, 0.000477133d },
            { 883000.0d, 0.000477954d },
            { 892000.0d, 0.000478691d },
            { 901000.0d, 0.000479342d },
            { 910000.0d, 0.000479909d },
            { 919000.0d, 0.000480392d },
            { 928000.0d, 0.000480787d },
            { 937000.0d, 0.000481098d },
            { 946000.0d, 0.000481322d },
            { 955000.0d, 0.000481463d },
            { 964000.0d, 0.00048152d },
            { 973000.0d, 0.000481491d },
            { 982000.0d, 0.000481379d },
            { 991000.0d, 0.000481181d },
            { 1000000.0d, 0.000480902d },
            { 1009000.0d, 0.00048054d },
            { 1018000.0d, 0.000480095d },
            { 1027000.0d, 0.000479571d },
            { 1036000.0d, 0.000478967d },
            { 1045000.0d, 0.000478285d },
            { 1054000.0d, 0.000477525d },
            { 1063000.0d, 0.000476688d },
            { 1072000.0d, 0.000475776d },
            { 1081000.0d, 0.000474789d },
            { 1090000.0d, 0.000473728d },
            { 1099000.0d, 0.000472596d },
            { 1108000.0d, 0.000471392d },
            { 1117000.0d, 0.000470118d },
            { 1126000.0d, 0.000468775d },
            { 1135000.0d, 0.000467364d },
            { 1144000.0d, 0.000465886d },
            { 1153000.0d, 0.000464335d },
            { 1162000.0d, 0.000462712d },
            { 1171000.0d, 0.000461016d },
            { 1180000.0d, 0.00045925d },
            { 1189000.0d, 0.000457413d },
            { 1198000.0d, 0.000455508d },
            { 1207000.0d, 0.000453535d },
            { 1216000.0d, 0.000451495d },
            { 1225000.0d, 0.00044939d },
            { 1234000.0d, 0.000447221d },
            { 1243000.0d, 0.000444988d },
            { 1252000.0d, 0.000442694d },
            { 1261000.0d, 0.000440336d },
            { 1270000.0d, 0.00043792d },
            { 1279000.0d, 0.000435444d },
            { 1288000.0d, 0.000432911d },
            { 1297000.0d, 0.00043032d },
            { 1306000.0d, 0.000427675d },
            { 1315000.0d, 0.000424974d },
            { 1324000.0d, 0.000422221d },
            { 1333000.0d, 0.000419417d },
            { 1342000.0d, 0.000416562d },
            { 1351000.0d, 0.000413659d },
            { 1360000.0d, 0.000410709d },
            { 1369000.0d, 0.000407712d },
            { 1378000.0d, 0.00040467d },
            { 1387000.0d, 0.000401586d },
            { 1396000.0d, 0.000398459d },
            { 1405000.0d, 0.000395292d },
            { 1414000.0d, 0.000392087d },
            { 1423000.0d, 0.000388845d },
            { 1432000.0d, 0.000385567d },
            { 1441000.0d, 0.000382254d },
            { 1450000.0d, 0.000378908d },
            { 1459000.0d, 0.000375532d },
            { 1468000.0d, 0.000372127d },
            { 1477000.0d, 0.000368693d },
            { 1486000.0d, 0.000365234d },
            { 1495000.0d, 0.00036175d },
            { 1504000.0d, 0.000358244d },
            { 1513000.0d, 0.000354716d },
            { 1522000.0d, 0.00035117d },
            { 1531000.0d, 0.000347605d },
            { 1540000.0d, 0.000344025d },
            { 1549000.0d, 0.00034043d },
            { 1558000.0d, 0.000336823d },
            { 1567000.0d, 0.000333205d },
            { 1576000.0d, 0.000329578d },
            { 1585000.0d, 0.000325943d },
            { 1594000.0d, 0.000322301d },
            { 1603000.0d, 0.000318656d },
            { 1612000.0d, 0.000315008d },
            { 1621000.0d, 0.00031136d },
            { 1630000.0d, 0.000307707d },
            { 1639000.0d, 0.00030405d },
            { 1648000.0d, 0.000300387d },
            { 1657000.0d, 0.000296718d },
            { 1666000.0d, 0.000293046d },
            { 1675000.0d, 0.000289371d },
            { 1684000.0d, 0.000285695d },
            { 1693000.0d, 0.00028202d },
            { 1702000.0d, 0.000278348d },
            { 1711000.0d, 0.000274681d },
            { 1720000.0d, 0.00027102d },
            { 1729000.0d, 0.000267367d },
            { 1738000.0d, 0.000263724d },
            { 1747000.0d, 0.000260093d },
            { 1756000.0d, 0.000256475d },
            { 1765000.0d, 0.000252873d },
            { 1774000.0d, 0.000249288d },
            { 1783000.0d, 0.000245722d },
            { 1792000.0d, 0.000242178d },
            { 1801000.0d, 0.000238655d },
            { 1810000.0d, 0.000235159d },
            { 1819000.0d, 0.000231689d },
            { 1828000.0d, 0.000228247d },
            { 1837000.0d, 0.000224837d },
            { 1846000.0d, 0.000221459d },
            { 1855000.0d, 0.000218116d },
            { 1864000.0d, 0.00021481d },
            { 1873000.0d, 0.000211542d },
            { 1882000.0d, 0.000208315d },
            { 1891000.0d, 0.00020513d },
            { 1900000.0d, 0.000201992d },
            { 1909000.0d, 0.000198899d },
            { 1918000.0d, 0.000195853d },
            { 1927000.0d, 0.000192854d },
            { 1936000.0d, 0.000189902d },
            { 1945000.0d, 0.000187001d },
            { 1954000.0d, 0.000184151d },
            { 1963000.0d, 0.000181355d },
            { 1972000.0d, 0.000178614d },
            { 1981000.0d, 0.00017592d },
            { 1990000.0d, 0.000173263d },
            { 1999000.0d, 0.000170644d },
            { 2008000.0d, 0.000168046d },
            { 2017000.0d, 0.000165447d },
            { 2026000.0d, 0.000162846d },
            { 2035000.0d, 0.000160242d },
            { 2044000.0d, 0.000157639d },
            { 2053000.0d, 0.000155037d },
            { 2062000.0d, 0.000152435d },
            { 2071000.0d, 0.000149835d },
            { 2080000.0d, 0.000147239d },
            { 2089000.0d, 0.000144646d },
            { 2098000.0d, 0.000142056d },
            { 2107000.0d, 0.000139472d },
            { 2116000.0d, 0.000136893d },
            { 2125000.0d, 0.000134319d },
            { 2134000.0d, 0.000131753d },
            { 2143000.0d, 0.000129193d },
            { 2152000.0d, 0.000126642d },
            { 2161000.0d, 0.000124101d },
            { 2170000.0d, 0.000121568d },
            { 2179000.0d, 0.000119047d },
            { 2188000.0d, 0.000116537d },
            { 2197000.0d, 0.00011404d },
            { 2206000.0d, 0.000111555d },
            { 2215000.0d, 0.000109085d },
            { 2224000.0d, 0.00010663d },
            { 2233000.0d, 0.000104191d },
            { 2242000.0d, 0.000101768d },
            { 2251000.0d, 0.0000993603d },
            { 2260000.0d, 0.0000969676d },
            { 2269000.0d, 0.0000945908d },
            { 2278000.0d, 0.0000922306d },
            { 2287000.0d, 0.0000898879d },
            { 2296000.0d, 0.0000875635d },
            { 2305000.0d, 0.0000852582d },
            { 2314000.0d, 0.000082973d },
            { 2323000.0d, 0.0000807086d },
            { 2332000.0d, 0.000078466d },
            { 2341000.0d, 0.0000762461d },
            { 2350000.0d, 0.0000740495d },
            { 2359000.0d, 0.0000718774d },
            { 2368000.0d, 0.0000697305d },
            { 2377000.0d, 0.0000676097d },
            { 2386000.0d, 0.000065516d },
            { 2395000.0d, 0.0000634503d },
            { 2404000.0d, 0.0000614133d },
            { 2413000.0d, 0.0000594061d },
            { 2422000.0d, 0.0000574295d },
            { 2431000.0d, 0.0000554845d },
            { 2440000.0d, 0.000053572d },
            { 2449000.0d, 0.0000516923d },
            { 2458000.0d, 0.0000498455d },
            { 2467000.0d, 0.0000480327d },
            { 2476000.0d, 0.0000462547d },
            { 2485000.0d, 0.0000445123d },
            { 2494000.0d, 0.0000428066d },
            { 2503000.0d, 0.0000411386d },
            { 2512000.0d, 0.0000395087d },
            { 2521000.0d, 0.0000379129d },
            { 2530000.0d, 0.0000363498d },
            { 2539000.0d, 0.0000348201d },
            { 2548000.0d, 0.0000333248d },
            { 2557000.0d, 0.0000318637d },
            { 2566000.0d, 0.0000304363d },
            { 2575000.0d, 0.0000290434d },
            { 2584000.0d, 0.0000276856d },
            { 2593000.0d, 0.0000263628d },
            { 2602000.0d, 0.0000250673d },
            { 2611000.0d, 0.0000237966d },
            { 2620000.0d, 0.0000225514d },
            { 2629000.0d, 0.0000213325d },
            { 2638000.0d, 0.0000201404d },
            { 2647000.0d, 0.0000189757d },
            { 2656000.0d, 0.000017839d },
            { 2665000.0d, 0.000016731d },
            { 2674000.0d, 0.0000156524d },
            { 2683000.0d, 0.0000146037d },
            { 2692000.0d, 0.0000135857d },
            { 2701000.0d, 0.0000125988d },
            { 2710000.0d, 0.000011644d },
            { 2719000.0d, 0.0000107216d },
            { 2728000.0d, 0.00000983245d },
            { 2737000.0d, 0.00000897714d },
            { 2746000.0d, 0.00000815635d },
            { 2755000.0d, 0.00000737073d },
            { 2764000.0d, 0.00000662094d },
            { 2773000.0d, 0.00000590766d },
            { 2782000.0d, 0.00000523153d },
            { 2791000.0d, 0.00000459324d },
            { 2800000.0d, 0.00000399344d },
            { 2809000.0d, 0.0000034328d },
            { 2818000.0d, 0.00000291201d },
            { 2827000.0d, 0.00000243173d },
            { 2836000.0d, 0.00000199262d },
            { 2845000.0d, 0.00000159536d },
            { 2854000.0d, 0.00000124062d },
            { 2863000.0d, 0.000000929057d },
            { 2872000.0d, 0.00000066134d },
            { 2881000.0d, 0.00000043812d },
            { 2890000.0d, 0.000000260036d },
            { 2899000.0d, 0.000000127712d },
            { 2908000.0d, 0.0000000417331d },
            { 2917000.0d, 0.00000000259119d },
            { 2920000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    