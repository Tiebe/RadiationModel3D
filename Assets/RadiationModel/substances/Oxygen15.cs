using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Oxygen15 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen15";
        public override double halfLife { get; } = 122.24d;
        public override double atomicWeight { get; } = 15.00307d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Carbon15()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.998006d, new GammaParticle(511000.0, 0.00243)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 5000.0d, 0.0000263374d },
            { 10000.0d, 0.0000540103d },
            { 15000.0d, 0.0000782271d },
            { 20000.0d, 0.000099951d },
            { 25000.0d, 0.00011986d },
            { 30000.0d, 0.000138389d },
            { 35000.0d, 0.00015583d },
            { 40000.0d, 0.000172389d },
            { 45000.0d, 0.000188215d },
            { 50000.0d, 0.000203421d },
            { 55000.0d, 0.000218093d },
            { 60000.0d, 0.000232299d },
            { 65000.0d, 0.000246094d },
            { 70000.0d, 0.000259524d },
            { 75000.0d, 0.000272625d },
            { 80000.0d, 0.000285428d },
            { 85000.0d, 0.000297958d },
            { 90000.0d, 0.000310238d },
            { 95000.0d, 0.000322288d },
            { 100000.0d, 0.000334122d },
            { 105000.0d, 0.000345755d },
            { 110000.0d, 0.0003572d },
            { 115000.0d, 0.000368468d },
            { 120000.0d, 0.000379567d },
            { 125000.0d, 0.000390505d },
            { 130000.0d, 0.000401292d },
            { 135000.0d, 0.000411932d },
            { 140000.0d, 0.000422432d },
            { 145000.0d, 0.000432797d },
            { 150000.0d, 0.000443032d },
            { 155000.0d, 0.00045314d },
            { 160000.0d, 0.000463126d },
            { 165000.0d, 0.000472993d },
            { 170000.0d, 0.000482744d },
            { 175000.0d, 0.000492381d },
            { 180000.0d, 0.000501907d },
            { 185000.0d, 0.000511324d },
            { 190000.0d, 0.000520635d },
            { 195000.0d, 0.00052984d },
            { 200000.0d, 0.000538942d },
            { 205000.0d, 0.000547941d },
            { 210000.0d, 0.00055684d },
            { 215000.0d, 0.00056564d },
            { 220000.0d, 0.00057434d },
            { 225000.0d, 0.000582943d },
            { 230000.0d, 0.000591449d },
            { 235000.0d, 0.000599859d },
            { 240000.0d, 0.000608174d },
            { 245000.0d, 0.000616393d },
            { 250000.0d, 0.000624519d },
            { 255000.0d, 0.00063255d },
            { 260000.0d, 0.000640488d },
            { 265000.0d, 0.000648332d },
            { 270000.0d, 0.000656084d },
            { 275000.0d, 0.000663743d },
            { 280000.0d, 0.000671309d },
            { 285000.0d, 0.000678784d },
            { 290000.0d, 0.000686166d },
            { 295000.0d, 0.000693456d },
            { 300000.0d, 0.000700654d },
            { 305000.0d, 0.00070776d },
            { 310000.0d, 0.000714774d },
            { 315000.0d, 0.000721697d },
            { 320000.0d, 0.000728527d },
            { 325000.0d, 0.000735266d },
            { 330000.0d, 0.000741912d },
            { 335000.0d, 0.000748467d },
            { 340000.0d, 0.000754929d },
            { 345000.0d, 0.000761299d },
            { 350000.0d, 0.000767577d },
            { 355000.0d, 0.000773762d },
            { 360000.0d, 0.000779855d },
            { 365000.0d, 0.000785856d },
            { 370000.0d, 0.000791763d },
            { 375000.0d, 0.000797578d },
            { 380000.0d, 0.000803299d },
            { 385000.0d, 0.000808927d },
            { 390000.0d, 0.000814462d },
            { 395000.0d, 0.000819904d },
            { 400000.0d, 0.000825252d },
            { 405000.0d, 0.000830506d },
            { 410000.0d, 0.000835666d },
            { 415000.0d, 0.000840732d },
            { 420000.0d, 0.000845704d },
            { 425000.0d, 0.000850582d },
            { 430000.0d, 0.000855365d },
            { 435000.0d, 0.000860053d },
            { 440000.0d, 0.000864647d },
            { 445000.0d, 0.000869146d },
            { 450000.0d, 0.000873549d },
            { 455000.0d, 0.000877858d },
            { 460000.0d, 0.000882071d },
            { 465000.0d, 0.000886188d },
            { 470000.0d, 0.00089021d },
            { 475000.0d, 0.000894137d },
            { 480000.0d, 0.000897967d },
            { 485000.0d, 0.000901702d },
            { 490000.0d, 0.00090534d },
            { 495000.0d, 0.000908883d },
            { 500000.0d, 0.000912329d },
            { 505000.0d, 0.000915679d },
            { 510000.0d, 0.000918933d },
            { 515000.0d, 0.00092209d },
            { 520000.0d, 0.000925151d },
            { 525000.0d, 0.000928116d },
            { 530000.0d, 0.000930983d },
            { 535000.0d, 0.000933754d },
            { 540000.0d, 0.000936429d },
            { 545000.0d, 0.000939006d },
            { 550000.0d, 0.000941487d },
            { 555000.0d, 0.000943871d },
            { 560000.0d, 0.000946159d },
            { 565000.0d, 0.000948349d },
            { 570000.0d, 0.000950443d },
            { 575000.0d, 0.000952441d },
            { 580000.0d, 0.000954341d },
            { 585000.0d, 0.000956145d },
            { 590000.0d, 0.000957852d },
            { 595000.0d, 0.000959463d },
            { 600000.0d, 0.000960977d },
            { 605000.0d, 0.000962394d },
            { 610000.0d, 0.000963716d },
            { 615000.0d, 0.00096494d },
            { 620000.0d, 0.000966069d },
            { 625000.0d, 0.000967102d },
            { 630000.0d, 0.000968038d },
            { 635000.0d, 0.000968879d },
            { 640000.0d, 0.000969624d },
            { 645000.0d, 0.000970273d },
            { 650000.0d, 0.000970827d },
            { 655000.0d, 0.000971285d },
            { 660000.0d, 0.000971648d },
            { 665000.0d, 0.000971916d },
            { 670000.0d, 0.00097209d },
            { 675000.0d, 0.000972168d },
            { 680000.0d, 0.000972153d },
            { 685000.0d, 0.000972043d },
            { 690000.0d, 0.000971839d },
            { 695000.0d, 0.000971541d },
            { 700000.0d, 0.000971149d },
            { 705000.0d, 0.000970665d },
            { 710000.0d, 0.000970087d },
            { 715000.0d, 0.000969416d },
            { 720000.0d, 0.000968653d },
            { 725000.0d, 0.000967797d },
            { 730000.0d, 0.00096685d },
            { 735000.0d, 0.000965811d },
            { 740000.0d, 0.00096468d },
            { 745000.0d, 0.000963459d },
            { 750000.0d, 0.000962147d },
            { 755000.0d, 0.000960744d },
            { 760000.0d, 0.000959251d },
            { 765000.0d, 0.000957669d },
            { 770000.0d, 0.000955998d },
            { 775000.0d, 0.000954237d },
            { 780000.0d, 0.000952388d },
            { 785000.0d, 0.000950451d },
            { 790000.0d, 0.000948426d },
            { 795000.0d, 0.000946314d },
            { 800000.0d, 0.000944115d },
            { 805000.0d, 0.000941829d },
            { 810000.0d, 0.000939457d },
            { 815000.0d, 0.000937d },
            { 820000.0d, 0.000934458d },
            { 825000.0d, 0.000931831d },
            { 830000.0d, 0.00092912d },
            { 835000.0d, 0.000926325d },
            { 840000.0d, 0.000923448d },
            { 845000.0d, 0.000920487d },
            { 850000.0d, 0.000917445d },
            { 855000.0d, 0.000914321d },
            { 860000.0d, 0.000911115d },
            { 865000.0d, 0.00090783d },
            { 870000.0d, 0.000904464d },
            { 875000.0d, 0.00090102d },
            { 880000.0d, 0.000897496d },
            { 885000.0d, 0.000893894d },
            { 890000.0d, 0.000890215d },
            { 895000.0d, 0.000886459d },
            { 900000.0d, 0.000882627d },
            { 905000.0d, 0.000878718d },
            { 910000.0d, 0.000874735d },
            { 915000.0d, 0.000870678d },
            { 920000.0d, 0.000866546d },
            { 925000.0d, 0.000862342d },
            { 930000.0d, 0.000858066d },
            { 935000.0d, 0.000853717d },
            { 940000.0d, 0.000849298d },
            { 945000.0d, 0.000844808d },
            { 950000.0d, 0.000840249d },
            { 955000.0d, 0.000835621d },
            { 960000.0d, 0.000830925d },
            { 965000.0d, 0.000826162d },
            { 970000.0d, 0.000821332d },
            { 975000.0d, 0.000816437d },
            { 980000.0d, 0.000811476d },
            { 985000.0d, 0.000806452d },
            { 990000.0d, 0.000801364d },
            { 995000.0d, 0.000796213d },
            { 1000000.0d, 0.000791001d },
            { 1005000.0d, 0.000785728d },
            { 1010000.0d, 0.000780394d },
            { 1015000.0d, 0.000775002d },
            { 1020000.0d, 0.000769551d },
            { 1025000.0d, 0.000764042d },
            { 1030000.0d, 0.000758477d },
            { 1035000.0d, 0.000752857d },
            { 1040000.0d, 0.000747181d },
            { 1045000.0d, 0.000741452d },
            { 1050000.0d, 0.00073567d },
            { 1055000.0d, 0.000729836d },
            { 1060000.0d, 0.00072395d },
            { 1065000.0d, 0.000718015d },
            { 1070000.0d, 0.00071203d },
            { 1075000.0d, 0.000705997d },
            { 1080000.0d, 0.000699917d },
            { 1085000.0d, 0.000693791d },
            { 1090000.0d, 0.000687619d },
            { 1095000.0d, 0.000681404d },
            { 1100000.0d, 0.000675145d },
            { 1105000.0d, 0.000668844d },
            { 1110000.0d, 0.000662502d },
            { 1115000.0d, 0.00065612d },
            { 1120000.0d, 0.000649699d },
            { 1125000.0d, 0.00064324d },
            { 1130000.0d, 0.000636745d },
            { 1135000.0d, 0.000630213d },
            { 1140000.0d, 0.000623647d },
            { 1145000.0d, 0.000617048d },
            { 1150000.0d, 0.000610416d },
            { 1155000.0d, 0.000603753d },
            { 1160000.0d, 0.00059706d },
            { 1165000.0d, 0.000590337d },
            { 1170000.0d, 0.000583588d },
            { 1175000.0d, 0.000576811d },
            { 1180000.0d, 0.000570009d },
            { 1185000.0d, 0.000563183d },
            { 1190000.0d, 0.000556334d },
            { 1195000.0d, 0.000549463d },
            { 1200000.0d, 0.000542571d },
            { 1205000.0d, 0.000535661d },
            { 1210000.0d, 0.000528732d },
            { 1215000.0d, 0.000521786d },
            { 1220000.0d, 0.000514825d },
            { 1225000.0d, 0.000507849d },
            { 1230000.0d, 0.00050086d },
            { 1235000.0d, 0.00049386d },
            { 1240000.0d, 0.000486849d },
            { 1245000.0d, 0.000479829d },
            { 1250000.0d, 0.000472802d },
            { 1255000.0d, 0.000465768d },
            { 1260000.0d, 0.000458728d },
            { 1265000.0d, 0.000451685d },
            { 1270000.0d, 0.00044464d },
            { 1275000.0d, 0.000437594d },
            { 1280000.0d, 0.000430548d },
            { 1285000.0d, 0.000423504d },
            { 1290000.0d, 0.000416463d },
            { 1295000.0d, 0.000409426d },
            { 1300000.0d, 0.000402396d },
            { 1305000.0d, 0.000395373d },
            { 1310000.0d, 0.000388359d },
            { 1315000.0d, 0.000381355d },
            { 1320000.0d, 0.000374363d },
            { 1325000.0d, 0.000367384d },
            { 1330000.0d, 0.00036042d },
            { 1335000.0d, 0.000353473d },
            { 1340000.0d, 0.000346543d },
            { 1345000.0d, 0.000339632d },
            { 1350000.0d, 0.000332742d },
            { 1355000.0d, 0.000325875d },
            { 1360000.0d, 0.000319031d },
            { 1365000.0d, 0.000312213d },
            { 1370000.0d, 0.000305422d },
            { 1375000.0d, 0.000298659d },
            { 1380000.0d, 0.000291926d },
            { 1385000.0d, 0.000285225d },
            { 1390000.0d, 0.000278558d },
            { 1395000.0d, 0.000271925d },
            { 1400000.0d, 0.000265329d },
            { 1405000.0d, 0.000258771d },
            { 1410000.0d, 0.000252252d },
            { 1415000.0d, 0.000245776d },
            { 1420000.0d, 0.000239342d },
            { 1425000.0d, 0.000232953d },
            { 1430000.0d, 0.000226611d },
            { 1435000.0d, 0.000220317d },
            { 1440000.0d, 0.000214072d },
            { 1445000.0d, 0.000207879d },
            { 1450000.0d, 0.00020174d },
            { 1455000.0d, 0.000195655d },
            { 1460000.0d, 0.000189627d },
            { 1465000.0d, 0.000183658d },
            { 1470000.0d, 0.000177749d },
            { 1475000.0d, 0.000171901d },
            { 1480000.0d, 0.000166118d },
            { 1485000.0d, 0.0001604d },
            { 1490000.0d, 0.000154749d },
            { 1495000.0d, 0.000149168d },
            { 1500000.0d, 0.000143657d },
            { 1505000.0d, 0.00013822d },
            { 1510000.0d, 0.000132856d },
            { 1515000.0d, 0.00012757d },
            { 1520000.0d, 0.000122361d },
            { 1525000.0d, 0.000117233d },
            { 1530000.0d, 0.000112186d },
            { 1535000.0d, 0.000107224d },
            { 1540000.0d, 0.000102347d },
            { 1545000.0d, 0.0000975581d },
            { 1550000.0d, 0.0000928585d },
            { 1555000.0d, 0.0000882504d },
            { 1560000.0d, 0.0000837357d },
            { 1565000.0d, 0.0000793162d },
            { 1570000.0d, 0.000074994d },
            { 1575000.0d, 0.000070771d },
            { 1580000.0d, 0.0000666491d },
            { 1585000.0d, 0.0000626303d },
            { 1590000.0d, 0.0000587165d },
            { 1595000.0d, 0.0000549098d },
            { 1600000.0d, 0.0000512122d },
            { 1605000.0d, 0.0000476255d },
            { 1610000.0d, 0.000044152d },
            { 1615000.0d, 0.0000407934d },
            { 1620000.0d, 0.0000375519d },
            { 1625000.0d, 0.0000344295d },
            { 1630000.0d, 0.0000314282d },
            { 1635000.0d, 0.0000285501d },
            { 1640000.0d, 0.0000257972d },
            { 1645000.0d, 0.0000231715d },
            { 1650000.0d, 0.0000206752d },
            { 1655000.0d, 0.0000183103d },
            { 1660000.0d, 0.0000160788d },
            { 1665000.0d, 0.0000139828d },
            { 1670000.0d, 0.0000120245d },
            { 1675000.0d, 0.0000102058d },
            { 1680000.0d, 0.00000852895d },
            { 1685000.0d, 0.00000699594d },
            { 1690000.0d, 0.00000560888d },
            { 1695000.0d, 0.00000436984d },
            { 1700000.0d, 0.00000328092d },
            { 1705000.0d, 0.00000234416d },
            { 1710000.0d, 0.00000156161d },
            { 1715000.0d, 0.000000935305d },
            { 1720000.0d, 0.000000467204d },
            { 1725000.0d, 0.000000159196d },
            { 1730000.0d, 0.0000000129579d },
            { 1732000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    