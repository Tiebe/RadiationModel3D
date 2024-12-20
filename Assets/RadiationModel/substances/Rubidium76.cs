using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium76 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium76";
        public override double halfLife { get; } = 36.5d;
        public override double atomicWeight { get; } = 75.93507d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine76()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00337d, new GammaParticle(324300.0, 0.00382)), new(0.057800000000000004d, new GammaParticle(345900.0, 0.00358)), new(0.076d, new GammaParticle(355600.0, 0.00349)), new(0.0022d, new GammaParticle(376400.0, 0.00329)), new(0.0023699999999999997d, new GammaParticle(378500.0, 0.00328)), new(0.0013d, new GammaParticle(403900.0, 0.00307)), new(0.00096d, new GammaParticle(417100.0, 0.00297)), new(0.43799999999999994d, new GammaParticle(424000.0, 0.00292)), new(0.0023d, new GammaParticle(431700.0, 0.00287)), new(0.0006d, new GammaParticle(432000.0, 0.00287)), new(0.0011799999999999998d, new GammaParticle(443300.0, 0.0028)), new(0.0254d, new GammaParticle(453500.0, 0.00273)), new(0.0022d, new GammaParticle(466000.0, 0.00266)), new(0.0011d, new GammaParticle(466900.0, 0.00266)), new(0.0079d, new GammaParticle(479500.0, 0.00259)), new(0.00092d, new GammaParticle(493400.0, 0.00251)), new(0.0031d, new GammaParticle(493800.0, 0.00251)), new(0.0034999999999999996d, new GammaParticle(506000.0, 0.00245)), new(0.0022d, new GammaParticle(511600.0, 0.00242)), new(0.00105d, new GammaParticle(540000.0, 0.0023)), new(0.0175d, new GammaParticle(610600.0, 0.00203)), new(0.0022d, new GammaParticle(652600.0, 0.0019)), new(0.0017100000000000001d, new GammaParticle(686500.0, 0.00181)), new(0.00092d, new GammaParticle(698400.0, 0.00178)), new(0.013600000000000001d, new GammaParticle(766700.0, 0.00162)), new(0.0434d, new GammaParticle(797600.0, 0.00155)), new(0.013999999999999999d, new GammaParticle(822200.0, 0.00151)), new(0.0105d, new GammaParticle(882400.0, 0.00141)), new(0.0451d, new GammaParticle(883600.0, 0.0014)), new(0.036000000000000004d, new GammaParticle(917400.0, 0.00135)), new(0.0053d, new GammaParticle(918500.0, 0.00135)), new(0.0039000000000000003d, new GammaParticle(920200.0, 0.00135)), new(0.021d, new GammaParticle(973000.0, 0.00127)), new(0.0105d, new GammaParticle(1005500.0, 0.00123)), new(0.00092d, new GammaParticle(1009000.0, 0.00123)), new(0.0022d, new GammaParticle(1035500.0, 0.0012)), new(0.026699999999999998d, new GammaParticle(1174000.0, 0.00106)), new(0.0333d, new GammaParticle(1221600.0, 0.00101)), new(0.0039000000000000003d, new GammaParticle(1222600.0, 0.00101)), new(0.0092d, new GammaParticle(1263200.0, 0.00098)), new(0.0016200000000000001d, new GammaParticle(1270100.0, 0.00098)), new(0.00197d, new GammaParticle(1291300.0, 0.00096)), new(0.0127d, new GammaParticle(1309300.0, 0.00095)), new(0.006999999999999999d, new GammaParticle(1321600.0, 0.00094)), new(0.0034999999999999996d, new GammaParticle(1334400.0, 0.00093)), new(0.0088d, new GammaParticle(1349300.0, 0.00092)), new(0.00394d, new GammaParticle(1359400.0, 0.00091)), new(0.0017000000000000001d, new GammaParticle(1463000.0, 0.00085)), new(0.0014000000000000002d, new GammaParticle(1498400.0, 0.00083)), new(0.00153d, new GammaParticle(1542600.0, 0.0008)), new(0.0018d, new GammaParticle(1546100.0, 0.0008)), new(0.0074d, new GammaParticle(1553200.0, 0.0008)), new(0.00368d, new GammaParticle(1567800.0, 0.00079)), new(0.00131d, new GammaParticle(1665600.0, 0.00074)), new(0.0034999999999999996d, new GammaParticle(1667600.0, 0.00074)), new(0.056100000000000004d, new GammaParticle(1680300.0, 0.00074)), new(0.013999999999999999d, new GammaParticle(1687100.0, 0.00073)), new(0.0118d, new GammaParticle(1718600.0, 0.00072)), new(0.00469d, new GammaParticle(1768400.0, 0.0007)), new(0.055999999999999994d, new GammaParticle(1803200.0, 0.00069)), new(0.015300000000000001d, new GammaParticle(1833600.0, 0.00068)), new(0.0028499999999999997d, new GammaParticle(1908500.0, 0.00065)), new(0.0035499999999999998d, new GammaParticle(2046500.0, 0.00061)), new(0.00438d, new GammaParticle(2054300.0, 0.0006)), new(0.0127d, new GammaParticle(2104300.0, 0.00059)), new(0.00136d, new GammaParticle(2140500.0, 0.00058)), new(0.0044d, new GammaParticle(2147200.0, 0.00058)), new(0.0066d, new GammaParticle(2185000.0, 0.00057)), new(0.00526d, new GammaParticle(2276600.0, 0.00054)), new(0.0008799999999999999d, new GammaParticle(2333200.0, 0.00053)), new(0.019299999999999998d, new GammaParticle(2350900.0, 0.00053)), new(0.021d, new GammaParticle(2392800.0, 0.00052)), new(0.0049499999999999995d, new GammaParticle(2546000.0, 0.00049)), new(0.455d, new GammaParticle(2571100.0, 0.00048)), new(0.03d, new GammaParticle(2600200.0, 0.00048)), new(0.00263d, new GammaParticle(2805500.0, 0.00044)), new(0.006d, new GammaParticle(2816600.0, 0.00044)), new(0.0092d, new GammaParticle(2817300.0, 0.00044)), new(0.00302d, new GammaParticle(2997500.0, 0.00041)), new(0.040999999999999995d, new GammaParticle(3178300.0, 0.00039)), new(0.0074d, new GammaParticle(3214200.0, 0.00039)), new(0.0053d, new GammaParticle(3216300.0, 0.00039)), new(0.0053d, new GammaParticle(3242300.0, 0.00038)), new(0.002d, new GammaParticle(3257400.0, 0.00038)), new(0.0013d, new GammaParticle(3327600.0, 0.00037)), new(0.0043d, new GammaParticle(3553600.0, 0.00035)), new(0.0048d, new GammaParticle(3562700.0, 0.00035)), new(0.0074d, new GammaParticle(3602200.0, 0.00034)), new(0.0149d, new GammaParticle(3602800.0, 0.00034)), new(0.0033d, new GammaParticle(3636100.0, 0.00034)), new(0.0096d, new GammaParticle(3673600.0, 0.00034)), new(0.0039000000000000003d, new GammaParticle(3978200.0, 0.00031)), new(0.0038d, new GammaParticle(4026800.0, 0.00031)), new(0.0044d, new GammaParticle(4098800.0, 0.0003)), new(2.012930539013813d, new GammaParticle(511000.0, 0.00243)), new(0.00106d, new GammaParticle(1648.0, 0.75233)), new(0.0074199999999999995d, new GammaParticle(12596.0, 0.09843)), new(0.0143d, new GammaParticle(12649.0, 0.09802)), new(0.0034300000000000003d, new GammaParticle(14169.0, 0.0875)), new(0.00377d, new GammaParticle(14209.0, 0.08726)), new(0.00034500000000000004d, new GammaParticle(14313.0, 0.08662)) } },
            { 3.8e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium72()), new(1.0d, new AlphaParticle(5986102.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.00000000000543269d },
            { 200.0d, 0.0000000000117581d },
            { 300.0d, 0.0000000000189761d },
            { 400.0d, 0.0000000000278288d },
            { 500.0d, 0.0000000000380452d },
            { 600.0d, 0.0000000000507332d },
            { 700.0d, 0.0000000000657951d },
            { 800.0d, 0.0000000000827446d },
            { 900.0d, 0.000000000101582d },
            { 1000.0d, 0.000000000122307d },
            { 1500.0d, 0.000000000305587d },
            { 2000.0d, 0.000000000708308d },
            { 2500.0d, 0.0000000016504d },
            { 3000.0d, 0.00000000416941d },
            { 3500.0d, 0.0000000106977d },
            { 4000.0d, 0.0000000240879d },
            { 4500.0d, 0.0000000423687d },
            { 5000.0d, 0.000000064043d },
            { 5500.0d, 0.0000000891107d },
            { 6000.0d, 0.000000117572d },
            { 6500.0d, 0.000000149426d },
            { 7000.0d, 0.000000184674d },
            { 7500.0d, 0.000000223315d },
            { 8000.0d, 0.00000026535d },
            { 8500.0d, 0.000000310981d },
            { 9000.0d, 0.000000360051d },
            { 9500.0d, 0.000000412558d },
            { 10000.0d, 0.000000468505d },
            { 11000.0d, 0.000000591243d },
            { 12000.0d, 0.000000727912d },
            { 13000.0d, 0.000000879615d },
            { 14000.0d, 0.00000104556d },
            { 15000.0d, 0.00000122593d },
            { 16000.0d, 0.00000142032d },
            { 17000.0d, 0.00000162854d },
            { 18000.0d, 0.00000185083d },
            { 19000.0d, 0.00000208512d },
            { 20000.0d, 0.00000233291d },
            { 21000.0d, 0.00000259228d },
            { 22000.0d, 0.00000286322d },
            { 23000.0d, 0.00000314537d },
            { 24000.0d, 0.00000343996d },
            { 25000.0d, 0.0000037433d },
            { 26000.0d, 0.0000040577d },
            { 27000.0d, 0.00000438198d },
            { 28000.0d, 0.00000471652d },
            { 29000.0d, 0.00000505856d },
            { 30000.0d, 0.00000541088d },
            { 31000.0d, 0.00000576643d },
            { 32000.0d, 0.00000613093d },
            { 33000.0d, 0.00000650038d },
            { 34000.0d, 0.00000687641d },
            { 35000.0d, 0.00000725881d },
            { 36000.0d, 0.00000764774d },
            { 37000.0d, 0.00000804039d },
            { 38000.0d, 0.00000843979d },
            { 39000.0d, 0.00000884543d },
            { 40000.0d, 0.00000925647d },
            { 41000.0d, 0.0000096716d },
            { 42000.0d, 0.0000100927d },
            { 43000.0d, 0.0000105164d },
            { 44000.0d, 0.0000109455d },
            { 45000.0d, 0.0000113786d },
            { 46000.0d, 0.000011814d },
            { 47000.0d, 0.000012254d },
            { 48000.0d, 0.0000126988d },
            { 49000.0d, 0.0000131446d },
            { 50000.0d, 0.0000135939d },
            { 51000.0d, 0.0000140462d },
            { 52000.0d, 0.0000145012d },
            { 53000.0d, 0.000014959d },
            { 54000.0d, 0.0000154203d },
            { 55000.0d, 0.0000158837d },
            { 56000.0d, 0.0000163496d },
            { 57000.0d, 0.000016817d },
            { 58000.0d, 0.0000172869d },
            { 59000.0d, 0.0000177596d },
            { 60000.0d, 0.000018235d },
            { 61000.0d, 0.0000187106d },
            { 62000.0d, 0.0000191885d },
            { 63000.0d, 0.0000196687d },
            { 64000.0d, 0.0000201506d },
            { 65000.0d, 0.0000206335d },
            { 66000.0d, 0.0000211179d },
            { 67000.0d, 0.0000216036d },
            { 68000.0d, 0.000022091d },
            { 69000.0d, 0.0000225797d },
            { 70000.0d, 0.0000230702d },
            { 71000.0d, 0.0000235613d },
            { 72000.0d, 0.000024054d },
            { 73000.0d, 0.0000245472d },
            { 74000.0d, 0.0000250418d },
            { 75000.0d, 0.0000255377d },
            { 76000.0d, 0.0000260343d },
            { 77000.0d, 0.000026532d },
            { 78000.0d, 0.0000270305d },
            { 79000.0d, 0.0000275297d },
            { 80000.0d, 0.00002803d },
            { 81000.0d, 0.0000285305d },
            { 82000.0d, 0.0000290318d },
            { 83000.0d, 0.000029534d },
            { 84000.0d, 0.0000300372d },
            { 85000.0d, 0.0000305405d },
            { 86000.0d, 0.0000310444d },
            { 87000.0d, 0.0000315491d },
            { 88000.0d, 0.0000320544d },
            { 89000.0d, 0.0000325603d },
            { 90000.0d, 0.0000330668d },
            { 91000.0d, 0.0000335733d },
            { 92000.0d, 0.00003408d },
            { 93000.0d, 0.0000345873d },
            { 94000.0d, 0.0000350951d },
            { 95000.0d, 0.0000356033d },
            { 96000.0d, 0.000036112d },
            { 97000.0d, 0.0000366207d },
            { 98000.0d, 0.0000371298d },
            { 99000.0d, 0.0000376391d },
            { 100000.0d, 0.0000381486d },
            { 110000.0d, 0.0000432544d },
            { 120000.0d, 0.0000483692d },
            { 130000.0d, 0.0000534813d },
            { 140000.0d, 0.0000585835d },
            { 150000.0d, 0.0000636705d },
            { 160000.0d, 0.0000687383d },
            { 170000.0d, 0.0000737824d },
            { 180000.0d, 0.0000788012d },
            { 190000.0d, 0.0000837942d },
            { 200000.0d, 0.0000887583d },
            { 210000.0d, 0.0000936925d },
            { 220000.0d, 0.0000985976d },
            { 230000.0d, 0.000103471d },
            { 240000.0d, 0.000108311d },
            { 250000.0d, 0.000113121d },
            { 260000.0d, 0.000117895d },
            { 270000.0d, 0.000122638d },
            { 280000.0d, 0.000127346d },
            { 290000.0d, 0.000132019d },
            { 300000.0d, 0.000136658d },
            { 310000.0d, 0.00014126d },
            { 320000.0d, 0.000145828d },
            { 330000.0d, 0.000150359d },
            { 340000.0d, 0.000154854d },
            { 350000.0d, 0.00015931d },
            { 360000.0d, 0.00016373d },
            { 370000.0d, 0.000168113d },
            { 380000.0d, 0.000172457d },
            { 390000.0d, 0.000176761d },
            { 400000.0d, 0.000181026d },
            { 410000.0d, 0.000185252d },
            { 420000.0d, 0.000189436d },
            { 430000.0d, 0.000193581d },
            { 440000.0d, 0.000197687d },
            { 450000.0d, 0.00020175d },
            { 460000.0d, 0.00020577d },
            { 470000.0d, 0.00020975d },
            { 480000.0d, 0.000213686d },
            { 490000.0d, 0.000217581d },
            { 500000.0d, 0.000221431d },
            { 510000.0d, 0.000225239d },
            { 520000.0d, 0.000229001d },
            { 530000.0d, 0.000232719d },
            { 540000.0d, 0.000236394d },
            { 550000.0d, 0.000240023d },
            { 560000.0d, 0.000243606d },
            { 570000.0d, 0.000247143d },
            { 580000.0d, 0.000250635d },
            { 590000.0d, 0.00025408d },
            { 600000.0d, 0.000257479d },
            { 610000.0d, 0.000260832d },
            { 620000.0d, 0.000264137d },
            { 630000.0d, 0.000267394d },
            { 640000.0d, 0.000270603d },
            { 650000.0d, 0.000273765d },
            { 660000.0d, 0.00027688d },
            { 670000.0d, 0.000279945d },
            { 680000.0d, 0.000282961d },
            { 690000.0d, 0.00028593d },
            { 700000.0d, 0.000288849d },
            { 710000.0d, 0.00029172d },
            { 720000.0d, 0.000294542d },
            { 730000.0d, 0.000297314d },
            { 740000.0d, 0.000300036d },
            { 750000.0d, 0.000302709d },
            { 760000.0d, 0.000305333d },
            { 770000.0d, 0.000307907d },
            { 780000.0d, 0.000310431d },
            { 790000.0d, 0.000312906d },
            { 800000.0d, 0.000315331d },
            { 810000.0d, 0.000317706d },
            { 820000.0d, 0.000320031d },
            { 830000.0d, 0.000322308d },
            { 840000.0d, 0.000324534d },
            { 850000.0d, 0.000326709d },
            { 860000.0d, 0.000328835d },
            { 870000.0d, 0.000330912d },
            { 880000.0d, 0.000332939d },
            { 890000.0d, 0.000334917d },
            { 900000.0d, 0.000336845d },
            { 910000.0d, 0.000338725d },
            { 920000.0d, 0.000340555d },
            { 930000.0d, 0.000342336d },
            { 940000.0d, 0.000344068d },
            { 950000.0d, 0.000345751d },
            { 960000.0d, 0.000347387d },
            { 970000.0d, 0.000348974d },
            { 980000.0d, 0.000350513d },
            { 990000.0d, 0.000352005d },
            { 1000000.0d, 0.000353449d },
            { 1022000.0d, 0.000356462d },
            { 1044000.0d, 0.000359249d },
            { 1066000.0d, 0.000361813d },
            { 1088000.0d, 0.000364161d },
            { 1110000.0d, 0.000366294d },
            { 1132000.0d, 0.000368218d },
            { 1154000.0d, 0.000369937d },
            { 1176000.0d, 0.000371458d },
            { 1198000.0d, 0.000372785d },
            { 1220000.0d, 0.000373924d },
            { 1242000.0d, 0.000374881d },
            { 1264000.0d, 0.000375662d },
            { 1286000.0d, 0.000376271d },
            { 1308000.0d, 0.000376711d },
            { 1330000.0d, 0.000376987d },
            { 1352000.0d, 0.000377103d },
            { 1374000.0d, 0.000377064d },
            { 1396000.0d, 0.000376873d },
            { 1418000.0d, 0.000376538d },
            { 1440000.0d, 0.000376063d },
            { 1462000.0d, 0.000375452d },
            { 1484000.0d, 0.000374711d },
            { 1506000.0d, 0.000373848d },
            { 1528000.0d, 0.000372868d },
            { 1550000.0d, 0.000371777d },
            { 1572000.0d, 0.00037058d },
            { 1594000.0d, 0.000369285d },
            { 1616000.0d, 0.000367897d },
            { 1638000.0d, 0.000366423d },
            { 1660000.0d, 0.00036487d },
            { 1682000.0d, 0.00036324d },
            { 1704000.0d, 0.000361542d },
            { 1726000.0d, 0.00035978d },
            { 1748000.0d, 0.00035796d },
            { 1770000.0d, 0.000356087d },
            { 1792000.0d, 0.000354168d },
            { 1814000.0d, 0.000352206d },
            { 1836000.0d, 0.000350209d },
            { 1858000.0d, 0.000348181d },
            { 1880000.0d, 0.000346125d },
            { 1902000.0d, 0.00034405d },
            { 1924000.0d, 0.000341958d },
            { 1946000.0d, 0.000339851d },
            { 1968000.0d, 0.000337731d },
            { 1990000.0d, 0.0003356d },
            { 2012000.0d, 0.000333455d },
            { 2034000.0d, 0.000331293d },
            { 2056000.0d, 0.000329112d },
            { 2078000.0d, 0.000326904d },
            { 2100000.0d, 0.000324668d },
            { 2122000.0d, 0.000322394d },
            { 2144000.0d, 0.000320084d },
            { 2166000.0d, 0.000317729d },
            { 2188000.0d, 0.000315331d },
            { 2210000.0d, 0.000312886d },
            { 2232000.0d, 0.000310395d },
            { 2254000.0d, 0.000307857d },
            { 2276000.0d, 0.000305272d },
            { 2298000.0d, 0.00030264d },
            { 2320000.0d, 0.000299961d },
            { 2342000.0d, 0.000297237d },
            { 2364000.0d, 0.000294467d },
            { 2386000.0d, 0.000291654d },
            { 2408000.0d, 0.000288796d },
            { 2430000.0d, 0.000285896d },
            { 2452000.0d, 0.000282954d },
            { 2474000.0d, 0.000279972d },
            { 2496000.0d, 0.000276951d },
            { 2518000.0d, 0.000273893d },
            { 2540000.0d, 0.000270799d },
            { 2562000.0d, 0.000267672d },
            { 2584000.0d, 0.000264514d },
            { 2606000.0d, 0.000261326d },
            { 2628000.0d, 0.000258112d },
            { 2650000.0d, 0.000254874d },
            { 2672000.0d, 0.000251613d },
            { 2694000.0d, 0.000248333d },
            { 2716000.0d, 0.000245035d },
            { 2738000.0d, 0.000241721d },
            { 2760000.0d, 0.000238394d },
            { 2782000.0d, 0.000235056d },
            { 2804000.0d, 0.000231707d },
            { 2826000.0d, 0.000228351d },
            { 2848000.0d, 0.000224988d },
            { 2870000.0d, 0.000221621d },
            { 2892000.0d, 0.000218252d },
            { 2914000.0d, 0.000214881d },
            { 2936000.0d, 0.000211513d },
            { 2958000.0d, 0.000208149d },
            { 2980000.0d, 0.000204791d },
            { 3002000.0d, 0.000201443d },
            { 3024000.0d, 0.000198105d },
            { 3046000.0d, 0.000194782d },
            { 3068000.0d, 0.000191473d },
            { 3090000.0d, 0.00018818d },
            { 3112000.0d, 0.000184905d },
            { 3134000.0d, 0.000181647d },
            { 3156000.0d, 0.000178406d },
            { 3178000.0d, 0.000175183d },
            { 3200000.0d, 0.000171978d },
            { 3222000.0d, 0.00016879d },
            { 3244000.0d, 0.00016562d },
            { 3266000.0d, 0.000162463d },
            { 3288000.0d, 0.00015932d },
            { 3310000.0d, 0.000156192d },
            { 3332000.0d, 0.00015308d },
            { 3354000.0d, 0.000149987d },
            { 3376000.0d, 0.000146913d },
            { 3398000.0d, 0.00014386d },
            { 3420000.0d, 0.00014083d },
            { 3442000.0d, 0.00013782d },
            { 3464000.0d, 0.000134829d },
            { 3486000.0d, 0.000131859d },
            { 3508000.0d, 0.000128908d },
            { 3530000.0d, 0.000125974d },
            { 3552000.0d, 0.000123056d },
            { 3574000.0d, 0.000120152d },
            { 3596000.0d, 0.000117264d },
            { 3618000.0d, 0.000114393d },
            { 3640000.0d, 0.000111541d },
            { 3662000.0d, 0.000108708d },
            { 3684000.0d, 0.000105898d },
            { 3706000.0d, 0.000103113d },
            { 3728000.0d, 0.000100354d },
            { 3750000.0d, 0.000097624d },
            { 3772000.0d, 0.0000949248d },
            { 3794000.0d, 0.0000922584d },
            { 3816000.0d, 0.000089627d },
            { 3838000.0d, 0.0000870314d },
            { 3860000.0d, 0.0000844729d },
            { 3882000.0d, 0.0000819528d },
            { 3904000.0d, 0.0000794708d },
            { 3926000.0d, 0.000077023d },
            { 3948000.0d, 0.0000745976d },
            { 3970000.0d, 0.0000721956d },
            { 3992000.0d, 0.0000698193d },
            { 4014000.0d, 0.0000674703d },
            { 4036000.0d, 0.0000651504d },
            { 4058000.0d, 0.000062862d },
            { 4080000.0d, 0.0000606064d },
            { 4102000.0d, 0.0000583852d },
            { 4124000.0d, 0.0000561997d },
            { 4146000.0d, 0.0000540519d },
            { 4168000.0d, 0.0000519437d },
            { 4190000.0d, 0.0000498772d },
            { 4212000.0d, 0.0000478544d },
            { 4234000.0d, 0.0000458775d },
            { 4256000.0d, 0.0000439478d },
            { 4278000.0d, 0.0000420664d },
            { 4300000.0d, 0.0000402325d },
            { 4322000.0d, 0.0000384474d },
            { 4344000.0d, 0.0000367132d },
            { 4366000.0d, 0.0000350318d },
            { 4388000.0d, 0.0000334055d },
            { 4410000.0d, 0.0000318361d },
            { 4432000.0d, 0.000030326d },
            { 4454000.0d, 0.000028877d },
            { 4476000.0d, 0.0000274912d },
            { 4498000.0d, 0.000026169d },
            { 4520000.0d, 0.0000248994d },
            { 4542000.0d, 0.0000236812d },
            { 4564000.0d, 0.0000225156d },
            { 4586000.0d, 0.0000214037d },
            { 4608000.0d, 0.0000203375d },
            { 4630000.0d, 0.0000193086d },
            { 4652000.0d, 0.0000183181d },
            { 4674000.0d, 0.0000173674d },
            { 4696000.0d, 0.0000164579d },
            { 4718000.0d, 0.0000155877d },
            { 4740000.0d, 0.0000147549d },
            { 4762000.0d, 0.0000139576d },
            { 4784000.0d, 0.0000131947d },
            { 4806000.0d, 0.0000124671d },
            { 4828000.0d, 0.0000117755d },
            { 4850000.0d, 0.0000111207d },
            { 4872000.0d, 0.0000105038d },
            { 4894000.0d, 0.00000992577d },
            { 4916000.0d, 0.00000938771d },
            { 4938000.0d, 0.00000889058d },
            { 4960000.0d, 0.00000842555d },
            { 4982000.0d, 0.00000797593d },
            { 5004000.0d, 0.00000754185d },
            { 5026000.0d, 0.00000712385d },
            { 5048000.0d, 0.00000672248d },
            { 5070000.0d, 0.00000633832d },
            { 5092000.0d, 0.00000597191d },
            { 5114000.0d, 0.00000562381d },
            { 5136000.0d, 0.00000529461d },
            { 5158000.0d, 0.00000498491d },
            { 5180000.0d, 0.00000469523d },
            { 5202000.0d, 0.00000442603d },
            { 5224000.0d, 0.00000417774d },
            { 5246000.0d, 0.0000039509d },
            { 5268000.0d, 0.0000037456d },
            { 5290000.0d, 0.00000356008d },
            { 5312000.0d, 0.00000338786d },
            { 5334000.0d, 0.00000322599d },
            { 5356000.0d, 0.00000307453d },
            { 5378000.0d, 0.00000293366d },
            { 5400000.0d, 0.00000280318d },
            { 5422000.0d, 0.00000268169d },
            { 5444000.0d, 0.00000256342d },
            { 5466000.0d, 0.00000244763d },
            { 5488000.0d, 0.00000233441d },
            { 5510000.0d, 0.00000222389d },
            { 5532000.0d, 0.0000021162d },
            { 5554000.0d, 0.00000201144d },
            { 5576000.0d, 0.00000190974d },
            { 5598000.0d, 0.00000181123d },
            { 5620000.0d, 0.00000171604d },
            { 5642000.0d, 0.00000162429d },
            { 5664000.0d, 0.00000153612d },
            { 5686000.0d, 0.00000145167d },
            { 5708000.0d, 0.00000137107d },
            { 5730000.0d, 0.00000129446d },
            { 5752000.0d, 0.00000122197d },
            { 5774000.0d, 0.00000115375d },
            { 5796000.0d, 0.00000108949d },
            { 5818000.0d, 0.00000102819d },
            { 5840000.0d, 0.000000969537d },
            { 5862000.0d, 0.000000912413d },
            { 5884000.0d, 0.000000856783d },
            { 5906000.0d, 0.000000802713d },
            { 5928000.0d, 0.000000750198d },
            { 5950000.0d, 0.000000699036d },
            { 5972000.0d, 0.000000649262d },
            { 5994000.0d, 0.000000600945d },
            { 6016000.0d, 0.00000055415d },
            { 6038000.0d, 0.000000508951d },
            { 6060000.0d, 0.000000465421d },
            { 6082000.0d, 0.000000423637d },
            { 6104000.0d, 0.000000383677d },
            { 6126000.0d, 0.000000345622d },
            { 6148000.0d, 0.000000309554d },
            { 6170000.0d, 0.000000275561d },
            { 6192000.0d, 0.000000243729d },
            { 6214000.0d, 0.000000214149d },
            { 6236000.0d, 0.000000186914d },
            { 6258000.0d, 0.000000162119d },
            { 6280000.0d, 0.00000013986d },
            { 6302000.0d, 0.000000120077d },
            { 6324000.0d, 0.000000101944d },
            { 6346000.0d, 0.0000000853935d },
            { 6368000.0d, 0.0000000705164d },
            { 6390000.0d, 0.0000000574063d },
            { 6412000.0d, 0.0000000461593d },
            { 6434000.0d, 0.0000000368737d },
            { 6456000.0d, 0.0000000296485d },
            { 6478000.0d, 0.0000000245737d },
            { 6500000.0d, 0.0000000207691d },
            { 6522000.0d, 0.0000000172651d },
            { 6544000.0d, 0.0000000140673d },
            { 6566000.0d, 0.0000000111816d },
            { 6588000.0d, 0.00000000861358d },
            { 6610000.0d, 0.00000000636909d },
            { 6632000.0d, 0.00000000445377d },
            { 6654000.0d, 0.00000000287319d },
            { 6676000.0d, 0.00000000163276d },
            { 6698000.0d, 0.00000000073764d },
            { 6720000.0d, 0.000000000192447d },
            { 6742000.0d, 0.000000000000317017d },
            { 6743100.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    