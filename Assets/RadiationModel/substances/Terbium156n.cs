using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium156n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium156n";
        public override double halfLife { get; } = 87840.0d;
        public override double atomicWeight { get; } = 155.92486d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium156()), new(0.741d, new GammaParticle(49630.0, 0.02498)), new(0.037902149999999996d, new GammaParticle(7118.0, 0.17418)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    