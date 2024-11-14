using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium266";
        public override double halfLife { get; } = 0.39d;
        public override double atomicWeight { get; } = 266.12198d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    