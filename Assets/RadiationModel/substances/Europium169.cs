using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium169";
        public override double halfLife { get; } = 0.42d;
        public override double atomicWeight { get; } = 168.96172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    