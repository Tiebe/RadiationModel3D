using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium185n : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium185n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 184.95434d;

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
    