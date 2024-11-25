using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium157m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium157m";
        public override double halfLife { get; } = 4.79d;
        public override double atomicWeight { get; } = 156.95017d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium157() }, { 1.0d, new BetaParticle(1, 6145000.0) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium153() }, { 1.0d, new AlphaParticle(6151002.09) } } },

        };
    }
}
    