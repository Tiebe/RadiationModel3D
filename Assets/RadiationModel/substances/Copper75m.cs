using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper75m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper75m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 74.94159d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copper75()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    