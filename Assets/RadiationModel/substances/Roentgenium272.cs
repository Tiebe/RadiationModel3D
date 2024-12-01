using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Roentgenium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium272";
        public override double halfLife { get; } = 0.0038d;
        public override double atomicWeight { get; } = 272.15327d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Meitnerium268()), new(1.0d, new AlphaParticle(12217002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    