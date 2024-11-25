using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium241";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 241.06859d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    