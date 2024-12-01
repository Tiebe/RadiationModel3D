using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony114m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony114m";
        public override double halfLife { get; } = 0.00022d;
        public override double atomicWeight { get; } = 113.90982d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony114()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    