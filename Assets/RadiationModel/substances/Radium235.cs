
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium235";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 235.05489d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    