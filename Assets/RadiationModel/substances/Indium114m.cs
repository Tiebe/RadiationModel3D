using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium114m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium114m";
        public override double halfLife { get; } = 4277664.0d;
        public override double atomicWeight { get; } = 113.90512d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9675d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium114()), new(0.15560000000000002d, new GammaParticle(190270.0, 0.00652)), new(0.041933577599999994d, new GammaParticle(3571.0, 0.3472)), new(0.07560982499533715d, new GammaParticle(24001.0, 0.05166)), new(0.14185708254284646d, new GammaParticle(24209.0, 0.05121)), new(0.03980192643850117d, new GammaParticle(27367.0, 0.0453)), new(0.047364292461816386d, new GammaParticle(27581.0, 0.04495)), new(0.007562366023315222d, new GammaParticle(27858.0, 0.04451)) } },
            { 0.0325d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver114()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.032d, new GammaParticle(558430.0, 0.00222)), new(0.032d, new GammaParticle(725240.0, 0.00171)), new(0.0019522149198559998d, new GammaParticle(3388.0, 0.36595)), new(0.0067808781077343195d, new GammaParticle(22983.0, 0.05395)), new(0.012753203136607709d, new GammaParticle(23173.0, 0.0535)), new(0.0035548061553789937d, new GammaParticle(26184.0, 0.04735)), new(0.00420178087565797d, new GammaParticle(26381.0, 0.047)), new(0.0006469747202789769d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    