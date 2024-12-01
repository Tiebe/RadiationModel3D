using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Roentgenium279 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium279";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 279.16288d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Meitnerium275()), new(1.0d, new AlphaParticle(11547002.09)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    