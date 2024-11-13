
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine98 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine98";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 97.96989d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    