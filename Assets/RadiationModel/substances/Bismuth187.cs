using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth187 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth187";
        public override double halfLife { get; } = 0.037d;
        public override double atomicWeight { get; } = 186.99315d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium183()), new(1.0d, new AlphaParticle(8801002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    