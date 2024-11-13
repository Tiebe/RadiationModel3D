
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium184n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium184n";
        public override double halfLife { get; } = 960.0d;
        public override double atomicWeight { get; } = 183.95811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    