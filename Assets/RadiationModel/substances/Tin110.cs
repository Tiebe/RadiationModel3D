using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin110 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin110";
        public override double halfLife { get; } = 14954.4d;
        public override double atomicWeight { get; } = 109.90784d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Indium110() } },

        };
    }
}
    
    