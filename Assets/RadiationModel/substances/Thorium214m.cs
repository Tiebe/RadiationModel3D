using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium214m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium214m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 214.01382d;

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
    