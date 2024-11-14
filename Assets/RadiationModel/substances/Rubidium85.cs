using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium85";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 84.91179d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    