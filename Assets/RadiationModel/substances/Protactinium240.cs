
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium240";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 240.0612d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    