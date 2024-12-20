using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium219";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 219.02501d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium215()), new(1.0d, new AlphaParticle(10972002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    