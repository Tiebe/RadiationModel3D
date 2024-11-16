using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium61";
        public override double halfLife { get; } = 0.007d;
        public override double atomicWeight { get; } = 61.00054d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    