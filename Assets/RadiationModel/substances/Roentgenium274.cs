using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Roentgenium274 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium274";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 274.15525d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Meitnerium270()), new(1.0d, new AlphaParticle(12497002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    