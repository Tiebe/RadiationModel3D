using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum99m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum99m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 98.90781d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    