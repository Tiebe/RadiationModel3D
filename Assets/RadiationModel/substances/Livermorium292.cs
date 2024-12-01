using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Livermorium292 : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium292";
        public override double halfLife { get; } = 0.0128d;
        public override double atomicWeight { get; } = 292.20197d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Flerovium288()), new(1.0d, new AlphaParticle(11807002.09)) } },
            { 0.09d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    