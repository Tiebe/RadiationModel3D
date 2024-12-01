using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium254n : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium254n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 254.1022d;

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
    