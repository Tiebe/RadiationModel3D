using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium111";
        public override double halfLife { get; } = 1404.0d;
        public override double atomicWeight { get; } = 110.90769d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver111()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.005481000000000001d, new GammaParticle(59820.0, 0.02073)), new(0.00783d, new GammaParticle(70430.0, 0.0176)), new(0.0001566d, new GammaParticle(87000.0, 0.01425)), new(5.2199999999999995e-05d, new GammaParticle(101400.0, 0.01223)), new(4.35e-06d, new GammaParticle(141800.0, 0.00874)), new(0.0001305d, new GammaParticle(166000.0, 0.00747)), new(0.000348d, new GammaParticle(169400.0, 0.00732)), new(0.00010439999999999999d, new GammaParticle(202200.0, 0.00613)), new(0.00024359999999999999d, new GammaParticle(230300.0, 0.00538)), new(0.00010439999999999999d, new GammaParticle(279000.0, 0.00444)), new(0.0010613999999999999d, new GammaParticle(289800.0, 0.00428)), new(9.570000000000001e-05d, new GammaParticle(308400.0, 0.00402)), new(0.00020879999999999998d, new GammaParticle(316800.0, 0.00391)), new(6.0899999999999996e-05d, new GammaParticle(352200.0, 0.00352)), new(0.0046110000000000005d, new GammaParticle(376680.0, 0.00329)), new(0.0002697d, new GammaParticle(391200.0, 0.00317)), new(0.0008699999999999999d, new GammaParticle(404800.0, 0.00306)), new(0.000261d, new GammaParticle(414000.0, 0.00299)), new(0.0007656000000000001d, new GammaParticle(415500.0, 0.00298)), new(4.35e-05d, new GammaParticle(418000.0, 0.00297)), new(0.0005046d, new GammaParticle(438500.0, 0.00283)), new(0.0006003d, new GammaParticle(476700.0, 0.0026)), new(0.0002001d, new GammaParticle(478900.0, 0.00259)), new(0.0002697d, new GammaParticle(485800.0, 0.00255)), new(8.7e-05d, new GammaParticle(494100.0, 0.00251)), new(0.002175d, new GammaParticle(509100.0, 0.00244)), new(0.002175d, new GammaParticle(509100.0, 0.00244)), new(0.0002697d, new GammaParticle(516400.0, 0.0024)), new(0.00010439999999999999d, new GammaParticle(519300.0, 0.00239)), new(0.0002697d, new GammaParticle(540700.0, 0.00229)), new(0.003828d, new GammaParticle(547000.0, 0.00227)), new(0.0001653d, new GammaParticle(552600.0, 0.00224)), new(0.0087d, new GammaParticle(580000.0, 0.00214)), new(0.00023490000000000002d, new GammaParticle(603100.0, 0.00206)), new(0.00018270000000000002d, new GammaParticle(611300.0, 0.00203)), new(0.0028710000000000003d, new GammaParticle(623200.0, 0.00199)), new(0.000174d, new GammaParticle(624000.0, 0.00199)), new(0.00021749999999999997d, new GammaParticle(635000.0, 0.00195)), new(0.000174d, new GammaParticle(641700.0, 0.00193)), new(0.00043499999999999995d, new GammaParticle(641700.0, 0.00193)), new(0.005742000000000001d, new GammaParticle(650400.0, 0.00191)), new(0.00024359999999999999d, new GammaParticle(657300.0, 0.00189)), new(0.000522d, new GammaParticle(685400.0, 0.00181)), new(0.001305d, new GammaParticle(709800.0, 0.00175)), new(0.000174d, new GammaParticle(742600.0, 0.00167)), new(0.0001479d, new GammaParticle(745700.0, 0.00166)), new(4.35e-05d, new GammaParticle(773000.0, 0.0016)), new(0.00043499999999999995d, new GammaParticle(775500.0, 0.0016)), new(0.00018270000000000002d, new GammaParticle(793800.0, 0.00156)), new(0.0003567d, new GammaParticle(803800.0, 0.00154)), new(1.2179999999999999e-05d, new GammaParticle(808500.0, 0.00153)), new(0.0002697d, new GammaParticle(808500.0, 0.00153)), new(7.83e-05d, new GammaParticle(816500.0, 0.00152)), new(8.7e-05d, new GammaParticle(833000.0, 0.00149)), new(0.002784d, new GammaParticle(835700.0, 0.00148)), new(4.35e-05d, new GammaParticle(890000.0, 0.00139)), new(0.0002523d, new GammaParticle(921400.0, 0.00135)), new(6.96e-05d, new GammaParticle(937300.0, 0.00132)), new(8.7e-05d, new GammaParticle(950000.0, 0.00131)), new(0.0003915d, new GammaParticle(955500.0, 0.0013)), new(0.0006351d, new GammaParticle(1002300.0, 0.00124)), new(8.7e-05d, new GammaParticle(1015000.0, 0.00122)), new(6.96e-05d, new GammaParticle(1022000.0, 0.00121)), new(8.7e-05d, new GammaParticle(1026600.0, 0.00121)), new(4.35e-05d, new GammaParticle(1053000.0, 0.00118)), new(0.0001305d, new GammaParticle(1059800.0, 0.00117)), new(0.0001305d, new GammaParticle(1067100.0, 0.00116)), new(6.96e-05d, new GammaParticle(1098000.0, 0.00113)), new(0.001392d, new GammaParticle(1120400.0, 0.00111)), new(3.48e-05d, new GammaParticle(1246000.0, 0.001)), new(8.7e-05d, new GammaParticle(1269700.0, 0.00098)), new(7.83e-05d, new GammaParticle(1311200.0, 0.00095)), new(0.000174d, new GammaParticle(1348000.0, 0.00092)), new(0.005568d, new GammaParticle(1388500.0, 0.00089)), new(4.35e-05d, new GammaParticle(1395000.0, 0.00089)), new(0.005829d, new GammaParticle(1459000.0, 0.00085)), new(8.7e-06d, new GammaParticle(1506000.0, 0.00082)), new(0.00022620000000000002d, new GammaParticle(1542900.0, 0.0008)), new(5.2199999999999995e-05d, new GammaParticle(1549000.0, 0.0008)), new(0.0002697d, new GammaParticle(1574500.0, 0.00079)), new(0.0002001d, new GammaParticle(1644300.0, 0.00075)), new(2.6099999999999997e-05d, new GammaParticle(1863200.0, 0.00067)), new(0.05035681349081951d, new GammaParticle(3218.0, 0.38528)), new(0.05779222221358335d, new GammaParticle(21990.0, 0.05638)), new(0.10893915591627397d, new GammaParticle(22163.0, 0.05594)), new(0.03017923156098355d, new GammaParticle(25030.0, 0.04953)), new(0.03543041785259468d, new GammaParticle(25211.0, 0.04918)), new(0.005251186291611138d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000351583d },
            { 1000.0d, 0.000352547d },
            { 2000.0d, 0.000353497d },
            { 3000.0d, 0.000354432d },
            { 4000.0d, 0.00035534d },
            { 5000.0d, 0.000356222d },
            { 6000.0d, 0.000357077d },
            { 7000.0d, 0.000357929d },
            { 8000.0d, 0.00035877d },
            { 9000.0d, 0.000359606d },
            { 10000.0d, 0.000360436d },
            { 11000.0d, 0.000361262d },
            { 12000.0d, 0.000362082d },
            { 13000.0d, 0.000362898d },
            { 14000.0d, 0.000363709d },
            { 15000.0d, 0.000364516d },
            { 16000.0d, 0.000365318d },
            { 17000.0d, 0.000366116d },
            { 18000.0d, 0.00036691d },
            { 19000.0d, 0.000367701d },
            { 20000.0d, 0.000368487d },
            { 21000.0d, 0.000369269d },
            { 22000.0d, 0.00037006d },
            { 23000.0d, 0.00037085d },
            { 24000.0d, 0.000371639d },
            { 25000.0d, 0.000372428d },
            { 26000.0d, 0.000373217d },
            { 27000.0d, 0.000374005d },
            { 28000.0d, 0.000374792d },
            { 29000.0d, 0.000375586d },
            { 30000.0d, 0.00037638d },
            { 31000.0d, 0.000377176d },
            { 32000.0d, 0.000377972d },
            { 33000.0d, 0.00037877d },
            { 34000.0d, 0.000379569d },
            { 35000.0d, 0.000380369d },
            { 36000.0d, 0.000381173d },
            { 37000.0d, 0.000381978d },
            { 38000.0d, 0.000382785d },
            { 39000.0d, 0.000383594d },
            { 40000.0d, 0.000384404d },
            { 41000.0d, 0.000385216d },
            { 42000.0d, 0.00038603d },
            { 43000.0d, 0.000386846d },
            { 44000.0d, 0.000387664d },
            { 45000.0d, 0.000388483d },
            { 46000.0d, 0.000389304d },
            { 47000.0d, 0.000390127d },
            { 48000.0d, 0.000390951d },
            { 49000.0d, 0.000391777d },
            { 50000.0d, 0.000392604d },
            { 51000.0d, 0.000393433d },
            { 52000.0d, 0.000394263d },
            { 53000.0d, 0.000395095d },
            { 54000.0d, 0.000395929d },
            { 55000.0d, 0.000396764d },
            { 56000.0d, 0.0003976d },
            { 57000.0d, 0.000398437d },
            { 58000.0d, 0.000399275d },
            { 59000.0d, 0.000400115d },
            { 60000.0d, 0.000400956d },
            { 61000.0d, 0.000401798d },
            { 62000.0d, 0.000402641d },
            { 63000.0d, 0.000403486d },
            { 64000.0d, 0.000404331d },
            { 65000.0d, 0.000405176d },
            { 66000.0d, 0.000406023d },
            { 67000.0d, 0.00040687d },
            { 68000.0d, 0.000407719d },
            { 69000.0d, 0.000408568d },
            { 70000.0d, 0.000409419d },
            { 71000.0d, 0.000410269d },
            { 72000.0d, 0.00041112d },
            { 73000.0d, 0.000411972d },
            { 74000.0d, 0.000412825d },
            { 75000.0d, 0.000413678d },
            { 76000.0d, 0.000414531d },
            { 77000.0d, 0.000415386d },
            { 78000.0d, 0.00041624d },
            { 79000.0d, 0.000417095d },
            { 80000.0d, 0.00041795d },
            { 81000.0d, 0.000418806d },
            { 82000.0d, 0.000419662d },
            { 83000.0d, 0.000420519d },
            { 84000.0d, 0.000421376d },
            { 85000.0d, 0.000422232d },
            { 86000.0d, 0.000423089d },
            { 87000.0d, 0.000423946d },
            { 88000.0d, 0.000424803d },
            { 89000.0d, 0.000425661d },
            { 90000.0d, 0.000426518d },
            { 91000.0d, 0.000427376d },
            { 92000.0d, 0.000428233d },
            { 93000.0d, 0.000429091d },
            { 94000.0d, 0.000429948d },
            { 95000.0d, 0.000430806d },
            { 96000.0d, 0.000431663d },
            { 97000.0d, 0.000432521d },
            { 98000.0d, 0.000433379d },
            { 99000.0d, 0.000434236d },
            { 100000.0d, 0.000435093d },
            { 107000.0d, 0.000441086d },
            { 114000.0d, 0.000447063d },
            { 121000.0d, 0.00045302d },
            { 128000.0d, 0.00045895d },
            { 135000.0d, 0.000464849d },
            { 142000.0d, 0.000470712d },
            { 149000.0d, 0.000476536d },
            { 156000.0d, 0.000482319d },
            { 163000.0d, 0.000488055d },
            { 170000.0d, 0.000493744d },
            { 177000.0d, 0.000499384d },
            { 184000.0d, 0.00050497d },
            { 191000.0d, 0.000510503d },
            { 198000.0d, 0.000515979d },
            { 205000.0d, 0.000521398d },
            { 212000.0d, 0.000526757d },
            { 219000.0d, 0.000532056d },
            { 226000.0d, 0.000537292d },
            { 233000.0d, 0.000542465d },
            { 240000.0d, 0.000547574d },
            { 247000.0d, 0.000552618d },
            { 254000.0d, 0.000557595d },
            { 261000.0d, 0.000562505d },
            { 268000.0d, 0.000567348d },
            { 275000.0d, 0.000572122d },
            { 282000.0d, 0.000576827d },
            { 289000.0d, 0.000581461d },
            { 296000.0d, 0.000586026d },
            { 303000.0d, 0.00059052d },
            { 310000.0d, 0.000594943d },
            { 317000.0d, 0.000599294d },
            { 324000.0d, 0.000603574d },
            { 331000.0d, 0.00060778d },
            { 338000.0d, 0.000611914d },
            { 345000.0d, 0.000615976d },
            { 352000.0d, 0.000619965d },
            { 359000.0d, 0.000623881d },
            { 366000.0d, 0.000627724d },
            { 373000.0d, 0.000631494d },
            { 380000.0d, 0.000635191d },
            { 387000.0d, 0.000638814d },
            { 394000.0d, 0.000642364d },
            { 401000.0d, 0.000645843d },
            { 408000.0d, 0.000649247d },
            { 415000.0d, 0.00065258d },
            { 422000.0d, 0.000655841d },
            { 429000.0d, 0.00065903d },
            { 436000.0d, 0.000662147d },
            { 443000.0d, 0.000665192d },
            { 450000.0d, 0.000668167d },
            { 457000.0d, 0.00067107d },
            { 464000.0d, 0.000673904d },
            { 471000.0d, 0.000676668d },
            { 478000.0d, 0.000679362d },
            { 485000.0d, 0.000681988d },
            { 492000.0d, 0.000684546d },
            { 499000.0d, 0.000687036d },
            { 506000.0d, 0.000689459d },
            { 513000.0d, 0.000691816d },
            { 520000.0d, 0.000694105d },
            { 527000.0d, 0.000696326d },
            { 534000.0d, 0.00069848d },
            { 541000.0d, 0.000700566d },
            { 548000.0d, 0.000702585d },
            { 555000.0d, 0.000704538d },
            { 562000.0d, 0.000706426d },
            { 569000.0d, 0.000708248d },
            { 576000.0d, 0.000710006d },
            { 583000.0d, 0.0007117d },
            { 590000.0d, 0.00071333d },
            { 597000.0d, 0.0007149d },
            { 604000.0d, 0.000716407d },
            { 611000.0d, 0.000717855d },
            { 618000.0d, 0.000719242d },
            { 625000.0d, 0.000720569d },
            { 632000.0d, 0.000721838d },
            { 639000.0d, 0.000723048d },
            { 646000.0d, 0.000724201d },
            { 653000.0d, 0.000725299d },
            { 660000.0d, 0.000726341d },
            { 667000.0d, 0.000727329d },
            { 674000.0d, 0.000728265d },
            { 681000.0d, 0.000729149d },
            { 688000.0d, 0.000729981d },
            { 695000.0d, 0.000730764d },
            { 702000.0d, 0.000731493d },
            { 709000.0d, 0.000732142d },
            { 716000.0d, 0.000732708d },
            { 723000.0d, 0.000733193d },
            { 730000.0d, 0.000733595d },
            { 737000.0d, 0.000733914d },
            { 744000.0d, 0.00073415d },
            { 751000.0d, 0.000734306d },
            { 758000.0d, 0.000734379d },
            { 765000.0d, 0.000734371d },
            { 772000.0d, 0.000734281d },
            { 779000.0d, 0.00073411d },
            { 786000.0d, 0.000733858d },
            { 793000.0d, 0.000733524d },
            { 800000.0d, 0.000733112d },
            { 807000.0d, 0.000732617d },
            { 814000.0d, 0.000732044d },
            { 821000.0d, 0.00073139d },
            { 828000.0d, 0.000730658d },
            { 835000.0d, 0.000729846d },
            { 842000.0d, 0.000728955d },
            { 849000.0d, 0.000727987d },
            { 856000.0d, 0.00072694d },
            { 863000.0d, 0.000725816d },
            { 870000.0d, 0.000724614d },
            { 877000.0d, 0.000723336d },
            { 884000.0d, 0.000721982d },
            { 891000.0d, 0.000720551d },
            { 898000.0d, 0.000719045d },
            { 905000.0d, 0.000717464d },
            { 912000.0d, 0.000715808d },
            { 919000.0d, 0.000714079d },
            { 926000.0d, 0.000712276d },
            { 933000.0d, 0.0007104d },
            { 940000.0d, 0.000708452d },
            { 947000.0d, 0.000706432d },
            { 954000.0d, 0.00070434d },
            { 961000.0d, 0.000702178d },
            { 968000.0d, 0.000699946d },
            { 975000.0d, 0.000697644d },
            { 982000.0d, 0.000695273d },
            { 989000.0d, 0.000692834d },
            { 996000.0d, 0.000690327d },
            { 1003000.0d, 0.000687754d },
            { 1010000.0d, 0.000685114d },
            { 1017000.0d, 0.000682407d },
            { 1024000.0d, 0.000679634d },
            { 1031000.0d, 0.000676796d },
            { 1038000.0d, 0.000673893d },
            { 1045000.0d, 0.000670926d },
            { 1052000.0d, 0.000667893d },
            { 1059000.0d, 0.000664797d },
            { 1066000.0d, 0.000661636d },
            { 1073000.0d, 0.000658413d },
            { 1080000.0d, 0.000655127d },
            { 1087000.0d, 0.000651779d },
            { 1094000.0d, 0.000648372d },
            { 1101000.0d, 0.000644903d },
            { 1108000.0d, 0.000641375d },
            { 1115000.0d, 0.000637788d },
            { 1122000.0d, 0.000634141d },
            { 1129000.0d, 0.000630437d },
            { 1136000.0d, 0.000626676d },
            { 1143000.0d, 0.000622857d },
            { 1150000.0d, 0.00061898d },
            { 1157000.0d, 0.000615048d },
            { 1164000.0d, 0.00061106d },
            { 1171000.0d, 0.000607015d },
            { 1178000.0d, 0.000602915d },
            { 1185000.0d, 0.000598761d },
            { 1192000.0d, 0.000594554d },
            { 1199000.0d, 0.000590294d },
            { 1206000.0d, 0.000585983d },
            { 1213000.0d, 0.00058162d },
            { 1220000.0d, 0.000577209d },
            { 1227000.0d, 0.000572747d },
            { 1234000.0d, 0.000568237d },
            { 1241000.0d, 0.00056368d },
            { 1248000.0d, 0.000559078d },
            { 1255000.0d, 0.000554429d },
            { 1262000.0d, 0.000549736d },
            { 1269000.0d, 0.000545001d },
            { 1276000.0d, 0.000540222d },
            { 1283000.0d, 0.000535402d },
            { 1290000.0d, 0.000530541d },
            { 1297000.0d, 0.000525641d },
            { 1304000.0d, 0.000520702d },
            { 1311000.0d, 0.000515727d },
            { 1318000.0d, 0.000510714d },
            { 1325000.0d, 0.000505665d },
            { 1332000.0d, 0.000500583d },
            { 1339000.0d, 0.000495468d },
            { 1346000.0d, 0.00049032d },
            { 1353000.0d, 0.000485141d },
            { 1360000.0d, 0.000479932d },
            { 1367000.0d, 0.000474695d },
            { 1374000.0d, 0.000469429d },
            { 1381000.0d, 0.000464137d },
            { 1388000.0d, 0.000458818d },
            { 1395000.0d, 0.000453476d },
            { 1402000.0d, 0.00044811d },
            { 1409000.0d, 0.000442723d },
            { 1416000.0d, 0.000437315d },
            { 1423000.0d, 0.000431886d },
            { 1430000.0d, 0.000426439d },
            { 1437000.0d, 0.000420975d },
            { 1444000.0d, 0.000415494d },
            { 1451000.0d, 0.00041d },
            { 1458000.0d, 0.000404491d },
            { 1465000.0d, 0.00039897d },
            { 1472000.0d, 0.000393437d },
            { 1479000.0d, 0.000387895d },
            { 1486000.0d, 0.000382345d },
            { 1493000.0d, 0.000376787d },
            { 1500000.0d, 0.000371224d },
            { 1507000.0d, 0.000365655d },
            { 1514000.0d, 0.000360082d },
            { 1521000.0d, 0.0003545d },
            { 1528000.0d, 0.000348914d },
            { 1535000.0d, 0.000343323d },
            { 1542000.0d, 0.000337729d },
            { 1549000.0d, 0.000332132d },
            { 1556000.0d, 0.000326536d },
            { 1563000.0d, 0.000320939d },
            { 1570000.0d, 0.000315346d },
            { 1577000.0d, 0.000309755d },
            { 1584000.0d, 0.000304169d },
            { 1591000.0d, 0.000298589d },
            { 1598000.0d, 0.000293017d },
            { 1605000.0d, 0.000287453d },
            { 1612000.0d, 0.0002819d },
            { 1619000.0d, 0.000276357d },
            { 1626000.0d, 0.000270826d },
            { 1633000.0d, 0.000265308d },
            { 1640000.0d, 0.000259805d },
            { 1647000.0d, 0.000254317d },
            { 1654000.0d, 0.000248846d },
            { 1661000.0d, 0.000243394d },
            { 1668000.0d, 0.000237962d },
            { 1675000.0d, 0.00023255d },
            { 1682000.0d, 0.000227161d },
            { 1689000.0d, 0.000221796d },
            { 1696000.0d, 0.000216456d },
            { 1703000.0d, 0.000211142d },
            { 1710000.0d, 0.000205858d },
            { 1717000.0d, 0.000200602d },
            { 1724000.0d, 0.000195379d },
            { 1731000.0d, 0.000190187d },
            { 1738000.0d, 0.000185031d },
            { 1745000.0d, 0.000179909d },
            { 1752000.0d, 0.000174825d },
            { 1759000.0d, 0.00016978d },
            { 1766000.0d, 0.000164775d },
            { 1773000.0d, 0.000159812d },
            { 1780000.0d, 0.000154892d },
            { 1787000.0d, 0.000150018d },
            { 1794000.0d, 0.00014519d },
            { 1801000.0d, 0.000140411d },
            { 1808000.0d, 0.000135681d },
            { 1815000.0d, 0.000131003d },
            { 1822000.0d, 0.000126378d },
            { 1829000.0d, 0.000121808d },
            { 1836000.0d, 0.000117293d },
            { 1843000.0d, 0.000112837d },
            { 1850000.0d, 0.00010844d },
            { 1857000.0d, 0.000104104d },
            { 1864000.0d, 0.0000998305d },
            { 1871000.0d, 0.0000956214d },
            { 1878000.0d, 0.000091478d },
            { 1885000.0d, 0.0000874022d },
            { 1892000.0d, 0.0000833956d },
            { 1899000.0d, 0.00007946d },
            { 1906000.0d, 0.0000755971d },
            { 1913000.0d, 0.0000718086d },
            { 1920000.0d, 0.0000680963d },
            { 1927000.0d, 0.0000644618d },
            { 1934000.0d, 0.0000609069d },
            { 1941000.0d, 0.0000574336d },
            { 1948000.0d, 0.0000540432d },
            { 1955000.0d, 0.0000507379d },
            { 1962000.0d, 0.0000475192d },
            { 1969000.0d, 0.000044389d },
            { 1976000.0d, 0.0000413491d },
            { 1983000.0d, 0.0000384012d },
            { 1990000.0d, 0.0000355472d },
            { 1997000.0d, 0.000032789d },
            { 2004000.0d, 0.0000301281d },
            { 2011000.0d, 0.0000275667d },
            { 2018000.0d, 0.0000251065d },
            { 2025000.0d, 0.0000227492d },
            { 2032000.0d, 0.0000204968d },
            { 2039000.0d, 0.0000183511d },
            { 2046000.0d, 0.000016314d },
            { 2053000.0d, 0.0000143873d },
            { 2060000.0d, 0.0000125728d },
            { 2067000.0d, 0.0000108725d },
            { 2074000.0d, 0.00000928828d },
            { 2081000.0d, 0.00000782189d },
            { 2088000.0d, 0.00000647526d },
            { 2095000.0d, 0.00000525025d },
            { 2102000.0d, 0.00000414875d },
            { 2109000.0d, 0.0000031726d },
            { 2116000.0d, 0.00000232368d },
            { 2123000.0d, 0.0000016038d },
            { 2130000.0d, 0.00000101479d },
            { 2137000.0d, 0.000000558424d },
            { 2144000.0d, 0.000000236429d },
            { 2151000.0d, 0.0000000503746d },
            { 2157000.0d, 0d },

        }; 
    }
}
    