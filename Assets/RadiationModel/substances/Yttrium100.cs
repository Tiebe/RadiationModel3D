using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium100";
        public override double halfLife { get; } = 0.732d;
        public override double atomicWeight { get; } = 99.92773d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium100()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.15403d, new GammaParticle(118590.0, 0.01045)), new(0.73d, new GammaParticle(212531.0, 0.00583)), new(0.005475d, new GammaParticle(244800.0, 0.00506)), new(0.0006569999999999999d, new GammaParticle(314300.0, 0.00394)), new(0.00146d, new GammaParticle(317800.0, 0.0039)), new(0.012629d, new GammaParticle(351960.0, 0.00352)), new(0.002482d, new GammaParticle(416010.0, 0.00298)), new(0.008687d, new GammaParticle(496880.0, 0.0025)), new(0.0017519999999999999d, new GammaParticle(512600.0, 0.00242)), new(0.02044d, new GammaParticle(547370.0, 0.00227)), new(0.004964d, new GammaParticle(611600.0, 0.00203)), new(0.06862d, new GammaParticle(616670.0, 0.00201)), new(0.00803d, new GammaParticle(631840.0, 0.00196)), new(0.004234d, new GammaParticle(643430.0, 0.00193)), new(0.07738d, new GammaParticle(665980.0, 0.00186)), new(0.0438d, new GammaParticle(741990.0, 0.00167)), new(0.002847d, new GammaParticle(754540.0, 0.00164)), new(0.00657d, new GammaParticle(832640.0, 0.00149)), new(0.02336d, new GammaParticle(865050.0, 0.00143)), new(0.04015d, new GammaParticle(878540.0, 0.00141)), new(0.007227d, new GammaParticle(885180.0, 0.0014)), new(0.004526d, new GammaParticle(908090.0, 0.00137)), new(0.001387d, new GammaParticle(919300.0, 0.00135)), new(0.006935d, new GammaParticle(978370.0, 0.00127)), new(0.012410000000000001d, new GammaParticle(983590.0, 0.00126)), new(0.006059d, new GammaParticle(1038680.0, 0.00119)), new(0.06351d, new GammaParticle(1059510.0, 0.00117)), new(0.024820000000000002d, new GammaParticle(1082330.0, 0.00115)), new(0.0073d, new GammaParticle(1109100.0, 0.00112)), new(0.0073d, new GammaParticle(1110500.0, 0.00112)), new(0.0026279999999999997d, new GammaParticle(1185800.0, 0.00105)), new(0.0365d, new GammaParticle(1196080.0, 0.00104)), new(0.01533d, new GammaParticle(1228990.0, 0.00101)), new(0.001971d, new GammaParticle(1329600.0, 0.00093)), new(0.003285d, new GammaParticle(1441200.0, 0.00086)), new(0.012702d, new GammaParticle(1476530.0, 0.00084)), new(0.008176d, new GammaParticle(1551400.0, 0.0008)), new(0.01752d, new GammaParticle(1595160.0, 0.00078)), new(0.01095d, new GammaParticle(1608000.0, 0.00077)), new(0.004672d, new GammaParticle(1637000.0, 0.00076)), new(0.006059d, new GammaParticle(1670800.0, 0.00074)), new(0.006789d, new GammaParticle(1725440.0, 0.00072)), new(0.0073d, new GammaParticle(1750000.0, 0.00071)), new(0.01168d, new GammaParticle(1807900.0, 0.00069)), new(0.002117d, new GammaParticle(1814900.0, 0.00068)), new(0.01679d, new GammaParticle(1891800.0, 0.00066)), new(0.007081d, new GammaParticle(1937900.0, 0.00064)), new(0.007592d, new GammaParticle(2017000.0, 0.00061)), new(0.0031390000000000003d, new GammaParticle(2182300.0, 0.00057)), new(0.01314d, new GammaParticle(2240500.0, 0.00055)), new(0.0015329999999999999d, new GammaParticle(2375300.0, 0.00052)), new(0.009198d, new GammaParticle(2396200.0, 0.00052)), new(0.06643d, new GammaParticle(2439390.0, 0.00051)), new(0.010585d, new GammaParticle(2469600.0, 0.0005)), new(0.03431d, new GammaParticle(2480170.0, 0.0005)), new(0.06132d, new GammaParticle(2515130.0, 0.00049)), new(0.004088d, new GammaParticle(2557800.0, 0.00048)), new(0.04453d, new GammaParticle(2600950.0, 0.00048)), new(0.00803d, new GammaParticle(2633700.0, 0.00047)), new(0.002336d, new GammaParticle(2692600.0, 0.00046)), new(0.007956999999999999d, new GammaParticle(2719200.0, 0.00046)), new(0.0035039999999999997d, new GammaParticle(2728000.0, 0.00045)), new(0.002409d, new GammaParticle(2738600.0, 0.00045)), new(0.05694d, new GammaParticle(2770400.0, 0.00045)), new(0.04234d, new GammaParticle(2846200.0, 0.00044)), new(0.02701d, new GammaParticle(2932100.0, 0.00042)), new(0.0030659999999999997d, new GammaParticle(2980800.0, 0.00042)), new(0.008322000000000001d, new GammaParticle(3359200.0, 0.00037)), new(0.006351d, new GammaParticle(3571800.0, 0.00035)), new(0.004818d, new GammaParticle(3743900.0, 0.00033)), new(0.0054020000000000006d, new GammaParticle(3956800.0, 0.00031)), new(0.003796d, new GammaParticle(4075800.0, 0.0003)), new(0.001679d, new GammaParticle(4288100.0, 0.00029)), new(0.00471614271638208d, new GammaParticle(2161.0, 0.57374)), new(0.02593088052798557d, new GammaParticle(15691.0, 0.07902)), new(0.04962847947939822d, new GammaParticle(15775.0, 0.0786)), new(0.012645973167029853d, new GammaParticle(17736.0, 0.06991)), new(0.01449228524941621d, new GammaParticle(17824.0, 0.06956)), new(0.0018463120823863587d, new GammaParticle(17968.0, 0.069)) } },
            { 0.0102d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium100()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.15403d, new GammaParticle(118590.0, 0.01045)), new(0.73d, new GammaParticle(212531.0, 0.00583)), new(0.005475d, new GammaParticle(244800.0, 0.00506)), new(0.0006569999999999999d, new GammaParticle(314300.0, 0.00394)), new(0.00146d, new GammaParticle(317800.0, 0.0039)), new(0.012629d, new GammaParticle(351960.0, 0.00352)), new(0.002482d, new GammaParticle(416010.0, 0.00298)), new(0.008687d, new GammaParticle(496880.0, 0.0025)), new(0.0017519999999999999d, new GammaParticle(512600.0, 0.00242)), new(0.02044d, new GammaParticle(547370.0, 0.00227)), new(0.004964d, new GammaParticle(611600.0, 0.00203)), new(0.06862d, new GammaParticle(616670.0, 0.00201)), new(0.00803d, new GammaParticle(631840.0, 0.00196)), new(0.004234d, new GammaParticle(643430.0, 0.00193)), new(0.07738d, new GammaParticle(665980.0, 0.00186)), new(0.0438d, new GammaParticle(741990.0, 0.00167)), new(0.002847d, new GammaParticle(754540.0, 0.00164)), new(0.00657d, new GammaParticle(832640.0, 0.00149)), new(0.02336d, new GammaParticle(865050.0, 0.00143)), new(0.04015d, new GammaParticle(878540.0, 0.00141)), new(0.007227d, new GammaParticle(885180.0, 0.0014)), new(0.004526d, new GammaParticle(908090.0, 0.00137)), new(0.001387d, new GammaParticle(919300.0, 0.00135)), new(0.006935d, new GammaParticle(978370.0, 0.00127)), new(0.012410000000000001d, new GammaParticle(983590.0, 0.00126)), new(0.006059d, new GammaParticle(1038680.0, 0.00119)), new(0.06351d, new GammaParticle(1059510.0, 0.00117)), new(0.024820000000000002d, new GammaParticle(1082330.0, 0.00115)), new(0.0073d, new GammaParticle(1109100.0, 0.00112)), new(0.0073d, new GammaParticle(1110500.0, 0.00112)), new(0.0026279999999999997d, new GammaParticle(1185800.0, 0.00105)), new(0.0365d, new GammaParticle(1196080.0, 0.00104)), new(0.01533d, new GammaParticle(1228990.0, 0.00101)), new(0.001971d, new GammaParticle(1329600.0, 0.00093)), new(0.003285d, new GammaParticle(1441200.0, 0.00086)), new(0.012702d, new GammaParticle(1476530.0, 0.00084)), new(0.008176d, new GammaParticle(1551400.0, 0.0008)), new(0.01752d, new GammaParticle(1595160.0, 0.00078)), new(0.01095d, new GammaParticle(1608000.0, 0.00077)), new(0.004672d, new GammaParticle(1637000.0, 0.00076)), new(0.006059d, new GammaParticle(1670800.0, 0.00074)), new(0.006789d, new GammaParticle(1725440.0, 0.00072)), new(0.0073d, new GammaParticle(1750000.0, 0.00071)), new(0.01168d, new GammaParticle(1807900.0, 0.00069)), new(0.002117d, new GammaParticle(1814900.0, 0.00068)), new(0.01679d, new GammaParticle(1891800.0, 0.00066)), new(0.007081d, new GammaParticle(1937900.0, 0.00064)), new(0.007592d, new GammaParticle(2017000.0, 0.00061)), new(0.0031390000000000003d, new GammaParticle(2182300.0, 0.00057)), new(0.01314d, new GammaParticle(2240500.0, 0.00055)), new(0.0015329999999999999d, new GammaParticle(2375300.0, 0.00052)), new(0.009198d, new GammaParticle(2396200.0, 0.00052)), new(0.06643d, new GammaParticle(2439390.0, 0.00051)), new(0.010585d, new GammaParticle(2469600.0, 0.0005)), new(0.03431d, new GammaParticle(2480170.0, 0.0005)), new(0.06132d, new GammaParticle(2515130.0, 0.00049)), new(0.004088d, new GammaParticle(2557800.0, 0.00048)), new(0.04453d, new GammaParticle(2600950.0, 0.00048)), new(0.00803d, new GammaParticle(2633700.0, 0.00047)), new(0.002336d, new GammaParticle(2692600.0, 0.00046)), new(0.007956999999999999d, new GammaParticle(2719200.0, 0.00046)), new(0.0035039999999999997d, new GammaParticle(2728000.0, 0.00045)), new(0.002409d, new GammaParticle(2738600.0, 0.00045)), new(0.05694d, new GammaParticle(2770400.0, 0.00045)), new(0.04234d, new GammaParticle(2846200.0, 0.00044)), new(0.02701d, new GammaParticle(2932100.0, 0.00042)), new(0.0030659999999999997d, new GammaParticle(2980800.0, 0.00042)), new(0.008322000000000001d, new GammaParticle(3359200.0, 0.00037)), new(0.006351d, new GammaParticle(3571800.0, 0.00035)), new(0.004818d, new GammaParticle(3743900.0, 0.00033)), new(0.0054020000000000006d, new GammaParticle(3956800.0, 0.00031)), new(0.003796d, new GammaParticle(4075800.0, 0.0003)), new(0.001679d, new GammaParticle(4288100.0, 0.00029)), new(0.00471614271638208d, new GammaParticle(2161.0, 0.57374)), new(0.02593088052798557d, new GammaParticle(15691.0, 0.07902)), new(0.04962847947939822d, new GammaParticle(15775.0, 0.0786)), new(0.012645973167029853d, new GammaParticle(17736.0, 0.06991)), new(0.01449228524941621d, new GammaParticle(17824.0, 0.06956)), new(0.0018463120823863587d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000233083d },
            { 7000.0d, 0.0000237976d },
            { 14000.0d, 0.0000243025d },
            { 21000.0d, 0.0000248227d },
            { 28000.0d, 0.0000253603d },
            { 35000.0d, 0.0000259158d },
            { 42000.0d, 0.0000264889d },
            { 49000.0d, 0.0000270794d },
            { 56000.0d, 0.0000276867d },
            { 63000.0d, 0.0000283086d },
            { 70000.0d, 0.0000289419d },
            { 77000.0d, 0.0000295866d },
            { 84000.0d, 0.0000302411d },
            { 91000.0d, 0.0000309031d },
            { 98000.0d, 0.0000315725d },
            { 105000.0d, 0.0000322487d },
            { 115000.0d, 0.000033226d },
            { 125000.0d, 0.0000342146d },
            { 135000.0d, 0.000035214d },
            { 145000.0d, 0.0000362235d },
            { 155000.0d, 0.000037242d },
            { 165000.0d, 0.0000382695d },
            { 175000.0d, 0.0000393052d },
            { 185000.0d, 0.0000403488d },
            { 195000.0d, 0.0000413999d },
            { 205000.0d, 0.0000424583d },
            { 215000.0d, 0.0000435236d },
            { 225000.0d, 0.0000445956d },
            { 235000.0d, 0.000045674d },
            { 245000.0d, 0.0000467586d },
            { 255000.0d, 0.0000478493d },
            { 265000.0d, 0.0000489457d },
            { 275000.0d, 0.0000500477d },
            { 285000.0d, 0.0000511552d },
            { 295000.0d, 0.0000522679d },
            { 305000.0d, 0.0000533856d },
            { 315000.0d, 0.0000545082d },
            { 325000.0d, 0.0000556356d },
            { 335000.0d, 0.0000567676d },
            { 345000.0d, 0.000057904d },
            { 355000.0d, 0.0000590446d },
            { 365000.0d, 0.0000601893d },
            { 375000.0d, 0.000061338d },
            { 385000.0d, 0.0000624906d },
            { 395000.0d, 0.0000636468d },
            { 405000.0d, 0.0000648065d },
            { 415000.0d, 0.0000659696d },
            { 425000.0d, 0.000067136d },
            { 435000.0d, 0.0000683056d },
            { 445000.0d, 0.0000694781d },
            { 455000.0d, 0.0000706534d },
            { 465000.0d, 0.0000718316d },
            { 475000.0d, 0.0000730122d },
            { 485000.0d, 0.0000741954d },
            { 495000.0d, 0.0000753809d },
            { 505000.0d, 0.0000765686d },
            { 515000.0d, 0.0000777585d },
            { 525000.0d, 0.0000789503d },
            { 535000.0d, 0.0000801438d },
            { 545000.0d, 0.0000813391d },
            { 555000.0d, 0.0000825361d },
            { 565000.0d, 0.0000837346d },
            { 575000.0d, 0.0000849345d },
            { 585000.0d, 0.0000861356d },
            { 595000.0d, 0.0000873378d },
            { 605000.0d, 0.0000885411d },
            { 615000.0d, 0.0000897453d },
            { 625000.0d, 0.0000909503d },
            { 635000.0d, 0.0000921561d },
            { 645000.0d, 0.0000933625d },
            { 655000.0d, 0.0000945693d },
            { 665000.0d, 0.0000957765d },
            { 675000.0d, 0.000096984d },
            { 685000.0d, 0.0000981917d },
            { 695000.0d, 0.0000993994d },
            { 705000.0d, 0.000100607d },
            { 715000.0d, 0.000101815d },
            { 725000.0d, 0.000103022d },
            { 735000.0d, 0.000104229d },
            { 745000.0d, 0.000105436d },
            { 755000.0d, 0.000106642d },
            { 765000.0d, 0.000107847d },
            { 775000.0d, 0.000109052d },
            { 785000.0d, 0.000110256d },
            { 795000.0d, 0.000111459d },
            { 805000.0d, 0.000112661d },
            { 815000.0d, 0.000113862d },
            { 825000.0d, 0.000115062d },
            { 835000.0d, 0.000116261d },
            { 845000.0d, 0.000117459d },
            { 855000.0d, 0.000118655d },
            { 865000.0d, 0.000119849d },
            { 875000.0d, 0.000121042d },
            { 885000.0d, 0.000122233d },
            { 895000.0d, 0.000123423d },
            { 905000.0d, 0.00012461d },
            { 915000.0d, 0.000125796d },
            { 925000.0d, 0.00012698d },
            { 935000.0d, 0.000128162d },
            { 945000.0d, 0.000129341d },
            { 955000.0d, 0.000130519d },
            { 965000.0d, 0.000131694d },
            { 975000.0d, 0.000132867d },
            { 985000.0d, 0.000134037d },
            { 995000.0d, 0.000135205d },
            { 1005000.0d, 0.00013637d },
            { 1035000.0d, 0.00013985d },
            { 1065000.0d, 0.000143305d },
            { 1095000.0d, 0.000146732d },
            { 1125000.0d, 0.000150131d },
            { 1155000.0d, 0.000153499d },
            { 1185000.0d, 0.000156835d },
            { 1215000.0d, 0.000160139d },
            { 1245000.0d, 0.000163408d },
            { 1275000.0d, 0.000166641d },
            { 1305000.0d, 0.000169837d },
            { 1335000.0d, 0.000172995d },
            { 1365000.0d, 0.000176114d },
            { 1395000.0d, 0.000179193d },
            { 1425000.0d, 0.000182231d },
            { 1455000.0d, 0.000185227d },
            { 1485000.0d, 0.000188182d },
            { 1515000.0d, 0.000191093d },
            { 1545000.0d, 0.000193961d },
            { 1575000.0d, 0.000196784d },
            { 1605000.0d, 0.000199563d },
            { 1635000.0d, 0.000202298d },
            { 1665000.0d, 0.000204987d },
            { 1695000.0d, 0.00020763d },
            { 1725000.0d, 0.000210229d },
            { 1755000.0d, 0.000212781d },
            { 1785000.0d, 0.000215288d },
            { 1815000.0d, 0.00021775d },
            { 1845000.0d, 0.000220166d },
            { 1875000.0d, 0.000222536d },
            { 1905000.0d, 0.000224862d },
            { 1935000.0d, 0.000227143d },
            { 1965000.0d, 0.00022938d },
            { 1995000.0d, 0.000231573d },
            { 2025000.0d, 0.000233722d },
            { 2055000.0d, 0.000235829d },
            { 2085000.0d, 0.000237894d },
            { 2115000.0d, 0.000239917d },
            { 2145000.0d, 0.000241899d },
            { 2175000.0d, 0.000243842d },
            { 2205000.0d, 0.000245745d },
            { 2235000.0d, 0.000247608d },
            { 2265000.0d, 0.000249412d },
            { 2295000.0d, 0.000251151d },
            { 2325000.0d, 0.000252825d },
            { 2355000.0d, 0.000254433d },
            { 2385000.0d, 0.000255975d },
            { 2415000.0d, 0.00025745d },
            { 2445000.0d, 0.000258857d },
            { 2475000.0d, 0.000260197d },
            { 2505000.0d, 0.000261469d },
            { 2535000.0d, 0.000262673d },
            { 2565000.0d, 0.000263808d },
            { 2595000.0d, 0.000264874d },
            { 2625000.0d, 0.000265871d },
            { 2655000.0d, 0.000266798d },
            { 2685000.0d, 0.000267657d },
            { 2715000.0d, 0.000268445d },
            { 2745000.0d, 0.000269164d },
            { 2775000.0d, 0.000269813d },
            { 2805000.0d, 0.000270393d },
            { 2835000.0d, 0.000270902d },
            { 2865000.0d, 0.000271342d },
            { 2895000.0d, 0.000271711d },
            { 2925000.0d, 0.000272011d },
            { 2955000.0d, 0.000272242d },
            { 2985000.0d, 0.000272403d },
            { 3015000.0d, 0.000272494d },
            { 3045000.0d, 0.000272517d },
            { 3075000.0d, 0.00027247d },
            { 3105000.0d, 0.000272355d },
            { 3135000.0d, 0.000272172d },
            { 3165000.0d, 0.00027192d },
            { 3195000.0d, 0.000271601d },
            { 3225000.0d, 0.000271214d },
            { 3255000.0d, 0.00027076d },
            { 3285000.0d, 0.00027024d },
            { 3315000.0d, 0.000269653d },
            { 3345000.0d, 0.000269001d },
            { 3375000.0d, 0.000268283d },
            { 3405000.0d, 0.000267501d },
            { 3435000.0d, 0.000266655d },
            { 3465000.0d, 0.000265746d },
            { 3495000.0d, 0.000264773d },
            { 3525000.0d, 0.000263738d },
            { 3555000.0d, 0.000262642d },
            { 3585000.0d, 0.000261485d },
            { 3615000.0d, 0.000260268d },
            { 3645000.0d, 0.000258991d },
            { 3675000.0d, 0.000257656d },
            { 3705000.0d, 0.000256263d },
            { 3735000.0d, 0.000254813d },
            { 3765000.0d, 0.000253306d },
            { 3795000.0d, 0.000251745d },
            { 3825000.0d, 0.000250129d },
            { 3855000.0d, 0.00024846d },
            { 3885000.0d, 0.000246738d },
            { 3915000.0d, 0.000244965d },
            { 3945000.0d, 0.000243142d },
            { 3975000.0d, 0.000241269d },
            { 4005000.0d, 0.000239347d },
            { 4035000.0d, 0.000237379d },
            { 4065000.0d, 0.000235364d },
            { 4095000.0d, 0.000233304d },
            { 4125000.0d, 0.000231201d },
            { 4155000.0d, 0.000229055d },
            { 4185000.0d, 0.000226867d },
            { 4215000.0d, 0.00022464d },
            { 4245000.0d, 0.000222373d },
            { 4275000.0d, 0.000220069d },
            { 4305000.0d, 0.000217728d },
            { 4335000.0d, 0.000215353d },
            { 4365000.0d, 0.000212944d },
            { 4395000.0d, 0.000210502d },
            { 4425000.0d, 0.00020803d },
            { 4455000.0d, 0.000205529d },
            { 4485000.0d, 0.000202999d },
            { 4515000.0d, 0.000200444d },
            { 4545000.0d, 0.000197863d },
            { 4575000.0d, 0.000195259d },
            { 4605000.0d, 0.000192633d },
            { 4635000.0d, 0.000189987d },
            { 4665000.0d, 0.000187322d },
            { 4695000.0d, 0.000184641d },
            { 4725000.0d, 0.000181943d },
            { 4755000.0d, 0.000179233d },
            { 4785000.0d, 0.000176509d },
            { 4815000.0d, 0.000173774d },
            { 4845000.0d, 0.000171028d },
            { 4875000.0d, 0.000168274d },
            { 4905000.0d, 0.000165512d },
            { 4935000.0d, 0.000162745d },
            { 4965000.0d, 0.000159974d },
            { 4995000.0d, 0.000157202d },
            { 5025000.0d, 0.00015443d },
            { 5055000.0d, 0.00015166d },
            { 5085000.0d, 0.000148893d },
            { 5115000.0d, 0.000146132d },
            { 5145000.0d, 0.000143374d },
            { 5175000.0d, 0.000140622d },
            { 5205000.0d, 0.000137877d },
            { 5235000.0d, 0.000135142d },
            { 5265000.0d, 0.000132419d },
            { 5295000.0d, 0.000129708d },
            { 5325000.0d, 0.000127013d },
            { 5355000.0d, 0.000124334d },
            { 5385000.0d, 0.000121675d },
            { 5415000.0d, 0.000119036d },
            { 5445000.0d, 0.00011642d },
            { 5475000.0d, 0.00011383d },
            { 5505000.0d, 0.000111265d },
            { 5535000.0d, 0.000108725d },
            { 5565000.0d, 0.000106212d },
            { 5595000.0d, 0.000103729d },
            { 5625000.0d, 0.000101277d },
            { 5655000.0d, 0.0000988587d },
            { 5685000.0d, 0.0000964754d },
            { 5715000.0d, 0.0000941297d },
            { 5745000.0d, 0.0000918234d },
            { 5775000.0d, 0.0000895587d },
            { 5805000.0d, 0.0000873377d },
            { 5835000.0d, 0.0000851623d },
            { 5865000.0d, 0.0000830349d },
            { 5895000.0d, 0.0000809575d },
            { 5925000.0d, 0.0000789323d },
            { 5955000.0d, 0.0000769614d },
            { 5985000.0d, 0.0000750469d },
            { 6015000.0d, 0.0000731893d },
            { 6045000.0d, 0.0000713895d },
            { 6075000.0d, 0.00006965d },
            { 6105000.0d, 0.0000679724d },
            { 6135000.0d, 0.000066357d },
            { 6165000.0d, 0.0000647954d },
            { 6195000.0d, 0.0000632881d },
            { 6225000.0d, 0.0000618319d },
            { 6255000.0d, 0.0000604124d },
            { 6285000.0d, 0.0000590295d },
            { 6315000.0d, 0.0000576698d },
            { 6345000.0d, 0.0000563262d },
            { 6375000.0d, 0.0000549968d },
            { 6405000.0d, 0.000053677d },
            { 6435000.0d, 0.000052367d },
            { 6465000.0d, 0.0000510672d },
            { 6495000.0d, 0.0000497786d },
            { 6525000.0d, 0.0000485017d },
            { 6555000.0d, 0.0000472373d },
            { 6585000.0d, 0.0000459861d },
            { 6615000.0d, 0.0000447489d },
            { 6645000.0d, 0.0000435264d },
            { 6675000.0d, 0.0000423193d },
            { 6705000.0d, 0.0000411284d },
            { 6735000.0d, 0.0000399543d },
            { 6765000.0d, 0.0000387979d },
            { 6795000.0d, 0.0000376599d },
            { 6825000.0d, 0.0000365411d },
            { 6855000.0d, 0.0000354422d },
            { 6885000.0d, 0.0000343638d },
            { 6915000.0d, 0.0000333059d },
            { 6945000.0d, 0.0000322692d },
            { 6975000.0d, 0.0000312545d },
            { 7005000.0d, 0.0000302624d },
            { 7035000.0d, 0.0000292936d },
            { 7065000.0d, 0.000028349d },
            { 7095000.0d, 0.0000274294d },
            { 7125000.0d, 0.000026534d },
            { 7155000.0d, 0.0000256537d },
            { 7185000.0d, 0.0000247863d },
            { 7215000.0d, 0.0000239326d },
            { 7245000.0d, 0.0000230929d },
            { 7275000.0d, 0.0000222654d },
            { 7305000.0d, 0.0000214487d },
            { 7335000.0d, 0.0000206434d },
            { 7365000.0d, 0.00001985d },
            { 7395000.0d, 0.0000190688d },
            { 7425000.0d, 0.0000183002d },
            { 7455000.0d, 0.0000175448d },
            { 7485000.0d, 0.0000168029d },
            { 7515000.0d, 0.000016075d },
            { 7545000.0d, 0.0000153616d },
            { 7575000.0d, 0.0000146632d },
            { 7605000.0d, 0.0000139801d },
            { 7635000.0d, 0.0000133124d },
            { 7665000.0d, 0.0000126598d },
            { 7695000.0d, 0.0000120225d },
            { 7725000.0d, 0.0000114011d },
            { 7755000.0d, 0.0000107961d },
            { 7785000.0d, 0.0000102075d },
            { 7815000.0d, 0.00000963534d },
            { 7845000.0d, 0.0000090802d },
            { 7875000.0d, 0.00000854186d },
            { 7905000.0d, 0.00000801902d },
            { 7935000.0d, 0.00000751192d },
            { 7965000.0d, 0.00000702099d },
            { 7995000.0d, 0.00000654662d },
            { 8025000.0d, 0.00000608921d },
            { 8055000.0d, 0.00000564916d },
            { 8085000.0d, 0.00000522686d },
            { 8115000.0d, 0.00000482272d },
            { 8145000.0d, 0.00000443713d },
            { 8175000.0d, 0.00000407044d },
            { 8205000.0d, 0.00000372086d },
            { 8235000.0d, 0.00000338706d },
            { 8265000.0d, 0.00000306761d },
            { 8295000.0d, 0.00000276248d },
            { 8325000.0d, 0.00000247197d },
            { 8355000.0d, 0.0000021964d },
            { 8385000.0d, 0.00000193607d },
            { 8415000.0d, 0.0000016913d },
            { 8445000.0d, 0.00000146241d },
            { 8475000.0d, 0.00000124969d },
            { 8505000.0d, 0.00000105348d },
            { 8535000.0d, 0.000000874074d },
            { 8565000.0d, 0.000000711784d },
            { 8595000.0d, 0.000000566921d },
            { 8625000.0d, 0.000000439784d },
            { 8655000.0d, 0.000000330669d },
            { 8685000.0d, 0.000000239862d },
            { 8715000.0d, 0.000000167621d },
            { 8745000.0d, 0.000000112159d },
            { 8775000.0d, 0.0000000700308d },
            { 8805000.0d, 0.0000000413301d },
            { 8835000.0d, 0.0000000261721d },
            { 8865000.0d, 0.0000000194374d },
            { 8895000.0d, 0.0000000137202d },
            { 8925000.0d, 0.00000000897692d },
            { 8955000.0d, 0.00000000522246d },
            { 8985000.0d, 0.00000000247056d },
            { 9015000.0d, 0.000000000733583d },
            { 9045000.0d, 0.0000000000197368d },
            { 9051000.0d, 0d },

        }; 
    }
}
    