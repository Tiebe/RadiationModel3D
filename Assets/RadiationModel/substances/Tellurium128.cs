using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium128";
        public override double halfLife { get; } = 2.429883300043584e+32d;
        public override double atomicWeight { get; } = 127.90446d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon128()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    