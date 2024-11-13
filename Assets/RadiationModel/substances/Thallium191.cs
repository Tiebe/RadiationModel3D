
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium191 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium191";
        public override double halfLife { get; } = 1200.0d;
        public override double atomicWeight { get; } = 190.97178d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    