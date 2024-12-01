using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium246m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium246m";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 246.08177d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium242()), new(1.0d, new AlphaParticle(9967002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    