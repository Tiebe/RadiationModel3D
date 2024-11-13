
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine147 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine147";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 146.96651d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    