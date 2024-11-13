
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium253m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium253m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 253.10074d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    