using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium282";
        public override double halfLife { get; } = 66.0d;
        public override double atomicWeight { get; } = 282.16617d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hassium278()), new(1.0d, new AlphaParticle(10167002.09)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    