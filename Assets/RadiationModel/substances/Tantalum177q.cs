using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum177q : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum177q";
        public override double halfLife { get; } = 0.00013d;
        public override double atomicWeight { get; } = 176.94948d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    