using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium117";
        public override double halfLife { get; } = 8964.0d;
        public override double atomicWeight { get; } = 116.90723d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium117()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.003906d, new GammaParticle(71120.0, 0.01743)), new(0.032643d, new GammaParticle(89730.0, 0.01382)), new(0.0002232d, new GammaParticle(105400.0, 0.01176)), new(0.0001116d, new GammaParticle(131400.0, 0.00944)), new(0.0002232d, new GammaParticle(132700.0, 0.00934)), new(0.0025109999999999998d, new GammaParticle(160800.0, 0.00771)), new(0.0002511d, new GammaParticle(171050.0, 0.00725)), new(8.37e-05d, new GammaParticle(172200.0, 0.0072)), new(0.0009765d, new GammaParticle(179350.0, 0.00691)), new(0.011718d, new GammaParticle(220920.0, 0.00561)), new(0.000558d, new GammaParticle(221000.0, 0.00561)), new(0.27899999999999997d, new GammaParticle(273349.0, 0.00454)), new(0.001116d, new GammaParticle(279800.0, 0.00443)), new(0.000837d, new GammaParticle(284790.0, 0.00435)), new(0.006417000000000001d, new GammaParticle(292050.0, 0.00425)), new(0.0006975000000000001d, new GammaParticle(310000.0, 0.004)), new(0.000837d, new GammaParticle(314400.0, 0.00394)), new(0.178839d, new GammaParticle(344459.0, 0.0036)), new(0.0003627d, new GammaParticle(385500.0, 0.00322)), new(0.003069d, new GammaParticle(387960.0, 0.0032)), new(0.001953d, new GammaParticle(397200.0, 0.00312)), new(0.0001674d, new GammaParticle(416900.0, 0.00297)), new(0.0018414d, new GammaParticle(419790.0, 0.00295)), new(0.09792899999999999d, new GammaParticle(434190.0, 0.00286)), new(0.001116d, new GammaParticle(439390.0, 0.00282)), new(0.0003627d, new GammaParticle(453800.0, 0.00273)), new(0.007533d, new GammaParticle(463040.0, 0.00268)), new(0.001116d, new GammaParticle(497770.0, 0.00249)), new(0.0001395d, new GammaParticle(500600.0, 0.00248)), new(0.000279d, new GammaParticle(526600.0, 0.00235)), new(0.0013950000000000002d, new GammaParticle(527000.0, 0.00235)), new(0.0001395d, new GammaParticle(597600.0, 0.00207)), new(0.0011439d, new GammaParticle(627010.0, 0.00198)), new(0.0001674d, new GammaParticle(644500.0, 0.00192)), new(0.001116d, new GammaParticle(660830.0, 0.00188)), new(0.0001116d, new GammaParticle(688000.0, 0.0018)), new(0.0023994d, new GammaParticle(699580.0, 0.00177)), new(0.005580000000000001d, new GammaParticle(712710.0, 0.00174)), new(0.0020088d, new GammaParticle(716430.0, 0.00173)), new(0.0023994d, new GammaParticle(728640.0, 0.0017)), new(0.0006138d, new GammaParticle(736140.0, 0.00168)), new(0.005580000000000001d, new GammaParticle(748050.0, 0.00166)), new(0.000279d, new GammaParticle(757600.0, 0.00164)), new(0.000558d, new GammaParticle(787400.0, 0.00157)), new(0.022599d, new GammaParticle(831800.0, 0.00149)), new(0.008091000000000001d, new GammaParticle(840210.0, 0.00148)), new(0.0011997d, new GammaParticle(850720.0, 0.00146)), new(0.0027900000000000004d, new GammaParticle(861300.0, 0.00144)), new(0.006138d, new GammaParticle(862600.0, 0.00144)), new(0.039618d, new GammaParticle(880710.0, 0.00141)), new(0.015345d, new GammaParticle(945670.0, 0.00131)), new(0.0022041d, new GammaParticle(949630.0, 0.00131)), new(0.0013671d, new GammaParticle(952330.0, 0.0013)), new(0.006138d, new GammaParticle(963110.0, 0.00129)), new(0.000837d, new GammaParticle(965800.0, 0.00128)), new(0.004464d, new GammaParticle(969300.0, 0.00128)), new(0.000558d, new GammaParticle(970400.0, 0.00128)), new(0.0007254d, new GammaParticle(975500.0, 0.00127)), new(0.0001674d, new GammaParticle(994300.0, 0.00125)), new(0.000837d, new GammaParticle(1012300.0, 0.00122)), new(0.0023994d, new GammaParticle(1035610.0, 0.0012)), new(0.0001674d, new GammaParticle(1036000.0, 0.0012)), new(0.037944d, new GammaParticle(1051700.0, 0.00118)), new(0.007254d, new GammaParticle(1052700.0, 0.00118)), new(0.000558d, new GammaParticle(1061100.0, 0.00117)), new(0.010323d, new GammaParticle(1116600.0, 0.00111)), new(0.0023994d, new GammaParticle(1120050.0, 0.00111)), new(0.004464d, new GammaParticle(1125100.0, 0.0011)), new(0.016739999999999998d, new GammaParticle(1142430.0, 0.00109)), new(0.0013950000000000002d, new GammaParticle(1143500.0, 0.00108)), new(0.0013113d, new GammaParticle(1183400.0, 0.00105)), new(0.006138d, new GammaParticle(1229110.0, 0.00101)), new(0.0027900000000000004d, new GammaParticle(1232300.0, 0.00101)), new(0.011997d, new GammaParticle(1247890.0, 0.00099)), new(0.000279d, new GammaParticle(1249300.0, 0.00099)), new(0.011439d, new GammaParticle(1260000.0, 0.00098)), new(0.007254d, new GammaParticle(1272730.0, 0.00097)), new(0.0002511d, new GammaParticle(1276000.0, 0.00097)), new(0.006696d, new GammaParticle(1291000.0, 0.00096)), new(0.183582d, new GammaParticle(1303270.0, 0.00095)), new(0.005859d, new GammaParticle(1314710.0, 0.00094)), new(0.000279d, new GammaParticle(1316000.0, 0.00094)), new(0.0001674d, new GammaParticle(1317500.0, 0.00094)), new(0.016182000000000002d, new GammaParticle(1337570.0, 0.00093)), new(0.0023994d, new GammaParticle(1362400.0, 0.00091)), new(0.0011997d, new GammaParticle(1404400.0, 0.00088)), new(0.012834000000000002d, new GammaParticle(1408720.0, 0.00088)), new(0.003348d, new GammaParticle(1422270.0, 0.00087)), new(0.005580000000000001d, new GammaParticle(1430970.0, 0.00087)), new(0.001116d, new GammaParticle(1433500.0, 0.00086)), new(0.006138d, new GammaParticle(1450150.0, 0.00085)), new(0.00039059999999999995d, new GammaParticle(1468900.0, 0.00084)), new(0.0041849999999999995d, new GammaParticle(1475460.0, 0.00084)), new(0.0006696d, new GammaParticle(1511900.0, 0.00082)), new(0.0008928d, new GammaParticle(1521000.0, 0.00082)), new(0.014229d, new GammaParticle(1562240.0, 0.00079)), new(0.000837d, new GammaParticle(1563600.0, 0.00079)), new(0.111879d, new GammaParticle(1576620.0, 0.00079)), new(0.0013950000000000002d, new GammaParticle(1578400.0, 0.00079)), new(0.0005301d, new GammaParticle(1583100.0, 0.00078)), new(0.000279d, new GammaParticle(1596000.0, 0.00078)), new(0.000558d, new GammaParticle(1597300.0, 0.00078)), new(0.0027900000000000004d, new GammaParticle(1652100.0, 0.00075)), new(0.006975d, new GammaParticle(1682070.0, 0.00074)), new(0.00039059999999999995d, new GammaParticle(1685800.0, 0.00074)), new(0.010043999999999999d, new GammaParticle(1706930.0, 0.00073)), new(0.020087999999999998d, new GammaParticle(1723060.0, 0.00072)), new(0.0012554999999999999d, new GammaParticle(1739130.0, 0.00071)), new(0.000837d, new GammaParticle(1748700.0, 0.00071)), new(0.0004464d, new GammaParticle(1756800.0, 0.00071)), new(0.0025109999999999998d, new GammaParticle(1856400.0, 0.00067)), new(0.0010602d, new GammaParticle(1867300.0, 0.00066)), new(0.0010881d, new GammaParticle(2012490.0, 0.00062)), new(0.0006417d, new GammaParticle(2030140.0, 0.00061)), new(0.0048d, new GammaParticle(3571.0, 0.3472)), new(0.013000000000000001d, new GammaParticle(24001.0, 0.05166)), new(0.025d, new GammaParticle(24209.0, 0.05121)), new(0.0070999999999999995d, new GammaParticle(27367.0, 0.0453)), new(0.0084d, new GammaParticle(27581.0, 0.04495)), new(0.0013d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00279394d },
            { 200.0d, 0.002769d },
            { 400.0d, 0.00274963d },
            { 600.0d, 0.00273584d },
            { 800.0d, 0.0027249d },
            { 1000.0d, 0.00271615d },
            { 1500.0d, 0.00270266d },
            { 2000.0d, 0.00269872d },
            { 2500.0d, 0.00269727d },
            { 3000.0d, 0.00269652d },
            { 3500.0d, 0.00269477d },
            { 4000.0d, 0.00269272d },
            { 4500.0d, 0.00269039d },
            { 5000.0d, 0.0026878d },
            { 5500.0d, 0.00268503d },
            { 6000.0d, 0.00268207d },
            { 6500.0d, 0.00267911d },
            { 7000.0d, 0.00267606d },
            { 7500.0d, 0.00267294d },
            { 8000.0d, 0.00266974d },
            { 8500.0d, 0.00266656d },
            { 9000.0d, 0.00266334d },
            { 9500.0d, 0.00266009d },
            { 10000.0d, 0.00265682d },
            { 11000.0d, 0.00265023d },
            { 12000.0d, 0.00264357d },
            { 13000.0d, 0.00263686d },
            { 14000.0d, 0.00263011d },
            { 15000.0d, 0.00262331d },
            { 16000.0d, 0.00261647d },
            { 17000.0d, 0.0026096d },
            { 18000.0d, 0.00260271d },
            { 19000.0d, 0.00259579d },
            { 20000.0d, 0.00258884d },
            { 21000.0d, 0.00258188d },
            { 22000.0d, 0.00257491d },
            { 23000.0d, 0.00256793d },
            { 24000.0d, 0.00256093d },
            { 25000.0d, 0.00255393d },
            { 26000.0d, 0.00254693d },
            { 27000.0d, 0.00253993d },
            { 28000.0d, 0.00253292d },
            { 29000.0d, 0.00252592d },
            { 30000.0d, 0.00251891d },
            { 31000.0d, 0.00251192d },
            { 32000.0d, 0.00250493d },
            { 33000.0d, 0.00249794d },
            { 34000.0d, 0.00249097d },
            { 35000.0d, 0.002484d },
            { 36000.0d, 0.00247704d },
            { 37000.0d, 0.00247009d },
            { 38000.0d, 0.00246315d },
            { 39000.0d, 0.00245623d },
            { 40000.0d, 0.00244931d },
            { 41000.0d, 0.00244241d },
            { 42000.0d, 0.00243552d },
            { 43000.0d, 0.00242865d },
            { 44000.0d, 0.00242179d },
            { 45000.0d, 0.00241494d },
            { 46000.0d, 0.00240811d },
            { 47000.0d, 0.00240129d },
            { 48000.0d, 0.00239449d },
            { 49000.0d, 0.0023877d },
            { 50000.0d, 0.00238093d },
            { 51000.0d, 0.00237418d },
            { 52000.0d, 0.00236744d },
            { 53000.0d, 0.00236072d },
            { 54000.0d, 0.00235402d },
            { 55000.0d, 0.00234734d },
            { 56000.0d, 0.00234067d },
            { 57000.0d, 0.00233402d },
            { 58000.0d, 0.0023274d },
            { 59000.0d, 0.00232079d },
            { 60000.0d, 0.0023142d },
            { 61000.0d, 0.00230763d },
            { 62000.0d, 0.00230108d },
            { 63000.0d, 0.00229455d },
            { 64000.0d, 0.00228804d },
            { 65000.0d, 0.00228155d },
            { 66000.0d, 0.00227509d },
            { 67000.0d, 0.00226863d },
            { 68000.0d, 0.00226217d },
            { 69000.0d, 0.0022557d },
            { 70000.0d, 0.00224924d },
            { 71000.0d, 0.00224276d },
            { 72000.0d, 0.00223629d },
            { 73000.0d, 0.0022298d },
            { 74000.0d, 0.00222332d },
            { 75000.0d, 0.00221683d },
            { 76000.0d, 0.00221034d },
            { 77000.0d, 0.00220385d },
            { 78000.0d, 0.00219735d },
            { 79000.0d, 0.00219085d },
            { 80000.0d, 0.00218435d },
            { 81000.0d, 0.00217785d },
            { 82000.0d, 0.00217134d },
            { 83000.0d, 0.00216484d },
            { 84000.0d, 0.00215833d },
            { 85000.0d, 0.00215182d },
            { 86000.0d, 0.00214531d },
            { 87000.0d, 0.0021388d },
            { 88000.0d, 0.00213229d },
            { 89000.0d, 0.00212578d },
            { 90000.0d, 0.00211927d },
            { 91000.0d, 0.00211277d },
            { 92000.0d, 0.00210626d },
            { 93000.0d, 0.00209976d },
            { 94000.0d, 0.00209325d },
            { 95000.0d, 0.00208675d },
            { 96000.0d, 0.00208025d },
            { 97000.0d, 0.00207376d },
            { 98000.0d, 0.00206727d },
            { 99000.0d, 0.00206078d },
            { 100000.0d, 0.00205429d },
            { 107000.0d, 0.00200904d },
            { 114000.0d, 0.00196415d },
            { 121000.0d, 0.00191974d },
            { 128000.0d, 0.001876d },
            { 135000.0d, 0.00183308d },
            { 142000.0d, 0.00179116d },
            { 149000.0d, 0.00175043d },
            { 156000.0d, 0.00171108d },
            { 163000.0d, 0.00167332d },
            { 170000.0d, 0.00163734d },
            { 177000.0d, 0.00160337d },
            { 184000.0d, 0.00157148d },
            { 191000.0d, 0.00154175d },
            { 198000.0d, 0.00151433d },
            { 205000.0d, 0.00148915d },
            { 212000.0d, 0.00146625d },
            { 219000.0d, 0.00144357d },
            { 226000.0d, 0.00142036d },
            { 233000.0d, 0.00139666d },
            { 240000.0d, 0.00137251d },
            { 247000.0d, 0.00134795d },
            { 254000.0d, 0.001323d },
            { 261000.0d, 0.00129773d },
            { 268000.0d, 0.00127216d },
            { 275000.0d, 0.00124634d },
            { 282000.0d, 0.00122032d },
            { 289000.0d, 0.00119414d },
            { 296000.0d, 0.00116785d },
            { 303000.0d, 0.0011415d },
            { 310000.0d, 0.00111513d },
            { 317000.0d, 0.00108881d },
            { 324000.0d, 0.00106257d },
            { 331000.0d, 0.00103647d },
            { 338000.0d, 0.00101057d },
            { 345000.0d, 0.00098492d },
            { 352000.0d, 0.000959564d },
            { 359000.0d, 0.000934372d },
            { 366000.0d, 0.000909325d },
            { 373000.0d, 0.000884471d },
            { 380000.0d, 0.000859856d },
            { 387000.0d, 0.000835529d },
            { 394000.0d, 0.000811537d },
            { 401000.0d, 0.000787931d },
            { 408000.0d, 0.000764762d },
            { 415000.0d, 0.000742062d },
            { 422000.0d, 0.000719765d },
            { 429000.0d, 0.000697895d },
            { 436000.0d, 0.000676499d },
            { 443000.0d, 0.000655622d },
            { 450000.0d, 0.000635313d },
            { 457000.0d, 0.000615625d },
            { 464000.0d, 0.000596562d },
            { 471000.0d, 0.000578109d },
            { 478000.0d, 0.000560313d },
            { 485000.0d, 0.000543222d },
            { 492000.0d, 0.000526881d },
            { 499000.0d, 0.000511339d },
            { 506000.0d, 0.0004966d },
            { 513000.0d, 0.000482633d },
            { 520000.0d, 0.000469483d },
            { 527000.0d, 0.000457176d },
            { 534000.0d, 0.00044547d },
            { 541000.0d, 0.000434295d },
            { 548000.0d, 0.00042368d },
            { 555000.0d, 0.000413658d },
            { 562000.0d, 0.000404263d },
            { 569000.0d, 0.000395527d },
            { 576000.0d, 0.000387484d },
            { 583000.0d, 0.000380167d },
            { 590000.0d, 0.000373611d },
            { 597000.0d, 0.000367849d },
            { 604000.0d, 0.000362917d },
            { 611000.0d, 0.000358848d },
            { 618000.0d, 0.000355679d },
            { 625000.0d, 0.000353443d },
            { 632000.0d, 0.000352135d },
            { 639000.0d, 0.000351065d },
            { 646000.0d, 0.00034998d },
            { 653000.0d, 0.000348884d },
            { 660000.0d, 0.000347779d },
            { 667000.0d, 0.000346665d },
            { 674000.0d, 0.000345545d },
            { 681000.0d, 0.000344422d },
            { 688000.0d, 0.000343297d },
            { 695000.0d, 0.000342173d },
            { 702000.0d, 0.00034105d },
            { 709000.0d, 0.000339932d },
            { 716000.0d, 0.000338821d },
            { 723000.0d, 0.000337719d },
            { 730000.0d, 0.000336628d },
            { 737000.0d, 0.000335551d },
            { 744000.0d, 0.000334483d },
            { 751000.0d, 0.000333421d },
            { 758000.0d, 0.000332367d },
            { 765000.0d, 0.000331323d },
            { 772000.0d, 0.000330289d },
            { 779000.0d, 0.000329271d },
            { 786000.0d, 0.000328268d },
            { 793000.0d, 0.000327284d },
            { 800000.0d, 0.000326319d },
            { 807000.0d, 0.000325377d },
            { 814000.0d, 0.000324444d },
            { 821000.0d, 0.000323481d },
            { 828000.0d, 0.000322485d },
            { 835000.0d, 0.000321457d },
            { 842000.0d, 0.000320398d },
            { 849000.0d, 0.000319309d },
            { 856000.0d, 0.000318189d },
            { 863000.0d, 0.000317039d },
            { 870000.0d, 0.00031586d },
            { 877000.0d, 0.000314653d },
            { 884000.0d, 0.000313418d },
            { 891000.0d, 0.000312156d },
            { 898000.0d, 0.000310867d },
            { 905000.0d, 0.000309552d },
            { 912000.0d, 0.000308212d },
            { 919000.0d, 0.000306842d },
            { 926000.0d, 0.000305438d },
            { 933000.0d, 0.000304001d },
            { 940000.0d, 0.000302534d },
            { 947000.0d, 0.000301033d },
            { 954000.0d, 0.000299502d },
            { 961000.0d, 0.000297939d },
            { 968000.0d, 0.000296346d },
            { 975000.0d, 0.000294723d },
            { 982000.0d, 0.000293069d },
            { 989000.0d, 0.000291385d },
            { 996000.0d, 0.000289672d },
            { 1003000.0d, 0.000287929d },
            { 1010000.0d, 0.000286158d },
            { 1017000.0d, 0.000284359d },
            { 1024000.0d, 0.000282533d },
            { 1031000.0d, 0.00028068d },
            { 1038000.0d, 0.000278801d },
            { 1045000.0d, 0.000276896d },
            { 1052000.0d, 0.000274967d },
            { 1059000.0d, 0.000273012d },
            { 1066000.0d, 0.000271034d },
            { 1073000.0d, 0.00026903d },
            { 1080000.0d, 0.000267003d },
            { 1087000.0d, 0.000264954d },
            { 1094000.0d, 0.000262879d },
            { 1101000.0d, 0.000260781d },
            { 1108000.0d, 0.00025866d },
            { 1115000.0d, 0.000256516d },
            { 1122000.0d, 0.00025435d },
            { 1129000.0d, 0.000252162d },
            { 1136000.0d, 0.000249954d },
            { 1143000.0d, 0.000247726d },
            { 1150000.0d, 0.000245477d },
            { 1157000.0d, 0.000243206d },
            { 1164000.0d, 0.000240915d },
            { 1171000.0d, 0.000238604d },
            { 1178000.0d, 0.000236274d },
            { 1185000.0d, 0.000233923d },
            { 1192000.0d, 0.000231555d },
            { 1199000.0d, 0.000229169d },
            { 1206000.0d, 0.000226766d },
            { 1213000.0d, 0.000224347d },
            { 1220000.0d, 0.000221911d },
            { 1227000.0d, 0.00021946d },
            { 1234000.0d, 0.000216994d },
            { 1241000.0d, 0.000214515d },
            { 1248000.0d, 0.000212022d },
            { 1255000.0d, 0.000209517d },
            { 1262000.0d, 0.000207d },
            { 1269000.0d, 0.000204472d },
            { 1276000.0d, 0.000201933d },
            { 1283000.0d, 0.000199385d },
            { 1290000.0d, 0.000196828d },
            { 1297000.0d, 0.000194262d },
            { 1304000.0d, 0.000191689d },
            { 1311000.0d, 0.000189109d },
            { 1318000.0d, 0.000186524d },
            { 1325000.0d, 0.000183933d },
            { 1332000.0d, 0.000181338d },
            { 1339000.0d, 0.00017874d },
            { 1346000.0d, 0.000176139d },
            { 1353000.0d, 0.000173537d },
            { 1360000.0d, 0.000170933d },
            { 1367000.0d, 0.000168329d },
            { 1374000.0d, 0.000165726d },
            { 1381000.0d, 0.000163125d },
            { 1388000.0d, 0.000160525d },
            { 1395000.0d, 0.00015793d },
            { 1402000.0d, 0.000155338d },
            { 1409000.0d, 0.000152753d },
            { 1416000.0d, 0.000150173d },
            { 1423000.0d, 0.0001476d },
            { 1430000.0d, 0.000145035d },
            { 1437000.0d, 0.00014248d },
            { 1444000.0d, 0.000139934d },
            { 1451000.0d, 0.000137399d },
            { 1458000.0d, 0.000134876d },
            { 1465000.0d, 0.000132366d },
            { 1472000.0d, 0.00012987d },
            { 1479000.0d, 0.000127385d },
            { 1486000.0d, 0.000124909d },
            { 1493000.0d, 0.000122445d },
            { 1500000.0d, 0.000119992d },
            { 1507000.0d, 0.000117552d },
            { 1514000.0d, 0.000115125d },
            { 1521000.0d, 0.000112712d },
            { 1528000.0d, 0.000110315d },
            { 1535000.0d, 0.000107933d },
            { 1542000.0d, 0.000105568d },
            { 1549000.0d, 0.00010322d },
            { 1556000.0d, 0.000100891d },
            { 1563000.0d, 0.000098581d },
            { 1570000.0d, 0.0000962911d },
            { 1577000.0d, 0.0000940223d },
            { 1584000.0d, 0.0000917754d },
            { 1591000.0d, 0.0000895512d },
            { 1598000.0d, 0.0000873505d },
            { 1605000.0d, 0.0000851744d },
            { 1612000.0d, 0.0000830238d },
            { 1619000.0d, 0.0000808994d },
            { 1626000.0d, 0.0000788023d },
            { 1633000.0d, 0.0000767332d },
            { 1640000.0d, 0.0000746932d },
            { 1647000.0d, 0.0000726832d },
            { 1654000.0d, 0.000070704d },
            { 1661000.0d, 0.0000687567d },
            { 1668000.0d, 0.0000668421d },
            { 1675000.0d, 0.0000649612d },
            { 1682000.0d, 0.0000631149d },
            { 1689000.0d, 0.0000613042d },
            { 1696000.0d, 0.0000595301d },
            { 1703000.0d, 0.0000577935d },
            { 1710000.0d, 0.0000560952d },
            { 1717000.0d, 0.0000544364d },
            { 1724000.0d, 0.000052818d },
            { 1731000.0d, 0.0000512409d },
            { 1738000.0d, 0.000049706d },
            { 1745000.0d, 0.0000482144d },
            { 1752000.0d, 0.0000467671d },
            { 1759000.0d, 0.0000453649d },
            { 1766000.0d, 0.0000440089d },
            { 1773000.0d, 0.0000426998d },
            { 1780000.0d, 0.0000414226d },
            { 1787000.0d, 0.0000401623d },
            { 1794000.0d, 0.0000389193d },
            { 1801000.0d, 0.0000376942d },
            { 1808000.0d, 0.0000364873d },
            { 1815000.0d, 0.0000352993d },
            { 1822000.0d, 0.0000341305d },
            { 1829000.0d, 0.0000329816d },
            { 1836000.0d, 0.0000318529d },
            { 1843000.0d, 0.000030745d },
            { 1850000.0d, 0.0000296585d },
            { 1857000.0d, 0.0000285938d },
            { 1864000.0d, 0.0000275512d },
            { 1871000.0d, 0.0000265271d },
            { 1878000.0d, 0.0000255208d },
            { 1885000.0d, 0.0000245327d },
            { 1892000.0d, 0.0000235633d },
            { 1899000.0d, 0.0000226128d },
            { 1906000.0d, 0.0000216818d },
            { 1913000.0d, 0.0000207707d },
            { 1920000.0d, 0.0000198799d },
            { 1927000.0d, 0.0000190099d },
            { 1934000.0d, 0.000018161d },
            { 1941000.0d, 0.0000173293d },
            { 1948000.0d, 0.0000165122d },
            { 1955000.0d, 0.0000157105d },
            { 1962000.0d, 0.0000149244d },
            { 1969000.0d, 0.0000141541d },
            { 1976000.0d, 0.0000134002d },
            { 1983000.0d, 0.0000126627d },
            { 1990000.0d, 0.0000119423d },
            { 1997000.0d, 0.0000112391d },
            { 2004000.0d, 0.0000105537d },
            { 2011000.0d, 0.00000988628d },
            { 2018000.0d, 0.00000923718d },
            { 2025000.0d, 0.00000860687d },
            { 2032000.0d, 0.00000799566d },
            { 2039000.0d, 0.00000740391d },
            { 2046000.0d, 0.000006832d },
            { 2053000.0d, 0.00000628027d },
            { 2060000.0d, 0.0000057491d },
            { 2067000.0d, 0.00000523887d },
            { 2074000.0d, 0.00000474992d },
            { 2081000.0d, 0.00000428265d },
            { 2088000.0d, 0.0000038374d },
            { 2095000.0d, 0.00000341457d },
            { 2102000.0d, 0.00000301451d },
            { 2109000.0d, 0.0000026376d },
            { 2116000.0d, 0.00000228422d },
            { 2123000.0d, 0.00000195474d },
            { 2130000.0d, 0.00000164953d },
            { 2137000.0d, 0.00000136896d },
            { 2144000.0d, 0.00000111342d },
            { 2151000.0d, 0.000000883269d },
            { 2158000.0d, 0.000000678886d },
            { 2165000.0d, 0.00000050064d },
            { 2172000.0d, 0.000000348897d },
            { 2179000.0d, 0.000000224021d },
            { 2186000.0d, 0.000000126367d },
            { 2193000.0d, 0.0000000562801d },
            { 2200000.0d, 0.000000014076d },
            { 2207000.0d, 0d },

        }; 
    }
}
    