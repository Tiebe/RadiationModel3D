using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium245m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium245m";
        public override double halfLife { get; } = 0.33d;
        public override double atomicWeight { get; } = 245.08098d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium241()), new(1.0d, new AlphaParticle(10137002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    