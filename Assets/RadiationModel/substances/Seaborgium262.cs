using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium262";
        public override double halfLife { get; } = 0.0103d;
        public override double atomicWeight { get; } = 262.11634d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    