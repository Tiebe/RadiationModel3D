using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon133m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon133m";
        public override double halfLife { get; } = 189907.2d;
        public override double atomicWeight { get; } = 132.90616d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon133()), new(0.1012d, new GammaParticle(233221.0, 0.00532)), new(0.05937744032d, new GammaParticle(4540.0, 0.27309)), new(0.1124494469213099d, new GammaParticle(29458.0, 0.04209)), new(0.2083168709175804d, new GammaParticle(29778.0, 0.04164)), new(0.06039022828568751d, new GammaParticle(33726.0, 0.03676)), new(0.07464232216110978d, new GammaParticle(34030.0, 0.03643)), new(0.014252093875422254d, new GammaParticle(34414.0, 0.03603)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    