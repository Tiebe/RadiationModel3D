using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold171m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold171m";
        public override double halfLife { get; } = 0.00104d;
        public override double atomicWeight { get; } = 170.99215d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium167()), new(1.0d, new AlphaParticle(8361002.09)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum170()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    