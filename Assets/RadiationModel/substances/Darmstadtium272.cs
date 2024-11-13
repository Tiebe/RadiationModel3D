
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium272";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 272.14609d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    