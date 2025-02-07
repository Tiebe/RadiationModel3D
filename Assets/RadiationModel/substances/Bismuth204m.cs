using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth204m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth204m";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 203.9787d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth204()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    