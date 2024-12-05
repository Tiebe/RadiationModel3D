using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese49i : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese49i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 48.96478d;

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
    