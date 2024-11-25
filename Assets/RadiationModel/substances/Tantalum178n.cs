using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum178n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum178n";
        public override double halfLife { get; } = 0.058d;
        public override double atomicWeight { get; } = 177.94726d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum178() } } },

        };
    }
}
    