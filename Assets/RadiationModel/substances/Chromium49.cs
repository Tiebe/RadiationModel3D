using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium49";
        public override double halfLife { get; } = 2538.0d;
        public override double atomicWeight { get; } = 48.95133d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium49()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.163856d, new GammaParticle(62289.0, 0.0199)), new(0.532d, new GammaParticle(90639.0, 0.01368)), new(3.1388e-09d, new GammaParticle(133800.0, 0.00927)), new(0.30324d, new GammaParticle(152928.0, 0.00811)), new(2.66e-06d, new GammaParticle(595300.0, 0.00208)), new(2.66e-06d, new GammaParticle(657500.0, 0.00189)), new(1.064e-05d, new GammaParticle(1021300.0, 0.00121)), new(1.2768e-06d, new GammaParticle(1027800.0, 0.00121)), new(2.6599999999999997e-07d, new GammaParticle(1064630.0, 0.00116)), new(7.98e-07d, new GammaParticle(1155330.0, 0.00107)), new(0.00045220000000000004d, new GammaParticle(1361610.0, 0.00091)), new(0.00010108d, new GammaParticle(1423300.0, 0.00087)), new(7.979999999999999e-05d, new GammaParticle(1508300.0, 0.00082)), new(0.00026068d, new GammaParticle(1514100.0, 0.00082)), new(0.00019684d, new GammaParticle(1570600.0, 0.00079)), new(3.99e-06d, new GammaParticle(2091100.0, 0.00059)), new(9.2036e-06d, new GammaParticle(2143700.0, 0.00058)), new(1.6492000000000002e-06d, new GammaParticle(2155700.0, 0.00058)), new(3.192e-07d, new GammaParticle(2181600.0, 0.00057)), new(1.9152e-06d, new GammaParticle(2218600.0, 0.00056)), new(2.2343999999999997e-06d, new GammaParticle(2236200.0, 0.00055)), new(1.0108e-06d, new GammaParticle(2310600.0, 0.00054)), new(1.855623448d, new GammaParticle(511000.0, 0.00243)), new(0.0006900000000000001d, new GammaParticle(536.0, 2.31314)), new(0.00847d, new GammaParticle(4945.0, 0.25073)), new(0.0167d, new GammaParticle(4952.0, 0.25037)), new(0.00335d, new GammaParticle(5444.0, 0.22774)), new(0.00335d, new GammaParticle(5444.0, 0.22774)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 300.0d, 0.0000000164537d },
            { 600.0d, 0.000000324196d },
            { 900.0d, 0.00000115257d },
            { 1200.0d, 0.00000242514d },
            { 1700.0d, 0.00000553321d },
            { 2200.0d, 0.0000098752d },
            { 2700.0d, 0.0000154511d },
            { 3200.0d, 0.000022261d },
            { 3700.0d, 0.0000303047d },
            { 4200.0d, 0.0000395824d },
            { 4700.0d, 0.0000500939d },
            { 5200.0d, 0.0000618394d },
            { 5700.0d, 0.0000748187d },
            { 6200.0d, 0.0000890319d },
            { 6700.0d, 0.000104479d },
            { 7200.0d, 0.00012116d },
            { 7700.0d, 0.000139074d },
            { 8200.0d, 0.000157974d },
            { 8700.0d, 0.000177631d },
            { 9200.0d, 0.000198374d },
            { 9700.0d, 0.000220203d },
            { 10000.0d, 0.000233821d },
            { 11000.0d, 0.000279803d },
            { 12000.0d, 0.000329384d },
            { 13000.0d, 0.000380742d },
            { 14000.0d, 0.00043497d },
            { 15000.0d, 0.000492068d },
            { 16000.0d, 0.000550094d },
            { 17000.0d, 0.000609083d },
            { 18000.0d, 0.00066979d },
            { 19000.0d, 0.000732216d },
            { 20000.0d, 0.000796361d },
            { 21000.0d, 0.000860262d },
            { 22000.0d, 0.000925174d },
            { 23000.0d, 0.000991097d },
            { 24000.0d, 0.00105803d },
            { 25000.0d, 0.00112545d },
            { 26000.0d, 0.001193d },
            { 27000.0d, 0.00126113d },
            { 28000.0d, 0.00132984d },
            { 29000.0d, 0.00139878d },
            { 30000.0d, 0.00146817d },
            { 31000.0d, 0.0015376d },
            { 32000.0d, 0.00160734d },
            { 33000.0d, 0.00167716d },
            { 34000.0d, 0.0017472d },
            { 35000.0d, 0.00181746d },
            { 36000.0d, 0.00188769d },
            { 37000.0d, 0.00195791d },
            { 38000.0d, 0.0020282d },
            { 39000.0d, 0.00209857d },
            { 40000.0d, 0.00216902d },
            { 41000.0d, 0.00223928d },
            { 42000.0d, 0.00230953d },
            { 43000.0d, 0.00237976d },
            { 44000.0d, 0.00244998d },
            { 45000.0d, 0.00252011d },
            { 46000.0d, 0.0025901d },
            { 47000.0d, 0.00266001d },
            { 48000.0d, 0.00272985d },
            { 49000.0d, 0.00279956d },
            { 50000.0d, 0.00286917d },
            { 51000.0d, 0.00293862d },
            { 52000.0d, 0.00300796d },
            { 53000.0d, 0.00307715d },
            { 54000.0d, 0.00314621d },
            { 55000.0d, 0.00321514d },
            { 56000.0d, 0.00328391d },
            { 57000.0d, 0.0033525d },
            { 58000.0d, 0.00342095d },
            { 59000.0d, 0.00348925d },
            { 60000.0d, 0.00355739d },
            { 61000.0d, 0.00362534d },
            { 62000.0d, 0.00369313d },
            { 63000.0d, 0.00376075d },
            { 64000.0d, 0.0038282d },
            { 65000.0d, 0.00389548d },
            { 66000.0d, 0.00396258d },
            { 67000.0d, 0.0040295d },
            { 68000.0d, 0.00409625d },
            { 69000.0d, 0.00416281d },
            { 70000.0d, 0.0042292d },
            { 71000.0d, 0.00429541d },
            { 72000.0d, 0.00436143d },
            { 73000.0d, 0.00442728d },
            { 74000.0d, 0.00449294d },
            { 75000.0d, 0.00455843d },
            { 76000.0d, 0.00462373d },
            { 77000.0d, 0.00468885d },
            { 78000.0d, 0.00475379d },
            { 79000.0d, 0.00481855d },
            { 80000.0d, 0.00488312d },
            { 81000.0d, 0.00494751d },
            { 82000.0d, 0.00501172d },
            { 83000.0d, 0.00507575d },
            { 84000.0d, 0.0051396d },
            { 85000.0d, 0.00520327d },
            { 86000.0d, 0.00526676d },
            { 87000.0d, 0.00533007d },
            { 88000.0d, 0.00539319d },
            { 89000.0d, 0.00545614d },
            { 90000.0d, 0.00551891d },
            { 91000.0d, 0.0055815d },
            { 92000.0d, 0.00564391d },
            { 93000.0d, 0.00570614d },
            { 94000.0d, 0.0057682d },
            { 95000.0d, 0.00583008d },
            { 96000.0d, 0.00589179d },
            { 97000.0d, 0.00595332d },
            { 98000.0d, 0.00601467d },
            { 99000.0d, 0.00607585d },
            { 100000.0d, 0.00613686d },
            { 105000.0d, 0.0064393d },
            { 110000.0d, 0.0067375d },
            { 115000.0d, 0.00703153d },
            { 120000.0d, 0.00732145d },
            { 125000.0d, 0.00760734d },
            { 130000.0d, 0.00788928d },
            { 135000.0d, 0.00816731d },
            { 140000.0d, 0.00844154d },
            { 145000.0d, 0.00871199d },
            { 150000.0d, 0.00897873d },
            { 155000.0d, 0.00924182d },
            { 160000.0d, 0.00950129d },
            { 165000.0d, 0.00975721d },
            { 170000.0d, 0.0100096d },
            { 175000.0d, 0.0102585d },
            { 180000.0d, 0.010504d },
            { 185000.0d, 0.0107461d },
            { 190000.0d, 0.0109848d },
            { 195000.0d, 0.0112202d },
            { 200000.0d, 0.0114522d },
            { 205000.0d, 0.011681d },
            { 210000.0d, 0.0119065d },
            { 215000.0d, 0.0121287d },
            { 220000.0d, 0.0123477d },
            { 225000.0d, 0.0125635d },
            { 230000.0d, 0.0127762d },
            { 235000.0d, 0.0129856d },
            { 240000.0d, 0.0131919d },
            { 245000.0d, 0.013395d },
            { 250000.0d, 0.013595d },
            { 255000.0d, 0.0137919d },
            { 260000.0d, 0.0139857d },
            { 265000.0d, 0.0141763d },
            { 270000.0d, 0.0143639d },
            { 275000.0d, 0.0145483d },
            { 280000.0d, 0.0147297d },
            { 285000.0d, 0.014908d },
            { 290000.0d, 0.0150833d },
            { 295000.0d, 0.0152555d },
            { 300000.0d, 0.0154246d },
            { 305000.0d, 0.0155906d },
            { 310000.0d, 0.0157537d },
            { 315000.0d, 0.0159136d },
            { 320000.0d, 0.0160706d },
            { 325000.0d, 0.0162245d },
            { 330000.0d, 0.0163753d },
            { 335000.0d, 0.0165232d },
            { 340000.0d, 0.0166679d },
            { 345000.0d, 0.0168097d },
            { 350000.0d, 0.0169485d },
            { 355000.0d, 0.0170842d },
            { 360000.0d, 0.0172169d },
            { 365000.0d, 0.0173466d },
            { 370000.0d, 0.0174733d },
            { 375000.0d, 0.017597d },
            { 380000.0d, 0.0177176d },
            { 385000.0d, 0.0178353d },
            { 390000.0d, 0.0179499d },
            { 395000.0d, 0.0180616d },
            { 400000.0d, 0.0181702d },
            { 405000.0d, 0.0182759d },
            { 410000.0d, 0.0183785d },
            { 415000.0d, 0.0184782d },
            { 420000.0d, 0.0185749d },
            { 425000.0d, 0.0186686d },
            { 430000.0d, 0.0187593d },
            { 435000.0d, 0.018847d },
            { 440000.0d, 0.0189318d },
            { 445000.0d, 0.0190136d },
            { 450000.0d, 0.0190924d },
            { 455000.0d, 0.0191683d },
            { 460000.0d, 0.0192412d },
            { 465000.0d, 0.0193112d },
            { 470000.0d, 0.0193781d },
            { 475000.0d, 0.0194422d },
            { 480000.0d, 0.0195034d },
            { 485000.0d, 0.0195615d },
            { 490000.0d, 0.0196168d },
            { 495000.0d, 0.0196691d },
            { 500000.0d, 0.0197185d },
            { 505000.0d, 0.019765d },
            { 510000.0d, 0.0198086d },
            { 515000.0d, 0.0198493d },
            { 520000.0d, 0.0198871d },
            { 525000.0d, 0.019922d },
            { 530000.0d, 0.0199541d },
            { 535000.0d, 0.0199833d },
            { 540000.0d, 0.0200096d },
            { 545000.0d, 0.020033d },
            { 550000.0d, 0.0200537d },
            { 555000.0d, 0.0200714d },
            { 560000.0d, 0.0200864d },
            { 565000.0d, 0.0200985d },
            { 570000.0d, 0.0201078d },
            { 575000.0d, 0.0201144d },
            { 580000.0d, 0.0201182d },
            { 585000.0d, 0.0201191d },
            { 590000.0d, 0.0201174d },
            { 595000.0d, 0.0201128d },
            { 600000.0d, 0.0201055d },
            { 605000.0d, 0.0200955d },
            { 610000.0d, 0.0200828d },
            { 615000.0d, 0.0200673d },
            { 620000.0d, 0.0200492d },
            { 625000.0d, 0.0200283d },
            { 630000.0d, 0.0200049d },
            { 635000.0d, 0.0199788d },
            { 640000.0d, 0.01995d },
            { 645000.0d, 0.0199185d },
            { 650000.0d, 0.0198846d },
            { 655000.0d, 0.0198479d },
            { 660000.0d, 0.0198087d },
            { 665000.0d, 0.019767d },
            { 670000.0d, 0.0197226d },
            { 675000.0d, 0.0196758d },
            { 680000.0d, 0.0196264d },
            { 685000.0d, 0.0195745d },
            { 690000.0d, 0.0195202d },
            { 695000.0d, 0.0194634d },
            { 700000.0d, 0.0194041d },
            { 705000.0d, 0.0193424d },
            { 710000.0d, 0.0192783d },
            { 715000.0d, 0.0192118d },
            { 720000.0d, 0.0191429d },
            { 725000.0d, 0.0190716d },
            { 730000.0d, 0.018998d },
            { 735000.0d, 0.0189222d },
            { 740000.0d, 0.018844d },
            { 745000.0d, 0.0187635d },
            { 750000.0d, 0.0186808d },
            { 755000.0d, 0.0185958d },
            { 760000.0d, 0.0185087d },
            { 765000.0d, 0.0184193d },
            { 770000.0d, 0.0183278d },
            { 775000.0d, 0.0182341d },
            { 780000.0d, 0.0181383d },
            { 785000.0d, 0.0180405d },
            { 790000.0d, 0.0179405d },
            { 795000.0d, 0.0178385d },
            { 800000.0d, 0.0177345d },
            { 805000.0d, 0.0176285d },
            { 810000.0d, 0.0175204d },
            { 815000.0d, 0.0174105d },
            { 820000.0d, 0.0172986d },
            { 825000.0d, 0.0171848d },
            { 830000.0d, 0.0170692d },
            { 835000.0d, 0.0169517d },
            { 840000.0d, 0.0168324d },
            { 845000.0d, 0.0167113d },
            { 850000.0d, 0.0165884d },
            { 855000.0d, 0.0164638d },
            { 860000.0d, 0.0163375d },
            { 865000.0d, 0.0162095d },
            { 870000.0d, 0.0160798d },
            { 875000.0d, 0.0159486d },
            { 880000.0d, 0.0158157d },
            { 885000.0d, 0.0156813d },
            { 890000.0d, 0.0155454d },
            { 895000.0d, 0.015408d },
            { 900000.0d, 0.015269d },
            { 905000.0d, 0.0151287d },
            { 910000.0d, 0.014987d },
            { 915000.0d, 0.0148439d },
            { 920000.0d, 0.0146994d },
            { 925000.0d, 0.0145536d },
            { 930000.0d, 0.0144066d },
            { 935000.0d, 0.0142583d },
            { 940000.0d, 0.0141089d },
            { 945000.0d, 0.0139582d },
            { 950000.0d, 0.0138064d },
            { 955000.0d, 0.0136535d },
            { 960000.0d, 0.0134996d },
            { 965000.0d, 0.0133446d },
            { 970000.0d, 0.0131886d },
            { 975000.0d, 0.0130317d },
            { 980000.0d, 0.0128738d },
            { 985000.0d, 0.0127151d },
            { 990000.0d, 0.0125555d },
            { 995000.0d, 0.0123951d },
            { 1000000.0d, 0.0122339d },
            { 1005000.0d, 0.012072d },
            { 1010000.0d, 0.0119094d },
            { 1015000.0d, 0.0117461d },
            { 1020000.0d, 0.0115823d },
            { 1025000.0d, 0.0114178d },
            { 1030000.0d, 0.0112528d },
            { 1035000.0d, 0.0110873d },
            { 1040000.0d, 0.0109213d },
            { 1045000.0d, 0.010755d },
            { 1050000.0d, 0.0105882d },
            { 1055000.0d, 0.0104212d },
            { 1060000.0d, 0.0102538d },
            { 1065000.0d, 0.0100862d },
            { 1070000.0d, 0.0099184d },
            { 1075000.0d, 0.00975043d },
            { 1080000.0d, 0.00958234d },
            { 1085000.0d, 0.00941417d },
            { 1090000.0d, 0.00924597d },
            { 1095000.0d, 0.00907779d },
            { 1100000.0d, 0.00890966d },
            { 1105000.0d, 0.00874163d },
            { 1110000.0d, 0.00857378d },
            { 1115000.0d, 0.00840609d },
            { 1120000.0d, 0.00823865d },
            { 1125000.0d, 0.0080715d },
            { 1130000.0d, 0.00790469d },
            { 1135000.0d, 0.00773825d },
            { 1140000.0d, 0.00757225d },
            { 1145000.0d, 0.00740672d },
            { 1150000.0d, 0.00724172d },
            { 1155000.0d, 0.00707728d },
            { 1160000.0d, 0.00691349d },
            { 1165000.0d, 0.00675034d },
            { 1170000.0d, 0.00658794d },
            { 1175000.0d, 0.00642628d },
            { 1180000.0d, 0.00626547d },
            { 1185000.0d, 0.00610551d },
            { 1190000.0d, 0.00594648d },
            { 1195000.0d, 0.00578842d },
            { 1200000.0d, 0.00563139d },
            { 1205000.0d, 0.00547543d },
            { 1210000.0d, 0.0053206d },
            { 1215000.0d, 0.00516695d },
            { 1220000.0d, 0.00501454d },
            { 1225000.0d, 0.0048634d },
            { 1230000.0d, 0.00471362d },
            { 1235000.0d, 0.00456523d },
            { 1240000.0d, 0.00441829d },
            { 1245000.0d, 0.00427284d },
            { 1250000.0d, 0.00412897d },
            { 1255000.0d, 0.00398669d },
            { 1260000.0d, 0.00384609d },
            { 1265000.0d, 0.00370721d },
            { 1270000.0d, 0.00357011d },
            { 1275000.0d, 0.00343485d },
            { 1280000.0d, 0.00330147d },
            { 1285000.0d, 0.00317004d },
            { 1290000.0d, 0.00304063d },
            { 1295000.0d, 0.00291328d },
            { 1300000.0d, 0.00278805d },
            { 1305000.0d, 0.002665d },
            { 1310000.0d, 0.0025442d },
            { 1315000.0d, 0.00242569d },
            { 1320000.0d, 0.00230953d },
            { 1325000.0d, 0.0021958d },
            { 1330000.0d, 0.00208454d },
            { 1335000.0d, 0.00197582d },
            { 1340000.0d, 0.0018697d },
            { 1345000.0d, 0.00176623d },
            { 1350000.0d, 0.00166549d },
            { 1355000.0d, 0.00156752d },
            { 1360000.0d, 0.00147239d },
            { 1365000.0d, 0.00138017d },
            { 1370000.0d, 0.00129092d },
            { 1375000.0d, 0.00120469d },
            { 1380000.0d, 0.00112155d },
            { 1385000.0d, 0.00104157d },
            { 1390000.0d, 0.000964804d },
            { 1395000.0d, 0.000891318d },
            { 1400000.0d, 0.000821175d },
            { 1405000.0d, 0.00075444d },
            { 1410000.0d, 0.000691175d },
            { 1415000.0d, 0.000631447d },
            { 1420000.0d, 0.000575316d },
            { 1425000.0d, 0.000522849d },
            { 1430000.0d, 0.00047411d },
            { 1435000.0d, 0.000429163d },
            { 1440000.0d, 0.000388069d },
            { 1445000.0d, 0.000350893d },
            { 1450000.0d, 0.000317693d },
            { 1455000.0d, 0.000287956d },
            { 1460000.0d, 0.000259986d },
            { 1465000.0d, 0.000233688d },
            { 1470000.0d, 0.000209089d },
            { 1475000.0d, 0.000186221d },
            { 1480000.0d, 0.000165112d },
            { 1485000.0d, 0.00014579d },
            { 1490000.0d, 0.000128285d },
            { 1495000.0d, 0.000112627d },
            { 1500000.0d, 0.0000988418d },
            { 1505000.0d, 0.0000869595d },
            { 1510000.0d, 0.0000770064d },
            { 1515000.0d, 0.0000689655d },
            { 1520000.0d, 0.0000617683d },
            { 1525000.0d, 0.0000549336d },
            { 1530000.0d, 0.0000484677d },
            { 1535000.0d, 0.0000423768d },
            { 1540000.0d, 0.0000366672d },
            { 1545000.0d, 0.0000313452d },
            { 1550000.0d, 0.0000264171d },
            { 1555000.0d, 0.0000218892d },
            { 1560000.0d, 0.000017768d },
            { 1565000.0d, 0.0000140596d },
            { 1570000.0d, 0.0000107704d },
            { 1575000.0d, 0.00000790665d },
            { 1580000.0d, 0.00000547469d },
            { 1585000.0d, 0.00000348069d },
            { 1590000.0d, 0.00000193076d },
            { 1595000.0d, 0.000000830839d },
            { 1600000.0d, 0.000000186538d },
            { 1604500.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    