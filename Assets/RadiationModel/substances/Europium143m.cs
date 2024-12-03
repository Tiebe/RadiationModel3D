using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium143m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 142.92072d;

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
    