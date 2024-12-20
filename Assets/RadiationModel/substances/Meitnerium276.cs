using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Meitnerium276 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium276";
        public override double halfLife { get; } = 0.69d;
        public override double atomicWeight { get; } = 276.1517d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bohrium272()), new(1.0d, new AlphaParticle(11117002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    