using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine194 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine194";
        public override double halfLife { get; } = 0.286d;
        public override double atomicWeight { get; } = 193.99923d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth190()), new(1.0d, new AlphaParticle(8477002.09)) } },
            { 0.008d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    