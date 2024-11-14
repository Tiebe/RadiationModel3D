using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium164";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 163.99197d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    