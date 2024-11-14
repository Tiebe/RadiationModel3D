using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium60";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 60.01181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    