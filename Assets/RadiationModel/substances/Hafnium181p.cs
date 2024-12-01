using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium181p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium181p";
        public override double halfLife { get; } = 0.0015d;
        public override double atomicWeight { get; } = 180.95098d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium181()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    