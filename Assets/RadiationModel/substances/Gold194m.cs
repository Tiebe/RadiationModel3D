using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold194m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold194m";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 193.96553d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold194()), new(0.00013299999999999998d, new GammaParticle(26900.0, 0.04609)), new(0.023d, new GammaParticle(35220.0, 0.0352)), new(0.055999999999999994d, new GammaParticle(45290.0, 0.02738)), new(0.7451675d, new GammaParticle(11419.0, 0.10858)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    