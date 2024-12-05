using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine195 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine195";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 194.99627d;

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
    