using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium167m";
        public override double halfLife { get; } = 5.9d;
        public override double atomicWeight { get; } = 166.96275d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    