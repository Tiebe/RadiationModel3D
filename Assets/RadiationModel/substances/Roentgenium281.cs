using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Roentgenium281 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium281";
        public override double halfLife { get; } = 15.0d;
        public override double atomicWeight { get; } = 281.16675d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.82d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.18d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Meitnerium277()), new(1.0d, new AlphaParticle(10917002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    