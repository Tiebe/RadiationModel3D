using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine215 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine215";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 214.99865d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth211()), new(1.0d, new AlphaParticle(9199002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    