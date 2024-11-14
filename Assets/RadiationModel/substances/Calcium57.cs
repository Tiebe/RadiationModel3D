using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium57";
        public override double halfLife { get; } = 0.008d;
        public override double atomicWeight { get; } = 56.99296d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    