using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium177n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium177n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 176.95042d;

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
    