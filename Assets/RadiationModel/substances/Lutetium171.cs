using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium171";
        public override double halfLife { get; } = 712540.8d;
        public override double atomicWeight { get; } = 170.93792d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium171()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0015584000000000001d, new GammaParticle(9149.0, 0.13552)), new(0.139769d, new GammaParticle(19394.0, 0.06393)), new(0.0078894d, new GammaParticle(27133.0, 0.04569)), new(0.00171424d, new GammaParticle(46543.0, 0.02664)), new(0.012418499999999999d, new GammaParticle(55689.0, 0.02226)), new(0.025177900000000003d, new GammaParticle(66731.0, 0.01858)), new(0.0203079d, new GammaParticle(72380.0, 0.01713)), new(0.0619464d, new GammaParticle(75889.0, 0.01634)), new(0.011006199999999999d, new GammaParticle(85602.0, 0.01448)), new(0.00457293d, new GammaParticle(91408.0, 0.01356)), new(0.0061849d, new GammaParticle(109289.0, 0.01134)), new(4.9186999999999995e-05d, new GammaParticle(112700.0, 0.011)), new(0.00011931499999999999d, new GammaParticle(122370.0, 0.01013)), new(0.00039447d, new GammaParticle(132255.0, 0.00937)), new(4.6265000000000005e-05d, new GammaParticle(149630.0, 0.00829)), new(0.000487d, new GammaParticle(154753.0, 0.00801)), new(0.0017044999999999999d, new GammaParticle(163847.0, 0.00757)), new(0.00090582d, new GammaParticle(163847.0, 0.00757)), new(0.00070615d, new GammaParticle(170732.0, 0.00726)), new(0.0018019d, new GammaParticle(194896.0, 0.00636)), new(8.766e-05d, new GammaParticle(222060.0, 0.00558)), new(3.6037999999999996e-05d, new GammaParticle(240630.0, 0.00515)), new(0.00026785d, new GammaParticle(241730.0, 0.00513)), new(0.00022888999999999999d, new GammaParticle(256650.0, 0.00483)), new(0.00105192d, new GammaParticle(498755.0, 0.00249)), new(0.0034771800000000003d, new GammaParticle(517773.0, 0.00239)), new(0.00017045000000000002d, new GammaParticle(605600.0, 0.00205)), new(0.008522499999999999d, new GammaParticle(627062.0, 0.00198)), new(0.00133925d, new GammaParticle(631066.0, 0.00196)), new(0.11249700000000001d, new GammaParticle(667422.0, 0.00186)), new(0.00017532d, new GammaParticle(676150.0, 0.00183)), new(0.0241065d, new GammaParticle(689286.0, 0.0018)), new(6.331e-05d, new GammaParticle(701500.0, 0.00177)), new(0.00012175d, new GammaParticle(707460.0, 0.00175)), new(0.0115419d, new GammaParticle(712670.0, 0.00174)), new(0.0007402400000000001d, new GammaParticle(724970.0, 0.00171)), new(0.48700000000000004d, new GammaParticle(739793.0, 0.00168)), new(9.740000000000001e-05d, new GammaParticle(753370.0, 0.00165)), new(0.00023862999999999998d, new GammaParticle(759210.0, 0.00163)), new(0.0071589d, new GammaParticle(767614.0, 0.00162)), new(0.000487d, new GammaParticle(777990.0, 0.00159)), new(0.0444144d, new GammaParticle(780711.0, 0.00159)), new(0.00072076d, new GammaParticle(794000.0, 0.00156)), new(6.331e-05d, new GammaParticle(804950.0, 0.00154)), new(0.00036038d, new GammaParticle(816370.0, 0.00152)), new(8.279e-05d, new GammaParticle(821960.0, 0.00151)), new(0.0016411899999999998d, new GammaParticle(825960.0, 0.0015)), new(8.766e-05d, new GammaParticle(828900.0, 0.0015)), new(0.0002922d, new GammaParticle(834300.0, 0.00149)), new(0.0002922d, new GammaParticle(834300.0, 0.00149)), new(0.00098861d, new GammaParticle(835910.0, 0.00148)), new(0.0309732d, new GammaParticle(839961.0, 0.00148)), new(0.0007305d, new GammaParticle(850380.0, 0.00146)), new(0.0259571d, new GammaParticle(853091.0, 0.00145)), new(0.00035064d, new GammaParticle(862389.0, 0.00144)), new(0.00031168d, new GammaParticle(868450.0, 0.00143)), new(8.279e-05d, new GammaParticle(872790.0, 0.00142)), new(0.00022888999999999999d, new GammaParticle(877600.0, 0.00141)), new(0.00021915000000000001d, new GammaParticle(881030.0, 0.00141)), new(9.253000000000001e-05d, new GammaParticle(884740.0, 0.0014)), new(0.00017045000000000002d, new GammaParticle(888770.0, 0.0014)), new(7.305e-05d, new GammaParticle(893820.0, 0.00139)), new(0.00013636d, new GammaParticle(897180.0, 0.00138)), new(0.0014950900000000001d, new GammaParticle(902248.0, 0.00137)), new(0.00017532d, new GammaParticle(921980.0, 0.00134)), new(0.00038473d, new GammaParticle(925776.0, 0.00134)), new(0.00012175d, new GammaParticle(929430.0, 0.00133)), new(4.6265000000000005e-05d, new GammaParticle(934360.0, 0.00133)), new(3.409e-05d, new GammaParticle(937480.0, 0.00132)), new(6.818e-05d, new GammaParticle(944400.0, 0.00131)), new(0.0008960799999999999d, new GammaParticle(948740.0, 0.00131)), new(5.357e-05d, new GammaParticle(953450.0, 0.0013)), new(6.331e-05d, new GammaParticle(958270.0, 0.00129)), new(0.00021428d, new GammaParticle(985690.0, 0.00126)), new(0.00027272d, new GammaParticle(998020.0, 0.00124)), new(0.00033603d, new GammaParticle(1005040.0, 0.00123)), new(0.00013149d, new GammaParticle(1013490.0, 0.00122)), new(3.7499e-05d, new GammaParticle(1016700.0, 0.00122)), new(1.5584e-05d, new GammaParticle(1026800.0, 0.00121)), new(3.3603e-05d, new GammaParticle(1051730.0, 0.00118)), new(1.3148999999999999e-05d, new GammaParticle(1064200.0, 0.00117)), new(1.461e-05d, new GammaParticle(1088600.0, 0.00114)), new(5.357e-05d, new GammaParticle(1169480.0, 0.00106)), new(3.5551e-05d, new GammaParticle(1202570.0, 0.00103)), new(0.00067206d, new GammaParticle(1209830.0, 0.00102)), new(1.1688e-05d, new GammaParticle(1220520.0, 0.00102)), new(3.896e-05d, new GammaParticle(1238700.0, 0.001)), new(6.1849e-05d, new GammaParticle(1255140.0, 0.00099)), new(0.0032142d, new GammaParticle(1282214.0, 0.00097)), new(0.00011200999999999999d, new GammaParticle(1311340.0, 0.00095)), new(0.000124d, new GammaParticle(511000.0, 0.00243)), new(0.576905910901998d, new GammaParticle(8502.0, 0.14583)), new(0.3456189045462429d, new GammaParticle(51354.0, 0.02414)), new(0.609234804417844d, new GammaParticle(52389.0, 0.02367)), new(0.1999816530828036d, new GammaParticle(59481.0, 0.02084)), new(0.25217686453741534d, new GammaParticle(60151.0, 0.02061)), new(0.05219521145461174d, new GammaParticle(60961.0, 0.02034)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.000000000000296319d },
            { 200.0d, 0.000000000000684228d },
            { 300.0d, 0.00000000000116373d },
            { 400.0d, 0.00000000000173482d },
            { 500.0d, 0.0000000000023975d },
            { 600.0d, 0.00000000000315177d },
            { 700.0d, 0.00000000000399763d },
            { 800.0d, 0.00000000000493508d },
            { 900.0d, 0.00000000000596638d },
            { 1000.0d, 0.00000000000709016d },
            { 1500.0d, 0.0000000000141007d },
            { 2000.0d, 0.000000000023587d },
            { 2500.0d, 0.0000000000372393d },
            { 3000.0d, 0.0000000000546743d },
            { 3500.0d, 0.0000000000775647d },
            { 4000.0d, 0.000000000105503d },
            { 4500.0d, 0.00000000014032d },
            { 5000.0d, 0.000000000181544d },
            { 5500.0d, 0.000000000231012d },
            { 6000.0d, 0.00000000028831d },
            { 6500.0d, 0.000000000355226d },
            { 7000.0d, 0.000000000431368d },
            { 7500.0d, 0.000000000518514d },
            { 8000.0d, 0.000000000616207d },
            { 8500.0d, 0.000000000726282d },
            { 9000.0d, 0.000000000848211d },
            { 9500.0d, 0.000000000983767d },
            { 10000.0d, 0.00000000113248d },
            { 11000.0d, 0.00000000147388d },
            { 12000.0d, 0.00000000187696d },
            { 13000.0d, 0.00000000234601d },
            { 14000.0d, 0.00000000288488d },
            { 15000.0d, 0.00000000349714d },
            { 16000.0d, 0.00000000418596d },
            { 17000.0d, 0.00000000495419d },
            { 18000.0d, 0.0000000058043d },
            { 19000.0d, 0.00000000673841d },
            { 20000.0d, 0.0000000077583d },
            { 21000.0d, 0.00000000886546d },
            { 22000.0d, 0.000000010061d },
            { 23000.0d, 0.0000000113459d },
            { 24000.0d, 0.0000000127205d },
            { 25000.0d, 0.0000000141854d },
            { 26000.0d, 0.0000000157404d },
            { 27000.0d, 0.0000000173854d },
            { 28000.0d, 0.0000000191201d },
            { 29000.0d, 0.0000000209438d },
            { 30000.0d, 0.0000000228555d },
            { 31000.0d, 0.0000000248546d },
            { 32000.0d, 0.0000000269398d },
            { 33000.0d, 0.0000000291097d },
            { 34000.0d, 0.0000000313629d },
            { 35000.0d, 0.0000000336979d },
            { 36000.0d, 0.0000000361131d },
            { 37000.0d, 0.0000000386065d },
            { 38000.0d, 0.0000000411764d },
            { 39000.0d, 0.0000000438208d },
            { 40000.0d, 0.0000000465377d },
            { 41000.0d, 0.000000049325d },
            { 42000.0d, 0.0000000521805d },
            { 43000.0d, 0.000000055102d },
            { 44000.0d, 0.0000000580874d },
            { 45000.0d, 0.0000000611342d },
            { 46000.0d, 0.0000000642402d },
            { 47000.0d, 0.0000000674031d },
            { 48000.0d, 0.0000000706205d },
            { 49000.0d, 0.0000000738899d },
            { 50000.0d, 0.0000000772092d },
            { 51000.0d, 0.0000000805759d },
            { 52000.0d, 0.0000000839875d },
            { 53000.0d, 0.0000000874417d },
            { 54000.0d, 0.0000000909362d },
            { 55000.0d, 0.0000000944686d },
            { 56000.0d, 0.0000000980366d },
            { 57000.0d, 0.000000101638d },
            { 58000.0d, 0.00000010527d },
            { 59000.0d, 0.00000010893d },
            { 60000.0d, 0.000000112617d },
            { 61000.0d, 0.000000116328d },
            { 62000.0d, 0.000000120061d },
            { 63000.0d, 0.000000123813d },
            { 64000.0d, 0.000000127583d },
            { 65000.0d, 0.000000131369d },
            { 66000.0d, 0.000000135167d },
            { 67000.0d, 0.000000138976d },
            { 68000.0d, 0.000000142795d },
            { 69000.0d, 0.000000146621d },
            { 70000.0d, 0.000000150452d },
            { 71000.0d, 0.000000154285d },
            { 72000.0d, 0.000000158121d },
            { 73000.0d, 0.000000161956d },
            { 74000.0d, 0.000000165788d },
            { 75000.0d, 0.000000169616d },
            { 76000.0d, 0.000000173438d },
            { 77000.0d, 0.000000177252d },
            { 78000.0d, 0.000000181057d },
            { 79000.0d, 0.000000184851d },
            { 80000.0d, 0.000000188632d },
            { 81000.0d, 0.000000192398d },
            { 82000.0d, 0.000000196149d },
            { 83000.0d, 0.000000199883d },
            { 84000.0d, 0.000000203598d },
            { 85000.0d, 0.000000207292d },
            { 86000.0d, 0.000000210965d },
            { 87000.0d, 0.000000214615d },
            { 88000.0d, 0.000000218241d },
            { 89000.0d, 0.000000221841d },
            { 90000.0d, 0.000000225414d },
            { 91000.0d, 0.000000228959d },
            { 92000.0d, 0.000000232475d },
            { 93000.0d, 0.000000235961d },
            { 94000.0d, 0.000000239414d },
            { 95000.0d, 0.000000242836d },
            { 96000.0d, 0.000000246223d },
            { 97000.0d, 0.000000249576d },
            { 98000.0d, 0.000000252894d },
            { 99000.0d, 0.000000256174d },
            { 100000.0d, 0.000000259417d },
            { 101000.0d, 0.000000262622d },
            { 102000.0d, 0.000000265787d },
            { 103000.0d, 0.000000268913d },
            { 104000.0d, 0.000000271997d },
            { 105000.0d, 0.00000027504d },
            { 106000.0d, 0.00000027804d },
            { 107000.0d, 0.000000280997d },
            { 108000.0d, 0.00000028391d },
            { 109000.0d, 0.000000286779d },
            { 110000.0d, 0.000000289603d },
            { 111000.0d, 0.00000029238d },
            { 112000.0d, 0.000000295112d },
            { 113000.0d, 0.000000297797d },
            { 114000.0d, 0.000000300434d },
            { 115000.0d, 0.000000303024d },
            { 116000.0d, 0.000000305565d },
            { 117000.0d, 0.000000308058d },
            { 118000.0d, 0.000000310501d },
            { 119000.0d, 0.000000312895d },
            { 120000.0d, 0.000000315238d },
            { 121000.0d, 0.000000317533d },
            { 122000.0d, 0.000000319776d },
            { 123000.0d, 0.000000321967d },
            { 124000.0d, 0.000000324108d },
            { 125000.0d, 0.000000326197d },
            { 126000.0d, 0.000000328235d },
            { 127000.0d, 0.000000330221d },
            { 128000.0d, 0.000000332155d },
            { 129000.0d, 0.000000334036d },
            { 130000.0d, 0.000000335864d },
            { 131000.0d, 0.000000337641d },
            { 132000.0d, 0.000000339364d },
            { 133000.0d, 0.000000341035d },
            { 134000.0d, 0.000000342654d },
            { 135000.0d, 0.000000344219d },
            { 136000.0d, 0.000000345731d },
            { 137000.0d, 0.00000034719d },
            { 138000.0d, 0.000000348596d },
            { 139000.0d, 0.00000034995d },
            { 140000.0d, 0.000000351249d },
            { 141000.0d, 0.000000352493d },
            { 142000.0d, 0.000000353682d },
            { 143000.0d, 0.000000354816d },
            { 144000.0d, 0.000000355893d },
            { 145000.0d, 0.000000356916d },
            { 146000.0d, 0.000000357883d },
            { 147000.0d, 0.000000358795d },
            { 148000.0d, 0.000000359651d },
            { 149000.0d, 0.000000360452d },
            { 150000.0d, 0.000000361199d },
            { 151000.0d, 0.00000036189d },
            { 152000.0d, 0.000000362526d },
            { 153000.0d, 0.000000363108d },
            { 154000.0d, 0.000000363635d },
            { 155000.0d, 0.000000364108d },
            { 156000.0d, 0.000000364526d },
            { 157000.0d, 0.00000036489d },
            { 158000.0d, 0.000000365199d },
            { 159000.0d, 0.000000365456d },
            { 160000.0d, 0.000000365659d },
            { 161000.0d, 0.000000365809d },
            { 162000.0d, 0.000000365905d },
            { 163000.0d, 0.00000036595d },
            { 164000.0d, 0.000000365941d },
            { 165000.0d, 0.00000036588d },
            { 166000.0d, 0.000000365767d },
            { 167000.0d, 0.000000365603d },
            { 168000.0d, 0.000000365387d },
            { 169000.0d, 0.00000036512d },
            { 170000.0d, 0.000000364802d },
            { 171000.0d, 0.000000364435d },
            { 172000.0d, 0.000000364017d },
            { 173000.0d, 0.000000363549d },
            { 174000.0d, 0.000000363032d },
            { 175000.0d, 0.000000362467d },
            { 176000.0d, 0.000000361852d },
            { 177000.0d, 0.000000361191d },
            { 178000.0d, 0.000000360481d },
            { 179000.0d, 0.000000359724d },
            { 180000.0d, 0.000000358919d },
            { 181000.0d, 0.000000358068d },
            { 182000.0d, 0.000000357172d },
            { 183000.0d, 0.00000035623d },
            { 184000.0d, 0.000000355243d },
            { 185000.0d, 0.000000354211d },
            { 186000.0d, 0.000000353135d },
            { 187000.0d, 0.000000352015d },
            { 188000.0d, 0.000000350852d },
            { 189000.0d, 0.000000349646d },
            { 190000.0d, 0.000000348398d },
            { 191000.0d, 0.000000347109d },
            { 192000.0d, 0.000000345779d },
            { 193000.0d, 0.000000344408d },
            { 194000.0d, 0.000000342997d },
            { 195000.0d, 0.000000341546d },
            { 196000.0d, 0.000000340056d },
            { 197000.0d, 0.000000338528d },
            { 198000.0d, 0.000000336962d },
            { 199000.0d, 0.000000335359d },
            { 200000.0d, 0.000000333719d },
            { 201000.0d, 0.000000332044d },
            { 202000.0d, 0.000000330333d },
            { 203000.0d, 0.000000328586d },
            { 204000.0d, 0.000000326805d },
            { 205000.0d, 0.000000324991d },
            { 206000.0d, 0.000000323142d },
            { 207000.0d, 0.000000321262d },
            { 208000.0d, 0.000000319351d },
            { 209000.0d, 0.000000317407d },
            { 210000.0d, 0.000000315434d },
            { 211000.0d, 0.000000313431d },
            { 212000.0d, 0.000000311398d },
            { 213000.0d, 0.000000309336d },
            { 214000.0d, 0.000000307247d },
            { 215000.0d, 0.000000305131d },
            { 216000.0d, 0.000000302987d },
            { 217000.0d, 0.000000300818d },
            { 218000.0d, 0.000000298623d },
            { 219000.0d, 0.000000296404d },
            { 220000.0d, 0.000000294162d },
            { 221000.0d, 0.000000291896d },
            { 222000.0d, 0.000000289607d },
            { 223000.0d, 0.000000287297d },
            { 224000.0d, 0.000000284966d },
            { 225000.0d, 0.000000282615d },
            { 226000.0d, 0.000000280244d },
            { 227000.0d, 0.000000277854d },
            { 228000.0d, 0.000000275446d },
            { 229000.0d, 0.000000273021d },
            { 230000.0d, 0.000000270578d },
            { 231000.0d, 0.000000268121d },
            { 232000.0d, 0.000000265648d },
            { 233000.0d, 0.000000263161d },
            { 234000.0d, 0.00000026066d },
            { 235000.0d, 0.000000258146d },
            { 236000.0d, 0.00000025562d },
            { 237000.0d, 0.000000253084d },
            { 238000.0d, 0.000000250536d },
            { 239000.0d, 0.000000247978d },
            { 240000.0d, 0.000000245413d },
            { 241000.0d, 0.000000242838d },
            { 242000.0d, 0.000000240257d },
            { 243000.0d, 0.000000237668d },
            { 244000.0d, 0.000000235074d },
            { 245000.0d, 0.000000232475d },
            { 246000.0d, 0.000000229872d },
            { 247000.0d, 0.000000227265d },
            { 248000.0d, 0.000000224657d },
            { 249000.0d, 0.000000222044d },
            { 250000.0d, 0.000000219421d },
            { 251000.0d, 0.000000216785d },
            { 252000.0d, 0.000000214139d },
            { 253000.0d, 0.000000211482d },
            { 254000.0d, 0.000000208817d },
            { 255000.0d, 0.000000206142d },
            { 256000.0d, 0.000000203458d },
            { 257000.0d, 0.000000200767d },
            { 258000.0d, 0.000000198069d },
            { 259000.0d, 0.000000195364d },
            { 260000.0d, 0.000000192653d },
            { 261000.0d, 0.000000189938d },
            { 262000.0d, 0.000000187217d },
            { 263000.0d, 0.000000184493d },
            { 264000.0d, 0.000000181766d },
            { 265000.0d, 0.000000179036d },
            { 266000.0d, 0.000000176304d },
            { 267000.0d, 0.000000173571d },
            { 268000.0d, 0.000000170837d },
            { 269000.0d, 0.000000168104d },
            { 270000.0d, 0.000000165371d },
            { 271000.0d, 0.000000162639d },
            { 272000.0d, 0.000000159909d },
            { 273000.0d, 0.000000157183d },
            { 274000.0d, 0.000000154459d },
            { 275000.0d, 0.000000151741d },
            { 276000.0d, 0.000000149026d },
            { 277000.0d, 0.000000146316d },
            { 278000.0d, 0.000000143614d },
            { 279000.0d, 0.000000140918d },
            { 280000.0d, 0.000000138229d },
            { 281000.0d, 0.000000135549d },
            { 282000.0d, 0.000000132878d },
            { 283000.0d, 0.000000130216d },
            { 284000.0d, 0.000000127565d },
            { 285000.0d, 0.000000124926d },
            { 286000.0d, 0.000000122296d },
            { 287000.0d, 0.00000011968d },
            { 288000.0d, 0.000000117078d },
            { 289000.0d, 0.000000114488d },
            { 290000.0d, 0.000000111911d },
            { 291000.0d, 0.000000109345d },
            { 292000.0d, 0.000000106793d },
            { 293000.0d, 0.000000104254d },
            { 294000.0d, 0.000000101727d },
            { 295000.0d, 0.0000000992161d },
            { 296000.0d, 0.0000000967199d },
            { 297000.0d, 0.0000000942396d },
            { 298000.0d, 0.0000000917758d },
            { 299000.0d, 0.0000000893293d },
            { 300000.0d, 0.0000000869005d },
            { 301000.0d, 0.0000000844905d },
            { 302000.0d, 0.0000000820996d },
            { 303000.0d, 0.0000000797286d },
            { 304000.0d, 0.0000000773783d },
            { 305000.0d, 0.0000000750493d },
            { 306000.0d, 0.0000000727423d },
            { 307000.0d, 0.0000000704581d },
            { 308000.0d, 0.0000000681971d },
            { 309000.0d, 0.0000000659603d },
            { 310000.0d, 0.0000000637483d },
            { 311000.0d, 0.0000000615617d },
            { 312000.0d, 0.0000000594013d },
            { 313000.0d, 0.0000000572678d },
            { 314000.0d, 0.0000000551619d },
            { 315000.0d, 0.0000000530843d },
            { 316000.0d, 0.0000000510357d },
            { 317000.0d, 0.0000000490168d },
            { 318000.0d, 0.0000000470284d },
            { 319000.0d, 0.000000045071d },
            { 320000.0d, 0.0000000431456d },
            { 321000.0d, 0.0000000412526d },
            { 322000.0d, 0.000000039393d },
            { 323000.0d, 0.0000000375674d },
            { 324000.0d, 0.0000000357765d },
            { 325000.0d, 0.000000034021d },
            { 326000.0d, 0.0000000323018d },
            { 327000.0d, 0.0000000306194d },
            { 328000.0d, 0.0000000289746d },
            { 329000.0d, 0.0000000273682d },
            { 330000.0d, 0.0000000258009d },
            { 331000.0d, 0.0000000242734d },
            { 332000.0d, 0.0000000227864d },
            { 333000.0d, 0.0000000213407d },
            { 334000.0d, 0.000000019937d },
            { 335000.0d, 0.0000000185753d },
            { 336000.0d, 0.0000000172555d },
            { 337000.0d, 0.0000000159783d },
            { 338000.0d, 0.0000000147444d },
            { 339000.0d, 0.0000000135547d },
            { 340000.0d, 0.0000000124097d },
            { 341000.0d, 0.0000000113102d },
            { 342000.0d, 0.000000010257d },
            { 343000.0d, 0.00000000925072d },
            { 344000.0d, 0.00000000829215d },
            { 345000.0d, 0.00000000738199d },
            { 346000.0d, 0.00000000652098d },
            { 347000.0d, 0.00000000570985d },
            { 348000.0d, 0.00000000494932d },
            { 349000.0d, 0.00000000424013d },
            { 350000.0d, 0.00000000358301d },
            { 351000.0d, 0.00000000297869d },
            { 352000.0d, 0.0000000024279d },
            { 353000.0d, 0.00000000193139d },
            { 354000.0d, 0.00000000148987d },
            { 355000.0d, 0.00000000110408d },
            { 356000.0d, 0.000000000774748d },
            { 357000.0d, 0.000000000502609d },
            { 358000.0d, 0.000000000288385d },
            { 359000.0d, 0.000000000132795d },
            { 360000.0d, 0.0000000000365431d },
            { 361000.0d, 0.000000000000301907d },
            { 361100.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    