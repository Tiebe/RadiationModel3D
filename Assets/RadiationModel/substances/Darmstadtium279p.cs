using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium279p : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium279p";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 279.16023d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.33299999999999996d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hassium275()), new(1.0d, new AlphaParticle(11357002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    