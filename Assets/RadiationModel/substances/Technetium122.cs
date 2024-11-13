
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium122";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 121.97176d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    