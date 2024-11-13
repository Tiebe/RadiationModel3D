
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium59";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 58.96376d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    