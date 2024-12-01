using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt51 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt51";
        public override double halfLife { get; } = 0.0688d;
        public override double atomicWeight { get; } = 50.97065d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese51()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.038d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese50()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    