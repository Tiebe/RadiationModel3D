using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium167m";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 166.93829d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    