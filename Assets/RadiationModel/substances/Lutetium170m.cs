using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium170m";
        public override double halfLife { get; } = 0.67d;
        public override double atomicWeight { get; } = 169.93858d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium170()), new(0.00865d, new GammaParticle(44520.0, 0.02785)), new(0.0044634d, new GammaParticle(48420.0, 0.02561)), new(0.3745605008d, new GammaParticle(8810.0, 0.14073)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    