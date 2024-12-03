using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium142n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium142n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 141.93998d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium142()), new(0.09359999999999999d, new GammaParticle(32200.0, 0.0385)), new(0.5544d, new GammaParticle(37200.0, 0.03333)), new(0.0216d, new GammaParticle(81500.0, 0.01521)), new(0.0216d, new GammaParticle(83700.0, 0.01481)), new(0.0216d, new GammaParticle(115800.0, 0.01071)), new(0.2736d, new GammaParticle(137700.0, 0.009)), new(0.24480000000000002d, new GammaParticle(165400.0, 0.0075)), new(0.036000000000000004d, new GammaParticle(197600.0, 0.00627)), new(0.09359999999999999d, new GammaParticle(219400.0, 0.00565)), new(0.72d, new GammaParticle(302900.0, 0.00409)), new(0.0072d, new GammaParticle(335100.0, 0.0037)), new(0.0072d, new GammaParticle(340100.0, 0.00365)), new(0.31183952257055997d, new GammaParticle(7118.0, 0.17418)), new(0.1188006624024565d, new GammaParticle(43743.0, 0.02834)), new(0.21301893921903622d, new GammaParticle(44481.0, 0.02787)), new(0.06802433612272223d, new GammaParticle(50494.0, 0.02455)), new(0.08564263917850727d, new GammaParticle(51040.0, 0.02429)), new(0.01761830305578506d, new GammaParticle(51699.0, 0.02398)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    