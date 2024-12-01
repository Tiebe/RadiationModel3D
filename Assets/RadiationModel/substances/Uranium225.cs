using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium225";
        public override double halfLife { get; } = 0.069d;
        public override double atomicWeight { get; } = 225.02939d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium221()), new(1.0d, new AlphaParticle(9029002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    