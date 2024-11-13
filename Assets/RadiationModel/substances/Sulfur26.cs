
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur26 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur26";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 26.02972d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    