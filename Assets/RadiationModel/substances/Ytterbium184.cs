using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium184";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 183.965d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    