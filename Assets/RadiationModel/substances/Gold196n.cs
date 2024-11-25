using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold196n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold196n";
        public override double halfLife { get; } = 34560.0d;
        public override double atomicWeight { get; } = 195.96721d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold196() }, { 2.8536e-05d, new GammaParticle(19920.0, 0.06224) }, { 0.0022533d, new GammaParticle(30710.0, 0.04037) }, { 9.570000000000001e-05d, new GammaParticle(50570.0, 0.02452) }, { 0.003045d, new GammaParticle(84660.0, 0.01464) }, { 0.013049999999999999d, new GammaParticle(137690.0, 0.009) }, { 0.435d, new GammaParticle(147810.0, 0.00839) }, { 0.0783d, new GammaParticle(168370.0, 0.00736) }, { 0.0043847999999999995d, new GammaParticle(174910.0, 0.00709) }, { 0.30015000000000003d, new GammaParticle(188270.0, 0.00659) }, { 0.013049999999999999d, new GammaParticle(264000.0, 0.0047) }, { 0.04437d, new GammaParticle(285490.0, 0.00434) }, { 0.029580000000000002d, new GammaParticle(316190.0, 0.00392) }, { 0.89d, new GammaParticle(11419.0, 0.10858) }, { 0.23783960141981594d, new GammaParticle(66991.0, 0.01851) }, { 0.4049022836564793d, new GammaParticle(68806.0, 0.01802) }, { 0.13662628123421636d, new GammaParticle(78048.0, 0.01589) }, { 0.17611127651090488d, new GammaParticle(78983.0, 0.0157) }, { 0.03948499527668853d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    