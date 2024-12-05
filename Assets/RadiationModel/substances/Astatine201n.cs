using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine201n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine201n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 200.99091d;

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
    