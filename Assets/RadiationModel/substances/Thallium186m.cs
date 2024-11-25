using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium186m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium186m";
        public override double halfLife { get; } = 3.4d;
        public override double atomicWeight { get; } = 185.97868d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    