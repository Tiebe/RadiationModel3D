using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium26m : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium26m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 25.99272d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium26() } } },

        };
    }
}
    