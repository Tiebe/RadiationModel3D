using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum111 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum111";
        public override double halfLife { get; } = 0.186d;
        public override double atomicWeight { get; } = 110.93565d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium111()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.12d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium111()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    