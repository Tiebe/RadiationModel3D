
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead202 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead202";
        public override double halfLife { get; } = 1656739980000.0d;
        public override double atomicWeight { get; } = 201.97215d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Thallium202() } },

        };
    }
}
    
    