using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium183";
        public override double halfLife { get; } = 6048000.0d;
        public override double atomicWeight { get; } = 182.95082d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Tungsten183() } },

        };
    }
}
    
    