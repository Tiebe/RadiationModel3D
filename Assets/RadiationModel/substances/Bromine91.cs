using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine91 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine91";
        public override double halfLife { get; } = 0.543d;
        public override double atomicWeight { get; } = 90.9344d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton91() }, { 1.0d, new BetaParticle(-1, 4933500.0) } } },
            { 0.195d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton91() }, { 1.0d, new BetaParticle(-1, 4933500.0) } } },

        };
    }
}
    