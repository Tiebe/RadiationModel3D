using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon14 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon14";
        public override double halfLife { get; } = 179874478055.1744d;
        public override double atomicWeight { get; } = 14.00324d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen14() }, { 1.0d, new BetaParticle(-1, 78238.1) } } },

        };
    }
}
    