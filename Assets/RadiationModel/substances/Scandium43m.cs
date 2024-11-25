using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium43m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium43m";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 42.96131d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium43() } } },

        };
    }
}
    