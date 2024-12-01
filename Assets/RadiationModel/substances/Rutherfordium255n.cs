using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium255n : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium255n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 255.10239d;

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
    