using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium140";
        public override double halfLife { get; } = 889.2d;
        public override double atomicWeight { get; } = 139.91899d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium140()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00043999999999999996d, new GammaParticle(35200.0, 0.03522)), new(0.0038d, new GammaParticle(75300.0, 0.01647)), new(0.013000000000000001d, new GammaParticle(84400.0, 0.01469)), new(0.0048d, new GammaParticle(109900.0, 0.01128)), new(0.009399999999999999d, new GammaParticle(114600.0, 0.01082)), new(0.0026d, new GammaParticle(119500.0, 0.01038)), new(0.017d, new GammaParticle(120800.0, 0.01026)), new(0.0034999999999999996d, new GammaParticle(136400.0, 0.00909)), new(0.049d, new GammaParticle(140000.0, 0.00886)), new(0.0029d, new GammaParticle(141300.0, 0.00877)), new(0.0025d, new GammaParticle(145700.0, 0.00851)), new(0.00098d, new GammaParticle(150400.0, 0.00824)), new(0.0062d, new GammaParticle(158500.0, 0.00782)), new(0.0008799999999999999d, new GammaParticle(163600.0, 0.00758)), new(0.00039d, new GammaParticle(189600.0, 0.00654)), new(0.00098d, new GammaParticle(195400.0, 0.00635)), new(0.0068000000000000005d, new GammaParticle(199900.0, 0.0062)), new(0.00098d, new GammaParticle(204900.0, 0.00605)), new(0.0049d, new GammaParticle(220600.0, 0.00562)), new(0.0078000000000000005d, new GammaParticle(220700.0, 0.00562)), new(0.098d, new GammaParticle(225400.0, 0.0055)), new(0.00098d, new GammaParticle(237000.0, 0.00523)), new(0.0018d, new GammaParticle(255600.0, 0.00485)), new(0.0016d, new GammaParticle(260600.0, 0.00476)), new(0.0026d, new GammaParticle(267500.0, 0.00463)), new(0.0048d, new GammaParticle(279000.0, 0.00444)), new(0.0013d, new GammaParticle(306000.0, 0.00405)), new(0.0008799999999999999d, new GammaParticle(308700.0, 0.00402)), new(0.0024d, new GammaParticle(311400.0, 0.00398)), new(0.0017000000000000001d, new GammaParticle(312400.0, 0.00397)), new(0.00049d, new GammaParticle(335500.0, 0.0037)), new(0.018000000000000002d, new GammaParticle(339800.0, 0.00365)), new(0.00098d, new GammaParticle(339800.0, 0.00365)), new(0.021d, new GammaParticle(341300.0, 0.00363)), new(0.009000000000000001d, new GammaParticle(344900.0, 0.00359)), new(0.0021d, new GammaParticle(370300.0, 0.00335)), new(0.0016d, new GammaParticle(409500.0, 0.00303)), new(0.0015d, new GammaParticle(415300.0, 0.00299)), new(0.00107d, new GammaParticle(425600.0, 0.00291)), new(0.00098d, new GammaParticle(427000.0, 0.0029)), new(0.0005899999999999999d, new GammaParticle(431900.0, 0.00287)), new(0.0005899999999999999d, new GammaParticle(436300.0, 0.00284)), new(0.0014000000000000002d, new GammaParticle(445200.0, 0.00278)), new(0.0012d, new GammaParticle(468500.0, 0.00265)), new(0.001d, new GammaParticle(481100.0, 0.00258)), new(0.005600000000000001d, new GammaParticle(503300.0, 0.00246)), new(0.0015d, new GammaParticle(520500.0, 0.00238)), new(0.0015d, new GammaParticle(533900.0, 0.00232)), new(0.0032d, new GammaParticle(565600.0, 0.00219)), new(0.0029d, new GammaParticle(572200.0, 0.00217)), new(0.0039000000000000003d, new GammaParticle(576300.0, 0.00215)), new(0.0017000000000000001d, new GammaParticle(586300.0, 0.00211)), new(0.0021d, new GammaParticle(604200.0, 0.00205)), new(0.0014000000000000002d, new GammaParticle(608300.0, 0.00204)), new(0.0005899999999999999d, new GammaParticle(630500.0, 0.00197)), new(0.0024d, new GammaParticle(648900.0, 0.00191)), new(0.0017000000000000001d, new GammaParticle(652500.0, 0.0019)), new(0.0032d, new GammaParticle(668200.0, 0.00186)), new(0.00039d, new GammaParticle(671600.0, 0.00185)), new(0.0027d, new GammaParticle(701000.0, 0.00177)), new(0.0022d, new GammaParticle(725800.0, 0.00171)), new(0.0055000000000000005d, new GammaParticle(761500.0, 0.00163)), new(0.004d, new GammaParticle(774700.0, 0.0016)), new(0.0005899999999999999d, new GammaParticle(808300.0, 0.00153)), new(0.0025d, new GammaParticle(811000.0, 0.00153)), new(0.003d, new GammaParticle(814500.0, 0.00152)), new(0.0073d, new GammaParticle(825500.0, 0.0015)), new(0.0060999999999999995d, new GammaParticle(844800.0, 0.00147)), new(0.001d, new GammaParticle(855800.0, 0.00145)), new(0.00039d, new GammaParticle(858000.0, 0.00145)), new(0.002d, new GammaParticle(862000.0, 0.00144)), new(0.0018d, new GammaParticle(863500.0, 0.00144)), new(0.004699999999999999d, new GammaParticle(874200.0, 0.00142)), new(0.0009d, new GammaParticle(926300.0, 0.00134)), new(0.0028000000000000004d, new GammaParticle(951100.0, 0.0013)), new(0.0018d, new GammaParticle(967000.0, 0.00128)), new(0.0012d, new GammaParticle(999900.0, 0.00124)), new(0.0015d, new GammaParticle(1017800.0, 0.00122)), new(0.0015d, new GammaParticle(1018200.0, 0.00122)), new(0.0022d, new GammaParticle(1022600.0, 0.00121)), new(0.0018d, new GammaParticle(1046900.0, 0.00118)), new(0.0008799999999999999d, new GammaParticle(1053500.0, 0.00118)), new(0.00029d, new GammaParticle(1065500.0, 0.00116)), new(0.0038d, new GammaParticle(1089100.0, 0.00114)), new(0.0012d, new GammaParticle(1093900.0, 0.00113)), new(0.0051d, new GammaParticle(1098000.0, 0.00113)), new(0.0022d, new GammaParticle(1116000.0, 0.00111)), new(0.0023d, new GammaParticle(1119600.0, 0.00111)), new(0.018000000000000002d, new GammaParticle(1138100.0, 0.00109)), new(0.0067d, new GammaParticle(1166700.0, 0.00106)), new(0.0028000000000000004d, new GammaParticle(1173300.0, 0.00106)), new(0.0014000000000000002d, new GammaParticle(1188900.0, 0.00104)), new(0.0040999999999999995d, new GammaParticle(1249500.0, 0.00099)), new(0.0025d, new GammaParticle(1254700.0, 0.00099)), new(0.016d, new GammaParticle(1274200.0, 0.00097)), new(0.0055000000000000005d, new GammaParticle(1278100.0, 0.00097)), new(0.0055000000000000005d, new GammaParticle(1278100.0, 0.00097)), new(0.0052d, new GammaParticle(1283000.0, 0.00097)), new(0.0052d, new GammaParticle(1283000.0, 0.00097)), new(0.0043d, new GammaParticle(1324900.0, 0.00094)), new(0.003d, new GammaParticle(1330000.0, 0.00093)), new(0.012d, new GammaParticle(1393500.0, 0.00089)), new(0.0015d, new GammaParticle(1397500.0, 0.00089)), new(0.00107d, new GammaParticle(1427100.0, 0.00087)), new(0.0014000000000000002d, new GammaParticle(1444400.0, 0.00086)), new(0.00107d, new GammaParticle(1479900.0, 0.00084)), new(0.013000000000000001d, new GammaParticle(1530200.0, 0.00081)), new(0.0043d, new GammaParticle(1578100.0, 0.00079)), new(0.00049d, new GammaParticle(1594700.0, 0.00078)), new(0.0014000000000000002d, new GammaParticle(1596100.0, 0.00078)), new(0.0005899999999999999d, new GammaParticle(1619100.0, 0.00077)), new(0.00029d, new GammaParticle(1623000.0, 0.00076)), new(0.0016d, new GammaParticle(1642300.0, 0.00075)), new(0.0043d, new GammaParticle(1670000.0, 0.00074)), new(0.0008799999999999999d, new GammaParticle(1672200.0, 0.00074)), new(0.0018d, new GammaParticle(1677500.0, 0.00074)), new(0.0014000000000000002d, new GammaParticle(1786300.0, 0.00069)), new(0.00107d, new GammaParticle(1815500.0, 0.00068)), new(0.0021d, new GammaParticle(1959400.0, 0.00063)), new(0.0013d, new GammaParticle(2017500.0, 0.00061)), new(0.37799999999999995d, new GammaParticle(511000.0, 0.00243)), new(0.1165574517926d, new GammaParticle(6109.0, 0.20295)), new(0.19780961551990056d, new GammaParticle(38171.0, 0.03248)), new(0.35913147334767714d, new GammaParticle(38724.0, 0.03202)), new(0.11134391060654121d, new GammaParticle(43934.0, 0.02822)), new(0.1399592956324223d, new GammaParticle(44387.0, 0.02793)), new(0.02861538502588109d, new GammaParticle(44938.0, 0.02759)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 200.0d, 0.000000000000289839d },
            { 400.0d, 0.000000000000621735d },
            { 600.0d, 0.00000000000133709d },
            { 800.0d, 0.00000000000331953d },
            { 1000.0d, 0.00000000000610644d },
            { 1500.0d, 0.0000000000166699d },
            { 2000.0d, 0.0000000000325305d },
            { 2500.0d, 0.0000000000881922d },
            { 3000.0d, 0.00000000094149d },
            { 3500.0d, 0.00000000298455d },
            { 4000.0d, 0.00000000556702d },
            { 4500.0d, 0.0000000086972d },
            { 5000.0d, 0.0000000123704d },
            { 5500.0d, 0.0000000165868d },
            { 6000.0d, 0.0000000213465d },
            { 6500.0d, 0.000000026658d },
            { 7000.0d, 0.0000000325165d },
            { 7500.0d, 0.000000038922d },
            { 8000.0d, 0.0000000458747d },
            { 8500.0d, 0.0000000534393d },
            { 9000.0d, 0.0000000615671d },
            { 9500.0d, 0.0000000702581d },
            { 10000.0d, 0.0000000795124d },
            { 11000.0d, 0.000000104882d },
            { 12000.0d, 0.000000134235d },
            { 13000.0d, 0.00000016769d },
            { 14000.0d, 0.00000020518d },
            { 15000.0d, 0.000000246717d },
            { 16000.0d, 0.000000296061d },
            { 17000.0d, 0.000000350788d },
            { 18000.0d, 0.000000410846d },
            { 19000.0d, 0.000000476244d },
            { 20000.0d, 0.000000546979d },
            { 21000.0d, 0.000000625301d },
            { 22000.0d, 0.000000709713d },
            { 23000.0d, 0.000000800218d },
            { 24000.0d, 0.000000896813d },
            { 25000.0d, 0.000000999521d },
            { 26000.0d, 0.00000110927d },
            { 27000.0d, 0.00000122542d },
            { 28000.0d, 0.00000134799d },
            { 29000.0d, 0.00000147697d },
            { 30000.0d, 0.00000161236d },
            { 31000.0d, 0.0000017542d },
            { 32000.0d, 0.00000190247d },
            { 33000.0d, 0.00000205714d },
            { 34000.0d, 0.00000221823d },
            { 35000.0d, 0.00000238573d },
            { 36000.0d, 0.0000025591d },
            { 37000.0d, 0.00000273869d },
            { 38000.0d, 0.00000292449d },
            { 39000.0d, 0.00000311651d },
            { 40000.0d, 0.00000331474d },
            { 41000.0d, 0.00000351826d },
            { 42000.0d, 0.00000372769d },
            { 43000.0d, 0.00000394302d },
            { 44000.0d, 0.00000416424d },
            { 45000.0d, 0.00000439134d },
            { 46000.0d, 0.00000462322d },
            { 47000.0d, 0.00000486061d },
            { 48000.0d, 0.00000510353d },
            { 49000.0d, 0.00000535192d },
            { 50000.0d, 0.00000560581d },
            { 51000.0d, 0.00000586401d },
            { 52000.0d, 0.00000612731d },
            { 53000.0d, 0.00000639567d },
            { 54000.0d, 0.00000666913d },
            { 55000.0d, 0.00000694766d },
            { 56000.0d, 0.00000723006d },
            { 57000.0d, 0.00000751711d },
            { 58000.0d, 0.00000780882d },
            { 59000.0d, 0.00000810519d },
            { 60000.0d, 0.00000840622d },
            { 61000.0d, 0.00000871069d },
            { 62000.0d, 0.00000901941d },
            { 63000.0d, 0.00000933237d },
            { 64000.0d, 0.00000964959d },
            { 65000.0d, 0.00000997102d },
            { 66000.0d, 0.0000102955d },
            { 67000.0d, 0.0000106239d },
            { 68000.0d, 0.0000109562d },
            { 69000.0d, 0.0000112922d },
            { 70000.0d, 0.0000116321d },
            { 71000.0d, 0.0000119747d },
            { 72000.0d, 0.0000123208d },
            { 73000.0d, 0.0000126703d },
            { 74000.0d, 0.0000130233d },
            { 75000.0d, 0.0000133798d },
            { 76000.0d, 0.0000137387d },
            { 77000.0d, 0.0000141007d },
            { 78000.0d, 0.0000144658d },
            { 79000.0d, 0.0000148341d },
            { 80000.0d, 0.0000152054d },
            { 81000.0d, 0.0000155789d },
            { 82000.0d, 0.0000159552d },
            { 83000.0d, 0.0000163342d },
            { 84000.0d, 0.0000167161d },
            { 85000.0d, 0.0000171007d },
            { 86000.0d, 0.0000174872d },
            { 87000.0d, 0.0000178762d },
            { 88000.0d, 0.0000182677d },
            { 89000.0d, 0.0000186616d },
            { 90000.0d, 0.000019058d },
            { 91000.0d, 0.0000194562d },
            { 92000.0d, 0.0000198565d },
            { 93000.0d, 0.0000202591d },
            { 94000.0d, 0.0000206638d },
            { 95000.0d, 0.0000210708d },
            { 96000.0d, 0.0000214792d },
            { 97000.0d, 0.0000218895d },
            { 98000.0d, 0.0000223018d },
            { 99000.0d, 0.0000227161d },
            { 100000.0d, 0.0000231323d },
            { 105000.0d, 0.0000252371d },
            { 110000.0d, 0.0000273797d },
            { 115000.0d, 0.0000295553d },
            { 120000.0d, 0.0000317595d },
            { 125000.0d, 0.0000339879d },
            { 130000.0d, 0.0000362367d },
            { 135000.0d, 0.0000385025d },
            { 140000.0d, 0.0000407821d },
            { 145000.0d, 0.0000430726d },
            { 150000.0d, 0.0000453713d },
            { 155000.0d, 0.0000476759d },
            { 160000.0d, 0.000049984d },
            { 165000.0d, 0.0000522935d },
            { 170000.0d, 0.0000546026d },
            { 175000.0d, 0.0000569096d },
            { 180000.0d, 0.0000592128d },
            { 185000.0d, 0.0000615107d },
            { 190000.0d, 0.000063802d },
            { 195000.0d, 0.0000660853d },
            { 200000.0d, 0.0000683596d },
            { 205000.0d, 0.0000706235d },
            { 210000.0d, 0.0000728764d },
            { 215000.0d, 0.000075117d },
            { 220000.0d, 0.0000773446d },
            { 225000.0d, 0.0000795584d },
            { 230000.0d, 0.0000817575d },
            { 235000.0d, 0.0000839413d },
            { 240000.0d, 0.0000861091d },
            { 245000.0d, 0.0000882603d },
            { 250000.0d, 0.0000903943d },
            { 255000.0d, 0.0000925106d },
            { 260000.0d, 0.0000946086d },
            { 265000.0d, 0.000096688d },
            { 270000.0d, 0.0000987483d },
            { 275000.0d, 0.000100789d },
            { 280000.0d, 0.00010281d },
            { 285000.0d, 0.00010481d },
            { 290000.0d, 0.00010679d },
            { 295000.0d, 0.000108749d },
            { 300000.0d, 0.000110687d },
            { 305000.0d, 0.000112602d },
            { 310000.0d, 0.000114497d },
            { 315000.0d, 0.000116369d },
            { 320000.0d, 0.000118219d },
            { 325000.0d, 0.000120047d },
            { 330000.0d, 0.000121852d },
            { 335000.0d, 0.000123634d },
            { 340000.0d, 0.000125393d },
            { 345000.0d, 0.000127129d },
            { 350000.0d, 0.000128841d },
            { 355000.0d, 0.000130529d },
            { 360000.0d, 0.000132194d },
            { 365000.0d, 0.000133836d },
            { 370000.0d, 0.000135453d },
            { 375000.0d, 0.000137046d },
            { 380000.0d, 0.000138616d },
            { 385000.0d, 0.000140161d },
            { 390000.0d, 0.000141682d },
            { 395000.0d, 0.000143178d },
            { 400000.0d, 0.00014465d },
            { 405000.0d, 0.000146098d },
            { 410000.0d, 0.00014752d },
            { 415000.0d, 0.000148919d },
            { 420000.0d, 0.000150292d },
            { 425000.0d, 0.00015164d },
            { 430000.0d, 0.000152964d },
            { 435000.0d, 0.000154264d },
            { 440000.0d, 0.000155538d },
            { 445000.0d, 0.000156787d },
            { 450000.0d, 0.000158011d },
            { 455000.0d, 0.000159211d },
            { 460000.0d, 0.000160385d },
            { 465000.0d, 0.000161535d },
            { 470000.0d, 0.000162659d },
            { 475000.0d, 0.000163759d },
            { 480000.0d, 0.000164833d },
            { 485000.0d, 0.000165883d },
            { 490000.0d, 0.000166907d },
            { 495000.0d, 0.000167908d },
            { 500000.0d, 0.000168882d },
            { 505000.0d, 0.000169832d },
            { 510000.0d, 0.000170758d },
            { 515000.0d, 0.000171658d },
            { 520000.0d, 0.000172533d },
            { 525000.0d, 0.000173384d },
            { 530000.0d, 0.00017421d },
            { 535000.0d, 0.00017501d },
            { 540000.0d, 0.000175786d },
            { 545000.0d, 0.000176539d },
            { 550000.0d, 0.000177266d },
            { 555000.0d, 0.000177969d },
            { 560000.0d, 0.000178647d },
            { 565000.0d, 0.0001793d },
            { 570000.0d, 0.000179929d },
            { 575000.0d, 0.000180534d },
            { 580000.0d, 0.000181115d },
            { 585000.0d, 0.000181671d },
            { 590000.0d, 0.000182203d },
            { 595000.0d, 0.000182711d },
            { 600000.0d, 0.000183195d },
            { 605000.0d, 0.000183656d },
            { 610000.0d, 0.000184092d },
            { 615000.0d, 0.000184504d },
            { 620000.0d, 0.000184893d },
            { 625000.0d, 0.000185258d },
            { 630000.0d, 0.0001856d },
            { 635000.0d, 0.000185918d },
            { 640000.0d, 0.000186213d },
            { 645000.0d, 0.000186485d },
            { 650000.0d, 0.000186733d },
            { 655000.0d, 0.000186958d },
            { 660000.0d, 0.000187161d },
            { 665000.0d, 0.000187339d },
            { 670000.0d, 0.000187497d },
            { 675000.0d, 0.00018763d },
            { 680000.0d, 0.000187742d },
            { 685000.0d, 0.000187831d },
            { 690000.0d, 0.000187897d },
            { 695000.0d, 0.000187941d },
            { 700000.0d, 0.000187964d },
            { 705000.0d, 0.000187963d },
            { 710000.0d, 0.000187942d },
            { 715000.0d, 0.000187898d },
            { 720000.0d, 0.000187833d },
            { 725000.0d, 0.000187747d },
            { 730000.0d, 0.000187638d },
            { 735000.0d, 0.000187509d },
            { 740000.0d, 0.000187358d },
            { 745000.0d, 0.000187188d },
            { 750000.0d, 0.000186995d },
            { 755000.0d, 0.000186782d },
            { 760000.0d, 0.000186548d },
            { 765000.0d, 0.000186294d },
            { 770000.0d, 0.000186019d },
            { 775000.0d, 0.000185725d },
            { 780000.0d, 0.000185411d },
            { 785000.0d, 0.000185075d },
            { 790000.0d, 0.000184722d },
            { 795000.0d, 0.000184348d },
            { 800000.0d, 0.000183955d },
            { 805000.0d, 0.000183543d },
            { 810000.0d, 0.000183112d },
            { 815000.0d, 0.000182661d },
            { 820000.0d, 0.000182192d },
            { 825000.0d, 0.000181704d },
            { 830000.0d, 0.000181197d },
            { 835000.0d, 0.000180674d },
            { 840000.0d, 0.00018013d },
            { 845000.0d, 0.00017957d },
            { 850000.0d, 0.000178992d },
            { 855000.0d, 0.000178396d },
            { 860000.0d, 0.000177783d },
            { 865000.0d, 0.000177153d },
            { 870000.0d, 0.000176505d },
            { 875000.0d, 0.000175842d },
            { 880000.0d, 0.00017516d },
            { 885000.0d, 0.000174463d },
            { 890000.0d, 0.000173749d },
            { 895000.0d, 0.000173019d },
            { 900000.0d, 0.000172272d },
            { 905000.0d, 0.000171509d },
            { 910000.0d, 0.000170729d },
            { 915000.0d, 0.000169933d },
            { 920000.0d, 0.000169122d },
            { 925000.0d, 0.000168294d },
            { 930000.0d, 0.00016745d },
            { 935000.0d, 0.000166591d },
            { 940000.0d, 0.000165718d },
            { 945000.0d, 0.000164827d },
            { 950000.0d, 0.000163924d },
            { 955000.0d, 0.000163005d },
            { 960000.0d, 0.000162071d },
            { 965000.0d, 0.000161124d },
            { 970000.0d, 0.000160162d },
            { 975000.0d, 0.000159186d },
            { 980000.0d, 0.000158197d },
            { 985000.0d, 0.000157194d },
            { 990000.0d, 0.000156178d },
            { 995000.0d, 0.000155148d },
            { 1000000.0d, 0.000154106d },
            { 1005000.0d, 0.000153051d },
            { 1010000.0d, 0.000151984d },
            { 1015000.0d, 0.000150904d },
            { 1020000.0d, 0.000149812d },
            { 1025000.0d, 0.000148709d },
            { 1030000.0d, 0.000147594d },
            { 1035000.0d, 0.000146467d },
            { 1040000.0d, 0.00014533d },
            { 1045000.0d, 0.000144182d },
            { 1050000.0d, 0.000143022d },
            { 1055000.0d, 0.000141853d },
            { 1060000.0d, 0.000140673d },
            { 1065000.0d, 0.000139483d },
            { 1070000.0d, 0.000138282d },
            { 1075000.0d, 0.000137074d },
            { 1080000.0d, 0.000135855d },
            { 1085000.0d, 0.000134627d },
            { 1090000.0d, 0.000133391d },
            { 1095000.0d, 0.000132146d },
            { 1100000.0d, 0.000130892d },
            { 1105000.0d, 0.000129631d },
            { 1110000.0d, 0.000128361d },
            { 1115000.0d, 0.000127084d },
            { 1120000.0d, 0.0001258d },
            { 1125000.0d, 0.000124508d },
            { 1130000.0d, 0.00012321d },
            { 1135000.0d, 0.000121904d },
            { 1140000.0d, 0.000120594d },
            { 1145000.0d, 0.000119276d },
            { 1150000.0d, 0.000117953d },
            { 1155000.0d, 0.000116623d },
            { 1160000.0d, 0.00011529d },
            { 1165000.0d, 0.000113951d },
            { 1170000.0d, 0.000112607d },
            { 1175000.0d, 0.000111258d },
            { 1180000.0d, 0.000109905d },
            { 1185000.0d, 0.000108549d },
            { 1190000.0d, 0.000107188d },
            { 1195000.0d, 0.000105825d },
            { 1200000.0d, 0.000104458d },
            { 1205000.0d, 0.000103088d },
            { 1210000.0d, 0.000101716d },
            { 1215000.0d, 0.000100341d },
            { 1220000.0d, 0.0000989643d },
            { 1225000.0d, 0.0000975859d },
            { 1230000.0d, 0.000096206d },
            { 1235000.0d, 0.000094825d },
            { 1240000.0d, 0.000093443d },
            { 1245000.0d, 0.0000920606d },
            { 1250000.0d, 0.0000906778d },
            { 1255000.0d, 0.000089295d },
            { 1260000.0d, 0.0000879126d },
            { 1265000.0d, 0.0000865307d },
            { 1270000.0d, 0.0000851497d },
            { 1275000.0d, 0.0000837699d },
            { 1280000.0d, 0.0000823916d },
            { 1285000.0d, 0.0000810151d },
            { 1290000.0d, 0.0000796407d },
            { 1295000.0d, 0.0000782687d },
            { 1300000.0d, 0.0000768995d },
            { 1305000.0d, 0.0000755333d },
            { 1310000.0d, 0.0000741704d },
            { 1315000.0d, 0.0000728111d },
            { 1320000.0d, 0.0000714559d },
            { 1325000.0d, 0.0000701047d },
            { 1330000.0d, 0.0000687572d },
            { 1335000.0d, 0.0000674139d },
            { 1340000.0d, 0.0000660751d },
            { 1345000.0d, 0.0000647409d },
            { 1350000.0d, 0.0000634119d },
            { 1355000.0d, 0.0000620881d },
            { 1360000.0d, 0.0000607701d },
            { 1365000.0d, 0.000059458d },
            { 1370000.0d, 0.0000581522d },
            { 1375000.0d, 0.0000568531d },
            { 1380000.0d, 0.0000555609d },
            { 1385000.0d, 0.0000542759d },
            { 1390000.0d, 0.0000529986d },
            { 1395000.0d, 0.000051729d },
            { 1400000.0d, 0.0000504671d },
            { 1405000.0d, 0.0000492134d },
            { 1410000.0d, 0.000047968d },
            { 1415000.0d, 0.0000467314d },
            { 1420000.0d, 0.0000455037d },
            { 1425000.0d, 0.0000442856d },
            { 1430000.0d, 0.000043077d },
            { 1435000.0d, 0.0000418786d },
            { 1440000.0d, 0.0000406904d },
            { 1445000.0d, 0.000039513d },
            { 1450000.0d, 0.0000383466d },
            { 1455000.0d, 0.0000371916d },
            { 1460000.0d, 0.0000360482d },
            { 1465000.0d, 0.0000349168d },
            { 1470000.0d, 0.0000337979d },
            { 1475000.0d, 0.0000326917d },
            { 1480000.0d, 0.0000315985d },
            { 1485000.0d, 0.0000305187d },
            { 1490000.0d, 0.0000294526d },
            { 1495000.0d, 0.0000284007d },
            { 1500000.0d, 0.0000273631d },
            { 1505000.0d, 0.0000263404d },
            { 1510000.0d, 0.0000253327d },
            { 1515000.0d, 0.0000243401d },
            { 1520000.0d, 0.0000233621d },
            { 1525000.0d, 0.000022399d },
            { 1530000.0d, 0.0000214511d },
            { 1535000.0d, 0.0000205187d },
            { 1540000.0d, 0.0000196022d },
            { 1545000.0d, 0.000018702d },
            { 1550000.0d, 0.0000178183d },
            { 1555000.0d, 0.0000169515d },
            { 1560000.0d, 0.000016102d },
            { 1565000.0d, 0.0000152701d },
            { 1570000.0d, 0.0000144562d },
            { 1575000.0d, 0.0000136605d },
            { 1580000.0d, 0.0000128836d },
            { 1585000.0d, 0.0000121256d },
            { 1590000.0d, 0.000011387d },
            { 1595000.0d, 0.000010668d },
            { 1600000.0d, 0.00000996918d },
            { 1605000.0d, 0.00000929073d },
            { 1610000.0d, 0.00000863307d },
            { 1615000.0d, 0.00000799653d },
            { 1620000.0d, 0.00000738148d },
            { 1625000.0d, 0.00000678828d },
            { 1630000.0d, 0.00000621728d },
            { 1635000.0d, 0.00000566886d },
            { 1640000.0d, 0.00000514337d },
            { 1645000.0d, 0.00000464117d },
            { 1650000.0d, 0.00000416263d },
            { 1655000.0d, 0.00000370811d },
            { 1660000.0d, 0.00000327799d },
            { 1665000.0d, 0.00000287261d },
            { 1670000.0d, 0.00000249236d },
            { 1675000.0d, 0.00000213759d },
            { 1680000.0d, 0.00000180867d },
            { 1685000.0d, 0.00000150597d },
            { 1690000.0d, 0.00000122986d },
            { 1695000.0d, 0.000000980694d },
            { 1700000.0d, 0.000000758846d },
            { 1705000.0d, 0.000000564677d },
            { 1710000.0d, 0.000000398545d },
            { 1715000.0d, 0.000000260808d },
            { 1720000.0d, 0.000000151816d },
            { 1725000.0d, 0.0000000719101d },
            { 1730000.0d, 0.0000000214106d },
            { 1735000.0d, 0.000000000590971d },
            { 1736000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    