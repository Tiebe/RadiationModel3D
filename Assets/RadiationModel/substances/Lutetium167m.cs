using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium167m";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 166.93829d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    