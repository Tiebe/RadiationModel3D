using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium280 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium280";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 280.16158d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    