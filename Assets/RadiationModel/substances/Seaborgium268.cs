using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium268 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium268";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 268.12539d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    