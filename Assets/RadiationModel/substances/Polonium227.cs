using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium227";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 227.04539d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    