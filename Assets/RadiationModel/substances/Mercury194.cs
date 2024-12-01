using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury194 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury194";
        public override double halfLife { get; } = 14105945910.64262d;
        public override double atomicWeight { get; } = 193.96545d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold194()), new(0.235298d, new GammaParticle(11419.0, 0.10858)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    