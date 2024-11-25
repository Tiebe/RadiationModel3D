using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum151 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum151";
        public override double halfLife { get; } = 0.457d;
        public override double atomicWeight { get; } = 150.94277d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium151() }, { 1.0d, new BetaParticle(-1, 3957500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    