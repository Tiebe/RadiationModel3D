
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium153";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 152.94937d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    