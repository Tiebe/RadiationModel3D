
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium183";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 182.96243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    