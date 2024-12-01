using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon127m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon127m";
        public override double halfLife { get; } = 69.2d;
        public override double atomicWeight { get; } = 126.9055d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon127()), new(0.69d, new GammaParticle(124600.0, 0.00995)), new(0.3795d, new GammaParticle(172500.0, 0.00719)), new(0.07528908848999999d, new GammaParticle(4540.0, 0.27309)), new(0.147502773996212d, new GammaParticle(29458.0, 0.04209)), new(0.2732544905450389d, new GammaParticle(29778.0, 0.04164)), new(0.07921538467536335d, new GammaParticle(33726.0, 0.03676)), new(0.0979102154587491d, new GammaParticle(34030.0, 0.03643)), new(0.01869483078338575d, new GammaParticle(34414.0, 0.03603)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    