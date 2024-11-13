
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium255m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium255m";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 255.09342d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    