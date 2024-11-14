using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium245";
        public override double halfLife { get; } = 360.0d;
        public override double atomicWeight { get; } = 245.07069d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    