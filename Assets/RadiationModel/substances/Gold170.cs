using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold170 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold170";
        public override double halfLife { get; } = 0.00029d;
        public override double atomicWeight { get; } = 169.99603d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.89d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum169()), new(1.0d, new ProtonParticle()) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium166()), new(1.0d, new AlphaParticle(8207002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    