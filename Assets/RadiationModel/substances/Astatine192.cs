using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine192 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine192";
        public override double halfLife { get; } = 0.088d;
        public override double atomicWeight { get; } = 192.00314d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth188()), new(1.0d, new AlphaParticle(8718002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    