using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium44";
        public override double halfLife { get; } = 1865015863.2d;
        public override double atomicWeight { get; } = 43.95969d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Scandium44() } },

        };
    }
}
    
    