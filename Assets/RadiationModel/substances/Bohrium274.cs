using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium274 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium274";
        public override double halfLife { get; } = 44.0d;
        public override double atomicWeight { get; } = 274.1436d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dubnium270()), new(1.0d, new AlphaParticle(9957002.09)) } },
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
    