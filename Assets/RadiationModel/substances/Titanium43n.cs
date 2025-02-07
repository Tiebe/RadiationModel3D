using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Titanium43n : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium43n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 42.97182d;

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
    