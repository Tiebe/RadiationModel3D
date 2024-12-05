using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine193n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine193n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 192.99997d;

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
    