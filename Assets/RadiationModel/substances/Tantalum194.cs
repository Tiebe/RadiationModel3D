
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum194 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum194";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 193.98161d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    