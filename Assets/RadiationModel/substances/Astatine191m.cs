using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine191m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine191m";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 191.00421d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth187()), new(1.0d, new AlphaParticle(8902002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    