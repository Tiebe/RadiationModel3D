using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium157m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium157m";
        public override double halfLife { get; } = 0.076d;
        public override double atomicWeight { get; } = 156.93209d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium157()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    