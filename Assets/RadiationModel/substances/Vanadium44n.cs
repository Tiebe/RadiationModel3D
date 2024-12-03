using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium44n : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium44n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 43.9746d;

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
    