using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum157n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum157n";
        public override double halfLife { get; } = 0.0017d;
        public override double atomicWeight { get; } = 156.96994d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium153()), new(1.0d, new AlphaParticle(8977002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    