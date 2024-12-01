using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium223";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 223.04584d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium219()), new(1.0d, new AlphaParticle(11857002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    