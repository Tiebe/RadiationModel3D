using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium103m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium103m";
        public override double halfLife { get; } = 0.00169d;
        public override double atomicWeight { get; } = 102.90657d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium103()), new(0.0030849d, new GammaParticle(2700.0, 0.4592)), new(0.0011283999999999999d, new GammaParticle(24000.0, 0.05166)), new(0.91d, new GammaParticle(210700.0, 0.00588)), new(0.05096d, new GammaParticle(213400.0, 0.00581)), new(0.042034433532d, new GammaParticle(2737.0, 0.45299)), new(0.16394574310074397d, new GammaParticle(19150.0, 0.06474)), new(0.3110924916522656d, new GammaParticle(19279.0, 0.06431)), new(0.0836018235860503d, new GammaParticle(21736.0, 0.05704)), new(0.09714531900699046d, new GammaParticle(21875.0, 0.05668)), new(0.013543495420940148d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    