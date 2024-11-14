using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium280 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium280";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 280.16138d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    