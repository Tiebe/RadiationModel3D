using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium132";
        public override double halfLife { get; } = 9.4670777923776e+28d;
        public override double atomicWeight { get; } = 131.90506d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    