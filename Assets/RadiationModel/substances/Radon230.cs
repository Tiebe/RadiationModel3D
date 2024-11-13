
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon230 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon230";
        public override double halfLife { get; } = 24.0d;
        public override double atomicWeight { get; } = 230.04527d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    