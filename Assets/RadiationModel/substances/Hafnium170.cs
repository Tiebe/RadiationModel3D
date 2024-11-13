
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium170";
        public override double halfLife { get; } = 57636.0d;
        public override double atomicWeight { get; } = 169.93961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Lutetium170() } },

        };
    }
}
    
    