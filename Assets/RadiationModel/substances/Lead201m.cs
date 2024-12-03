using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead201m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead201m";
        public override double halfLife { get; } = 60.8d;
        public override double atomicWeight { get; } = 200.97355d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead201()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    