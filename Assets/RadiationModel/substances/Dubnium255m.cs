using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium255m : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium255m";
        public override double halfLife { get; } = 0.0028d;
        public override double atomicWeight { get; } = 255.10703d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    