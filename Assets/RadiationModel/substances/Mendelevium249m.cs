using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium249m";
        public override double halfLife { get; } = 24.8d;
        public override double atomicWeight { get; } = 249.08296d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.75d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium245()), new(1.0d, new AlphaParticle(9557002.09)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium249()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    