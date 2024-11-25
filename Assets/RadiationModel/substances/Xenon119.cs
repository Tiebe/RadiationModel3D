using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon119 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon119";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 118.91541d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium119() }, { 1.0d, new BetaParticle(1, 4194500.0) } } },

        };
    }
}
    