using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum136m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum136m";
        public override double halfLife { get; } = 0.114d;
        public override double atomicWeight { get; } = 135.90791d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum136() } } },

        };
    }
}
    