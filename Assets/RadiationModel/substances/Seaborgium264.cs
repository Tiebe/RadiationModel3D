using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium264";
        public override double halfLife { get; } = 0.078d;
        public override double atomicWeight { get; } = 264.11893d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    