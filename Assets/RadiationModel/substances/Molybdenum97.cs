using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum97 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum97";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 96.90602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    