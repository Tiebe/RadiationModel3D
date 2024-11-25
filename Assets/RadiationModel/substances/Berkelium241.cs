using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium241";
        public override double halfLife { get; } = 276.0d;
        public override double atomicWeight { get; } = 241.0601d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    