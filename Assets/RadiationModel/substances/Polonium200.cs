using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium200";
        public override double halfLife { get; } = 692.4d;
        public override double atomicWeight { get; } = 199.98181d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.887d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead200() }, { 1.0d, new BetaParticle(1, 4654500.0) } } },
            { 0.113d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead196() }, { 1.0d, new AlphaParticle(7003002.09) } } },

        };
    }
}
    