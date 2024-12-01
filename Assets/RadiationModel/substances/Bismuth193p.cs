using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth193p : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth193p";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 192.98547d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth193()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    