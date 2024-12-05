using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten186n : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten186n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 185.95817d;

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
    