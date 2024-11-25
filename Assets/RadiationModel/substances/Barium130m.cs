using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium130m";
        public override double halfLife { get; } = 0.0094d;
        public override double atomicWeight { get; } = 129.90898d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium130() }, { 0.06465499999999999d, new GammaParticle(80300.0, 0.01544) }, { 0.965d, new GammaParticle(357200.0, 0.00347) }, { 0.02895d, new GammaParticle(420300.0, 0.00295) }, { 0.02895d, new GammaParticle(452500.0, 0.00274) }, { 0.12545d, new GammaParticle(463100.0, 0.00268) }, { 0.82025d, new GammaParticle(544500.0, 0.00228) }, { 0.019299999999999998d, new GammaParticle(551100.0, 0.00225) }, { 0.06755d, new GammaParticle(652500.0, 0.0019) }, { 0.7334d, new GammaParticle(691100.0, 0.00179) }, { 0.08685000000000001d, new GammaParticle(802900.0, 0.00154) }, { 0.6369d, new GammaParticle(883000.0, 0.0014) }, { 0.009649999999999999d, new GammaParticle(908300.0, 0.00137) }, { 0.04825d, new GammaParticle(1004000.0, 0.00123) }, { 0.024125d, new GammaParticle(1111000.0, 0.00112) }, { 0.006801289166320001d, new GammaParticle(4966.0, 0.24967) }, { 0.015151972051080423d, new GammaParticle(31816.0, 0.03897) }, { 0.0279144658273405d, new GammaParticle(32193.0, 0.03851) }, { 0.008210829649823542d, new GammaParticle(36482.0, 0.03399) }, { 0.010279958721579075d, new GammaParticle(36827.0, 0.03367) }, { 0.0020691290717555324d, new GammaParticle(37255.0, 0.03328) } } },

        };
    }
}
    