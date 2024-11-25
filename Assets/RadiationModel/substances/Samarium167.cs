using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium167";
        public override double halfLife { get; } = 0.334d;
        public override double atomicWeight { get; } = 166.96207d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium167() }, { 1.0d, new BetaParticle(-1, 4220000.0) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium167() }, { 1.0d, new BetaParticle(-1, 4220000.0) } } },

        };
    }
}
    