using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Oganesson294 : RadioactiveSubstance
    {
        public override string name { get; } = "Oganesson294";
        public override double halfLife { get; } = 0.00058d;
        public override double atomicWeight { get; } = 294.21398d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Livermorium290()), new(1.0d, new AlphaParticle(12887002.09)) } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    