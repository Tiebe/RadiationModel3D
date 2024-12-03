using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine194m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine194m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 193.99921d;

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
    