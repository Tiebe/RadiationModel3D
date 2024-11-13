
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium279p : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium279p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 279.16023d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    