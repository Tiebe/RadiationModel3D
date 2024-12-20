using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium223";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 223.03291d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium219()), new(1.0d, new AlphaParticle(10677002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    