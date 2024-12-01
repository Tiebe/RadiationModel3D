using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium277";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 277.15576d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hassium273()), new(1.0d, new AlphaParticle(11917002.09)) } },
            { 0.125d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    