
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium67";
        public override double halfLife { get; } = 281810.88d;
        public override double atomicWeight { get; } = 66.9282d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Zinc67() } },

        };
    }
}
    
    