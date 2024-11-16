using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium167";
        public override double halfLife { get; } = 799200.0d;
        public override double atomicWeight { get; } = 166.93286d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Erbium167() } },

        };
    }
}
    
    