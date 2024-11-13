
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium145";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 144.91258d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    