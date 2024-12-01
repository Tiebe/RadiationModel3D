using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium176p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium176p";
        public override double halfLife { get; } = 0.0004d;
        public override double atomicWeight { get; } = 175.94449d;

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
    