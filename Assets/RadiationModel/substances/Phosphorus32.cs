using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus32 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus32";
        public override double halfLife { get; } = 1232755.2d;
        public override double atomicWeight { get; } = 31.97391d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur32()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000281151d },
            { 5000.0d, 0.000288175d },
            { 10000.0d, 0.000296871d },
            { 15000.0d, 0.000307239d },
            { 20000.0d, 0.000318124d },
            { 25000.0d, 0.000329105d },
            { 30000.0d, 0.000340019d },
            { 35000.0d, 0.000350797d },
            { 40000.0d, 0.000361413d },
            { 45000.0d, 0.000371862d },
            { 50000.0d, 0.000382144d },
            { 55000.0d, 0.000392265d },
            { 60000.0d, 0.000402233d },
            { 65000.0d, 0.000412053d },
            { 70000.0d, 0.000421733d },
            { 75000.0d, 0.000431281d },
            { 80000.0d, 0.000440702d },
            { 85000.0d, 0.000450002d },
            { 90000.0d, 0.000459187d },
            { 95000.0d, 0.000468259d },
            { 100000.0d, 0.000477225d },
            { 105000.0d, 0.000486087d },
            { 110000.0d, 0.000494849d },
            { 115000.0d, 0.000503513d },
            { 120000.0d, 0.000512082d },
            { 125000.0d, 0.000520559d },
            { 130000.0d, 0.000528945d },
            { 135000.0d, 0.000537242d },
            { 140000.0d, 0.000545453d },
            { 145000.0d, 0.000553577d },
            { 150000.0d, 0.000561617d },
            { 155000.0d, 0.000569573d },
            { 160000.0d, 0.000577447d },
            { 165000.0d, 0.000585239d },
            { 170000.0d, 0.00059295d },
            { 175000.0d, 0.000600581d },
            { 180000.0d, 0.000608132d },
            { 185000.0d, 0.000615603d },
            { 190000.0d, 0.000622996d },
            { 195000.0d, 0.00063031d },
            { 200000.0d, 0.000637545d },
            { 205000.0d, 0.000644702d },
            { 210000.0d, 0.000651782d },
            { 215000.0d, 0.000658783d },
            { 220000.0d, 0.000665706d },
            { 225000.0d, 0.000672551d },
            { 230000.0d, 0.000679319d },
            { 235000.0d, 0.000686008d },
            { 240000.0d, 0.000692619d },
            { 245000.0d, 0.000699153d },
            { 250000.0d, 0.000705608d },
            { 255000.0d, 0.000711985d },
            { 260000.0d, 0.000718283d },
            { 265000.0d, 0.000724503d },
            { 270000.0d, 0.000730644d },
            { 275000.0d, 0.000736705d },
            { 280000.0d, 0.000742688d },
            { 285000.0d, 0.000748591d },
            { 290000.0d, 0.000754415d },
            { 295000.0d, 0.000760158d },
            { 300000.0d, 0.000765822d },
            { 305000.0d, 0.000771405d },
            { 310000.0d, 0.000776908d },
            { 315000.0d, 0.00078233d },
            { 320000.0d, 0.00078767d },
            { 325000.0d, 0.00079293d },
            { 330000.0d, 0.000798107d },
            { 335000.0d, 0.000803203d },
            { 340000.0d, 0.000808217d },
            { 345000.0d, 0.000813149d },
            { 350000.0d, 0.000817998d },
            { 355000.0d, 0.000822764d },
            { 360000.0d, 0.000827447d },
            { 365000.0d, 0.000832047d },
            { 370000.0d, 0.000836563d },
            { 375000.0d, 0.000840995d },
            { 380000.0d, 0.000845344d },
            { 385000.0d, 0.000849608d },
            { 390000.0d, 0.000853787d },
            { 395000.0d, 0.000857882d },
            { 400000.0d, 0.000861892d },
            { 405000.0d, 0.000865817d },
            { 410000.0d, 0.000869656d },
            { 415000.0d, 0.00087341d },
            { 420000.0d, 0.000877078d },
            { 425000.0d, 0.00088066d },
            { 430000.0d, 0.000884157d },
            { 435000.0d, 0.000887566d },
            { 440000.0d, 0.00089089d },
            { 445000.0d, 0.000894126d },
            { 450000.0d, 0.000897276d },
            { 455000.0d, 0.000900339d },
            { 460000.0d, 0.000903315d },
            { 465000.0d, 0.000906204d },
            { 470000.0d, 0.000909006d },
            { 475000.0d, 0.00091172d },
            { 480000.0d, 0.000914346d },
            { 485000.0d, 0.000916885d },
            { 490000.0d, 0.000919336d },
            { 495000.0d, 0.000921699d },
            { 500000.0d, 0.000923974d },
            { 505000.0d, 0.000926161d },
            { 510000.0d, 0.00092826d },
            { 515000.0d, 0.000930271d },
            { 520000.0d, 0.000932194d },
            { 525000.0d, 0.000934028d },
            { 530000.0d, 0.000935774d },
            { 535000.0d, 0.000937432d },
            { 540000.0d, 0.000939002d },
            { 545000.0d, 0.000940483d },
            { 550000.0d, 0.000941876d },
            { 555000.0d, 0.000943181d },
            { 560000.0d, 0.000944398d },
            { 565000.0d, 0.000945526d },
            { 570000.0d, 0.000946566d },
            { 575000.0d, 0.000947518d },
            { 580000.0d, 0.000948381d },
            { 585000.0d, 0.000949157d },
            { 590000.0d, 0.000949845d },
            { 595000.0d, 0.000950444d },
            { 600000.0d, 0.000950956d },
            { 605000.0d, 0.000951381d },
            { 610000.0d, 0.000951717d },
            { 615000.0d, 0.000951966d },
            { 620000.0d, 0.000952128d },
            { 625000.0d, 0.000952203d },
            { 630000.0d, 0.00095219d },
            { 635000.0d, 0.000952091d },
            { 640000.0d, 0.000951904d },
            { 645000.0d, 0.000951631d },
            { 650000.0d, 0.000951272d },
            { 655000.0d, 0.000950827d },
            { 660000.0d, 0.000950295d },
            { 665000.0d, 0.000949678d },
            { 670000.0d, 0.000948974d },
            { 675000.0d, 0.000948186d },
            { 680000.0d, 0.000947312d },
            { 685000.0d, 0.000946354d },
            { 690000.0d, 0.000945311d },
            { 695000.0d, 0.000944183d },
            { 700000.0d, 0.000942971d },
            { 705000.0d, 0.000941676d },
            { 710000.0d, 0.000940297d },
            { 715000.0d, 0.000938834d },
            { 720000.0d, 0.000937289d },
            { 725000.0d, 0.000935661d },
            { 730000.0d, 0.000933951d },
            { 735000.0d, 0.000932159d },
            { 740000.0d, 0.000930285d },
            { 745000.0d, 0.00092833d },
            { 750000.0d, 0.000926294d },
            { 755000.0d, 0.000924177d },
            { 760000.0d, 0.00092198d },
            { 765000.0d, 0.000919704d },
            { 770000.0d, 0.000917348d },
            { 775000.0d, 0.000914913d },
            { 780000.0d, 0.0009124d },
            { 785000.0d, 0.000909808d },
            { 790000.0d, 0.000907139d },
            { 795000.0d, 0.000904393d },
            { 800000.0d, 0.00090157d },
            { 805000.0d, 0.00089867d },
            { 810000.0d, 0.000895695d },
            { 815000.0d, 0.000892645d },
            { 820000.0d, 0.000889519d },
            { 825000.0d, 0.00088632d },
            { 830000.0d, 0.000883046d },
            { 835000.0d, 0.000879699d },
            { 840000.0d, 0.000876279d },
            { 845000.0d, 0.000872788d },
            { 850000.0d, 0.000869224d },
            { 855000.0d, 0.000865589d },
            { 860000.0d, 0.000861884d },
            { 865000.0d, 0.000858109d },
            { 870000.0d, 0.000854264d },
            { 875000.0d, 0.00085035d },
            { 880000.0d, 0.000846369d },
            { 885000.0d, 0.000842319d },
            { 890000.0d, 0.000838203d },
            { 895000.0d, 0.00083402d },
            { 900000.0d, 0.000829772d },
            { 905000.0d, 0.000825459d },
            { 910000.0d, 0.000821081d },
            { 915000.0d, 0.000816639d },
            { 920000.0d, 0.000812135d },
            { 925000.0d, 0.000807568d },
            { 930000.0d, 0.000802939d },
            { 935000.0d, 0.00079825d },
            { 940000.0d, 0.0007935d },
            { 945000.0d, 0.00078869d },
            { 950000.0d, 0.000783822d },
            { 955000.0d, 0.000778896d },
            { 960000.0d, 0.000773912d },
            { 965000.0d, 0.000768872d },
            { 970000.0d, 0.000763776d },
            { 975000.0d, 0.000758626d },
            { 980000.0d, 0.00075342d },
            { 985000.0d, 0.000748162d },
            { 990000.0d, 0.000742851d },
            { 995000.0d, 0.000737488d },
            { 1000000.0d, 0.000732074d },
            { 1005000.0d, 0.00072661d },
            { 1010000.0d, 0.000721096d },
            { 1015000.0d, 0.000715534d },
            { 1020000.0d, 0.000709924d },
            { 1025000.0d, 0.000704268d },
            { 1030000.0d, 0.000698566d },
            { 1035000.0d, 0.000692819d },
            { 1040000.0d, 0.000687028d },
            { 1045000.0d, 0.000681193d },
            { 1050000.0d, 0.000675316d },
            { 1055000.0d, 0.000669398d },
            { 1060000.0d, 0.00066344d },
            { 1065000.0d, 0.000657441d },
            { 1070000.0d, 0.000651405d },
            { 1075000.0d, 0.000645331d },
            { 1080000.0d, 0.00063922d },
            { 1085000.0d, 0.000633073d },
            { 1090000.0d, 0.000626892d },
            { 1095000.0d, 0.000620677d },
            { 1100000.0d, 0.00061443d },
            { 1105000.0d, 0.00060815d },
            { 1110000.0d, 0.000601841d },
            { 1115000.0d, 0.000595501d },
            { 1120000.0d, 0.000589133d },
            { 1125000.0d, 0.000582737d },
            { 1130000.0d, 0.000576315d },
            { 1135000.0d, 0.000569867d },
            { 1140000.0d, 0.000563395d },
            { 1145000.0d, 0.0005569d },
            { 1150000.0d, 0.000550382d },
            { 1155000.0d, 0.000543844d },
            { 1160000.0d, 0.000537285d },
            { 1165000.0d, 0.000530708d },
            { 1170000.0d, 0.000524112d },
            { 1175000.0d, 0.0005175d },
            { 1180000.0d, 0.000510873d },
            { 1185000.0d, 0.000504231d },
            { 1190000.0d, 0.000497576d },
            { 1195000.0d, 0.000490909d },
            { 1200000.0d, 0.000484231d },
            { 1205000.0d, 0.000477543d },
            { 1210000.0d, 0.000470847d },
            { 1215000.0d, 0.000464144d },
            { 1220000.0d, 0.000457435d },
            { 1225000.0d, 0.00045072d },
            { 1230000.0d, 0.000444002d },
            { 1235000.0d, 0.000437282d },
            { 1240000.0d, 0.00043056d },
            { 1245000.0d, 0.000423839d },
            { 1250000.0d, 0.000417119d },
            { 1255000.0d, 0.000410401d },
            { 1260000.0d, 0.000403688d },
            { 1265000.0d, 0.00039698d },
            { 1270000.0d, 0.000390278d },
            { 1275000.0d, 0.000383584d },
            { 1280000.0d, 0.000376898d },
            { 1285000.0d, 0.000370224d },
            { 1290000.0d, 0.000363561d },
            { 1295000.0d, 0.000356911d },
            { 1300000.0d, 0.000350276d },
            { 1305000.0d, 0.000343656d },
            { 1310000.0d, 0.000337054d },
            { 1315000.0d, 0.000330469d },
            { 1320000.0d, 0.000323905d },
            { 1325000.0d, 0.000317362d },
            { 1330000.0d, 0.000310842d },
            { 1335000.0d, 0.000304346d },
            { 1340000.0d, 0.000297875d },
            { 1345000.0d, 0.000291431d },
            { 1350000.0d, 0.000285016d },
            { 1355000.0d, 0.00027863d },
            { 1360000.0d, 0.000272276d },
            { 1365000.0d, 0.000265954d },
            { 1370000.0d, 0.000259666d },
            { 1375000.0d, 0.000253414d },
            { 1380000.0d, 0.000247199d },
            { 1385000.0d, 0.000241022d },
            { 1390000.0d, 0.000234885d },
            { 1395000.0d, 0.00022879d },
            { 1400000.0d, 0.000222738d },
            { 1405000.0d, 0.000216731d },
            { 1410000.0d, 0.000210769d },
            { 1415000.0d, 0.000204856d },
            { 1420000.0d, 0.000198991d },
            { 1425000.0d, 0.000193177d },
            { 1430000.0d, 0.000187416d },
            { 1435000.0d, 0.000181708d },
            { 1440000.0d, 0.000176056d },
            { 1445000.0d, 0.000170461d },
            { 1450000.0d, 0.000164924d },
            { 1455000.0d, 0.000159448d },
            { 1460000.0d, 0.000154033d },
            { 1465000.0d, 0.000148682d },
            { 1470000.0d, 0.000143396d },
            { 1475000.0d, 0.000138177d },
            { 1480000.0d, 0.000133025d },
            { 1485000.0d, 0.000127944d },
            { 1490000.0d, 0.000122935d },
            { 1495000.0d, 0.000117999d },
            { 1500000.0d, 0.000113137d },
            { 1505000.0d, 0.000108353d },
            { 1510000.0d, 0.000103647d },
            { 1515000.0d, 0.0000990206d },
            { 1520000.0d, 0.0000944761d },
            { 1525000.0d, 0.0000900152d },
            { 1530000.0d, 0.0000856394d },
            { 1535000.0d, 0.0000813505d },
            { 1540000.0d, 0.0000771502d },
            { 1545000.0d, 0.0000730404d },
            { 1550000.0d, 0.0000690226d },
            { 1555000.0d, 0.0000650988d },
            { 1560000.0d, 0.0000612707d },
            { 1565000.0d, 0.0000575399d },
            { 1570000.0d, 0.0000539085d },
            { 1575000.0d, 0.000050378d },
            { 1580000.0d, 0.0000469503d },
            { 1585000.0d, 0.0000436273d },
            { 1590000.0d, 0.0000404107d },
            { 1595000.0d, 0.0000373024d },
            { 1600000.0d, 0.0000343042d },
            { 1605000.0d, 0.0000314179d },
            { 1610000.0d, 0.0000286454d },
            { 1615000.0d, 0.0000259885d },
            { 1620000.0d, 0.0000234492d },
            { 1625000.0d, 0.0000210291d },
            { 1630000.0d, 0.0000187304d },
            { 1635000.0d, 0.0000165547d },
            { 1640000.0d, 0.0000145041d },
            { 1645000.0d, 0.0000125804d },
            { 1650000.0d, 0.0000107856d },
            { 1655000.0d, 0.00000912148d },
            { 1660000.0d, 0.00000759004d },
            { 1665000.0d, 0.00000619321d },
            { 1670000.0d, 0.00000493292d },
            { 1675000.0d, 0.00000381112d },
            { 1680000.0d, 0.00000282976d },
            { 1685000.0d, 0.00000199081d },
            { 1690000.0d, 0.00000129623d },
            { 1695000.0d, 0.00000074801d },
            { 1700000.0d, 0.000000348125d },
            { 1705000.0d, 0.0000000985701d },
            { 1710000.0d, 0.00000000134613d },
            { 1710660.0d, 0d },

        }; 
    }
}
    