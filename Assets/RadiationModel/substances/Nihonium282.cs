using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nihonium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium282";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 282.17577d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Roentgenium278()), new(1.0d, new AlphaParticle(11807002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    