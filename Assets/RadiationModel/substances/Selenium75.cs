
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium75";
        public override double halfLife { get; } = 10348992.0d;
        public override double atomicWeight { get; } = 74.92252d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Arsenic75() } },

        };
    }
}
    
    