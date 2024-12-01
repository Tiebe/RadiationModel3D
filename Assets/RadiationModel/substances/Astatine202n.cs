using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine202n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine202n";
        public override double halfLife { get; } = 0.46d;
        public override double atomicWeight { get; } = 201.98925d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine202()) } },
            { 0.00096d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth198()), new(1.0d, new AlphaParticle(7961002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    