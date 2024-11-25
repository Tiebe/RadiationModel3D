using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium96";
        public override double halfLife { get; } = 6.3113851949184e+26d;
        public override double atomicWeight { get; } = 95.90828d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    