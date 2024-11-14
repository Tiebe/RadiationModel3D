using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus46 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus46";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 46.02452d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    