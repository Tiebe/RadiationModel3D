
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium89";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 88.96453d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    