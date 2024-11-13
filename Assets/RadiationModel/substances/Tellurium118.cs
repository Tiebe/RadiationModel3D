
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium118";
        public override double halfLife { get; } = 518400.0d;
        public override double atomicWeight { get; } = 117.90586d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Antimony118() } },

        };
    }
}
    
    