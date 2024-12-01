using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth207m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth207m";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 206.98073d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth207()), new(0.025750000000000002d, new GammaParticle(117900.0, 0.01052)), new(0.025750000000000002d, new GammaParticle(238000.0, 0.00521)), new(0.2369d, new GammaParticle(262200.0, 0.00473)), new(0.0103d, new GammaParticle(288000.0, 0.00431)), new(0.025750000000000002d, new GammaParticle(308600.0, 0.00402)), new(0.04325999999999999d, new GammaParticle(405000.0, 0.00306)), new(0.1442d, new GammaParticle(426100.0, 0.00291)), new(0.5047d, new GammaParticle(456100.0, 0.00272)), new(0.1648d, new GammaParticle(571000.0, 0.00217)), new(0.6386d, new GammaParticle(669500.0, 0.00185)), new(0.4017d, new GammaParticle(713500.0, 0.00174)), new(0.3811d, new GammaParticle(743300.0, 0.00167)), new(0.2987d, new GammaParticle(931800.0, 0.00133)), new(0.0721d, new GammaParticle(975600.0, 0.00127)), new(0.023690000000000003d, new GammaParticle(1240900.0, 0.001)), new(0.163d, new GammaParticle(12904.0, 0.09608)), new(0.11199999999999999d, new GammaParticle(74815.0, 0.01657)), new(0.188d, new GammaParticle(77108.0, 0.01608)), new(0.064d, new GammaParticle(87388.0, 0.01419)), new(0.084d, new GammaParticle(88458.0, 0.01402)), new(0.0197d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    