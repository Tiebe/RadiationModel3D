using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium87";
        public override double halfLife { get; } = 5.5d;
        public override double atomicWeight { get; } = 86.92869d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine87() }, { 1.0d, new BetaParticle(-1, 3732950.0) } } },
            { 0.0036d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine87() }, { 1.0d, new BetaParticle(-1, 3732950.0) } } },

        };
    }
}
    