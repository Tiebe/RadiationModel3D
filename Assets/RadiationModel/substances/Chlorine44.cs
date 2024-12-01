using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chlorine44 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine44";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 43.97801d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Argon44()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.08d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Argon44()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    