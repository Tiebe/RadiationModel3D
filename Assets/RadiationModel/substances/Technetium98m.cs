using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium98m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 97.90731d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium98()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    