using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium258";
        public override double halfLife { get; } = 0.0027d;
        public override double atomicWeight { get; } = 258.11304d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    