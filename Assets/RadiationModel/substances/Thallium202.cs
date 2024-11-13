
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium202";
        public override double halfLife { get; } = 1063584.0d;
        public override double atomicWeight { get; } = 201.97211d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Mercury202() } },

        };
    }
}
    
    