using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium79";
        public override double halfLife { get; } = 10319114793691.584d;
        public override double atomicWeight { get; } = 78.9185d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine79() }, { 1.0d, new BetaParticle(-1, 75315.0) } } },

        };
    }
}
    