using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese47 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese47";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 46.97577d;

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
    