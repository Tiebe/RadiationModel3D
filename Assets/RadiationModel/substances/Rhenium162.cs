using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium162";
        public override double halfLife { get; } = 0.107d;
        public override double atomicWeight { get; } = 161.9759d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum158() }, { 1.0d, new AlphaParticle(7267002.09) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum162() }, { 1.0d, new BetaParticle(1, 8665000.0) } } },

        };
    }
}
    