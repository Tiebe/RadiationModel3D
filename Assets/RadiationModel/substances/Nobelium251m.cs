using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium251m";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 251.08906d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium247()), new(1.0d, new AlphaParticle(9887002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    