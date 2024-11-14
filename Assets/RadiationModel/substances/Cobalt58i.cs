using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt58i : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt58i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 57.94193d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    