
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium252";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 252.08487d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    