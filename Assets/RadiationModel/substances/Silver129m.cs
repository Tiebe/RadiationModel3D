using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver129m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver129m";
        public override double halfLife { get; } = 0.046d;
        public override double atomicWeight { get; } = 128.94434d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium129()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium129()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    