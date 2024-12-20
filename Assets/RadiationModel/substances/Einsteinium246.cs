using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium246";
        public override double halfLife { get; } = 450.0d;
        public override double atomicWeight { get; } = 246.07281d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9009999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium246()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.099d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium242()), new(1.0d, new AlphaParticle(8667002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    