using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt47 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt47";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 47.0114d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    