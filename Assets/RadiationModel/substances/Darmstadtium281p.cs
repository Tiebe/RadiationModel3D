using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium281p : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium281p";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 281.16462d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.94d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hassium277()), new(1.0d, new AlphaParticle(10557002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    