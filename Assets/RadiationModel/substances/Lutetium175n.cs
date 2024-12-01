using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium175n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium175n";
        public override double halfLife { get; } = 0.00098d;
        public override double atomicWeight { get; } = 174.94227d;

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
    