using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton97 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton97";
        public override double halfLife { get; } = 0.063d;
        public override double atomicWeight { get; } = 96.94909d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium97()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.067d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium97()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    