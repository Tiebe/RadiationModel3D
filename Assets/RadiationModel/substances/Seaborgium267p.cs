using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium267p : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium267p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 267.12435d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    