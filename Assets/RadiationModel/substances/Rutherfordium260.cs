using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium260";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 260.10644d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    