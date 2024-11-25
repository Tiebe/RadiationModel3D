using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium90";
        public override double halfLife { get; } = 0.195d;
        public override double atomicWeight { get; } = 89.9401d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine90() }, { 1.0d, new BetaParticle(-1, 4100000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    