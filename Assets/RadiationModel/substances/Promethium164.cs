using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium164";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 163.95882d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    