using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton88 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton88";
        public override double halfLife { get; } = 10170.0d;
        public override double atomicWeight { get; } = 87.91445d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium88()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.019376d, new GammaParticle(27513.0, 0.04506)), new(0.0002768d, new GammaParticle(28260.0, 0.04387)), new(0.0019722d, new GammaParticle(122270.0, 0.01014)), new(0.0310362d, new GammaParticle(165980.0, 0.00747)), new(6.92e-05d, new GammaParticle(168500.0, 0.00736)), new(0.00024219999999999998d, new GammaParticle(176710.0, 0.00702)), new(0.259846d, new GammaParticle(196301.0, 0.00632)), new(0.0025258000000000004d, new GammaParticle(240710.0, 0.00515)), new(0.0003d, new GammaParticle(268240.0, 0.00462)), new(0.0010726d, new GammaParticle(311690.0, 0.00398)), new(0.0014532d, new GammaParticle(334710.0, 0.0037)), new(0.000173d, new GammaParticle(350040.0, 0.00354)), new(0.02249d, new GammaParticle(362226.0, 0.00342)), new(0.00048439999999999996d, new GammaParticle(363500.0, 0.00341)), new(0.0064356000000000005d, new GammaParticle(390543.0, 0.00317)), new(0.0007957999999999999d, new GammaParticle(391200.0, 0.00317)), new(0.0001038d, new GammaParticle(421700.0, 0.00294)), new(0.007266d, new GammaParticle(471800.0, 0.00263)), new(0.0009687999999999999d, new GammaParticle(500020.0, 0.00248)), new(0.000346d, new GammaParticle(517000.0, 0.0024)), new(0.0006228000000000001d, new GammaParticle(570570.0, 0.00217)), new(0.0007266d, new GammaParticle(573270.0, 0.00216)), new(0.00024219999999999998d, new GammaParticle(579040.0, 0.00214)), new(0.0004152d, new GammaParticle(603210.0, 0.00206)), new(0.0008649999999999999d, new GammaParticle(665940.0, 0.00186)), new(0.0023528d, new GammaParticle(677340.0, 0.00183)), new(0.000346d, new GammaParticle(731010.0, 0.0017)), new(0.000346d, new GammaParticle(741340.0, 0.00167)), new(0.0009687999999999999d, new GammaParticle(774140.0, 0.0016)), new(0.0009687999999999999d, new GammaParticle(779120.0, 0.00159)), new(0.0053284d, new GammaParticle(788280.0, 0.00157)), new(0.0012456000000000001d, new GammaParticle(790320.0, 0.00157)), new(0.0002768d, new GammaParticle(798650.0, 0.00155)), new(0.0008996d, new GammaParticle(822010.0, 0.00151)), new(0.12975d, new GammaParticle(834830.0, 0.00149)), new(0.0017299999999999998d, new GammaParticle(850340.0, 0.00146)), new(0.0067123999999999994d, new GammaParticle(862327.0, 0.00144)), new(0.00024219999999999998d, new GammaParticle(879510.0, 0.00141)), new(0.0004152d, new GammaParticle(883060.0, 0.0014)), new(0.0029409999999999996d, new GammaParticle(944920.0, 0.00131)), new(0.0003806d, new GammaParticle(950490.0, 0.0013)), new(0.0008304d, new GammaParticle(961830.0, 0.00129)), new(0.013148d, new GammaParticle(985780.0, 0.00126)), new(0.0014186000000000001d, new GammaParticle(990090.0, 0.00125)), new(0.004844d, new GammaParticle(1039590.0, 0.00119)), new(0.0014186000000000001d, new GammaParticle(1049480.0, 0.00118)), new(0.00031140000000000003d, new GammaParticle(1054540.0, 0.00118)), new(0.0006228000000000001d, new GammaParticle(1090530.0, 0.00114)), new(0.0128366d, new GammaParticle(1141330.0, 0.00109)), new(0.009964800000000001d, new GammaParticle(1179510.0, 0.00105)), new(0.006885400000000001d, new GammaParticle(1184950.0, 0.00105)), new(0.0014186000000000001d, new GammaParticle(1209840.0, 0.00102)), new(0.001384d, new GammaParticle(1212730.0, 0.00102)), new(0.003633d, new GammaParticle(1245220.0, 0.001)), new(0.0112104d, new GammaParticle(1250670.0, 0.00099)), new(0.0009342d, new GammaParticle(1298780.0, 0.00095)), new(0.0006574d, new GammaParticle(1303090.0, 0.00095)), new(0.0015915999999999999d, new GammaParticle(1324980.0, 0.00094)), new(0.0006574d, new GammaParticle(1335810.0, 0.00093)), new(0.0015915999999999999d, new GammaParticle(1352320.0, 0.00092)), new(0.0147742d, new GammaParticle(1369500.0, 0.00091)), new(0.0021798d, new GammaParticle(1406940.0, 0.00088)), new(0.0011418d, new GammaParticle(1464840.0, 0.00085)), new(0.0215212d, new GammaParticle(1518390.0, 0.00082)), new(0.109336d, new GammaParticle(1529770.0, 0.00081)), new(0.0045672d, new GammaParticle(1603790.0, 0.00077)), new(0.000692d, new GammaParticle(1608010.0, 0.00077)), new(0.0008996d, new GammaParticle(1661300.0, 0.00075)), new(0.0066432d, new GammaParticle(1685600.0, 0.00074)), new(0.0004498d, new GammaParticle(1789140.0, 0.00069)), new(0.000346d, new GammaParticle(1793300.0, 0.00069)), new(0.0003806d, new GammaParticle(1801300.0, 0.00069)), new(0.001384d, new GammaParticle(1892760.0, 0.00066)), new(0.0010034d, new GammaParticle(1908700.0, 0.00065)), new(0.0452914d, new GammaParticle(2029840.0, 0.00061)), new(0.037368d, new GammaParticle(2035411.0, 0.00061)), new(0.0028718d, new GammaParticle(2186500.0, 0.00057)), new(0.131826d, new GammaParticle(2195840.0, 0.00056)), new(0.033908d, new GammaParticle(2231772.0, 0.00056)), new(0.00031140000000000003d, new GammaParticle(2259500.0, 0.00055)), new(0.007300600000000001d, new GammaParticle(2352080.0, 0.00053)), new(0.00031140000000000003d, new GammaParticle(2364700.0, 0.00052)), new(0.34600000000000003d, new GammaParticle(2392110.0, 0.00052)), new(0.001038d, new GammaParticle(2408910.0, 0.00051)), new(0.0004152d, new GammaParticle(2535520.0, 0.00049)), new(0.006228d, new GammaParticle(2548400.0, 0.00049)), new(0.0014878d, new GammaParticle(2771020.0, 0.00045)), new(0.0036458451689840997d, new GammaParticle(1767.0, 0.70166)), new(0.023774722676030712d, new GammaParticle(13336.0, 0.09297)), new(0.04576462497792245d, new GammaParticle(13396.0, 0.09255)), new(0.011141250323052711d, new GammaParticle(15021.0, 0.08254)), new(0.012433635360526827d, new GammaParticle(15070.0, 0.08227)), new(0.0012923850374741148d, new GammaParticle(15187.0, 0.08164)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0027042d },
            { 400.0d, 0.00273388d },
            { 800.0d, 0.00275756d },
            { 1200.0d, 0.00277524d },
            { 1700.0d, 0.0027909d },
            { 2200.0d, 0.00279987d },
            { 2700.0d, 0.00280231d },
            { 3200.0d, 0.00280092d },
            { 3700.0d, 0.00280093d },
            { 4200.0d, 0.00280035d },
            { 4700.0d, 0.00279989d },
            { 5200.0d, 0.00279929d },
            { 5700.0d, 0.00279867d },
            { 6200.0d, 0.002798d },
            { 6700.0d, 0.00279735d },
            { 7200.0d, 0.00279666d },
            { 7700.0d, 0.00279595d },
            { 8200.0d, 0.00279522d },
            { 8700.0d, 0.00279446d },
            { 9200.0d, 0.00279368d },
            { 9700.0d, 0.00279288d },
            { 10000.0d, 0.0027924d },
            { 11000.0d, 0.00279072d },
            { 12000.0d, 0.00278899d },
            { 13000.0d, 0.00278722d },
            { 14000.0d, 0.00278542d },
            { 15000.0d, 0.00278362d },
            { 16000.0d, 0.00278181d },
            { 17000.0d, 0.00278d },
            { 18000.0d, 0.0027782d },
            { 19000.0d, 0.00277642d },
            { 20000.0d, 0.00277465d },
            { 21000.0d, 0.0027729d },
            { 22000.0d, 0.00277118d },
            { 23000.0d, 0.00276947d },
            { 24000.0d, 0.0027678d },
            { 25000.0d, 0.00276613d },
            { 26000.0d, 0.0027645d },
            { 27000.0d, 0.00276287d },
            { 28000.0d, 0.00276128d },
            { 29000.0d, 0.00275969d },
            { 30000.0d, 0.00275812d },
            { 31000.0d, 0.00275657d },
            { 32000.0d, 0.00275503d },
            { 33000.0d, 0.0027535d },
            { 34000.0d, 0.00275197d },
            { 35000.0d, 0.00275046d },
            { 36000.0d, 0.00274895d },
            { 37000.0d, 0.00274744d },
            { 38000.0d, 0.00274592d },
            { 39000.0d, 0.00274441d },
            { 40000.0d, 0.0027429d },
            { 41000.0d, 0.0027414d },
            { 42000.0d, 0.00273987d },
            { 43000.0d, 0.00273835d },
            { 44000.0d, 0.00273682d },
            { 45000.0d, 0.00273527d },
            { 46000.0d, 0.00273372d },
            { 47000.0d, 0.00273215d },
            { 48000.0d, 0.00273057d },
            { 49000.0d, 0.00272898d },
            { 50000.0d, 0.00272737d },
            { 51000.0d, 0.00272574d },
            { 52000.0d, 0.0027241d },
            { 53000.0d, 0.00272244d },
            { 54000.0d, 0.00272076d },
            { 55000.0d, 0.00271906d },
            { 56000.0d, 0.00271734d },
            { 57000.0d, 0.00271559d },
            { 58000.0d, 0.00271383d },
            { 59000.0d, 0.00271204d },
            { 60000.0d, 0.00271023d },
            { 61000.0d, 0.00270839d },
            { 62000.0d, 0.00270652d },
            { 63000.0d, 0.00270464d },
            { 64000.0d, 0.00270272d },
            { 65000.0d, 0.00270078d },
            { 66000.0d, 0.0026988d },
            { 67000.0d, 0.00269681d },
            { 68000.0d, 0.00269478d },
            { 69000.0d, 0.00269272d },
            { 70000.0d, 0.00269064d },
            { 71000.0d, 0.00268853d },
            { 72000.0d, 0.00268638d },
            { 73000.0d, 0.00268421d },
            { 74000.0d, 0.00268201d },
            { 75000.0d, 0.00267977d },
            { 76000.0d, 0.0026775d },
            { 77000.0d, 0.0026752d },
            { 78000.0d, 0.00267287d },
            { 79000.0d, 0.00267051d },
            { 80000.0d, 0.00266812d },
            { 81000.0d, 0.00266569d },
            { 82000.0d, 0.00266323d },
            { 83000.0d, 0.00266075d },
            { 84000.0d, 0.00265822d },
            { 85000.0d, 0.00265567d },
            { 86000.0d, 0.00265308d },
            { 87000.0d, 0.00265046d },
            { 88000.0d, 0.0026478d },
            { 89000.0d, 0.00264511d },
            { 90000.0d, 0.00264239d },
            { 91000.0d, 0.00263963d },
            { 92000.0d, 0.00263685d },
            { 93000.0d, 0.00263402d },
            { 94000.0d, 0.00263117d },
            { 95000.0d, 0.00262828d },
            { 96000.0d, 0.00262535d },
            { 97000.0d, 0.0026224d },
            { 98000.0d, 0.00261942d },
            { 99000.0d, 0.00261639d },
            { 100000.0d, 0.00261333d },
            { 109000.0d, 0.00258432d },
            { 118000.0d, 0.00255265d },
            { 127000.0d, 0.00251838d },
            { 136000.0d, 0.00248164d },
            { 145000.0d, 0.00244255d },
            { 154000.0d, 0.00240101d },
            { 163000.0d, 0.00235658d },
            { 172000.0d, 0.00230938d },
            { 181000.0d, 0.00225951d },
            { 190000.0d, 0.0022071d },
            { 199000.0d, 0.0021523d },
            { 208000.0d, 0.00209523d },
            { 217000.0d, 0.00203606d },
            { 226000.0d, 0.00197494d },
            { 235000.0d, 0.00191204d },
            { 244000.0d, 0.00184754d },
            { 253000.0d, 0.00178161d },
            { 262000.0d, 0.00171445d },
            { 271000.0d, 0.00164624d },
            { 280000.0d, 0.00157718d },
            { 289000.0d, 0.00150748d },
            { 298000.0d, 0.00143735d },
            { 307000.0d, 0.00136702d },
            { 316000.0d, 0.00129669d },
            { 325000.0d, 0.00122661d },
            { 334000.0d, 0.00115701d },
            { 343000.0d, 0.00108813d },
            { 352000.0d, 0.00102022d },
            { 361000.0d, 0.000953531d },
            { 370000.0d, 0.000888323d },
            { 379000.0d, 0.000824552d },
            { 388000.0d, 0.000762208d },
            { 397000.0d, 0.00070153d },
            { 406000.0d, 0.000642766d },
            { 415000.0d, 0.000586165d },
            { 424000.0d, 0.000531986d },
            { 433000.0d, 0.000480489d },
            { 442000.0d, 0.000431941d },
            { 451000.0d, 0.000386612d },
            { 460000.0d, 0.000344781d },
            { 469000.0d, 0.000306722d },
            { 478000.0d, 0.000272717d },
            { 487000.0d, 0.000243056d },
            { 496000.0d, 0.000218032d },
            { 505000.0d, 0.000197943d },
            { 514000.0d, 0.000183089d },
            { 523000.0d, 0.000173773d },
            { 532000.0d, 0.000168934d },
            { 541000.0d, 0.000164505d },
            { 550000.0d, 0.000160199d },
            { 559000.0d, 0.000156033d },
            { 568000.0d, 0.000152021d },
            { 577000.0d, 0.00014818d },
            { 586000.0d, 0.000144524d },
            { 595000.0d, 0.00014107d },
            { 604000.0d, 0.000137834d },
            { 613000.0d, 0.000134832d },
            { 622000.0d, 0.000132082d },
            { 631000.0d, 0.000129601d },
            { 640000.0d, 0.000127405d },
            { 649000.0d, 0.000125513d },
            { 658000.0d, 0.000123942d },
            { 667000.0d, 0.000122709d },
            { 676000.0d, 0.000121833d },
            { 685000.0d, 0.000121331d },
            { 694000.0d, 0.000121064d },
            { 703000.0d, 0.000120784d },
            { 712000.0d, 0.000120488d },
            { 721000.0d, 0.000120176d },
            { 730000.0d, 0.00011985d },
            { 739000.0d, 0.000119509d },
            { 748000.0d, 0.000119155d },
            { 757000.0d, 0.000118789d },
            { 766000.0d, 0.000118411d },
            { 775000.0d, 0.000118021d },
            { 784000.0d, 0.000117621d },
            { 793000.0d, 0.000117212d },
            { 802000.0d, 0.000116793d },
            { 811000.0d, 0.000116367d },
            { 820000.0d, 0.000115933d },
            { 829000.0d, 0.000115492d },
            { 838000.0d, 0.000115044d },
            { 847000.0d, 0.000114587d },
            { 856000.0d, 0.000114121d },
            { 865000.0d, 0.000113648d },
            { 874000.0d, 0.000113168d },
            { 883000.0d, 0.000112682d },
            { 892000.0d, 0.00011219d },
            { 901000.0d, 0.000111693d },
            { 910000.0d, 0.000111192d },
            { 919000.0d, 0.000110688d },
            { 928000.0d, 0.000110181d },
            { 937000.0d, 0.000109672d },
            { 946000.0d, 0.000109162d },
            { 955000.0d, 0.000108652d },
            { 964000.0d, 0.000108142d },
            { 973000.0d, 0.000107634d },
            { 982000.0d, 0.000107128d },
            { 991000.0d, 0.000106624d },
            { 1000000.0d, 0.000106124d },
            { 1009000.0d, 0.000105628d },
            { 1018000.0d, 0.000105133d },
            { 1027000.0d, 0.00010464d },
            { 1036000.0d, 0.000104151d },
            { 1045000.0d, 0.000103665d },
            { 1054000.0d, 0.000103183d },
            { 1063000.0d, 0.000102707d },
            { 1072000.0d, 0.000102237d },
            { 1081000.0d, 0.000101773d },
            { 1090000.0d, 0.000101316d },
            { 1099000.0d, 0.000100868d },
            { 1108000.0d, 0.000100429d },
            { 1117000.0d, 0.0000999994d },
            { 1126000.0d, 0.0000995802d },
            { 1135000.0d, 0.000099172d },
            { 1144000.0d, 0.0000987753d },
            { 1153000.0d, 0.0000983909d },
            { 1162000.0d, 0.0000980195d },
            { 1171000.0d, 0.0000976621d },
            { 1180000.0d, 0.0000973193d },
            { 1189000.0d, 0.000096992d },
            { 1198000.0d, 0.0000966808d },
            { 1207000.0d, 0.0000963847d },
            { 1216000.0d, 0.0000960881d },
            { 1225000.0d, 0.0000957875d },
            { 1234000.0d, 0.0000954831d },
            { 1243000.0d, 0.000095175d },
            { 1252000.0d, 0.0000948634d },
            { 1261000.0d, 0.0000945481d },
            { 1270000.0d, 0.0000942277d },
            { 1279000.0d, 0.0000939019d },
            { 1288000.0d, 0.0000935707d },
            { 1297000.0d, 0.0000932344d },
            { 1306000.0d, 0.000092893d },
            { 1315000.0d, 0.0000925465d },
            { 1324000.0d, 0.0000921952d },
            { 1333000.0d, 0.000091839d },
            { 1342000.0d, 0.0000914784d },
            { 1351000.0d, 0.0000911131d },
            { 1360000.0d, 0.0000907433d },
            { 1369000.0d, 0.0000903692d },
            { 1378000.0d, 0.0000899909d },
            { 1387000.0d, 0.0000896086d },
            { 1396000.0d, 0.0000892222d },
            { 1405000.0d, 0.0000888318d },
            { 1414000.0d, 0.0000884379d },
            { 1423000.0d, 0.0000880404d },
            { 1432000.0d, 0.0000876392d },
            { 1441000.0d, 0.0000872347d },
            { 1450000.0d, 0.000086827d },
            { 1459000.0d, 0.0000864161d },
            { 1468000.0d, 0.0000860021d },
            { 1477000.0d, 0.0000855853d },
            { 1486000.0d, 0.000085165d },
            { 1495000.0d, 0.0000847404d },
            { 1504000.0d, 0.0000843118d },
            { 1513000.0d, 0.0000838793d },
            { 1522000.0d, 0.0000834429d },
            { 1531000.0d, 0.0000830028d },
            { 1540000.0d, 0.0000825591d },
            { 1549000.0d, 0.0000821119d },
            { 1558000.0d, 0.0000816612d },
            { 1567000.0d, 0.0000812072d },
            { 1576000.0d, 0.0000807501d },
            { 1585000.0d, 0.0000802898d },
            { 1594000.0d, 0.0000798267d },
            { 1603000.0d, 0.0000793607d },
            { 1612000.0d, 0.000078892d },
            { 1621000.0d, 0.0000784209d },
            { 1630000.0d, 0.0000779472d },
            { 1639000.0d, 0.0000774713d },
            { 1648000.0d, 0.0000769933d },
            { 1657000.0d, 0.0000765132d },
            { 1666000.0d, 0.0000760314d },
            { 1675000.0d, 0.0000755478d },
            { 1684000.0d, 0.0000750627d },
            { 1693000.0d, 0.0000745762d },
            { 1702000.0d, 0.0000740885d },
            { 1711000.0d, 0.0000735998d },
            { 1720000.0d, 0.0000731102d },
            { 1729000.0d, 0.0000726199d },
            { 1738000.0d, 0.0000721289d },
            { 1747000.0d, 0.0000716344d },
            { 1756000.0d, 0.0000711349d },
            { 1765000.0d, 0.0000706308d },
            { 1774000.0d, 0.000070122d },
            { 1783000.0d, 0.0000696087d },
            { 1792000.0d, 0.0000690905d },
            { 1801000.0d, 0.0000685676d },
            { 1810000.0d, 0.0000680401d },
            { 1819000.0d, 0.0000675081d },
            { 1828000.0d, 0.0000669717d },
            { 1837000.0d, 0.0000664312d },
            { 1846000.0d, 0.0000658865d },
            { 1855000.0d, 0.0000653379d },
            { 1864000.0d, 0.0000647855d },
            { 1873000.0d, 0.0000642294d },
            { 1882000.0d, 0.0000636699d },
            { 1891000.0d, 0.000063107d },
            { 1900000.0d, 0.0000625411d },
            { 1909000.0d, 0.0000619722d },
            { 1918000.0d, 0.0000614006d },
            { 1927000.0d, 0.0000608264d },
            { 1936000.0d, 0.0000602499d },
            { 1945000.0d, 0.0000596713d },
            { 1954000.0d, 0.0000590908d },
            { 1963000.0d, 0.0000585085d },
            { 1972000.0d, 0.0000579249d },
            { 1981000.0d, 0.0000573401d },
            { 1990000.0d, 0.0000567544d },
            { 1999000.0d, 0.000056168d },
            { 2008000.0d, 0.0000555812d },
            { 2017000.0d, 0.0000549943d },
            { 2026000.0d, 0.0000544077d },
            { 2035000.0d, 0.0000538214d },
            { 2044000.0d, 0.000053236d },
            { 2053000.0d, 0.0000526517d },
            { 2062000.0d, 0.0000520671d },
            { 2071000.0d, 0.0000514775d },
            { 2080000.0d, 0.0000508829d },
            { 2089000.0d, 0.0000502832d },
            { 2098000.0d, 0.0000496785d },
            { 2107000.0d, 0.0000490688d },
            { 2116000.0d, 0.0000484543d },
            { 2125000.0d, 0.000047835d },
            { 2134000.0d, 0.0000472111d },
            { 2143000.0d, 0.0000465826d },
            { 2152000.0d, 0.0000459497d },
            { 2161000.0d, 0.0000453123d },
            { 2170000.0d, 0.0000446707d },
            { 2179000.0d, 0.0000440249d },
            { 2188000.0d, 0.000043375d },
            { 2197000.0d, 0.0000427213d },
            { 2206000.0d, 0.0000420637d },
            { 2215000.0d, 0.0000414026d },
            { 2224000.0d, 0.0000407378d },
            { 2233000.0d, 0.0000400698d },
            { 2242000.0d, 0.0000393983d },
            { 2251000.0d, 0.000038724d },
            { 2260000.0d, 0.0000380466d },
            { 2269000.0d, 0.0000373666d },
            { 2278000.0d, 0.0000366839d },
            { 2287000.0d, 0.0000359989d },
            { 2296000.0d, 0.0000353117d },
            { 2305000.0d, 0.0000346225d },
            { 2314000.0d, 0.0000339314d },
            { 2323000.0d, 0.0000332388d },
            { 2332000.0d, 0.0000325447d },
            { 2341000.0d, 0.0000318496d },
            { 2350000.0d, 0.0000311535d },
            { 2359000.0d, 0.0000304566d },
            { 2368000.0d, 0.0000297594d },
            { 2377000.0d, 0.0000290618d },
            { 2386000.0d, 0.0000283645d },
            { 2395000.0d, 0.0000276674d },
            { 2404000.0d, 0.0000269708d },
            { 2413000.0d, 0.0000262752d },
            { 2422000.0d, 0.0000255809d },
            { 2431000.0d, 0.0000248879d },
            { 2440000.0d, 0.0000241967d },
            { 2449000.0d, 0.0000235076d },
            { 2458000.0d, 0.0000228209d },
            { 2467000.0d, 0.0000221371d },
            { 2476000.0d, 0.0000214563d },
            { 2485000.0d, 0.000020779d },
            { 2494000.0d, 0.0000201055d },
            { 2503000.0d, 0.0000194361d },
            { 2512000.0d, 0.0000187714d },
            { 2521000.0d, 0.0000181116d },
            { 2530000.0d, 0.0000174572d },
            { 2539000.0d, 0.0000168079d },
            { 2548000.0d, 0.000016164d },
            { 2557000.0d, 0.000015526d },
            { 2566000.0d, 0.0000148941d },
            { 2575000.0d, 0.0000142687d },
            { 2584000.0d, 0.0000136506d },
            { 2593000.0d, 0.0000130399d },
            { 2602000.0d, 0.0000124371d },
            { 2611000.0d, 0.0000118429d },
            { 2620000.0d, 0.0000112574d },
            { 2629000.0d, 0.0000106813d },
            { 2638000.0d, 0.0000101152d },
            { 2647000.0d, 0.00000955948d },
            { 2656000.0d, 0.00000901464d },
            { 2665000.0d, 0.00000848124d },
            { 2674000.0d, 0.00000795983d },
            { 2683000.0d, 0.00000745096d },
            { 2692000.0d, 0.00000695519d },
            { 2701000.0d, 0.0000064731d },
            { 2710000.0d, 0.00000600526d },
            { 2719000.0d, 0.00000555228d },
            { 2728000.0d, 0.00000511407d },
            { 2737000.0d, 0.0000046893d },
            { 2746000.0d, 0.00000427844d },
            { 2755000.0d, 0.0000038821d },
            { 2764000.0d, 0.0000035009d },
            { 2773000.0d, 0.00000313549d },
            { 2782000.0d, 0.0000027865d },
            { 2791000.0d, 0.00000245459d },
            { 2800000.0d, 0.00000214045d },
            { 2809000.0d, 0.00000184474d },
            { 2818000.0d, 0.00000156818d },
            { 2827000.0d, 0.00000131147d },
            { 2836000.0d, 0.00000107535d },
            { 2845000.0d, 0.000000860514d },
            { 2854000.0d, 0.000000667741d },
            { 2863000.0d, 0.000000497777d },
            { 2872000.0d, 0.00000035139d },
            { 2881000.0d, 0.000000229353d },
            { 2890000.0d, 0.000000132446d },
            { 2899000.0d, 0.0000000614461d },
            { 2908000.0d, 0.0000000171208d },
            { 2917000.0d, 0.000000000169793d },
            { 2918000.0d, 0d },

        }; 
    }
}
    