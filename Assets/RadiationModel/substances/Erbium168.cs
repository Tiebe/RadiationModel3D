
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium168";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 167.93238d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    