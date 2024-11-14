using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium244m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium244m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 244.08137d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    