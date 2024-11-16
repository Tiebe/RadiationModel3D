using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium272";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 272.13582d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    