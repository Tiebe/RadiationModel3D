using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium168";
        public override double halfLife { get; } = 330.0d;
        public override double atomicWeight { get; } = 167.93873d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium168() }, { 1.0d, new BetaParticle(1, 2121200.0) } } },

        };
    }
}
    