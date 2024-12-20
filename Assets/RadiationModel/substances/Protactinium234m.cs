using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium234m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium234m";
        public override double halfLife { get; } = 69.54d;
        public override double atomicWeight { get; } = 234.04339d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9984000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium234()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.1999999999999999e-05d, new GammaParticle(62700.0, 0.01977)), new(4.3e-08d, new GammaParticle(135320.0, 0.00916)), new(4.6999999999999995e-07d, new GammaParticle(137230.0, 0.00903)), new(1.2800000000000001e-05d, new GammaParticle(140100.0, 0.00885)), new(2.4e-09d, new GammaParticle(166500.0, 0.00745)), new(1.6800000000000002e-05d, new GammaParticle(184700.0, 0.00671)), new(7.2000000000000005e-06d, new GammaParticle(193400.0, 0.00641)), new(7.2000000000000005e-06d, new GammaParticle(193400.0, 0.00641)), new(2.7e-07d, new GammaParticle(197910.0, 0.00626)), new(5.7e-06d, new GammaParticle(199900.0, 0.0062)), new(1.7e-05d, new GammaParticle(203300.0, 0.0061)), new(1.3500000000000001e-05d, new GammaParticle(209900.0, 0.00591)), new(8.000000000000001e-07d, new GammaParticle(235900.0, 0.00526)), new(5e-06d, new GammaParticle(243500.0, 0.00509)), new(2.44e-06d, new GammaParticle(247700.0, 0.00501)), new(0.0007639999999999999d, new GammaParticle(258227.0, 0.0048)), new(3.1e-06d, new GammaParticle(275500.0, 0.0045)), new(6.5e-06d, new GammaParticle(299000.0, 0.00415)), new(8.4e-07d, new GammaParticle(311000.0, 0.00399)), new(1.9e-06d, new GammaParticle(316700.0, 0.00391)), new(1.1000000000000001e-05d, new GammaParticle(338100.0, 0.00367)), new(7e-07d, new GammaParticle(340200.0, 0.00364)), new(8e-06d, new GammaParticle(357500.0, 0.00347)), new(6.8e-06d, new GammaParticle(362800.0, 0.00342)), new(9.3e-06d, new GammaParticle(387600.0, 0.0032)), new(4.68e-06d, new GammaParticle(387600.0, 0.0032)), new(2.0000000000000002e-07d, new GammaParticle(427400.0, 0.0029)), new(3e-07d, new GammaParticle(445910.0, 0.00278)), new(3.11e-05d, new GammaParticle(450970.0, 0.00275)), new(2.13e-05d, new GammaParticle(453580.0, 0.00273)), new(7.2000000000000005e-06d, new GammaParticle(456700.0, 0.00271)), new(2.29e-05d, new GammaParticle(468430.0, 0.00265)), new(2.39e-05d, new GammaParticle(475740.0, 0.00261)), new(1.9e-07d, new GammaParticle(485440.0, 0.00255)), new(1.57e-05d, new GammaParticle(507500.0, 0.00244)), new(2.1e-05d, new GammaParticle(509200.0, 0.00243)), new(1.3e-07d, new GammaParticle(516600.0, 0.0024)), new(9.300000000000001e-08d, new GammaParticle(526020.0, 0.00236)), new(3.67e-05d, new GammaParticle(543980.0, 0.00228)), new(8.4e-08d, new GammaParticle(557240.0, 0.00222)), new(7.2000000000000005e-06d, new GammaParticle(557300.0, 0.00222)), new(8.67e-06d, new GammaParticle(572000.0, 0.00217)), new(8.2e-07d, new GammaParticle(581190.0, 0.00213)), new(1.15e-06d, new GammaParticle(624600.0, 0.00199)), new(1.57e-05d, new GammaParticle(647700.0, 0.00191)), new(1e-05d, new GammaParticle(649000.0, 0.00191)), new(4.1e-07d, new GammaParticle(649000.0, 0.00191)), new(1.38e-05d, new GammaParticle(655300.0, 0.00189)), new(3.7e-06d, new GammaParticle(670800.0, 0.00185)), new(6.5e-06d, new GammaParticle(673900.0, 0.00184)), new(5.7e-06d, new GammaParticle(683400.0, 0.00181)), new(8.920000000000001e-05d, new GammaParticle(691000.0, 0.00179)), new(1.62e-05d, new GammaParticle(695500.0, 0.00178)), new(5.7e-05d, new GammaParticle(699020.0, 0.00177)), new(7.24e-05d, new GammaParticle(702000.0, 0.00177)), new(5.6e-05d, new GammaParticle(705940.0, 0.00176)), new(6.73e-06d, new GammaParticle(708200.0, 0.00175)), new(2.6e-07d, new GammaParticle(719010.0, 0.00172)), new(1.3e-05d, new GammaParticle(732500.0, 0.00169)), new(0.00010899999999999999d, new GammaParticle(740100.0, 0.00168)), new(0.001066d, new GammaParticle(742813.0, 0.00167)), new(1.8e-07d, new GammaParticle(750120.0, 0.00165)), new(1.57e-05d, new GammaParticle(760300.0, 0.00163)), new(4.3e-08d, new GammaParticle(760530.0, 0.00163)), new(0.00317d, new GammaParticle(766420.0, 0.00162)), new(7.77e-05d, new GammaParticle(781750.0, 0.00159)), new(3.8999999999999997e-07d, new GammaParticle(783400.0, 0.00158)), new(0.000544d, new GammaParticle(786280.0, 0.00158)), new(1.0000000000000001e-07d, new GammaParticle(791940.0, 0.00157)), new(5.9e-05d, new GammaParticle(805750.0, 0.00154)), new(2.7799999999999998e-05d, new GammaParticle(808200.0, 0.00153)), new(1e-05d, new GammaParticle(818200.0, 0.00152)), new(6.6e-05d, new GammaParticle(825600.0, 0.0015)), new(1.1000000000000001e-05d, new GammaParticle(844100.0, 0.00147)), new(6.9e-05d, new GammaParticle(851580.0, 0.00146)), new(1.14e-05d, new GammaParticle(866800.0, 0.00143)), new(4e-05d, new GammaParticle(880900.0, 0.00141)), new(3.5000000000000004e-05d, new GammaParticle(883220.0, 0.0014)), new(7.09e-05d, new GammaParticle(887290.0, 0.0014)), new(0.0001278d, new GammaParticle(921720.0, 0.00135)), new(1.24e-05d, new GammaParticle(926610.0, 0.00134)), new(1.1000000000000001e-05d, new GammaParticle(936300.0, 0.00132)), new(2.5200000000000003e-05d, new GammaParticle(941960.0, 0.00132)), new(0.000101d, new GammaParticle(945940.0, 0.00131)), new(8e-06d, new GammaParticle(960000.0, 0.00129)), new(5.6e-05d, new GammaParticle(996100.0, 0.00124)), new(0.00842d, new GammaParticle(1001030.0, 0.00124)), new(1.24e-05d, new GammaParticle(1041700.0, 0.00119)), new(2.28e-05d, new GammaParticle(1059400.0, 0.00117)), new(2.14e-05d, new GammaParticle(1061860.0, 0.00117)), new(9e-06d, new GammaParticle(1081900.0, 0.00115)), new(8e-06d, new GammaParticle(1084250.0, 0.00114)), new(1.7199999999999998e-05d, new GammaParticle(1120600.0, 0.00111)), new(3.03e-05d, new GammaParticle(1124930.0, 0.0011)), new(3.4e-06d, new GammaParticle(1124930.0, 0.0011)), new(1.94e-05d, new GammaParticle(1174200.0, 0.00106)), new(0.0001358d, new GammaParticle(1193730.0, 0.00104)), new(9.1e-06d, new GammaParticle(1220370.0, 0.00102)), new(5.25e-05d, new GammaParticle(1237260.0, 0.001)), new(1.09e-05d, new GammaParticle(1353000.0, 0.00092)), new(3.46e-05d, new GammaParticle(1392700.0, 0.00089)), new(2.2599999999999997e-05d, new GammaParticle(1413880.0, 0.00088)), new(9.730000000000001e-05d, new GammaParticle(1434140.0, 0.00086)), new(1.9e-05d, new GammaParticle(1458500.0, 0.00085)), new(9.26e-06d, new GammaParticle(1501000.0, 0.00083)), new(0.0001305d, new GammaParticle(1510210.0, 0.00082)), new(2.01e-05d, new GammaParticle(1527270.0, 0.00081)), new(1.14e-05d, new GammaParticle(1550000.0, 0.0008)), new(8.21e-05d, new GammaParticle(1553750.0, 0.0008)), new(7.2000000000000005e-06d, new GammaParticle(1558400.0, 0.0008)), new(1.09e-05d, new GammaParticle(1570670.0, 0.00079)), new(1.89e-05d, new GammaParticle(1593870.0, 0.00078)), new(4.7e-06d, new GammaParticle(1601800.0, 0.00077)), new(1.15e-05d, new GammaParticle(1667600.0, 0.00074)), new(4.5e-06d, new GammaParticle(1694100.0, 0.00073)), new(3.4e-06d, new GammaParticle(1720500.0, 0.00072)), new(1.9e-05d, new GammaParticle(1732200.0, 0.00072)), new(0.000213d, new GammaParticle(1737750.0, 0.00071)), new(1.4599999999999999e-05d, new GammaParticle(1759810.0, 0.0007)), new(8.750000000000001e-05d, new GammaParticle(1765440.0, 0.0007)), new(4.2000000000000004e-06d, new GammaParticle(1796200.0, 0.00069)), new(3.74e-05d, new GammaParticle(1809040.0, 0.00069)), new(8.8e-06d, new GammaParticle(1819690.0, 0.00068)), new(0.0001742d, new GammaParticle(1831360.0, 0.00068)), new(1.21e-05d, new GammaParticle(1863090.0, 0.00067)), new(9.259999999999999e-05d, new GammaParticle(1867690.0, 0.00066)), new(8.18e-05d, new GammaParticle(1874880.0, 0.00066)), new(1.89e-05d, new GammaParticle(1893510.0, 0.00065)), new(6.24e-05d, new GammaParticle(1911190.0, 0.00065)), new(4.5e-06d, new GammaParticle(1926500.0, 0.00064)), new(2.1e-05d, new GammaParticle(1937040.0, 0.00064)), new(4.1e-06d, new GammaParticle(1970000.0, 0.00063)), new(1.85e-06d, new GammaParticle(2022240.0, 0.00061)), new(1.0900000000000002e-06d, new GammaParticle(2041230.0, 0.00061)), new(7.100000000000001e-07d, new GammaParticle(2065800.0, 0.0006)), new(2.0000000000000002e-07d, new GammaParticle(2093190.0, 0.00059)), new(6.1e-07d, new GammaParticle(2102140.0, 0.00059)), new(7.100000000000001e-07d, new GammaParticle(2136690.0, 0.00058)), new(0.00013440056954692d, new GammaParticle(16678.0, 0.07434)), new(6.777915027462378e-05d, new GammaParticle(94657.0, 0.0131)), new(0.000108498719824914d, new GammaParticle(98439.0, 0.0126)), new(3.9143670111521795e-05d, new GammaParticle(111238.0, 0.01115)), new(5.253080528966225e-05d, new GammaParticle(112645.0, 0.01101)), new(1.3387135178140451e-05d, new GammaParticle(114446.0, 0.01083)) } },
            { 0.0016d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium234()), new(0.00013d, new GammaParticle(73920.0, 0.01677)), new(0.0005403136d, new GammaParticle(16228.0, 0.0764)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000438417d },
            { 900.0d, 0.000440998d },
            { 1800.0d, 0.000443171d },
            { 2700.0d, 0.000444936d },
            { 3600.0d, 0.00044646d },
            { 4500.0d, 0.000447908d },
            { 5400.0d, 0.00044929d },
            { 6300.0d, 0.000450617d },
            { 7200.0d, 0.000451904d },
            { 8100.0d, 0.000453147d },
            { 9000.0d, 0.00045435d },
            { 9900.0d, 0.000455512d },
            { 10000.0d, 0.000455639d },
            { 11000.0d, 0.00045688d },
            { 12000.0d, 0.000458072d },
            { 13000.0d, 0.000459237d },
            { 14000.0d, 0.000460363d },
            { 15000.0d, 0.000461449d },
            { 16000.0d, 0.000462497d },
            { 17000.0d, 0.000463508d },
            { 18000.0d, 0.000464482d },
            { 19000.0d, 0.000465418d },
            { 20000.0d, 0.000466317d },
            { 21000.0d, 0.00046718d },
            { 22000.0d, 0.000468106d },
            { 23000.0d, 0.00046902d },
            { 24000.0d, 0.000469922d },
            { 25000.0d, 0.000470813d },
            { 26000.0d, 0.000471692d },
            { 27000.0d, 0.00047256d },
            { 28000.0d, 0.000473417d },
            { 29000.0d, 0.000474285d },
            { 30000.0d, 0.000475147d },
            { 31000.0d, 0.000476003d },
            { 32000.0d, 0.000476854d },
            { 33000.0d, 0.000477699d },
            { 34000.0d, 0.000478538d },
            { 35000.0d, 0.000479372d },
            { 36000.0d, 0.000480208d },
            { 37000.0d, 0.000481041d },
            { 38000.0d, 0.00048187d },
            { 39000.0d, 0.000482695d },
            { 40000.0d, 0.000483517d },
            { 41000.0d, 0.000484336d },
            { 42000.0d, 0.00048515d },
            { 43000.0d, 0.000485965d },
            { 44000.0d, 0.000486777d },
            { 45000.0d, 0.000487587d },
            { 46000.0d, 0.000488393d },
            { 47000.0d, 0.000489198d },
            { 48000.0d, 0.000489999d },
            { 49000.0d, 0.000490798d },
            { 50000.0d, 0.000491596d },
            { 51000.0d, 0.000492392d },
            { 52000.0d, 0.000493186d },
            { 53000.0d, 0.000493977d },
            { 54000.0d, 0.000494766d },
            { 55000.0d, 0.000495553d },
            { 56000.0d, 0.000496338d },
            { 57000.0d, 0.000497122d },
            { 58000.0d, 0.000497904d },
            { 59000.0d, 0.000498684d },
            { 60000.0d, 0.000499461d },
            { 61000.0d, 0.000500237d },
            { 62000.0d, 0.000501011d },
            { 63000.0d, 0.000501784d },
            { 64000.0d, 0.000502554d },
            { 65000.0d, 0.000503323d },
            { 66000.0d, 0.00050409d },
            { 67000.0d, 0.000504856d },
            { 68000.0d, 0.000505619d },
            { 69000.0d, 0.000506381d },
            { 70000.0d, 0.000507141d },
            { 71000.0d, 0.0005079d },
            { 72000.0d, 0.000508656d },
            { 73000.0d, 0.000509412d },
            { 74000.0d, 0.000510165d },
            { 75000.0d, 0.000510917d },
            { 76000.0d, 0.000511667d },
            { 77000.0d, 0.000512415d },
            { 78000.0d, 0.000513162d },
            { 79000.0d, 0.000513908d },
            { 80000.0d, 0.000514652d },
            { 81000.0d, 0.000515395d },
            { 82000.0d, 0.000516136d },
            { 83000.0d, 0.000516875d },
            { 84000.0d, 0.000517613d },
            { 85000.0d, 0.000518349d },
            { 86000.0d, 0.000519084d },
            { 87000.0d, 0.000519817d },
            { 88000.0d, 0.000520549d },
            { 89000.0d, 0.000521279d },
            { 90000.0d, 0.000522007d },
            { 91000.0d, 0.000522734d },
            { 92000.0d, 0.00052346d },
            { 93000.0d, 0.000524184d },
            { 94000.0d, 0.000524907d },
            { 95000.0d, 0.000525628d },
            { 96000.0d, 0.000526348d },
            { 97000.0d, 0.000527066d },
            { 98000.0d, 0.000527782d },
            { 99000.0d, 0.000528498d },
            { 100000.0d, 0.000529212d },
            { 107000.0d, 0.000534169d },
            { 114000.0d, 0.000539057d },
            { 121000.0d, 0.000543876d },
            { 128000.0d, 0.000548628d },
            { 135000.0d, 0.000553312d },
            { 142000.0d, 0.000557931d },
            { 149000.0d, 0.000562483d },
            { 156000.0d, 0.00056697d },
            { 163000.0d, 0.000571392d },
            { 170000.0d, 0.000575749d },
            { 177000.0d, 0.000580041d },
            { 184000.0d, 0.000584268d },
            { 191000.0d, 0.00058843d },
            { 198000.0d, 0.000592529d },
            { 205000.0d, 0.000596563d },
            { 212000.0d, 0.000600532d },
            { 219000.0d, 0.000604438d },
            { 226000.0d, 0.000608279d },
            { 233000.0d, 0.000612057d },
            { 240000.0d, 0.00061577d },
            { 247000.0d, 0.000619419d },
            { 254000.0d, 0.000623005d },
            { 261000.0d, 0.000626528d },
            { 268000.0d, 0.000629987d },
            { 275000.0d, 0.000633382d },
            { 282000.0d, 0.000636715d },
            { 289000.0d, 0.000639985d },
            { 296000.0d, 0.000643192d },
            { 303000.0d, 0.000646335d },
            { 310000.0d, 0.000649417d },
            { 317000.0d, 0.000652436d },
            { 324000.0d, 0.000655391d },
            { 331000.0d, 0.000658284d },
            { 338000.0d, 0.000661115d },
            { 345000.0d, 0.000663883d },
            { 352000.0d, 0.000666587d },
            { 359000.0d, 0.000669228d },
            { 366000.0d, 0.000671804d },
            { 373000.0d, 0.000674311d },
            { 380000.0d, 0.000676751d },
            { 387000.0d, 0.000679123d },
            { 394000.0d, 0.000681428d },
            { 401000.0d, 0.000683663d },
            { 408000.0d, 0.000685828d },
            { 415000.0d, 0.000687926d },
            { 422000.0d, 0.000689952d },
            { 429000.0d, 0.000691909d },
            { 436000.0d, 0.000693797d },
            { 443000.0d, 0.000695615d },
            { 450000.0d, 0.000697365d },
            { 457000.0d, 0.000699045d },
            { 464000.0d, 0.000700656d },
            { 471000.0d, 0.000702198d },
            { 478000.0d, 0.000703671d },
            { 485000.0d, 0.000705074d },
            { 492000.0d, 0.000706408d },
            { 499000.0d, 0.000707671d },
            { 506000.0d, 0.000708864d },
            { 513000.0d, 0.000709987d },
            { 520000.0d, 0.000711039d },
            { 527000.0d, 0.000712021d },
            { 534000.0d, 0.000712934d },
            { 541000.0d, 0.000713776d },
            { 548000.0d, 0.00071455d },
            { 555000.0d, 0.000715254d },
            { 562000.0d, 0.000715889d },
            { 569000.0d, 0.000716457d },
            { 576000.0d, 0.000716954d },
            { 583000.0d, 0.000717385d },
            { 590000.0d, 0.000717746d },
            { 597000.0d, 0.00071804d },
            { 604000.0d, 0.000718267d },
            { 611000.0d, 0.000718426d },
            { 618000.0d, 0.000718518d },
            { 625000.0d, 0.000718543d },
            { 632000.0d, 0.000718503d },
            { 639000.0d, 0.000718395d },
            { 646000.0d, 0.000718222d },
            { 653000.0d, 0.000717984d },
            { 660000.0d, 0.00071768d },
            { 667000.0d, 0.000717312d },
            { 674000.0d, 0.000716879d },
            { 681000.0d, 0.000716381d },
            { 688000.0d, 0.000715821d },
            { 695000.0d, 0.000715195d },
            { 702000.0d, 0.000714507d },
            { 709000.0d, 0.000713755d },
            { 716000.0d, 0.00071294d },
            { 723000.0d, 0.000712062d },
            { 730000.0d, 0.000711122d },
            { 737000.0d, 0.000710121d },
            { 744000.0d, 0.000709056d },
            { 751000.0d, 0.000707931d },
            { 758000.0d, 0.000706745d },
            { 765000.0d, 0.000705497d },
            { 772000.0d, 0.000704191d },
            { 779000.0d, 0.000702824d },
            { 786000.0d, 0.000701398d },
            { 793000.0d, 0.000699912d },
            { 800000.0d, 0.000698368d },
            { 807000.0d, 0.000696766d },
            { 814000.0d, 0.000695106d },
            { 821000.0d, 0.000693389d },
            { 828000.0d, 0.000691616d },
            { 835000.0d, 0.000689786d },
            { 842000.0d, 0.0006879d },
            { 849000.0d, 0.000685959d },
            { 856000.0d, 0.000683963d },
            { 863000.0d, 0.000681913d },
            { 870000.0d, 0.000679808d },
            { 877000.0d, 0.000677651d },
            { 884000.0d, 0.00067544d },
            { 891000.0d, 0.000673177d },
            { 898000.0d, 0.000670862d },
            { 905000.0d, 0.000668495d },
            { 912000.0d, 0.000666079d },
            { 919000.0d, 0.000663611d },
            { 926000.0d, 0.000661094d },
            { 933000.0d, 0.000658528d },
            { 940000.0d, 0.000655914d },
            { 947000.0d, 0.000653251d },
            { 954000.0d, 0.000650541d },
            { 961000.0d, 0.000647785d },
            { 968000.0d, 0.000644981d },
            { 975000.0d, 0.000642132d },
            { 982000.0d, 0.000639238d },
            { 989000.0d, 0.000636299d },
            { 996000.0d, 0.000633317d },
            { 1003000.0d, 0.00063029d },
            { 1010000.0d, 0.000627222d },
            { 1017000.0d, 0.000624111d },
            { 1024000.0d, 0.000620958d },
            { 1031000.0d, 0.000617765d },
            { 1038000.0d, 0.000614531d },
            { 1045000.0d, 0.000611257d },
            { 1052000.0d, 0.000607945d },
            { 1059000.0d, 0.000604594d },
            { 1066000.0d, 0.000601205d },
            { 1073000.0d, 0.000597779d },
            { 1080000.0d, 0.000594317d },
            { 1087000.0d, 0.000590818d },
            { 1094000.0d, 0.000587284d },
            { 1101000.0d, 0.000583716d },
            { 1108000.0d, 0.000580114d },
            { 1115000.0d, 0.000576478d },
            { 1122000.0d, 0.000572809d },
            { 1129000.0d, 0.00056911d },
            { 1136000.0d, 0.000565378d },
            { 1143000.0d, 0.000561616d },
            { 1150000.0d, 0.000557824d },
            { 1157000.0d, 0.000554003d },
            { 1164000.0d, 0.000550154d },
            { 1171000.0d, 0.000546276d },
            { 1178000.0d, 0.000542371d },
            { 1185000.0d, 0.00053844d },
            { 1192000.0d, 0.000534484d },
            { 1199000.0d, 0.000530502d },
            { 1206000.0d, 0.000526496d },
            { 1213000.0d, 0.000522466d },
            { 1220000.0d, 0.000518413d },
            { 1227000.0d, 0.000514339d },
            { 1234000.0d, 0.000510238d },
            { 1241000.0d, 0.000506113d },
            { 1248000.0d, 0.000501963d },
            { 1255000.0d, 0.000497789d },
            { 1262000.0d, 0.000493592d },
            { 1269000.0d, 0.000489371d },
            { 1276000.0d, 0.000485129d },
            { 1283000.0d, 0.000480866d },
            { 1290000.0d, 0.000476582d },
            { 1297000.0d, 0.000472277d },
            { 1304000.0d, 0.000467954d },
            { 1311000.0d, 0.000463612d },
            { 1318000.0d, 0.000459252d },
            { 1325000.0d, 0.000454875d },
            { 1332000.0d, 0.000450481d },
            { 1339000.0d, 0.000446071d },
            { 1346000.0d, 0.000441646d },
            { 1353000.0d, 0.000437207d },
            { 1360000.0d, 0.000432754d },
            { 1367000.0d, 0.000428288d },
            { 1374000.0d, 0.00042381d },
            { 1381000.0d, 0.00041932d },
            { 1388000.0d, 0.000414819d },
            { 1395000.0d, 0.000410307d },
            { 1402000.0d, 0.000405787d },
            { 1409000.0d, 0.000401258d },
            { 1416000.0d, 0.000396721d },
            { 1423000.0d, 0.000392176d },
            { 1430000.0d, 0.000387625d },
            { 1437000.0d, 0.000383069d },
            { 1444000.0d, 0.000378507d },
            { 1451000.0d, 0.000373941d },
            { 1458000.0d, 0.000369371d },
            { 1465000.0d, 0.000364797d },
            { 1472000.0d, 0.000360219d },
            { 1479000.0d, 0.000355636d },
            { 1486000.0d, 0.00035105d },
            { 1493000.0d, 0.000346462d },
            { 1500000.0d, 0.000341871d },
            { 1507000.0d, 0.000337279d },
            { 1514000.0d, 0.000332686d },
            { 1521000.0d, 0.000328093d },
            { 1528000.0d, 0.000323501d },
            { 1535000.0d, 0.00031891d },
            { 1542000.0d, 0.000314321d },
            { 1549000.0d, 0.000309736d },
            { 1556000.0d, 0.000305154d },
            { 1563000.0d, 0.000300577d },
            { 1570000.0d, 0.000296005d },
            { 1577000.0d, 0.000291439d },
            { 1584000.0d, 0.000286879d },
            { 1591000.0d, 0.000282327d },
            { 1598000.0d, 0.000277783d },
            { 1605000.0d, 0.000273248d },
            { 1612000.0d, 0.000268722d },
            { 1619000.0d, 0.000264207d },
            { 1626000.0d, 0.000259703d },
            { 1633000.0d, 0.000255212d },
            { 1640000.0d, 0.000250733d },
            { 1647000.0d, 0.000246267d },
            { 1654000.0d, 0.000241816d },
            { 1661000.0d, 0.000237379d },
            { 1668000.0d, 0.000232958d },
            { 1675000.0d, 0.000228553d },
            { 1682000.0d, 0.000224166d },
            { 1689000.0d, 0.000219798d },
            { 1696000.0d, 0.000215448d },
            { 1703000.0d, 0.000211118d },
            { 1710000.0d, 0.000206808d },
            { 1717000.0d, 0.000202519d },
            { 1724000.0d, 0.000198252d },
            { 1731000.0d, 0.000194008d },
            { 1738000.0d, 0.000189788d },
            { 1745000.0d, 0.000185592d },
            { 1752000.0d, 0.00018142d },
            { 1759000.0d, 0.000177275d },
            { 1766000.0d, 0.000173157d },
            { 1773000.0d, 0.000169066d },
            { 1780000.0d, 0.000165003d },
            { 1787000.0d, 0.000160971d },
            { 1794000.0d, 0.000156967d },
            { 1801000.0d, 0.000152994d },
            { 1808000.0d, 0.000149053d },
            { 1815000.0d, 0.000145144d },
            { 1822000.0d, 0.000141268d },
            { 1829000.0d, 0.000137426d },
            { 1836000.0d, 0.000133619d },
            { 1843000.0d, 0.000129848d },
            { 1850000.0d, 0.000126113d },
            { 1857000.0d, 0.000122414d },
            { 1864000.0d, 0.000118755d },
            { 1871000.0d, 0.000115133d },
            { 1878000.0d, 0.000111552d },
            { 1885000.0d, 0.000108011d },
            { 1892000.0d, 0.000104511d },
            { 1899000.0d, 0.000101054d },
            { 1906000.0d, 0.0000976393d },
            { 1913000.0d, 0.0000942684d },
            { 1920000.0d, 0.0000909422d },
            { 1927000.0d, 0.0000876613d },
            { 1934000.0d, 0.0000844266d },
            { 1941000.0d, 0.0000812392d },
            { 1948000.0d, 0.0000780994d },
            { 1955000.0d, 0.0000750085d },
            { 1962000.0d, 0.0000719672d },
            { 1969000.0d, 0.0000689763d },
            { 1976000.0d, 0.0000660366d },
            { 1983000.0d, 0.000063149d },
            { 1990000.0d, 0.0000603143d },
            { 1997000.0d, 0.0000575334d },
            { 2004000.0d, 0.0000548071d },
            { 2011000.0d, 0.0000521362d },
            { 2018000.0d, 0.0000495216d },
            { 2025000.0d, 0.0000469641d },
            { 2032000.0d, 0.0000444647d },
            { 2039000.0d, 0.0000420239d },
            { 2046000.0d, 0.0000396429d },
            { 2053000.0d, 0.0000373224d },
            { 2060000.0d, 0.0000350632d },
            { 2067000.0d, 0.0000328662d },
            { 2074000.0d, 0.0000307322d },
            { 2081000.0d, 0.0000286622d },
            { 2088000.0d, 0.0000266568d },
            { 2095000.0d, 0.0000247171d },
            { 2102000.0d, 0.0000228438d },
            { 2109000.0d, 0.0000210377d },
            { 2116000.0d, 0.0000192999d },
            { 2123000.0d, 0.000017631d },
            { 2130000.0d, 0.0000160318d },
            { 2137000.0d, 0.0000145034d },
            { 2144000.0d, 0.0000130465d },
            { 2151000.0d, 0.000011662d },
            { 2158000.0d, 0.0000103506d },
            { 2165000.0d, 0.00000911335d },
            { 2172000.0d, 0.00000795094d },
            { 2179000.0d, 0.00000686428d },
            { 2186000.0d, 0.00000585418d },
            { 2193000.0d, 0.00000492148d },
            { 2200000.0d, 0.00000406702d },
            { 2207000.0d, 0.00000329162d },
            { 2214000.0d, 0.00000259609d },
            { 2221000.0d, 0.00000198125d },
            { 2228000.0d, 0.0000014479d },
            { 2235000.0d, 0.00000099684d },
            { 2242000.0d, 0.000000628825d },
            { 2249000.0d, 0.000000344605d },
            { 2256000.0d, 0.000000144879d },
            { 2263000.0d, 0.0000000302496d },
            { 2268900.0d, 0d },

        }; 
    }
}
    