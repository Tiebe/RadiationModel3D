using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium99";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 98.90593d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    