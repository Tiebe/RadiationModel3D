using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium160";
        public override double halfLife { get; } = 9.6d;
        public override double atomicWeight { get; } = 159.93534d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium160()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    