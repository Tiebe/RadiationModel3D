using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium180q : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium180q";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 179.95042d;

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
    