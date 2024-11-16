using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum82 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum82";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 81.95666d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    