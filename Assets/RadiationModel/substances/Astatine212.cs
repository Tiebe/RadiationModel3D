using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine212 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine212";
        public override double halfLife { get; } = 0.314d;
        public override double atomicWeight { get; } = 211.99074d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth208()), new(1.0d, new AlphaParticle(8839102.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    