
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium169m";
        public override double halfLife { get; } = 15.1d;
        public override double atomicWeight { get; } = 168.95895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    