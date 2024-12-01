using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium254";
        public override double halfLife { get; } = 600.0d;
        public override double atomicWeight { get; } = 254.08959d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium254()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    