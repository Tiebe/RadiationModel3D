using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Aluminum32m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum32m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 31.98911d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Aluminum32()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    