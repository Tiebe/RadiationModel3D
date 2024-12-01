using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel48 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel48";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 48.01952d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron46()), new(1.0d, new ProtonParticle()) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron47()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    