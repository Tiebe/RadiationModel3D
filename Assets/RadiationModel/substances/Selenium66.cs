using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium66 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium66";
        public override double halfLife { get; } = 0.042d;
        public override double atomicWeight { get; } = 65.95528d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic66() } } },

        };
    }
}
    