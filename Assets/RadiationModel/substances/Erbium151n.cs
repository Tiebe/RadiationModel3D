using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium151n : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium151n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 150.94849d;

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
    