using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium96m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium96m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 95.92093d;

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
    