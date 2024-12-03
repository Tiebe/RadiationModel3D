using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel70m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel70m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 69.9395d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel70()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    