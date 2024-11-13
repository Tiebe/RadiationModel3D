
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium157";
        public override double halfLife { get; } = 7.7d;
        public override double atomicWeight { get; } = 156.95014d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    