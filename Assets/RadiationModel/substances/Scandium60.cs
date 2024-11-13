
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium60";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 59.99512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    