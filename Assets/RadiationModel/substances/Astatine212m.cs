using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine212m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine212m";
        public override double halfLife { get; } = 0.121d;
        public override double atomicWeight { get; } = 211.99098d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.995d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth208()), new(1.0d, new AlphaParticle(9062002.09)) } },
            { 0.005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine212()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    