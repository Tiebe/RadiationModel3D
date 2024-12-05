using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus40 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus40";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 39.99126d;

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
    