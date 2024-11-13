
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium87";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 86.95091d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    