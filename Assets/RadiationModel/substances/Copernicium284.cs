using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copernicium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium284";
        public override double halfLife { get; } = 0.108d;
        public override double atomicWeight { get; } = 284.17437d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.03d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Darmstadtium280()), new(1.0d, new AlphaParticle(10697002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    