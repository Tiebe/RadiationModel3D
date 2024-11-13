
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium42i : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium42i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 41.96909d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    