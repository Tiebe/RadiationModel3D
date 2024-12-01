using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium234";
        public override double halfLife { get; } = 44.0d;
        public override double atomicWeight { get; } = 234.04814d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium234()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    