using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium49";
        public override double halfLife { get; } = 28512000.0d;
        public override double atomicWeight { get; } = 48.94851d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Titanium49() } },

        };
    }
}
    
    