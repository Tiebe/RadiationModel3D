using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium72 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium72";
        public override double halfLife { get; } = 725760.0d;
        public override double atomicWeight { get; } = 71.92714d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Arsenic72() } },

        };
    }
}
    
    