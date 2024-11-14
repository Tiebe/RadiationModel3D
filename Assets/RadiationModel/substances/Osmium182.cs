using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium182";
        public override double halfLife { get; } = 78624.0d;
        public override double atomicWeight { get; } = 181.95211d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Rhenium182() } },

        };
    }
}
    
    