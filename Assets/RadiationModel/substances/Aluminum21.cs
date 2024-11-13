
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum21 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum21";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 21.02908d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    