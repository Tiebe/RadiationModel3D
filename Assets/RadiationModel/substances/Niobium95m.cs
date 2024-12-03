using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium95m";
        public override double halfLife { get; } = 311904.0d;
        public override double atomicWeight { get; } = 94.90708d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9440000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium95()), new(0.248d, new GammaParticle(235690.0, 0.00526)), new(0.02510153584d, new GammaParticle(2299.0, 0.5393)), new(0.1263733141906527d, new GammaParticle(16521.0, 0.07505)), new(0.24135468714792338d, new GammaParticle(16615.0, 0.07462)), new(0.06244980753167297d, new GammaParticle(18694.0, 0.06632)), new(0.07181727866142391d, new GammaParticle(18795.0, 0.06597)), new(0.009367471129750945d, new GammaParticle(18951.0, 0.06542)) } },
            { 0.055999999999999994d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum95()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.009553d, new GammaParticle(204116.1, 0.00607)), new(2.33e-10d, new GammaParticle(218640.0, 0.00567)), new(4.66e-09d, new GammaParticle(253070.0, 0.0049)), new(0.00019805d, new GammaParticle(582077.5, 0.00213)), new(3.961e-07d, new GammaParticle(616507.0, 0.00201)), new(5.592e-05d, new GammaParticle(786192.2, 0.00158)), new(1.4213e-06d, new GammaParticle(820622.0, 0.00151)), new(2.33e-07d, new GammaParticle(835146.0, 0.00148)), new(2.33e-08d, new GammaParticle(1039260.0, 0.00119)), new(1.892716793553e-05d, new GammaParticle(2440.0, 0.50813)), new(9.44569402281335e-05d, new GammaParticle(17374.0, 0.07136)), new(0.00018002085044431767d, new GammaParticle(17479.0, 0.07093)), new(4.723681908799722e-05d, new GammaParticle(19681.0, 0.063)), new(5.45112892275488e-05d, new GammaParticle(19794.0, 0.06264)), new(7.274470139551572e-06d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    