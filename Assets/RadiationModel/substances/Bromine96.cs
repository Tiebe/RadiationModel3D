
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine96 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine96";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 95.95898d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    