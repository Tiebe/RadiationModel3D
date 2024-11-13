
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury216 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury216";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 216.02246d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    