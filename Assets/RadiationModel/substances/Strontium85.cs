
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium85";
        public override double halfLife { get; } = 5602694.4d;
        public override double atomicWeight { get; } = 84.91293d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Rubidium85() } },

        };
    }
}
    
    