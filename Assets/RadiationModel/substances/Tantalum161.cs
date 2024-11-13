
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum161 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum161";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 160.95837d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    