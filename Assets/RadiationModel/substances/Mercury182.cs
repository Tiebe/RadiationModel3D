using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury182 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury182";
        public override double halfLife { get; } = 10.83d;
        public override double atomicWeight { get; } = 181.97469d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.862d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum182() }, { 1.0d, new BetaParticle(1, 6295500.0) }, { 0.0015d, new GammaParticle(25600.0, 0.04843) }, { 0.0111d, new GammaParticle(30500.0, 0.04065) }, { 0.0012d, new GammaParticle(37800.0, 0.0328) }, { 0.0105d, new GammaParticle(51900.0, 0.02389) }, { 0.0042d, new GammaParticle(61000.0, 0.02033) }, { 0.018000000000000002d, new GammaParticle(62900.0, 0.01971) }, { 0.01d, new GammaParticle(64100.0, 0.01934) }, { 0.0126d, new GammaParticle(98900.0, 0.01254) }, { 0.069d, new GammaParticle(103900.0, 0.01193) }, { 0.0036d, new GammaParticle(127000.0, 0.00976) }, { 0.3d, new GammaParticle(129500.0, 0.00957) }, { 0.02d, new GammaParticle(144000.0, 0.00861) }, { 0.0197d, new GammaParticle(173100.0, 0.00716) }, { 0.009300000000000001d, new GammaParticle(179500.0, 0.00691) }, { 0.0021d, new GammaParticle(180300.0, 0.00688) }, { 0.02d, new GammaParticle(182000.0, 0.00681) }, { 0.013500000000000002d, new GammaParticle(195900.0, 0.00633) }, { 0.003d, new GammaParticle(203700.0, 0.00609) }, { 0.017d, new GammaParticle(212300.0, 0.00584) }, { 0.185d, new GammaParticle(217600.0, 0.0057) }, { 0.0236d, new GammaParticle(233200.0, 0.00532) }, { 0.035d, new GammaParticle(235700.0, 0.00526) }, { 0.0039000000000000003d, new GammaParticle(240400.0, 0.00516) }, { 0.0182d, new GammaParticle(248000.0, 0.005) }, { 0.0245d, new GammaParticle(269500.0, 0.0046) }, { 0.047d, new GammaParticle(273500.0, 0.00453) }, { 0.025699999999999997d, new GammaParticle(339300.0, 0.00365) }, { 0.0254d, new GammaParticle(362700.0, 0.00342) }, { 0.156d, new GammaParticle(413500.0, 0.003) }, { 0.0212d, new GammaParticle(442300.0, 0.0028) }, { 0.03d, new GammaParticle(480000.0, 0.00258) }, { 0.0191d, new GammaParticle(543000.0, 0.00228) }, { 0.62d, new GammaParticle(511000.0, 0.00243) }, { 0.39d, new GammaParticle(11419.0, 0.10858) }, { 0.231d, new GammaParticle(66991.0, 0.01851) }, { 0.39299999999999996d, new GammaParticle(68806.0, 0.01802) }, { 0.133d, new GammaParticle(78048.0, 0.01589) }, { 0.171d, new GammaParticle(78983.0, 0.0157) }, { 0.0384d, new GammaParticle(80133.0, 0.01547) } } },
            { 0.138d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum178() }, { 1.0d, new AlphaParticle(7017002.09) } } },

        };
    }
}
    