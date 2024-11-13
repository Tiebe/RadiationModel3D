
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium272";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 272.1433d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    