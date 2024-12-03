using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese60m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese60m";
        public override double halfLife { get; } = 1.77d;
        public override double atomicWeight { get; } = 59.94343d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.885d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron60()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0023d, new GammaParticle(279600.0, 0.00443)), new(0.0015d, new GammaParticle(401000.0, 0.00309)), new(0.188d, new GammaParticle(493000.0, 0.00251)), new(0.026000000000000002d, new GammaParticle(678100.0, 0.00183)), new(0.753d, new GammaParticle(823800.0, 0.00151)), new(0.0098d, new GammaParticle(957500.0, 0.00129)), new(0.022000000000000002d, new GammaParticle(1078900.0, 0.00115)), new(0.012d, new GammaParticle(1150200.0, 0.00108)), new(0.0053d, new GammaParticle(1238300.0, 0.001)), new(0.11800000000000001d, new GammaParticle(1290800.0, 0.00096)), new(0.027000000000000003d, new GammaParticle(1371400.0, 0.0009)), new(0.004d, new GammaParticle(1384000.0, 0.0009)), new(0.105d, new GammaParticle(1475800.0, 0.00084)), new(0.52d, new GammaParticle(1968800.0, 0.00063)), new(0.02d, new GammaParticle(2248000.0, 0.00055)), new(0.132d, new GammaParticle(2299700.0, 0.00054)), new(3.6067106208000003e-06d, new GammaParticle(728.0, 1.70308)), new(4.113436657554716e-05d, new GammaParticle(6391.0, 0.194)), new(8.05450686813142e-05d, new GammaParticle(6404.0, 0.1936)), new(1.6645746743138635e-05d, new GammaParticle(7082.0, 0.17507)), new(1.6645746743138635e-05d, new GammaParticle(7082.0, 0.17507)) } },
            { 0.115d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese60()), new(0.109d, new GammaParticle(271900.0, 0.00456)), new(4.4152787e-05d, new GammaParticle(660.0, 1.87855)), new(0.0005721250286011785d, new GammaParticle(5888.0, 0.21057)), new(0.001122033788196075d, new GammaParticle(5899.0, 0.21018)), new(0.00023023618320274674d, new GammaParticle(6512.0, 0.19039)), new(0.00023023618320274674d, new GammaParticle(6512.0, 0.19039)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    