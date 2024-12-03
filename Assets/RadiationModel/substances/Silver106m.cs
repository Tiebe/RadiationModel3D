using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver106m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver106m";
        public override double halfLife { get; } = 715392.0d;
        public override double atomicWeight { get; } = 105.90676d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium106()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0051743d, new GammaParticle(69000.0, 0.01797)), new(0.0091208d, new GammaParticle(70300.0, 0.01764)), new(0.0034203d, new GammaParticle(80100.0, 0.01548)), new(0.0007893d, new GammaParticle(83200.0, 0.0149)), new(0.0005262d, new GammaParticle(178200.0, 0.00696)), new(0.0030695d, new GammaParticle(195050.0, 0.00636)), new(0.065775d, new GammaParticle(221701.0, 0.00559)), new(0.021048d, new GammaParticle(228633.0, 0.00542)), new(0.011401d, new GammaParticle(328463.0, 0.00377)), new(0.002631d, new GammaParticle(374460.0, 0.00331)), new(0.036834d, new GammaParticle(391035.0, 0.00317)), new(0.134181d, new GammaParticle(406182.0, 0.00305)), new(0.0033326d, new GammaParticle(418550.0, 0.00296)), new(0.13155d, new GammaParticle(429646.0, 0.00289)), new(0.000877d, new GammaParticle(433900.0, 0.00286)), new(0.282394d, new GammaParticle(450976.0, 0.00275)), new(0.0092962d, new GammaParticle(474060.0, 0.00262)), new(0.877d, new GammaParticle(511850.0, 0.00242)), new(0.000877d, new GammaParticle(522300.0, 0.00237)), new(0.004385d, new GammaParticle(585970.0, 0.00212)), new(0.0161368d, new GammaParticle(601170.0, 0.00206)), new(0.21574200000000002d, new GammaParticle(616170.0, 0.00201)), new(0.014558199999999999d, new GammaParticle(646030.0, 0.00192)), new(0.006402099999999999d, new GammaParticle(679640.0, 0.00182)), new(0.0154352d, new GammaParticle(680420.0, 0.00182)), new(0.044726999999999996d, new GammaParticle(703110.0, 0.00176)), new(0.28941d, new GammaParticle(717340.0, 0.00173)), new(0.206095d, new GammaParticle(748360.0, 0.00166)), new(0.058759d, new GammaParticle(793170.0, 0.00156)), new(0.123657d, new GammaParticle(804280.0, 0.00154)), new(0.040342d, new GammaParticle(808360.0, 0.00153)), new(0.153475d, new GammaParticle(824690.0, 0.0015)), new(0.028064d, new GammaParticle(847030.0, 0.00146)), new(0.015786d, new GammaParticle(847270.0, 0.00146)), new(0.0033326d, new GammaParticle(874810.0, 0.00142)), new(0.0019294d, new GammaParticle(949520.0, 0.00131)), new(0.0047358d, new GammaParticle(956220.0, 0.0013)), new(3.5079999999999996e-05d, new GammaParticle(986800.0, 0.00126)), new(0.0104363d, new GammaParticle(1019720.0, 0.00122)), new(0.295549d, new GammaParticle(1045830.0, 0.00119)), new(0.002631d, new GammaParticle(1050600.0, 0.00118)), new(0.009647d, new GammaParticle(1053770.0, 0.00118)), new(0.0005262d, new GammaParticle(1077200.0, 0.00115)), new(0.0057005d, new GammaParticle(1121590.0, 0.00111)), new(0.117518d, new GammaParticle(1128020.0, 0.0011)), new(0.0022802d, new GammaParticle(1136850.0, 0.00109)), new(0.0009647d, new GammaParticle(1168250.0, 0.00106)), new(0.0011401d, new GammaParticle(1178070.0, 0.00105)), new(0.112256d, new GammaParticle(1199390.0, 0.00103)), new(0.07016d, new GammaParticle(1222880.0, 0.00101)), new(0.0012278d, new GammaParticle(1349500.0, 0.00092)), new(0.014908999999999999d, new GammaParticle(1394350.0, 0.00089)), new(0.0003508d, new GammaParticle(1419400.0, 0.00087)), new(0.16312200000000002d, new GammaParticle(1527650.0, 0.00081)), new(0.0048235d, new GammaParticle(1565400.0, 0.00079)), new(0.065775d, new GammaParticle(1572350.0, 0.00079)), new(0.00035957000000000003d, new GammaParticle(1690200.0, 0.00073)), new(0.014032d, new GammaParticle(1722760.0, 0.00072)), new(0.00040342000000000004d, new GammaParticle(1771100.0, 0.0007)), new(0.00037711d, new GammaParticle(1794000.0, 0.00069)), new(0.020171d, new GammaParticle(1839050.0, 0.00067)), new(0.00013155d, new GammaParticle(1909100.0, 0.00065)), new(2.1925e-05d, new GammaParticle(2077300.0, 0.0006)), new(0.00022802d, new GammaParticle(2084000.0, 0.00059)), new(0.05240159481485665d, new GammaParticle(3053.0, 0.40611)), new(0.20457993407635156d, new GammaParticle(21020.0, 0.05898)), new(0.38651036099820807d, new GammaParticle(21177.0, 0.05855)), new(0.1060426093471368d, new GammaParticle(23904.0, 0.05187)), new(0.12406985293615007d, new GammaParticle(24070.0, 0.05151)), new(0.018027243589013257d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    