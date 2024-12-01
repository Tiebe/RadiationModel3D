using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum109 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum109";
        public override double halfLife { get; } = 0.61d;
        public override double atomicWeight { get; } = 108.92844d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium109()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.011000000000000001d, new GammaParticle(32200.0, 0.0385)), new(0.0282d, new GammaParticle(43600.0, 0.02844)), new(0.0348d, new GammaParticle(65200.0, 0.01902)), new(0.044000000000000004d, new GammaParticle(69100.0, 0.01794)), new(0.036000000000000004d, new GammaParticle(90700.0, 0.01367)), new(0.051d, new GammaParticle(128700.0, 0.00963)), new(0.004d, new GammaParticle(137000.0, 0.00905)), new(0.0014000000000000002d, new GammaParticle(152100.0, 0.00815)), new(0.0040999999999999995d, new GammaParticle(165000.0, 0.00751)), new(7.6e-05d, new GammaParticle(206100.0, 0.00602)), new(0.0379d, new GammaParticle(213500.0, 0.00581)), new(0.0174d, new GammaParticle(282500.0, 0.00439)), new(0.1d, new GammaParticle(289500.0, 0.00428)), new(0.0096d, new GammaParticle(314800.0, 0.00394)), new(0.0179d, new GammaParticle(321400.0, 0.00386)), new(0.2d, new GammaParticle(333300.0, 0.00372)), new(0.012199999999999999d, new GammaParticle(354600.0, 0.0035)), new(0.055999999999999994d, new GammaParticle(358700.0, 0.00346)), new(0.011200000000000002d, new GammaParticle(386600.0, 0.00321)), new(0.06d, new GammaParticle(412000.0, 0.00301)), new(0.077d, new GammaParticle(423900.0, 0.00292)), new(0.043d, new GammaParticle(438600.0, 0.00283)), new(0.033d, new GammaParticle(471000.0, 0.00263)), new(0.0089d, new GammaParticle(652300.0, 0.0019)), new(0.042d, new GammaParticle(744600.0, 0.00167)), new(0.0202d, new GammaParticle(1332200.0, 0.00093)), new(0.0066d, new GammaParticle(1365500.0, 0.00091)), new(0.0131d, new GammaParticle(1599100.0, 0.00078)), new(0.0052d, new GammaParticle(1664200.0, 0.00075)), new(0.0415d, new GammaParticle(1689600.0, 0.00073)), new(0.0085d, new GammaParticle(2022900.0, 0.00061)), new(0.0154d, new GammaParticle(2235700.0, 0.00055)), new(0.0076480522913236005d, new GammaParticle(2586.0, 0.47944)), new(0.03568187489881028d, new GammaParticle(18250.0, 0.06794)), new(0.06784916314662535d, new GammaParticle(18367.0, 0.0675)), new(0.01803299686853572d, new GammaParticle(20695.0, 0.05991)), new(0.020882210373764365d, new GammaParticle(20820.0, 0.05955)), new(0.002849213505228644d, new GammaParticle(21003.0, 0.05903)) } },
            { 0.013000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium109()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.011000000000000001d, new GammaParticle(32200.0, 0.0385)), new(0.0282d, new GammaParticle(43600.0, 0.02844)), new(0.0348d, new GammaParticle(65200.0, 0.01902)), new(0.044000000000000004d, new GammaParticle(69100.0, 0.01794)), new(0.036000000000000004d, new GammaParticle(90700.0, 0.01367)), new(0.051d, new GammaParticle(128700.0, 0.00963)), new(0.004d, new GammaParticle(137000.0, 0.00905)), new(0.0014000000000000002d, new GammaParticle(152100.0, 0.00815)), new(0.0040999999999999995d, new GammaParticle(165000.0, 0.00751)), new(7.6e-05d, new GammaParticle(206100.0, 0.00602)), new(0.0379d, new GammaParticle(213500.0, 0.00581)), new(0.0174d, new GammaParticle(282500.0, 0.00439)), new(0.1d, new GammaParticle(289500.0, 0.00428)), new(0.0096d, new GammaParticle(314800.0, 0.00394)), new(0.0179d, new GammaParticle(321400.0, 0.00386)), new(0.2d, new GammaParticle(333300.0, 0.00372)), new(0.012199999999999999d, new GammaParticle(354600.0, 0.0035)), new(0.055999999999999994d, new GammaParticle(358700.0, 0.00346)), new(0.011200000000000002d, new GammaParticle(386600.0, 0.00321)), new(0.06d, new GammaParticle(412000.0, 0.00301)), new(0.077d, new GammaParticle(423900.0, 0.00292)), new(0.043d, new GammaParticle(438600.0, 0.00283)), new(0.033d, new GammaParticle(471000.0, 0.00263)), new(0.0089d, new GammaParticle(652300.0, 0.0019)), new(0.042d, new GammaParticle(744600.0, 0.00167)), new(0.0202d, new GammaParticle(1332200.0, 0.00093)), new(0.0066d, new GammaParticle(1365500.0, 0.00091)), new(0.0131d, new GammaParticle(1599100.0, 0.00078)), new(0.0052d, new GammaParticle(1664200.0, 0.00075)), new(0.0415d, new GammaParticle(1689600.0, 0.00073)), new(0.0085d, new GammaParticle(2022900.0, 0.00061)), new(0.0154d, new GammaParticle(2235700.0, 0.00055)), new(0.0076480522913236005d, new GammaParticle(2586.0, 0.47944)), new(0.03568187489881028d, new GammaParticle(18250.0, 0.06794)), new(0.06784916314662535d, new GammaParticle(18367.0, 0.0675)), new(0.01803299686853572d, new GammaParticle(20695.0, 0.05991)), new(0.020882210373764365d, new GammaParticle(20820.0, 0.05955)), new(0.002849213505228644d, new GammaParticle(21003.0, 0.05903)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    