using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine228 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine228";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 228.04496d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    