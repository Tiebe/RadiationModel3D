
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium148";
        public override double halfLife { get; } = 0.25d;
        public override double atomicWeight { get; } = 147.96755d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    