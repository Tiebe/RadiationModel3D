using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium152";
        public override double halfLife { get; } = 247.2d;
        public override double atomicWeight { get; } = 151.92351d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium152()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.004396d, new GammaParticle(119500.0, 0.01038)), new(0.157d, new GammaParticle(121800.0, 0.01018)), new(0.0002041d, new GammaParticle(209500.0, 0.00592)), new(0.009734d, new GammaParticle(244700.0, 0.00507)), new(0.0014130000000000002d, new GammaParticle(251400.0, 0.00493)), new(0.003297d, new GammaParticle(272500.0, 0.00455)), new(0.002355d, new GammaParticle(329200.0, 0.00377)), new(0.0006123d, new GammaParticle(365900.0, 0.00339)), new(0.002041d, new GammaParticle(443600.0, 0.00279)), new(0.000314d, new GammaParticle(534100.0, 0.00232)), new(0.004396d, new GammaParticle(563000.0, 0.0022)), new(0.00157d, new GammaParticle(564100.0, 0.0022)), new(0.001727d, new GammaParticle(571900.0, 0.00217)), new(0.000157d, new GammaParticle(616000.0, 0.00201)), new(0.00157d, new GammaParticle(642800.0, 0.00193)), new(0.002355d, new GammaParticle(661700.0, 0.00187)), new(0.003297d, new GammaParticle(674200.0, 0.00184)), new(0.005809d, new GammaParticle(688300.0, 0.0018)), new(0.026062d, new GammaParticle(695900.0, 0.00178)), new(0.000314d, new GammaParticle(727100.0, 0.00171)), new(0.005181d, new GammaParticle(735100.0, 0.00169)), new(0.002512d, new GammaParticle(810200.0, 0.00153)), new(0.00471d, new GammaParticle(812900.0, 0.00153)), new(0.040506d, new GammaParticle(841400.0, 0.00147)), new(0.000628d, new GammaParticle(847500.0, 0.00146)), new(0.000628d, new GammaParticle(867200.0, 0.00143)), new(0.001099d, new GammaParticle(870200.0, 0.00142)), new(0.001099d, new GammaParticle(903300.0, 0.00137)), new(0.008321d, new GammaParticle(919000.0, 0.00135)), new(0.004867d, new GammaParticle(926000.0, 0.00134)), new(0.002041d, new GammaParticle(929100.0, 0.00133)), new(0.000471d, new GammaParticle(958200.0, 0.00129)), new(0.036738d, new GammaParticle(960900.0, 0.00129)), new(0.032028d, new GammaParticle(963300.0, 0.00129)), new(0.0036109999999999996d, new GammaParticle(964700.0, 0.00129)), new(0.002198d, new GammaParticle(981000.0, 0.00126)), new(0.000942d, new GammaParticle(995700.0, 0.00125)), new(0.00157d, new GammaParticle(1050000.0, 0.00118)), new(0.005809d, new GammaParticle(1079500.0, 0.00115)), new(0.002512d, new GammaParticle(1086500.0, 0.00114)), new(0.000785d, new GammaParticle(1112400.0, 0.00111)), new(0.0014130000000000002d, new GammaParticle(1127400.0, 0.0011)), new(0.000628d, new GammaParticle(1253200.0, 0.00099)), new(0.000471d, new GammaParticle(1274400.0, 0.00097)), new(0.002041d, new GammaParticle(1293000.0, 0.00096)), new(0.002041d, new GammaParticle(1317400.0, 0.00094)), new(0.010676000000000001d, new GammaParticle(1321600.0, 0.00094)), new(0.000471d, new GammaParticle(1326400.0, 0.00093)), new(0.000471d, new GammaParticle(1332000.0, 0.00093)), new(0.0039250000000000005d, new GammaParticle(1388800.0, 0.00089)), new(0.000785d, new GammaParticle(1403000.0, 0.00088)), new(0.001884d, new GammaParticle(1408200.0, 0.00088)), new(0.000314d, new GammaParticle(1488100.0, 0.00083)), new(0.000314d, new GammaParticle(1535300.0, 0.00081)), new(0.000157d, new GammaParticle(1558500.0, 0.0008)), new(0.000314d, new GammaParticle(1770400.0, 0.0007)), new(0.000942d, new GammaParticle(1822100.0, 0.00068)), new(0.000157d, new GammaParticle(1843200.0, 0.00067)), new(0.000157d, new GammaParticle(1873100.0, 0.00066)), new(0.000157d, new GammaParticle(1921600.0, 0.00065)), new(0.000471d, new GammaParticle(1970800.0, 0.00063)), new(0.001727d, new GammaParticle(2007000.0, 0.00062)), new(0.001256d, new GammaParticle(2045200.0, 0.00061)), new(0.000314d, new GammaParticle(2053900.0, 0.0006)), new(0.004553d, new GammaParticle(2079300.0, 0.0006)), new(0.000314d, new GammaParticle(2114200.0, 0.00059)), new(0.002041d, new GammaParticle(2118000.0, 0.00059)), new(0.000314d, new GammaParticle(2165600.0, 0.00057)), new(0.000628d, new GammaParticle(2175000.0, 0.00057)), new(0.000785d, new GammaParticle(2187000.0, 0.00057)), new(0.0036109999999999996d, new GammaParticle(2224800.0, 0.00056)), new(0.000628d, new GammaParticle(2239700.0, 0.00055)), new(0.000157d, new GammaParticle(2255000.0, 0.00055)), new(0.000628d, new GammaParticle(2309100.0, 0.00054)), new(0.000628d, new GammaParticle(2387900.0, 0.00052)), new(0.000628d, new GammaParticle(2566000.0, 0.00048)), new(0.000785d, new GammaParticle(2803700.0, 0.00044)), new(0.0239d, new GammaParticle(6354.0, 0.19513)), new(0.0285d, new GammaParticle(39522.0, 0.03137)), new(0.052000000000000005d, new GammaParticle(40117.0, 0.03091)), new(0.0161d, new GammaParticle(45523.0, 0.02724)), new(0.0203d, new GammaParticle(45998.0, 0.02695)), new(0.0042d, new GammaParticle(46575.0, 0.02662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000201684d },
            { 1000.0d, 0.000202155d },
            { 2000.0d, 0.000202668d },
            { 3000.0d, 0.000203224d },
            { 4000.0d, 0.000203782d },
            { 5000.0d, 0.000204336d },
            { 6000.0d, 0.000204885d },
            { 7000.0d, 0.000205427d },
            { 8000.0d, 0.000205962d },
            { 9000.0d, 0.000206491d },
            { 10000.0d, 0.000207014d },
            { 11000.0d, 0.00020753d },
            { 12000.0d, 0.00020804d },
            { 13000.0d, 0.000208549d },
            { 14000.0d, 0.000209055d },
            { 15000.0d, 0.000209556d },
            { 16000.0d, 0.000210055d },
            { 17000.0d, 0.000210552d },
            { 18000.0d, 0.000211047d },
            { 19000.0d, 0.00021154d },
            { 20000.0d, 0.000212031d },
            { 21000.0d, 0.00021252d },
            { 22000.0d, 0.000213008d },
            { 23000.0d, 0.000213494d },
            { 24000.0d, 0.000213978d },
            { 25000.0d, 0.000214461d },
            { 26000.0d, 0.000214944d },
            { 27000.0d, 0.000215424d },
            { 28000.0d, 0.000215904d },
            { 29000.0d, 0.000216382d },
            { 30000.0d, 0.000216859d },
            { 31000.0d, 0.000217334d },
            { 32000.0d, 0.000217809d },
            { 33000.0d, 0.000218282d },
            { 34000.0d, 0.000218758d },
            { 35000.0d, 0.000219233d },
            { 36000.0d, 0.000219707d },
            { 37000.0d, 0.000220181d },
            { 38000.0d, 0.000220655d },
            { 39000.0d, 0.000221128d },
            { 40000.0d, 0.0002216d },
            { 41000.0d, 0.000222072d },
            { 42000.0d, 0.000222544d },
            { 43000.0d, 0.000223015d },
            { 44000.0d, 0.000223486d },
            { 45000.0d, 0.000223958d },
            { 46000.0d, 0.000224429d },
            { 47000.0d, 0.0002249d },
            { 48000.0d, 0.000225371d },
            { 49000.0d, 0.000225842d },
            { 50000.0d, 0.000226313d },
            { 51000.0d, 0.000226784d },
            { 52000.0d, 0.000227254d },
            { 53000.0d, 0.000227725d },
            { 54000.0d, 0.000228195d },
            { 55000.0d, 0.000228665d },
            { 56000.0d, 0.000229136d },
            { 57000.0d, 0.000229607d },
            { 58000.0d, 0.000230077d },
            { 59000.0d, 0.000230548d },
            { 60000.0d, 0.000231018d },
            { 61000.0d, 0.000231489d },
            { 62000.0d, 0.00023196d },
            { 63000.0d, 0.00023243d },
            { 64000.0d, 0.000232901d },
            { 65000.0d, 0.000233371d },
            { 66000.0d, 0.000233842d },
            { 67000.0d, 0.000234313d },
            { 68000.0d, 0.000234783d },
            { 69000.0d, 0.000235254d },
            { 70000.0d, 0.000235725d },
            { 71000.0d, 0.000236196d },
            { 72000.0d, 0.000236667d },
            { 73000.0d, 0.000237138d },
            { 74000.0d, 0.000237609d },
            { 75000.0d, 0.00023808d },
            { 76000.0d, 0.000238551d },
            { 77000.0d, 0.000239022d },
            { 78000.0d, 0.000239493d },
            { 79000.0d, 0.000239964d },
            { 80000.0d, 0.000240436d },
            { 81000.0d, 0.000240907d },
            { 82000.0d, 0.000241378d },
            { 83000.0d, 0.000241849d },
            { 84000.0d, 0.000242321d },
            { 85000.0d, 0.000242792d },
            { 86000.0d, 0.000243263d },
            { 87000.0d, 0.000243734d },
            { 88000.0d, 0.000244206d },
            { 89000.0d, 0.000244677d },
            { 90000.0d, 0.000245148d },
            { 91000.0d, 0.00024562d },
            { 92000.0d, 0.000246091d },
            { 93000.0d, 0.000246562d },
            { 94000.0d, 0.000247033d },
            { 95000.0d, 0.000247504d },
            { 96000.0d, 0.000247976d },
            { 97000.0d, 0.000248447d },
            { 98000.0d, 0.000248918d },
            { 99000.0d, 0.000249389d },
            { 100000.0d, 0.00024986d },
            { 110000.0d, 0.000254567d },
            { 120000.0d, 0.000259264d },
            { 130000.0d, 0.000263948d },
            { 140000.0d, 0.000268615d },
            { 150000.0d, 0.00027326d },
            { 160000.0d, 0.000277881d },
            { 170000.0d, 0.000282475d },
            { 180000.0d, 0.000287037d },
            { 190000.0d, 0.000291566d },
            { 200000.0d, 0.000296058d },
            { 210000.0d, 0.000300513d },
            { 220000.0d, 0.000304927d },
            { 230000.0d, 0.000309298d },
            { 240000.0d, 0.000313624d },
            { 250000.0d, 0.000317905d },
            { 260000.0d, 0.000322137d },
            { 270000.0d, 0.000326321d },
            { 280000.0d, 0.000330453d },
            { 290000.0d, 0.000334535d },
            { 300000.0d, 0.000338562d },
            { 310000.0d, 0.000342535d },
            { 320000.0d, 0.000346453d },
            { 330000.0d, 0.000350316d },
            { 340000.0d, 0.00035412d },
            { 350000.0d, 0.000357867d },
            { 360000.0d, 0.000361555d },
            { 370000.0d, 0.000365184d },
            { 380000.0d, 0.000368753d },
            { 390000.0d, 0.000372261d },
            { 400000.0d, 0.000375709d },
            { 410000.0d, 0.000379095d },
            { 420000.0d, 0.000382419d },
            { 430000.0d, 0.000385682d },
            { 440000.0d, 0.000388882d },
            { 450000.0d, 0.000392018d },
            { 460000.0d, 0.000395092d },
            { 470000.0d, 0.000398104d },
            { 480000.0d, 0.000401052d },
            { 490000.0d, 0.000403937d },
            { 500000.0d, 0.000406759d },
            { 510000.0d, 0.000409517d },
            { 520000.0d, 0.000412213d },
            { 530000.0d, 0.000414846d },
            { 540000.0d, 0.000417416d },
            { 550000.0d, 0.000419924d },
            { 560000.0d, 0.000422369d },
            { 570000.0d, 0.000424753d },
            { 580000.0d, 0.000427075d },
            { 590000.0d, 0.000429334d },
            { 600000.0d, 0.000431526d },
            { 610000.0d, 0.000433651d },
            { 620000.0d, 0.00043571d },
            { 630000.0d, 0.000437702d },
            { 640000.0d, 0.000439628d },
            { 650000.0d, 0.000441489d },
            { 660000.0d, 0.000443284d },
            { 670000.0d, 0.000445014d },
            { 680000.0d, 0.00044668d },
            { 690000.0d, 0.000448281d },
            { 700000.0d, 0.000449818d },
            { 710000.0d, 0.000451293d },
            { 720000.0d, 0.000452704d },
            { 730000.0d, 0.000454054d },
            { 740000.0d, 0.000455341d },
            { 750000.0d, 0.000456568d },
            { 760000.0d, 0.000457734d },
            { 770000.0d, 0.000458841d },
            { 780000.0d, 0.000459889d },
            { 790000.0d, 0.000460879d },
            { 800000.0d, 0.00046181d },
            { 810000.0d, 0.000462685d },
            { 820000.0d, 0.000463505d },
            { 830000.0d, 0.000464269d },
            { 840000.0d, 0.000464975d },
            { 850000.0d, 0.000465628d },
            { 860000.0d, 0.000466225d },
            { 870000.0d, 0.000466769d },
            { 880000.0d, 0.00046726d },
            { 890000.0d, 0.000467699d },
            { 900000.0d, 0.000468088d },
            { 910000.0d, 0.000468426d },
            { 920000.0d, 0.000468716d },
            { 930000.0d, 0.000468958d },
            { 940000.0d, 0.000469153d },
            { 950000.0d, 0.000469302d },
            { 960000.0d, 0.000469408d },
            { 970000.0d, 0.00046947d },
            { 980000.0d, 0.00046949d },
            { 990000.0d, 0.000469468d },
            { 1000000.0d, 0.000469407d },
            { 1011000.0d, 0.000469294d },
            { 1022000.0d, 0.000469135d },
            { 1033000.0d, 0.000468932d },
            { 1044000.0d, 0.000468684d },
            { 1055000.0d, 0.000468396d },
            { 1066000.0d, 0.000468068d },
            { 1077000.0d, 0.000467702d },
            { 1088000.0d, 0.0004673d },
            { 1099000.0d, 0.000466865d },
            { 1110000.0d, 0.000466397d },
            { 1121000.0d, 0.000465899d },
            { 1132000.0d, 0.000465373d },
            { 1143000.0d, 0.00046482d },
            { 1154000.0d, 0.000464242d },
            { 1165000.0d, 0.000463637d },
            { 1176000.0d, 0.000463011d },
            { 1187000.0d, 0.000462363d },
            { 1198000.0d, 0.000461696d },
            { 1209000.0d, 0.000461012d },
            { 1220000.0d, 0.00046031d },
            { 1231000.0d, 0.000459588d },
            { 1242000.0d, 0.000458834d },
            { 1253000.0d, 0.000458051d },
            { 1264000.0d, 0.000457241d },
            { 1275000.0d, 0.000456402d },
            { 1286000.0d, 0.000455535d },
            { 1297000.0d, 0.000454635d },
            { 1308000.0d, 0.000453703d },
            { 1319000.0d, 0.000452738d },
            { 1330000.0d, 0.000451739d },
            { 1341000.0d, 0.000450705d },
            { 1352000.0d, 0.000449634d },
            { 1363000.0d, 0.000448524d },
            { 1374000.0d, 0.00044738d },
            { 1385000.0d, 0.000446199d },
            { 1396000.0d, 0.000444981d },
            { 1407000.0d, 0.000443724d },
            { 1418000.0d, 0.000442432d },
            { 1429000.0d, 0.000441102d },
            { 1440000.0d, 0.000439735d },
            { 1451000.0d, 0.000438331d },
            { 1462000.0d, 0.000436891d },
            { 1473000.0d, 0.000435416d },
            { 1484000.0d, 0.000433902d },
            { 1495000.0d, 0.00043235d },
            { 1506000.0d, 0.00043076d },
            { 1517000.0d, 0.000429134d },
            { 1528000.0d, 0.000427473d },
            { 1539000.0d, 0.000425778d },
            { 1550000.0d, 0.000424049d },
            { 1561000.0d, 0.000422287d },
            { 1572000.0d, 0.000420494d },
            { 1583000.0d, 0.000418666d },
            { 1594000.0d, 0.000416805d },
            { 1605000.0d, 0.000414913d },
            { 1616000.0d, 0.000412989d },
            { 1627000.0d, 0.000411035d },
            { 1638000.0d, 0.00040905d },
            { 1649000.0d, 0.000407035d },
            { 1660000.0d, 0.000404992d },
            { 1671000.0d, 0.000402922d },
            { 1682000.0d, 0.000400824d },
            { 1693000.0d, 0.000398701d },
            { 1704000.0d, 0.000396554d },
            { 1715000.0d, 0.000394383d },
            { 1726000.0d, 0.000392189d },
            { 1737000.0d, 0.000389974d },
            { 1748000.0d, 0.000387733d },
            { 1759000.0d, 0.000385466d },
            { 1770000.0d, 0.000383174d },
            { 1781000.0d, 0.000380858d },
            { 1792000.0d, 0.000378519d },
            { 1803000.0d, 0.000376158d },
            { 1814000.0d, 0.000373775d },
            { 1825000.0d, 0.000371373d },
            { 1836000.0d, 0.00036895d },
            { 1847000.0d, 0.000366509d },
            { 1858000.0d, 0.000364044d },
            { 1869000.0d, 0.000361549d },
            { 1880000.0d, 0.000359023d },
            { 1891000.0d, 0.000356467d },
            { 1902000.0d, 0.000353882d },
            { 1913000.0d, 0.000351268d },
            { 1924000.0d, 0.000348627d },
            { 1935000.0d, 0.000345958d },
            { 1946000.0d, 0.000343263d },
            { 1957000.0d, 0.000340542d },
            { 1968000.0d, 0.000337797d },
            { 1979000.0d, 0.000335028d },
            { 1990000.0d, 0.000332234d },
            { 2001000.0d, 0.000329419d },
            { 2012000.0d, 0.000326581d },
            { 2023000.0d, 0.000323722d },
            { 2034000.0d, 0.000320842d },
            { 2045000.0d, 0.000317942d },
            { 2056000.0d, 0.000315023d },
            { 2067000.0d, 0.000312086d },
            { 2078000.0d, 0.000309131d },
            { 2089000.0d, 0.00030616d },
            { 2100000.0d, 0.000303173d },
            { 2111000.0d, 0.000300171d },
            { 2122000.0d, 0.000297155d },
            { 2133000.0d, 0.000294126d },
            { 2144000.0d, 0.000291085d },
            { 2155000.0d, 0.000288031d },
            { 2166000.0d, 0.000284968d },
            { 2177000.0d, 0.000281895d },
            { 2188000.0d, 0.000278814d },
            { 2199000.0d, 0.000275724d },
            { 2210000.0d, 0.000272628d },
            { 2221000.0d, 0.000269526d },
            { 2232000.0d, 0.000266415d },
            { 2243000.0d, 0.000263296d },
            { 2254000.0d, 0.000260171d },
            { 2265000.0d, 0.000257041d },
            { 2276000.0d, 0.000253905d },
            { 2287000.0d, 0.000250765d },
            { 2298000.0d, 0.000247621d },
            { 2309000.0d, 0.000244475d },
            { 2320000.0d, 0.000241327d },
            { 2331000.0d, 0.000238178d },
            { 2342000.0d, 0.000235029d },
            { 2353000.0d, 0.000231881d },
            { 2364000.0d, 0.000228735d },
            { 2375000.0d, 0.000225592d },
            { 2386000.0d, 0.000222453d },
            { 2397000.0d, 0.000219318d },
            { 2408000.0d, 0.000216189d },
            { 2419000.0d, 0.000213066d },
            { 2430000.0d, 0.00020995d },
            { 2441000.0d, 0.000206831d },
            { 2452000.0d, 0.000203709d },
            { 2463000.0d, 0.000200585d },
            { 2474000.0d, 0.000197459d },
            { 2485000.0d, 0.000194332d },
            { 2496000.0d, 0.000191204d },
            { 2507000.0d, 0.000188077d },
            { 2518000.0d, 0.000184951d },
            { 2529000.0d, 0.000181826d },
            { 2540000.0d, 0.000178704d },
            { 2551000.0d, 0.000175585d },
            { 2562000.0d, 0.000172468d },
            { 2573000.0d, 0.000169354d },
            { 2584000.0d, 0.000166244d },
            { 2595000.0d, 0.000163137d },
            { 2606000.0d, 0.000160036d },
            { 2617000.0d, 0.00015694d },
            { 2628000.0d, 0.000153852d },
            { 2639000.0d, 0.00015077d },
            { 2650000.0d, 0.000147697d },
            { 2661000.0d, 0.000144632d },
            { 2672000.0d, 0.000141578d },
            { 2683000.0d, 0.000138533d },
            { 2694000.0d, 0.0001355d },
            { 2705000.0d, 0.000132479d },
            { 2716000.0d, 0.00012947d },
            { 2727000.0d, 0.000126475d },
            { 2738000.0d, 0.000123494d },
            { 2749000.0d, 0.000120528d },
            { 2760000.0d, 0.000117577d },
            { 2771000.0d, 0.000114643d },
            { 2782000.0d, 0.000111726d },
            { 2793000.0d, 0.000108827d },
            { 2804000.0d, 0.000105947d },
            { 2815000.0d, 0.000103088d },
            { 2826000.0d, 0.000100248d },
            { 2837000.0d, 0.0000974304d },
            { 2848000.0d, 0.0000946344d },
            { 2859000.0d, 0.0000918611d },
            { 2870000.0d, 0.0000891115d },
            { 2881000.0d, 0.0000863863d },
            { 2892000.0d, 0.0000836865d },
            { 2903000.0d, 0.0000810128d },
            { 2914000.0d, 0.0000783663d },
            { 2925000.0d, 0.0000757478d },
            { 2936000.0d, 0.0000731582d },
            { 2947000.0d, 0.0000705982d },
            { 2958000.0d, 0.000068069d },
            { 2969000.0d, 0.0000655712d },
            { 2980000.0d, 0.0000631059d },
            { 2991000.0d, 0.0000606739d },
            { 3002000.0d, 0.0000582762d },
            { 3013000.0d, 0.0000559135d },
            { 3024000.0d, 0.000053587d },
            { 3035000.0d, 0.0000512974d },
            { 3046000.0d, 0.0000490457d },
            { 3057000.0d, 0.0000468329d },
            { 3068000.0d, 0.0000446598d },
            { 3079000.0d, 0.0000425274d },
            { 3090000.0d, 0.0000404366d },
            { 3101000.0d, 0.0000383884d },
            { 3112000.0d, 0.0000363837d },
            { 3123000.0d, 0.0000344234d },
            { 3134000.0d, 0.0000325085d },
            { 3145000.0d, 0.00003064d },
            { 3156000.0d, 0.0000288186d },
            { 3167000.0d, 0.0000270457d },
            { 3178000.0d, 0.0000253219d },
            { 3189000.0d, 0.0000236483d },
            { 3200000.0d, 0.0000220259d },
            { 3211000.0d, 0.0000204556d },
            { 3222000.0d, 0.0000189384d },
            { 3233000.0d, 0.0000174752d },
            { 3244000.0d, 0.0000160671d },
            { 3255000.0d, 0.0000147149d },
            { 3266000.0d, 0.0000134198d },
            { 3277000.0d, 0.0000121827d },
            { 3288000.0d, 0.0000110045d },
            { 3299000.0d, 0.00000988627d },
            { 3310000.0d, 0.00000882892d },
            { 3321000.0d, 0.00000783348d },
            { 3332000.0d, 0.00000690091d },
            { 3343000.0d, 0.00000603219d },
            { 3354000.0d, 0.00000522827d },
            { 3365000.0d, 0.00000449014d },
            { 3376000.0d, 0.00000381871d },
            { 3387000.0d, 0.00000321475d },
            { 3398000.0d, 0.00000266729d },
            { 3409000.0d, 0.0000021688d },
            { 3420000.0d, 0.00000171999d },
            { 3431000.0d, 0.00000132157d },
            { 3442000.0d, 0.000000974222d },
            { 3453000.0d, 0.000000678649d },
            { 3464000.0d, 0.000000435528d },
            { 3475000.0d, 0.000000245518d },
            { 3486000.0d, 0.000000109247d },
            { 3497000.0d, 0.0000000272804d },
            { 3508000.0d, 0d },

        }; 
    }
}
    