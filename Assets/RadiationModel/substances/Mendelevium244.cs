using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium244";
        public override double halfLife { get; } = 0.38d;
        public override double atomicWeight { get; } = 244.08116d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium240()), new(1.0d, new AlphaParticle(9967002.09)) } },
            { 0.14d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium244()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    