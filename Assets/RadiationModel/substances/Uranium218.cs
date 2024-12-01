using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium218";
        public override double halfLife { get; } = 0.00065d;
        public override double atomicWeight { get; } = 218.02351d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium214()), new(1.0d, new AlphaParticle(9797002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    