using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Magnesium24j : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium24j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 24.00161d;

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
    