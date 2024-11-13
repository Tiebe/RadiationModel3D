
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium145";
        public override double halfLife { get; } = 29376000.0d;
        public override double atomicWeight { get; } = 144.91342d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Promethium145() } },

        };
    }
}
    
    