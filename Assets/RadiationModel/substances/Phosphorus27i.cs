using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus27i : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus27i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 27.01289d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    