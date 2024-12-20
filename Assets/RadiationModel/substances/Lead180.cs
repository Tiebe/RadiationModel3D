using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead180 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead180";
        public override double halfLife { get; } = 0.0041d;
        public override double atomicWeight { get; } = 179.99792d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury176()), new(1.0d, new AlphaParticle(8441002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    