
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium268 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium268";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 268.14348d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    