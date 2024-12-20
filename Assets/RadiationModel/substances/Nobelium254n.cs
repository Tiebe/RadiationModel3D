using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium254n : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium254n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 254.09441d;

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
    