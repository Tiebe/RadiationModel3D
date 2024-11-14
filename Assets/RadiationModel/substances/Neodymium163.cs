using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium163";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 162.96341d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    