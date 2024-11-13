
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium71 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium71";
        public override double halfLife { get; } = 987552.0d;
        public override double atomicWeight { get; } = 70.92495d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Gallium71() } },

        };
    }
}
    
    