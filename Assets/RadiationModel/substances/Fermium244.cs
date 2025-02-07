using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium244";
        public override double halfLife { get; } = 0.00312d;
        public override double atomicWeight { get; } = 244.07403d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.97d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium244()) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium240()), new(1.0d, new AlphaParticle(9568002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    