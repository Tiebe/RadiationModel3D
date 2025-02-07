using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine201m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine201m";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 200.98891d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine201()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    