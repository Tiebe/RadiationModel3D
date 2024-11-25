using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium50m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium50m";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 49.95246d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium50() }, { 0.963d, new GammaParticle(256894.0, 0.00483) }, { 0.000139952243016d, new GammaParticle(422.0, 2.93801) }, { 0.0018005997657528617d, new GammaParticle(4086.0, 0.30344) }, { 0.00355217945502636d, new GammaParticle(4091.0, 0.30307) }, { 0.0007060315792207793d, new GammaParticle(4474.0, 0.27712) }, { 0.0007060315792207793d, new GammaParticle(4474.0, 0.27712) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium50() }, { 1.0d, new BetaParticle(-1, 3575835.0) } } },

        };
    }
}
    