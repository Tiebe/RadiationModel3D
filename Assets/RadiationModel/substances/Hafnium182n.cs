using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium182n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium182n";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 181.95332d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium182()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    