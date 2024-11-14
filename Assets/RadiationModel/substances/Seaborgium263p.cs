using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium263p : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium263p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 263.1184d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    