using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead203 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead203";
        public override double halfLife { get; } = 186926.4d;
        public override double atomicWeight { get; } = 202.97339d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Thallium203() } },

        };
    }
}
    
    