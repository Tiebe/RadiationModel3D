using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic89 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic89";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 88.95005d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium89() }, { 1.0d, new BetaParticle(-1, 6231000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    