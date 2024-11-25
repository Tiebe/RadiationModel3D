using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen16m : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen16m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 16.00623d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    