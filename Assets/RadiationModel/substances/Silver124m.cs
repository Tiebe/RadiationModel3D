using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver124m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver124m";
        public override double halfLife { get; } = 0.191d;
        public override double atomicWeight { get; } = 123.92895d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium124()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.013000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium124()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    