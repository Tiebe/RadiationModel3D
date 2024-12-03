using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium177n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177n";
        public override double halfLife { get; } = 0.00015d;
        public override double atomicWeight { get; } = 176.94438d;

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
    