using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium98p : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium98p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 97.92293d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium98() } } },

        };
    }
}
    