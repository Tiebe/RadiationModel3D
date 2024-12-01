using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium260";
        public override double halfLife { get; } = 2747520.0d;
        public override double atomicWeight { get; } = 260.10365d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.42d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium256()), new(1.0d, new AlphaParticle(7957002.09)) } },
            { 0.23d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    