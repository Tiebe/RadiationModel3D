using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine203m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine203m";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 202.98768d;

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
    