using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury174 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury174";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 173.99287d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.996d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum170()), new(1.0d, new AlphaParticle(8255002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    