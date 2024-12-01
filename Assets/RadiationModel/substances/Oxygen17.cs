using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Oxygen17 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen17";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 16.99913d;

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
    