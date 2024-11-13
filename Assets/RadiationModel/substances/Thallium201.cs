
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium201";
        public override double halfLife { get; } = 262837.44d;
        public override double atomicWeight { get; } = 200.97082d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Mercury201() } },

        };
    }
}
    
    