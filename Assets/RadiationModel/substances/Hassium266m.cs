using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium266m : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium266m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 266.13123d;

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
    