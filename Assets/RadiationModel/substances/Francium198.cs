using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium198 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium198";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 198.01028d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine194()), new(1.0d, new AlphaParticle(8893002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    