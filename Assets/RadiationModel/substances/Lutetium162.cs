using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium162";
        public override double halfLife { get; } = 82.2d;
        public override double atomicWeight { get; } = 161.94328d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium162() }, { 1.0d, new BetaParticle(1, 4323500.0) } } },

        };
    }
}
    