using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum186m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum186m";
        public override double halfLife { get; } = 92.4d;
        public override double atomicWeight { get; } = 185.95892d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum186()) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    