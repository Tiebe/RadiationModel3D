using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium226";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 226.04031d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    