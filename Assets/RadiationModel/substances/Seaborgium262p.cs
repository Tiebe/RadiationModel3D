using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium262p : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium262p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 262.11726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    