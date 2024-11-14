using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton82 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton82";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 81.91348d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    