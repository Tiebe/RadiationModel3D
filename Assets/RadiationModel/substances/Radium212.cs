using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium212";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 211.99979d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    