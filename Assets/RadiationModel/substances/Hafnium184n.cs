using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium184n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium184n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 183.95811d;

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
    