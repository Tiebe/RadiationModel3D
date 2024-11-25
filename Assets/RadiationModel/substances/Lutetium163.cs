using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium163";
        public override double halfLife { get; } = 238.2d;
        public override double atomicWeight { get; } = 162.94118d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium163() }, { 1.0d, new BetaParticle(1, 3968500.0) } } },

        };
    }
}
    