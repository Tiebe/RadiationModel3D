using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium260";
        public override double halfLife { get; } = 0.106d;
        public override double atomicWeight { get; } = 260.10264d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    