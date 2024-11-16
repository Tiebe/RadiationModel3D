using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium33 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium33";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 33.00809d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    