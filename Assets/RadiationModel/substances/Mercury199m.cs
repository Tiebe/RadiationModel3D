using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury199m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury199m";
        public override double halfLife { get; } = 2560.2d;
        public override double atomicWeight { get; } = 198.96885d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury199()), new(1.22e-07d, new GammaParticle(118600.0, 0.01045)), new(0.523d, new GammaParticle(158300.0, 0.00783)), new(2.6150000000000002e-05d, new GammaParticle(255000.0, 0.00486)), new(0.137549d, new GammaParticle(374100.0, 0.00331)), new(0.00027196d, new GammaParticle(413400.0, 0.003)), new(0.3664939153879743d, new GammaParticle(11777.0, 0.10528)), new(0.17990190170628226d, new GammaParticle(68894.0, 0.018)), new(0.30497016732714405d, new GammaParticle(70820.0, 0.01751)), new(0.10349937436444367d, new GammaParticle(80316.0, 0.01544)), new(0.13382469105322564d, new GammaParticle(81285.0, 0.01525)), new(0.030325316688781995d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    