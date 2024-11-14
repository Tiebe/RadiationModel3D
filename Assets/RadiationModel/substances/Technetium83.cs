using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium83";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 82.96638d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    