
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium270";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 270.13036d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    