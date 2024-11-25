using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium89";
        public override double halfLife { get; } = 0.43d;
        public override double atomicWeight { get; } = 88.93667d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine89() }, { 1.0d, new BetaParticle(-1, 4641000.0) } } },
            { 0.078d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine89() }, { 1.0d, new BetaParticle(-1, 4641000.0) } } },

        };
    }
}
    