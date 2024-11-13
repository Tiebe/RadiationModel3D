
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium184";
        public override double halfLife { get; } = 3.534378624e+20d;
        public override double atomicWeight { get; } = 183.95249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    