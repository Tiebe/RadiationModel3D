using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium131n : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium131n";
        public override double halfLife { get; } = 0.093d;
        public override double atomicWeight { get; } = 130.9106d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium131()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    