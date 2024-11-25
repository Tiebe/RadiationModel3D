using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead204 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead204";
        public override double halfLife { get; } = 4.41796963644288e+24d;
        public override double atomicWeight { get; } = 203.97304d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    