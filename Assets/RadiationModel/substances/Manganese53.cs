using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese53 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese53";
        public override double halfLife { get; } = 116760722400000.0d;
        public override double atomicWeight { get; } = 52.94129d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Chromium53() } },

        };
    }
}
    
    