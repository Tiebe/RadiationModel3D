using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium153";
        public override double halfLife { get; } = 20787840.0d;
        public override double atomicWeight { get; } = 152.92176d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Europium153() } },

        };
    }
}
    
    