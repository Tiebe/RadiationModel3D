using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc83 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc83";
        public override double halfLife { get; } = 0.117d;
        public override double atomicWeight { get; } = 82.96104d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium83() }, { 1.0d, new BetaParticle(-1, 6483550.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    