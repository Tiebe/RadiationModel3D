
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium191m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 190.96328d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    