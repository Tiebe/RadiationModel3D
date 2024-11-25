using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium241";
        public override double halfLife { get; } = 834.0d;
        public override double atomicWeight { get; } = 241.05831d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium241() }, { 1.0d, new BetaParticle(-1, 682450.0) }, { 0.001d, new GammaParticle(42000.0, 0.02952) }, { 0.0002d, new GammaParticle(53810.0, 0.02304) }, { 0.0004d, new GammaParticle(79260.0, 0.01564) }, { 3e-05d, new GammaParticle(95790.0, 0.01294) }, { 0.0086d, new GammaParticle(133100.0, 0.00932) }, { 0.0007000000000000001d, new GammaParticle(161600.0, 0.00767) }, { 0.031d, new GammaParticle(175100.0, 0.00708) }, { 0.0007000000000000001d, new GammaParticle(308800.0, 0.00402) }, { 0.0019d, new GammaParticle(362400.0, 0.00342) }, { 0.00064d, new GammaParticle(465650.0, 0.00266) }, { 0.001d, new GammaParticle(476600.0, 0.0026) }, { 0.0031d, new GammaParticle(518810.0, 0.00239) }, { 0.0012d, new GammaParticle(519430.0, 0.00239) }, { 0.0008d, new GammaParticle(561100.0, 0.00221) }, { 0.0011d, new GammaParticle(834600.0, 0.00149) }, { 0.0008d, new GammaParticle(929700.0, 0.00133) }, { 0.15271207812812d, new GammaParticle(17604.0, 0.07043) }, { 0.0583176101927029d, new GammaParticle(99533.0, 0.01246) }, { 0.09231852175510986d, new GammaParticle(103741.0, 0.01195) }, { 0.03388474237578862d, new GammaParticle(117130.0, 0.01059) }, { 0.04564274798018727d, new GammaParticle(118619.0, 0.01045) }, { 0.011758005604398651d, new GammaParticle(120544.0, 0.01029) } } },

        };
    }
}
    