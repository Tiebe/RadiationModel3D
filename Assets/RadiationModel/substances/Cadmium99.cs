using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium99";
        public override double halfLife { get; } = 16.0d;
        public override double atomicWeight { get; } = 98.92493d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium99()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0017000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium98()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },
            { 1e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver99()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    