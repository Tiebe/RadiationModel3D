using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium179p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium179p";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 178.94988d;

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
    