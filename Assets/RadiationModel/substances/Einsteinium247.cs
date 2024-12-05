using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium247";
        public override double halfLife { get; } = 273.0d;
        public override double atomicWeight { get; } = 247.07362d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.93d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium247()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium243()), new(1.0d, new AlphaParticle(8485002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    