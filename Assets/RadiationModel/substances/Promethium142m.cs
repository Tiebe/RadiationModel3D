using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium142m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium142m";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 141.91384d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium142() } } },

        };
    }
}
    