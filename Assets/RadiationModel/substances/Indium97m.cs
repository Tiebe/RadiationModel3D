using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium97m";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 96.94955d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    