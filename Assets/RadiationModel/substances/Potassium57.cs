using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium57";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 57.01517d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    