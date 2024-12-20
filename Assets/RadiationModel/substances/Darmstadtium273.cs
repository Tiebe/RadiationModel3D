using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium273";
        public override double halfLife { get; } = 0.00019d;
        public override double atomicWeight { get; } = 273.14846d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hassium269()), new(1.0d, new AlphaParticle(12397002.09)) } },
            { 0.17d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    