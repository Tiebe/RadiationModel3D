using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth189 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth189";
        public override double halfLife { get; } = 0.688d;
        public override double atomicWeight { get; } = 188.98919d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium185()), new(1.0d, new AlphaParticle(8290002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    