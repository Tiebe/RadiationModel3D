using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sulfur36 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur36";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 35.96708d;

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
    