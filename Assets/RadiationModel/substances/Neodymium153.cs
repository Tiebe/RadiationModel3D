using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium153";
        public override double halfLife { get; } = 31.6d;
        public override double atomicWeight { get; } = 152.92772d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium153()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0943d, new GammaParticle(32200.0, 0.0385)), new(0.00123d, new GammaParticle(33300.0, 0.03723)), new(0.00370025d, new GammaParticle(39800.0, 0.03115)), new(0.00054325d, new GammaParticle(45500.0, 0.02725)), new(0.00519675d, new GammaParticle(56820.0, 0.02182)), new(0.0072775d, new GammaParticle(65540.0, 0.01892)), new(0.0010249999999999999d, new GammaParticle(70380.0, 0.01762)), new(0.0032287500000000003d, new GammaParticle(73320.0, 0.01691)), new(0.0017425d, new GammaParticle(78230.0, 0.01585)), new(0.0023575d, new GammaParticle(85100.0, 0.01457)), new(0.000492d, new GammaParticle(85500.0, 0.0145)), new(0.0011275d, new GammaParticle(103140.0, 0.01202)), new(0.022755d, new GammaParticle(105470.0, 0.01176)), new(0.00177325d, new GammaParticle(133270.0, 0.0093)), new(0.0001845d, new GammaParticle(135000.0, 0.00918)), new(0.0001025d, new GammaParticle(151900.0, 0.00816)), new(0.00025624999999999997d, new GammaParticle(160400.0, 0.00773)), new(0.007175d, new GammaParticle(185250.0, 0.00669)), new(0.000656d, new GammaParticle(236300.0, 0.00525)), new(0.01763d, new GammaParticle(255330.0, 0.00486)), new(0.00577075d, new GammaParticle(263380.0, 0.00471)), new(0.0119925d, new GammaParticle(283820.0, 0.00437)), new(0.0005124999999999999d, new GammaParticle(308500.0, 0.00402)), new(0.00097375d, new GammaParticle(320500.0, 0.00387)), new(0.0064575000000000006d, new GammaParticle(322000.0, 0.00385)), new(0.007072500000000001d, new GammaParticle(340660.0, 0.00364)), new(0.0023575d, new GammaParticle(343900.0, 0.00361)), new(0.01722d, new GammaParticle(344970.0, 0.00359)), new(0.00212175d, new GammaParticle(401800.0, 0.00309)), new(0.006765d, new GammaParticle(407470.0, 0.00304)), new(0.00279825d, new GammaParticle(409600.0, 0.00303)), new(0.1025d, new GammaParticle(418340.0, 0.00296)), new(0.00064575d, new GammaParticle(435000.0, 0.00285)), new(0.00041d, new GammaParticle(450400.0, 0.00275)), new(0.017835d, new GammaParticle(475120.0, 0.00261)), new(0.002747d, new GammaParticle(480140.0, 0.00258)), new(0.000615d, new GammaParticle(507500.0, 0.00244)), new(0.0009225d, new GammaParticle(547100.0, 0.00227)), new(0.0009532499999999999d, new GammaParticle(553500.0, 0.00224)), new(0.002091d, new GammaParticle(555800.0, 0.00223)), new(0.0002665d, new GammaParticle(571200.0, 0.00217)), new(0.0014862500000000002d, new GammaParticle(571400.0, 0.00217)), new(0.000246d, new GammaParticle(585600.0, 0.00212)), new(0.00328d, new GammaParticle(615000.0, 0.00202)), new(0.002132d, new GammaParticle(662800.0, 0.00187)), new(0.0035977500000000003d, new GammaParticle(665330.0, 0.00186)), new(0.005124999999999999d, new GammaParticle(668430.0, 0.00185)), new(0.0013735d, new GammaParticle(673670.0, 0.00184)), new(0.0037925d, new GammaParticle(685700.0, 0.00181)), new(0.0048175d, new GammaParticle(710000.0, 0.00175)), new(0.003895d, new GammaParticle(725220.0, 0.00171)), new(0.0015477499999999999d, new GammaParticle(738400.0, 0.00168)), new(0.00341325d, new GammaParticle(759100.0, 0.00163)), new(0.0001025d, new GammaParticle(770900.0, 0.00161)), new(0.0018859999999999999d, new GammaParticle(785500.0, 0.00158)), new(0.007072500000000001d, new GammaParticle(795630.0, 0.00156)), new(0.00328d, new GammaParticle(828860.0, 0.0015)), new(0.0033825d, new GammaParticle(868100.0, 0.00143)), new(0.008199999999999999d, new GammaParticle(891740.0, 0.00139)), new(0.0068674999999999995d, new GammaParticle(947960.0, 0.00131)), new(0.000328d, new GammaParticle(952800.0, 0.0013)), new(0.0212175d, new GammaParticle(967080.0, 0.00128)), new(0.00083025d, new GammaParticle(1004900.0, 0.00123)), new(0.0009532499999999999d, new GammaParticle(1013540.0, 0.00122)), new(0.0015375d, new GammaParticle(1026000.0, 0.00121)), new(0.0011275d, new GammaParticle(1070800.0, 0.00116)), new(0.0012915d, new GammaParticle(1106300.0, 0.00112)), new(0.00121975d, new GammaParticle(1107460.0, 0.00112)), new(0.0013017500000000002d, new GammaParticle(1115000.0, 0.00111)), new(0.000902d, new GammaParticle(1120700.0, 0.00111)), new(0.000656d, new GammaParticle(1128300.0, 0.0011)), new(0.00451d, new GammaParticle(1136650.0, 0.00109)), new(0.00099425d, new GammaParticle(1143900.0, 0.00108)), new(0.00070725d, new GammaParticle(1160500.0, 0.00107)), new(0.0025317499999999997d, new GammaParticle(1170700.0, 0.00106)), new(0.000287d, new GammaParticle(1176300.0, 0.00105)), new(0.005124999999999999d, new GammaParticle(1180970.0, 0.00105)), new(0.00105575d, new GammaParticle(1190400.0, 0.00104)), new(0.001845d, new GammaParticle(1191500.0, 0.00104)), new(0.0042025000000000005d, new GammaParticle(1194000.0, 0.00104)), new(0.007267249999999999d, new GammaParticle(1202170.0, 0.00103)), new(0.0146575d, new GammaParticle(1213750.0, 0.00102)), new(0.01107d, new GammaParticle(1230500.0, 0.00101)), new(0.00212175d, new GammaParticle(1237800.0, 0.001)), new(0.00185525d, new GammaParticle(1243300.0, 0.001)), new(0.00060475d, new GammaParticle(1257100.0, 0.00099)), new(0.00328d, new GammaParticle(1259060.0, 0.00098)), new(0.0017425d, new GammaParticle(1264200.0, 0.00098)), new(0.00021525d, new GammaParticle(1282200.0, 0.00097)), new(0.0036285d, new GammaParticle(1296150.0, 0.00096)), new(0.000369d, new GammaParticle(1302700.0, 0.00095)), new(0.00117875d, new GammaParticle(1325800.0, 0.00094)), new(0.001845d, new GammaParticle(1328700.0, 0.00093)), new(0.002255d, new GammaParticle(1402450.0, 0.00088)), new(0.004305d, new GammaParticle(1435790.0, 0.00086)), new(0.0025624999999999997d, new GammaParticle(1480300.0, 0.00084)), new(0.00369d, new GammaParticle(1524500.0, 0.00081)), new(0.0029725000000000003d, new GammaParticle(1537100.0, 0.00081)), new(0.0020499999999999997d, new GammaParticle(1541000.0, 0.0008)), new(0.0013017500000000002d, new GammaParticle(1547000.0, 0.0008)), new(0.0011275d, new GammaParticle(1554100.0, 0.0008)), new(0.00246d, new GammaParticle(1732000.0, 0.00072)), new(0.0019475d, new GammaParticle(1745400.0, 0.00071)), new(0.00123d, new GammaParticle(1759000.0, 0.0007)), new(0.00123d, new GammaParticle(1784900.0, 0.00069)), new(0.003895d, new GammaParticle(1805290.0, 0.00069)), new(0.0013325000000000001d, new GammaParticle(1817900.0, 0.00068)), new(0.000164d, new GammaParticle(1824500.0, 0.00068)), new(0.000615d, new GammaParticle(1850300.0, 0.00067)), new(0.00164d, new GammaParticle(1882400.0, 0.00066)), new(0.00246d, new GammaParticle(1892200.0, 0.00066)), new(0.0005124999999999999d, new GammaParticle(1922300.0, 0.00064)), new(0.0014247499999999998d, new GammaParticle(1954800.0, 0.00063)), new(0.0244975d, new GammaParticle(1965580.0, 0.00063)), new(0.00273675d, new GammaParticle(1987840.0, 0.00062)), new(0.00214225d, new GammaParticle(1994800.0, 0.00062)), new(0.006765d, new GammaParticle(1997750.0, 0.00062)), new(0.00107625d, new GammaParticle(2008400.0, 0.00062)), new(0.0006252499999999999d, new GammaParticle(2027900.0, 0.00061)), new(0.00499175d, new GammaParticle(2032200.0, 0.00061)), new(0.0001025d, new GammaParticle(2060500.0, 0.0006)), new(0.001845d, new GammaParticle(2318900.0, 0.00053)), new(0.00123d, new GammaParticle(2340500.0, 0.00053)), new(0.0298327974882997d, new GammaParticle(6109.0, 0.20295)), new(0.02266309485925545d, new GammaParticle(38171.0, 0.03248)), new(0.04114577861157489d, new GammaParticle(38724.0, 0.03202)), new(0.012756698411471493d, new GammaParticle(43934.0, 0.02822)), new(0.016035169903219664d, new GammaParticle(44387.0, 0.02793)), new(0.0032784714917481732d, new GammaParticle(44938.0, 0.02759)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000260576d },
            { 4000.0d, 0.000263528d },
            { 8000.0d, 0.000266299d },
            { 12000.0d, 0.00026889d },
            { 16000.0d, 0.00027139d },
            { 20000.0d, 0.000273835d },
            { 24000.0d, 0.000276242d },
            { 28000.0d, 0.000278619d },
            { 32000.0d, 0.000280973d },
            { 36000.0d, 0.000283314d },
            { 40000.0d, 0.000285646d },
            { 44000.0d, 0.000287968d },
            { 48000.0d, 0.000290288d },
            { 52000.0d, 0.000292603d },
            { 56000.0d, 0.000294915d },
            { 60000.0d, 0.000297226d },
            { 64000.0d, 0.000299536d },
            { 68000.0d, 0.000301844d },
            { 72000.0d, 0.000304151d },
            { 76000.0d, 0.000306457d },
            { 80000.0d, 0.000308761d },
            { 84000.0d, 0.000311064d },
            { 88000.0d, 0.000313365d },
            { 92000.0d, 0.000315663d },
            { 96000.0d, 0.000317958d },
            { 100000.0d, 0.00032025d },
            { 110000.0d, 0.000325964d },
            { 120000.0d, 0.00033165d },
            { 130000.0d, 0.000337301d },
            { 140000.0d, 0.000342912d },
            { 150000.0d, 0.000348476d },
            { 160000.0d, 0.00035399d },
            { 170000.0d, 0.000359449d },
            { 180000.0d, 0.000364848d },
            { 190000.0d, 0.000370184d },
            { 200000.0d, 0.000375453d },
            { 210000.0d, 0.000380652d },
            { 220000.0d, 0.000385778d },
            { 230000.0d, 0.000390828d },
            { 240000.0d, 0.0003958d },
            { 250000.0d, 0.000400691d },
            { 260000.0d, 0.000405498d },
            { 270000.0d, 0.00041022d },
            { 280000.0d, 0.000414855d },
            { 290000.0d, 0.000419401d },
            { 300000.0d, 0.000423857d },
            { 310000.0d, 0.000428219d },
            { 320000.0d, 0.000432488d },
            { 330000.0d, 0.000436664d },
            { 340000.0d, 0.000440741d },
            { 350000.0d, 0.000444723d },
            { 360000.0d, 0.000448605d },
            { 370000.0d, 0.000452388d },
            { 380000.0d, 0.000456071d },
            { 390000.0d, 0.000459653d },
            { 400000.0d, 0.000463133d },
            { 410000.0d, 0.000466512d },
            { 420000.0d, 0.000469788d },
            { 430000.0d, 0.000472959d },
            { 440000.0d, 0.000476028d },
            { 450000.0d, 0.000478993d },
            { 460000.0d, 0.000481853d },
            { 470000.0d, 0.000484609d },
            { 480000.0d, 0.00048726d },
            { 490000.0d, 0.000489807d },
            { 500000.0d, 0.000492248d },
            { 510000.0d, 0.000494586d },
            { 520000.0d, 0.000496819d },
            { 530000.0d, 0.000498948d },
            { 540000.0d, 0.000500973d },
            { 550000.0d, 0.000502894d },
            { 560000.0d, 0.000504711d },
            { 570000.0d, 0.000506426d },
            { 580000.0d, 0.000508039d },
            { 590000.0d, 0.000509549d },
            { 600000.0d, 0.000510958d },
            { 610000.0d, 0.000512266d },
            { 620000.0d, 0.000513476d },
            { 630000.0d, 0.000514585d },
            { 640000.0d, 0.000515596d },
            { 650000.0d, 0.00051651d },
            { 660000.0d, 0.000517326d },
            { 670000.0d, 0.000518048d },
            { 680000.0d, 0.000518676d },
            { 690000.0d, 0.000519209d },
            { 700000.0d, 0.000519649d },
            { 710000.0d, 0.000519999d },
            { 720000.0d, 0.000520259d },
            { 730000.0d, 0.000520429d },
            { 740000.0d, 0.000520513d },
            { 750000.0d, 0.00052051d },
            { 760000.0d, 0.000520423d },
            { 770000.0d, 0.000520252d },
            { 780000.0d, 0.00052d },
            { 790000.0d, 0.000519667d },
            { 800000.0d, 0.000519257d },
            { 810000.0d, 0.000518769d },
            { 820000.0d, 0.000518207d },
            { 830000.0d, 0.00051757d },
            { 840000.0d, 0.000516863d },
            { 850000.0d, 0.000516086d },
            { 860000.0d, 0.00051524d },
            { 870000.0d, 0.000514329d },
            { 880000.0d, 0.000513354d },
            { 890000.0d, 0.000512317d },
            { 900000.0d, 0.00051122d },
            { 910000.0d, 0.000510066d },
            { 920000.0d, 0.000508855d },
            { 930000.0d, 0.000507592d },
            { 940000.0d, 0.000506277d },
            { 950000.0d, 0.000504913d },
            { 960000.0d, 0.000503503d },
            { 970000.0d, 0.000502049d },
            { 980000.0d, 0.000500553d },
            { 990000.0d, 0.000499017d },
            { 1000000.0d, 0.000497445d },
            { 1011000.0d, 0.000495676d },
            { 1022000.0d, 0.000493869d },
            { 1033000.0d, 0.000492026d },
            { 1044000.0d, 0.000490154d },
            { 1055000.0d, 0.000488254d },
            { 1066000.0d, 0.00048633d },
            { 1077000.0d, 0.000484386d },
            { 1088000.0d, 0.000482426d },
            { 1099000.0d, 0.000480453d },
            { 1110000.0d, 0.000478473d },
            { 1121000.0d, 0.000476486d },
            { 1132000.0d, 0.0004745d },
            { 1143000.0d, 0.000472518d },
            { 1154000.0d, 0.000470543d },
            { 1165000.0d, 0.00046858d },
            { 1176000.0d, 0.000466633d },
            { 1187000.0d, 0.000464705d },
            { 1198000.0d, 0.000462803d },
            { 1209000.0d, 0.00046093d },
            { 1220000.0d, 0.00045909d },
            { 1231000.0d, 0.000457287d },
            { 1242000.0d, 0.000455528d },
            { 1253000.0d, 0.000453815d },
            { 1264000.0d, 0.000452153d },
            { 1275000.0d, 0.000450543d },
            { 1286000.0d, 0.000448986d },
            { 1297000.0d, 0.00044748d },
            { 1308000.0d, 0.000446019d },
            { 1319000.0d, 0.000444602d },
            { 1330000.0d, 0.000443184d },
            { 1341000.0d, 0.000441728d },
            { 1352000.0d, 0.000440225d },
            { 1363000.0d, 0.000438677d },
            { 1374000.0d, 0.000437084d },
            { 1385000.0d, 0.000435447d },
            { 1396000.0d, 0.00043377d },
            { 1407000.0d, 0.00043205d },
            { 1418000.0d, 0.000430291d },
            { 1429000.0d, 0.000428492d },
            { 1440000.0d, 0.000426656d },
            { 1451000.0d, 0.000424783d },
            { 1462000.0d, 0.000422875d },
            { 1473000.0d, 0.000420932d },
            { 1484000.0d, 0.000418952d },
            { 1495000.0d, 0.000416931d },
            { 1506000.0d, 0.000414867d },
            { 1517000.0d, 0.000412763d },
            { 1528000.0d, 0.000410618d },
            { 1539000.0d, 0.000408432d },
            { 1550000.0d, 0.000406208d },
            { 1561000.0d, 0.000403943d },
            { 1572000.0d, 0.000401637d },
            { 1583000.0d, 0.000399293d },
            { 1594000.0d, 0.000396909d },
            { 1605000.0d, 0.000394485d },
            { 1616000.0d, 0.000392019d },
            { 1627000.0d, 0.000389515d },
            { 1638000.0d, 0.000386971d },
            { 1649000.0d, 0.00038439d },
            { 1660000.0d, 0.000381773d },
            { 1671000.0d, 0.000379119d },
            { 1682000.0d, 0.000376431d },
            { 1693000.0d, 0.000373709d },
            { 1704000.0d, 0.000370954d },
            { 1715000.0d, 0.000368167d },
            { 1726000.0d, 0.000365349d },
            { 1737000.0d, 0.000362501d },
            { 1748000.0d, 0.000359624d },
            { 1759000.0d, 0.000356719d },
            { 1770000.0d, 0.000353787d },
            { 1781000.0d, 0.000350829d },
            { 1792000.0d, 0.000347846d },
            { 1803000.0d, 0.00034484d },
            { 1814000.0d, 0.000341811d },
            { 1825000.0d, 0.000338761d },
            { 1836000.0d, 0.00033569d },
            { 1847000.0d, 0.0003326d },
            { 1858000.0d, 0.000329492d },
            { 1869000.0d, 0.000326366d },
            { 1880000.0d, 0.000323225d },
            { 1891000.0d, 0.000320069d },
            { 1902000.0d, 0.0003169d },
            { 1913000.0d, 0.000313718d },
            { 1924000.0d, 0.000310525d },
            { 1935000.0d, 0.000307322d },
            { 1946000.0d, 0.00030411d },
            { 1957000.0d, 0.000300891d },
            { 1968000.0d, 0.000297666d },
            { 1979000.0d, 0.000294436d },
            { 1990000.0d, 0.000291201d },
            { 2001000.0d, 0.000287964d },
            { 2012000.0d, 0.000284726d },
            { 2023000.0d, 0.000281489d },
            { 2034000.0d, 0.000278248d },
            { 2045000.0d, 0.000275003d },
            { 2056000.0d, 0.000271755d },
            { 2067000.0d, 0.000268504d },
            { 2078000.0d, 0.000265251d },
            { 2089000.0d, 0.000261997d },
            { 2100000.0d, 0.000258743d },
            { 2111000.0d, 0.000255487d },
            { 2122000.0d, 0.000252229d },
            { 2133000.0d, 0.000248968d },
            { 2144000.0d, 0.000245705d },
            { 2155000.0d, 0.000242441d },
            { 2166000.0d, 0.000239174d },
            { 2177000.0d, 0.000235905d },
            { 2188000.0d, 0.000232637d },
            { 2199000.0d, 0.000229369d },
            { 2210000.0d, 0.000226102d },
            { 2221000.0d, 0.000222835d },
            { 2232000.0d, 0.000219566d },
            { 2243000.0d, 0.000216298d },
            { 2254000.0d, 0.000213032d },
            { 2265000.0d, 0.000209768d },
            { 2276000.0d, 0.000206508d },
            { 2287000.0d, 0.000203252d },
            { 2298000.0d, 0.000200002d },
            { 2309000.0d, 0.000196758d },
            { 2320000.0d, 0.000193518d },
            { 2331000.0d, 0.000190284d },
            { 2342000.0d, 0.000187057d },
            { 2353000.0d, 0.000183837d },
            { 2364000.0d, 0.000180621d },
            { 2375000.0d, 0.00017741d },
            { 2386000.0d, 0.000174203d },
            { 2397000.0d, 0.000171001d },
            { 2408000.0d, 0.000167807d },
            { 2419000.0d, 0.00016462d },
            { 2430000.0d, 0.000161441d },
            { 2441000.0d, 0.000158273d },
            { 2452000.0d, 0.000155114d },
            { 2463000.0d, 0.000151967d },
            { 2474000.0d, 0.000148833d },
            { 2485000.0d, 0.000145711d },
            { 2496000.0d, 0.000142604d },
            { 2507000.0d, 0.000139513d },
            { 2518000.0d, 0.000136439d },
            { 2529000.0d, 0.000133382d },
            { 2540000.0d, 0.000130342d },
            { 2551000.0d, 0.000127321d },
            { 2562000.0d, 0.000124317d },
            { 2573000.0d, 0.00012133d },
            { 2584000.0d, 0.00011836d },
            { 2595000.0d, 0.00011541d },
            { 2606000.0d, 0.00011248d },
            { 2617000.0d, 0.00010957d },
            { 2628000.0d, 0.000106681d },
            { 2639000.0d, 0.000103814d },
            { 2650000.0d, 0.00010097d },
            { 2661000.0d, 0.0000981489d },
            { 2672000.0d, 0.0000953527d },
            { 2683000.0d, 0.0000925822d },
            { 2694000.0d, 0.0000898385d },
            { 2705000.0d, 0.0000871225d },
            { 2716000.0d, 0.0000844351d },
            { 2727000.0d, 0.0000817777d },
            { 2738000.0d, 0.000079151d },
            { 2749000.0d, 0.0000765561d },
            { 2760000.0d, 0.0000739943d },
            { 2771000.0d, 0.0000714664d },
            { 2782000.0d, 0.0000689735d },
            { 2793000.0d, 0.0000665168d },
            { 2804000.0d, 0.0000640972d },
            { 2815000.0d, 0.0000617151d },
            { 2826000.0d, 0.0000593643d },
            { 2837000.0d, 0.0000570438d },
            { 2848000.0d, 0.0000547546d },
            { 2859000.0d, 0.0000524977d },
            { 2870000.0d, 0.0000502739d },
            { 2881000.0d, 0.0000480842d },
            { 2892000.0d, 0.0000459296d },
            { 2903000.0d, 0.0000438111d },
            { 2914000.0d, 0.0000417297d },
            { 2925000.0d, 0.0000396863d },
            { 2936000.0d, 0.0000376819d },
            { 2947000.0d, 0.0000357176d },
            { 2958000.0d, 0.0000337943d },
            { 2969000.0d, 0.0000319131d },
            { 2980000.0d, 0.0000300751d },
            { 2991000.0d, 0.0000282811d },
            { 3002000.0d, 0.0000265323d },
            { 3013000.0d, 0.0000248296d },
            { 3024000.0d, 0.000023174d },
            { 3035000.0d, 0.0000215667d },
            { 3046000.0d, 0.0000200085d },
            { 3057000.0d, 0.0000185006d },
            { 3068000.0d, 0.000017044d },
            { 3079000.0d, 0.0000156398d },
            { 3090000.0d, 0.0000142891d },
            { 3101000.0d, 0.0000129928d },
            { 3112000.0d, 0.0000117522d },
            { 3123000.0d, 0.0000105683d },
            { 3134000.0d, 0.0000094419d },
            { 3145000.0d, 0.00000837402d },
            { 3156000.0d, 0.00000736572d },
            { 3167000.0d, 0.00000641811d },
            { 3178000.0d, 0.00000553226d },
            { 3189000.0d, 0.00000470927d },
            { 3200000.0d, 0.00000395021d },
            { 3211000.0d, 0.00000325617d },
            { 3222000.0d, 0.00000262775d },
            { 3233000.0d, 0.0000020651d },
            { 3244000.0d, 0.00000156923d },
            { 3255000.0d, 0.00000114106d },
            { 3266000.0d, 0.000000779985d },
            { 3277000.0d, 0.000000486325d },
            { 3288000.0d, 0.000000260979d },
            { 3299000.0d, 0.0000001048d },
            { 3310000.0d, 0.000000018545d },
            { 3318000.0d, 0d },

        }; 
    }
}
    