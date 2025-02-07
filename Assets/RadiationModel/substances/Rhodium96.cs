using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium96";
        public override double halfLife { get; } = 594.0d;
        public override double atomicWeight { get; } = 95.91445d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium96()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0019d, new GammaParticle(237900.0, 0.00521)), new(0.0024d, new GammaParticle(300700.0, 0.00412)), new(0.0001d, new GammaParticle(366300.0, 0.00338)), new(0.0016d, new GammaParticle(380400.0, 0.00326)), new(0.0013d, new GammaParticle(400000.0, 0.0031)), new(0.0013d, new GammaParticle(400000.0, 0.0031)), new(0.0062d, new GammaParticle(415200.0, 0.00299)), new(0.0062d, new GammaParticle(415200.0, 0.00299)), new(0.005d, new GammaParticle(421800.0, 0.00294)), new(0.0207d, new GammaParticle(430180.0, 0.00288)), new(6.6e-05d, new GammaParticle(435300.0, 0.00285)), new(0.0016d, new GammaParticle(471700.0, 0.00263)), new(0.005d, new GammaParticle(485900.0, 0.00255)), new(0.0039000000000000003d, new GammaParticle(488900.0, 0.00254)), new(0.00029d, new GammaParticle(531200.0, 0.00233)), new(0.015300000000000001d, new GammaParticle(586620.0, 0.00211)), new(0.0015d, new GammaParticle(594100.0, 0.00209)), new(0.005699999999999999d, new GammaParticle(594100.0, 0.00209)), new(0.00043999999999999996d, new GammaParticle(613800.0, 0.00202)), new(0.745d, new GammaParticle(631730.0, 0.00196)), new(0.045700000000000005d, new GammaParticle(644160.0, 0.00192)), new(0.0024d, new GammaParticle(657500.0, 0.00189)), new(0.9570000000000001d, new GammaParticle(685470.0, 0.00181)), new(0.0026d, new GammaParticle(693100.0, 0.00179)), new(0.0009d, new GammaParticle(699500.0, 0.00177)), new(7.000000000000001e-05d, new GammaParticle(718500.0, 0.00173)), new(0.294d, new GammaParticle(741870.0, 0.00167)), new(0.002d, new GammaParticle(766800.0, 0.00162)), new(0.0332d, new GammaParticle(800700.0, 0.00155)), new(1.0d, new GammaParticle(832520.0, 0.00149)), new(0.0048d, new GammaParticle(852300.0, 0.00145)), new(0.0013d, new GammaParticle(863500.0, 0.00144)), new(0.0038d, new GammaParticle(890000.0, 0.00139)), new(0.0025d, new GammaParticle(912200.0, 0.00136)), new(0.0103d, new GammaParticle(915200.0, 0.00135)), new(0.024300000000000002d, new GammaParticle(944070.0, 0.00131)), new(0.0022d, new GammaParticle(966800.0, 0.00128)), new(0.0079d, new GammaParticle(995500.0, 0.00125)), new(0.0028000000000000004d, new GammaParticle(1006500.0, 0.00123)), new(0.002d, new GammaParticle(1011400.0, 0.00123)), new(0.0018d, new GammaParticle(1016800.0, 0.00122)), new(0.0032d, new GammaParticle(1048000.0, 0.00118)), new(0.0183d, new GammaParticle(1070350.0, 0.00116)), new(0.0052d, new GammaParticle(1098200.0, 0.00113)), new(0.00037d, new GammaParticle(1131900.0, 0.0011)), new(0.004d, new GammaParticle(1157000.0, 0.00107)), new(0.0034000000000000002d, new GammaParticle(1162900.0, 0.00107)), new(0.0058d, new GammaParticle(1188600.0, 0.00104)), new(0.0019d, new GammaParticle(1212800.0, 0.00102)), new(0.078d, new GammaParticle(1227850.0, 0.00101)), new(0.07200000000000001d, new GammaParticle(1230660.0, 0.00101)), new(0.0129d, new GammaParticle(1242140.0, 0.001)), new(0.0031d, new GammaParticle(1269100.0, 0.00098)), new(0.030699999999999998d, new GammaParticle(1275760.0, 0.00097)), new(0.0025d, new GammaParticle(1286400.0, 0.00096)), new(0.005d, new GammaParticle(1367800.0, 0.00091)), new(0.0014000000000000002d, new GammaParticle(1379500.0, 0.0009)), new(0.0027d, new GammaParticle(1394700.0, 0.00089)), new(0.0011d, new GammaParticle(1400500.0, 0.00089)), new(0.0007000000000000001d, new GammaParticle(1450500.0, 0.00085)), new(0.0043d, new GammaParticle(1470200.0, 0.00084)), new(0.0007000000000000001d, new GammaParticle(1525200.0, 0.00081)), new(0.0192d, new GammaParticle(1556720.0, 0.0008)), new(0.0096d, new GammaParticle(1559000.0, 0.0008)), new(0.0034999999999999996d, new GammaParticle(1593100.0, 0.00078)), new(0.0265d, new GammaParticle(1605400.0, 0.00077)), new(0.0036d, new GammaParticle(1642700.0, 0.00075)), new(0.0206d, new GammaParticle(1648660.0, 0.00075)), new(0.0038d, new GammaParticle(1656000.0, 0.00075)), new(0.0216d, new GammaParticle(1692300.0, 0.00073)), new(0.0026d, new GammaParticle(1701100.0, 0.00073)), new(0.0447d, new GammaParticle(1737450.0, 0.00071)), new(0.0044d, new GammaParticle(1743100.0, 0.00071)), new(0.0021d, new GammaParticle(1758200.0, 0.00071)), new(0.0016d, new GammaParticle(1773400.0, 0.0007)), new(0.0196d, new GammaParticle(1788600.0, 0.00069)), new(0.004699999999999999d, new GammaParticle(1800700.0, 0.00069)), new(0.0019d, new GammaParticle(1817500.0, 0.00068)), new(0.0161d, new GammaParticle(1859700.0, 0.00067)), new(0.0036d, new GammaParticle(1885700.0, 0.00066)), new(0.0038d, new GammaParticle(1907800.0, 0.00065)), new(0.00031d, new GammaParticle(1930900.0, 0.00064)), new(0.0127d, new GammaParticle(1963190.0, 0.00063)), new(0.0022d, new GammaParticle(1991100.0, 0.00062)), new(0.0092d, new GammaParticle(1996160.0, 0.00062)), new(0.00021999999999999998d, new GammaParticle(1998400.0, 0.00062)), new(0.0012d, new GammaParticle(2052400.0, 0.0006)), new(0.0028000000000000004d, new GammaParticle(2059200.0, 0.0006)), new(0.00067d, new GammaParticle(2061200.0, 0.0006)), new(0.00043999999999999996d, new GammaParticle(2064700.0, 0.0006)), new(0.0011d, new GammaParticle(2075000.0, 0.0006)), new(0.0015d, new GammaParticle(2121000.0, 0.00058)), new(0.0014000000000000002d, new GammaParticle(2143100.0, 0.00058)), new(0.00065d, new GammaParticle(2149600.0, 0.00058)), new(0.0076d, new GammaParticle(2163900.0, 0.00057)), new(0.003d, new GammaParticle(2196900.0, 0.00056)), new(0.0013d, new GammaParticle(2203000.0, 0.00056)), new(0.0023d, new GammaParticle(2224800.0, 0.00056)), new(0.0025d, new GammaParticle(2252700.0, 0.00055)), new(0.0012d, new GammaParticle(2264900.0, 0.00055)), new(0.0008d, new GammaParticle(2290500.0, 0.00054)), new(0.0016d, new GammaParticle(2361500.0, 0.00053)), new(0.0022d, new GammaParticle(2402400.0, 0.00052)), new(0.0012d, new GammaParticle(2424900.0, 0.00051)), new(0.0036d, new GammaParticle(2459100.0, 0.0005)), new(0.0013d, new GammaParticle(2500900.0, 0.0005)), new(0.0016d, new GammaParticle(2508700.0, 0.00049)), new(0.0029d, new GammaParticle(2525600.0, 0.00049)), new(0.002d, new GammaParticle(2534500.0, 0.00049)), new(0.0046d, new GammaParticle(2539200.0, 0.00049)), new(0.0011d, new GammaParticle(2628000.0, 0.00047)), new(0.0013d, new GammaParticle(2698500.0, 0.00046)), new(0.001d, new GammaParticle(2800000.0, 0.00044)), new(0.0016d, new GammaParticle(2962000.0, 0.00042)), new(0.0021d, new GammaParticle(3073400.0, 0.0004)), new(0.0015d, new GammaParticle(3220500.0, 0.00038)), new(0.002d, new GammaParticle(3261500.0, 0.00038)), new(0.002d, new GammaParticle(3431500.0, 0.00036)), new(1.2933649299999999d, new GammaParticle(511000.0, 0.00243)), new(0.0129293934628908d, new GammaParticle(2737.0, 0.45299)), new(0.057959819327365006d, new GammaParticle(19150.0, 0.06474)), new(0.10998068183560722d, new GammaParticle(19279.0, 0.06431)), new(0.029555793879369893d, new GammaParticle(21736.0, 0.05704)), new(0.03434383248782782d, new GammaParticle(21875.0, 0.05668)), new(0.004788038608457923d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 1000.0d, 0.000000000155019d },
            { 2000.0d, 0.0000000010402d },
            { 3000.0d, 0.00000000707627d },
            { 4000.0d, 0.0000000310005d },
            { 5000.0d, 0.000000080574d },
            { 6000.0d, 0.000000149074d },
            { 7000.0d, 0.000000235534d },
            { 8000.0d, 0.0000003399d },
            { 9000.0d, 0.000000465099d },
            { 10000.0d, 0.000000609492d },
            { 11000.0d, 0.000000775581d },
            { 12000.0d, 0.000000961754d },
            { 13000.0d, 0.00000117618d },
            { 14000.0d, 0.00000141318d },
            { 15000.0d, 0.00000167335d },
            { 16000.0d, 0.00000195681d },
            { 17000.0d, 0.00000226872d },
            { 18000.0d, 0.00000260477d },
            { 19000.0d, 0.00000296537d },
            { 20000.0d, 0.00000335015d },
            { 21000.0d, 0.00000375868d },
            { 22000.0d, 0.00000419095d },
            { 23000.0d, 0.00000464699d },
            { 24000.0d, 0.00000512679d },
            { 25000.0d, 0.00000562373d },
            { 26000.0d, 0.00000614181d },
            { 27000.0d, 0.00000668146d },
            { 28000.0d, 0.00000724231d },
            { 29000.0d, 0.00000782339d },
            { 30000.0d, 0.00000842546d },
            { 31000.0d, 0.000009043d },
            { 32000.0d, 0.00000967997d },
            { 33000.0d, 0.0000103304d },
            { 34000.0d, 0.0000109987d },
            { 35000.0d, 0.0000116848d },
            { 36000.0d, 0.0000123874d },
            { 37000.0d, 0.0000131029d },
            { 38000.0d, 0.0000138344d },
            { 39000.0d, 0.0000145819d },
            { 40000.0d, 0.0000153452d },
            { 41000.0d, 0.000016117d },
            { 42000.0d, 0.0000169028d },
            { 43000.0d, 0.0000176993d },
            { 44000.0d, 0.0000185089d },
            { 45000.0d, 0.0000193308d },
            { 46000.0d, 0.0000201645d },
            { 47000.0d, 0.0000210105d },
            { 48000.0d, 0.0000218688d },
            { 49000.0d, 0.0000227326d },
            { 50000.0d, 0.0000236066d },
            { 51000.0d, 0.0000244895d },
            { 52000.0d, 0.0000253823d },
            { 53000.0d, 0.0000262846d },
            { 54000.0d, 0.0000271967d },
            { 55000.0d, 0.0000281162d },
            { 56000.0d, 0.0000290443d },
            { 57000.0d, 0.0000299775d },
            { 58000.0d, 0.0000309187d },
            { 59000.0d, 0.0000318678d },
            { 60000.0d, 0.0000328248d },
            { 61000.0d, 0.0000337865d },
            { 62000.0d, 0.0000347551d },
            { 63000.0d, 0.0000357306d },
            { 64000.0d, 0.0000367127d },
            { 65000.0d, 0.0000376988d },
            { 66000.0d, 0.0000386908d },
            { 67000.0d, 0.0000396873d },
            { 68000.0d, 0.0000406894d },
            { 69000.0d, 0.0000416967d },
            { 70000.0d, 0.0000427095d },
            { 71000.0d, 0.0000437267d },
            { 72000.0d, 0.0000447491d },
            { 73000.0d, 0.0000457732d },
            { 74000.0d, 0.0000468016d },
            { 75000.0d, 0.0000478342d },
            { 76000.0d, 0.0000488708d },
            { 77000.0d, 0.0000499113d },
            { 78000.0d, 0.0000509557d },
            { 79000.0d, 0.0000520032d },
            { 80000.0d, 0.0000530544d },
            { 81000.0d, 0.000054107d },
            { 82000.0d, 0.0000551626d },
            { 83000.0d, 0.0000562214d },
            { 84000.0d, 0.0000572832d },
            { 85000.0d, 0.0000583471d },
            { 86000.0d, 0.0000594136d },
            { 87000.0d, 0.0000604827d },
            { 88000.0d, 0.0000615545d },
            { 89000.0d, 0.0000626277d },
            { 90000.0d, 0.0000637033d },
            { 91000.0d, 0.0000647799d },
            { 92000.0d, 0.0000658585d },
            { 93000.0d, 0.000066939d },
            { 94000.0d, 0.0000680214d },
            { 95000.0d, 0.0000691058d },
            { 96000.0d, 0.0000701919d },
            { 97000.0d, 0.0000712783d },
            { 98000.0d, 0.0000723661d },
            { 99000.0d, 0.0000734554d },
            { 100000.0d, 0.000074546d },
            { 110000.0d, 0.0000855009d },
            { 120000.0d, 0.0000965053d },
            { 130000.0d, 0.000107511d },
            { 140000.0d, 0.000118482d },
            { 150000.0d, 0.000129391d },
            { 160000.0d, 0.000140215d },
            { 170000.0d, 0.000150939d },
            { 180000.0d, 0.000161547d },
            { 190000.0d, 0.000172029d },
            { 200000.0d, 0.000182376d },
            { 210000.0d, 0.000192582d },
            { 220000.0d, 0.000202639d },
            { 230000.0d, 0.000212545d },
            { 240000.0d, 0.000222295d },
            { 250000.0d, 0.000231886d },
            { 260000.0d, 0.000241315d },
            { 270000.0d, 0.000250581d },
            { 280000.0d, 0.000259681d },
            { 290000.0d, 0.000268616d },
            { 300000.0d, 0.000277382d },
            { 310000.0d, 0.000285981d },
            { 320000.0d, 0.000294411d },
            { 330000.0d, 0.000302672d },
            { 340000.0d, 0.000310764d },
            { 350000.0d, 0.000318686d },
            { 360000.0d, 0.00032644d },
            { 370000.0d, 0.000334025d },
            { 380000.0d, 0.000341442d },
            { 390000.0d, 0.000348691d },
            { 400000.0d, 0.000355773d },
            { 410000.0d, 0.000362688d },
            { 420000.0d, 0.000369437d },
            { 430000.0d, 0.00037602d },
            { 440000.0d, 0.000382432d },
            { 450000.0d, 0.000388674d },
            { 460000.0d, 0.000394749d },
            { 470000.0d, 0.000400654d },
            { 480000.0d, 0.000406393d },
            { 490000.0d, 0.000411964d },
            { 500000.0d, 0.00041737d },
            { 510000.0d, 0.000422612d },
            { 520000.0d, 0.00042769d },
            { 530000.0d, 0.000432605d },
            { 540000.0d, 0.000437358d },
            { 550000.0d, 0.000441953d },
            { 560000.0d, 0.000446389d },
            { 570000.0d, 0.000450668d },
            { 580000.0d, 0.000454792d },
            { 590000.0d, 0.000458761d },
            { 600000.0d, 0.000462576d },
            { 610000.0d, 0.000466229d },
            { 620000.0d, 0.000469718d },
            { 630000.0d, 0.000473046d },
            { 640000.0d, 0.000476213d },
            { 650000.0d, 0.00047922d },
            { 660000.0d, 0.000482069d },
            { 670000.0d, 0.000484761d },
            { 680000.0d, 0.000487298d },
            { 690000.0d, 0.00048968d },
            { 700000.0d, 0.000491909d },
            { 710000.0d, 0.000493986d },
            { 720000.0d, 0.000495914d },
            { 730000.0d, 0.000497694d },
            { 740000.0d, 0.000499328d },
            { 750000.0d, 0.000500816d },
            { 760000.0d, 0.000502163d },
            { 770000.0d, 0.000503367d },
            { 780000.0d, 0.000504434d },
            { 790000.0d, 0.000505361d },
            { 800000.0d, 0.000506151d },
            { 810000.0d, 0.000506806d },
            { 820000.0d, 0.000507324d },
            { 830000.0d, 0.000507703d },
            { 840000.0d, 0.000507945d },
            { 850000.0d, 0.000508052d },
            { 860000.0d, 0.000508022d },
            { 870000.0d, 0.000507851d },
            { 880000.0d, 0.000507541d },
            { 890000.0d, 0.000507094d },
            { 900000.0d, 0.000506512d },
            { 910000.0d, 0.000505796d },
            { 920000.0d, 0.000504948d },
            { 930000.0d, 0.000503971d },
            { 940000.0d, 0.000502864d },
            { 950000.0d, 0.000501632d },
            { 960000.0d, 0.000500276d },
            { 970000.0d, 0.000498797d },
            { 980000.0d, 0.000497199d },
            { 990000.0d, 0.000495483d },
            { 1000000.0d, 0.000493651d },
            { 1010000.0d, 0.000491707d },
            { 1020000.0d, 0.000489651d },
            { 1030000.0d, 0.000487487d },
            { 1040000.0d, 0.000485216d },
            { 1050000.0d, 0.000482843d },
            { 1060000.0d, 0.000480368d },
            { 1070000.0d, 0.000477795d },
            { 1080000.0d, 0.000475125d },
            { 1090000.0d, 0.000472365d },
            { 1100000.0d, 0.000469512d },
            { 1110000.0d, 0.000466572d },
            { 1120000.0d, 0.000463547d },
            { 1130000.0d, 0.000460441d },
            { 1140000.0d, 0.000457256d },
            { 1150000.0d, 0.000453995d },
            { 1160000.0d, 0.000450661d },
            { 1170000.0d, 0.000447257d },
            { 1180000.0d, 0.000443785d },
            { 1190000.0d, 0.00044025d },
            { 1200000.0d, 0.000436652d },
            { 1210000.0d, 0.000432997d },
            { 1220000.0d, 0.000429288d },
            { 1230000.0d, 0.000425528d },
            { 1240000.0d, 0.000421719d },
            { 1250000.0d, 0.000417866d },
            { 1260000.0d, 0.000413971d },
            { 1270000.0d, 0.000410032d },
            { 1280000.0d, 0.000406046d },
            { 1290000.0d, 0.000402018d },
            { 1300000.0d, 0.000397949d },
            { 1310000.0d, 0.000393837d },
            { 1320000.0d, 0.000389685d },
            { 1330000.0d, 0.000385492d },
            { 1340000.0d, 0.00038126d },
            { 1350000.0d, 0.000376993d },
            { 1360000.0d, 0.000372694d },
            { 1370000.0d, 0.000368366d },
            { 1380000.0d, 0.000364012d },
            { 1390000.0d, 0.000359636d },
            { 1400000.0d, 0.000355242d },
            { 1410000.0d, 0.000350831d },
            { 1420000.0d, 0.000346408d },
            { 1430000.0d, 0.000341976d },
            { 1440000.0d, 0.000337538d },
            { 1450000.0d, 0.000333099d },
            { 1460000.0d, 0.000328661d },
            { 1470000.0d, 0.000324229d },
            { 1480000.0d, 0.000319805d },
            { 1490000.0d, 0.000315388d },
            { 1500000.0d, 0.000310962d },
            { 1510000.0d, 0.000306527d },
            { 1520000.0d, 0.000302085d },
            { 1530000.0d, 0.000297641d },
            { 1540000.0d, 0.000293196d },
            { 1550000.0d, 0.000288754d },
            { 1560000.0d, 0.000284318d },
            { 1570000.0d, 0.000279891d },
            { 1580000.0d, 0.000275473d },
            { 1590000.0d, 0.000271067d },
            { 1600000.0d, 0.000266676d },
            { 1610000.0d, 0.000262304d },
            { 1620000.0d, 0.000257953d },
            { 1630000.0d, 0.000253614d },
            { 1640000.0d, 0.000249286d },
            { 1650000.0d, 0.00024497d },
            { 1660000.0d, 0.00024067d },
            { 1670000.0d, 0.000236385d },
            { 1680000.0d, 0.000232107d },
            { 1690000.0d, 0.000227839d },
            { 1700000.0d, 0.000223581d },
            { 1710000.0d, 0.000219338d },
            { 1720000.0d, 0.000215112d },
            { 1730000.0d, 0.000210904d },
            { 1740000.0d, 0.000206719d },
            { 1750000.0d, 0.000202557d },
            { 1760000.0d, 0.000198423d },
            { 1770000.0d, 0.000194319d },
            { 1780000.0d, 0.000190248d },
            { 1790000.0d, 0.000186212d },
            { 1800000.0d, 0.000182214d },
            { 1810000.0d, 0.000178257d },
            { 1820000.0d, 0.000174344d },
            { 1830000.0d, 0.000170477d },
            { 1840000.0d, 0.000166658d },
            { 1850000.0d, 0.000162889d },
            { 1860000.0d, 0.000159173d },
            { 1870000.0d, 0.000155513d },
            { 1880000.0d, 0.000151912d },
            { 1890000.0d, 0.000148372d },
            { 1900000.0d, 0.000144898d },
            { 1910000.0d, 0.000141491d },
            { 1920000.0d, 0.000138154d },
            { 1930000.0d, 0.000134892d },
            { 1940000.0d, 0.000131706d },
            { 1950000.0d, 0.0001286d },
            { 1960000.0d, 0.000125577d },
            { 1970000.0d, 0.00012264d },
            { 1980000.0d, 0.000119791d },
            { 1990000.0d, 0.000117035d },
            { 2000000.0d, 0.000114343d },
            { 2010000.0d, 0.000111671d },
            { 2020000.0d, 0.000109019d },
            { 2030000.0d, 0.000106388d },
            { 2040000.0d, 0.000103779d },
            { 2050000.0d, 0.000101194d },
            { 2060000.0d, 0.0000986347d },
            { 2070000.0d, 0.0000961007d },
            { 2080000.0d, 0.0000935882d },
            { 2090000.0d, 0.0000910983d },
            { 2100000.0d, 0.0000886322d },
            { 2110000.0d, 0.000086191d },
            { 2120000.0d, 0.0000837763d },
            { 2130000.0d, 0.0000813895d },
            { 2140000.0d, 0.000079032d },
            { 2150000.0d, 0.0000767052d },
            { 2160000.0d, 0.0000744105d },
            { 2170000.0d, 0.0000721492d },
            { 2180000.0d, 0.0000699231d },
            { 2190000.0d, 0.0000677333d },
            { 2200000.0d, 0.0000655813d },
            { 2210000.0d, 0.0000634676d },
            { 2220000.0d, 0.0000613891d },
            { 2230000.0d, 0.0000593467d },
            { 2240000.0d, 0.0000573419d },
            { 2250000.0d, 0.0000553759d },
            { 2260000.0d, 0.0000534504d },
            { 2270000.0d, 0.0000515665d },
            { 2280000.0d, 0.0000497259d },
            { 2290000.0d, 0.00004793d },
            { 2300000.0d, 0.0000461799d },
            { 2310000.0d, 0.0000444764d },
            { 2320000.0d, 0.0000428205d },
            { 2330000.0d, 0.000041214d },
            { 2340000.0d, 0.0000396583d },
            { 2350000.0d, 0.0000381548d },
            { 2360000.0d, 0.0000367051d },
            { 2370000.0d, 0.0000353107d },
            { 2380000.0d, 0.0000339731d },
            { 2390000.0d, 0.0000326938d },
            { 2400000.0d, 0.0000314745d },
            { 2410000.0d, 0.0000303167d },
            { 2420000.0d, 0.0000292218d },
            { 2430000.0d, 0.0000281911d },
            { 2440000.0d, 0.0000272254d },
            { 2450000.0d, 0.0000263263d },
            { 2460000.0d, 0.0000254953d },
            { 2470000.0d, 0.0000247337d },
            { 2480000.0d, 0.0000240424d },
            { 2490000.0d, 0.0000233873d },
            { 2500000.0d, 0.0000227453d },
            { 2510000.0d, 0.000022117d },
            { 2520000.0d, 0.0000215027d },
            { 2530000.0d, 0.000020903d },
            { 2540000.0d, 0.0000203183d },
            { 2550000.0d, 0.000019749d },
            { 2560000.0d, 0.0000191956d },
            { 2570000.0d, 0.0000186585d },
            { 2580000.0d, 0.0000181377d },
            { 2590000.0d, 0.0000176256d },
            { 2600000.0d, 0.0000171197d },
            { 2610000.0d, 0.0000166204d },
            { 2620000.0d, 0.0000161273d },
            { 2630000.0d, 0.0000156392d },
            { 2640000.0d, 0.0000151564d },
            { 2650000.0d, 0.0000146792d },
            { 2660000.0d, 0.0000142078d },
            { 2670000.0d, 0.0000137424d },
            { 2680000.0d, 0.0000132832d },
            { 2690000.0d, 0.0000128304d },
            { 2700000.0d, 0.0000123844d },
            { 2710000.0d, 0.0000119453d },
            { 2720000.0d, 0.0000115134d },
            { 2730000.0d, 0.0000110889d },
            { 2740000.0d, 0.000010672d },
            { 2750000.0d, 0.000010263d },
            { 2760000.0d, 0.0000098622d },
            { 2770000.0d, 0.00000946975d },
            { 2780000.0d, 0.00000908592d },
            { 2790000.0d, 0.00000871029d },
            { 2800000.0d, 0.00000834115d },
            { 2810000.0d, 0.00000797857d },
            { 2820000.0d, 0.00000762278d },
            { 2830000.0d, 0.00000727401d },
            { 2840000.0d, 0.00000693245d },
            { 2850000.0d, 0.00000659835d },
            { 2860000.0d, 0.00000627192d },
            { 2870000.0d, 0.00000595338d },
            { 2880000.0d, 0.00000564297d },
            { 2890000.0d, 0.00000534091d },
            { 2900000.0d, 0.00000504743d },
            { 2910000.0d, 0.00000476275d },
            { 2920000.0d, 0.00000448559d },
            { 2930000.0d, 0.00000421513d },
            { 2940000.0d, 0.00000395152d },
            { 2950000.0d, 0.00000369491d },
            { 2960000.0d, 0.00000344547d },
            { 2970000.0d, 0.00000320335d },
            { 2980000.0d, 0.0000029687d },
            { 2990000.0d, 0.00000274169d },
            { 3000000.0d, 0.00000252248d },
            { 3010000.0d, 0.00000231122d },
            { 3020000.0d, 0.00000210808d },
            { 3030000.0d, 0.00000191321d },
            { 3040000.0d, 0.00000172679d },
            { 3050000.0d, 0.00000154896d },
            { 3060000.0d, 0.0000013799d },
            { 3070000.0d, 0.00000121976d },
            { 3080000.0d, 0.00000106872d },
            { 3090000.0d, 0.000000926926d },
            { 3100000.0d, 0.000000794553d },
            { 3110000.0d, 0.000000671762d },
            { 3120000.0d, 0.000000558719d },
            { 3130000.0d, 0.000000455588d },
            { 3140000.0d, 0.000000362533d },
            { 3150000.0d, 0.000000279717d },
            { 3160000.0d, 0.000000207304d },
            { 3170000.0d, 0.000000145454d },
            { 3180000.0d, 0.0000000943286d },
            { 3190000.0d, 0.0000000540826d },
            { 3200000.0d, 0.000000024867d },
            { 3210000.0d, 0.00000000682137d },
            { 3220000.0d, 0.0000000000555266d },
            { 3221000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    