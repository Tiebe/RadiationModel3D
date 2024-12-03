using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium179m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium179m";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 178.95006d;

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
    