using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium273";
        public override double halfLife { get; } = 300.0d;
        public override double atomicWeight { get; } = 273.13947d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    