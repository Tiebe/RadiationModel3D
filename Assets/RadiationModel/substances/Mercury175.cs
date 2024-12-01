using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury175 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury175";
        public override double halfLife { get; } = 0.0106d;
        public override double atomicWeight { get; } = 174.99144d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum171()), new(1.0d, new AlphaParticle(8097002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    