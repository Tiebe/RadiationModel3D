using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium243";
        public override double halfLife { get; } = 960.0d;
        public override double atomicWeight { get; } = 243.06708d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    