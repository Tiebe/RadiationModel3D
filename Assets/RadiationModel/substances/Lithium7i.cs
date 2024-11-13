
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium7i : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium7i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 7.02807d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    