
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton73i : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton73i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 72.94273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    