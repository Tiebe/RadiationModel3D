using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium164";
        public override double halfLife { get; } = 0.719d;
        public override double atomicWeight { get; } = 163.97051d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    