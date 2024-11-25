using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium158m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium158m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 157.9367d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    