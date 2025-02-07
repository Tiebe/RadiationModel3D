using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium263p : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium263p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 263.11279d;

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
    