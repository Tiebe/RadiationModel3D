
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium68 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium68";
        public override double halfLife { get; } = 23418720.0d;
        public override double atomicWeight { get; } = 67.9281d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Gallium68() } },

        };
    }
}
    
    