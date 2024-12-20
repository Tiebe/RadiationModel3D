using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium150";
        public override double halfLife { get; } = 18.5d;
        public override double atomicWeight { get; } = 149.93792d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium150()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.024806599999999998d, new GammaParticle(130000.0, 0.00954)), new(0.0047705d, new GammaParticle(346100.0, 0.00358)), new(0.9541d, new GammaParticle(476000.0, 0.0026)), new(0.0019081999999999999d, new GammaParticle(663300.0, 0.00187)), new(0.0085869d, new GammaParticle(1014000.0, 0.00122)), new(0.0085869d, new GammaParticle(1022100.0, 0.00121)), new(0.0047705d, new GammaParticle(1151900.0, 0.00108)), new(0.0028623d, new GammaParticle(1177100.0, 0.00105)), new(0.0019081999999999999d, new GammaParticle(1320500.0, 0.00094)), new(0.0028623d, new GammaParticle(1450900.0, 0.00085)), new(0.0038163999999999997d, new GammaParticle(1490400.0, 0.00083)), new(0.79732d, new GammaParticle(511000.0, 0.00243)), new(0.10430066991509608d, new GammaParticle(7656.0, 0.16194)), new(0.13678089468307103d, new GammaParticle(46700.0, 0.02655)), new(0.24359910005889765d, new GammaParticle(47547.0, 0.02608)), new(0.07870243224542162d, new GammaParticle(53982.0, 0.02297)), new(0.09916506462923123d, new GammaParticle(54577.0, 0.02272)), new(0.02046263238380962d, new GammaParticle(55293.0, 0.02242)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 5000.0d, 0.000000000923229d },
            { 10000.0d, 0.0000000483718d },
            { 15000.0d, 0.000000143177d },
            { 20000.0d, 0.000000320476d },
            { 25000.0d, 0.000000591261d },
            { 30000.0d, 0.000000973898d },
            { 35000.0d, 0.00000146679d },
            { 40000.0d, 0.00000207397d },
            { 45000.0d, 0.00000279186d },
            { 50000.0d, 0.00000361823d },
            { 55000.0d, 0.00000454746d },
            { 60000.0d, 0.00000557311d },
            { 65000.0d, 0.00000669185d },
            { 70000.0d, 0.00000789421d },
            { 75000.0d, 0.00000917693d },
            { 80000.0d, 0.0000105345d },
            { 85000.0d, 0.0000119577d },
            { 90000.0d, 0.0000134458d },
            { 95000.0d, 0.0000149913d },
            { 100000.0d, 0.0000165897d },
            { 109000.0d, 0.0000195884d },
            { 118000.0d, 0.000022723d },
            { 127000.0d, 0.0000259735d },
            { 136000.0d, 0.000029322d },
            { 145000.0d, 0.0000327525d },
            { 154000.0d, 0.000036252d },
            { 163000.0d, 0.0000398087d },
            { 172000.0d, 0.0000434123d },
            { 181000.0d, 0.0000470536d },
            { 190000.0d, 0.0000507245d },
            { 199000.0d, 0.0000544181d },
            { 208000.0d, 0.0000581279d },
            { 217000.0d, 0.0000618483d },
            { 226000.0d, 0.0000655745d },
            { 235000.0d, 0.0000693021d },
            { 244000.0d, 0.000073027d },
            { 253000.0d, 0.0000767459d },
            { 262000.0d, 0.0000804555d },
            { 271000.0d, 0.0000841529d },
            { 280000.0d, 0.0000878355d },
            { 289000.0d, 0.0000915008d },
            { 298000.0d, 0.0000951469d },
            { 307000.0d, 0.0000987718d },
            { 316000.0d, 0.000102374d },
            { 325000.0d, 0.000105951d },
            { 334000.0d, 0.000109502d },
            { 343000.0d, 0.000113025d },
            { 352000.0d, 0.00011652d },
            { 361000.0d, 0.000119985d },
            { 370000.0d, 0.000123418d },
            { 379000.0d, 0.00012682d },
            { 388000.0d, 0.000130188d },
            { 397000.0d, 0.000133523d },
            { 406000.0d, 0.000136824d },
            { 415000.0d, 0.000140089d },
            { 424000.0d, 0.000143317d },
            { 433000.0d, 0.000146508d },
            { 442000.0d, 0.000149663d },
            { 451000.0d, 0.000152779d },
            { 460000.0d, 0.000155857d },
            { 469000.0d, 0.000158896d },
            { 478000.0d, 0.000161895d },
            { 487000.0d, 0.000164854d },
            { 496000.0d, 0.000167773d },
            { 505000.0d, 0.000170652d },
            { 514000.0d, 0.000173489d },
            { 523000.0d, 0.000176284d },
            { 532000.0d, 0.000179036d },
            { 541000.0d, 0.000181748d },
            { 550000.0d, 0.000184416d },
            { 559000.0d, 0.000187042d },
            { 568000.0d, 0.000189625d },
            { 577000.0d, 0.000192163d },
            { 586000.0d, 0.00019466d },
            { 595000.0d, 0.000197111d },
            { 604000.0d, 0.000199519d },
            { 613000.0d, 0.000201882d },
            { 622000.0d, 0.000204202d },
            { 631000.0d, 0.000206476d },
            { 640000.0d, 0.000208705d },
            { 649000.0d, 0.00021089d },
            { 658000.0d, 0.000213031d },
            { 667000.0d, 0.000215125d },
            { 676000.0d, 0.000217174d },
            { 685000.0d, 0.000219178d },
            { 694000.0d, 0.000221136d },
            { 703000.0d, 0.000223048d },
            { 712000.0d, 0.000224915d },
            { 721000.0d, 0.000226736d },
            { 730000.0d, 0.000228512d },
            { 739000.0d, 0.00023024d },
            { 748000.0d, 0.000231924d },
            { 757000.0d, 0.000233561d },
            { 766000.0d, 0.000235153d },
            { 775000.0d, 0.000236698d },
            { 784000.0d, 0.000238196d },
            { 793000.0d, 0.000239649d },
            { 802000.0d, 0.000241056d },
            { 811000.0d, 0.000242417d },
            { 820000.0d, 0.000243731d },
            { 829000.0d, 0.000245d },
            { 838000.0d, 0.000246222d },
            { 847000.0d, 0.000247399d },
            { 856000.0d, 0.000248529d },
            { 865000.0d, 0.000249614d },
            { 874000.0d, 0.000250652d },
            { 883000.0d, 0.000251645d },
            { 892000.0d, 0.000252592d },
            { 901000.0d, 0.000253494d },
            { 910000.0d, 0.000254349d },
            { 919000.0d, 0.000255159d },
            { 928000.0d, 0.000255925d },
            { 937000.0d, 0.000256644d },
            { 946000.0d, 0.000257319d },
            { 955000.0d, 0.000257949d },
            { 964000.0d, 0.000258533d },
            { 973000.0d, 0.000259073d },
            { 982000.0d, 0.000259568d },
            { 991000.0d, 0.000260018d },
            { 1000000.0d, 0.000260425d },
            { 1009000.0d, 0.000260786d },
            { 1018000.0d, 0.000261104d },
            { 1027000.0d, 0.000261378d },
            { 1036000.0d, 0.000261609d },
            { 1045000.0d, 0.000261795d },
            { 1054000.0d, 0.000261938d },
            { 1063000.0d, 0.000262039d },
            { 1072000.0d, 0.000262097d },
            { 1081000.0d, 0.000262111d },
            { 1090000.0d, 0.000262083d },
            { 1099000.0d, 0.000262013d },
            { 1108000.0d, 0.000261901d },
            { 1117000.0d, 0.000261747d },
            { 1126000.0d, 0.000261551d },
            { 1135000.0d, 0.000261313d },
            { 1144000.0d, 0.000261036d },
            { 1153000.0d, 0.000260717d },
            { 1162000.0d, 0.000260356d },
            { 1171000.0d, 0.000259957d },
            { 1180000.0d, 0.000259517d },
            { 1189000.0d, 0.000259037d },
            { 1198000.0d, 0.000258517d },
            { 1207000.0d, 0.000257959d },
            { 1216000.0d, 0.000257361d },
            { 1225000.0d, 0.000256725d },
            { 1234000.0d, 0.000256052d },
            { 1243000.0d, 0.000255339d },
            { 1252000.0d, 0.000254589d },
            { 1261000.0d, 0.000253802d },
            { 1270000.0d, 0.000252977d },
            { 1279000.0d, 0.000252117d },
            { 1288000.0d, 0.00025122d },
            { 1297000.0d, 0.000250286d },
            { 1306000.0d, 0.000249318d },
            { 1315000.0d, 0.000248314d },
            { 1324000.0d, 0.000247275d },
            { 1333000.0d, 0.000246203d },
            { 1342000.0d, 0.000245095d },
            { 1351000.0d, 0.000243955d },
            { 1360000.0d, 0.00024278d },
            { 1369000.0d, 0.000241573d },
            { 1378000.0d, 0.000240333d },
            { 1387000.0d, 0.000239062d },
            { 1396000.0d, 0.000237758d },
            { 1405000.0d, 0.000236423d },
            { 1414000.0d, 0.000235057d },
            { 1423000.0d, 0.000233661d },
            { 1432000.0d, 0.000232236d },
            { 1441000.0d, 0.00023078d },
            { 1450000.0d, 0.000229296d },
            { 1459000.0d, 0.000227783d },
            { 1468000.0d, 0.000226242d },
            { 1477000.0d, 0.000224672d },
            { 1486000.0d, 0.000223076d },
            { 1495000.0d, 0.000221453d },
            { 1504000.0d, 0.000219804d },
            { 1513000.0d, 0.000218129d },
            { 1522000.0d, 0.00021643d },
            { 1531000.0d, 0.000214704d },
            { 1540000.0d, 0.000212955d },
            { 1549000.0d, 0.000211182d },
            { 1558000.0d, 0.000209387d },
            { 1567000.0d, 0.000207568d },
            { 1576000.0d, 0.000205727d },
            { 1585000.0d, 0.000203864d },
            { 1594000.0d, 0.00020198d },
            { 1603000.0d, 0.000200076d },
            { 1612000.0d, 0.000198151d },
            { 1621000.0d, 0.000196206d },
            { 1630000.0d, 0.00019424d },
            { 1639000.0d, 0.000192255d },
            { 1648000.0d, 0.000190251d },
            { 1657000.0d, 0.000188228d },
            { 1666000.0d, 0.000186187d },
            { 1675000.0d, 0.000184128d },
            { 1684000.0d, 0.000182052d },
            { 1693000.0d, 0.000179959d },
            { 1702000.0d, 0.00017785d },
            { 1711000.0d, 0.000175726d },
            { 1720000.0d, 0.000173587d },
            { 1729000.0d, 0.000171433d },
            { 1738000.0d, 0.000169265d },
            { 1747000.0d, 0.000167085d },
            { 1756000.0d, 0.000164892d },
            { 1765000.0d, 0.000162687d },
            { 1774000.0d, 0.00016047d },
            { 1783000.0d, 0.000158243d },
            { 1792000.0d, 0.000156006d },
            { 1801000.0d, 0.00015376d },
            { 1810000.0d, 0.000151504d },
            { 1819000.0d, 0.00014924d },
            { 1828000.0d, 0.000146968d },
            { 1837000.0d, 0.000144691d },
            { 1846000.0d, 0.000142406d },
            { 1855000.0d, 0.000140115d },
            { 1864000.0d, 0.00013782d },
            { 1873000.0d, 0.00013552d },
            { 1882000.0d, 0.000133217d },
            { 1891000.0d, 0.000130911d },
            { 1900000.0d, 0.000128603d },
            { 1909000.0d, 0.000126293d },
            { 1918000.0d, 0.000123982d },
            { 1927000.0d, 0.00012167d },
            { 1936000.0d, 0.000119359d },
            { 1945000.0d, 0.00011705d },
            { 1954000.0d, 0.00011474d },
            { 1963000.0d, 0.000112433d },
            { 1972000.0d, 0.000110128d },
            { 1981000.0d, 0.000107824d },
            { 1990000.0d, 0.000105526d },
            { 1999000.0d, 0.000103231d },
            { 2008000.0d, 0.000100941d },
            { 2017000.0d, 0.0000986569d },
            { 2026000.0d, 0.0000963792d },
            { 2035000.0d, 0.0000941085d },
            { 2044000.0d, 0.0000918458d },
            { 2053000.0d, 0.0000895916d },
            { 2062000.0d, 0.0000873468d },
            { 2071000.0d, 0.000085112d },
            { 2080000.0d, 0.0000828881d },
            { 2089000.0d, 0.0000806758d },
            { 2098000.0d, 0.000078476d },
            { 2107000.0d, 0.0000762892d },
            { 2116000.0d, 0.0000741163d },
            { 2125000.0d, 0.0000719581d },
            { 2134000.0d, 0.0000698154d },
            { 2143000.0d, 0.0000676889d },
            { 2152000.0d, 0.0000655795d },
            { 2161000.0d, 0.0000634879d },
            { 2170000.0d, 0.000061415d },
            { 2179000.0d, 0.0000593615d },
            { 2188000.0d, 0.0000573282d },
            { 2197000.0d, 0.000055316d },
            { 2206000.0d, 0.0000533257d },
            { 2215000.0d, 0.000051358d },
            { 2224000.0d, 0.0000494139d },
            { 2233000.0d, 0.0000474941d },
            { 2242000.0d, 0.0000455996d },
            { 2251000.0d, 0.0000437311d },
            { 2260000.0d, 0.0000418894d },
            { 2269000.0d, 0.0000400756d },
            { 2278000.0d, 0.0000382903d },
            { 2287000.0d, 0.0000365344d },
            { 2296000.0d, 0.0000348087d },
            { 2305000.0d, 0.0000331144d },
            { 2314000.0d, 0.000031452d },
            { 2323000.0d, 0.0000298225d },
            { 2332000.0d, 0.0000282269d },
            { 2341000.0d, 0.0000266659d },
            { 2350000.0d, 0.0000251404d },
            { 2359000.0d, 0.0000236514d },
            { 2368000.0d, 0.0000221998d },
            { 2377000.0d, 0.0000207864d },
            { 2386000.0d, 0.0000194122d },
            { 2395000.0d, 0.000018078d },
            { 2404000.0d, 0.0000167848d },
            { 2413000.0d, 0.0000155335d },
            { 2422000.0d, 0.0000143249d },
            { 2431000.0d, 0.00001316d },
            { 2440000.0d, 0.0000120398d },
            { 2449000.0d, 0.0000109652d },
            { 2458000.0d, 0.00000993712d },
            { 2467000.0d, 0.00000895644d },
            { 2476000.0d, 0.00000802412d },
            { 2485000.0d, 0.0000071411d },
            { 2494000.0d, 0.00000630832d },
            { 2503000.0d, 0.00000552673d },
            { 2512000.0d, 0.00000479725d },
            { 2521000.0d, 0.0000041209d },
            { 2530000.0d, 0.00000349857d },
            { 2539000.0d, 0.0000029312d },
            { 2548000.0d, 0.00000241973d },
            { 2557000.0d, 0.00000196512d },
            { 2566000.0d, 0.00000156829d },
            { 2575000.0d, 0.00000123017d },
            { 2584000.0d, 0.000000951678d },
            { 2593000.0d, 0.000000733745d },
            { 2602000.0d, 0.000000577198d },
            { 2611000.0d, 0.00000048281d },
            { 2620000.0d, 0.000000447599d },
            { 2629000.0d, 0.00000042659d },
            { 2638000.0d, 0.000000405967d },
            { 2647000.0d, 0.000000385742d },
            { 2656000.0d, 0.00000036592d },
            { 2665000.0d, 0.000000346513d },
            { 2674000.0d, 0.000000327529d },
            { 2683000.0d, 0.000000308978d },
            { 2692000.0d, 0.000000290868d },
            { 2701000.0d, 0.00000027321d },
            { 2710000.0d, 0.000000256011d },
            { 2719000.0d, 0.000000239283d },
            { 2728000.0d, 0.000000223034d },
            { 2737000.0d, 0.000000207272d },
            { 2746000.0d, 0.000000192009d },
            { 2755000.0d, 0.000000177254d },
            { 2764000.0d, 0.000000163015d },
            { 2773000.0d, 0.000000149303d },
            { 2782000.0d, 0.000000136126d },
            { 2791000.0d, 0.000000123496d },
            { 2800000.0d, 0.00000011142d },
            { 2809000.0d, 0.0000000999094d },
            { 2818000.0d, 0.0000000889731d },
            { 2827000.0d, 0.0000000786211d },
            { 2836000.0d, 0.000000068863d },
            { 2845000.0d, 0.0000000597084d },
            { 2854000.0d, 0.0000000511671d },
            { 2863000.0d, 0.0000000432488d },
            { 2872000.0d, 0.0000000359633d },
            { 2881000.0d, 0.0000000293202d },
            { 2890000.0d, 0.0000000233291d },
            { 2899000.0d, 0.0000000179998d },
            { 2908000.0d, 0.0000000133418d },
            { 2917000.0d, 0.00000000936443d },
            { 2926000.0d, 0.00000000607725d },
            { 2935000.0d, 0.00000000348934d },
            { 2944000.0d, 0.00000000160946d },
            { 2953000.0d, 0.000000000445713d },
            { 2962000.0d, 0.00000000000436807d },
            { 2963000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    