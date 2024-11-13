
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon44 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon44";
        public override double halfLife { get; } = 0.004d;
        public override double atomicWeight { get; } = 44.03147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    