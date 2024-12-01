using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Roentgenium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium286";
        public override double halfLife { get; } = 660.0d;
        public override double atomicWeight { get; } = 286.17876d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Meitnerium282()), new(1.0d, new AlphaParticle(9647002.09)) } },
            { 0.54d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    