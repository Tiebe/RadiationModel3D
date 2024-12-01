using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus31 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus31";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 30.97376d;

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
    