using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum165 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum165";
        public override double halfLife { get; } = 0.00026d;
        public override double atomicWeight { get; } = 164.99966d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium161()), new(1.0d, new AlphaParticle(8477002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    