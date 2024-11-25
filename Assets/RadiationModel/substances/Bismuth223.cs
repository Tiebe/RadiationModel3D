using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth223 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth223";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 223.03461d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    