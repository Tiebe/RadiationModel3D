using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium91";
        public override double halfLife { get; } = 0.27d;
        public override double atomicWeight { get; } = 90.9457d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine91() }, { 1.0d, new BetaParticle(-1, 5263500.0) } } },
            { 0.21d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine91() }, { 1.0d, new BetaParticle(-1, 5263500.0) } } },

        };
    }
}
    