using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Meitnerium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium282";
        public override double halfLife { get; } = 66.0d;
        public override double atomicWeight { get; } = 282.16689d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bohrium278()), new(1.0d, new AlphaParticle(9687002.09)) } },
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
    