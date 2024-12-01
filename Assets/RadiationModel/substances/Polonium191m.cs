using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium191m";
        public override double halfLife { get; } = 0.093d;
        public override double atomicWeight { get; } = 190.99462d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead187()), new(1.0d, new AlphaParticle(8576002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    