using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium125";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 124.96954d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    