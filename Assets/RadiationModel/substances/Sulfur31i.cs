using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sulfur31i : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur31i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 30.9863d;

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
    