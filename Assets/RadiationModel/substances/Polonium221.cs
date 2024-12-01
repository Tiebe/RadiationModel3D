using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium221";
        public override double halfLife { get; } = 112.0d;
        public override double atomicWeight { get; } = 221.02123d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine221()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    