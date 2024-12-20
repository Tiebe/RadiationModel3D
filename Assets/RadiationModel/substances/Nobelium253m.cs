using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium253m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium253m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 253.09074d;

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
    