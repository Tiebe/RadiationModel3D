
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium285 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium285";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 285.17577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    