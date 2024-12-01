using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead181 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead181";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 180.99666d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury177()), new(1.0d, new AlphaParticle(8267002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    