using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum180n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum180n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 179.94903d;

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
    