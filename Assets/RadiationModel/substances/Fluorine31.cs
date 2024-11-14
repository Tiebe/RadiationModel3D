using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine31 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine31";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 31.06102d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    