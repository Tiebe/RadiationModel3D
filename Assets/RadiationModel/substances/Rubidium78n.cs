using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium78n : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium78n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 77.92826d;

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
    