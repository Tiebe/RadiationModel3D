using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium86";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 85.95731d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    