using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper71m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper71m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 70.93564d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copper71()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    