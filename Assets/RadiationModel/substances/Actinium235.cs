using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium235";
        public override double halfLife { get; } = 62.0d;
        public override double atomicWeight { get; } = 235.05084d;

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
    