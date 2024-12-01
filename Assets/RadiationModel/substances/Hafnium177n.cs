using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium177n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium177n";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 176.94467d;

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
    