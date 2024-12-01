using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium151";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 150.9554d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium151()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium150()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    