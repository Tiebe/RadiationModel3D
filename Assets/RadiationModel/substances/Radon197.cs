using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon197 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon197";
        public override double halfLife { get; } = 0.065d;
        public override double atomicWeight { get; } = 197.00162d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium193()), new(1.0d, new AlphaParticle(8432002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    