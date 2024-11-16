using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium267";
        public override double halfLife { get; } = 9000.0d;
        public override double atomicWeight { get; } = 267.12178d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    