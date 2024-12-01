using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium270";
        public override double halfLife { get; } = 0.0002d;
        public override double atomicWeight { get; } = 270.14458d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hassium266()), new(1.0d, new AlphaParticle(12137002.09)) } },
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
    