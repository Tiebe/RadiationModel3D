using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium271";
        public override double halfLife { get; } = 0.0016d;
        public override double atomicWeight { get; } = 271.14595d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hassium267()), new(1.0d, new AlphaParticle(11887002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    