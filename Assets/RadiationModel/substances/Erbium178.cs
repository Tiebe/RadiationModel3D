using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium178";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 177.95678d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    