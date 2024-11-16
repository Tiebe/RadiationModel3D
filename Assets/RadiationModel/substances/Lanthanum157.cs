using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum157 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum157";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 156.96879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    