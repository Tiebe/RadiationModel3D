using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium124";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 123.93031d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium124() }, { 1.0d, new BetaParticle(1, 7085000.0) } } },

        };
    }
}
    