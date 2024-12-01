using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium199";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 199.00727d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine195()), new(1.0d, new AlphaParticle(8838002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    