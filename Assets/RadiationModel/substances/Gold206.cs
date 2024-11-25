using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold206 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold206";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 205.98477d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury206() }, { 1.0d, new BetaParticle(-1, 3378000.0) } } },

        };
    }
}
    