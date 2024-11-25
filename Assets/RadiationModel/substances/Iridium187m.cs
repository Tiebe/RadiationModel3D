using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium187m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium187m";
        public override double halfLife { get; } = 0.0303d;
        public override double atomicWeight { get; } = 186.95774d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium187() } } },

        };
    }
}
    