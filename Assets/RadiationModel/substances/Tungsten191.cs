
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten191 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten191";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 190.96653d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    