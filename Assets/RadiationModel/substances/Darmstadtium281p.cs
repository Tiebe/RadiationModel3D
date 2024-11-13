
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium281p : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium281p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 281.16462d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    