using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium211m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium211m";
        public override double halfLife { get; } = 25.2d;
        public override double atomicWeight { get; } = 210.98822d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99984d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead207()), new(1.0d, new AlphaParticle(10079002.09)), new(0.0165d, new GammaParticle(897780.0, 0.00138)) } },
            { 0.00016d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium211()), new(2.5e-11d, new GammaParticle(34000.0, 0.03647)), new(0.00016d, new GammaParticle(363000.0, 0.00342)), new(6.7e-06d, new GammaParticle(377600.0, 0.00328)), new(1.1999999999999999e-05d, new GammaParticle(687100.0, 0.0018)), new(0.00015d, new GammaParticle(1064900.0, 0.00116)), new(3.8595763375e-06d, new GammaParticle(13292.0, 0.09328)), new(2.6342796633608546e-06d, new GammaParticle(76862.0, 0.01613)), new(4.386810430242889e-06d, new GammaParticle(79290.0, 0.01564)), new(1.5102573656722013e-06d, new GammaParticle(89837.0, 0.0138)), new(1.9799474063962557e-06d, new GammaParticle(90941.0, 0.01363)), new(4.696900407240546e-07d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    