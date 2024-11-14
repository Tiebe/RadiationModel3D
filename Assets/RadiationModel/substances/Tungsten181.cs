using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten181 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten181";
        public override double halfLife { get; } = 10450598.4d;
        public override double atomicWeight { get; } = 180.94822d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Tantalum181() } },

        };
    }
}
    
    