using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth188 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth188";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 187.99228d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium184()), new(1.0d, new AlphaParticle(8285002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    