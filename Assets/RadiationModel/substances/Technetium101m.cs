using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium101m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium101m";
        public override double halfLife { get; } = 0.00064d;
        public override double atomicWeight { get; } = 100.90753d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium101()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    