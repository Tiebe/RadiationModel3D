using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon213 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon213";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 212.99389d;

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
    