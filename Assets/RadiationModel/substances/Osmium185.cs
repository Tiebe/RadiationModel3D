
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium185 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium185";
        public override double halfLife { get; } = 8030880.0d;
        public override double atomicWeight { get; } = 184.95405d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Rhenium185() } },

        };
    }
}
    
    