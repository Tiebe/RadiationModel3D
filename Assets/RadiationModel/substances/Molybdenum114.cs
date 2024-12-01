using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum114 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum114";
        public override double halfLife { get; } = 0.058d;
        public override double atomicWeight { get; } = 113.94667d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium114()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    