using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium132n : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium132n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 131.91061d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium132()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    