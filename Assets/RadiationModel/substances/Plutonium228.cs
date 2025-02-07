using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium228";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 228.03876d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium224()), new(1.0d, new AlphaParticle(8962002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    