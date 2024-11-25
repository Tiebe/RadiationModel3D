using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon124 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon124";
        public override double halfLife { get; } = 5.04910815593472e+21d;
        public override double atomicWeight { get; } = 123.90589d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    