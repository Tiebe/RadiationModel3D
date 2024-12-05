using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium154m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 153.96778d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium154()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    