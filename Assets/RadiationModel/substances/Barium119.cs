using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium119";
        public override double halfLife { get; } = 5.4d;
        public override double atomicWeight { get; } = 118.93066d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon119() }, { 1.0d, new BetaParticle(1, 7102000.0) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon118() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    