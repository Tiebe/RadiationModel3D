using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium169";
        public override double halfLife { get; } = 0.353d;
        public override double atomicWeight { get; } = 168.97628d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.45d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium165()), new(1.0d, new AlphaParticle(7163002.09)) } },
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
    