using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium160";
        public override double halfLife { get; } = 0.00061d;
        public override double atomicWeight { get; } = 159.98188d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.89d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten159()), new(1.0d, new ProtonParticle()) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum156()), new(1.0d, new AlphaParticle(7717002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    