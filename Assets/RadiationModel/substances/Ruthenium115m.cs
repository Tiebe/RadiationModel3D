using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium115m";
        public override double halfLife { get; } = 0.076d;
        public override double atomicWeight { get; } = 114.92903d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    